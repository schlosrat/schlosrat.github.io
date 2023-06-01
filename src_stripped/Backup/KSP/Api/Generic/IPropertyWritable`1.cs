// Decompiled with JetBrains decompiler
// Type: KSP.Api.Generic.IPropertyWritable`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Api.Generic
{
  public interface IPropertyWritable<T> : IPropertyWritable, IProperty, IProperty<T>
  {
    void SetValue(T value);
  }
}
