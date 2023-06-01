// Decompiled with JetBrains decompiler
// Type: I2.Loc.TranslationJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public class TranslationJob : IDisposable
  {
    public TranslationJob.eJobState mJobState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TranslationJob.eJobState GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TranslationJob() => throw null;

    public enum eJobState
    {
      Running,
      Succeeded,
      Failed,
    }
  }
}
