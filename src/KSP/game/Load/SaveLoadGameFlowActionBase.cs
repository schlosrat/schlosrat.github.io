// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SaveLoadGameFlowActionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Flow;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public abstract class SaveLoadGameFlowActionBase : FlowAction
  {
    protected readonly LoadGameData _data;
    protected readonly GameInstance _game;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SaveLoadGameFlowActionBase(string name, LoadGameData data) => throw null;
  }
}
