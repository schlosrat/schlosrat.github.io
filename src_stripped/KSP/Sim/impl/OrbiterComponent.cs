// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OrbiterComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class OrbiterComponent : ObjectComponent, IPositionDriver, ILinearMotionDriver
  {
    public const int MAX_NBODY_ORBITS = 10;
    private double _lastKnownPeriapsis;
    private double _warpCollisionRecalculateThreshhold;
    private double _collisionUT;
    private bool _isConverged;
    private bool _collisionPathNotified;
    private bool isStable;
    private IUniverseModel universeModel;

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

    public Color orbitColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Color nodeColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float lowerCamVsSmaRatio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float upperCamVsSmaRatio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public PatchedConicsOrbit PatchedConicsOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public List<PatchedNBodyOrbit> PatchedNBodyOrbits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public IPatchedOrbit PatchedOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public bool reverse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<IKeplerOrbit> OrbitalStateUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<OrbiterComponent, CelestialBodyComponent> OnReferenceBodyChange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [TypeConverterIgnore]
    public PatchedConicSolver PatchedConicSolver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public ManeuverPlanSolver ManeuverPlanSolver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public OrbitTargeter OrbitTargeter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Vector3d localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePosition(Position newPosition) => throw null;

    public event Action<Position> PositionUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [TypeConverterIgnore]
    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVelocity(Velocity newVelocity) => throw null;

    public event Action<Velocity> VelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFromStateVectors(Position newPosition, Velocity newVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbiterComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbiterComponent(UniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbiterComponent(OrbiterDefinition orbiterDefinition, IUniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(
      KeplerOrbitState state,
      double universalTime,
      ISimulationModelMap simulationModelMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFromParameters(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckOrbitStability() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckInactiveVesselCollision(double collisionTolerance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onRailsCollision(
      PatchedConicsOrbit patch,
      double collisionTolerance,
      double referenceBodyHeight)
    {
      throw null;
    }
  }
}
