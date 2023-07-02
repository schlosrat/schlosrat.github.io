// Decompiled with JetBrains decompiler
// Type: RTG.GizmoDblAxisScaleDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoDblAxisScaleDrag3D : GizmoPlaneDrag3D
  {
    private GizmoDblAxisScaleDrag3D.WorkData _workData;
    private float _accumSnapDrag0;
    private float _accumSnapDrag1;
    private float _scale0;
    private float _scale1;
    private float _relativeScale0;
    private float _relativeScale1;
    private float _totalScale0;
    private float _totalScale1;
    private Vector3 _scaleDragAxis;

    public override GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int AxisIndex0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int AxisIndex1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeScale0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeScale1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalScale0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalScale1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWorkData(GizmoDblAxisScaleDrag3D.WorkData workData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override Plane CalculateDragPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateDragValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSessionEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoDblAxisScaleDrag3D() => throw null;

    public struct WorkData
    {
      public int AxisIndex0;
      public int AxisIndex1;
      public Vector3 DragOrigin;
      public Vector3 Axis0;
      public Vector3 Axis1;
      public float SnapStep;
    }
  }
}
