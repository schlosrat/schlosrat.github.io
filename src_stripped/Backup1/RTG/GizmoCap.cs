// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoCap : IGizmoCap
  {
    private Gizmo _gizmo;
    private GizmoHandle _handle;
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
    public GizmoCap(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void OnVisibilityStateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void OnHoverableStateChanged() => throw null;
  }
}
