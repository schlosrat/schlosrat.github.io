// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.FlowGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class FlowGraph : DirectedGraph<IFlowNode, IFlowEdge>
  {
    private bool _flowGraphIsDirty;
    private ResourceContainerGroup _resourceContainerGroup;

    public ResourceContainerGroup ContainerGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool FlowGraphIsDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGraphDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RebuildFlowGraphIfDirty(PartOwnerComponent partOwner, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildVesselFlowGraphIfDirty(PartOwnerComponent partOwner, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RebuildOABFlowGraphIfDirty(ObjectAssembly objectAssembly, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEdgeData(
      IFlowNode thisNode,
      IFlowNode attachedNode,
      IObjectAssemblyPart part,
      IObjectAssemblyPart otherPart,
      bool setCompoundEdge = false,
      bool fuelLine = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEdgeData(
      IFlowNode thisNode,
      IFlowNode attachedNode,
      PartComponent part,
      bool setCompoundEdge = false,
      bool fuelLine = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowGraph() => throw null;
  }
}
