namespace AgendaWF
{
    partial class Form2
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
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btInserir = new Button();
            btAlterar = new Button();
            btExcluir = new Button();
            btLocalizar = new Button();
            dataGridView1 = new DataGridView();
            lbDados = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(67, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(90, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(67, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(205, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "NOME";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(357, 49);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(205, 23);
            txtTelefone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 54);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "TELEFONE";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 94);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "EMAIL";
            // 
            // btInserir
            // 
            btInserir.Location = new Point(291, 94);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(75, 23);
            btInserir.TabIndex = 8;
            btInserir.Text = "INSERIR";
            btInserir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(372, 94);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 23);
            btAlterar.TabIndex = 9;
            btAlterar.Text = "ALTERAR";
            btAlterar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(453, 94);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 10;
            btExcluir.Text = "EXCLUIR";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(534, 94);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(87, 23);
            btLocalizar.TabIndex = 11;
            btLocalizar.Text = "LOCALIZAR";
            btLocalizar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(598, 164);
            dataGridView1.TabIndex = 12;
            // 
            // lbDados
            // 
            lbDados.AutoSize = true;
            lbDados.Location = new Point(23, 336);
            lbDados.Name = "lbDados";
            lbDados.Size = new Size(219, 15);
            lbDados.TabIndex = 13;
            lbDados.Text = "Local onde os dados estão armazenados";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(633, 362);
            Controls.Add(lbDados);
            Controls.Add(dataGridView1);
            Controls.Add(btLocalizar);
            Controls.Add(btExcluir);
            Controls.Add(btAlterar);
            Controls.Add(btInserir);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form2";
            Text = "AGENDA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btInserir;
        private Button btAlterar;
        private Button btExcluir;
        private Button btLocalizar;
        private DataGridView dataGridView1;
        private Label lbDados;
    }
}