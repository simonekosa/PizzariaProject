namespace InterfaceUsuario.Pessoas
{
    partial class FrmCadUsuario
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBscUsuario = new System.Windows.Forms.Button();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.txtCodigoTipoUsuario = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblMstTipoUsuario = new System.Windows.Forms.Label();
            this.btnBscTipoUsuario = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnConfirma);
            this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(399, 275);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(338, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirma.Location = new System.Drawing.Point(3, 3);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(105, 42);
            this.btnConfirma.TabIndex = 0;
            this.btnConfirma.Text = "CONFIRMAR";
            this.btnConfirma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(114, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 42);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::InterfaceUsuario.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(225, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // btnBscUsuario
            // 
            this.btnBscUsuario.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscUsuario.Location = new System.Drawing.Point(122, 22);
            this.btnBscUsuario.Name = "btnBscUsuario";
            this.btnBscUsuario.Size = new System.Drawing.Size(35, 32);
            this.btnBscUsuario.TabIndex = 2;
            this.btnBscUsuario.UseVisualStyleBackColor = true;
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(16, 29);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoUsuario.TabIndex = 3;
            // 
            // txtCodigoTipoUsuario
            // 
            this.txtCodigoTipoUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoTipoUsuario.Location = new System.Drawing.Point(16, 134);
            this.txtCodigoTipoUsuario.Name = "txtCodigoTipoUsuario";
            this.txtCodigoTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoTipoUsuario.TabIndex = 6;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(13, 118);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(70, 13);
            this.lblTipoUsuario.TabIndex = 4;
            this.lblTipoUsuario.Text = "Tipo Usuário:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(261, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNomeUsuario.Location = new System.Drawing.Point(264, 29);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(464, 20);
            this.txtNomeUsuario.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(261, 71);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login:";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLoginUsuario.Location = new System.Drawing.Point(264, 87);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(226, 20);
            this.txtLoginUsuario.TabIndex = 10;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(503, 87);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(226, 20);
            this.txtSenhaUsuario.TabIndex = 12;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(500, 71);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // lblMstTipoUsuario
            // 
            this.lblMstTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstTipoUsuario.Location = new System.Drawing.Point(262, 131);
            this.lblMstTipoUsuario.Name = "lblMstTipoUsuario";
            this.lblMstTipoUsuario.Size = new System.Drawing.Size(467, 23);
            this.lblMstTipoUsuario.TabIndex = 13;
            // 
            // btnBscTipoUsuario
            // 
            this.btnBscTipoUsuario.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscTipoUsuario.Location = new System.Drawing.Point(122, 127);
            this.btnBscTipoUsuario.Name = "btnBscTipoUsuario";
            this.btnBscTipoUsuario.Size = new System.Drawing.Size(35, 32);
            this.btnBscTipoUsuario.TabIndex = 14;
            this.btnBscTipoUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 327);
            this.Controls.Add(this.btnBscTipoUsuario);
            this.Controls.Add(this.lblMstTipoUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigoTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.txtCodigoUsuario);
            this.Controls.Add(this.btnBscUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Usuario";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBscUsuario;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.TextBox txtCodigoTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblMstTipoUsuario;
        private System.Windows.Forms.Button btnBscTipoUsuario;
    }
}