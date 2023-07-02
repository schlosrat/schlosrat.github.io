// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SelectablePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
