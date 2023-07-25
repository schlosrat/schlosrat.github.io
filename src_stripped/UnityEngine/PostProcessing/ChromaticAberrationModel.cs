// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ChromaticAberrationModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class ChromaticAberrationModel : PostProcessingModel
  {
    [SerializeField]
    private ChromaticAberrationModel.Settings m_Settings;

    public ChromaticAberrationModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChromaticAberrationModel() => throw null;

    [Serializable]
    public struct Settings
    {
      [Tooltip("Shift the hue of chromatic aberrations.")]
      public Texture2D spectralTexture;
      [Tooltip("Amount of tangential distortion.")]
      [Range(0.0f, 1f)]
      public float intensity;

      public static ChromaticAberrationModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
