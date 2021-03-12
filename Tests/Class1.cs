using System;
using NUnit.Framework;
using Generic2;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void CheckIntIsNotNull()

        {
            Optional<int> optional = new Optional<int>
            {
                Value = 5
                
            };
            Assert.IsNotNull(optional.Value);
            Assert.IsTrue(optional.HasValue);
        }
        [Test]
        public void CheckIntIsNull()

        {
            Optional<object> optional = new Optional<object>
            {
                Value = null
            };
            Assert.IsTrue(optional.HasValue);
            Assert.IsNull(optional.Value);
           
        }
        [Test]
        public void CheckIntHasNoValue()
        {
            Optional<int> optional = new Optional<int>();

            Assert.IsFalse(optional.HasValue);
        }
    }
}
