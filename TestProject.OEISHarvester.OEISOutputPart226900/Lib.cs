using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A265282
{
public static readonly long[] Value={ 0L,1L,3L,5L,10L,13L,22L,26L,41L,46L,68L,74L,105L,112L,153L,161L,214L,223L,289L,299L,380L,391L,488L,500L,615L,628L,762L,776L,931L,946L,1123L,1139L,1340L,1357L,1583L,1601L,1854L,1873L,2154L,2174L,2485L,2506L,2848L,2870L,3245L,3268L,3677L,3701L,4146L,4171L,4653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265282Inst : IEnumerable<long>
{
public static readonly long[] Value=A265282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265282.Bytes);
public long this[int i]=>Value[i];

public static A265282Inst Instance=new A265282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265283
{
public static readonly long[] Value={ 1L,3L,4L,6L,6L,8L,8L,10L,10L,12L,12L,14L,14L,16L,16L,18L,18L,20L,20L,22L,22L,24L,24L,26L,26L,28L,28L,30L,30L,32L,32L,34L,34L,36L,36L,38L,38L,40L,40L,42L,42L,44L,44L,46L,46L,48L,48L,50L,50L,52L,52L,54L,54L,56L,56L,58L,58L,60L,60L,62L,62L,64L,64L,66L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265283Inst : IEnumerable<long>
{
public static readonly long[] Value=A265283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265283.Bytes);
public long this[int i]=>Value[i];

public static A265283Inst Instance=new A265283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265284
{
public static readonly long[] Value={ 1L,4L,8L,14L,20L,28L,36L,46L,56L,68L,80L,94L,108L,124L,140L,158L,176L,196L,216L,238L,260L,284L,308L,334L,360L,388L,416L,446L,476L,508L,540L,574L,608L,644L,680L,718L,756L,796L,836L,878L,920L,964L,1008L,1054L,1100L,1148L,1196L,1246L,1296L,1348L,1400L,1454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265284Inst : IEnumerable<long>
{
public static readonly long[] Value=A265284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265284.Bytes);
public long this[int i]=>Value[i];

public static A265284Inst Instance=new A265284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265285
{
public static readonly long[] Value={ 46657L,2433601L,67371265L,351596817937L,422240040001L,18677955240001L,458631349862401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265285Inst : IEnumerable<long>
{
public static readonly long[] Value=A265285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265285.Bytes);
public long this[int i]=>Value[i];

public static A265285Inst Instance=new A265285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265286
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,11L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265286Inst : IEnumerable<long>
{
public static readonly long[] Value=A265286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265286.Bytes);
public long this[int i]=>Value[i];

public static A265286Inst Instance=new A265286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265287
{
public static readonly long[] Value={ 0L,1L,5L,2L,4L,6L,6L,3L,14L,5L,5L,7L,13L,7L,7L,4L,18L,15L,12L,6L,9L,6L,20L,8L,17L,14L,11L,8L,11L,8L,8L,5L,19L,19L,19L,16L,19L,13L,10L,7L,13L,10L,13L,7L,7L,21L,18L,9L,21L,18L,18L,15L,18L,12L,12L,9L,30L,12L,12L,9L,12L,9L,9L,6L,23L,20L,17L,20L,23L,20L,23L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265287Inst : IEnumerable<long>
{
public static readonly long[] Value=A265287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265287.Bytes);
public long this[int i]=>Value[i];

public static A265287Inst Instance=new A265287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265288
{
public static readonly long[] Value={ 7L,5L,7L,2L,0L,4L,3L,7L,5L,0L,4L,6L,0L,0L,7L,3L,3L,8L,6L,4L,7L,8L,2L,5L,2L,6L,0L,6L,7L,3L,7L,7L,4L,8L,3L,0L,1L,0L,5L,8L,5L,2L,0L,1L,6L,1L,5L,6L,6L,7L,8L,4L,1L,9L,2L,9L,3L,2L,0L,1L,5L,5L,1L,1L,3L,4L,7L,1L,9L,0L,7L,3L,6L,6L,1L,7L,8L,3L,5L,7L,6L,6L,9L,7L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265288Inst : IEnumerable<long>
{
public static readonly long[] Value=A265288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265288.Bytes);
public long this[int i]=>Value[i];

public static A265288Inst Instance=new A265288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265289
{
public static readonly long[] Value={ 4L,3L,8L,7L,5L,1L,4L,1L,0L,9L,7L,1L,5L,0L,6L,2L,5L,7L,3L,5L,5L,6L,4L,9L,5L,3L,9L,3L,4L,7L,5L,2L,7L,1L,9L,0L,1L,6L,9L,6L,6L,4L,1L,9L,3L,4L,2L,5L,9L,2L,0L,0L,6L,7L,1L,9L,4L,1L,3L,7L,2L,8L,5L,1L,5L,0L,3L,7L,2L,1L,9L,5L,3L,9L,9L,5L,9L,3L,2L,4L,5L,5L,0L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265289Inst : IEnumerable<long>
{
public static readonly long[] Value=A265289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265289.Bytes);
public long this[int i]=>Value[i];

public static A265289Inst Instance=new A265289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265290
{
public static readonly long[] Value={ 1L,1L,9L,5L,9L,5L,5L,7L,8L,6L,0L,1L,7L,5L,1L,3L,5L,9L,6L,0L,0L,3L,4L,7L,4L,8L,0L,0L,0L,2L,1L,3L,0L,2L,0L,2L,0L,2L,7L,5L,5L,1L,6L,2L,0L,9L,5L,8L,2L,5L,9L,8L,4L,8L,6L,4L,8L,7L,3L,3L,8L,8L,3L,6L,2L,8L,5L,0L,9L,1L,2L,6L,9L,0L,6L,1L,3L,7L,6L,8L,2L,2L,2L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265290Inst : IEnumerable<long>
{
public static readonly long[] Value=A265290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265290.Bytes);
public long this[int i]=>Value[i];

public static A265290Inst Instance=new A265290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265291
{
public static readonly long[] Value={ 4L,2L,8L,8L,6L,0L,3L,3L,8L,0L,6L,8L,0L,9L,5L,9L,8L,3L,0L,0L,2L,1L,1L,1L,3L,6L,7L,6L,1L,3L,2L,7L,2L,3L,0L,7L,2L,3L,9L,6L,0L,1L,7L,6L,5L,1L,2L,5L,6L,0L,8L,2L,7L,4L,6L,6L,8L,3L,0L,2L,9L,6L,0L,2L,2L,3L,0L,5L,6L,9L,3L,1L,3L,7L,0L,6L,6L,5L,3L,5L,8L,8L,2L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265291Inst : IEnumerable<long>
{
public static readonly long[] Value=A265291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265291.Bytes);
public long this[int i]=>Value[i];

public static A265291Inst Instance=new A265291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265292
{
public static readonly long[] Value={ 0L,8L,8L,3L,1L,3L,8L,8L,2L,1L,5L,2L,5L,7L,5L,9L,0L,3L,2L,1L,7L,8L,5L,2L,9L,8L,4L,7L,2L,5L,3L,9L,6L,9L,2L,8L,8L,6L,5L,9L,1L,9L,5L,9L,2L,2L,2L,4L,3L,6L,2L,7L,7L,8L,8L,7L,8L,8L,8L,8L,7L,0L,3L,5L,1L,4L,1L,3L,2L,9L,2L,7L,4L,5L,2L,6L,3L,7L,7L,2L,6L,4L,7L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265292Inst : IEnumerable<long>
{
public static readonly long[] Value=A265292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265292.Bytes);
public long this[int i]=>Value[i];

public static A265292Inst Instance=new A265292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265293
{
public static readonly long[] Value={ 5L,1L,7L,1L,7L,4L,2L,2L,0L,2L,2L,0L,6L,7L,1L,8L,8L,6L,2L,1L,9L,9L,6L,4L,3L,5L,2L,3L,3L,8L,6L,6L,9L,2L,3L,6L,1L,0L,5L,5L,2L,1L,3L,5L,7L,3L,4L,9L,9L,7L,1L,0L,5L,3L,5L,4L,7L,1L,9L,1L,6L,6L,3L,7L,3L,7L,1L,8L,9L,8L,5L,8L,8L,2L,3L,3L,0L,3L,0L,8L,5L,2L,9L,6L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265293Inst : IEnumerable<long>
{
public static readonly long[] Value=A265293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265293.Bytes);
public long this[int i]=>Value[i];

public static A265293Inst Instance=new A265293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265294
{
public static readonly long[] Value={ 8L,0L,2L,5L,8L,3L,0L,9L,0L,8L,0L,3L,5L,1L,4L,8L,3L,4L,3L,7L,7L,8L,7L,4L,1L,8L,1L,2L,6L,3L,0L,4L,2L,4L,9L,6L,0L,5L,8L,6L,0L,4L,7L,7L,6L,8L,9L,5L,1L,3L,2L,7L,7L,7L,0L,1L,7L,7L,4L,1L,8L,5L,1L,4L,8L,4L,1L,4L,0L,6L,0L,8L,4L,4L,8L,7L,0L,0L,3L,0L,2L,2L,1L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265294Inst : IEnumerable<long>
{
public static readonly long[] Value=A265294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265294.Bytes);
public long this[int i]=>Value[i];

public static A265294Inst Instance=new A265294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265295
{
public static readonly long[] Value={ 2L,8L,7L,2L,8L,0L,0L,8L,0L,0L,8L,3L,4L,8L,8L,3L,9L,3L,5L,1L,1L,4L,5L,1L,5L,3L,9L,8L,7L,6L,6L,8L,3L,3L,1L,6L,8L,2L,3L,9L,0L,9L,4L,2L,0L,8L,6L,4L,5L,6L,7L,1L,8L,7L,9L,3L,8L,7L,1L,6L,8L,2L,6L,8L,1L,3L,8L,8L,3L,8L,6L,4L,1L,0L,7L,1L,6L,8L,0L,0L,6L,4L,0L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265295Inst : IEnumerable<long>
{
public static readonly long[] Value=A265295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265295.Bytes);
public long this[int i]=>Value[i];

public static A265295Inst Instance=new A265295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265296
{
public static readonly long[] Value={ 1L,0L,8L,9L,8L,6L,3L,1L,7L,0L,8L,8L,7L,0L,0L,3L,2L,2L,7L,8L,8L,9L,3L,2L,5L,7L,2L,1L,1L,3L,9L,7L,2L,5L,8L,1L,2L,8L,8L,2L,5L,1L,4L,1L,9L,7L,7L,5L,9L,6L,9L,9L,9L,6L,4L,9L,5L,6L,4L,5L,8L,6L,7L,8L,2L,9L,8L,0L,2L,4L,4L,7L,2L,5L,5L,5L,8L,6L,8L,3L,0L,8L,6L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265296Inst : IEnumerable<long>
{
public static readonly long[] Value=A265296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265296.Bytes);
public long this[int i]=>Value[i];

public static A265296Inst Instance=new A265296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265297
{
public static readonly long[] Value={ 2L,3L,6L,8L,4L,4L,2L,4L,8L,5L,7L,0L,1L,4L,8L,1L,8L,7L,5L,9L,5L,3L,8L,0L,1L,7L,8L,2L,2L,9L,9L,0L,1L,1L,9L,4L,7L,6L,0L,9L,8L,0L,4L,2L,0L,1L,8L,2L,7L,4L,6L,3L,5L,3L,4L,6L,5L,2L,3L,3L,3L,3L,0L,8L,9L,6L,9L,1L,8L,8L,7L,4L,4L,3L,0L,3L,6L,3L,8L,2L,0L,4L,5L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265297Inst : IEnumerable<long>
{
public static readonly long[] Value=A265297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265297.Bytes);
public long this[int i]=>Value[i];

public static A265297Inst Instance=new A265297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265298
{
public static readonly long[] Value={ 0L,1L,3L,9L,7L,5L,2L,9L,0L,4L,8L,4L,1L,6L,0L,6L,9L,4L,6L,3L,0L,4L,3L,1L,9L,3L,7L,0L,2L,8L,4L,6L,9L,2L,8L,1L,3L,5L,3L,8L,0L,0L,2L,5L,5L,6L,4L,1L,8L,4L,2L,4L,2L,7L,3L,4L,1L,7L,9L,8L,4L,7L,0L,7L,1L,5L,1L,8L,7L,0L,8L,2L,4L,8L,3L,8L,8L,2L,4L,0L,8L,6L,3L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265298Inst : IEnumerable<long>
{
public static readonly long[] Value=A265298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265298.Bytes);
public long this[int i]=>Value[i];

public static A265298Inst Instance=new A265298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265299
{
public static readonly long[] Value={ 2L,5L,0L,8L,1L,9L,5L,3L,9L,0L,5L,4L,3L,0L,8L,8L,8L,2L,2L,2L,5L,8L,1L,2L,1L,1L,5L,2L,5L,8L,3L,7L,0L,4L,7L,6L,1L,1L,4L,7L,8L,0L,6L,7L,5L,8L,2L,4L,5L,8L,8L,7L,8L,0L,8L,0L,7L,0L,3L,1L,8L,0L,1L,6L,1L,2L,1L,0L,5L,9L,5L,6L,9L,1L,4L,2L,4L,6L,2L,2L,9L,0L,8L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265299Inst : IEnumerable<long>
{
public static readonly long[] Value=A265299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265299.Bytes);
public long this[int i]=>Value[i];

public static A265299Inst Instance=new A265299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265300
{
public static readonly long[] Value={ 4L,5L,4L,5L,8L,7L,1L,1L,3L,0L,6L,5L,0L,7L,2L,4L,7L,4L,9L,9L,8L,9L,7L,8L,3L,3L,0L,8L,0L,9L,5L,4L,3L,0L,1L,3L,3L,2L,5L,0L,8L,5L,3L,9L,7L,8L,3L,5L,3L,3L,9L,5L,4L,2L,6L,8L,1L,3L,8L,8L,7L,2L,6L,3L,3L,6L,6L,4L,0L,3L,9L,0L,4L,6L,5L,0L,4L,3L,5L,4L,0L,9L,4L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265300Inst : IEnumerable<long>
{
public static readonly long[] Value=A265300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265300.Bytes);
public long this[int i]=>Value[i];

public static A265300Inst Instance=new A265300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265301
{
public static readonly long[] Value={ 5L,1L,0L,2L,5L,7L,7L,4L,8L,2L,8L,4L,4L,7L,5L,3L,6L,6L,8L,7L,0L,9L,7L,4L,1L,8L,6L,1L,6L,4L,1L,0L,1L,0L,5L,9L,5L,6L,1L,6L,0L,0L,2L,0L,2L,9L,8L,4L,0L,3L,7L,1L,6L,6L,0L,9L,9L,6L,8L,0L,9L,4L,1L,3L,0L,5L,2L,4L,6L,3L,3L,9L,0L,6L,3L,0L,8L,4L,9L,6L,2L,8L,1L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265301Inst : IEnumerable<long>
{
public static readonly long[] Value=A265301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265301.Bytes);
public long this[int i]=>Value[i];

public static A265301Inst Instance=new A265301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265302
{
public static readonly long[] Value={ 5L,0L,5L,6L,1L,2L,8L,8L,7L,8L,9L,3L,5L,2L,0L,0L,1L,1L,6L,8L,6L,0L,7L,5L,7L,4L,9L,4L,2L,5L,9L,5L,3L,1L,1L,9L,2L,8L,1L,2L,4L,5L,4L,1L,8L,1L,3L,3L,7L,4L,3L,2L,5L,9L,2L,9L,1L,3L,5L,6L,8L,2L,0L,4L,6L,7L,1L,6L,5L,0L,2L,4L,3L,7L,1L,3L,5L,2L,0L,3L,7L,2L,2L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265302Inst : IEnumerable<long>
{
public static readonly long[] Value=A265302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265302.Bytes);
public long this[int i]=>Value[i];

public static A265302Inst Instance=new A265302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265303
{
public static readonly long[] Value={ 8L,5L,7L,7L,2L,0L,6L,7L,6L,1L,3L,6L,1L,9L,1L,9L,6L,6L,0L,0L,4L,2L,2L,2L,7L,3L,5L,2L,2L,6L,5L,4L,4L,6L,1L,4L,4L,7L,9L,2L,0L,3L,5L,3L,0L,2L,5L,1L,2L,1L,6L,5L,4L,9L,3L,3L,6L,6L,0L,5L,9L,2L,0L,4L,4L,6L,1L,1L,3L,8L,6L,2L,7L,4L,1L,3L,3L,0L,7L,1L,7L,6L,5L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265303Inst : IEnumerable<long>
{
public static readonly long[] Value=A265303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265303.Bytes);
public long this[int i]=>Value[i];

public static A265303Inst Instance=new A265303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265304
{
public static readonly long[] Value={ 1L,7L,6L,6L,2L,7L,7L,6L,4L,3L,0L,5L,1L,5L,1L,8L,0L,6L,4L,3L,5L,7L,0L,5L,9L,6L,9L,4L,5L,0L,7L,9L,3L,8L,5L,7L,7L,3L,1L,8L,3L,9L,1L,8L,4L,4L,4L,8L,7L,2L,5L,5L,5L,7L,7L,5L,7L,7L,7L,7L,4L,0L,7L,0L,2L,8L,2L,6L,5L,8L,5L,4L,9L,0L,5L,2L,7L,5L,4L,5L,2L,9L,4L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265304Inst : IEnumerable<long>
{
public static readonly long[] Value=A265304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265304.Bytes);
public long this[int i]=>Value[i];

public static A265304Inst Instance=new A265304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265305
{
public static readonly long[] Value={ 1L,0L,3L,4L,3L,4L,8L,4L,4L,0L,4L,4L,1L,3L,4L,3L,7L,7L,2L,4L,3L,9L,9L,2L,8L,7L,0L,4L,6L,7L,7L,3L,3L,8L,4L,7L,2L,2L,1L,1L,0L,4L,2L,7L,1L,4L,6L,9L,9L,9L,4L,2L,1L,0L,7L,0L,9L,4L,3L,8L,3L,3L,2L,7L,4L,7L,4L,3L,7L,9L,7L,1L,7L,6L,4L,6L,6L,0L,6L,1L,7L,0L,5L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265305Inst : IEnumerable<long>
{
public static readonly long[] Value=A265305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265305.Bytes);
public long this[int i]=>Value[i];

public static A265305Inst Instance=new A265305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265306
{
public static readonly long[] Value={ 7L,7L,4L,2L,2L,8L,5L,8L,9L,2L,0L,8L,2L,1L,9L,6L,2L,0L,5L,5L,2L,9L,3L,3L,9L,6L,8L,9L,4L,0L,5L,9L,3L,6L,3L,8L,3L,7L,2L,4L,3L,7L,6L,3L,7L,2L,4L,2L,9L,7L,3L,9L,1L,6L,2L,1L,6L,1L,3L,2L,5L,9L,4L,2L,0L,3L,4L,3L,2L,8L,6L,6L,9L,8L,6L,7L,5L,3L,2L,4L,8L,4L,0L,8L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265306Inst : IEnumerable<long>
{
public static readonly long[] Value=A265306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265306.Bytes);
public long this[int i]=>Value[i];

public static A265306Inst Instance=new A265306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265307
{
public static readonly long[] Value={ 3L,1L,3L,9L,3L,4L,3L,0L,5L,9L,8L,4L,4L,1L,2L,4L,0L,5L,2L,5L,6L,5L,9L,6L,0L,0L,7L,5L,9L,6L,8L,3L,4L,7L,7L,7L,8L,0L,0L,5L,7L,7L,7L,4L,9L,1L,4L,9L,6L,7L,1L,5L,1L,9L,5L,1L,3L,3L,1L,0L,1L,9L,7L,5L,8L,6L,6L,3L,8L,0L,2L,9L,1L,0L,5L,2L,2L,5L,2L,8L,5L,1L,6L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265307Inst : IEnumerable<long>
{
public static readonly long[] Value=A265307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265307.Bytes);
public long this[int i]=>Value[i];

public static A265307Inst Instance=new A265307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265308
{
public static readonly long[] Value={ 1L,0L,8L,8L,1L,6L,2L,8L,9L,5L,1L,9L,2L,6L,3L,2L,0L,2L,5L,8L,0L,9L,5L,2L,9L,9L,7L,6L,5L,3L,7L,4L,2L,8L,4L,1L,6L,1L,7L,3L,0L,1L,5L,3L,8L,6L,3L,9L,2L,6L,4L,5L,4L,3L,5L,7L,2L,9L,4L,4L,2L,7L,9L,1L,7L,9L,0L,0L,7L,0L,8L,9L,6L,0L,9L,1L,9L,7L,8L,5L,3L,3L,5L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265308Inst : IEnumerable<long>
{
public static readonly long[] Value=A265308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265308.Bytes);
public long this[int i]=>Value[i];

public static A265308Inst Instance=new A265308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265309
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,17L,55L,61L,259L,269L,791L,3613L,6448L,8317L,18194L,32219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265309Inst : IEnumerable<long>
{
public static readonly long[] Value=A265309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265309.Bytes);
public long this[int i]=>Value[i];

public static A265309Inst Instance=new A265309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265310
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,9L,13L,14L,10L,12L,17L,15L,19L,15L,14L,22L,23L,16L,15L,26L,15L,21L,29L,20L,31L,16L,22L,34L,14L,21L,37L,38L,26L,20L,41L,28L,43L,33L,15L,46L,47L,24L,21L,25L,34L,39L,53L,27L,22L,28L,38L,58L,59L,25L,61L,62L,21L,24L,26L,44L,67L,51L,46L,28L,71L,27L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265310Inst : IEnumerable<long>
{
public static readonly long[] Value=A265310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265310.Bytes);
public long this[int i]=>Value[i];

public static A265310Inst Instance=new A265310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265311
{
public static readonly long[] Value={ 1L,1L,1L,7L,10L,10L,245L,280L,280L,14700L,15400L,15400L,1401400L,1401400L,1401400L,196196000L,190590400L,190590400L,38022784800L,36212176000L,36212176000L,9759181432000L,9161680528000L,9161680528000L,3206588184800000L,2977546171600000L,2977546171600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265311Inst : IEnumerable<long>
{
public static readonly long[] Value=A265311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265311.Bytes);
public long this[int i]=>Value[i];

public static A265311Inst Instance=new A265311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265312
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,5L,1L,1L,1L,2L,6L,15L,1L,1L,1L,2L,6L,23L,52L,1L,1L,1L,2L,6L,24L,106L,203L,1L,1L,1L,2L,6L,24L,119L,568L,877L,1L,1L,1L,2L,6L,24L,120L,700L,3459L,4140L,1L,1L,1L,2L,6L,24L,120L,719L,4748L,23544L,21147L,1L,1L,1L,2L,6L,24L,120L,720L,5013L,36403L,176850L,115975L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265312Inst : IEnumerable<long>
{
public static readonly long[] Value=A265312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265312.Bytes);
public long this[int i]=>Value[i];

public static A265312Inst Instance=new A265312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265313
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,-1L,0L,1L,1L,-1L,2L,1L,1L,1L,-1L,2L,-4L,1L,1L,1L,-1L,2L,-6L,9L,-2L,1L,1L,-1L,2L,-6L,22L,-22L,-9L,1L,1L,-1L,2L,-6L,24L,-95L,54L,-9L,1L,1L,-1L,2L,-6L,24L,-118L,472L,-139L,50L,1L,1L,-1L,2L,-6L,24L,-120L,683L,-2638L,372L,267L,1L,1L,-1L,2L,-6L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265313Inst : IEnumerable<long>
{
public static readonly long[] Value=A265313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265313.Bytes);
public long this[int i]=>Value[i];

public static A265313Inst Instance=new A265313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265314
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,1L,0L,0L,17L,3L,1L,0L,-1L,5L,65L,5L,1L,0L,0L,7L,55L,175L,15L,1L,0L,1L,-7L,2023L,245L,385L,21L,1L,0L,0L,-38L,49L,34181L,595L,371L,14L,1L,0L,-1L,3L,-14351L,973L,56567L,525L,217L,18L,1L,0L,0L,99L,-19L,10637L,13601L,208859L,2415L,355L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265314Inst : IEnumerable<long>
{
public static readonly long[] Value=A265314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265314.Bytes);
public long this[int i]=>Value[i];

public static A265314Inst Instance=new A265314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265315
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,2L,1L,1L,1L,12L,1L,1L,1L,30L,6L,12L,1L,1L,1L,1L,90L,8L,12L,2L,1L,1L,42L,20L,360L,8L,12L,2L,1L,1L,1L,315L,45L,720L,6L,6L,1L,1L,1L,30L,7L,3780L,20L,240L,2L,2L,1L,1L,1L,1L,350L,7L,756L,32L,240L,4L,2L,2L,1L,1L,66L,12L,6300L,1512L,6048L,96L,240L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265315Inst : IEnumerable<long>
{
public static readonly long[] Value=A265315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265315.Bytes);
public long this[int i]=>Value[i];

public static A265315Inst Instance=new A265315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265316
{
public static readonly long[] Value={ 0L,2L,7L,21L,23L,64L,69L,71L,193L,207L,209L,214L,579L,581L,622L,627L,629L,643L,1737L,1739L,1744L,1866L,1868L,1882L,1887L,1889L,1930L,5211L,5213L,5218L,5232L,5234L,5599L,5604L,5606L,5647L,5661L,5663L,5668L,5790L,5792L,15634L,15639L,15641L,15655L,15696L,15698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265316Inst : IEnumerable<long>
{
public static readonly long[] Value=A265316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265316.Bytes);
public long this[int i]=>Value[i];

public static A265316Inst Instance=new A265316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265317
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,17L,33L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265317Inst : IEnumerable<long>
{
public static readonly long[] Value=A265317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265317.Bytes);
public long this[int i]=>Value[i];

public static A265317Inst Instance=new A265317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265318
{
public static readonly long[] Value={ 1L,0L,2L,5L,3L,0L,6L,4L,0L,0L,7L,0L,0L,0L,0L,0L,8L,10L,0L,0L,20L,0L,0L,9L,11L,0L,19L,21L,0L,0L,0L,0L,12L,18L,0L,22L,0L,0L,0L,0L,13L,0L,17L,23L,0L,0L,0L,0L,0L,0L,14L,16L,0L,24L,26L,0L,0L,0L,0L,0L,0L,15L,0L,0L,25L,27L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,28L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265318Inst : IEnumerable<long>
{
public static readonly long[] Value=A265318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265318.Bytes);
public long this[int i]=>Value[i];

public static A265318Inst Instance=new A265318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265319
{
public static readonly BigInteger[] Value={ 1L,110L,10100L,1111000L,100010000L,11001100000L,1010101000000L,111111110000000L,10000000100000000L,1100000011000000000L,BigInteger.Parse("101000001010000000000"),BigInteger.Parse("11110000111100000000000"),BigInteger.Parse("1000100010001000000000000"),BigInteger.Parse("110011001100110000000000000"),BigInteger.Parse("10101010101010100000000000000") };
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
public class A265319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265319Inst Instance=new A265319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265320
{
public static readonly BigInteger[] Value={ 1L,110L,11100L,1101000L,111110000L,11000100000L,1110011000000L,110101110000000L,11111110100000000L,1100000111000000000L,BigInteger.Parse("111000011010000000000"),BigInteger.Parse("11010001111100000000000"),BigInteger.Parse("1111100110001000000000000"),BigInteger.Parse("110001011100110000000000000"),BigInteger.Parse("11100111101011100000000000000") };
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
public class A265320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265320.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265320Inst Instance=new A265320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265321
{
public static readonly long[] Value={ 1L,3L,6L,9L,14L,17L,22L,28L,36L,41L,47L,55L,63L,71L,82L,93L,106L,115L,126L,137L,150L,164L,180L,194L,208L,221L,234L,251L,273L,293L,309L,326L,350L,369L,383L,402L,427L,445L,465L,490L,514L,533L,557L,588L,615L,641L,665L,687L,719L,750L,778L,802L,831L,865L,895L,926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265321Inst : IEnumerable<long>
{
public static readonly long[] Value=A265321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265321.Bytes);
public long this[int i]=>Value[i];

public static A265321Inst Instance=new A265321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265322
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,8L,8L,9L,9L,14L,15L,15L,17L,19L,18L,20L,20L,26L,26L,28L,28L,29L,29L,33L,35L,38L,40L,38L,35L,39L,45L,46L,41L,48L,55L,52L,48L,57L,57L,54L,57L,64L,61L,56L,62L,65L,69L,73L,65L,68L,73L,79L,76L,73L,79L,80L,76L,81L,83L,83L,86L,89L,90L,91L,86L,91L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265322Inst : IEnumerable<long>
{
public static readonly long[] Value=A265322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265322.Bytes);
public long this[int i]=>Value[i];

public static A265322Inst Instance=new A265322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265323
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,19L,27L,36L,45L,59L,74L,89L,106L,125L,143L,163L,183L,209L,235L,263L,291L,320L,349L,382L,417L,455L,495L,533L,568L,607L,652L,698L,739L,787L,842L,894L,942L,999L,1056L,1110L,1167L,1231L,1292L,1348L,1410L,1475L,1544L,1617L,1682L,1750L,1823L,1902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265323Inst : IEnumerable<long>
{
public static readonly long[] Value=A265323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265323.Bytes);
public long this[int i]=>Value[i];

public static A265323Inst Instance=new A265323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265324
{
public static readonly BigInteger[] Value={ 2L,3L,5L,7L,11L,31L,71L,73L,97L,311L,733L,971L,991L,9311L,999331L,1111111111111111111L,BigInteger.Parse("11111111111111111111111") };
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
public class A265324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265324.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265324Inst Instance=new A265324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265325
{
public static readonly long[] Value={ 10L,90L,730L,5410L,37900L,264250L,1908910L,14322520L,110305720L,875799550L,7203731050L,60866700940L,527138423380L,4696469283970L,42797376850150L,397903278667600L,3783002076771760L,36604891556846470L,360117919584474850L,3603555076712108500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265325Inst : IEnumerable<long>
{
public static readonly long[] Value=A265325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265325.Bytes);
public long this[int i]=>Value[i];

public static A265325Inst Instance=new A265325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265326
{
public static readonly long[] Value={ 1L,0L,0L,0L,-2L,2L,0L,-6L,-6L,6L,0L,-4L,4L,-10L,-14L,10L,4L,14L,-30L,-42L,0L,-42L,-18L,12L,30L,18L,-12L,0L,18L,42L,0L,-62L,-8L,-70L,-20L,-82L,-28L,-34L,-62L,-8L,-26L,8L,-62L,62L,34L,-28L,8L,-28L,28L,62L,82L,-8L,98L,28L,0L,-186L,-84L,-210L,-60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265326Inst : IEnumerable<long>
{
public static readonly long[] Value=A265326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265326.Bytes);
public long this[int i]=>Value[i];

public static A265326Inst Instance=new A265326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265327
{
public static readonly long[] Value={ 1L,4L,13L,2L,11L,42L,9L,40L,3L,38L,5L,36L,129L,34L,127L,32L,125L,30L,123L,28L,121L,6L,119L,8L,117L,10L,115L,12L,113L,14L,111L,16L,109L,392L,107L,390L,105L,388L,103L,386L,101L,384L,99L,382L,97L,380L,95L,378L,93L,376L,91L,374L,89L,372L,87L,370L,85L,368L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265327Inst : IEnumerable<long>
{
public static readonly long[] Value=A265327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265327.Bytes);
public long this[int i]=>Value[i];

public static A265327Inst Instance=new A265327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265328
{
public static readonly long[] Value={ 1729L,46657L,2433601L,2628073L,19683001L,67371265L,110592000001L,351596817937L,422240040001L,432081216001L,2116874304001L,3176523000001L,18677955240001L,458631349862401L,286245437364810001L,312328165704192001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265328Inst : IEnumerable<long>
{
public static readonly long[] Value=A265328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265328.Bytes);
public long this[int i]=>Value[i];

public static A265328Inst Instance=new A265328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265329
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,17L,12L,19L,26L,15L,16L,11L,18L,13L,20L,21L,22L,55L,24L,25L,14L,27L,28L,65L,30L,67L,32L,39L,38L,35L,36L,37L,34L,33L,40L,145L,42L,73L,100L,45L,46L,61L,48L,79L,226L,219L,76L,121L,54L,23L,56L,57L,70L,59L,60L,47L,82L,63L,64L,29L,66L,31L,68L,81L,58L,217L,72L,43L,74L,75L,52L,193L,174L,49L,80L,69L,62L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265329Inst : IEnumerable<long>
{
public static readonly long[] Value=A265329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265329.Bytes);
public long this[int i]=>Value[i];

public static A265329Inst Instance=new A265329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265330
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,4L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,6L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,4L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,5L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,4L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,6L,0L,1L,0L,2L,0L,1L,0L,4L,0L,1L,0L,2L,0L,1L,0L,4L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265330Inst : IEnumerable<long>
{
public static readonly long[] Value=A265330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265330.Bytes);
public long this[int i]=>Value[i];

public static A265330Inst Instance=new A265330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265331
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,5L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,7L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,5L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,6L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,5L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,7L,1L,2L,1L,3L,1L,2L,1L,5L,1L,2L,1L,3L,1L,2L,1L,5L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265331Inst : IEnumerable<long>
{
public static readonly long[] Value=A265331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265331.Bytes);
public long this[int i]=>Value[i];

public static A265331Inst Instance=new A265331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265332
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,2L,4L,1L,1L,1L,2L,1L,2L,3L,5L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,6L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,7L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265332Inst : IEnumerable<long>
{
public static readonly long[] Value=A265332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265332.Bytes);
public long this[int i]=>Value[i];

public static A265332Inst Instance=new A265332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265333
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265333Inst : IEnumerable<long>
{
public static readonly long[] Value=A265333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265333.Bytes);
public long this[int i]=>Value[i];

public static A265333Inst Instance=new A265333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265334
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,9L,10L,11L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265334Inst : IEnumerable<long>
{
public static readonly long[] Value=A265334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265334.Bytes);
public long this[int i]=>Value[i];

public static A265334Inst Instance=new A265334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265335
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,9L,10L,8L,6L,7L,11L,12L,13L,29L,45L,16L,17L,33L,49L,20L,21L,37L,41L,36L,25L,26L,42L,40L,14L,30L,46L,32L,18L,34L,50L,24L,22L,38L,39L,28L,23L,27L,43L,44L,15L,31L,47L,48L,19L,35L,51L,52L,77L,141L,157L,116L,93L,109L,173L,180L,61L,125L,189L,64L,65L,129L,193L,68L,81L,145L,161L,132L,97L,113L,177L,196L,53L,117L,181L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265335Inst : IEnumerable<long>
{
public static readonly long[] Value=A265335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265335.Bytes);
public long this[int i]=>Value[i];

public static A265335Inst Instance=new A265335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265336
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,1L,3L,2L,2L,2L,2L,1L,2L,2L,4L,2L,3L,1L,3L,0L,1L,1L,3L,3L,2L,1L,2L,1L,1L,3L,6L,2L,2L,4L,4L,0L,2L,2L,4L,4L,5L,3L,4L,0L,4L,1L,4L,2L,4L,3L,3L,2L,2L,1L,3L,4L,3L,5L,2L,1L,4L,2L,5L,1L,3L,3L,5L,4L,3L,3L,5L,3L,1L,2L,3L,3L,3L,2L,5L,4L,4L,4L,4L,2L,2L,4L,6L,3L,3L,2L,4L,1L,2L,3L,6L,5L,4L,3L,4L,3L,5L,0L,5L,2L,4L,2L,3L,3L,4L,2L,4L,5L,3L,4L,3L,2L,2L,2L,3L,2L,4L,4L,5L,3L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265336Inst : IEnumerable<long>
{
public static readonly long[] Value=A265336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265336.Bytes);
public long this[int i]=>Value[i];

public static A265336Inst Instance=new A265336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265337
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,2L,1L,2L,2L,3L,2L,3L,3L,3L,1L,3L,2L,3L,2L,4L,3L,4L,2L,2L,3L,4L,3L,5L,4L,3L,1L,4L,4L,3L,2L,5L,4L,4L,2L,3L,2L,3L,3L,6L,2L,5L,2L,4L,3L,4L,3L,5L,4L,4L,3L,2L,3L,2L,4L,5L,3L,4L,1L,5L,3L,3L,2L,3L,3L,4L,2L,3L,5L,4L,3L,4L,4L,4L,2L,3L,3L,4L,3L,5L,6L,4L,2L,5L,4L,5L,4L,6L,5L,5L,2L,3L,4L,5L,3L,5L,3L,7L,3L,6L,4L,6L,4L,4L,4L,5L,3L,3L,5L,4L,5L,5L,5L,6L,4L,5L,4L,4L,3L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265337Inst : IEnumerable<long>
{
public static readonly long[] Value=A265337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265337.Bytes);
public long this[int i]=>Value[i];

public static A265337Inst Instance=new A265337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265338
{
public static readonly long[] Value={ 0L,1L,8L,7L,6L,5L,4L,3L,2L,9L,10L,71L,62L,53L,44L,35L,26L,17L,72L,89L,80L,61L,52L,43L,34L,25L,16L,63L,88L,79L,70L,51L,42L,33L,24L,15L,54L,87L,78L,69L,60L,41L,32L,23L,14L,45L,86L,77L,68L,59L,50L,31L,22L,13L,36L,85L,76L,67L,58L,49L,40L,21L,12L,27L,84L,75L,66L,57L,48L,39L,30L,11L,18L,83L,74L,65L,56L,47L,38L,29L,20L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265338Inst : IEnumerable<long>
{
public static readonly long[] Value=A265338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265338.Bytes);
public long this[int i]=>Value[i];

public static A265338Inst Instance=new A265338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265339
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,3L,2L,4L,4L,7L,9L,6L,6L,19L,10L,8L,12L,9L,7L,10L,5L,5L,19L,12L,8L,13L,13L,22L,27L,21L,18L,64L,28L,23L,36L,18L,21L,55L,11L,20L,57L,57L,24L,58L,37L,25L,30L,24L,15L,73L,31L,26L,39L,27L,22L,28L,16L,11L,64L,30L,23L,31L,14L,16L,55L,15L,20L,46L,46L,17L,58L,36L,25L,37L,17L,14L,73L,39L,26L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265339Inst : IEnumerable<long>
{
public static readonly long[] Value=A265339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265339.Bytes);
public long this[int i]=>Value[i];

public static A265339Inst Instance=new A265339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265340
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,4L,4L,5L,5L,5L,5L,5L,4L,5L,4L,4L,5L,5L,5L,5L,5L,5L,6L,5L,6L,7L,6L,6L,7L,6L,5L,6L,6L,6L,7L,7L,6L,7L,6L,6L,6L,6L,6L,7L,7L,6L,7L,6L,5L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,6L,6L,7L,7L,6L,7L,7L,6L,6L,6L,6L,7L,7L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265340Inst : IEnumerable<long>
{
public static readonly long[] Value=A265340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265340.Bytes);
public long this[int i]=>Value[i];

public static A265340Inst Instance=new A265340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265341
{
public static readonly long[] Value={ 1L,3L,7L,5L,9L,21L,13L,19L,25L,11L,15L,39L,17L,27L,63L,49L,57L,75L,31L,23L,67L,37L,55L,61L,43L,73L,79L,29L,33L,93L,47L,51L,147L,139L,111L,129L,35L,45L,117L,53L,81L,189L,157L,171L,225L,103L,69L,201L,145L,165L,183L,151L,219L,237L,85L,65L,193L,41L,71L,211L,121L,199L,205L,91L,59L,175L,109L,163L,169L,115L,181L,187L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265341Inst : IEnumerable<long>
{
public static readonly long[] Value=A265341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265341.Bytes);
public long this[int i]=>Value[i];

public static A265341Inst Instance=new A265341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265342
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,22L,12L,10L,16L,18L,20L,58L,24L,26L,76L,66L,64L,70L,36L,14L,40L,30L,28L,34L,48L,46L,52L,54L,56L,166L,60L,62L,184L,174L,172L,178L,72L,74L,220L,78L,80L,238L,228L,226L,232L,198L,68L,202L,192L,190L,196L,210L,208L,214L,108L,38L,112L,42L,44L,130L,120L,118L,124L,90L,32L,94L,84L,82L,88L,102L,100L,106L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265342Inst : IEnumerable<long>
{
public static readonly long[] Value=A265342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265342.Bytes);
public long this[int i]=>Value[i];

public static A265342Inst Instance=new A265342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265343
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,5L,6L,17L,4L,9L,10L,7L,24L,26L,14L,15L,44L,16L,18L,19L,20L,51L,53L,11L,12L,35L,13L,27L,28L,29L,30L,89L,23L,21L,62L,22L,72L,71L,25L,78L,80L,41L,42L,125L,43L,45L,46L,47L,132L,134L,50L,48L,143L,49L,54L,55L,56L,57L,170L,59L,60L,179L,58L,153L,152L,52L,159L,161L,32L,33L,98L,31L,36L,37L,34L,105L,107L,38L,39L,116L,40L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265343Inst : IEnumerable<long>
{
public static readonly long[] Value=A265343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265343.Bytes);
public long this[int i]=>Value[i];

public static A265343Inst Instance=new A265343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265344
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,5L,6L,11L,4L,9L,10L,23L,24L,26L,14L,15L,17L,7L,18L,19L,20L,33L,35L,32L,12L,38L,13L,27L,28L,29L,30L,71L,68L,69L,74L,25L,72L,73L,77L,78L,80L,41L,42L,44L,16L,45L,46L,47L,51L,53L,50L,21L,65L,22L,54L,55L,56L,57L,62L,59L,60L,101L,34L,99L,100L,104L,105L,107L,95L,96L,98L,37L,36L,109L,110L,114L,116L,113L,39L,119L,40L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265344Inst : IEnumerable<long>
{
public static readonly long[] Value=A265344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265344.Bytes);
public long this[int i]=>Value[i];

public static A265344Inst Instance=new A265344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265345
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,4L,5L,10L,12L,8L,9L,22L,20L,24L,16L,21L,18L,28L,40L,48L,64L,13L,30L,36L,56L,80L,192L,32L,19L,26L,60L,72L,112L,160L,96L,184L,25L,14L,52L,120L,144L,224L,640L,552L,352L,11L,46L,76L,208L,240L,576L,448L,320L,1056L,704L,15L,58L,68L,136L,104L,480L,288L,1720L,1600L,2112L,1408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265345Inst : IEnumerable<long>
{
public static readonly long[] Value=A265345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265345.Bytes);
public long this[int i]=>Value[i];

public static A265345Inst Instance=new A265345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265346
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,5L,4L,10L,11L,8L,46L,9L,22L,38L,56L,15L,79L,17L,29L,13L,16L,12L,191L,14L,37L,30L,92L,18L,379L,23L,172L,28L,407L,212L,667L,24L,232L,278L,67L,19L,1654L,155L,301L,69L,704L,47L,466L,20L,121L,353L,497L,39L,781L,107L,254L,25L,137L,57L,2081L,31L,277L,192L,106L,21L,1541L,68L,211L,58L,1082L,93L,1712L,32L,326L,255L,154L,48L,2702L,80L,352L,26L,821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265346Inst : IEnumerable<long>
{
public static readonly long[] Value=A265346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265346.Bytes);
public long this[int i]=>Value[i];

public static A265346Inst Instance=new A265346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265347
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,10L,5L,16L,24L,20L,22L,9L,64L,48L,40L,28L,18L,21L,32L,192L,80L,56L,36L,30L,13L,184L,96L,160L,112L,72L,60L,26L,19L,352L,552L,640L,224L,144L,120L,52L,14L,25L,704L,1056L,320L,448L,576L,240L,208L,76L,46L,11L,1408L,2112L,1600L,1720L,288L,480L,104L,136L,68L,58L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265347Inst : IEnumerable<long>
{
public static readonly long[] Value=A265347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265347.Bytes);
public long this[int i]=>Value[i];

public static A265347Inst Instance=new A265347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265348
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,5L,6L,7L,15L,9L,55L,8L,28L,44L,66L,11L,91L,20L,36L,13L,21L,14L,210L,12L,45L,35L,105L,19L,406L,27L,190L,22L,435L,230L,703L,26L,253L,299L,78L,18L,1711L,170L,325L,76L,741L,54L,496L,17L,136L,377L,528L,43L,820L,119L,276L,25L,153L,65L,2145L,34L,300L,209L,120L,16L,1596L,77L,231L,64L,1128L,104L,1770L,33L,351L,275L,171L,53L,2775L,90L,378L,24L,861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265348Inst : IEnumerable<long>
{
public static readonly long[] Value=A265348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265348.Bytes);
public long this[int i]=>Value[i];

public static A265348Inst Instance=new A265348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265349
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,10L,12L,13L,14L,18L,19L,20L,22L,23L,24L,28L,36L,42L,46L,48L,49L,50L,54L,66L,67L,68L,72L,73L,74L,76L,77L,78L,82L,84L,85L,86L,96L,97L,98L,100L,101L,102L,106L,108L,109L,110L,114L,115L,116L,118L,119L,120L,124L,132L,138L,142L,168L,186L,192L,196L,204L,216L,220L,228L,234L,238L,240L,241L,242L,246L,258L,259L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265349Inst : IEnumerable<long>
{
public static readonly long[] Value=A265349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265349.Bytes);
public long this[int i]=>Value[i];

public static A265349Inst Instance=new A265349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265350
{
public static readonly long[] Value={ 3L,7L,8L,9L,11L,15L,16L,17L,21L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,47L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,69L,70L,71L,75L,79L,80L,81L,83L,87L,88L,89L,90L,91L,92L,93L,94L,95L,99L,103L,104L,105L,107L,111L,112L,113L,117L,121L,122L,123L,125L,126L,127L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265350Inst : IEnumerable<long>
{
public static readonly long[] Value=A265350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265350.Bytes);
public long this[int i]=>Value[i];

public static A265350Inst Instance=new A265350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265351
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,11L,6L,5L,8L,9L,10L,29L,12L,13L,38L,33L,32L,35L,18L,7L,20L,15L,14L,17L,24L,23L,26L,27L,28L,83L,30L,31L,92L,87L,86L,89L,36L,37L,110L,39L,40L,119L,114L,113L,116L,99L,34L,101L,96L,95L,98L,105L,104L,107L,54L,19L,56L,21L,22L,65L,60L,59L,62L,45L,16L,47L,42L,41L,44L,51L,50L,53L,72L,25L,74L,69L,68L,71L,78L,77L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265351Inst : IEnumerable<long>
{
public static readonly long[] Value=A265351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265351.Bytes);
public long this[int i]=>Value[i];

public static A265351Inst Instance=new A265351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265352
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,19L,8L,9L,10L,5L,12L,13L,22L,21L,64L,23L,18L,55L,20L,57L,58L,25L,24L,73L,26L,27L,28L,11L,30L,31L,16L,15L,46L,17L,36L,37L,14L,39L,40L,67L,66L,199L,68L,63L,190L,65L,192L,193L,70L,69L,208L,71L,54L,163L,56L,165L,166L,61L,60L,181L,62L,171L,172L,59L,174L,175L,76L,75L,226L,77L,72L,217L,74L,219L,220L,79L,78L,235L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265352Inst : IEnumerable<long>
{
public static readonly long[] Value=A265352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265352.Bytes);
public long this[int i]=>Value[i];

public static A265352Inst Instance=new A265352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265353
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,10L,6L,9L,12L,5L,7L,19L,8L,13L,31L,24L,28L,37L,15L,11L,33L,18L,27L,30L,21L,36L,39L,14L,16L,46L,23L,25L,73L,69L,55L,64L,17L,22L,58L,26L,40L,94L,78L,85L,112L,51L,34L,100L,72L,82L,91L,75L,109L,118L,42L,32L,96L,20L,35L,105L,60L,99L,102L,45L,29L,87L,54L,81L,84L,57L,90L,93L,48L,38L,114L,63L,108L,111L,66L,117L,120L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265353Inst : IEnumerable<long>
{
public static readonly long[] Value=A265353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265353.Bytes);
public long this[int i]=>Value[i];

public static A265353Inst Instance=new A265353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265354
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,9L,6L,10L,12L,7L,5L,19L,8L,13L,27L,18L,28L,36L,21L,11L,57L,24L,37L,30L,15L,31L,39L,22L,16L,64L,23L,14L,55L,20L,46L,58L,25L,17L,73L,26L,40L,81L,54L,82L,108L,63L,29L,171L,72L,109L,90L,45L,85L,117L,66L,34L,192L,69L,38L,165L,60L,100L,174L,75L,35L,219L,78L,118L,84L,33L,91L,93L,48L,32L,138L,51L,112L,111L,42L,94L,120L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265354Inst : IEnumerable<long>
{
public static readonly long[] Value=A265354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265354.Bytes);
public long this[int i]=>Value[i];

public static A265354Inst Instance=new A265354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265355
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,9L,6L,10L,12L,5L,11L,7L,8L,13L,27L,18L,28L,36L,15L,29L,21L,24L,37L,30L,33L,31L,39L,14L,32L,16L,17L,38L,19L,20L,34L,22L,23L,35L,25L,26L,40L,81L,54L,82L,108L,45L,83L,63L,72L,109L,90L,99L,85L,117L,42L,86L,48L,51L,110L,57L,60L,88L,66L,69L,89L,75L,78L,118L,84L,87L,91L,93L,96L,92L,102L,105L,112L,111L,114L,94L,120L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265355Inst : IEnumerable<long>
{
public static readonly long[] Value=A265355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265355.Bytes);
public long this[int i]=>Value[i];

public static A265355Inst Instance=new A265355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265356
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,9L,6L,11L,12L,5L,7L,10L,8L,13L,27L,18L,29L,30L,15L,32L,33L,20L,35L,36L,21L,38L,39L,14L,16L,19L,23L,25L,28L,24L,34L,37L,17L,22L,31L,26L,40L,81L,54L,83L,84L,45L,86L,87L,56L,89L,90L,57L,92L,93L,42L,95L,96L,59L,98L,99L,60L,101L,102L,47L,104L,105L,62L,107L,108L,63L,110L,111L,48L,113L,114L,65L,116L,117L,66L,119L,120L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265356Inst : IEnumerable<long>
{
public static readonly long[] Value=A265356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265356.Bytes);
public long this[int i]=>Value[i];

public static A265356Inst Instance=new A265356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265357
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,6L,8L,11L,14L,16L,7L,17L,13L,9L,18L,32L,29L,15L,23L,20L,59L,26L,12L,56L,35L,38L,41L,43L,19L,50L,52L,10L,47L,25L,34L,44L,49L,22L,53L,40L,27L,54L,86L,83L,45L,95L,33L,167L,98L,30L,164L,89L,92L,42L,68L,24L,176L,71L,21L,60L,62L,65L,140L,77L,74L,179L,80L,36L,57L,113L,110L,137L,104L,101L,170L,107L,39L,173L,116L,119L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265357Inst : IEnumerable<long>
{
public static readonly long[] Value=A265357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265357.Bytes);
public long this[int i]=>Value[i];

public static A265357Inst Instance=new A265357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265358
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,6L,11L,7L,14L,32L,8L,23L,13L,9L,18L,10L,12L,15L,29L,20L,59L,38L,19L,56L,34L,22L,41L,95L,17L,50L,113L,16L,47L,35L,25L,68L,104L,26L,77L,40L,27L,54L,28L,36L,45L,83L,33L,96L,37L,30L,87L,31L,39L,42L,86L,24L,69L,110L,21L,60L,101L,61L,176L,302L,62L,185L,119L,55L,164L,100L,58L,167L,299L,65L,194L,115L,64L,191L,103L,67L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265358Inst : IEnumerable<long>
{
public static readonly long[] Value=A265358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265358.Bytes);
public long this[int i]=>Value[i];

public static A265358Inst Instance=new A265358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265359
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,11L,12L,13L,13L,13L,14L,15L,15L,15L,15L,16L,17L,17L,17L,17L,18L,19L,19L,19L,19L,19L,20L,21L,21L,21L,21L,21L,22L,23L,23L,23L,23L,23L,23L,24L,25L,25L,25L,25L,25L,25L,26L,27L,27L,27L,27L,27L,27L,27L,28L,29L,29L,29L,29L,29L,29L,29L,30L,31L,31L,31L,31L,31L,31L,31L,31L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265359Inst : IEnumerable<long>
{
public static readonly long[] Value=A265359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265359.Bytes);
public long this[int i]=>Value[i];

public static A265359Inst Instance=new A265359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265360
{
public static readonly long[] Value={ 6L,8L,12L,13L,19L,25L,29L,43L,53L,67L,94L,131L,173L,214L,269L,359L,479L,713L,863L,1277L,1499L,2099L,3019L,3833L,5639L,7103L,10463L,12527L,18899L,22643L,33647L,45989L,60443L,88379L,103319L,166319L,206639L,280223L,384479L,543659L,755663L,1020599L,1316699L,1856159L,2556839L,3346559L,4895963L,6649199L,8666783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265360Inst : IEnumerable<long>
{
public static readonly long[] Value=A265360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265360.Bytes);
public long this[int i]=>Value[i];

public static A265360Inst Instance=new A265360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265361
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,6L,7L,19L,14L,8L,16L,17L,13L,9L,18L,10L,12L,15L,11L,20L,59L,34L,55L,56L,22L,58L,41L,23L,43L,44L,35L,46L,47L,25L,49L,50L,26L,52L,53L,40L,27L,54L,28L,36L,45L,29L,21L,24L,37L,30L,33L,31L,39L,42L,32L,48L,51L,38L,57L,60L,61L,181L,176L,62L,178L,179L,115L,163L,164L,64L,166L,167L,65L,169L,170L,103L,172L,173L,67L,175L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265361Inst : IEnumerable<long>
{
public static readonly long[] Value=A265361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265361.Bytes);
public long this[int i]=>Value[i];

public static A265361Inst Instance=new A265361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265362
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,6L,7L,10L,14L,16L,19L,17L,13L,9L,18L,11L,12L,15L,8L,20L,47L,25L,28L,48L,34L,37L,41L,43L,46L,50L,52L,55L,51L,22L,31L,44L,49L,58L,53L,40L,27L,54L,29L,30L,45L,32L,33L,56L,35L,36L,57L,38L,39L,42L,23L,24L,59L,26L,21L,60L,61L,64L,128L,70L,73L,143L,79L,82L,144L,88L,91L,129L,97L,100L,146L,106L,109L,147L,115L,118L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265362Inst : IEnumerable<long>
{
public static readonly long[] Value=A265362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265362.Bytes);
public long this[int i]=>Value[i];

public static A265362Inst Instance=new A265362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265363
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,16L,9L,10L,11L,12L,13L,34L,21L,8L,25L,18L,19L,20L,15L,14L,43L,48L,17L,52L,27L,28L,29L,30L,31L,88L,33L,32L,97L,36L,37L,38L,39L,40L,115L,102L,35L,106L,63L,22L,61L,24L,23L,70L,75L,26L,79L,54L,55L,56L,57L,58L,169L,60L,59L,178L,45L,46L,47L,42L,41L,124L,129L,44L,133L,144L,49L,142L,51L,50L,151L,156L,53L,160L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265363Inst : IEnumerable<long>
{
public static readonly long[] Value=A265363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265363.Bytes);
public long this[int i]=>Value[i];

public static A265363Inst Instance=new A265363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265364
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,16L,9L,10L,11L,12L,13L,22L,21L,8L,25L,18L,19L,20L,15L,46L,49L,48L,17L,52L,27L,28L,29L,30L,31L,34L,33L,14L,43L,36L,37L,38L,39L,40L,67L,66L,23L,70L,63L,64L,65L,24L,73L,76L,75L,26L,79L,54L,55L,56L,57L,58L,61L,60L,47L,142L,45L,136L,137L,138L,139L,148L,147L,50L,151L,144L,145L,146L,51L,154L,157L,156L,53L,160L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265364Inst : IEnumerable<long>
{
public static readonly long[] Value=A265364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265364.Bytes);
public long this[int i]=>Value[i];

public static A265364Inst Instance=new A265364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265365
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,7L,6L,5L,4L,9L,10L,29L,24L,26L,25L,21L,23L,22L,18L,17L,20L,15L,14L,16L,12L,11L,13L,27L,28L,83L,30L,89L,88L,87L,86L,85L,72L,71L,74L,78L,80L,79L,75L,77L,76L,63L,62L,61L,69L,68L,70L,66L,65L,67L,54L,19L,56L,51L,53L,52L,60L,59L,58L,45L,44L,47L,42L,41L,43L,48L,50L,49L,36L,35L,34L,33L,32L,31L,39L,38L,40L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265365Inst : IEnumerable<long>
{
public static readonly long[] Value=A265365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265365.Bytes);
public long this[int i]=>Value[i];

public static A265365Inst Instance=new A265365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265366
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,7L,6L,5L,4L,9L,10L,25L,24L,26L,22L,21L,23L,19L,18L,55L,20L,15L,17L,16L,12L,14L,13L,27L,28L,11L,30L,77L,76L,75L,74L,73L,72L,217L,79L,78L,80L,67L,66L,68L,64L,63L,190L,65L,69L,71L,70L,57L,59L,58L,54L,163L,56L,165L,62L,61L,60L,47L,46L,45L,136L,52L,51L,53L,49L,48L,50L,37L,36L,109L,38L,42L,44L,43L,39L,41L,40L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265366Inst : IEnumerable<long>
{
public static readonly long[] Value=A265366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265366.Bytes);
public long this[int i]=>Value[i];

public static A265366Inst Instance=new A265366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265367
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,19L,6L,5L,16L,9L,10L,55L,12L,13L,58L,57L,46L,49L,18L,7L,20L,15L,14L,17L,48L,43L,52L,27L,28L,163L,30L,37L,172L,165L,136L,145L,36L,31L,166L,39L,40L,175L,174L,139L,148L,171L,22L,181L,138L,127L,154L,147L,130L,157L,54L,11L,56L,21L,34L,169L,60L,47L,142L,45L,8L,59L,42L,41L,50L,51L,44L,53L,144L,25L,178L,129L,124L,151L,156L,133L,160L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265367Inst : IEnumerable<long>
{
public static readonly long[] Value=A265367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265367.Bytes);
public long this[int i]=>Value[i];

public static A265367Inst Instance=new A265367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265368
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,19L,64L,9L,10L,55L,12L,13L,22L,21L,8L,23L,18L,5L,20L,57L,46L,199L,192L,73L,208L,27L,28L,163L,30L,37L,190L,165L,58L,193L,36L,31L,166L,39L,40L,67L,66L,25L,70L,63L,16L,61L,24L,17L,68L,69L,26L,71L,54L,11L,56L,15L,14L,65L,60L,181L,586L,171L,100L,505L,138L,127L,604L,597L,226L,631L,576L,145L,550L,219L,154L,613L,624L,235L,640L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265368Inst : IEnumerable<long>
{
public static readonly long[] Value=A265368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265368.Bytes);
public long this[int i]=>Value[i];

public static A265368Inst Instance=new A265368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265369
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,10L,11L,12L,25L,26L,21L,16L,19L,18L,17L,20L,15L,22L,59L,24L,13L,14L,27L,28L,29L,30L,41L,64L,39L,58L,53L,36L,97L,98L,33L,40L,31L,66L,121L,44L,63L,50L,61L,48L,73L,46L,105L,100L,35L,54L,65L,56L,57L,34L,23L,60L,47L,82L,45L,32L,55L,42L,137L,68L,69L,142L,131L,72L,49L,74L,219L,76L,155L,234L,79L,80L,81L,62L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265369Inst : IEnumerable<long>
{
public static readonly long[] Value=A265369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265369.Bytes);
public long this[int i]=>Value[i];

public static A265369Inst Instance=new A265369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265370
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265370Inst : IEnumerable<long>
{
public static readonly long[] Value=A265370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265370.Bytes);
public long this[int i]=>Value[i];

public static A265370Inst Instance=new A265370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265371
{
public static readonly long[] Value={ 0L,0L,1L,32L,4954L,878953L,192333677L,53404173562L,18545695848787L,7914432322153846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265371Inst : IEnumerable<long>
{
public static readonly long[] Value=A265371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265371.Bytes);
public long this[int i]=>Value[i];

public static A265371Inst Instance=new A265371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265372
{
public static readonly long[] Value={ 0L,0L,1L,236L,363850L,860077644L,3040856393843L,15614173687644042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265372Inst : IEnumerable<long>
{
public static readonly long[] Value=A265372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265372.Bytes);
public long this[int i]=>Value[i];

public static A265372Inst Instance=new A265372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265373
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,10L,1L,0L,0L,1L,32L,99L,1L,0L,0L,1L,236L,4954L,1146L,1L,0L,0L,1L,1238L,363850L,878953L,15422L,1L,0L,0L,1L,7968L,25964546L,860077644L,192333677L,237135L,1L,0L,0L,1L,49214L,2006263350L,919241950442L,3040856393843L,53404173562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265373Inst : IEnumerable<long>
{
public static readonly long[] Value=A265373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265373.Bytes);
public long this[int i]=>Value[i];

public static A265373Inst Instance=new A265373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265374
{
public static readonly long[] Value={ 1L,10L,32L,236L,1238L,7968L,49214L,324152L,2143190L,14504394L,99426578L,689852636L,4833447174L,34171252034L,243350167280L,1744518978956L,12578806997916L,91164415152504L,663757426934364L,4852711337116032L,35610643603759148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265374Inst : IEnumerable<long>
{
public static readonly long[] Value=A265374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265374.Bytes);
public long this[int i]=>Value[i];

public static A265374Inst Instance=new A265374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265375
{
public static readonly long[] Value={ 1L,99L,4954L,363850L,25964546L,2006263350L,159927435847L,13175135914848L,1111064939631727L,95607791613443343L,8362857163936394397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265375Inst : IEnumerable<long>
{
public static readonly long[] Value=A265375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265375.Bytes);
public long this[int i]=>Value[i];

public static A265375Inst Instance=new A265375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265376
{
public static readonly BigInteger[] Value={ 1L,-1L,-3L,6L,30L,-120L,-840L,5040L,45360L,-362880L,-3991680L,39916800L,518918400L,-6227020800L,-93405312000L,1307674368000L,22230464256000L,-355687428096000L,-6758061133824000L,121645100408832000L,2554547108585472000L,BigInteger.Parse("-51090942171709440000"),BigInteger.Parse("-1175091669949317120000") };
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
public class A265376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265376Inst Instance=new A265376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265377
{
public static readonly long[] Value={ 9L,35L,36L,91L,99L,100L,189L,216L,224L,225L,341L,405L,432L,440L,441L,559L,684L,748L,775L,783L,784L,855L,1071L,1196L,1241L,1260L,1287L,1295L,1296L,1584L,1729L,1800L,1925L,1989L,2016L,2024L,2025L,2241L,2331L,2584L,2800L,2925L,2989L,3016L,3024L,3025L,3059L,3060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265377Inst : IEnumerable<long>
{
public static readonly long[] Value=A265377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265377.Bytes);
public long this[int i]=>Value[i];

public static A265377Inst Instance=new A265377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265378
{
public static readonly long[] Value={ 4L,8L,10L,11L,14L,17L,20L,22L,29L,32L,44L,56L,61L,173L,202L,211L,215L,241L,388L,410L,416L,569L,583L,680L,823L,964L,1271L,1732L,2309L,2335L,2404L,2765L,3019L,3047L,4670L,5209L,6320L,6817L,7531L,9923L,11243L,14912L,17969L,21193L,28940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265378Inst : IEnumerable<long>
{
public static readonly long[] Value=A265378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265378.Bytes);
public long this[int i]=>Value[i];

public static A265378Inst Instance=new A265378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265379
{
public static readonly BigInteger[] Value={ 1L,111L,11101L,1110011L,111011101L,11100110011L,1110111011101L,111001100110011L,11101110111011101L,1110011001100110011L,BigInteger.Parse("111011101110111011101"),BigInteger.Parse("11100110011001100110011"),BigInteger.Parse("1110111011101110111011101"),BigInteger.Parse("111001100110011001100110011"),BigInteger.Parse("11101110111011101110111011101") };
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
public class A265379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265379Inst Instance=new A265379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265380
{
public static readonly ulong[] Value={ 1L,11L,111L,1110L,11101L,111011L,1110111L,11101110L,111011101L,1110111011L,11101110111L,111011101110L,1110111011101L,11101110111011L,111011101110111L,1110111011101110L,11101110111011101L,111011101110111011L,1110111011101110111L,11101110111011101110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265380Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A265380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265380.Bytes);
public ulong this[int i]=>Value[i];

public static A265380Inst Instance=new A265380Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265381
{
public static readonly long[] Value={ 1L,3L,7L,14L,29L,59L,119L,238L,477L,955L,1911L,3822L,7645L,15291L,30583L,61166L,122333L,244667L,489335L,978670L,1957341L,3914683L,7829367L,15658734L,31317469L,62634939L,125269879L,250539758L,501079517L,1002159035L,2004318071L,4008636142L,8017272285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265381Inst : IEnumerable<long>
{
public static readonly long[] Value=A265381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265381.Bytes);
public long this[int i]=>Value[i];

public static A265381Inst Instance=new A265381Inst();

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