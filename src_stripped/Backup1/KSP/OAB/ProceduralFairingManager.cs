// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralFairingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Modules;
using KSP.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace KSP.OAB
{
  public class ProceduralFairingManager
  {
    private ObjectAssemblyBuilderEvents _events;
    private ObjectAssemblyPartTracker _oabPartTracker;
    private bool _isInitialized;
    private IndicatorButton _editButtonPrefab;
    private IndicatorButton _visibilityButtonPrefab;
    private const string INDICATOR_EDIT_BUTTON_PREFAB_PATH = "IndicatorButton_EditPart.prefab";
    private const string INDICATOR_VISIBILITY_BUTTON_PREFAB_PATH = "IndicatorButton_VisibilityFairing.prefab";
    private const string INDICATOR_EDIT_ID = "EditButton";
    private const string INDICATOR_VISIBILITY_ID = "VisibilityButton";
    private const float VISIBILITY_BUTTON_X_OFFSET = 50f;
    private bool canSaveCurrentFairingChanges;
    private Dictionary<Module_Fairing, FairingIndicatorButtons> _indicatorButtons;
    private Module_Fairing _editSelection;
    private Module_Fairing _grabbedPart;
    private bool _selectNewEditableParts;
    private readonly HashSet<Module_Fairing> _editableProceduralFairings;
    private readonly Dictionary<IObjectAssemblyPart, Module_Fairing> _trackedProceduralFairingsMap;
    private List<Module_Fairing> _partsNeedingEditButton;

    public bool SelectNewEditableParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralFairingManager(
      ObjectAssemblyBuilderEvents events,
      ObjectAssemblyPartTracker tracker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Terminate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnHover(Module_Fairing part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeButtons(Module_Fairing fairingPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IndicatorButton InitializeIndicatorButton(
      string indicatorId,
      IndicatorButton prefab,
      IndicatorData data,
      UnityAction onClickCallback,
      Action<Indicator> onButtonHide)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEditClicked(Module_Fairing fairingPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVisibilityModeClicked(Module_Fairing fairingPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEditButtonHide(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVisibilityButtonHide(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveIndicatorButtons(Module_Fairing fairingPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselSaved(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartDeleted(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostOnPartFinalized(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartGrabbed(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartDropped(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProceduralFairingEditModeChanged(Module_Fairing fairingPart, bool isEditing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleEditableChange(Module_Fairing fairingPart, bool isEditing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEditSelection(Module_Fairing fairingPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitEditMode(bool saveCurrentChanges) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRing() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteCurrentRing() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateScale(float addedRadius, float addedHeight, bool isSnapEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetCurrentFairingLastRingCenterPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetCurrentFairingLastRingRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFairingCollisionEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeRingEvent(bool isRadiusAboveThreshold) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeSectionEvent(bool sectionsAboveMinimum) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFairingCollisionExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleInvalidFairingWarningModal() => throw null;
  }
}
