// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedCelestialBody
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedCelestialBody
  {
    public string GUID;
    public string referenceBodyGuid;
    public SerializedOrbitProperties OrbitProperties;
    public SerializedOribiterDefinition OrbiterProperties;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedCelestialBody() => throw null;
  }
}
