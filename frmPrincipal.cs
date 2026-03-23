using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppNuvemDesktop;

namespace AppNuvemDesktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = Cliente.listaCliente();
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("O campo de Id é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cliente c = new Cliente();
            Cliente novoC = c.Localizar(Convert.ToInt32(txtId.Text));
            if (novoC == null)
            {
                MessageBox.Show("Nenhum cliente encontrado!", "Nenhum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txtNome.Text = novoC.nome;
            cbxGenero.Text = novoC.GeneroDesc;
            dtpData.Value = novoC.datanasc;
            mskCelular.Text = novoC.celular;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNome.Text) || cbxGenero.SelectedItem == null || string.IsNullOrEmpty(dtpData.Text) || mskCelular.MaskCompleted == false)
            {
                MessageBox.Show("Todos campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("O campo deve estar em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string celular = mskCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            string genero = "";
            if (celular.Trim().Length != 11)
            {
                MessageBox.Show("O celular deve conter 11 dígitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool existe = Cliente.RegistroRepetidoInsert(celular.Trim());
            if (existe)
            {
                MessageBox.Show("Esse celular ja está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbxGenero.Text == "Masculino")
            {
                genero = "M";
            }
            else if (cbxGenero.Text == "Feminino")
            {
                genero = "F";
            }
            else
            {
                genero = "O";
            }
            Cliente.Inserir(new Cliente
            {
                nome = txtNome.Text.Trim(),
                celular = celular.Trim(),
                datanasc = dtpData.Value.Date,
                genero = genero
            });
            dgvCliente.DataSource = Cliente.listaCliente();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                int id = Convert.ToInt32(txtId.Text.Trim());
                string datanasc = dtpData.Value.Date.ToString("yyyy-MM-dd");
                string celular = mskCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                string genero = "";
                if (cbxGenero.Text == "Masculino")
                {
                    genero = "M";
                }
                else if (cbxGenero.Text == "Feminino")
                {
                    genero = "F";
                }
                else
                {
                    genero = "O";
                }
                Cliente.Atualizar(new Cliente
                {
                    id = Convert.ToInt32(txtId.Text),
                    nome = txtNome.Text.Trim(),
                    celular = celular.Trim(),
                    datanasc = dtpData.Value.Date,
                    genero = genero
                });
                MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCliente.DataSource = c;
                txtNome.Text = string.Empty;
                mskCelular.Text = string.Empty;
                dtpData.Text = string.Empty;
                cbxGenero.Text = string.Empty;
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;
            dgvCliente.DataSource = Cliente.listaCliente();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var fechar = MessageBox.Show("Deseja realmente fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fechar == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("O campo Id não deve estar em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente.Excluir(Convert.ToInt32(txtId.Text));
            dgvCliente.DataSource = Cliente.listaCliente();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                this.dgvCliente.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mskCelular.Text = row.Cells[2].Value.ToString();
                dtpData.Text = row.Cells[3].Value.ToString();
                cbxGenero.Text = row.Cells[4].Value.ToString();
            }
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}