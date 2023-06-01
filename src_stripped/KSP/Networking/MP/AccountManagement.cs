// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.AccountManagement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP
{
  public class AccountManagement
  {
    public const AccountManagementState DEFAULT_ACCOUNT_MANAGEMENT_STATE = AccountManagementState.None;
    public const AccountManagementOperation DEFAULT_ACCOUNT_MANAGEMENT_OPERATION = AccountManagementOperation.None;
    public const AccountLoginCodeState DEFAULT_ACCOUNT_LOGINCODE_STATE = AccountLoginCodeState.None;
    private AccountManagementState _accountManagementState;
    private long _timestampStateChanged;
    private AccountManagementOperation _accountManagementOperation;
    private bool _isBypass;
    private AccountLoginCodeState _accountLoginCodeState;
    private string _errorString;
    private string _userLoginCode;
    private bool _accountWindowOpened;
    private bool _isAuthorizationComplete;
    private bool _openBrowserOnLogin;
    private bool _isLoginProcessStarted;
    public int LoginRetryDelay;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AccountManagementState AccountManagementState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoggedOut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoggingIn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoggedIn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoggingOut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AccountLoginCodeState AccountLoginCodeState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool AccountCodeNotReceived
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsAccountCodeReceiving
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsAccountCodeReceived
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int MSInCurrentState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string TimeInCurrentStateString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AccountManagementOperation AccountManagementOperation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBypass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string UserLoginCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ErrorString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetErrorString(string errorString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearErrorString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AccountManagement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~AccountManagement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GotoAccountManagementState(
      AccountManagementState accountManagementState,
      bool force = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GotoAccountLoginCodeState(AccountLoginCodeState accountLoginCodeState, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpLoggedOut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpLoggingIn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpLoggingOut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpLoggedIn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpError() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pump() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpReceivingUserCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpReceivedUserCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PumpErrorUserCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PumpUserCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenAccountWindowOnReady() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckAuthorizationStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool StartLoggingIn(
      AccountManagementLogInMode accountManagementLogInMode,
      out string errorStringOut,
      string accountNameString = "",
      string accountPasswordString = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CancelLoggingIn(out string errorStringOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool StartLoggingOut(out string errorStringOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool StartFetchingUserCode(out string errorStringOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CancelFetchingUserCode(out string errorStringOut) => throw null;

    public string AccountNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string AccountGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ActivePlayerNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ActivePlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
