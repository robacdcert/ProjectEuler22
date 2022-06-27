// Project Euler 22: Names scores

// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
// Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
// So, COLIN would obtain a score of 938 × 53 = 49714.

// What is the total of all the name scores in the file?

using System.Numerics;

// Putting the txt document in a string
string allNames = System.IO.File.ReadAllText(@"C:\repos\ProjectEuler22\p022_names.txt");
allNames = allNames.Replace("\"", "");
string[] names = allNames.Split(',');
Array.Sort(names);

BigInteger total = 0;
int index = 1;

foreach (string name in names)
{
    int score = 0;
    for (int lp = 0; lp < name.Length; lp++)
    {
        // Takes the numeric value of the letter
        score += 1 + name[lp] - 'A';
        // For example, the Letter 'C' has an ASCII value of 67
        // 67 + 1 = = 68
        // 68 - 'A' (which has an ASCII value of 65) = 3
    }
    score *= index;
    Console.WriteLine("Name " + index + ": " + name + " Score: " + score);
    total = total + score;
    index++;
}

Console.WriteLine("Total: " + total);