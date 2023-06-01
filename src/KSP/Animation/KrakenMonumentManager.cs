// Decompiled with JetBrains decompiler
// Type: KSP.Animation.KrakenMonumentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class KrakenMonumentManager : KerbalMonoBehaviour, ILateUpdate
  {
    [SerializeField]
    private double ViewDistance;
    [Tooltip("In Degrees Per Second")]
    [Space(10f)]
    [SerializeField]
    private float LookSpeed;
    [SerializeField]
    private float EyeRotationOffsetLimit;
    [SerializeField]
    private Transform LeftEye;
    [SerializeField]
    private Transform _LeftEyeDefaultState;
    [SerializeField]
    private Transform RightEye;
    [SerializeField]
    private Transform _RightEyeDefaultState;
    [Space(10f)]
    [SerializeField]
    private int MaxPartCountBeforeShakingStarts;
    [SerializeField]
    private int MaximumShakePartCount;
    [SerializeField]
    private float MaximumShakeAngleAmount;
    [Space(25f)]
    [SerializeField]
    private bool _debugMode;
    [SerializeField]
    private Transform _debugTargetVessel;
    [SerializeField]
    [Range(0.0f, 1000f)]
    private int _debugPartCount;
    private bool _isActive;
    private int _targetVesselPartCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<VesselBehavior> CollectVesselsInRange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AimEyesAtTargetOverTime(Transform target, int partCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLimitedEyeRotationOverTime(
      Transform eye,
      float rotLimit,
      Transform target,
      Transform defaultTransformState,
      int partCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetEyePositionsOverTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KrakenMonumentManager() => throw null;
  }
}
