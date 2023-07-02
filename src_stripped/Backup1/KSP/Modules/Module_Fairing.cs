// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Fairing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.OAB;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Fairing : PartBehaviourModule, IDynamicCargoOccluder
  {
    [SerializeField]
    private Data_Fairing _dataFairing;
    private ModuleAction _actionJettison;
    public List<FairingVisualizationMode> VisualizationModes;
    public List<MeshCollider> ClosedColliders;
    public List<AttachNodeRing> NodeRings;
    private Quaternion _attachNodeOrientation;
    public List<FairingPanel> Panels;
    public int NumberOfCollidersPerArc;
    private bool _isFairingUnderConstruction;
    private bool _isInitialized;
    private int _amountOfRings;
    private string _materialName;
    private Material _fairingMaterial;
    private Material _fairingConeMaterial;
    private bool _materialLoaded;
    private float _radius;
    private float _height;
    private float _panelMass;
    private float _lastRadiusBeforeCapped;
    private float _lengthAtAttachment;
    private FairingCrossSection _previousFairing;
    private FairingCrossSection _currentFairing;
    private List<PartBehavior> _enclosedParts;
    private ModuleProperty<bool>[] _ringToggles;
    private ModuleProperty<int>[] _ringCounts;
    private ModuleProperty<float>[] _ringDistances;
    private ModuleProperty<int>[] _ringSizes;
    private float _closeRadius;
    private Transform _modelTransform;
    private Renderer _baseRenderer;
    private Collider[] _baseColliders;
    private ProceduralFairingManager ConstructionManager;
    private DragCubeGenerator _dragCubeGenerator;
    private Data_Drag _dataDrag;
    private CorePartData _corePartData;
    private Module_Color _moduleColor;
    private IObjectAssemblyPartNode _floatingNode;
    private bool _isFloatingNodeConnectedToPart;
    private bool _fairingStarted;
    private const int MIN_SIDE_COUNT = 12;
    private int _currentVisibilityModeIndex;
    private Transform[] _pieceGroups;
    private Dictionary<GameObject, FairingPanel> _panelGameObjectMap;
    [NonSerialized]
    private Module_CargoBay _cargoModule;
    private Module_Engine _moduleEngine;
    private ObjectAssemblyPartTracker _oabPartTracker;
    private float _coneSweepOffset;
    private float _srfLevel;
    private float _srfHeight;
    private float _lastRadius;
    private bool _coneSweepHit;
    private bool _coneSweepHitLast;
    private bool _coneSweepClear;
    private RaycastHit _rcHit;
    public static string FAIRING_PROCEDURAL_MAT;
    public static string FAIRING_PROCEDURAL_FLIGHT_MAT;
    public static string FAIRING_PROCEDURAL_DRAG_CUBE_NAME;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SnapIncrement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool FairingConstructing
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsAutomated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMaterialLoaded(Material fairingMat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFairingEnabledValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsStagingEnabledValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckForNeededShroud(bool engineWithAttachedPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitForMaterialsAndSpawn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLengthChangedValue(float newLengthValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFloatingNodeEnabledChangedValue(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ObjectAssemblyAvailablePartNode CreateOABFloatingAttachNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartSeparated(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPlaced(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateTargetAttachmentDiameter(
      IObjectAssemblyPartNode hostNode,
      IObjectAssemblyPartNode otherNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRingAdded(MessageCenterMessage ringMsg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingCrossSection GetCurrentCrossSection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVisibilityChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnterEdit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnExitEdit(bool saveChanges, bool isSymmetrySibling = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateCrossSectionConeCast(
      FairingCrossSection currentCrossSec,
      FairingCrossSection previousCrossSec,
      Vector3 wAxis,
      Vector3 wPivot,
      Vector3 wFwd,
      out RaycastHit hit)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateDragCubes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCompleteDragCubeCalculation(DragCube cube) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDragCubes(bool jettisoned) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEnclosedParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShieldEnclosedParts(bool shield) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupOcclusionTest(bool testActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetClosedCollidersEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<PartBehavior> FindNearbyParts(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindEnclosedParts(List<PartBehavior> nearParts, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPartWithinBounds(PartBehavior nearPart, Bounds fairingBounds, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFairingDeployed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRingUnplace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnRingChangedState(bool newState, object sender) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNodeRingCountChanged(int newValue, object sender) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNodeRingSizeChanged(int newValue, object sender) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNodeRingDistanceChanged(float newValue, object sender) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onVesselModified(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onPartDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetFairingArea() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bounds GetFairingBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddPanelColliders(FairingPanel panel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SpawnMeshes(bool addColliders, bool offsetHeight = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WipeMesh() => throw null;

    [ContextMenu("Refresh panel meshes")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshPanels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMeshVisibility(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePanelMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateSimpleFairing(bool capped, float withRadius = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateConnectingCrossSection(float targetPartDiameter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResizeCrossSection(
      FairingCrossSection section,
      FairingCrossSection previous,
      float newSize,
      float newRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DetermineSealedState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private FairingCrossSection PlaceNewCrossSection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MeshPreviewUpdate(FairingCrossSection current, FairingCrossSection previous) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool WillCapOnPlace(FairingCrossSection current) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCrossSectionPlacement(
      FairingCrossSection currentXsc,
      Vector3 wAxis,
      Vector3 wPivot)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateScale(float addedRadius, float addedHeight, bool isSnapEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ClampH(float h) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ClampR(float r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float SnapR(float r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float SnapH(float h, float r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckAttachNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineStateChange(MessageCenterMessage engineMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateOrModifyAttachNodes(int ring) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPieceGroupsParent(Transform newParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformJettison() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformJettison(bool fairingNodeOccupied, bool createPhysicsObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformJettison(
      float jettisonForceScalar,
      bool fairingNodeOccupied,
      bool createPhysicsObjects)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TempPhysicsObject ConvertToTempPhysicsObject(GameObject groupGameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DispatchFX(PartBehavior part, KSPPartAudioManager audioManager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDeployTypeChanged(FairingDeployType newType) => throw null;

    [ContextMenu("Reset Piece Groups")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetPieceGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GroupPanelsIntoPieces(int numGroups) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Fairing() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Module_Fairing() => throw null;
  }
}
