using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace textboxdesign
{
    public partial class textBoxdesign : TextBox
    {
        public Color _BottomBorderColor = Color.Black;
        public Color _OnFocusColor = Color.FromArgb(4, 0, 154);

        public textBoxdesign()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _BottomBorderColor
            });
            InitializeComponent();
        }

        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        public Color BottomBorderColor
        {
            get { return _BottomBorderColor; }
            set
            {
                _BottomBorderColor = value;
                Controls[0].BackColor = _BottomBorderColor;
            }
        }

        public Color OnFocusColor
        {
            get { return _OnFocusColor; }
            set
            {
                _OnFocusColor = value;
            }
        }

        private void txtboxborder_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _OnFocusColor;
        }

        private void txtboxborder_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _BottomBorderColor;
        }
    }
}
