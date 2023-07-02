// Decompiled with JetBrains decompiler
// Type: RTG.GizmoDblAxisRotationDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoDblAxisRotationDrag3D : GizmoScreenDrag
  {
    private GizmoDblAxisRotationDrag3D.WorkData _workData;
    private bool _adjustRotationForAbsSnap;
    private float _accumSnapDrag0;
    private float _accumSnapDrag1;
    private float _relativeRotation0;
    private float _relativeRotation1;
    private float _totalRotation0;
    private float _totalRotation1;

    public override GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeRotation0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeRotation1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalRotation0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalRotation1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWorkData(GizmoDblAxisRotationDrag3D.WorkData workData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateDragValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSessionEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoDblAxisRotationDrag3D() => throw null;

    public struct WorkData
    {
      public Vector2 ScreenAxis0;
      public Vector2 ScreenAxis1;
      public Vector3 Axis0;
      public Vector3 Axis1;
      public GizmoSnapMode SnapMode;
      public float SnapStep0;
      public float SnapStep1;
    }
  }
}
