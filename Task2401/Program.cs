using Task2401;

int num1 = 20;
Console.WriteLine(num1.IsOdd());
Console.WriteLine(num1.IsEven());



string text1 = "FiDaN";
Console.WriteLine(text1.IsContainsDigit());
Console.WriteLine(text1.ToCapitalize());


string sentence = "Salam necesen.Men yaxshiyam";
Console.WriteLine(sentence.GetFirstSentence());


string text2 = "Salam necesen sagol";
Console.WriteLine(text2.GetSecondWord());


string text3 = "Salam necesen sagol";
int[] nums = text3.GetValueIndexes('a');
for (int i = 0; i < nums.Length; i++)
    Console.WriteLine(nums[i]);




