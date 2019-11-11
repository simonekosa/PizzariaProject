using Entidades.Sistema;
using Negocios.Pessoas;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace InterfaceUsuario.Login
{
    public partial class FrmLogin : Form
    {
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
    }
}
