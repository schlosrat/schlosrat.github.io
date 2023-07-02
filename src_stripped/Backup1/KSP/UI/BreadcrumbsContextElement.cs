// Decompiled with JetBrains decompiler
// Type: KSP.UI.BreadcrumbsContextElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class BreadcrumbsContextElement : ApiDataContext
  {
    private DataContext _breadcrumbContext;
    [DataProperty("title")]
    public PropertyReadonly<string> Title;
    [DataProperty("icon")]
    public PropertyReadonly<Sprite> Icon;
    public GameState GameState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BreadcrumbsContextElement(GameState gameState, string title, Sprite icon) => throw null;
  }
}
