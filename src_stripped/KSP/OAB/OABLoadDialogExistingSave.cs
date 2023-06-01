// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABLoadDialogExistingSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.IO;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class OABLoadDialogExistingSave : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Space]
    private OABLoadDialog _owner;
    private DataContext _oabExisitingSaveFileDialogContext;
    private ToggleExtended _defaultSelectedToggle;
    private Property<string> _vehicleName;
    private Property<string> _vehicleDescription;
    private Property<string> _vehiclePartsAndStages;
    private Property<string> _vehicleSaveDate;
    private Property<string> _warningMessage;
    private Property<Sprite> _vehicleThumbnailImage;
    private Property<bool> _showWarningTag;
    private Property<bool> _isStock;
    private IOProvider.DataLocation _dataLocation;
    private OABSavedWorkspaceMetaInfo _workspaceMetaInfo;

    public string Label
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Path
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string Content
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Sprite ThumbnailImage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string PartsAndStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SaveDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string SaveDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float Mass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsStock
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IOProvider.DataLocation DataLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string FileName
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
      OABLoadDialog owner,
      string entryName,
      OABSavedWorkspaceMetaInfo workspaceMetaInfo,
      string path,
      bool isStock,
      Sprite thumbnailImage,
      IOProvider.DataLocation dataLocation,
      string fileName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteFileActions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABLoadDialogExistingSave() => throw null;
  }
}
