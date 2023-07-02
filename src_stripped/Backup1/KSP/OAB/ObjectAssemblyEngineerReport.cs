// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyEngineerReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyEngineerReport
  {
    private EngineeringReportStats stats;
    private EngineeringReportFlawListSetup flawListSetup;
    private List<EngineeringReportFlawItem> checklist;
    private List<EngineeringReportFlawItem> activeConcerns;
    private bool hasInit;

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
    private void OnAssemblyResourceMassRecalculated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeltaVCalculatedMessage(MessageCenterMessage msg) => throw null;
  }
}
