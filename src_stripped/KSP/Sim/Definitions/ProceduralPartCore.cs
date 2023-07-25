// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ProceduralPartCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class ProceduralPartCore
  {
    public const string PROCEDURAL_PART_SERIALIZATION_VERSION = "0.1";
    [HideInInspector]
    public string version;
    [HideInInspector]
    public bool useExternal;
    public ProceduralPartDefinition data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartCore() => throw null;
  }
}
