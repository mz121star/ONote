using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ONote.Common.Files
{
   public class BackUp
    {
       /// <summary>
       /// 备份文件
       /// </summary>
       /// <param name="source">源文件地址</param>
       /// <param name="target">目标地址</param>
       /// <returns></returns>
       public static bool BackUpFile(string source,string target)
       {
           bool s = false;
           try
           {
               File.Copy(source, target);
               s = true;
           }
           catch (Exception ex)
           {

               throw ex;
           }
           return s;

       }
       /// <summary>
       /// 创建文件夹
       /// </summary>
       /// <param name="path"></param>
       public static void  CreateDirectory(string path)
       {
          if(! Directory.Exists(path))
          {
              Directory.CreateDirectory(path);
          }
       }
    }
}
