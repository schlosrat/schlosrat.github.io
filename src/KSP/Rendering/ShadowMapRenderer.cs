// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ShadowMapRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public class ShadowMapRenderer : MonoBehaviour
  {
    private const int SHADOW_MAP_SIZE = 1024;
    private const string SCALED_CMD_BUFFER_NAME = "Scaled Space ShadowMap Pass";
    private const float SHADOW_NEAR_CLIP_PLANE = 0.01f;
    private const float SHADOW_BOUNDS_BUFFER_MULT = 1.2f;
    public float bounds_multiplier;
    public float clipPlaneMultipler;
    private const string RESOLVE_CMD_BUFFER_NAME = "Scaled Space ShadowMap Resolve Pass";
    private static readonly int _scaledShadowMapID;
    private static readonly int _scaledShadowMatrixID;
    private static readonly int _physicsToScaledMatrixID;
    private static readonly int _screenCopyID;
    private static readonly Vector3 _shadowViewScale;
    private ShadowSystem _shadowSystem;
    private Light _dirLight;
    private bool _enabled;
    [SerializeField]
    private bool _visualizeShadowMap;
    private RenderTexture _shadowDepthTarget;
    private bool _shadowMapCleared;
    private CommandBuffer _cmdBuffer;
    private Material _shadowCasterMat;
    private bool _cmdBufferActive;
    private CommandBuffer _resolveCmdBuffer;
    private Material _shadowResolveMat;
    private Mesh _fullscreenQuad;
    private ShadowMapRenderer.GraphicsAPI _graphicsDeviceVersion;
    private float _localToScaledFactor;
    private Vector3 _physicsToScaledVector;
    private CelestialBodyRingGroup ringGroup;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(ShadowSystem shadowSystemRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShadowLight(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Enable(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGraphicsDeviceVersion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateShadowResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFullscreenQuad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldRenderShadowMap(CelestialBodyBehavior cbBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderShadowMap(CelestialBodyBehavior soiBodyBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckCmdBufferActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateResolveCmdBuffer(CelestialBodyBehavior soiBodyBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowMapRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ShadowMapRenderer() => throw null;

    private enum GraphicsAPI
    {
      OGL,
      D3D9,
      D3D11,
      D3D12,
      GNM,
    }
  }
}
