// Decompiled with JetBrains decompiler
// Type: EnvironmentLightingProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class EnvironmentLightingProfile : MonoBehaviour
{
  public Material skybox;
  [Header("Environment Lighting")]
  public AmbientMode ambientMode;
  public Color ambientSkyColor;
  public Color ambientEquatorColor;
  public Color ambientGroundColor;
  public float ambientIntensity;
  [Header("Environment Reflections")]
  public DefaultReflectionMode reflectionMode;
  public Cubemap customReflection;
  public float reflectionIntensity;
  [Header("Deferred Fog")]
  public bool fog;
  public Color fogColor;
  public FogMode fogMode;
  public float fogDensity;
  public float fogStartDistance;
  public float fogEndDistance;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EnvironmentLightingProfile() => throw null;
}
