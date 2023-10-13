// Decompiled with JetBrains decompiler
// Type: CoroutineHost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoroutineHost : MonoBehaviour
{
  private bool disposable;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static CoroutineHost Create(string name, bool persistThroughSceneChanges, bool disposable) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Coroutine StartCoroutine(IEnumerator coroutine) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator RunAndDispose(IEnumerator coroutine) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Terminate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CoroutineHost() => throw null;
}
