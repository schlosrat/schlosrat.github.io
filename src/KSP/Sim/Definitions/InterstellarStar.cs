// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.InterstellarStar
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
  public class InterstellarStar
  {
    public string friendlyName;
    public Vector3 offset;
    public Vector3 planeOrientation;
    public InterstellarStarMotion motion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InterstellarStar() => throw null;
  }
}
