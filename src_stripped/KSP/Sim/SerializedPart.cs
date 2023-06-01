// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedPart
  {
    [Obsolete("Use PartGuid instead")]
    public string partGuid;
    public IGGuid PartGuid;
    public string partName;
    public PartState partState;
    public List<SerializedPartModule> PartModulesState;
    [Obsolete("This field is the old version where there was no hierarchy of PartModule->DataModules - pre v0.3 saves")]
    public List<SerializedModuleData> ModulesState;
    public List<SerializedLegacyModuleData> LegacyModulesState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConvertModulesToPartModule() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CombinePartModulesState(Type master, Type child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPart ConvertLegacyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPart UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPart() => throw null;
  }
}
