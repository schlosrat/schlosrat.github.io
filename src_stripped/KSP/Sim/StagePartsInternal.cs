// Decompiled with JetBrains decompiler
// Type: KSP.Sim.StagePartsInternal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using KSP.Sim.State;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class StagePartsInternal
  {
    public List<IGGuid> PartIds;
    public int ID;
    public bool IsActive;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsInternal(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsInternal(IEnumerable<PartComponent> parts, int id, bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsInternal(IEnumerable<IGGuid> partGuids, int id, bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsState ToState() => throw null;
  }
}
