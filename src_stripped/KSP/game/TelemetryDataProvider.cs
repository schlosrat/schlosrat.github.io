// Decompiled with JetBrains decompiler
// Type: KSP.Game.TelemetryDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class TelemetryDataProvider : DataBus<VesselComponent>
  {
    private const float NAVBALL_VECTOR_SPEED_THRESHOLD = 0.1f;
    private TelemetryComponent _telemetryComp;
    private Quaternion _navballRotation;

    public PropertyExternal<KSP.Sim.AltimeterDisplayMode> AltimeterDisplayMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyDerived<double, KSP.Sim.AltimeterDisplayMode> DisplayAltitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSP.Sim.SpeedDisplayMode> SpeedDisplayMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyDerived<double, KSP.Sim.SpeedDisplayMode> DisplaySpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> VerticalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> GForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> Heading
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> Latitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> Longitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> AtmosphereStaticPressurekPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> AtmosphereTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> AtmosphereDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> AtmosphereNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> AtmosphereGaugeNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASPrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASRetrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASAntiNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASRadialIn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASRadialOut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASAntiTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASManeuver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASStabilityAssist
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Quaternion> VesselOrbitalProgradeRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> SASEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> RCSEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<VesselControlState> VesselControlStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Quaternion> NAVBallRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> NormalMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> AntiNormalMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> ProgradeMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> RetrogradeMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> RadialInMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> RadialOutMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> ManeuverMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> TargetMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> AntiTargetMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> ProgradeMarkerBelowThreshold
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> RetrogradeMarkerBelowThreshold
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> HasTargetObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> HasManeuver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> CanSetSASOrientationModes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> CanSetSASTargetMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> CanSetSASManeuverMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<Vector3> HighlightMarkerVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryDataProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(VesselComponent dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ValidateProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTelemetryCompTelemetryUpdated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSP.Sim.AltimeterDisplayMode GetAltimeterDisplayMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSP.Sim.SpeedDisplayMode GetSpeedDisplayMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVesselGForce() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVesselHeading() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVesselVerticalSpeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVesselLatitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVesselLongitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion GetNavBallRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetNormalMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetAntiNormalMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetProgradeMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetRetrogradeMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetRadialInMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetRadialOutMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetManeuverMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetTargetMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetAntiTargetMarkerVectorByMovementVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetDisplaySpeedBelowVectorThreshold() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetHasTargetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetHasManeuver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetCanSetSASOrientationModes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetCanSetSASTargetMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetCanSetSASManeuverMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetHighlightVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetNormalizedAtmosphereDensity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetAtmosphereDensityGaugeValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotPrograde() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotRetrograde() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotNormal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotAntiNormal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotRadialIn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotRadialOut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotAntiTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotManeuver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotStabilityAssist() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetAutopilotState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetRCSEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VesselControlState GetVesselControlStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCompSpeedModeChanged(KSP.Sim.SpeedDisplayMode obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCompAltimeterModeChanged(KSP.Sim.AltimeterDisplayMode obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselHasTargetChanged(bool hasTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetMarkerVectorByMovementVector(Vector orbitalMovementVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion GetVesselOrbitalProgradeRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeDisplayValue(KSP.Sim.AltimeterDisplayMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSpeedDisplayValue(KSP.Sim.SpeedDisplayMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTargetDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVesselAtmosphericPressureDisplayValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAltitudeDisplayMode(KSP.Sim.AltimeterDisplayMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSpeedDisplayMode(KSP.Sim.SpeedDisplayMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetAutopilotMode(AutopilotMode autopilotModeNew) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotPrograde(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotRetrograde(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotNormal(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotAntiNormal(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotRadialIn(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotRadialOut(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotTarget(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotAntiTarget(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotManeuver(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotStabilityAssist(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAutopilotState(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSEnabled(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFlightControlMode(FlightControlsMode newMode) => throw null;
  }
}
