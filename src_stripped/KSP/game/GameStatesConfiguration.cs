// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameStatesConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class GameStatesConfiguration : ScriptableObject
  {
    [SerializeField]
    public GameStateConfiguration[] GameStates;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameStatesConfiguration() => throw null;
  }
}
