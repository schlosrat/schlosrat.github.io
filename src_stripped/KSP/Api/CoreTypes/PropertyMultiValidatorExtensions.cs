// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.PropertyMultiValidatorExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
