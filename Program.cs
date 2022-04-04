//// Reverse the String Order
//#region Reverse the Stirng 

//        string line = "Display the pattern like pyramid using the alphabet.";
//        Console.WriteLine("\nOriginal String: " + line);
//        string result = "";
//        List<String> wordsList = new List<String>();

//        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.None);
//        for (int i = words.Length - 1; i >= 0; i--)
//        {
//            result += words[i] + " ";
//        }
//        wordsList.Add(result);

//        foreach (var s in wordsList)
//        {
//            Console.WriteLine(s);
//        }
//#endregion

////Convert the HexaDecimal No. to Decimal No
//#region Hexadecimal No

//string HaxVal = "4B0";
//        Console.WriteLine($"Hexadecimal Value {HaxVal}");
//        Console.WriteLine($"Decimal No. {int.Parse(HaxVal, System.Globalization.NumberStyles.HexNumber)}");

//#endregion

//// Display the Rantangle of 3 Column and 5 rows
//#region Display the Ractangle

//for (int i = 0; i < 5; i++)
//        {
//            if (i == 0 || i == 4)
//            {
//                Console.WriteLine($"{i}{i}{i}");
//            }
//            else
//            {
//                Console.WriteLine($"{i} {i}");
//            }
//        }

//#endregion


using Coding_Practice;

using Coding_Practice;



string[] strs = { "car", "fog", "flight" };
var lc_Result = LC_Prefix.LongestCommonPrefix(strs);
Console.WriteLine(lc_Result);


//M_Jump j = new M_Jump();
//int[] minAr = new int[] { 1, 3, 5, 8, 9, 2,
//                                6, 7, 6, 8, 9 };

//// calling minJumps method
//Console.Write(j.min_Jump(minAr));


//GFG arraysum = new GFG();
//int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
//int n = arr.Length;
//int sum = 23;
//var result=arraysum.subArraySub(arr, n, sum);

//string s;
//string answer = "";
//Console.Write("Enter the string : ");
//s = Console.ReadLine();

//Console.Write("\nAll possible strings are : ");
//permute(s, answer);

//Console.ReadKey();

//static void permute(string s, string answer)
//{
//    if(s.Length==0)
//    {
//        Console.WriteLine($"{answer} ");

//        return;
//    }

//    for (int i = 0; i < s.Length; i++)
//    {
//        char ch = s[i];
//        string left_Substring = s.Substring(0, i);
//        string right_Substring = s.Substring(i + 1);

//        string result= left_Substring + right_Substring;
//        permute(result, answer + ch);
//    }
//}

