// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.AttachRules
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct AttachRules
  {
    public bool stack;
    public bool srfAttach;
    public bool allowStack;
    public bool allowSrfAttach;
    public bool allowCollision;
    public bool allowDock;
    public bool allowRotate;
    public bool allowRoot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AttachRules Defaults() => throw null;
  }
}
