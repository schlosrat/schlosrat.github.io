// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVPartExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.DeltaV
{
  public static class DeltaVPartExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ContainsPart(this List<DeltaVPartInfo> list, IDeltaVPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DeltaVPartInfo Get(this List<DeltaVPartInfo> list, IDeltaVPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DeltaVPartInfo Get(this List<DeltaVPartInfo> list, IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<IDeltaVPart> PartsInStage(this List<DeltaVPartInfo> list, int stage) => throw null;
  }
}
