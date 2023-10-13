// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SaveLoadGameFlowActionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Assets;
using KSP.Game.Flow;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public abstract class SaveLoadGameFlowActionBase : FlowAction
  {
    protected readonly LoadGameData _data;
    protected readonly GameInstance _game;
    protected readonly AssetProvider _assets;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SaveLoadGameFlowActionBase(string name, LoadGameData data) => throw null;
  }
}
