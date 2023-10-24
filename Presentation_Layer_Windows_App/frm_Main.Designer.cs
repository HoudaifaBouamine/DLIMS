namespace Presentation_Layer_Windows_App
{
    partial class frm_Main
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnl_Container = new Guna.UI2.WinForms.Guna2Panel();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            SuspendLayout();
            // 
            // pnl_Container
            // 
            pnl_Container.CustomizableEdges = customizableEdges1;
            pnl_Container.Dock = DockStyle.Fill;
            pnl_Container.Location = new Point(0, 0);
            pnl_Container.Name = "pnl_Container";
            pnl_Container.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnl_Container.Size = new Size(1082, 650);
            pnl_Container.TabIndex = 0;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 650);
            Controls.Add(pnl_Container);
            Name = "frm_Main";
            Text = "frm_Main";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Container;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}