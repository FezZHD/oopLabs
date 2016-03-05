using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicEditor
{
    abstract class Shape
    {
       protected uint _startPoint;
       public abstract string Draw();

        void dd() { }

        protected Shape(uint startPoint)
        {
            _startPoint = startPoint;
        }  
    }
}
