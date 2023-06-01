// Decompiled with JetBrains decompiler
// Type: DecalInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Unity.Mathematics;
using UnityEngine;

public struct DecalInstance
{
  public Matrix4x4 worldToLocal;
  public Vector3 position;
  public int index;
  public float clipPos;
  public float cullDist;
  public float heightScale;
  public float heightOffset;
  public float blendParams;
  public float fadeStrength;
  public float verticalOffset;
  public int useAlphaMask;
  public int useDecalTexturing;
  public float AlbedoOpacity;
  public float NormalOpacity;
  public int NormalBlend;
  public float GradientOpacity;
  public Vector4 TintColor;
  public int UseTextureAlphaMask;
  public int UseTextureHeightmapFade;
  public float3 DecalUp;
  public float3 DecalForward;
  public float3 DecalRight;
  public float GradientScale;
}
