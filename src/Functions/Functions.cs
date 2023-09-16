using System;

namespace myApp
{
public class Functions:Process{

        public Result<List<int>> EvenNumbers(){
            List<int> temp = new List<int>();
            foreach (int num in numberList)
            {
                if (num % 2 == 0)
                {
                    temp.Add(num);
                }
            }
            //Result<int> a = new SuccessResult<int>();
            return new SuccessResult<List<int>>("Even numbers:",temp); 
        }
        public Result<List<int>> OddNumbers(){
            List<int> temp = new List<int>();
            foreach (int num in numberList)
            {
                if (num % 2 != 0)
                {
                   temp.Add(num);
                }
            }
            return new SuccessResult<List<int>>("Odd numbers:",temp);
        }
        public Result<int> AverageNumbers(){
            int average = 0;
            foreach (int num in numberList)
            {
                average += num;
            }
            average /= numberList.Count;
            return new SuccessResult<int>("Average:",average);
        }
        public Result<List<int>> ThersholdNumbers() {
           
            int threshold = CO.ReadLineInt("Enter the threshold value: ");
            List<int> temp = new List<int>();
            foreach (int num in numberList)
            {
                if (num > threshold)
                {
                    temp.Add(num);
                }
            }
            return new SuccessResult<List<int>>("Numbers above:",temp);
        }
        public Result<bool> IsExist(){
            int numberToCheck = CO.ReadLineInt("Enter a number to check: ");
            bool exists = numberList.Contains(numberToCheck);
            return new SuccessResult<bool>("Numbers exists:",exists);
        }

    }
}