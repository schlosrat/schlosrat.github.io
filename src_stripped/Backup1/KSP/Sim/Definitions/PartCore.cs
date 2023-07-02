// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
