// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class PartCore
  {
    public const double PART_SERIALIZATION_VERSION = 0.3;
    [HideInInspector]
    public double version;
    [HideInInspector]
    public bool useExternal;
    public PartData data;
    public List<ModuleData> modules;
    public string legacyModules;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PartCore UpgradeAndRead(string rawFileData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool Is(double versionParsed, double versionTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartCore() => throw null;
  }
}
