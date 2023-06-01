// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIDroppableVisuals
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class UIDroppableVisuals : MonoBehaviour
  {
    [SerializeField]
    private bool _isPendingDrop;
    [SerializeField]
    private UIDroppableVisuals.PendingDropVisualStyle _styleWhenPendingDrop;
    [SerializeField]
    private Color _highlightColor;
    private Color _startingColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    public bool IsPendingDrop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIDroppableVisuals() => throw null;

    public enum PendingDropVisualStyle
    {
      None,
      Highlight,
    }
  }
}
