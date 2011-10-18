using NUnit.Framework;

namespace Blueprint.Tests.Unit
{
    public class RectangleTests
    {
        [Test]
        public void ShouldCalculatePerimeter()
        {
            Assert.That(new Rectangle(3,5).Perimeter, Is.EqualTo(16));
        }     
    }

    public class Rectangle
    {
        private readonly int width;
        private readonly int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Perimeter
        {
            get { return 2*width + 2*height; }
        }
    }
}