// Decompiled with JetBrains decompiler
// Type: CameraFXModules.CameraFXModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraFXModules
{
  public abstract class CameraFXModule
  {
    public string id;
    public Views views;
    public float linFactor;
    public float rotFactor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraFXModule(string id, Views views, float rotFactor = 1f, float linFactor = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void OnFXAdded(CameraFXCollection host) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void OnFXRemoved(CameraFXCollection host) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Vector3 UpdateLocalPosition(
      Vector3 defaultPos,
      Vector3 currPos,
      float m,
      Views viewMask)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Quaternion UpdateLocalRotation(
      Quaternion defaultRot,
      Quaternion currRot,
      float m,
      Views viewMask)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool IsActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetModuleID() => throw null;
  }
}
