﻿using NUnit.Framework;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class NoneValueTests
    {
        [Test]
        public void DeserializeNoneValueHexDump()
        {
            // given
            var data = new byte[] { 0x00 };

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
