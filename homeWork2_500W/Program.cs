using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2_500W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////სავარჯიშო 1 მასივის შევსება
            /*
             //სტრინგებით
            string[] arr = new string[10];
            Console.WriteLine("Enter the text data");

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = Console.ReadLine();
            }
            for (int i = 0; i < arr.Length; ++i)
            {
               Console.Write(arr[i] + " ");
            }

            */


            /*
            //რიცხვებით
            int[] arr = new int[10];
            Console.WriteLine("Enter the itegers data");
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            */

            ///////////////////////////////////////////////////////////////// სავარჯიშო 2 პირამიდა
            /*
            Console.WriteLine("Enter the number");
            int _length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[_length];

            for (int x = 0; x != _length; x++)
            {
                arr[x] += x + 1;
            }
            Array.Reverse(arr);

            int i, j, rows, k = 1;
            rows = _length;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                { 

                    Console.Write("{0} ", k++);
                    if (k > arr[0])
                    {
                        break;
                    }
                }
                Console.WriteLine();
                //Console.Write("\n");

                if (k > arr[0])
                {
                    break;
                }

            }
            */
            /////////////////////////////////////////////////////// სავარჯიშო 3 
            ///კლავიატურიდან შემოიტანეთ რიცხვი და დათვალეთ 1-დან n მდე კენტი რიცხვების ჯამი, ნამრავლი.

            /*
            int evenSum = 0;
            int evenMultiplication = 1;
            Console.WriteLine("Enter the number");
            int _length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[_length];

            for (int x = 0; x <= arr.Length - 1; x++)
            {
                arr[x] += x + 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    evenSum += arr[i];
                    evenMultiplication *= arr[i];

                }
            }
            Console.WriteLine($"Sum of even numbers is {evenSum} and Multiplicatin is  {evenMultiplication} ");
            */


            /////////////////////////////////////////////////// სავარჯიშო 4
            ///დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოტანილი რიცხვისთვის 
            ///დაითვლის 1-დან n მდე ამ რიცხვების კვადრატების ჯამს.

            /* 

            int sum = 0;    
            Console.WriteLine("Enter the number");
            int _length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[_length];

            for (int x = 0; x <= arr.Length - 1; x++)
            {
                arr[x] += x + 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Convert.ToInt32(Math.Pow(arr[i], 2));

            }
            Console.WriteLine(sum);


            */

            ////////////////////////////////////////////////////////// სავარჯიშო 5 პალინდრომი
            ///
            //string a = string.Empty;
            //Console.WriteLine("Enter your Word/s!");
            //a = Console.ReadLine();
            //char[] palindrome = a.ToCharArray();
            //Array.Reverse(palindrome);
            //string b = new string(palindrome);
            //if (a.ToLower().Equals(b.ToLower()))
            //{
            //    Console.WriteLine("You enter the Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("You enter the notPalindrome");
            //}

            //Console.ReadLine();


            /////////////////////////////////////////////////////////////////// სავარჯიშო 6 რიცხვების პალინდრომი
            /*
            int number, digit, sum = 0, temp;
            Console.Write("Enter the Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                digit = number % 10;
                sum = (sum * 10) + digit;
                number = number / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.WriteLine("Number is not Palindrome");
            */


            /////////////////////////////////////////// სავარჯიშო 7 მასივსი ელემენტის რაოდენობის დათვლა

            /*
             int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine($"There are {arr.Length} elements in the Array");
            */


            ////////////////////////////////////////////////////////სავარჯიშო 8 
            ///მასივში ვიპოვოთ მაქსიმუმმი, მინიმუმი და მედიანა
            /*
            int[] arr = { 200, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

            Array.Sort(arr);


            Console.WriteLine($"The maximum in array is  {arr.Max()}");
            Console.WriteLine($"The minimum in array is  {arr.Min()}");
            if (arr.Length % 2 == 0)
            {
                double median = Convert.ToDouble(arr[arr.Length / 2-1]);
                double median2 = Convert.ToDouble(arr[arr.Length / 2]);
                Console.WriteLine($"The median in array is  {(median+median2)/2}");
            }
            else
            {
                double median = arr[arr.Length / 2];
                Console.WriteLine($"The median in array is  {median}");
            }

            */

            ////////////////////////////////////////////////////////////////სავარჯიშო 9 
            ///დაწერეთ პროგრამა რომელიც მოცემულ მასივს დაბეჭდავს შებრუნებული სახით
            ///მაგ 1 2 3 4 —-> 4 3 2 1

            /*
            int[] arr = { 100, 1, 2, 3, 4, 5,800};

            int[] arr2 = arr;


            for (int i = 0; i<arr2.Length/2; i++)
            {
                (arr2[i], arr2[arr2.Length -i- 1]) = (arr2[arr2.Length -i- 1], arr2[i]);
            }


            for (int k = 0; k < arr2.Length; k++)
            {
                Console.Write(arr2[k] + ", ");

            }
            */

            ////////////////////////////////////////////////////////////////// სავარჯიშო 10 
            ///დაწერეთ პროგრამა რომელიც მასივიდან დაბეჭდავს უარყოფითი რიცხვების რაოდენობას.


            /*
            int[] arr = { 100, -1, 2, 3, -4, 5, -800, -2 };
            int count = 0;
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} negative numbers");
            */

            /////////////////////////////////////////////////////////////////////// სავარჯიშო 11
            ///დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივიდან ყველა ელემენტებს ერთხელ
            /*
            int[] arr = { 2, 3, 5, 3, 7, 5, 7};
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.Write(arr[i] + ", ");

                }
            }
            */

            ////////////////////////////////////////////////////////////// სავარჯიშო 12
            ///დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივიდან მხოლოდ იმ ელემენტს რომელიც გვხვდება 1-ხელ
            /*
            int[] arr = { 2, 3, 5, 3, 7, 5, 7 };
            foreach (int i in arr
                                 .GroupBy(i => i)
                                 .Where(g => g.Count() == 1)
                                 .Select(g => g.Key))
                Console.WriteLine(i);

            */

            /////////////////////////////////////////////////////////////////// სავარჯიშო 13
            //დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიყვანს ტექსტ და დაითვლის ტექსტში სიტყვების რაოდენობას. 
            //(პუნქტუაციური ნიშნების რაოდენობას, და მაღალი და დაბალი რეგისტრის სიმბოლოებს)
            /*
             Console.WriteLine("Enter the text: ");
             string text = Console.ReadLine();
             byte[] asciiSymb = Encoding.ASCII.GetBytes(text);
             int countSymbol = 0;
             for (int i = 0; i < text.Length; i++)
             {
                 if ((asciiSymb[i] >= 33 && asciiSymb[i] <= 47)
                     || (asciiSymb[i] >= 58 && asciiSymb[i] <= 69)
                     || (asciiSymb[i] >= 91 && asciiSymb[i] <= 96))
                 {
                     countSymbol++;
                 }
             }

             int count = 0;
             string[] textArr = text.Split(' ');
             for (int i = 0; i < textArr.Length; i++)
             {
                 if (textArr[i] != "")
                 {
                     count++;
                 }
             }
             byte[] asciiCapLet = Encoding.ASCII.GetBytes(text);
             int countCapLet = 0;
             for (int i = 0; i < text.Length; i++)
             {
                 if (asciiCapLet[i] >= 65 && asciiCapLet[i] <= 90)
                 {
                     countCapLet++;
                 }
             }

             byte[] asciiLowLet = Encoding.ASCII.GetBytes(text);
             int countLowLet = 0;
             for (int i = 0; i < text.Length; i++)
             {
                 if (asciiLowLet[i] >= 97 && asciiLowLet[i] <= 122)
                 {
                     countLowLet++;
                 }
             }
             Console.WriteLine($"There are  { count} words");
             Console.WriteLine($"There are  { countSymbol} symbols");
             Console.WriteLine($"There are  { countCapLet} capital letters");
             Console.WriteLine($"There are  { countLowLet} capital letters");
            */

            /////////////////////////////////////////////////////////////// სავარჯიშო 14
            //დაწერეთ პროგრამა რომელიც ტექსტში დაითვლის ხმოვნებს/თანხმოვნებს.
            /*
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine().ToLower();
            byte[] asciiCodes = Encoding.ASCII.GetBytes(text);
            int countVowel = 0;
            int countConsonant = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((asciiCodes[i] >= 97 && asciiCodes[i] <= 122))
                {
                    if (asciiCodes[i] == 97 || asciiCodes[i] == 101 || asciiCodes[i] == 105 ||
                        asciiCodes[i] == 111 || asciiCodes[i] == 117 || asciiCodes[i] == 121)
                    {
                        countVowel++;
                    }
                    else
                    {
                        countConsonant++;
                    }
                }
            }
            Console.WriteLine($" There are {countVowel} vowels and {countConsonant} consonants");
            */

            //////////////////////////////////////////////////////////////// სავარჯიშო 15
            ///დაწერეთ პროგრამა რომელიც იპოვნის ტექსტი შეიცავს თუ არა  
            ///substring-ს (მაგ: some text    შეიცავს ext-ს ? შეიცავს!)

            /*
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the searching word: ");
            string search = Console.ReadLine().ToLower();

            if (text.Contains(search))
            {
                Console.WriteLine(text + " contains the word - " + search);
            }
            else
            {
                Console.WriteLine(text + " does not contain the word - " + search);
            }
            */

            //////////////////////////////////////////////////////////////// სავარჯიშო 16 
            ///http://codeforces.com/problemset/problem/71/A
            ///
            /*
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine().ToLower();
            string[] words = text.Split();
            int count = 0;
            for (int i = 0; i < words[i].Length; i++)
            {
                char [] characters = words[i].ToCharArray();
                count = characters.Length - 2;
                if (characters.Length > 10)
                {
                    Console.WriteLine($"{characters[0]}{count}{characters[characters.Length - 1]}");
                }
                else
                {
                    Console.WriteLine(words[i]);
                }
            }
            */
            //////////////////////////////////////////////////////////////// სავარჯიშო 17 
            ///http://codeforces.com/problemset/problem/339/A
            ///
            /*
            Console.WriteLine("Enter the addition operation (example: 1+1+3+1+3)  ");
            string solution = Console.ReadLine();
            char[] symbols = solution.ToCharArray();
            char symbolToRemove = '+';
            symbols = symbols.Where(val => val != symbolToRemove).ToArray();
            Array.Sort(symbols);

            for (int j = 0; j < symbols.Length; j++)
            {
                if (j == symbols.Length - 1) { 
                Console.Write($"{symbols[j]}=");
                }
                else
                {
                    Console.Write($"{symbols[j]}+");

                }
            }
                Console.WriteLine();
            */

            ///////////////////////////////////////////////////////////////////// სავარჯიშო 18
            //http://codeforces.com/problemset/problem/118/A
            /*
            Console.WriteLine("Enter the word: ");

            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                   
                        chars = chars.Where(val => val != vowels[j]).ToArray();
                    
                }
                Console.Write("."+chars[i]);

            }
            Console.WriteLine();
            */

            /////////////////////////////////////////////////////////////////////სავარჯიშო 19
            ///https://codeforces.com/problemset/problem/236/A%20%20*
            ///
            /*
            Console.WriteLine("Enter the username: ");
            string username = Console.ReadLine();
            string answer = new String(username.Distinct().ToArray());
            if(answer.Count() % 2 == 0)
            {
                Console.WriteLine("Chat with her");
            }
            else
            {
                Console.WriteLine("Ignore him");
            }
            */

            ////////////////////////////////////////////////////////////სავარჯიშო 20
            //http://codeforces.com/problemset/problem/59/A 

            /*
            Console.WriteLine("Enter the username: ");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            int countLowLet = 0;
            int countCapLet = 0;
            byte[] asciiCodes = Encoding.ASCII.GetBytes(chars);
            for (int i = 0; i < asciiCodes.Length; i++)
            {
                if (asciiCodes[i] >= 97 && asciiCodes[i] <= 122)
                {
                    countLowLet++;
                }
                else if (asciiCodes[i] >= 65 && asciiCodes[i] <= 90)
                {
                    countCapLet++;
                }
                else
                {
                    break;
                }
            }

            if (countCapLet > countLowLet)
            {
                Console.WriteLine(word.ToUpper());
            }
            else
            {
                Console.WriteLine(word.ToLower());
            }
            */



            ///////////////////////////////////////////////////////////////სავარჯიშო 21
            ///http://codeforces.com/problemset/problem/131/A  
            /*
            Console.WriteLine("Enter the word : ");
            string word = Console.ReadLine();
            word = word.ToLower();
            char[] arrChar = word.ToCharArray();
            arrChar[0] = char.ToUpper(arrChar[0]);
            Console.WriteLine(arrChar);
            */
        }
    }
}
