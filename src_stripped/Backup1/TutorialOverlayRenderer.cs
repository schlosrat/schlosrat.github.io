// Decompiled with JetBrains decompiler
// Type: TutorialOverlayRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class TutorialOverlayRenderer : PostProcessEffectRenderer<TutorialOverlay>
{
  private Shader _shader;
  private const string _shaderPath = "Hidden/KSP/TutorialOverlay";
  private readonly int _Thickness;
  private readonly int _DepthMultiplier;
  private readonly int _DepthBias;
  private readonly int _LineColor;
  private readonly int _Tint;
  private readonly int _TintBlend;
  private readonly int _BGBlend;
  private readonly int _OceanDepthTexture;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Render(PostProcessRenderContext context) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TutorialOverlayRenderer() => throw null;
}
