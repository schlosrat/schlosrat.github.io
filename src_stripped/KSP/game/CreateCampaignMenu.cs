// Decompiled with JetBrains decompiler
// Type: KSP.Game.CreateCampaignMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class CreateCampaignMenu : KerbalMonoBehaviour
  {
    private const string WINDOWS_ILLEGAL_CAMPAIGN_CHARACTERS = "\\ / : * ? \" < > |";
    private static char[] ILLEGAL_CAMPAIGN_CHARACTERS;
    public const string GAMEMODE_SANDBOX = "Menu/NewCampaign/Sandbox";
    public const string GAMEMODE_EXPLORATION = "Menu/NewCampaign/Exploration";
    private const string DEFAULT_CAMPAIGN_NAME = "Menu/NewCampaign/Default Campaign Name";
    private const string DEFAULT_AGENCY_NAME = "Menu/NewCampaign/Default Agency Name";
    private const string DEFAULT_CAMPAIGN_NAME_SEPARATOR = " ";
    private const string OK_BUTTON_LOC_PATH = "Menu/TrainingCenter/OK";
    private const string ERROR_MESSAGE_TITLE_LOC_PATH = "Menu/NewCampaign/ErrorMessageTitle";
    private const string ERROR_MESSAGE_INVALID_CHARACTERS_LOC_PATH = "Menu/NewCampaign/ErrorMessageInvalidCharacters";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    [Space]
    private GameObject _singleplayerCampaignMenu;
    [SerializeField]
    private CampaignMenu _campaignMenu;
    [SerializeField]
    [Header("Other Menus")]
    private CanvasGroup _gameModesMenu;
    [SerializeField]
    private CanvasGroup _difficultyMenu;
    [SerializeField]
    private DifficultyOptionsMenu _difficultyOptionsMenuScript;
    [SerializeField]
    private CanvasGroup _campaignNameMenu;
    [SerializeField]
    private CanvasGroup _agencyNameMenu;
    [SerializeField]
    private CanvasGroup _agencyFlagAndColorsMenu;
    [SerializeField]
    private AgencyFlagManager _agencyFlagManager;
    [SerializeField]
    private CanvasGroup _FTUEConfirmationDialog;
    [SerializeField]
    [Header("WarningModal")]
    private CanvasGroup _warningModal;
    [SerializeField]
    private CanvasGroup _campaignNameWarning;
    [SerializeField]
    private CampaignMode _defaultCampaignMode;
    public DataContext DataContext;
    private Property<string> _campaignGameMode;
    private Property<string> _difficultyOptions;
    private Property<string> _campaignNameText;
    private Property<string> _agencyNameText;
    private Property<bool> _isFTUEEnabled;
    private Property<string> _warningMessage;
    private CanvasGroup _currentSelectedMenu;
    private CampaignMode _selectedGameMode;
    private List<SaveFileInfo> _campaignSaves;
    private string _currentSelectedDifficultyOption;
    private string _defaultCampaignName;
    private string _localizedCampaignName;
    private string _cancelButtonTitle;
    private string _errorMessageTitle;
    private string _errorMessageInvalidCharacters;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupNewCampaignName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDefaultCampaignName(int defaultNumber) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartCampaignCreationFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckCampaignName(bool isCampaignNameAlreadyInUse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateNewCampaign() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameMode(CampaignMode campaignMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGameModeText(CampaignMode campaignMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCampaignBack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDifficultyOptions(string difficultyOptions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCampaignNameEndEdit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CancelCampaignNameWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfirmCampaignNameWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenGameModesMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenDifficultyMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenCampaignNameMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenAgencyNameMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenAgencyFlagAndColorsMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CloseSubMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CancelWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCampaignName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAgencyName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleFTUEConfirmationPanel(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CreateCampaignMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CreateCampaignMenu() => throw null;
  }
}
