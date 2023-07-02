// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.DirectionalLightShadowController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [ExecuteInEditMode]
  public class DirectionalLightShadowController : KerbalMonoBehaviour
  {
    [Tooltip("If disabled, NGSS Directional shadows replacement will be removed from Graphics settings when OnDisable is called in this component.")]
    [Header("MAIN SETTINGS")]
    public bool NgssKeepOnDisable;
    [Tooltip("Check this option if you don't need to update shadows variables at runtime, only once when scene loads.\nUseful to save some CPU cycles.")]
    public bool NgssUpdateOnPlay;
    [Tooltip("Shadows resolution.\nUseQualitySettings = From Quality Settings, SuperLow = 512, Low = 1024, Med = 2048, High = 4096, Ultra = 8192, Mega = 16384.")]
    public DirectionalLightShadowController.ShadowMapResolution NgssShadowsResolution;
    [Range(4f, 32f)]
    [Header("BASE SAMPLING")]
    [Tooltip("Used to test blocker search and early bail out algorithms. Keep it as low as possible, might lead to white noise if too low.\nRecommended values: Mobile = 8, Consoles & VR = 16, Desktop = 24")]
    public int NgssSamplingTest;
    [Tooltip("Number of samplers per pixel used for PCF and PCSS shadows algorithms.\nRecommended values: Mobile = 16, Consoles & VR = 32, Desktop Med = 48, Desktop High = 64, Desktop Ultra = 128")]
    [Range(8f, 128f)]
    public int NgssSamplingFilter;
    [Tooltip("Overall shadows softness.")]
    [Range(0.0f, 3f)]
    [Header("SHADOW SOFTNESS")]
    public float NgssShadowsSoftness;
    [Tooltip("PCSS Requires inline sampling and SM3.5.\nProvides Area Light soft-shadows.\nDisable it if you are looking for PCF filtering (uniform soft-shadows) which runs with SM3.0.")]
    [Header("PCSS")]
    public bool NgssPcssEnabled;
    [Range(0.0f, 2f)]
    [Tooltip("How soft shadows are when close to caster.")]
    public float NgssPcssSoftnessNear;
    [Range(0.0f, 2f)]
    [Tooltip("How soft shadows are when far from caster.")]
    public float NgssPcssSoftnessFar;
    [Range(0.0f, 1f)]
    [Tooltip("If zero = 100% noise.\nIf one = 100% dithering.\nUseful when fighting banding.")]
    [Header("NOISE")]
    public int NgssNoiseToDitheringScale;
    [Tooltip("If you set the noise scale value to something less than 1 you need to input a noise texture.\nRecommended noise textures are blue noise signals.")]
    public Texture2D NgssNoiseTexture;
    [Header("DENOISER")]
    [Tooltip("How many iterations the Denoiser algorithm should do.\nRequires NGSS Shadows Libraries to be installed and Cascaded Shadows to be enabled in the Editor Graphics Settings.")]
    [Range(1f, 3f)]
    public int NgssDenoiserIterations;
    [Tooltip("Overall Denoiser softness.")]
    [Range(0.0f, 1f)]
    public float NgssDenoiserBlur;
    [Tooltip("The amount of shadow edges the Denoiser can tolerate during denoising.")]
    [Range(0.05f, 1f)]
    public float NgssDenoiserEdgeTolerance;
    [Tooltip("This estimates receiver slope using derivatives and tries to tilt the filtering kernel along it.\nHowever, when doing it in screenspace from the depth texture can leads to shadow artifacts.\nThus it is disabled by default.")]
    [Header("BIAS")]
    public bool NgssReceiverPlaneBias;
    [Header("GLOBAL SETTINGS")]
    [Tooltip("Enable it to let NGSS_Directional control global shadows settings through this component.\nDisable it if you want to manage shadows settings through Unity Quality & Graphics Settings panel.")]
    public bool GlobalSettingsOverride;
    [Tooltip("Shadows projection.\nRecommeded StableFit as it helps stabilizing shadows as camera moves.")]
    public ShadowProjection GlobalShadowsProjection;
    [Tooltip("Sets the maximum distance at wich shadows are visible from camera.\nThis option affects your shadow distance in Quality Settings.")]
    public float GlobalShadowsDistance;
    [Tooltip("Used for the cascade stitching algorithm.\nThese values set the cascade distances as well as number of cascades.")]
    public ShadowCascadeSplits GlobalCascades;
    [Tooltip("Blends cascades at seams intersection.\nAdditional overhead required for this option.")]
    [Header("CASCADES")]
    public bool NgssCascadesBlending;
    [Tooltip("Tweak this value to adjust the blending transition between cascades.")]
    [Range(0.0f, 2f)]
    public float NgssCascadesBlendingValue;
    [Tooltip("If one, softness across cascades will be matched using splits distribution, resulting in realistic soft-ness over distance.\nIf zero the softness distribution will be based on cascade index, resulting in blurrier shadows over distance thus less realistic.")]
    [Range(0.0f, 1f)]
    public float NgssCascadesSoftnessNormalization;
    private const string NGSS_NOISE_TEXTURE_KEY = "BlueNoise/BlueNoise_R8_8.png";
    private bool _isSetup;
    private bool _isInitialized;
    private bool _isGraphicSet;
    private bool _shaderRefsInitialized;
    private Shader _defaultShadowShader;
    private Shader _ngssShadowShader;
    private Light _dirLight;

    public Light DirLight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncToCurrentSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsNotSupported() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DirectionalLightShadowController() => throw null;

    public enum ShadowMapResolution
    {
      UseQualitySettings = 256, // 0x00000100
      VeryLow = 512, // 0x00000200
      Low = 1024, // 0x00000400
      Med = 2048, // 0x00000800
      High = 4096, // 0x00001000
      Ultra = 8192, // 0x00002000
      Mega = 16384, // 0x00004000
    }
  }
}
