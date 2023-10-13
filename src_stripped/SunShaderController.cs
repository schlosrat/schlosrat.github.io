// Decompiled with JetBrains decompiler
// Type: SunShaderController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (Renderer))]
public class SunShaderController : MonoBehaviour
{
  public bool usePlanetariumTime;
  public float speedFactor;
  public float frequency0;
  public AnimationCurve curve0;
  public float frequency1;
  public AnimationCurve curve1;
  public float frequency2;
  public AnimationCurve curve2;
  public float frequency3;
  public AnimationCurve curve3;
  private Renderer r;
  private float time;
  private float rate0;
  private float rate1;
  private float rate2;
  private float rate3;
  private Texture2D rampMap;
  private static int shaderPropertyOffset0;
  private static int shaderPropertyOffset1;
  private static int shaderPropertyOffset2;
  private static int shaderPropertyOffset3;

  public CelestialBodyBehavior celestialBody
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public IUniverseView universeView
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public IUniverseObserver universeObserver
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [ContextMenu("Update Ramp Map")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateRampMap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SunShaderController() => throw null;
}
