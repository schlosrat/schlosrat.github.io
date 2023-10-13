// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyPart : 
    MonoBehaviour,
    IObjectAssemblyPart,
    IFlowNode,
    IDeltaVPart,
    IEquatable<IDeltaVPart>,
    IInteractivePart
  {
    private Transform _attachmentOffsetTransform;
    private MeshRenderer _attachmentOffsetMeshRender;
    private bool _surfaceAttachInfoProvided;
    private Transform _transform;
    private IGGuid _uniqueId;
    private ObjectAssemblyBuilderEvents _builderEvents;
    private double mass;
    private double massModifyAmount;
    private double resourceMass;
    private double greenMass;
    private int _currentKerbalCountTotal;
    private IObjectAssemblyPart parentPart;
    private IObjectAssemblyPart originalPart;
    private Quaternion userRotationOffset;
    private Quaternion _automaticSuggestedRotation;
    private IObjectAssembly _assembly;
    private bool _canStage;
    private Transform m_transform;
    private bool hasInitTransform;
    private Bounds cachedBounds;
    private Vector3 cachedBoundsPosition;
    private bool isBoundsDirty;

    public Transform PartTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSymmetryMirrored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MirrorTechnique MirrorTechnique
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OABOrientation OrientationPreference
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool CanSuggestOrientation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public DictionaryValueList<System.Type, IPartModule> Modules
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public List<SerializedPartModule> RawPartModules
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<IObjectAssemblyPartNode> Nodes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IObjectAssemblyResource[] Resources
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IResourceContainer[] Containers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public AssemblySizeFilterType PartSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float StaticPressureAtm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float StaticPressureAtmASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericTemperatureASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmDensityASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartResourceCostDefinition[] ResourceCosts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IResourceContainer[] DeltaVContainers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PartName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid UniqueId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IGGuid GlobalId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(IDeltaVPart other) => throw null;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ResourceFlowRequestBroker ResourceFlowRequestBroker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsFinalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double DryMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double WetMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ResourceMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double GreenMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TotalMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Collider[] Colliders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int ActivationStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int DecoupleStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int InStageIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasChildren() => throw null;

    public IGGuid Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCategoryName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDisplayName() => throw null;

    public IObjectAssemblyPartNode MyNodeConnectedToParent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyPartNode ParentNodeConnectedToMe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyPart ParentPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IDeltaVPart Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentPart(IObjectAssemblyPart value) => throw null;

    public IObjectAssemblyPart OriginalPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOriginalPart(IObjectAssemblyPart value) => throw null;

    public IObjectAssemblyAvailablePart AvailablePart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<Transform> FindModelTransforms(string transformName) => throw null;

    public List<IObjectAssemblyPart> Children
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IEnumerable<IDeltaVPart> DeltaVChildren
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPart GetAnchorPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDeltaVPart FindAttachNodeAttachedPart(string nodeName) => throw null;

    public bool IsActiveInStaging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    bool IDeltaVPart.IsDestroyedOrBeingDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Highlighted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color HighlightColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 WorldPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 ParentPartRelativePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 ParentNodeRelativePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 AssemblyRelativePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion WorldRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion UserRotationOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion AutomaticSuggestedRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion ParentPartRelativeRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion ParentNodeRelativeRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion AssemblyRelativeRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool CanAttachToSurfaces
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool CanHaveSurfaceAttachedTo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3 SurfaceAttachmentPositionOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Quaternion SurfaceAttachmentRotationOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float SurfaceAttachmentVisualSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Quaternion BaseAttachmentRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 PickupPointOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 PickupRotationPointOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartCategories Category
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsCompound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool FuelCrossFeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssembly Assembly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SymmetrySet SymmetrySet
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public AssemblyPartStageType StageType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string StagingIconAssetAddress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool CanStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private new Transform transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SelectablePart SelectablePartReference
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 OriginalNodeLocalAttachPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 OriginalPartLocalAttachPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [ContextMenu("Calculate Bounds")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateOffsetToGround() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Mesh CreateTorus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Mesh CreateCone(float height, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FinalizeLoad(ObjectAssemblyBuilderEvents events, IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FinalizeModules(GameObject newObject, IObjectAssemblyAvailablePart availablePart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSymmetrySyncRequired() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(IObjectAssemblyAvailablePart availablePart, ObjectAssemblyAssets prefabs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPartNode AddDynamicNode(
      IObjectAssemblyPart oabPart,
      IObjectAssemblyAvailablePartNode dynamicNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveDynamicNode(IObjectAssemblyPartNode existingNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPartNode FindNodeWithTag(string attachNodeTag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPartNode FindNodeAttachedPart(IGGuid attachedPartID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNodeLocalPosition(IObjectAssemblyPartNode node, Vector3 newLocalPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNodeLocalScale(IObjectAssemblyPartNode node, float newScaleFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ObjectAssemblyPartNode ConfigureSurfaceNode(
      IObjectAssemblyAvailablePartNode dynamicNode,
      ObjectAssemblyAssets builderAssets,
      ref Transform attachOffsetTransform,
      ref MeshRenderer meshRenderer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ObjectAssemblyPartNode CreateStackNode(
      IObjectAssemblyPart oabPart,
      IObjectAssemblyAvailablePartNode dynamicNode,
      ObjectAssemblyAssets builderAssets)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableParticleSystems(GameObject GOToDisableVFXOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<Collider> GetChildColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void getChildrenOfPartNotOthers(GameObject current, List<Transform> children) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalcVisualScaleByPartSize(AssemblySizeFilterType partSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowNodes(bool show, bool onlyShowAvailable = true, bool showSurfaceNodes = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveChildedPart(IObjectAssemblyPart child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NotifyNodesOfDisconnect(IObjectAssemblyPart disconnectedPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator SetPartColorEndFrame(Color baseColor, Color detailColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyColors(Color baseColor, Color detailColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColors(Color baseColor, Color detailColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColliders(Collider[] colliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPartBounds(ref Bounds totalBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecalculateCachedBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyInteractivePart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMassValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalRosterChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCurrentKerbalCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModule<T>(out T module) where T : PartBehaviourModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModule(System.Type moduleType, out PartBehaviourModule foundModule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleOfInstanceType<T>(out T module) where T : PartBehaviourModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleOfInstanceType(System.Type moduleType, out PartBehaviourModule foundModule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleData<T, U>(out U data)
      where T : PartComponentModule
      where U : ModuleData
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasModule<T>() where T : PartComponentModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnContainerChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPart() => throw null;
  }
}
