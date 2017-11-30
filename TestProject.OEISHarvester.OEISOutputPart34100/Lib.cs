using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011734
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011734Inst : IEnumerable<long>
{
public static readonly long[] Value=A011734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011734.Bytes);
public long this[int i]=>Value[i];

public static A011734Inst Instance=new A011734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011733
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011733Inst : IEnumerable<long>
{
public static readonly long[] Value=A011733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011733.Bytes);
public long this[int i]=>Value[i];

public static A011733Inst Instance=new A011733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011732
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011732Inst : IEnumerable<long>
{
public static readonly long[] Value=A011732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011732.Bytes);
public long this[int i]=>Value[i];

public static A011732Inst Instance=new A011732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011731
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011731Inst : IEnumerable<long>
{
public static readonly long[] Value=A011731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011731.Bytes);
public long this[int i]=>Value[i];

public static A011731Inst Instance=new A011731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011730
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011730Inst : IEnumerable<long>
{
public static readonly long[] Value=A011730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011730.Bytes);
public long this[int i]=>Value[i];

public static A011730Inst Instance=new A011730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011729
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011729Inst : IEnumerable<long>
{
public static readonly long[] Value=A011729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011729.Bytes);
public long this[int i]=>Value[i];

public static A011729Inst Instance=new A011729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011728
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011728Inst : IEnumerable<long>
{
public static readonly long[] Value=A011728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011728.Bytes);
public long this[int i]=>Value[i];

public static A011728Inst Instance=new A011728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011727
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011727Inst : IEnumerable<long>
{
public static readonly long[] Value=A011727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011727.Bytes);
public long this[int i]=>Value[i];

public static A011727Inst Instance=new A011727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011726
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011726Inst : IEnumerable<long>
{
public static readonly long[] Value=A011726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011726.Bytes);
public long this[int i]=>Value[i];

public static A011726Inst Instance=new A011726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011709
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011709Inst : IEnumerable<long>
{
public static readonly long[] Value=A011709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011709.Bytes);
public long this[int i]=>Value[i];

public static A011709Inst Instance=new A011709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011708
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011708Inst : IEnumerable<long>
{
public static readonly long[] Value=A011708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011708.Bytes);
public long this[int i]=>Value[i];

public static A011708Inst Instance=new A011708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011707
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011707Inst : IEnumerable<long>
{
public static readonly long[] Value=A011707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011707.Bytes);
public long this[int i]=>Value[i];

public static A011707Inst Instance=new A011707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011706
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011706Inst : IEnumerable<long>
{
public static readonly long[] Value=A011706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011706.Bytes);
public long this[int i]=>Value[i];

public static A011706Inst Instance=new A011706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011705
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011705Inst : IEnumerable<long>
{
public static readonly long[] Value=A011705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011705.Bytes);
public long this[int i]=>Value[i];

public static A011705Inst Instance=new A011705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011704
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011704Inst : IEnumerable<long>
{
public static readonly long[] Value=A011704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011704.Bytes);
public long this[int i]=>Value[i];

public static A011704Inst Instance=new A011704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011703
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011703Inst : IEnumerable<long>
{
public static readonly long[] Value=A011703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011703.Bytes);
public long this[int i]=>Value[i];

public static A011703Inst Instance=new A011703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011702
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011702Inst : IEnumerable<long>
{
public static readonly long[] Value=A011702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011702.Bytes);
public long this[int i]=>Value[i];

public static A011702Inst Instance=new A011702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011701
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011701Inst : IEnumerable<long>
{
public static readonly long[] Value=A011701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011701.Bytes);
public long this[int i]=>Value[i];

public static A011701Inst Instance=new A011701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011700
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011700Inst : IEnumerable<long>
{
public static readonly long[] Value=A011700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011700.Bytes);
public long this[int i]=>Value[i];

public static A011700Inst Instance=new A011700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011699
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011699Inst : IEnumerable<long>
{
public static readonly long[] Value=A011699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011699.Bytes);
public long this[int i]=>Value[i];

public static A011699Inst Instance=new A011699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011698
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011698Inst : IEnumerable<long>
{
public static readonly long[] Value=A011698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011698.Bytes);
public long this[int i]=>Value[i];

public static A011698Inst Instance=new A011698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011697
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011697Inst : IEnumerable<long>
{
public static readonly long[] Value=A011697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011697.Bytes);
public long this[int i]=>Value[i];

public static A011697Inst Instance=new A011697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011696
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011696Inst : IEnumerable<long>
{
public static readonly long[] Value=A011696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011696.Bytes);
public long this[int i]=>Value[i];

public static A011696Inst Instance=new A011696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011695
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011695Inst : IEnumerable<long>
{
public static readonly long[] Value=A011695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011695.Bytes);
public long this[int i]=>Value[i];

public static A011695Inst Instance=new A011695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011694
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011694Inst : IEnumerable<long>
{
public static readonly long[] Value=A011694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011694.Bytes);
public long this[int i]=>Value[i];

public static A011694Inst Instance=new A011694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011677
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011677Inst : IEnumerable<long>
{
public static readonly long[] Value=A011677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011677.Bytes);
public long this[int i]=>Value[i];

public static A011677Inst Instance=new A011677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011676
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011676Inst : IEnumerable<long>
{
public static readonly long[] Value=A011676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011676.Bytes);
public long this[int i]=>Value[i];

public static A011676Inst Instance=new A011676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011675
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011675Inst : IEnumerable<long>
{
public static readonly long[] Value=A011675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011675.Bytes);
public long this[int i]=>Value[i];

public static A011675Inst Instance=new A011675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011674
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011674Inst : IEnumerable<long>
{
public static readonly long[] Value=A011674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011674.Bytes);
public long this[int i]=>Value[i];

public static A011674Inst Instance=new A011674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011673
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011673Inst : IEnumerable<long>
{
public static readonly long[] Value=A011673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011673.Bytes);
public long this[int i]=>Value[i];

public static A011673Inst Instance=new A011673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011672
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011672Inst : IEnumerable<long>
{
public static readonly long[] Value=A011672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011672.Bytes);
public long this[int i]=>Value[i];

public static A011672Inst Instance=new A011672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011671
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011671Inst : IEnumerable<long>
{
public static readonly long[] Value=A011671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011671.Bytes);
public long this[int i]=>Value[i];

public static A011671Inst Instance=new A011671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011670
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011670Inst : IEnumerable<long>
{
public static readonly long[] Value=A011670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011670.Bytes);
public long this[int i]=>Value[i];

public static A011670Inst Instance=new A011670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011669
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011669Inst : IEnumerable<long>
{
public static readonly long[] Value=A011669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011669.Bytes);
public long this[int i]=>Value[i];

public static A011669Inst Instance=new A011669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011668
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011668Inst : IEnumerable<long>
{
public static readonly long[] Value=A011668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011668.Bytes);
public long this[int i]=>Value[i];

public static A011668Inst Instance=new A011668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011667
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011667Inst : IEnumerable<long>
{
public static readonly long[] Value=A011667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011667.Bytes);
public long this[int i]=>Value[i];

public static A011667Inst Instance=new A011667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011666
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011666Inst : IEnumerable<long>
{
public static readonly long[] Value=A011666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011666.Bytes);
public long this[int i]=>Value[i];

public static A011666Inst Instance=new A011666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011665
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011665Inst : IEnumerable<long>
{
public static readonly long[] Value=A011665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011665.Bytes);
public long this[int i]=>Value[i];

public static A011665Inst Instance=new A011665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011664
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011664Inst : IEnumerable<long>
{
public static readonly long[] Value=A011664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011664.Bytes);
public long this[int i]=>Value[i];

public static A011664Inst Instance=new A011664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011663
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011663Inst : IEnumerable<long>
{
public static readonly long[] Value=A011663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011663.Bytes);
public long this[int i]=>Value[i];

public static A011663Inst Instance=new A011663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011662
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011662Inst : IEnumerable<long>
{
public static readonly long[] Value=A011662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011662.Bytes);
public long this[int i]=>Value[i];

public static A011662Inst Instance=new A011662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011661
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011661Inst : IEnumerable<long>
{
public static readonly long[] Value=A011661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011661.Bytes);
public long this[int i]=>Value[i];

public static A011661Inst Instance=new A011661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011660
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011660Inst : IEnumerable<long>
{
public static readonly long[] Value=A011660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011660.Bytes);
public long this[int i]=>Value[i];

public static A011660Inst Instance=new A011660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011659
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011659Inst : IEnumerable<long>
{
public static readonly long[] Value=A011659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011659.Bytes);
public long this[int i]=>Value[i];

public static A011659Inst Instance=new A011659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011658
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011658Inst : IEnumerable<long>
{
public static readonly long[] Value=A011658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011658.Bytes);
public long this[int i]=>Value[i];

public static A011658Inst Instance=new A011658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011657
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011657Inst : IEnumerable<long>
{
public static readonly long[] Value=A011657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011657.Bytes);
public long this[int i]=>Value[i];

public static A011657Inst Instance=new A011657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011656
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011656Inst : IEnumerable<long>
{
public static readonly long[] Value=A011656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011656.Bytes);
public long this[int i]=>Value[i];

public static A011656Inst Instance=new A011656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011655
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011655Inst : IEnumerable<long>
{
public static readonly long[] Value=A011655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011655.Bytes);
public long this[int i]=>Value[i];

public static A011655Inst Instance=new A011655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011654
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011654Inst : IEnumerable<long>
{
public static readonly long[] Value=A011654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011654.Bytes);
public long this[int i]=>Value[i];

public static A011654Inst Instance=new A011654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011653
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011653Inst : IEnumerable<long>
{
public static readonly long[] Value=A011653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011653.Bytes);
public long this[int i]=>Value[i];

public static A011653Inst Instance=new A011653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011652
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011652Inst : IEnumerable<long>
{
public static readonly long[] Value=A011652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011652.Bytes);
public long this[int i]=>Value[i];

public static A011652Inst Instance=new A011652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011651
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011651Inst : IEnumerable<long>
{
public static readonly long[] Value=A011651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011651.Bytes);
public long this[int i]=>Value[i];

public static A011651Inst Instance=new A011651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011650
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,-2L,-1L,-1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,-1L,-1L,-2L,-1L,-1L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011650Inst : IEnumerable<long>
{
public static readonly long[] Value=A011650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011650.Bytes);
public long this[int i]=>Value[i];

public static A011650Inst Instance=new A011650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011649
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011649Inst : IEnumerable<long>
{
public static readonly long[] Value=A011649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011649.Bytes);
public long this[int i]=>Value[i];

public static A011649Inst Instance=new A011649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011648
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011648Inst : IEnumerable<long>
{
public static readonly long[] Value=A011648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011648.Bytes);
public long this[int i]=>Value[i];

public static A011648Inst Instance=new A011648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011647
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011647Inst : IEnumerable<long>
{
public static readonly long[] Value=A011647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011647.Bytes);
public long this[int i]=>Value[i];

public static A011647Inst Instance=new A011647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011646
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011646Inst : IEnumerable<long>
{
public static readonly long[] Value=A011646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011646.Bytes);
public long this[int i]=>Value[i];

public static A011646Inst Instance=new A011646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011613
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011613Inst : IEnumerable<long>
{
public static readonly long[] Value=A011613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011613.Bytes);
public long this[int i]=>Value[i];

public static A011613Inst Instance=new A011613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011612
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011612Inst : IEnumerable<long>
{
public static readonly long[] Value=A011612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011612.Bytes);
public long this[int i]=>Value[i];

public static A011612Inst Instance=new A011612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011611
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011611Inst : IEnumerable<long>
{
public static readonly long[] Value=A011611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011611.Bytes);
public long this[int i]=>Value[i];

public static A011611Inst Instance=new A011611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011610
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011610Inst : IEnumerable<long>
{
public static readonly long[] Value=A011610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011610.Bytes);
public long this[int i]=>Value[i];

public static A011610Inst Instance=new A011610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011609
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011609Inst : IEnumerable<long>
{
public static readonly long[] Value=A011609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011609.Bytes);
public long this[int i]=>Value[i];

public static A011609Inst Instance=new A011609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011608
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011608Inst : IEnumerable<long>
{
public static readonly long[] Value=A011608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011608.Bytes);
public long this[int i]=>Value[i];

public static A011608Inst Instance=new A011608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011607
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011607Inst : IEnumerable<long>
{
public static readonly long[] Value=A011607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011607.Bytes);
public long this[int i]=>Value[i];

public static A011607Inst Instance=new A011607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011606
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011606Inst : IEnumerable<long>
{
public static readonly long[] Value=A011606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011606.Bytes);
public long this[int i]=>Value[i];

public static A011606Inst Instance=new A011606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011605
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011605Inst : IEnumerable<long>
{
public static readonly long[] Value=A011605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011605.Bytes);
public long this[int i]=>Value[i];

public static A011605Inst Instance=new A011605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011604
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011604Inst : IEnumerable<long>
{
public static readonly long[] Value=A011604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011604.Bytes);
public long this[int i]=>Value[i];

public static A011604Inst Instance=new A011604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011603
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011603Inst : IEnumerable<long>
{
public static readonly long[] Value=A011603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011603.Bytes);
public long this[int i]=>Value[i];

public static A011603Inst Instance=new A011603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011602
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011602Inst : IEnumerable<long>
{
public static readonly long[] Value=A011602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011602.Bytes);
public long this[int i]=>Value[i];

public static A011602Inst Instance=new A011602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011601
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011601Inst : IEnumerable<long>
{
public static readonly long[] Value=A011601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011601.Bytes);
public long this[int i]=>Value[i];

public static A011601Inst Instance=new A011601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011600
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011600Inst : IEnumerable<long>
{
public static readonly long[] Value=A011600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011600.Bytes);
public long this[int i]=>Value[i];

public static A011600Inst Instance=new A011600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011599
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011599Inst : IEnumerable<long>
{
public static readonly long[] Value=A011599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011599.Bytes);
public long this[int i]=>Value[i];

public static A011599Inst Instance=new A011599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011598
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011598Inst : IEnumerable<long>
{
public static readonly long[] Value=A011598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011598.Bytes);
public long this[int i]=>Value[i];

public static A011598Inst Instance=new A011598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011597
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011597Inst : IEnumerable<long>
{
public static readonly long[] Value=A011597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011597.Bytes);
public long this[int i]=>Value[i];

public static A011597Inst Instance=new A011597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011596
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,0L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011596Inst : IEnumerable<long>
{
public static readonly long[] Value=A011596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011596.Bytes);
public long this[int i]=>Value[i];

public static A011596Inst Instance=new A011596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011595
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011595Inst : IEnumerable<long>
{
public static readonly long[] Value=A011595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011595.Bytes);
public long this[int i]=>Value[i];

public static A011595Inst Instance=new A011595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011594
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011594Inst : IEnumerable<long>
{
public static readonly long[] Value=A011594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011594.Bytes);
public long this[int i]=>Value[i];

public static A011594Inst Instance=new A011594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011593
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011593Inst : IEnumerable<long>
{
public static readonly long[] Value=A011593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011593.Bytes);
public long this[int i]=>Value[i];

public static A011593Inst Instance=new A011593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011592
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011592Inst : IEnumerable<long>
{
public static readonly long[] Value=A011592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011592.Bytes);
public long this[int i]=>Value[i];

public static A011592Inst Instance=new A011592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011591
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,0L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011591Inst : IEnumerable<long>
{
public static readonly long[] Value=A011591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011591.Bytes);
public long this[int i]=>Value[i];

public static A011591Inst Instance=new A011591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011590
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,0L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011590Inst : IEnumerable<long>
{
public static readonly long[] Value=A011590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011590.Bytes);
public long this[int i]=>Value[i];

public static A011590Inst Instance=new A011590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011589
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011589Inst : IEnumerable<long>
{
public static readonly long[] Value=A011589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011589.Bytes);
public long this[int i]=>Value[i];

public static A011589Inst Instance=new A011589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011588
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011588Inst : IEnumerable<long>
{
public static readonly long[] Value=A011588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011588.Bytes);
public long this[int i]=>Value[i];

public static A011588Inst Instance=new A011588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011587
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011587Inst : IEnumerable<long>
{
public static readonly long[] Value=A011587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011587.Bytes);
public long this[int i]=>Value[i];

public static A011587Inst Instance=new A011587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011586
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011586Inst : IEnumerable<long>
{
public static readonly long[] Value=A011586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011586.Bytes);
public long this[int i]=>Value[i];

public static A011586Inst Instance=new A011586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011585
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,0L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011585Inst : IEnumerable<long>
{
public static readonly long[] Value=A011585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011585.Bytes);
public long this[int i]=>Value[i];

public static A011585Inst Instance=new A011585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011584
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011584Inst : IEnumerable<long>
{
public static readonly long[] Value=A011584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011584.Bytes);
public long this[int i]=>Value[i];

public static A011584Inst Instance=new A011584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011583
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011583Inst : IEnumerable<long>
{
public static readonly long[] Value=A011583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011583.Bytes);
public long this[int i]=>Value[i];

public static A011583Inst Instance=new A011583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011582
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011582Inst : IEnumerable<long>
{
public static readonly long[] Value=A011582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011582.Bytes);
public long this[int i]=>Value[i];

public static A011582Inst Instance=new A011582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011581
{
public static readonly BigInteger[] Value={ 1L,2147483647L,308834550658326L,768305500780164501L,BigInteger.Parse("193257076459811283150"),BigInteger.Parse("10860054705353951941382"),BigInteger.Parse("208175663741028175181836"),BigInteger.Parse("1751346256720122175776157"),BigInteger.Parse("7605059958514260997905150") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011581Inst Instance=new A011581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011580
{
public static readonly BigInteger[] Value={ 1L,1073741823L,102944492305501L,192050639071964750L,BigInteger.Parse("38613005164147863680"),BigInteger.Parse("1803573616698300679617"),BigInteger.Parse("29481727160618553500317"),BigInteger.Parse("215233066194937952784480"),BigInteger.Parse("821091876924369227235630") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011580Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011580.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011580Inst Instance=new A011580Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011579
{
public static readonly BigInteger[] Value={ 1L,536870911L,34314651811530L,48004081105038305L,7713000216608565075L,BigInteger.Parse("299310102746948685757"),BigInteger.Parse("4168916722553086402080"),BigInteger.Parse("26383018684048108297800"),BigInteger.Parse("88300984248924568770870"),BigInteger.Parse("173373343599189364594756") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011579Inst Instance=new A011579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011578
{
public static readonly BigInteger[] Value={ 1L,268435455L,11438127792025L,11998160744311570L,1540200411172850701L,BigInteger.Parse("49628317055962639176"),BigInteger.Parse("588469772213874823272"),BigInteger.Parse("3224318613979279184316"),BigInteger.Parse("9452962848327254398506"),BigInteger.Parse("16392038075086211019625") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011578Inst Instance=new A011578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011577
{
public static readonly BigInteger[] Value={ 1L,134217727L,3812664524766L,2998587019946701L,307440364830580800L,8220146115188676396L,BigInteger.Parse("82892803728383735268"),BigInteger.Parse("392678226281361931131"),BigInteger.Parse("1006698291338432496375"),BigInteger.Parse("1538533978374777852325"),BigInteger.Parse("1501910658871554621690") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011577Inst Instance=new A011577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011576
{
public static readonly BigInteger[] Value={ 1L,67108863L,1270865805301L,749329038535350L,61338207158409090L,1359801318005044551L,11647571772911241531UL,BigInteger.Parse("47628831813556336200"),BigInteger.Parse("106563273280541795575"),BigInteger.Parse("143197070509423605675"),BigInteger.Parse("123519417123830092365") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011576Inst Instance=new A011576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011575
{
public static readonly ulong[] Value={ 1L,33554431L,423610750290L,187226356946265L,12230196160292565L,224595186974125331L,1631853797991016600L,5749622251945664950L,11201516780955125625UL,13199555372846848005UL,10029078340998476760UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011575Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A011575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011575.Bytes);
public ulong this[int i]=>Value[i];

public static A011575Inst Instance=new A011575Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011574
{
public static readonly long[] Value={ 1L,16777215L,141197991025L,46771289738810L,2436684974110751L,37026417000002430L,227832482998716310L,690223721118368580L,1167921451092973005L,1203163392175387500L,802355904438462660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011574Inst : IEnumerable<long>
{
public static readonly long[] Value=A011574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011574.Bytes);
public long this[int i]=>Value[i];

public static A011574Inst Instance=new A011574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011573
{
public static readonly long[] Value={ 1L,8388607L,47063200806L,11681056634501L,485000783495250L,6090236036084530L,31677463851804540L,82318282158320505L,120622574326072500L,108254081784931500L,63100165695775560L,24930204590758260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011573Inst : IEnumerable<long>
{
public static readonly long[] Value=A011573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011573.Bytes);
public long this[int i]=>Value[i];

public static A011573Inst Instance=new A011573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011572
{
public static readonly long[] Value={ 1L,4194303L,15686335501L,2916342574750L,96416888184100L,998969857983405L,4382641999117305L,9741955019900400L,12320068811796900L,9593401297313460L,4864251308951100L,1672162773483930L,401282560341390L,68629175807115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011572Inst : IEnumerable<long>
{
public static readonly long[] Value=A011572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011572.Bytes);
public long this[int i]=>Value[i];

public static A011572Inst Instance=new A011572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011571
{
public static readonly long[] Value={ 1L,2097151L,5228079450L,727778623825L,19137821912055L,163305339345225L,602762379967440L,1142399079991620L,1241963303533920L,835143799377954L,366282500870286L,108823356051137L,22496861868481L,3295165281331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011571Inst : IEnumerable<long>
{
public static readonly long[] Value=A011571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011571.Bytes);
public long this[int i]=>Value[i];

public static A011571Inst Instance=new A011571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}