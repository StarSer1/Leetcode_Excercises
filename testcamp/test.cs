using leetcodex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcamp
{
    public class test
    {
        //chupa chupa thomas
        [Theory]
        [InlineData(121, true)]
        [InlineData(10, false)]
        [InlineData(-121, false)]
        [InlineData(2323, false)]
        [InlineData(112211, true)]
        [InlineData(332233, true)]
        [InlineData(552155, false)]
        public void NumberPal_IsPalindrome_ReturnBool(int NumberTest, bool Expected)
        {
            //TEST 
            bool o = Solutions.IsPalindrome(NumberTest);
            Assert.Equal(Expected, o);
        }

        [Theory]
        [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        [InlineData(new[] { 0, 1, 1, 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6, 6, 6, 7, 8 }, 9)]
        [InlineData(new[] { 0 }, 1)]
        public void NumberPal_RemoveDuplicates_ReturnInt(int[] arrayTest, int Expected)
        {
            //TEST 
            int result = Solutions.RemoveDuplicates(arrayTest);
            Assert.Equal(Expected, result);
        }
        [Theory]
        [InlineData(19, true)]
        [InlineData(2, false)]
        [InlineData(7, true)]
        public void NumberPal_IsHappy_ReturnBool(int number, bool Expected)
        {
            //TEST 
            bool result = Solutions.IsHappy(number);
            Assert.Equal(Expected, result);
        }
        [Theory]
        [InlineData(new[] { 2, 2, 1 }, 1)]
        [InlineData(new[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new[] { 4, 1, 2, 1, 4 }, 2)]
        public void NumberPal_SingleNumber_ReturnInt(int[] arrayTest, int Expected)
        {
            //TEST 
            int result = Solutions.SingleNumber(arrayTest);
            Assert.Equal(Expected, result);
        }
        [Fact]
        public void NumberPal_UniqueOccurrences_ReturnBool()
        {
            bool result;
            //TEST 1
            int[] a = { 26, 2, 16, 16, 5, 5, 26, 2, 5, 20, 20, 5, 2, 20, 2, 2, 20, 2, 16, 20, 16, 17, 16, 2, 16, 20, 26, 16 };
            result = Solutions.UniqueOccurrences(a);
            Assert.False(result);

            //TEST 2
            int[] b = { 1, 2 };
            result = Solutions.UniqueOccurrences(b);
            Assert.False(result);

            //TEST 3
            int[] c = { 1, 2, 2, 1, 1, 3 };
            result = Solutions.UniqueOccurrences(c);
            Assert.True(result);
        }
        [Fact]
        public void Numbre_Suma_Test()
        {
            int pendejo1 = 1;
            int pendejo2 = 2;
            int resultadopendejo = Solutions.sumasxd(pendejo1, pendejo2);
            Assert.Equal(3, resultadopendejo);
        }
        
    }
}
