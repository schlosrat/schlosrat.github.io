// Decompiled with JetBrains decompiler
// Type: JTemp.UIInteract
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
