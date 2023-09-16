using System;

namespace myApp
{
    public class QuestionService{
        private List<Question> questions = new List<Question>();
        public Functions functions;
  
        public QuestionService(Functions functions){
            this.functions = functions;
        }
        // public void AddQuestion(string question, Func<object> function ){
        //     questions.Add(new Question(question, Count(), function));
        // } 

        public void AddQuestion(string question, Func<Result> function ){
            questions.Add(new Question(question, Count(), function));
        }       
        public int Count(){
            return questions.Count();
        }
        public Question GetQuestion(int index){
            return questions[index];
        }
        public List<Question> GetQuestionList(){
            return questions;
        }
    }
}