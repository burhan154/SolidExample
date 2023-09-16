using System;

namespace myApp
{
    public class SuccessResult<T> :Result<T>{

        public SuccessResult(string text, T data):base(true,text,data)
        {
            
        }

        public SuccessResult(T data):base(true,data)
        {
            
        }

        public SuccessResult():base(true)
        {
            
        }
    }
}