// Decompiled with JetBrains decompiler
// Type: KSP.UI.BreadcrumbsContextElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
