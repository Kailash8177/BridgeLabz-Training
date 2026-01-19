using System;
using System.Collections.Generic;
using System.Text;

namespace online_exam_review_system
{
    internal class Menu
    {
        private IExamProctor exam = new ExamUtility();
        public Menu()
        {
            ShowMenu();
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n===== Exam Proctor Menu =====");
                Console.WriteLine("1. Visit Question");
                Console.WriteLine("2. Submit Answer");
                Console.WriteLine("3. Go Back");
                Console.WriteLine("4. Submit Exam");
                Console.WriteLine("5. Exit");

                Console.Write("Choose option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Question ID: ");
                        exam.VisitQuestion(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("Enter Question ID: ");
                        int qid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Answer: ");
                        exam.SubmitAnswer(qid, Console.ReadLine());
                        break;

                    case 3:
                        exam.GoBack();
                        break;

                    case 4:
                        Console.WriteLine("Final Score: " + exam.CalculateScore());
                        return;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
