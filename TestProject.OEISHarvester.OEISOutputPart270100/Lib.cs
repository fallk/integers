using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040760
{
public static readonly long[] Value={ 28L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L,2L,18L,2L,1L,3L,13L,1L,3L,2L,1L,1L,4L,11L,56L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L,2L,18L,2L,1L,3L,13L,1L,3L,2L,1L,1L,4L,11L,56L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L,2L,18L,2L,1L,3L,13L,1L,3L,2L,1L,1L,4L,11L,56L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L };
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
public class A040760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040760Inst : IEnumerable<long>
{
public static readonly long[] Value=A040760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040760.Bytes);
public long this[int i]=>Value[i];

public static A040760Inst Instance=new A040760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040761
{
public static readonly long[] Value={ 28L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L };
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
public class A040761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040761Inst : IEnumerable<long>
{
public static readonly long[] Value=A040761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040761.Bytes);
public long this[int i]=>Value[i];

public static A040761Inst Instance=new A040761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040762
{
public static readonly long[] Value={ 28L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L };
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
public class A040762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040762Inst : IEnumerable<long>
{
public static readonly long[] Value=A040762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040762.Bytes);
public long this[int i]=>Value[i];

public static A040762Inst Instance=new A040762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040763
{
public static readonly long[] Value={ 28L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L };
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
public class A040763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040763Inst : IEnumerable<long>
{
public static readonly long[] Value=A040763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040763.Bytes);
public long this[int i]=>Value[i];

public static A040763Inst Instance=new A040763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040764
{
public static readonly long[] Value={ 28L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L };
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
public class A040764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040764Inst : IEnumerable<long>
{
public static readonly long[] Value=A040764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040764.Bytes);
public long this[int i]=>Value[i];

public static A040764Inst Instance=new A040764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040845
{
public static readonly long[] Value={ 29L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L };
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
public class A040845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040845Inst : IEnumerable<long>
{
public static readonly long[] Value=A040845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040845.Bytes);
public long this[int i]=>Value[i];

public static A040845Inst Instance=new A040845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040846
{
public static readonly long[] Value={ 29L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L };
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
public class A040846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040846Inst : IEnumerable<long>
{
public static readonly long[] Value=A040846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040846.Bytes);
public long this[int i]=>Value[i];

public static A040846Inst Instance=new A040846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040847
{
public static readonly long[] Value={ 29L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L };
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
public class A040847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040847Inst : IEnumerable<long>
{
public static readonly long[] Value=A040847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040847.Bytes);
public long this[int i]=>Value[i];

public static A040847Inst Instance=new A040847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040848
{
public static readonly long[] Value={ 29L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L };
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
public class A040848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040848Inst : IEnumerable<long>
{
public static readonly long[] Value=A040848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040848.Bytes);
public long this[int i]=>Value[i];

public static A040848Inst Instance=new A040848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040849
{
public static readonly long[] Value={ 29L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L };
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
public class A040849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040849Inst : IEnumerable<long>
{
public static readonly long[] Value=A040849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040849.Bytes);
public long this[int i]=>Value[i];

public static A040849Inst Instance=new A040849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040850
{
public static readonly long[] Value={ 29L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L };
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
public class A040850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040850Inst : IEnumerable<long>
{
public static readonly long[] Value=A040850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040850.Bytes);
public long this[int i]=>Value[i];

public static A040850Inst Instance=new A040850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040851
{
public static readonly long[] Value={ 29L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,11L,7L,2L,1L,58L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,11L,7L,2L,1L,58L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,11L,7L,2L,1L,58L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L };
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
public class A040851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040851Inst : IEnumerable<long>
{
public static readonly long[] Value=A040851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040851.Bytes);
public long this[int i]=>Value[i];

public static A040851Inst Instance=new A040851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040852
{
public static readonly long[] Value={ 29L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L };
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
public class A040852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040852Inst : IEnumerable<long>
{
public static readonly long[] Value=A040852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040852.Bytes);
public long this[int i]=>Value[i];

public static A040852Inst Instance=new A040852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040853
{
public static readonly long[] Value={ 29L,1L,2L,1L,1L,19L,4L,5L,6L,2L,2L,2L,1L,2L,1L,1L,2L,8L,9L,1L,3L,1L,2L,29L,2L,1L,3L,1L,9L,8L,2L,1L,1L,2L,1L,2L,2L,2L,6L,5L,4L,19L,1L,1L,2L,1L,58L,1L,2L,1L,1L,19L,4L,5L,6L,2L,2L,2L,1L,2L,1L,1L,2L,8L,9L,1L,3L,1L,2L,29L,2L,1L,3L,1L,9L,8L,2L,1L,1L,2L,1L,2L,2L,2L,6L,5L,4L,19L,1L,1L };
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
public class A040853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040853Inst : IEnumerable<long>
{
public static readonly long[] Value=A040853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040853.Bytes);
public long this[int i]=>Value[i];

public static A040853Inst Instance=new A040853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040854
{
public static readonly long[] Value={ 29L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L };
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
public class A040854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040854Inst : IEnumerable<long>
{
public static readonly long[] Value=A040854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040854.Bytes);
public long this[int i]=>Value[i];

public static A040854Inst Instance=new A040854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040855
{
public static readonly long[] Value={ 29L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L };
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
public class A040855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040855Inst : IEnumerable<long>
{
public static readonly long[] Value=A040855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040855.Bytes);
public long this[int i]=>Value[i];

public static A040855Inst Instance=new A040855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040856
{
public static readonly long[] Value={ 29L,1L,3L,3L,1L,2L,1L,1L,5L,2L,1L,1L,1L,9L,3L,2L,1L,1L,19L,3L,1L,11L,6L,1L,1L,7L,1L,28L,1L,7L,1L,1L,6L,11L,1L,3L,19L,1L,1L,2L,3L,9L,1L,1L,1L,2L,5L,1L,1L,2L,1L,3L,3L,1L,58L,1L,3L,3L,1L,2L,1L,1L,5L,2L,1L,1L,1L,9L,3L,2L,1L,1L,19L,3L,1L,11L,6L,1L,1L,7L,1L,28L,1L,7L,1L,1L,6L,11L };
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
public class A040856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040856Inst : IEnumerable<long>
{
public static readonly long[] Value=A040856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040856.Bytes);
public long this[int i]=>Value[i];

public static A040856Inst Instance=new A040856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040857
{
public static readonly long[] Value={ 29L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L };
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
public class A040857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040857Inst : IEnumerable<long>
{
public static readonly long[] Value=A040857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040857.Bytes);
public long this[int i]=>Value[i];

public static A040857Inst Instance=new A040857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040858
{
public static readonly long[] Value={ 29L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L };
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
public class A040858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040858Inst : IEnumerable<long>
{
public static readonly long[] Value=A040858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040858.Bytes);
public long this[int i]=>Value[i];

public static A040858Inst Instance=new A040858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040859
{
public static readonly long[] Value={ 29L,1L,4L,2L,3L,1L,1L,11L,2L,1L,3L,19L,1L,1L,1L,1L,6L,1L,5L,1L,3L,8L,3L,1L,5L,1L,6L,1L,1L,1L,1L,19L,3L,1L,2L,11L,1L,1L,3L,2L,4L,1L,58L,1L,4L,2L,3L,1L,1L,11L,2L,1L,3L,19L,1L,1L,1L,1L,6L,1L,5L,1L,3L,8L,3L,1L,5L,1L,6L,1L,1L,1L,1L,19L,3L,1L,2L,11L,1L,1L,3L,2L,4L,1L,58L,1L,4L,2L,3L };
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
public class A040859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040859Inst : IEnumerable<long>
{
public static readonly long[] Value=A040859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040859.Bytes);
public long this[int i]=>Value[i];

public static A040859Inst Instance=new A040859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040860
{
public static readonly long[] Value={ 29L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L };
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
public class A040860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040860Inst : IEnumerable<long>
{
public static readonly long[] Value=A040860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040860.Bytes);
public long this[int i]=>Value[i];

public static A040860Inst Instance=new A040860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040893
{
public static readonly long[] Value={ 30L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L };
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
public class A040893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040893Inst : IEnumerable<long>
{
public static readonly long[] Value=A040893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040893.Bytes);
public long this[int i]=>Value[i];

public static A040893Inst Instance=new A040893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040894
{
public static readonly long[] Value={ 30L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L };
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
public class A040894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040894Inst : IEnumerable<long>
{
public static readonly long[] Value=A040894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040894.Bytes);
public long this[int i]=>Value[i];

public static A040894Inst Instance=new A040894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040895
{
public static readonly long[] Value={ 30L,2L,3L,11L,1L,7L,1L,3L,2L,5L,1L,1L,1L,4L,30L,4L,1L,1L,1L,5L,2L,3L,1L,7L,1L,11L,3L,2L,60L,2L,3L,11L,1L,7L,1L,3L,2L,5L,1L,1L,1L,4L,30L,4L,1L,1L,1L,5L,2L,3L,1L,7L,1L,11L,3L,2L,60L,2L,3L,11L,1L,7L,1L,3L,2L,5L,1L,1L,1L,4L,30L,4L,1L,1L,1L,5L,2L,3L,1L,7L,1L,11L,3L,2L,60L,2L,3L };
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
public class A040895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040895Inst : IEnumerable<long>
{
public static readonly long[] Value=A040895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040895.Bytes);
public long this[int i]=>Value[i];

public static A040895Inst Instance=new A040895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040896
{
public static readonly long[] Value={ 30L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L };
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
public class A040896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040896Inst : IEnumerable<long>
{
public static readonly long[] Value=A040896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040896.Bytes);
public long this[int i]=>Value[i];

public static A040896Inst Instance=new A040896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040897
{
public static readonly long[] Value={ 30L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L };
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
public class A040897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040897Inst : IEnumerable<long>
{
public static readonly long[] Value=A040897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040897.Bytes);
public long this[int i]=>Value[i];

public static A040897Inst Instance=new A040897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040898
{
public static readonly long[] Value={ 30L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L };
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
public class A040898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040898Inst : IEnumerable<long>
{
public static readonly long[] Value=A040898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040898.Bytes);
public long this[int i]=>Value[i];

public static A040898Inst Instance=new A040898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040899
{
public static readonly long[] Value={ 30L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L };
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
public class A040899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040899Inst : IEnumerable<long>
{
public static readonly long[] Value=A040899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040899.Bytes);
public long this[int i]=>Value[i];

public static A040899Inst Instance=new A040899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040900
{
public static readonly long[] Value={ 30L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L,60L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L,60L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L,60L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L };
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
public class A040900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040900Inst : IEnumerable<long>
{
public static readonly long[] Value=A040900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040900.Bytes);
public long this[int i]=>Value[i];

public static A040900Inst Instance=new A040900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040901
{
public static readonly long[] Value={ 30L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L };
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
public class A040901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040901Inst : IEnumerable<long>
{
public static readonly long[] Value=A040901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040901.Bytes);
public long this[int i]=>Value[i];

public static A040901Inst Instance=new A040901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040902
{
public static readonly long[] Value={ 30L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L };
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
public class A040902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040902Inst : IEnumerable<long>
{
public static readonly long[] Value=A040902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040902.Bytes);
public long this[int i]=>Value[i];

public static A040902Inst Instance=new A040902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040903
{
public static readonly long[] Value={ 30L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L };
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
public class A040903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040903Inst : IEnumerable<long>
{
public static readonly long[] Value=A040903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040903.Bytes);
public long this[int i]=>Value[i];

public static A040903Inst Instance=new A040903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040904
{
public static readonly long[] Value={ 30L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L,60L,1L,1L,2L,1L,2L,1L,1L };
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
public class A040904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040904Inst : IEnumerable<long>
{
public static readonly long[] Value=A040904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040904.Bytes);
public long this[int i]=>Value[i];

public static A040904Inst Instance=new A040904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040905
{
public static readonly long[] Value={ 30L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L,60L,1L,1L,2L,6L,2L,1L,1L };
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
public class A040905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040905Inst : IEnumerable<long>
{
public static readonly long[] Value=A040905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040905.Bytes);
public long this[int i]=>Value[i];

public static A040905Inst Instance=new A040905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040906
{
public static readonly long[] Value={ 30L,1L,1L,1L,1L,3L,4L,2L,3L,6L,1L,1L,19L,1L,6L,1L,2L,2L,1L,6L,1L,19L,1L,1L,6L,3L,2L,4L,3L,1L,1L,1L,1L,60L,1L,1L,1L,1L,3L,4L,2L,3L,6L,1L,1L,19L,1L,6L,1L,2L,2L,1L,6L,1L,19L,1L,1L,6L,3L,2L,4L,3L,1L,1L,1L,1L,60L,1L,1L,1L,1L,3L,4L,2L,3L,6L,1L,1L,19L,1L,6L,1L,2L,2L,1L,6L,1L,19L,1L,1L };
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
public class A040906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040906Inst : IEnumerable<long>
{
public static readonly long[] Value=A040906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040906.Bytes);
public long this[int i]=>Value[i];

public static A040906Inst Instance=new A040906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040907
{
public static readonly long[] Value={ 30L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L,60L,1L,1L,1L,2L,8L,2L,1L,1L,1L };
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
public class A040907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040907Inst : IEnumerable<long>
{
public static readonly long[] Value=A040907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040907.Bytes);
public long this[int i]=>Value[i];

public static A040907Inst Instance=new A040907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040908
{
public static readonly long[] Value={ 30L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L,20L,4L,1L,1L,1L,60L,1L,1L,1L,4L };
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
public class A040908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040908Inst : IEnumerable<long>
{
public static readonly long[] Value=A040908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040908.Bytes);
public long this[int i]=>Value[i];

public static A040908Inst Instance=new A040908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040925
{
public static readonly long[] Value={ 30L,1L,11L,2L,1L,1L,1L,1L,7L,8L,1L,2L,2L,1L,2L,1L,14L,1L,2L,1L,2L,2L,1L,8L,7L,1L,1L,1L,1L,2L,11L,1L,60L,1L,11L,2L,1L,1L,1L,1L,7L,8L,1L,2L,2L,1L,2L,1L,14L,1L,2L,1L,2L,2L,1L,8L,7L,1L,1L,1L,1L,2L,11L,1L,60L,1L,11L,2L,1L,1L,1L,1L,7L,8L,1L,2L,2L,1L,2L,1L,14L,1L,2L,1L,2L,2L,1L,8L };
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
public class A040925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040925Inst : IEnumerable<long>
{
public static readonly long[] Value=A040925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040925.Bytes);
public long this[int i]=>Value[i];

public static A040925Inst Instance=new A040925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040926
{
public static readonly long[] Value={ 30L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L };
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
public class A040926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040926Inst : IEnumerable<long>
{
public static readonly long[] Value=A040926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040926.Bytes);
public long this[int i]=>Value[i];

public static A040926Inst Instance=new A040926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040927
{
public static readonly long[] Value={ 30L,1L,19L,1L,1L,1L,6L,4L,1L,1L,1L,1L,2L,1L,4L,1L,9L,2L,30L,2L,9L,1L,4L,1L,2L,1L,1L,1L,1L,4L,6L,1L,1L,1L,19L,1L,60L,1L,19L,1L,1L,1L,6L,4L,1L,1L,1L,1L,2L,1L,4L,1L,9L,2L,30L,2L,9L,1L,4L,1L,2L,1L,1L,1L,1L,4L,6L,1L,1L,1L,19L,1L,60L,1L,19L,1L,1L,1L,6L,4L,1L,1L,1L,1L,2L,1L,4L,1L,9L };
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
public class A040927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040927Inst : IEnumerable<long>
{
public static readonly long[] Value=A040927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040927.Bytes);
public long this[int i]=>Value[i];

public static A040927Inst Instance=new A040927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040928
{
public static readonly long[] Value={ 30L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L };
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
public class A040928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040928Inst : IEnumerable<long>
{
public static readonly long[] Value=A040928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040928.Bytes);
public long this[int i]=>Value[i];

public static A040928Inst Instance=new A040928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040929
{
public static readonly long[] Value={ 30L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L };
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
public class A040929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040929Inst : IEnumerable<long>
{
public static readonly long[] Value=A040929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040929.Bytes);
public long this[int i]=>Value[i];

public static A040929Inst Instance=new A040929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040930
{
public static readonly long[] Value={ 31L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L };
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
public class A040930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040930Inst : IEnumerable<long>
{
public static readonly long[] Value=A040930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040930.Bytes);
public long this[int i]=>Value[i];

public static A040930Inst Instance=new A040930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040931
{
public static readonly long[] Value={ 31L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L };
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
public class A040931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040931Inst : IEnumerable<long>
{
public static readonly long[] Value=A040931.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040931.Bytes);
public long this[int i]=>Value[i];

public static A040931Inst Instance=new A040931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040932
{
public static readonly long[] Value={ 31L,20L,1L,2L,6L,1L,1L,3L,1L,1L,1L,1L,11L,1L,4L,3L,1L,14L,1L,3L,4L,1L,11L,1L,1L,1L,1L,3L,1L,1L,6L,2L,1L,20L,62L,20L,1L,2L,6L,1L,1L,3L,1L,1L,1L,1L,11L,1L,4L,3L,1L,14L,1L,3L,4L,1L,11L,1L,1L,1L,1L,3L,1L,1L,6L,2L,1L,20L,62L,20L,1L,2L,6L,1L,1L,3L,1L,1L,1L,1L,11L,1L,4L,3L,1L,14L };
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
public class A040932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040932Inst : IEnumerable<long>
{
public static readonly long[] Value=A040932.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040932.Bytes);
public long this[int i]=>Value[i];

public static A040932Inst Instance=new A040932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040933
{
public static readonly long[] Value={ 31L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L };
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
public class A040933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040933Inst : IEnumerable<long>
{
public static readonly long[] Value=A040933.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040933.Bytes);
public long this[int i]=>Value[i];

public static A040933Inst Instance=new A040933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040934
{
public static readonly long[] Value={ 31L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L };
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
public class A040934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040934Inst : IEnumerable<long>
{
public static readonly long[] Value=A040934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040934.Bytes);
public long this[int i]=>Value[i];

public static A040934Inst Instance=new A040934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040935
{
public static readonly long[] Value={ 31L,10L,2L,1L,6L,4L,3L,2L,2L,1L,1L,8L,3L,2L,1L,20L,31L,20L,1L,2L,3L,8L,1L,1L,2L,2L,3L,4L,6L,1L,2L,10L,62L,10L,2L,1L,6L,4L,3L,2L,2L,1L,1L,8L,3L,2L,1L,20L,31L,20L,1L,2L,3L,8L,1L,1L,2L,2L,3L,4L,6L,1L,2L,10L,62L,10L,2L,1L,6L,4L,3L,2L,2L,1L,1L,8L,3L,2L,1L,20L,31L,20L,1L,2L,3L };
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
public class A040935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040935Inst : IEnumerable<long>
{
public static readonly long[] Value=A040935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040935.Bytes);
public long this[int i]=>Value[i];

public static A040935Inst Instance=new A040935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040936
{
public static readonly long[] Value={ 31L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L };
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
public class A040936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040936Inst : IEnumerable<long>
{
public static readonly long[] Value=A040936.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040936.Bytes);
public long this[int i]=>Value[i];

public static A040936Inst Instance=new A040936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040937
{
public static readonly long[] Value={ 31L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L };
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
public class A040937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040937Inst : IEnumerable<long>
{
public static readonly long[] Value=A040937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040937.Bytes);
public long this[int i]=>Value[i];

public static A040937Inst Instance=new A040937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040938
{
public static readonly long[] Value={ 31L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L };
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
public class A040938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040938Inst : IEnumerable<long>
{
public static readonly long[] Value=A040938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040938.Bytes);
public long this[int i]=>Value[i];

public static A040938Inst Instance=new A040938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040939
{
public static readonly long[] Value={ 31L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L,4L,6L,62L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L,4L,6L,62L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L,4L,6L,62L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L };
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
public class A040939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040939Inst : IEnumerable<long>
{
public static readonly long[] Value=A040939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040939.Bytes);
public long this[int i]=>Value[i];

public static A040939Inst Instance=new A040939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040940
{
public static readonly long[] Value={ 31L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L };
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
public class A040940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040940Inst : IEnumerable<long>
{
public static readonly long[] Value=A040940.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040940.Bytes);
public long this[int i]=>Value[i];

public static A040940Inst Instance=new A040940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040957
{
public static readonly long[] Value={ 31L,2L,4L,2L,1L,11L,1L,8L,15L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,15L,8L,1L,11L,1L,2L,4L,2L,62L,2L,4L,2L,1L,11L,1L,8L,15L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,15L,8L,1L,11L,1L,2L,4L,2L,62L,2L,4L,2L,1L,11L,1L,8L,15L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L };
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
public class A040957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040957Inst : IEnumerable<long>
{
public static readonly long[] Value=A040957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040957.Bytes);
public long this[int i]=>Value[i];

public static A040957Inst Instance=new A040957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040958
{
public static readonly long[] Value={ 31L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L,62L,2L,6L,2L };
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
public class A040958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040958Inst : IEnumerable<long>
{
public static readonly long[] Value=A040958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040958.Bytes);
public long this[int i]=>Value[i];

public static A040958Inst Instance=new A040958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040959
{
public static readonly long[] Value={ 31L,2L,12L,10L,2L,2L,2L,1L,1L,2L,6L,1L,1L,1L,1L,3L,1L,8L,4L,1L,2L,1L,2L,3L,1L,4L,1L,20L,6L,4L,31L,4L,6L,20L,1L,4L,1L,3L,2L,1L,2L,1L,4L,8L,1L,3L,1L,1L,1L,1L,6L,2L,1L,1L,2L,2L,2L,10L,12L,2L,62L,2L,12L,10L,2L,2L,2L,1L,1L,2L,6L,1L,1L,1L,1L,3L,1L,8L,4L,1L,2L,1L,2L,3L,1L,4L,1L,20L };
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
public class A040959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040959Inst : IEnumerable<long>
{
public static readonly long[] Value=A040959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040959.Bytes);
public long this[int i]=>Value[i];

public static A040959Inst Instance=new A040959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040960
{
public static readonly long[] Value={ 31L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L,2L,62L };
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
public class A040960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040960Inst : IEnumerable<long>
{
public static readonly long[] Value=A040960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040960.Bytes);
public long this[int i]=>Value[i];

public static A040960Inst Instance=new A040960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040961
{
public static readonly long[] Value={ 31L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L,20L,1L,1L,62L,1L,1L };
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
public class A040961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040961Inst : IEnumerable<long>
{
public static readonly long[] Value=A040961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040961.Bytes);
public long this[int i]=>Value[i];

public static A040961Inst Instance=new A040961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040962
{
public static readonly long[] Value={ 31L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L,8L,1L,1L,62L,1L,1L };
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
public class A040962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040962Inst : IEnumerable<long>
{
public static readonly long[] Value=A040962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040962.Bytes);
public long this[int i]=>Value[i];

public static A040962Inst Instance=new A040962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040963
{
public static readonly long[] Value={ 31L,1L,1L,5L,4L,3L,12L,3L,4L,5L,1L,1L,62L,1L,1L,5L,4L,3L,12L,3L,4L,5L,1L,1L,62L,1L,1L,5L,4L,3L,12L,3L,4L,5L,1L,1L,62L,1L,1L,5L,4L,3L,12L,3L,4L,5L,1L,1L,62L,1L,1L,5L,4L,3L,12L,3L,4L,5L,1L,1L,62L,1L,1L,5L,4L,3L,12L,3L,4L,5L,1L,1L,62L,1L,1L,5L,4L,3L,12L,3L,4L,5L,1L,1L,62L,1L,1L };
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
public class A040963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040963Inst : IEnumerable<long>
{
public static readonly long[] Value=A040963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040963.Bytes);
public long this[int i]=>Value[i];

public static A040963Inst Instance=new A040963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040964
{
public static readonly long[] Value={ 31L,1L,1L,3L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,3L,1L,1L,62L,1L,1L,3L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,3L,1L,1L,62L,1L,1L,3L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,3L,1L,1L,62L,1L,1L,3L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,3L,1L,1L,62L,1L,1L,3L,1L,2L,2L,1L,1L,1L,4L,1L };
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
public class A040964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040964Inst : IEnumerable<long>
{
public static readonly long[] Value=A040964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040964.Bytes);
public long this[int i]=>Value[i];

public static A040964Inst Instance=new A040964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040965
{
public static readonly long[] Value={ 31L,1L,1L,2L,1L,4L,1L,1L,4L,1L,2L,1L,1L,62L,1L,1L,2L,1L,4L,1L,1L,4L,1L,2L,1L,1L,62L,1L,1L,2L,1L,4L,1L,1L,4L,1L,2L,1L,1L,62L,1L,1L,2L,1L,4L,1L,1L,4L,1L,2L,1L,1L,62L,1L,1L,2L,1L,4L,1L,1L,4L,1L,2L,1L,1L,62L,1L,1L,2L,1L,4L,1L,1L,4L,1L,2L,1L,1L,62L,1L,1L,2L,1L,4L,1L,1L,4L,1L,2L,1L };
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
public class A040965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040965Inst : IEnumerable<long>
{
public static readonly long[] Value=A040965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040965.Bytes);
public long this[int i]=>Value[i];

public static A040965Inst Instance=new A040965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040966
{
public static readonly long[] Value={ 31L,1L,1L,2L,4L,8L,1L,3L,1L,30L,1L,3L,1L,8L,4L,2L,1L,1L,62L,1L,1L,2L,4L,8L,1L,3L,1L,30L,1L,3L,1L,8L,4L,2L,1L,1L,62L,1L,1L,2L,4L,8L,1L,3L,1L,30L,1L,3L,1L,8L,4L,2L,1L,1L,62L,1L,1L,2L,4L,8L,1L,3L,1L,30L,1L,3L,1L,8L,4L,2L,1L,1L,62L,1L,1L,2L,4L,8L,1L,3L,1L,30L,1L,3L,1L,8L,4L,2L,1L };
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
public class A040966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040966Inst : IEnumerable<long>
{
public static readonly long[] Value=A040966.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040966.Bytes);
public long this[int i]=>Value[i];

public static A040966Inst Instance=new A040966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040967
{
public static readonly long[] Value={ 31L,1L,1L,1L,1L,5L,6L,1L,5L,2L,5L,1L,6L,5L,1L,1L,1L,1L,62L,1L,1L,1L,1L,5L,6L,1L,5L,2L,5L,1L,6L,5L,1L,1L,1L,1L,62L,1L,1L,1L,1L,5L,6L,1L,5L,2L,5L,1L,6L,5L,1L,1L,1L,1L,62L,1L,1L,1L,1L,5L,6L,1L,5L,2L,5L,1L,6L,5L,1L,1L,1L,1L,62L,1L,1L,1L,1L,5L,6L,1L,5L,2L,5L,1L,6L,5L,1L,1L,1L,1L,62L };
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
public class A040967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040967Inst : IEnumerable<long>
{
public static readonly long[] Value=A040967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040967.Bytes);
public long this[int i]=>Value[i];

public static A040967Inst Instance=new A040967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040968
{
public static readonly long[] Value={ 31L,1L,1L,1L,1L,1L,6L,2L,2L,15L,2L,2L,6L,1L,1L,1L,1L,1L,62L,1L,1L,1L,1L,1L,6L,2L,2L,15L,2L,2L,6L,1L,1L,1L,1L,1L,62L,1L,1L,1L,1L,1L,6L,2L,2L,15L,2L,2L,6L,1L,1L,1L,1L,1L,62L,1L,1L,1L,1L,1L,6L,2L,2L,15L,2L,2L,6L,1L,1L,1L,1L,1L,62L,1L,1L,1L,1L,1L,6L,2L,2L,15L,2L,2L,6L,1L,1L,1L,1L };
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
public class A040968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040968Inst : IEnumerable<long>
{
public static readonly long[] Value=A040968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040968.Bytes);
public long this[int i]=>Value[i];

public static A040968Inst Instance=new A040968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040969
{
public static readonly long[] Value={ 31L,41L,61L,71L,101L,131L,151L,181L,191L,241L,251L,281L,311L,331L,401L,421L,461L,491L,521L,541L,571L,601L,631L,641L,661L,691L,701L,751L,761L,821L,881L,911L,971L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L };
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
public class A040969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040969Inst : IEnumerable<long>
{
public static readonly long[] Value=A040969.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040969.Bytes);
public long this[int i]=>Value[i];

public static A040969Inst Instance=new A040969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040970
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,61L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,271L,277L,283L };
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
public class A040970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040970Inst : IEnumerable<long>
{
public static readonly long[] Value=A040970.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040970.Bytes);
public long this[int i]=>Value[i];

public static A040970Inst Instance=new A040970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040971
{
public static readonly long[] Value={ 11L,31L,41L,71L,101L,131L,151L,181L,191L,211L,241L,251L,281L,401L,421L,431L,491L,521L,541L,571L,631L,641L,661L,691L,701L,751L,811L,821L,881L,911L,941L,991L,1031L,1051L,1171L,1181L,1201L,1231L,1291L,1301L,1321L };
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
public class A040971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040971Inst : IEnumerable<long>
{
public static readonly long[] Value=A040971.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040971.Bytes);
public long this[int i]=>Value[i];

public static A040971Inst Instance=new A040971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040972
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,41L,43L,47L,53L,59L,61L,67L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,257L,263L };
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
public class A040972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040972Inst : IEnumerable<long>
{
public static readonly long[] Value=A040972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040972.Bytes);
public long this[int i]=>Value[i];

public static A040972Inst Instance=new A040972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040989
{
public static readonly long[] Value={ 31L,41L,61L,71L,101L,131L,151L,181L,191L,211L,251L,271L,281L,311L,331L,421L,431L,491L,521L,541L,571L,601L,631L,641L,661L,691L,701L,751L,761L,821L,941L,971L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1201L };
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
public class A040989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040989Inst : IEnumerable<long>
{
public static readonly long[] Value=A040989.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040989.Bytes);
public long this[int i]=>Value[i];

public static A040989Inst Instance=new A040989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040990
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,71L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,151L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,271L };
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
public class A040990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040990Inst : IEnumerable<long>
{
public static readonly long[] Value=A040990.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040990.Bytes);
public long this[int i]=>Value[i];

public static A040990Inst Instance=new A040990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040991
{
public static readonly long[] Value={ 31L,41L,61L,101L,131L,181L,191L,211L,241L,251L,281L,311L,401L,421L,431L,491L,521L,541L,571L,601L,631L,641L,661L,751L,811L,821L,881L,911L,941L,971L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1181L,1201L,1231L,1291L,1301L,1321L,1361L,1381L,1451L,1471L,1481L };
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
public class A040991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040991Inst : IEnumerable<long>
{
public static readonly long[] Value=A040991.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040991.Bytes);
public long this[int i]=>Value[i];

public static A040991Inst Instance=new A040991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040992
{
public static readonly long[] Value={ 2L,17L,23L,31L,41L,47L,71L,89L,113L,127L,137L,167L,191L,223L,233L,239L,257L,263L,281L,311L,353L,359L,383L,401L,431L,433L,439L,449L,457L,479L,503L,521L,569L,593L,599L,601L,617L,641L,647L,719L,727L,743L,761L,809L,839L,857L,863L,881L,887L,911L,919L,929L,953L };
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
public class A040992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040992Inst : IEnumerable<long>
{
public static readonly long[] Value=A040992.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040992.Bytes);
public long this[int i]=>Value[i];

public static A040992Inst Instance=new A040992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040993
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,29L,37L,43L,53L,59L,61L,67L,73L,79L,83L,97L,101L,103L,107L,109L,131L,139L,149L,151L,157L,163L,173L,179L,181L,193L,197L,199L,211L,227L,229L,241L,251L,269L,271L,277L,283L,293L,307L,313L,317L,331L,337L,347L,349L,367L,373L,379L,389L,397L,409L };
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
public class A040993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040993Inst : IEnumerable<long>
{
public static readonly long[] Value=A040993.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040993.Bytes);
public long this[int i]=>Value[i];

public static A040993Inst Instance=new A040993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040994
{
public static readonly long[] Value={ 2L,3L,11L,23L,47L,59L,61L,71L,73L,83L,107L,131L,167L,179L,191L,193L,227L,239L,251L,263L,311L,347L,359L,383L,419L,431L,443L,467L,479L,491L,503L,563L,577L,587L,599L,613L,647L,659L,661L,683L,719L,743L,757L,827L,839L };
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
public class A040994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040994Inst : IEnumerable<long>
{
public static readonly long[] Value=A040994.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040994.Bytes);
public long this[int i]=>Value[i];

public static A040994Inst Instance=new A040994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040995
{
public static readonly long[] Value={ 5L,7L,13L,17L,19L,29L,31L,37L,41L,43L,53L,67L,79L,89L,97L,101L,103L,109L,113L,127L,137L,139L,149L,151L,157L,163L,173L,181L,197L,199L,211L,223L,229L,233L,241L,257L,269L,271L,277L,281L,283L,293L,307L,313L,317L,331L,337L,349L,353L,367L,373L };
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
public class A040995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040995Inst : IEnumerable<long>
{
public static readonly long[] Value=A040995.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040995.Bytes);
public long this[int i]=>Value[i];

public static A040995Inst Instance=new A040995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040996
{
public static readonly BigInteger[] Value={ 1L,6L,120L,32640L,2147450880L,9223372034707292160L,BigInteger.Parse("170141183460469231722463931679029329920"),BigInteger.Parse("57896044618658097711785492504343953926464851149359812787997104700240680714240") };
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
public class A040996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A040996.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A040996Inst Instance=new A040996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040997
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,0L,1L,2L,3L,4L,5L,6L,7L };
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
public class A040997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040997Inst : IEnumerable<long>
{
public static readonly long[] Value=A040997.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040997.Bytes);
public long this[int i]=>Value[i];

public static A040997Inst Instance=new A040997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040998
{
public static readonly long[] Value={ 2L,5L,11L,29L,41L,59L,71L,89L,101L,131L,149L,179L,181L,191L,199L,211L,239L,241L,251L,269L,281L,311L,359L,379L,389L,401L,409L,419L,431L,449L,461L,479L,491L,509L,521L,569L,599L,631L,641L,659L,691L,701L,719L,739L };
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
public class A040998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040998Inst : IEnumerable<long>
{
public static readonly long[] Value=A040998.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040998.Bytes);
public long this[int i]=>Value[i];

public static A040998Inst Instance=new A040998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040999
{
public static readonly long[] Value={ 3L,7L,13L,17L,19L,23L,31L,37L,43L,47L,53L,61L,67L,73L,79L,83L,97L,103L,107L,109L,113L,127L,137L,139L,151L,157L,163L,167L,173L,193L,197L,223L,227L,229L,233L,257L,263L,271L,277L,283L,293L,307L,313L,317L,331L,337L,347L,349L,353L,367L,373L,383L,397L };
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
public class A040999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040999Inst : IEnumerable<long>
{
public static readonly long[] Value=A040999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040999.Bytes);
public long this[int i]=>Value[i];

public static A040999Inst Instance=new A040999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041000
{
public static readonly long[] Value={ 2L,3L,5L,7L,0L,2L,6L,8L,1L,7L,2L,4L,3L,1L,3L,2L,4L,5L,1L,6L,4L,2L,5L,1L,2L,0L,2L,6L,8L,1L,4L,1L,3L,5L,4L,3L,1L,2L,0L,3L,1L,6L,7L,5L,1L,1L,0L,1L,3L,5L,2L,4L,1L,2L,0L,1L,1L,4L,2L,5L,3L,4L,4L,1L,1L,3L,1L,1L,0L,2L,1L,1L,2L,1L,1L,2L,2L,1L,3L,5L,4L,1L,0L,2L,2L,3L,1L,2L,1L,1L,3L,2L,3L,4L,4L,2L,4L,2L,0L,0L,2L,3L,2L,2L,1L,5L };
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
public class A041000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041000Inst : IEnumerable<long>
{
public static readonly long[] Value=A041000.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041000.Bytes);
public long this[int i]=>Value[i];

public static A041000Inst Instance=new A041000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041001
{
public static readonly long[] Value={ 1L,14L,125L,906L,5810L,34364L,191901L,1026610L,5312230L,26767940L,131990066L,639210404L,3048892740L,14354652152L,66828135005L,308078809794L,1408022619806L,6385966846580L,28765327498278L,128777533131500L };
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
public class A041001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041001Inst : IEnumerable<long>
{
public static readonly long[] Value=A041001.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041001.Bytes);
public long this[int i]=>Value[i];

public static A041001Inst Instance=new A041001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041002
{
public static readonly long[] Value={ 1L,3L,4L,7L,14L,18L,19L,20L,22L,23L,25L,26L,28L,29L,30L,31L,35L,36L,37L,38L,40L,41L,42L,45L,48L,49L,50L,52L };
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
public class A041002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041002Inst : IEnumerable<long>
{
public static readonly long[] Value=A041002.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041002.Bytes);
public long this[int i]=>Value[i];

public static A041002Inst Instance=new A041002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041003
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,6L,7L,8L,10L,12L,14L,16L,20L,23L,26L,30L,36L,41L,47L,55L,64L,73L,83L,96L,111L,125L,144L,165L,187L,211L,241L,272L,306L,346L,391L,439L,493L,553L,622L,695L,779L,871L,974L,1086L,1211L,1348L,1502L,1671L };
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
public class A041003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041003Inst : IEnumerable<long>
{
public static readonly long[] Value=A041003.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041003.Bytes);
public long this[int i]=>Value[i];

public static A041003Inst Instance=new A041003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041004
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L };
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
public class A041004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041004Inst : IEnumerable<long>
{
public static readonly long[] Value=A041004.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041004.Bytes);
public long this[int i]=>Value[i];

public static A041004Inst Instance=new A041004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041021
{
public static readonly long[] Value={ 1L,1L,3L,4L,27L,31L,89L,120L,809L,929L,2667L,3596L,24243L,27839L,79921L,107760L,726481L,834241L,2394963L,3229204L,21770187L,24999391L,71768969L,96768360L,652379129L,749147489L,2150674107L,2899821596L };
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
public class A041021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041021Inst : IEnumerable<long>
{
public static readonly long[] Value=A041021.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041021.Bytes);
public long this[int i]=>Value[i];

public static A041021Inst Instance=new A041021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041022
{
public static readonly long[] Value={ 3L,4L,27L,31L,213L,244L,1677L,1921L,13203L,15124L,103947L,119071L,818373L,937444L,6443037L,7380481L,50725923L,58106404L,399364347L,457470751L,3144188853L,3601659604L,24754146477L,28355806081L };
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
public class A041022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041022Inst : IEnumerable<long>
{
public static readonly long[] Value=A041022.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041022.Bytes);
public long this[int i]=>Value[i];

public static A041022Inst Instance=new A041022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041023
{
public static readonly long[] Value={ 1L,1L,7L,8L,55L,63L,433L,496L,3409L,3905L,26839L,30744L,211303L,242047L,1663585L,1905632L,13097377L,15003009L,103115431L,118118440L,811826071L,929944511L,6391493137L,7321437648L,50320119025L };
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
public class A041023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041023Inst : IEnumerable<long>
{
public static readonly long[] Value=A041023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041023.Bytes);
public long this[int i]=>Value[i];

public static A041023Inst Instance=new A041023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041024
{
public static readonly long[] Value={ 4L,33L,268L,2177L,17684L,143649L,1166876L,9478657L,76996132L,625447713L,5080577836L,41270070401L,335241141044L,2723199198753L,22120834731068L,179689877047297L,1459639851109444L,11856808685922849L,96314109338492236L };
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
public class A041024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041024Inst : IEnumerable<long>
{
public static readonly long[] Value=A041024.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041024.Bytes);
public long this[int i]=>Value[i];

public static A041024Inst Instance=new A041024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041025
{
public static readonly long[] Value={ 1L,8L,65L,528L,4289L,34840L,283009L,2298912L,18674305L,151693352L,1232221121L,10009462320L,81307919681L,660472819768L,5365090477825L,43581196642368L,354014663616769L,2875698505576520L,23359602708228929L,189752520171407952L,1541379764079492545L };
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
public class A041025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041025Inst : IEnumerable<long>
{
public static readonly long[] Value=A041025.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041025.Bytes);
public long this[int i]=>Value[i];

public static A041025Inst Instance=new A041025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041026
{
public static readonly long[] Value={ 4L,17L,140L,577L,4756L,19601L,161564L,665857L,5488420L,22619537L,186444716L,768398401L,6333631924L,26102926097L,215157040700L,886731088897L,7309005751876L,30122754096401L,248291038523084L };
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
public class A041026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041026Inst : IEnumerable<long>
{
public static readonly long[] Value=A041026.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041026.Bytes);
public long this[int i]=>Value[i];

public static A041026Inst Instance=new A041026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041027
{
public static readonly long[] Value={ 1L,4L,33L,136L,1121L,4620L,38081L,156944L,1293633L,5331476L,43945441L,181113240L,1492851361L,6152518684L,50713000833L,209004522016L,1722749176961L,7100001229860L,58522759015841L,241191037293224L };
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
public class A041027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041027Inst : IEnumerable<long>
{
public static readonly long[] Value=A041027.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041027.Bytes);
public long this[int i]=>Value[i];

public static A041027Inst Instance=new A041027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041028
{
public static readonly long[] Value={ 4L,9L,13L,48L,61L,170L,1421L,3012L,4433L,16311L,20744L,57799L,483136L,1024071L,1507207L,5545692L,7052899L,19651490L,164264819L,348181128L,512445947L,1885518969L,2397964916L,6681448801L,55849555324L };
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
public class A041028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041028Inst : IEnumerable<long>
{
public static readonly long[] Value=A041028.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041028.Bytes);
public long this[int i]=>Value[i];

public static A041028Inst Instance=new A041028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041029
{
public static readonly long[] Value={ 1L,2L,3L,11L,14L,39L,326L,691L,1017L,3742L,4759L,13260L,110839L,234938L,345777L,1272269L,1618046L,4508361L,37684934L,79878229L,117563163L,432567718L,550130881L,1532829480L,12812766721L,27158362922L };
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
public class A041029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041029Inst : IEnumerable<long>
{
public static readonly long[] Value=A041029.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041029.Bytes);
public long this[int i]=>Value[i];

public static A041029Inst Instance=new A041029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041030
{
public static readonly long[] Value={ 4L,9L,76L,161L,1364L,2889L,24476L,51841L,439204L,930249L,7881196L,16692641L,141422324L,299537289L,2537720636L,5374978561L,45537549124L,96450076809L,817138163596L,1730726404001L,14662949395604L };
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
public class A041030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041030Inst : IEnumerable<long>
{
public static readonly long[] Value=A041030.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041030.Bytes);
public long this[int i]=>Value[i];

public static A041030Inst Instance=new A041030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041031
{
public static readonly long[] Value={ 1L,2L,17L,36L,305L,646L,5473L,11592L,98209L,208010L,1762289L,3732588L,31622993L,66978574L,567451585L,1201881744L,10182505537L,21566892818L,182717648081L,387002188980L,3278735159921L,6944472508822L };
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
public class A041031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041031Inst : IEnumerable<long>
{
public static readonly long[] Value=A041031.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041031.Bytes);
public long this[int i]=>Value[i];

public static A041031Inst Instance=new A041031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041032
{
public static readonly long[] Value={ 4L,5L,9L,23L,32L,55L,472L,527L,999L,2525L,3524L,6049L,51916L,57965L,109881L,277727L,387608L,665335L,5710288L,6375623L,12085911L,30547445L,42633356L,73180801L,628079764L,701260565L,1329340329L,3359941223L };
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
public class A041032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041032Inst : IEnumerable<long>
{
public static readonly long[] Value=A041032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041032.Bytes);
public long this[int i]=>Value[i];

public static A041032Inst Instance=new A041032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041033
{
public static readonly long[] Value={ 1L,1L,2L,5L,7L,12L,103L,115L,218L,551L,769L,1320L,11329L,12649L,23978L,60605L,84583L,145188L,1246087L,1391275L,2637362L,6665999L,9303361L,15969360L,137058241L,153027601L,290085842L,733199285L,1023285127L };
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
public class A041033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041033Inst : IEnumerable<long>
{
public static readonly long[] Value=A041033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041033.Bytes);
public long this[int i]=>Value[i];

public static A041033Inst Instance=new A041033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041034
{
public static readonly long[] Value={ 4L,5L,14L,61L,136L,197L,1712L,1909L,5530L,24029L,53588L,77617L,674524L,752141L,2178806L,9467365L,21113536L,30580901L,265760744L,296341645L,858444034L,3730117781L,8318679596L,12048797377L,104709058612L };
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
public class A041034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041034Inst : IEnumerable<long>
{
public static readonly long[] Value=A041034.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041034.Bytes);
public long this[int i]=>Value[i];

public static A041034Inst Instance=new A041034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041035
{
public static readonly long[] Value={ 1L,1L,3L,13L,29L,42L,365L,407L,1179L,5123L,11425L,16548L,143809L,160357L,464523L,2018449L,4501421L,6519870L,56660381L,63180251L,183020883L,795263783L,1773548449L,2568812232L,22324046305L,24892858537L };
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
public class A041035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041035Inst : IEnumerable<long>
{
public static readonly long[] Value=A041035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A041035.Bytes);
public long this[int i]=>Value[i];

public static A041035Inst Instance=new A041035Inst();

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