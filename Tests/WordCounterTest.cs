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
    [Fact]
    public void RepeatCounterTest2_RecognizeNotSame_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("house", "dog");
      Assert.Equal(0, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void RepeatCounterTest3_CountHowMany_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("house", "house house");
      Assert.Equal(2, testRepeatCounter.CountRepeats());
    }
  }
}
