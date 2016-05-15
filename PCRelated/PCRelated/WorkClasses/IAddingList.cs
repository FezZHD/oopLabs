using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    interface IAddingList
    {
        RelatedCommon AddList();
    }


    class AddKeyboard:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Keyboard("Клавиатура");
        }
    }

    class AddMouse:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Mouse("Мышь");
        }
    }

    class AddMonitor:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Monitor("Монитор");
        }
    }

    class AddPrinter : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Printers("Принтер");
        }
    }

    class AddMfp : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Mfp("МФУ");
        }
    }

    class AddKit : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new MouseKeyboardSet("Комплект: Клавиатура + мышь");
        }
    }
}
