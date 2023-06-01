// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_buttonbar_partcategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_buttonbar_partcategory : UIWidget
  {
    [SerializeField]
    [Header("Enum Part Category - Writable")]
    private UIValueBinder partCategory;
    [SerializeField]
    [Header("Search String - Writable")]
    private UIValueBinder searchString;

    public IUIValueEnumBindable PartCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueBindable<string> SearchString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_buttonbar_partcategory() => throw null;
  }
}
