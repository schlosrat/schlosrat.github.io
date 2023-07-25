// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SymmetrySetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
