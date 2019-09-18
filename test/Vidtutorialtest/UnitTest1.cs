using System;
using Xunit;
using Vidtutorial.Controllers;


namespace Vidtutorialtest
{
    public class UnitTest1
    {
        ValuesController vcontr = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
        //Given
        var returnValue = vcontr.Get(1);
        Assert.Equal("what", returnValue.Value);
        //When
        
        //Then
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
