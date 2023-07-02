// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.InputLockManagerAdapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class InputLockManagerAdapter : IInputLockManager
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    ControlTypes IInputLockManager.SetControlLock(ControlTypes locks, string lockID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ControlTypes IInputLockManager.SetControlLock(string lockID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IInputLockManager.RemoveControlLock(string lockID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IInputLockManager.ClearControlLocks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ControlTypes IInputLockManager.GetControlLock(string lockID) => throw null;

    ulong IInputLockManager.LockMask
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsLocked(ControlTypes controlType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsUnlocked(ControlTypes controlType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsAllLocked(ControlTypes mask) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsAnyUnlocked(ControlTypes mask) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsLocked(ControlTypes controlType, ControlTypes refMask) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsUnlocked(ControlTypes controlType, ControlTypes refMask) => throw null;

    [Obsolete("deprecated - uses GameEvents", true)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsLocking(
      ControlTypes controlType,
      GameEvents.FromToAction<ControlTypes, ControlTypes> refMasks)
    {
      throw null;
    }

    [Obsolete("deprecated - uses GameEvents", true)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IInputLockManager.IsUnlocking(
      ControlTypes controlType,
      GameEvents.FromToAction<ControlTypes, ControlTypes> refMasks)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ulong IInputLockManager.ControlLocks(int lower, int upper) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputLockManagerAdapter() => throw null;
  }
}
