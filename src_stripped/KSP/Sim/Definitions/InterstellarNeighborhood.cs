// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.InterstellarNeighborhood
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
  public class InterstellarNeighborhood
  {
    public string friendlyName;
    public Vector3 location;
    public string version;
    public List<InterstellarStar> children;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InterstellarNeighborhood() => throw null;
  }
}
