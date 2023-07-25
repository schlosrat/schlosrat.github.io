// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameStateConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
