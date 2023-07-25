// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.TimeWarp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class TimeWarp : IFixedUpdate, IPriorityOverride
  {
    private readonly GameInstance _game;
    private readonly UniverseTime _universeTime;
    public const int NO_TIME_WARP_INDEX = 0;
    public const int MAX_PHYSICS_WARP_RATE_INDEX = 2;
    public const float DEFAULT_MAX_WARP_TO = 10f;
    public const float DEFAULT_MIN_WARP_TO = 1f;
    private bool _includeInterstellarRates;
    private const int INTERSTELLAR_RATES_TO_BLOCK = 1;
    private float _lerpStartTime;
    private bool _isAutoWarpEngaged;
    private bool _isWarping;
    private float _targetRate;
    private float _prevRate;
    private float _currentRate;
    private bool _isPhysicsWarp;
    private bool _isChangingRate;
    private int _currentRateIndex;
    private bool _isPaused;
    private double _autoWarpTargetUniversalTime;
    private int _autoWarpTargetRateIndex;
    private bool _autoWarpEnding;

    private int _maxWarpRateIdx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<int> RateIndexChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<float> RateChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<bool> PauseStateChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool IsAutoWarpEngaged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeWarp.TimeWarpLevel[] GetWarpRates() => throw null;

    public float CurrentRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int CurrentRateIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsWarping
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsPhysicsTimeWarp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeWarp(GameInstance game, UniverseTime universeTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTimeWarpIncrease() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTimeWarpDecrease() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTimeWarpStop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRate(int rateIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IncreaseTimeWarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DecreaseTimeWarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopTimeWarp(bool instant = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetRateIndex(int rateIndex, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsPaused(bool isPaused) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WarpTo(double targetUniversalTime, float minTimeWarpRate = 1f, float maxTimeWarpRate = 10f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CancelAutoWarp() => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IFixedUpdate.OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRateIndexNoBoundsCheck(int rateIndex, bool isPhysicsWarp, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateRate(float rate, bool scalePhysics) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetMaxRateIndex(bool includeInterstellar, out bool isPhysicsTimeWarp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoWarpTo(double targetUniversalTime, int targetRateIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetMaxOnRailsRateIdx(int tgtRateIdx, bool lookAhead, out ClearToSaveStatus reason) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ClampRateToOrbitTransitions(
      int rate,
      IPatchedOrbit obt,
      int maxAllowedRateDuringOrbitalEvents)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetMaxWarpRateForTravel(
      double warpDeltaTime,
      double minTimeInWarp,
      double maxTimeInWarp,
      out int rateIdx)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetAccelerationTime(
      double initialWarpFactor,
      double targetWarpFactor,
      double lerpSpeed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double GetWarpRateAcceleration(
      double startSpeed,
      double targetSpeed,
      double lerpTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsPatchSlowdownTransitionType(PatchTransitionType patchTransitionType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetOrbitalEventLookaheadTimeSeconds(PatchTransitionType patchTransitionType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopTimeWarpByGameState(GameState[] statesToCauseStop, bool instant = false) => throw null;

    public readonly struct TimeWarpLevel
    {
      public readonly float TimeScaleFactor;
      public readonly float AdditionalAltitudeRequirement;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TimeWarpLevel(float timeScaleFactor, float additionalAltitudeRequirement) => throw null;
    }
  }
}
