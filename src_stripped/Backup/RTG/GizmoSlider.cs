// Decompiled with JetBrains decompiler
// Type: RTG.GizmoSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoSlider : IGizmoSlider
  {
    private GizmoHandle _handle;
    private Gizmo _gizmo;
    private bool _isVisible;
    private bool _isHoverable;

    protected GizmoHandle Handle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gizmo Gizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int HandleId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHovered
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority HoverPriority3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority HoverPriority2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority GenericHoverPriority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoSlider(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void OnVisibilityStateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void OnHoverableStateChanged() => throw null;
  }
}
