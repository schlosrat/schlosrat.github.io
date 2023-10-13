// Decompiled with JetBrains decompiler
// Type: LightCullingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Rendering;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LightCullingManager : KerbalMonoBehaviour
{
  public static LightCullingManager Singleton;
  public TimeOfDayManager TODManager;
  public Mesh LightQuadMesh;
  public Material LightQuadMaterial;
  private Camera _targetCamera;
  private CullingGroup _mainCameraGroup;
  private int _lightCount;
  private BoundingSphere[] _boundingSpheres;
  private SceneLightInfo[] _lightInfo;
  private float[] _lightDistanceBands;
  private Transform _thisTransform;
  private Vector3 _lastPosition;
  private bool _lightsEnabled;
  private const int MAX_INSTANCE_COUNT = 1023;
  private int EMISSION_COLOR_ID;
  private int ALPHA_MAX_ID;
  private MaterialPropertyBlock _lightQuadMatPropBlock;
  private Matrix4x4[] _lightQuadMatrices;
  private Vector4[] _quadEmissionColors;
  private float[] _quadAlphaMaxes;
  private Vector4[] _tempColors;
  private float[] _tempAlphas;
  private Matrix4x4[] _tempTRSs;
  private int _iterations;
  private int _remainder;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CullGroupOnStateChanged(CullingGroupEvent sphere) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetBoundingSphere(int index, Vector3 position, float radius) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetLightInfo(
    int index,
    Transform lightObjectTransform,
    Light light,
    Transform quadTransform)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetLightQuadLODInfo(int index, Transform t, Color emissionColor, float alphaMax) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int GetIndex() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleLights(bool enabled) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LightCullingManager() => throw null;
}
