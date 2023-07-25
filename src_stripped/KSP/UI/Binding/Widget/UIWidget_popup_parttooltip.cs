// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_popup_parttooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_popup_parttooltip : UIWidget
  {
    [Header("Part Name - Readable")]
    [SerializeField]
    private UIValueBinder partName;
    [Header("Part Description - Readable")]
    [SerializeField]
    private UIValueBinder partDescription;
    [Header("Part Image - Readable")]
    [SerializeField]
    private UIValueBinder partImage;

    public IUIValueBindable<string> PartName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueBindable<string> PartDescription
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueBindable<Texture> PartImage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_popup_parttooltip() => throw null;
  }
}
