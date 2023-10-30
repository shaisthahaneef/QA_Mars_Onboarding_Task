using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaistha_onboarding.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
          
            driver.Manage().Window.Maximize();

            //Launch Website and navigate to login

            driver.Navigate().GoToUrl("http://localhost:5000/Home");


            //Navigate to signin page

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signInButton.Click();

            //identify Email Adress textbox and enter valid Email

            IWebElement emailAddressTextbox = driver.FindElement(By.Name("email"));
            emailAddressTextbox.SendKeys("shaisthahaneef@gmail.com");

            //identify password textbox and enter valid password

            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("Shanimoopa@1");

            //identify remember me box and check it

            IWebElement rememberMeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            rememberMeCheckbox.Click();

            //identify login button and click on the button

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();


        }


    }
}
