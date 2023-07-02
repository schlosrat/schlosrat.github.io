// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.FlowInstructionConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
