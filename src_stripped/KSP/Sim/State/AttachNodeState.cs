// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.AttachNodeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
