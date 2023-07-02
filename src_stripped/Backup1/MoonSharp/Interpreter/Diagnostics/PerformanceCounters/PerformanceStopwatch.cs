// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Diagnostics.PerformanceCounters.PerformanceStopwatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
  internal class PerformanceStopwatch : IDisposable, IPerformanceStopwatch
  {
    private Stopwatch m_Stopwatch;
    private int m_Count;
    private int m_Reentrant;
    private MoonSharp.Interpreter.Diagnostics.PerformanceCounter m_Counter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PerformanceStopwatch(MoonSharp.Interpreter.Diagnostics.PerformanceCounter perfcounter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDisposable Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PerformanceResult GetResult() => throw null;
  }
}
