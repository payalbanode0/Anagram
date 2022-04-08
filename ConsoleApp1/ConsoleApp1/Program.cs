using System;


namespace ConsoleApp1
{
    public  class Program
    {
        public static void Main() 
        { 
            string str1="heart";
            string str2="earth";
            if (n1!=n2)
            char[] ch1=str1.ToLower().ToCharArray();
            char[] ch2=str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1=new string(ch1);
            string val2=new string(ch2);
            if(val1== val2)
            {
                Console.WriteLine("the two strings are" + "anagram of each other");
            }
            else
            {
                Console.WriteLine("the two strings are not angram" + "angram of each other");
            }
        }
    }
 


