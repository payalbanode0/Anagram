using System;


namespace ConsoleApp1
{
    public  class Program
    {
        public static bool areAnagram(string 1,string 2)
        { 
            int n1 = str1.count1;
            int n2 = str2.count2;
            if (n1!=n2)
            {
                return false;
            }
        }
        str1.Sort();
        str2.Sort();
            for (int i =0; i< n1; i++)
            if(str1[i]!=str2[i])
            {
            return false;
            }
       return true;
      public static void main (string[] args)
        {
            ArrayList str1 = new ArrayList();
            str1.Add('h');
            str1.Add('e');
            str1.Add('a');
            str1.Add('r');
            str1.Add('t');
            Arraylist.str2 = new ArrayList();
            str2.Add('e');
            str2.Add('a');
            str2.Add('r');
            str2.Add('t');
            str2.Add('h');
            if (areAnagram(str1.str2))
            {
                Console.WriteLine("the two strings are" + "anagram of each other");
            }
            else
            {
                Console.WriteLine("the two strings are not angram" + "angram of each other");
            }
        }
    }
} 


