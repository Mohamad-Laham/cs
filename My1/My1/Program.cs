using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace My1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("enter 2 numbers :");
            //int num1=int.Parse(Console.ReadLine());
            //int num2=int.Parse(Console.ReadLine());
            //Console.WriteLine($"the final answer is :{SumNumbers(num1, num2)}");

            //Console.WriteLine("enter 2 strings: ");
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //Console.WriteLine(Stringthings(str1,str2));

            //Console.WriteLine("enter string: ");
            //string enter = Console.ReadLine();
            //// int n=enter.Length;
            // reverse(enter);
            // Plindrom();
            //  Reverse(enter);
            //string[] websites = { "Google", "Facebook", "Twitter", "Instagram", "YouTube" };

            //int i = 0;

            //while (i < websites.Length)
            //{
            //    // Only output those sites with an 'o' in their name
            //    if (websites[i].Contains("o"))
            //    {
            //        Console.WriteLine(websites[i]);
            //    }
            //    i++;
            //}
            //Savestrings();
            //  Getstrings();
            //String[] arr = { "GeeksforGeeks", "I", "from", "am" };
            string[] arr = { "Geek", "kk", "bs", "Geek", "kk" };
            //string[] arr = { "def", "ll", "ww", "ll" };
            //  int n = arr.Length;
            //Findiftowstrings(arr, n);
            // sort(arr, n);
            // Deletstrings(arr, n);
            //printArraystring(arr, n);
            // int[] arr = {10,7,6,3,15}; 
            //   Console.WriteLine("enter "); 
            //int n=arr.Length;   
            //checkifbigger(arr,n);   
            //printint(arr,n);
            // qustion();

            // rehalfnumbers();
            //  enternumbers();
            //Fibonacci();
            //oodNumbers(); return to it 
            // multiplynumpers();
            // ForceNumbers();
            // RandomNumber();
            // Printnumbers();
            // Plindromenumbers();
            // Counter();
            //int n = 5;
            //string[] arr2 = new string[5];
            // AddString(arr2, 5);
            //ReserveNumber();
            // Makesomthing();
            //  Armstrong();
            //  Parentheses();
            ///////////////////////// Workhome
            //BaseNumbers();
            //SumAver();
            // MakeChanges();
            // Oddnumbers();
            //  ConvertChar();
            ///////////////////////// Workhome

            //Console.WriteLine("Enter number: ");
            //int num=int.Parse(Console.ReadLine());
            //while( num < 99) {
            //    Console.WriteLine("Eror!! you need to enter 3 digits:");
            //    num = int.Parse(Console.ReadLine());
            //}
            //if (num >= 1000) { Console.WriteLine(num+"  your pasword is good"); }
            //else
            //{
            //    UpdatePasword(num);
            //}

            // string x = ".",y="l",d="t",e="T";

            //// double newx=Convert.ToDouble(x);
            //// Console.WriteLine(x); 
            // List<string> list = new List<string>();
            // list.Add(x);
            // list.Add(y);
            // list.Add(d);
            // list.Add(e);
            // list.Reverse();
            // list.Remove(list[0]);
            // list.Reverse();
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            //int x = 8;
            //double y = 4 / 5; //0.02;
            //double z = x * y;
            //Console.WriteLine(y);
            //double value1 = .333333333333333;
            //double value2 = 1.0 / 3;
            //int precision = 7;
            ////value1 = Math.Round(value1, precision);
            ////value2 = Math.Round(value2, precision);
            //Console.WriteLine("{0:R} = {1:R}: {2}", value1, value2, value1.Equals(value2));
            ChckNumberType();
            string ae = "fb7w3r63148@#@@@$";
            string t = "23645";
        }






        static int SumNumbers(int x, int y)
        {
            int z = x + y;
            if (x == y)
            {
                return z * x;
            }
            return z;
        }
        static string Stringthings(string num1, string num2)
        {
            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    if (num1.Length != num2.Length)
                    {
                        return num1 + num2;
                    }
                }
            }
            return num2;
        }

        static void Plindrom()//return is important
        {
            Console.WriteLine("enter string: ");
            string str12 = Console.ReadLine();
            string str1 = str12;
            //int i = 0, j = str12.Length - 1;
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    for (int j = str12.Length - 1; j >= 0; j--)
            //    {
            //        if (i == j)
            //        {
            //            Console.WriteLine("true");
            //        }
            //        else { Console.WriteLine("false"); }
            //        i++;
            //        j--;
            //    }
            //}
            reverse(str1);
            int x = str12.Length - 1;
            for (int i = 0; i < str1.Length; i++, x--)
            {
                if (str1[i] == str12[x])
                {
                    Console.WriteLine("it is plindrom");
                }
                else { Console.WriteLine("it is not plindrom"); }
            }

        }


        //while (i < str1.Length && j > 0)
        //{
        //    if (str1[i] == str12[j])
        //    {
        //        Console.WriteLine("it is plindrome");
        //    }
        //    else { Console.WriteLine("it is not"); }
        //    i++;
        //    j--;

        ///}

        static void Getstrings()
        {
            int x; List<string> list = new List<string>();
            Console.WriteLine("enter how many strings do you want to add");
            x = int.Parse(Console.ReadLine()); Console.WriteLine("enter a string:");
            while (x > 0)
            {
                list.Add(Console.ReadLine()); x--;
            }
            foreach (string str in list) { Console.WriteLine(); Console.WriteLine(str); }

        }
        static void sort(String[] s, int n)
        {
            //String[] arr = { "GeeksforGeeks", "I", "from", "am" };
            for (int i = 1; i < n; i++)
            {
                String temp = s[i];

                // Insert s[j] at its correct position
                int j = i - 1;
                while (j >= 0 && temp.Length < s[j].Length)
                {
                    s[j + 1] = s[j];
                    j--;
                }
                s[j + 1] = temp;
            }
        }

        static void printArraystring(string[] str, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(str[i] + " ");
        }
        static void printint(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        static void Deletstrings(string[] s, int n)
        {
            //   string[] arr = { "Geek", "kk", "bs", "Geek", "kk" };
            List<string> list = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]);
            }
            //foreach (string sdr in list)
            //{
            //    Console.WriteLine(sdr);
            //    Console.WriteLine();
            //}
            int j = 1;
            for (int i = 0; i < s.Length; i++)
            {
                string temp = s[i];
                while (j < s.Length)
                {
                    if (s[j] == temp)
                    {
                        list.Remove(s[j]);
                    }
                    j++;
                }
                j = i + 2;
            }
            foreach (string h in list)
            {
                Console.WriteLine(h);
            }

        }
        static void checkifbigger(int[] N, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = N[i];
                int j = i - 1;
                while (j >= 0 && N[j] > temp)
                {
                    N[j + 1] = N[j];
                    j--;
                }
                N[j + 1] = temp;
            }
        }
        static bool Findiftowstrings(string[] str, int n)
        {
            //  string[] arr = { "def", "ll", "ww", "ll" };
            //find if there is 2 strings are equal in array strings 
            for (int i = 0; i < n; i++)
            {
                string temp = str[i];
                int j = i + 1;
                while (j < n && str[j] != temp)
                {
                    bool c = str[j] == temp ? true : false;
                    j++;
                    return c;
                }
            }
            return false;
        }
        static void reverse(string str)
        {
            char[] arr = str.ToCharArray();
            int n = str.Length - 1;
            for (int i = 0; i < n; i++, n--)
            {
                char r = str[i];
                arr[i] = str[n];
                arr[n] = r;
            }
            Console.WriteLine(arr);
        }
        static void Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            //  return reverse;
            Console.WriteLine(reverse);
        }
        static void rehalfnumbers()
        {
            int n = 0;
            int t = 3;
            int temp = n;
            n = t;
            t = temp;
            Console.WriteLine(n);
            Console.WriteLine(t);
        }
        static void enternumbers()
        {
            Console.WriteLine("enter number to get");
            int n = int.Parse(Console.ReadLine());
            int i = 0, j = 0;
            while (n >= i)
            {
                if (i == 7)
                {
                    i++;
                }
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("enter another numbers to get ");
            int x = int.Parse(Console.ReadLine());
            while (x >= j)
            {
                if (j % 7 == 0 && j % 3 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
        }

        static void Fibonacci()
        {
            int y = 1, x = 0, z;
            while (144 >= x)
            {
                z = x + y;
                x = z;
                int n = x + y;
                y = n;
                Console.WriteLine(x);
                Console.WriteLine(n);
            }
        }
        static bool oodNumbers()
        {
            int n, i = 1;
            List<int> list = new List<int>();
            Console.WriteLine("enter number to check if it is an ood number or not");
            n = int.Parse(Console.ReadLine());
            while (n >= i)
            {
                list.Add(i);
                i++;
            }
            foreach (int x in list)
            {
                if (n % x == 0) { Console.WriteLine("true"); return true; }
                Console.WriteLine("false");
            }
            return true;
        }

        static void multiplynumpers()//עצרת
        {
            Console.WriteLine("enter number to get his multiply");
            int n = int.Parse(Console.ReadLine());
            int x = 1, i = 1;
            int temp = x * i;
            while (i < n)
            {
                i++;
                temp = temp * i;
            }
            Console.WriteLine(temp);
        }
        static void ForceNumbers()//חזקה
        {
            Console.WriteLine("enter 2 numbers to get the multiply");
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int temp = x;
            for (int i = 1; i < n; i++)
            {
                x = x * temp;
            }
            Console.WriteLine(x);
        }
        static void RandomNumber()//מספר רנדומאלי
        {
            Random random = new Random();
            Console.WriteLine("enter number to check if it is correct or not, you have just 4 times to check");
            int n = int.Parse(Console.ReadLine());
            int ran = random.Next(1, 11);
            int x = 4;
            while (x > 0)
            {
                if (ran == n)
                {
                    Console.WriteLine("it is correct");
                    Console.WriteLine("the game is over, thank you for playing");
                    return;
                }
                else
                {
                    Console.WriteLine("try again");
                    n = int.Parse(Console.ReadLine());
                    x--;
                }
                if (x == 1)
                {
                    Console.WriteLine("sorry you loose");
                    return;
                }
            }
        }
        static void Printnumbers()
        {
            int x = 10;
            int i = 9;
            while (x > 0 && x % 2 == 0 && i % 2 != 0)
            {
                Console.WriteLine(x * (-1));
                Console.WriteLine(i);
                x = x - 2;
                i = i - 2;
            }
        }

        static void Plindromenumbers()
        {
            Console.WriteLine("enter number to chek if it is an plindrome number or not");
            int x = int.Parse(Console.ReadLine());
            int y = x % 1000;
            int z = y % 100;
            int q = z % 10;
            int w = z % 1;
            if (y == w && z == q) { Console.WriteLine("it is Plindrome"); }
            else { Console.WriteLine("it is not Plindrome"); }
        }

        static void Counter()
        {
            int x, counter = 0;
            bool flag = true; List<string> list1 = new List<string>();
            while (flag)
            {
                Console.WriteLine("enter names");
                string names = Console.ReadLine();
                list1.Add(names);
                Console.WriteLine("enter 1 to continue or 2 to stop");
                x = int.Parse(Console.ReadLine());
                if (x == 1) { flag = true; }
                if (x == 2) { flag = false; }
            }
            string n = null;
            foreach (string name in list1)
            {

                if (name == n) { counter++; }
                n = name;
            }
            if (counter < 1) { Console.WriteLine("there is no Equal names in the list"); }
            if (counter >= 1) { Console.WriteLine("ther is Equal name in the list"); }
        }
        static void AddString(string[] arr, int n)
        {
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            int i = 0;
            for (; i < n; i++)
            {
                if (arr[i] == null) { break; }
            }
            if (i < n) { arr[i] = name; }
            foreach (string nam in arr)
            {
                Console.WriteLine(nam);
            }
        }
        static void ReserveNumber()
        {
            Console.WriteLine("Enter number under 10000:");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int n1 = n / 1000;//3
            n = temp;
            int n2 = n / 100 % 10 * 10;//4
            int n3 = (n % 100) / 10 * 100;
            int n4 = n % 1000 % 100 % 10 * 1000;
            Console.WriteLine(n1 + n2 + n3 + n4);
        }

        static void UpdatePasword(int number)
        {
            int sum = 0, newNumber = 0;
            int temp = number;
            int x = number / 100;
            number = temp;
            int y = number % 100 / 10;
            int z = number % 100 % 10;
            if (y > z && y < x) { sum = z + x; }//z<y<x=>x+z
            if (x < y && z > y) { sum = x + z; }//x<y<z=>z+x
            if (y < z && x > z) { sum = x + y; }//y<z<x=>x+y 
            if (x < z && y > z) { sum = x + y; }//x<z<y=>x+y
            if (y < x && z > x) { sum = y + z; }//y<x<z=>y+z
            if (z < x && y > x) { sum = z + y; }//z<x<y=>y+z
            if (sum < 10 && sum > 0)
            {
                newNumber = sum + number * 10;
            }
            else { if (sum > 10) { newNumber = sum + number * 100; } }
            Console.WriteLine("the sum of 2 digits that we nee to add is: " + sum);
            Console.WriteLine("the new number is: " + newNumber);
        }

        static void Makesomthing()
        {
            int x = 1, i = 1;
            for (; i < 10; i++)
            {
                Console.WriteLine(" ");
                for (; x <= 10; x++)
                {
                    Console.WriteLine(x);
                }
            }
        }

        static void Armstrong()
        {
            Console.WriteLine("Enter number to check if it is an armstrong number:");
            string arm = Console.ReadLine();
            int newarm = Int32.Parse(arm);
            //int x = newarm / 100;
            //int x1 = x;
            //Console.WriteLine(x);
            //int y = (newarm % 100)/10;
            //int y1= y;
            //Console.WriteLine(y);
            //int z = (newarm % 100)%10;
            //int z1= z;
            //Console.WriteLine(z);
            //for (int i = 0; i < arm.Length-1; i++)
            //{
            //    x1 = x1 * x;
            //    y1 = y1 * y;
            //    z1 = z1 * z;
            //}
            //if (newarm == x1 + y1 + z1)
            //{
            //    Console.WriteLine($"the number {newarm} is an armstrong number");
            //}
            //else { Console.WriteLine($"the number {newarm} is not an armstrong number"); }

            for (int i = 1; i <= newarm; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine($"the number {i} is an armstrong number ");
                    // continue;
                }
                else
                {
                    if (i >= 100 && i <= 1000)
                    {
                        int x = i / 100;
                        int x1 = x;
                        int y = (i % 100) / 10;
                        int y1 = y;
                        int z = (i % 100) % 10;
                        int z1 = z;
                        for (int j = 0; j < 2; j++)
                        {
                            x1 = x1 * x;
                            y1 = y1 * y;
                            z1 = z1 * z;
                        }
                    if (i == x1 + y1 + z1)
                    {
                        Console.WriteLine($"the number {i} is an armstrong number");
                    }
                }
            }
            }
        }

        static bool Parentheses()///(5)
        {
            int counter=0,counter2=0;
            int i=0;
            Console.WriteLine("Enter nested parenthes: ");
            string get = Console.ReadLine();
            for (; i < get.Length; i++)
            {
                if(get[i].ToString() == "(") { counter++; }
                if(get[i].ToString() == ")") { counter2++; }
            }
           if(counter%2 == 0&&counter2%2==0||counter%2!=0&&counter2%2!=0) { Console.WriteLine("legal"); return true; }
            Console.WriteLine("Illigal");
            return false;
        }

        static void BaseNumbers()
        {
            Console.WriteLine("Entre base number number1:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int carry = 0, sum = 0, i = 19, x, y;
            int[] a = new int[20];//0-->19
            // // 11+11
            x = (num1 % 1000) % 100 % 10;//1
            y = (num2 % 1000) % 100 % 10;//1
            sum = x + y + carry;//sum=2
            if (sum == 2)
            {
                carry = 1;
                a[i] = sum-2;//a[20]=0  i=19
                a[i-1] = carry;//a[19]=1   i=18
                i--;//i=18
            }
            if (sum <= 1)
            {
                carry=0;
                a[i] = sum;
                i--;
            }
            ////////////////////////////////////////
            x = (num1 % 1000) % 100 / 10;//1
            y = (num2 % 1000) % 100 / 10;//1
            sum = x + y + carry;//sum=3
            if (sum == 2)
            {
                carry = 1;
                a[i] = sum - 2;
                a[i - 1] = carry;
                i--;
            }

            if (sum == 3)
            {
                carry = 1;
                a[i] = sum - 2;//1[19]=1  i=18
                a[i - 1] = carry;//a[18]=1  i=17
                i--;//17
            }
            if (sum <= 1)
            {
                carry=0;
                a[i] = sum;
                i--;
            }
            /////////////////////////////////////
            x = (num1 % 1000) / 100;
            y = (num2 % 1000) / 100;
            sum = x + y + carry;
            if (sum == 2)
            {
                carry = 1;
                a[i] = sum - 2;
                a[i - 1] = carry;
                i--;
            }
            if (sum == 3)
            {
                carry = 1;
                a[i] = sum - 2;
                a[i - 1] = carry;
                i--;
            }
            if (sum <= 1)
            {
                carry=0;
                a[i] = sum;
                i--;
            }
            ////////////////////////////////////////
            x = (num1 / 1000);
            y = (num2 / 1000);
            sum = x + y + carry;
            if (sum == 2)
            {
                carry = 1;
                a[i] = sum - 2;
                a[i - 1] = carry;
                i--;
            }
            if (sum == 3)
            {
                carry = 1;
                a[i] = sum - 2;
                a[i - 1] = carry;
                i--;
            }
            if (sum <= 1)
            {
                carry = 0;
                a[i] = sum;
                i--;
            }
            ///////////////////////////////////////////////
            for (int j = 0; j < a.Length; j++)
            {
                Console.Write(a[j]);
            }
        }

        
        static void SumAver()////// start an workhome (1)
        {
            int Number = 524;
            double average = 0,sum=0;
            int x = Number / 100;
            int y = (Number % 100)/10;
            int z= (Number % 100)%10;
            sum=x+y+z;
            average = sum / 3;
            Console.WriteLine($"the number is {Number}, the sum of his digits is: {sum}, the average is: {((float)average)}");
        }

        static void MakeChanges()//(2)
        {
            Console.WriteLine("Enter 4 digits:");
            int Number=int.Parse(Console.ReadLine());//3167---->1376
            int x=Number/1000;//3
            int y=(Number%1000)/100;//1
            int z = ((Number % 1000) % 100) / 10;//6
            int w=((Number%1000)%100)%10;//7
            int temp1=x, temp2=z,sum=0;
            x = y*1000;
            y = temp1*100;
            z = w*10;
            w = temp2;
            sum = x + z + y + w;
            Console.WriteLine($"the orginal number is {Number}, after mixing neer digits={sum}");
        }
        static void Oddnumbers()//(3)
        {
            //Console.WriteLine("Entre 4 numbers to chck how many odd numbers of them");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            //int w = int.Parse(Console.ReadLine());
            int counter = 0;
            //if (x % 2 == 0) { counter++; }
            //if (y % 2 == 0) { counter++; }
            //if (z % 2 == 0) { counter++; }
            //if (w % 2 == 0) { counter++; }
            //Console.WriteLine("the number of odd numbers is " + counter);
            ///////////////////////////// another code 
            int[] arr = new int[4];//  int arr[]  array
            for (int i = 0; i < 4; i++)//0 1 2 3
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 != 0) { counter++; }
            }
            Console.WriteLine("the number of odd numbers is " + counter);
        }
        static void ConvertChar()//(4)
        {
            Console.WriteLine("Entre 2 small letters:");
            int c = 0, d = 0;
            char chr1 = char.Parse(Console.ReadLine());
            char chr2 =char.Parse(Console.ReadLine()) ;
            while((int)chr1<97&&(int)chr2<97)// a=97,z=122  A=65, Z=90
            {
                Console.WriteLine("Entre again:");
                chr1=char.Parse(Console.ReadLine());    
                chr2=char.Parse(Console.ReadLine());
            }
            for (int i = 97; i < 123; i++)
            {
                if (i != 97&&(int)chr1==i) { c= (int)chr1 - 96;}
               if(i !=97&&(int)chr2==i) { d = (int)chr2 - 96; }
            }
            if (c > d) { Console.WriteLine($"the leetres are {chr1} and {chr2} and there gimatria is: {c}"); }
            Console.WriteLine($"the letters are {chr1} and {chr2} and there gimatria is: {d}");
        }

       static void chickPassword(int password)
        {
            Console.WriteLine("Enter your password to chek");
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        static bool ChckNumberType()
        {
            Console.WriteLine("Enter a number to chick it basis number");
             string input = Console.ReadLine();
            while (input.Length==0)
            {
                Console.WriteLine("Eror you need to input a number");
                input = Console.ReadLine();
            }
           int num=  Int32.Parse(input);
            Console.WriteLine("the number is: "+num);
            if (num >= 10) {
                    int w = ((num % 1000) % 100) % 10;
                while (w == 0)
                {
                    Console.WriteLine("The number is uncorrect please enter again:");
                    input = Console.ReadLine();
                    num = Int32.Parse(input);
                   w = ((num % 1000) % 100) % 10;
                }
            }
            Console.WriteLine("Enter anumber between 2 and 10 ");
            int number = int.Parse(Console.ReadLine());
            while (number < 2 && number > 10)
            {
                Console.WriteLine("Eror enter again: ");
                number = int.Parse(Console.ReadLine());
            }
            int x = num / 1000;
            int y = (num % 1000) / 100;
            int z = ((num % 1000) % 100) / 10;
            int f = ((num % 1000) % 100) % 10;
            int sum = 0;

                    if (number == 2 && x <= 1 && y <= 1 && z <= 1 && f <= 1) {
                        x = x * 1;
                        y = y * 2;
                        z = z * 2 * 2;
                        f = f * 2 * 2 * 2;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false");
                    return false; }

                    if (number == 3)
                    {
                        x = x * 1;
                        y = y * 3;
                        z = z * 3 * 3;
                        f = f * 3 * 3 * 3;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false"); return false; }

                    if (number == 4)
                    {
                        x = x * 1;
                        y = y * 4;
                        z = z * 4 * 4;
                        f = f * 4 * 4 * 4;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false");return false; }

                    if (number == 5)
                    {
                        x = x * 1;
                        y = y * 5;
                        z = z * 5 * 5;
                        f = f * 5 * 5 * 5;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false");return false; }

                    if (number == 6)
                    {
                        x = x * 1;
                        y = y * 6;
                        z = z * 6 * 6;
                        f = f * 6 * 6 * 6;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false");return false; }

                    if (number == 7)
                    {
                        x = x * 1;
                        y = y * 7;
                        z = z * 7 * 7;
                        f = f * 7 * 7 * 7;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false"); return false; }

                    if (number == 8)
                    {
                        x = x * 1;
                        y = y * 8;
                        z = z * 8 * 8;
                        f = f * 8 * 8 * 8;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false");return false; }

                    if (number == 9)
                    {
                        x = x * 1;
                        y = y * 9;
                        z = z * 9 * 9;
                        f = f * 9 * 9 * 9;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false");return false; }

                    if (number == 10)
                    {
                        x = x * 1;
                        y = y * 2;
                        z = z * 10 * 10;
                        f = f * 10 * 10 * 10;
                        sum = x + y + z + f;
                        Console.WriteLine("true");
                        return true;
                    }
                    else { Console.WriteLine("false");return false; }

            return true;
        }
    }
}


