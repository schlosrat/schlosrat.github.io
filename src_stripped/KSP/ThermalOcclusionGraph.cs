// Decompiled with JetBrains decompiler
// Type: KSP.ThermalOcclusionGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class ThermalOcclusionGraph
  {
    public List<ThermalOcclusionData> ConvectionOccluderData;
    public OcclusionCone[] OcclusionCones;
    private VesselBehavior _vesselBehavior;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermalOcclusionGraph(VesselBehavior vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateThermalGraph() => throw null;
  }
}
