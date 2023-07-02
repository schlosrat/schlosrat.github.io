// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSJobUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class PQSJobUtil
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double asinDouble(double a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double fma(double a, double b, double c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 GetVertexSphericalUVs(Vector3 dir) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double2 GetVertexSphericalUVsForQuad(double3 dir, Vector3 quadPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float RangeFilter(float v, Vector4 range) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float HeightSample(Vector2 uv, Vector3 dir, float nearness, PQS owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Color BilinearSample(
      Vector2 uv,
      NativeArray<Color32> tex,
      int width,
      int height)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float BilinearSample(Vector2 uv, NativeArray<byte> tex, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float Quadratic(float a, float b, float c, float f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int WrapCoord(int x, int range) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CoordToIndex(int x, int y, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float BiquadraticSample(
      Vector2 uv,
      NativeArray<ushort> heightMap,
      int width,
      int height,
      int offset = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float HeightLayerSample(
      Vector2 uv,
      Vector2 uvTop,
      NativeArray<ushort> mapR,
      int widthR,
      int heightR,
      float uvScaleR,
      float heightScaleR,
      NativeArray<ushort> mapG,
      int widthG,
      int heightG,
      float uvScaleG,
      float heightScaleG,
      NativeArray<ushort> mapB,
      int widthB,
      int heightB,
      float uvScaleB,
      float heightScaleB,
      NativeArray<ushort> mapA,
      int widthA,
      int heightA,
      float uvScaleA,
      float heightScaleA,
      float tiledHeightMapContrast,
      Color mask,
      float blend)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float DrawDecal(
      DecalInstance decal,
      float2 uv,
      NativeArray<ushort> decalArray,
      int decalArraySizeX,
      int decalArraySizeY,
      NativeArray<ushort> decalAlpha,
      int decalAlphaSizeX,
      int decalAlphaSizeY,
      float curOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float CullDecal(
      Vector3 pos,
      DecalInstance decal,
      NativeArray<ushort> decalArray,
      int decalArraySizeX,
      int decalArraySizeY,
      NativeArray<ushort> decalAlpha,
      int decalAlphaSizeX,
      int decalAlphaSizeY,
      float curOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float DoDecals(
      Vector2 uv,
      Vector3 vertexPos,
      NativeList<DecalInstance> decalInstances,
      NativeArray<ushort> declaHeights,
      int decalHeightsSizeX,
      int decalHeightsSizeY,
      NativeArray<ushort> decalAlpha,
      int decalAlphaSizeX,
      int decalAlphaSizeY)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float FixPoleDistortion(
      float height,
      float nearness,
      Vector3 dir,
      float northRadius,
      float northHeightOffset,
      float northNoiseFreq,
      float northNoiseScale,
      float northFalloff,
      float southRadius,
      float southHeightOffset,
      float southNoiseFreq,
      float southNoiseScale,
      float southFalloff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float HeightSample(
      Vector2 uv,
      Vector3 dir,
      NativeList<DecalInstance> decalInstances,
      NativeArray<ushort> decalArray,
      int decalArraySizeX,
      int decalArraySizeY,
      NativeArray<ushort> decalAlpha,
      int decalAlphaSizeX,
      int decalAlphaSizeY,
      NativeArray<ushort> globalHeightMap,
      int globalWidth,
      int globalHeight,
      float globalMapScale,
      NativeArray<ushort> largeMapR,
      int largeMapWidthR,
      int largeMapHeightR,
      float largeUVScaleR,
      float largeHeightScaleR,
      NativeArray<ushort> largeMapG,
      int largeMapWidthG,
      int largeMapHeightG,
      float largeUVScaleG,
      float largeHeightScaleG,
      NativeArray<ushort> largeMapB,
      int largeMapWidthB,
      int largeMapHeightB,
      float largeUVScaleB,
      float largeHeightScaleB,
      NativeArray<ushort> largeMapA,
      int largeMapWidthA,
      int largeMapHeightA,
      float largeUVScaleA,
      float largeHeightScaleA,
      NativeArray<ushort> mediumMapR,
      int mediumMapWidthR,
      int mediumMapHeightR,
      float mediumUVScaleR,
      float mediumHeightScaleR,
      NativeArray<ushort> mediumMapG,
      int mediumMapWidthG,
      int mediumMapHeightG,
      float mediumUVScaleG,
      float mediumHeightScaleG,
      NativeArray<ushort> mediumMapB,
      int mediumMapWidthB,
      int mediumMapHeightB,
      float mediumUVScaleB,
      float mediumHeightScaleB,
      NativeArray<ushort> mediumMapA,
      int mediumMapWidthA,
      int mediumMapHeightA,
      float mediumUVScaleA,
      float mediumHeightScaleA,
      float tiledHeightMapContrast,
      float sphereRadius,
      NativeArray<Color32> mask,
      int maskWidth,
      int maskHeight,
      float poleNearness,
      float northRadius,
      float northHeightOffset,
      float northNoiseFreq,
      float northNoiseScale,
      float northFalloff,
      float southRadius,
      float southHeightOffset,
      float southNoiseFreq,
      float southNoiseScale,
      float southFalloff,
      bool onlyGlobalHeight = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSJobUtil() => throw null;
  }
}
