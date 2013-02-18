using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateTable()
        {
           // 获取当前NHibernate中的配置信息   
       NHibernate.Cfg.Configuration _cfg = new NHibernate.Cfg.Configuration().Configure();  
      //用NHibernate.Tool.hbm2ddl.SchemaExport生成表结构到D:\sql.sql文件当中   
       NHibernate.Tool.hbm2ddl.SchemaExport export = new NHibernate.Tool.hbm2ddl.SchemaExport(_cfg);  
       export.SetOutputFile("D:\\sql.sql"); //设置输出目录   
       export.Drop(true, true);//设置生成表结构存在性判断,并删除   
       export.Create(true, true);//设置是否生成脚本,是否导出来   

        }
    }
}
