// Decompiled with JetBrains decompiler
// Type: CallbackUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class CallbackUtil
{
  private static Dictionary<MonoBehaviour, Dictionary<Callback, CallbackUtil.LazyCoroutineData>> lazyCoroutines;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback(float timeToWait, Callback cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback(int framesToWait, Callback cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback(IEnumerable yieldObj, Callback cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T>(float timeToWait, Callback<T> cb, T arg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T>(int framesToWait, Callback<T> cb, T arg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T>(IEnumerable yieldObj, Callback<T> cb, T arg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T, U>(
    float timeToWait,
    Callback<T, U> cb,
    T arg1,
    U arg2)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T, U>(
    int framesToWait,
    Callback<T, U> cb,
    T arg1,
    U arg2)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T, U>(
    IEnumerable yieldObj,
    Callback<T, U> cb,
    T arg1,
    U arg2)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T, U, V>(
    float timeToWait,
    Callback<T, U, V> cb,
    T arg1,
    U arg2,
    V arg3)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T, U, V>(
    int framesToWait,
    Callback<T, U, V> cb,
    T arg1,
    U arg2,
    V arg3)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DelayedCallback<T, U, V>(
    IEnumerable yieldObj,
    Callback<T, U, V> cb,
    T arg1,
    U arg2,
    V arg3)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator WaitUntil(Func<bool> condition, Callback cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator DoUntil(Callback cb, Func<bool> condition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator HoldUntil(Func<bool> condition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear(this Callback cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T>(this Callback<T> cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T, U>(this Callback<T, U> cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T, U, V>(this Callback<T, U, V> cb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void LazyCallback(Callback cb, MonoBehaviour coroutineHost, int framedelay) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static IEnumerator lazyCB(
    CallbackUtil.LazyCoroutineData lzcd,
    Dictionary<Callback, CallbackUtil.LazyCoroutineData> lzDict,
    MonoBehaviour host)
  {
    throw null;
  }

  private class LazyCoroutineData
  {
    public Coroutine coroutine;
    public readonly Callback cb;
    public int t;
    public int delay;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LazyCoroutineData(Callback cb) => throw null;
  }
}
