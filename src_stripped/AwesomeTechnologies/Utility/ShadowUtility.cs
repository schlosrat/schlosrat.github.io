// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.ShadowUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  public class ShadowUtility
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsShadowVisible(
      Bounds objectBounds,
      Vector3 lightDirection,
      Vector3 planeOrigin,
      Plane[] frustumPlanes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool BoundsIntersectsFrustum(Plane[] planes, Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Bounds GetShadowBounds(
      Bounds objectBounds,
      Vector3 lightDirection,
      Vector3 planeOrigin,
      out bool hitPlane)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IntersectPlane(Ray ray, Vector3 planeOrigin, out Vector3 hitPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowUtility() => throw null;
  }
}
