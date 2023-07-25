// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.MotionBlurModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
      [Range(0.0f, 360f)]
      [Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
      public float shutterAngle;
      [Range(4f, 32f)]
      [Tooltip("The amount of sample points, which affects quality and performances.")]
      public int sampleCount;
      [Range(0.0f, 1f)]
      [Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
      public float frameBlending;

      public static MotionBlurModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
