using System;
using System.Windows.Forms;
using Proov.Services;

namespace Proov
{
    public partial class FormAddQuiz : Form
    {
        private readonly QuizService _quizService;
        public FormAddQuiz()
        {
            _quizService = new QuizService();
            InitializeComponent();
        }

        private void Btn_AddQuiz_Click(object sender, EventArgs e)
        {
            var quizName = txtbx_quizName.Text;

            var success = _quizService.AddQuiz("0003", quizName, "0001");
            Console.WriteLine(success ? "Quiz Successfully Added to Database" : "Error while adding Quiz to database");
        }

    }
}

