// Decompiled with JetBrains decompiler
// Type: KSP.PlanetViewer.PlanetViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.Tools;
using KSP.Tools.PQSFreeCamUtils;
using KSP.VolumeCloud;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.PlanetViewer
{
  public class PlanetViewer : KerbalMonoBehaviour
  {
    private const double MIN_SURFACE_OFFSET = 0.5;
    private const double MIN_FLIGHT_OFFSET = 5.0;
    private const double MAX_PITCH_UP = 90.0;
    private const double MAX_PITCH_DOWN = 90.0;
    private const double BASE_GROUND_SPEED = 3.0;
    private const double BASE_AIR_SPEED = 6.0;
    private const double ALTITUDE_SCALE_POWER = 0.65;
    private double ALTITUDE_SPEED_FACTOR;
    private FloatSnapLerper _speedMultiplier;
    private const float SPEED_MULTIPLIER_CHANGE_FACTOR = 1.5f;
    private const float SPEED_MULTIPLIER_LERP_FACTOR = 0.95f;
    private const float SPEED_MULTIPLIER_TIME_TO_SNAP = 5f;
    private const float SPEED_MULTIPLIER_MAX = 20f;
    private const float SPEED_MULTIPLIER_MIN = 0.001f;
    private FloatSnapLerper _boostMultiplier;
    private const float BOOST_MULTIPLIER_CHANGE_FACTOR = 3f;
    private const float BOOST_MULTIPLIER_LERP_FACTOR = 0.95f;
    private const float BOOST_MULTIPLIER_TIME_TO_SNAP = 0.8f;
    private FloatSnapLerper _rotateOffset;
    private const float ROTATE_SPEED = 90f;
    private const float ROTATE_LERP_FACTOR = 0.95f;
    private const float ROTATE_TIME_TO_SNAP = 3f;
    private Vector2SnapLerper _mouseOffset;
    private const float MOUSE_SPEED = 100f;
    private const float MOUSE_LERP_FACTOR = 0.85f;
    private const float MOUSE_TIME_TO_SNAP = 0.1f;
    private FloatSnapLerper _elevationOffset;
    private const float ELEVATION_LERP_FACTOR = 0.95f;
    private const float ELEVATION_TIME_TO_SNAP = 1f;
    private QuaternionD _orientation;
    private double _centerDistance;
    private double _altitudeSeaLevel;
    private double _altitudeGroundLevel;
    public bool Observing;
    public bool InvalidIndexLastUpdate;
    private int _celestialBodyIndex;
    private string[] _celestialBodyGuids;
    private bool _showKerbalForScale;
    private GameObject _kerbalObject;
    private GameObject _kerbalHead;
    private const string KERBAL_ADDRESSABLE_PREFAB = "body_spacesuit_01.prefab";
    private const string KERBAL_ADDRESSABLE_HEAD_PREFAB = "head_f_01.prefab";
    public float KerbalForwardOffset;
    public float KerbalVerticalOffset;

    public UniverseObserver Observer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInputEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string[] CelestialBodyNameKeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<string> CelestialBodyNameKeysList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel GetCelestialBodySimObject(string cbNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetCelestialBodyComponent(string cbNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCelestialBodyRadius(string cbNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ITransformFrame GetCelestialBodyBodyFrame(string cbNameKey) => throw null;

    public int CelestialBodyIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string CurrentCelestialBodyNameKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double CurrentLatitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double CurrentLongitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double CurrentAltitudeSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double CurrentAltitudeGroundLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double CurrentCelestialBodyRotationAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ShowKerbalForScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private ICameraRenderStack physicsRenderStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private ICameraRenderStack scaledRenderStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double CamPitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double CamAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Exit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitAndReturnToKSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitAndReturnToFlightView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEnabledClouds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableClouds(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VolumeCloudRenderer GetCloudRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInputMovement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInputCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSpeedFactors() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPosition(
      int bodyIndex,
      double latitude,
      double longitude,
      AltitudeMode altitudeMode,
      double altitude,
      double camAngle = 0.0,
      double camPitch = 89.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OffsetCelestialBodyRotationAngle(string guid, double angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetCelestialRotationOffset(string guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ResetAllCelestialBodyRotationOffsets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRotationAngle(string guid, double targetAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTerrainAltitudeFromCenter(string guid, double latitude, double longitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTerrainAltitudeFromCenter(string guid, Vector3d radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValidInputCelestialBody(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSpeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetHeading() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangePitch(float amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeAltitude(double amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeHeading(double amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Translate(double x, double y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateKerbal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyKerbal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateKerbalTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlanetViewer() => throw null;
  }
}
