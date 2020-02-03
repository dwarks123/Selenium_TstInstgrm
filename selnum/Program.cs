
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;
using System.Threading;

namespace selnum
{

    [TestFixture]
    class insta : hook
    {
        public insta() : base(browsertype.Chrome)
        {

        }
        [Test]
        public void rinsta()
        {

            driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.FindElement(By.Name("q")).SendKeys("Instagram");
            driver.FindElement(By.Name("btnK")).Click();
            driver.FindElement(By.XPath("//a[@href='https://www.instagram.com/']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//a[@href='/accounts/login/?source=auth_switcher']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("username")).SendKeys("jamesholderson6885");
            driver.FindElement(By.Name("password")).SendKeys("dwarakesh244");
            driver.FindElement(By.XPath("//*[contains(@class,'                  Igw0E     IwRSH      eGOV_         _4EzTm    bkEs3                          CovQj                  jKUp7          DhRcB                                                    ')]")).Click();

        }
    }
    ////////////////////////////
    ///

    [TestFixture]
    class facebook : hook
    {
        public facebook() : base(browsertype.Firefox)
        {
        }

        [Test]
        public void rface()
        {

            driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.FindElement(By.Name("q")).SendKeys("facebook");
            driver.FindElement(By.Name("btnK")).Click();
            driver.FindElement(By.XPath("//a[@href='http://www.facebook.com/']")).Click();
            driver.FindElement(By.Name("email")).SendKeys("9849719430");
            driver.FindElement(By.Name("pass")).SendKeys("screaming");
            driver.FindElement(By.Id("u_0_b")).Click();
            // driver.FindElement(By.Name("login")).Click();

        }
    }
    //////////////////////////////////////////////////
    ///

    class youtube : hook
    {
        public youtube() : base(browsertype.Chrome)
        {

        }
        [Test]
        public void rinsta()
        {

            driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.FindElement(By.Name("q")).SendKeys("youtube");
            driver.FindElement(By.Name("btnK")).Click();
            driver.FindElement(By.XPath("//a[@href='https://www.youtube.com/']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("search")).SendKeys("Selenium automation for C#");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[contains(@id,'search-icon-legacy')]")).Click();
            // driver.FindElement(By.Id("search-icon-legacy")).Click();
            // driver.FindElement(By.Id("video-title")).Click();
            // driver.FindElement(By.Id("text")).Click();

        }

    }

    class gmailac :hook
    {

        public gmailac() : base(browsertype.Firefox)
        {

        }
        [Test]
        public void gmac()
        {       
            driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.FindElement(By.Name("q")).SendKeys("gmail");
           driver.FindElement(By.Name("btnK")).Click();
            Thread.Sleep(3000);
             driver.FindElement(By.XPath("//a[@href='https://www.google.com/gmail/']")).Click();
            // driver.FindElement(By.XPath("//*[contains(@class,'h-c-header__nav-li-link ')]")).Click();
            driver.FindElement(By.LinkText("Sign in")).Click();
            Thread.Sleep(5000);
             //driver.FindElement(By.LinkText("Email or Phone")).SendKeys("lkjkkjok");

             driver.FindElement(By.LinkText("Next")).Click();
            IWebElement emt = driver.FindElement(By.CssSelector("#identifierId"));
            Thread.Sleep(8100);
            emt.SendKeys("darvebhat");

       

            //driver.FindElement(By.XPath("//*[contains(@class,'CwaK9')]")).Click();
        }
    }
    class reportpot : hook
    {

        public reportpot() : base(browsertype.Chrome)
        {

        }
        [Test]
        public void rmac()
        {
            driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.FindElement(By.Name("q")).SendKeys("hub thomson reuters");
            driver.FindElement(By.Name("btnK")).Click();
            Thread.Sleep(3000);
            
        }
    }
    class aumne : hook
    {

        public aumne() : base(browsertype.Chrome)
        {

        }
        [Test]
        public void aum()
        {   driver.Url = "";


            driver.Navigate().GoToUrl(driver.Url);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@name='txtUserName']")).SendKeys("admin");
            driver.FindElement(By.XPath(" //input[@type='password']")).SendKeys("admin");
            

            driver.FindElement(By.CssSelector("#btnLogin")).Click();
           
            


            Thread.Sleep(3000);

        }
    }

}
