// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueBinder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UI.Binding.Core
{
  public abstract class UIValueBinder<T> : 
    UIValueBinder,
    IUIValueBinder<T>,
    IUIValueBindable<T>,
    IUIValueBindable
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindValue(IProperty<T> valueProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIValueBinder() => throw null;
  }
}
