// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AssemblyMassChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
