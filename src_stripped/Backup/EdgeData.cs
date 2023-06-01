// Decompiled with JetBrains decompiler
// Type: EdgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
