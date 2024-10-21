using Portal.Infraestrutura;

namespace Portal
{
    public partial class Form1 : Form
    {
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        //lista para verificar se tem algum aluno repetido, dentro dela

        public Form1()
        {
            InitializeComponent();
            ObterAlunos();
        }

        private void ObterAlunos()
        {
            var repository = new AlunoRepository();
            Alunos = repository.Get();

            foreach (var item in Alunos)
            {
                lv_alunos.Items.Add(new ListViewItem(new String[] { item.nome, item.idade.ToString(), item.curso }));
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome.Text;
                var idade = txt_idade.Text;
                var curso = txt_curso.Text;

                foreach (var item in Alunos)
                {
                    if (item.nome == nome)
                    {
                        MessageBox.Show(nome + " já está cadastrado no sistema.");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);

                var repository = new AlunoRepository();
                repository.Add(aluno);

                lv_alunos.Items.Add(new ListViewItem(new String[] { nome, idade, curso }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
