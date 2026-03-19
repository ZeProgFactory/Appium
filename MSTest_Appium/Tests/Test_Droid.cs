using OpenQA.Selenium.Appium;
using ZPF.UITests;

namespace MauiApp.UITests;

[TestClass]
public class AndroidTests : TestBase_Android
{
   // Runs once before all tests in this class
   [ClassInitialize]
   public static void ClassInit(TestContext context)
   {
      // Global setup for this test class

      // 1)
      // UITestViewModel.Current.Config.AndroidDeviceName = "Android Emulator"; // or your device name
      // UITestViewModel.Current.Config.APK = @"C:\Path\To\Your\App.apk";
   }


   [TestMethod]
   public void CounterButton_IncrementsValue()
   {
      // Find elements by MAUI AutomationId
      // var list = driver.FindElements(MobileBy.Id("com.companyname.maui:id/CounterBtn"));
      // var button = driver.FindElement(MobileBy.Id("com.companyname.maui:id/CounterBtn"));
      var button = Driver.FindUIElement("com.companyname.maui:id/CounterBtn");
      //var button = driver.FindElement(MobileBy.AccessibilityId("CounterBtn"));

      // Click button
      button.Click();
      button.Click();

      // Verify updated text
      Assert.AreEqual("Clicked 2 times", button.Text);
   }
}
