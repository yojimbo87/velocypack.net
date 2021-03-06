﻿using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class IllegalValueSegmentationTests
    {
        [Test]
        public void SegmentizeIllegalValue()
        {
            // given
            var data = Hex.IllegalValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<IllegalSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Illegal, segment.Type);
            Assert.AreEqual(ValueType.Illegal, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
