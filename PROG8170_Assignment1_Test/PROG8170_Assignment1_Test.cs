using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170_Assignment1;
using NUnit.Framework;

namespace PROG8170_Assignment1_Test
{
    [TestFixture]
    public class PROG8170_Assignment1_Test
    {
        [Test]
        public void GetLength_Input_5_ExpectedLength_5()
        {
            // Arrange
            int len = 5;
            int wid = 5;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int length = rectangle.GetLength();
            // Assert
            Assert.AreEqual(length, len);
        }

        [Test]
        public void SetLength_Input_10_ExpectedLength_10()
        {
            // Arranage
            int len = 10;
            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(len);
            // Act
            int length = rectangle.GetLength();
            // Assert
            Assert.AreEqual(length, len);
        }

        [Test]
        public void GetWidth_Input_20_ExpectedWidth_20()
        {
            // Arranage
            int len = 20;
            int wid = 20;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int width = rectangle.GetWidth();
            // Assert
            Assert.AreEqual(width, wid);
        }

        [Test]
        public void SetWidth_Input_8_ExpectedWidth_8()
        {
            // Arranage
            int len = 8;
            int wid = 8;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int width = rectangle.SetWidth(wid);
            // Assert
            Assert.AreEqual(width, wid);
        }

        [Test]
        public void GetPerimeter_InputLength_9_InputWidth_9_ExpectedPerimeter_36()
        {
            // Arranage
            int len = 9;
            int wid = 9;
            int per = 2 * (9 + 9);

            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int perimeter = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(perimeter, per);
        }

        [Test]
        public void GetArea_InputLength_10_InputWidth_10_ExpectedArea_100()
        {
            // Arranage
            int len = 10;
            int wid = 10;
            int ar = len * wid;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int area = rectangle.GetArea();
            // Assert
            Assert.AreEqual(area, ar);
        }
    }
}
