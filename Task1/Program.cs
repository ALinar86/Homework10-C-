Console.Clear();

int FindVowel(string[] phrase)
{
    int count = 0;
    string[] vowel = { "A", "a", "E", "e", "I", "i", "U", "u", "Y", "y", "O", "o" };
    for (int i = 0; i < phrase.Length; i++)
        for (int j = 0; j < vowel.Length; j++)
            if (phrase[i][0] == vowel[j][0]) count++;
    return count;
}

string[] words = { "Awe", "aer", "srt", "rty", "tyu", "Ontr", "yje", "ddf", "gfd" };
Console.WriteLine($"The number of words in the array starting with a vowel letter:  {FindVowel(words)}");