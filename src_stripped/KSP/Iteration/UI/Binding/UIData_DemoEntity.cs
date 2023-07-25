// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.UIData_DemoEntity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
