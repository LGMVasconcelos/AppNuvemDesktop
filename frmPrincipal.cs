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
            List<Cliente> cliente = Cliente.listaCliente();
            dgvCliente.DataSource = cliente;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;

            cbxGenero.Items.Add("M");
            cbxGenero.Items.Add("F");
            cbxGenero.Items.Add("O");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("O preenchimento do campo de Id é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cliente c = new Cliente();
            Cliente novoC = c.Localizar(Convert.ToInt32(txtId.Text));
            if (novoC == null)
            {
                MessageBox.Show("Nenhum cliente encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}