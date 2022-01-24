using System;
using System.Collections.Generic;
using System.Linq;

namespace LLDuplicates
{
    public class Program
    {
        //just to show all linkedlist items
        static void showItems(LinkedList<char> list)
        {
            foreach (char i in list)
            {
                Console.Write(i + " ");
            }
        }

        //gets the duplicates
        public LinkedList<char>  DuplicateValues(LinkedList<char> list)
        {
            int currentIndex = 0;
            int count = 1;
            List<char> values = new List<char>();
            
            List<char> myList = new List<char>(list);
           

            char[] myArr = myList.ToArray();


            if (myArr.Length < 3)
            {
                LinkedList<char> tmpdata = new LinkedList<char>(myArr);
                /*foreach (char i in myArr)
                {
                    Console.Write(i + " ");
                }*/
                return tmpdata;
            }

            values.Add(myArr[0]);
            
            for (int i = 1; i < myArr.Length; i++)
            {
                int countJump = 0;
                if (myArr[i] != myArr[currentIndex])
                {
                    myArr[++currentIndex] = myArr[i];
                    count = 0;
                    foreach (var item in values)
                    {
                        if (item == myArr[i])
                        {
                            countJump++;
                        }
                            
                    }
                    if (!(countJump >= 2))
                    {
                        values.Add(myArr[i]);
                    }
                    
                }
                else if (count < 1)
                {  
                    myArr[++currentIndex] = myArr[i];
                    values.Add(myArr[i]);
                }
                count++;
            }
             ;

           // Console.WriteLine("\n LinkdList After Duplicates have been removed :");
            LinkedList<char> tmp = new LinkedList<char>(values);
           /*foreach (char i in tmp)
            {
                Console.Write(i + " ");
            }*/
            return tmp;
        }

        public static void Main(String[] args)
        {
            LinkedList<char> linkedlist = new LinkedList<char>();
            linkedlist.AddFirst('E');
            linkedlist.AddLast('B');
            linkedlist.AddLast('E');
            linkedlist.AddLast('E');
            linkedlist.AddLast('B');
            linkedlist.AddLast('A');
            linkedlist.AddLast('B');

            Console.WriteLine("Before removing duplicates :");
            showItems(linkedlist);
            Program prog = new Program();
            prog.DuplicateValues(linkedlist);


        }
    }
}
