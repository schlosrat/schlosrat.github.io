﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GrainComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
  {
    private RenderTexture m_GrainLookupRT;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Prepare(Material uberMaterial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GrainComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _Grain_Params1;
      internal static readonly int _Grain_Params2;
      internal static readonly int _GrainTex;
      internal static readonly int _Phase;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
