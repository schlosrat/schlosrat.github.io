// Decompiled with JetBrains decompiler
// Type: DecalInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
