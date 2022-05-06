// The method creates and fills an array with user elements
string[] CreatFillUserArray()
{
   Console.WriteLine($"Enter the elements of the array one by one. To end entry, type: < esc >");
   string arg = Console.ReadLine();
   if (arg.ToLower() == "esc")
   {
      Console.WriteLine($"You have not entered any elements of the array.\nEnter any values you want. Enter <esc> to complete the entry.");
      arg = Console.ReadLine();
   }

   string[] userArr = new string[1];
   userArr[0] = arg;
   int count = 1;
   while (arg.ToLower() != "esc")
   {
      arg = Console.ReadLine();
      if (arg.ToLower() == "esc") break;
      else
      {
         Array.Resize(ref userArr, userArr.Length + 1);
         userArr[count++] = arg;
      }
   }
   return userArr;
}

// The method looks for elements of an array with a string length less or equal to three characters
string[] FindCharArray(string[] arrayInput)
{
   string[] blankArray = new string[0];
   int strLeng = 3;
   int size = arrayInput.Length;

   for (int i = 0; i < size; i++)
   {
      if (arrayInput[i].Length <= strLeng)
      {
         Array.Resize(ref blankArray, blankArray.Length + 1);
         blankArray[blankArray.Length - 1] = arrayInput[i];
      }
   }
   return blankArray;
}

// The method outputs the array elements in the console
string PrintArray(string[] array)
{
   int size = array.Length;
   string print = String.Empty;

   for (int i = 0; i < size; i++)
   {
      print += $"{array[i]} ";
   }
   return print;
}

Console.Clear();

string[] userArray = CreatFillUserArray();
Console.WriteLine();
Console.WriteLine($"[ {PrintArray(userArray)}]");

string[] resultArray = FindCharArray(userArray);
Console.WriteLine($"[ {PrintArray(resultArray)}]");