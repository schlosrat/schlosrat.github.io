// Decompiled with JetBrains decompiler
// Type: KSP.UI.FlightStagingUIDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class FlightStagingUIDriver : StagingUIDriverBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStagingDataContext_StageMoved(int fromStageIndex, int toStageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStagingDataContext_StageAdded(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStagingDataContext_StageRemoved(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStagingDataContext_PartGroupMoved(
      int fromStageIndex,
      IGGuid partIdToMove,
      int toStageIndex,
      int toPartGroupIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStagingDataContext_PartFolderMoved(
      int fromStageIndex,
      List<IGGuid> partIdsToMove,
      int toStageIndex,
      int toPartGroupIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterBackend(StagingDataProvider stagingProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterBackend() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateStageDeltaV(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EngineModeChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightStagingUIDriver() => throw null;
  }
}
