// Decompiled with JetBrains decompiler
// Type: ApplyGIProbe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class ApplyGIProbe : MonoBehaviour
{
  public bool enableCache;
  public Color ambientColor;
  public Color directionalColor;
  public Vector3 direction;
  public float directionIntensity;
  private Renderer _renderer;
  private MaterialPropertyBlock _propBlock;
  private SphericalHarmonicsL2 _shCache;
  private List<SphericalHarmonicsL2> _shCacheList;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ApplyGIProbe() => throw null;
}
