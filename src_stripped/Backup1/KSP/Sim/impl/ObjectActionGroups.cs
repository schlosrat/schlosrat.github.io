// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ObjectActionGroups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
