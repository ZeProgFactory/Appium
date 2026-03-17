using OpenQA.Selenium.Appium;

namespace MauiApp.UITests;

[TestClass]
public class WindowsTests : WinTestBase   
{
   [TestMethod]
   public void CounterButton_IncrementsValue()
   {
      var button = driver.FindElement(MobileBy.AccessibilityId("CounterBtn"));

      button.Click();
      button.Click();

      Assert.AreEqual("Clicked 2 times", button.Text);
   }
}
