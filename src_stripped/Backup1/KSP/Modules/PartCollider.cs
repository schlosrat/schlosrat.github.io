// Decompiled with JetBrains decompiler
// Type: KSP.Modules.PartCollider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public class PartCollider
  {
    public Collider collider;
    public PartBehavior owner;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartCollider(PartBehavior p, Collider c) => throw null;
  }
}
