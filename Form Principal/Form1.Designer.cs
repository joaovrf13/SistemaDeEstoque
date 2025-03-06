namespace SistemaMelhorado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtnCadastrar = new Button();
            BtnLimpar = new Button();
            BtnExcluir = new Button();
            BtnPesquisar = new Button();
            BtnDados = new Button();
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            txtCusto = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            txtFornecedor = new TextBox();
            txtDatadaCompra = new TextBox();
            BtnClientes = new Button();
            txtId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "ID do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 53);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome do produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 92);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 2;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 3;
            label4.Text = "Custo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 170);
            label5.Name = "label5";
            label5.Size = new Size(61, 19);
            label5.TabIndex = 4;
            label5.Text = "Preço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 211);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 5;
            label6.Text = "Quantidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 251);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 6;
            label7.Text = "Fornecedor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 296);
            label8.Name = "label8";
            label8.Size = new Size(147, 19);
            label8.TabIndex = 7;
            label8.Text = "Data da Compra: ";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(12, 367);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(94, 29);
            BtnCadastrar.TabIndex = 9;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(121, 367);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(94, 29);
            BtnLimpar.TabIndex = 10;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(371, 367);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(94, 29);
            BtnExcluir.TabIndex = 11;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(262, 367);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(94, 29);
            BtnPesquisar.TabIndex = 12;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnDados
            // 
            BtnDados.Location = new Point(447, 12);
            BtnDados.Name = "BtnDados";
            BtnDados.Size = new Size(94, 29);
            BtnDados.TabIndex = 14;
            BtnDados.Text = "Dados";
            BtnDados.UseVisualStyleBackColor = true;
            BtnDados.Click += BtnDados_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(162, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(152, 27);
            txtNome.TabIndex = 15;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(162, 85);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(152, 27);
            txtCategoria.TabIndex = 16;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(162, 127);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(152, 27);
            txtCusto.TabIndex = 17;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(162, 163);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(152, 27);
            txtPreco.TabIndex = 18;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(162, 204);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(152, 27);
            txtQuantidade.TabIndex = 19;
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(162, 244);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(152, 27);
            txtFornecedor.TabIndex = 20;
            // 
            // txtDatadaCompra
            // 
            txtDatadaCompra.Location = new Point(162, 288);
            txtDatadaCompra.Name = "txtDatadaCompra";
            txtDatadaCompra.Size = new Size(152, 27);
            txtDatadaCompra.TabIndex = 21;
            // 
            // BtnClientes
            // 
            BtnClientes.Location = new Point(447, 53);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(94, 29);
            BtnClientes.TabIndex = 22;
            BtnClientes.Text = "Clientes ";
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(121, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(0, 20);
            txtId.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 432);
            Controls.Add(txtId);
            Controls.Add(BtnClientes);
            Controls.Add(txtDatadaCompra);
            Controls.Add(txtFornecedor);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtCusto);
            Controls.Add(txtCategoria);
            Controls.Add(txtNome);
            Controls.Add(BtnDados);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnCadastrar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BtnCadastrar;
        private Button BtnLimpar;
        private Button BtnExcluir;
        private Button BtnPesquisar;
        private Button BtnDados;
        private TextBox txtNome;
        private TextBox txtCategoria;
        private TextBox txtCusto;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private TextBox txtFornecedor;
        private TextBox txtDatadaCompra;
        private Button BtnClientes;
        private Label txtId;
    }
}
