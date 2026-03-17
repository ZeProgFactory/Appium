using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace MauiApp.UITests;

/// <summary>
/// Handles screenshots + page source capture.
/// </summary>
public static class ScreenshotHelper
{
   public static void Capture(AppiumDriver driver, string testName, TestContext context)
   {
      var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
      var fileName = Path.Join(DriverFactory.TestResults, $"FAIL_{testName}_{timestamp}.png");

      var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
      //screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Png);
      screenshot.SaveAsFile(fileName);

      context.AddResultFile(fileName);
   }

   public static void CapturePageSource(AppiumDriver driver, string testName, TestContext context)
   {
      var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
      var fileName = Path.Join(DriverFactory.TestResults, $"FAIL_{testName}_{timestamp}.xml");

      File.WriteAllText(fileName, driver.PageSource);
      context.AddResultFile(fileName);
   }
}
