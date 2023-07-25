// Decompiled with JetBrains decompiler
// Type: CameraFXModules.Wobble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraFXModules
{
  [Serializable]
  public class Wobble : CameraFXModule
  {
    public float amplitude;
    public float frequency;
    public WobbleModes modes;
    public float seed;
    public float t;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Wobble(
      string id,
      float amplitude,
      float frequency,
      WobbleModes modes,
      Views views,
      float seed,
      float rotFactor = 1f,
      float linFactor = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFXAdded(CameraFXCollection host) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFXRemoved(CameraFXCollection host) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 UpdateLocalPosition(
      Vector3 defaultPos,
      Vector3 currPos,
      float m,
      Views viewMask)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Quaternion UpdateLocalRotation(
      Quaternion defaultRot,
      Quaternion currRot,
      float m,
      Views viewMask)
    {
      throw null;
    }
  }
}
