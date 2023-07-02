// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BloomModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class BloomModel : PostProcessingModel
  {
    [SerializeField]
    private BloomModel.Settings m_Settings;

    public BloomModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BloomModel() => throw null;

    [Serializable]
    public struct BloomSettings
    {
      [Tooltip("Strength of the bloom filter.")]
      [Min(0.0f)]
      public float intensity;
      [Min(0.0f)]
      [Tooltip("Filters out pixels under this level of brightness.")]
      public float threshold;
      [Range(0.0f, 1f)]
      [Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
      public float softKnee;
      [Range(1f, 7f)]
      [Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
      public float radius;
      [Tooltip("Reduces flashing noise with an additional filter.")]
      public bool antiFlicker;

      public float thresholdLinear
      {
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public static BloomModel.BloomSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct LensDirtSettings
    {
      [Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
      public Texture texture;
      [Min(0.0f)]
      [Tooltip("Amount of lens dirtiness.")]
      public float intensity;

      public static BloomModel.LensDirtSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct Settings
    {
      public BloomModel.BloomSettings bloom;
      public BloomModel.LensDirtSettings lensDirt;

      public static BloomModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
