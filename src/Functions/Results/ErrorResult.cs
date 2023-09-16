using System;

namespace myApp
{
    public class ErrorResult<T> :Result<T>{

        public ErrorResult(string text, T data):base(false,text,data)
        {
            
        }

        public ErrorResult(T data):base(false,data)
        {
            
        }

        public ErrorResult():base(false)
        {
            
        }
    }
}