// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.OffsetAndRotateScaleVegetationInstanceMathJob
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
  public struct OffsetAndRotateScaleVegetationInstanceMathJob : IJobParallelFor
  {
    public NativeArray<float3> Position;
    public NativeArray<int> RandomNumberIndex;
    public NativeArray<quaternion> Rotation;
    public NativeArray<float3> Scale;
    public NativeArray<float3> TerrainNormal;
    public NativeArray<float3> SphereNormal;
    public NativeArray<byte> Excluded;
    [ReadOnly]
    public NativeArray<float> RandomNumbers;
    public VegetationRotationType VegetationRotationType;
    public float MinScale;
    public float MaxScale;
    public float MinYOffset;
    public float MaxYOffset;
    public float3 RotationOffset;
    public float3 ScaleMultiplier;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RandomRange(int randomNumberIndex, float min, float max) => throw null;
  }
}
