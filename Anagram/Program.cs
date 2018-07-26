using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
          int GetMaximumSubset(string[] words)
          {
            char[] charWord;
        
            string appendList = "";
            List<char> charList = new List<char>();
            List<string> SortedString = new List<string>();
            List<string> appendedList = new List<string>();
            for (int index=0;index<words.Length;index++)
            {
                charWord = words[index].ToCharArray();
                for (int nextIndex = 0; nextIndex < charWord.Length; nextIndex++)
                {
                    charList.Add(charWord[nextIndex]);
                }
                charList.Sort();
                foreach (char getChr in charList)
                {
                    appendList += getChr;
                }
                SortedString.Add(appendList);
                charList.Clear();
                appendList = "";
            }
            appendedList.Add(SortedString[0]);
             
                for(int j=1;j<SortedString.Count;j++)
                {
                    if(!appendedList.Contains(SortedString[j]))
                    {
                        appendedList.Add(SortedString[j]);
                    }
                }
             
            return appendedList.Count();

          }

            #region Testing code Do not change
            public static void Main(String[] args)
            {
                String input = Console.ReadLine();
                Program anagramSolver = new Program();
                do
                {
                    string[] words = input.Split(',');
                    Console.WriteLine(anagramSolver.GetMaximumSubset(words));
                    input = Console.ReadLine();
                } while (input != "-1");
            }
            #endregion
        }
    }
