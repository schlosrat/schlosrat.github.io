// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UniverseTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Logging;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class UniverseTime : IUniverseTime, IUniverseTimeCommandEntry
  {
    private const LogFilter LOGFLAG = LogFilter.Simulation;
    private const string logTag = "[UniverseTime]";
    private const float PHYSICS_TIME_SCALE_MAX = 4f;
    private const float UNIVERSE_TIME_SCALE_MAX = 1E+12f;
    private const float TIME_EQUALITY_EPSILON = 1E-06f;
    public const float DEFAULT_TIME_SCALE = 1f;
    public const bool DEFAULT_SCALE_PHYSICS = false;
    private float _timeScale;
    private bool _scalePhysics;
    private TimeScaleValues? pauseTimeScaleStorage;

    public IUniverseTimeCommandEntry CommandEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MaxPhysicsTimeScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MaxUniverseTimeScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<TimeScaleValues> TimeScaleChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<float> UniverseTimeScaleChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public TimeScaleValues TimeScaleValues
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float PhysicsTimeScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float PhysicsToUniverseMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float UniverseTimeScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<bool> IsTimePausedChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool IsTimePaused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUniverseTimeCommandEntry.SetTimeScale(float timeScale, bool scalePhysics) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    float IUniverseTimeCommandEntry.GetTimeScale() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IUniverseTimeCommandEntry.GetScalePhysics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IUniverseTimeCommandEntry.PopTimePause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IUniverseTimeCommandEntry.PushTimePause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowPauseNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowUnpauseNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUniverseTimeCommandEntry.InvokeTimeScaleChanged(TimeScaleValues timeValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUniverseTimeCommandEntry.InvokeIsTimePauseChanged(bool isTimePaused) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsCloseTo(float a, float b, float epsilon = 1E-06f) => throw null;
  }
}
