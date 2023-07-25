// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Decouple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.VFX;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Decouple : PartBehaviourModule
  {
    [FormerlySerializedAs("data")]
    [SerializeField]
    private Data_Decouple _dataDecouple;
    public Vector3 ExplosiveDir;
    protected AttachNodeData _explosiveNode;
    private ContextualFxSystem _vfxSystem;
    private KSPPartAudioManager _kspPartAudioManager;
    private Transform _anchor;
    private const string _moduleDisplayName = "PartModules/Decoupler/Name";
    private DebugShapesDraw.Arrow _shapesArrow;
    private Vector3 _debugVectorPhysicsSpace;
    private Transform _parentPartTransform;
    private ModuleAction _actionDecouple;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AttachNodeData ExplosiveNode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDecouple() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PerformPartDecouple(
      PartBehavior hostViewPart,
      PartComponent partToDetach,
      Vector jettisonDirection,
      string nodeIdToDetach,
      bool isOmniDecoupler,
      float ejectionForce)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryJettisonFairing(AttachNodeData attachmentToCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector CalculateJettisonDirection(PartComponent part, PartComponent otherPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PartBehavior GetPartBehavior(PartComponent modelComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ApplyImpulseForce(
      RigidbodyComponent rigidbodyComponent,
      ForceType forceType,
      Vector forceDir,
      double forceAmount,
      Vector3d relativePos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LaunchFX(
      PartBehavior part,
      string explosiveNodeId,
      ContextualFxSystem vfxSystem,
      KSPPartAudioManager audioManager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Decouple() => throw null;
  }
}
