// Decompiled with JetBrains decompiler
// Type: ScaledCloudConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
[Serializable]
public class ScaledCloudConfiguration : ScriptableObject
{
  [SerializeField]
  public List<ScaledCloudConfiguration.scaledCloudMaterialData> scaledCloudLayers;
  [SerializeField]
  [Range(0.0f, 5f)]
  public float brightness;
  [NonSerialized]
  public Cubemap cloudsNormalTexture;
  [Range(0.0f, 4f)]
  [NonSerialized]
  public float diffuseFactor;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float ambientIntensity;
  [Range(0.0f, 10f)]
  [NonSerialized]
  public float ambientFalloff;
  [Range(-1f, 1f)]
  [NonSerialized]
  public float sunsetStart;
  [Range(-1f, 1f)]
  [NonSerialized]
  public float sunsetEnd;
  [NonSerialized]
  public Color sunsetColor;
  [SerializeField]
  public bool enableAtmosphere;
  [Range(0.0f, 2f)]
  public float atmosphereIntensity;
  [Range(0.0f, 2f)]
  public float atmosphereDistanceFalloff;
  public bool UseScaleCloudsOnly;
  public float ShadowDensity;
  public float ShadowOpacity;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void BindToMaterial(ref Material mat) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ScaledCloudConfiguration() => throw null;

  private class PropertyHash
  {
    public static int UseScaleCloudsOnly;
    public static int AtmosphereActive;
    public static int Brightness;
    public static int EnableAtmosphereScaled;
    public static int AtmosphereIntensityScaled;
    public static int AtmosphereFalloffScaled;
    public static int SunsetStartScaled;
    public static int SunsetEndScaled;
    public static int AmbientIntensity;
    public static int AmbientFalloff;
    public static int ShadowDensity;
    public static int ShadowOpacity;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyHash() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PropertyHash() => throw null;
  }

  [Serializable]
  public class scaledCloudMaterialData
  {
    public string CloudLayerName;
    public bool IsEnable;
    public float Radius;
    public Cubemap CloudsTexture;
    public Cubemap CloudsNormalTexture;
    public float NormalFactor;
    public Quaternion Rotation;
    public bool EnableWind;
    public Vector3 WindDirection;
    public float MovmentSpeed;
    public bool EnableColorTexture;
    public float CloudColorIntensity;
    public Cubemap CloudColorTexture;
    public Texture3D CloudDetailTexture;
    public float CloudDetailTile;
    public float CloudDetailStrenth;
    public Color ScaleCloudColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public scaledCloudMaterialData() => throw null;
  }
}
