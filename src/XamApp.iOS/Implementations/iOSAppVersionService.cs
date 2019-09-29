using Foundation;
using UseMap.Contracts;

namespace UseMap.iOS.Implementations
{
    public class iOSAppVersionService : IAppVersionService
    {
        public string GetAppVersion()
        {
            var infoDictionary = NSBundle.MainBundle.InfoDictionary;
            return infoDictionary?["CFBundleShortVersionString"] as NSString;
        }
    }
}
