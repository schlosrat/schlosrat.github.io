// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ColorGradingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class ColorGradingModel : PostProcessingModel
  {
    [SerializeField]
    private ColorGradingModel.Settings m_Settings;

    public ColorGradingModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool isDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    public RenderTexture bakedLut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorGradingModel() => throw null;

    public enum Tonemapper
    {
      None,
      ACES,
      Neutral,
    }

    [Serializable]
    public struct TonemappingSettings
    {
      [Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
      public ColorGradingModel.Tonemapper tonemapper;
      [Range(-0.1f, 0.1f)]
      public float neutralBlackIn;
      [Range(1f, 20f)]
      public float neutralWhiteIn;
      [Range(-0.09f, 0.1f)]
      public float neutralBlackOut;
      [Range(1f, 19f)]
      public float neutralWhiteOut;
      [Range(0.1f, 20f)]
      public float neutralWhiteLevel;
      [Range(1f, 10f)]
      public float neutralWhiteClip;

      public static ColorGradingModel.TonemappingSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct BasicSettings
    {
      [Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
      public float postExposure;
      [Range(-100f, 100f)]
      [Tooltip("Sets the white balance to a custom color temperature.")]
      public float temperature;
      [Range(-100f, 100f)]
      [Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
      public float tint;
      [Tooltip("Shift the hue of all colors.")]
      [Range(-180f, 180f)]
      public float hueShift;
      [Range(0.0f, 2f)]
      [Tooltip("Pushes the intensity of all colors.")]
      public float saturation;
      [Range(0.0f, 2f)]
      [Tooltip("Expands or shrinks the overall range of tonal values.")]
      public float contrast;

      public static ColorGradingModel.BasicSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct ChannelMixerSettings
    {
      public Vector3 red;
      public Vector3 green;
      public Vector3 blue;
      [HideInInspector]
      public int currentEditingChannel;

      public static ColorGradingModel.ChannelMixerSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct LogWheelsSettings
    {
      [Trackball("GetSlopeValue")]
      public Color slope;
      [Trackball("GetPowerValue")]
      public Color power;
      [Trackball("GetOffsetValue")]
      public Color offset;

      public static ColorGradingModel.LogWheelsSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct LinearWheelsSettings
    {
      [Trackball("GetLiftValue")]
      public Color lift;
      [Trackball("GetGammaValue")]
      public Color gamma;
      [Trackball("GetGainValue")]
      public Color gain;

      public static ColorGradingModel.LinearWheelsSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    public enum ColorWheelMode
    {
      Linear,
      Log,
    }

    [Serializable]
    public struct ColorWheelsSettings
    {
      public ColorGradingModel.ColorWheelMode mode;
      [TrackballGroup]
      public ColorGradingModel.LogWheelsSettings log;
      [TrackballGroup]
      public ColorGradingModel.LinearWheelsSettings linear;

      public static ColorGradingModel.ColorWheelsSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct CurvesSettings
    {
      public ColorGradingCurve master;
      public ColorGradingCurve red;
      public ColorGradingCurve green;
      public ColorGradingCurve blue;
      public ColorGradingCurve hueVShue;
      public ColorGradingCurve hueVSsat;
      public ColorGradingCurve satVSsat;
      public ColorGradingCurve lumVSsat;
      [HideInInspector]
      public int e_CurrentEditingCurve;
      [HideInInspector]
      public bool e_CurveY;
      [HideInInspector]
      public bool e_CurveR;
      [HideInInspector]
      public bool e_CurveG;
      [HideInInspector]
      public bool e_CurveB;

      public static ColorGradingModel.CurvesSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct Settings
    {
      public ColorGradingModel.TonemappingSettings tonemapping;
      public ColorGradingModel.BasicSettings basic;
      public ColorGradingModel.ChannelMixerSettings channelMixer;
      public ColorGradingModel.ColorWheelsSettings colorWheels;
      public ColorGradingModel.CurvesSettings curves;

      public static ColorGradingModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
