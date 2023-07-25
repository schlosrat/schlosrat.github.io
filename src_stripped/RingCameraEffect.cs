// Decompiled with JetBrains decompiler
// Type: RingCameraEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class RingCameraEffect : MonoBehaviour
{
  [Header("GameObjects")]
  public GameObject targetPlanet;
  private Camera mainCamera;
  private GameObject ringGroup;
  private GameObject planetRing;
  private Texture2D ringColorTexture;
  private Texture2D ringDensityTexture;
  private Vector3 targetPos;
  private Vector3 targetAngles;
  private Collider targetCollider;
  public float minRingRadius;
  public float maxRingRadius;
  public float minParticleRadius;
  public float maxParticleRadius;
  [Header("Local Space Effect")]
  public GameObject ringLocalSpacePrefab;
  private GameObject cameraEffect;
  private GameObject particleFieldGroup;
  private GameObject debrisGroup;
  private GameObject exclusionZoneGroup;
  private GameObject minEZ;
  private GameObject maxEZ;
  private PAParticleField debrisPF_01;
  private PAParticleField debrisPF_02;
  private PAParticleField debrisSmallPF;
  private PAParticleField dustPF;
  private int debrisPF_Count;
  private float debrisSmallPF_Alpha;
  private float dustPF_Alpha;
  private float effectFadeMin;
  private float effectFadeMax;
  private float effectDistanceLimit;
  [Header("Shaders")]
  public Shader ringDebrisFadeShader;
  public Shader ringDebrisOpaqueShader;
  [Header("Centripetal Force")]
  public float orbitalVelocityScale;
  public bool xInvert;
  public bool yInvert;
  public bool zInvert;
  [SerializeField]
  [Header("Runtime - Debug")]
  private float distanceFromRing;
  [SerializeField]
  private float distanceFromCenter;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateParticleFields(Vector3 camPos, Vector3 ringPos) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ExclusionOffset(GameObject zone, Vector3 ringPos, float radius, float bufferScale) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CalculateDebrisSpeed(Vector3 center, Vector3 cam) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Color ReadTextureColor(Texture2D tex, float distance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private PAParticleField CheckCurrentDebrisPF(float density) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float ScaleValue(float value, float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float IsForceInverted(bool invert) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OffsetEffect(Vector3 ringPoint, Vector3 camPos, float distance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 ClosestPointOnRing(Vector3 source) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 ClampValueToRing(Vector3 newPosition, Vector3 centerPoint) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RingCameraEffect() => throw null;
}
