// Decompiled with JetBrains decompiler
// Type: PlanetRingCameraFX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlanetRingCameraFX : KerbalMonoBehaviour
{
  [Header("Ring Debris Shaders")]
  public Shader ringDebrisFadeShader;
  public Shader ringDebrisOpaqueShader;
  private int colorID;
  private int opacityID;
  private Texture2D ringColorTexture;
  private Texture2D ringDensityTexture;
  [Header("Centripetal Force")]
  public bool xInvert;
  public bool yInvert;
  public bool zInvert;
  private GameObject ringGroup;
  private Collider ringCollider;
  private Renderer ringRenderer;
  private float minRingRadius;
  private float maxRingRadius;
  private GameObject cameraEffect;
  private GameObject particleFieldGroup;
  private GameObject exclusionZoneGroup;
  private PAParticleField debrisPF_01;
  private PAParticleField debrisPF_02;
  private PAParticleField debrisSmallPF;
  private PAParticleField dustPF_01;
  private PAParticleField dustPF_02;
  private float debrisSmallPF_Alpha;
  private float dustPF_01_Alpha;
  private float dustPF_02_Alpha;
  private GameObject minEZ;
  private GameObject maxEZ;
  private double effectFadeMin;
  private double effectFadeMax;
  private double effectDistanceLimit;
  private GameObject physicsSpaceCameraPivot;
  private Position lastPointOnRing;
  private Vector3 lastDifferenceVector;

  private CelestialBodyComponent parentPlanet
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IScaledSpaceProvider scaledSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IPhysicsSpaceProvider physicsSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IUniverseView universeView
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private Transform celestialTransform
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InjectDependencies(
    CelestialBodyComponent body,
    IScaledSpaceProvider scaledSpace,
    IPhysicsSpaceProvider physicsSpace,
    IUniverseView universeObserver,
    Transform celestialTransform,
    GameObject ringGroup,
    Collider ringCollider,
    Renderer ringRenderer)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateParticleField(
    Position cameraIPos,
    Position pointOnRingIPos,
    Position ringCenterIPos,
    double distanceFromRing)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateParticleField_Offset(
    Position cameraIPos,
    Position pointOnRingIPos,
    double centerDist)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateParticleField_Forces(
    Position cameraPos,
    Position pointOnRing,
    Position ringCenter)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateParticleField_ExclusionOffset(
    GameObject zone,
    Position pointOnRing,
    Position ringCenter,
    float radius,
    float bufferScale)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float ClampAngles(float angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float IsForceInverted(bool invert) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Color ReadTextureColor(Texture2D tex, double distance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float ScaleValue(float value, float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsCameraDistanceWitinRange(double camDist, double range) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateRingObject(ITransformFrame planetFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 CalculateRingNormal(GameObject ring) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 CalculateCentripetalForce(Position camPos, Position centerPos) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PlanetRingCameraFX() => throw null;
}
