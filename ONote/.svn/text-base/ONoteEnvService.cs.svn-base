using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.IService;
 
using Spring.Context;
using Spring.Context.Support;

namespace ONote
{
  public  class ONoteEnvService
    {
      readonly IApplicationContext ctx = ContextRegistry.GetContext();


      public IUserService UserService
      {
          get { return (IUserService)ctx.GetObject("UserServiceTrans"); }
      }
    }
}
