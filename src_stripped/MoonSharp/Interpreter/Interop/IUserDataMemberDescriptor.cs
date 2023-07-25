﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IUserDataMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
