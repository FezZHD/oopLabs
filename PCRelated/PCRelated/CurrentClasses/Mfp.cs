using System;

namespace PCRelated.CurrentClasses
{
    [Serializable]
    public class Mfp:Printers
    {
        public string CopyResolution { get; set; }
        public uint CopySpeed { get; set; }
        public uint MaxCopySpeed { get; set; }

        public Mfp()
        {

        }
       
    }
}
