﻿using InterfaceUsuario.Login;
using InterfaceUsuario.Pessoas;
using System;
using System.Windows.Forms;

namespace InterfaceUsuario
{
    public partial class MDIFrm : Form
    {
        public MDIFrm()
        {
            InitializeComponent();
        }

        private void MDIFrm_Load(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                if(control is MdiClient)
                {
                    control.BackgroundImage = Properties.Resources.fundo;
                    control.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                }

               
            }

            mnsPrincipal.Visible = false;

            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            if (!frmLogin.bFlagLogin) Application.Exit();

            mnsPrincipal.Visible = true;

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormularios(Form oFrm)
        {
            oFrm.WindowState = FormWindowState.Normal;
            oFrm.StartPosition = FormStartPosition.Manual;
            oFrm.MdiParent = this;
            oFrm.Top = 0;
            oFrm.Left = 0;
            oFrm.Show();

        }
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmCadUsuario());

        }
    }
}
