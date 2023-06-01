// Decompiled with JetBrains decompiler
// Type: ProFlareBatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof (MeshRenderer))]
[RequireComponent(typeof (MeshFilter))]
public class ProFlareBatch : KerbalMonoBehaviour
{
  public bool debugMessages;
  public bool debugSceneView;
  public ProFlareBatch.Mode mode;
  public ProFlareAtlas _atlas;
  public List<FlareData> FlaresList;
  public List<ProFlareElement> FlareElements;
  public ProFlareElement[] FlareElementsArray;
  public Camera GameCamera;
  public Transform GameCameraTrans;
  public Camera FlareCamera;
  public Transform FlareCameraTrans;
  public MeshFilter meshFilter;
  public Transform thisTransform;
  public MeshRenderer meshRender;
  public float zPos;
  private Mesh bufferMesh;
  private Mesh meshA;
  private Mesh meshB;
  private bool PingPong;
  public Material mat;
  private Vector3[] vertices;
  private Vector2[] uv;
  private Color32[] colors;
  private int[] triangles;
  public FlareOcclusion[] FlareOcclusionData;
  public bool useBrightnessThreshold;
  public int BrightnessThreshold;
  public bool overdrawDebug;
  public bool dirty;
  public bool useCulling;
  public int cullFlaresAfterTime;
  public int cullFlaresAfterCount;
  public bool culledFlaresNowVisiable;
  private float reshowCulledFlaresTimer;
  public float reshowCulledFlaresAfter;
  public Transform helperTransform;
  public bool showAllConnectedFlares;
  public bool VR_Mode;
  public float VR_Depth;
  public bool SingleCamera_Mode;
  private ActiveCameraGroup _activeCameraGroup;
  private const float _raycastMax = 300000f;
  private Vector3[] verts;
  private Vector2 _scale;
  private Color32 _color;
  private float PI_Div180;
  private float Div180_PI;
  private int visibleFlares;

  private IPhysicsSpaceProvider PhysicsSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateMat() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SwitchCamera(Camera newCamera) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SwitchToSceneCamera(bool useScene) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateActiveCameraGroup(ActiveCameraGroup activeCameraGroup) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveFlare(ProFlare _flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddFlare(ProFlare _flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateHelperTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateFlares() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ForceRefresh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsCelestialBody(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool TransformModelIsNull(ProFlare flare) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ReBuildGeometry() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetupMeshes() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateOcclusion() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateGeometry() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProFlareBatch() => throw null;

  public enum Mode
  {
    Standard,
    SingleCamera,
    VR,
  }
}
