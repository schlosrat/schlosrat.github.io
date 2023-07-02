// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABSessionInformation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class OABSessionInformation
  {
    private const uint MAX_LAST_PARTS_PLACED_COUNT = 5;
    private ObjectyAssemblyBuilderHistorian historian;
    private ObjectAssemblyEngineerReport engineerReport;
    private ObjectAssemblyBuilderEvents events;
    private ObjectAssemblyUIEvents eventsUI;
    private ObjectAssemblyBuilder builder;
    private ObjectAssemblyBehaviorValues behaviorValues;
    private EngineeringReportFlawListSetup flawListSetup;
    public Property<string> CurrentWorkspaceDisplayName;
    public Property<string> CurrentWorkspaceLocalizationNameKey;
    public Property<string> CurrentWorkspaceVehicleDisplayName;
    public Property<string> CurrentWorkspaceDescription;
    private SubscriptionHandle _handlePartStageChangedMessage;
    public string PartToLookFor;
    private int _partActivationStage;
    private OABOrientation _oabOrientation;
    private IObjectAssembly mainAssembly;

    public event Action OnEngineersReportUpdateNeeded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<BuilderSymmetryMode> SymmetryMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<KSP.OAB.ManipulationMode> ManipulationMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasMainAssembly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string GetCurrentWorkspaceName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string GetCurrentWorkspaceVehicleDisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string GetCurrentWorkspaceDescription
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABSessionInformation(
      ObjectAssemblyBuilder builder,
      ObjectAssemblyBehaviorValues behaviorValues,
      EngineeringReportFlawListSetup flawListSetup)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddLastPlacedPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLastPlacedPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyBehavioralValues(ObjectAssemblyBehaviorValues newValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEventsUIOnLanguageChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendEngineerReportUpdateNeeded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SymmetryMode_OnChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManipulationMode_OnChanged() => throw null;

    public ObjectAssemblyBehaviorValues BehavioralValues
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ShipInformation ShipInformation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GameObject OABRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<IObjectAssemblyAvailablePart> AllKnownParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<IObjectAssemblyAvailablePart> AvailableParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssembly GrabbedAssembly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyHUD OABActiveHUD
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<IObjectAssemblyPartStageInfo> StageInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsSnapEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsLocalFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart LastPartPlaced
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<IObjectAssemblyPart> LastPartsPlaced
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart LastPartGrabbed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart LastPartDeleted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartCategories CurrentCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyBuilderSizeLimits SizeLimits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABOrientation OABOrientation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssembly MainAssembly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateEngineersReport() => throw null;

    public ObjectAssemblyBuilder CurrentBuilder
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public EngineeringReportStats CurrentStats
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<EngineeringReportFlawItem> UnaddressedConcerns
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<string> CriticalConcernLocTerms
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyCollection<OABHistoricalSnapshot> CurrentHistoryState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int CurrentHistoryIndexOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABEnvironmentType EnvironmentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string CelestialBodyDependencyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABVariant ActiveVariant
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABConstructionType ConstructionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInBlueprintMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform highlightAttachPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPartStageChangedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPartStageActivation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateShipInformation() => throw null;
  }
}
