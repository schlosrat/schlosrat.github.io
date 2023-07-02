// Decompiled with JetBrains decompiler
// Type: ProFlareBatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering;
using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (MeshFilter))]
[RequireComponent(typeof (MeshRenderer))]
[ExecuteInEditMode]
public class ProFlareBatch : KerbalMonoBehaviour
{
  public ProFlareBatch.Mode BatchMode;
  private static readonly int MASKTEX_ID;
  private const string FLARE_SHADER_NAME = "ProFlares/Textured Flare Shader";
  private const float RAYCAST_MAX = 300000f;
  private const float PI_Div180 = 0.0174532924f;
  private const float Div180_PI = 57.2957764f;
  private CelestialBodyLensFlareSystem LensFlareSystem;
  private IPhysicsSpaceProvider PhysicsSpace;
  private ActiveCameraGroup _activeCameraGroup;
  public float OcclusionScaleTime;
  public float PixelVisibilityThreshold;
  public ProFlareAtlas Atlas;
  public List<FlareData> FlareDataList;
  public List<ProFlareElement> FlareElements;
  public ProFlareElement[] FlareElementsArray;
  public FlareOcclusion[] FlareOcclusionData;
  public Camera GameCamera;
  public Transform GameCameraTransform;
  public Camera FlareCamera;
  public Transform FlareCameraTransform;
  public float ZPos;
  public bool VRMode;
  public float VRDepth;
  public bool SingleCameraMode;
  public MeshFilter MeshFilter;
  public Transform BatchTransform;
  public MeshRenderer MeshRender;
  private Mesh _bufferMesh;
  private Mesh _meshA;
  private Mesh _meshB;
  private bool _pingPong;
  public Material Mat;
  private Vector3[] _vertices;
  private Vector2[] _uv;
  private Color32[] _colors;
  private int[] _triangles;
  public bool UseCulling;
  public int CullFlaresAfterTime;
  public int CullFlaresAfterCount;
  public bool CulledFlaresNowVisible;
  public float ReshowCulledFlaresAfter;
  private float _reshowCulledFlaresTimer;
  public bool UseBrightnessThreshold;
  public int BrightnessThreshold;
  public Transform helperTransform;
  public bool dirty;
  [NonSerialized]
  public bool overdrawDebug;
  [NonSerialized]
  public bool showAllConnectedFlares;
  [NonSerialized]
  public bool debugMessages;
  [NonSerialized]
  public bool debugSceneView;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitDependencies(
    CelestialBodyLensFlareSystem lensFlareSystem,
    IPhysicsSpaceProvider physicsSpace)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SwitchCamera(Camera newCamera) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateActiveCameraGroup(ActiveCameraGroup activeCameraGroup) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ForceRefresh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddFlare(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveFlare(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateHelperTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateOceanFlareMask() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateFlares() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ReBuildGeometry() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetupMeshes() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateGeometry() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateOcclusionVisiblePixels(FlareOcclusion data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateOcclusionRaycast(ProFlare flare, FlareOcclusion data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetOcclusionScale(FlareOcclusion data, float maxScale = 1f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateElementGeometry(
    ProFlare flare,
    FlareOcclusion data,
    Vector3 LensPosition,
    bool isVisible,
    float offScreenFade,
    float centerBoost,
    float dynamicEdgeAmount,
    float angleFallOff,
    float distanceFalloff)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCullingState(
    ref int visibleFlares,
    ref int canCullFlares,
    ProFlare flare,
    FlareOcclusion data)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateBufferMeshArrays() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DisablePlayModeEarlyOut(int elementIndex, int extra) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector2 ScaleSingleElement(int elementIndex, float scaleMulti, ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector2 ScaleMultiElement(int elementIndex, float scaleMulti, int subElementIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ApplyBrightnessThreshold(ref Vector2 scale, Color32 color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetPositionAndRotation(
    int elementIndex,
    int extra,
    Vector3 offset,
    float angle,
    Vector2 scale)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetColorsArray(int extra, Color32 color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float CalculateOffScreenFade(ProFlare flare, Vector3 LensPosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float CalculateCenterBoostAmount(ProFlare flare, Vector3 LensPosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float CalculateDynamicEdgeAmount(ProFlare flare, Vector3 LensPosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float CalculateDistanceFalloff(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float CalculateAngleFalloff(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetElementScale(
    ProFlare flare,
    FlareOcclusion data,
    bool isVisible,
    float centerBoost,
    float dynamicEdgeAmount,
    float angleFallOff,
    float distanceFalloff,
    float tempScale,
    ProFlareElement element)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetElementAlpha(
    ProFlare flare,
    FlareOcclusion data,
    float offScreenFade,
    float centerBoost,
    float dynamicEdgeAmount,
    float angleFallOff,
    float distanceFalloff,
    ProFlareElement element,
    Color GlobalColor)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetElementScreenPosition(
    Vector3 LensPosition,
    bool isVisible,
    ProFlareElement element)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetElementAngle(Vector3 LensPosition, ProFlareElement element) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 GetFlarePosition(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsCelestialBody(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool TransformModelIsNull(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsFlareVisible(Vector3 position, float edgeOffset) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateMat() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProFlareBatch() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static ProFlareBatch() => throw null;

  public enum Mode
  {
    Standard,
    SingleCamera,
    VR,
  }
}
