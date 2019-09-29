using Android.Content;
using UseMap.Contracts;

namespace UseMap.Droid.Implementations
{
    public class AndroidAppVersionService : IAppVersionService
    {
        public Android.Content.Context Context { get; set; }

        public string GetAppVersion()
        {
            return Context.PackageManager.GetPackageInfo(Context.PackageName, 0).VersionName;
        }
    }
}
