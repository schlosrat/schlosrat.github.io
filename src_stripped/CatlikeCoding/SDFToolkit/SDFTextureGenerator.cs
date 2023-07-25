// Decompiled with JetBrains decompiler
// Type: CatlikeCoding.SDFToolkit.SDFTextureGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace CatlikeCoding.SDFToolkit
{
  public static class SDFTextureGenerator
  {
    private static int width;
    private static int height;
    private static SDFTextureGenerator.Pixel[,] pixels;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D GenerateSdf(Texture2D source, float maxOutside) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Generate(Texture2D source, Texture2D destination, float maxOutside) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ComputeEdgeGradients() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ApproximateEdgeDelta(float gx, float gy, float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UpdateDistance(SDFTextureGenerator.Pixel p, int x, int y, int oX, int oY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GenerateDistanceTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void PostProcess(float maxDistance) => throw null;

    private class Pixel
    {
      public float alpha;
      public float distance;
      public Vector2 gradient;
      public int dX;
      public int dY;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Pixel() => throw null;
    }
  }
}
