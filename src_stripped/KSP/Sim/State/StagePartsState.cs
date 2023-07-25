// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.StagePartsState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct StagePartsState
  {
    [Obsolete("Use PartIds instead")]
    public List<string> partGuids;
    public List<IGGuid> PartIds;
    public int StageID;
    public bool IsActive;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Sanitize(StagePartsState input, out StagePartsState output) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsState ConvertLegacyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsState UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;
  }
}
