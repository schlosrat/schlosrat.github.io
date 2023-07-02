// Decompiled with JetBrains decompiler
// Type: EdgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
