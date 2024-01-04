namespace DVLD.WebAPI.AuthService
{
    public static class Policies
    {
        public static readonly string AuthSheme = "cookie";
        public static readonly string HaveUserName = "HaveUserName";
        public static readonly string HavePermissionValue2OrMore = "Permission>=2";
        public static readonly string AuthRequirmentTest = "AuthRequirmentTest";
    }
}
