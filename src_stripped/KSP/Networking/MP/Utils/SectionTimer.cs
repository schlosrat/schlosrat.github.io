// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.SectionTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class SectionTimer : IDisposable
  {
    public const long DEFAULT_TIME_STAMP = 0;
    public const long DEFAULT_ELAPSED_TIME_IN_MS = -1;
    private long _timeStamp;
    private long _elapsedTimeInMS;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SectionTimer(bool start = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~SectionTimer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool start = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SectionTimer Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public long Stop() => throw null;

    public bool IsRunning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    public long ElapsedTimeInMS
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ElapsedTimeInMSString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
