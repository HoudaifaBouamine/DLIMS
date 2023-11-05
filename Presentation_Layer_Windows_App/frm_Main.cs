using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;

namespace Presentation_Layer_Windows_App.Testing
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            // Resizing window
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //

            ucMain test = new ucMain();
            //ucLogin test = new ucLogin();
            pnl_MainContainer.Controls.Add(test);
            test.Dock = DockStyle.Fill;
            test.Show();
        }

        #region Resizing window
        protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            Brush b = new SolidBrush(Color.FromArgb(30, 30, 30));

            e.Graphics.FillRectangle(b, TopRect);
            e.Graphics.FillRectangle(b, LeftRect);
            e.Graphics.FillRectangle(b, RightRect);
            e.Graphics.FillRectangle(b, BottomRect);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

        private Rectangle TopRect { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }

        private Rectangle LeftRect { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }

        private Rectangle BottomRect { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }

        private Rectangle RightRect { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (TopRect.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (LeftRect.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (RightRect.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (BottomRect.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        #endregion


    }
}
