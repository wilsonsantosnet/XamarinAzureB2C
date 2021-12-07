﻿namespace XamarinB2C
{
    internal class Constants
    {
        // set your tenant name, for example "contoso123tenant"
        static readonly string tenantName = "seedazb2c";

        // set your tenant id, for example: "contoso123tenant.onmicrosoft.com"
        static readonly string tenantId = "seedazb2c.onmicrosoft.com";

        // set your client/application id, for example: aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"
        static readonly string clientId = "a39d9297-9367-4315-8a9e-a24c9fd2a769";

        // set your sign up/in policy name, for example: "B2C_1_signupsignin"
        static readonly string policySignin = "b2c_1_sigin_apimsm";

        // set your forgot password policy, for example: "B2C_1_passwordreset"
        static readonly string policyPassword = "b2c_1_password_reset";

        // set to a unique value for your app, such as your bundle identifier. Used on iOS to share keychain access.
        static readonly string iosKeychainSecurityGroup = "com.xamarin.adb2cauthorization";



        // The following fields and properties should not need to be changed
        static readonly string[] scopes = { "openid", "offline_access" };
        static readonly string authorityBase = $"https://{tenantName}.b2clogin.com/tfp/{tenantId}/";
        public static string ClientId
        {
            get
            {
                return clientId;
            }
        }
        public static string AuthoritySignin
        {
            get
            {
                return $"{authorityBase}{policySignin}";
            }
        }
        public static string AuthorityPasswordReset
        {
            get
            {
                return $"{authorityBase}{policyPassword}";
            }
        }
        public static string[] Scopes
        {
            get
            {
                return scopes;
            }
        }
        public static string IosKeychainSecurityGroups
        {
            get
            {
                return iosKeychainSecurityGroup;
            }
        }
    }
}
