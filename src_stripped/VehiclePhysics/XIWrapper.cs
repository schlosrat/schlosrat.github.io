// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.XIWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VehiclePhysics
{
  public static class XIWrapper
  {
    private const string DllName = "XIWrapper";

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Enable() => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Disable() => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsDeviceAttached(XboxDevice device) => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SelectDevice(XboxDevice device) => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetState(out XINPUT_STATE xs) => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetVibration(float left, float right) => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetLastResult() => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr GetLog() => throw null;

    [DllImport("XIWrapper")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearLog() => throw null;
  }
}
