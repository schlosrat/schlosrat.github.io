// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVPartExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
