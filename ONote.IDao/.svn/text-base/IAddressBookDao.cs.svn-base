using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Common.Dao;
using ONote.Dto;
using ONote.Model;

namespace ONote.IDao
{
    public interface IAddressBookDao : IRepositoryBase<AddressBook>
    {
        IList<AddressBook> GetAllAddressBook();
        IList<AddressBook> GetAllAddressBookByCondition(QueryAddressBookDto queryAddressBookDto);
    }
}
