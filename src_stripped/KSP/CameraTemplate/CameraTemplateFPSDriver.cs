// Decompiled with JetBrains decompiler
// Type: KSP.CameraTemplate.CameraTemplateFPSDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ModularCamera;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.CameraTemplate
{
  public class CameraTemplateFPSDriver : CameraDriverBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraTemplateFPSDriver(ICameraDriver other) => throw null;

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
    public CameraTemplateFPSDriver(Transform pivot, Transform gimbal, Transform camera) => throw null;
  }
}
