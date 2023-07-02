// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCircle2DBorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoCircle2DBorder
  {
    private GizmoPlaneSlider2D _planeSlider;
    private GizmoHandle _targetHandle;
    private CircleShape2D _targetCircle;
    private bool _isVisible;
    private bool _isHoverable;
    private int _borderCircleIndex;
    private CircleShape2D _borderCircle;
    private GizmoCircle2DBorderControllerData _controllerData;
    private IGizmoCircle2DBorderController[] _controllers;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCircle2DBorder(
      GizmoPlaneSlider2D planeSlider,
      GizmoHandle targetHandle,
      CircleShape2D targetCircle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCircleShapeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPreUpdateBegin(Gizmo gizmo) => throw null;
  }
}
