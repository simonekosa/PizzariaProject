using Entidades.Entidades;
using Entidades.Enumeradores;
using InterfaceUsuario.Modulos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceUsuario.Pesquisas
{
    public partial class FrmPesquisaGenerica : Form
    {
        public List<EntidadeViewPesquisa> lista = new List<EntidadeViewPesquisa>();
        public int iRetorno = 0;


        public FrmPesquisaGenerica(string strTitulo, Status status)
        {
            InitializeComponent();

            this.Text = strTitulo;
            if (status == Status.Ativo)
                optSomenteAtivos.Checked = true;
            else if (status == Status.Inativo)
                optSomenteInativos.Checked = true;
            else
                optTodos.Checked = true;

        }

        private void FrmPesquisaGenerica_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true,
                Top = 0,
                Left = 0,

            };
            LimparCampos();
            PreencherLista(lista);
        }

        public void LimparCampos()
        {
            txtBusca.Text = string.Empty;
            iRetorno = 0;
        }

        private void PreencherLista(List<EntidadeViewPesquisa> list)
        {
            lvlListagem.Clear();
            lvlListagem.View = View.Details;

            lvlListagem.Columns.Add("Código", 80, HorizontalAlignment.Right);
            lvlListagem.Columns.Add("Descricao", 280, HorizontalAlignment.Left);

            foreach (var item in list)
            {
                if (!optTodos.Checked)
                {
                    if (optSomenteAtivos.Checked && item.Status != Entidades.Enumeradores.Status.Ativo)
                        continue;
                    else if (optSomenteInativos.Checked && item.Status != Entidades.Enumeradores.Status.Inativo)
                        continue;

                }

                var linha = new string[2];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Descricao;
                var itemX = new ListViewItem(linha);
                lvlListagem.Items.Add(itemX);
            }

            Funcoes.ListViewColor(lvlListagem);

        }

      
        private void LvlListagem_DoubleClick(object sender, EventArgs e)
        {
            BtnConfirmar_Click(btnConfirmar, new EventArgs());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (lvlListagem.SelectedIndices.Count <= 0)
                return;

            var iSelectedIndex = Convert.ToInt32(lvlListagem.SelectedIndices[0]);
            if(iSelectedIndex >= 0)
            {
                iRetorno = Convert.ToInt32(lvlListagem.Items[iSelectedIndex].Text);
                BtnSair_Click(btnSair, new EventArgs());
            }
        }

        private void OptTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optTodos.Checked) return;
            LimparCampos();
            PreencherLista(lista);
        }

        private void OptSomenteAtivos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optSomenteAtivos.Checked) return;
            LimparCampos();
            PreencherLista(lista);
        }

        private void OptSomenteInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optSomenteInativos.Checked) return;
            LimparCampos();
            PreencherLista(lista);
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Trim().Equals(string.Empty))
                return;

            var listResult = new List<EntidadeViewPesquisa>(from p in lista where p.Descricao.ToLower().Contains(txtBusca.Text.Trim().ToLower()) select p);
            PreencherLista(listResult);
        }
    }
}
