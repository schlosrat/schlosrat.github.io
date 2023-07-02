// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.VignetteComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
