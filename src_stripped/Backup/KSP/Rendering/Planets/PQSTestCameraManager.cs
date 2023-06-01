// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSTestCameraManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using KSP.Rendering.impl;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Rendering.Planets
{
  [AwesomeTechnologiesScriptOrder(2)]
  public class PQSTestCameraManager : MonoBehaviour
  {
    public float CameraFieldOfView;
    [FormerlySerializedAs("pqsTestScene")]
    public PQSTestCameraModes PqsTestCameraModes;
    private PQS pqs;
    public FlightCameraRenderStack_Scaled ScaledPrefab;
    public FlightCameraRenderStack_Physics PhysicsPrefab;
    private GameObject debugSkyboxCam;
    private ITransformModel root;
    private ITransformModel sun;
    private ITransformModel planet;
    private ITransformModel viewport;
    private ITransformModel galacticOrigin;
    private PQSTestCameraScaledSpaceProvider scaledSpace;
    private IPhysicsSpaceProvider physicsSpace;
    private PQSTestCameraShot cameraShot;
    private ICameraRenderView cameraView;
    private GameObject debugLocal;
    private GameObject debugScaled;
    public CoreCelestialBodyData CoreCelestialBodyData;
    public PQSGlobalSettings GlobalSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTransformModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraShotSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSTestCameraManager() => throw null;
  }
}
