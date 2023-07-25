// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.VignetteModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class VignetteModel : PostProcessingModel
  {
    [SerializeField]
    private VignetteModel.Settings m_Settings;

    public VignetteModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VignetteModel() => throw null;

    public enum Mode
    {
      Classic,
      Masked,
    }

    [Serializable]
    public struct Settings
    {
      [Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
      public VignetteModel.Mode mode;
      [Tooltip("Vignette color. Use the alpha channel for transparency.")]
      [ColorUsage(false)]
      public Color color;
      [Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
      public Vector2 center;
      [Tooltip("Amount of vignetting on screen.")]
      [Range(0.0f, 1f)]
      public float intensity;
      [Tooltip("Smoothness of the vignette borders.")]
      [Range(0.01f, 1f)]
      public float smoothness;
      [Range(0.0f, 1f)]
      [Tooltip("Lower values will make a square-ish vignette.")]
      public float roundness;
      [Tooltip("A black and white mask to use as a vignette.")]
      public Texture mask;
      [Range(0.0f, 1f)]
      [Tooltip("Mask opacity.")]
      public float opacity;
      [Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
      public bool rounded;

      public static VignetteModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
