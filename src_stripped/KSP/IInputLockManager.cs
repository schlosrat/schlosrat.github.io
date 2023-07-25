// Decompiled with JetBrains decompiler
// Type: KSP.IInputLockManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP
{
  public interface IInputLockManager
  {
    ControlTypes SetControlLock(ControlTypes locks, string lockID);

    ControlTypes SetControlLock(string lockID);

    void RemoveControlLock(string lockID);

    void ClearControlLocks();

    ControlTypes GetControlLock(string lockID);

    ulong LockMask { get; }

    bool IsLocked(ControlTypes controlType);

    bool IsUnlocked(ControlTypes controlType);

    bool IsAllLocked(ControlTypes mask);

    bool IsAnyUnlocked(ControlTypes mask);

    bool IsLocked(ControlTypes controlType, ControlTypes refMask);

    bool IsUnlocked(ControlTypes controlType, ControlTypes refMask);

    [Obsolete("deprecated - make an IContext event if needed")]
    bool IsLocking(
      ControlTypes controlType,
      GameEvents.FromToAction<ControlTypes, ControlTypes> refMasks);

    [Obsolete("deprecated - make an IContext event if needed")]
    bool IsUnlocking(
      ControlTypes controlType,
      GameEvents.FromToAction<ControlTypes, ControlTypes> refMasks);

    ulong ControlLocks(int lower, int upper);
  }
}
