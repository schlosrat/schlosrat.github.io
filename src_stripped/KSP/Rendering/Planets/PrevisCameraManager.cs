// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PrevisCameraManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Rendering.impl;
using KSP.Sim;
using KSP.Tools;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Rendering.Planets
{
  public class PrevisCameraManager : MonoBehaviour
  {
    [FormerlySerializedAs("pqsTestScene")]
    [Header("PQS")]
    public PrevisCameraModes previsCameraModes;
    private PQS pqs;
    private Transform _pqsTransform;
    public PQSGlobalSettings GlobalSettings;
    private const string settingsAssetPath = "Assets/Environments/settings/pqs_global_settings.asset";
    private ITransformModel root;
    private ITransformModel targetBodyStar;
    private ITransformModel targetBodyNeighbor;
    private ITransformModel targetBody;
    private ITransformModel viewport;
    private ITransformModel galacticOrigin;
    private Transform origin;
    private bool pqsPosUpdateQueued;
    private Vector3 camRelativePosition;
    private Material _targetBodyScaledMaterial;
    [Header("Cameras")]
    public float cameraFieldOfView;
    private const float CAM_DEFAULT_FOV = 60f;
    public float originUpdateDistance;
    public PQSFreeCam pqsFreeCam;
    public IScaledSpaceProvider scaledSpace;
    private ICameraRenderStack _scaledCamRenderStack;
    public FlightCameraRenderStack_Scaled scaledPrefab;
    private const string scaledPrefabAssetPath = "Assets/Scripts/Simulation Scripts/View/Cameras/prefabs/FlightCameraAssembly_Scaled.prefab";
    public IPhysicsSpaceProvider physicsSpace;
    private ICameraRenderStack _physicsCamRenderStack;
    public FlightCameraRenderStack_Physics physicsPrefab;
    private const string physicsPrefabAssetPath = "Assets/Scripts/Simulation Scripts/View/Cameras/prefabs/FlightCameraAssembly_Physics.prefab";
    private PQSTestCameraShot cameraShot;
    private ICameraRenderView CameraView;
    private PrevisGameInstance PrevisGame;
    [HideInInspector]
    public CoreCelestialBodyData CoreCelestialBodyData;
    public PrevisCelestialBodyProvider PrevisCelestialBodyProvider;
    private bool previsScene;
    private bool updateReady;
    [ReadOnlyUnityInspectorProperty]
    public string pqsName;
    [Header("Star")]
    [ReadOnlyUnityInspectorProperty]
    public string sunName;
    public GameObject sunPrefab;
    private Transform sunScaledObj;
    public double sunDistance;
    public double sunAngle;
    private double sunRadius;
    [Header("Neighbor")]
    [ReadOnlyUnityInspectorProperty]
    public string neighborName;
    public GameObject neighborPrefab;
    private Transform neighborScaledObj;
    public double neighborDistance;
    public double neighborAngle;
    private double neighborRadius;
    public bool isMoon;

    public PQS Pqs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform PQSTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraRenderStack ScaledCameraRenderStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraRenderStack PhysicsCameraRenderStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PQSTestCameraShot CameraShot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreGraphicsManager(bool usePrevis = false, PrevisGameInstance previsGame = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InstantiateCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetPQSData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PostGraphicsManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetSimPrefabData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTransformModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformModel GetObserverTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetObserverPos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformModel GetBodyTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraShotSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrevisCameraManager() => throw null;
  }
}
