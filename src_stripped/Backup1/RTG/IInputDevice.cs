// Decompiled with JetBrains decompiler
// Type: RTG.IInputDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IInputDevice
  {
    event InputDeviceDoubleTapHandler DoubleTap;

    bool DidDoubleTap { get; }

    float DoubleTapDelay { get; set; }

    InputDeviceType DeviceType { get; }

    Ray GetRay(Camera camera);

    Vector3 GetPositionYAxisUp();

    bool HasPointer();

    bool IsButtonPressed(int buttonIndex);

    bool WasButtonPressedInCurrentFrame(int buttonIndex);

    bool WasButtonReleasedInCurrentFrame(int buttonIndex);

    bool WasMoved();

    bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId);

    void RemoveDeltaCapture(int deltaCaptureId);

    Vector3 GetCaptureDelta(int deltaCaptureId);

    Vector3 GetFrameDelta();

    void Update();
  }
}
