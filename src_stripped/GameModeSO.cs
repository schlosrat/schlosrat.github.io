// Decompiled with JetBrains decompiler
// Type: GameModeSO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
