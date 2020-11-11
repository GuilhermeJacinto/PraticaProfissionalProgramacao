namespace Stonks_Adm.Forms
{
    partial class FormFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedor));
            this.mktbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dataGVListar = new System.Windows.Forms.DataGridView();
            this.tbxProduto = new System.Windows.Forms.TextBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.mktbEmail = new System.Windows.Forms.TextBox();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.picBoxFechar = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.btnPagCategoria = new System.Windows.Forms.Button();
            this.btnPagEditar = new System.Windows.Forms.Button();
            this.btnPagRemover = new System.Windows.Forms.Button();
            this.btnPagCadastro = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnMostarEdicao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFechar)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // mktbTelefone
            // 
            this.mktbTelefone.Location = new System.Drawing.Point(667, 43);
            this.mktbTelefone.Mask = "(99) 0 0000 0000";
            this.mktbTelefone.Name = "mktbTelefone";
            this.mktbTelefone.Size = new System.Drawing.Size(124, 20);
            this.mktbTelefone.TabIndex = 22;
            // 
            // dataGVListar
            // 
            this.dataGVListar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dataGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListar.GridColor = System.Drawing.Color.White;
            this.dataGVListar.Location = new System.Drawing.Point(174, 163);
            this.dataGVListar.Name = "dataGVListar";
            this.dataGVListar.Size = new System.Drawing.Size(759, 194);
            this.dataGVListar.TabIndex = 61;
            // 
            // tbxProduto
            // 
            this.tbxProduto.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProduto.Location = new System.Drawing.Point(352, 100);
            this.tbxProduto.Name = "tbxProduto";
            this.tbxProduto.Size = new System.Drawing.Size(124, 23);
            this.tbxProduto.TabIndex = 68;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Items.AddRange(new object[] {
            "Panificação",
            "Confeitaria",
            "Lanches",
            "Salgados",
            "Bebidas Geladas",
            "Bebidas Quentes"});
            this.cboxCategoria.Location = new System.Drawing.Point(666, 71);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(124, 24);
            this.cboxCategoria.TabIndex = 67;
            // 
            // mktbEmail
            // 
            this.mktbEmail.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktbEmail.Location = new System.Drawing.Point(352, 71);
            this.mktbEmail.Name = "mktbEmail";
            this.mktbEmail.Size = new System.Drawing.Size(124, 23);
            this.mktbEmail.TabIndex = 66;
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.Location = new System.Drawing.Point(531, 103);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(130, 16);
            this.lblValorProduto.TabIndex = 65;
            this.lblValorProduto.Text = "Valor do Produto:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(278, 100);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(68, 16);
            this.lblProduto.TabIndex = 64;
            this.lblProduto.Text = "Produto:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(516, 71);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(144, 16);
            this.lblCategoria.TabIndex = 63;
            this.lblCategoria.Text = "Informar Categoria:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.AutoSize = true;
            this.tbxEmail.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(189, 71);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(157, 16);
            this.tbxEmail.TabIndex = 62;
            this.tbxEmail.Text = "E-mail do Fornecedor:";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.Location = new System.Drawing.Point(352, 43);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(124, 23);
            this.tbxNome.TabIndex = 72;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(491, 43);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(170, 16);
            this.lblTelefone.TabIndex = 71;
            this.lblTelefone.Text = "Telefone do Fornecedor:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(194, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(152, 16);
            this.lblNome.TabIndex = 70;
            this.lblNome.Text = "Nome do Fornecedor:";
            // 
            // tbxPreco
            // 
            this.tbxPreco.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPreco.Location = new System.Drawing.Point(667, 103);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(124, 23);
            this.tbxPreco.TabIndex = 73;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(633, 129);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(124, 28);
            this.btnRemover.TabIndex = 76;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(503, 129);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditar.Size = new System.Drawing.Size(124, 28);
            this.btnEditar.TabIndex = 75;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(373, 129);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(124, 28);
            this.btnInserir.TabIndex = 74;
            this.btnInserir.Text = "Cadastrar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTitulo.Controls.Add(this.picBoxFechar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 10);
            this.panelTitulo.TabIndex = 77;
            // 
            // picBoxFechar
            // 
            this.picBoxFechar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxFechar.ErrorImage = null;
            this.picBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFechar.Image")));
            this.picBoxFechar.InitialImage = null;
            this.picBoxFechar.Location = new System.Drawing.Point(828, 0);
            this.picBoxFechar.Name = "picBoxFechar";
            this.picBoxFechar.Size = new System.Drawing.Size(45, 38);
            this.picBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFechar.TabIndex = 0;
            this.picBoxFechar.TabStop = false;
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuVertical.Controls.Add(this.btnPagCategoria);
            this.panelMenuVertical.Controls.Add(this.btnPagEditar);
            this.panelMenuVertical.Controls.Add(this.btnPagRemover);
            this.panelMenuVertical.Controls.Add(this.btnPagCadastro);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 10);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(165, 359);
            this.panelMenuVertical.TabIndex = 78;
            // 
            // btnPagCategoria
            // 
            this.btnPagCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagCategoria.FlatAppearance.BorderSize = 0;
            this.btnPagCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagCategoria.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagCategoria.ForeColor = System.Drawing.Color.White;
            this.btnPagCategoria.Location = new System.Drawing.Point(12, 261);
            this.btnPagCategoria.Name = "btnPagCategoria";
            this.btnPagCategoria.Size = new System.Drawing.Size(138, 47);
            this.btnPagCategoria.TabIndex = 70;
            this.btnPagCategoria.Text = "Procurar por Categorias";
            this.btnPagCategoria.UseVisualStyleBackColor = false;
            // 
            // btnPagEditar
            // 
            this.btnPagEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagEditar.FlatAppearance.BorderSize = 0;
            this.btnPagEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagEditar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagEditar.ForeColor = System.Drawing.Color.White;
            this.btnPagEditar.Location = new System.Drawing.Point(12, 212);
            this.btnPagEditar.Name = "btnPagEditar";
            this.btnPagEditar.Size = new System.Drawing.Size(138, 43);
            this.btnPagEditar.TabIndex = 69;
            this.btnPagEditar.Text = "Editar";
            this.btnPagEditar.UseVisualStyleBackColor = false;
            this.btnPagEditar.Click += new System.EventHandler(this.btnPagEditar_Click);
            // 
            // btnPagRemover
            // 
            this.btnPagRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagRemover.FlatAppearance.BorderSize = 0;
            this.btnPagRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagRemover.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagRemover.ForeColor = System.Drawing.Color.White;
            this.btnPagRemover.Location = new System.Drawing.Point(12, 167);
            this.btnPagRemover.Name = "btnPagRemover";
            this.btnPagRemover.Size = new System.Drawing.Size(138, 39);
            this.btnPagRemover.TabIndex = 68;
            this.btnPagRemover.Text = "Remover";
            this.btnPagRemover.UseVisualStyleBackColor = false;
            this.btnPagRemover.Click += new System.EventHandler(this.btnPagRemover_Click);
            // 
            // btnPagCadastro
            // 
            this.btnPagCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPagCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagCadastro.FlatAppearance.BorderSize = 0;
            this.btnPagCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPagCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagCadastro.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagCadastro.ForeColor = System.Drawing.Color.White;
            this.btnPagCadastro.Location = new System.Drawing.Point(12, 123);
            this.btnPagCadastro.Name = "btnPagCadastro";
            this.btnPagCadastro.Size = new System.Drawing.Size(138, 37);
            this.btnPagCadastro.TabIndex = 67;
            this.btnPagCadastro.Text = "Cadastrar";
            this.btnPagCadastro.UseVisualStyleBackColor = false;
            this.btnPagCadastro.Click += new System.EventHandler(this.btnPagCadastro_Click);
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnID.FlatAppearance.BorderSize = 0;
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnID.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.ForeColor = System.Drawing.Color.White;
            this.btnID.Location = new System.Drawing.Point(352, 10);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(124, 28);
            this.btnID.TabIndex = 82;
            this.btnID.Text = "Mostrar";
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // tBoxID
            // 
            this.tBoxID.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxID.Location = new System.Drawing.Point(215, 13);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(124, 23);
            this.tBoxID.TabIndex = 80;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(182, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 16);
            this.lblID.TabIndex = 79;
            this.lblID.Text = "ID:";
            // 
            // btnMostarEdicao
            // 
            this.btnMostarEdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMostarEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostarEdicao.FlatAppearance.BorderSize = 0;
            this.btnMostarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostarEdicao.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostarEdicao.ForeColor = System.Drawing.Color.White;
            this.btnMostarEdicao.Location = new System.Drawing.Point(352, 10);
            this.btnMostarEdicao.Name = "btnMostarEdicao";
            this.btnMostarEdicao.Size = new System.Drawing.Size(124, 28);
            this.btnMostarEdicao.TabIndex = 83;
            this.btnMostarEdicao.Text = "Mostrar";
            this.btnMostarEdicao.UseVisualStyleBackColor = false;
            this.btnMostarEdicao.Click += new System.EventHandler(this.btnMostarEdicao_Click);
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.btnMostarEdicao);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxProduto);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.mktbEmail);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.dataGVListar);
            this.Controls.Add(this.mktbTelefone);
            this.Name = "FormFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFechar)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mktbTelefone;
        private System.Windows.Forms.DataGridView dataGVListar;
        private System.Windows.Forms.TextBox tbxProduto;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.TextBox mktbEmail;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label tbxEmail;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox picBoxFechar;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Button btnPagCategoria;
        private System.Windows.Forms.Button btnPagEditar;
        private System.Windows.Forms.Button btnPagRemover;
        private System.Windows.Forms.Button btnPagCadastro;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnMostarEdicao;
    }
}