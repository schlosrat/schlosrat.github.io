// Decompiled with JetBrains decompiler
// Type: RTG.BoxMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class BoxMath
  {
    private static List<BoxFace> _allBoxFaces;
    private static Vector3[] A;
    private static Vector3[] B;
    private static float[,] R;
    private static float[,] absR;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static BoxMath() => throw null;

    public static List<BoxFace> AllBoxFaces
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetFaceAxisIndex(BoxFace face) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BoxFaceDesc GetFaceClosestToPoint(
      Vector3 point,
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BoxFaceDesc GetFaceClosestToPoint(
      Vector3 point,
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      Vector3 viewVector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BoxFace GetMostAlignedFace(
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      Vector3 direction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 CalcBoxFaceSize(Vector3 boxSize, BoxFace boxFace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BoxFaceAreaDesc GetBoxFaceAreaDesc(Vector3 boxSize, BoxFace boxFace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Plane CalcBoxFacePlane(
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      BoxFace boxFace)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 CalcBoxFaceNormal(
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      BoxFace boxFace)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 CalcBoxFaceCenter(
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      BoxFace boxFace)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CalcBoxCornerPoints(
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TransformBox(
      Vector3 boxCenter,
      Vector3 boxSize,
      Matrix4x4 transformMatrix,
      out Vector3 newBoxCenter,
      out Vector3 newBoxSize)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool BoxIntersectsBox(
      Vector3 center0,
      Vector3 size0,
      Quaternion rotation0,
      Vector3 center1,
      Vector3 size1,
      Quaternion rotation1)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 CalcBoxPtClosestToPt(
      Vector3 point,
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      BoxEpsilon epsilon = default (BoxEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      BoxEpsilon epsilon = default (BoxEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ContainsPoint(
      Vector3 point,
      Vector3 boxCenter,
      Vector3 boxSize,
      Quaternion boxRotation,
      BoxEpsilon epsilon = default (BoxEpsilon))
    {
      throw null;
    }
  }
}
