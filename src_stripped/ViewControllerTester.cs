// Decompiled with JetBrains decompiler
// Type: ViewControllerTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
