// Decompiled with JetBrains decompiler
// Type: KSP.Sim.CameraInputState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class CameraInputState
  {
    public bool ZoomIn;
    public bool ZoomOut;
    public bool ResetInMode;
    public bool ResetTotal;
    public bool OrbitIsActive;
    public bool PanIsActive;
    public bool IsDragging;
    public bool PanLeft;
    public bool PanRight;
    public bool PanUp;
    public bool PanDown;
    public bool OrbitLeft;
    public bool OrbitRight;
    public bool OrbitUp;
    public bool OrbitDown;
    public bool RollLeft;
    public bool RollRight;
    public bool ToggleAutoOrbit;
    public bool IncreaseInputSpeed;
    public bool DecreaseInputSpeed;
    public bool SwapFrames;
    public bool IsOverUI;
    public bool InputUnlocked;
    public float AxisZoom;
    public float AxisX;
    public float AxisY;
    public float AxisHeading;
    public float AxisPitch;

    public static CameraInputState NoInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasMouseInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInputState(IInputLockManager inputLockManager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsCameraFineMovementEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CameraInputState() => throw null;
  }
}
