using System;
using Xunit;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterTest1_SentenceContainsWord_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("house");
      Assert.Equal("there is", testRepeatCounter.GetCount());
    }
  }
}
