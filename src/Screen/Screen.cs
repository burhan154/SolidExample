using System;

namespace myApp
{
public class Screen{
        
        private QuestionService questionService;

        public Screen(QuestionService questionService){
            this.questionService = questionService;       
        }    
        public void Start(){
            
            while(true) {
                
                foreach (var question in  questionService.GetQuestionList())
                {
                    CO.WriteLine(question.GetId()+". " + question.GetText());    
                }
                CO.WriteLine(questionService.Count()+". Exit.");
                CO.Write("Please select an operation:");

                int selected = CO.ReadLineInt();

                if(selected<questionService.Count()){
                    CO.WriteLine(questionService.GetQuestion(selected).GetAnswer());
                    //questionService.GetQuestion(selected).GetAnswer().Message.ToString();
                }
                else if(selected==questionService.Count()){
                    Environment.Exit(0);
                }
                CO.WriteLine();
            }
        }

    }
}