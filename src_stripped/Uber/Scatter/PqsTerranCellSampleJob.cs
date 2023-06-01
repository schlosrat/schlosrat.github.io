// Decompiled with JetBrains decompiler
// Type: Uber.Scatter.PqsTerranCellSampleJob
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

namespace Uber.Scatter
{
  [BurstCompile(CompileSynchronously = true)]
  public struct PqsTerranCellSampleJob : IJobParallelFor
  {
    public NativeArray<Bounds> VegetationCellBoundsList;
    [ReadOnly]
    public NativeList<DecalInstance> decalInstances;
    [ReadOnly]
    public NativeArray<ushort> decalArray;
    [ReadOnly]
    public int decalWidth;
    [ReadOnly]
    public int decalHeight;
    [ReadOnly]
    public NativeArray<ushort> decalAlpha;
    [ReadOnly]
    public int decalAlphaWidth;
    [ReadOnly]
    public int decalAlphaHeight;
    [ReadOnly]
    public NativeArray<ushort> GlobalHeightMap;
    public int GlobalWidth;
    public int GlobalHeight;
    public float GlobalMapScale;
    [ReadOnly]
    public NativeArray<ushort> LargeMapR;
    public int LargeMapWidthR;
    public int LargeMapHeightR;
    public float LargeUvScaleR;
    public float LargeHeightScaleR;
    [ReadOnly]
    public NativeArray<ushort> LargeMapG;
    public int LargeMapWidthG;
    public int LargeMapHeightG;
    public float LargeUvScaleG;
    public float LargeHeightScaleG;
    [ReadOnly]
    public NativeArray<ushort> LargeMapB;
    public int LargeMapWidthB;
    public int LargeMapHeightB;
    public float LargeUvScaleB;
    public float LargeHeightScaleB;
    [ReadOnly]
    public NativeArray<ushort> LargeMapA;
    public int LargeMapWidthA;
    public int LargeMapHeightA;
    public float LargeUvScaleA;
    public float LargeHeightScaleA;
    [ReadOnly]
    public NativeArray<ushort> MediumMapR;
    public int MediumMapWidthR;
    public int MediumMapHeightR;
    public float MediumUvScaleR;
    public float MediumHeightScaleR;
    [ReadOnly]
    public NativeArray<ushort> MediumMapG;
    public int MediumMapWidthG;
    public int MediumMapHeightG;
    public float MediumUvScaleG;
    public float MediumHeightScaleG;
    [ReadOnly]
    public NativeArray<ushort> MediumMapB;
    public int MediumMapWidthB;
    public int MediumMapHeightB;
    public float MediumUvScaleB;
    public float MediumHeightScaleB;
    [ReadOnly]
    public NativeArray<ushort> MediumMapA;
    public int MediumMapWidthA;
    public int MediumMapHeightA;
    public float MediumUvScaleA;
    public float MediumHeightScaleA;
    public float TiledHeightMapContrast;
    public float SphereRadius;
    public float OceanAltitude;
    [ReadOnly]
    public NativeArray<Color32> LayerMask;
    public int MaskWidth;
    public int MaskHeight;
    [ReadOnly]
    public float2 PoleDirectionOffsets;
    [ReadOnly]
    public float NorthRadius;
    [ReadOnly]
    public float NorthHeightOffset;
    [ReadOnly]
    public float NorthNoiseFreq;
    [ReadOnly]
    public float NorthNoiseScale;
    [ReadOnly]
    public float NorthFalloff;
    [ReadOnly]
    public float SouthRadius;
    [ReadOnly]
    public float SouthHeightOffset;
    [ReadOnly]
    public float SouthNoiseFreq;
    [ReadOnly]
    public float SouthNoiseScale;
    [ReadOnly]
    public float SouthFalloff;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float3 PolarToCartesian(float2 polar, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float HeightSample(Vector2 uv, Vector3 dir) => throw null;
  }
}
