using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestCountries.Controllers;

namespace UnitTestRestCountries
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestGet()
		{
			//Arrange
			CountriesController controller = new CountriesController();

			//Act
			var countriesList = controller.GetCountries();

			//Assert
			Assert.IsNotNull(countriesList);
		}
	}
}
