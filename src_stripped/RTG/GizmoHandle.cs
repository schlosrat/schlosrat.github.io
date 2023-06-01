// Decompiled with JetBrains decompiler
// Type: RTG.GizmoHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoHandle : IGizmoHandle
  {
    public GizmoHandleCanHoverHandler CanHover;
    private int _id;
    private Gizmo _gizmo;
    private GizmoTransform _zoomFactorTransform;
    private Priority _genericHoverPriority;
    private Priority _hoverPriority2D;
    private Priority _hoverPriority3D;
    private List<GizmoHandleShape3D> _3DShapes;
    private List<GizmoHandleShape2D> _2DShapes;

    public int Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gizmo Gizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGizmoDragSession DragSession
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Priority GenericHoverPriority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority HoverPriority2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority HoverPriority3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Num3DShapes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Num2DShapes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Has3DShapes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Has2DShapes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Is2DHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Is3DHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Is2DVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Is3DVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoHandle(Gizmo gizmo, int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZoomFactorTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Shape3D Get3DShape(int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Shape2D Get2DShape(int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAll3DShapesVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set3DShapeVisible(int shapeIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Is3DShapeVisible(int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set3DShapeHoverable(int shapeIndex, bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAll2DShapesVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set2DShapeVisible(int shapeIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Is2DShapeVisible(int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set2DShapeHoverable(int shapeIndex, bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains3DShape(Shape3D shape) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains2DShape(Shape2D shape) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add3DShape(Shape3D shape) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add2DShape(Shape2D shape) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove3DShape(Shape3D shape) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove2DShape(Shape2D shape) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render3DSolid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render3DWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render3DSolid(int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render3DWire(int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render2DSolid(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render2DWire(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render2DSolid(Camera camera, int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render2DWire(Camera camera, int shapeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoHandleHoverData GetHoverData(Ray hoverRay) => throw null;
  }
}
