using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace Proov.Services
{
    class QuizService
    {
        private int count = 0;
        public QuizService()
        {
            GetCount();
        }

        private bool GetCount()
        {
            throw new NotImplementedException();
        }
    }
        public bool AddQuiz(string QuizID, string QuizName, string TeacherID)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Proov.Properties.Settings.proovConnectionString"].ConnectionString))
                {
                    connection.Open();
                    
                    var cmd = new SqlCommand("INSERT INTO Quiz(quiz_id, quiz_name, teacher_id) VALUES(@QUIZ_ID, @QUIZ_NAME, @TEACHER_ID)", connection);
                    cmd.Parameters.AddWithValue("@QUIZ_ID", QuizID);
                    cmd.Parameters.AddWithValue("@QUIZ_NAME", QuizName);
                    cmd.Parameters.AddWithValue("@TEACHER_ID", TeacherID);
                    
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception);
                return false;
            }
        }

        public 

    }
}
