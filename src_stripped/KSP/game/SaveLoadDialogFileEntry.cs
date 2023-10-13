// Decompiled with JetBrains decompiler
// Type: KSP.Game.SaveLoadDialogFileEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class SaveLoadDialogFileEntry : KerbalMonoBehaviour
  {
    public ContextBindRoot BindRoot;
    public const string LOC_VESSEL_UNAVAILABLE = "Menu/Main/VesselUnavailable";
    public const string LOC_LOCATION_UNAVAILABLE = "Menu/Main/LocationUnavailable";
    [Header("Save Card Labels")]
    [SerializeField]
    private TextMeshProUGUI _labelSaveName;
    [SerializeField]
    private TextMeshProUGUI _labelVehicle;
    [SerializeField]
    private TextMeshProUGUI _labelLocation;
    [SerializeField]
    private TextMeshProUGUI _labelGameTime;
    [Header("Thumnail Image")]
    [SerializeField]
    private RectTransform _thumbnailHolder;
    [SerializeField]
    private Image _thumbnailScreenshot;
    [SerializeField]
    private Sprite _defaultThumbnailSprite;
    [Header("Save Type Tag")]
    [SerializeField]
    private GameObject _tagHolder;
    [SerializeField]
    private TextMeshProUGUI _labelLastPlayedTime;
    [HideInInspector]
    public ExtendedSaveFileInfo _fileInfo;
    private bool _isLoading;
    private bool _isLastPlayed;
    private int _thumnailWidth;
    private int _thumbnailHeight;
    private Texture2D _thumbnailTexture2D;
    private ToggleExtended _defaultSelectedToggle;
    private DataContext _saveLoadFileEntryDialogContext;
    private CampaignLoadMenu _campaignLoadMenu;
    private Property<double> _timeDisplay;

    public bool IsLoading
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsLastPlayed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    public GameObjectPool<SaveLoadDialogFileEntry> ObjectPool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ExtendedSaveFileInfo fileInfo, bool loading, bool isLastPlayed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetThumbnailSprite(ExtendedSaveFileInfo fileInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      ExtendedSaveFileInfo fileInfo,
      bool isLastPlayed,
      CampaignLoadMenu campaignLoadMenu)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentToggleState(bool lastPlayed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExecuteFileAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D Resize(Texture2D thumbnailScreenshot, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveLoadDialogFileEntry() => throw null;
  }
}
