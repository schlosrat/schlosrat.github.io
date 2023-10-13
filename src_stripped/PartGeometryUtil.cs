// Decompiled with JetBrains decompiler
// Type: PartGeometryUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class PartGeometryUtil
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Bounds GetMeshBoundsFromVertices(this GameObject partGO) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Bounds GetRendererBounds(this GameObject p) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Bounds GetColliderBounds(this GameObject p) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Bounds MergeBounds(Bounds[] bounds, Transform relativeTo) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Bounds MergeBounds(
    Dictionary<Bounds[], PartGeometryUtil.PosRot> centeredBounds,
    PartGeometryUtil.PosRot relativeTo)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Vector3 FindBoundsCentroid(Bounds[] bounds, Transform localTo) => throw null;

  public class PosRot
  {
    public Vector3 vector;
    public Quaternion quaternion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PosRot(Vector3 v, Quaternion q) => throw null;
  }
}
