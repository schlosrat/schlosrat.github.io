// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.QuickNavAccessTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [Header("Set null to get the RectTransform of current GameObject.")]
    [Tooltip("Register by RectTransform range as default.")]
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
