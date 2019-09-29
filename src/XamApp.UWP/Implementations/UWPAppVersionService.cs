using Windows.ApplicationModel;
using UseMap.Contracts;

namespace UseMap.UWP.Implementations
{
    public class UWPAppVersionService : IAppVersionService
    {
        public string GetAppVersion()
        {
            return $"{Package.Current.Id.Version.Major}.{Package.Current.Id.Version.Minor}";
        }
    }
}
