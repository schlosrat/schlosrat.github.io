// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.XIWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
