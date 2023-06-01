// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyGIProbeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public struct CelestialBodyGIProbeData
  {
    public SphericalHarmonicsL2 SH;
    private const int MAX_SPHERICAL_GAUSSIANS = 3;
    private SphericalGaussian SG0;
    private SphericalGaussian SG1;
    private SphericalGaussian SG2;
    private static int SGAmplitudeAndSharpness_Id;
    private static int SGAxis_Id;
    private static Vector4[] sgAmplitudeAndSharpnessForShader;
    private static Vector4[] sgAxisForShader;
    private static SphericalHarmonicsL2[] shSingleWorker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAmbientLight(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDirectionalLight(Vector3 direction, Color color, float intensity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDirectionalSGTerm(
      Vector3 direction,
      Color color,
      float intensity,
      float sharpness)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareForShader(int index, ref SphericalGaussian sg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareForShader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyToMaterialPropertyBlock(MaterialPropertyBlock materialPropertyBlock) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyGlobal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CelestialBodyGIProbeData() => throw null;
  }
}
