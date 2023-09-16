using System;
using System.Collections.Generic;
using System.Text;

namespace myApp
{
    public interface IResult
    {
        bool Success { get; }
        object Data { get; }
        public string Text { get; }
    }
}
