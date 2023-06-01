// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIDataBinder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UI.Binding.Core
{
  public abstract class UIDataBinder<T> : 
    UIDataBinder,
    IUIDataBinder<T>,
    IUIDataBindable<T>,
    IUIDataBindable
    where T : class
  {
    public T Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindData(IProperty<T> dataProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIDataBinder() => throw null;
  }
}
