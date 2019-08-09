using ShapeWorld.Domain.Models;
using Xunit;

namespace ShapeWorld.Testing
{
		public class RectangleTest{

			[Fact]
				public void Test_Edges(){
				// Arrange --> Expected Value
				var rectangle = new Rectangle(2,4);
				var expected = 4;
				// Act --> Actual Value
				var actual = rectangle.NumberOfEdges;
				// Assert
				Assert.True(expected == actual);
			}
		}
}