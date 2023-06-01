// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CelestialBodyCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class CelestialBodyCore
  {
    public const string CELESTIAL_BODY_SERIALIZATION_VERSION = "0.3";
    [HideInInspector]
    public string version;
    [HideInInspector]
    public bool useExternal;
    public CelestialBodyData data;
    public const string CELESTIALBODY_DISPLAYNAME_PREFIX = "CelestialBody/";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyCore() => throw null;
  }
}
