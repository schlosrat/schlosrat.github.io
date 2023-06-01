// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AssemblyMassChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public class AssemblyMassChangedMessage : ResourceMessageBase
  {
    public IObjectAssembly ObjectAssembly;
    public double WetMass;
    public double DryMass;
    public double ResourceMass;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyMassChangedMessage() => throw null;
  }
}
