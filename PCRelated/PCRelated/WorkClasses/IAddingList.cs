using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    interface IAddingList//maybe this is composite pattern
    {
        RelatedCommon AddList();
    }


    class AddKeyboard:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Keyboard("Keyboard");
        }
    }

    class AddMouse:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Mouse("Mouse");
        }
    }

    class AddMonitor:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Monitor("Monitor");
        }
    }

    class AddPrinter : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Printers("Printer");
        }
    }

    class AddMfp : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Mfp("Mfp");
        }
    }

    class AddKit : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new MouseKeyboardSet("Keyboard + mouse set");
        }
    }
}
