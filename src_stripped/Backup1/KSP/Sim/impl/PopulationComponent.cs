// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PopulationComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.Converters;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PopulationComponent : ObjectComponent
  {
    private KerbalRosterManager _roster;
    private KerbalRosterManager.CustomKerbalHandlingOptions _customKerbalOptions;
    private int _refillKerbalLimit;
    private double _refillDelay;
    private bool _refillKerbalEmptySubIdOnly;
    private int _currentKerbalCountTotal;
    private int _currentKerbalCountNoSecondaryId;
    private double _vacancyDetectedAtUT;

    [TypeConverterIgnore]
    public override Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private int _currentKerbalCountWatermark
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalRosterChanges(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCurrentKerbalCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetFillLimit(int newFillLimit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetFillVacancyDelay(int delaySecondsUT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetFillLimitEmptySubIdOnly(bool emptySubIdOnly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetCreateNewNonVeteranKerbals(bool createNonVeterans) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetCreateNewVeteranKerbals(bool createVeteranKerbals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetReuseNonVeteranKerbals(bool reuseNonVeterans) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetReuseVeteranKerbals(bool reuseVeteranKerbals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PopulationComponent() => throw null;
  }
}
