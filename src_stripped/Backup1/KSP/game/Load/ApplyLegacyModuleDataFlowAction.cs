// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.ApplyLegacyModuleDataFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Load
{
  internal class ApplyLegacyModuleDataFlowAction : SaveLoadGameFlowActionBase
  {
    private double _timeOut;
    private double _timeWaitStarted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ApplyLegacyModuleDataFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Coroutine ApplyVesselLegacyData(
      string vesselGuid,
      List<SerializedPart> serParts,
      ApplyLegacyModuleDataFlowAction.LegacyDataCoroutine tracker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator ApplyVesselLegacyDataCoroutine(
      string vesselGuid,
      List<SerializedPart> serParts,
      ApplyLegacyModuleDataFlowAction.LegacyDataCoroutine tracker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FromSerializedLegacyModuleData(
      IPartModule comp,
      SerializedLegacyModuleData moduleData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator TrackVesselDataApplication(
      List<ApplyLegacyModuleDataFlowAction.LegacyDataCoroutine> vessels,
      Action resolve)
    {
      throw null;
    }

    private class LegacyDataCoroutine
    {
      public Coroutine Routine;
      public bool IsFinished;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LegacyDataCoroutine() => throw null;
    }
  }
}
