using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.IDao;
using ONote.IService;

namespace ONote.Service
{
    public class AddressBookService : ServiceBase<IAddressBookDao>, IAddressBookService
    {

        #region IAddressBookService 成员

        public IList<Model.AddressBook> GetAllAddressBook()
        {
          return  Dao.GetAllAddressBook();
        }

        public IList<Model.AddressBook> GetAllAddressBookByCondition(Dto.QueryAddressBookDto queryAddressBookDto)
        {
            return Dao.GetAllAddressBookByCondition(queryAddressBookDto);
        }

        public void SaveOrUpdata(Model.AddressBook addressBook)
        {
           Dao.SaveOrUpdate(addressBook);
        }

        public void Delete(IList<Model.AddressBook> addressBooks)
        {
           Dao.DeleteEntity(addressBooks);
        }

        #endregion
    }
}
