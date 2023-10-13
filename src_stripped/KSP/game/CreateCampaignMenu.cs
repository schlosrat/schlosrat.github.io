// Decompiled with JetBrains decompiler
// Type: KSP.Game.CreateCampaignMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    private const string DEFAULT_CAMPAIGN_NAME = "Menu/NewCampaign/Default Campaign Name";
    private const string DEFAULT_AGENCY_NAME = "Menu/NewCampaign/Default Agency Name";
    private const string DEFAULT_CAMPAIGN_NAME_SEPARATOR = " ";
    private const string OK_BUTTON_LOC_PATH = "Menu/TrainingCenter/OK";
    private const string ERROR_MESSAGE_TITLE_LOC_PATH = "Menu/NewCampaign/ErrorMessageTitle";
    private const string ERROR_MESSAGE_INVALID_CHARACTERS_LOC_PATH = "Menu/NewCampaign/ErrorMessageInvalidCharacters";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Space]
    [SerializeField]
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
    private GameModePicker _gameModeMenuScript;
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
    [Header("WarningModal")]
    [SerializeField]
    private CanvasGroup _warningModal;
    [SerializeField]
    private CanvasGroup _campaignNameWarning;
    public DataContext DataContext;
    private Property<bool> _canCampaignGameMode;
    private Property<string> _campaignGameMode;
    private Property<string> _difficultyOptions;
    private Property<string> _campaignNameText;
    private Property<string> _agencyNameText;
    private Property<bool> _isFTUEEnabled;
    private Property<string> _warningMessage;
    private CanvasGroup _currentSelectedMenu;
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
    public bool TrySetGameMode(string campaignMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGameModeText(string campaignMode) => throw null;

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
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LocalizeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CreateCampaignMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CreateCampaignMenu() => throw null;
  }
}
