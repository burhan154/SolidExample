using System;

namespace myApp
{
public class Operation{
        private Screen newScreen;
        private QuestionService questionService;
        public Operation(){

            questionService = new QuestionService(new Functions());

            OperationSettings();  

            newScreen = new Screen(questionService);        
        }
        public void Run(){
            newScreen.Start(); 
        }

        public void OperationSettings(){
            questionService.AddQuestion("Display all even numbers.",questionService.functions.EvenNumbers);
            questionService.AddQuestion("Display all odd numbers.",questionService.functions.OddNumbers);
            questionService.AddQuestion("Calculate the average of the numbers.",questionService.functions.AverageNumbers);
            questionService.AddQuestion("Display numbers above a certain threshold.",questionService.functions.ThersholdNumbers);
            questionService.AddQuestion("Check if a specific number exists in the array.",questionService.functions.IsExist);
        }

    }
}