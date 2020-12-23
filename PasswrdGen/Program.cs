using System;
namespace C_
{
    class Program
    {
        static string input;
        static void Main(string[] args)
        {
            input = Console.ReadLine();
            GeneratePasswrds(input);
            
        }
        static void GeneratePasswrds(string input){
            var passwrdChars = input.ToCharArray();
            char replaceChr = ' ';
            char oldChr = ' ';
            string currPasswrd = "";
           do{
                for(int j=0;j<passwrdChars.Length-1; j++){
                    oldChr = passwrdChars[j];
                    replaceChr = passwrdChars[j+1];
                    passwrdChars[j] = replaceChr;
                    passwrdChars[j+1] = oldChr;
                    currPasswrd =  PasswrdCompare(passwrdChars);
                    if(input.Equals(currPasswrd)){
                        continue;
                    }
                    PrintArrayElements(passwrdChars);
                }
        } while(!input.Equals(currPasswrd));
        }
        static void PrintArrayElements(char[] chrArray){
        foreach(char element in chrArray){
            Console.Write(element);
        }
        Console.WriteLine();
    }
    static string PasswrdCompare(char[] chrArray){
        string comparatorPass = "";
        foreach(char chr in chrArray){
            comparatorPass+=chr;
        }
        return comparatorPass;
    }
    }
}
