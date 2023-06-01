// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.AtmosphereTextureBuffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class AtmosphereTextureBuffer
  {
    public Texture2D TransmittanceTexture;
    public Texture2D IrradianceTexture;
    public Texture3D ScatteringTexture;

    public RenderTexture DeltaIrradianceTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture DeltaRayleighScatteringTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture DeltaMieScatteringTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture DeltaScatteringDensityTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture DeltaMultipleScatteringTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture[] TransmittanceArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture[] IrradianceArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture[] ScatteringArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture[] OptionalSingleMieScatteringArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphereTextureBuffer(bool halfPrecision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyFromRenderTextures(ComputeShader compute, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(ComputeShader compute) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseTexture(RenderTexture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseTexture(Texture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseArray(RenderTexture[] arr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RenderTexture[] NewTexture2DArray(int width, int height, bool halfPrecision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RenderTexture[] NewTexture3DArray(
      int width,
      int height,
      int depth,
      bool halfPrecision)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearArray(ComputeShader compute, RenderTexture[] arr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearTexture(ComputeShader compute, RenderTexture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RenderTexture NewRenderTexture2D(int width, int height, bool halfPrecision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RenderTexture NewRenderTexture3D(
      int width,
      int height,
      int depth,
      bool halfPrecision)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D NewTexture2D(int width, int height, bool halfPrecision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture3D NewTexture3D(int width, int height, int depth, bool halfPrecision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyFromRenderTexture(RenderTexture src, ref Texture2D dest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RenderTexture Copy3DSliceToRenderTexture(
      ComputeShader compute,
      RenderTexture source,
      int layer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyFromRenderTexture(
      ComputeShader compute,
      RenderTexture src,
      ref Texture3D dest)
    {
      throw null;
    }
  }
}
