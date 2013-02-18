using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
 


namespace ONote.Common.Configs
{
    public class AppConfigManager
    {
        ///<summary>  ///在＊.exe.config文件中appSettings配置节增加一对键、值对  
        ///</summary>  
        ///<param name="newKey"></param>  
        ///<param name="newValue"></param> 
        public static void UpdateAppConfig(string newKey, string newValue)
        {

            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }

            // Open App.Config of executable      
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");


        }
    }
}
