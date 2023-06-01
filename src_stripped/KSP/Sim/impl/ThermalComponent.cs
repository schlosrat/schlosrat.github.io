// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ThermalComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.Converters;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class ThermalComponent : ObjectComponent
  {
    public double TotalCoolingDemand;
    private const double AVERAGE_INITIAL_TEMPERATURE = 280.0;
    private CelestialBodyComponent _currentCBData;
    private Texture2D _bodySurfaceFluxMap;
    private double _netPartFlux;
    private double _partDeltaTemperature;
    private double _bodyAtmosphereFlux;
    private double _bodyLocalFlux;
    private double _bodySurfaceFlux;
    private double _minFlux;
    private double _maxFlux;
    private List<PartComponentModule_Cooler> _coolingModules;
    private List<PartComponent> _partsToDestroy;

    [TypeConverterIgnore]
    public override System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap modelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateEnvironmentFlux(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSolarFlux(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCooling(PartComponent part, double energy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetThermalConductivity(double altitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateBodySurfaceFluxFromColor(Color pixelColorValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double computeEnvironmentFluxForBody(
      CelestialBodyComponent cbComponent,
      PartComponent part,
      ref double atmosphereFlux,
      ref double localFlux,
      ref double surfaceFlux)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 LatLonToPixelCoords(double lat, double lon, int mapWidth, int mapHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermalComponent() => throw null;
  }
}
