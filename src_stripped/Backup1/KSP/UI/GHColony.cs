// Decompiled with JetBrains decompiler
// Type: KSP.UI.GHColony
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
