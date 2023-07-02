// Decompiled with JetBrains decompiler
// Type: RTG.InputDeviceScreenDragSession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class InputDeviceScreenDragSession
  {
    private Vector2 _dragPoint;
    private Vector2 _dragDelta;
    private Vector2 _accumDrag;
    private IInputDevice _inputDevice;
    private bool _isActive;

    public Vector2 DragPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 DragDelta
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 AccumDrag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputDeviceScreenDragSession(IInputDevice inputDevice) => throw null;

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
