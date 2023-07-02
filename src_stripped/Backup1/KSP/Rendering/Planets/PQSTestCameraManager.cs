// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSTestCameraManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
