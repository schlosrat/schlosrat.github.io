// Decompiled with JetBrains decompiler
// Type: SunLightData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class SunLightData : MonoBehaviour
{
  private Light SunLiht;
  public Color SunLightColor;
  public Vector3 SunLightDirection;
  public float SunLightIntensity;
  public LightType SunLightType;
  private CommandBuffer m_cbShadowMap;
  private static SunLightData Singleton;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static SunLightData Instance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SunLightData() => throw null;
}
