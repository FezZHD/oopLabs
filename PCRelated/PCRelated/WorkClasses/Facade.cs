using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    public class Facade
    {

        private AddList _addList = new AddList();
        private DeleteList _deleteList = new DeleteList();
 

        public void AddToList(RelatedCommon related)
        {
            _addList.Add(MainForm.RelatedList, related);
        }

        public void DeleteFromList(int relatedIndex)
        {
            _deleteList.Delete(MainForm.RelatedList, relatedIndex);
        }
    }
}
