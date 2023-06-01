// Decompiled with JetBrains decompiler
// Type: RTG.GizmoHandleHoverData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoHandleHoverData
  {
    private int _handleId;
    private Gizmo _gizmo;
    private GizmoDimension _handleDimension;
    private Ray _hoverRay;
    private Vector3 _hoverPoint;
    private float _hoverEnter3D;

    public int HandleId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gizmo Gizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoDimension HandleDimension
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Ray HoverRay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 HoverPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float HoverEnter3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, float hoverEnter3D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, Vector2 hoverPt2D) => throw null;
  }
}
