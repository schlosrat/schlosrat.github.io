// Decompiled with JetBrains decompiler
// Type: KSP.UI.GHResearchDevelopment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class GHResearchDevelopment : KerbalMonoBehaviour, IGHContextualMenu
  {
    private const string PLAYER_SCIENCE_PROPERTY_KEY = "playerScience";
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;

    public GameState ID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBackgroundVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowContextualMenu(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GHResearchDevelopment() => throw null;
  }
}
