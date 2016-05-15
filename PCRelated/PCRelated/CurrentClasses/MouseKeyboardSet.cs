using System;
using System.ComponentModel;

namespace PCRelated.CurrentClasses
{
    [Serializable]
    class MouseKeyboardSet:Keyboard
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Mouse MouseKit { get; set; }

        public MouseKeyboardSet(string type) : base(type)
        {
            MouseKit = new Mouse("Мышь из комплекта");
        }
    }
}
