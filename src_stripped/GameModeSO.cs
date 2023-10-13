// Decompiled with JetBrains decompiler
// Type: GameModeSO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Contexts.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "gamemode.asset", menuName = "KSP/Game Mode")]
public class GameModeSO : ScriptableObject
{
  public GameModeData data;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GameModeSO() => throw null;
}
