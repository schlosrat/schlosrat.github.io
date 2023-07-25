// Decompiled with JetBrains decompiler
// Type: CameraFXModules.CameraFXCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraFXModules
{
  [Serializable]
  public class CameraFXCollection
  {
    private List<CameraFXModule> fxModules;
    private int fxModuleCount;
    private Vector3 p;
    private Quaternion r;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraFXCollection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetLocalPositionFX(Vector3 p0, float multiplier, Views viewMask) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion GetLocalRotationFX(Quaternion r0, float multiplier, Views viewMask) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFX(CameraFXModule fx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InsertFX(CameraFXModule fx, int at) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveFX(CameraFXModule fx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(CameraFXModule fx) => throw null;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(CameraFXModule fx) => throw null;

    public CameraFXModule this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
