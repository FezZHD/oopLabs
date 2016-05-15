using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace PCRelated.WorkClasses
{
    class TextSerializer : ISerializable
    {
        private delegate string DelegateParseFunction(Object obj, string tabs);
        private delegate Object DelegateHandleFunction(string typeString, ref string fullText);
        private char[] SEPARATORS = { '\n', '\r', ' ', '\t', ',', ':' };

        public void Serialize(Object obj, string fileName , FileStream outputStream)
        {
            string text = GetText(obj);
            StreamWriter writer = new StreamWriter(outputStream);
            writer.WriteLine(text);
            writer.Flush();
        }

        public Object Deserialize(FileStream inputStream)
        {
            TextReader reader = new StreamReader(inputStream);
            string fullTextFromFile = reader.ReadToEnd();
            return GetObjectFromText(fullTextFromFile);
        }

        public string GetText(Object obj)
        {
            string res = obj.GetType().ToString() + " : ";
            return res + GetFieldsInfo(obj, "\t");
        }

        private string GetFieldsInfo(Object obj, string tabs)
        {
            if (obj == null) return "\"\"";
            string res = "";
            Type type = obj.GetType();
            DelegateParseFunction parseMethod = GetParseMethod(type);
            if (parseMethod != null)
                res = parseMethod(obj, tabs);
            return res;
        }

        private DelegateParseFunction GetParseMethod(Type type)
        {
            if (type.IsPrimitive || type.IsValueType || type == typeof(string)) return ParsePrimitive;
            if (type.IsArray) return ParseArray;
            if (type.IsClass) return ParseClass;
            return null;
        }

        private string ParsePrimitive(Object obj, string tabs)
        {
            return "\"" + obj.ToString() + "\"";
        }

        private string ParseArray(Object obj, string tabs)
        {
            Array arr = (Array)obj;

            StringBuilder stringObject = new StringBuilder();
            stringObject.Append("[\r\n");
            foreach (var item in arr)
            {
                stringObject.Append(tabs);
                stringObject.Append("\"");
                stringObject.Append(item.GetType().ToString());
                stringObject.Append("\" : ");
                stringObject.Append(GetFieldsInfo(item, tabs + "\t"));
                stringObject.Append(", \r\n");
            }

            if (arr.Length == 0)
            {
                stringObject.Remove(stringObject.Length - 2, 2);
            }
            else
            {
                stringObject.Remove(stringObject.Length - 4, 4);
                stringObject.Append("\r\n");
                stringObject.Append(tabs.Remove(0, 1));
            }
            stringObject.Append("]");

            return stringObject.ToString();
        }

        private string ParseClass(Object obj, string tabs)
        {
            Type type = obj.GetType();

            if (IsImplementsIEnumerable(type) && IsArray(type))
            {
                obj = CallToArray(obj);
                return ParseArray(obj, tabs);
            }

            StringBuilder stringObject = new StringBuilder();
            stringObject.Append(" { \r\n");
            stringObject.Append(GetFields(obj, tabs));
            stringObject.Append(GetProperties(obj, tabs));
            stringObject.Remove(stringObject.Length - 1, 1);
            stringObject.Append("\r\n");
            stringObject.Append(tabs.Remove(0, 1));
            stringObject.Append("}");

            return stringObject.ToString();
        }

        private bool IsArray(Type type)
        {
            if (type.GetMethod("ToArray") != null)
                return true;
            return false;
        }

        private bool IsImplementsIEnumerable(Type type)
        {
            if (type.GetInterface("IEnumerable", true) != null)
                return true;
            else
                return false;
        }

        private Object CallToArray(Object obj)
        {
            MethodInfo objMethod;
            if ((objMethod = obj.GetType().GetMethod("ToArray")) != null)
                return objMethod.Invoke(obj, null);
            return false;
        }

        private string GetFields(Object obj, string tabs)
        {
            StringBuilder stringFields = new StringBuilder();
            FieldInfo[] fields = obj.GetType().GetFields();
            foreach (FieldInfo fieldItem in fields)
            {
                if (!fieldItem.IsInitOnly)
                {
                    stringFields.Append(tabs);
                    stringFields.Append("\"");
                    stringFields.Append(fieldItem.Name.ToString());
                    stringFields.Append("\" : ");
                    stringFields.Append(GetFieldsInfo(fieldItem.GetValue(obj), tabs + "\t"));
                    stringFields.Append(", \r\n");
                }
            }
            if (stringFields.Length > 0)
                stringFields.Remove(stringFields.Length - 4, 4);

            return stringFields.ToString();
        }

        private string GetProperties(Object obj, string tabs)
        {
            StringBuilder stringPropertys = new StringBuilder();
            PropertyInfo[] fields = obj.GetType().GetProperties();
            foreach (PropertyInfo field in fields)
            {
                if (field.CanWrite)
                {
                    stringPropertys.Append(tabs);
                    stringPropertys.Append("\"");
                    stringPropertys.Append(field.Name.ToString());
                    stringPropertys.Append("\" : ");
                    stringPropertys.Append(GetFieldsInfo(field.GetValue(obj), tabs + "\t"));
                }
                stringPropertys.Append(", \r\n");
            }
            if (stringPropertys.Length > 0)
                stringPropertys.Remove(stringPropertys.Length - 4, 3);

            return stringPropertys.ToString();
        }

        private Object GetObjectFromText(string objString)
        {
            objString.Trim(SEPARATORS);
            return ParseText(ref objString);
        }

        private Object ParseText(ref string fullText)
        {
            string pattern = @":";
            Match regInfo = Regex.Match(fullText, pattern);
            string typeString = "";
            DelegateHandleFunction handleMethod = null;
            if (regInfo.Success)
            {
                typeString = CutText(ref fullText, 0, regInfo.Index);
                handleMethod = GetTypeHandle(typeString);
            }
            return handleMethod == null ? null : handleMethod(typeString, ref fullText);
        }

        private DelegateHandleFunction GetTypeHandle(string typeString)
        {
            Type typeObj = Type.GetType(typeString);
            if (typeObj.IsPrimitive || typeObj.IsValueType || typeObj == typeof(string)) return HandlePrimitive;
            if (typeObj.IsArray) return HandleArray;
            if (typeObj.IsClass) return HandleClass;
            throw new Exception("Нет данного типа.");
        }

        private Object ConvertToType(string value, Type type)
        {
            if (type.IsEnum) return Enum.Parse(type, value);
            return Convert.ChangeType(value, type);
        }

        private Object HandlePrimitive(string typeString, ref string fullText)
        {
            Type typeObj = Type.GetType(typeString);
            string pattern = @",|(\r\n)|$";
            Match regInfo = Regex.Match(fullText, pattern);
            if (regInfo.Success)
            {
                string value = CutText(ref fullText, 0, regInfo.Index);
                return ConvertToType(value, typeObj);
            }
            return null;
        }

        private Object HandleArray(string typeString, ref string fullText)
        {
            if (!IsNextChar(ref fullText, "["))
                throw new Exception("Некорректное значение. HandleArray()");
            typeString = typeString.Remove(typeString.Length - 2);
            Type typeObj = Type.GetType(typeString);
            Type list = typeof(List<>);
            Type listOfType = list.MakeGenericType(typeObj);
            Object listObject = Activator.CreateInstance(listOfType);
            HandleIEnumerable(listObject, ref fullText);

            MethodInfo toArrayMethod;
            if ((toArrayMethod = listObject.GetType().GetMethod("ToArray")) != null)
            {
                return toArrayMethod.Invoke(listObject, null);
            }

            return null;
        }

        private Object HandleClass(string typeString, ref string fullText)
        {
            Type typeObj = Type.GetType(typeString);
            Object obj = Activator.CreateInstance(typeObj);
            if (IsNextChar(ref fullText, "[")) return HandleIEnumerable(obj, ref fullText);
            else if (IsNextChar(ref fullText, "{")) return HandleSimpleClass(obj, ref fullText);
            return null;
        }

        private Object HandleIEnumerable(object obj, ref string fullText)
        {
            while (!IsNextChar(ref fullText, "]"))
            {
                string pattern = @":";
                Match regInfo = Regex.Match(fullText, pattern);
                string typeString = "";
                DelegateHandleFunction handleMethod = null;
                if (regInfo.Success)
                {
                    typeString = CutText(ref fullText, 0, regInfo.Index);
                    handleMethod = GetTypeHandle(typeString);
                    MethodInfo objMethod;
                    Object[] newObj = { handleMethod(typeString, ref fullText) };
                    if ((objMethod = obj.GetType().GetMethod("Add")) != null)
                        objMethod.Invoke(obj, newObj);
                }
            }
            return obj;
        }

        private PropertyInfo HasPropertyObject(string name, Object obj)
        {
            PropertyInfo[] fields = obj.GetType().GetProperties();
            foreach (PropertyInfo property in fields)
            {
                if (property.CanWrite && property.Name == name)
                    return property;
            }
            return null;
        }

        private FieldInfo HasFieldObject(string name, Object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields();
            foreach (FieldInfo field in fields)
            {
                if (field.IsPublic && field.Name == name)
                    return field;
            }
            return null;
        }

        private string CutText(ref string src, int startIndex, int length)
        {
            string returnValue = src.Substring(startIndex, length - 1).Replace("\"", "");
            src = src.Remove(0, length).Trim(SEPARATORS);
            return returnValue;
        }

        private Object HandleSimpleClass(object obj, ref string fullText)
        {
            while (!IsNextChar(ref fullText, "}"))
            {
                FieldInfo field = null;
                PropertyInfo property = null;

                string pattern = @":";
                Match regInfo = Regex.Match(fullText, pattern);
                string fieldName = "";
                DelegateHandleFunction handleMethod = null;
                if (regInfo.Success)
                {
                    fieldName = CutText(ref fullText, 0, regInfo.Index);

                    field = HasFieldObject(fieldName, obj);
                    property = HasPropertyObject(fieldName, obj);

                    string typeString = "";
                    if (field != null)
                        typeString = field.FieldType.ToString();
                    else if (property != null)
                        typeString = property.PropertyType.ToString();
                    else throw new Exception("Неизвестное поле. HandleSimpleClass().");

                    handleMethod = GetTypeHandle(typeString);

                    if (field != null)
                        field.SetValue(obj, handleMethod(typeString, ref fullText));
                    else if (property != null)
                        property.SetValue(obj, handleMethod(typeString, ref fullText));
                }
            }
            return obj;
        }

        private bool IsNextChar(ref string src, string dest)
        {
            if (src.IndexOf(dest) == 0)
            {
                src = src.Remove(0, 1);
                src = src.Trim(SEPARATORS);
                return true;
            }
            return false;
        }
    }
}
