// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.InterstellarStar
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
