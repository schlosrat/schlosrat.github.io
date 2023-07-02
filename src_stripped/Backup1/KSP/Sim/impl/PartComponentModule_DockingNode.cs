// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_DockingNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Modules;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_DockingNode : PartComponentModule
  {
    protected Data_DockingNode _dataDocking;
    protected AttachNodeData _referenceAttachNode;
    private HashSet<string> _nodeTypesSet;
    public PartComponent PartAttachedFromVAB;
    public string PartAttachedFromVABNodeId;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AttachNodeData ReferenceAttachNode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsCompatibleWith(
      PartComponentModule_DockingNode otherDockingComponent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_DockingNode.DockingState GetCurrentState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReferenceAttachNode(AttachNodeData nodeReference) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDockingNodeAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanDock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanUndock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAnimationEnded(MessageCenterMessage mcm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_DockingNode() => throw null;
  }
}
