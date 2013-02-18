using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ONote.Common.Forms
{
    public partial class SingletonForms<T> : Form where T : Form, new()
    {
        
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            instance = null;//关闭时确保注销实例 
        }
        private static T instance = null;
        private static readonly object lockHelper = new object();
        /// <summary>  
        /// 获取窗体的唯一实例  
        /// </summary>  
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new T();
                            instance.FormClosed += new FormClosedEventHandler(DestroyForm);
                        }
                    }
                }
                return instance;
            }
        }
       

        private static void DestroyForm(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
