// Decompiled with JetBrains decompiler
// Type: PQSTestCameraModes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AwesomeTechnologies.Utility;
using KSP.Rendering.Planets;
using KSP.Tools;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AwesomeTechnologiesScriptOrder(1)]
public class PQSTestCameraModes : MonoBehaviour
{
  public PQS pqs;
  public Transform scaledPlanet;
  public PQSTestCameraModes.CameraMode mode;
  private Transform camTransform;
  private Light sunLight;
  private List<GameObject> objects;
  private SphereCollider sc;
  private PQSGlobeDisplay globeDisplay;
  private bool lateStarted;
  private PQSRover rover;
  private PQSOrbit orbit;
  private PQSFreeCam freeCam;
  public PQSRenderer pqsRenderer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetupCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Transform GetCamTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleGlobeChildVisibility(bool turnOn) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static T[] FindObjectHierarchyRootsByLayer<T>(int layer, bool includeInactive = false) where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetCamera(Transform parent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetCameraMode(PQSTestCameraModes.CameraMode newMode) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OrbitPutRover(bool useMouse) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RoverSwitchToOrbit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSTestCameraModes() => throw null;

  public enum CameraMode
  {
    Orbit,
    Rover,
    FreeCam,
  }
}
