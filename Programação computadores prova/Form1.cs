using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programação_computadores
{
    public partial class Form1 : Form
    {
        //LIST USADA AO DECORRER DO CÓDIGO
        List<Pessoa> listadepessoas = new List<Pessoa>();
       //

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //FUNÇÃO BOTÃO EXCLUIR
        private void btnincluir_Click(object sender, EventArgs e)
        {
            if(txtnome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome", "Atenção");
            }
            else
            {
                listadepessoas.Add(new Pessoa(txtnome.Text, msktelefone.Text, mskcpf.Text, data.Value, (float)nupdinheiro.Value));
                mostrar();
                txtnome.Clear();
                msktelefone.Clear();
                mskcpf.Clear();
                nupdinheiro.ResetText();
            }
        }
        //

        //fUNÇÃO MOSTRAR O ITEM NA LISTBOX
        private void mostrar()
        {
            listBox1.Items.Clear();

            foreach(Pessoa pessoa in listadepessoas)
            {
                listBox1.Items.Add(pessoa.Nome);
            }
        }
        //

        //FUNÇÃO SELECIONAR4 PRODUTO NA LSITBOX
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            txtnomealterar.Text = listadepessoas[index].Nome;
            msktelefonealterar.Text = listadepessoas[index].Telefone;
            mskcpfalterar.Text = listadepessoas[index].Cpf;
            dataalterar.Value = listadepessoas[index].Data;
            nupdinheiroalterar.Text = Convert.ToString(listadepessoas[index].Dinheiro);
        }
        //

        //FUNÇÃO BOTÃO ALTERAR
        private void btnalterar_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listadepessoas[index].Nome = txtnomealterar.Text;
            listadepessoas[index].Telefone = msktelefonealterar.Text;
            listadepessoas[index].Cpf = mskcpfalterar.Text;
            listadepessoas[index].Data = dataalterar.Value;
            listadepessoas[index].Dinheiro = (float)nupdinheiroalterar.Value;
            mostrar();
        }
        //

        //FUNÇÃO BOTÃO EXCLUIR
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            var result = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                return;
            }
            listadepessoas.RemoveAt(index);
            mostrar();
            txtnomealterar.Clear();
            msktelefonealterar.Clear();
            mskcpfalterar.Clear();
            nupdinheiroalterar.ResetText();
        }
        //
    }
}
