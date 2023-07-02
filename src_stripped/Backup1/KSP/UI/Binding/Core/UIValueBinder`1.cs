// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueBinder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
