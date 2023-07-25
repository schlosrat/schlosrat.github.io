// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.FogComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
  public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
  {
    private const string k_ShaderString = "Hidden/Post FX/Fog";

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DepthTextureMode GetCameraFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CameraEvent GetCameraEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PopulateCommandBuffer(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FogComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _FogColor;
      internal static readonly int _Density;
      internal static readonly int _Start;
      internal static readonly int _End;
      internal static readonly int _TempRT;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
