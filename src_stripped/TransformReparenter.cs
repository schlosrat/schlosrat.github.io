﻿// Decompiled with JetBrains decompiler
// Type: TransformReparenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TransformReparenter : MonoBehaviour
{
  public bool ApplyOnStart;
  public TransformReparenter.ReparentInfo[] ReparentArray;
  public float Delay;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ReParent(int index) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerator ReparentWithDelay(float delay) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TransformReparenter() => throw null;

  [Serializable]
  public struct ReparentInfo
  {
    public Transform ReparentMe;
    public Transform NewParent;
  }
}
