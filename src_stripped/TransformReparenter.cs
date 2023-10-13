// Decompiled with JetBrains decompiler
// Type: TransformReparenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
