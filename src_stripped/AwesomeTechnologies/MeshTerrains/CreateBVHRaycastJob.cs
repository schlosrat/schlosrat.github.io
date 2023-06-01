// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.CreateBVHRaycastJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.MeshTerrains
{
  [BurstCompile(CompileSynchronously = true)]
  public struct CreateBVHRaycastJob : IJob
  {
    [ReadOnly]
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    public NativeArray<BVHRay> Rays;
    public Rect TerrainRect;
    public int LayerMask;
    public int MaxHits;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
