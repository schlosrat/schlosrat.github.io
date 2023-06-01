// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.ConvenientStopwatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.AtmosphereScattering
{
  public class ConvenientStopwatch : IDisposable
  {
    private Action<string> Log;
    private DateTime start;
    private string name;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConvenientStopwatch(string name, Action<string> Log = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
