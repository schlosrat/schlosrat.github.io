// Decompiled with JetBrains decompiler
// Type: KSP.UI.BasicTextTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class BasicTextTooltipData : KerbalMonoBehaviour
  {
    private const string TITLE_PROPERTY_KEY = "TooltipTitle";
    [SerializeField]
    private string _tooltipTitleKey;
    private Basic2DTooltipTarget _tooltipTargetObject;
    protected DataContext _dataContext;

    public PropertyExternal<string> TooltipTitle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    public string TooltipTitleKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Basic2DTooltipTarget TooltipTargetObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DataContext TooltipDataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize(Basic2DTooltipTarget tooltipTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ValidateData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool IsEmpty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected string LocalizeText(string localizationKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetTooltipTitle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicTextTooltipData() => throw null;
  }
}
