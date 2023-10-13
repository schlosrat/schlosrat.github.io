// Decompiled with JetBrains decompiler
// Type: Awaiters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
