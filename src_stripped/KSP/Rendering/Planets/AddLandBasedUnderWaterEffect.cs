// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.AddLandBasedUnderWaterEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using Unity.Collections;
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
    private NativeArray<Vector3> _invalidRegionSize;
    public NativeArray<Matrix4x4> _invalidRegionWorldToLocalMatrix;
    private bool _waterBackSurfaceMatInitDone;
    private bool _underWaterEffetMatInitDone;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPositionInBoxCollider(Vector3 position, Vector3 colliderSize, float zOffset = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int IsCameraInUnderWaterRegion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleWaterDetectJob() => throw null;

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
