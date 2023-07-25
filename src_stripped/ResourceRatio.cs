// Decompiled with JetBrains decompiler
// Type: ResourceRatio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
