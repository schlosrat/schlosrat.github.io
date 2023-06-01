// Decompiled with JetBrains decompiler
// Type: NoiseEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Noise")]
[RequireComponent(typeof (Camera))]
public class NoiseEffect : MonoBehaviour
{
  public bool monochrome;
  private bool rgbFallback;
  public float grainIntensityMin;
  public float grainIntensityMax;
  public float grainSize;
  public float scratchIntensityMin;
  public float scratchIntensityMax;
  public float scratchFPS;
  public float scratchJitter;
  public Texture grainTexture;
  public Texture scratchTexture;
  public Shader shaderRGB;
  public Shader shaderYUV;
  private Material m_MaterialRGB;
  private Material m_MaterialYUV;
  private float scratchTimeLeft;
  private float scratchX;
  private float scratchY;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void Start() => throw null;

  protected Material material
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SanitizeParameters() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnRenderImage(RenderTexture source, RenderTexture destination) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NoiseEffect() => throw null;
}
