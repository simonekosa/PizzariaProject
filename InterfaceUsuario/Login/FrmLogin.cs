using Entidades.Sistema;
using Negocios.Pessoas;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace InterfaceUsuario.Login
{
    public partial class FrmLogin : Form
    {
        public bool bFlagLogin;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersao.Text = string.Format(lblVersao.Text, version.Major, version.Minor, version.Build, version.Revision);

            //Metodo para carregar usuarios no login
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            var lista = new UsuarioNG().ListarUsuarios();
            if(lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    cmbUsuarios.Items.Add(new ComboBoxItemUsuario(item.Login, item.Codigo, item.Senha));
                }
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar um usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSenha.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar uma senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (ComboBoxItemUsuario)cmbUsuarios.SelectedItem;
            if(item.Senha != txtSenha.Text.Trim())
            {
                MessageBox.Show("Senha inválida para o usuario informado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bFlagLogin = true;
            this.Close();

        }
    }
}
