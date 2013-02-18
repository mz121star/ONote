using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONote.Model
{
    [Serializable]
  public  class Category
    {
      public virtual int CategoryID { get; set; }
      public virtual string CategoryName { get; set; }
      public override string ToString()
      {
          return CategoryName.ToString();
      }
    }
}
