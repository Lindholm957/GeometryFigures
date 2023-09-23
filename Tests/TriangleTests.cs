using GeometryFigures;

namespace Tests
{
    public class TriangleTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void TriangleWithErrorTest(double sideA, double sideB, double sideC)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Test]
        public void GetAreaTest()
        {
            double a = 3d, b = 4d, c = 5d;
            double expectedValue = 6d;
            var triangle = new Triangle(a, b, c);
            float calcTolerance = 0.1f;


            double? area = triangle?.GetArea();

            Assert.NotNull(area);
            Assert.Less(Math.Abs(area.Value - expectedValue), calcTolerance);
        }

        [Test]
        public void ExistenceTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
        }
        
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 2, ExpectedResult = false)]
        [TestCase(3, 4, 5 + 0.2f, ExpectedResult = false)]
        public bool NotRightTriangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            bool result = triangle.IsRightTriangle;
            return result;
        }
    }
}