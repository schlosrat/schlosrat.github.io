// Decompiled with JetBrains decompiler
// Type: RTG.GizmoSglAxisRotationDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoSglAxisRotationDrag3D : GizmoScreenDrag
  {
    private float _accumSnapDrag;
    private Plane _rotationPlane;
    private Vector3 _screenDragCircleTangent;
    private GizmoSglAxisRotationDrag3D.WorkData _workData;
    private bool _adjustRotationForAbsSnap;
    private float _relativeRotation;
    private float _totalRotation;

    public override GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane RotationPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWorkData(GizmoSglAxisRotationDrag3D.WorkData workData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateDragValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSessionBegin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSessionEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoSglAxisRotationDrag3D() => throw null;

    public struct WorkData
    {
      public Vector3 RotationPlanePos;
      public Vector3 Axis;
      public GizmoSnapMode SnapMode;
      public float SnapStep;
    }
  }
}
