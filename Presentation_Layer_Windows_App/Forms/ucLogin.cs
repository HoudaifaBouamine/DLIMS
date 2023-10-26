using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer_Windows_App.Testing
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        Size LoginWindowBaseSize = new Size(639, 788);

        private void pnl_Right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void pnl_LoginWindow_LocationChanged(object sender, EventArgs e)
        {
            if (pnl_Main.Width / 2 <= pnl_LoginWindow.Width + 60)
            {
                pnl_Left.Visible = false;
            }
            else
            {
                pnl_Left.Visible = true;
            }
        }

        private void pnl_Right_Paint_1(object sender, PaintEventArgs e)
        {
            pnl_Left.Width = pnl_Main.Width / 2;
        }
    }
}
