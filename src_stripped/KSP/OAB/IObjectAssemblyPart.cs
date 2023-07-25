// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace KSP.OAB
{
  public interface IObjectAssemblyPart : IFlowNode, IDeltaVPart, IEquatable<IDeltaVPart>
  {
    void FinalizeLoad(ObjectAssemblyBuilderEvents events, IObjectAssemblyAvailablePart part);

    float CalculateOffsetToGround();

    List<SerializedPartModule> RawPartModules { get; set; }

    DictionaryValueList<System.Type, IPartModule> Modules { get; }

    List<IObjectAssemblyPartNode> Nodes { get; }

    IObjectAssemblyResource[] Resources { get; }

    PartResourceCostDefinition[] ResourceCosts { get; }

    ResourceFlowRequestBroker ResourceFlowRequestBroker { get; set; }

    Transform PartTransform { get; }

    bool IsSymmetryMirrored { get; set; }

    MirrorTechnique MirrorTechnique { get; }

    OABOrientation OrientationPreference { get; }

    bool CanSuggestOrientation { get; }

    IGGuid UniqueId { get; set; }

    bool IsFinalized { get; set; }

    PartCategories Category { get; }

    bool FuelCrossFeed { get; set; }

    AssemblySizeFilterType PartSize { get; }

    Collider[] Colliders { get; }

    int InStageIndex { get; set; }

    bool HasParent();

    bool HasChildren();

    IObjectAssemblyPartNode MyNodeConnectedToParent { get; }

    IObjectAssemblyPartNode ParentNodeConnectedToMe { get; }

    IObjectAssemblyPart ParentPart { get; }

    void SetParentPart(IObjectAssemblyPart parent);

    IObjectAssemblyPart OriginalPart { get; }

    void SetOriginalPart(IObjectAssemblyPart original);

    IObjectAssemblyAvailablePart AvailablePart { get; }

    List<IObjectAssemblyPart> Children { get; set; }

    IEnumerable<Transform> FindModelTransforms(string transformName);

    IObjectAssemblyPart GetAnchorPart();

    IObjectAssembly Assembly { get; set; }

    SymmetrySet SymmetrySet { get; set; }

    void GetPartBounds(ref Bounds totalBounds);

    bool Highlighted { get; set; }

    Color HighlightColor { get; set; }

    Vector3 WorldPosition { get; set; }

    Vector3 ParentPartRelativePosition { get; set; }

    Vector3 ParentNodeRelativePosition { get; set; }

    Vector3 AssemblyRelativePosition { get; set; }

    Vector3 OriginalNodeLocalAttachPosition { get; set; }

    Vector3 OriginalPartLocalAttachPosition { get; set; }

    Quaternion WorldRotation { get; set; }

    Quaternion UserRotationOffset { get; set; }

    Quaternion AutomaticSuggestedRotation { get; set; }

    Quaternion ParentPartRelativeRotation { get; set; }

    Quaternion ParentNodeRelativeRotation { get; set; }

    Quaternion AssemblyRelativeRotation { get; set; }

    bool CanAttachToSurfaces { get; }

    bool CanHaveSurfaceAttachedTo { get; }

    Vector3 SurfaceAttachmentPositionOffset { get; }

    Quaternion SurfaceAttachmentRotationOffset { get; }

    Quaternion BaseAttachmentRotation { get; }

    Vector3 PickupPointOffset { get; }

    Vector3 PickupRotationPointOffset { get; }

    AssemblyPartStageType StageType { get; }

    string StagingIconAssetAddress { get; }

    bool CanStage { get; set; }

    void Initialize(IObjectAssemblyAvailablePart availablePart, ObjectAssemblyAssets prefabs);

    void ShowNodes(bool show, bool onlyShowAvailable = true, bool showSurfaceNodes = true);

    void RemoveChildedPart(IObjectAssemblyPart child);

    void NotifyNodesOfDisconnect(IObjectAssemblyPart disconnectedPart);

    void ApplyColors(Color baseColor, Color detailColor);

    void SetColors(Color baseColor, Color detailColor);

    void SetColliders(Collider[] colliders);

    bool HasModule<T>() where T : PartComponentModule;

    bool TryGetModule<T>(out T module) where T : PartBehaviourModule;

    bool TryGetModule(System.Type type, out PartBehaviourModule module);

    bool TryGetModuleOfInstanceType<T>(out T module) where T : PartBehaviourModule;

    bool TryGetModuleOfInstanceType(System.Type type, out PartBehaviourModule module);

    IObjectAssemblyPartNode FindNodeWithTag(string attachNodeTag);

    IObjectAssemblyPartNode FindNodeAttachedPart(IGGuid attachedPartID);

    IObjectAssemblyPartNode AddDynamicNode(
      IObjectAssemblyPart oabPart,
      IObjectAssemblyAvailablePartNode dynamicNode);

    bool RemoveDynamicNode(IObjectAssemblyPartNode dynamicNode);

    void SetNodeLocalPosition(IObjectAssemblyPartNode node, Vector3 newLocalPosition);

    void SetNodeLocalScale(IObjectAssemblyPartNode node, float newScaleFactor);
  }
}
