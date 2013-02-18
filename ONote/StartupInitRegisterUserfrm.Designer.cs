namespace ONote
{
    partial class StartupInitRegisterUserfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupInitRegisterUserfrm));
            this.lblinfo = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtuname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtconfirm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            // 
            // 
            // 
            this.lblinfo.BackgroundStyle.Class = "";
            this.lblinfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblinfo.Location = new System.Drawing.Point(0, 12);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(264, 23);
            this.lblinfo.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 51);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "用户名：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(22, 80);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(53, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "密码：";
            // 
            // txtuname
            // 
            // 
            // 
            // 
            this.txtuname.Border.Class = "TextBoxBorder";
            this.txtuname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtuname.Location = new System.Drawing.Point(81, 53);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(183, 21);
            this.txtuname.TabIndex = 3;
            // 
            // txtpwd
            // 
            // 
            // 
            // 
            this.txtpwd.Border.Class = "TextBoxBorder";
            this.txtpwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpwd.Location = new System.Drawing.Point(81, 80);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(183, 21);
            this.txtpwd.TabIndex = 4;
            // 
            // txtconfirm
            // 
            // 
            // 
            // 
            this.txtconfirm.Border.Class = "TextBoxBorder";
            this.txtconfirm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtconfirm.Location = new System.Drawing.Point(81, 107);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(183, 21);
            this.txtconfirm.TabIndex = 6;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(-3, 107);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(78, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "确认密码：";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(91, 148);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "注册";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // StartupInitRegisterUserfrm
            // 
            this.ClientSize = new System.Drawing.Size(261, 210);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupInitRegisterUserfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增用户";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblinfo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtuname;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpwd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtconfirm;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}