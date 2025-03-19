using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TennisSatisfaction.Model;

namespace TennisSatisfactionSurveySystem
{
    public class MySQLController
    {
        private MySqlConnection connection;
        string connectionString = "server=localhost;port=3306;user=root;password=aline;database=tennis";

        // Constructor
        public MySQLController()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Add a student to the database
        public bool AddStudent(Student student)
        {
            string query = "INSERT INTO students (name, gender, email, university, course_time) " +
                           "VALUES (@Name, @Gender, @Email, @University, @CourseTime)";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Gender", student.Gender);
                        cmd.Parameters.AddWithValue("@Email", student.Email);
                        cmd.Parameters.AddWithValue("@University", student.University);
                        cmd.Parameters.AddWithValue("@CourseTime", student.CourseTime);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: A" + ex.Message);
                    return false;
                }
            }
        }

        public int? GetStudentIdByEmail(string email)
        {
            string query = "SELECT student_id FROM students WHERE email = @Email";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : (int?)null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving student ID: " + ex.Message);
                    return null;
                }
            }
        }

        public List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();

            string query = "SELECT question_id, question_text, question_text_fr, question_type FROM questions";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Question question = new Question
                                {
                                    Id = reader.GetInt32("question_id"),
                                    QuestionText = reader.GetString("question_text"),
                                    QuestionText_fr = reader.GetString("question_text_fr"),
                                    QuestionType = reader.GetString("question_type")
                                };
                                questions.Add(question);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return questions;
        }

        public bool AddResponse(Student student, Response response, int questionId)
        {
            int? studentId = GetStudentIdByEmail(student.Email);
            if (studentId == null)
            {
                MessageBox.Show("Error: Student ID not found for email " + student.Email);
                return false;
            }

            string query = "INSERT INTO responses (student_id, question_id, answer) " +
                           "VALUES (@StudentId, @QuestionId, @Answer)";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        cmd.Parameters.AddWithValue("@QuestionId", questionId);
                        cmd.Parameters.AddWithValue("@Answer", response.Answer);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding response: " + ex.Message);
                    return false;
                }
            }
        }
        // Add a question
        public bool AddQuestion(string questionText, string questionTextFr, string questionType)
        {
            string query = "INSERT INTO questions (question_text, question_text_fr, question_type) " +
                           "VALUES (@QuestionText, @QuestionTextFr, @QuestionType)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@QuestionText", questionText);
                        cmd.Parameters.AddWithValue("@QuestionTextFr", questionTextFr);
                        cmd.Parameters.AddWithValue("@QuestionType", questionType);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding question: " + ex.Message);
                    return false;
                }
            }
        }
        //delete a question
        public bool DeleteQuestion(int questionId)
        {
            string query = "DELETE FROM questions WHERE question_id = @QuestionId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@QuestionId", questionId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting question: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable SearchByName(string name)
        {
            string query = $@"
        SELECT s.name, s.gender, s.university, s.course_time, q.question_text, r.answer 
        FROM students s
        JOIN responses r ON s.student_id = r.student_id
        JOIN questions q ON r.question_id = q.question_id
        WHERE s.name LIKE '%{name}%'";
            return ExecuteQuery(query);
        }

        public DataTable SearchByUniversity(string university)
        {
            string query = $@"
        SELECT q.question_text, r.answer, COUNT(r.answer) as Count
        FROM students s
        JOIN responses r ON s.student_id = r.student_id
        JOIN questions q ON r.question_id = q.question_id
        WHERE s.university = '{university}'
        GROUP BY q.question_text, r.answer";
            return ExecuteQuery(query);
        }

        public DataTable SearchByCourseTime(string courseTime)
        {
            string query = $@"
        SELECT q.question_text, r.answer, COUNT(r.answer) as Count
        FROM students s
        JOIN responses r ON s.student_id = r.student_id
        JOIN questions q ON r.question_id = q.question_id
        WHERE s.course_time = '{courseTime}'
        GROUP BY q.question_text, r.answer";
            return ExecuteQuery(query);
        }

        public DataTable SearchByGender(string gender)
        {
            string query = $@"
        SELECT q.question_text, r.answer, COUNT(r.answer) as Count
        FROM students s
        JOIN responses r ON s.student_id = r.student_id
        JOIN questions q ON r.question_id = q.question_id
        WHERE s.gender = '{gender}'
        GROUP BY q.question_text, r.answer";
            return ExecuteQuery(query);
        }

        public DataTable SearchAnswersByQuestion(string question)
        {
            string query = $@"
        SELECT s.name, s.gender, s.university, s.course_time, r.answer
        FROM students s
        JOIN responses r ON s.student_id = r.student_id
        JOIN questions q ON r.question_id = q.question_id
        WHERE q.question_text = '{question}'";
            return ExecuteQuery(query);
        }

        public DataTable GetQuestionsDataTable()
        {
            string query = "SELECT question_id AS 'ID', question_text AS 'Question (EN)', question_text_fr AS 'Question (FR)', question_type AS 'Type' FROM questions";
            return ExecuteQuery(query);
        }

        private DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetAllDistinctValues(string column, string table)
        {
            string query = $"SELECT DISTINCT {column} FROM {table}";
            return ExecuteQuery(query);
        }


    }
}
