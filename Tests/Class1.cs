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
        }
        [Test]
        public void CheckIntIsNull()

        {
            Optional<object> optional = new Optional<object>
            {
                Value = null
            };
            Assert.IsNotNull(optional.Value);
        }
    }
}
