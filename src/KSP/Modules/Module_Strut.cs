// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Strut
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Strut : Module_CompoundPart
  {
    [SerializeField]
    protected Data_Strut dataStrut;
    [SerializeField]
    private PartOwnerBehavior.JointConnection _strutJoint;
    private Coroutine _createJointRoutine;
    [SerializeField]
    private AttachNodeData _strutNode;
    private PartOwnerComponent currentPartOwner;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartOwnerBehavior.JointConnection StrutJoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartUnpack(PartBehavior partBeh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPack(PartBehavior partBeh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckEndsStillConnected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CreateJoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PartBehavior TryGetConnectedPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyJoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Strut() => throw null;
  }
}
