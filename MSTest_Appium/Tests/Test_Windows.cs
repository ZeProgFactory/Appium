using OpenQA.Selenium.Appium;
using ZPF.UITests;

namespace MauiApp.UITests;

[TestClass]
public class WindowsTests : TestBase_Windows
{
   public WindowsTests() : base()
   {
      // Constructor for this test class

      // 2)
   }


   // Runs once before all tests in this class
   [ClassInitialize]
   public static void ClassInit(TestContext context)
   {
      // Global setup for this test class

      // 1)
      // UITestViewModel.Current.Config.APP_WIN = @"C:\Path\To\Your\App.exe";  
      UITestViewModel.Current.Config.CompareBeforeAfter = true;
   }


   [TestMethod]
   public void CounterButton_IncrementsValue()
   {
      //var button = Driver.FindElement(MobileBy.AccessibilityId("CounterBtn"));
      var button = Driver.FindUIElement("CounterBtn");

      button.Click();
      button.Click();

      Assert.AreEqual("Clicked 2 times", button.Text);
   }
}
