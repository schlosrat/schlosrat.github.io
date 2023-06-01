// Decompiled with JetBrains decompiler
// Type: DoubleKeyframe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

public struct DoubleKeyframe : IComparable
{
  public double inTangent;
  public double outTangent;
  public double time;
  public double value;
  public bool autoTangent;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoubleKeyframe(double time, double value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoubleKeyframe(double time, double value, double inTangent, double outTangent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  int IComparable.CompareTo(object obj) => throw null;
}
