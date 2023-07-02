// Decompiled with JetBrains decompiler
// Type: RTG.GizmoQuad2DBorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoQuad2DBorder
  {
    private GizmoPlaneSlider2D _planeSlider;
    private GizmoHandle _targetHandle;
    private QuadShape2D _targetQuad;
    private bool _isVisible;
    private bool _isHoverable;
    private int _borderQuadIndex;
    private QuadShape2D _borderQuad;
    private GizmoQuad2DBorderControllerData _controllerData;
    private IGizmoQuad2DBorderController[] _controllers;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoQuad2DBorder(
      GizmoPlaneSlider2D planeSlider,
      GizmoHandle targetHandle,
      QuadShape2D targetQuad)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnQuadShapeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPreUpdateBegin(Gizmo gizmo) => throw null;
  }
}
