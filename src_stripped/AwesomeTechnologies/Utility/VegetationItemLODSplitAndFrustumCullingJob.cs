// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.VegetationItemLODSplitAndFrustumCullingJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  [BurstCompile(CompileSynchronously = true)]
  public struct VegetationItemLODSplitAndFrustumCullingJob : IJob
  {
    [ReadOnly]
    public NativeList<MatrixInstance> VegetationItemMatrixList;
    [ReadOnly]
    public NativeArray<Plane> FrustumPlanes;
    public NativeList<Matrix4x4> VegetationItemLOD0MatrixList;
    public NativeList<Matrix4x4> VegetationItemLOD1MatrixList;
    public NativeList<Matrix4x4> VegetationItemLOD2MatrixList;
    public NativeList<Matrix4x4> VegetationItemLOD3MatrixList;
    public NativeList<Matrix4x4> VegetationItemLOD0ShadowMatrixList;
    public NativeList<Matrix4x4> VegetationItemLOD1ShadowMatrixList;
    public NativeList<Matrix4x4> VegetationItemLOD2ShadowMatrixList;
    public NativeList<Matrix4x4> VegetationItemLOD3ShadowMatrixList;
    public NativeList<Vector4> LOD0FadeList;
    public NativeList<Vector4> LOD1FadeList;
    public NativeList<Vector4> LOD2FadeList;
    public NativeList<Vector4> LOD3FadeList;
    public Vector3 LightDirection;
    public Vector3 PlaneOrigin;
    public Vector3 BoundsSize;
    public bool ShadowCulling;
    public bool NoFrustumCulling;
    public float CullDistance;
    public float3 CameraPosition;
    public float BoundingSphereRadius;
    public int VegetationItemDistanceBand;
    public float LODFactor;
    public float LODBias;
    public float LODFadeDistance;
    public float LOD1Distance;
    public float LOD2Distance;
    public float LOD3Distance;
    public int LODCount;
    public bool LODFadePercentage;
    public bool LODFadeCrossfade;
    public Vector3 FloatingOriginOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SphereInFrustum(BoundingSphere boundingSphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float3 ExtractTranslationFromMatrix(Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matrix4x4 TranslateMatrix(Matrix4x4 matrix, float3 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateLODFade(float cameraDistance, float nextLODDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsShadowVisible(
      Bounds objectBounds,
      Vector3 lightDirection,
      Vector3 planeOrigin,
      NativeArray<Plane> frustumPlanes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Bounds GetShadowBounds(
      Bounds objectBounds,
      Vector3 lightDirection,
      Vector3 planeOrigin,
      out bool hitPlane)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IntersectPlane(Ray ray, Vector3 planeOrigin, out Vector3 hitPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool BoundsIntersectsFrustum(NativeArray<Plane> planes, Bounds bounds) => throw null;
  }
}
