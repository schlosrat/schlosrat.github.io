// Decompiled with JetBrains decompiler
// Type: KSP.Animation.AnimationManager_Expressions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Space(10f)]
    [Header("Animator Parameter Defines")]
    [FormerlySerializedAs("expressionParameterName")]
    [SerializeField]
    private string _expressionParamName;
    [SerializeField]
    [FormerlySerializedAs("varianceParameterName")]
    private string _varianceParamName;
    [SerializeField]
    [FormerlySerializedAs("secondaryVarianceParameterName")]
    private string _2ndVarianceParamName;
    [SerializeField]
    private string _gravityParamName;
    [SerializeField]
    [Space(10f)]
    [FormerlySerializedAs("wheeLevel")]
    [Header("Watch Variables")]
    private float _wheeLevel;
    [FormerlySerializedAs("panicLevel")]
    [SerializeField]
    private float _panicLevel;
    [SerializeField]
    [FormerlySerializedAs("expression")]
    protected float _curExpValue;
    [Header("General Tunables")]
    [Space(10f)]
    [SerializeField]
    [FormerlySerializedAs("varianceUpdateInterval")]
    private float _varianceUpdateInterval;
    [SerializeField]
    [FormerlySerializedAs("secondaryVarianceUpdateInterval")]
    private float _2ndVarianceUpdateInterval;
    [SerializeField]
    [FormerlySerializedAs("expressionLerpRate")]
    private float _expLerpRate;
    [FormerlySerializedAs("varianceLerpRate")]
    [SerializeField]
    private float _varianceLerpRate;
    [FormerlySerializedAs("baselineMin")]
    [SerializeField]
    [Space(5f)]
    private float _minEmotionalBaseline;
    [SerializeField]
    [FormerlySerializedAs("baseLineMax")]
    private float _maxEmotionalBaseline;
    [Space(5f)]
    [SerializeField]
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
    [Space(5f)]
    [SerializeField]
    private float _panicLevelForcesMultiplier;
    [SerializeField]
    private float _panicLevelStupidityMultiplier;
    [Space(10f)]
    [Header("IVA Tunables")]
    [SerializeField]
    private float _gForceMultiplierIVA;
    [SerializeField]
    private float _angularVelocityMultiplierIVA;
    [SerializeField]
    private float _velocityMultiplierIVA;
    [SerializeField]
    [Space(10f)]
    [Header("EVA Tunables")]
    private float _gForceMultiplierEVA;
    [SerializeField]
    private float _angularVelocityMultiplierEVA;
    [SerializeField]
    private float _velocityMultiplierEVA;
    [Space(10f)]
    [Header("DEBUG Variables")]
    [FormerlySerializedAs("debug_angularV")]
    [SerializeField]
    [Range(0.0f, 100f)]
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
