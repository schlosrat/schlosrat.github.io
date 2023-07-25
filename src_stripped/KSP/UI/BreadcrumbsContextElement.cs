// Decompiled with JetBrains decompiler
// Type: KSP.UI.BreadcrumbsContextElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
