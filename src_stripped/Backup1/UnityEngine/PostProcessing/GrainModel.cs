// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GrainModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
      [Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
      [Range(0.0f, 1f)]
      public float luminanceContribution;

      public static GrainModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
