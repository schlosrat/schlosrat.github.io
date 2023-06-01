// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.StagePartsState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
