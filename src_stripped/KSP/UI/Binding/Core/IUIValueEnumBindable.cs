// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.IUIValueEnumBindable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System;
using System.Collections.Generic;

namespace KSP.UI.Binding.Core
{
  public interface IUIValueEnumBindable : IUIValueBindable
  {
    void BindValue(IProperty valueEnumProperty, IEnumerable<string> enumValues);

    void BindValue(IProperty valueEnumProperty, Type enumType);

    void SetMappedEnumValues(IEnumerable<string> enumValues, bool shouldRedraw = true);

    void SetMappedEnum(Type enumType, bool shouldRedraw = true);
  }
}
