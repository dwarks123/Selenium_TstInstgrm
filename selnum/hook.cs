using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace selnum
{
    class hook : basde
    {
         public enum browsertype
        {
            Chrome,
            Firefox,
            IE
        }
        private browsertype tb;

        public hook(browsertype bt)
        {
            tb = bt;
            
        }
        [SetUp]
        public void initialteset()
        {
            chooseinstance(tb);
        }
        public void chooseinstance(browsertype btt)
        {
            if(btt == browsertype.Chrome)
            {
                driver = new ChromeDriver();
            }
            else if(btt == browsertype.Firefox)
            {
                driver = new FirefoxDriver();
            }
            else if(btt== browsertype.IE)
            {
                driver = new InternetExplorerDriver();
            }
        }

    }
}
