// Decompiled with JetBrains decompiler
// Type: PartGeometryUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
