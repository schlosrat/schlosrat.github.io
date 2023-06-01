// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_buttonbar_partmanipulationtools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_buttonbar_partmanipulationtools : UIWidget
  {
    [Header("Enum Part Manipulation Mode - Writable")]
    [SerializeField]
    private UIValueBinder partManipulationMode;

    public IUIValueEnumBindable PartManipulationMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_buttonbar_partmanipulationtools() => throw null;
  }
}
