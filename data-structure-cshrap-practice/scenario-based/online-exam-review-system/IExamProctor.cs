using System;
using System.Collections.Generic;
using System.Text;

namespace online_exam_review_system
{
    internal interface IExamProctor
    {
        void VisitQuestion(int questionId);
        void SubmitAnswer(int questionId, string answer);
        void GoBack();
        int CalculateScore();
    }
}
