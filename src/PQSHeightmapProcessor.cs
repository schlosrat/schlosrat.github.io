// Decompiled with JetBrains decompiler
// Type: PQSHeightmapProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PQSHeightmapProcessor
{
  private const string computeAssetPath = "Assets/Scripts/Scenery/PQS Library/Shaders/HeightmapProcessing.compute";
  private ComputeShader heightMapProcShader;
  private int blurRadius;
  private const int gpuMemoryBlockSizeBlur = 512;
  private const int gpuSobelBlockSize = 32;
  private const int gpuLoGBlockSize = 32;
  private int hmBlurHorzKernelID;
  private int hmBlurVertKernelID;
  private int hmSobelFilterKernelID;
  private int hmLoGFilterKernelID;
  private int hmGaussianBlurKernelID;
  private RenderTexture hmBlurSource;
  private RenderTexture hmBlurHorzOutput;
  private RenderTexture hmBlurVertOutput;
  private RenderTexture sobelOutput;
  private RenderTexture logOutput;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSHeightmapProcessor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Dispose() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ClearTexture(ref RenderTexture texToClear) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ClearTextures() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateTexture(ref RenderTexture texToCreate, int w, int h) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void BlurHeightMap_GPU(Texture2D hm) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GaussianBlurHeightMap_GPU(Texture2D hm, int radius) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CopyTexture(Texture2D src, ref RenderTexture dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Texture2D CreateGradienceMap_GPU(Texture2D hm) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Texture2D CreateCurvatureMap_GPU(Texture2D hm) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CopyTexture(RenderTexture src, ref Texture2D dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitTextures(int width, int height) => throw null;
}
