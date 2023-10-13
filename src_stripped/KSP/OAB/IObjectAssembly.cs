// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Data;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.ResourceSystem;
using System.Collections.Generic;
using UnityEngine;

namespace KSP.OAB
{
  public interface IObjectAssembly
  {
    List<IObjectAssemblyPart> Parts { get; }

    List<IObjectAssemblyPartNode> Nodes { get; }

    CenterOfPhysicalProperties CenterOfProperties { get; set; }

    IObjectAssemblyPart Anchor { get; }

    VesselDeltaVComponent VesselDeltaV { get; }

    void Initialize(IObjectAssemblyPart anchor, ObjectAssemblyBuilderEvents events);

    void DestroyAssembly();

    FlowGraph FlowGraph { get; }

    void AddPart(IObjectAssemblyPart partToAdd);

    void RemovePart(IObjectAssemblyPart partToRemove);

    int GetNumberOfParts();

    double GetWetMass();

    double GetDryMass();

    double GetTotalMass();

    Bounds GetBoundingBox();

    Vector3d GetCenterOfMass();

    UnityEngine.Ray GetCenterOfThrust();

    void SetAnchor(IObjectAssemblyPart anchor, bool resetResourceSolvers = false);

    void SetAnchorExternal(IObjectAssemblyPart anchor, bool resetResourceSolvers = false);

    void SetHoveredOverPart(IObjectAssemblyPart hoverPart);

    void UpdateAssemblyIcons(IObjectAssemblyPart partGrabbed);

    void UpdateAssemblyIconsPosition(Camera curCamera);

    void UpdateAssemblyPartAnchorIcons(IObjectAssemblyPart partGrabbed);

    void UpdateAssemblyPartAnchorIconsPosition(Camera curCamera);

    void DestroyLaunchIcon();

    void DestroyAnchorIcons();

    void MarkAsLaunchAssembly(bool b);

    bool IsLaunchAssembly();

    void MouseEnter(bool grabbingPart = false);

    void MouseLeave();

    bool TryGetPartBehaviourModule<T>(out T foundPartModule) where T : PartBehaviourModule;

    bool TryGetPartBehaviourModules<T>(out List<T> foundPartModules) where T : PartBehaviourModule;

    bool HasPartWithName(List<string> partNames, bool exactMatch);

    bool TryGetPartsWithResourceCapacity(
      string resourceName,
      out List<IObjectAssemblyPart> foundParts);

    bool TryGetPartsWithResourceStored(
      string resourceName,
      out List<IObjectAssemblyPart> foundParts);

    bool TryGetPartsByResource(
      string resourceName,
      FlowDirection direction,
      out List<IObjectAssemblyPart> foundParts);

    bool HasParts();

    ResourceFlowRequestManager ResourceFlowRequestManager { get; }
  }
}
