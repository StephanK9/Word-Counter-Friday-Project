using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userInputWord;
    private string _userInputString;
    private int _wordsCounted = 0;

    public RepeatCounter(string userInputWord, string userInputString)
    {
      _userInputWord = userInputWord;
      _userInputString = userInputString;
    }

    public string GetUserWord()
    {
      return _userInputWord;
    }

    public string GetUserString()
    {
      return _userInputString;
    }

    public int GetWordsCounted()
    {
      return _wordsCounted;
    }

    public int CountRepeats()
    {
      string[] searchForWords = _userInputString.ToLower().Split(' ');
      for (int i = 0; i < searchForWords.Length; i++)
      {
        if(searchForWords[i] == _userInputWord.ToLower())
        {
          _wordsCounted += 1;
        }
      }
    return _wordsCounted;
  }
 }
}
