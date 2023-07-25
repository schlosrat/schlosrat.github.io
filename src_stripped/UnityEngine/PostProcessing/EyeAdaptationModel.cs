// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.EyeAdaptationModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class EyeAdaptationModel : PostProcessingModel
  {
    [SerializeField]
    private EyeAdaptationModel.Settings m_Settings;

    public EyeAdaptationModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EyeAdaptationModel() => throw null;

    public enum EyeAdaptationType
    {
      Progressive,
      Fixed,
    }

    [Serializable]
    public struct Settings
    {
      [Range(1f, 99f)]
      [Tooltip("Filters the dark part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
      public float lowPercent;
      [Range(1f, 99f)]
      [Tooltip("Filters the bright part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
      public float highPercent;
      [Tooltip("Minimum average luminance to consider for auto exposure (in EV).")]
      public float minLuminance;
      [Tooltip("Maximum average luminance to consider for auto exposure (in EV).")]
      public float maxLuminance;
      [Min(0.0f)]
      [Tooltip("Exposure bias. Use this to offset the global exposure of the scene.")]
      public float keyValue;
      [Tooltip("Set this to true to let Unity handle the key value automatically based on average luminance.")]
      public bool dynamicKeyValue;
      [Tooltip("Use \"Progressive\" if you want the auto exposure to be animated. Use \"Fixed\" otherwise.")]
      public EyeAdaptationModel.EyeAdaptationType adaptationType;
      [Min(0.0f)]
      [Tooltip("Adaptation speed from a dark to a light environment.")]
      public float speedUp;
      [Min(0.0f)]
      [Tooltip("Adaptation speed from a light to a dark environment.")]
      public float speedDown;
      [Range(-16f, -1f)]
      [Tooltip("Lower bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
      public int logMin;
      [Range(1f, 16f)]
      [Tooltip("Upper bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
      public int logMax;

      public static EyeAdaptationModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
