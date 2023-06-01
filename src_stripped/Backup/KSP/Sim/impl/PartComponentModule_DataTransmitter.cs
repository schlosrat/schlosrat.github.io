// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_DataTransmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_DataTransmitter : PartComponentModule
  {
    protected Data_Transmitter _dataTransmitter;
    protected bool _requiresDeployment;
    protected Data_Deployable _dataDeployable;
    private Data_Deployable.DeployState _prevDeployState;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    public double CommunicationRangeMeters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsTransmitterActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeployStateChanged(
      Data_Deployable.DeployState prevDeployState,
      Data_Deployable.DeployState newDeployState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PublishTransmitterStateChangedMessage(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_DataTransmitter() => throw null;
  }
}
