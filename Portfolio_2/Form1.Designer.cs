namespace Portfolio_2
{
    partial class FormProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.groupBoxBusca = new System.Windows.Forms.GroupBox();
            this.datePickerFim = new System.Windows.Forms.DateTimePicker();
            this.datePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.comboBusca = new System.Windows.Forms.ComboBox();
            this.groupBoxDetalhes = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblQuantidadeValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDataValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustoValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxProdutos = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxBusca.SuspendLayout();
            this.groupBoxDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listProdutos);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxBusca);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDetalhes);
            this.splitContainer1.Size = new System.Drawing.Size(895, 612);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 0;
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(8, 227);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(270, 277);
            this.listProdutos.TabIndex = 1;
            this.listProdutos.SelectedIndexChanged += new System.EventHandler(this.listProdutos_SelectedIndexChanged);
            // 
            // groupBoxBusca
            // 
            this.groupBoxBusca.Controls.Add(this.datePickerFim);
            this.groupBoxBusca.Controls.Add(this.datePickerInicio);
            this.groupBoxBusca.Controls.Add(this.label7);
            this.groupBoxBusca.Controls.Add(this.label6);
            this.groupBoxBusca.Controls.Add(this.btnLimpar);
            this.groupBoxBusca.Controls.Add(this.btnBuscar);
            this.groupBoxBusca.Controls.Add(this.txtBusca);
            this.groupBoxBusca.Controls.Add(this.comboBusca);
            this.groupBoxBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusca.Location = new System.Drawing.Point(8, 8);
            this.groupBoxBusca.Name = "groupBoxBusca";
            this.groupBoxBusca.Size = new System.Drawing.Size(270, 213);
            this.groupBoxBusca.TabIndex = 0;
            this.groupBoxBusca.TabStop = false;
            this.groupBoxBusca.Text = "Pesquisar Produto";
            this.groupBoxBusca.Enter += new System.EventHandler(this.groupBoxBusca_Enter);
            // 
            // datePickerFim
            // 
            this.datePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFim.Location = new System.Drawing.Point(46, 115);
            this.datePickerFim.Name = "datePickerFim";
            this.datePickerFim.Size = new System.Drawing.Size(200, 20);
            this.datePickerFim.TabIndex = 7;
            // 
            // datePickerInicio
            // 
            this.datePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerInicio.Location = new System.Drawing.Point(46, 88);
            this.datePickerInicio.Name = "datePickerInicio";
            this.datePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.datePickerInicio.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Até:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "De:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(142, 172);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(33, 172);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(6, 57);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(240, 20);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBusca
            // 
            this.comboBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusca.FormattingEnabled = true;
            this.comboBusca.Items.AddRange(new object[] {
            "Nome",
            "ID do Produto",
            "Período (Data)"});
            this.comboBusca.Location = new System.Drawing.Point(6, 30);
            this.comboBusca.Name = "comboBusca";
            this.comboBusca.Size = new System.Drawing.Size(240, 21);
            this.comboBusca.TabIndex = 0;
            this.comboBusca.SelectedIndexChanged += new System.EventHandler(this.comboBusca_SelectedIndexChanged);
            // 
            // groupBoxDetalhes
            // 
            this.groupBoxDetalhes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxDetalhes.Controls.Add(this.btnSair);
            this.groupBoxDetalhes.Controls.Add(this.btnExcluir);
            this.groupBoxDetalhes.Controls.Add(this.btnEditar);
            this.groupBoxDetalhes.Controls.Add(this.btnCadastrar);
            this.groupBoxDetalhes.Controls.Add(this.lblQuantidadeValor);
            this.groupBoxDetalhes.Controls.Add(this.label5);
            this.groupBoxDetalhes.Controls.Add(this.lblDataValor);
            this.groupBoxDetalhes.Controls.Add(this.label4);
            this.groupBoxDetalhes.Controls.Add(this.lblCustoValor);
            this.groupBoxDetalhes.Controls.Add(this.label3);
            this.groupBoxDetalhes.Controls.Add(this.lblNomeValor);
            this.groupBoxDetalhes.Controls.Add(this.label2);
            this.groupBoxDetalhes.Controls.Add(this.lblIdValor);
            this.groupBoxDetalhes.Controls.Add(this.lblValor);
            this.groupBoxDetalhes.Controls.Add(this.label1);
            this.groupBoxDetalhes.Controls.Add(this.pictureBoxProdutos);
            this.groupBoxDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetalhes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetalhes.Name = "groupBoxDetalhes";
            this.groupBoxDetalhes.Size = new System.Drawing.Size(578, 612);
            this.groupBoxDetalhes.TabIndex = 0;
            this.groupBoxDetalhes.TabStop = false;
            this.groupBoxDetalhes.Text = "Detalhes do Produto";
            this.groupBoxDetalhes.Enter += new System.EventHandler(this.groupBoxDetalhes_Enter);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(364, 491);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(158, 30);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar Novo Produto";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblQuantidadeValor
            // 
            this.lblQuantidadeValor.AutoSize = true;
            this.lblQuantidadeValor.Location = new System.Drawing.Point(140, 420);
            this.lblQuantidadeValor.Name = "lblQuantidadeValor";
            this.lblQuantidadeValor.Size = new System.Drawing.Size(10, 13);
            this.lblQuantidadeValor.TabIndex = 11;
            this.lblQuantidadeValor.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade:";
            // 
            // lblDataValor
            // 
            this.lblDataValor.AutoSize = true;
            this.lblDataValor.Location = new System.Drawing.Point(140, 385);
            this.lblDataValor.Name = "lblDataValor";
            this.lblDataValor.Size = new System.Drawing.Size(10, 13);
            this.lblDataValor.TabIndex = 9;
            this.lblDataValor.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data da Compra:";
            // 
            // lblCustoValor
            // 
            this.lblCustoValor.AutoSize = true;
            this.lblCustoValor.Location = new System.Drawing.Point(140, 350);
            this.lblCustoValor.Name = "lblCustoValor";
            this.lblCustoValor.Size = new System.Drawing.Size(10, 13);
            this.lblCustoValor.TabIndex = 7;
            this.lblCustoValor.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Custo Unitário:";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Location = new System.Drawing.Point(140, 315);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(10, 13);
            this.lblNomeValor.TabIndex = 5;
            this.lblNomeValor.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Location = new System.Drawing.Point(140, 280);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(10, 13);
            this.lblIdValor.TabIndex = 3;
            this.lblIdValor.Text = "-";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(140, 280);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 13);
            this.lblValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // pictureBoxProdutos
            // 
            this.pictureBoxProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProdutos.Location = new System.Drawing.Point(20, 25);
            this.pictureBoxProdutos.Name = "pictureBoxProdutos";
            this.pictureBoxProdutos.Size = new System.Drawing.Size(260, 240);
            this.pictureBoxProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProdutos.TabIndex = 0;
            this.pictureBoxProdutos.TabStop = false;
            this.pictureBoxProdutos.Click += new System.EventHandler(this.pictureBoxProdutos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(23, 491);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 30);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(143, 491);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(432, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 30);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(895, 612);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormProdutos";
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxBusca.ResumeLayout(false);
            this.groupBoxBusca.PerformLayout();
            this.groupBoxDetalhes.ResumeLayout(false);
            this.groupBoxDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxBusca;
        private System.Windows.Forms.ComboBox comboBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBoxDetalhes;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxProdutos;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblDataValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustoValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuantidadeValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerFim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerInicio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
    }
}

