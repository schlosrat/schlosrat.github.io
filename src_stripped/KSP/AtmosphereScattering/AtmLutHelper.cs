// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.AtmLutHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.AtmosphereScattering
{
  public static class AtmLutHelper
  {
    public static ComputeShader computeShader;
    private static int CalculateTransmittanceLUT;
    private static int CalculateSingleScatteringLUT;
    private static int CalculateGroundDirectIrradianceLUT;
    private static int CalculateGroundIndirectIrradianceLUT;
    private static int CalculateMultipleScatteringDensityLUT;
    private static int CalculateMultipleScatteringLUT;
    private static int SumGroundIrradianceLUT;
    private static int SumMultipleScatteringLUT;
    private static int ClearCombineGroundIrradianceLUT;
    private static int ClearCombineMultipleScatteringLUT;
    private static int CalculateCameraScatteringVolume;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Init(ComputeShader shader) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetupKernals(ComputeShader computeShader) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyComputeShaderParams(
      AtmLutGenerateConfig lutConfig,
      AtmosphereConfig atmConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateLUT(
      ref RenderTexture result,
      string name,
      int width,
      int height,
      int zsize,
      RenderTextureFormat format,
      bool forceReplace = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void NormalizeProgressPointer(
      float start,
      float end,
      int length,
      out int startInt,
      out int endInt)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateTransmittanceTexture(
      ref RenderTexture target,
      AtmLutGenerateConfig lutconfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateSingleRayleighMieTexture(
      ref RenderTexture rayleigh,
      ref RenderTexture mie,
      AtmLutGenerateConfig lutconfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateGroundIrradianceTexture(
      ref RenderTexture target,
      int order,
      AtmLutGenerateConfig lutconfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateMultiScatteringDensityTexture(
      ref RenderTexture result,
      AtmLutGenerateConfig lutConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateMultiScatteringTexture(
      ref RenderTexture result,
      int order,
      AtmLutGenerateConfig lutConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateFinalCombinedTexture(
      ref RenderTexture MultipleScatteringLUT,
      ref RenderTexture IrradianceLUT,
      AtmLutGenerateConfig lutConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateCameraAlignedVolumeTexture(
      ref RenderTexture transmittance,
      ref RenderTexture scattering,
      Vector3Int volumeTexSize)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateTransmittance(
      RenderTexture target,
      AtmLutGenerateConfig lutConfig,
      float start = 0.0f,
      float end = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateSingleRayleighMie(
      RenderTexture rayleightarget,
      RenderTexture mietarget,
      RenderTexture TransmittanceLUT,
      AtmLutGenerateConfig lutConfig,
      float start = 0.0f,
      float end = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateGroundDirectIrradiance(
      RenderTexture target,
      RenderTexture TransmittanceLUT,
      AtmLutGenerateConfig lutConfig,
      float start = 0.0f,
      float end = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateGroundIrradiance(
      RenderTexture target,
      RenderTexture singleRayleigh,
      RenderTexture singleMie,
      RenderTexture multiScattering,
      int scatteringOrder,
      AtmLutGenerateConfig lutConfig,
      float start = 0.0f,
      float end = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateMultiScatteringDensity(
      RenderTexture target,
      RenderTexture TransmittanceLUT,
      RenderTexture SingleScatteringLUTRayleigh,
      RenderTexture SingleScatteringLUTMie,
      RenderTexture MultiScatteringOfLastOrder,
      RenderTexture GroundDirectIrradianceLUT,
      int scatteringOrder,
      AtmLutGenerateConfig lutConfig,
      float start = 0.0f,
      float end = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateMultiScatteringCombineDensity(
      RenderTexture target,
      RenderTexture TransmittanceLUT,
      RenderTexture multipleScatteringDensity,
      AtmLutGenerateConfig lutConfig,
      float start = 0.0f,
      float end = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearFinalCombinedMultiScatter(
      RenderTexture multiScatteringTarget,
      AtmLutGenerateConfig lutConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateFinalCombinedMultiScatter(
      RenderTexture multiScatteringTarget,
      RenderTexture multiScatteringOfSingleOrder,
      AtmLutGenerateConfig lutConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearFinalCombinedIrradiance(
      RenderTexture target,
      AtmLutGenerateConfig lutConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateFinalCombinedIrradiance(
      RenderTexture target,
      RenderTexture irradianceOfSingleOrder,
      AtmLutGenerateConfig lutConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateCameraVolume(
      RenderTexture transmittanceTarget,
      RenderTexture scatteringTarget,
      Vector3Int volumeSize,
      Vector3 cameraPos,
      Vector3 sunDirection,
      Vector3[] frustrumCorners,
      Vector2 nearFarPlane)
    {
      throw null;
    }
  }
}
