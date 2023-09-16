using System;

namespace myApp
{
public static class CO{
        
        //ConsoleOperation            
        
        public static string ReadLine(){
            return Console.ReadLine() ?? string.Empty;
        }
        public static string[] ReadLineArray(){
            return ReadLine().Split(',');;
        }

        public static List<int> ReadLineList(){
            return ReadLineArrayInt().ToList<int>();
        }
        public static int[] ReadLineArrayInt(){
            return Array.ConvertAll(ReadLineArray(), int.Parse);
        }

        public static int ReadLineInt(){
            var line = ReadLine();
            return int.Parse(line); 
        }

        public static int ReadLineInt(string text){
            Write(text);   
            return ReadLineInt(); 
        }
        public static void Write(string line){
            Console.Write(line);
        }
        public static void WriteLine(string line){
            Console.WriteLine(line);
        }
        public static void WriteLine(){
            WriteLine("");
        }
        
    }
}