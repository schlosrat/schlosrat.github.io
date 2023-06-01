// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.PropertyMultiValidatorExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.Generic;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public static class PropertyMultiValidatorExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddValidation<T>(
      this PropertyMultiValidator multiValidator,
      IProperty<T> property,
      Func<T, bool> evaluator)
    {
      throw null;
    }
  }
}
