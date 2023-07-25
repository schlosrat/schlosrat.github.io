// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.AttachNodeDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Tooltip("Set true this attach node will create multiple PhysX joints")]
    public bool IsMultiJoint;
    [Tooltip("The number of PhysX joints, only used if IsMultiJoint is true.")]
    public int MultiJointMaxJoint;
    [Tooltip("The radius to use when creating the PhysX joints, only used if IsMultiJoint is true.")]
    public float MultiJointRadiusOffset;
    [Tooltip("if True multi joints will be created along one axis instead of in a circle, only used if IsMultiJoint is true.")]
    public bool MultiJointOnSingleAxis;
    [Tooltip("The axis the joints will be credated along, only used if IsMultiJoint and MultiJointOnSingleAxis are true.")]
    public TransformDirAxis SingleJointAxis;
    [Tooltip("The number of PhysX joints, only used if IsMultiJoint is true.")]
    public bool MultiJointFullBreakStrength;
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
