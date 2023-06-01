// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ContainedResourceDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace KSP.Sim.ResourceSystem
{
  [Serializable]
  public class ContainedResourceDefinition
  {
    public string name;
    [FormerlySerializedAs("maxAmount")]
    public double capacityUnits;
    [FormerlySerializedAs("startAmountInUnits")]
    [FormerlySerializedAs("amount")]
    public double initialUnits;
    public bool NonStageable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceDefinition(
      ContainedResourceData data,
      ResourceDefinitionDatabase database)
    {
      throw null;
    }

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceDefinition(double capacity, string name) => throw null;
  }
}
