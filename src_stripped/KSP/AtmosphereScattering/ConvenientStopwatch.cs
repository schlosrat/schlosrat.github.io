// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.ConvenientStopwatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
