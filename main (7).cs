using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Введите предложение:");
    string sentence = Console.ReadLine();
    string[] words = sentence.Split('/');
    Console.WriteLine(words[words.Length-1]);
  }
}