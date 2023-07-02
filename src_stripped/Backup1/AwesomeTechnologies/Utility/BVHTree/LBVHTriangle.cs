// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.LBVHTriangle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
