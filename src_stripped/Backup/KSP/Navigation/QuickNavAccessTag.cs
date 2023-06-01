// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.QuickNavAccessTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Navigation
{
  [DisableCustomEditorBase]
  public class QuickNavAccessTag : KerbalMonoBehaviour
  {
    [Header("If set, register an access to the explicit NavLayout.")]
    public ADynamicNavLayout ExplicitTargetNavLayout;
    public string LayoutTag;
    public MoveDirection ListDirection;
    public SelectPoint StartPoint;
    [Tooltip("Register by RectTransform range as default.")]
    [Header("Set null to get the RectTransform of current GameObject.")]
    public RectTransform SelectionRect;
    [Header("If set, register by the explicit Selectable component.")]
    public Selectable ExplicitTargetSelectable;

    private IQuickNavRegister quickNavLayout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuickNavAccessTag() => throw null;
  }
}
