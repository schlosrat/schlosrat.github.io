// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Authentication.AuthenticationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
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
    private const char EPIC_CMD_LINE_DELIMITER = '=';
    private HTTPRequestHelper _helper;
    private static AuthenticationManager instance;
    private string _currentLoginTryID;
    private bool _platformLoggedIn;
    private bool _platformIsLoggingIn;
    private bool _anonymousLoggedIn;
    private string _authTicket;
    public AuthenticationManager.LoginEvent OnAnonymousLoginSuccess;
    public AuthenticationManager.LoginEvent OnPlatformLoginSuccess;
    public AuthenticationManager.LoginEvent OnAnonymousLoginFailure;
    public AuthenticationManager.LoginEvent OnPlatformLoginFailure;
    public bool IsLoggingIn;
    public static string OnlinePlayerNameString;
    public static string OnlinePlayerGuidString;
    public static string DeviceCode;
    public static string LoginLink;
    public static string UserCode;
    public static string PDAuthTicket;
    public static string PlayFabSessionTicket;
    public static string PlayFabID;
    public static string PlayFabEntityToken;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

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

    public static bool AuthenticationComplete
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
    private void PlatformInitializedCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAuthenticatedWithPlayFab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetOnlinePlayerGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetOnlinePlayerNameString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitiateTimedSteamLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator TimedSteamLogin(int numTries, float timeoutDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitiateTimedAnonLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator TimedAnonLogin(int numTries, float timeoutDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SteamLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlatformLoginCallback(bool loginSuccess, string error = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AnonymousLogin(string LoginTryID, AuthenticationManager.Platform platform = AuthenticationManager.Platform.None) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AnonymousLoginCallback(bool loginSuccess, string LoginTryID, string error = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoginPlayFabOpenIdConnect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string InitiateLogin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator InitiateLoginEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator GetDeviceCode(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FinalizeLogin(string deviceCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPrivateDivisionUsername() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetPrivateDivisionUsernameCallback(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Logout() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConfirmLoginStatus() => throw null;

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
      string username = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PrivateDivisionJWTResponse DecodeJWT(string token) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AuthenticationManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AuthenticationManager() => throw null;

    private enum Platform
    {
      None,
      DRMFree,
      Epic,
      Steam,
    }

    public delegate void LoginEvent();
  }
}
