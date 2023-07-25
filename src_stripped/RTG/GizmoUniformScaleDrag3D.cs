// Decompiled with JetBrains decompiler
// Type: RTG.GizmoUniformScaleDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoUniformScaleDrag3D : GizmoPlaneDrag3D
  {
    private GizmoUniformScaleDrag3D.WorkData _workData;
    private Vector3 _planeAxis0;
    private Vector3 _planeAxis1;
    private float _accumSnapDrag;
    private float _scale;
    private float _relativeScale;
    private float _totalScale;
    private Vector3 _scaleDragAxis;

    public override GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWorkData(GizmoUniformScaleDrag3D.WorkData workData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override Plane CalculateDragPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateDragValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSessionEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoUniformScaleDrag3D() => throw null;

    public struct WorkData
    {
      public Vector3 CameraRight;
      public Vector3 CameraUp;
      public Vector3 DragOrigin;
      public float SnapStep;
    }
  }
}
