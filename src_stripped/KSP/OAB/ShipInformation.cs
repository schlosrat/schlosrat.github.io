// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ShipInformation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class ShipInformation
  {
    public string name;
    public string description;
    public string localizationNameKey;
    public const string version = "1";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShipInformation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShipInformation(AssemblyDefinition def) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyDefinition AsVesselDefinition() => throw null;
  }
}
