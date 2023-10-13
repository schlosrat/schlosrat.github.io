// Decompiled with JetBrains decompiler
// Type: ScaledSpaceTextureGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class ScaledSpaceTextureGenerator : MonoBehaviour
{
  public RenderTexture RenderTextureAlbedo;
  public RenderTexture RenderTextureSpecular;
  public RenderTexture RenderTextureNormal;
  public RenderTexture RenderTextureEmission;
  public float DistanceToCamera;
  public Camera OrthoCamera;
  private Camera _currentCamera;
  private static readonly int GenerateScaledSpaceCameraDistanceID;
  private static readonly int GenerateScaledSpaceIncludeDecalsID;
  private static readonly int GenerateScaledSpaceIncludeBackgroundID;
  private static readonly int GenerateScaledSpace_IncludeOceanID;
  private static readonly int GenerateScaledSpace_OceanHeightID;
  private static readonly int GenerateScaledSpace_OceanColorID;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateOrthoCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateRenderTextures() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DestroyRenderTextures() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GenerateTextures(
    ScaledSpaceTextureGeneratorSettings settings,
    Material pqsMaterial,
    MaterialPropertyBlock materialPropertyBlock,
    int vertexCount,
    float radius)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void BlendPolarNormals(
    Texture2D pqsNormalTexture,
    Texture2D polarTexture,
    int totalLines,
    int blendLines)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Color SamplePolarPixel(Texture2D polarNormal, float sourceAngle, float radius) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTextureSrgb(string assetPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTextureMaxSize(string assetPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTextureMaxSizeAndQuality(string assetPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTextureNormalMap(string assetPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SaveTexture(Texture2D source, string name) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Texture2D CreateTextureFromRenderTexture(RenderTexture source) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ScaledSpaceTextureGenerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static ScaledSpaceTextureGenerator() => throw null;
}
