// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.AssemblyDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct AssemblyDefinition
  {
    public const string TYPE_VESSEL = "Vessel";
    public const string TYPE_COLONY = "Colony";
    public const string TYPE_KERBAL = "Kerbal";
    public string assemblyName;
    public string localizationNameKey;
    public string version;
    public string description;
    public string simulationObjectType;
    public float offsetToGround;
  }
}
