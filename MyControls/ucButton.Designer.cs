
namespace MyControls
{
    partial class ucButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUnderLine = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnderLine
            // 
            this.lblUnderLine.BackColor = System.Drawing.Color.DarkGray;
            this.lblUnderLine.Location = new System.Drawing.Point(16, 13);
            this.lblUnderLine.Name = "lblUnderLine";
            this.lblUnderLine.Size = new System.Drawing.Size(227, 1);
            this.lblUnderLine.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyControls.Properties.Resources.FosedTag;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCaption.ImageIndex = 1;
            this.lblCaption.Location = new System.Drawing.Point(14, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(95, 12);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "ucButtonCaption";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaption.Click += new System.EventHandler(this.lblCaption_Click);
            this.lblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseDown);
            this.lblCaption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseUp);
            this.lblCaption.MouseEnter += new System.EventHandler(this.lblCaption_MouseEnter);
            // 
            // ucButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUnderLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCaption);
            this.MinimumSize = new System.Drawing.Size(0, 14);
            this.Name = "ucButton";            
            this.Size = new System.Drawing.Size(270, 17);
            this.SizeChanged += new System.EventHandler(this.ucButton_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.ucButton_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnderLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCaption;
    }
}
