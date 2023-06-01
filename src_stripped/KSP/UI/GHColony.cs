// Decompiled with JetBrains decompiler
// Type: KSP.UI.GHColony
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class GHColony : KerbalMonoBehaviour, IGHContextualMenu
  {
    [SerializeField]
    private GameObject _multiplayerOptionsButton;
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private const string COLONY_STAFF_PROPERTY_KEY = "colonyStaff";
    private const string ASTRONAUTS_PROPERTY_KEY = "astronauts";
    private const string SCIENCE_TOTAL_PROPERTY_KEY = "scienceTotal";
    private Property<string> _colonyStaff;
    private Property<string> _astronauts;

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
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowContextualMenu(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GHColony() => throw null;
  }
}
