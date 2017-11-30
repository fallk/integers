using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021241
{
public static readonly long[] Value={ 0L,0L,4L,2L,1L,9L,4L,0L,9L,2L,8L,2L,7L,0L,0L,4L,2L,1L,9L,4L,0L,9L,2L,8L,2L,7L,0L,0L,4L,2L,1L,9L,4L,0L,9L,2L,8L,2L,7L,0L,0L,4L,2L,1L,9L,4L,0L,9L,2L,8L,2L,7L,0L,0L,4L,2L,1L,9L,4L,0L,9L,2L,8L,2L,7L,0L,0L,4L,2L,1L,9L,4L,0L,9L,2L,8L,2L,7L,0L,0L,4L,2L,1L,9L,4L,0L,9L,2L,8L,2L,7L,0L,0L,4L,2L,1L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021241Inst : IEnumerable<long>
{
public static readonly long[] Value=A021241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021241.Bytes);
public long this[int i]=>Value[i];

public static A021241Inst Instance=new A021241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021240
{
public static readonly long[] Value={ 0L,0L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021240Inst : IEnumerable<long>
{
public static readonly long[] Value=A021240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021240.Bytes);
public long this[int i]=>Value[i];

public static A021240Inst Instance=new A021240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021239
{
public static readonly long[] Value={ 0L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021239Inst : IEnumerable<long>
{
public static readonly long[] Value=A021239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021239.Bytes);
public long this[int i]=>Value[i];

public static A021239Inst Instance=new A021239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021238
{
public static readonly long[] Value={ 0L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L,2L,7L,3L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021238Inst : IEnumerable<long>
{
public static readonly long[] Value=A021238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021238.Bytes);
public long this[int i]=>Value[i];

public static A021238Inst Instance=new A021238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021237
{
public static readonly long[] Value={ 0L,0L,4L,2L,9L,1L,8L,4L,5L,4L,9L,3L,5L,6L,2L,2L,3L,1L,7L,5L,9L,6L,5L,6L,6L,5L,2L,3L,6L,0L,5L,1L,5L,0L,2L,1L,4L,5L,9L,2L,2L,7L,4L,6L,7L,8L,1L,1L,1L,5L,8L,7L,9L,8L,2L,8L,3L,2L,6L,1L,8L,0L,2L,5L,7L,5L,1L,0L,7L,2L,9L,6L,1L,3L,7L,3L,3L,9L,0L,5L,5L,7L,9L,3L,9L,9L,1L,4L,1L,6L,3L,0L,9L,0L,1L,2L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021237Inst : IEnumerable<long>
{
public static readonly long[] Value=A021237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021237.Bytes);
public long this[int i]=>Value[i];

public static A021237Inst Instance=new A021237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021236
{
public static readonly long[] Value={ 0L,0L,4L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021236Inst : IEnumerable<long>
{
public static readonly long[] Value=A021236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021236.Bytes);
public long this[int i]=>Value[i];

public static A021236Inst Instance=new A021236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021235
{
public static readonly long[] Value={ 0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L,3L,2L,9L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021235Inst : IEnumerable<long>
{
public static readonly long[] Value=A021235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021235.Bytes);
public long this[int i]=>Value[i];

public static A021235Inst Instance=new A021235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021234
{
public static readonly long[] Value={ 1L,20L,277L,3324L,37149L,398916L,4181269L,43157708L,440992717L,4475837652L,45219751941L,455427151452L,4576878947005L,45927041513828L,460378179477493L,4611536145214956L,46169641905360813L,462076382226349044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021234Inst : IEnumerable<long>
{
public static readonly long[] Value=A021234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021234.Bytes);
public long this[int i]=>Value[i];

public static A021234Inst Instance=new A021234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021233
{
public static readonly long[] Value={ 0L,0L,4L,3L,6L,6L,8L,1L,2L,2L,2L,7L,0L,7L,4L,2L,3L,5L,8L,0L,7L,8L,6L,0L,2L,6L,2L,0L,0L,8L,7L,3L,3L,6L,2L,4L,4L,5L,4L,1L,4L,8L,4L,7L,1L,6L,1L,5L,7L,2L,0L,5L,2L,4L,0L,1L,7L,4L,6L,7L,2L,4L,8L,9L,0L,8L,2L,9L,6L,9L,4L,3L,2L,3L,1L,4L,4L,1L,0L,4L,8L,0L,3L,4L,9L,3L,4L,4L,9L,7L,8L,1L,6L,5L,9L,3L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021233Inst : IEnumerable<long>
{
public static readonly long[] Value=A021233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021233.Bytes);
public long this[int i]=>Value[i];

public static A021233Inst Instance=new A021233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021232
{
public static readonly long[] Value={ 0L,0L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021232Inst : IEnumerable<long>
{
public static readonly long[] Value=A021232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021232.Bytes);
public long this[int i]=>Value[i];

public static A021232Inst Instance=new A021232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021231
{
public static readonly long[] Value={ 0L,0L,4L,4L,0L,5L,2L,8L,6L,3L,4L,3L,6L,1L,2L,3L,3L,4L,8L,0L,1L,7L,6L,2L,1L,1L,4L,5L,3L,7L,4L,4L,4L,9L,3L,3L,9L,2L,0L,7L,0L,4L,8L,4L,5L,8L,1L,4L,9L,7L,7L,9L,7L,3L,5L,6L,8L,2L,8L,1L,9L,3L,8L,3L,2L,5L,9L,9L,1L,1L,8L,9L,4L,2L,7L,3L,1L,2L,7L,7L,5L,3L,3L,0L,3L,9L,6L,4L,7L,5L,7L,7L,0L,9L,2L,5L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021231Inst : IEnumerable<long>
{
public static readonly long[] Value=A021231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021231.Bytes);
public long this[int i]=>Value[i];

public static A021231Inst Instance=new A021231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021230
{
public static readonly long[] Value={ 0L,0L,4L,4L,2L,4L,7L,7L,8L,7L,6L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L,5L,9L,2L,9L,2L,0L,3L,5L,3L,9L,8L,2L,3L,0L,0L,8L,8L,4L,9L,5L,5L,7L,5L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L,3L,1L,8L,5L,8L,4L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021230Inst : IEnumerable<long>
{
public static readonly long[] Value=A021230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021230.Bytes);
public long this[int i]=>Value[i];

public static A021230Inst Instance=new A021230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021229
{
public static readonly long[] Value={ 1L,19L,248L,2786L,28983L,288273L,2786566L,26424112L,247232645L,2291004287L,21080414004L,192953358078L,1759187655187L,15990940940461L,145026232803362L,1312990445670284L,11871194464243809L,107220713350935195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021229Inst : IEnumerable<long>
{
public static readonly long[] Value=A021229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021229.Bytes);
public long this[int i]=>Value[i];

public static A021229Inst Instance=new A021229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021228
{
public static readonly long[] Value={ 0L,0L,4L,4L,6L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021228Inst : IEnumerable<long>
{
public static readonly long[] Value=A021228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021228.Bytes);
public long this[int i]=>Value[i];

public static A021228Inst Instance=new A021228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021227
{
public static readonly long[] Value={ 0L,0L,4L,4L,8L,4L,3L,0L,4L,9L,3L,2L,7L,3L,5L,4L,2L,6L,0L,0L,8L,9L,6L,8L,6L,0L,9L,8L,6L,5L,4L,7L,0L,8L,5L,2L,0L,1L,7L,9L,3L,7L,2L,1L,9L,7L,3L,0L,9L,4L,1L,7L,0L,4L,0L,3L,5L,8L,7L,4L,4L,3L,9L,4L,6L,1L,8L,8L,3L,4L,0L,8L,0L,7L,1L,7L,4L,8L,8L,7L,8L,9L,2L,3L,7L,6L,6L,8L,1L,6L,1L,4L,3L,4L,9L,7L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021227Inst : IEnumerable<long>
{
public static readonly long[] Value=A021227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021227.Bytes);
public long this[int i]=>Value[i];

public static A021227Inst Instance=new A021227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021226
{
public static readonly long[] Value={ 0L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021226Inst : IEnumerable<long>
{
public static readonly long[] Value=A021226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021226.Bytes);
public long this[int i]=>Value[i];

public static A021226Inst Instance=new A021226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021225
{
public static readonly long[] Value={ 0L,0L,4L,5L,2L,4L,8L,8L,6L,8L,7L,7L,8L,2L,8L,0L,5L,4L,2L,9L,8L,6L,4L,2L,5L,3L,3L,9L,3L,6L,6L,5L,1L,5L,8L,3L,7L,1L,0L,4L,0L,7L,2L,3L,9L,8L,1L,9L,0L,0L,4L,5L,2L,4L,8L,8L,6L,8L,7L,7L,8L,2L,8L,0L,5L,4L,2L,9L,8L,6L,4L,2L,5L,3L,3L,9L,3L,6L,6L,5L,1L,5L,8L,3L,7L,1L,0L,4L,0L,7L,2L,3L,9L,8L,1L,9L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021225Inst : IEnumerable<long>
{
public static readonly long[] Value=A021225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021225.Bytes);
public long this[int i]=>Value[i];

public static A021225Inst Instance=new A021225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021224
{
public static readonly long[] Value={ 1L,18L,221L,2322L,22485L,207306L,1850557L,16149474L,138611429L,1174801914L,9859790733L,82107957906L,679471095733L,5594020809642L,45859930816349L,374633796970818L,3051350828977797L,24790769804563290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021224Inst : IEnumerable<long>
{
public static readonly long[] Value=A021224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021224.Bytes);
public long this[int i]=>Value[i];

public static A021224Inst Instance=new A021224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021223
{
public static readonly long[] Value={ 0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L,5L,6L,6L,2L,1L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021223Inst : IEnumerable<long>
{
public static readonly long[] Value=A021223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021223.Bytes);
public long this[int i]=>Value[i];

public static A021223Inst Instance=new A021223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021222
{
public static readonly long[] Value={ 0L,0L,4L,5L,8L,7L,1L,5L,5L,9L,6L,3L,3L,0L,2L,7L,5L,2L,2L,9L,3L,5L,7L,7L,9L,8L,1L,6L,5L,1L,3L,7L,6L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L,7L,2L,4L,7L,7L,0L,6L,4L,2L,2L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L,0L,0L,9L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021222Inst : IEnumerable<long>
{
public static readonly long[] Value=A021222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021222.Bytes);
public long this[int i]=>Value[i];

public static A021222Inst Instance=new A021222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021221
{
public static readonly long[] Value={ 0L,0L,4L,6L,0L,8L,2L,9L,4L,9L,3L,0L,8L,7L,5L,5L,7L,6L,0L,3L,6L,8L,6L,6L,3L,5L,9L,4L,4L,7L,0L,0L,4L,6L,0L,8L,2L,9L,4L,9L,3L,0L,8L,7L,5L,5L,7L,6L,0L,3L,6L,8L,6L,6L,3L,5L,9L,4L,4L,7L,0L,0L,4L,6L,0L,8L,2L,9L,4L,9L,3L,0L,8L,7L,5L,5L,7L,6L,0L,3L,6L,8L,6L,6L,3L,5L,9L,4L,4L,7L,0L,0L,4L,6L,0L,8L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021221Inst : IEnumerable<long>
{
public static readonly long[] Value=A021221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021221.Bytes);
public long this[int i]=>Value[i];

public static A021221Inst Instance=new A021221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021220
{
public static readonly long[] Value={ 0L,0L,4L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021220Inst : IEnumerable<long>
{
public static readonly long[] Value=A021220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021220.Bytes);
public long this[int i]=>Value[i];

public static A021220Inst Instance=new A021220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021219
{
public static readonly long[] Value={ 0L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021219Inst : IEnumerable<long>
{
public static readonly long[] Value=A021219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021219.Bytes);
public long this[int i]=>Value[i];

public static A021219Inst Instance=new A021219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021218
{
public static readonly long[] Value={ 0L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021218Inst : IEnumerable<long>
{
public static readonly long[] Value=A021218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021218.Bytes);
public long this[int i]=>Value[i];

public static A021218Inst Instance=new A021218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021217
{
public static readonly long[] Value={ 0L,0L,4L,6L,9L,4L,8L,3L,5L,6L,8L,0L,7L,5L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L,8L,3L,5L,6L,8L,0L,7L,5L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L,8L,3L,5L,6L,8L,0L,7L,5L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021217Inst : IEnumerable<long>
{
public static readonly long[] Value=A021217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021217.Bytes);
public long this[int i]=>Value[i];

public static A021217Inst Instance=new A021217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021216
{
public static readonly long[] Value={ 0L,0L,4L,7L,1L,6L,9L,8L,1L,1L,3L,2L,0L,7L,5L,4L,7L,1L,6L,9L,8L,1L,1L,3L,2L,0L,7L,5L,4L,7L,1L,6L,9L,8L,1L,1L,3L,2L,0L,7L,5L,4L,7L,1L,6L,9L,8L,1L,1L,3L,2L,0L,7L,5L,4L,7L,1L,6L,9L,8L,1L,1L,3L,2L,0L,7L,5L,4L,7L,1L,6L,9L,8L,1L,1L,3L,2L,0L,7L,5L,4L,7L,1L,6L,9L,8L,1L,1L,3L,2L,0L,7L,5L,4L,7L,1L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021216Inst : IEnumerable<long>
{
public static readonly long[] Value=A021216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021216.Bytes);
public long this[int i]=>Value[i];

public static A021216Inst Instance=new A021216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021215
{
public static readonly long[] Value={ 0L,0L,4L,7L,3L,9L,3L,3L,6L,4L,9L,2L,8L,9L,0L,9L,9L,5L,2L,6L,0L,6L,6L,3L,5L,0L,7L,1L,0L,9L,0L,0L,4L,7L,3L,9L,3L,3L,6L,4L,9L,2L,8L,9L,0L,9L,9L,5L,2L,6L,0L,6L,6L,3L,5L,0L,7L,1L,0L,9L,0L,0L,4L,7L,3L,9L,3L,3L,6L,4L,9L,2L,8L,9L,0L,9L,9L,5L,2L,6L,0L,6L,6L,3L,5L,0L,7L,1L,0L,9L,0L,0L,4L,7L,3L,9L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021215Inst : IEnumerable<long>
{
public static readonly long[] Value=A021215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021215.Bytes);
public long this[int i]=>Value[i];

public static A021215Inst Instance=new A021215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021214
{
public static readonly long[] Value={ 1L,21L,313L,4137L,51961L,637497L,7733881L,93310329L,1122747001L,13491103353L,162002078329L,1944677972601L,23340053875321L,280104155744889L,3361390924417657L,40337537425951353L,484055527109184121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021214Inst : IEnumerable<long>
{
public static readonly long[] Value=A021214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021214.Bytes);
public long this[int i]=>Value[i];

public static A021214Inst Instance=new A021214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021213
{
public static readonly long[] Value={ 0L,0L,4L,7L,8L,4L,6L,8L,8L,9L,9L,5L,2L,1L,5L,3L,1L,1L,0L,0L,4L,7L,8L,4L,6L,8L,8L,9L,9L,5L,2L,1L,5L,3L,1L,1L,0L,0L,4L,7L,8L,4L,6L,8L,8L,9L,9L,5L,2L,1L,5L,3L,1L,1L,0L,0L,4L,7L,8L,4L,6L,8L,8L,9L,9L,5L,2L,1L,5L,3L,1L,1L,0L,0L,4L,7L,8L,4L,6L,8L,8L,9L,9L,5L,2L,1L,5L,3L,1L,1L,0L,0L,4L,7L,8L,4L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021213Inst : IEnumerable<long>
{
public static readonly long[] Value=A021213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021213.Bytes);
public long this[int i]=>Value[i];

public static A021213Inst Instance=new A021213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021212
{
public static readonly long[] Value={ 0L,0L,4L,8L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021212Inst : IEnumerable<long>
{
public static readonly long[] Value=A021212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021212.Bytes);
public long this[int i]=>Value[i];

public static A021212Inst Instance=new A021212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021211
{
public static readonly long[] Value={ 0L,0L,4L,8L,3L,0L,9L,1L,7L,8L,7L,4L,3L,9L,6L,1L,3L,5L,2L,6L,5L,7L,0L,0L,4L,8L,3L,0L,9L,1L,7L,8L,7L,4L,3L,9L,6L,1L,3L,5L,2L,6L,5L,7L,0L,0L,4L,8L,3L,0L,9L,1L,7L,8L,7L,4L,3L,9L,6L,1L,3L,5L,2L,6L,5L,7L,0L,0L,4L,8L,3L,0L,9L,1L,7L,8L,7L,4L,3L,9L,6L,1L,3L,5L,2L,6L,5L,7L,0L,0L,4L,8L,3L,0L,9L,1L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021211Inst : IEnumerable<long>
{
public static readonly long[] Value=A021211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021211.Bytes);
public long this[int i]=>Value[i];

public static A021211Inst Instance=new A021211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021210
{
public static readonly long[] Value={ 0L,0L,4L,8L,5L,4L,3L,6L,8L,9L,3L,2L,0L,3L,8L,8L,3L,4L,9L,5L,1L,4L,5L,6L,3L,1L,0L,6L,7L,9L,6L,1L,1L,6L,5L,0L,4L,8L,5L,4L,3L,6L,8L,9L,3L,2L,0L,3L,8L,8L,3L,4L,9L,5L,1L,4L,5L,6L,3L,1L,0L,6L,7L,9L,6L,1L,1L,6L,5L,0L,4L,8L,5L,4L,3L,6L,8L,9L,3L,2L,0L,3L,8L,8L,3L,4L,9L,5L,1L,4L,5L,6L,3L,1L,0L,6L,7L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021210Inst : IEnumerable<long>
{
public static readonly long[] Value=A021210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021210.Bytes);
public long this[int i]=>Value[i];

public static A021210Inst Instance=new A021210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021209
{
public static readonly long[] Value={ 0L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021209Inst : IEnumerable<long>
{
public static readonly long[] Value=A021209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021209.Bytes);
public long this[int i]=>Value[i];

public static A021209Inst Instance=new A021209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021208
{
public static readonly long[] Value={ 0L,0L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021208Inst : IEnumerable<long>
{
public static readonly long[] Value=A021208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021208.Bytes);
public long this[int i]=>Value[i];

public static A021208Inst Instance=new A021208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021207
{
public static readonly long[] Value={ 0L,0L,4L,9L,2L,6L,1L,0L,8L,3L,7L,4L,3L,8L,4L,2L,3L,6L,4L,5L,3L,2L,0L,1L,9L,7L,0L,4L,4L,3L,3L,4L,9L,7L,5L,3L,6L,9L,4L,5L,8L,1L,2L,8L,0L,7L,8L,8L,1L,7L,7L,3L,3L,9L,9L,0L,1L,4L,7L,7L,8L,3L,2L,5L,1L,2L,3L,1L,5L,2L,7L,0L,9L,3L,5L,9L,6L,0L,5L,9L,1L,1L,3L,3L,0L,0L,4L,9L,2L,6L,1L,0L,8L,3L,7L,4L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021207Inst : IEnumerable<long>
{
public static readonly long[] Value=A021207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021207.Bytes);
public long this[int i]=>Value[i];

public static A021207Inst Instance=new A021207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021206
{
public static readonly long[] Value={ 0L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L,9L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021206Inst : IEnumerable<long>
{
public static readonly long[] Value=A021206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021206.Bytes);
public long this[int i]=>Value[i];

public static A021206Inst Instance=new A021206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021205
{
public static readonly long[] Value={ 0L,0L,4L,9L,7L,5L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L,7L,5L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L,7L,5L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021205Inst : IEnumerable<long>
{
public static readonly long[] Value=A021205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021205.Bytes);
public long this[int i]=>Value[i];

public static A021205Inst Instance=new A021205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021204
{
public static readonly BigInteger[] Value={ 1L,20L,281L,3472L,40509L,459564L,5139121L,57034088L,630398021L,6952517572L,76586531385L,843104877888L,9278071860877L,102082299710684L,1123046352296513L,12354356208201112L,135902996287980117L,1494963427154650740L,16444780506622899145UL,BigInteger.Parse("180893682420383385200") };
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
public class A021204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A021204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A021204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A021204Inst Instance=new A021204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021203
{
public static readonly long[] Value={ 0L,0L,5L,0L,2L,5L,1L,2L,5L,6L,2L,8L,1L,4L,0L,7L,0L,3L,5L,1L,7L,5L,8L,7L,9L,3L,9L,6L,9L,8L,4L,9L,2L,4L,6L,2L,3L,1L,1L,5L,5L,7L,7L,8L,8L,9L,4L,4L,7L,2L,3L,6L,1L,8L,0L,9L,0L,4L,5L,2L,2L,6L,1L,3L,0L,6L,5L,3L,2L,6L,6L,3L,3L,1L,6L,5L,8L,2L,9L,1L,4L,5L,7L,2L,8L,6L,4L,3L,2L,1L,6L,0L,8L,0L,4L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021203Inst : IEnumerable<long>
{
public static readonly long[] Value=A021203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021203.Bytes);
public long this[int i]=>Value[i];

public static A021203Inst Instance=new A021203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021202
{
public static readonly BigInteger[] Value={ 1L,19L,251L,2891L,31227L,326235L,3346267L,33966427L,342687323L,3445012571L,34558963803L,346242670683L,3466344910939L,34686958350427L,347010638983259L,3470952722772059L,34714605225488475L,347176520241754203L,3471948010339283035L,BigInteger.Parse("34720576950924324955") };
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
public class A021202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A021202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A021202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A021202Inst Instance=new A021202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021201
{
public static readonly long[] Value={ 0L,0L,5L,0L,7L,6L,1L,4L,2L,1L,3L,1L,9L,7L,9L,6L,9L,5L,4L,3L,1L,4L,7L,2L,0L,8L,1L,2L,1L,8L,2L,7L,4L,1L,1L,1L,6L,7L,5L,1L,2L,6L,9L,0L,3L,5L,5L,3L,2L,9L,9L,4L,9L,2L,3L,8L,5L,7L,8L,6L,8L,0L,2L,0L,3L,0L,4L,5L,6L,8L,5L,2L,7L,9L,1L,8L,7L,8L,1L,7L,2L,5L,8L,8L,8L,3L,2L,4L,8L,7L,3L,0L,9L,6L,4L,4L,6L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021201Inst : IEnumerable<long>
{
public static readonly long[] Value=A021201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021201.Bytes);
public long this[int i]=>Value[i];

public static A021201Inst Instance=new A021201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021200
{
public static readonly long[] Value={ 0L,0L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021200Inst : IEnumerable<long>
{
public static readonly long[] Value=A021200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021200.Bytes);
public long this[int i]=>Value[i];

public static A021200Inst Instance=new A021200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021199
{
public static readonly long[] Value={ 0L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021199Inst : IEnumerable<long>
{
public static readonly long[] Value=A021199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021199.Bytes);
public long this[int i]=>Value[i];

public static A021199Inst Instance=new A021199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021198
{
public static readonly long[] Value={ 0L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021198Inst : IEnumerable<long>
{
public static readonly long[] Value=A021198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021198.Bytes);
public long this[int i]=>Value[i];

public static A021198Inst Instance=new A021198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021197
{
public static readonly long[] Value={ 0L,0L,5L,1L,8L,1L,3L,4L,7L,1L,5L,0L,2L,5L,9L,0L,6L,7L,3L,5L,7L,5L,1L,2L,9L,5L,3L,3L,6L,7L,8L,7L,5L,6L,4L,7L,6L,6L,8L,3L,9L,3L,7L,8L,2L,3L,8L,3L,4L,1L,9L,6L,8L,9L,1L,1L,9L,1L,7L,0L,9L,8L,4L,4L,5L,5L,9L,5L,8L,5L,4L,9L,2L,2L,2L,7L,9L,7L,9L,2L,7L,4L,6L,1L,1L,3L,9L,8L,9L,6L,3L,7L,3L,0L,5L,6L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021197Inst : IEnumerable<long>
{
public static readonly long[] Value=A021197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021197.Bytes);
public long this[int i]=>Value[i];

public static A021197Inst Instance=new A021197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021196
{
public static readonly long[] Value={ 0L,0L,5L,2L,0L,8L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021196Inst : IEnumerable<long>
{
public static readonly long[] Value=A021196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021196.Bytes);
public long this[int i]=>Value[i];

public static A021196Inst Instance=new A021196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021195
{
public static readonly long[] Value={ 0L,0L,5L,2L,3L,5L,6L,0L,2L,0L,9L,4L,2L,4L,0L,8L,3L,7L,6L,9L,6L,3L,3L,5L,0L,7L,8L,5L,3L,4L,0L,3L,1L,4L,1L,3L,6L,1L,2L,5L,6L,5L,4L,4L,5L,0L,2L,6L,1L,7L,8L,0L,1L,0L,4L,7L,1L,2L,0L,4L,1L,8L,8L,4L,8L,1L,6L,7L,5L,3L,9L,2L,6L,7L,0L,1L,5L,7L,0L,6L,8L,0L,6L,2L,8L,2L,7L,2L,2L,5L,1L,3L,0L,8L,9L,0L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021195Inst : IEnumerable<long>
{
public static readonly long[] Value=A021195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021195.Bytes);
public long this[int i]=>Value[i];

public static A021195Inst Instance=new A021195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021194
{
public static readonly long[] Value={ 1L,18L,223L,2388L,23809L,228246L,2138131L,19746936L,180745477L,1644848634L,14912475799L,134865314844L,1217706037705L,10982863580382L,98986827702427L,891727782261312L,8030628038119693L,72306120329946690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021194Inst : IEnumerable<long>
{
public static readonly long[] Value=A021194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021194.Bytes);
public long this[int i]=>Value[i];

public static A021194Inst Instance=new A021194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021193
{
public static readonly long[] Value={ 0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L,2L,9L,1L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021193Inst : IEnumerable<long>
{
public static readonly long[] Value=A021193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021193.Bytes);
public long this[int i]=>Value[i];

public static A021193Inst Instance=new A021193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021192
{
public static readonly long[] Value={ 0L,0L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021192Inst : IEnumerable<long>
{
public static readonly long[] Value=A021192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021192.Bytes);
public long this[int i]=>Value[i];

public static A021192Inst Instance=new A021192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021191
{
public static readonly long[] Value={ 0L,0L,5L,3L,4L,7L,5L,9L,3L,5L,8L,2L,8L,8L,7L,7L,0L,0L,5L,3L,4L,7L,5L,9L,3L,5L,8L,2L,8L,8L,7L,7L,0L,0L,5L,3L,4L,7L,5L,9L,3L,5L,8L,2L,8L,8L,7L,7L,0L,0L,5L,3L,4L,7L,5L,9L,3L,5L,8L,2L,8L,8L,7L,7L,0L,0L,5L,3L,4L,7L,5L,9L,3L,5L,8L,2L,8L,8L,7L,7L,0L,0L,5L,3L,4L,7L,5L,9L,3L,5L,8L,2L,8L,8L,7L,7L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021191Inst : IEnumerable<long>
{
public static readonly long[] Value=A021191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021191.Bytes);
public long this[int i]=>Value[i];

public static A021191Inst Instance=new A021191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021190
{
public static readonly long[] Value={ 0L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021190Inst : IEnumerable<long>
{
public static readonly long[] Value=A021190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021190.Bytes);
public long this[int i]=>Value[i];

public static A021190Inst Instance=new A021190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021189
{
public static readonly long[] Value={ 0L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021189Inst : IEnumerable<long>
{
public static readonly long[] Value=A021189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021189.Bytes);
public long this[int i]=>Value[i];

public static A021189Inst Instance=new A021189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021188
{
public static readonly long[] Value={ 0L,0L,5L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021188Inst : IEnumerable<long>
{
public static readonly long[] Value=A021188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021188.Bytes);
public long this[int i]=>Value[i];

public static A021188Inst Instance=new A021188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021187
{
public static readonly long[] Value={ 0L,0L,5L,4L,6L,4L,4L,8L,0L,8L,7L,4L,3L,1L,6L,9L,3L,9L,8L,9L,0L,7L,1L,0L,3L,8L,2L,5L,1L,3L,6L,6L,1L,2L,0L,2L,1L,8L,5L,7L,9L,2L,3L,4L,9L,7L,2L,6L,7L,7L,5L,9L,5L,6L,2L,8L,4L,1L,5L,3L,0L,0L,5L,4L,6L,4L,4L,8L,0L,8L,7L,4L,3L,1L,6L,9L,3L,9L,8L,9L,0L,7L,1L,0L,3L,8L,2L,5L,1L,3L,6L,6L,1L,2L,0L,2L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021187Inst : IEnumerable<long>
{
public static readonly long[] Value=A021187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021187.Bytes);
public long this[int i]=>Value[i];

public static A021187Inst Instance=new A021187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021186
{
public static readonly long[] Value={ 0L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L,4L,9L,4L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021186Inst : IEnumerable<long>
{
public static readonly long[] Value=A021186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021186.Bytes);
public long this[int i]=>Value[i];

public static A021186Inst Instance=new A021186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021185
{
public static readonly long[] Value={ 0L,0L,5L,5L,2L,4L,8L,6L,1L,8L,7L,8L,4L,5L,3L,0L,3L,8L,6L,7L,4L,0L,3L,3L,1L,4L,9L,1L,7L,1L,2L,7L,0L,7L,1L,8L,2L,3L,2L,0L,4L,4L,1L,9L,8L,8L,9L,5L,0L,2L,7L,6L,2L,4L,3L,0L,9L,3L,9L,2L,2L,6L,5L,1L,9L,3L,3L,7L,0L,1L,6L,5L,7L,4L,5L,8L,5L,6L,3L,5L,3L,5L,9L,1L,1L,6L,0L,2L,2L,0L,9L,9L,4L,4L,7L,5L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021185Inst : IEnumerable<long>
{
public static readonly long[] Value=A021185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021185.Bytes);
public long this[int i]=>Value[i];

public static A021185Inst Instance=new A021185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021184
{
public static readonly long[] Value={ 1L,17L,197L,1957L,17973L,157749L,1345909L,11271029L,93191285L,763669621L,6218195061L,50398593141L,407106949237L,3280364834933L,26383974158453L,211918126207093L,1700423007424629L,13633852046266485L,109253624291872885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021184Inst : IEnumerable<long>
{
public static readonly long[] Value=A021184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021184.Bytes);
public long this[int i]=>Value[i];

public static A021184Inst Instance=new A021184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021183
{
public static readonly long[] Value={ 0L,0L,5L,5L,8L,6L,5L,9L,2L,1L,7L,8L,7L,7L,0L,9L,4L,9L,7L,2L,0L,6L,7L,0L,3L,9L,1L,0L,6L,1L,4L,5L,2L,5L,1L,3L,9L,6L,6L,4L,8L,0L,4L,4L,6L,9L,2L,7L,3L,7L,4L,3L,0L,1L,6L,7L,5L,9L,7L,7L,6L,5L,3L,6L,3L,1L,2L,8L,4L,9L,1L,6L,2L,0L,1L,1L,1L,7L,3L,1L,8L,4L,3L,5L,7L,5L,4L,1L,8L,9L,9L,4L,4L,1L,3L,4L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021183Inst : IEnumerable<long>
{
public static readonly long[] Value=A021183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021183.Bytes);
public long this[int i]=>Value[i];

public static A021183Inst Instance=new A021183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021182
{
public static readonly long[] Value={ 0L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021182Inst : IEnumerable<long>
{
public static readonly long[] Value=A021182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021182.Bytes);
public long this[int i]=>Value[i];

public static A021182Inst Instance=new A021182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021165
{
public static readonly long[] Value={ 0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L,9L,9L,3L,7L,8L,8L,8L,1L,9L,8L,7L,5L,7L,7L,6L,3L,9L,7L,5L,1L,5L,5L,2L,7L,9L,5L,0L,3L,1L,0L,5L,5L,9L,0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021165Inst : IEnumerable<long>
{
public static readonly long[] Value=A021165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021165.Bytes);
public long this[int i]=>Value[i];

public static A021165Inst Instance=new A021165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021164
{
public static readonly long[] Value={ 1L,20L,287L,3694L,45609L,553776L,6677779L,80295938L,964364717L,11576444932L,138937682871L,1667353916982L,20008755624625L,240107610616088L,2881304043028763L,34575712094589226L,414908863026422133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021164Inst : IEnumerable<long>
{
public static readonly long[] Value=A021164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021164.Bytes);
public long this[int i]=>Value[i];

public static A021164Inst Instance=new A021164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021163
{
public static readonly long[] Value={ 0L,0L,6L,2L,8L,9L,3L,0L,8L,1L,7L,6L,1L,0L,0L,6L,2L,8L,9L,3L,0L,8L,1L,7L,6L,1L,0L,0L,6L,2L,8L,9L,3L,0L,8L,1L,7L,6L,1L,0L,0L,6L,2L,8L,9L,3L,0L,8L,1L,7L,6L,1L,0L,0L,6L,2L,8L,9L,3L,0L,8L,1L,7L,6L,1L,0L,0L,6L,2L,8L,9L,3L,0L,8L,1L,7L,6L,1L,0L,0L,6L,2L,8L,9L,3L,0L,8L,1L,7L,6L,1L,0L,0L,6L,2L,8L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021163Inst : IEnumerable<long>
{
public static readonly long[] Value=A021163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021163.Bytes);
public long this[int i]=>Value[i];

public static A021163Inst Instance=new A021163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021162
{
public static readonly long[] Value={ 0L,0L,6L,3L,2L,9L,1L,1L,3L,9L,2L,4L,0L,5L,0L,6L,3L,2L,9L,1L,1L,3L,9L,2L,4L,0L,5L,0L,6L,3L,2L,9L,1L,1L,3L,9L,2L,4L,0L,5L,0L,6L,3L,2L,9L,1L,1L,3L,9L,2L,4L,0L,5L,0L,6L,3L,2L,9L,1L,1L,3L,9L,2L,4L,0L,5L,0L,6L,3L,2L,9L,1L,1L,3L,9L,2L,4L,0L,5L,0L,6L,3L,2L,9L,1L,1L,3L,9L,2L,4L,0L,5L,0L,6L,3L,2L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021162Inst : IEnumerable<long>
{
public static readonly long[] Value=A021162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021162.Bytes);
public long this[int i]=>Value[i];

public static A021162Inst Instance=new A021162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021161
{
public static readonly long[] Value={ 0L,0L,6L,3L,6L,9L,4L,2L,6L,7L,5L,1L,5L,9L,2L,3L,5L,6L,6L,8L,7L,8L,9L,8L,0L,8L,9L,1L,7L,1L,9L,7L,4L,5L,2L,2L,2L,9L,2L,9L,9L,3L,6L,3L,0L,5L,7L,3L,2L,4L,8L,4L,0L,7L,6L,4L,3L,3L,1L,2L,1L,0L,1L,9L,1L,0L,8L,2L,8L,0L,2L,5L,4L,7L,7L,7L,0L,7L,0L,0L,6L,3L,6L,9L,4L,2L,6L,7L,5L,1L,5L,9L,2L,3L,5L,6L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021161Inst : IEnumerable<long>
{
public static readonly long[] Value=A021161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021161.Bytes);
public long this[int i]=>Value[i];

public static A021161Inst Instance=new A021161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021160
{
public static readonly long[] Value={ 0L,0L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021160Inst : IEnumerable<long>
{
public static readonly long[] Value=A021160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021160.Bytes);
public long this[int i]=>Value[i];

public static A021160Inst Instance=new A021160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021159
{
public static readonly long[] Value={ 0L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021159Inst : IEnumerable<long>
{
public static readonly long[] Value=A021159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021159.Bytes);
public long this[int i]=>Value[i];

public static A021159Inst Instance=new A021159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021158
{
public static readonly long[] Value={ 0L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L,4L,9L,3L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021158Inst : IEnumerable<long>
{
public static readonly long[] Value=A021158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021158.Bytes);
public long this[int i]=>Value[i];

public static A021158Inst Instance=new A021158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021157
{
public static readonly long[] Value={ 0L,0L,6L,5L,3L,5L,9L,4L,7L,7L,1L,2L,4L,1L,8L,3L,0L,0L,6L,5L,3L,5L,9L,4L,7L,7L,1L,2L,4L,1L,8L,3L,0L,0L,6L,5L,3L,5L,9L,4L,7L,7L,1L,2L,4L,1L,8L,3L,0L,0L,6L,5L,3L,5L,9L,4L,7L,7L,1L,2L,4L,1L,8L,3L,0L,0L,6L,5L,3L,5L,9L,4L,7L,7L,1L,2L,4L,1L,8L,3L,0L,0L,6L,5L,3L,5L,9L,4L,7L,7L,1L,2L,4L,1L,8L,3L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021157Inst : IEnumerable<long>
{
public static readonly long[] Value=A021157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021157.Bytes);
public long this[int i]=>Value[i];

public static A021157Inst Instance=new A021157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021156
{
public static readonly long[] Value={ 0L,0L,6L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021156Inst : IEnumerable<long>
{
public static readonly long[] Value=A021156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021156.Bytes);
public long this[int i]=>Value[i];

public static A021156Inst Instance=new A021156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021155
{
public static readonly long[] Value={ 0L,0L,6L,6L,2L,2L,5L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L,2L,0L,5L,2L,9L,8L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L,3L,6L,4L,2L,3L,8L,4L,1L,0L,5L,9L,6L,0L,2L,6L,4L,9L,0L,0L,6L,6L,2L,2L,5L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021155Inst : IEnumerable<long>
{
public static readonly long[] Value=A021155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021155.Bytes);
public long this[int i]=>Value[i];

public static A021155Inst Instance=new A021155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021154
{
public static readonly long[] Value={ 1L,19L,256L,3066L,35007L,391545L,4339462L,47896672L,527676853L,5808513711L,63913994508L,703155662118L,7735220904139L,85089973066117L,936002419362994L,10296090191237004L,113257309994958465L,1245831999401562363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021154Inst : IEnumerable<long>
{
public static readonly long[] Value=A021154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021154.Bytes);
public long this[int i]=>Value[i];

public static A021154Inst Instance=new A021154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021153
{
public static readonly long[] Value={ 0L,0L,6L,7L,1L,1L,4L,0L,9L,3L,9L,5L,9L,7L,3L,1L,5L,4L,3L,6L,2L,4L,1L,6L,1L,0L,7L,3L,8L,2L,5L,5L,0L,3L,3L,5L,5L,7L,0L,4L,6L,9L,7L,9L,8L,6L,5L,7L,7L,1L,8L,1L,2L,0L,8L,0L,5L,3L,6L,9L,1L,2L,7L,5L,1L,6L,7L,7L,8L,5L,2L,3L,4L,8L,9L,9L,3L,2L,8L,8L,5L,9L,0L,6L,0L,4L,0L,2L,6L,8L,4L,5L,6L,3L,7L,5L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021153Inst : IEnumerable<long>
{
public static readonly long[] Value=A021153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021153.Bytes);
public long this[int i]=>Value[i];

public static A021153Inst Instance=new A021153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021152
{
public static readonly long[] Value={ 0L,0L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021152Inst : IEnumerable<long>
{
public static readonly long[] Value=A021152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021152.Bytes);
public long this[int i]=>Value[i];

public static A021152Inst Instance=new A021152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021151
{
public static readonly long[] Value={ 0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L,8L,4L,3L,5L,3L,7L,4L,1L,4L,9L,6L,5L,9L,8L,6L,3L,9L,4L,5L,5L,7L,8L,2L,3L,1L,2L,9L,2L,5L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L,8L,4L,3L,5L,3L,7L,4L,1L,4L,9L,6L,5L,9L,8L,6L,3L,9L,4L,5L,5L,7L,8L,2L,3L,1L,2L,9L,2L,5L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L,8L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021151Inst : IEnumerable<long>
{
public static readonly long[] Value=A021151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021151.Bytes);
public long this[int i]=>Value[i];

public static A021151Inst Instance=new A021151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021150
{
public static readonly long[] Value={ 0L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L,8L,4L,9L,3L,1L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021150Inst : IEnumerable<long>
{
public static readonly long[] Value=A021150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021150.Bytes);
public long this[int i]=>Value[i];

public static A021150Inst Instance=new A021150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021133
{
public static readonly long[] Value={ 0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021133Inst : IEnumerable<long>
{
public static readonly long[] Value=A021133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021133.Bytes);
public long this[int i]=>Value[i];

public static A021133Inst Instance=new A021133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021132
{
public static readonly long[] Value={ 0L,0L,7L,8L,1L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021132Inst : IEnumerable<long>
{
public static readonly long[] Value=A021132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021132.Bytes);
public long this[int i]=>Value[i];

public static A021132Inst Instance=new A021132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021131
{
public static readonly long[] Value={ 0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021131Inst : IEnumerable<long>
{
public static readonly long[] Value=A021131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021131.Bytes);
public long this[int i]=>Value[i];

public static A021131Inst Instance=new A021131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021130
{
public static readonly long[] Value={ 0L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021130Inst : IEnumerable<long>
{
public static readonly long[] Value=A021130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021130.Bytes);
public long this[int i]=>Value[i];

public static A021130Inst Instance=new A021130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021129
{
public static readonly long[] Value={ 1L,16L,175L,1650L,14481L,122316L,1010995L,8250550L,66817861L,538611216L,4329233415L,34735589850L,278393339641L,2229689837716L,17850234337435L,142865452943550L,1143241514899821L,9147521576217816L,73188119895363055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021129Inst : IEnumerable<long>
{
public static readonly long[] Value=A021129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021129.Bytes);
public long this[int i]=>Value[i];

public static A021129Inst Instance=new A021129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021128
{
public static readonly long[] Value={ 0L,0L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021128Inst : IEnumerable<long>
{
public static readonly long[] Value=A021128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021128.Bytes);
public long this[int i]=>Value[i];

public static A021128Inst Instance=new A021128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021127
{
public static readonly long[] Value={ 0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021127Inst : IEnumerable<long>
{
public static readonly long[] Value=A021127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021127.Bytes);
public long this[int i]=>Value[i];

public static A021127Inst Instance=new A021127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021126
{
public static readonly long[] Value={ 0L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021126Inst : IEnumerable<long>
{
public static readonly long[] Value=A021126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021126.Bytes);
public long this[int i]=>Value[i];

public static A021126Inst Instance=new A021126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021125
{
public static readonly long[] Value={ 0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021125Inst : IEnumerable<long>
{
public static readonly long[] Value=A021125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021125.Bytes);
public long this[int i]=>Value[i];

public static A021125Inst Instance=new A021125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021124
{
public static readonly long[] Value={ 1L,15L,152L,1314L,10479L,79821L,591214L,4301088L,30921077L,220515867L,1563954756L,11049405822L,77854461595L,547524351753L,3845386097978L,26981280929916L,189186857860833L,1325897462045079L,9289229519936080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021124Inst : IEnumerable<long>
{
public static readonly long[] Value=A021124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021124.Bytes);
public long this[int i]=>Value[i];

public static A021124Inst Instance=new A021124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021123
{
public static readonly long[] Value={ 0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021123Inst : IEnumerable<long>
{
public static readonly long[] Value=A021123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021123.Bytes);
public long this[int i]=>Value[i];

public static A021123Inst Instance=new A021123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021122
{
public static readonly long[] Value={ 0L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021122Inst : IEnumerable<long>
{
public static readonly long[] Value=A021122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021122.Bytes);
public long this[int i]=>Value[i];

public static A021122Inst Instance=new A021122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021121
{
public static readonly long[] Value={ 0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021121Inst : IEnumerable<long>
{
public static readonly long[] Value=A021121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021121.Bytes);
public long this[int i]=>Value[i];

public static A021121Inst Instance=new A021121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021120
{
public static readonly long[] Value={ 0L,0L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021120Inst : IEnumerable<long>
{
public static readonly long[] Value=A021120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021120.Bytes);
public long this[int i]=>Value[i];

public static A021120Inst Instance=new A021120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021119
{
public static readonly long[] Value={ 0L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021119Inst : IEnumerable<long>
{
public static readonly long[] Value=A021119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021119.Bytes);
public long this[int i]=>Value[i];

public static A021119Inst Instance=new A021119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021118
{
public static readonly long[] Value={ 0L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021118Inst : IEnumerable<long>
{
public static readonly long[] Value=A021118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021118.Bytes);
public long this[int i]=>Value[i];

public static A021118Inst Instance=new A021118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021117
{
public static readonly long[] Value={ 0L,0L,8L,8L,4L,9L,5L,5L,7L,5L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L,3L,1L,8L,5L,8L,4L,0L,7L,0L,7L,9L,6L,4L,6L,0L,1L,7L,6L,9L,9L,1L,1L,5L,0L,4L,4L,2L,4L,7L,7L,8L,7L,6L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021117Inst : IEnumerable<long>
{
public static readonly long[] Value=A021117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021117.Bytes);
public long this[int i]=>Value[i];

public static A021117Inst Instance=new A021117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021116
{
public static readonly long[] Value={ 0L,0L,8L,9L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021116Inst : IEnumerable<long>
{
public static readonly long[] Value=A021116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021116.Bytes);
public long this[int i]=>Value[i];

public static A021116Inst Instance=new A021116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021115
{
public static readonly long[] Value={ 0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021115Inst : IEnumerable<long>
{
public static readonly long[] Value=A021115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021115.Bytes);
public long this[int i]=>Value[i];

public static A021115Inst Instance=new A021115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021114
{
public static readonly long[] Value={ 1L,14L,131L,1036L,7497L,51450L,341167L,2209592L,14071013L,88494406L,551310123L,3409583268L,20966120449L,128339843282L,782754695399L,4760106416464L,28878529850205L,174860636120478L,1057111102343395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021114Inst : IEnumerable<long>
{
public static readonly long[] Value=A021114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021114.Bytes);
public long this[int i]=>Value[i];

public static A021114Inst Instance=new A021114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021113
{
public static readonly long[] Value={ 0L,0L,9L,1L,7L,4L,3L,1L,1L,9L,2L,6L,6L,0L,5L,5L,0L,4L,5L,8L,7L,1L,5L,5L,9L,6L,3L,3L,0L,2L,7L,5L,2L,2L,9L,3L,5L,7L,7L,9L,8L,1L,6L,5L,1L,3L,7L,6L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L,7L,2L,4L,7L,7L,0L,6L,4L,2L,2L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021113Inst : IEnumerable<long>
{
public static readonly long[] Value=A021113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021113.Bytes);
public long this[int i]=>Value[i];

public static A021113Inst Instance=new A021113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021112
{
public static readonly long[] Value={ 9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021112Inst : IEnumerable<long>
{
public static readonly long[] Value=A021112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021112.Bytes);
public long this[int i]=>Value[i];

public static A021112Inst Instance=new A021112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021111
{
public static readonly long[] Value={ 0L,0L,9L,3L,4L,5L,7L,9L,4L,3L,9L,2L,5L,2L,3L,3L,6L,4L,4L,8L,5L,9L,8L,1L,3L,0L,8L,4L,1L,1L,2L,1L,4L,9L,5L,3L,2L,7L,1L,0L,2L,8L,0L,3L,7L,3L,8L,3L,1L,7L,7L,5L,7L,0L,0L,9L,3L,4L,5L,7L,9L,4L,3L,9L,2L,5L,2L,3L,3L,6L,4L,4L,8L,5L,9L,8L,1L,3L,0L,8L,4L,1L,1L,2L,1L,4L,9L,5L,3L,2L,7L,1L,0L,2L,8L,0L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021111Inst : IEnumerable<long>
{
public static readonly long[] Value=A021111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021111.Bytes);
public long this[int i]=>Value[i];

public static A021111Inst Instance=new A021111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021110
{
public static readonly long[] Value={ 0L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021110Inst : IEnumerable<long>
{
public static readonly long[] Value=A021110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021110.Bytes);
public long this[int i]=>Value[i];

public static A021110Inst Instance=new A021110Inst();

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