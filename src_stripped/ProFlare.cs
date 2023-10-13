// Decompiled with JetBrains decompiler
// Type: ProFlare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Sim;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class ProFlare : KerbalMonoBehaviour
{
  public ProFlare.FlareType kspFlareType;
  public ProFlareAtlas _Atlas;
  public ProFlareBatch[] FlareBatches;
  public bool EditingAtlas;
  public bool DisabledPlayMode;
  public bool IsVisible;
  private bool _initialized;
  public List<ProFlareElement> Elements;
  public Transform thisTransform;
  public ITransformModel transformModel;
  public Vector3 LensPosition;
  public bool EditGlobals;
  public float GlobalScale;
  public bool MultiplyScaleByTransformScale;
  public float GlobalBrightness;
  public Color GlobalTintColor;
  public bool useMaxDistance;
  public bool useDistanceScale;
  public bool useDistanceFade;
  public float GlobalMaxDistance;
  public bool UseAngleLimit;
  public float maxAngle;
  public bool UseAngleScale;
  public bool UseAngleBrightness;
  public bool UseAngleCurve;
  public AnimationCurve AngleCurve;
  public LayerMask mask;
  public bool RaycastPhysics;
  public bool UsePixelCountVisibility;
  public bool Occluded;
  public float OccludeScale;
  public LayerMask layerMaskFlight;
  public LayerMask layerMaskMap;
  public LayerMask layerMaskOAB;
  public float OcclusionScaledSpace;
  public float OffScreenFadeDist;
  public bool useDynamicEdgeBoost;
  public float DynamicEdgeBoost;
  public float DynamicEdgeBrightness;
  public float DynamicEdgeRange;
  public float DynamicEdgeBias;
  public AnimationCurve DynamicEdgeCurve;
  public bool useDynamicCenterBoost;
  public float DynamicCenterBoost;
  public float DynamicCenterBrightness;
  public float DynamicCenterRange;
  public float DynamicCenterBias;
  public bool neverCull;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PopulateFlareBatches() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ReInitialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProFlare() => throw null;

  public enum FlareType
  {
    Prefab,
    CelestialBody,
  }
}
