// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Kerbal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Game;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.VFX;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Kerbal : PartBehaviourModule
  {
    [Tooltip("AnimationManager_EVA instance to manage communication with the Animation Tree.")]
    public AnimationManager_EVA EVAAnimationManager;
    [Tooltip("JetpackVFXManager instance to manage Jetpack VFX.")]
    public JetpackVFXManager EVAJetpackVFXManager;
    [Tooltip("name of transform to parent the jetpack vfx to, once the 3d kerbal has been loaded and this transform would exist.")]
    public string EVAJetpackVFXParentName;
    [Tooltip("name of transform to mark the location of the left foot for VFX and decals.")]
    public string LeftFootVFXTransformName;
    [Tooltip("name of transform to mark the location of the right foot for VFX and decals.")]
    public string RightFootVFXTransformName;
    [Tooltip("Tag of gameobject to attach the JetpackVFXManager object to.")]
    public string KerbalAttachNodeName;
    [Tooltip("CapsuleCollider for the character.")]
    public CapsuleCollider CharacterCapsuleCollider;
    [Header("Interact")]
    [SerializeField]
    [Tooltip("InteractPreset type to listen for on Airlock Use.")]
    public InteractPresetAssetReference AirlockInteractPreset;
    [SerializeField]
    [Tooltip("InteractPreset type to listen for to start climbing a Ladder.")]
    public InteractPresetAssetReference LadderStartClimbInteractPreset;
    [SerializeField]
    [Tooltip("InteractPreset type to listen for on Flag Removal.")]
    public InteractPresetAssetReference FlagRemovalInteractPreset;
    [Header("Climb")]
    [SerializeField]
    [Tooltip("InteractPreset type to listen for to stop climbing or let go of a Ladder.")]
    public InteractPresetAssetReference LadderStopClimbInteractPreset;
    [SerializeField]
    [Tooltip("InteractPreset type to listen for to clamber onto a platform available at the top of a Ladder.")]
    public InteractPresetAssetReference LadderTopClamberInteractPreset;
    [SerializeField]
    [Tooltip("InteractPreset type to listen for to clamber onto a Step or Low Obstacle.")]
    public InteractPresetAssetReference StepClamberInteractPreset;
    [Header("Jetpack")]
    [HideInInspector]
    public JetpackResourceManager JetpackResourceManager;
    [SerializeField]
    protected Data_Kerbal dataKerbal;
    private ModuleAction _actionPlantFlag;
    private KerbalBehavior _kerbalBehavior;
    private bool _isPlantActionVisible;
    private bool _isJetpackISPVisible;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselComponent KerbalVesselComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReparentJetpackVFXToRig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateJetpackISPVisibility(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMPlantFlagVisibility(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlantFlagAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Kerbal() => throw null;
  }
}
