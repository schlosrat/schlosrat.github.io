// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ActionGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ActionGroup : List<ModuleActionGroupAction>
  {
    public KSPActionType ActionType;
    public KSPActionGroupState ActionGroupState;
    public readonly KSPActionGroup Group;
    private int _partCount;

    public int PartCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroup(KSPActionGroup groupType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckAddGroupAndWarn(ModuleActionGroupAction newAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckRemoveGroupAndWarn(ModuleActionGroupAction newAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void Add(ModuleActionGroupAction newAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void Insert(int index, ModuleActionGroupAction newAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void CopyTo(ModuleActionGroupAction[] array, int arrayIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new bool Remove(ModuleActionGroupAction action) => throw null;

    [Obsolete("This list is not order sensitive, use Remove instead of this", true)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void RemoveAt(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubscribeAction(ModuleActionGroupAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnsubscribeAction(ModuleActionGroupAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StateProperty_OnChangedValue(bool obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateActionGroupState() => throw null;
  }
}
