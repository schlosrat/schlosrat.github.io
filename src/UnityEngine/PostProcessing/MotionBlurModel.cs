// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.MotionBlurModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class MotionBlurModel : PostProcessingModel
  {
    [SerializeField]
    private MotionBlurModel.Settings m_Settings;

    public MotionBlurModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionBlurModel() => throw null;

    [Serializable]
    public struct Settings
    {
      [Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
      [Range(0.0f, 360f)]
      public float shutterAngle;
      [Range(4f, 32f)]
      [Tooltip("The amount of sample points, which affects quality and performances.")]
      public int sampleCount;
      [Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
      [Range(0.0f, 1f)]
      public float frameBlending;

      public static MotionBlurModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
