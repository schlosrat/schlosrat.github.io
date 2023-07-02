// Decompiled with JetBrains decompiler
// Type: KSP.OAB.MeshPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class MeshPoint
  {
    public Vector3 vert;
    public Vector3 normal;
    public Vector2 uv1;
    public Vector2 uv2;
    public Color color;
    public int index;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3[] GetVerts(MeshPoint[] meshPoints, Vector3 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3[] GetNormals(MeshPoint[] meshPoints) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2[] GetUV1(MeshPoint[] meshPoints) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2[] GetUV2(MeshPoint[] meshPoints) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color[] GetColors(MeshPoint[] meshPoints) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MeshPoint CopyFrom(MeshPoint p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector4 GetUVMinMax(MeshPoint[] meshPoints) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshPoint() => throw null;
  }
}
