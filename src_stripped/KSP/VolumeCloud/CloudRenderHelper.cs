// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.CloudRenderHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.VolumeCloud
{
  public class CloudRenderHelper : MonoBehaviour
  {
    [SerializeField]
    public AssetReferenceT<VolumeCloudConfiguration> HighQualityCloudConfiguration;
    [SerializeField]
    public AssetReferenceT<VolumeCloudConfiguration> MediumQualityCloudConfiguration;
    [SerializeField]
    public AssetReferenceT<VolumeCloudConfiguration> LowQualityCloudConfiguration;
    private VolumeCloudConfiguration CurrentConfig;
    [SerializeField]
    private CloudRenderHelper.QualitySelection QualitySetting;
    private CloudRenderHelper.QualitySelection CurrentQualitySetting;
    public Action<VolumeCloudConfiguration> OnConfigFileChanged;
    [SerializeField]
    public bool UseSGTLight;
    [SerializeField]
    public bool AutoGetLight;
    [HideInInspector]
    public List<Light> DirectionalLightList;
    [SerializeField]
    public Light MainLight;
    [SerializeField]
    public Light SecondLight;
    private bool isSetLight;
    private bool hasStarted;
    private List<CloudLightManager.LightInfo> LightInfoList;

    public string CelestialBodyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public VolumeCloudConfiguration CloudConfiguration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssetReferenceT<VolumeCloudConfiguration> GetCloudConfigurationByQuality(
      CloudRenderHelper.QualitySelection QualitySetting)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBodyName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadingConfigCompleted(
      AsyncOperationHandle<VolumeCloudConfiguration> handle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetQualityLevel(int level, bool forceSet = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddLight(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLight(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetLightsCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateLightInfoList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CreateLightListManually() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CreateLightListAutomatically() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CloudLightManager.LightInfo GetLightInfo(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSetLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FinishSetLight(bool finished) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CloudRenderHelper() => throw null;

    public enum QualitySelection
    {
      Low,
      Medium,
      High,
    }
  }
}
