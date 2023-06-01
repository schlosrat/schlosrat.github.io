// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class PQData
  {
    [HideInInspector]
    public double[] subdivisionThresholds;
    [HideInInspector]
    public double[] collapseThresholds;
    [HideInInspector]
    public int numTesselationSteps;
    [HideInInspector]
    public double tesselationAltitudeFalloff;
    [NoAlias]
    public NativeList<PQJob.PQ> allPQ;
    [NoAlias]
    public NativeQueue<int> quadCache;
    public NativeHashSet<int> UniqueQuadCache;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ref PQJob.PQ Q(QI initQuad) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupQuad(
      PQS pqs,
      ref PQJob.PQ quad,
      QuadPlane plane,
      ref PQJob.PQ north,
      ref PQJob.PQ south,
      ref PQJob.PQ east,
      ref PQJob.PQ west,
      Vector3d pos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTargetRelativity(PQS pqs, ref PQJob.PQ pq) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateQuads(PQS pqs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQData() => throw null;

    public struct TesselationPositionData
    {
      public double3 pos;
      public double heightOffset;
    }
  }
}
