// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Const
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    public const string ACCOUNT_CREATION_ENDPOINT = "https://9096B.playfabapi.com/Client/RegisterPlayFabUser";
    public const string CROSS_SAVE_UPLOAD_ENDPOINT = "https://9096B.playfabapi.com/File/InitiateFileUploads";
    public const string CROSS_SAVE_FINALIZE_UPLOAD_ENDPOINT = "https://9096B.playfabapi.com/File/FinalizeFileUploads";
    public const string CROSS_SAVE_DOWNLOAD_ENDPOINT = "https://9096B.playfabapi.com/File/GetFiles";
    public const string CROSS_SAVE_DELETE_ENDPOINT = "https://9096B.playfabapi.com/File/DeleteFiles";
    public const string SOCIAL_GET_FRIENDS_ENDPOINT = "https://9096B.playfabapi.com/Client/GetFriendsList";
    public const string SOCIAL_ADD_FRIEND_ENDPOINT = "https://9096B.playfabapi.com/Client/AddFriend";
    public const string SOCIAL_REMOVE_FRIEND_ENDPOINT = "https://9096B.playfabapi.com/Client/RemoveFriend";
    public const string SOCIAL_ADD_GENERIC_ID_ENDPOINT = "https://9096B.playfabapi.com/Client/AddGenericID";
    public const string SOCIAL_GET_GENERIC_ID_ENDPOINT = "https://9096B.playfabapi.com/Client/GetPlayFabIDsFromGenericIDs";
    public const string PLAYFAB_DISPLAY_NAME_ENDPOINT = "https://9096B.playfabapi.com/Client/UpdateUserTitleDisplayName";
    public const string PD_PROFILE_ENDPOINT = "https://account-dev.id.privatedivision.com/api/user";
    public const string PD_DEVICE_AUTHORIZE_ENDPOINT = "https://account-dev.id.privatedivision.com/oauth2/device_authorize";
    public const string PD_AUTH_TOKEN_ENDPOINT = "https://account-dev.id.privatedivision.com/oauth2/token";
    public const float PERCENT_USERS_ERRORS_LOGGED = 100f;
  }
}
