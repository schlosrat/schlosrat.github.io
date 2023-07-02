// Decompiled with JetBrains decompiler
// Type: KSP.UI.ContextualTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class ContextualTooltipData : BasicTextTooltipData
  {
    private const string ICON_PROPERTY_KEY = "TooltipIcon";
    [SerializeField]
    private Sprite _tooltipIcon;

    public Property<Sprite> TooltipIcon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Basic2DTooltipTarget tooltipTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ValidateData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsEmpty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextualTooltipData() => throw null;
  }
}
