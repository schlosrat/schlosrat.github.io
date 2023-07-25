// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Diagnostics.PerformanceStatistics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Diagnostics.PerformanceCounters;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Diagnostics
{
  public class PerformanceStatistics
  {
    private IPerformanceStopwatch[] m_Stopwatches;
    private static IPerformanceStopwatch[] m_GlobalStopwatches;
    private bool m_Enabled;

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PerformanceResult GetPerformanceCounterResult(PerformanceCounter pc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal IDisposable StartStopwatch(PerformanceCounter pc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IDisposable StartGlobalStopwatch(PerformanceCounter pc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetPerformanceLog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PerformanceStatistics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PerformanceStatistics() => throw null;
  }
}
