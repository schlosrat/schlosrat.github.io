// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public static class PQJob
  {
    private const bool MAX_UPDATES_ENABLED = false;
    private const int MAX_NUM_UPDATES = 50000;
    private static readonly ProfilerMarker sHeightSampleMarker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool GetSubdivided(ref PQJob.PQ pq) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ResetPQ(ref PQJob.PQ pq) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PQJob.PQ NewQuad(int subdiv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PQJob.HeightProjection InfoToProjection(PQSData.HeightRegion r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PQJob.UpdateSubdivisions CreateJob(
      PQS pqs,
      PQData data,
      PQSGlobalSettings.SubdivData sd,
      float colliderCullDistance,
      bool heightSample,
      float offset = 0.0f,
      bool initialPass = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RenderJob(
      PQS pqs,
      ref PQJob.UpdateSubdivisions job,
      IPQSRenderer renderer = null,
      PQS.StatCollection stats = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PQJob.PQSJobHolder ScheduleJob(
      PQS pqs,
      PQData pqData,
      PQSGlobalSettings.SubdivData sd,
      float colliderCullDistance,
      bool heightSample,
      float offset = 0.0f,
      bool initialPass = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EndJob(
      PQJob.PQSJobHolder h,
      PQS pqs,
      IPQSRenderer renderer = null,
      PQS.StatCollection stats = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PQJob() => throw null;

    private struct SphereData : IDisposable
    {
      [ReadOnly]
      public double circumference;
      [ReadOnly]
      public double radius;
      [ReadOnly]
      public double3 relativePrimaryTargetPositionNormalized;
      [ReadOnly]
      public double primaryTargetHeight;
      [ReadOnly]
      public double3 relativePrimaryObserverPositionNormalized;
      [ReadOnly]
      public double primaryObserverHeight;
      [ReadOnly]
      public double3 relativeObserverPosition;
      [ReadOnly]
      public int subDivMaxLevel;
      [ReadOnly]
      public int subDivMinLevel;
      [NoAlias]
      [ReadOnly]
      public NativeArray<double> subdivisionThresholds;
      [ReadOnly]
      [NoAlias]
      public NativeArray<double> collapseThresholds;
      [ReadOnly]
      [NoAlias]
      public NativeList<double3> interestTargets;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Dispose() => throw null;
    }

    private enum QuadChild
    {
      Null = -1, // 0xFFFFFFFF
      SouthWest = 0,
      SouthEast = 1,
      NorthWest = 2,
      NorthEast = 3,
    }

    public struct PQ
    {
      public int id;
      public int subdivision;
      public int quadRoot;
      public int parent;
      public int north;
      public int south;
      public int east;
      public int west;
      public int4 subNodes;
      public bool isActive;
      public bool colliderActive;
      public bool colliderRequest;
      public Matrix4x4 quadMatrix;
      public Matrix4x4 inverseQuadMatrix;
      public QuaternionD planeRotation;
      public double3 positionPlanetRelative;
      public double3 positionPlanet;
      public double3 positionPlanePosition;
      public double scalePlaneRelative;
      public double angularinterval;
      public double gcDist;
      public double gcd1;
      public EdgeState edgeState;
    }

    private struct HeightMap
    {
      [ReadOnly]
      public NativeArray<ushort> texture_noDispose;
      [ReadOnly]
      public int2 texSize;
      [ReadOnly]
      public float uvScale;
    }

    private struct HeightProjection
    {
      [ReadOnly]
      public PQJob.HeightMap map;
      [ReadOnly]
      public float heightScale;
    }

    public struct PQSJobHolder
    {
      public IJob job;
      public JobHandle handle;
    }

    [BurstCompile]
    private struct UpdateSubdivisions : IJob, IDisposable
    {
      [ReadOnly]
      public bool enabled;
      [ReadOnly]
      public bool heightSample;
      [ReadOnly]
      public PQJob.SphereData sphereRoot;
      [NoAlias]
      public NativeList<PQJob.PQ> PQs_noDispose;
      [NoAlias]
      public NativeQueue<int> quadCache_noDispose;
      public NativeHashSet<int> UniqueQuadCache;
      [WriteOnly]
      public NativeList<int> destroyedQuads;
      [WriteOnly]
      public NativeList<int> addedQuads;
      [WriteOnly]
      public NativeList<int> changedEdges;
      [WriteOnly]
      public NativeList<int> changedSubdiv;
      [WriteOnly]
      public NativeList<int> changedCollapsed;
      [ReadOnly]
      public int2 globalTexSize;
      [ReadOnly]
      public float globalScale;
      [ReadOnly]
      public NativeArray<ushort> globalHeightMap_noDispose;
      [ReadOnly]
      public float sphereRadius;
      [ReadOnly]
      public PQJob.HeightProjection largeR;
      [ReadOnly]
      public PQJob.HeightProjection largeG;
      [ReadOnly]
      public PQJob.HeightProjection largeB;
      [ReadOnly]
      public PQJob.HeightProjection largeA;
      [ReadOnly]
      public PQJob.HeightProjection mediumR;
      [ReadOnly]
      public PQJob.HeightProjection mediumG;
      [ReadOnly]
      public PQJob.HeightProjection mediumB;
      [ReadOnly]
      public PQJob.HeightProjection mediumA;
      [ReadOnly]
      public NativeArray<Color32> mask_noDispose;
      [ReadOnly]
      public int2 maskSize;
      [ReadOnly]
      public NativeList<DecalInstance> decalInstances_noDispose;
      [ReadOnly]
      public NativeArray<ushort> decalHeights_noDispose;
      [ReadOnly]
      public NativeArray<ushort> decalAlpha_noDispose;
      [ReadOnly]
      public int decalArraySizeX;
      [ReadOnly]
      public int decalArraySizeY;
      [ReadOnly]
      public int decalAlphaSizeX;
      [ReadOnly]
      public int decalAlphaSizeY;
      [ReadOnly]
      public float tiledHeightMapContrast;
      [ReadOnly]
      public float2 poleDirectionOffsets;
      [ReadOnly]
      public float northRadius;
      [ReadOnly]
      public float northHeightOffset;
      [ReadOnly]
      public float northNoiseFreq;
      [ReadOnly]
      public float northNoiseScale;
      [ReadOnly]
      public float northFalloff;
      [ReadOnly]
      public float southRadius;
      [ReadOnly]
      public float southHeightOffset;
      [ReadOnly]
      public float southNoiseFreq;
      [ReadOnly]
      public float southNoiseScale;
      [ReadOnly]
      public float southFalloff;
      [ReadOnly]
      public float colliderCullDistanceSqr;
      public ProfilerMarker sHeightSampleMarker;
      public bool UseFixedLevel;
      public int FixedLevel;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float HeightSample(float3 dir) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UpdateTargetRelativity(ref PQJob.PQ pq) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private ref PQJob.PQ GetPQ(int index) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private EdgeState GetEdgeState(ref PQJob.PQ pq) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UpdateVisibility(ref PQJob.PQ pq) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void PerformColliderRequestCheck(ref PQJob.PQ pq) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static void GetEdgeQuads(
        ref PQJob.PQ pq,
        ref PQJob.PQ caller,
        out int left,
        out int right)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static QuadEdge GetEdge(ref PQJob.PQ pq, PQJob.PQ caller) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SetNeighbour(ref PQJob.PQ pq, int oldNeighbour, int newNeighbour) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void ClearAndDestroy(ref PQJob.PQ pq, ref int numUpdates) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool Collapse(ref PQJob.PQ pq, ref int numUpdates) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool Subdivide(ref PQJob.PQ pq, ref int numUpdates) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SetupQuad(ref PQJob.PQ pq, ref PQJob.PQ parentQuad) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UpdateSubdivision(ref PQJob.PQ pq, ref int numUpdates) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Dispose() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UpdateVisibilityFixedLevel(ref PQJob.PQ pq) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UpdateSubdivisionFixedLevel(ref PQJob.PQ pq, ref int numUpdates) => throw null;
    }
  }
}
