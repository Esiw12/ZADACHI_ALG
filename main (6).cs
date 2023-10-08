using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Введите предложение:");
    string sentence = Console.ReadLine();
    string[] words = sentence.Split(' ');
    string longestWord = "";
    foreach (string word in words)
    {
        if (word.Length > longestWord.Length)
        {
        longestWord = word;
        }
    }
    Console.WriteLine("Самое длинное слово: " + longestWord);
  }
}