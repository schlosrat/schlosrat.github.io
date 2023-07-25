// Decompiled with JetBrains decompiler
// Type: RTG.Matrix4x4Ex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class Matrix4x4Ex
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matrix4x4 GetInverse(this Matrix4x4 mtx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matrix4x4 GetRelativeTransform(
      this Matrix4x4 matrix,
      Matrix4x4 referenceTransform)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matrix4x4 Translation(Vector3 translation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matrix4x4 RotationMatrixFromRightUp(Vector3 right, Vector3 up) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetTranslation(this Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetScale(this Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetNormalizedAxis(this Matrix4x4 matrix, int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3[] GetNormalizedAxes(this Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> TransformPoints(this Matrix4x4 matrix, List<Vector3> points) => throw null;
  }
}
