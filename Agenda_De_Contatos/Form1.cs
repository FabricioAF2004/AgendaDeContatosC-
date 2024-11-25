using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Agenda_De_Contatos
{
    public partial class Agenda : Form
    {
        private List<Contato> contatos; // Declara a lista de contatos corretamente

        public Agenda()
        {
            InitializeComponent();
            contatos = new List<Contato>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };
            contatos.Add(contato);
            AtualizarLista();
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBoxContatos.SelectedIndex >= 0)
            {
                var contato = contatos[listBoxContatos.SelectedIndex];
                contato.Nome = txtNome.Text;
                contato.Telefone = txtTelefone.Text;
                contato.Email = txtEmail.Text;
                AtualizarLista();
                LimparCampos();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxContatos.SelectedIndex >= 0)
            {
                contatos.RemoveAt(listBoxContatos.SelectedIndex);
                AtualizarLista();
                LimparCampos();
            }
        }

        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContatos.SelectedIndex >= 0)
            {
                var contato = contatos[listBoxContatos.SelectedIndex];
                txtNome.Text = contato.Nome;
                txtTelefone.Text = contato.Telefone;
                txtEmail.Text = contato.Email;
            }
        }

        private void AtualizarLista()
        {
            listBoxContatos.Items.Clear();
            foreach (var contato in contatos)
            {
                // Adiciona o contato no formato: Nome - Telefone - Email
                listBoxContatos.Items.Add($"{contato.Nome} - {contato.Telefone} - {contato.Email}");
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            listBoxContatos.ClearSelected();
        }

        // Implementa a função do botão Ver Lista
        private void btnVerLista_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        public class Contato
        {
            public string Nome { get; set; } = string.Empty;
            public string Telefone { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }
    }
}
