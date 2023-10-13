// Decompiled with JetBrains decompiler
// Type: ApplyGIProbe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
