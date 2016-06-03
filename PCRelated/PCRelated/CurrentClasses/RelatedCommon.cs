using System;
using System.Xml.Serialization;

namespace PCRelated.CurrentClasses
{
    [Serializable]
    [XmlInclude(typeof(Keyboard)),XmlInclude(typeof(Mouse)),
    XmlInclude(typeof(Monitor)),XmlInclude(typeof(Printers)),
    XmlInclude(typeof(Mfp)),XmlInclude(typeof(MouseKeyboardSet))]
    public abstract class RelatedCommon
    {
        public string Name { get; set; }
        public string Interfaces { get; set; }

        public RelatedCommon()
        {
            
        }

    }
}
