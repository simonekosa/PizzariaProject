using System;
using System.Windows.Forms;
using Entidades.Enumeradores;

namespace InterfaceUsuario.UserControls
{
    public partial class ucSituacao : UserControl
    {
        public Status _status;
        public ucSituacao()
        {
            InitializeComponent();
        }

        private void UcSituacao_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            InicializarSituacao(Status.Ativo);

        }

        private void InicializarSituacao(Status status)
        {
            if (DesignMode) return;
            _status = status;
            if (status == Status.Ativo)
                optAtivo.Checked = true;
            else
                optInativo.Checked = true;
        }

        private void OptAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (optAtivo.Checked)
                _status = Status.Ativo;
        }

        private void OptInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (optInativo.Checked)
                _status = Status.Inativo;
        }
    }
}
