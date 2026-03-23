namespace AppNuvemDesktop
{
    partial class frmPrincipal
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
            cbxGenero = new ComboBox();
            dtpData = new DateTimePicker();
            mskCelular = new MaskedTextBox();
            dgvCliente = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnLocalizar = new Button();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btnSair = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            cbxGenero.Location = new Point(231, 180);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(121, 29);
            cbxGenero.TabIndex = 3;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(12, 180);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 29);
            dtpData.TabIndex = 4;
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(318, 118);
            mskCelular.Mask = "(99) 00000-0000";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(110, 29);
            mskCelular.TabIndex = 5;
            // 
            // dgvCliente
            // 
            dgvCliente.BackgroundColor = SystemColors.ControlLightLight;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(12, 234);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(540, 174);
            dgvCliente.TabIndex = 6;
            dgvCliente.CellClick += dgvCliente_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 29);
            txtId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 12;
            label3.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 14;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 118);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 29);
            txtNome.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 94);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 16;
            label4.Text = "Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 156);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 17;
            label5.Text = "Gênero";
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = Color.SteelBlue;
            btnLocalizar.FlatAppearance.BorderSize = 0;
            btnLocalizar.FlatStyle = FlatStyle.Flat;
            btnLocalizar.ForeColor = SystemColors.ControlLightLight;
            btnLocalizar.Location = new Point(131, 31);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(138, 43);
            btnLocalizar.TabIndex = 18;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.ForestGreen;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.ForeColor = SystemColors.ControlLightLight;
            btnInserir.Location = new Point(569, 39);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(138, 43);
            btnInserir.TabIndex = 19;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.LightSeaGreen;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.ForeColor = SystemColors.ControlLightLight;
            btnAtualizar.Location = new Point(569, 91);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(138, 43);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Firebrick;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = SystemColors.ControlLightLight;
            btnSair.Location = new Point(569, 365);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(138, 43);
            btnSair.TabIndex = 22;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(569, 142);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(138, 43);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 420);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(btnLocalizar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(dgvCliente);
            Controls.Add(mskCelular);
            Controls.Add(dtpData);
            Controls.Add(cbxGenero);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxGenero;
        private DateTimePicker dtpData;
        private MaskedTextBox mskCelular;
        private DataGridView dgvCliente;
        private Label label1;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private Label label4;
        private Label label5;
        private Button btnLocalizar;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btnSair;
        private Button btnExcluir;
    }
}