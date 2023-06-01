// Decompiled with JetBrains decompiler
// Type: RTG.GizmoTransformAxisMap2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoTransformAxisMap2D
  {
    private Vector2 _freeAxis;
    private AxisDescriptor _mappedAxisDesc;
    private GizmoTransform _transform;

    public AxisDescriptor MappedAxisDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int MappedAxisIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AxisSign MappedAxisSign
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMapped
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 Axis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoTransform Transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unmap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxis(Vector2 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedAxis(Vector2 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFreeAxis(Vector2 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoTransformAxisMap2D() => throw null;
  }
}
