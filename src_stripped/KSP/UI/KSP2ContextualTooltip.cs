// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2ContextualTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (CanvasGroup))]
  public class KSP2ContextualTooltip : Basic2DTooltip
  {
    [SerializeField]
    private GameObject _icon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2ContextualTooltip() => throw null;
  }
}
