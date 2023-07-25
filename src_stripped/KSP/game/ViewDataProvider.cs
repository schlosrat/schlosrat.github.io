// Decompiled with JetBrains decompiler
// Type: KSP.Game.ViewDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class ViewDataProvider : DataBus<ViewController>
  {
    private Property<List<CelestialDataProvider>> celestialBodiesInternal;
    private SubscriptionHandle _handleVesselChanged;
    private SubscriptionHandle _handleVesselCreated;
    private SubscriptionHandle _handleVesselDestroyed;

    public TelemetryDataProvider TelemetryDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public VesselDataProvider VesselDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public StagingDataProvider StagingDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public UniverseDataProvider UniverseDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ResourceDataProvider ResourceDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsMapEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IProperty<IReadOnlyList<CelestialDataProvider>> CelestialBodies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<bool> IsPartsManagerVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsNavballVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsActionGroupManagerVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsMissionTrackerTooltipVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsTripPlannerVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsFlightReportVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsFlagSiteVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsNonStageableResourcesVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsResourceManagerVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> IsKerbalManagerVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> IsOtherAppBarVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> CanSwitchActiveVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<VesselDataProvider> ActiveVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<IReadOnlyList<VesselComponent>> VesselsInRange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ViewDataProvider(ViewController dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncToVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IReadOnlyList<VesselComponent> GetVesselsInRange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCelestials(
      IEnumerable<CelestialBodyComponent> allCelestialBodies)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetCanSwitchActiveVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPartsManagerVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartsManagerVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetNavballVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidatePartsManagerIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateNavballIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetActionGroupManagerVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionGroupManagerVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateActionGroupManagerIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetMissionTrackerTooltipVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissionTrackerTooltipVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateMissionTrackerIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetTripPlannerVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTripPlannerVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateTripPlannerIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetFlightReportVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlightReportVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateFlightReportIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetFlagSiteVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlagSiteVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateFlagSiteIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetResourceManagerVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetResourceManagerVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateResourceManagerIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetNonStageableResourcesVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetKerbalManagerVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetKerbalManagerVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateKerbalManagerIsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideBentoCanvasGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChange(MessageCenterMessage message) => throw null;
  }
}
