// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABSaveDialogExistingSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.IO;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class OABSaveDialogExistingSave : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Space]
    private OABSaveDialog _owner;
    private DataContext _oabExisitingSaveFileDialogContext;
    private ToggleExtended _defaultSelectedToggle;
    private Property<string> _workspaceName;
    private Property<string> _vehicleName;
    private Property<string> _vehicleDescription;
    private Property<string> _vehiclePartsAndStages;
    private Property<string> _vehicleSaveDate;
    private Property<Sprite> _vehicleThumbnailImage;
    private Property<string> _warningMessage;
    private Property<bool> _showWarningTag;
    private OABSavedWorkspaceMetaInfo _workspaceMetaInfo;
    private IOProvider.DataLocation _dataLocation;

    public string Label
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string VehicleName
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

    public Sprite ThumbnailImage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string PartsAndStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SaveDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string SaveDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IOProvider.DataLocation DataLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      OABSaveDialog owner,
      string vesselName,
      OABSavedWorkspaceMetaInfo workspaceMetaInfo,
      string path,
      Sprite thumbnailImage,
      IOProvider.DataLocation dataLocation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteFileAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DeselectEntryIfWorkspaceNameChanged(string newWorkspaceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABSaveDialogExistingSave() => throw null;
  }
}
