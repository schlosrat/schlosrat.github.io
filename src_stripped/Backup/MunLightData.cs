// Decompiled with JetBrains decompiler
// Type: MunLightData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class MunLightData : MonoBehaviour
{
  private Light MunLiht;
  public Color MunLightColor;
  public Vector3 MunLightDirection;
  public float MunLightIntensity;
  public LightType MunLightType;
  private CommandBuffer m_cbShadowMap;
  private static MunLightData Singleton;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static MunLightData Instance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MunLightData() => throw null;
}
