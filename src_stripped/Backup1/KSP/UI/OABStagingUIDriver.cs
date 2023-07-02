// Decompiled with JetBrains decompiler
// Type: KSP.UI.OABStagingUIDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class OABStagingUIDriver : StagingUIDriverBase
  {
    private List<IObjectAssemblyPartStageInfo> lastOABReportedState;

    public int TotalStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessChange(List<IObjectAssemblyPartStageInfo> current) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanEmptyStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMainAssemblyChanged(
      IObjectAssembly oldObjectAssembly,
      IObjectAssembly newObjectAssembly)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InformVABOfStagingChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HasID(List<IObjectAssemblyPartStageInfo> info, IGGuid unique) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStageChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOmitStagingMessages(bool omitStagingMsgs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDeltaV() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EngineModeChanged(string guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABStagingUIDriver() => throw null;
  }
}
