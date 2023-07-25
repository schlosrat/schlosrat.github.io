// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
