// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ObjectActionGroups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public abstract class ObjectActionGroups
  {
    protected DictionaryValueList<KSPActionGroup, ActionGroup> _groups;
    protected Dictionary<KSPActionGroup, HashSet<IGGuid>> _partIds;

    public ActionGroup this[KSPActionGroup key]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ObjectActionGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateDictionary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetActionGroupStateInternal(KSPActionGroup group, bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ToggleActionGroupActionsInternal(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddActionToActionGroup(ModuleActionGroupAction action, KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveActionFromActionGroup(ModuleActionGroupAction action, KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract IEnumerable<object> GetListOfParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void SendActionGroupsChangedMessage() => throw null;
  }
}
