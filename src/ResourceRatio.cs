// Decompiled with JetBrains decompiler
// Type: ResourceRatio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
