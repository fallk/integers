using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040208
{
public static readonly long[] Value={ 14L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040208Inst : IEnumerable<long>
{
public static readonly long[] Value=A040208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040208.Bytes);
public long this[int i]=>Value[i];

public static A040208Inst Instance=new A040208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040209
{
public static readonly long[] Value={ 14L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040209Inst : IEnumerable<long>
{
public static readonly long[] Value=A040209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040209.Bytes);
public long this[int i]=>Value[i];

public static A040209Inst Instance=new A040209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040210
{
public static readonly long[] Value={ 15L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040210Inst : IEnumerable<long>
{
public static readonly long[] Value=A040210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040210.Bytes);
public long this[int i]=>Value[i];

public static A040210Inst Instance=new A040210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040211
{
public static readonly long[] Value={ 15L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040211Inst : IEnumerable<long>
{
public static readonly long[] Value=A040211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040211.Bytes);
public long this[int i]=>Value[i];

public static A040211Inst Instance=new A040211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040212
{
public static readonly long[] Value={ 15L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040212Inst : IEnumerable<long>
{
public static readonly long[] Value=A040212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040212.Bytes);
public long this[int i]=>Value[i];

public static A040212Inst Instance=new A040212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040213
{
public static readonly long[] Value={ 15L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040213Inst : IEnumerable<long>
{
public static readonly long[] Value=A040213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040213.Bytes);
public long this[int i]=>Value[i];

public static A040213Inst Instance=new A040213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040214
{
public static readonly long[] Value={ 15L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040214Inst : IEnumerable<long>
{
public static readonly long[] Value=A040214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040214.Bytes);
public long this[int i]=>Value[i];

public static A040214Inst Instance=new A040214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040215
{
public static readonly long[] Value={ 15L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040215Inst : IEnumerable<long>
{
public static readonly long[] Value=A040215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040215.Bytes);
public long this[int i]=>Value[i];

public static A040215Inst Instance=new A040215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040216
{
public static readonly long[] Value={ 15L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040216Inst : IEnumerable<long>
{
public static readonly long[] Value=A040216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040216.Bytes);
public long this[int i]=>Value[i];

public static A040216Inst Instance=new A040216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040217
{
public static readonly long[] Value={ 15L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040217Inst : IEnumerable<long>
{
public static readonly long[] Value=A040217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040217.Bytes);
public long this[int i]=>Value[i];

public static A040217Inst Instance=new A040217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040218
{
public static readonly long[] Value={ 15L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040218Inst : IEnumerable<long>
{
public static readonly long[] Value=A040218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040218.Bytes);
public long this[int i]=>Value[i];

public static A040218Inst Instance=new A040218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040219
{
public static readonly long[] Value={ 15L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040219Inst : IEnumerable<long>
{
public static readonly long[] Value=A040219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040219.Bytes);
public long this[int i]=>Value[i];

public static A040219Inst Instance=new A040219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040220
{
public static readonly long[] Value={ 15L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040220Inst : IEnumerable<long>
{
public static readonly long[] Value=A040220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040220.Bytes);
public long this[int i]=>Value[i];

public static A040220Inst Instance=new A040220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040349
{
public static readonly long[] Value={ 19L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040349Inst : IEnumerable<long>
{
public static readonly long[] Value=A040349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040349.Bytes);
public long this[int i]=>Value[i];

public static A040349Inst Instance=new A040349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040350
{
public static readonly long[] Value={ 19L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040350Inst : IEnumerable<long>
{
public static readonly long[] Value=A040350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040350.Bytes);
public long this[int i]=>Value[i];

public static A040350Inst Instance=new A040350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040351
{
public static readonly long[] Value={ 19L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040351Inst : IEnumerable<long>
{
public static readonly long[] Value=A040351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040351.Bytes);
public long this[int i]=>Value[i];

public static A040351Inst Instance=new A040351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040352
{
public static readonly long[] Value={ 19L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040352Inst : IEnumerable<long>
{
public static readonly long[] Value=A040352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040352.Bytes);
public long this[int i]=>Value[i];

public static A040352Inst Instance=new A040352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040353
{
public static readonly long[] Value={ 19L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040353Inst : IEnumerable<long>
{
public static readonly long[] Value=A040353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040353.Bytes);
public long this[int i]=>Value[i];

public static A040353Inst Instance=new A040353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040354
{
public static readonly long[] Value={ 19L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040354Inst : IEnumerable<long>
{
public static readonly long[] Value=A040354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040354.Bytes);
public long this[int i]=>Value[i];

public static A040354Inst Instance=new A040354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040355
{
public static readonly long[] Value={ 19L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040355Inst : IEnumerable<long>
{
public static readonly long[] Value=A040355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040355.Bytes);
public long this[int i]=>Value[i];

public static A040355Inst Instance=new A040355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040356
{
public static readonly long[] Value={ 19L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040356Inst : IEnumerable<long>
{
public static readonly long[] Value=A040356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040356.Bytes);
public long this[int i]=>Value[i];

public static A040356Inst Instance=new A040356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040357
{
public static readonly long[] Value={ 19L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040357Inst : IEnumerable<long>
{
public static readonly long[] Value=A040357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040357.Bytes);
public long this[int i]=>Value[i];

public static A040357Inst Instance=new A040357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040358
{
public static readonly long[] Value={ 19L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040358Inst : IEnumerable<long>
{
public static readonly long[] Value=A040358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040358.Bytes);
public long this[int i]=>Value[i];

public static A040358Inst Instance=new A040358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040359
{
public static readonly long[] Value={ 19L,2L,7L,3L,2L,2L,6L,12L,1L,4L,1L,1L,1L,3L,4L,19L,4L,3L,1L,1L,1L,4L,1L,12L,6L,2L,2L,3L,7L,2L,38L,2L,7L,3L,2L,2L,6L,12L,1L,4L,1L,1L,1L,3L,4L,19L,4L,3L,1L,1L,1L,4L,1L,12L,6L,2L,2L,3L,7L,2L,38L,2L,7L,3L,2L,2L,6L,12L,1L,4L,1L,1L,1L,3L,4L,19L,4L,3L,1L,1L,1L,4L,1L,12L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040359Inst : IEnumerable<long>
{
public static readonly long[] Value=A040359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040359.Bytes);
public long this[int i]=>Value[i];

public static A040359Inst Instance=new A040359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040360
{
public static readonly long[] Value={ 19L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040360Inst : IEnumerable<long>
{
public static readonly long[] Value=A040360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040360.Bytes);
public long this[int i]=>Value[i];

public static A040360Inst Instance=new A040360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040361
{
public static readonly long[] Value={ 19L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040361Inst : IEnumerable<long>
{
public static readonly long[] Value=A040361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040361.Bytes);
public long this[int i]=>Value[i];

public static A040361Inst Instance=new A040361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040362
{
public static readonly long[] Value={ 19L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L,2L,1L,1L,5L,1L,12L,5L,1L,1L,38L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L,2L,1L,1L,5L,1L,12L,5L,1L,1L,38L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L,2L,1L,1L,5L,1L,12L,5L,1L,1L,38L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040362Inst : IEnumerable<long>
{
public static readonly long[] Value=A040362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040362.Bytes);
public long this[int i]=>Value[i];

public static A040362Inst Instance=new A040362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040363
{
public static readonly long[] Value={ 19L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040363Inst : IEnumerable<long>
{
public static readonly long[] Value=A040363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040363.Bytes);
public long this[int i]=>Value[i];

public static A040363Inst Instance=new A040363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040364
{
public static readonly long[] Value={ 19L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040364Inst : IEnumerable<long>
{
public static readonly long[] Value=A040364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040364.Bytes);
public long this[int i]=>Value[i];

public static A040364Inst Instance=new A040364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040381
{
public static readonly long[] Value={ 20L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040381Inst : IEnumerable<long>
{
public static readonly long[] Value=A040381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040381.Bytes);
public long this[int i]=>Value[i];

public static A040381Inst Instance=new A040381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040382
{
public static readonly long[] Value={ 20L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040382Inst : IEnumerable<long>
{
public static readonly long[] Value=A040382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040382.Bytes);
public long this[int i]=>Value[i];

public static A040382Inst Instance=new A040382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040383
{
public static readonly long[] Value={ 20L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040383Inst : IEnumerable<long>
{
public static readonly long[] Value=A040383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040383.Bytes);
public long this[int i]=>Value[i];

public static A040383Inst Instance=new A040383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040384
{
public static readonly long[] Value={ 20L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040384Inst : IEnumerable<long>
{
public static readonly long[] Value=A040384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040384.Bytes);
public long this[int i]=>Value[i];

public static A040384Inst Instance=new A040384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040385
{
public static readonly long[] Value={ 20L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040385Inst : IEnumerable<long>
{
public static readonly long[] Value=A040385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040385.Bytes);
public long this[int i]=>Value[i];

public static A040385Inst Instance=new A040385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040386
{
public static readonly long[] Value={ 20L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040386Inst : IEnumerable<long>
{
public static readonly long[] Value=A040386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040386.Bytes);
public long this[int i]=>Value[i];

public static A040386Inst Instance=new A040386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040387
{
public static readonly long[] Value={ 20L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040387Inst : IEnumerable<long>
{
public static readonly long[] Value=A040387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040387.Bytes);
public long this[int i]=>Value[i];

public static A040387Inst Instance=new A040387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040388
{
public static readonly long[] Value={ 20L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040388Inst : IEnumerable<long>
{
public static readonly long[] Value=A040388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040388.Bytes);
public long this[int i]=>Value[i];

public static A040388Inst Instance=new A040388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040389
{
public static readonly long[] Value={ 20L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040389Inst : IEnumerable<long>
{
public static readonly long[] Value=A040389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040389.Bytes);
public long this[int i]=>Value[i];

public static A040389Inst Instance=new A040389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040390
{
public static readonly long[] Value={ 20L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040390Inst : IEnumerable<long>
{
public static readonly long[] Value=A040390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040390.Bytes);
public long this[int i]=>Value[i];

public static A040390Inst Instance=new A040390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040391
{
public static readonly long[] Value={ 20L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040391Inst : IEnumerable<long>
{
public static readonly long[] Value=A040391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040391.Bytes);
public long this[int i]=>Value[i];

public static A040391Inst Instance=new A040391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040392
{
public static readonly long[] Value={ 20L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040392Inst : IEnumerable<long>
{
public static readonly long[] Value=A040392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040392.Bytes);
public long this[int i]=>Value[i];

public static A040392Inst Instance=new A040392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040393
{
public static readonly long[] Value={ 20L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040393Inst : IEnumerable<long>
{
public static readonly long[] Value=A040393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040393.Bytes);
public long this[int i]=>Value[i];

public static A040393Inst Instance=new A040393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040394
{
public static readonly long[] Value={ 20L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040394Inst : IEnumerable<long>
{
public static readonly long[] Value=A040394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040394.Bytes);
public long this[int i]=>Value[i];

public static A040394Inst Instance=new A040394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040395
{
public static readonly long[] Value={ 20L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040395Inst : IEnumerable<long>
{
public static readonly long[] Value=A040395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040395.Bytes);
public long this[int i]=>Value[i];

public static A040395Inst Instance=new A040395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040396
{
public static readonly long[] Value={ 20L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040396Inst : IEnumerable<long>
{
public static readonly long[] Value=A040396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040396.Bytes);
public long this[int i]=>Value[i];

public static A040396Inst Instance=new A040396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040429
{
public static readonly long[] Value={ 21L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040429Inst : IEnumerable<long>
{
public static readonly long[] Value=A040429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040429.Bytes);
public long this[int i]=>Value[i];

public static A040429Inst Instance=new A040429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040430
{
public static readonly long[] Value={ 21L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040430Inst : IEnumerable<long>
{
public static readonly long[] Value=A040430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040430.Bytes);
public long this[int i]=>Value[i];

public static A040430Inst Instance=new A040430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040431
{
public static readonly long[] Value={ 21L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040431Inst : IEnumerable<long>
{
public static readonly long[] Value=A040431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040431.Bytes);
public long this[int i]=>Value[i];

public static A040431Inst Instance=new A040431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040432
{
public static readonly long[] Value={ 21L,3L,3L,1L,13L,2L,3L,2L,1L,1L,4L,6L,1L,7L,1L,1L,1L,20L,1L,1L,1L,7L,1L,6L,4L,1L,1L,2L,3L,2L,13L,1L,3L,3L,42L,3L,3L,1L,13L,2L,3L,2L,1L,1L,4L,6L,1L,7L,1L,1L,1L,20L,1L,1L,1L,7L,1L,6L,4L,1L,1L,2L,3L,2L,13L,1L,3L,3L,42L,3L,3L,1L,13L,2L,3L,2L,1L,1L,4L,6L,1L,7L,1L,1L,1L,20L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040432Inst : IEnumerable<long>
{
public static readonly long[] Value=A040432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040432.Bytes);
public long this[int i]=>Value[i];

public static A040432Inst Instance=new A040432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040433
{
public static readonly long[] Value={ 21L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040433Inst : IEnumerable<long>
{
public static readonly long[] Value=A040433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040433.Bytes);
public long this[int i]=>Value[i];

public static A040433Inst Instance=new A040433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040434
{
public static readonly long[] Value={ 21L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040434Inst : IEnumerable<long>
{
public static readonly long[] Value=A040434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040434.Bytes);
public long this[int i]=>Value[i];

public static A040434Inst Instance=new A040434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040435
{
public static readonly long[] Value={ 21L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L,1L,4L,1L,3L,1L,13L,2L,5L,1L,1L,1L,2L,42L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L,1L,4L,1L,3L,1L,13L,2L,5L,1L,1L,1L,2L,42L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L,1L,4L,1L,3L,1L,13L,2L,5L,1L,1L,1L,2L,42L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040435Inst : IEnumerable<long>
{
public static readonly long[] Value=A040435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040435.Bytes);
public long this[int i]=>Value[i];

public static A040435Inst Instance=new A040435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040436
{
public static readonly long[] Value={ 21L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040436Inst : IEnumerable<long>
{
public static readonly long[] Value=A040436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040436.Bytes);
public long this[int i]=>Value[i];

public static A040436Inst Instance=new A040436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040437
{
public static readonly long[] Value={ 21L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040437Inst : IEnumerable<long>
{
public static readonly long[] Value=A040437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040437.Bytes);
public long this[int i]=>Value[i];

public static A040437Inst Instance=new A040437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040438
{
public static readonly long[] Value={ 21L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040438Inst : IEnumerable<long>
{
public static readonly long[] Value=A040438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040438.Bytes);
public long this[int i]=>Value[i];

public static A040438Inst Instance=new A040438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040439
{
public static readonly long[] Value={ 21L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040439Inst : IEnumerable<long>
{
public static readonly long[] Value=A040439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040439.Bytes);
public long this[int i]=>Value[i];

public static A040439Inst Instance=new A040439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040440
{
public static readonly long[] Value={ 21L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040440Inst : IEnumerable<long>
{
public static readonly long[] Value=A040440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040440.Bytes);
public long this[int i]=>Value[i];

public static A040440Inst Instance=new A040440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040441
{
public static readonly long[] Value={ 21L,1L,1L,13L,1L,5L,4L,1L,1L,1L,1L,2L,2L,6L,1L,3L,21L,3L,1L,6L,2L,2L,1L,1L,1L,1L,4L,5L,1L,13L,1L,1L,42L,1L,1L,13L,1L,5L,4L,1L,1L,1L,1L,2L,2L,6L,1L,3L,21L,3L,1L,6L,2L,2L,1L,1L,1L,1L,4L,5L,1L,13L,1L,1L,42L,1L,1L,13L,1L,5L,4L,1L,1L,1L,1L,2L,2L,6L,1L,3L,21L,3L,1L,6L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040441Inst : IEnumerable<long>
{
public static readonly long[] Value=A040441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040441.Bytes);
public long this[int i]=>Value[i];

public static A040441Inst Instance=new A040441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040442
{
public static readonly long[] Value={ 21L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040442Inst : IEnumerable<long>
{
public static readonly long[] Value=A040442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040442.Bytes);
public long this[int i]=>Value[i];

public static A040442Inst Instance=new A040442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040443
{
public static readonly long[] Value={ 21L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040443Inst : IEnumerable<long>
{
public static readonly long[] Value=A040443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040443.Bytes);
public long this[int i]=>Value[i];

public static A040443Inst Instance=new A040443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040444
{
public static readonly long[] Value={ 21L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040444Inst : IEnumerable<long>
{
public static readonly long[] Value=A040444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040444.Bytes);
public long this[int i]=>Value[i];

public static A040444Inst Instance=new A040444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040525
{
public static readonly long[] Value={ 23L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040525Inst : IEnumerable<long>
{
public static readonly long[] Value=A040525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040525.Bytes);
public long this[int i]=>Value[i];

public static A040525Inst Instance=new A040525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040526
{
public static readonly long[] Value={ 23L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040526Inst : IEnumerable<long>
{
public static readonly long[] Value=A040526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040526.Bytes);
public long this[int i]=>Value[i];

public static A040526Inst Instance=new A040526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040527
{
public static readonly long[] Value={ 23L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040527Inst : IEnumerable<long>
{
public static readonly long[] Value=A040527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040527.Bytes);
public long this[int i]=>Value[i];

public static A040527Inst Instance=new A040527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040528
{
public static readonly long[] Value={ 23L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040528Inst : IEnumerable<long>
{
public static readonly long[] Value=A040528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040528.Bytes);
public long this[int i]=>Value[i];

public static A040528Inst Instance=new A040528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040529
{
public static readonly long[] Value={ 23L,1L,1L,15L,5L,1L,4L,2L,1L,1L,3L,1L,2L,6L,2L,1L,3L,1L,1L,2L,4L,1L,5L,15L,1L,1L,46L,1L,1L,15L,5L,1L,4L,2L,1L,1L,3L,1L,2L,6L,2L,1L,3L,1L,1L,2L,4L,1L,5L,15L,1L,1L,46L,1L,1L,15L,5L,1L,4L,2L,1L,1L,3L,1L,2L,6L,2L,1L,3L,1L,1L,2L,4L,1L,5L,15L,1L,1L,46L,1L,1L,15L,5L,1L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040529Inst : IEnumerable<long>
{
public static readonly long[] Value=A040529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040529.Bytes);
public long this[int i]=>Value[i];

public static A040529Inst Instance=new A040529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040530
{
public static readonly long[] Value={ 23L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040530Inst : IEnumerable<long>
{
public static readonly long[] Value=A040530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040530.Bytes);
public long this[int i]=>Value[i];

public static A040530Inst Instance=new A040530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040531
{
public static readonly long[] Value={ 23L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040531Inst : IEnumerable<long>
{
public static readonly long[] Value=A040531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040531.Bytes);
public long this[int i]=>Value[i];

public static A040531Inst Instance=new A040531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040532
{
public static readonly long[] Value={ 23L,1L,1L,2L,1L,1L,1L,3L,3L,2L,1L,5L,5L,15L,1L,1L,8L,1L,10L,1L,8L,1L,1L,15L,5L,5L,1L,2L,3L,3L,1L,1L,1L,2L,1L,1L,46L,1L,1L,2L,1L,1L,1L,3L,3L,2L,1L,5L,5L,15L,1L,1L,8L,1L,10L,1L,8L,1L,1L,15L,5L,5L,1L,2L,3L,3L,1L,1L,1L,2L,1L,1L,46L,1L,1L,2L,1L,1L,1L,3L,3L,2L,1L,5L,5L,15L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040532Inst : IEnumerable<long>
{
public static readonly long[] Value=A040532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040532.Bytes);
public long this[int i]=>Value[i];

public static A040532Inst Instance=new A040532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040533
{
public static readonly long[] Value={ 23L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040533Inst : IEnumerable<long>
{
public static readonly long[] Value=A040533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040533.Bytes);
public long this[int i]=>Value[i];

public static A040533Inst Instance=new A040533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040534
{
public static readonly long[] Value={ 23L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040534Inst : IEnumerable<long>
{
public static readonly long[] Value=A040534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040534.Bytes);
public long this[int i]=>Value[i];

public static A040534Inst Instance=new A040534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040535
{
public static readonly long[] Value={ 23L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040535Inst : IEnumerable<long>
{
public static readonly long[] Value=A040535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040535.Bytes);
public long this[int i]=>Value[i];

public static A040535Inst Instance=new A040535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040536
{
public static readonly long[] Value={ 23L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040536Inst : IEnumerable<long>
{
public static readonly long[] Value=A040536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040536.Bytes);
public long this[int i]=>Value[i];

public static A040536Inst Instance=new A040536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040537
{
public static readonly long[] Value={ 23L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040537Inst : IEnumerable<long>
{
public static readonly long[] Value=A040537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040537.Bytes);
public long this[int i]=>Value[i];

public static A040537Inst Instance=new A040537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040538
{
public static readonly long[] Value={ 23L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040538Inst : IEnumerable<long>
{
public static readonly long[] Value=A040538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040538.Bytes);
public long this[int i]=>Value[i];

public static A040538Inst Instance=new A040538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040539
{
public static readonly long[] Value={ 23L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040539Inst : IEnumerable<long>
{
public static readonly long[] Value=A040539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040539.Bytes);
public long this[int i]=>Value[i];

public static A040539Inst Instance=new A040539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040540
{
public static readonly long[] Value={ 23L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040540Inst : IEnumerable<long>
{
public static readonly long[] Value=A040540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040540.Bytes);
public long this[int i]=>Value[i];

public static A040540Inst Instance=new A040540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040557
{
public static readonly long[] Value={ 24L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040557Inst : IEnumerable<long>
{
public static readonly long[] Value=A040557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040557.Bytes);
public long this[int i]=>Value[i];

public static A040557Inst Instance=new A040557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040558
{
public static readonly long[] Value={ 24L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040558Inst : IEnumerable<long>
{
public static readonly long[] Value=A040558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040558.Bytes);
public long this[int i]=>Value[i];

public static A040558Inst Instance=new A040558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040559
{
public static readonly long[] Value={ 24L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040559Inst : IEnumerable<long>
{
public static readonly long[] Value=A040559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040559.Bytes);
public long this[int i]=>Value[i];

public static A040559Inst Instance=new A040559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040560
{
public static readonly long[] Value={ 24L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040560Inst : IEnumerable<long>
{
public static readonly long[] Value=A040560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040560.Bytes);
public long this[int i]=>Value[i];

public static A040560Inst Instance=new A040560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040561
{
public static readonly long[] Value={ 24L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L,48L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L,48L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L,48L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040561Inst : IEnumerable<long>
{
public static readonly long[] Value=A040561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040561.Bytes);
public long this[int i]=>Value[i];

public static A040561Inst Instance=new A040561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040562
{
public static readonly long[] Value={ 24L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040562Inst : IEnumerable<long>
{
public static readonly long[] Value=A040562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040562.Bytes);
public long this[int i]=>Value[i];

public static A040562Inst Instance=new A040562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040563
{
public static readonly long[] Value={ 24L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040563Inst : IEnumerable<long>
{
public static readonly long[] Value=A040563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040563.Bytes);
public long this[int i]=>Value[i];

public static A040563Inst Instance=new A040563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040564
{
public static readonly long[] Value={ 24L,3L,1L,2L,2L,15L,1L,3L,9L,2L,4L,1L,11L,3L,6L,1L,1L,1L,1L,3L,2L,3L,1L,1L,1L,1L,6L,3L,11L,1L,4L,2L,9L,3L,1L,15L,2L,2L,1L,3L,48L,3L,1L,2L,2L,15L,1L,3L,9L,2L,4L,1L,11L,3L,6L,1L,1L,1L,1L,3L,2L,3L,1L,1L,1L,1L,6L,3L,11L,1L,4L,2L,9L,3L,1L,15L,2L,2L,1L,3L,48L,3L,1L,2L,2L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040564Inst : IEnumerable<long>
{
public static readonly long[] Value=A040564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040564.Bytes);
public long this[int i]=>Value[i];

public static A040564Inst Instance=new A040564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040565
{
public static readonly long[] Value={ 24L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040565Inst : IEnumerable<long>
{
public static readonly long[] Value=A040565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040565.Bytes);
public long this[int i]=>Value[i];

public static A040565Inst Instance=new A040565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040566
{
public static readonly long[] Value={ 24L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040566Inst : IEnumerable<long>
{
public static readonly long[] Value=A040566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040566.Bytes);
public long this[int i]=>Value[i];

public static A040566Inst Instance=new A040566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040567
{
public static readonly long[] Value={ 24L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040567Inst : IEnumerable<long>
{
public static readonly long[] Value=A040567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040567.Bytes);
public long this[int i]=>Value[i];

public static A040567Inst Instance=new A040567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040568
{
public static readonly long[] Value={ 24L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040568Inst : IEnumerable<long>
{
public static readonly long[] Value=A040568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040568.Bytes);
public long this[int i]=>Value[i];

public static A040568Inst Instance=new A040568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040569
{
public static readonly long[] Value={ 24L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040569Inst : IEnumerable<long>
{
public static readonly long[] Value=A040569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040569.Bytes);
public long this[int i]=>Value[i];

public static A040569Inst Instance=new A040569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040570
{
public static readonly long[] Value={ 24L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040570Inst : IEnumerable<long>
{
public static readonly long[] Value=A040570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040570.Bytes);
public long this[int i]=>Value[i];

public static A040570Inst Instance=new A040570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040571
{
public static readonly long[] Value={ 24L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040571Inst : IEnumerable<long>
{
public static readonly long[] Value=A040571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040571.Bytes);
public long this[int i]=>Value[i];

public static A040571Inst Instance=new A040571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040572
{
public static readonly long[] Value={ 24L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L,3L,2L,48L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L,3L,2L,48L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L,3L,2L,48L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040572Inst : IEnumerable<long>
{
public static readonly long[] Value=A040572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040572.Bytes);
public long this[int i]=>Value[i];

public static A040572Inst Instance=new A040572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040589
{
public static readonly long[] Value={ 24L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L,2L,24L,2L,1L,1L,3L,4L,1L,2L,9L,1L,1L,3L,1L,48L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L,2L,24L,2L,1L,1L,3L,4L,1L,2L,9L,1L,1L,3L,1L,48L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L,2L,24L,2L,1L,1L,3L,4L,1L,2L,9L,1L,1L,3L,1L,48L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040589Inst : IEnumerable<long>
{
public static readonly long[] Value=A040589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040589.Bytes);
public long this[int i]=>Value[i];

public static A040589Inst Instance=new A040589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040590
{
public static readonly long[] Value={ 24L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040590Inst : IEnumerable<long>
{
public static readonly long[] Value=A040590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040590.Bytes);
public long this[int i]=>Value[i];

public static A040590Inst Instance=new A040590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040591
{
public static readonly long[] Value={ 24L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040591Inst : IEnumerable<long>
{
public static readonly long[] Value=A040591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040591.Bytes);
public long this[int i]=>Value[i];

public static A040591Inst Instance=new A040591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040592
{
public static readonly long[] Value={ 24L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040592Inst : IEnumerable<long>
{
public static readonly long[] Value=A040592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040592.Bytes);
public long this[int i]=>Value[i];

public static A040592Inst Instance=new A040592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040593
{
public static readonly long[] Value={ 24L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040593Inst : IEnumerable<long>
{
public static readonly long[] Value=A040593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040593.Bytes);
public long this[int i]=>Value[i];

public static A040593Inst Instance=new A040593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040594
{
public static readonly long[] Value={ 24L,1L,7L,3L,5L,4L,1L,3L,1L,2L,1L,1L,9L,2L,1L,1L,1L,15L,1L,23L,1L,15L,1L,1L,1L,2L,9L,1L,1L,2L,1L,3L,1L,4L,5L,3L,7L,1L,48L,1L,7L,3L,5L,4L,1L,3L,1L,2L,1L,1L,9L,2L,1L,1L,1L,15L,1L,23L,1L,15L,1L,1L,1L,2L,9L,1L,1L,2L,1L,3L,1L,4L,5L,3L,7L,1L,48L,1L,7L,3L,5L,4L,1L,3L,1L,2L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040594Inst : IEnumerable<long>
{
public static readonly long[] Value=A040594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040594.Bytes);
public long this[int i]=>Value[i];

public static A040594Inst Instance=new A040594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040595
{
public static readonly long[] Value={ 24L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040595Inst : IEnumerable<long>
{
public static readonly long[] Value=A040595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040595.Bytes);
public long this[int i]=>Value[i];

public static A040595Inst Instance=new A040595Inst();

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