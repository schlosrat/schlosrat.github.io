// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.LBVHTriangle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.MeshTerrains;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;

namespace AwesomeTechnologies.Utility.BVHTree
{
  [Serializable]
  public struct LBVHTriangle
  {
    public float3 V0;
    public float3 V1;
    public float3 V2;
    public float3 N;
    public int TerrainSourceID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LBVHTriangle(float3 v0, float3 v1, float3 v2, float3 n, int terrainSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectRay(BVHRay ray, out HitInfo hitInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectRay(BVHRay ray, ref NativeArray<HitInfo> hitInfos, int hitInfoID) => throw null;
  }
}
