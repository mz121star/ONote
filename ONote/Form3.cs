using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ONote
{
    public partial class Form3 : Form
    {
        private Form3()
        {
            InitializeComponent();
        }
       
        private static volatile Form3 instance = null;
        public static Form3 Instance
        {
            get
            {
                if (null == instance)
                {
                    lock (typeof(Form3))
                    {
                        if (null == instance)
                        {
                            instance = new Form3();
                        }
                    }
                }
                return instance;
            }
        } 
    }
}
