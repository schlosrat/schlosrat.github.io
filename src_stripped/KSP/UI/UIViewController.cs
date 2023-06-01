// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIViewController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class UIViewController
  {
    private Dictionary<string, IUIViewElement> _currentElements;
    private UIView _currentView;
    private UIView _previousView;

    public UIView CurrentView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RegisterElement(IUIViewElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UnregisterElement(IUIViewElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UnregisterElement(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushView(UIView newView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushViewKeepPrevious(UIView newView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestorePreviousView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetElementState(string id, out ViewState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIViewController() => throw null;
  }
}
