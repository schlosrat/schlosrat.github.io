// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedKerbalRoster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedKerbalRoster
  {
    public Dictionary<string, SerializedKerbalInfo> Kerbals;
    public Dictionary<string, string> CustomKerbals;
    public Dictionary<string, uint> CustomKerbalRefresh;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedKerbalRoster() => throw null;
  }
}
