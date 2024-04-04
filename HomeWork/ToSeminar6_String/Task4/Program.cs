// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string ReversalOfWordInSentence(string str)
{
    int strLen = str.Split(' ').Length;
    string[] Words = new string[strLen];
    string WordsAfterReversal = "";
    Words = str.Split(' ');
    
// // Соединение слов обратно в строку с пробелами
// return string.Join(" ", words);

    for (int i = (strLen - 1); i >= 0; i--)
    {
        WordsAfterReversal += Words[i] + " ";
    }
    return WordsAfterReversal;
}


string sentence = "may the force be with you";
Console.WriteLine(sentence);
Console.WriteLine(ReversalOfWordInSentence(sentence).Trim(' '));