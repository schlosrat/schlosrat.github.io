// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyEngineerReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyEngineerReport
  {
    private EngineeringReportStats stats;
    private EngineeringReportFlawListSetup flawListSetup;
    private List<EngineeringReportFlawItem> checklist;
    private List<EngineeringReportFlawItem> activeConcerns;
    private bool hasInit;
    private EngineeringReportFlawListCheckConfig _flawListCheckConfig;

    public event Action OnUpdateNeeded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyEngineerReport(
      ObjectAssemblyBuilderEvents eventsBuilder,
      EngineeringReportFlawListSetup flawListSetup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown(ObjectAssemblyBuilderEvents eventsBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineeringReportStats GetCurrentStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<EngineeringReportFlawItem> GetActiveConcerns() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetCriticalConcernLocTerms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetPartsRequiringHeatShieldCheck() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateReport(OABSessionInformation stats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize(ObjectAssemblyBuilderEvents eventsBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterOABMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregistedOABMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterOABEvents(ObjectAssemblyBuilderEvents eventsBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterOABEvents(ObjectAssemblyBuilderEvents eventsBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendNeedsUpdateEvent(object _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendNeedsUpdateEvent(OABActionType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendNeedsUpdateEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStats(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateActiveConcerns(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildChecklist() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildFlawListCheckData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBuildFlawListCheckDataLoaded(TextAsset flawListCheckData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAssemblyResourceMassRecalculated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeltaVCalculatedMessage(MessageCenterMessage msg) => throw null;
  }
}
