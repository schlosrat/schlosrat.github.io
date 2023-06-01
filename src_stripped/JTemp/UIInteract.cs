// Decompiled with JetBrains decompiler
// Type: JTemp.UIInteract
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace JTemp
{
  public abstract class UIInteract : UIElement
  {
    public Action OnInteract;
    protected UIInteract.State currentState;
    private UIInteract.State previousState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnStateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Drag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Drop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIInteract() => throw null;

    public enum State
    {
      Normal = 1,
      Pressed = 2,
      Highlighted = 4,
      Disabled = 8,
      On = 16, // 0x00000010
      Off = 32, // 0x00000020
    }
  }
}
