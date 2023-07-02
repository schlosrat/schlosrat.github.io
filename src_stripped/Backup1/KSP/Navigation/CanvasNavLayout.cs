// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.CanvasNavLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Navigation
{
  public class CanvasNavLayout : ADynamicNavLayout, INavElementRegister
  {
    public Canvas Canvas;
    [SerializeField]
    [HideInInspector]
    private string _layoutTag;

    public override Camera Camera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string LayoutTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasNavLayout() => throw null;
  }
}
