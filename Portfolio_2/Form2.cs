using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Portfolio_2
{
    public partial class FormCadastroProduto : Form
    {
        private string connectionString = "Server=localhost;Database=Produtos;Uid=root;Pwd=;";
        string caminhoImagem = "";

        private bool modoEdicao = false;
        private string idEdicao = "";

        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(230, 241, 251);

            btnSalvar.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            btnSalvar.ForeColor = System.Drawing.Color.White;
            btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalvar.FlatAppearance.BorderSize = 0;

            btnLimpar.BackColor = System.Drawing.Color.White;
            btnLimpar.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);

            btnConsultar.BackColor = System.Drawing.Color.FromArgb(4, 44, 83);
            btnConsultar.ForeColor = System.Drawing.Color.White;
            btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultar.FlatAppearance.BorderSize = 0;

            btnImagem.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            btnImagem.ForeColor = System.Drawing.Color.White;
            btnImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImagem.FlatAppearance.BorderSize = 0;

            btnSair.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnSair.ForeColor = System.Drawing.Color.White;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.FlatAppearance.BorderSize = 0;

            txtId.Enabled = false;
            txtId.Text = "(gerado automaticamente)";

        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o Nome do produto.",
                                "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCusto.Text))
            {
                MessageBox.Show("Por favor, preencha o Custo Unitário.",
                                "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusto.Focus();
                return;
            }

            if (!decimal.TryParse(txtCusto.Text, out decimal custo))
            {
                MessageBox.Show("Custo Unitário deve ser um número válido.\nExemplo: 99,90",
                                "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Por favor, preencha a Quantidade.",
                                "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número inteiro.\nExemplo: 10",
                                "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }

            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();

                if (modoEdicao)
                {
                    comando.CommandText = @"UPDATE Produtos 
                        SET Nome=@Nome, CustoUnitario=@Custo, 
                            DataCompra=@Data, Imagem=@Imagem, Quantidade=@Quantidade
                        WHERE idProduto = @Id;";

                    comando.Parameters.AddWithValue("@Id", idEdicao);
                    comando.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@Custo", custo);
                    comando.Parameters.AddWithValue("@Data", dateCompra.Value.Date);
                    comando.Parameters.AddWithValue("@Imagem", caminhoImagem);
                    comando.Parameters.AddWithValue("@Quantidade", quantidade);

                    int retorno = comando.ExecuteNonQuery();

                    if (retorno < 1)
                        MessageBox.Show("Erro ao atualizar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    comando.CommandText = @"INSERT INTO Produtos 
                        (Nome, CustoUnitario, DataCompra, Imagem, Quantidade)
                        VALUES (@Nome, @Custo, @Data, @Imagem, @Quantidade);";

                    comando.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@Custo", custo);
                    comando.Parameters.AddWithValue("@Data", dateCompra.Value.Date);
                    comando.Parameters.AddWithValue("@Imagem", caminhoImagem);
                    comando.Parameters.AddWithValue("@Quantidade", quantidade);

                    int retorno = comando.ExecuteNonQuery();

                    if (retorno < 1)
                        MessageBox.Show("Erro ao inserir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                }
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show("Erro MySQL:\n" + msqle.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }


        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                caminhoImagem = ofd.FileName;
                pictureProduto.Image = System.Drawing.Image.FromFile(caminhoImagem);
                pictureProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtCusto.Text = "";
            txtQuantidade.Text = "";
            dateCompra.Value = DateTime.Today;
            pictureProduto.Image = null;
            caminhoImagem = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
             FormProdutos formConsulta = new FormProdutos();
             formConsulta.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "(gerado automaticamente)";
            txtNome.Text = "";
            txtCusto.Text = "";
            txtQuantidade.Text = "";
            dateCompra.Value = DateTime.Today;
            pictureProduto.Image = null;
            caminhoImagem = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        
            DialogResult resposta = MessageBox.Show("Deseja realmente sair?","Sair",
            MessageBoxButtons.YesNo,MessageBoxIcon.Question);

          if (resposta == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void Edicao(string id, string nome, string custo, DateTime data, string quantidade, string imagem)
        {
            modoEdicao = true;
            idEdicao = id;  
            txtId.Enabled = false;
            txtId.Text = id;
            txtNome.Text = nome;
            txtCusto.Text = custo;
            dateCompra.Value = data;
            txtQuantidade.Text = quantidade;
            caminhoImagem = imagem;

            if (!string.IsNullOrEmpty(imagem) && System.IO.File.Exists(imagem))
            {
                pictureProduto.Image = System.Drawing.Image.FromFile(imagem);
                pictureProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }

            btnSalvar.Text = "Atualizar";
        }
    }
}