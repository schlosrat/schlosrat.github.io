// Decompiled with JetBrains decompiler
// Type: JTemp.UIDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace JTemp
{
  public abstract class UIDisplay : UIElement
  {
    private UIDisplay.State currentState;
    private UIDisplay.State previousState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIDisplay() => throw null;

    public enum State
    {
      On,
      Off,
      Disabled,
    }
  }
}
