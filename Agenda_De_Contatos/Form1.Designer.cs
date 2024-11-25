namespace Agenda_De_Contatos
{
    partial class Agenda
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
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBoxContatos = new ListBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            btnLimpar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(646, 31);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 113);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(646, 31);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(646, 31);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 4;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // listBoxContatos
            // 
            listBoxContatos.FormattingEnabled = true;
            listBoxContatos.ItemHeight = 25;
            listBoxContatos.Location = new Point(12, 298);
            listBoxContatos.Name = "listBoxContatos";
            listBoxContatos.Size = new Size(726, 504);
            listBoxContatos.TabIndex = 6;
            listBoxContatos.SelectedIndexChanged += listBoxContatos_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(733, 44);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(122, 43);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(733, 93);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 43);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(733, 147);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(122, 43);
            btnRemover.TabIndex = 9;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(733, 196);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(122, 43);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 263);
            label4.Name = "label4";
            label4.Size = new Size(193, 32);
            label4.TabIndex = 11;
            label4.Text = "Lista de contatos";
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 814);
            Controls.Add(label4);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(listBoxContatos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Name = "Agenda";
            Text = "Agenda De Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxContatos;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnLimpar;
        private Label label4;
    }
}
