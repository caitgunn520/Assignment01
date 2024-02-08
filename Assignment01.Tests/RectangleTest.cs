using Assignment01;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Tests
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleGetLengthTest
        {
            [Test]
            public void RectangleGetLength_DefaultLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 1;

                //Act
                int actual = rectangle.GetLength();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetLength_MaxLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(2300, 2300);
                int expected = 2300;

                //Act
                int actual = rectangle.GetLength();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetLength_AvgLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(1150, 1150);
                int expected = 1150;

                //Act
                int actual = rectangle.GetLength();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
        }

        [TestFixture]
        public class RectangleSetLengthTest
        {
            [Test]
            public void RectangleSetLength_MinLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(2, 1);
                int expected = 1;

                //Act
                int actual = rectangle.SetLength(1);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleSetLength_MaxLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 2300;

                //Act
                int actual = rectangle.SetLength(2300);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleSetLength_AvgLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 1150;

                //Act
                int actual = rectangle.SetLength(1150);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
        }

        [TestFixture]
        public class RectangleGetWidthTest
        {
            [Test]
            public void RectangleGetWidth_DefaultWidth()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 1;

                //Act
                int actual = rectangle.GetWidth();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetWidth_MaxWidth()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(2300, 2300);
                int expected = 2300;

                //Act
                int actual = rectangle.GetWidth();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetWidth_AvgWidth()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(1150, 1150);
                int expected = 1150;

                //Act
                int actual = rectangle.GetWidth();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
        }

        [TestFixture]
        public class RectangleSetWidthTest
        {
            [Test]
            public void RectangleSetWidth_MinWidth()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(1, 2);
                int expected = 1;

                //Act
                int actual = rectangle.SetWidth(1);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleSetWidth_MaxWidth()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 2300;

                //Act
                int actual = rectangle.SetWidth(2300);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleSetWidth_AvgWidth()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 1150;

                //Act
                int actual = rectangle.SetWidth(1150);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
        }

        public class RectangleGetPerimeterTest
        {
            [Test]
            public void RectangleGetPerimeter_DefaultPerimeter()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = (2 * 1) + (2 * 1);

                //Act
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetPerimeter_MaxPerimeter()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(2300, 2300);
                int expected = (2 * 2300) + (2 * 2300);

                //Act
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetPerimeter_AvgPerimeter()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(1150, 1150);
                int expected = (2 * 1150) + (2 * 1150);

                //Act
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
        }

        public class RectangleGetAreaTest
        {
            [Test]
            public void RectangleGetArea_DefaultArea()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 1 * 1;

                //Act
                int actual = rectangle.GetArea();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetArea_MaxArea()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(2300, 2300);
                int expected = 2300 * 2300;

                //Act
                int actual = rectangle.GetArea();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

            [Test]
            public void RectangleGetArea_AvgArea()
            {
                //Arrange
                Rectangle rectangle = new Rectangle(1150, 1150);
                int expected = 1150 * 1150;

                //Act
                int actual = rectangle.GetArea();

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }
        }
    }
}
