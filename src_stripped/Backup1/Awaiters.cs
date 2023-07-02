// Decompiled with JetBrains decompiler
// Type: Awaiters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Awaiters
{
  private static readonly WaitForUpdate _waitForUpdate;
  private static readonly WaitForFixedUpdate _waitForFixedUpdate;
  private static readonly WaitForEndOfFrame _waitForEndOfFrame;

  public static WaitForUpdate NextFrame
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static WaitForFixedUpdate FixedUpdate
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static WaitForEndOfFrame EndOfFrame
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static WaitForSeconds Seconds(float seconds) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static WaitForSecondsRealtime SecondsRealtime(float seconds) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static WaitUntil Until(Func<bool> predicate) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static WaitWhile While(Func<bool> predicate) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static Awaiters() => throw null;
}
