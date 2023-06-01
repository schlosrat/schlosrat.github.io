// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ProceduralPartCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
