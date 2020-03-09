using System;
using System.Data.SqlClient;

namespace Proov.Services
{
    internal class QuizService
    {
        private readonly SqlService _sqlService;
        public int Count { get; private set; }

        public QuizService()
        {
            _sqlService = new SqlService();
            Count = GetCount();
        }

        private int GetCount()
        {
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Quiz");

            try
            {
                return Count = (int) _sqlService.RunScalar(cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool AddQuiz(string quizId, string quizName, string teacherId)
        { 
            var cmd = new SqlCommand("INSERT INTO Quiz(quiz_id, quiz_name, teacher_id) VALUES(@QUIZ_ID, @QUIZ_NAME, @TEACHER_ID)");
                    
            cmd.Parameters.AddWithValue("@QUIZ_ID", quizId);
            cmd.Parameters.AddWithValue("@QUIZ_NAME", quizName);
            cmd.Parameters.AddWithValue("@TEACHER_ID", teacherId);

            try
            {
                _sqlService.RunNonQuery(cmd);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
