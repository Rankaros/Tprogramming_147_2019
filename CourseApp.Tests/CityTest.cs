using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CityTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new City();
            Assert.Equal(0, item.Pop);
            Assert.Equal("Untiled", item.Country);
            Assert.Equal("Unnamed", item.Name);
        }

        [Fact]
        public void TestView()
        {
            var item = new City();
            var view = @"
▐▌▐▐▄▄▄▐███▌▄███▄▐▌▌
▐██▐█▄█▐▌▌▐▌█▄█▄█▐▌█▌
▐▄██▄█▐▐▌▌▐▌█▄█▄█▐▌▌█▌
▐█▄██▐▐▐▌▌▐▌█▄█▄█▐▌▌▌█
██████████████████████
         ";  
            Assert.Equal(view, item.View());
        }

        [Fact]

        public void TestSetPop()
        {
            var item = new City();
            item.Pop = 1; //ну как минимум, там живет пользователь
            Assert.Equal(1, item.Pop);
        }

        [Fact]
        public void TestINcorrectSetPop()
        {
            var item = new City();
            item.Pop = -100000;
            Assert.Equal(0, item.Pop);
        }

        [Fact]
        public void TestCorrectIncorrectSetPop()
        {
            var item = new City();
            item.Pop = 1;
            item.Pop = -100000;
            Assert.Equal(10, item.Pop);
        }

    }
}