// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ContainedResourceDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [FormerlySerializedAs("amount")]
    [FormerlySerializedAs("startAmountInUnits")]
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
