// Decompiled with JetBrains decompiler
// Type: SetupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Rendering;
using System;

[Serializable]
public struct SetupData
{
  public string name;
  public bool isStar;
  public double periapsis;
  public double apoapsis;
  public PlanetShinePreset planetShinePreset;
}
