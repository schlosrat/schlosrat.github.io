// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.AttachRules
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
