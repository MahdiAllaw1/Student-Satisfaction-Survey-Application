using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisSatisfaction.Model;
using TennisSatisfactionSurveySystem;

namespace TennisSatisfaction.Controller
{
    public class QuestionController
    {
        private MySQLController sqlController;
        private List<Question> questionList;
        private int currentQuestionIndex;

        public QuestionController()
        {
            sqlController = new MySQLController();
            questionList = sqlController.GetQuestions();
            currentQuestionIndex = 0;
        }

        public int GetNumberOfQuestions()
        {
            return questionList.Count;
        }

        public Question GetNextQuestion()
        {
            if (questionList.Count == 0 || currentQuestionIndex == questionList.Count)
            {
                return null;
            }

            // Get the next question
            Question nextQuestion = questionList[currentQuestionIndex];

            // Update the index (loop back to the start if needed)
            currentQuestionIndex++;

            return nextQuestion;
        }
    }

}
