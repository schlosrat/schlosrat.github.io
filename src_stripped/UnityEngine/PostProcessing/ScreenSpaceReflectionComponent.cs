// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ScreenSpaceReflectionComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
  public sealed class ScreenSpaceReflectionComponent : 
    PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
  {
    private bool k_HighlightSuppression;
    private bool k_TraceBehindObjects;
    private bool k_TreatBackfaceHitAsMiss;
    private bool k_BilateralUpsample;
    private readonly int[] m_ReflectionTextures;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DepthTextureMode GetCameraFlags() => throw null;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CameraEvent GetCameraEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PopulateCommandBuffer(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScreenSpaceReflectionComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _RayStepSize;
      internal static readonly int _AdditiveReflection;
      internal static readonly int _BilateralUpsampling;
      internal static readonly int _TreatBackfaceHitAsMiss;
      internal static readonly int _AllowBackwardsRays;
      internal static readonly int _TraceBehindObjects;
      internal static readonly int _MaxSteps;
      internal static readonly int _FullResolutionFiltering;
      internal static readonly int _HalfResolution;
      internal static readonly int _HighlightSuppression;
      internal static readonly int _PixelsPerMeterAtOneMeter;
      internal static readonly int _ScreenEdgeFading;
      internal static readonly int _ReflectionBlur;
      internal static readonly int _MaxRayTraceDistance;
      internal static readonly int _FadeDistance;
      internal static readonly int _LayerThickness;
      internal static readonly int _SSRMultiplier;
      internal static readonly int _FresnelFade;
      internal static readonly int _FresnelFadePower;
      internal static readonly int _ReflectionBufferSize;
      internal static readonly int _ScreenSize;
      internal static readonly int _InvScreenSize;
      internal static readonly int _ProjInfo;
      internal static readonly int _CameraClipInfo;
      internal static readonly int _ProjectToPixelMatrix;
      internal static readonly int _WorldToCameraMatrix;
      internal static readonly int _CameraToWorldMatrix;
      internal static readonly int _Axis;
      internal static readonly int _CurrentMipLevel;
      internal static readonly int _NormalAndRoughnessTexture;
      internal static readonly int _HitPointTexture;
      internal static readonly int _BlurTexture;
      internal static readonly int _FilteredReflections;
      internal static readonly int _FinalReflectionTexture;
      internal static readonly int _TempTexture;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }

    private enum PassIndex
    {
      RayTraceStep,
      CompositeFinal,
      Blur,
      CompositeSSR,
      MinMipGeneration,
      HitPointToReflections,
      BilateralKeyPack,
      BlitDepthAsCSZ,
      PoissonBlur,
    }
  }
}
