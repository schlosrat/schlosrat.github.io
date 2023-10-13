// Decompiled with JetBrains decompiler
// Type: ApplyCubemaps
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class ApplyCubemaps : MonoBehaviour
{
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
  [SerializeField]
  private Texture _observerCubemap;
  [SerializeField]
  private Texture _galaxyCubemap;
  [SerializeField]
  private bool _useObserverCubemap;
  [SerializeField]
  private bool _useGalaxyCubemap;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateCubemaps() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetActiveObserverCubemapKeyword(bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetActiveGalaxyCubemapKeyword(bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ApplyCubemaps() => throw null;
}
