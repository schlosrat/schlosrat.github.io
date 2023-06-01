// Decompiled with JetBrains decompiler
// Type: ViewControllerTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisableCustomEditorBase]
public class ViewControllerTester : KerbalMonoBehaviour
{
  [SerializeField]
  private UIView _currentView;
  private UIViewController _viewController;

  public UIViewController ViewController
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [ContextMenu("Apply View")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateView() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ViewControllerTester() => throw null;
}
