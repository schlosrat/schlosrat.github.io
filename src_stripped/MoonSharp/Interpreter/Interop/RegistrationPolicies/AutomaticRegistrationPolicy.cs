// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.RegistrationPolicies.AutomaticRegistrationPolicy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
  public class AutomaticRegistrationPolicy : DefaultRegistrationPolicy
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool AllowTypeAutoRegistration(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutomaticRegistrationPolicy() => throw null;
  }
}
