// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.CalculateVisibilityAndLODJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public class CalculateVisibilityAndLODJob : IJob
  {
    [ReadOnly]
    public NativeList<Matrix4x4> InstanceList;
    [ReadOnly]
    public NativeArray<Plane> FrustumPlanes;
    public NativeList<Matrix4x4> LOD0InstanceList;
    public NativeList<Matrix4x4> LOD1InstanceList;
    public NativeList<Matrix4x4> LOD2InstanceList;
    public NativeList<Matrix4x4> LOD0ShadowInstanceList;
    public NativeList<Matrix4x4> LOD1ShadowInstanceList;
    public NativeList<Matrix4x4> LOD2ShadowInstanceList;
    public NativeList<float> LOD0LODFadeList;
    public NativeList<float> LOD1LODFadeList;
    public NativeList<float> LOD2LODFadeList;
    public NativeList<float> LOD0ShadowLODFadeList;
    public NativeList<float> LOD1ShadowLODFadeList;
    public NativeList<float> LOD2ShadowLODFadeList;
    public Vector3 LightDirection;
    public Vector3 PlaneOrigin;
    public Vector3 CameraPosition;
    public Vector3 ItemBoundSize;
    public float LOD1Distance;
    public float LOD2Distance;
    public float CullDistance;
    public float LODFadeDistance;
    public bool DisableLOD;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearLists() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CheckItemVisibility(float3 position, float3 boundSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float3 ExtractTranslationFromMatrix(Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool BoundsIntersectsFrustum(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsShadowVisible(
      Bounds objectBounds,
      Vector3 lightDirection,
      Vector3 planeOrigin,
      NativeArray<Plane> frustumPlanes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bounds GetShadowBounds(
      Bounds objectBounds,
      float3 lightDirection,
      float3 planeOrigin,
      out bool hitPlane)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectPlane(Ray ray, float3 planeOrigin, out float3 hitPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateLODFade(float cameraDistance, float nextLODDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CalculateVisibilityAndLODJob() => throw null;
  }
}
