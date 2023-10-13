// Decompiled with JetBrains decompiler
// Type: KSP.Research.ResearchManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Assets;
using KSP.Game;
using KSP.Game.Load;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Research
{
  public class ResearchManager
  {
    public List<Technology> Technologies;

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private AssetProvider _assets
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Technology GetTechnologyByID(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTechTreeWithSaveGameData(LoadGameData gameData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTechTreeToSaveGame(LoadGameData gameData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadTechTreeFromAddressableData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ref List<Technology> GetTechnologies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResearchManager() => throw null;
  }
}
