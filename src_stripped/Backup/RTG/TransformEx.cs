// Decompiled with JetBrains decompiler
// Type: RTG.TransformEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class TransformEx
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TransformPoints(this Transform transform, List<Vector3> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Transform> GetGameObjectTransformCollection(
      IEnumerable<GameObject> gameObjects)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Transform> FilterParentsOnly(IEnumerable<Transform> transforms) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetWorldScale(this Transform transform, Vector3 worldScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ScaleFromPivot(this Transform transform, Vector3 scaleFactor, Vector3 pivot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RotateAroundPivot(
      this Transform transform,
      Quaternion rotation,
      Vector3 pivot)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetLocalAxis(this Transform transform, AxisDescriptor axisDesc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Plane GetLocalPlane(this Transform transform, PlaneDescriptor planeDesc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Quaternion Align(
      this Transform transform,
      Vector3 normAlignVector,
      TransformAxis alignmentAxis)
    {
      throw null;
    }
  }
}
