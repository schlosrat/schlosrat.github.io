﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameStateConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
