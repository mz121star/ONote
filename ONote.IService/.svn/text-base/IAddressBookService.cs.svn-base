using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Dto;
using ONote.Model;

namespace ONote.IService
{
   public interface IAddressBookService
   {
       IList<AddressBook> GetAllAddressBook();
       IList<AddressBook> GetAllAddressBookByCondition(QueryAddressBookDto queryAddressBookDto);
       void SaveOrUpdata(AddressBook addressBook);
       void Delete(IList<AddressBook> addressBooks);
   }
}
