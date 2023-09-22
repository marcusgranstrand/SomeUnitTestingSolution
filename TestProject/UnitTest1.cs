namespace TestProject
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			string firstName = "nathaniel";
			string lastName = "haWthorNe";

			string expected = "#_Hawthorne, Nathaniel (HAWNAT)";
			string actual = SomeUnitTesting.Classes.Methods.Formatter(firstName, lastName);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Test2()
		{
			string firstName = "ELisabeth";
			string lastName = "GEorge";

			string expected = "#_George, Elisabeth (GEOELI)";
			string actual = SomeUnitTesting.Classes.Methods.Formatter(firstName, lastName);

			Assert.Equal(expected, actual);
		}
	}
}