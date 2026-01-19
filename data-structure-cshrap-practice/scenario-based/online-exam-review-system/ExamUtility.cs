using System;
using System.Collections.Generic;
using System.Text;

namespace online_exam_review_system
{
    internal class ExamUtility : IExamProctor
    {
        private Stack navigationStack;
        private Dictionary studentAnswer;
        private Dictionary correctAnswer;

        public ExamUtility()
        {
            navigationStack = new Stack(10);
            studentAnswer = new Dictionary(10);
            correctAnswer = new Dictionary(10);

            correctAnswer.Add(1, "A");
            correctAnswer.Add(2, "B");
            correctAnswer.Add(3, "C");
            correctAnswer.Add(4, "A");
            correctAnswer.Add(5, "B");
            correctAnswer.Add(6, "C");
            correctAnswer.Add(7, "A");
            correctAnswer.Add(8, "B");
            correctAnswer.Add(9, "C");
            correctAnswer.Add(10, "A");
        }
        public void VisitQuestion(int quesId)
        {
            navigationStack.Push(quesId);
            Console.WriteLine("Visited Question " + quesId);
        }

        public void SubmitAnswer(int questionId, string answer)
        {
            studentAnswer.Add(questionId, answer);
            Console.WriteLine("Answer saved");
        }

        public void GoBack()
        {
            if (!navigationStack.IsEmpty())
            {
                Console.WriteLine("Back from Question " + navigationStack.Pop());
            }
            else
            {
                Console.WriteLine("No previous question");
            }
        }
        public int CalculateScore()
        {
            int score = 0;

            for (int i = 0; i < studentAnswer.Count(); i++)
            {
                int qid = studentAnswer.GetKeyAt(i);
                string studentAns = studentAnswer.GetValueAt(i);
                string correctAns = correctAnswer.Get(qid);

                if (studentAns != null && studentAns == correctAns)
                    score++;
            }
            return score;
        }
    }
}
