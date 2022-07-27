namespace Padarosa.Formularios
{
    partial class MenuProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.gbxCadastroPro = new System.Windows.Forms.GroupBox();
            this.cmbCadastrar = new System.Windows.Forms.ComboBox();
            this.btnCadastrarPro = new System.Windows.Forms.Button();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.txbNomeProCad = new System.Windows.Forms.TextBox();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblNomeProCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbEditar = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbPrecoEdit = new System.Windows.Forms.TextBox();
            this.txbNomeProEdit = new System.Windows.Forms.TextBox();
            this.lblCategoriaEdit = new System.Windows.Forms.Label();
            this.lblPrecoEdit = new System.Windows.Forms.Label();
            this.lblNomeProEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gbxCadastroPro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(67, 105);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(831, 316);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo3.Font = new System.Drawing.Font("RomanT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo3.Location = new System.Drawing.Point(263, 35);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(475, 55);
            this.lblTitulo3.TabIndex = 9;
            this.lblTitulo3.Text = "MENU DE PRODUTO";
            // 
            // gbxCadastroPro
            // 
            this.gbxCadastroPro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxCadastroPro.Controls.Add(this.cmbCadastrar);
            this.gbxCadastroPro.Controls.Add(this.btnCadastrarPro);
            this.gbxCadastroPro.Controls.Add(this.txbPrecoCad);
            this.gbxCadastroPro.Controls.Add(this.txbNomeProCad);
            this.gbxCadastroPro.Controls.Add(this.lblCategoriaCad);
            this.gbxCadastroPro.Controls.Add(this.lblPrecoCad);
            this.gbxCadastroPro.Controls.Add(this.lblNomeProCad);
            this.gbxCadastroPro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbxCadastroPro.Location = new System.Drawing.Point(67, 451);
            this.gbxCadastroPro.Name = "gbxCadastroPro";
            this.gbxCadastroPro.Size = new System.Drawing.Size(272, 198);
            this.gbxCadastroPro.TabIndex = 10;
            this.gbxCadastroPro.TabStop = false;
            this.gbxCadastroPro.Text = "Cadastro de Produto:";
            // 
            // cmbCadastrar
            // 
            this.cmbCadastrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCadastrar.FormattingEnabled = true;
            this.cmbCadastrar.Location = new System.Drawing.Point(113, 122);
            this.cmbCadastrar.Name = "cmbCadastrar";
            this.cmbCadastrar.Size = new System.Drawing.Size(139, 21);
            this.cmbCadastrar.TabIndex = 7;
            // 
            // btnCadastrarPro
            // 
            this.btnCadastrarPro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarPro.Location = new System.Drawing.Point(26, 166);
            this.btnCadastrarPro.Name = "btnCadastrarPro";
            this.btnCadastrarPro.Size = new System.Drawing.Size(212, 23);
            this.btnCadastrarPro.TabIndex = 6;
            this.btnCadastrarPro.Text = "Cadastrar";
            this.btnCadastrarPro.UseVisualStyleBackColor = true;
            this.btnCadastrarPro.Click += new System.EventHandler(this.btnCadastrarPro_Click);
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Location = new System.Drawing.Point(113, 82);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(139, 20);
            this.txbPrecoCad.TabIndex = 4;
            // 
            // txbNomeProCad
            // 
            this.txbNomeProCad.Location = new System.Drawing.Point(113, 41);
            this.txbNomeProCad.Name = "txbNomeProCad";
            this.txbNomeProCad.Size = new System.Drawing.Size(139, 20);
            this.txbNomeProCad.TabIndex = 3;
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoriaCad.Location = new System.Drawing.Point(12, 125);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(60, 15);
            this.lblCategoriaCad.TabIndex = 2;
            this.lblCategoriaCad.Text = "Categoria: ";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecoCad.Location = new System.Drawing.Point(12, 87);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(43, 15);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço: ";
            // 
            // lblNomeProCad
            // 
            this.lblNomeProCad.AutoSize = true;
            this.lblNomeProCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeProCad.Location = new System.Drawing.Point(9, 44);
            this.lblNomeProCad.Name = "lblNomeProCad";
            this.lblNomeProCad.Size = new System.Drawing.Size(98, 15);
            this.lblNomeProCad.TabIndex = 0;
            this.lblNomeProCad.Text = "Nome do Produto: ";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbEditar.Controls.Add(this.cmbEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEdit);
            this.grbEditar.Controls.Add(this.txbNomeProEdit);
            this.grbEditar.Controls.Add(this.lblCategoriaEdit);
            this.grbEditar.Controls.Add(this.lblPrecoEdit);
            this.grbEditar.Controls.Add(this.lblNomeProEdit);
            this.grbEditar.Enabled = false;
            this.grbEditar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grbEditar.Location = new System.Drawing.Point(592, 451);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(271, 198);
            this.grbEditar.TabIndex = 11;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar: ";
            // 
            // cmbEditar
            // 
            this.cmbEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditar.FormattingEnabled = true;
            this.cmbEditar.Location = new System.Drawing.Point(99, 119);
            this.cmbEditar.Name = "cmbEditar";
            this.cmbEditar.Size = new System.Drawing.Size(139, 21);
            this.cmbEditar.TabIndex = 8;
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
            // txbPrecoEdit
            // 
            this.txbPrecoEdit.Location = new System.Drawing.Point(99, 80);
            this.txbPrecoEdit.Name = "txbPrecoEdit";
            this.txbPrecoEdit.Size = new System.Drawing.Size(139, 20);
            this.txbPrecoEdit.TabIndex = 4;
            // 
            // txbNomeProEdit
            // 
            this.txbNomeProEdit.Location = new System.Drawing.Point(99, 37);
            this.txbNomeProEdit.Name = "txbNomeProEdit";
            this.txbNomeProEdit.Size = new System.Drawing.Size(139, 20);
            this.txbNomeProEdit.TabIndex = 3;
            // 
            // lblCategoriaEdit
            // 
            this.lblCategoriaEdit.AutoSize = true;
            this.lblCategoriaEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoriaEdit.Location = new System.Drawing.Point(12, 125);
            this.lblCategoriaEdit.Name = "lblCategoriaEdit";
            this.lblCategoriaEdit.Size = new System.Drawing.Size(60, 15);
            this.lblCategoriaEdit.TabIndex = 2;
            this.lblCategoriaEdit.Text = "Categoria: ";
            // 
            // lblPrecoEdit
            // 
            this.lblPrecoEdit.AutoSize = true;
            this.lblPrecoEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecoEdit.Location = new System.Drawing.Point(12, 87);
            this.lblPrecoEdit.Name = "lblPrecoEdit";
            this.lblPrecoEdit.Size = new System.Drawing.Size(43, 15);
            this.lblPrecoEdit.TabIndex = 1;
            this.lblPrecoEdit.Text = "Preço: ";
            // 
            // lblNomeProEdit
            // 
            this.lblNomeProEdit.AutoSize = true;
            this.lblNomeProEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeProEdit.Location = new System.Drawing.Point(9, 44);
            this.lblNomeProEdit.Name = "lblNomeProEdit";
            this.lblNomeProEdit.Size = new System.Drawing.Size(43, 15);
            this.lblNomeProEdit.TabIndex = 0;
            this.lblNomeProEdit.Text = "Nome: ";
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 671);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.gbxCadastroPro);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "MenuProdutos";
            this.Text = "MenuProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gbxCadastroPro.ResumeLayout(false);
            this.gbxCadastroPro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.GroupBox gbxCadastroPro;
        private System.Windows.Forms.Button btnCadastrarPro;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.TextBox txbNomeProCad;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeProCad;
        private System.Windows.Forms.ComboBox cmbCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbPrecoEdit;
        private System.Windows.Forms.TextBox txbNomeProEdit;
        private System.Windows.Forms.Label lblCategoriaEdit;
        private System.Windows.Forms.Label lblPrecoEdit;
        private System.Windows.Forms.Label lblNomeProEdit;
        private System.Windows.Forms.ComboBox cmbEditar;
    }
}