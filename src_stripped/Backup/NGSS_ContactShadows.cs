// Decompiled with JetBrains decompiler
// Type: NGSS_ContactShadows
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
[ImageEffectAllowedInSceneView]
public class NGSS_ContactShadows : MonoBehaviour
{
  [Header("REFERENCES")]
  public Light contactShadowsLight;
  public Shader contactShadowsShader;
  [Header("SHADOWS SETTINGS")]
  [Tooltip("Poisson Noise. Randomize samples to remove repeated patterns.")]
  public bool m_noiseFilter;
  [Tooltip("If enabled, backfaced lit fragments will be skipped increasing performance. Requires GBuffer normals.")]
  public bool m_deferredBackfaceOptimization;
  [Tooltip("Set how backfaced lit fragments are shaded. Requires DeferredBackfaceOptimization to be enabled.")]
  [Range(0.0f, 1f)]
  public float m_deferredBackfaceTranslucency;
  [Tooltip("Tweak this value to remove soft-shadows leaking around edges.")]
  [Range(0.01f, 1f)]
  public float m_shadowsEdgeTolerance;
  [Range(0.01f, 1f)]
  [Tooltip("Overall softness of the shadows.")]
  public float m_shadowsSoftness;
  [Tooltip("Overall distance of the shadows.")]
  [Range(1f, 4f)]
  public float m_shadowsDistance;
  [Range(0.1f, 4f)]
  [Tooltip("The distance where shadows start to fade.")]
  public float m_shadowsFade;
  [Range(0.0f, 1f)]
  [Tooltip("Tweak this value if your objects display backface shadows.")]
  public float m_shadowsFrustumBias;
  [Header("RAY SETTINGS")]
  [Tooltip("Number of samplers between each step. The higher values produces less gaps between shadows. Keep this value as low as you can!")]
  [Range(16f, 128f)]
  public int m_raySamples;
  [Tooltip("Samplers scale over distance. Lower this value if you want to speed things up by doing less sampling on far away objects.")]
  [Range(0.0f, 1f)]
  public float m_raySamplesScale;
  [Tooltip("The higher the value, the ticker the shadows will look.")]
  [Range(0.0f, 1f)]
  public float m_rayWidth;
  private Texture2D noMixTexture;
  private CommandBuffer blendShadowsCB;
  private CommandBuffer computeShadowsCB;
  private bool isInitialized;
  private Camera _mCamera;
  private Material _mMaterial;

  private Camera mCamera
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private Material mMaterial
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddCommandBuffers() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveCommandBuffers() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsNotSupported() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnApplicationQuit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPreRender() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPostRender() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NGSS_ContactShadows() => throw null;
}
