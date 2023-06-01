// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSGeometry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class PQSGeometry
  {
    public static int cacheSideVertCount;
    public static float cacheMeshSize;
    public static Mesh cacheMesh;
    public static int cacheVertCount;
    public static int cacheRes;
    public static int cacheResDiv2;
    public static int cacheResDiv2Plus1;
    public static int cacheTriIndexCount;
    public static int cacheTriCount;
    public static int[][] cacheIndices;
    public static int[][] cacheVisualIndices;
    public static Vector3[] cacheVerts;
    public static double cacheVertCountReciprocal;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateIndexCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void StripEdge(int[] tris) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateIndexState(EdgeState state, int[] tris, int[] trisBck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int TriIndex(int x, int z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int VertexIndex(int x, int z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSGeometry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PQSGeometry() => throw null;
  }
}
