// Decompiled with JetBrains decompiler
// Type: PhysicsUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PhysicsUtil
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool HasAncestorTransform(Transform src, Transform ancestor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RaycastHit[] CapsuleCastAllIgnoreSelf(
    Vector3 p1,
    Vector3 p2,
    float capsuleRadius,
    Vector3 direction,
    float distance,
    int layerMask,
    Transform transform)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static int RaycastHitDistCompare(RaycastHit a, RaycastHit b) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RaycastHit[] SphereCastAllIgnoreSelf(
    Vector3 p1,
    float radius,
    Vector3 direction,
    float distance,
    int layerMask,
    Transform transform)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RaycastHit[] RaycastAllIgnoreSelf(
    Vector3 origin,
    Vector3 direction,
    float distance,
    int layerMask,
    Transform transform)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static List<PhysicsUtil.SphereHit> SphereSweepTest(
    Vector3 start,
    Vector3 forward,
    float distance,
    float sweepInterval,
    float radius,
    int layerMask)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static List<PhysicsUtil.SphereHit> SphereSweepTestWhere(
    Vector3 start,
    Vector3 forward,
    float distance,
    float sweepInterval,
    float radius,
    int layerMask,
    Func<PhysicsUtil.SphereHit, bool> criteria)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PhysicsUtil() => throw null;

  public class SphereHit
  {
    public Vector3 position;
    public float distance;
    public Collider collider;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereHit(Collider col, Vector3 position, float distance) => throw null;
  }
}
