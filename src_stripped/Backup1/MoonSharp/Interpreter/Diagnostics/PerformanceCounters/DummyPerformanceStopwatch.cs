// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Diagnostics.PerformanceCounters.DummyPerformanceStopwatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
  internal class DummyPerformanceStopwatch : IPerformanceStopwatch, IDisposable
  {
    public static DummyPerformanceStopwatch Instance;
    private PerformanceResult m_Result;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DummyPerformanceStopwatch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDisposable Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PerformanceResult GetResult() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DummyPerformanceStopwatch() => throw null;
  }
}
