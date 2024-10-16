using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MMO_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       private string randomString()
        {
            Random rand = new Random();
            string allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string user_name = string.Empty;
            for (int i = 0; i <= 10; i++)
            {
                user_name += allChar[rand.Next(allChar.Length)];
            }
            return user_name;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                //FirefoxProfile profile = new FirefoxProfile(@"C:\Users\admin\AppData\Roaming\Mozilla\Firefox\Profiles\80exhr9h.Test");
                //FirefoxOptions options = new FirefoxOptions();
               // options.Profile = profile;
                FirefoxDriver driver = new FirefoxDriver();
                driver.Url = "https://accounts.google.com/lifecycle/steps/signup/name?ddm=0&dsh=S-2046707672:1729005850021175&flowEntry=SignUp&flowName=GlifWebSignIn&TL=APps6eYPGTwkd2_n_6wuZfaWKmtrT38Kme1FnrIUF4roQFHX25qdOn2NH9KnisZ9";
                driver.Navigate();
               var continueButton = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[3]/div/div/div/div/button/span"));
               continueButton.Click();
               Thread.Sleep(1000);
            try
            {
                var textboxFirstName = driver.FindElement(By.Id("firstName"));
                textboxFirstName.SendKeys("Trung");
                Thread.Sleep(2000);
                var continueButton2 = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[3]/div/div/div/div/button/span"));
                continueButton2.Click();
                Thread.Sleep(1000);
                var textboxDay = driver.FindElement(By.Id("day"));
                textboxDay.SendKeys("15");
                Thread.Sleep(1000);
                var textboxYear = driver.FindElement(By.Id("year"));
                textboxYear.SendKeys("2005");
                var textboxMonth = driver.FindElement(By.Id("month"));
                textboxMonth.Click();
                textboxMonth.SendKeys("t");
                textboxMonth.Click();
                Thread.Sleep(1000);
                var textboxGender = driver.FindElement(By.Id("gender"));
                textboxGender.Click();
                textboxGender.SendKeys("n");
                textboxGender.Click();
                Thread.Sleep(1000);
                var continueButton3 = driver.FindElement(By.CssSelector(".VfPpkd-vQzf8d"));
                continueButton3.Click();
                try
                {
                    Thread.Sleep(2000);
                    var optionButton = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div/form/span/section/div/div/div[1]/div[1]/div/span/div[3]/div/div[1]/div/div[3]"));
                    optionButton.Click();
                    Thread.Sleep(2000);
                    var username = driver.FindElement(By.CssSelector(".whsOnd"));
                    username.SendKeys(randomString());
                    var continueButton4 = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[3]/div/div[1]/div/div/button/span"));
                    continueButton4.Click();
                }
                catch
                {
                    var userName = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div/form/span/section/div/div/div/div[1]/div/div[1]/div/div[1]/input"));
                    string user_name = randomString();
                    MessageBox.Show(user_name);
                    Thread.Sleep(2000);
                    userName.SendKeys(user_name);
                    var continueButton4 = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[3]/div/div[1]/div/div/button/span"));
                    continueButton4.Click();
                }
                Thread.Sleep(2000);
                var password = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div/form/span/section/div/div/div/div[1]/div/div/div[1]/div/div[1]/div/div[1]/input"));
                password.SendKeys("Trung1506");
                var confirmPassWord = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div/form/span/section/div/div/div/div[1]/div/div/div[2]/div/div[1]/div/div[1]/input"));
                confirmPassWord.SendKeys("Trung1506");
                var continueButton5 = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[3]/div/div[1]/div/div/button/span"));
                continueButton5.Click();
            }
            catch (Exception ex)
            {
                //driver.Quit();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
