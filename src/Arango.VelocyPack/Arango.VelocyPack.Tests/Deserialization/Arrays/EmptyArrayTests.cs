﻿using System.Collections.Generic;
using NUnit.Framework;
using Arango.VelocyPack.Tests.Helpers;

namespace Arango.VelocyPack.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class EmptyArrayTests
    {
        [Test]
        public void DeserializeEmptyArrayHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEmptyArray);

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(0, value.Count);
        }
    }
}
