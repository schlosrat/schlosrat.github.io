// Decompiled with JetBrains decompiler
// Type: RTG.InputDevicePlaneDragSession3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class InputDevicePlaneDragSession3D
  {
    private Plane _plane;
    private Camera _raycastCamera;
    private Vector3 _dragPoint;
    private Vector3 _dragDelta;
    private Vector3 _accumDrag;
    private IInputDevice _inputDevice;
    private bool _isActive;

    public Plane Plane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Camera RaycastCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 DragPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DragDelta
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 AccumDrag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputDevicePlaneDragSession3D(IInputDevice inputDevice, Camera raycastCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Begin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void End() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateDragPoint() => throw null;
  }
}
