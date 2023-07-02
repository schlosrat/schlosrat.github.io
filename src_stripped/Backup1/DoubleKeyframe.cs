// Decompiled with JetBrains decompiler
// Type: DoubleKeyframe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
