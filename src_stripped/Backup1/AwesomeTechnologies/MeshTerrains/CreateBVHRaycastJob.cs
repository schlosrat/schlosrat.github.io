// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.CreateBVHRaycastJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
