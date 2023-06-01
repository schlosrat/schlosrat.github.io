// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.AddLandBasedUnderWaterEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering.Planets
{
  [ExecuteInEditMode]
  public class AddLandBasedUnderWaterEffect : KerbalMonoBehaviour
  {
    public BoxCollider UnderWaterRegion;
    public BoxCollider[] InvalidUnderWaterRegion;
    private WaterManager _waterManager;
    private CommandBuffer _drawUnderWaterCommand;
    private float _runningTime_caustics;
    private Vector3 _lightDirection;
    private Vector3 _lightColor;
    private Shader _landBasedWaterDepthShader;
    private Material _waterMaterial;
    private Material _waterBackSurfaceMaterial;
    private Material _waterDepthMaterial;
    private Mesh _waterMesh;
    private Camera _mainCamera;
    private GameObject _fullScreenProxy;
    private MeshRenderer _fullScreenProxyRender;
    private const int COMPUTE_GROUP_SIZE = 16;
    private Vector3 _underWaterRegionSize;
    private Vector3[] _invalidUnderWaterRegionSize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float RayTracePlane(
      Vector3 linePoint,
      Vector3 lineDirection,
      Vector3 planePoint,
      Vector3 planeNormal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetWaterSurfacePosition(
      Vector3 position,
      Vector3 horizonUp,
      out Vector3 waterSurfacePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPositionInBoxCollider(Vector3 position, Vector3 colliderSize, float zOffset = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPositionInUnderWaterRegion(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int IsCameraInUnderWaterRegion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessWaterDetectObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawLandBasedWater() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWaterBackSurfaceMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateUnderWaterLightingTexture(float waterHeight, Vector3 objectScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetUnderWaterEffectMaterial(float waterHeight, Vector3 objectScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AddLandBasedUnderWaterEffect() => throw null;
  }
}
