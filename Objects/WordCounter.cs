using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userInputWord;
    private string _userInputString;
    private int _wordCount = 0;

    public RepeatCounter(string userInputWord, string userInputString)
    {
      _userInputWord = userInputWord;
      _userInputString = userInputString;
    }

    public int CountRepeats()
    {
      return 0;
    }
  }
}
