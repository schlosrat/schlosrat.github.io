// Decompiled with JetBrains decompiler
// Type: DoubleCurve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DoubleCurve
{
  public List<DoubleKeyframe> keys;
  public double minTime;
  public double maxTime;
  private static char[] delimiters;
  private static int findCurveMinMaxInterations;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoubleCurve() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoubleCurve(DoubleKeyframe[] keyframes) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoubleCurve(List<DoubleKeyframe> keyframes) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected int GetInsertionIndex(double time) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(double time, double value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(double time, double value, double inTangent, double outTangent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public double Evaluate(double t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RecomputeTangents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FindMinMaxValue(out double min, out double max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FindMinMaxValue(out double min, out double max, out double tMin, out double tMax) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static DoubleCurve() => throw null;
}
