namespace Padarosa.Formularios
{
    partial class MenuUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbxCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbUsuarioSenhaCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenhaEdit = new System.Windows.Forms.TextBox();
            this.txbEmailEdit = new System.Windows.Forms.TextBox();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblSenhaEdit = new System.Windows.Forms.Label();
            this.lblEmailEdit = new System.Windows.Forms.Label();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbxCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(29, 88);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(831, 316);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // gbxCadastro
            // 
            this.gbxCadastro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxCadastro.Controls.Add(this.btnCadastrar);
            this.gbxCadastro.Controls.Add(this.txbUsuarioSenhaCad);
            this.gbxCadastro.Controls.Add(this.txbEmailCad);
            this.gbxCadastro.Controls.Add(this.txbNomeCad);
            this.gbxCadastro.Controls.Add(this.lblSenhaCad);
            this.gbxCadastro.Controls.Add(this.lblEmailCad);
            this.gbxCadastro.Controls.Add(this.lblNomeCad);
            this.gbxCadastro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbxCadastro.Location = new System.Drawing.Point(103, 456);
            this.gbxCadastro.Name = "gbxCadastro";
            this.gbxCadastro.Size = new System.Drawing.Size(272, 198);
            this.gbxCadastro.TabIndex = 1;
            this.gbxCadastro.TabStop = false;
            this.gbxCadastro.Text = "Cadastro: ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(26, 166);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(212, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbUsuarioSenhaCad
            // 
            this.txbUsuarioSenhaCad.Location = new System.Drawing.Point(99, 118);
            this.txbUsuarioSenhaCad.Name = "txbUsuarioSenhaCad";
            this.txbUsuarioSenhaCad.Size = new System.Drawing.Size(139, 20);
            this.txbUsuarioSenhaCad.TabIndex = 5;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(99, 80);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(139, 20);
            this.txbEmailCad.TabIndex = 4;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(99, 37);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(139, 20);
            this.txbNomeCad.TabIndex = 3;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenhaCad.Location = new System.Drawing.Point(12, 125);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(46, 15);
            this.lblSenhaCad.TabIndex = 2;
            this.lblSenhaCad.Text = "Senha: ";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailCad.Location = new System.Drawing.Point(12, 87);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(40, 15);
            this.lblEmailCad.TabIndex = 1;
            this.lblEmailCad.Text = "Email: ";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeCad.Location = new System.Drawing.Point(9, 44);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(90, 15);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome Completo: ";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbSenhaEdit);
            this.grbEditar.Controls.Add(this.txbEmailEdit);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Controls.Add(this.lblSenhaEdit);
            this.grbEditar.Controls.Add(this.lblEmailEdit);
            this.grbEditar.Controls.Add(this.lblNomeEdit);
            this.grbEditar.Enabled = false;
            this.grbEditar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grbEditar.Location = new System.Drawing.Point(506, 456);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(271, 198);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar: ";
            this.grbEditar.Enter += new System.EventHandler(this.grbEditar_Enter);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(26, 166);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(212, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbSenhaEdit
            // 
            this.txbSenhaEdit.Location = new System.Drawing.Point(99, 118);
            this.txbSenhaEdit.Name = "txbSenhaEdit";
            this.txbSenhaEdit.Size = new System.Drawing.Size(139, 20);
            this.txbSenhaEdit.TabIndex = 5;
            // 
            // txbEmailEdit
            // 
            this.txbEmailEdit.Location = new System.Drawing.Point(99, 80);
            this.txbEmailEdit.Name = "txbEmailEdit";
            this.txbEmailEdit.Size = new System.Drawing.Size(139, 20);
            this.txbEmailEdit.TabIndex = 4;
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Location = new System.Drawing.Point(99, 37);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(139, 20);
            this.txbNomeEdit.TabIndex = 3;
            // 
            // lblSenhaEdit
            // 
            this.lblSenhaEdit.AutoSize = true;
            this.lblSenhaEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenhaEdit.Location = new System.Drawing.Point(12, 125);
            this.lblSenhaEdit.Name = "lblSenhaEdit";
            this.lblSenhaEdit.Size = new System.Drawing.Size(75, 15);
            this.lblSenhaEdit.TabIndex = 2;
            this.lblSenhaEdit.Text = "Nova Senha: ";
            // 
            // lblEmailEdit
            // 
            this.lblEmailEdit.AutoSize = true;
            this.lblEmailEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailEdit.Location = new System.Drawing.Point(12, 87);
            this.lblEmailEdit.Name = "lblEmailEdit";
            this.lblEmailEdit.Size = new System.Drawing.Size(40, 15);
            this.lblEmailEdit.TabIndex = 1;
            this.lblEmailEdit.Text = "Email: ";
            // 
            // lblNomeEdit
            // 
            this.lblNomeEdit.AutoSize = true;
            this.lblNomeEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeEdit.Location = new System.Drawing.Point(9, 44);
            this.lblNomeEdit.Name = "lblNomeEdit";
            this.lblNomeEdit.Size = new System.Drawing.Size(90, 15);
            this.lblNomeEdit.TabIndex = 0;
            this.lblNomeEdit.Text = "Nome Completo: ";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo2.Font = new System.Drawing.Font("RomanT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo2.Location = new System.Drawing.Point(227, 30);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(461, 55);
            this.lblTitulo2.TabIndex = 8;
            this.lblTitulo2.Text = "MENU DE USUÁRIO";
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(884, 702);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.gbxCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "MenuUsuarios";
            this.Text = "MenuUsuarios";
            this.Load += new System.EventHandler(this.MenuUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbxCadastro.ResumeLayout(false);
            this.gbxCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbxCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbUsuarioSenhaCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenhaEdit;
        private System.Windows.Forms.TextBox txbEmailEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.Label lblSenhaEdit;
        private System.Windows.Forms.Label lblEmailEdit;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.Label lblTitulo2;
    }
}