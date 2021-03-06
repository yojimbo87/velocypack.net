﻿using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation.Arrays
{
    [TestFixture]
    public class EmptyArraySegmentationTests
    {
        [Test]
        public void SegmentizeEmptyArray()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEmptyArray);

            // when
            var segment = VPack.ToSegment<EmptyArraySegment>(data);

            // then
            Assert.IsInstanceOf<EmptyArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.EmptyArray, segment.Type);
            Assert.AreEqual(ValueType.EmptyArray, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
            Assert.AreEqual(0, segment.Items.Count);
        }
    }
}
