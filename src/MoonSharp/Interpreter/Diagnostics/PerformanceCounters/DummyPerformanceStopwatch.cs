// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Diagnostics.PerformanceCounters.DummyPerformanceStopwatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
