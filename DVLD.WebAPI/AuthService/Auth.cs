namespace DVLD.WebAPI.AuthService
{
    public static class Auth
    {
        public static class Scheme
        {
            public const string DriverCookie = "driver-cookie";
            public const string UserCookie = "user-cookie";
        }

        public static class Policy
        {
            public const string UserPolicy = "user-policy";
            public const string DriverPolicy = "driver-policy";
        }

    }
}
