// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SymmetrySetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class SymmetrySetData
  {
    public static readonly string CURRENT_VERSION;
    public string Version;
    public SymmetryType SymmetryType;
    public IGGuid Anchor;
    public List<IGGuid> AllParts;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymmetrySetData Clone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymmetrySetData UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymmetrySetData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SymmetrySetData() => throw null;
  }
}
