// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ReinforcedConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  public class Module_ReinforcedConnection : PartBehaviourModule
  {
    public const string ReinforcedConnectionJointName = "ReinforcedConnectionJoint";
    [SerializeField]
    protected Data_ReinforcedConnection _dataReinforcedConnection;
    private SubscriptionHandle _handleDocked;
    private SubscriptionHandle _handleUndocked;
    private SubscriptionHandle _handleDetached;
    private SubscriptionHandle _handleDestroyed;
    private SubscriptionHandle _handleChanged;
    private SubscriptionHandle _handleJointBroke;
    [SerializeField]
    private PartOwnerBehavior.JointConnection _reinforcedJoint;
    [SerializeField]
    private PartBehavior _connectedPart;
    private Coroutine _secureJointRoutine;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PartJointBroke(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void VesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitAndSecureReinforcedStrut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SecureReinforcedStrut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PartBehavior GetReinforcedAnchor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PartBehavior GetHeaviestPart(params PartBehavior[] excluded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPack(PartBehavior partBeh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartUnpack(PartBehavior partBeh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyJoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ReinforcedConnection() => throw null;
  }
}
