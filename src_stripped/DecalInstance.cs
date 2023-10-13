// Decompiled with JetBrains decompiler
// Type: DecalInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
