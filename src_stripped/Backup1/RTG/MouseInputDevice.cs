// Decompiled with JetBrains decompiler
// Type: RTG.MouseInputDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class MouseInputDevice : InputDeviceBase
  {
    private Vector3 _frameDelta;
    private Vector3 _mousePosInLastFrame;

    public override InputDeviceType DeviceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MouseInputDevice() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 GetFrameDelta() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Ray GetRay(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 GetPositionYAxisUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool HasPointer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsButtonPressed(int buttonIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasButtonPressedInCurrentFrame(int buttonIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasButtonReleasedInCurrentFrame(int buttonIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasMoved() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpateFrameDeltas() => throw null;
  }
}
