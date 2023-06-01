// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.CreateVSPInstanceDataMatrixJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct CreateVSPInstanceDataMatrixJob : IJob
  {
    [ReadOnly]
    public NativeArray<byte> Excluded;
    [ReadOnly]
    public NativeArray<float3> Position;
    [ReadOnly]
    public NativeArray<quaternion> Rotation;
    [ReadOnly]
    public NativeArray<float3> Scale;
    [ReadOnly]
    public NativeArray<float3> TerrainNormal;
    [ReadOnly]
    public NativeArray<float> DistanceFalloff;
    [ReadOnly]
    public NativeArray<float2> uv;
    public NativeList<VSPInstanceData> VSPInstanceDataList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
