using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Common.Dao;
using ONote.Dto;
using ONote.IDao;
using ONote.Model;

namespace ONote.Dao
{
    class AddressBookDao : RepositoryBase<AddressBook>, IAddressBookDao
    {

        #region IAddressBookDao 成员

        public IList<AddressBook> GetAllAddressBook()
        {
          return  Session.QueryOver<AddressBook>().OrderBy(x => x.Name).Asc.List();
        }

        public IList<AddressBook> GetAllAddressBookByCondition(Dto.QueryAddressBookDto queryAddressBookDto)
        {
            
            var result = Session.QueryOver<AddressBook>();
            if(queryAddressBookDto!=null)
            {
                if (!string.IsNullOrEmpty(queryAddressBookDto.Address))
                    result.Where(x => x.Address == queryAddressBookDto.Address);
                if (!string.IsNullOrEmpty(queryAddressBookDto.Company))
                    result.Where(x => x.Company == queryAddressBookDto.Company);
                if (!string.IsNullOrEmpty(queryAddressBookDto.Department))
                    result.Where(x => x.Department == queryAddressBookDto.Department);
                if (!string.IsNullOrEmpty(queryAddressBookDto.Email))
                    result.Where(x => x.Email == queryAddressBookDto.Email);
                if (!string.IsNullOrEmpty(queryAddressBookDto.Mobile))
                    result.Where(x => x.Mobile == queryAddressBookDto.Mobile);
                if (!string.IsNullOrEmpty(queryAddressBookDto.Name))
                    result.Where(x => x.Name == queryAddressBookDto.Name);
                if (!string.IsNullOrEmpty(queryAddressBookDto.Phone))
                    result.Where(x => x.Phone == queryAddressBookDto.Phone);
                if (!string.IsNullOrEmpty(queryAddressBookDto.QQ))
                    result.Where(x => x.QQ == queryAddressBookDto.QQ);

            }
            return result.OrderBy(x => x.Name).Asc.List();
        }

        #endregion
    }
}
