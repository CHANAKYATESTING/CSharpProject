using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlanetsProject
{
    public class Planet
    {
        private readonly IWebElement planetElement;

        public Planet(IWebElement planetElement)
        {
            this.planetElement = planetElement;
        }

        public string GetName()
        {
            return planetElement.FindElement(By.ClassName("name")).Text;
        }
        public string GetRadius()
        {
            return planetElement.FindElement(By.ClassName("radius")).Text;
        }

        public void ClickExplore()
        {
            planetElement.FindElement(By.TagName("button")).Click();
        }
    }
}
