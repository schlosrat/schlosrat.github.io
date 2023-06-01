// Decompiled with JetBrains decompiler
// Type: RTG.GizmoSglAxisOffsetDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoSglAxisOffsetDrag3D : GizmoPlaneDrag3D
  {
    private float _accumSnapDrag;
    private GizmoSglAxisOffsetDrag3D.WorkData _workData;

    public Vector3 Axis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWorkData(GizmoSglAxisOffsetDrag3D.WorkData workData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override Plane CalculateDragPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateDragValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSessionEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoSglAxisOffsetDrag3D() => throw null;

    public struct WorkData
    {
      public Vector3 DragOrigin;
      public Vector3 Axis;
      public float SnapStep;
    }
  }
}
