// Decompiled with JetBrains decompiler
// Type: CameraFXModules.Wobble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
