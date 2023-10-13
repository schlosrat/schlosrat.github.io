// Decompiled with JetBrains decompiler
// Type: PlanetaryWindApplier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PlanetaryWindApplier : MonoBehaviour
{
  [Header("PRIMARY WIND CONTROLS")]
  [SerializeField]
  [Space(5f)]
  private bool ManualWindMode;
  private bool lastManualMode;
  [Range(0.0f, 1f)]
  [Space(15f)]
  [SerializeField]
  private float windGlobalMul;
  [SerializeField]
  [Space(10f)]
  [Range(0.0f, 10f)]
  private float windSpeed;
  [SerializeField]
  private float windSpeedDelayMin;
  [SerializeField]
  private float windSpeedDelayMax;
  private int windSpeedParamID;
  [Range(0.0f, 1f)]
  [Space(10f)]
  [SerializeField]
  private float windScale;
  [SerializeField]
  private float windScaleDelayMin;
  [SerializeField]
  private float windScaleDelayMax;
  private int windScaleParamID;
  private Animator WindEffectedAnimator;
  private bool userJustChangedModes;
  private float animTransitionTime;
  private float windSpeedDelay;
  private float windScaleDelay;
  private float windSpeedStartTime;
  private float windScaleStartTime;
  private float windSpeedMin;
  private float windSpeedMax;
  private float windScaleMin;
  private float windScaleMax;
  private int WindVolatilityCategory;
  private int defaultWindCategory;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateWindParameters() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetWindUpdateConstants(int windCategory) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CalcPlanetaryWindVolatility(double pressure, double temp) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PlanetaryWindApplier() => throw null;
}
