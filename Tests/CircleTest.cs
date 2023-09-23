using GeometryFigures;

namespace Tests
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void GetAreaTest()
        {
            double radius = 12;
            Circle circle = new Circle(radius);
            double expectedValue = Math.PI * Math.Pow(radius, 2); 

            var area = circle.GetArea();
			
            Assert.Less(Math.Abs(area-expectedValue), 1);
        }
    }
}