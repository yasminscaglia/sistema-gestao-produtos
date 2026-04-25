using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Portfolio_2
{
    public partial class FormProdutos : Form
    {

        private string connectionString = "Server=localhost;Database=Produtos;Uid=root;Pwd=;";

        private DataTable tabelaProdutos = new DataTable();

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(230, 241, 251);

            groupBoxBusca.BackColor = System.Drawing.Color.White;
            groupBoxBusca.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);

            groupBoxDetalhes.BackColor = System.Drawing.Color.White;
            groupBoxDetalhes.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);

            listProdutos.BackColor = System.Drawing.Color.White;
            listProdutos.ForeColor = System.Drawing.Color.FromArgb(4, 44, 83);

            btnBuscar.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            btnBuscar.ForeColor = System.Drawing.Color.White;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;

            btnLimpar.BackColor = System.Drawing.Color.White;
            btnLimpar.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);

            btnEditar.BackColor = System.Drawing.Color.White;
            btnEditar.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);

            btnExcluir.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnExcluir.ForeColor = System.Drawing.Color.White;
            btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcluir.FlatAppearance.BorderSize = 0;

            btnSair.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnSair.ForeColor = System.Drawing.Color.White;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.FlatAppearance.BorderSize = 0;

            datePickerInicio.Visible = false;
            datePickerFim.Visible = false;
            datePickerInicio.Value = DateTime.Today.AddMonths(-1);
            datePickerFim.Value = DateTime.Today;
            CarregarTodosProdutos();
        }

        private void CarregarTodosProdutos()
        {
            try
            {
                string sql = @"SELECT idProduto, Nome, CustoUnitario, 
                              DataCompra, Imagem, Quantidade
                       FROM Produtos
                       ORDER BY idProduto";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    tabelaProdutos = new DataTable();
                    da.Fill(tabelaProdutos);
                }

                AtualizarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBox()
        {
            listProdutos.Items.Clear();

            foreach (DataRow row in tabelaProdutos.Rows)
            {
                listProdutos.Items.Add($"{row["idProduto"]} - {row["Nome"]}");
            }
        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProdutos.SelectedIndex < 0) return;

            DataRow row = tabelaProdutos.Rows[listProdutos.SelectedIndex];

            lblIdValor.Text = row["idProduto"].ToString();
            lblNomeValor.Text = row["Nome"].ToString();
            lblCustoValor.Text = $"R$ {Convert.ToDecimal(row["CustoUnitario"]):N2}";
            lblDataValor.Text = Convert.ToDateTime(row["DataCompra"]).ToString("dd/MM/yyyy");
            lblQuantidadeValor.Text = row["Quantidade"].ToString();

            string caminho = row["Imagem"].ToString();

            if (!string.IsNullOrEmpty(caminho) && File.Exists(caminho))
            {
                pictureBoxProdutos.Image = Image.FromFile(caminho);
                pictureBoxProdutos.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBoxProdutos.Image = null;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxDetalhes_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxBusca_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                string filtro = comboBusca.SelectedItem.ToString();

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;

                    if (filtro == "Nome")
                    {
                        cmd.CommandText = @"SELECT idProduto, Nome, CustoUnitario, 
                                           DataCompra, Imagem, Quantidade
                                    FROM Produtos
                                    WHERE Nome LIKE @Nome
                                    ORDER BY Nome";
                        cmd.Parameters.AddWithValue("@Nome", "%" + txtBusca.Text + "%");
                    }
                    else if (filtro == "ID do Produto")
                    {
                        cmd.CommandText = @"SELECT idProduto, Nome, CustoUnitario, 
                                           DataCompra, Imagem, Quantidade
                                    FROM Produtos
                                    WHERE idProduto = @Id
                                    ORDER BY Nome";
                        cmd.Parameters.AddWithValue("@Id", int.Parse(txtBusca.Text));
                    }
                    else if (filtro == "Período (Data)")
                    {
                        cmd.CommandText = @"SELECT idProduto, Nome, CustoUnitario, 
                                           DataCompra, Imagem, Quantidade
                                    FROM Produtos
                                    WHERE DataCompra BETWEEN @DataInicio AND @DataFim
                                    ORDER BY DataCompra";
                        cmd.Parameters.AddWithValue("@DataInicio", datePickerInicio.Value.Date);
                        cmd.Parameters.AddWithValue("@DataFim", datePickerFim.Value.Date);
                    }

                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    tabelaProdutos = new DataTable();
                    da.Fill(tabelaProdutos);
                }

                AtualizarListBox();

                if (tabelaProdutos.Rows.Count == 0)
                    MessageBox.Show("Nenhum produto encontrado.",
                                    "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            comboBusca.SelectedIndex = 0;
            pictureBoxProdutos.Image = null;
            lblIdValor.Text = "-";
            lblNomeValor.Text = "-";
            lblCustoValor.Text = "-";
            lblDataValor.Text = "-";
            lblQuantidadeValor.Text = "-";
            CarregarTodosProdutos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBusca.SelectedItem.ToString() == "Período (Data)")
            {
                txtBusca.Visible = false;
                datePickerInicio.Visible = true;
                datePickerFim.Visible = true;
            }
            else
            {
                txtBusca.Visible = true;
                datePickerInicio.Visible = false;
                datePickerFim.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            form.ShowDialog();

            CarregarTodosProdutos();
        }

        private void pictureBoxProdutos_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (listProdutos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um produto para editar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = tabelaProdutos.Rows[listProdutos.SelectedIndex];

            FormCadastroProduto formEditar = new FormCadastroProduto();
            formEditar.Edicao(
                row["idProduto"].ToString(),
                row["Nome"].ToString(),
                row["CustoUnitario"].ToString(),
                Convert.ToDateTime(row["DataCompra"]),
                row["Quantidade"].ToString(),
                row["Imagem"].ToString()
            );
            formEditar.Show();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listProdutos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um produto para excluir.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = tabelaProdutos.Rows[listProdutos.SelectedIndex];

            DialogResult resposta = MessageBox.Show(
                $"Deseja excluir o produto: {row["Nome"]}?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.No) return;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Produtos WHERE idProduto = @Id;";
                    cmd.Parameters.AddWithValue("@Id", row["idProduto"]);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto excluído com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarTodosProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair?","Sair",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
                Application.Exit();
        }
    }
}
