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

    public int CountRepeats()
    {
      //return 0; used for testing fail
      //used for second test if(_userInputWord == _userInputString)
      string[] searchForWords = _userInputString.Split(' ');
      foreach(string word in searchForWords)
      {
        if(_userInputWord == word)
      {
        _wordsCounted += 1;
      }
    }
    return _wordsCounted;
  }
 }
}
