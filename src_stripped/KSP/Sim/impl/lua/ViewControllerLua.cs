// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.lua.ViewControllerLua
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.ScriptInterop;
using KSP.Sim.State;
using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl.lua
{
  public class ViewControllerLua
  {
    private ViewController viewController;
    private ISimulationModelMap simulationModelMap;
    private IModelViewMap modelViewMap;
    private SpaceSimulation spaceSimulation;
    private ITypeInterop typeInterop;
    private ITypeWriter typeWriter;
    private IUniverseModel universeModel;
    private IScriptEnvironment scriptEnvironment;
    private int localSpawnedKerbalCount;
    private float spawnRadius;
    private float spawnAngle;
    private int spawnLevel;
    private int spawnCountToTransition;
    private float curAngle;

    private UniverseCameraManager CameraManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ViewControllerLua(
      ViewController viewController,
      SpaceSimulation spaceSimulation,
      ISimulationModelMap simulationModelMap,
      IScriptEnvironment scriptEnvironment,
      IModelViewMap modelViewMap,
      IUniverseModel universeModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ViewController_ReParentToVessel(string childName, string tag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetLanguage(string languageKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetNextSpawnPosition(float zOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InstanceGOByNameAndPlaceInfrontOfCamera(
      string GOName,
      float zOffset = 10f,
      bool placeLocalToCamera = true,
      string kerbalName = null,
      KerbalAttributes? overrideKerbalStats = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Action<string> WrapClosure(IScriptClosure callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ActionGroupStates? ActiveVehicle_GetActionGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool? ActiveVehicle_GetActionGroup(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ActiveVehicle_SetActionGroup(
      KSPActionGroup group,
      bool value,
      IScriptClosure callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SpeedDisplayMode? ActiveVehicle_GetSpeedMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ActiveVehicle_SetSpeedMode(SpeedDisplayMode speedMode, IScriptClosure callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AltimeterDisplayMode? ActiveVehicle_GetAltimeterMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ActiveVehicle_SetAltimeterMode(
      AltimeterDisplayMode altimeterMode,
      IScriptClosure callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private FlightControlsMode? ActiveVehicle_GetFlightControlsMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ActiveVehicle_SetFlightControlsMode(
      FlightControlsMode controlsMode,
      IScriptClosure callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CameraMode FlightCamera_GetMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CameraMode FlightCamera_SetMode(CameraMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerable<CameraMode> FlightCamera_GetAvailableModes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_SetDistance(double distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_GetDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_SetHeading(double heading) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_GetHeading() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_SetPitch(double pitch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_GetPitch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_SetFieldOfView(double fieldOfView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double FlightCamera_GetFieldOfView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlightCamera_RevertToDefaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ViewController_SetActiveVessel(string instanceGuid, bool? controllable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ViewController_GetActiveVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool MapIsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool StartCutscene(string gameObjectName, params Table[] shotList) => throw null;
  }
}
