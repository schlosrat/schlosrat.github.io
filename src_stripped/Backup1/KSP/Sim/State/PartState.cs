// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.PartState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  [Serializable]
  public struct PartState
  {
    [Obsolete("Use PartOwnerGuid instead")]
    public string partOwnerGuid;
    public IGGuid PartOwnerGuid;
    public PartStatus partStatus;
    public List<AttachNodeState> attachNodeStates;
    public Dictionary<string, ContainedResourceState> resources;
    public Vector3d localPosition;
    public Vector3d originalAttachLocalPosition;
    public QuaternionD localRotation;
    public QuaternionD UserRotation;
    public bool isMirrored;
    public int StageIndex;
    [DefaultValue(true)]
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
    public bool FuelCrossfeed;
    public Dictionary<string, object> partPropertyOverrides;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartState ConvertLegacyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartState UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;
  }
}
