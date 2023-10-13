// Decompiled with JetBrains decompiler
// Type: KSP.Game.CampaignLoadMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
  public class CampaignLoadMenu : KerbalMonoBehaviour
  {
    private const long NUMBER_OF_FLIGHTS = 5;
    private const string GAME_MODE = "Menu/SaveLoad/GameMode";
    private const string GAME_TIME = "Menu/SaveLoad/GameTime";
    private const string LAST_PLAYED = "Menu/SaveLoad/LastPlayed";
    private const string DELETE_GAME_WARNING = "Menu/SaveLoad/DeleteGameWarning";
    public ContextBindRoot BindRoot;
    [Header("Campaign Menu")]
    [SerializeField]
    private CampaignMenu _campaignMenu;
    [Header("Load Game...")]
    [SerializeField]
    private RectTransform _saveGamesListParent;
    [SerializeField]
    private SaveLoadDialogFileEntry _fileEntryPrefab;
    [SerializeField]
    private SyncToggleGroupWithChildren _loadGameToggleGroup;
    [SerializeField]
    [Header("Save Game...")]
    private TextMeshProUGUI _lastPlayedLabel;
    [SerializeField]
    private TextMeshProUGUI _gameTimeLabel;
    [SerializeField]
    private TextMeshProUGUI _gameModeLabel;
    [SerializeField]
    private TextMeshProUGUI _lastPlayedText;
    [SerializeField]
    private TextMeshProUGUI _gameTimeText;
    [SerializeField]
    private TextMeshProUGUI _gameModeText;
    [Header("Save Game...")]
    [SerializeField]
    private int _excessDotsAmount;
    [Header("WarningModal")]
    [SerializeField]
    private CanvasGroup _warningModal;
    private GameObjectPool<SaveLoadDialogFileEntry> _fileEntryPrefabPool;
    private List<GameObject> _fileEntryUIControls;
    private bool _isInitialized;
    private bool _sortFileSavesByName;
    private string _currentSelectedSaveFilePath;
    private SaveLoadDialogFileEntry _currentSelectedSaveFileEntry;
    private DataContext _saveLoadDialogContext;
    private int _currentSaveFileCount;
    private Property<Sprite> _playerFlag;
    private Property<string> _campaignName;
    private Property<string> _saveName;
    private Property<float> _playerScience;
    private Property<long> _flights;
    private Property<string> _lastPlayed;
    private Property<string> _universeTime;
    private Property<string> _gameMode;
    private Property<string> _warningMessage;
    private CompareDateTime _comparer;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLoadMenuGameInformation(
      ExtendedSaveFileInfo fileInfo,
      Image thumnailScreenshot)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadSelectedFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteSaveWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteSaveFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleWarningMessageConfirmation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CancelWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwapFileSavesSortMethod() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAndRefillSavedGamesList(bool sortFilesByName, bool quicksave = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSaveLoadFileEntry(ExtendedSaveFileInfo fileInfo, bool isFirstFile) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RemoveUI(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixLabelVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWarningMessageVisibility(CanvasGroup canvasGroup, bool visibility) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignLoadMenu() => throw null;
  }
}
