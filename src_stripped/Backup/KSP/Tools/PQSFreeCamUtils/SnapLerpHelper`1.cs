// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCamUtils.SnapLerpHelper`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Tools.PQSFreeCamUtils
{
  public abstract class SnapLerpHelper<T>
  {
    protected const float FLOAT_COMPARISON_TOLERANCE = 1E-05f;
    private float _lerpFactor;
    private float _timeToSnap;
    private float _snapCountdown;
    private float _curLerp;

    public T TargetValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public T CurValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SnapLerpHelper(T startValue, float lerpFactor, float timeToSnap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(T value, bool snap = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIfDifferentFromTarget(T value, bool snap = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTimeToSnap(float timeToSnap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLerpFactor(float lerpFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Snap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void DoLerp(float lerpFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract bool IsSameAsTargetValue(T value) => throw null;
  }
}
