// Decompiled with JetBrains decompiler
// Type: KSP.AsyncSearchSortFilter.AbstractOperationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Threading;

namespace KSP.AsyncSearchSortFilter
{
  public abstract class AbstractOperationData
  {
    public bool complete;
    public Thread thread;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void RunOperation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void MakeCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TerminateThread() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartThread() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected AbstractOperationData() => throw null;
  }
}
