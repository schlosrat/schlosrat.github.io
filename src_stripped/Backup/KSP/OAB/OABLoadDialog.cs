// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABLoadDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.IO;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI.Control;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class OABLoadDialog : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private ButtonExtended[] _interactableButtons;
    [Space]
    [SerializeField]
    private OABLoadDialogExistingSave _saveEntryTemplate;
    [SerializeField]
    private Sprite _defaultPreviewImage;
    [SerializeField]
    private ToggleGroupExtended _sortToggleGroup;
    private DataContext _OABLoadDialogContext;
    private List<OABLoadDialogExistingSave> _saveEntries;
    private OABLoadDialogExistingSave _selectedEntry;
    private Transform _saveEntryParent;
    private bool _clickedOnce;
    private SortingMethod _sortingMethod;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByRealWorldDateTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopulateEntries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateEntriesByDataLocation(
      IEnumerable<string> saves,
      IOProvider.DataLocation dataLocation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectExistingSaveEntry(OABLoadDialogExistingSave save, bool isSelected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OABLoadDialogExistingSave CreateSaveEntry(
      string entryName,
      OABSavedWorkspaceMetaInfo workspaceMetaInfo,
      bool isStock,
      string path = "",
      Texture2D texture = null,
      IOProvider.DataLocation dataLocation = IOProvider.DataLocation.OABWorkspacesActiveCampaign,
      string fileName = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Delete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteWorkspace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadWorkspace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MergeWorkspace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D Resize(Texture2D thumbnailScreenshot, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABLoadDialog() => throw null;
  }
}
