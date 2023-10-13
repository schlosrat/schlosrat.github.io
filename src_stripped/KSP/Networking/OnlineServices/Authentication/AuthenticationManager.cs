// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Authentication.AuthenticationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Networking.OnlineServices.Authentication.Models;
using System.Collections;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Authentication
{
  public class AuthenticationManager
  {
    private const float LOGIN_TIMEOUT_DURATION = 10f;
    private const int MAX_LOGIN_TRIES = 3;
    private const string EPIC_USERID_CMD_LINE_ARG = "-epicuserid";
    private const string EPIC_USERNAME_CMD_LINE_ARG = "-epicusername";
    private const char EPIC_CMD_LINE_DELIMITER = '=';
    private HTTPRequestHelper _helper;
    private static AuthenticationManager instance;
    private string _currentLoginTryId;
    private bool _platformLoggedIn;
    private bool _platformIsLoggingIn;
    private bool _platformLinked;
    private bool _platformIsLinking;
    private bool _anonymousLoggedIn;
    private string _authTicket;
    public AuthenticationManager.LoginEvent OnAnonymousLoginSuccess;
    public AuthenticationManager.LoginEvent OnPlatformLoginSuccess;
    public AuthenticationManager.LoginEvent OnAnonymousLoginFailure;
    public AuthenticationManager.LoginEvent OnPlatformLoginFailure;
    public bool IsLoggingIn;
    private static string _pdUsername;
    private static string _firstPartyUsername;
    private static string _pdId;
    private static string _firstPartyId;
    public static string DeviceCode;
    public static string LoginLink;
    public static string UserCode;
    public static string PDAuthTicket;
    public static string PlayFabSessionTicket;
    public static string PlayFabId;
    public static string PlayFabEntityToken;

    public static string EntityKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static string PlayFabTelemetrySessionTicket
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static bool LoginLinkReady
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool DeviceCodeReady
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static AuthenticationManager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AuthenticateTo(AuthenticationManager.LoginProvider loginProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAuthenticated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAuthenticatedWithPDId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAuthenticatedWithFirstParty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAuthenticatedWithTelemetryProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Logout() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlatformInitializedCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetPDId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetPDUsername() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetPlayFabId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetFirstPartyId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetFirstPartyUsername() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetOnlinePlayerGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetOnlinePlayerNameString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitiateTimedAnonLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoginPlayFabOpenIdConnect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string InitiatePDIdLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FinalizePDIdLogin(string deviceCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPrivateDivisionUsername() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConfirmLoginStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator TimedAnonLogin(int numTries, float timeoutDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignSteamUserInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitiateTimedSteamLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitiateTimedLinkWithSteam() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SteamLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator TimedSteamLogin(int numTries, float timeoutDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator TimedLinkWithSteam(int numTries, float timeoutDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator LinkWithSteam() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlatformLoginCallback(bool loginSuccess, string error = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlatformLinkCallback(bool linkSuccess, string error = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AnonymousLogin(
      string LoginTryID,
      AuthenticationManager.LoginProvider platform = AuthenticationManager.LoginProvider.None)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AnonymousLoginCallback(bool loginSuccess, string LoginTryID, string error = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string InitiateLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator InitiateLoginEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator StorePDLoginDeviceCode(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetPrivateDivisionUsernameCallback(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAccessToken(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetPlayFabSessionTicket(string entityKeyResponse, string error = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayName(string onlinePlayerID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayNameCallback(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ProcessPlayFabLoginResponse(
      string entityKeyResponse,
      string error = "",
      string username = "",
      bool isFirstParty = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PrivateDivisionJWTResponse DecodeJWT(string token) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AuthenticationManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AuthenticationManager() => throw null;

    public delegate void LoginEvent();

    public enum LoginProvider
    {
      None,
      PDId,
      Epic,
      Steam,
    }
  }
}
