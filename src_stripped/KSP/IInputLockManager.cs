// Decompiled with JetBrains decompiler
// Type: KSP.IInputLockManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
