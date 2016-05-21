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
            return new Keyboard();
        }
    }

    class AddMouse:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Mouse();
        }
    }

    class AddMonitor:IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Monitor();
        }
    }

    class AddPrinter : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Printers();
        }
    }

    class AddMfp : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new Mfp();
        }
    }

    class AddKit : IAddingList
    {
        public RelatedCommon AddList()
        {
            return new MouseKeyboardSet();
        }
    }
}
