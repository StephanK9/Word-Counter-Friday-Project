using System;
using Xunit;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterTest1_RecognizeSame_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("house", "house");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
  }
}
