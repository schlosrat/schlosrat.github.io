// Decompiled with JetBrains decompiler
// Type: KSP.Animation.AnimationManager_Expressions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  public class AnimationManager_Expressions : AnimationManager
  {
    private const float PRE_PANIC_LIMIT = -0.39f;
    private const float STAGE1_PANIC_LIMIT = -0.5f;
    private const float STAGE2_PANIC_LIMIT = -0.85f;
    private const float STAGE3_PANIC_LIMIT = -1f;
    [Header("Public Variables")]
    [FormerlySerializedAs("stupidity")]
    public float AttrStupidity;
    [FormerlySerializedAs("bravery")]
    public float AttrBravery;
    [FormerlySerializedAs("optimism")]
    public float AttrOptimism;
    [SerializeField]
    [Space(10f)]
    [FormerlySerializedAs("expressionParameterName")]
    [Header("Animator Parameter Defines")]
    private string _expressionParamName;
    [FormerlySerializedAs("varianceParameterName")]
    [SerializeField]
    private string _varianceParamName;
    [SerializeField]
    [FormerlySerializedAs("secondaryVarianceParameterName")]
    private string _2ndVarianceParamName;
    [SerializeField]
    private string _gravityParamName;
    [FormerlySerializedAs("wheeLevel")]
    [Space(10f)]
    [Header("Watch Variables")]
    [SerializeField]
    private float _wheeLevel;
    [FormerlySerializedAs("panicLevel")]
    [SerializeField]
    private float _panicLevel;
    [SerializeField]
    [FormerlySerializedAs("expression")]
    protected float _curExpValue;
    [SerializeField]
    [FormerlySerializedAs("varianceUpdateInterval")]
    [Header("General Tunables")]
    [Space(10f)]
    private float _varianceUpdateInterval;
    [SerializeField]
    [FormerlySerializedAs("secondaryVarianceUpdateInterval")]
    private float _2ndVarianceUpdateInterval;
    [FormerlySerializedAs("expressionLerpRate")]
    [SerializeField]
    private float _expLerpRate;
    [SerializeField]
    [FormerlySerializedAs("varianceLerpRate")]
    private float _varianceLerpRate;
    [SerializeField]
    [FormerlySerializedAs("baselineMin")]
    [Space(5f)]
    private float _minEmotionalBaseline;
    [FormerlySerializedAs("baseLineMax")]
    [SerializeField]
    private float _maxEmotionalBaseline;
    [SerializeField]
    [Space(5f)]
    private float _normalizedStupidityThresholdToUnlockFullPanic;
    [SerializeField]
    private float _normalizedBraveryThresholdToPreventPanic;
    [Space(5f)]
    [SerializeField]
    private float _forceIsFunBaseline;
    [SerializeField]
    private float _forceIsFunStupidityMultiplier;
    [SerializeField]
    private float _forceIsFunBraveryMultiplier;
    [Space(5f)]
    [SerializeField]
    private float _wheeLevelBaseline;
    [SerializeField]
    private float _wheeLevelStupidityMultiplier;
    [SerializeField]
    [Space(5f)]
    private float _panicLevelForcesMultiplier;
    [SerializeField]
    private float _panicLevelStupidityMultiplier;
    [SerializeField]
    [Header("IVA Tunables")]
    [Space(10f)]
    private float _gForceMultiplierIVA;
    [SerializeField]
    private float _angularVelocityMultiplierIVA;
    [SerializeField]
    private float _velocityMultiplierIVA;
    [SerializeField]
    [Header("EVA Tunables")]
    [Space(10f)]
    private float _gForceMultiplierEVA;
    [SerializeField]
    private float _angularVelocityMultiplierEVA;
    [SerializeField]
    private float _velocityMultiplierEVA;
    [Range(0.0f, 100f)]
    [Header("DEBUG Variables")]
    [FormerlySerializedAs("debug_angularV")]
    [Space(10f)]
    [SerializeField]
    private float _debugAngularVelocity;
    [FormerlySerializedAs("debug_velocity")]
    [Range(0.0f, 100f)]
    [SerializeField]
    private float _debugVelocity;
    [Range(0.0f, 100f)]
    [SerializeField]
    [FormerlySerializedAs("debug_gee")]
    private float _debugGForce;
    protected float _curVarianceValue;
    protected float _cur2ndVarianceValue;
    protected float _curExpTarget;
    protected float _curVarianceTarget;
    protected float _cur2ndVarianceTarget;
    private bool _isIVAController;
    private int _expressionID;
    private int _varianceID;
    private int _2ndVarianceID;
    private int _gravityID;
    private float _varianceTimer;
    private float _2ndVarianceTimer;
    private float _flightVelocity;
    private float _flightAngularVelocity;
    private float _flightGForce;
    private float _forceIsFunThreshold;
    private float _maxPanic;
    private float _baseline;
    private VesselBehavior _vessel;

    private bool IsVesselValid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitAnimTreeParamIndices() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void IVAUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EVAUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVariance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnimationManager_Expressions() => throw null;
  }
}
