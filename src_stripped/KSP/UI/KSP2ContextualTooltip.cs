// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2ContextualTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
