// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.FxaaComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
  {
    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(RenderTexture source, RenderTexture destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FxaaComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _QualitySettings;
      internal static readonly int _ConsoleSettings;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
