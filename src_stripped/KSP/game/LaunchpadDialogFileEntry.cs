// Decompiled with JetBrains decompiler
// Type: KSP.Game.LaunchpadDialogFileEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.IO;
using KSP.OAB;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class LaunchpadDialogFileEntry : KerbalMonoBehaviour
  {
    private const string MASS_SUFFIX = "Menu/Launchpad/t";
    private const string SIZE_SUFFIX = "Menu/Launchpad/m";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private TextMeshProUGUI _vehicleName;
    [SerializeField]
    private Image _vehicleThumbnail;
    [SerializeField]
    private LayoutElement _vehicleThumbnailParent;
    [SerializeField]
    private TextMeshProUGUI _numberOfPartsAndStages;
    [SerializeField]
    private TextMeshProUGUI _massAmount;
    [SerializeField]
    private TextMeshProUGUI _vehicleSize;
    private Property<string> _warningMessage;
    private Property<bool> _showWarningTag;
    private DataContext _launchpadFileEntryContext;
    private ToggleExtended _defaultSelectedToggle;
    private Sprite _thumbnailSprite;
    private string _vehicleSizeSuffix;
    private string _vehicleSizeSuffixComma;
    private OABSavedWorkspaceMetaInfo _workspaceMetaInfo;
    private IOProvider.DataLocation _dataLocation;

    public GameObjectPool<LaunchpadDialogFileEntry> ObjectPool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string FileName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public TextAsset FileAsset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string ThumbnailPath
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Stages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PartsAndStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Mass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsStock
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      string name,
      OABSavedWorkspaceMetaInfo workspaceMetaInfo,
      string fileName,
      Vector3 size,
      bool isStock,
      TextAsset fileAsset,
      bool isFirst = false,
      IOProvider.DataLocation dataLocation = IOProvider.DataLocation.OABWorkspacesActiveCampaign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Sprite GetSpriteForEntry(string thumbnailPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExecuteFileAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D Resize(Texture2D thumbnailScreenshot, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Log(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchpadDialogFileEntry() => throw null;
  }
}
