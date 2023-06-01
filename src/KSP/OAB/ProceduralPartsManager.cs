// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralPartsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using KSP.UI;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ProceduralPartsManager
  {
    private const string LOG_PREFIX = "ProceduralPartsManager";
    protected ObjectAssemblyBuilderEvents _events;
    protected ObjectAssemblyUIEvents _uiEvents;
    protected bool _isInitialized;
    private bool _selectNewEditableParts;
    private Module_ProceduralPart _editSelection;
    private Module_ProceduralPart _grabbedPart;
    private readonly HashSet<Module_ProceduralPart> _editableProceduralParts;
    private readonly Dictionary<IObjectAssemblyPart, Module_ProceduralPart> _trackedProceduralPartsMap;
    private readonly Dictionary<SymmetrySet, Module_ProceduralPart[]> _trackedProceduralSymmetrySetsMap;
    private IndicatorButton _editButtonPrefab;
    private const string INDICATOR_BUTTON_PREFAB_PATH = "IndicatorButton_EditPart.prefab";
    private Dictionary<Module_ProceduralPart, IndicatorButton> _editButtons;
    private List<IObjectAssemblyPart> _partsNeedingButton;

    public bool SelectNewEditableParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartsManager(
      ObjectAssemblyBuilderEvents events,
      ObjectAssemblyUIEvents uiEvents)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Terminate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartGrabbed(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartDropped(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartDeleted(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostOnPartFinalized(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProceduralPartEditModeChanged(Module_ProceduralPart module, bool editMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleEditableChange(Module_ProceduralPart module, bool editing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEditSelection(Module_ProceduralPart module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IndicatorButton InitializeEditButton(Module_ProceduralPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveEditButton(Module_ProceduralPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEditButtonHide(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEditButton(Module_ProceduralPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnHover(Module_ProceduralPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProceduralPartEditSelectionChanged(Module_ProceduralPart selection) => throw null;
  }
}
