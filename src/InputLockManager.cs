// Decompiled with JetBrains decompiler
// Type: InputLockManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Obsolete("Use KSP.IInputLockManager")]
public static class InputLockManager
{
  public static Dictionary<string, ulong> lockStack;
  public static ulong lockMask;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void RecalcMask() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static ControlTypes SetControlLock(ControlTypes locks, string lockID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static ControlTypes SetControlLock(string lockID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void RemoveControlLock(string lockID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ClearControlLocks() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static ControlTypes GetControlLock(string lockID) => throw null;

  public static ulong LockMask
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsLocked(ControlTypes controlType) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsUnlocked(ControlTypes controlType) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsAllLocked(ControlTypes mask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsAnyUnlocked(ControlTypes mask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsLocked(ControlTypes controlType, ControlTypes refMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsUnlocked(ControlTypes controlType, ControlTypes refMask) => throw null;

  [Obsolete("deprecated", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsLocking(
    ControlTypes controlType,
    GameEvents.FromToAction<ControlTypes, ControlTypes> refMasks)
  {
    throw null;
  }

  [Obsolete("deprecated", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsUnlocking(
    ControlTypes controlType,
    GameEvents.FromToAction<ControlTypes, ControlTypes> refMasks)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static ulong ControlLocks(int lower, int upper) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static InputLockManager() => throw null;
}
