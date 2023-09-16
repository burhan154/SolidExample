using System;

namespace myApp
{
public class Question{
        private string text;
        private int id;
        private Func<Result> function;
        private Result result;
        public Question(string text, int id, Func<Result> function)
        {
            this.text = text;
            this.id = id;
            this.function = function;
            //result = new Result<int>(false);
        }
        public string GetText()
        {
            return text;
        }
        public int GetId()
        {
            return id;
        }

        private string ConvertToString(object obj){
            Type type = obj.GetType();
            
            if(type == typeof(List<int>)){
                string text ="";
                foreach (var item in (List<int>)obj)
                {
                    text += item.ToString()+",";
                }
                return text;
            }
            else if(type == typeof(int)){
                return (int)obj+"";
            }
            else if(type == typeof(bool)){

                return (bool)obj +"";
            }
            return "type not found";
        }
        public string GetAnswer()
        {
            if(result == null)
                result = function();

            string a = ConvertToString(result.Data);
            return result.Text+" "+ a;
        }
    }
}