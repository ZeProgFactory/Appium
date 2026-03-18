using OpenQA.Selenium.Appium;
using ZPF.UITests;

namespace MauiApp.UITests;

[TestClass]
public class WindowsTests : TestBase_Windows   
{
   [TestMethod]
   public void CounterButton_IncrementsValue()
   {
      //var button = driver.FindElement(MobileBy.AccessibilityId("CounterBtn"));
      var button = driver.FindUIElement("CounterBtn");

      button.Click();
      button.Click();

      Assert.AreEqual("Clicked 2 times", button.Text);
   }
}
