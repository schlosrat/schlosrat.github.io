// Decompiled with JetBrains decompiler
// Type: RTG.InputDeviceBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class InputDeviceBase : IInputDevice
  {
    private float _doubleTapDelay;
    private float _lastTapTime;
    private bool _didDoubleTap;
    private int _maxNumDeltaCaptures;
    private InputDeviceDeltaCapture[] _deltaCaptures;

    public event InputDeviceDoubleTapHandler DoubleTap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool DidDoubleTap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DoubleTapDelay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public abstract InputDeviceType DeviceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputDeviceBase() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMaxNumDeltaCaptures(int maxNumDeltaCaptures) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveDeltaCapture(int deltaCaptureId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetCaptureDelta(int deltaCaptureId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Vector3 GetFrameDelta() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Ray GetRay(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Vector3 GetPositionYAxisUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool HasPointer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsButtonPressed(int buttonIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool WasButtonPressedInCurrentFrame(int buttonIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool WasButtonReleasedInCurrentFrame(int buttonIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool WasMoved() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void UpateFrameDeltas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDeltaCaptures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DetectAndHandleDoubleTap() => throw null;
  }
}
