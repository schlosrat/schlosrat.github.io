// Decompiled with JetBrains decompiler
// Type: NGSS_Local
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (Light))]
[ExecuteInEditMode]
public class NGSS_Local : MonoBehaviour
{
  [Tooltip("Check this option to disable this component from receiving updates calls at runtime or when you hit play in Editor.\nUseful when you have lot of lights in your scene and you don't want that many update calls.")]
  public bool NGSS_DISABLE_ON_PLAY;
  [Tooltip("Check this option if you don't need to update shadows variables at runtime, only once when scene loads.\nUseful when you have lot of lights in your scene and you don't want that many update calls.")]
  public bool NGSS_NO_UPDATE_ON_PLAY;
  [Tooltip("If enabled, this component will manage GLOBAL SETTINGS for all Local shadows.\nEnable this option only in one of your scene local lights to avoid multiple lights fighting for global tweaks.\nLOCAL SETTINGS are not affected by this option.")]
  public bool NGSS_MANAGE_GLOBAL_SETTINGS;
  [Space]
  [Tooltip("Used to test blocker search and early bail out algorithms. Keep it as low as possible, might lead to noise artifacts if too low.\nRecommended values: Mobile = 8, Consoles & VR = 16, Desktop = 24")]
  [Range(4f, 32f)]
  [Header("GLOBAL SETTINGS")]
  public int NGSS_SAMPLING_TEST;
  [Tooltip("Number of samplers per pixel used for PCF and PCSS shadows algorithms.\nRecommended values: Mobile = 12, Consoles & VR = 24, Desktop Med = 32, Desktop High = 48, Desktop Ultra = 64")]
  [Range(4f, 64f)]
  public int NGSS_SAMPLING_FILTER;
  [Space]
  [Tooltip("If zero = 100% noise.\nIf one = 100% dithering.\nUseful when fighting banding.")]
  [Range(0.0f, 1f)]
  public int NGSS_NOISE_TO_DITHERING_SCALE;
  [Tooltip("If you set the noise scale value to something less than 1 you need to input a noise texture.\nRecommended noise textures are blue noise signals.")]
  public Texture2D NGSS_NOISE_TEXTURE;
  [Tooltip("Number of samplers per pixel used for PCF and PCSS shadows algorithms.\nRecommended values: Mobile = 12, Consoles & VR = 24, Desktop Med = 32, Desktop High = 48, Desktop Ultra = 64")]
  [Range(0.0f, 1f)]
  [Space]
  public float NGSS_SHADOWS_OPACITY;
  [Header("LOCAL SETTINGS")]
  [Tooltip("PCSS Requires inline sampling and SM3.5.\nProvides Area Light soft-shadows.\nDisable it if you are looking for PCF filtering (uniform soft-shadows) which runs with SM3.0.")]
  public bool NGSS_PCSS_ENABLED;
  [Tooltip("How soft shadows are when close to caster. Low values means sharper shadows.")]
  [Range(0.0f, 2f)]
  public float NGSS_PCSS_SOFTNESS_NEAR;
  [Tooltip("How soft shadows are when far from caster. Low values means sharper shadows.")]
  [Range(0.0f, 2f)]
  public float NGSS_PCSS_SOFTNESS_FAR;
  [Range(0.0f, 1f)]
  [Tooltip("Value to fix blocker search bias artefacts. Be careful with extreme values, can lead to false self-shadowing.")]
  public float NGSS_PCSS_BLOCKER_BIAS;
  [Space]
  [Tooltip("Defines the Penumbra size of this shadows.")]
  [Range(0.0f, 1f)]
  public float NGSS_SHADOWS_SOFTNESS;
  [Tooltip("Shadows resolution.\nUseQualitySettings = From Quality Settings, SuperLow = 512, Low = 1024, Med = 2048, High = 4096, Ultra = 8192.")]
  public NGSS_Local.ShadowMapResolution NGSS_SHADOWS_RESOLUTION;
  private const string NGSS_NOISE_TEXTURE_KEY = "BlueNoise/BlueNoise_R8_8.png";
  private bool isInitialized;
  private Light _LocalLight;

  private Light LocalLight
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
  private void SetProperties(bool setLocalAndGlobalProperties) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NGSS_Local() => throw null;

  public enum ShadowMapResolution
  {
    UseQualitySettings = 256, // 0x00000100
    VeryLow = 512, // 0x00000200
    Low = 1024, // 0x00000400
    Med = 2048, // 0x00000800
    High = 4096, // 0x00001000
    Ultra = 8192, // 0x00002000
  }
}
