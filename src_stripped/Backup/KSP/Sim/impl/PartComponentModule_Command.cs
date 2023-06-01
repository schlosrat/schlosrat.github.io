// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_Command
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Modules;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_Command : PartComponentModule
  {
    private FlowRequestResolutionState _returnedRequestResolutionState;
    private bool _hasResourcesToOperate;
    private bool _lastHasResourcesToOperate;
    private bool _requestOutstanding;
    private bool _hasCrewToOperate;
    private bool _hasCommNetToOperate;
    protected Data_Command dataCommand;
    private CommandControlState _lastControlStatus;

    protected bool NeedResourcesToOperate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetInitialHasResourcesToOperateValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHibernateChange(bool newHibernationState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHibernateInWarpChange(bool newHibernateInWarpState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFlowUnits(float rateMultiple) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateControlStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCommNetControlStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateKerbalControlStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsCommandEnabledChanged(bool obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalLocationChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalRemoved(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCommNetConnectionChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnControlStateChanged(CommandControlState newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_Command() => throw null;
  }
}
