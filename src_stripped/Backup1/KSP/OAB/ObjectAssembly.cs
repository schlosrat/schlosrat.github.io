// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim;
using KSP.Sim.Data;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssembly : MustInitialize<ObjectAssemblyAssets>, IObjectAssembly
  {
    private readonly FlowGraph flowGraph;
    private Vector3d CenterOfMass;
    private AssemblyActionGroups _actionGroupList;
    private List<IObjectAssemblyPart> _crewableParts;
    private bool isLaunchAssembly;
    private bool isMouseOver;
    private OABSessionInformation stats;
    private ObjectAssemblyLaunchIcon oabLaunchIcon;
    private ObjectAssemblyAssets builderAssets;
    private ObjectAssemblyPartTracker partTracker;
    private Dictionary<IObjectAssemblyPart, ObjectAssemblyPartAnchorIcon> partAnchorIcons;
    private bool _isInitialized;
    private bool _isInitializing;
    private static CenterOfThrustQuery _cacheThrustQuery;
    private ObjectAssemblyBuilderEvents _events;
    private Dictionary<IObjectAssemblyPart, IObjectAssemblyPart> recursionSafetyDictionary;
    private List<IObjectAssemblyPart> removedThisPass;

    public List<IObjectAssemblyPart> Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public List<IObjectAssemblyPartNode> Nodes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public CenterOfPhysicalProperties CenterOfProperties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart Anchor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IObjectAssemblyPart HoveredOverPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ResourceFlowRequestManager ResourceFlowRequestManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public VesselDeltaVComponent VesselDeltaV
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FlowGraph FlowGraph
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceContainerGroup ContainerGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IObjectAssemblyPart> CrewableParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int CrewablePartsCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABSessionInformation Stats
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssembly(
      ObjectAssemblyAssets assets,
      OABSessionInformation stats,
      ObjectAssemblyPartTracker partTracker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MouseEnter(bool partGrabbed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MouseLeave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAsLaunchAssembly(bool isMainAssembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLaunchAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPart(IObjectAssemblyPart partToAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDryMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTotalMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetCenterOfMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityEngine.Ray GetCenterOfThrust() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bounds GetBoundingBox() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 FindCenterOfMass(IObjectAssemblyPart rootPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RecursePartsForCoM(IObjectAssemblyPart part, ref Vector3 CoM, ref float m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private UnityEngine.Ray FindCenterOfThrust(IObjectAssemblyPart rootPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RecursePartsForCoT(
      IObjectAssemblyPart part,
      ref Vector3 origin,
      ref Vector3 direction,
      ref float thrust)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNumberOfParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetWetMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(IObjectAssemblyPart anchor, ObjectAssemblyBuilderEvents events) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePart(IObjectAssemblyPart partToRemove) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoveredOverPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAnchor(IObjectAssemblyPart anchor, bool resetResourceSolvers = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleAnchorIcons(IObjectAssemblyPart anchor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FlipParentChildRelationshipsToNewAnchor(
      IObjectAssemblyPart newAnchor,
      bool resetResourceSolvers = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FlipParentChildRelationship(
      IObjectAssemblyPart originalParent,
      IObjectAssemblyPart originalChild)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrintAssemblyHierarchy(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecursivePrintHierarchy(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemovePartInternal(IObjectAssemblyPart partToRemove, bool derived = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsAssemblyActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyIconsPosition(Camera curCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyPartAnchorIconsPosition(Camera curCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyIcons(IObjectAssemblyPart partGrabbed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyPartAnchorIcons(IObjectAssemblyPart partGrabbed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAssemblyBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddPartAnchorIcon(IObjectAssemblyPart part, IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemovePartAnchorIcon(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyLaunchIcon() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyAnchorIcons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartBehaviourModule<T>(out T foundPartModule) where T : PartBehaviourModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartBehaviourModules<T>(out List<T> foundPartModules) where T : PartBehaviourModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartsWithResourceCapacity(
      string resourceName,
      out List<IObjectAssemblyPart> foundParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartsWithResourceStored(
      string resourceName,
      out List<IObjectAssemblyPart> foundParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartsByResource(
      string resourceName,
      FlowDirection direction,
      out List<IObjectAssemblyPart> foundParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasPartWithName(List<string> partNames, bool exactMatch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildActionGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddActionToActionGroup(ModuleActionGroupAction action, KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveActionFromActionGroup(ModuleActionGroupAction action, KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetActionGroupPartCount(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HasSourceOfControl(
      out ObjectAssemblyPart firstCommandPart,
      out Data_Command dataCommand)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartFinalized(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoPopulateCrewOnAddedPart(ObjectAssemblyPart partAdded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoPopulateCrewPartIfNeeded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoPopulatePart(ObjectAssemblyPart partToPopulate, Data_Command dataCommand) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectAssembly() => throw null;
  }
}
