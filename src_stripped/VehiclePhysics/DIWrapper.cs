// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DIWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VehiclePhysics
{
  public static class DIWrapper
  {
    private const string DllName = "DIWrapper";

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Initialize() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Release() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetNumDevices() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetDeviceInfo(int n, out DIDEVICEINSTANCE device) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SelectDevice(int index) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool OpenDevice() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CloseDevice() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool AcquireExclusive() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnacquireExclusive() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetNumButtons() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetNumAxis() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetNumFFAxis() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetButtonInfo(int n, out DIDEVICEOBJECTINSTANCE button) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetAxisInfo(int n, out DIDEVICEOBJECTINSTANCE axis) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetFFAxisInfo(int n, out DIDEVICEOBJECTINSTANCE ffaxis) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SelectFFAxis(int n) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PlayConstant(int magnitude) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StopConstant() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PlaySpring(int offset, int saturation, int coefficient) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StopSpring() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PlayDamper(int coefficient) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StopDamper() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PlayFriction(int saturation, int coefficient) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StopFriction() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PlayPeriodic(
      DIWrapper.PeriodicEffect effect,
      int magnitude,
      int offset,
      int phase,
      int period)
    {
      throw null;
    }

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StopPeriodic(DIWrapper.PeriodicEffect effect) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Poll() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetState(out DIJOYSTATE2 js) => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetLastResult() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr GetLog() => throw null;

    [DllImport("DIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearLog() => throw null;

    public enum PeriodicEffect
    {
      Square,
      Sine,
      Triangle,
      SawToothUp,
      SawToothDown,
    }
  }
}
