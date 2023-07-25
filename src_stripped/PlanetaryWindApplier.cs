// Decompiled with JetBrains decompiler
// Type: PlanetaryWindApplier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PlanetaryWindApplier : MonoBehaviour
{
  [SerializeField]
  [Space(5f)]
  [Header("PRIMARY WIND CONTROLS")]
  private bool ManualWindMode;
  private bool lastManualMode;
  [Space(15f)]
  [Range(0.0f, 1f)]
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
  [SerializeField]
  [Range(0.0f, 1f)]
  [Space(10f)]
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
