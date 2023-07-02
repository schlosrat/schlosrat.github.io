// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyCompoundPartTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Modules;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyCompoundPartTool : ObjectAssemblyPlacementTool
  {
    private List<ObjectAssemblyCompoundPartTool.CompoundPartPair> _compoundPartPairs;
    private int _compoundPartPairAnchorIndex;
    private ObjectAssemblyCompoundPartTool.CompoundToolState _currentState;
    private IObjectAssemblyAvailablePart _compoundPart;
    private ObjectAssemblyAssets _assemblyAssets;
    private List<IObjectAssemblyRelationship> _relationships;
    private bool _secondPartValidPlacement;
    private const int RAYCAST_ARRAY_COUNT = 10;
    private Collider[] _sphereHits;
    private RaycastHit[] _hitInfo;
    private int _layerMask;
    private const float SPHERE_CAST_RANGE = 1f;
    private const float RAYCAST_EXTRA_RANGE = 0.5f;
    public Action OnFinished;
    public PartRelationshipType ToolMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyCompoundPartTool(
      ObjectAssemblyBuilderEvents eventSystemToUse,
      ObjectAssemblyUIEvents uiEventsToUse,
      ObjectAssemblyInputHandler inputToUse,
      ObjectAssemblyPartTracker partTrackerToUse,
      OABSessionInformation stats,
      ObjectAssemblyCameraManager cameraManagerToUse,
      IObjectAssemblyAvailablePart availablePart,
      ObjectAssemblyAssets oabAssets,
      List<IObjectAssemblyRelationship> relationships,
      PartRelationshipType toolMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyCompoundPartTool(
      ObjectAssemblyBuilderEvents eventSystemToUse,
      ObjectAssemblyUIEvents uiEventsToUse,
      ObjectAssemblyInputHandler inputToUse,
      ObjectAssemblyPartTracker partTrackerToUse,
      OABSessionInformation stats,
      ObjectAssemblyCameraManager cameraManagerToUse,
      IObjectAssemblyPart heldPart,
      ObjectAssemblyAssets oabAssets,
      List<IObjectAssemblyRelationship> relationships,
      PartRelationshipType toolMode,
      bool reCreateSavedEnd)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecreatingEnd(IObjectAssemblyPart heldPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPart RecreateAnchorEnd(IObjectAssemblyPart heldPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RepositioningEnd(IObjectAssemblyPart heldPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool FindOtherPart(Module_CompoundPart module, out IObjectAssemblyPart otherPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPlacingPart(bool isAttachedToSomethingElse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleSymmetryConnectorObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearSymmetryConnectorObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HighlightPartAndSymmetryParts(int outlineType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateState(IObjectAssemblyPart latestInteraction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetToolState(bool deleteConnector = false, IObjectAssemblyPart partToDelete = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateLinkerObjectOAB(
      IObjectAssemblyPart firstPart,
      IObjectAssemblyPart secondPart,
      Module_CompoundPart firstModule,
      Module_CompoundPart secondModule,
      ObjectAssemblyBuilderEvents events,
      ObjectAssemblyAssets assemblyAssets,
      ref StackObjectsBetweenTwoPoints connectorObject)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateLinkerObjectFlight(
      PartBehavior firstPart,
      PartBehavior secondPart,
      Module_CompoundPart firstModule,
      Module_CompoundPart secondModule,
      ref StackObjectsBetweenTwoPoints connectorObject)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulatePartModuleReferences(IObjectAssemblyPart heldPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryFindCompoundPartPair(
      IObjectAssemblyPart heldPart,
      out ObjectAssemblyCompoundPartTool.CompoundPartPair compoundPartPair)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RelationshipsContains(
      IObjectAssemblyPart firstPart,
      IObjectAssemblyPart secondPart,
      out int index)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveInvalidRelationships() => throw null;

    private enum CompoundToolState
    {
      WaitingForFirst,
      WaitingForSecond,
      MovingAnchor,
    }

    public class CompoundPartPair
    {
      private IObjectAssemblyPart _firstPart;
      private IObjectAssemblyPart _secondPart;
      private Module_CompoundPart _firstModule;
      private Module_CompoundPart _secondModule;
      private StackObjectsBetweenTwoPoints _connectorObject;

      public IObjectAssemblyPart FirstPart
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IObjectAssemblyPart SecondPart
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Module_CompoundPart FirstModule
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Module_CompoundPart SecondModule
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public StackObjectsBetweenTwoPoints ConnectorObject
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public bool IsValid
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CompoundPartPair(IObjectAssemblyPart firstPart) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetFirstPart(IObjectAssemblyPart firstPart) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetSecondPart(IObjectAssemblyPart secondPart) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SetPartReferences() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetConnector(StackObjectsBetweenTwoPoints connectorObject) => throw null;
    }
  }
}
