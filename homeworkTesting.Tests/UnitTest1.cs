using Xunit;
using Moq;
namespace homeworkTesting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, A.f1(1));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(4, A.f2(2));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(5, A.f3(2));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(6, A.f4(2));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(2, A.f5(5,2));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(8, A.f6(3));
        }

        [Fact]
        public void Test7()
        {
            Assert.Equal("hello more stuff", A.f7("hello"));
        }

        [Fact]
        public void TestA()
        {
            var a = new A();
            Assert.NotNull(a);
        }

        [Fact]
        public void Testg1()
        {
            var mockA = new Mock<A>();
            mockA.Setup(a => a.f8(It.IsAny<int>())).Returns((int x) => x + 8);
            
            var a = mockA.Object;
            var retVal = B.g1(1, a);

            Assert.Equal(9, retVal);
        }
        
    }
}

/*
public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        var v1 = A.f1(1);
        var v2 = A.f2(2); 
        var v5 = A.f5(5,2);
        var v6 = A.f6(3);
        var v7 = A.f7("hello");
        var a = new A();
        var v8 = B.g1(1,a);
    }
}
*/