// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.UIData_DemoEntity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Iteration.Data;
using KSP.UI.Binding;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI.Binding
{
  public class UIData_DemoEntity : UIDataBinder<IDemoEntity>
  {
    [SerializeField]
    private UIValue_ReadString_Text guidText;
    [SerializeField]
    private UIValueBinderGroup scoreElements;
    [SerializeField]
    private UIValue_WriteString_Field nameField;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ClearDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawOnBoundValueChanged(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIData_DemoEntity() => throw null;
  }
}
