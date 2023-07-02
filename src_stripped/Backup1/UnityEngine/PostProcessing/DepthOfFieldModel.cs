// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DepthOfFieldModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class DepthOfFieldModel : PostProcessingModel
  {
    [SerializeField]
    private DepthOfFieldModel.Settings m_Settings;

    public DepthOfFieldModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DepthOfFieldModel() => throw null;

    public enum KernelSize
    {
      Small,
      Medium,
      Large,
      VeryLarge,
    }

    [Serializable]
    public struct Settings
    {
      [Tooltip("Distance to the point of focus.")]
      [Min(0.1f)]
      public float focusDistance;
      [Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
      [Range(0.05f, 32f)]
      public float aperture;
      [Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
      [Range(1f, 300f)]
      public float focalLength;
      [Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
      public bool useCameraFov;
      [Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
      public DepthOfFieldModel.KernelSize kernelSize;

      public static DepthOfFieldModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
