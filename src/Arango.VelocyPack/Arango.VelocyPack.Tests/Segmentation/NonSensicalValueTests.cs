﻿using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class NonSensicalValueTests
    {
        [Test]
        public void SegmentizeMinKeyValueHexDump()
        {
            // given
            var data = Hex.MinKeyValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NonSensicalSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonSensical, segment.Type);
            Assert.AreEqual(ValueType.MinKey, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeMaxKeyValueHexDump()
        {
            // given
            var data = Hex.MaxKeyValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NonSensicalSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonSensical, segment.Type);
            Assert.AreEqual(ValueType.MaxKey, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
