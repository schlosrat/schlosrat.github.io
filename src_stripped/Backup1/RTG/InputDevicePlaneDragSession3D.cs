// Decompiled with JetBrains decompiler
// Type: RTG.InputDevicePlaneDragSession3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
