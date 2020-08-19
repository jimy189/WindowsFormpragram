using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
       

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            var fornecedor = new Fornecedor();

            Retornarfornecedor(fornecedor);

           

         
            listaFornecedores.Add(Retornarfornecedor(fornecedor));

            dgvFornecedores.DataSource = listaFornecedores;
        }

        private Fornecedor Retornarfornecedor(Fornecedor fornecedor)
        {
            if (txtNomeDoFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeDoFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Voce não digitou o nome do Fonecedor");
              
            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Endereço");
                
            }

            if (txtNomeDoContato.Text != string.Empty)
            {
                fornecedor.NomeDoContato = txtNomeDoContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome de Contato");
              
            }

            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Telefone");
                
            }

            return fornecedor;
        }
    }
}
