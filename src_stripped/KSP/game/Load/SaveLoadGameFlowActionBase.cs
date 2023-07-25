// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SaveLoadGameFlowActionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
