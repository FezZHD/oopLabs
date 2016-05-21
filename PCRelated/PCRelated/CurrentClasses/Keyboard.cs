using System;

namespace PCRelated.CurrentClasses
{
    [Serializable]
    public class Keyboard:RelatedCommon
    {

        public uint KeysCount { get; set; }
        public uint PortFrequency { get; set; }
        public string Light { get; set; }

        public Keyboard() 
        {
        }

    }
}
