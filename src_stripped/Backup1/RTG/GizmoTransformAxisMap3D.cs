// Decompiled with JetBrains decompiler
// Type: RTG.GizmoTransformAxisMap3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoTransformAxisMap3D
  {
    private Vector3 _freeAxis;
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

    public Vector3 Axis
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
    public void SetAxis(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedAxis(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFreeAxis(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoTransformAxisMap3D() => throw null;
  }
}
