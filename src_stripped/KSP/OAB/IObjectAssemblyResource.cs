// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;

namespace KSP.OAB
{
  public interface IObjectAssemblyResource
  {
    ResourceType Type { get; }

    string Name { get; }

    float Count { get; }

    float Capacity { get; }

    float IndividualMass { get; }

    float TotalMass { get; }
  }
}
