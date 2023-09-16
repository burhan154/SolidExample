using System;
using System.Collections;

namespace myApp
{
public class Process{
        //protected int[] numbers;
        protected List<int> numberList = new List<int>();

        public List<int> ReadNumbers(){
            CO.WriteLine("Please write numbers(separated by commas):");
            return CO.ReadLineList();
        }
        public List<int> getNumbers(){
            return numberList;
        }
         public Process(){
            this.numberList = ReadNumbers();
        }
        public Process(List<int> numbers){
            this.numberList = numbers;
        }
        

    }
}