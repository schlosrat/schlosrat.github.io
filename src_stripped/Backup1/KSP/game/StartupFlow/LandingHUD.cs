// Decompiled with JetBrains decompiler
// Type: KSP.Game.StartupFlow.LandingHUD
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.UserInterface;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.Game.StartupFlow
{
  [PrefabName("MainMenu.prefab")]
  public class LandingHUD : UIModule
  {
    private const string SINGLEPLAYER_ACTION_KEY = "SinglePlayer";
    private const string MULTIPLAYER_ACTION_KEY = "MultiPlayer";
    private const string SETTINGS_ACTION_KEY = "Settings";
    private const string LOGIN_ACTION_KEY = "LogIn";
    private const string EXIT_ACTION_KEY = "Exit";
    private const string EXTRAS_ACTION_KEY = "Extras";
    private const string CREDITS_ACTION_KEY = "Credits";
    private const string EULA_ACTION_KEY = "EULA";
    private const string PRIVACY_POLICY_ACTION_KEY = "PrivacyPolicy";
    private const string TERMS_OF_SERVICE_ACTION_KEY = "TermsOfService";
    private const string BACK_ACTION_KEY = "MainMenuBack";
    private const string SINGLEPLAYER_TEXT_PROPERTY_KEY = "SinglePlayerOptionText";
    private const string INCLUDE_MULTIPLAYER_PROPERTY_KEY = "ShouldIncludeMultiplayerMenu";
    private const string LOG_IN_TO_PD = "Menu/Main/LogInToPD";
    private const string QUIT_WARNING = "Menu/MainMenu/Quit warning";
    private const string QUIT_STRING = "Menu/MainMenu/Quit";
    private const string CANCEL_STRING = "Application/Cancel";
    private const string SINGLEPLAYER_STRING = "Menu/Main/Single Player";
    private const string CAMPAIGN_STRING = "Menu/Main/Campaign";
    private const string EXIT_WARNING = "Menu/MainMenu/ExitWarning";
    public CanvasGroup HudMenuItems;
    public CanvasGroup ExtrasMenuItems;
    public ContextBindRoot BindRoot;
    [Header("Sub Menus")]
    public CampaignMenu CampaignMenu;
    public GameObject MultiplayerMenu;
    public PDLoginMenu LogInMenu;
    public GameObject Credits;
    public LegalMenu LegalMenu;
    [Space]
    [SerializeField]
    private CanvasGroup _loginTopBar;
    [SerializeField]
    private TMP_Text _topBarButtonText;
    [SerializeField]
    [Header("Debug button")]
    private GameObject _devBypassLoginButton;
    [SerializeField]
    private GameObject _debugLogOutButton;
    private GameObject versionID;
    private DataContext _dataContext;
    private Property<string> _singlePlayerOptionText;
    private Property<bool> _shouldIncludeMultiplayerMenuOption;
    private bool _shouldIncludePDLogInMenuOption;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IsActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSinglePlayerMultiplayerModifications() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMenuItemsInteractable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SinglePlayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MultiPlayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Settings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Extras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowCredits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EULA() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrivacyPolicy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TermsOfService() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Back() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SingleplayerLogIn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTopBarText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSinglePlayerOptionText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RelocalizeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugShowBypassLoginButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowExitWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Exit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LandingHUD() => throw null;
  }
}
