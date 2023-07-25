// Decompiled with JetBrains decompiler
// Type: JTemp.UIDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
