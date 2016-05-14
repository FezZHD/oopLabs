using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated
{
    class MouseKeyboardSet:Keyboard
    {
        private Mouse MouseKit { get; set; }

        public MouseKeyboardSet(string type) : base(type)
        {
            MouseKit = new Mouse("Мышь из комплекта");
        }
    }
}
