// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.RegistrationPolicies.PermanentRegistrationPolicy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
  public class PermanentRegistrationPolicy : IRegistrationPolicy
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IUserDataDescriptor HandleRegistration(
      IUserDataDescriptor newDescriptor,
      IUserDataDescriptor oldDescriptor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AllowTypeAutoRegistration(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PermanentRegistrationPolicy() => throw null;
  }
}
