// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralFairingEditUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ProceduralFairingEditUI : KerbalMonoBehaviour
  {
    private const string EDIT_BUTTONS_KEY = "FairingEditButtons.prefab";
    private const string SCALING_GIZMO_KEY = "FairingScalingGizmo.prefab";
    private EditFairingButtons editButtons;
    private EditFairingGizmo scalingGizmo;
    private ObjectAssemblyBuilder builder;
    private ObjectAssemblyBuilderEvents events;
    private Module_Fairing selectedPart;
    public Shader BaseFairingPanelShader;
    public Shader TransparentFairingPanelShader;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEditableChanged(Module_Fairing fairingPart, bool isEditing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ForceEndEdit(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartDeleted(IObjectAssemblyPart _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartGrabbed(IObjectAssemblyPart _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetButtonsPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 GetAnchoredPosition(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetLastRingEdgePosition(bool left) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSelectedPart(Module_Fairing fairingPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FairingRingChanged(bool isRadiusAboveThreshold) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FairingSectionChanged(bool sectionsAboveMinimum) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralFairingEditUI() => throw null;
  }
}
