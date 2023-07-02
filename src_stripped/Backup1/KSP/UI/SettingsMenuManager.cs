// Decompiled with JetBrains decompiler
// Type: KSP.UI.SettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Input;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class SettingsMenuManager : KerbalMonoBehaviour
  {
    private const string SETTINGS_ASSET_KEY = "SettingsMenu.prefab";
    private const string SETTINGS_MENU_LOC_PATH = "Menu/Settings/";
    private const string SHOW_GENERAL_ACTION_KEY = "ShowGeneralSettings";
    private const string SHOW_GAMEPLAY_ACTION_KEY = "ShowGameplaySettings";
    private const string SHOW_INPUT_ACTION_KEY = "ShowInputSettings";
    private const string SHOW_AUDIO_ACTION_KEY = "ShowAudioSettings";
    private const string SHOW_UI_ACTION_KEY = "ShowUISettings";
    private const string SHOW_ACCESSIBILITY_ACTION_KEY = "ShowAccessibilitySettings";
    private const string SHOW_GRAPHICS_ACTION_KEY = "ShowGraphicsSettings";
    private const string SHOW_MULTIPLAYER_ACTION_KEY = "ShowMultiplayerSettings";
    private const string APPLY_BUTTON_ACTION_KEY = "ApplySettings";
    private const string RESET_BUTTON_ACTION_KEY = "ResetSettings";
    private const string RESET_ALL_BUTTON_ACTION_KEY = "ResetAllSettings";
    private const string BACK_BUTTON_ACTION_KEY = "BackButton";
    private const string RESET_BUTTON_TEXT_PROPERTY_KEY = "ResetText";
    private const string IS_MAIN_MENU_PROPERTY_KEY = "IsMainMenu";
    private const string INCLUDE_MULTIPLAYER_PROPERTY_KEY = "ShouldIncludeMultiplayerMenu";
    private const string SETTING_DESCRIPTION_PROPERTY_KEY = "SettingDescription";
    private const string IS_CONFIRM_NOTIFI_VISIBLE_PROPERTY_KEY = "IsConfirmNotificationVisible";
    private const string CONFIRM_NOTIFICATION_PROPERTY_KEY = "ConfirmationNotificationText";
    private const string KEYBIND_INSTRUCTION_PROPERTY_KEY = "IsKeybindInstructionVisible";
    private const string IS_PROMPT_VISIBLE_PROPERTY_KEY = "IsPromptVisible";
    private const string PROMPT_TITLE_PROPERTY_KEY = "PromptTitle";
    private const string PROMPT_DESCRIPTION_PROPERTY_KEY = "PromptDescription";
    private const string LEFT_BUTTON_TEXT_PROPERTY_KEY = "LeftButtonText";
    private const string RIGHT_BUTTON_TEXT_PROPERTY_KEY = "RightButtonText";
    private const string LEFT_BUTTON_ACTION_KEY = "LeftButtonAction";
    private const string RIGHT_BUTTON_ACTION_KEY = "RightButtonAction";
    private const string RESET_TO_DEFAULT_LOC_KEY = "Reset to Default";
    private const string RESET_ALL_TO_DEFAULT_LOC_KEY = "Reset All to Default";
    private const string RESET_PROMPT_DESC_LOC_KEY_PREFIX = "ResetSettingsToDefaultDescription/";
    private const string RESET_ALL_PROMPT_DESC_LOC_KEY = "Reset All to Default description";
    private const string CANCEL_LOC_KEY = "Cancel";
    private const string RESET_LOC_KEY = "Reset";
    private const string GENERAL_LOC_KEY = "General";
    private const string GAMEPLAY_LOC_KEY = "Gameplay";
    private const string INPUT_LOC_KEY = "Input";
    private const string AUDIO_LOC_KEY = "Audio";
    private const string UI_LOC_KEY = "UserInterface";
    private const string ACCESSIBILITY_LOC_KEY = "Accessibility";
    private const string GRAPHICS_LOC_KEY = "Graphics";
    private const string CHANGES_APPLIED_LOC_KEY = "Changes Applied";
    private string _currentResetButtonLocKey;
    private string _currentDescriptionLocKey;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    private ToggleExtended _defaultCategoryToggle;
    [SerializeField]
    [Header("Settings menus")]
    private GeneralSettingsMenuManager _generalSettings;
    [SerializeField]
    private GameplaySettingsMenuManager _gameplaySettings;
    [SerializeField]
    private InputRebindingController _inputSettings;
    [SerializeField]
    private AudioSettingsMenuManager _audioSettings;
    [SerializeField]
    private UserInterfaceSettingsMenuManager _uiSettings;
    [SerializeField]
    private AccessibilitySettingsMenuManager _accessibilitySettings;
    [SerializeField]
    private GraphicsSettingsMenuManager _graphicsSettings;
    private DataContext _dataContext;
    private SettingsSubMenu _activeMenu;
    private Action _leftButtonAction;
    private Action _rightButtonAction;
    private Property<bool> _isPropmtVisible;
    private Property<string> _promptTitleText;
    private Property<string> _promptDescriptionText;
    private Property<string> _leftButtonText;
    private Property<string> _rightButtonText;
    private Property<bool> _isMainMenu;
    private Property<bool> _shouldIncludeMultiplayerMenuOption;
    private Property<string> _resetButtonText;
    private Property<string> _settingDescription;
    private Property<bool> _isConfirmNotificationVisible;
    private Property<string> _confirmationNotificationText;
    private Property<bool> _isKeybindInstructionVisible;
    private const float CONFIRMATION_DURATION = 3f;
    private float _confirmationTimer;

    public Property<bool> IsMainMenu
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Relocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible, bool isMainMenu = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSinglePlayerMultiplayerModifications() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleMenu(SettingsSubMenu menu) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseMenuSubOrSelf() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowGeneralSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowGameplaySettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowInputSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowAudioSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowUISettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowAccessibilitySettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowGraphicsSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowMultiplayerSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowChangesAppliedNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetAllSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BackButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseIfMainMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateResetButton(string settingsMenuLocalizationKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSettingsDescription(
      string descriptionLocalizationKey,
      bool isKeybindInstructionVisible = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowConfirmationNotification(string notificationLocalizationKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowPromptWindow(
      string promptTitle,
      string promptDescrition,
      string leftButtonText,
      Action leftButtonAction,
      string rightButtonText,
      Action rightButtonAction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLeftButtonClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRightButtonClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowResetSettingsPropmt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowResetAllSettingsPropmt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SettingsMenuManager() => throw null;
  }
}
