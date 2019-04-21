using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MyControls
{
    public class MyControl : UserControl
    {
        private Button button1;
    
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "个性按钮";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MyControl
            // 
            this.Controls.Add(this.button1);
            this.Name = "MyControl";
            this.Size = new System.Drawing.Size(108, 33);
            this.ResumeLayout(false);

        }
    }
}
