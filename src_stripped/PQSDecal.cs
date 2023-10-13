// Decompiled with JetBrains decompiler
// Type: PQSDecal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PQSDecal : ScriptableObject
{
  public string DecalID;
  public float HeightScale;
  public PQSDecalHeightBlendMode HeightBlendMode;
  [Range(-1f, 1f)]
  [SerializeField]
  public float HeightOffset;
  public PQSDecalAlphaFadeShape FadeShape;
  [Range(0.0f, 2f)]
  [SerializeField]
  public float FadeStrength;
  [Range(0.0f, 1f)]
  [SerializeField]
  public float AlbedoOpacity;
  [Range(0.0f, 1f)]
  [SerializeField]
  public float NormalOpacity;
  [Range(0.0f, 1f)]
  [SerializeField]
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
