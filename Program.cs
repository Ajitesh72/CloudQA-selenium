using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Initialize ChromeDriver
        IWebDriver driver = new ChromeDriver();

        try
        {
            // URL to open
            string url = "https://app.cloudqa.io/home/AutomationPracticeForm";

            // Open the website
            driver.Navigate().GoToUrl(url);

             // Find the element by its ID ("fname")
            IWebElement inputElement_fname = driver.FindElement(By.Id("fname"));
            IWebElement inputElement_lname = driver.FindElement(By.Id("lname"));
            IWebElement inputElement_gender = driver.FindElement(By.Id("male"));
            IWebElement inputElement_dob = driver.FindElement(By.Id("dob"));
            IWebElement inputElement_mobile= driver.FindElement(By.Id("mobile"));
            IWebElement inputElement_email= driver.FindElement(By.Id("email"));
            IWebElement inputElement_country= driver.FindElement(By.Id("country"));
            IWebElement click_state_dropdown= driver.FindElement(By.Id("state"));
            IWebElement state_dropdown = driver.FindElement(By.XPath("//option[@value='India']"));

            // Input text "ajitesh" into the element
            inputElement_fname.SendKeys("ajitesh");
            inputElement_lname.SendKeys("dubey");
            inputElement_gender.Click();
            inputElement_dob.SendKeys("2003-03-31");
            inputElement_mobile.SendKeys("1111111111");
            inputElement_email.SendKeys("ajitesh@gmail.com");
            inputElement_country.SendKeys("India");
            click_state_dropdown.Click();
            state_dropdown.Click();

            // Wait for a few seconds (you can adjust the time as needed)
            // System.Threading.Thread.Sleep(1000);

            // Close the browser
            // driver.Quit();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
