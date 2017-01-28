﻿using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class NoneValueTests
    {
        [Test]
        public void SegmentizeNoneValueHexDump()
        {
            // given
            var data = ValueHexDumps.None;

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NoneSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.None, segment.Type);
            Assert.AreEqual(ValueType.None, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
