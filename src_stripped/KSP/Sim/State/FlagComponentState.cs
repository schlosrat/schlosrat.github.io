// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.FlagComponentState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  [Serializable]
  public struct FlagComponentState
  {
    public KSP.Sim.PhysicsMode? PhysicsMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FlagComponentState GetDefaultState() => throw null;
  }
}
