using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Linq;
using System.IO;//Csv file
using System.Text;//Csv file 
namespace javakar
{
    public class Codewars
    {
        //Convert string to camel case;
        public void str1()
        {
            string answer = "";
            string a = "the-name-javakar";
            string[] d = a.Replace("-", " ").Replace("_", " ").Split(' ');

            for (int i = 0; i < d.Length; i++)
            {
                if (i != 0)
                {
                    string k = d[i];
                    string h = k[0].ToString().ToUpper() + k.Substring(1);
                    answer += h;
                }
                else
                {
                    answer += d[i];
                }

            }
            Console.WriteLine(answer);

            Console.ReadLine();

        }
        /*Given a non-empty array of integers,
        return the result of multiplying the values together in order.*/
        public void Mul()
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            int m = a.Length;
            int result = 1;
            for (int i = 0; i < m; i++)
            {
                result *= a[i];
            }
            Console.WriteLine(result);
        }
        /*Write a function that accepts an array of 10 integers (between 0 and 9),
          that returns a string of those numbers in the form of a phone number.*/
        public void Phonenumber()
        {
            int[] number = new int[] { 7, 5, 5, 8, 1, 0, 9, 0, 0, 2 };
            string strnum = "";
            for (int i = 0; i < number.Length; i++)
            {
                strnum += number[i].ToString();
            }
            strnum = strnum.Insert(0, "(");
            strnum = strnum.Insert(4, ")");
            strnum = strnum.Insert(5, " ");
            strnum = strnum.Insert(9, "-");
            Console.WriteLine(strnum);
            Console.ReadLine();
        }
        //Ascending and Decending;
        public void Ascendingdecending()
        {
            int[] x = new int[] { 2, 4, 6, 5, 1, 7 };
            List<int> list1 = new List<int>();//using System.Collections.Generic; creating the list;

            Array.Sort(x);//Sorting the Array;
            foreach (int i in x)
            {
                list1.Add(i);
            }
            int[] x1 = x;
            List<int> list2 = new List<int>();//using System.Collections.Generic;creating the list;
            Array.Reverse(x1);
            foreach (int i in x1)
            {
                list2.Add(i);
            }
            for (int i = 0; i < x1.Length; i++)
            {
                Console.WriteLine(list2[i]);
                Console.WriteLine(list1[i]);
            }

        }
        //You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
        public void Ascendingodd()
        {
            int[] inp = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            List<int> list = new List<int>();
            List<int> ind = new List<int>();
            List<int> ans = new List<int>();
            for (int i = 0; i < inp.Length; i++)
            {
                if (inp[i] % 2 != 0)
                {
                    list.Add(inp[i]);
                    ind.Add(Array.IndexOf(inp, inp[i]));//Finding index of an Array;
                }
                else
                    ans.Add(inp[i]);
            }
            list.Sort();//Sorting the List;
            for (int i = 0; i < list.Count; i++) //For finding the length of the list,we use (Count) ; 
            {
                ans.Insert(ind[i], list[i]);//For Replace the output into same index;
            }
            for (int i = 0; i < ans.Count; i++)//To print the List,we must use For Loop;
                Console.WriteLine(ans[i]);
        }


        //If the number has an integer square root, take this, otherwise square the number.
        public void Sqroot() // To Square Root or Not to square;
        {
            int[] inps = new int[] { 4, 3, 9, 7, 2, 1 };
            int[] inps2 = new int[] { 2, 3 ,7,10,5,6,8};//Square Root Starting Number
            List<int> ans = new List<int>();
            List<int> ans3 = new List<int>();
            List<int> ind = new List<int>();
            for (int i = 0; i < inps.Length; i++)
            {
                  if (inps[i]!=2&& inps[i]!=3 && inps[i]!=5 && inps[i] != 6 && inps[i] != 7 && inps[i] != 10 && inps[i] != 8)
                  {
                    var ans2 = Math.Sqrt(inps[i]);
                    ans.Add((int)ans2);
                  }
            }
            for(int i =0; i<inps.Length;i++)
            {

                if (inps[i]== 2 || inps[i]==3 || inps[i] == 5 || inps[i] == 6 || inps[i] == 7 || inps[i] == 10 || inps[i] == 8)
                {
                    ind.Add(Array.IndexOf(inps, inps[i]));
                    int ans1 = inps[i] * inps[i];
                    ans3.Add(ans1);
                }
            }
            for (int i = 0; i < ans3.Count; i++) //For finding the length of the list,we use (Count) ; 
            {
                ans.Insert(ind[i], ans3[i]);
            }
            for (int n = 0; n < ans.Count; n++)
            {
                Console.WriteLine(ans[n]);
            }
        }
                
                    
        
        /*Write a code that receives an array of numbers or strings, goes one by one through it while taking one value out,
        leaving one value in, taking, leaving, and back again to the beginning until all values are out.*/
        public void Yesno()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> ans1 = new List<int>();
            List<int> ans2 = new List<int>();
            List<int> ans3 = new List<int>();
            List<int> ans4 = new List<int>();
            List<int> ans = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                ans1.Add(i);
            }
            for (int i = 0; i < ans1.Count; i++)
            {
                if (ans1[i] % 2 == 0)
                {
                    ans2.Add(arr1[ans1[i]]);
                }
                else
                {
                    ans3.Add(arr1[ans1[i]]);
                }
            }
            for (int i = 0; i < ans3.Count; i++)
            {
                if (ans1[i] % 2 == 0)
                {
                    ans4.Add(ans3[ans1[i]]);
                }
                else
                {
                    ans.Add(ans3[ans1[i]]);
                }
            }
             ans4.AddRange(ans);//To Combine two List;
             ans2.AddRange(ans4);
             for(int j = 0; j < ans2.Count; j++)
             {
                Console.WriteLine(ans2[j]);
             }
        }
        //Find the number in the  Array is multiple by its Index or not; 
        public void Multiindex() // Multiple of index;
        {
            int [] mul = new int[] { -56, -85, 72, -26, -14, 76, -27, 72, 35, -21, -67, 87, 0, 21, 59, 27, -92, 68 };
            List<int> ind = new List<int>();
            List<int> ans = new List<int>();
            for (int i = 0; i < mul.Length; i++)
                ind.Add(i);
            for(int i = 0; i < mul.Length-1; i++)
            {
                int a = ind[i+1];
                int b=mul[i+1];
                if (b % a==0) //This helps to find whether number is Multiple by its own index; 
                {
                    ans.Add(mul[i+1]);
                }
            }
            ans.ForEach(Console.WriteLine);//To print the list in single step;
        }


        //Remove the duplicates from a list of integers, keeping the last(rightmost ) occurrence of each element.
        public void Duplicate()
        {
            int[] num = new int[] { 3, 4, 4, 3, 6, 3 };
            List<int> ans = new List<int>();
            num = num.Union(num).ToArray();//To Remove the Duplicate Element;
            for(int i = 0; i < num.Length; i++)
            {
                ans.Add(num[i]);
            }
            ans.ForEach(Console.WriteLine);
            Console.ReadLine(); 
        }
        //Descending Order;
        //Converting int type as Decending Order;
        public void Intdec()
        {
            int num = 42145;
            string num1 = num.ToString();
            List<string> list = new List<string>();
            foreach (char i in num1)
            {
                string str = i.ToString();
                list.Add(str);
            }
            list.Sort();
            list.Reverse();
            string ans = "";
            for (int i = 0; i < list.Count; i++)
            {
                ans += list[i];
            }
            int.TryParse(ans, out num);
            Console.WriteLine(num);
        }
        /*Mumbling
        accum("abcd") -> "A-Bb-Ccc-Dddd"
        accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
        accum("cwAt") -> "C-Ww-Aaa-Tttt"*/
        public void Mumbling()
        {
            string mum = "RqaEzty";
            List<string> list = new List<string>();
            List<string> ans1 = new List<string>();
            foreach (char c in mum)
            {
                string str = c.ToString();
                list.Add(str);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                {
                    ans1.Add("-");
                }
                int loop = i + 1;
                string str1 = list[i];
                string check = "";
                for (int j = 0; j < loop; j++)
                {
                    if (j == 0)
                    {
                        string n = str1.ToString().ToUpper();
                        check = n;
                        ans1.Add(n);
                    }
                    else if (str1 == check)
                    {
                        ans1.Add(str1.ToString().ToLower());
                    }
                    else
                    {
                        ans1.Add(str1);
                    }
                }
                check = "";
            }
            string str2 = "";
            for (int k = 0; k < ans1.Count; k++)
            {
                str2 += ans1[k];
            }
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
           
