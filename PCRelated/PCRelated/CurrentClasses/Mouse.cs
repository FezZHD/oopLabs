using System;

namespace PCRelated.CurrentClasses
{
    [Serializable]
    public class Mouse:RelatedCommon
    {
        public uint KeysCount { get; set; }
        public uint PortFrequency { get; set; }
        public string Light { get; set; }
        public uint Dpi { get; set; }

        public Mouse()
        {
        }
    }
}
