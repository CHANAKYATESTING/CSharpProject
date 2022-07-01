using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlanetsProject
{

    public class PlanetPage
    {
        WebDriver driver;
      public  PlanetPage(WebDriver driver)
        {
            this.driver = driver;
        }

        public String PopUpMessage()
        {
            var popUp = driver.FindElement(By.CssSelector(".snackbar.popup-message.mr-auto"));
            new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(driver => popUp.Displayed);
            String message = popUp.Text;
            return message;
        }


        public void ExplorePlanet(Predicate<Planet> strategy)
        {
            foreach (WebElement planetEle in driver.FindElements(By.ClassName("planet")))
            {
                var planet = new Planet(planetEle);
                if (strategy.Invoke(planet))
                {
                    planet.ClickExplore();
                    break;
                }
            }
        }

    }
}

