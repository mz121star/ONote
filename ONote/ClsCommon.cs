using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ONote.IService;
using Spring.Context;
using Spring.Context.Support;
using ONote.Model;
namespace ONote
{
   public class ClsCommon
    {
       /// <summary>
       /// 当前登录系统的用户
       /// </summary>
       public static User CurrentUser { get; set; }
     /// <summary>
     /// 获取程序根目录
     /// </summary>
       public static string GetAppDomain
       {
           get { return AppDomain.CurrentDomain.BaseDirectory; }
       }
       /// <summary>
       /// 获取备份目标文件夹
       /// </summary>
       public static string GetBackupDomain
       {
           get { return ConfigurationManager.AppSettings["onotebackup"]; }
       }
       private static IApplicationContext ctx = ContextRegistry.GetContext();
       /// <summary>
       /// 获得记事本目录服务
       /// </summary>
       public static ICategoryService GetCategoryService
        {
            get
            {
                return (ICategoryService)ctx.GetObject("CategoryServiceTrans");
            }
        }
       /// <summary>
       /// 用户服务
       /// </summary>
        public static IUserService GetUserService
        {
            get
            {
                return (IUserService)ctx.GetObject("UserServiceTrans");
            }
        }
       /// <summary>
       /// 记事本服务
       /// </summary>
        public static INoteService GetNoteService
        {
            get
            {
                return (INoteService)ctx.GetObject("NoteServiceTrans");
            }
        }
       /// <summary>
       /// 通讯录服务
       /// </summary>
        public static IAddressBookService GetAddressBookService
        {
            get
            {
                return (IAddressBookService)ctx.GetObject("AddressBookServiceTrans");
            }
        }


    }
}
