// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.SimpleTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Utilities
{
  public class SimpleTimer
  {
    private const float MIN_TIME_DURATION_SAFE = 1E-05f;
    private float _timeElapsed;
    private float _timeDuration;
    private bool _isEnabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleTimer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleTimer(float timeDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsCompleted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTimeDuration(float timeDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetTimeElapsed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetTimeElapsedPercentageNormalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetTimeRemainingPercentageNormalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Tick(float deltaTime) => throw null;
  }
}
