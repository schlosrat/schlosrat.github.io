// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyToolbar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyToolbar : KerbalMonoBehaviour
  {
    private ObjectAssemblyBuilderEvents builderEvents;
    private ObjectAssemblyUIEvents uiEvents;
    private ObjectAssemblyBuilder OAB;
    public ContextBindRoot bindRoot;
    private DataContext context;
    private bool toggleOABOrientation;
    private PropertyExternal<bool> toggleOABOrientationProp;
    private bool toggleOABSnap;
    private PropertyExternal<bool> toggleOABSnapProp;
    private bool centerOfDragOn;
    private PropertyExternal<bool> toggleCenterOfDragProp;
    private bool centerOfThrustOn;
    private PropertyExternal<bool> toggleCenterOfThrustProp;
    private bool centerOfMassOn;
    private PropertyExternal<bool> toggleCenterOfMassProp;
    private bool centerOfRadiationOn;
    private PropertyExternal<bool> toggleCenterOfRadiationProp;
    [Space(5f)]
    [Header("Symmetry Mode UI")]
    public MultiClickButton symmetryModeButton;
    public CanvasGroup symmetryModeFlyout;
    [Header("Alignment Mode UI")]
    [Space(5f)]
    public ToggleExtended alignmentModeToggle;
    public CanvasGroup alignmentModeFlyoutCanvas;
    [Space(5f)]
    public ObjectAssemblyCoMMarker CoMMarker;
    public ObjectAssemblyCoPMarker CoPMarker;
    public ObjectAssemblyCoTMarker CoTMarker;
    private OABToolType currentTool;
    private PropertyExternal<OABToolType> currentToolProp;
    private bool justHold;
    private ObjectAssemblyBuilderTooltipDisplay symmetryModeButtonTooltipDisplay;
    private ObjectAssemblyBuilderTooltipDisplay alignmentModeButtonTooltipDisplay;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder currentBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void setSymmetryMirrorModeperformed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TransformFound(Transform _transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleAngleSnap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleOABSnapProp_OnChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NextSymmetryMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreviousSymmetryMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSymmetryModeFlyoutEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSymmetryModeFlyoutEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAlignmentModeFlyoutEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WasSymmetryFlyoutButtonClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSymmetryModeOnClick(int modeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSymmetryModeOnClick(BuilderSymmetryMode modeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOABLocalFrame(bool isLocalFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateToolToggles(IObjectAssemblyTool tool) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleOABOrientationProp_OnChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleCenterOfDrag_OnChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleCenterOfThrust_OnChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleCenterOfMass_OnChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleCenterOfRadiation_OnChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOABOrientationMode(OABOrientation mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetManipulationMode(ManipulationMode newMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSymmetryToolByEnum(BuilderSymmetryMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateToolByNumber(int number) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onUndo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onRedo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetColorManagerVisible(bool isVisible, bool revertTool = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CurrentToolProp_OnChangedValue(OABToolType obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManipulationMode_OnChangedValue(ManipulationMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnbindInputs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyToolbar() => throw null;
  }
}
