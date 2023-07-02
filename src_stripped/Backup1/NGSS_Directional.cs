// Decompiled with JetBrains decompiler
// Type: NGSS_Directional
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (Light))]
[ExecuteInEditMode]
public class NGSS_Directional : MonoBehaviour
{
  [Tooltip("If disabled, NGSS Directional shadows replacement will be removed from Graphics settings when OnDisable is called in this component.")]
  [Header("MAIN SETTINGS")]
  public bool NGSS_KEEP_ONDISABLE;
  [Tooltip("Check this option if you don't need to update shadows variables at runtime, only once when scene loads.\nUseful to save some CPU cycles.")]
  public bool NGSS_NO_UPDATE_ON_PLAY;
  [Tooltip("Shadows resolution.\nUseQualitySettings = From Quality Settings, SuperLow = 512, Low = 1024, Med = 2048, High = 4096, Ultra = 8192, Mega = 16384.")]
  public NGSS_Directional.ShadowMapResolution NGSS_SHADOWS_RESOLUTION;
  [Range(4f, 32f)]
  [Header("BASE SAMPLING")]
  [Tooltip("Used to test blocker search and early bail out algorithms. Keep it as low as possible, might lead to white noise if too low.\nRecommended values: Mobile = 8, Consoles & VR = 16, Desktop = 24")]
  public int NGSS_SAMPLING_TEST;
  [Tooltip("Number of samplers per pixel used for PCF and PCSS shadows algorithms.\nRecommended values: Mobile = 16, Consoles & VR = 32, Desktop Med = 48, Desktop High = 64, Desktop Ultra = 128")]
  [Range(8f, 128f)]
  public int NGSS_SAMPLING_FILTER;
  [Header("SHADOW SOFTNESS")]
  [Tooltip("Overall shadows softness.")]
  [Range(0.0f, 3f)]
  public float NGSS_SHADOWS_SOFTNESS;
  [Header("PCSS")]
  [Tooltip("PCSS Requires inline sampling and SM3.5.\nProvides Area Light soft-shadows.\nDisable it if you are looking for PCF filtering (uniform soft-shadows) which runs with SM3.0.")]
  public bool NGSS_PCSS_ENABLED;
  [Tooltip("How soft shadows are when close to caster.")]
  [Range(0.0f, 2f)]
  public float NGSS_PCSS_SOFTNESS_NEAR;
  [Tooltip("How soft shadows are when far from caster.")]
  [Range(0.0f, 2f)]
  public float NGSS_PCSS_SOFTNESS_FAR;
  [Header("NOISE")]
  [Range(0.0f, 1f)]
  [Tooltip("If zero = 100% noise.\nIf one = 100% dithering.\nUseful when fighting banding.")]
  public int NGSS_NOISE_TO_DITHERING_SCALE;
  [Tooltip("If you set the noise scale value to something less than 1 you need to input a noise texture.\nRecommended noise textures are blue noise signals.")]
  public Texture2D NGSS_NOISE_TEXTURE;
  [Range(1f, 3f)]
  [Tooltip("How many iterations the Denoiser algorithm should do.\nRequires NGSS Shadows Libraries to be installed and Cascaded Shadows to be enabled in the Editor Graphics Settings.")]
  [Header("DENOISER")]
  public int NGSS_DENOISER_ITERATIONS;
  [Range(0.0f, 1f)]
  [Tooltip("Overall Denoiser softness.")]
  public float NGSS_DENOISER_BLUR;
  [Range(0.05f, 1f)]
  [Tooltip("The amount of shadow edges the Denoiser can tolerate during denoising.")]
  public float NGSS_DENOISER_EDGE_TOLERANCE;
  [Header("BIAS")]
  [Tooltip("This estimates receiver slope using derivatives and tries to tilt the filtering kernel along it.\nHowever, when doing it in screenspace from the depth texture can leads to shadow artifacts.\nThus it is disabled by default.")]
  public bool NGSS_RECEIVER_PLANE_BIAS;
  [Header("GLOBAL SETTINGS")]
  [Tooltip("Enable it to let NGSS_Directional control global shadows settings through this component.\nDisable it if you want to manage shadows settings through Unity Quality & Graphics Settings panel.")]
  public bool GLOBAL_SETTINGS_OVERRIDE;
  [Tooltip("Shadows projection.\nRecommeded StableFit as it helps stabilizing shadows as camera moves.")]
  public ShadowProjection GLOBAL_SHADOWS_PROJECTION;
  [Tooltip("Sets the maximum distance at wich shadows are visible from camera.\nThis option affects your shadow distance in Quality Settings.")]
  public float GLOBAL_SHADOWS_DISTANCE;
  [Range(0.0f, 4f)]
  [Tooltip("Number of cascades the shadowmap will have. This option affects your cascade counts in Quality Settings.\nYou should entierly disable Cascaded Shadows (Graphics Menu) if you are targeting low-end devices.")]
  public int GLOBAL_CASCADES_COUNT;
  [Tooltip("Used for the cascade stitching algorithm.\nCompute cascades splits distribution exponentially in a x*2^n form.\nIf 4 cascades, set this value to 0.1. If 2 cascades, set it to 0.25.\nThis option affects your cascade splits in Quality Settings.")]
  [Range(0.01f, 0.25f)]
  public float GLOBAL_CASCADES_SPLIT_VALUE;
  [Header("CASCADES")]
  [Tooltip("Blends cascades at seams intersection.\nAdditional overhead required for this option.")]
  public bool NGSS_CASCADES_BLENDING;
  [Tooltip("Tweak this value to adjust the blending transition between cascades.")]
  [Range(0.0f, 2f)]
  public float NGSS_CASCADES_BLENDING_VALUE;
  [Range(0.0f, 1f)]
  [Tooltip("If one, softness across cascades will be matched using splits distribution, resulting in realistic soft-ness over distance.\nIf zero the softness distribution will be based on cascade index, resulting in blurrier shadows over distance thus less realistic.")]
  public float NGSS_CASCADES_SOFTNESS_NORMALIZATION;
  private const string NGSS_NOISE_TEXTURE_KEY = "BlueNoise/BlueNoise_R8_8.png";
  private bool isSetup;
  private bool isInitialized;
  private bool isGraphicSet;
  private Light _DirLight;

  private Light DirLight
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsNotSupported() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NGSS_Directional() => throw null;

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
