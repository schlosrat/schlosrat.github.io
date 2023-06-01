// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ChromaticAberrationComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class ChromaticAberrationComponent : 
    PostProcessingComponentRenderTexture<ChromaticAberrationModel>
  {
    private Texture2D m_SpectrumLut;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Prepare(Material uberMaterial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChromaticAberrationComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _ChromaticAberration_Amount;
      internal static readonly int _ChromaticAberration_Spectrum;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
