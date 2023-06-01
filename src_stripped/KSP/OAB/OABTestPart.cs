// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABTestPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class OABTestPart : 
    MonoBehaviour,
    IObjectAssemblyPart,
    IFlowNode,
    IDeltaVPart,
    IEquatable<IDeltaVPart>
  {
    public List<SerializedPartModule> RawPartModules
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public DictionaryValueList<System.Type, IPartModule> Modules
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IObjectAssemblyPartNode> Nodes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyResource[] Resources
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartResourceCostDefinition[] ResourceCosts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceFlowRequestBroker ResourceFlowRequestBroker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform PartTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion AutomaticSuggestedRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string PartName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid GlobalId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSymmetryMirrored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IGGuid UniqueId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsFinalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double WetMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int DecoupleStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double DryMass
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

    public PartCategories Category
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsCompound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool FuelCrossFeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public AssemblySizeFilterType PartSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Collider[] Colliders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ActivationStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int InStageIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

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

    public IObjectAssemblyPart OriginalPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IObjectAssemblyPart> Children
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
    }

    public bool CanHaveSurfaceAttachedTo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 SurfaceAttachmentPositionOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion SurfaceAttachmentRotationOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion BaseAttachmentRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AssemblyPartStageType StageType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string StagingIconAssetAddress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IResourceContainer[] Containers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 PickupPointOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 PickupRotationPointOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string GuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IDeltaVPart> DeltaVChildren
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IDeltaVPart Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    IEnumerable<IDeltaVPart> IDeltaVPart.DeltaVChildren
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IResourceContainer[] DeltaVContainers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    bool IDeltaVPart.IsDestroyedOrBeingDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyColors(Color baseColor, Color detailColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateOffsetToGround() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FinalizeLoad(ObjectAssemblyBuilderEvents events, IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<Transform> FindModelTransforms(string transformName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPart GetAnchorPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPartBounds(ref Bounds totalBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasChildren() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(IObjectAssemblyAvailablePart availablePart, ObjectAssemblyAssets prefabs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NotifyNodesOfDisconnect(IObjectAssemblyPart disconnectedPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveChildedPart(IObjectAssemblyPart child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColliders(Collider[] colliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColors(Color baseColor, Color detailColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentPart(IObjectAssemblyPart parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOriginalPart(IObjectAssemblyPart parent) => throw null;

    public IObjectAssemblyAvailablePart AvailablePart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowNodes(bool show, bool onlyShowAvailable = true, bool showSurfaceNodes = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModule<T>(out T module) where T : PartBehaviourModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModule(System.Type type, out PartBehaviourModule module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDeltaVPart FindAttachNodeAttachedPart(string nodeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPartNode FindNodeWithTag(string attachNodeTag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPartNode FindNodeAttachedPart(IGGuid attachedPartID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPartNode AddDynamicNode(
      IObjectAssemblyPart oabPart,
      IObjectAssemblyAvailablePartNode dynamicNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveDynamicNode(IObjectAssemblyPartNode dynamicNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNodeLocalPosition(IObjectAssemblyPartNode node, Vector3 newLocalPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNodeLocalScale(IObjectAssemblyPartNode node, float newScaleFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(IDeltaVPart other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleData<T>(out T moduleData) where T : ModuleData => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleData<T, U>(out U moduleData)
      where T : PartComponentModule
      where U : ModuleData
    {
      throw null;
    }

    public bool IsActiveInStaging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MirrorTechnique MirrorTechnique
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABOrientation OrientationPreference
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanSuggestOrientation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleOfInstanceType<T>(out T module) where T : PartBehaviourModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetModuleOfInstanceType(System.Type type, out PartBehaviourModule module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasModule<T>() where T : PartComponentModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABTestPart() => throw null;
  }
}
