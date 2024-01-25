using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_1322
{
    internal class Question
    {
        private string questiontext;
        private string answer;
        private int difficulty;

        //Default
        public Question() 
        {
            questiontext = "TBD";
            answer = "TBD";
            difficulty = 0;      
        }
        //Overloaded
        public Question(string questiontext, string answer, int difficulty)
        {
            this.questiontext = questiontext;
            this.answer = answer;
            this.difficulty = difficulty;
        }
       
        // Get and Set Methods

        public string getQuestionText()
        { 
            return questiontext; 
        }
        public void setQuestionText(string setQuestion)
        {
            questiontext = setQuestion;
        }

        public string getAnswer() 
        {
            return answer;
        }
        public void setAnswer(string setAnswer)
        {
            answer = setAnswer;
        }

        public int getDifficulty() 
        { 
            return difficulty;
        }
        public void setDifficulty(int difficulty)
        {
            this.difficulty = difficulty;
        }

        
            
    }
}
