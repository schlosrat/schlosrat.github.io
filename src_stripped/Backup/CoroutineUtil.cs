// Decompiled with JetBrains decompiler
// Type: CoroutineUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoroutineUtil : MonoBehaviour
{
  private static CoroutineUtil _instance;

  public static CoroutineUtil Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Coroutine DoCoroutine(IEnumerator function) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EndCoroutine(Coroutine coroutine) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CoroutineUtil() => throw null;
}
