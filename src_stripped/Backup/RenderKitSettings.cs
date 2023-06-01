// Decompiled with JetBrains decompiler
// Type: RenderKitSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class RenderKitSettings : ScriptableObject
{
  public const string renderKitSettingsPath = "Assets/Data/RenderKit/RenderKitSettings.asset";
  [SerializeField]
  private float _pbrValueMin;
  [SerializeField]
  private float _pbrValueMax;
  [SerializeField]
  private Cubemap _galaxyCubemap;
  [SerializeField]
  private Cubemap _overrideCelestialCubemap;
  [SerializeField]
  private bool _overrideCelestialCubemapToggle;
  [SerializeField]
  private Cubemap _overrideObserverCubemap;
  [SerializeField]
  private bool _overrideObserverCubemapToggle;
  [SerializeField]
  private bool _overrideLightingKeywordsToggle;
  [SerializeField]
  private float _diffuseAmbientIntensity;
  [SerializeField]
  private float _diffuseCubemapIntensity;
  [SerializeField]
  private int _diffuseCubemapMip;
  [SerializeField]
  private float _specularCubemapIntensity;
  [SerializeField]
  private int _mipBiasMaxStep;
  [SerializeField]
  private int _mipBiasGrowthRate;
  [SerializeField]
  private float _mipBiasOffset;

  public float pbrValueMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float pbrValueMax
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Cubemap galaxyCubemap
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetOverrideCelestialCubemap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClearOverrideCelestialCubemap() => throw null;

  public bool overrideCelestialCubemapToggle
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetOverrideObserverCubemap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClearOverrideObserverCubemap() => throw null;

  public bool overrideObserverCubemapToggle
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool overrideLightingKeywordsToggle
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float diffuseAmbientIntensity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float diffuseCubemapIntensity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public int diffuseCubemapMip
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float specularCubemapIntensity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public int mipBiasMaxStep
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public int mipBiasGrowthRate
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float mipBiasOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateShaderValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RenderKitSettings() => throw null;
}
