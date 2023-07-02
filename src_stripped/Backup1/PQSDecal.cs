// Decompiled with JetBrains decompiler
// Type: PQSDecal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PQSDecal : ScriptableObject
{
  public string DecalID;
  public float HeightScale;
  public PQSDecalHeightBlendMode HeightBlendMode;
  [SerializeField]
  [Range(-1f, 1f)]
  public float HeightOffset;
  public PQSDecalAlphaFadeShape FadeShape;
  [SerializeField]
  [Range(0.0f, 2f)]
  public float FadeStrength;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float AlbedoOpacity;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float NormalOpacity;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float GradientOpacity;
  public Color Tint;
  public PQSDecalBlendMode NormalBlend;
  public int SortOrder;
  public Texture2D HeightTexture;
  public Texture2D AlphaTexture;
  public Texture2D DiffuseTexture;
  public Texture2D NormalTexture;
  public bool UseAlphaMask;
  public bool UseDecalTexturing;
  public bool UseTextureAlphaMask;
  public bool UseTextureHeightmapFade;
  [Range(0.01f, 1.99f)]
  [SerializeField]
  public float MaterialScaleFactor;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSDecal() => throw null;
}
