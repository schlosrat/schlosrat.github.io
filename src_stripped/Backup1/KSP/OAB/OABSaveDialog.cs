// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABSaveDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.IO;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class OABSaveDialog : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private InputFieldExtended _workspaceNameInput;
    [SerializeField]
    private InputFieldExtended _workspaceVehileNameInput;
    [SerializeField]
    private InputFieldExtended _workspaceDescriptionInput;
    [Space]
    [SerializeField]
    private OABSaveDialogExistingSave _saveEntryTemplate;
    [SerializeField]
    private Sprite _defaultPreviewImage;
    private Camera _workspaceView;
    private List<OABSaveDialogExistingSave> _saveEntries;
    private OABSaveDialogExistingSave _selectedEntry;
    private Transform _saveEntryParent;
    private string _targetFileName;
    private bool _savePending;
    private DataContext _OABSaveDialogContext;
    private Property<string> _workspaceName;
    private Property<string> _workspaceVehicleName;
    private Property<string> _workspaceDescription;
    private Property<Sprite> _workspacePreviewThumbnail;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWorkspaceName(string newName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWorkspaceVehicleName(string newName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWorkspaceDescription(string newDescription) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWorkspaceNameFieldEdited(string newName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SaveVehicleBuild() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Save() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteSaveFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopulateEntries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSaveEntries(IEnumerable<string> saves, IOProvider.DataLocation dataLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectExistingSaveEntry(OABSaveDialogExistingSave save, bool isSelected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSaveEntry(
      string fileName,
      OABSavedWorkspaceMetaInfo workspaceMetaInfo,
      string path = "",
      IOProvider.DataLocation dataLocation = IOProvider.DataLocation.OABWorkspacesActiveCampaign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D Resize(Texture2D thumbnailScreenshot, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABSaveDialog() => throw null;
  }
}
