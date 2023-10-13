// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.StagingState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveInvalidGuids(IEnumerable<PartComponent> parts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PartExists(IEnumerable<PartComponent> parts, IGGuid partId) => throw null;
  }
}
