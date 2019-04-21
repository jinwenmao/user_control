using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyControls;

namespace MyControls
{
    public partial class ucButton : UserControl
    {
        private bool _IsFocused = false; //标记按钮是否为焦点状态

        public ucButton()
        {
            InitializeComponent();

            this.DoHideFocusedTag();
            this.MyCatpionText = this.Name;
        }

        private EventHandler _OnButtonClick = null;

        private string _MyCatpionText = "ucButton1";

        /// <summary>
        /// 按钮标题
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DefaultValue("ucButton1")]
        public string MyCatpionText
        {
            get { return _MyCatpionText; }
            set { _MyCatpionText = value; lblCaption.Text = _MyCatpionText; }
        }

        /// <summary>
        /// 用户自定义Click事件
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public event EventHandler OnButtonClick
        {
            add { _OnButtonClick += new EventHandler(value); }
            remove { _OnButtonClick -= new EventHandler(value); }
        }

        private void lblCaption_Click(object sender, EventArgs e)
        {
            //转移Click事件, 触发用户自定义事件
            if (_OnButtonClick != null) _OnButtonClick(this, e);
        }

        private void lblCaption_MouseDown(object sender, MouseEventArgs e)
        {
            if (_IsFocused)
            {
                lblCaption.Font = new Font(lblCaption.Font.FontFamily, lblCaption.Font.Size, FontStyle.Bold);
            }
        }

        private void lblCaption_MouseUp(object sender, MouseEventArgs e)
        {
            if (_IsFocused)
            {
                lblCaption.Font = new Font(lblCaption.Font.FontFamily, lblCaption.Font.Size, FontStyle.Regular);
            }
        }

        private void ucButton_SizeChanged(object sender, EventArgs e)
        {
            lblUnderLine.Top = this.Height - 1;
            lblUnderLine.Width = this.Width - 15;
        }

        /// <summary>
        /// 还原按钮状态
        /// </summary>
        public void DoHideFocusedTag()
        {
            this.pictureBox1.Image = global::MyControls.Properties.Resources.GrayTag;
            this.lblUnderLine.Visible = false;
            lblCaption.ForeColor = Color.Black;
        }

        /// <summary>
        /// 设计按钮为焦点状态
        /// </summary>
        public void DoShowFocusedTag()
        {
            this.pictureBox1.Image = global::MyControls.Properties.Resources.FosedTag;
            this.lblUnderLine.Visible = true;
            lblCaption.ForeColor = Color.Blue;
        }

        private void ucButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                foreach (Control c in this.Parent.Controls)
                {
                    if (c is ucButton) (c as ucButton).DoHideFocusedTag();
                }
            }

            this.DoShowFocusedTag();
            _IsFocused = true;
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [Description("")]
        public Label MyCaption
        {
            get { return lblCaption; }
        }

        private void lblCaption_MouseEnter(object sender, EventArgs e)
        {
            this.ucButton_MouseEnter(sender, e);
        }

    }
}
