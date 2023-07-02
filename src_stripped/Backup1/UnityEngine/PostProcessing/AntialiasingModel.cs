// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.AntialiasingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class AntialiasingModel : PostProcessingModel
  {
    [SerializeField]
    private AntialiasingModel.Settings m_Settings;

    public AntialiasingModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AntialiasingModel() => throw null;

    public enum Method
    {
      Fxaa,
      Taa,
    }

    public enum FxaaPreset
    {
      ExtremePerformance,
      Performance,
      Default,
      Quality,
      ExtremeQuality,
    }

    [Serializable]
    public struct FxaaQualitySettings
    {
      [Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
      [Range(0.0f, 1f)]
      public float subpixelAliasingRemovalAmount;
      [Range(0.063f, 0.333f)]
      [Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
      public float edgeDetectionThreshold;
      [Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
      [Range(0.0f, 0.0833f)]
      public float minimumRequiredLuminance;
      public static AntialiasingModel.FxaaQualitySettings[] presets;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static FxaaQualitySettings() => throw null;
    }

    [Serializable]
    public struct FxaaConsoleSettings
    {
      [Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
      [Range(0.33f, 0.5f)]
      public float subpixelSpreadAmount;
      [Range(2f, 8f)]
      [Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
      public float edgeSharpnessAmount;
      [Range(0.125f, 0.25f)]
      [Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
      public float edgeDetectionThreshold;
      [Range(0.04f, 0.06f)]
      [Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
      public float minimumRequiredLuminance;
      public static AntialiasingModel.FxaaConsoleSettings[] presets;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static FxaaConsoleSettings() => throw null;
    }

    [Serializable]
    public struct FxaaSettings
    {
      public AntialiasingModel.FxaaPreset preset;

      public static AntialiasingModel.FxaaSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct TaaSettings
    {
      [Range(0.1f, 1f)]
      [Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
      public float jitterSpread;
      [Range(0.0f, 3f)]
      [Tooltip("Controls the amount of sharpening applied to the color buffer.")]
      public float sharpen;
      [Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
      [Range(0.0f, 0.99f)]
      public float stationaryBlending;
      [Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
      [Range(0.0f, 0.99f)]
      public float motionBlending;

      public static AntialiasingModel.TaaSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct Settings
    {
      public AntialiasingModel.Method method;
      public AntialiasingModel.FxaaSettings fxaaSettings;
      public AntialiasingModel.TaaSettings taaSettings;

      public static AntialiasingModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
