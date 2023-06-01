// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.PqsUpdateInstanceListJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct PqsUpdateInstanceListJob : IJob
  {
    [ReadOnly]
    public NativeArray<RaycastHit> RaycastHits;
    [ReadOnly]
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    public float3 FloatingOriginOffset;
    public byte TerrainSourceID;
    public NativeList<float3> Position;
    public NativeList<float3> TerrainNormal;
    public NativeList<byte> TerrainSourceIDs;
    public NativeList<byte> Excluded;
    public float SphereRadius;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
