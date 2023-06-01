// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameModesManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class GameModesManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private CreateCampaignMenu _createCampaignMenuManager;
    private DataContext _dataContext;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSandboxGameMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetExplorationGameMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameModesManager() => throw null;
  }
}
