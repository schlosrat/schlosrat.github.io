// Decompiled with JetBrains decompiler
// Type: CoroutineUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
