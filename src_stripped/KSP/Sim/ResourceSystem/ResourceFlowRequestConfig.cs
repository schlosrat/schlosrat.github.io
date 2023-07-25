// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowRequestConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceFlowRequestConfig
  {
    public double FlowMinimumNormalized;
    public double FlowPriorityOffset;
    public RequestFlowUpdateMode FlowUpdateMode;
    public List<ResourceFlowRequestCommandConfig> FlowCommands;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFlowCommands(params ResourceFlowRequestCommandConfig[] configs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestConfig() => throw null;
  }
}
