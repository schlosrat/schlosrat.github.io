// Decompiled with JetBrains decompiler
// Type: KSP.Api.Generic.IPropertyWritable`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Api.Generic
{
  public interface IPropertyWritable<T> : IPropertyWritable, IProperty, IProperty<T>
  {
    void SetValue(T value);
  }
}
