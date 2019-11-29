using Entidades.Enumeradores;
using InterfaceUsuario.Pesquisas;
using Negocios.Pessoas;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadUsuario : Form
    {
        private bool IsNovo;

        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void BtnBscUsuario_Click(object sender, EventArgs e)
        {
            var lista = new UsuarioNG().ListarEntidadesViewPesquisa(Status.Todos);
            //verifica se a lista está vazia
            if (lista.Count < 1)
            {
                MessageBox.Show("Sem dados para serem exibidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //passar a lista para o formulário genérico de pesquisa
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Usuarios", Status.Todos);
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;
            //iRetorno = 0
            if (iRetorno < 1) return;

            txtCodigoUsuario.Text = iRetorno.ToString();
            TxtCodigoUsuario_Validated(txtCodigoUsuario, new CancelEventArgs());
            btnBscUsuario.Focus();
            
        }

        private void BtnBscTipoUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtCodigoUsuario_Validated(object sender, EventArgs e)
        {
            //Verificar se esta vazio
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
                return;

            var oUsuario = new UsuarioNG().Buscar(Convert.ToInt32(txtCodigoUsuario.Text.Trim()));
            if(oUsuario == null)
            {
                btnExcluir.Enabled = false;
                return;
            }

            //carregar informações na tela
            IsNovo = false;
            txtNomeUsuario.Text = oUsuario.Nome;
            txtLoginUsuario.Text = oUsuario.Login;
            txtSenhaUsuario.Text = oUsuario.Senha;
            txtCodigoTipoUsuario.Text = oUsuario.TipoUsuario.Codigo.ToString();

            //1º - Validar Tipo Usuário
            //2º - Máscara do campo código Usuário
            //3º - Máscara do campo código tipo usuaá

            oUcSituacao.InicializarSituacao(oUsuario.Status);
            btnExcluir.Enabled = true;

        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {

        }
    }
}
