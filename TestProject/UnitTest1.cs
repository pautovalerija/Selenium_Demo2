using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_Demo
{
    class Selenium_Demo
    {
        String test_url = "http://prelive.aptimea.com/form/questionnaire";

        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_search()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(500);
            IWebElement b1 = driver.FindElement(By.XPath("//*[@id='edit-je-suis-0']"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", b1);


            IWebElement b2 = driver.FindElement(By.XPath("//*[@id='edit-je-suis-1']"));
            IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
            executor1.ExecuteScript("arguments[0].click();", b2);

  
            IWebElement oui = driver.FindElement(By.XPath("//*[@id='edit-je-suis-enceinte-0']"));
            IJavaScriptExecutor executoroui = (IJavaScriptExecutor)driver;
            executoroui.ExecuteScript("arguments[0].click();", oui);

            IWebElement non = driver.FindElement(By.XPath("//*[@id='edit-je-suis-enceinte-1']"));
            IJavaScriptExecutor executornon = (IJavaScriptExecutor)driver;
            executornon.ExecuteScript("arguments[0].click();", non);

            IWebElement b3 = driver.FindElement(By.XPath("//*[@id='edit-je-suis-2']"));
            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("arguments[0].click();", b3);


            SelectElement Select = new SelectElement(driver.FindElement(By.Id("edit-je-suis-ne-e-en-annee-year")));
            Select.SelectByIndex(50);
            

            for(int i=0; i<4; i++)
            {
                
                IWebElement r = driver.FindElement(By.XPath("//*[@id='edit-je-fais-du-sport-chaque-semaine-" + i +"']"));
                IJavaScriptExecutor executorr = (IJavaScriptExecutor)driver;
                executorr.ExecuteScript("arguments[0].click();", r);
            }

            for (int i = 0; i < 3; i++)
            {

                IWebElement r2 = driver.FindElement(By.XPath("//*[@id='edit-je-suis-2-" + i + "']"));
                IJavaScriptExecutor executorr2 = (IJavaScriptExecutor)driver;
                executorr2.ExecuteScript("arguments[0].click();", r2);
            }


            IWebElement searchText = driver.FindElement(By.CssSelector("#edit-mes-traitements-medicaux-sont"));
            searchText.SendKeys("LambdaTest");


            IWebElement searchText2 = driver.FindElement(By.CssSelector("#edit-user-weight"));
            searchText2.SendKeys("54");


            IWebElement searchText3 = driver.FindElement(By.CssSelector("#edit-user-height"));
            searchText3.SendKeys("170");

            for (int i = 0; i < 4; i++)
            {

                IWebElement r3 = driver.FindElement(By.XPath("//*[@id='edit-je-vis-" + i + "']"));
                IJavaScriptExecutor executorr3 = (IJavaScriptExecutor)driver;
                executorr3.ExecuteScript("arguments[0].click();", r3);
            }


            IWebElement searchText4 = driver.FindElement(By.CssSelector("#edit-j-ai-enfants-nombre-"));
            searchText4.SendKeys("3");


            IWebElement r4 = driver.FindElement(By.XPath("//*[@id='edit-patient-goals-28']"));
            IJavaScriptExecutor executorr4 = (IJavaScriptExecutor)driver;
            executorr4.ExecuteScript("arguments[0].click();", r4);



            IWebElement next = driver.FindElement(By.XPath("//button[@value='Suivant']"));
            IJavaScriptExecutor executornext = (IJavaScriptExecutor)driver;
            executornext.ExecuteScript("arguments[0].click();", next);
            System.Threading.Thread.Sleep(3000);

            IWebElement nextto = driver.FindElement(By.XPath("//*[@value='1']"));
            IJavaScriptExecutor executornextto = (IJavaScriptExecutor)driver;
            executornextto.ExecuteScript("arguments[0].click();", nextto);

  



            System.Threading.Thread.Sleep(100000);

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}