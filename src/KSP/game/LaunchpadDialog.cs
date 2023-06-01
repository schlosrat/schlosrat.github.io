// Decompiled with JetBrains decompiler
// Type: KSP.Game.LaunchpadDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.IO;
using KSP.Messages;
using KSP.OAB;
using KSP.Sim.impl;
using KSP.UI;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class LaunchpadDialog : KerbalMonoBehaviour
  {
    private const string NO_CRITICAL_CONCERNS = "Menu/Launchpad/NoCriticalConcerns";
    private const string CONFIRM_BEFORE_RECOVER = "Menu/Launchpad/ConfirmRecoverMessage";
    private const string RECOVER = "Menu/Launchpad/Recover";
    private const string IS_CLEAR = "Menu/Launchpad/ClearLaunchpadMessage";
    private const string AT_LAUNCHPAD = "Menu/Launchpad/VesselInLaunchpad";
    private const string KSC_LOC_PATH = "Menu/KSC/";
    [SerializeField]
    private ContextBindRoot bindRoot;
    [SerializeField]
    private CanvasGroup crewManagerCanvasGroup;
    [SerializeField]
    private CanvasGroup editVesselButton;
    [SerializeField]
    private CanvasGroup launchpadClearMessage;
    [SerializeField]
    private CanvasGroup vehicleInfo;
    [SerializeField]
    private CanvasGroup listVehiclePanelCanvasGroup;
    [SerializeField]
    private GameObject atLaunchpad;
    [SerializeField]
    private GameObject savedVehiclesList;
    [SerializeField]
    private LaunchpadDialogFileEntry fileEntryPrefab;
    [SerializeField]
    private RectTransform vehicleListParent;
    [SerializeField]
    private SyncToggleGroupWithChildren toggleGroup;
    [SerializeField]
    private ButtonExtended recoverVehicleButton;
    [SerializeField]
    private Sprite defaultSpriteThumbnail;
    [Header("Filters")]
    public AssemblyPartFilterType currentFilter;
    public DropdownExtended sortingDropdown;
    private GameObjectPool<LaunchpadDialogFileEntry> _fileEntryPrefabPool;
    private List<GameObject> _fileEntryUIControls;
    private List<LaunchpadDialogFileEntry> _vehiclesSaveList;
    private List<VesselComponent> _nearbyVessels;
    private CanvasGroup _dialogCanvasGroup;
    private CanvasGroup _recoverVehicleBtnCanvasGroup;
    private DataContext _launchpadDataContext;
    private RectTransform _rectTransformParent;
    private RectTransform _rectTransform;
    private bool _stockHidden;
    private bool _isVisible;
    private LaunchpadFileIO _launchpadFileIO;
    private ObjectAssemblySortingDropdownOptions _sortingDropdownData;
    private Property<Sprite> _vehicleThumbnail;
    private Property<Sprite> _missionFlag;
    private Property<string> _vehicleName;
    private Property<string> _vehicleDescription;
    private Property<string> _criticalConcerns;
    private Property<string> _launchpadVehicleName;
    private Property<string> _launchpadName;
    private Property<string> _atLaunchpad;
    private Property<string> _launchpadClearMessage;
    private Property<bool> _vehiclesAvailable;
    private Property<bool> _vehiclesAvailableOrOnLaunchPad;
    private Property<bool> _isSortOrderAscending;
    private SubscriptionHandle _onShuttingDownGameHandle;

    public GameObjectPool<LaunchpadDialogFileEntry> ObjectPool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string CurrentSelectedSaveFileName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IOProvider.DataLocation CurrentSelectedSaveFileDataLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public TextAsset CurrentSelectedSaveFile
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CanvasGroup VehicleInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CanvasGroup LaunchpadClearMessage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateAndLocalizeDropdownOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckIfVehicleAvailable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SavedVehiclesList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MultiplayerList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideStock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVisibleVehicleStocks(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EditVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowCrewManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideCrewManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecoverVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LaunchVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TakeControlOfVesselAtLauchsite(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfirmVehicleRecovery() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetClearMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateEntries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateEntriesByDataLocation(
      IEnumerable<string> saves,
      IOProvider.DataLocation dataLocation,
      ref bool isFirst,
      ref bool vehiclesAvailableSet)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetThumbnailExtension(string potentialStringWithExtensionWeWant = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSaveLoadFileEntry(
      string entryName,
      OABSavedWorkspaceMetaInfo workspaceMetaInfo,
      string path,
      bool isStock,
      TextAsset fileAsset,
      bool isFirst,
      IOProvider.DataLocation dataLocation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSelectedVehicleInformation(
      string name,
      string description,
      string fileName,
      TextAsset stockVesselfile,
      IOProvider.DataLocation dataLocation,
      Sprite thumbnail,
      List<string> criticalConcernLocTerms)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDropdownValueChanged(int newIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVisibleVehiclesFilters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFilterButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSortOrderChanged(bool orderChanged) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool visibility) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRecoverFlowVisible(bool recover, bool editVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCanvasGroupVisibility(CanvasGroup canvasGroup, bool visibility) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAllSaveFileEntriesActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStartGameShutdown(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Log(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchpadDialog() => throw null;
  }
}
