// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IUserDataMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter.Interop
{
  public interface IUserDataMemberDescriptor
  {
    string Name { get; }

    Type Type { get; }

    DynValue GetValue(Script script, object obj);

    bool SetValue(Script script, object obj, DynValue value);

    UserDataMemberType MemberType { get; }

    void Optimize();

    bool IsStatic { get; }
  }
}
