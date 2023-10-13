// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorHeatWarning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class IndicatorHeatWarning : Indicator
  {
    public const string PREFAB_PATH = "Indicator_HeatWarning.prefab";
    [SerializeField]
    private Image _progress;
    [SerializeField]
    private Image _frame;
    [SerializeField]
    private Image _background;
    [SerializeField]
    private RectTransform _sizeRectTrans;
    [Range(0.0f, 1f)]
    [SerializeField]
    private float _startThreshold;
    [SerializeField]
    [Range(0.0f, 1f)]
    private float _criticalThreshold;
    [SerializeField]
    private Color _primaryColorStart;
    [SerializeField]
    private Color _primaryColorCritical;
    [SerializeField]
    private Color _primaryColorPulse;
    [SerializeField]
    private Color _secondaryColorStart;
    [SerializeField]
    private Color _secondaryColorPulse;
    [SerializeField]
    private float _pulseInDuration;
    [SerializeField]
    private float _pulseOutDuration;
    private static bool _isLoadingPrefab;
    private static Dictionary<PartHeatIndicatorTracker, Action<IndicatorHeatWarning>> _pendingRequests;
    private PartHeatIndicatorTracker _partTracker;
    private float _pulseProgress;
    private bool _isPulseIn;
    private bool _isIndicatorShowing;

    public static IndicatorHeatWarning IndicatorPrefab
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RequestIndicatorAsync(
      PartHeatIndicatorTracker partTracker,
      Action<IndicatorHeatWarning> callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RequestIndicator(
      PartHeatIndicatorTracker partTracker,
      Action<IndicatorHeatWarning> callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseIndicator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize(PartHeatIndicatorTracker partTracker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdatePosition(
      Vector3 _,
      RectTransform canvasRectTransform,
      Camera uiCamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePulse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsValueWithin(float value, float minInclusive, float maxExclusive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndicatorHeatWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static IndicatorHeatWarning() => throw null;
  }
}
