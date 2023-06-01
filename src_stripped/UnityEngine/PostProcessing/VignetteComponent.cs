// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.VignetteComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
  {
    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Prepare(Material uberMaterial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VignetteComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _Vignette_Color;
      internal static readonly int _Vignette_Center;
      internal static readonly int _Vignette_Settings;
      internal static readonly int _Vignette_Mask;
      internal static readonly int _Vignette_Opacity;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
