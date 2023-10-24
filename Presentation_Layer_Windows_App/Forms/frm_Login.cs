namespace Presentation_Layer_Windows_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnl_Left.Width = pnl_Main.Width / 2;
        }

        private void pnl_LoginWindow_LocationChanged(object sender, EventArgs e)
        {
            if (pnl_Main.Width / 2 <= pnl_LoginWindow.Width + 20)
            {
                pnl_Left.Visible = false;
            }
            else
            {
                pnl_Left.Visible = true;
            }
        }

    }
}