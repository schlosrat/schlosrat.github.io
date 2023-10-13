// Decompiled with JetBrains decompiler
// Type: KSP.Game.SaveLoadDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class SaveLoadDialog : KerbalMonoBehaviour
  {
    private const long NUMBER_OF_FLIGHTS = 5;
    private const string LOG_FILTER = "[SaveLoadGameDialog] - ";
    private const string SAVE = "Menu/SaveLoad/Save";
    private const string GAME_MODE = "Menu/SaveLoad/GameMode";
    private const string GAME_TIME = "Menu/SaveLoad/GameTime";
    private const string LAST_PLAYED = "Menu/SaveLoad/LastPlayed";
    private const string OVERWRITE_GAME_WARNING = "Menu/SaveLoad/OverwriteGameWarning";
    private const string SAVE_FILE_INVALID_NAME_ERROR_TITLE = "Menu/SaveLoad/SaveFileInvalidNameErrorTitle";
    private const string SAVE_FILE_EMPTY_NAME_ERROR = "Menu/SaveLoad/EmptySaveFileNameWarning";
    private const string SAVE_FILE_INVALID_CHARACTERS_ERROR = "Menu/SaveLoad/InvalidCharacterSaveFileNameWarning";
    private const string VESSEL_UNAVAILABLE = "Menu/Main/VesselUnavailable";
    private const string VESSEL_NAME_UNSET = "Menu/Main/VesselNameUnset";
    private const string LOCATION_UNAVAILABLE = "Menu/Main/LocationUnavailable";
    private const string OK_BUTTON_LOC_PATH = "Menu/TrainingCenter/OK";
    private const string ILLEGAL_CHARACTERS = "\\ / : * ? \" < > |";
    private static char[] INVALID_FILENAME_CHARACTERS;
    public ContextBindRoot BindRoot;
    [HideInInspector]
    public bool IsLoading;
    [Header("Load Game...")]
    [SerializeField]
    private RectTransform _loadGameHeader;
    [SerializeField]
    private RectTransform _saveGamesListParent;
    [SerializeField]
    private RectTransform _scrollView;
    [SerializeField]
    private SaveLoadDialogFileEntry _fileEntryPrefab;
    [SerializeField]
    private SyncToggleGroupWithChildren _loadGameToggleGroup;
    [SerializeField]
    private RectTransform _loadGameButtons;
    [Header("Save Game...")]
    [SerializeField]
    private RectTransform _saveGameHeader;
    [SerializeField]
    private RectTransform _saveGameContent;
    [SerializeField]
    private InputFieldExtended _saveFileName;
    [SerializeField]
    private RectTransform _saveGameButtons;
    [SerializeField]
    private RectTransform _saveOverwrite;
    [SerializeField]
    private TextMeshProUGUI _lastPlayedLabel;
    [SerializeField]
    private TextMeshProUGUI _gameTimeLabel;
    [SerializeField]
    private TextMeshProUGUI _gameModeLabel;
    [SerializeField]
    private int _excessDots;
    [SerializeField]
    private ContextBindRoot _universalTimeBindRoot;
    [Header("Both...")]
    [SerializeField]
    private GameObject _horizontalInfoGameObject;
    [SerializeField]
    [Header("WarningModal")]
    private CanvasGroup _warningModal;
    [SerializeField]
    private DOTweenAnimation _showAnimation;
    [SerializeField]
    private DOTweenAnimation _hideAnimation;
    private GameObjectPool<SaveLoadDialogFileEntry> _fileEntryPrefabPool;
    private List<GameObject> _fileEntryUIControls;
    private string _newSaveFileName;
    private bool _isInitialized;
    private bool _refreshSaveGameContent;
    private bool _currentIsLoadingState;
    private bool _hasRunOnce;
    private bool _sortFileSavesByName;
    private string _currentSelectedSaveFilePath;
    private SaveLoadDialogFileEntry _currentSelectedSaveFileEntry;
    private DataContext _saveLoadDialogContext;
    private int _currentSaveFileCount;
    private RectTransform _rectTransformParent;
    private RectTransform _rectTransform;
    private CanvasGroup _dialogCanvasGroup;
    private bool _isFirstOpening;
    private Property<Sprite> _playerFlag;
    private Property<string> _campaignName;
    private Property<string> _saveName;
    private Property<string> _lastPlayed;
    private Property<string> _universeTime;
    private Property<string> _gameMode;
    private Property<double> _timeDisplay;
    private Property<string> _activeVessel;
    private Property<string> _currentLocation;
    private Property<string> _warningMessage;
    private bool _isVisible;

    public string CurrentSelectedFilePath
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SaveLoadDialogFileEntry CurrentSelectedFileEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int CurrentSaveFilesCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisiblity(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnHideAnimationComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSaveMenuGameInformation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLoadMenuGameInformation(
      ExtendedSaveFileInfo fileInfo,
      Image thumnailScreenshot)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadSelectedFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnNewSaveFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SaveFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidName(TMP_InputField saveFileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopInvalidFileNameWarningDialog(bool isNullOrEmpty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CancelWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAndRefillSavedGamesListIfVisible(bool sortFilesByName, bool quicksave = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAndRefillSavedGamesList(bool sortFilesByName, bool quicksave = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSaveLoadFileEntry(ExtendedSaveFileInfo fileInfo, bool isFirstFile) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOverwriteNameToBeSelected(string selectedOverwriteSaveName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOverwriteNameToDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwapSaveFileSortMethod() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RemoveUI(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReturnToEscapeMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDismissDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string SaveFilePathBuilder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixLabelVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWarningMessageVisibility(CanvasGroup canvasGroup, bool visibility) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveLoadDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SaveLoadDialog() => throw null;
  }
}
