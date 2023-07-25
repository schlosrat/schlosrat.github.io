// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.MainCameraNavLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public class MainCameraNavLayout : 
    ADynamicNavLayout,
    IMainCameraSelectableRegister,
    INavElementRegister
  {
    [HideInInspector]
    [SerializeField]
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
    public bool AddMainCameraSelectable(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveSelectable(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MainCameraNavLayout() => throw null;
  }
}
