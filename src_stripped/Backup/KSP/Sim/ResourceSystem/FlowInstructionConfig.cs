// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.FlowInstructionConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class FlowInstructionConfig : IEquatable<FlowInstructionConfig>
  {
    public IFlowNode FlowTarget;
    public ResourceDefinitionID FlowResource;
    public ResourceFlowMode FlowMode;
    public FlowDirection FlowDirection;
    public RequestFlowUpdateMode FlowUpdateMode;
    public double FlowPriority;
    public double FlowUnitsOptimal;
    public double FlowUnitsMinimum;
    public double FlowUnitsTarget;
    public IReadOnlyPriorityGroupCollection<IFlowNode> SearchPriorityGroup;
    public ResourceContainerGroupSequence ResourceContainerGroup;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetHashCode(FlowInstructionConfig obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(FlowInstructionConfig other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowInstructionConfig() => throw null;
  }
}
