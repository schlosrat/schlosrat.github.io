// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Const
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Networking.OnlineServices
{
  public static class Const
  {
    public const string PLAYFAB_TITLE_ID = "9096B";
    public const string TELEMETRY_ENDPOINT = "https://9096B.playfabapi.com/Client/WritePlayerEvent";
    public const string AUTHENTICATION_ENDPOINT_ANONYMOUS = "https://9096B.playfabapi.com/Client/LoginWithCustomID";
    public const string AUTHENTICATION_ENDPOINT_OPENID = "https://9096B.playfabapi.com/Client/LoginWithOpenIdConnect";
    public const string AUTHENTICATION_ENDPOINT_PLAYFAB = "https://9096B.playfabapi.com/Client/LoginWithEmailAddress";
    public const string AUTHENTICATION_ENDPOINT_STEAM = "https://9096B.playfabapi.com/Client/LoginWithSteam";
    public const string AUTHENTICATION_ENDPOINT_LINK_STEAM = "https://9096B.playfabapi.com/Client/LinkSteamAccount";
    public const string AUTHENTICATION_ENDPOINT_LINK_CUSTOM = "https://9096B.playfabapi.com/Client/LinkCustomID";
    public const string ACCOUNT_CREATION_ENDPOINT = "https://9096B.playfabapi.com/Client/RegisterPlayFabUser";
    public const string PLAYFAB_DISPLAY_NAME_ENDPOINT = "https://9096B.playfabapi.com/Client/UpdateUserTitleDisplayName";
    public const string PD_PROFILE_ENDPOINT = "https://account-dev.id.privatedivision.com/api/user";
    public const string PD_DEVICE_AUTHORIZE_ENDPOINT = "https://account-dev.id.privatedivision.com/oauth2/device_authorize";
    public const string PD_AUTH_TOKEN_ENDPOINT = "https://account-dev.id.privatedivision.com/oauth2/token";
    public const float PERCENT_USERS_ERRORS_LOGGED = 100f;
  }
}
