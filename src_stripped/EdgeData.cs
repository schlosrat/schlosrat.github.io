// Decompiled with JetBrains decompiler
// Type: EdgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

[Serializable]
public struct EdgeData
{
  public string StartNode;
  public string EndNode;
  public double Cost;
  public double InclinationCost;
  public bool CanAerobrake;
}
