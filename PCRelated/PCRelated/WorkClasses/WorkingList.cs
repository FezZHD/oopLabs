using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    public class WorkingList
    {
        private Facade _listFacade;

        public WorkingList(Facade facade)
        {
            _listFacade = facade;
        }

        public void FacadeAdd(RelatedCommon related)
        {
            _listFacade.AddToList(related);
        }

        public void FacadeDelete(int relatedIndex)
        {
            _listFacade.DeleteFromList(relatedIndex);
        }
    }
}
