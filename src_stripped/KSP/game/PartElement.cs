// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class PartElement : ApiDataContext
  {
    [DataProperty("DisplayName")]
    public PropertyReadonly<string> DisplayName;
    [DataProperty("GUID")]
    public PropertyReadonly<IGGuid> Guid;
    [DataList("ActionsList")]
    public ContextListProperty<ActionGroupActionElement> ActionGroupActions;
    [DataProperty("ActionsCount")]
    public PropertyReadonly<int> ActionsCount;
    [DataProperty("HasActions")]
    public PropertyReadonly<bool> HasActions;
    [DataProperty("SelectedActionsCount")]
    public PropertyReadonly<int> SelectedActionsCount;
    [DataProperty("HasSelectedActions")]
    public PropertyReadonly<bool> HasSelectedActions;
    [DataProperty("IsHighlighted")]
    public Property<bool> IsHighlighted;
    private IProperty<KSPActionGroup> _selectedActionGroup;
    private Action _onListChanged;
    private DictionaryValueList<ModuleActionGroupAction, ActionGroupActionElement> _actionMapping;
    private HashSet<ModuleActionGroupAction> _usedActions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartElement(
      IInteractivePart part,
      PropertyReadonly<KSPActionGroup> selectedActionGroupProperty,
      Action onChange)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateElement(
      IInteractivePart part,
      PropertyReadonly<KSPActionGroup> selectedActionGroupProperty)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateProperties() => throw null;
  }
}
