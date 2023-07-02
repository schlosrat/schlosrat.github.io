// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VesselActionGroups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class VesselActionGroups : ObjectActionGroups
  {
    private VesselComponent _vessel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselActionGroups(VesselComponent v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override IEnumerable<object> GetListOfParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SendActionGroupsChangedMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerActionGroup(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionGroupState(KSPActionGroup group, bool newState) => throw null;
  }
}
