// Decompiled with JetBrains decompiler
// Type: ResourceRatio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;

[Serializable]
public struct ResourceRatio
{
  public string ResourceName;
  public double Ratio;
  public bool DumpExcess;
  public ResourceFlowMode FlowMode;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ResourceRatio(string resourceName, double ratio, bool dumpExcess) => throw null;
}
