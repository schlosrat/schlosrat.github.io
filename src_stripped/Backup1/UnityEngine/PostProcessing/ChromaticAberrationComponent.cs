﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ChromaticAberrationComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
