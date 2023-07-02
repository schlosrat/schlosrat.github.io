// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DitheringComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
  {
    private Texture2D[] noiseTextures;
    private int textureIndex;
    private const int k_TextureCount = 64;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadNoiseTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Prepare(Material uberMaterial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DitheringComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _DitheringTex;
      internal static readonly int _DitheringCoords;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
