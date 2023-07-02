// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilderHUD
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Navigation;
using KSP.UI;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilderHUD : 
    KerbalMonoBehaviour,
    IDataContextProvider,
    IObjectAssemblyHUD
  {
    public ObjectAssemblyBuilder builder;
    public Camera _camera;
    public ObjectAssemblyViewCube viewCube;
    public AssemblyPartsPicker partsPicker;
    public AssemblyPartsPicker partsPickerBAE;
    public ObjectAssemblyHeader header;
    public ObjectAssemblyToolbar toolbar;
    public SpriteRenderer iconSprite;
    public ObjectAssemblyUIEngineeringReport engineeringReport;
    public ObjectAssemblyColorPicker colorPicker;
    public ObjectAssemblyPartsSearchFilter partSearchFilter;
    public ProceduralPartUI proceduralParts;
    public ProceduralFairingEditUI proceduralFairings;
    public ObjectAssemblyTooltip tooltip;
    [HideInInspector]
    public string lastSelectedWorkspaceFile;
    [HideInInspector]
    public string lastLoadedWorkspaceFile;
    public ObjectOutlinesManager objectOutlinesManager;
    public VABConsoleToolbox ConsoleToolbox;
    public QuickNavigationLayout QuickNavMenu;
    public DataContext dataContext;
    protected ContextBindRoot hudBindRoot;
    private ObjectAssemblyUIEvents eventsUI;
    private ObjectAssemblyBuilderEvents eventsBuilder;
    [SerializeField]
    private OABSideBar sideBar;
    [Header("Staging Related")]
    [SerializeField]
    private StagingUIBindRoot stagingTemplate;
    [SerializeField]
    private GameObject stagingParent;
    private OABStagingUIDriver stagingDriver;
    private StagingUIBindRoot stagingInstance;

    public int TotalStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IDataContextReadonly Context
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Canvas Canvas
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Camera Camera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindStagingEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUpContextBindRoot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVABUIReady() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraSet(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNewVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeClasses() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMainAssemblyChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageDeltaV(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EngineModeChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCursorImageUpdated(Texture2D image) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCursorPositionUpdated(bool visible, Vector2 screenPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowSideWidget(GameObject o, bool onscreen = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TogglePartsSearchFilter(bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOmitStagingMessages(bool omitStagingMsgs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyPartsPicker GetCurrentPartsPicker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilderHUD() => throw null;
  }
}
