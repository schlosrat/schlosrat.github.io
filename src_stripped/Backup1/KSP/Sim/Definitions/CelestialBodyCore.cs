// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CelestialBodyCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
