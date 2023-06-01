// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowRequestConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
