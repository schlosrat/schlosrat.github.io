// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.StagingState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct StagingState
  {
    public List<StagePartsState> availableStages;
    public StagePartsState? unassignedParts;
    public int totalStageCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Sanitize(StagingState input, out StagingState output) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingState ConvertLegacyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingState UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;
  }
}
