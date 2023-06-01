// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.TypeInteropAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public class TypeInteropAttribute : Attribute
  {
    public Type dataType;
    public string typeNickname;
    public string[] typeAltNames;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TypeInteropAttribute(Type dataType, string typeNickname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TypeInteropAttribute(Type dataType, string typeNickname, string[] typeAltNames) => throw null;
  }
}
