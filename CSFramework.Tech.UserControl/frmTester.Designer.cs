namespace CSFramework.Tech.UserControl
{
    partial class frmTester
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ucButton1 = new MyControls.ucButton();
            this.ucButton2 = new MyControls.ucButton();
            this.ucButton3 = new MyControls.ucButton();
            this.ucButton4 = new MyControls.ucButton();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.ucButton4);
            this.groupBox4.Controls.Add(this.ucButton3);
            this.groupBox4.Controls.Add(this.ucButton2);
            this.groupBox4.Controls.Add(this.ucButton1);
            this.groupBox4.Location = new System.Drawing.Point(12, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 249);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "用户控件";
            // 
            // ucButton1
            // 
            this.ucButton1.Location = new System.Drawing.Point(21, 30);
            this.ucButton1.MinimumSize = new System.Drawing.Size(0, 14);
            this.ucButton1.MyCatpionText = "ucButton";
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(154, 19);
            this.ucButton1.TabIndex = 0;
            // 
            // ucButton2
            // 
            this.ucButton2.Location = new System.Drawing.Point(21, 72);
            this.ucButton2.MinimumSize = new System.Drawing.Size(0, 14);
            this.ucButton2.MyCatpionText = "ucButton";
            this.ucButton2.Name = "ucButton2";
            this.ucButton2.Size = new System.Drawing.Size(154, 19);
            this.ucButton2.TabIndex = 1;
            // 
            // ucButton3
            // 
            this.ucButton3.Location = new System.Drawing.Point(20, 115);
            this.ucButton3.MinimumSize = new System.Drawing.Size(0, 14);
            this.ucButton3.MyCatpionText = "ucButton";
            this.ucButton3.Name = "ucButton3";
            this.ucButton3.Size = new System.Drawing.Size(154, 19);
            this.ucButton3.TabIndex = 2;
            // 
            // ucButton4
            // 
            this.ucButton4.Location = new System.Drawing.Point(21, 154);
            this.ucButton4.MinimumSize = new System.Drawing.Size(0, 14);
            this.ucButton4.MyCatpionText = "ucButton";
            this.ucButton4.Name = "ucButton4";
            this.ucButton4.Size = new System.Drawing.Size(154, 19);
            this.ucButton4.TabIndex = 3;
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmTester";
            this.Text = "用户控件";
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private MyControls.ucButton ucButton1;
        private MyControls.ucButton ucButton4;
        private MyControls.ucButton ucButton3;
        private MyControls.ucButton ucButton2;
    }
}

