using AgendaWF.DAL;
using AgendaWF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaWF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Mudar o caminho do banco de dados se eu quiser
            //DALAgenda.path = "Novo caminho do banco de dados";

            DALAgenda.CriarBancoSQLite();
            DALAgenda.CriarTabelaSQLite();
            ExibirDados();
            lbDados.Text = DALAgenda.path;
        }

        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DALAgenda.GetContatos();
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = txtTelefone.Text;

                DALAgenda.Add(contato);
                ExibirDados();

                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = txtTelefone.Text;

                DALAgenda.Update(contato);
                ExibirDados();

                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                DALAgenda.Delete(id);
                ExibirDados();

                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (txtId.Text != "")
                {
                    int id = Convert.ToInt32(txtId.Text);
                    dt = DALAgenda.GetContato(id);
                }
                else
                {
                    string nome = txtNome.Text;
                    dt = DALAgenda.GetContatos(nome);
                }
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
