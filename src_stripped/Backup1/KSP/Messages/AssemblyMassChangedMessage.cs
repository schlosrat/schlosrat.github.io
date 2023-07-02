// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AssemblyMassChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
