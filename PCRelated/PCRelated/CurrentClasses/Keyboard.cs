using System;

namespace PCRelated.CurrentClasses
{
    [Serializable]
    class Keyboard:RelatedCommon
    {

        public uint KeysCount { get; set; }
        public uint PortFrequency { get; set; }
        public string Light { get; set; }

        public Keyboard(string type) : base(type)
        {
        }
    }
}
