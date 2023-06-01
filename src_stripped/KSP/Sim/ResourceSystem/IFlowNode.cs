// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IFlowNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;

namespace KSP.Sim.ResourceSystem
{
  public interface IFlowNode
  {
    string Name { get; }

    IResourceContainer[] Containers { get; }

    bool IsCompound { get; }

    IGGuid GlobalId { get; }
  }
}
