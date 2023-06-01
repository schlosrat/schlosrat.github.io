// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.AttachNodeDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct AttachNodeDefinition
  {
    [Tooltip("Required. Must be unique for this node.")]
    public string nodeID;
    [Tooltip("Optional field that can be used to group nodes together, eg. 2 downward facing nodes grouped into a 'bottom' group. The group ID would be the same on both nodes. Empty means no group, which is default behavior.")]
    public string NodeSymmetryGroupID;
    public AttachNodeType nodeType;
    public AttachNodeMethod attachMethod;
    public bool IsMultiJoint;
    public int MultiJointMaxJoint;
    public float MultiJointRadiusOffset;
    public Vector3d position;
    public Vector3d orientation;
    public int size;
    public float visualSize;
    public bool isResourceCrossfeed;
    public bool isRigid;
    public float angularStrengthMultiplier;
    public float contactArea;
    public float overrideDragArea;
    public bool isCompoundJoint;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Defaults(out AttachNodeDefinition definition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FromAttachNodeData(
      AttachNodeData attachNodeData,
      out AttachNodeDefinition definition)
    {
      throw null;
    }
  }
}
