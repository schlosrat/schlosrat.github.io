// Decompiled with JetBrains decompiler
// Type: KSP.Game.UniverseDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class UniverseDataProvider : DataBus<ViewController>, IUpdate
  {
    public PLACEHOLDER_FlightTimeMode timeModeValue;
    public PropertyExternal<PLACEHOLDER_FlightTimeMode> TimeMode;
    public PropertyDerived<double, PLACEHOLDER_FlightTimeMode> TimeDisplay;
    public PropertyExternal<double> universalTime_internal;

    public PropertyExternal<int> TimeRateIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<int> MaxTimeRateIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> SelectedTimeRateSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> CurrentWarpRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsTimePaused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> HaveManeuvers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> ClosestManeuverVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IProperty<double> UniversalTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseDataProvider(ViewController dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(ViewController source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ValidateProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TimeRateChanged(float timeRate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IsPausedChanged(bool _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RateIndexChanged(int _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetCurrentWarpRate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetTimeRateIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetMaxTimeRateIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetSelectedTimeRateSpeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetTimeFromMode(PLACEHOLDER_FlightTimeMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PressPlayAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTimeRateIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTimePaused(bool isPaused) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetClosestManeuverVector() => throw null;
  }
}
