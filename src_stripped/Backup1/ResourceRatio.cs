// Decompiled with JetBrains decompiler
// Type: ResourceRatio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
