namespace Portal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_curso = new TextBox();
            btn_adicionar = new Button();
            panel1 = new Panel();
            label5 = new Label();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(117, 45);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 0;
            label1.Text = "Fomulário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(53, 103);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(53, 169);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Idade: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(53, 234);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 3;
            label4.Text = "Curso: ";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(53, 127);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(281, 23);
            txt_nome.TabIndex = 4;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(53, 193);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(281, 23);
            txt_idade.TabIndex = 5;
            // 
            // txt_curso
            // 
            txt_curso.Location = new Point(53, 258);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(281, 23);
            txt_curso.TabIndex = 6;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_adicionar.Location = new Point(117, 315);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(148, 43);
            btn_adicionar.TabIndex = 7;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(385, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 452);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 53);
            label5.Name = "label5";
            label5.Size = new Size(163, 30);
            label5.TabIndex = 1;
            label5.Text = "Lista de Alunos";
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos.Location = new Point(28, 104);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(372, 335);
            lv_alunos.TabIndex = 0;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 80;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 250;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 450);
            Controls.Add(panel1);
            Controls.Add(btn_adicionar);
            Controls.Add(txt_curso);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulário";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_curso;
        private Button btn_adicionar;
        private Panel panel1;
        private Label label5;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
    }
}
