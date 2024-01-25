using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_1322
{
    internal class Quiz
    {
        private List<Question> QuizQuestions = new List<Question>();

        static int count = 0;
        public void AddQuestion()
        {
            QuizQuestions.Add(createQuestion()); // Method To Shorten Rewriting Code (Local to Class but using Question class as base)
        }

        public void removeQuestions()
        {
            if (QuizQuestions.Count <= 0) 
            {
                Console.WriteLine("Your quiz has no questions to remove");
                return;
            }
            else 
            foreach (Question q1 in QuizQuestions)
            {
                    Console.WriteLine(q1);
            }
            Console.WriteLine("Which question would you like to remove");
            for (int i = 0; i < QuizQuestions.Count; i++)
            {
                Console.WriteLine(i + QuizQuestions[i].getQuestionText());
            }
            int questionRemoved = Convert.ToInt32(Console.ReadLine());
            QuizQuestions.RemoveAt(questionRemoved);
        }

        public void ModifyQuestion()
        {
            if (QuizQuestions.Count <= 0)
            {
                Console.WriteLine("Your quiz has no questions to Modify");
                return;
            }
            else
                foreach (Question q1 in QuizQuestions)
                {
                    Console.WriteLine(q1);
                }
            Console.WriteLine("Which question would you like to Modify");
            for (int i = 0; i < QuizQuestions.Count; i++)
            {
                Console.WriteLine(i + QuizQuestions[i].getQuestionText());
            }

            int questionModify = Convert.ToInt32(Console.ReadLine());
            QuizQuestions.Insert(questionModify, createQuestion());
            // Got Confused Here added a Method to assist 
        }

        public void GiveQuiz()
        {
            int score = 0;
            for (int i = 0;i < QuizQuestions.Count+1;i++)
            {
                Console.WriteLine(i + QuizQuestions[i].getQuestionText());
                string userinput = Console.ReadLine();
                if (userinput == QuizQuestions[i].getQuestionText()) 
                {
                    Console.WriteLine("That is correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("That is incorrect");
                }
            }
        }



            private Question createQuestion()
            {
            Console.WriteLine("What will the Question ask?");
            string QuestionText = Console.ReadLine();
            Console.WriteLine("What is the Answer to this Question?");
            string QuestionAnswer = Console.ReadLine();
            Console.WriteLine("What is the Difficulty from (1-3)");
            int QuestionDifficulty = Convert.ToInt32(Console.ReadLine());
            return new Question(QuestionText, QuestionAnswer, QuestionDifficulty);
            }







            
    }
}

       

    

