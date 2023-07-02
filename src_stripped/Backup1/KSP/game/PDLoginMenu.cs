// Decompiled with JetBrains decompiler
// Type: KSP.Game.PDLoginMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Networking.MP;
using KSP.UI.Binding;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class PDLoginMenu : KerbalMonoBehaviour
  {
    public ContextBindRoot BindRoot;
    public GameObject MultiplayerMenu;
    [SerializeField]
    private ButtonExtended _loginButton;
    [Header("Sub Menus")]
    public GameObject LinkPlatformAccountMenu;
    public GameObject LogInPDAccountMenu;
    public GameObject LinkPlatformAccountDone;
    public GameObject LogInPDAccountDone;
    public GameObject LoggingInMenu;
    public GameObject UserCodeLogIn;
    private DataContext _dataContext;
    private GameObject[] _submenus;
    private PDLoginSubmenu _currentSubmenu;
    private Property<string> _userCodeProperty;
    private AccountManagement _accountManagement;
    private Coroutine _loading;
    private bool _isMultiplayer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisibleSingleplayerMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisibleMultiplayerMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowCurrentLoginMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPDHyperlinkActivatePressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLogInPDPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLinkAccountsPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseLoginMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnContinuePressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLogInCancelButtonPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLogOutButtonPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSubMenuActive(PDLoginSubmenu newSubmenu, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitForLoggedIn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCopyUserCodePressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDevBypassLoginPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PDLoginMenu() => throw null;
  }
}
