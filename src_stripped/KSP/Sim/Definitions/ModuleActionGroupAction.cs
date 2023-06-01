// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ModuleActionGroupAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public class ModuleActionGroupAction : DelegateAction, IModuleAction, IAction, IModuleDataContext
  {
    private string _displayString;

    public string ContextKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetContextKey() => throw null;

    public bool ActionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KSPActionType ActionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KSPActionGroup ActionGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public KSPActionGroup DefaultActionGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsDefault
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ModuleProperty<bool> StateProperty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string DisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ModuleActionGroupAction(Delegate action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ModuleActionGroupAction(Delegate action, KSPActionGroup actionGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleActionGroupAction(Action action, KSPActionGroup defaultActionGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleActionGroupAction(
      Action<bool> action,
      KSPActionGroup defaultActionGroup,
      ModuleProperty<bool> stateProperty = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StateProperty_OnChangedValue(bool obj) => throw null;

    public event ModuleActionGroupAction.ActionChanged OnActionStateChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionGroupMapping(KSPActionGroup newValue, bool fireEvent = true) => throw null;

    public delegate void ActionChanged(ModuleActionGroupAction action, bool newState);
  }
}
