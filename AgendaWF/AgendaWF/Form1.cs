namespace AgendaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Centraliza o Form1 na tela
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-Vindo!");

            // Cria o Form2 e abre
            Form2 form2 = new Form2();

            // Inscreve no evento FormClosed para fechar o Form1 quando o Form2 for fechado
            form2.FormClosed += (s, args) => this.Close();  // Fecha o Form1 quando o Form2 for fechado

            // Exibe o Form2
            form2.Show();

            // Oculta o Form1
            this.Hide();
        }
    }
}
