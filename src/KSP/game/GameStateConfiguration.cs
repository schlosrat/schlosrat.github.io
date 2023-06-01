// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameStateConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  [Serializable]
  public class GameStateConfiguration
  {
    public GameState GameState;
    public bool IsObjectAssembly;
    public bool IsFlightMode;
    public bool InGameSession;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameStateConfiguration() => throw null;
  }
}
