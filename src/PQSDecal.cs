// Decompiled with JetBrains decompiler
// Type: PQSDecal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
  [SerializeField]
  [Range(0.01f, 1.99f)]
  public float MaterialScaleFactor;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSDecal() => throw null;
}
