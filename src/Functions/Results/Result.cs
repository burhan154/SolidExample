using System;

namespace myApp
{
   public abstract class Result : IResult
    {
       public Result(bool success, string text, object data):this(success,data)
        {
            Text = text;
        }
        public Result(bool success, object data):this(success)
        {
            Data = data;
        }
        public Result(bool success)
        {
            Success = success;
            Text = "";
            //Data = default(T);
            //Data = new T();
        }
        public bool Success { get; set; }
        public string Text { get; set; }
        public object Data
        {
            get { return GetValue(); }
            set { SetValue(value); }
        }
        protected abstract object GetValue();
        protected abstract void SetValue(object value);
    }
}