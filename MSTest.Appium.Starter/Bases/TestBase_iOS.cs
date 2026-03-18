using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Windows;
using ZPF.UITests;

namespace ZPF.UITests;

/// <summary>
/// Screenshots on failure & Page source on failure
/// </summary>
[TestClass]
public class TestBase_iOS
{
   /// <summary>
   /// MSTest exposes the test result in TestContext.
   /// </summary>
   public TestContext TestContext { get; set; }

   protected IOSDriver driver;


   [TestInitialize]
   public void Setup()
   {
      driver = DriverFactory.CreateIOSDriver();
      UITestViewModel.Current.TestContext = TestContext;
   }

   [TestCleanup]
   public void Cleanup()
   {
      var testName = TestContext.TestName;

      if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
      {
         ScreenshotHelper.Capture(driver, testName, TestContext, false);
         ScreenshotHelper.CapturePageSource(driver, testName, TestContext);
      }
      else
      {
         if (UITestViewModel.Current.Config.ScreenshotOnExit)
         {
            ScreenshotHelper.Capture(driver, testName, TestContext);
         }
      }

      driver?.Quit();
   }
}
