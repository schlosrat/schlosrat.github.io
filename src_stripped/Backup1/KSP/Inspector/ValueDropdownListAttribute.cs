// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.ValueDropdownListAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
  public class ValueDropdownListAttribute : PropertyAttribute
  {
    public string sourceMemberName;
    public object[] extraValues;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueDropdownListAttribute(string source, params object[] extraValues) => throw null;
  }
}
