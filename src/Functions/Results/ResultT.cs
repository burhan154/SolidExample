using System;

namespace myApp
{
    public class Result<T> : Result
    {
        public Result(bool success, string text, T data):this(success,data)
        {
            Text = text;
        }
        public Result(bool success, T data):this(success)
        {
            Data = data;
        }
        public Result(bool success) : base(success)
        {
            
        }

        public new T Data { get; set; }            
        protected override object GetValue() { return Data; }
        protected override void SetValue(object data) { Data = (T)data; }
    }
}