using System;
using System.Windows.Forms;
using Proov.Services;

namespace Proov
{
    // TODO: implement MessageHandling error handling service
    public partial class FormAddQuiz : Form
    {
        private readonly QuizService _quizService;
        private readonly RandomService _randomService;

        public FormAddQuiz()
        {
            _quizService = new QuizService();
            _randomService = new RandomService();
            InitializeComponent();
        }

        private void Btn_AddQuiz_Click(object sender, EventArgs e)
        {
            var quizName = txtbx_quizName.Text;
            var quizId = _randomService.GetRandomString(8);
            const string teacherId = "0001";

            var success = _quizService.AddQuiz(quizId, quizName, teacherId);

            Console.WriteLine(success ? "Quiz Successfully Added to Database" : "Error while adding Quiz to database");
        }
    }
}

