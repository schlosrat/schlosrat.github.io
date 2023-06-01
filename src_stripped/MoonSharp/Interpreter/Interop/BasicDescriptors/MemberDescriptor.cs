// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.MemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
  public static class MemberDescriptor
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasAllFlags(this MemberDescriptorAccess access, MemberDescriptorAccess flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanRead(this IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanWrite(this IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanExecute(this IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue GetGetterCallbackAsDynValue(
      this IMemberDescriptor desc,
      Script script,
      object obj)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IMemberDescriptor WithAccessOrNull(
      this IMemberDescriptor desc,
      MemberDescriptorAccess access)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckAccess(
      this IMemberDescriptor desc,
      MemberDescriptorAccess access,
      object obj)
    {
      throw null;
    }
  }
}
