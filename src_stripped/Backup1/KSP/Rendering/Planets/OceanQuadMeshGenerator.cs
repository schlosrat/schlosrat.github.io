// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.OceanQuadMeshGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public static class OceanQuadMeshGenerator
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GenerateOceanMesh(
      int layer,
      int grid,
      ref Vector3[] OceanVerts,
      ref int[] OceanIndices)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float[] GenerateOceanMeshArray(int layer, int grid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] FloatToByte(float[] oceanMeshData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<float> GenerateOceanMesh(int layer, int grid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GenerateOceanMesh(
      int layer,
      int grid,
      List<Vector3> oceanVerts,
      List<int> oceanIndices)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<int> GenerateExtraEdgeIndices(
      int grid,
      List<int> leftEdgeIndices,
      List<int> rightEdgeIndices,
      List<int> downEdgeIndices,
      List<int> upEdgeIndices)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GenerateExtraEdgeIndices(
      int countGrids,
      List<int> extraIndices,
      List<int> edgeIndices,
      bool isFlipped)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FixParameters(ref int layer, ref int grid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<Vector3> ToOceanVerts(
      this List<OceanQuadMeshGenerator.IntPosition> verts,
      int halfWidth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GenerateVerts(
      int width,
      int grid,
      List<OceanQuadMeshGenerator.IntPosition> verts,
      List<int> indicesCache,
      bool generateAll,
      List<int> leftEdgeIndices,
      List<int> rightEdgeIndices,
      List<int> downEdgeIndices,
      List<int> upEdgeIndices)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool isFlipped(int i, int j) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GenerateTriangleIndices(
      int ld,
      int lu,
      int rd,
      int ru,
      List<int> indices)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GenerateFlippedTriangleIndices(
      int ld,
      int lu,
      int rd,
      int ru,
      List<int> indices)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GenerateIndices(
      int grid,
      List<OceanQuadMeshGenerator.IntPosition> verts,
      List<int> indices,
      bool generateAll,
      int width,
      List<int> indicesCache,
      int lastCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int ToNewIndex(
      int width,
      int grid,
      int i,
      int j,
      int index,
      List<OceanQuadMeshGenerator.IntPosition> verts,
      List<int> indicesCache,
      int lastCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsAnyUseless(int grid, int i, int j) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsUseless(int grid, int i, int j) => throw null;

    private struct IntPosition
    {
      public int x;
      public int y;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3 ToVector3(float halfWidth) => throw null;
    }
  }
}
