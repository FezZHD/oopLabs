﻿using System;

namespace PCRelated.CurrentClasses

{
    [Serializable]
    public class Monitor:RelatedCommon
    {

        public string Resolution { get; set; }
        public string MatrixType { get; set; }
        public uint Frequency { get; set; }

        public Monitor()
        {
        }

    }
}
