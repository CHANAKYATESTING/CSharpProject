using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestPlanetsProject
{
    [TestClass]
    public class TestPlanets
    {
        WebDriver driver;

       

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.FullScreen();
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/planets";
        }
        [TestMethod]
        public void TestExplorePlanet()
        {
            String planetName = GetPlanetName();
            PlanetPage planetPage = new PlanetPage(driver);
            planetPage.ExplorePlanet(p => p.GetName() == planetName);
            Assert.AreEqual("Exploring " + planetName + "", planetPage.PopUpMessage());
        }

        private static String GetPlanetName()
        {
            return "Saturn";
        }

        [TestCleanup]
        public void teardown()
        {
            driver.Close();
        }


    }
}
    