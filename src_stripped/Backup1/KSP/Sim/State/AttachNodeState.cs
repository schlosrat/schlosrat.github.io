// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.AttachNodeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.State
{
  [Serializable]
  public struct AttachNodeState
  {
    public string nodeId;
    public bool IsDynamic;
    [Obsolete("Use AttachedPartGuid instead")]
    public string attachedPartGuid;
    public IGGuid AttachedPartGuid;
    public string attachedPartNodeID;
    public float SizeForDynamic;
    public Vector3 LocalPositionForDynamic;
    public Quaternion LocalRotationForDynamic;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FromAttachNodeData(AttachNodeData data, out AttachNodeState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeState ConvertLegacyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeState UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;
  }
}
