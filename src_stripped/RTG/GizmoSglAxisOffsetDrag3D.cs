// Decompiled with JetBrains decompiler
// Type: RTG.GizmoSglAxisOffsetDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
