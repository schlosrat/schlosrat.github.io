// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABCameraFPSDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ModularCamera;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class OABCameraFPSDriver : CameraDriverBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABCameraFPSDriver(ICameraDriver other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ICameraDriver Clone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetPitch(float value, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetYaw(float value, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetRoll(float value, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RotateWithLockedCamera(
      Action<float, bool> rotationSetter,
      float newVal,
      bool validate = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABCameraFPSDriver(Transform pivot, Transform gimbal, Transform camera) => throw null;
  }
}
