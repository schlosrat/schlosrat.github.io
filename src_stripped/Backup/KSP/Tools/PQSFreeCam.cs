// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering;
using KSP.Rendering.Planets;
using KSP.Tools.PQSFreeCamUtils;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools
{
  [DisableCustomEditorBase]
  [AddComponentMenu("PQuadSphere/Tools/Free Cam")]
  public class PQSFreeCam : MonoBehaviour
  {
    public double TerrainCollisionDistance;
    public bool EnableOceanCameraCollision;
    public const double MIN_FLIGHT_OFFSET = 5.0;
    public const float MAX_PITCH_UP = 90f;
    public const float MAX_PITCH_DOWN = 90f;
    private const string PREFS_PATH = "<SCENENAME>.PQSTestScene.FreeCam.State";
    private string PREFS_STATE_BOOKMARKS;
    private string PREFS_STATE_SNAPSHOT;
    private const string DEV_AUDIO_COLLISION_TEST_PATH = "Assets/Wwise/Uber Prefabs/Audio/wwiseInit_TestSceneUse.prefab";
    public PQSFreeCam.DevTerrainCollisionDelegate OnDevTerrainCollision;
    private RaycastHit[] _raycastResults;
    private KSPPartAudio _partAudio;
    private GameObject _devHitSphere;
    private bool _debugSphereVisibility;
    private const double baseGroundSpeed = 3.0;
    private const double baseAirSpeed = 6.0;
    private const double altitudeScalePower = 0.65;
    private double altitudeSpeedFactor;
    private const float speedMultiplierChangeFactor = 1.5f;
    private const float speedMultiplierLerpFactor = 0.95f;
    private const float speedMultiplierTimeToSnap = 5f;
    private const float speedMultiplierMax = 20f;
    private const float speedMultiplierMin = 0.001f;
    private const float boostMultiplierChangeFactor = 3f;
    private const float boostMultiplierLerpFactor = 0.95f;
    private const float boostMultiplierTimeToSnap = 0.8f;
    private const float rotateSpeed = 90f;
    private const float rotateLerpFactor = 0.95f;
    private const float rotateTimeToSnap = 3f;
    private const float mouseSpeed = 100f;
    private const float mouseLerpFactor = 0.85f;
    private const float mouseTimeToSnap = 0.1f;
    private const float elevationLerpFactor = 0.95f;
    private const float elevationTimeToSnap = 1f;
    public float doubleClickZoomFactor;
    private Vector3d realPos;
    private PQS pqs;
    private PQSFreeCamGUI gui;
    private Transform floatingOrigin;
    private PrevisCameraManager _previsCameraManager;
    private CoreCelestialBodyData _coreCelestialBodyData;
    public Transform pqsTransform;
    private bool warpedLastFrame;
    private float maxDoubleClickTime;
    private float lastClickTime;
    private ICameraRenderStack physicsRenderStack;
    private Vector3d camHitRadial;
    private Vector3d clickHitRadial;
    private UnityEngine.Ray camRay;
    private UnityEngine.Ray clickRay;

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PQSFreeCamState StateSnapshot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PQSFreeCamBookmarks StateBookmarks
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public FloatSnapLerper SpeedMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatSnapLerper BoostMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatSnapLerper RotateOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector2SnapLerper MouseOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatSnapLerper ElevationOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float CamPitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double CamAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public QuaternionD Orientation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double CenterDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AltitudeSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AltitudeGroundLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double OrbitWarpScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double OrbitThresholdScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PQS Pqs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double PqsRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double PqsRadiusOuter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double OceanAltitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePQSValues(PrevisCameraManager manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateInputDoubleClickWarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateInputBookmarksWarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateInputOrbitToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSpeedFactors() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInputMovement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInputCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTransform() => throw null;

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
    public void MoveToRadial(Vector3d radial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLatLon(double lat, double lon, double heading = 0.0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(
      double lat,
      double lon,
      double altitude,
      AltitudeMode mode,
      float pitch,
      float heading)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(PQSFreeCamState values, bool setSpeedMultiplier = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetMainRenderCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSFreeCamState GetState(AltitudeMode mode = AltitudeMode.FromGround) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAltitude(double altitude, AltitudeMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveStateBookmark(int index, string description = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearStateBookmark(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoadStateBookmark(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPQSPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetSurfaceHeight(Vector3 radialVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetPQSTerrainHitRadial(Vector3d rayPos, Vector3d rayDir, out Vector3d hitRadial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RefineTerrainHitParameter(
      Vector3d rayPos,
      Vector3d rayDir,
      double tStart,
      double tEnd,
      int resolution,
      int iterations,
      out double tFinal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnShootTerrainColliderRay(
      Vector3 origin,
      Vector3 direction,
      bool enableDebugSphere = true,
      bool enableLog = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleDebugSphereVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableDevSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSFreeCam() => throw null;

    public delegate void DevTerrainCollisionDelegate(
      PQSData.BiomeSurfaceData biomeData,
      float hitDistance,
      Vector3 normal);
  }
}
