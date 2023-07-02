// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.JointOptimization
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class JointOptimization
  {
    private DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> jointConnections;
    private DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> jointConnectionsCurrent;
    private DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> jointConnectionsRemoved;
    private GameObject triggerObject;
    private ISimulationObjectView SimObject;
    public bool decimateTest;
    public bool undecimateTest;
    private float boxTriggerScale;
    private bool isCreateBoxTrigger;

    public DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> JointConnections
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> JointConnectionsCurrent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> JointConnectionsRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JointOptimization(
      List<PartOwnerBehavior.JointConnection> jointConnections,
      ISimulationObjectView SimObject)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PartBehavior> GetChilds(PartBehavior father) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PartOwnerBehavior.JointConnection FindJointByHost(
      PartBehavior host,
      DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> jointConnections)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int FindJointIndex(
      PartOwnerBehavior.JointConnection joint,
      DictionaryValueList<PartBehavior, PartOwnerBehavior.JointConnection> jointConnections)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetDecimatedPartsCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnDecimateAllJoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DecimateJoint(PartBehavior obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UnDecimateJoint(PartBehavior obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FreshJointConnectionsCurrent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateBoxTrigger() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyBoxTrigger() => throw null;

    private struct ReConnectedPartInfo
    {
      public PartBehavior reConnectedPart;
      public List<PartBehavior> calParts;
    }
  }
}
