using Entidades.Enumeradores;
using InterfaceUsuario.Pesquisas;
using Negocios.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadUsuario : Form
    {
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
        }

        private void BtnBscTipoUsuario_Click(object sender, EventArgs e)
        {
           
        }
    }
}
