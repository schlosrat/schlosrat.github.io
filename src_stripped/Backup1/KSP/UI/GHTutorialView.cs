// Decompiled with JetBrains decompiler
// Type: KSP.UI.GHTutorialView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Game.Missions;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class GHTutorialView : KerbalMonoBehaviour
  {
    private const string TUTORIAL_NAME_PROPERTY_KEY = "tutorialName";
    private const string LESSONS_TITLES_LOCALIZATION_PATH = "Tutorials/Lessons/Titles/";
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<string> _tutorialName;

    public KSP2MissionManager MissionMgr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowContextualMenu(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GHTutorialView() => throw null;
  }
}
