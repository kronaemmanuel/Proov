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
            var quizId = _quizService.Count + 1;
            const string teacherId = "0001";

            var success = _quizService.AddQuiz(quizId.ToString(), quizName, teacherId);

            Console.WriteLine(success ? "Quiz Successfully Added to Database" : "Error while adding Quiz to database");
        }
    }
}

