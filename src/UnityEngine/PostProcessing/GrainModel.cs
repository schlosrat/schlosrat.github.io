// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GrainModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class GrainModel : PostProcessingModel
  {
    [SerializeField]
    private GrainModel.Settings m_Settings;

    public GrainModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GrainModel() => throw null;

    [Serializable]
    public struct Settings
    {
      [Tooltip("Enable the use of colored grain.")]
      public bool colored;
      [Tooltip("Grain strength. Higher means more visible grain.")]
      [Range(0.0f, 1f)]
      public float intensity;
      [Tooltip("Grain particle size.")]
      [Range(0.3f, 3f)]
      public float size;
      [Range(0.0f, 1f)]
      [Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
      public float luminanceContribution;

      public static GrainModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
