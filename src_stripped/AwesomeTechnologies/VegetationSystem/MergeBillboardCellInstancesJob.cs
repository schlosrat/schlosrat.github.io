// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.MergeBillboardCellInstancesJob
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
  public struct MergeBillboardCellInstancesJob : IJob
  {
    public NativeList<Matrix4x4> OutputNativeList;
    [ReadOnly]
    public NativeList<MatrixInstance> InputNativeList;
    [ReadOnly]
    public NativeArray<Plane> FrustumPlanes;
    public float CullDistance;
    public float FarCullDistance;
    public float3 CameraPosition;
    public float BoundingSphereRadius;
    public float3 FloatingOriginOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matrix4x4 TranslateMatrix(Matrix4x4 matrix, float3 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float3 ExtractTranslationFromMatrix(Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SphereInFrustum(BoundingSphere boundingSphere) => throw null;
  }
}
