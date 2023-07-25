// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.InterstellarStar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
