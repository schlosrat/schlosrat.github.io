// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyLensFlareSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public class CelestialBodyLensFlareSystem : MonoBehaviour
  {
    private GameInstance Game;
    private PrevisCameraManager PrevisCameraManager;
    private PrevisCelestialBodyProvider PrevisCelestialBodyProvider;
    private PrevisGameInstance PrevisGame;
    private bool previsScene;
    [SerializeField]
    private LightingSystem LightingSystem;
    private GraphicsManager GraphicsManager;
    private SessionManager SessionManager;
    private IPhysicsSpaceProvider PhysicsSpace;
    private Camera _mainCamera;
    private Transform _mainCameraTransform;
    private CommandBuffer _cmdBuffer;
    private Material _visibilityMaterial;
    private Shader _visibilityShader;
    private string _currentFlareBodyName;
    private static readonly string VISIBILITY_SHADER_NAME;
    private static readonly string SAMPLER_RENDER_VISIBILITY;
    private static readonly string SAMPLER_RENDER_LENSFLARES;
    private static readonly int VISIBILITY_DATA_ID;
    private readonly int OCEAN_DEPTH_TEXTURE_ID;
    private const float FAR_PLANE_OFFSET = 1f;
    private ComputeBuffer _visibilityData;
    private Vector2Int[] _visibilityResults;
    private float _visibility;
    [SerializeField]
    private ProFlareBatch proFlareBatch;
    [SerializeField]
    private Mesh _mesh;
    private Matrix4x4 _flareViewMatrix;
    private Matrix4x4 _flareProjectionMatrix;

    public Camera FlareCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(LightingSystem lightingSystem, bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraChanged(Camera newCamera, ActiveCameraGroup activeCameraGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsRenderLensFlarePassReady() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderLensFlarePass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderBodyVisibility(string samplerTag, CommandBuffer cmd, string body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderLensFlares(string samplerTag, CommandBuffer cmd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AsyncUpdateVisibility(AsyncGPUReadbackRequest request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matrix4x4 GetFarClipPlaneMatrix(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddCommandBuffer(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCommandBuffer(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlareCelestialBody(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveFlareCelestialBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetLensFlareVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyLensFlareSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CelestialBodyLensFlareSystem() => throw null;
  }
}
