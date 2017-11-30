using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A023120
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,1L,6L,3L,5L,2L,4L,1L,6L,3L,5L,2L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L };
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
public class A023120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023120Inst : IEnumerable<long>
{
public static readonly long[] Value=A023120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023120.Bytes);
public long this[int i]=>Value[i];

public static A023120Inst Instance=new A023120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023121
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,6L,2L,3L,4L,5L,1L,6L,2L,7L,3L,4L,5L,1L,6L,2L,7L,3L,8L,4L,5L,1L,6L,2L,7L,3L,8L,4L,9L,5L,1L,6L,2L,7L,3L,8L,4L,9L,5L,1L,10L,6L,2L,7L,3L,8L,4L,9L,5L,1L,10L,6L,2L,11L,7L,3L,8L,4L,9L,5L,1L,10L,6L,2L,11L,7L,3L,12L,8L,4L,9L,5L,1L,10L,6L,2L };
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
public class A023121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023121Inst : IEnumerable<long>
{
public static readonly long[] Value=A023121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023121.Bytes);
public long this[int i]=>Value[i];

public static A023121Inst Instance=new A023121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023122
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,7L,1L,6L,5L,4L,3L,8L,2L,7L,1L,6L,5L,4L,9L,3L,8L,2L,7L,1L,6L,5L,10L,4L,9L,3L,8L,2L,7L,1L,6L,11L,5L,10L,4L,9L,3L,8L,2L,7L,12L,1L,6L,11L,5L,10L,4L,9L,3L,8L,13L,2L,7L,12L,1L,6L,11L,5L,10L,4L,9L,14L,3L,8L,13L,2L,7L,12L,1L,6L,11L,5L,10L };
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
public class A023122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023122Inst : IEnumerable<long>
{
public static readonly long[] Value=A023122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023122.Bytes);
public long this[int i]=>Value[i];

public static A023122Inst Instance=new A023122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023123
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,2L,5L,3L,6L,1L,4L,7L,2L,5L,8L,3L,6L,9L,1L,4L,7L,10L,2L,5L,8L,11L,3L,6L,9L,1L,12L,4L,7L,10L,2L,13L,5L,8L,11L,3L,14L,6L,9L,1L,12L,4L,15L,7L,10L,2L,13L,5L,16L,8L,11L,3L,14L,6L,17L,9L,1L,12L,4L,15L,7L,18L,10L,2L,13L,5L,16L,8L,19L,11L,3L,14L,6L,17L,9L,20L,1L,12L,4L,15L,7L,18L,10L,21L,2L };
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
public class A023123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023123Inst : IEnumerable<long>
{
public static readonly long[] Value=A023123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023123.Bytes);
public long this[int i]=>Value[i];

public static A023123Inst Instance=new A023123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023124
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,5L,1L,4L,3L,2L,5L,1L,4L,3L,2L,5L,1L,4L,3L,6L,2L,5L,1L,4L,3L,6L,2L,5L };
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
public class A023124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023124Inst : IEnumerable<long>
{
public static readonly long[] Value=A023124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023124.Bytes);
public long this[int i]=>Value[i];

public static A023124Inst Instance=new A023124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023125
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,1L,9L,2L,10L,3L,11L,4L,12L,5L,13L,6L,14L,7L,15L,8L,1L,16L,9L,2L,17L,10L,3L,18L,11L,4L,19L,12L,5L,20L,13L,6L,21L,14L,7L,22L,15L,8L,23L,1L,16L,9L,24L,2L,17L,10L,25L,3L,18L,11L,26L,4L,19L,12L,27L,5L,20L,13L,28L,6L,21L,14L,29L,7L,22L,15L,30L,8L,23L,1L,16L };
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
public class A023125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023125Inst : IEnumerable<long>
{
public static readonly long[] Value=A023125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023125.Bytes);
public long this[int i]=>Value[i];

public static A023125Inst Instance=new A023125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023126
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,1L,4L,2L,5L,3L,1L,4L,2L,5L,3L,1L };
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
public class A023126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023126Inst : IEnumerable<long>
{
public static readonly long[] Value=A023126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023126.Bytes);
public long this[int i]=>Value[i];

public static A023126Inst Instance=new A023126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023127
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,2L,5L,3L,1L,6L,4L,2L,7L,5L,3L,8L,1L,6L,4L,9L,2L,7L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,13L,1L,6L,11L,4L,9L,14L,2L,7L,12L,5L,10L,15L,3L,8L,13L,1L,6L,11L,16L,4L,9L,14L,2L,7L,12L,17L,5L,10L,15L,3L,8L,13L,18L,1L,6L,11L,16L,4L,9L,14L,19L,2L,7L,12L,17L,5L,10L };
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
public class A023127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023127Inst : IEnumerable<long>
{
public static readonly long[] Value=A023127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023127.Bytes);
public long this[int i]=>Value[i];

public static A023127Inst Instance=new A023127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023128
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,1L,4L,2L,5L,3L,1L,4L,2L,5L,3L,1L,4L,2L,5L,3L,1L,6L,4L,2L,5L,3L,1L,6L,4L,2L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,8L,6L,4L,2L,7L,5L,3L,1L,8L,6L,4L,2L,7L,5L,3L,1L };
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
public class A023128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023128Inst : IEnumerable<long>
{
public static readonly long[] Value=A023128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023128.Bytes);
public long this[int i]=>Value[i];

public static A023128Inst Instance=new A023128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023129
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,9L,1L,6L,3L,8L,5L,10L,2L,7L,4L,9L,1L,6L,11L,3L,8L,5L,10L,2L,7L,12L,4L,9L,1L,6L,11L,3L,8L,13L,5L,10L,2L,7L,12L,4L,9L,14L,1L,6L,11L,3L,8L,13L,5L,10L,15L,2L,7L,12L,4L,9L,14L,1L,6L,11L,16L,3L,8L,13L,5L,10L,15L,2L };
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
public class A023129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023129Inst : IEnumerable<long>
{
public static readonly long[] Value=A023129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023129.Bytes);
public long this[int i]=>Value[i];

public static A023129Inst Instance=new A023129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023130
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,1L,6L,3L,5L,2L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,9L,6L,3L,8L,5L,2L,7L,4L,1L,9L,6L,3L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,8L,5L,2L,10L,7L,4L,1L };
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
public class A023130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023130Inst : IEnumerable<long>
{
public static readonly long[] Value=A023130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023130.Bytes);
public long this[int i]=>Value[i];

public static A023130Inst Instance=new A023130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023131
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,2L,5L,3L,6L,1L,4L,7L,2L,5L,8L,3L,6L,9L,1L,4L,7L,10L,2L,5L,8L,11L,3L,6L,9L,12L,1L,4L,7L,10L,13L,2L,5L,8L,11L,14L,3L,6L,9L,12L,15L,1L,4L,7L,10L,13L,16L,2L,5L,8L,11L,14L,17L,3L,6L,9L,12L,15L,1L,18L,4L,7L,10L,13L,16L,2L,19L,5L,8L,11L,14L,17L,3L,20L,6L,9L,12L,15L,1L,18L,4L };
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
public class A023131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023131Inst : IEnumerable<long>
{
public static readonly long[] Value=A023131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023131.Bytes);
public long this[int i]=>Value[i];

public static A023131Inst Instance=new A023131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023132
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,7L,1L,6L,5L,4L,3L,2L,7L,1L,6L,5L,4L,3L,2L,7L,1L,6L,5L,4L,3L,8L,2L,7L,1L };
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
public class A023132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023132Inst : IEnumerable<long>
{
public static readonly long[] Value=A023132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023132.Bytes);
public long this[int i]=>Value[i];

public static A023132Inst Instance=new A023132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023245
{
public static readonly long[] Value={ 5L,11L,19L,31L,59L,61L,71L,101L,109L,151L,179L,239L,241L,269L,281L,389L,409L,439L,449L,521L,571L,641L,659L,719L,829L,911L,971L,1051L,1061L,1181L,1201L,1229L,1319L,1361L,1439L,1579L,1669L,1699L,1741L,1831L,1949L,2269L,2341L,2371L,2521L,2549L,2579L,2609L,2671L };
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
public class A023245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023245Inst : IEnumerable<long>
{
public static readonly long[] Value=A023245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023245.Bytes);
public long this[int i]=>Value[i];

public static A023245Inst Instance=new A023245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023246
{
public static readonly long[] Value={ 5L,7L,19L,29L,79L,89L,97L,127L,139L,167L,317L,337L,397L,419L,607L,659L,709L,877L,929L,1069L,1129L,1409L,1699L,1777L,2029L,2099L,2267L,2339L,2557L,2617L,2707L,2837L,2917L,2939L,3019L,3067L,3389L,3407L,3529L,3617L,3659L,3719L,4229L,4549L,4919L,5209L,5227L,5417L };
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
public class A023246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023246Inst : IEnumerable<long>
{
public static readonly long[] Value=A023246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023246.Bytes);
public long this[int i]=>Value[i];

public static A023246Inst Instance=new A023246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023247
{
public static readonly long[] Value={ 3L,5L,23L,59L,73L,79L,109L,179L,269L,373L,383L,389L,409L,439L,509L,599L,683L,709L,929L,983L,1019L,1129L,1193L,1409L,1423L,1453L,1663L,1699L,1879L,2039L,2053L,2069L,2579L,2753L,2963L,3049L,3169L,3203L,3259L,3719L,3769L,3833L,4799L,4973L,4993L,5303L,5443L,5483L };
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
public class A023247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023247Inst : IEnumerable<long>
{
public static readonly long[] Value=A023247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023247.Bytes);
public long this[int i]=>Value[i];

public static A023247Inst Instance=new A023247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023248
{
public static readonly long[] Value={ 3L,11L,13L,31L,41L,43L,53L,101L,113L,211L,223L,263L,283L,431L,433L,491L,521L,563L,571L,601L,631L,641L,673L,743L,811L,911L,1151L,1361L,1621L,1693L,1973L,2243L,2393L,3083L,3163L,3181L,3343L,3461L,3821L,3923L,4481L,4523L,4561L,4591L,4663L,4861L,4903L,5051L,5261L };
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
public class A023248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023248Inst : IEnumerable<long>
{
public static readonly long[] Value=A023248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023248.Bytes);
public long this[int i]=>Value[i];

public static A023248Inst Instance=new A023248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023249
{
public static readonly long[] Value={ 3L,7L,11L,17L,19L,47L,67L,109L,149L,151L,199L,227L,233L,347L,353L,359L,397L,431L,457L,487L,563L,571L,577L,607L,709L,809L,919L,947L,997L,1013L,1033L,1069L,1103L,1117L,1151L,1187L,1279L,1361L,1367L,1451L,1601L,1607L,1697L,1699L,1801L,1811L,1823L,1831L,1871L,1913L };
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
public class A023249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023249Inst : IEnumerable<long>
{
public static readonly long[] Value=A023249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023249.Bytes);
public long this[int i]=>Value[i];

public static A023249Inst Instance=new A023249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023250
{
public static readonly long[] Value={ 2L,7L,11L,37L,67L,89L,109L,149L,179L,257L,439L,467L,571L,677L,691L,719L,929L,977L,1019L,1279L,1381L,1447L,1549L,1567L,1747L,1787L,1901L,1931L,2111L,2161L,2207L,2287L,2347L,2377L,2459L,2539L,2671L,2711L,2819L,3119L,3229L,3371L,3491L,3607L,3637L,3821L,3877L };
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
public class A023250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023250Inst : IEnumerable<long>
{
public static readonly long[] Value=A023250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023250.Bytes);
public long this[int i]=>Value[i];

public static A023250Inst Instance=new A023250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023251
{
public static readonly long[] Value={ 7L,41L,43L,47L,67L,71L,97L,103L,137L,263L,293L,307L,397L,421L,467L,491L,571L,587L,593L,683L,727L,757L,883L,907L,1021L,1061L,1063L,1097L,1153L,1373L,1427L,1433L,1453L,1523L,1567L,1657L,1747L,1811L,1867L,2141L,2251L,2281L,2287L,2647L,2693L,2791L,2797L,2857L,2927L };
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
public class A023251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023251Inst : IEnumerable<long>
{
public static readonly long[] Value=A023251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023251.Bytes);
public long this[int i]=>Value[i];

public static A023251Inst Instance=new A023251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023252
{
public static readonly long[] Value={ 13L,19L,31L,79L,97L,199L,331L,349L,373L,457L,541L,577L,607L,643L,709L,769L,811L,859L,1021L,1069L,1171L,1249L,1321L,1381L,1447L,1483L,1693L,1867L,2113L,2137L,2239L,2539L,2719L,3037L,3061L,3163L,3181L,3187L,3313L,3433L,3463L,3673L,3727L,3853L,3919L,4021L,4639L };
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
public class A023252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023252Inst : IEnumerable<long>
{
public static readonly long[] Value=A023252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023252.Bytes);
public long this[int i]=>Value[i];

public static A023252Inst Instance=new A023252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023253
{
public static readonly long[] Value={ 5L,17L,83L,101L,131L,251L,257L,263L,389L,419L,461L,467L,521L,587L,797L,809L,1217L,1319L,1511L,1721L,1847L,1907L,2141L,2531L,2579L,2693L,2699L,3623L,4079L,4217L,4253L,4283L,4493L,4673L,5333L,5507L,5711L,6011L,6089L,6353L,6599L,6761L,6803L,6947L,6983L,7013L };
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
public class A023253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023253Inst : IEnumerable<long>
{
public static readonly long[] Value=A023253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023253.Bytes);
public long this[int i]=>Value[i];

public static A023253Inst Instance=new A023253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023254
{
public static readonly long[] Value={ 7L,11L,29L,41L,53L,79L,83L,107L,113L,137L,139L,149L,163L,181L,193L,233L,239L,359L,379L,401L,449L,487L,503L,547L,601L,643L,653L,809L,839L,877L,883L,911L,1009L,1087L,1093L,1103L,1117L,1171L,1259L,1289L,1303L,1367L,1373L,1481L,1511L,1579L,1637L,1747L,1787L,1801L };
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
public class A023254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023254Inst : IEnumerable<long>
{
public static readonly long[] Value=A023254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023254.Bytes);
public long this[int i]=>Value[i];

public static A023254Inst Instance=new A023254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023255
{
public static readonly long[] Value={ 7L,13L,19L,31L,43L,73L,211L,223L,241L,307L,397L,409L,631L,661L,727L,757L,769L,829L,883L,1123L,1741L,1783L,1867L,2131L,2143L,2269L,2287L,2467L,2521L,2551L,2857L,2917L,3253L,3319L,3793L,3967L,4297L,4423L,4597L,4957L,5449L,5563L,5701L,6229L,6427L,6469L,6679L };
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
public class A023255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023255Inst : IEnumerable<long>
{
public static readonly long[] Value=A023255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023255.Bytes);
public long this[int i]=>Value[i];

public static A023255Inst Instance=new A023255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023256
{
public static readonly long[] Value={ 2L,17L,47L,61L,101L,131L,151L,331L,367L,461L,607L,751L,937L,971L,1151L,1321L,1327L,1361L,1481L,1511L,1607L,1811L,1847L,1907L,2081L,2287L,2347L,2357L,2791L,2851L,2971L,3251L,3257L,3457L,3491L,3581L,3761L,4007L,4091L,4127L,4861L,4967L,5231L,5347L,5387L,5407L };
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
public class A023256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023256Inst : IEnumerable<long>
{
public static readonly long[] Value=A023256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023256.Bytes);
public long this[int i]=>Value[i];

public static A023256Inst Instance=new A023256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023257
{
public static readonly long[] Value={ 2L,11L,13L,17L,31L,37L,41L,43L,71L,73L,79L,83L,97L,137L,139L,151L,163L,181L,191L,193L,197L,269L,277L,307L,317L,347L,373L,409L,431L,503L,577L,743L,811L,823L,911L,919L,941L,967L,983L,1021L,1033L,1049L,1051L,1093L,1163L,1187L,1201L,1361L,1373L,1423L,1493L,1571L,1597L };
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
public class A023257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023257Inst : IEnumerable<long>
{
public static readonly long[] Value=A023257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023257.Bytes);
public long this[int i]=>Value[i];

public static A023257Inst Instance=new A023257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023258
{
public static readonly long[] Value={ 5L,17L,29L,37L,89L,127L,199L,229L,269L,347L,359L,379L,397L,499L,769L,809L,929L,947L,977L,1049L,1087L,1129L,1277L,1279L,1367L,1409L,1439L,1489L,1499L,1607L,1609L,1787L,2017L,2039L,2089L,2399L,2539L,2707L,2819L,2837L,2957L,3089L,3109L,3217L,3229L,3389L,3499L };
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
public class A023258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023258Inst : IEnumerable<long>
{
public static readonly long[] Value=A023258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023258.Bytes);
public long this[int i]=>Value[i];

public static A023258Inst Instance=new A023258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023259
{
public static readonly long[] Value={ 5L,11L,31L,59L,61L,71L,149L,179L,269L,439L,499L,541L,571L,719L,761L,1049L,1091L,1181L,1319L,1451L,1489L,1579L,1601L,1831L,1861L,1879L,1949L,2069L,2089L,2269L,2311L,2389L,2441L,2621L,2699L,2819L,2851L,2909L,3001L,3079L,3119L,3391L,3529L,3631L,3701L,3709L };
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
public class A023259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023259Inst : IEnumerable<long>
{
public static readonly long[] Value=A023259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023259.Bytes);
public long this[int i]=>Value[i];

public static A023259Inst Instance=new A023259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023260
{
public static readonly long[] Value={ 2L,17L,101L,107L,401L,821L,947L,1151L,1487L,2027L,2207L,2411L,2741L,2927L,3851L,4391L,4691L,5231L,5861L,6701L,7001L,8297L,8807L,9341L,9587L,9851L,10067L,11117L,11447L,11897L,12107L,12911L,16187L,17657L,20681L,20771L,20807L,21221L,21227L,21491L,21521L };
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
public class A023260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023260Inst : IEnumerable<long>
{
public static readonly long[] Value=A023260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023260.Bytes);
public long this[int i]=>Value[i];

public static A023260Inst Instance=new A023260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023261
{
public static readonly long[] Value={ 5L,13L,31L,61L,101L,103L,163L,191L,233L,241L,251L,433L,461L,643L,751L,761L,821L,863L,983L,1021L,1153L,1193L,1283L,1291L,1531L,1543L,1861L,2281L,2543L,2903L,2953L,3271L,3373L,3673L,3701L,3733L,3793L,3923L,4003L,4241L,4283L,4751L,5333L,5581L,5711L,5801L,5813L };
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
public class A023261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023261Inst : IEnumerable<long>
{
public static readonly long[] Value=A023261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023261.Bytes);
public long this[int i]=>Value[i];

public static A023261Inst Instance=new A023261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023262
{
public static readonly long[] Value={ 13L,43L,103L,139L,199L,349L,397L,577L,727L,733L,829L,967L,1039L,1303L,1567L,1597L,1753L,2131L,2161L,2311L,2707L,2719L,2857L,3109L,3319L,3613L,3673L,3697L,3853L,4051L,4129L,4201L,4297L,4441L,4507L,4513L,4639L,4663L,4789L,5503L,5701L,5743L,5857L,5953L,6121L };
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
public class A023262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023262Inst : IEnumerable<long>
{
public static readonly long[] Value=A023262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023262.Bytes);
public long this[int i]=>Value[i];

public static A023262Inst Instance=new A023262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023263
{
public static readonly long[] Value={ 2L,5L,107L,137L,179L,197L,227L,359L,419L,617L,659L,839L,977L,1097L,1217L,1409L,1487L,1559L,1637L,2087L,2339L,2447L,2549L,2609L,2687L,2909L,2957L,3167L,3299L,3467L,3719L,4139L,4409L,4787L,4919L,4937L,5147L,5189L,5279L,5639L,6047L,6269L,7229L,7547L,7949L };
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
public class A023263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023263Inst : IEnumerable<long>
{
public static readonly long[] Value=A023263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023263.Bytes);
public long this[int i]=>Value[i];

public static A023263Inst Instance=new A023263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023264
{
public static readonly long[] Value={ 23L,43L,83L,109L,193L,379L,389L,569L,643L,659L,853L,1063L,1129L,1283L,1423L,1493L,1759L,1789L,1889L,2003L,2129L,2293L,2459L,2713L,2729L,2879L,2969L,3373L,3823L,4519L,4603L,4649L,4663L,4703L,4783L,4789L,5023L,5153L,5209L,5639L,5653L,5669L,5693L,5783L,6203L };
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
public class A023264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023264Inst : IEnumerable<long>
{
public static readonly long[] Value=A023264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023264.Bytes);
public long this[int i]=>Value[i];

public static A023264Inst Instance=new A023264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023265
{
public static readonly long[] Value={ 3L,11L,19L,31L,103L,109L,113L,131L,151L,173L,179L,239L,283L,313L,491L,521L,599L,619L,733L,739L,773L,929L,1019L,1103L,1361L,1439L,1481L,1621L,1709L,1741L,1831L,1993L,2083L,2153L,2293L,2411L,2549L,2551L,2593L,2689L,2741L,2819L,2843L,2969L,3001L,3623L,3931L,4001L };
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
public class A023265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023265Inst : IEnumerable<long>
{
public static readonly long[] Value=A023265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023265.Bytes);
public long this[int i]=>Value[i];

public static A023265Inst Instance=new A023265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023266
{
public static readonly long[] Value={ 3L,7L,31L,37L,41L,71L,73L,83L,107L,191L,283L,307L,317L,337L,373L,421L,631L,743L,773L,821L,857L,883L,967L,1283L,1297L,1361L,1451L,1567L,1571L,1637L,1823L,1973L,2137L,2207L,2351L,2417L,2677L,2683L,2837L,3011L,3083L,3271L,3331L,3517L,3571L,3691L,3727L,3793L,3877L };
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
public class A023266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023266Inst : IEnumerable<long>
{
public static readonly long[] Value=A023266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023266.Bytes);
public long this[int i]=>Value[i];

public static A023266Inst Instance=new A023266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023267
{
public static readonly long[] Value={ 7L,11L,19L,61L,97L,107L,131L,181L,251L,271L,397L,401L,419L,467L,557L,601L,677L,727L,907L,929L,1129L,1297L,1439L,1481L,1609L,1699L,1747L,1901L,1931L,2027L,2029L,2099L,2221L,2267L,2357L,2377L,2557L,2617L,2879L,3001L,3019L,3121L,3259L,3371L,3407L,3457L,3527L };
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
public class A023267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023267Inst : IEnumerable<long>
{
public static readonly long[] Value=A023267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023267.Bytes);
public long this[int i]=>Value[i];

public static A023267Inst Instance=new A023267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023268
{
public static readonly long[] Value={ 11L,13L,43L,47L,67L,83L,89L,103L,109L,193L,197L,251L,281L,293L,383L,397L,449L,461L,601L,617L,641L,733L,757L,823L,839L,853L,887L,937L,967L,1013L,1069L,1091L,1447L,1489L,1733L,1741L,1789L,1931L,2111L,2237L,2239L,2251L,2339L,2521L,2539L,2647L,2671L,2693L,2797L };
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
public class A023268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023268Inst : IEnumerable<long>
{
public static readonly long[] Value=A023268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023268.Bytes);
public long this[int i]=>Value[i];

public static A023268Inst Instance=new A023268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023269
{
public static readonly long[] Value={ 2L,7L,17L,19L,23L,37L,61L,67L,73L,101L,103L,173L,193L,233L,359L,383L,409L,479L,541L,557L,607L,613L,719L,809L,857L,997L,1013L,1033L,1109L,1117L,1237L,1297L,1361L,1459L,1531L,1549L,1699L,1823L,1871L,1979L,1999L,2069L,2131L,2161L,2347L,2377L,2399L,2447L,2663L };
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
public class A023269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023269Inst : IEnumerable<long>
{
public static readonly long[] Value=A023269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023269.Bytes);
public long this[int i]=>Value[i];

public static A023269Inst Instance=new A023269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023270
{
public static readonly long[] Value={ 5L,13L,19L,23L,47L,61L,103L,127L,139L,233L,257L,293L,331L,433L,463L,491L,499L,547L,593L,701L,859L,967L,1009L,1013L,1049L,1223L,1321L,1399L,1493L,1567L,1723L,1811L,1867L,1889L,1997L,2039L,2063L,2087L,2137L,2203L,2267L,2273L,2309L,2423L,2437L,2441L,2609L,2633L };
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
public class A023270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023270Inst : IEnumerable<long>
{
public static readonly long[] Value=A023270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023270.Bytes);
public long this[int i]=>Value[i];

public static A023270Inst Instance=new A023270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023271
{
public static readonly long[] Value={ 5L,11L,41L,61L,251L,601L,641L,1091L,1481L,1601L,1741L,1861L,2371L,2671L,3301L,3911L,4001L,5101L,5381L,5431L,5641L,6311L,6361L,9461L,11821L,12101L,12641L,13451L,14621L,14741L,15791L,15901L,17471L,18211L,19471L,20341L,21481L,23321L,24091L,26171L,26681L };
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
public class A023271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023271Inst : IEnumerable<long>
{
public static readonly long[] Value=A023271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023271.Bytes);
public long this[int i]=>Value[i];

public static A023271Inst Instance=new A023271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023272
{
public static readonly long[] Value={ 2L,5L,89L,179L,359L,509L,1229L,1409L,2699L,3539L,6449L,10589L,11549L,11909L,12119L,17159L,19709L,19889L,22349L,26189L,27479L,30389L,43649L,53639L,53849L,55229L,57839L,60149L,61409L,63419L,66749L,71399L,74699L,75329L,82499L,87539L,98369L,101399L,104369L };
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
public class A023272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023272Inst : IEnumerable<long>
{
public static readonly long[] Value=A023272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023272.Bytes);
public long this[int i]=>Value[i];

public static A023272Inst Instance=new A023272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023273
{
public static readonly long[] Value={ 2L,5L,47L,67L,97L,137L,197L,277L,307L,607L,617L,1307L,1427L,2857L,5717L,6047L,6217L,6257L,6997L,9377L,9787L,9967L,11197L,12097L,13297L,13997L,14347L,16057L,18757L,18947L,20887L,21517L,21587L,21757L,24197L,26227L,28097L,28447L,32117L,33767L,34367L,35117L };
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
public class A023273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023273Inst : IEnumerable<long>
{
public static readonly long[] Value=A023273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023273.Bytes);
public long this[int i]=>Value[i];

public static A023273Inst Instance=new A023273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023274
{
public static readonly long[] Value={ 13L,31L,37L,67L,73L,181L,367L,541L,661L,997L,1087L,1117L,1327L,1861L,2179L,2293L,2473L,2713L,2719L,3271L,3727L,4363L,5281L,5443L,5749L,7459L,8089L,8707L,9109L,9181L,9337L,10357L,10639L,12553L,13183L,14923L,16183L,16249L,17341L,17419L,17761L,17923L,17989L };
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
public class A023274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023274Inst : IEnumerable<long>
{
public static readonly long[] Value=A023274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023274.Bytes);
public long this[int i]=>Value[i];

public static A023274Inst Instance=new A023274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023275
{
public static readonly long[] Value={ 5L,23L,293L,593L,953L,2063L,3323L,4133L,4583L,8243L,8783L,9173L,9203L,14723L,15383L,16103L,16763L,18413L,19163L,20123L,25733L,29453L,37223L,38783L,39443L,40253L,41903L,42923L,44753L,45863L,49433L,51473L,54443L,54623L,54713L,57383L,58913L,63353L,66533L };
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
public class A023275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023275Inst : IEnumerable<long>
{
public static readonly long[] Value=A023275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023275.Bytes);
public long this[int i]=>Value[i];

public static A023275Inst Instance=new A023275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023276
{
public static readonly long[] Value={ 5L,11L,31L,71L,281L,521L,911L,1181L,2371L,2521L,3391L,3701L,4211L,4931L,5051L,7211L,7411L,8221L,8431L,8461L,8501L,8641L,8951L,9601L,9871L,10301L,11981L,12421L,13121L,13921L,14591L,16381L,16451L,16901L,16931L,17791L,17881L,19391L,19751L,21991L,23021L };
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
public class A023276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023276Inst : IEnumerable<long>
{
public static readonly long[] Value=A023276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023276.Bytes);
public long this[int i]=>Value[i];

public static A023276Inst Instance=new A023276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023277
{
public static readonly long[] Value={ 29L,139L,1129L,1409L,2339L,2939L,3389L,4549L,7309L,10009L,10039L,11489L,12539L,13859L,15259L,17159L,17569L,20939L,22079L,24229L,24509L,27799L,28099L,29339L,30029L,32059L,33599L,34469L,37379L,37619L,39419L,41579L,42359L,44549L,52919L,55259L,57679L,58109L };
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
public class A023277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023277Inst : IEnumerable<long>
{
public static readonly long[] Value=A023277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023277.Bytes);
public long this[int i]=>Value[i];

public static A023277Inst Instance=new A023277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023278
{
public static readonly long[] Value={ 23L,683L,1663L,2753L,3203L,6073L,6323L,7523L,8243L,9293L,9613L,15173L,19913L,21023L,21683L,25183L,26633L,29663L,34613L,34703L,39293L,41953L,43283L,45533L,52813L,59393L,62473L,65053L,66763L,71713L,71993L,81533L,81953L,84523L,87833L,103843L,104183L };
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
public class A023278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023278Inst : IEnumerable<long>
{
public static readonly long[] Value=A023278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023278.Bytes);
public long this[int i]=>Value[i];

public static A023278Inst Instance=new A023278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023279
{
public static readonly long[] Value={ 11L,31L,211L,1151L,3181L,5051L,5261L,6101L,6661L,9391L,9551L,10501L,11701L,13171L,15901L,16481L,19531L,22051L,24181L,26261L,27031L,28351L,28591L,28661L,29411L,30941L,31321L,32621L,38011L,40471L,42101L,48371L,49921L,57571L,59791L,61981L,66161L,67271L };
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
public class A023279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023279Inst : IEnumerable<long>
{
public static readonly long[] Value=A023279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023279.Bytes);
public long this[int i]=>Value[i];

public static A023279Inst Instance=new A023279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023280
{
public static readonly long[] Value={ 3L,19L,47L,149L,199L,233L,353L,563L,607L,709L,919L,1013L,1361L,1367L,1697L,1801L,1871L,2137L,2203L,2819L,2879L,2917L,3041L,3229L,3449L,3701L,3943L,4093L,4111L,4177L,4567L,4973L,5519L,5689L,5987L,6053L,6359L,6421L,6841L,7019L,7283L,8647L,8951L,9109L,9719L };
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
public class A023280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023280Inst : IEnumerable<long>
{
public static readonly long[] Value=A023280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023280.Bytes);
public long this[int i]=>Value[i];

public static A023280Inst Instance=new A023280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023281
{
public static readonly long[] Value={ 2L,109L,179L,571L,677L,977L,1279L,1447L,1747L,1901L,2207L,2671L,3119L,3917L,5011L,5399L,5441L,5569L,5791L,6211L,6607L,7079L,7417L,8369L,8831L,9221L,9697L,9769L,11821L,11897L,12347L,13537L,13669L,13691L,13729L,13781L,13907L,14747L,14851L,15581L,17231L,17497L };
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
public class A023281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023281Inst : IEnumerable<long>
{
public static readonly long[] Value=A023281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023281.Bytes);
public long this[int i]=>Value[i];

public static A023281Inst Instance=new A023281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023282
{
public static readonly long[] Value={ 71L,97L,103L,263L,883L,907L,1747L,1867L,2251L,2281L,2693L,2791L,2857L,3067L,3541L,4073L,4513L,4597L,4663L,4793L,6047L,6971L,6983L,8761L,9091L,9203L,9311L,9377L,10343L,11131L,11437L,12037L,12107L,12401L,13451L,13627L,14887L,15881L,16217L,16301L,16493L,16871L };
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
public class A023282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023282Inst : IEnumerable<long>
{
public static readonly long[] Value=A023282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023282.Bytes);
public long this[int i]=>Value[i];

public static A023282Inst Instance=new A023282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023283
{
public static readonly long[] Value={ 19L,373L,607L,1171L,1381L,1867L,2137L,2539L,3181L,4021L,5689L,5827L,5857L,6163L,7213L,7507L,11497L,12007L,13291L,13687L,14173L,15193L,16453L,21997L,22501L,24799L,25657L,28723L,31393L,31957L,32587L,35863L,40813L,42667L,42859L,43321L,43951L,45061L,45691L };
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
public class A023283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023283Inst : IEnumerable<long>
{
public static readonly long[] Value=A023283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023283.Bytes);
public long this[int i]=>Value[i];

public static A023283Inst Instance=new A023283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023284
{
public static readonly long[] Value={ 83L,263L,1217L,1319L,1511L,1721L,1847L,1907L,2141L,2531L,4283L,4673L,5333L,6089L,6353L,6983L,7013L,7151L,7529L,8543L,10709L,10973L,11423L,15077L,15137L,17387L,17573L,20129L,20201L,20411L,20663L,21521L,23369L,23561L,25343L,26669L,27143L,27647L,28697L };
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
public class A023284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023284Inst : IEnumerable<long>
{
public static readonly long[] Value=A023284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023284.Bytes);
public long this[int i]=>Value[i];

public static A023284Inst Instance=new A023284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023285
{
public static readonly long[] Value={ 7L,79L,181L,233L,359L,401L,449L,1009L,1093L,1259L,1303L,1373L,1511L,1931L,2011L,2339L,2477L,3019L,3691L,4349L,4409L,5417L,5879L,6301L,6553L,6637L,7079L,8329L,9127L,9137L,10303L,10499L,11579L,12391L,13259L,14251L,15101L,15107L,15217L,15329L,15527L,15679L };
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
public class A023285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023285Inst : IEnumerable<long>
{
public static readonly long[] Value=A023285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023285.Bytes);
public long this[int i]=>Value[i];

public static A023285Inst Instance=new A023285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023286
{
public static readonly long[] Value={ 7L,13L,43L,223L,757L,883L,2143L,2269L,2521L,2917L,3253L,3967L,4297L,4423L,6229L,6427L,6679L,7621L,7741L,10429L,11353L,12739L,14593L,14929L,15259L,15541L,15937L,16981L,17449L,17911L,21187L,23899L,24697L,25633L,27481L,28789L,29611L,29833L,30253L,30703L };
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
public class A023286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023286Inst : IEnumerable<long>
{
public static readonly long[] Value=A023286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023286.Bytes);
public long this[int i]=>Value[i];

public static A023286Inst Instance=new A023286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023287
{
public static readonly long[] Value={ 61L,101L,1811L,3491L,4091L,5711L,5801L,6361L,7121L,10391L,10771L,11311L,13421L,15131L,17791L,18911L,19471L,20011L,24391L,25601L,25951L,30091L,35251L,41911L,45631L,47431L,55631L,58711L,62921L,67891L,70451L,70571L,72271L,74051L,74161L,75431L,80471L,86341L };
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
public class A023287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023287Inst : IEnumerable<long>
{
public static readonly long[] Value=A023287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023287.Bytes);
public long this[int i]=>Value[i];

public static A023287Inst Instance=new A023287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023288
{
public static readonly long[] Value={ 2L,11L,13L,31L,71L,83L,151L,163L,193L,197L,317L,347L,373L,503L,577L,811L,911L,919L,1049L,1051L,1201L,1423L,1721L,1907L,2089L,2243L,2543L,2719L,2963L,3529L,3583L,3607L,3797L,4091L,4153L,4217L,4243L,4409L,4591L,4637L,4783L,5209L,5557L,5783L,5849L,5923L,6091L };
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
public class A023288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023288Inst : IEnumerable<long>
{
public static readonly long[] Value=A023288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023288.Bytes);
public long this[int i]=>Value[i];

public static A023288Inst Instance=new A023288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023289
{
public static readonly long[] Value={ 5L,37L,127L,347L,977L,2017L,3607L,5477L,9137L,10487L,13687L,14057L,14107L,19037L,19697L,19727L,20507L,22157L,23887L,24097L,25237L,25307L,26717L,26777L,27107L,29347L,30697L,33757L,33997L,34667L,34847L,35117L,35227L,37057L,40577L,40627L,41177L,41597L };
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
public class A023289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023289Inst : IEnumerable<long>
{
public static readonly long[] Value=A023289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023289.Bytes);
public long this[int i]=>Value[i];

public static A023289Inst Instance=new A023289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023290
{
public static readonly long[] Value={ 149L,439L,1319L,2069L,2089L,2389L,2699L,2819L,4259L,4919L,5059L,5689L,6469L,7559L,8429L,8669L,9199L,9239L,9319L,9769L,10159L,10529L,14449L,14479L,17659L,18899L,19289L,23879L,25189L,29819L,33119L,33149L,34159L,34439L,35089L,36229L,38839L,39829L,40699L };
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
public class A023290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023290Inst : IEnumerable<long>
{
public static readonly long[] Value=A023290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023290.Bytes);
public long this[int i]=>Value[i];

public static A023290Inst Instance=new A023290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023291
{
public static readonly long[] Value={ 2L,1487L,2207L,2927L,8807L,11117L,16187L,17657L,26357L,44927L,45377L,48497L,91757L,110237L,117167L,122327L,125387L,126107L,145007L,170927L,174527L,190787L,193847L,203897L,230567L,244247L,246017L,270287L,280547L,283937L,347957L,362237L,364337L };
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
public class A023291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023291Inst : IEnumerable<long>
{
public static readonly long[] Value=A023291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023291.Bytes);
public long this[int i]=>Value[i];

public static A023291Inst Instance=new A023291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023292
{
public static readonly long[] Value={ 31L,191L,821L,3271L,11171L,13121L,14591L,21521L,27751L,30341L,35951L,37561L,39671L,40231L,43651L,51061L,51551L,56671L,68161L,73681L,84871L,91541L,92581L,102031L,102871L,102881L,104971L,117281L,127781L,128201L,128551L,128761L,138511L,148091L };
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
public class A023292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023292Inst : IEnumerable<long>
{
public static readonly long[] Value=A023292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023292.Bytes);
public long this[int i]=>Value[i];

public static A023292Inst Instance=new A023292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023293
{
public static readonly long[] Value={ 43L,103L,199L,1039L,1303L,2311L,2857L,3673L,4513L,4663L,5743L,5953L,8431L,9721L,12391L,14143L,14533L,17599L,18457L,19507L,21211L,23719L,24169L,25621L,28663L,29023L,31963L,33409L,35311L,36979L,37423L,40867L,40939L,43891L,44371L,44983L,45841L,46747L,46807L };
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
public class A023293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023293Inst : IEnumerable<long>
{
public static readonly long[] Value=A023293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023293.Bytes);
public long this[int i]=>Value[i];

public static A023293Inst Instance=new A023293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023294
{
public static readonly long[] Value={ 659L,2549L,5189L,6269L,7229L,7949L,9209L,11579L,16139L,18089L,22739L,25589L,26099L,26339L,29009L,30689L,40289L,51719L,55799L,59669L,60689L,61379L,63599L,69959L,70229L,74609L,85829L,94949L,95819L,102539L,109589L,118169L,121469L,135599L,136889L };
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
public class A023294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023294Inst : IEnumerable<long>
{
public static readonly long[] Value=A023294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023294.Bytes);
public long this[int i]=>Value[i];

public static A023294Inst Instance=new A023294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023295
{
public static readonly long[] Value={ 23L,643L,2293L,5023L,5653L,9643L,10723L,11503L,12823L,15493L,18353L,18773L,28403L,32003L,32183L,41953L,42853L,45233L,49853L,50873L,52103L,53113L,54623L,56123L,76003L,80803L,84443L,86783L,88813L,89413L,92033L,95213L,96823L,97943L,100613L,115793L };
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
public class A023295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023295Inst : IEnumerable<long>
{
public static readonly long[] Value=A023295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023295.Bytes);
public long this[int i]=>Value[i];

public static A023295Inst Instance=new A023295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023296
{
public static readonly long[] Value={ 19L,103L,113L,151L,239L,283L,313L,599L,929L,1481L,2411L,2549L,2593L,2741L,2819L,2969L,3931L,4091L,4463L,4523L,5279L,5923L,6781L,7759L,8209L,8363L,9749L,10133L,10531L,12919L,14071L,15053L,15361L,16229L,16453L,16493L,16573L,16703L,17041L,17783L,18253L };
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
public class A023296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023296Inst : IEnumerable<long>
{
public static readonly long[] Value=A023296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023296.Bytes);
public long this[int i]=>Value[i];

public static A023296Inst Instance=new A023296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023297
{
public static readonly long[] Value={ 3L,31L,37L,41L,107L,421L,773L,967L,1451L,1567L,1571L,1637L,1973L,3011L,3793L,4111L,4217L,4703L,5783L,6961L,7331L,8443L,8627L,9323L,10733L,12071L,12413L,12721L,12967L,13523L,14107L,14503L,14737L,15647L,17851L,17881L,19853L,19991L,20051L,20233L,22157L,23291L };
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
public class A023297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023297Inst : IEnumerable<long>
{
public static readonly long[] Value=A023297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023297.Bytes);
public long this[int i]=>Value[i];

public static A023297Inst Instance=new A023297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023298
{
public static readonly long[] Value={ 11L,61L,251L,397L,467L,727L,907L,1747L,1901L,2221L,2617L,3121L,3527L,3581L,4001L,4099L,4211L,4759L,5231L,5717L,6277L,6661L,6689L,7237L,7877L,8117L,8171L,8581L,9371L,9587L,11171L,12457L,12539L,13109L,14221L,15187L,15731L,16069L,16477L,16979L,17117L,17491L };
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
public class A023298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023298Inst : IEnumerable<long>
{
public static readonly long[] Value=A023298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023298.Bytes);
public long this[int i]=>Value[i];

public static A023298Inst Instance=new A023298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023299
{
public static readonly long[] Value={ 11L,43L,83L,103L,281L,293L,641L,823L,937L,1069L,1489L,1733L,2237L,2251L,2521L,2539L,2647L,2671L,3361L,3529L,3919L,4129L,4759L,5531L,5867L,6101L,6299L,7417L,7669L,7853L,7951L,8443L,8737L,9547L,10597L,12041L,12641L,12821L,14813L,15083L,15091L,15413L };
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
public class A023299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023299Inst : IEnumerable<long>
{
public static readonly long[] Value=A023299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023299.Bytes);
public long this[int i]=>Value[i];

public static A023299Inst Instance=new A023299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023300
{
public static readonly long[] Value={ 2L,7L,17L,19L,23L,61L,101L,103L,409L,719L,857L,997L,1297L,1531L,1699L,2399L,3253L,3491L,4583L,4933L,5119L,5189L,5939L,6277L,6863L,7789L,8669L,9187L,9887L,10061L,10253L,10267L,11027L,11777L,12791L,12899L,13669L,17209L,17293L,17489L,17839L,19211L,19379L };
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
public class A023300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023300Inst : IEnumerable<long>
{
public static readonly long[] Value=A023300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023300.Bytes);
public long this[int i]=>Value[i];

public static A023300Inst Instance=new A023300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023301
{
public static readonly long[] Value={ 13L,139L,293L,331L,547L,967L,1049L,1399L,1567L,1889L,1997L,2087L,2137L,2309L,2423L,2437L,2753L,2939L,3719L,3761L,3919L,4451L,4517L,4621L,6089L,7001L,7741L,8423L,8849L,9437L,10487L,11657L,12007L,12347L,12823L,13469L,15289L,15373L,15661L,17737L,17989L };
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
public class A023301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023301Inst : IEnumerable<long>
{
public static readonly long[] Value=A023301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023301.Bytes);
public long this[int i]=>Value[i];

public static A023301Inst Instance=new A023301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023302
{
public static readonly long[] Value={ 2L,89L,179L,53639L,53849L,61409L,63419L,66749L,126839L,127139L,143609L,167729L,186149L,206369L,254279L,268049L,296099L,340919L,405269L,422069L,446609L,539009L,594449L,607319L,658349L,671249L,725009L,775949L,810539L,810809L,812849L,819509L };
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
public class A023302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023302Inst : IEnumerable<long>
{
public static readonly long[] Value=A023302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023302.Bytes);
public long this[int i]=>Value[i];

public static A023302Inst Instance=new A023302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023303
{
public static readonly long[] Value={ 47L,67L,97L,137L,307L,1427L,2857L,6047L,6997L,9377L,12097L,16057L,24197L,32117L,35117L,36877L,44507L,46687L,54517L,55487L,64877L,71327L,71807L,76537L,89017L,92387L,94427L,100057L,132707L,142057L,153077L,160207L,184777L,186647L,194027L,200117L,205237L };
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
public class A023303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023303Inst : IEnumerable<long>
{
public static readonly long[] Value=A023303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023303.Bytes);
public long this[int i]=>Value[i];

public static A023303Inst Instance=new A023303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023304
{
public static readonly long[] Value={ 13L,31L,181L,541L,661L,1087L,1861L,2179L,2719L,3727L,7459L,8089L,8707L,9109L,10639L,17341L,19333L,22501L,23293L,29287L,32797L,39847L,40387L,42703L,46591L,51613L,53101L,56149L,56809L,57829L,59233L,80779L,87643L,89113L,89413L,91291L,93979L,94261L,98899L };
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
public class A023304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023304Inst : IEnumerable<long>
{
public static readonly long[] Value=A023304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023304.Bytes);
public long this[int i]=>Value[i];

public static A023304Inst Instance=new A023304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023305
{
public static readonly long[] Value={ 293L,2063L,4583L,9203L,14723L,20123L,25733L,29453L,40253L,54713L,76103L,97523L,99833L,109433L,138683L,149993L,158243L,196853L,199403L,218873L,253103L,297623L,379913L,416963L,445463L,468113L,508073L,551963L,562403L,564713L,574703L,583733L };
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
public class A023305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023305Inst : IEnumerable<long>
{
public static readonly long[] Value=A023305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023305.Bytes);
public long this[int i]=>Value[i];

public static A023305Inst Instance=new A023305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023306
{
public static readonly long[] Value={ 11L,31L,1181L,2521L,3701L,4211L,4931L,8221L,8461L,9871L,11981L,13121L,14591L,16381L,16901L,21991L,23021L,34961L,36781L,37691L,43991L,44531L,45181L,46021L,46051L,52321L,57601L,59921L,62081L,75391L,89071L,92051L,95621L,105361L,115211L,124171L,128461L };
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
public class A023306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023306Inst : IEnumerable<long>
{
public static readonly long[] Value=A023306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023306.Bytes);
public long this[int i]=>Value[i];

public static A023306Inst Instance=new A023306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023307
{
public static readonly long[] Value={ 1129L,10009L,11489L,12539L,13859L,30029L,63079L,77359L,99119L,121039L,124669L,169409L,194749L,205589L,246329L,330329L,349519L,351829L,354839L,361279L,369539L,384589L,395719L,399769L,416989L,429109L,446819L,527599L,532489L,544259L,575119L };
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
public class A023307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023307Inst : IEnumerable<long>
{
public static readonly long[] Value=A023307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023307.Bytes);
public long this[int i]=>Value[i];

public static A023307Inst Instance=new A023307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023308
{
public static readonly long[] Value={ 3203L,21683L,34613L,52813L,103843L,116933L,117443L,165443L,172933L,193603L,195053L,213973L,226783L,321053L,322193L,357613L,360323L,362233L,363403L,368743L,472393L,474143L,496333L,518543L,528673L,569083L,571303L,631853L,654623L,714893L,758503L };
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
public class A023308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023308Inst : IEnumerable<long>
{
public static readonly long[] Value=A023308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023308.Bytes);
public long this[int i]=>Value[i];

public static A023308Inst Instance=new A023308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023309
{
public static readonly long[] Value={ 3181L,9551L,22051L,30941L,32621L,61981L,76651L,99961L,134291L,151901L,163661L,185951L,226691L,227671L,240551L,288191L,342821L,374501L,394411L,402881L,423781L,426301L,446461L,456151L,459091L,460951L,554011L,572321L,577601L,617191L,653831L };
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
public class A023309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023309Inst : IEnumerable<long>
{
public static readonly long[] Value=A023309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023309.Bytes);
public long this[int i]=>Value[i];

public static A023309Inst Instance=new A023309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023310
{
public static readonly long[] Value={ 3L,199L,233L,709L,1361L,1367L,2137L,2879L,5519L,5987L,7283L,9719L,11699L,14983L,16417L,17881L,20939L,24481L,30467L,31663L,31741L,35107L,35863L,46811L,47869L,49261L,58207L,60497L,63317L,64781L,68777L,73453L,74021L,79901L,85487L,85571L,94327L,94999L };
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
public class A023310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023310Inst : IEnumerable<long>
{
public static readonly long[] Value=A023310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023310.Bytes);
public long this[int i]=>Value[i];

public static A023310Inst Instance=new A023310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023311
{
public static readonly long[] Value={ 1447L,2207L,6211L,6607L,8369L,9769L,11821L,13537L,13729L,13781L,15581L,17231L,17497L,27817L,32059L,32569L,32611L,33647L,36251L,39079L,46381L,47417L,55127L,55171L,57077L,60869L,63361L,64327L,68927L,77951L,81619L,85469L,86767L,88001L,94099L,94477L,96149L };
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
public class A023311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023311Inst : IEnumerable<long>
{
public static readonly long[] Value=A023311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023311.Bytes);
public long this[int i]=>Value[i];

public static A023311Inst Instance=new A023311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023312
{
public static readonly long[] Value={ 883L,2857L,4073L,4663L,9311L,11131L,16493L,18257L,19541L,22063L,28687L,35837L,48383L,55817L,59393L,62131L,71387L,73037L,73133L,78173L,83423L,86111L,88261L,90511L,93287L,93811L,99377L,101051L,104537L,122203L,125927L,149497L,152377L,153941L,155653L };
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
public class A023312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023312Inst : IEnumerable<long>
{
public static readonly long[] Value=A023312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023312.Bytes);
public long this[int i]=>Value[i];

public static A023312Inst Instance=new A023312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023313
{
public static readonly long[] Value={ 373L,1171L,13687L,21997L,25657L,61603L,74413L,76471L,84199L,87181L,93487L,114691L,135859L,170761L,174877L,184333L,192979L,196177L,207931L,209743L,244219L,276229L,286687L,292561L,297811L,334603L,338893L,405037L,408361L,417097L,439141L,446323L };
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
public class A023313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023313Inst : IEnumerable<long>
{
public static readonly long[] Value=A023313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023313.Bytes);
public long this[int i]=>Value[i];

public static A023313Inst Instance=new A023313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023314
{
public static readonly long[] Value={ 263L,1217L,2141L,4673L,5333L,6983L,10973L,11423L,26669L,27143L,28697L,74843L,85061L,101063L,102647L,114113L,121001L,133349L,141623L,150497L,154823L,199877L,200183L,202409L,203039L,207953L,259697L,259781L,275813L,280487L,294167L,305477L,322727L };
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
public class A023314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023314Inst : IEnumerable<long>
{
public static readonly long[] Value=A023314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023314.Bytes);
public long this[int i]=>Value[i];

public static A023314Inst Instance=new A023314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023315
{
public static readonly long[] Value={ 79L,401L,1259L,2477L,3019L,4409L,10303L,15679L,20509L,24499L,34127L,43987L,44389L,53101L,66359L,71287L,74857L,81097L,85903L,90803L,93053L,102811L,103231L,104999L,112601L,125453L,132533L,144731L,156347L,157793L,160817L,161839L,163981L,170641L };
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
public class A023315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023315Inst : IEnumerable<long>
{
public static readonly long[] Value=A023315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023315.Bytes);
public long this[int i]=>Value[i];

public static A023315Inst Instance=new A023315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023316
{
public static readonly long[] Value={ 7L,43L,883L,2269L,2917L,7621L,15541L,15937L,36541L,38113L,54787L,60961L,67033L,71359L,77491L,79693L,82531L,84967L,112621L,129589L,176461L,185683L,192547L,239671L,248071L,267373L,271489L,271549L,310231L,316471L,340957L,343267L,350617L,382303L };
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
public class A023316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023316Inst : IEnumerable<long>
{
public static readonly long[] Value=A023316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023316.Bytes);
public long this[int i]=>Value[i];

public static A023316Inst Instance=new A023316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023317
{
public static readonly long[] Value={ 11L,13L,83L,151L,317L,373L,1721L,3529L,4153L,4243L,4637L,4783L,5209L,5849L,5923L,6661L,8431L,10903L,11329L,14519L,16183L,16979L,20149L,26669L,27509L,27827L,29873L,29947L,32987L,33637L,33937L,34919L,35099L,35543L,36277L,36691L,38069L,38461L,41651L,47407L };
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
public class A023317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023317Inst : IEnumerable<long>
{
public static readonly long[] Value=A023317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023317.Bytes);
public long this[int i]=>Value[i];

public static A023317Inst Instance=new A023317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023318
{
public static readonly long[] Value={ 1319L,2699L,4259L,4919L,5689L,8669L,10159L,10529L,29819L,33119L,82339L,86689L,98669L,174079L,177949L,196739L,207869L,210599L,222499L,231809L,253369L,267299L,275699L,323699L,362459L,371639L,378179L,388529L,397799L,402529L,421079L,448859L,468499L };
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
public class A023318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023318Inst : IEnumerable<long>
{
public static readonly long[] Value=A023318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023318.Bytes);
public long this[int i]=>Value[i];

public static A023318Inst Instance=new A023318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023319
{
public static readonly long[] Value={ 2207L,126107L,230567L,366347L,590207L,788027L,831167L,919067L,985937L,1111427L,1154567L,1170857L,1367507L,1463597L,1624757L,1934417L,2034797L,2468027L,2502767L,2545307L,3019787L,3287027L,3385817L,3675197L,3692207L,4087757L,4565927L,4600577L };
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
public class A023319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023319Inst : IEnumerable<long>
{
public static readonly long[] Value=A023319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023319.Bytes);
public long this[int i]=>Value[i];

public static A023319Inst Instance=new A023319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023320
{
public static readonly long[] Value={ 13121L,117281L,188831L,317971L,429281L,624721L,627791L,722431L,774791L,883721L,924731L,946291L,1002721L,1083851L,1212011L,1221601L,1249111L,1342361L,1469761L,1665761L,1896901L,2003081L,2156251L,2336011L,2382761L,2391451L,2612021L,2634551L };
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
public class A023320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023320Inst : IEnumerable<long>
{
public static readonly long[] Value=A023320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023320.Bytes);
public long this[int i]=>Value[i];

public static A023320Inst Instance=new A023320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023321
{
public static readonly long[] Value={ 8431L,9721L,24169L,35311L,63577L,74203L,109471L,109891L,140269L,174613L,176599L,182857L,210187L,241561L,270553L,274837L,274909L,276517L,281557L,324763L,326737L,383659L,464089L,474127L,489109L,498403L,540781L,563587L,576943L,582949L,633253L };
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
public class A023321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023321Inst : IEnumerable<long>
{
public static readonly long[] Value=A023321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023321.Bytes);
public long this[int i]=>Value[i];

public static A023321Inst Instance=new A023321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023322
{
public static readonly long[] Value={ 7949L,25589L,55799L,61379L,69959L,70229L,74609L,174569L,188369L,204719L,220469L,225629L,233759L,250919L,286619L,363659L,552749L,592139L,658349L,735419L,783269L,827549L,931949L,1018889L,1065839L,1126319L,1132739L,1187939L,1215629L,1378529L };
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
public class A023322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023322Inst : IEnumerable<long>
{
public static readonly long[] Value=A023322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023322.Bytes);
public long this[int i]=>Value[i];

public static A023322Inst Instance=new A023322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023323
{
public static readonly long[] Value={ 2293L,5653L,11503L,76003L,88813L,100613L,142993L,294793L,314983L,351383L,419603L,463633L,473293L,520363L,682063L,694523L,780733L,836873L,872393L,895003L,1004063L,1043723L,1085473L,1277593L,1290293L,1318783L,1336463L,1446043L,1483633L,1539773L };
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
public class A023323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023323Inst : IEnumerable<long>
{
public static readonly long[] Value=A023323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023323.Bytes);
public long this[int i]=>Value[i];

public static A023323Inst Instance=new A023323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023324
{
public static readonly long[] Value={ 103L,283L,313L,929L,2549L,2593L,3931L,4091L,5279L,6781L,7759L,8363L,16229L,16493L,16703L,19961L,24071L,25733L,27059L,32191L,34961L,35381L,36341L,44131L,50093L,52973L,59671L,66179L,69833L,69931L,75853L,90031L,92993L,93371L,101879L,103561L,106949L };
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
public class A023324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023324Inst : IEnumerable<long>
{
public static readonly long[] Value=A023324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023324.Bytes);
public long this[int i]=>Value[i];

public static A023324Inst Instance=new A023324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023405
{
public static readonly long[] Value={ 4L,4L,9L,4L,9L,9L,4L,9L,4L,9L,4L,4L,9L,9L,4L,9L,4L,9L,9L,9L,4L,4L,4L,4L,9L,4L,4L,4L,4L,9L,9L,9L,9L,4L,9L,4L,4L,9L,9L,4L,4L,9L,9L,4L,9L,4L,4L,9L,4L,9L,4L,9L,4L,4L,4L,4L,4L,4L,9L,9L,9L,9L,4L,9L,4L,4L,4L,9L,9L,4L,4L,9L,4L,4L,9L,9L,4L,4L,9L,9L,9L,4L,9L,9L,9L,9L,9L,9L,4L,4L,9L,4L,4L,9L,9L,9L,9L,9L,9L,4L,4L,4L,9L,9L,4L,4L,4L,4L };
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
public class A023405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023405Inst : IEnumerable<long>
{
public static readonly long[] Value=A023405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023405.Bytes);
public long this[int i]=>Value[i];

public static A023405Inst Instance=new A023405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023406
{
public static readonly long[] Value={ 6L,1L,6L,1L,1L,1L,6L,1L,6L,1L,6L,6L,1L,6L,6L,6L,6L,6L,6L,1L,6L,1L,1L,1L,6L,6L,6L,6L,6L,6L,6L,6L,1L,6L,6L,1L,6L,6L,6L,6L,6L,1L,1L,1L,1L,6L,6L,1L,6L,1L,1L,6L,1L,1L,6L,1L,1L,6L,1L,1L,1L,1L,6L,1L,1L,6L,1L,6L,6L,6L,1L,1L,6L,6L,6L,1L,6L,6L,6L,1L,1L,1L,1L,1L,6L,1L,1L,6L,6L,6L,1L,6L,1L,6L,6L,1L,6L,1L,6L,6L,1L,1L,1L,1L,1L,6L,1L,1L };
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
public class A023406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023406Inst : IEnumerable<long>
{
public static readonly long[] Value=A023406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023406.Bytes);
public long this[int i]=>Value[i];

public static A023406Inst Instance=new A023406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023407
{
public static readonly long[] Value={ 6L,3L,3L,6L,6L,3L,6L,3L,6L,3L,3L,3L,3L,3L,6L,3L,3L,3L,6L,3L,3L,3L,3L,3L,6L,6L,3L,3L,6L,3L,3L,6L,3L,6L,3L,3L,3L,6L,3L,6L,3L,6L,6L,3L,3L,6L,3L,6L,6L,6L,3L,3L,3L,3L,6L,6L,3L,6L,3L,3L,3L,6L,6L,6L,3L,6L,3L,3L,6L,6L,6L,3L,6L,6L,3L,3L,6L,3L,3L,3L,6L,3L,3L,6L,3L,6L,3L,3L,6L,6L,3L,3L,6L,3L,3L,6L,3L,3L,6L,3L,6L,3L,6L,3L,6L,3L,3L,3L };
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
public class A023407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023407Inst : IEnumerable<long>
{
public static readonly long[] Value=A023407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023407.Bytes);
public long this[int i]=>Value[i];

public static A023407Inst Instance=new A023407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023408
{
public static readonly long[] Value={ 6L,5L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,6L,5L,6L,5L,5L,6L,5L,5L,5L,5L,6L,5L,5L,6L,6L,5L,6L,6L,6L,5L,6L,6L,6L,6L,6L,6L,5L,6L,6L,5L,6L,5L,6L,6L,5L,5L,5L,6L,5L,6L,5L,6L,6L,5L,5L,6L,5L,6L,5L,6L,6L,6L,5L,6L,6L,6L,5L,6L,6L,5L,5L,5L,6L,5L,5L,5L,5L,5L,6L,6L,6L,6L,5L,6L,5L,6L,5L,5L,6L,6L,5L,5L,6L,6L,5L,6L,6L,5L,6L,5L,6L,6L,6L,5L,5L };
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
public class A023408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023408Inst : IEnumerable<long>
{
public static readonly long[] Value=A023408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023408.Bytes);
public long this[int i]=>Value[i];

public static A023408Inst Instance=new A023408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023409
{
public static readonly long[] Value={ 6L,7L,7L,7L,6L,6L,6L,6L,7L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,6L,7L,7L,6L,6L,7L,7L,7L,6L,6L,6L,6L,7L,6L,7L,7L,7L,7L,7L,6L,6L,6L,6L,7L,6L,7L,7L,6L,6L,6L,6L,7L,6L,7L,6L,6L,7L,6L,7L,7L,7L,6L,6L,6L,7L,6L,7L,7L,7L,6L,6L,6L,6L,6L,7L,6L,6L,6L,7L,7L,6L,7L,7L,6L,7L,7L,6L,7L,6L,6L,7L,7L,6L,7L,6L,7L,7L,6L,6L,7L,7L,6L,6L,7L };
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
public class A023409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023409Inst : IEnumerable<long>
{
public static readonly long[] Value=A023409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023409.Bytes);
public long this[int i]=>Value[i];

public static A023409Inst Instance=new A023409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023410
{
public static readonly long[] Value={ 6L,9L,6L,9L,6L,6L,6L,9L,6L,9L,6L,9L,9L,6L,9L,9L,9L,9L,9L,9L,6L,9L,6L,6L,6L,9L,9L,9L,9L,9L,9L,9L,9L,6L,9L,9L,6L,9L,9L,9L,9L,9L,6L,6L,6L,6L,9L,9L,6L,9L,6L,6L,9L,6L,6L,9L,6L,6L,9L,6L,6L,6L,6L,9L,6L,6L,9L,6L,9L,9L,9L,6L,6L,9L,9L,9L,6L,9L,9L,9L,6L,6L,6L,6L,6L,9L,6L,6L,9L,9L,9L,6L,9L,6L,9L,9L,6L,9L,6L,9L,9L,6L,6L,6L,6L,6L,9L,6L };
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
public class A023410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023410Inst : IEnumerable<long>
{
public static readonly long[] Value=A023410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023410.Bytes);
public long this[int i]=>Value[i];

public static A023410Inst Instance=new A023410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023411
{
public static readonly long[] Value={ 8L,8L,8L,1L,8L,1L,8L,1L,1L,8L,8L,8L,8L,8L,8L,1L,8L,1L,8L,8L,8L,8L,1L,8L,1L,8L,1L,1L,8L,1L,1L,8L,8L,1L,1L,8L,1L,1L,8L,8L,1L,8L,1L,8L,8L,1L,8L,1L,1L,1L,8L,8L,8L,1L,8L,8L,1L,8L,1L,1L,8L,8L,1L,8L,1L,1L,1L,8L,1L,1L,1L,8L,1L,1L,1L,1L,1L,8L,8L,8L,8L,1L,8L,8L,8L,8L,8L,1L,8L,8L,8L,8L,1L,8L,8L,8L,8L,1L,8L,8L,1L,1L,8L,1L,1L,1L,1L,1L };
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
public class A023411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023411Inst : IEnumerable<long>
{
public static readonly long[] Value=A023411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023411.Bytes);
public long this[int i]=>Value[i];

public static A023411Inst Instance=new A023411Inst();

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