using SmartsheetUtils;
using SmartsheetUtils.Enums;
using System;
using Xunit;

namespace SmartsheetUtilsTests.Enums
{
    public class Arrows4wayTest
    {

        [Fact]
        public void NoSmartsheetValueTests()
        {
            Assert.Equal(Arrows4way.Down.GetSmartsheetValue(), "Down");
        }

        [Fact]
        public void AngleDownTests()
        {
            Assert.Equal(Arrows4way.AngleDown.GetSmartsheetValue(), "Angle Down");
        }
    }
}
