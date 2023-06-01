// Decompiled with JetBrains decompiler
// Type: IEnumeratorAwaitExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class IEnumeratorAwaitExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiter(
    this WaitForSeconds instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiter(
    this WaitForUpdate instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiter(
    this WaitForEndOfFrame instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiter(
    this WaitForFixedUpdate instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiter(
    this WaitForSecondsRealtime instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiter(
    this WaitUntil instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiter(
    this WaitWhile instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(
    this AsyncOperation instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(
    this ResourceRequest instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<WWW> GetAwaiter(
    this WWW instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<AssetBundle> GetAwaiter(
    this AssetBundleCreateRequest instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(
    this AssetBundleRequest instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<T> GetAwaiter<T>(
    this IEnumerator<T> coroutine)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<object> GetAwaiter(
    this IEnumerator coroutine)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter GetAwaiterReturnVoid(
    object instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<T> GetAwaiterReturnSelf<T>(
    T instruction)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void RunOnUnityScheduler(Action action) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void Assert(bool condition) => throw null;

  public class SimpleCoroutineAwaiter<T> : INotifyCompletion
  {
    private bool _isDone;
    private Exception _exception;
    private Action _continuation;
    private T _result;

    public bool IsCompleted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetResult() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Complete(T result, Exception e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INotifyCompletion.OnCompleted(Action continuation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleCoroutineAwaiter() => throw null;
  }

  public class SimpleCoroutineAwaiter : INotifyCompletion
  {
    private bool _isDone;
    private Exception _exception;
    private Action _continuation;

    public bool IsCompleted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetResult() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Complete(Exception e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INotifyCompletion.OnCompleted(Action continuation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleCoroutineAwaiter() => throw null;
  }

  private class CoroutineWrapper<T>
  {
    private readonly IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<T> _awaiter;
    private readonly Stack<IEnumerator> _processStack;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CoroutineWrapper(
      IEnumerator coroutine,
      IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<T> awaiter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator Run() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GenerateObjectTraceMessage(List<System.Type> objTrace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<System.Type> GenerateObjectTrace(IEnumerable<IEnumerator> enumerators) => throw null;
  }

  private static class InstructionWrappers
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerator ReturnVoid(
      IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter awaiter,
      object instruction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerator AssetBundleCreateRequest(
      IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<AssetBundle> awaiter,
      AssetBundleCreateRequest instruction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerator ReturnSelf<T>(
      IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<T> awaiter,
      T instruction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerator AssetBundleRequest(
      IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<UnityEngine.Object> awaiter,
      AssetBundleRequest instruction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerator ResourceRequest(
      IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter<UnityEngine.Object> awaiter,
      ResourceRequest instruction)
    {
      throw null;
    }
  }
}
