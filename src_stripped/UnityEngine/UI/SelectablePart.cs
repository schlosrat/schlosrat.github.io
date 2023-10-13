// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SelectablePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.OAB;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class SelectablePart : Selectable, IPointerClickHandler, IEventSystemHandler
  {
    private GameInstance _game;
    private ObjectAssemblyPart _part;

    private ObjectAssemblyTool currentTool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private ObjectAssemblyPartTracker partTracker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private ObjectAssemblyBuilderEvents builderEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyPart Part
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectablePart() => throw null;
  }
}
