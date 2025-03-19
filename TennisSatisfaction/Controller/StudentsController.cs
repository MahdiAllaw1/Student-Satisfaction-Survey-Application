using System;
using System.Collections.Generic;
using System.Linq;
using TennisSatisfaction.Model;
using TennisSatisfactionSurveySystem;

namespace TennisSatisfaction.Controller
{
    public class StudentController
    {
        private readonly MySQLController controller;
        public Student CurrentStudent { get; set; }

        public StudentController()
        {
            controller = new MySQLController();
        }

        // Add a single student to the list (but not to the database yet)
        public void AddStudent(Student student)
        {
            CurrentStudent = student;
        }

        // Save all students from the list to the database
        public void SaveAllStudentsToDatabase()
        {
            controller.AddStudent(CurrentStudent);

            int questionId = 1; // Start with question 1

            foreach (Response res in CurrentStudent.Responses)
            {
                controller.AddResponse(CurrentStudent, res, questionId);
                questionId++; // Increment for the next response
            }

            CurrentStudent.Responses.Clear(); // Clear the list after saving

        }

    }
}
