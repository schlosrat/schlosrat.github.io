// Decompiled with JetBrains decompiler
// Type: Extend`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

public class Extend<T> where T : class
{
  public T Target
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Decorator<T> Tail
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Extend(T target) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Extend() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public U Get<U>() where U : Decorator<T> => throw null;
}
