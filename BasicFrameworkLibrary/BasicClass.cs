using System.Web.Configuration;

namespace BasicFrameworkLibrary {
  public static class BasicClass
  {
    public static string SayHello(string name) => $"Hello, {name}";
    public static string[] GetAppSettings() => WebConfigurationManager.AppSettings.AllKeys;
  }
}