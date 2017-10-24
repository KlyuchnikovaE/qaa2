using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Опрделяем драйвер чтобы работать именно с гугл хром
            IWebDriver driver = new ChromeDriver();
            //Переходим на гугл.ру
            driver.Navigate().GoToUrl("https://www.google.ru");
            //Ищем элемент ввода информации на сайте гугл по айди
            IWebElement findEdit = driver.FindElement(By.Id("lst-ib"));
            //Кликает по найденном элементу
            findEdit.Click();
            //И вводим значение в этот элемент
            findEdit.SendKeys("Симбирсофт");
        }
    }
}
