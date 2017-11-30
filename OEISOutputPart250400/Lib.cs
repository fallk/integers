using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A070415
{
public static readonly long[] Value={ 1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L,28L,10L,8L,25L,20L,16L,19L,9L,1L,7L,18L,2L,14L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070415Inst : IEnumerable<long>
{
public static readonly long[] Value=A070415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070415.Bytes);
public long this[int i]=>Value[i];

public static A070415Inst Instance=new A070415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070416
{
public static readonly long[] Value={ 1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L,1L,7L,17L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070416Inst : IEnumerable<long>
{
public static readonly long[] Value=A070416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070416.Bytes);
public long this[int i]=>Value[i];

public static A070416Inst Instance=new A070416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070417
{
public static readonly long[] Value={ 1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L,28L,31L,19L,1L,7L,16L,13L,25L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070417Inst : IEnumerable<long>
{
public static readonly long[] Value=A070417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070417.Bytes);
public long this[int i]=>Value[i];

public static A070417Inst Instance=new A070417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070418
{
public static readonly long[] Value={ 1L,3L,14L,15L,22L,28L,44L,46L,50L,56L,68L,70L,78L,88L,92L,94L,110L,112L,118L,166L,174L,176L,184L,188L,198L,214L,224L,228L,230L,234L,236L,255L,260L,294L,306L,318L,332L,334L,342L,352L,358L,368L,376L,414L,428L,448L,454L,462L,470L,472L,492L,500L,526L,550L,580L,590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070418Inst : IEnumerable<long>
{
public static readonly long[] Value=A070418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070418.Bytes);
public long this[int i]=>Value[i];

public static A070418Inst Instance=new A070418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070419
{
public static readonly long[] Value={ 1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L,1L,7L,13L,19L,25L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070419Inst : IEnumerable<long>
{
public static readonly long[] Value=A070419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070419.Bytes);
public long this[int i]=>Value[i];

public static A070419Inst Instance=new A070419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070452
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L,10L,21L,4L,19L,6L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L,10L,21L,4L,19L,6L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070452Inst : IEnumerable<long>
{
public static readonly long[] Value=A070452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070452.Bytes);
public long this[int i]=>Value[i];

public static A070452Inst Instance=new A070452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070453
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,5L,18L,2L,19L,7L,28L,20L,14L,10L,8L,8L,10L,14L,20L,28L,7L,19L,2L,18L,5L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,5L,18L,2L,19L,7L,28L,20L,14L,10L,8L,8L,10L,14L,20L,28L,7L,19L,2L,18L,5L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,5L,18L,2L,19L,7L,28L,20L,14L,10L,8L,8L,10L,14L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070453Inst : IEnumerable<long>
{
public static readonly long[] Value=A070453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070453.Bytes);
public long this[int i]=>Value[i];

public static A070453Inst Instance=new A070453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070454
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L,0L,17L,4L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070454Inst : IEnumerable<long>
{
public static readonly long[] Value=A070454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070454.Bytes);
public long this[int i]=>Value[i];

public static A070454Inst Instance=new A070454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070455
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,3L,16L,31L,15L,1L,22L,12L,4L,31L,27L,25L,25L,27L,31L,4L,12L,22L,1L,15L,31L,16L,3L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,3L,16L,31L,15L,1L,22L,12L,4L,31L,27L,25L,25L,27L,31L,4L,12L,22L,1L,15L,31L,16L,3L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,3L,16L,31L,15L,1L,22L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070455Inst : IEnumerable<long>
{
public static readonly long[] Value=A070455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070455.Bytes);
public long this[int i]=>Value[i];

public static A070455Inst Instance=new A070455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070456
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,2L,15L,30L,13L,32L,19L,8L,33L,26L,21L,18L,17L,18L,21L,26L,33L,8L,19L,32L,13L,30L,15L,2L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,2L,15L,30L,13L,32L,19L,8L,33L,26L,21L,18L,17L,18L,21L,26L,33L,8L,19L,32L,13L,30L,15L,2L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,2L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070456Inst : IEnumerable<long>
{
public static readonly long[] Value=A070456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070456.Bytes);
public long this[int i]=>Value[i];

public static A070456Inst Instance=new A070456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070457
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,1L,14L,29L,11L,30L,16L,4L,29L,21L,15L,11L,9L,9L,11L,15L,21L,29L,4L,16L,30L,11L,29L,14L,1L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,1L,14L,29L,11L,30L,16L,4L,29L,21L,15L,11L,9L,9L,11L,15L,21L,29L,4L,16L,30L,11L,29L,14L,1L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,1L,14L,29L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070457Inst : IEnumerable<long>
{
public static readonly long[] Value=A070457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070457.Bytes);
public long this[int i]=>Value[i];

public static A070457Inst Instance=new A070457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070458
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,0L,13L,28L,9L,28L,13L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070458Inst : IEnumerable<long>
{
public static readonly long[] Value=A070458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070458.Bytes);
public long this[int i]=>Value[i];

public static A070458Inst Instance=new A070458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070459
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,12L,27L,7L,26L,10L,33L,21L,11L,3L,34L,30L,28L,28L,30L,34L,3L,11L,21L,33L,10L,26L,7L,27L,12L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,12L,27L,7L,26L,10L,33L,21L,11L,3L,34L,30L,28L,28L,30L,34L,3L,11L,21L,33L,10L,26L,7L,27L,12L,36L,25L,16L,9L,4L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070459Inst : IEnumerable<long>
{
public static readonly long[] Value=A070459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070459.Bytes);
public long this[int i]=>Value[i];

public static A070459Inst Instance=new A070459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070460
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,11L,26L,5L,24L,7L,30L,17L,6L,35L,28L,23L,20L,19L,20L,23L,28L,35L,6L,17L,30L,7L,24L,5L,26L,11L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,11L,26L,5L,24L,7L,30L,17L,6L,35L,28L,23L,20L,19L,20L,23L,28L,35L,6L,17L,30L,7L,24L,5L,26L,11L,36L,25L,16L,9L,4L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070460Inst : IEnumerable<long>
{
public static readonly long[] Value=A070460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070460.Bytes);
public long this[int i]=>Value[i];

public static A070460Inst Instance=new A070460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070461
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,10L,25L,3L,22L,4L,27L,13L,1L,30L,22L,16L,12L,10L,10L,12L,16L,22L,30L,1L,13L,27L,4L,22L,3L,25L,10L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,10L,25L,3L,22L,4L,27L,13L,1L,30L,22L,16L,12L,10L,10L,12L,16L,22L,30L,1L,13L,27L,4L,22L,3L,25L,10L,36L,25L,16L,9L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070461Inst : IEnumerable<long>
{
public static readonly long[] Value=A070461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070461.Bytes);
public long this[int i]=>Value[i];

public static A070461Inst Instance=new A070461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070462
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,9L,24L,1L,20L,1L,24L,9L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070462Inst : IEnumerable<long>
{
public static readonly long[] Value=A070462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070462.Bytes);
public long this[int i]=>Value[i];

public static A070462Inst Instance=new A070462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070463
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,8L,23L,40L,18L,39L,21L,5L,32L,20L,10L,2L,37L,33L,31L,31L,33L,37L,2L,10L,20L,32L,5L,21L,39L,18L,40L,23L,8L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,8L,23L,40L,18L,39L,21L,5L,32L,20L,10L,2L,37L,33L,31L,31L,33L,37L,2L,10L,20L,32L,5L,21L,39L,18L,40L,23L,8L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070463Inst : IEnumerable<long>
{
public static readonly long[] Value=A070463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070463.Bytes);
public long this[int i]=>Value[i];

public static A070463Inst Instance=new A070463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070464
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,7L,22L,39L,16L,37L,18L,1L,28L,15L,4L,37L,30L,25L,22L,21L,22L,25L,30L,37L,4L,15L,28L,1L,18L,37L,16L,39L,22L,7L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,7L,22L,39L,16L,37L,18L,1L,28L,15L,4L,37L,30L,25L,22L,21L,22L,25L,30L,37L,4L,15L,28L,1L,18L,37L,16L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070464Inst : IEnumerable<long>
{
public static readonly long[] Value=A070464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070464.Bytes);
public long this[int i]=>Value[i];

public static A070464Inst Instance=new A070464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070465
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,6L,21L,38L,14L,35L,15L,40L,24L,10L,41L,31L,23L,17L,13L,11L,11L,13L,17L,23L,31L,41L,10L,24L,40L,15L,35L,14L,38L,21L,6L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,6L,21L,38L,14L,35L,15L,40L,24L,10L,41L,31L,23L,17L,13L,11L,11L,13L,17L,23L,31L,41L,10L,24L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070465Inst : IEnumerable<long>
{
public static readonly long[] Value=A070465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070465.Bytes);
public long this[int i]=>Value[i];

public static A070465Inst Instance=new A070465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070466
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L,37L,20L,5L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L,37L,20L,5L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L,37L,20L,5L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,5L,20L,37L,12L,33L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070466Inst : IEnumerable<long>
{
public static readonly long[] Value=A070466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070466.Bytes);
public long this[int i]=>Value[i];

public static A070466Inst Instance=new A070466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070467
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,4L,19L,36L,10L,31L,9L,34L,16L,0L,31L,19L,9L,1L,40L,36L,34L,34L,36L,40L,1L,9L,19L,31L,0L,16L,34L,9L,31L,10L,36L,19L,4L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,4L,19L,36L,10L,31L,9L,34L,16L,0L,31L,19L,9L,1L,40L,36L,34L,34L,36L,40L,1L,9L,19L,31L,0L,16L,34L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070467Inst : IEnumerable<long>
{
public static readonly long[] Value=A070467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070467.Bytes);
public long this[int i]=>Value[i];

public static A070467Inst Instance=new A070467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070548
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,5L,5L,5L,5L,5L,5L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,9L,10L,11L,11L,11L,12L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070548Inst : IEnumerable<long>
{
public static readonly long[] Value=A070548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070548.Bytes);
public long this[int i]=>Value[i];

public static A070548Inst Instance=new A070548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070549
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,14L,15L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,20L,20L,20L,20L,20L,21L,22L,22L,22L,23L,24L,24L,25L,25L,25L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070549Inst : IEnumerable<long>
{
public static readonly long[] Value=A070549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070549.Bytes);
public long this[int i]=>Value[i];

public static A070549Inst Instance=new A070549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070550
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,10L,15L,24L,40L,65L,104L,168L,273L,442L,714L,1155L,1870L,3026L,4895L,7920L,12816L,20737L,33552L,54288L,87841L,142130L,229970L,372099L,602070L,974170L,1576239L,2550408L,4126648L,6677057L,10803704L,17480760L,28284465L,45765226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070550Inst : IEnumerable<long>
{
public static readonly long[] Value=A070550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070550.Bytes);
public long this[int i]=>Value[i];

public static A070550Inst Instance=new A070550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070551
{
public static readonly long[] Value={ 0L,1L,16L,12L,3L,4L,8L,9L,2L,6L,18L,13L,13L,18L,6L,2L,9L,8L,4L,3L,12L,16L,1L,0L,1L,16L,12L,3L,4L,8L,9L,2L,6L,18L,13L,13L,18L,6L,2L,9L,8L,4L,3L,12L,16L,1L,0L,1L,16L,12L,3L,4L,8L,9L,2L,6L,18L,13L,13L,18L,6L,2L,9L,8L,4L,3L,12L,16L,1L,0L,1L,16L,12L,3L,4L,8L,9L,2L,6L,18L,13L,13L,18L,6L,2L,9L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070551Inst : IEnumerable<long>
{
public static readonly long[] Value=A070551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070551.Bytes);
public long this[int i]=>Value[i];

public static A070551Inst Instance=new A070551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070552
{
public static readonly long[] Value={ 9L,14L,21L,25L,33L,34L,38L,57L,85L,86L,93L,94L,118L,121L,122L,133L,141L,142L,145L,158L,177L,201L,202L,205L,213L,214L,217L,218L,253L,298L,301L,302L,326L,334L,361L,381L,393L,394L,445L,446L,453L,481L,501L,514L,526L,537L,542L,553L,565L,622L,633L,634L,694L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070552Inst : IEnumerable<long>
{
public static readonly long[] Value=A070552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070552.Bytes);
public long this[int i]=>Value[i];

public static A070552Inst Instance=new A070552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070553
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,0L,3L,6L,2L,5L,1L,4L,0L,2L,4L,6L,1L,3L,5L,0L,6L,5L,4L,3L,2L,1L,0L,4L,1L,5L,2L,6L,3L,0L,5L,3L,1L,6L,4L,2L,0L,1L,2L,3L,4L,5L,6L,0L,3L,6L,2L,5L,1L,4L,0L,2L,4L,6L,1L,3L,5L,0L,6L,5L,4L,3L,2L,1L,0L,4L,1L,5L,2L,6L,3L,0L,5L,3L,1L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070553Inst : IEnumerable<long>
{
public static readonly long[] Value=A070553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070553.Bytes);
public long this[int i]=>Value[i];

public static A070553Inst Instance=new A070553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070554
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,9L,11L,3L,15L,17L,5L,21L,15L,9L,27L,29L,9L,15L,35L,11L,39L,41L,9L,45L,35L,15L,51L,27L,17L,57L,59L,15L,33L,65L,21L,69L,71L,15L,45L,77L,27L,81L,45L,27L,87L,55L,29L,51L,95L,27L,99L,101L,15L,105L,107L,35L,111L,63L,33L,75L,99L,39L,75L,125L,41L,129L,85L,27L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070554Inst : IEnumerable<long>
{
public static readonly long[] Value=A070554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070554.Bytes);
public long this[int i]=>Value[i];

public static A070554Inst Instance=new A070554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070555
{
public static readonly long[] Value={ 1L,1L,6L,15L,12L,45L,66L,21L,120L,153L,50L,231L,180L,117L,378L,435L,144L,255L,630L,209L,780L,861L,198L,1035L,840L,375L,1326L,729L,476L,1653L,1770L,465L,1056L,2145L,714L,2415L,2556L,555L,1710L,3003L,1080L,3321L,1890L,1161L,3828L,2475L,1334L,2397L,4560L,1323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070555Inst : IEnumerable<long>
{
public static readonly long[] Value=A070555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070555.Bytes);
public long this[int i]=>Value[i];

public static A070555Inst Instance=new A070555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070556
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,4L,2L,4L,2L,6L,2L,8L,4L,4L,4L,8L,4L,12L,4L,8L,6L,12L,4L,12L,8L,12L,8L,16L,4L,22L,8L,12L,8L,16L,8L,24L,12L,16L,8L,24L,8L,30L,12L,16L,12L,24L,8L,30L,12L,16L,16L,28L,12L,24L,16L,24L,16L,30L,8L,44L,22L,24L,16L,32L,12L,46L,16L,24L,16L,46L,16L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070556Inst : IEnumerable<long>
{
public static readonly long[] Value=A070556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070556.Bytes);
public long this[int i]=>Value[i];

public static A070556Inst Instance=new A070556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070557
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,15L,26L,38L,60L,85L,125L,172L,243L,325L,442L,580L,767L,986L,1275L,1612L,2045L,2548L,3179L,3910L,4812L,5849L,7109L,8554L,10285L,12259L,14599L,17255L,20372L,23895L,27991L,32603L,37925L,43890L,50725L,58361L,67053L,76727L,87678L,99825L,113503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070557Inst : IEnumerable<long>
{
public static readonly long[] Value=A070557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070557.Bytes);
public long this[int i]=>Value[i];

public static A070557Inst Instance=new A070557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070558
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,16L,28L,42L,68L,100L,151L,215L,312L,432L,605L,821L,1117L,1485L,1977L,2581L,3371L,4335L,5566L,7060L,8938L,11196L,13994L,17338L,21426L,26280L,32152L,39074L,47369L,57093L,68637L,82097L,97955L,116339L,137849L,162665L,191507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070558Inst : IEnumerable<long>
{
public static readonly long[] Value=A070558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070558.Bytes);
public long this[int i]=>Value[i];

public static A070558Inst Instance=new A070558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070559
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,16L,29L,44L,72L,108L,166L,241L,357L,504L,720L,998L,1386L,1882L,2559L,3413L,4551L,5981L,7842L,10162L,13138L,16811L,21454L,27150L,34251L,42898L,53570L,66464L,82221L,101146L,124057L,151404L,184261L,223235L,269723L,324578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070559Inst : IEnumerable<long>
{
public static readonly long[] Value=A070559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070559.Bytes);
public long this[int i]=>Value[i];

public static A070559Inst Instance=new A070559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070560
{
public static readonly long[] Value={ 1L,12L,11L,11L,10L,3L,10L,9L,9L,8L,2L,10L,9L,9L,8L,3L,8L,8L,7L,5L,2L,7L,7L,6L,7L,4L,6L,7L,4L,5L,2L,5L,6L,4L,4L,3L,5L,5L,5L,4L,2L,6L,3L,4L,3L,5L,3L,4L,3L,6L,2L,7L,5L,10L,4L,3L,6L,4L,4L,3L,2L,4L,4L,7L,7L,4L,3L,3L,9L,7L,2L,6L,6L,4L,3L,3L,8L,7L,5L,4L,2L,6L,4L,3L,9L,5L,5L,5L,6L,5L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070560Inst : IEnumerable<long>
{
public static readonly long[] Value=A070560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070560.Bytes);
public long this[int i]=>Value[i];

public static A070560Inst Instance=new A070560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070561
{
public static readonly long[] Value={ 0L,11L,10L,10L,9L,2L,9L,8L,8L,7L,1L,9L,8L,8L,7L,2L,7L,7L,6L,4L,1L,6L,6L,5L,6L,3L,5L,6L,3L,4L,1L,4L,5L,3L,3L,2L,4L,4L,4L,3L,1L,5L,2L,3L,2L,4L,2L,3L,2L,5L,1L,6L,4L,9L,3L,2L,5L,3L,3L,2L,1L,3L,3L,6L,6L,3L,2L,2L,8L,6L,1L,5L,5L,3L,2L,2L,7L,6L,4L,3L,1L,5L,3L,2L,8L,4L,4L,4L,5L,4L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070561Inst : IEnumerable<long>
{
public static readonly long[] Value=A070561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070561.Bytes);
public long this[int i]=>Value[i];

public static A070561Inst Instance=new A070561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070562
{
public static readonly long[] Value={ 0L,10L,9L,9L,8L,1L,8L,7L,7L,6L,0L,8L,7L,7L,6L,1L,6L,6L,5L,3L,0L,5L,5L,4L,5L,2L,4L,5L,2L,3L,0L,3L,4L,2L,2L,1L,3L,3L,3L,2L,0L,4L,1L,2L,1L,3L,1L,2L,1L,4L,0L,5L,3L,8L,2L,1L,4L,2L,2L,1L,0L,2L,2L,5L,5L,2L,1L,1L,7L,5L,0L,4L,4L,2L,1L,1L,6L,5L,3L,2L,0L,4L,2L,1L,7L,3L,3L,3L,4L,3L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070562Inst : IEnumerable<long>
{
public static readonly long[] Value=A070562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070562.Bytes);
public long this[int i]=>Value[i];

public static A070562Inst Instance=new A070562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070563
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070563Inst : IEnumerable<long>
{
public static readonly long[] Value=A070563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070563.Bytes);
public long this[int i]=>Value[i];

public static A070563Inst Instance=new A070563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070596
{
public static readonly long[] Value={ 0L,1L,10L,1L,1L,1L,10L,10L,10L,1L,10L,0L,1L,10L,1L,1L,1L,10L,10L,10L,1L,10L,0L,1L,10L,1L,1L,1L,10L,10L,10L,1L,10L,0L,1L,10L,1L,1L,1L,10L,10L,10L,1L,10L,0L,1L,10L,1L,1L,1L,10L,10L,10L,1L,10L,0L,1L,10L,1L,1L,1L,10L,10L,10L,1L,10L,0L,1L,10L,1L,1L,1L,10L,10L,10L,1L,10L,0L,1L,10L,1L,1L,1L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070596Inst : IEnumerable<long>
{
public static readonly long[] Value=A070596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070596.Bytes);
public long this[int i]=>Value[i];

public static A070596Inst Instance=new A070596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070597
{
public static readonly long[] Value={ 0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070597Inst : IEnumerable<long>
{
public static readonly long[] Value=A070597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070597.Bytes);
public long this[int i]=>Value[i];

public static A070597Inst Instance=new A070597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070598
{
public static readonly long[] Value={ 0L,1L,6L,9L,10L,5L,2L,11L,8L,3L,4L,7L,12L,0L,1L,6L,9L,10L,5L,2L,11L,8L,3L,4L,7L,12L,0L,1L,6L,9L,10L,5L,2L,11L,8L,3L,4L,7L,12L,0L,1L,6L,9L,10L,5L,2L,11L,8L,3L,4L,7L,12L,0L,1L,6L,9L,10L,5L,2L,11L,8L,3L,4L,7L,12L,0L,1L,6L,9L,10L,5L,2L,11L,8L,3L,4L,7L,12L,0L,1L,6L,9L,10L,5L,2L,11L,8L,3L,4L,7L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070598Inst : IEnumerable<long>
{
public static readonly long[] Value=A070598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070598.Bytes);
public long this[int i]=>Value[i];

public static A070598Inst Instance=new A070598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070599
{
public static readonly long[] Value={ 0L,1L,4L,5L,2L,3L,6L,7L,8L,11L,12L,9L,10L,13L,0L,1L,4L,5L,2L,3L,6L,7L,8L,11L,12L,9L,10L,13L,0L,1L,4L,5L,2L,3L,6L,7L,8L,11L,12L,9L,10L,13L,0L,1L,4L,5L,2L,3L,6L,7L,8L,11L,12L,9L,10L,13L,0L,1L,4L,5L,2L,3L,6L,7L,8L,11L,12L,9L,10L,13L,0L,1L,4L,5L,2L,3L,6L,7L,8L,11L,12L,9L,10L,13L,0L,1L,4L,5L,2L,3L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070599Inst : IEnumerable<long>
{
public static readonly long[] Value=A070599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070599.Bytes);
public long this[int i]=>Value[i];

public static A070599Inst Instance=new A070599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070600
{
public static readonly BigInteger[] Value={ 0L,4L,27L,81L,3125L,15625L,823543L,5764801L,40353607L,282475249L,285311670611L,3138428376721L,302875106592253L,3937376385699289L,51185893014090757L,665416609183179841L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("14063084452067724991009") };
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
public class A070600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070600Inst Instance=new A070600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070601
{
public static readonly long[] Value={ 0L,1L,15L,5L,4L,14L,7L,11L,9L,8L,6L,10L,3L,13L,12L,2L,16L,0L,1L,15L,5L,4L,14L,7L,11L,9L,8L,6L,10L,3L,13L,12L,2L,16L,0L,1L,15L,5L,4L,14L,7L,11L,9L,8L,6L,10L,3L,13L,12L,2L,16L,0L,1L,15L,5L,4L,14L,7L,11L,9L,8L,6L,10L,3L,13L,12L,2L,16L,0L,1L,15L,5L,4L,14L,7L,11L,9L,8L,6L,10L,3L,13L,12L,2L,16L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070601Inst : IEnumerable<long>
{
public static readonly long[] Value=A070601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070601.Bytes);
public long this[int i]=>Value[i];

public static A070601Inst Instance=new A070601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070602
{
public static readonly long[] Value={ 0L,1L,14L,9L,16L,11L,0L,13L,8L,9L,10L,5L,0L,7L,2L,9L,4L,17L,0L,1L,14L,9L,16L,11L,0L,13L,8L,9L,10L,5L,0L,7L,2L,9L,4L,17L,0L,1L,14L,9L,16L,11L,0L,13L,8L,9L,10L,5L,0L,7L,2L,9L,4L,17L,0L,1L,14L,9L,16L,11L,0L,13L,8L,9L,10L,5L,0L,7L,2L,9L,4L,17L,0L,1L,14L,9L,16L,11L,0L,13L,8L,9L,10L,5L,0L,7L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070602Inst : IEnumerable<long>
{
public static readonly long[] Value=A070602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070602.Bytes);
public long this[int i]=>Value[i];

public static A070602Inst Instance=new A070602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070603
{
public static readonly long[] Value={ 0L,1L,13L,15L,17L,9L,5L,11L,12L,16L,3L,7L,8L,14L,10L,2L,4L,6L,18L,0L,1L,13L,15L,17L,9L,5L,11L,12L,16L,3L,7L,8L,14L,10L,2L,4L,6L,18L,0L,1L,13L,15L,17L,9L,5L,11L,12L,16L,3L,7L,8L,14L,10L,2L,4L,6L,18L,0L,1L,13L,15L,17L,9L,5L,11L,12L,16L,3L,7L,8L,14L,10L,2L,4L,6L,18L,0L,1L,13L,15L,17L,9L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070603Inst : IEnumerable<long>
{
public static readonly long[] Value=A070603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070603.Bytes);
public long this[int i]=>Value[i];

public static A070603Inst Instance=new A070603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070604
{
public static readonly long[] Value={ 0L,1L,12L,3L,4L,5L,16L,7L,8L,9L,0L,11L,12L,13L,4L,15L,16L,17L,8L,19L,0L,1L,12L,3L,4L,5L,16L,7L,8L,9L,0L,11L,12L,13L,4L,15L,16L,17L,8L,19L,0L,1L,12L,3L,4L,5L,16L,7L,8L,9L,0L,11L,12L,13L,4L,15L,16L,17L,8L,19L,0L,1L,12L,3L,4L,5L,16L,7L,8L,9L,0L,11L,12L,13L,4L,15L,16L,17L,8L,19L,0L,1L,12L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070604Inst : IEnumerable<long>
{
public static readonly long[] Value=A070604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070604.Bytes);
public long this[int i]=>Value[i];

public static A070604Inst Instance=new A070604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070605
{
public static readonly long[] Value={ 0L,1L,11L,12L,16L,17L,6L,7L,8L,18L,19L,2L,3L,13L,14L,15L,4L,5L,9L,10L,20L,0L,1L,11L,12L,16L,17L,6L,7L,8L,18L,19L,2L,3L,13L,14L,15L,4L,5L,9L,10L,20L,0L,1L,11L,12L,16L,17L,6L,7L,8L,18L,19L,2L,3L,13L,14L,15L,4L,5L,9L,10L,20L,0L,1L,11L,12L,16L,17L,6L,7L,8L,18L,19L,2L,3L,13L,14L,15L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070605Inst : IEnumerable<long>
{
public static readonly long[] Value=A070605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070605.Bytes);
public long this[int i]=>Value[i];

public static A070605Inst Instance=new A070605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070606
{
public static readonly long[] Value={ 0L,1L,10L,1L,12L,1L,10L,21L,10L,1L,10L,11L,12L,21L,12L,1L,12L,21L,10L,21L,12L,21L,0L,1L,10L,1L,12L,1L,10L,21L,10L,1L,10L,11L,12L,21L,12L,1L,12L,21L,10L,21L,12L,21L,0L,1L,10L,1L,12L,1L,10L,21L,10L,1L,10L,11L,12L,21L,12L,1L,12L,21L,10L,21L,12L,21L,0L,1L,10L,1L,12L,1L,10L,21L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070606Inst : IEnumerable<long>
{
public static readonly long[] Value=A070606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070606.Bytes);
public long this[int i]=>Value[i];

public static A070606Inst Instance=new A070606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070607
{
public static readonly long[] Value={ 0L,1L,9L,13L,12L,20L,2L,17L,16L,8L,19L,5L,18L,4L,15L,7L,6L,21L,3L,11L,10L,14L,22L,0L,1L,9L,13L,12L,20L,2L,17L,16L,8L,19L,5L,18L,4L,15L,7L,6L,21L,3L,11L,10L,14L,22L,0L,1L,9L,13L,12L,20L,2L,17L,16L,8L,19L,5L,18L,4L,15L,7L,6L,21L,3L,11L,10L,14L,22L,0L,1L,9L,13L,12L,20L,2L,17L,16L,8L,19L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070607Inst : IEnumerable<long>
{
public static readonly long[] Value=A070607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070607.Bytes);
public long this[int i]=>Value[i];

public static A070607Inst Instance=new A070607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070608
{
public static readonly long[] Value={ 0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L,8L,15L,16L,17L,0L,19L,8L,21L,16L,23L,0L,1L,8L,3L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070608Inst : IEnumerable<long>
{
public static readonly long[] Value=A070608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070608.Bytes);
public long this[int i]=>Value[i];

public static A070608Inst Instance=new A070608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070609
{
public static readonly long[] Value={ 0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L,7L,18L,24L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070609Inst : IEnumerable<long>
{
public static readonly long[] Value=A070609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070609.Bytes);
public long this[int i]=>Value[i];

public static A070609Inst Instance=new A070609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070610
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,6L,3L,3L,2L,5L,6L,5L,3L,10L,10L,3L,5L,4L,3L,8L,5L,9L,10L,12L,3L,8L,5L,8L,5L,18L,5L,4L,13L,7L,13L,4L,2L,12L,8L,10L,8L,19L,3L,15L,6L,18L,13L,7L,3L,5L,18L,5L,7L,21L,18L,21L,7L,10L,12L,27L,4L,19L,6L,2L,15L,26L,3L,13L,19L,26L,18L,6L,2L,7L,7L,8L,19L,27L,7L,9L,2L,13L,15L,14L,13L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070610Inst : IEnumerable<long>
{
public static readonly long[] Value=A070610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070610.Bytes);
public long this[int i]=>Value[i];

public static A070610Inst Instance=new A070610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070611
{
public static readonly long[] Value={ 0L,1L,5L,0L,25L,20L,0L,13L,17L,0L,19L,23L,0L,16L,11L,0L,4L,8L,0L,10L,14L,0L,7L,2L,0L,22L,26L,0L,1L,5L,0L,25L,20L,0L,13L,17L,0L,19L,23L,0L,16L,11L,0L,4L,8L,0L,10L,14L,0L,7L,2L,0L,22L,26L,0L,1L,5L,0L,25L,20L,0L,13L,17L,0L,19L,23L,0L,16L,11L,0L,4L,8L,0L,10L,14L,0L,7L,2L,0L,22L,26L,0L,1L,5L,0L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070611Inst : IEnumerable<long>
{
public static readonly long[] Value=A070611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070611.Bytes);
public long this[int i]=>Value[i];

public static A070611Inst Instance=new A070611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070644
{
public static readonly long[] Value={ 0L,1L,1L,15L,1L,1L,15L,7L,1L,15L,1L,1L,15L,1L,7L,15L,1L,1L,15L,1L,1L,0L,1L,1L,15L,1L,1L,15L,7L,1L,15L,1L,1L,15L,1L,7L,15L,1L,1L,15L,1L,1L,0L,1L,1L,15L,1L,1L,15L,7L,1L,15L,1L,1L,15L,1L,7L,15L,1L,1L,15L,1L,1L,0L,1L,1L,15L,1L,1L,15L,7L,1L,15L,1L,1L,15L,1L,7L,15L,1L,1L,15L,1L,1L,0L,1L,1L,15L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070644Inst : IEnumerable<long>
{
public static readonly long[] Value=A070644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070644.Bytes);
public long this[int i]=>Value[i];

public static A070644Inst Instance=new A070644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070645
{
public static readonly long[] Value={ 0L,1L,20L,3L,4L,5L,16L,15L,14L,9L,12L,11L,12L,9L,14L,15L,16L,5L,4L,3L,20L,1L,0L,1L,20L,3L,4L,5L,16L,15L,14L,9L,12L,11L,12L,9L,14L,15L,16L,5L,4L,3L,20L,1L,0L,1L,20L,3L,4L,5L,16L,15L,14L,9L,12L,11L,12L,9L,14L,15L,16L,5L,4L,3L,20L,1L,0L,1L,20L,3L,4L,5L,16L,15L,14L,9L,12L,11L,12L,9L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070645Inst : IEnumerable<long>
{
public static readonly long[] Value=A070645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070645.Bytes);
public long this[int i]=>Value[i];

public static A070645Inst Instance=new A070645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070646
{
public static readonly long[] Value={ 0L,1L,18L,16L,2L,8L,12L,4L,13L,3L,6L,9L,9L,6L,3L,13L,4L,12L,8L,2L,16L,18L,1L,0L,1L,18L,16L,2L,8L,12L,4L,13L,3L,6L,9L,9L,6L,3L,13L,4L,12L,8L,2L,16L,18L,1L,0L,1L,18L,16L,2L,8L,12L,4L,13L,3L,6L,9L,9L,6L,3L,13L,4L,12L,8L,2L,16L,18L,1L,0L,1L,18L,16L,2L,8L,12L,4L,13L,3L,6L,9L,9L,6L,3L,13L,4L,12L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070646Inst : IEnumerable<long>
{
public static readonly long[] Value=A070646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070646.Bytes);
public long this[int i]=>Value[i];

public static A070646Inst Instance=new A070646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070647
{
public static readonly long[] Value={ 3L,5L,7L,5L,7L,11L,13L,11L,17L,7L,19L,13L,23L,17L,11L,19L,29L,31L,13L,23L,37L,11L,41L,17L,43L,29L,13L,31L,47L,19L,53L,37L,23L,59L,17L,61L,41L,43L,19L,67L,47L,71L,13L,29L,73L,31L,79L,53L,23L,83L,59L,89L,61L,37L,17L,97L,67L,101L,29L,41L,103L,19L,71L,107L,43L,31L,109L,73L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070647Inst : IEnumerable<long>
{
public static readonly long[] Value=A070647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070647.Bytes);
public long this[int i]=>Value[i];

public static A070647Inst Instance=new A070647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070648
{
public static readonly long[] Value={ 0L,1L,14L,4L,21L,0L,6L,24L,19L,16L,0L,11L,9L,9L,11L,0L,16L,19L,24L,6L,0L,21L,4L,14L,1L,0L,1L,14L,4L,21L,0L,6L,24L,19L,16L,0L,11L,9L,9L,11L,0L,16L,19L,24L,6L,0L,21L,4L,14L,1L,0L,1L,14L,4L,21L,0L,6L,24L,19L,16L,0L,11L,9L,9L,11L,0L,16L,19L,24L,6L,0L,21L,4L,14L,1L,0L,1L,14L,4L,21L,0L,6L,24L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070648Inst : IEnumerable<long>
{
public static readonly long[] Value=A070648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070648.Bytes);
public long this[int i]=>Value[i];

public static A070648Inst Instance=new A070648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070649
{
public static readonly long[] Value={ 0L,1L,12L,1L,14L,25L,12L,25L,12L,1L,14L,25L,14L,13L,14L,25L,14L,1L,12L,25L,12L,25L,14L,1L,12L,1L,0L,1L,12L,1L,14L,25L,12L,25L,12L,1L,14L,25L,14L,13L,14L,25L,14L,1L,12L,25L,12L,25L,14L,1L,12L,1L,0L,1L,12L,1L,14L,25L,12L,25L,12L,1L,14L,25L,14L,13L,14L,25L,14L,1L,12L,25L,12L,25L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070649Inst : IEnumerable<long>
{
public static readonly long[] Value=A070649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070649.Bytes);
public long this[int i]=>Value[i];

public static A070649Inst Instance=new A070649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070650
{
public static readonly long[] Value={ 0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L,19L,19L,0L,10L,1L,0L,1L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070650Inst : IEnumerable<long>
{
public static readonly long[] Value=A070650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070650.Bytes);
public long this[int i]=>Value[i];

public static A070650Inst Instance=new A070650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070651
{
public static readonly long[] Value={ 0L,1L,8L,1L,8L,1L,8L,21L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,21L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,21L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,21L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,21L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,21L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,21L,8L,1L,8L,1L,8L,1L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070651Inst : IEnumerable<long>
{
public static readonly long[] Value=A070651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070651.Bytes);
public long this[int i]=>Value[i];

public static A070651Inst Instance=new A070651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070652
{
public static readonly long[] Value={ 0L,1L,6L,4L,7L,23L,24L,25L,13L,16L,22L,9L,28L,20L,5L,5L,20L,28L,9L,22L,16L,13L,25L,24L,23L,7L,4L,6L,1L,0L,1L,6L,4L,7L,23L,24L,25L,13L,16L,22L,9L,28L,20L,5L,5L,20L,28L,9L,22L,16L,13L,25L,24L,23L,7L,4L,6L,1L,0L,1L,6L,4L,7L,23L,24L,25L,13L,16L,22L,9L,28L,20L,5L,5L,20L,28L,9L,22L,16L,13L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070652Inst : IEnumerable<long>
{
public static readonly long[] Value=A070652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070652.Bytes);
public long this[int i]=>Value[i];

public static A070652Inst Instance=new A070652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070653
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L,10L,21L,4L,19L,6L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L,10L,21L,4L,19L,6L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,6L,19L,4L,21L,10L,1L,24L,19L,16L,15L,16L,19L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070653Inst : IEnumerable<long>
{
public static readonly long[] Value=A070653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070653.Bytes);
public long this[int i]=>Value[i];

public static A070653Inst Instance=new A070653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070654
{
public static readonly long[] Value={ 0L,1L,2L,16L,4L,1L,1L,4L,8L,8L,2L,4L,2L,16L,8L,16L,16L,8L,16L,2L,4L,2L,8L,8L,4L,1L,1L,4L,16L,2L,1L,0L,1L,2L,16L,4L,1L,1L,4L,8L,8L,2L,4L,2L,16L,8L,16L,16L,8L,16L,2L,4L,2L,8L,8L,4L,1L,1L,4L,16L,2L,1L,0L,1L,2L,16L,4L,1L,1L,4L,8L,8L,2L,4L,2L,16L,8L,16L,16L,8L,16L,2L,4L,2L,8L,8L,4L,1L,1L,4L,16L,2L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070654Inst : IEnumerable<long>
{
public static readonly long[] Value=A070654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070654.Bytes);
public long this[int i]=>Value[i];

public static A070654Inst Instance=new A070654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070655
{
public static readonly long[] Value={ 1L,2L,4L,19380L,285090L,337536L,448630L,532390L,534430L,545140L,547536L,585106L,602056L,677076L,876180L,1007386L,1030200L,1331950L,1462000L,1736346L,1878790L,1883856L,2071960L,2194666L,2240890L,2763010L,2824720L,3018606L,3114996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070655Inst : IEnumerable<long>
{
public static readonly long[] Value=A070655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070655.Bytes);
public long this[int i]=>Value[i];

public static A070655Inst Instance=new A070655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070656
{
public static readonly long[] Value={ 0L,1L,31L,3L,4L,16L,27L,4L,25L,9L,1L,22L,12L,31L,25L,15L,16L,16L,15L,25L,31L,12L,22L,1L,9L,25L,4L,27L,16L,4L,3L,31L,1L,0L,1L,31L,3L,4L,16L,27L,4L,25L,9L,1L,22L,12L,31L,25L,15L,16L,16L,15L,25L,31L,12L,22L,1L,9L,25L,4L,27L,16L,4L,3L,31L,1L,0L,1L,31L,3L,4L,16L,27L,4L,25L,9L,1L,22L,12L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070656Inst : IEnumerable<long>
{
public static readonly long[] Value=A070656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070656.Bytes);
public long this[int i]=>Value[i];

public static A070656Inst Instance=new A070656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070657
{
public static readonly long[] Value={ 0L,1L,30L,15L,16L,19L,8L,9L,4L,21L,26L,25L,2L,33L,32L,13L,18L,17L,18L,13L,32L,33L,2L,25L,26L,21L,4L,9L,8L,19L,16L,15L,30L,1L,0L,1L,30L,15L,16L,19L,8L,9L,4L,21L,26L,25L,2L,33L,32L,13L,18L,17L,18L,13L,32L,33L,2L,25L,26L,21L,4L,9L,8L,19L,16L,15L,30L,1L,0L,1L,30L,15L,16L,19L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070657Inst : IEnumerable<long>
{
public static readonly long[] Value=A070657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070657.Bytes);
public long this[int i]=>Value[i];

public static A070657Inst Instance=new A070657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070658
{
public static readonly long[] Value={ 0L,1L,29L,29L,1L,15L,1L,14L,29L,1L,15L,1L,29L,29L,21L,15L,1L,29L,29L,1L,15L,21L,29L,29L,1L,15L,1L,29L,14L,1L,15L,1L,29L,29L,1L,0L,1L,29L,29L,1L,15L,1L,14L,29L,1L,15L,1L,29L,29L,21L,15L,1L,29L,29L,1L,15L,21L,29L,29L,1L,15L,1L,29L,14L,1L,15L,1L,29L,29L,1L,0L,1L,29L,29L,1L,15L,1L,14L,29L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070658Inst : IEnumerable<long>
{
public static readonly long[] Value=A070658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070658.Bytes);
public long this[int i]=>Value[i];

public static A070658Inst Instance=new A070658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070659
{
public static readonly long[] Value={ 0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L,0L,1L,28L,9L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070659Inst : IEnumerable<long>
{
public static readonly long[] Value=A070659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070659.Bytes);
public long this[int i]=>Value[i];

public static A070659Inst Instance=new A070659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070788
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,100L,102L,106L,108L,111L,112L,113L,114L,116L,117L,118L,119L,122L,124L,128L,133L,135L,137L,138L,166L,184L,186L,196L,199L,359L,399L,459L,539L,659L,679L,739L,759L,779L,799L,859L,879L,919L,939L,959L,979L,999L,1000L,1006L,1011L,1013L,1022L,1033L,1037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070788Inst : IEnumerable<long>
{
public static readonly long[] Value=A070788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070788.Bytes);
public long this[int i]=>Value[i];

public static A070788Inst Instance=new A070788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070789
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,25L,34L,43L,52L,59L,61L,68L,70L,77L,86L,95L,104L,109L,151L,154L,155L,157L,203L,208L,209L,250L,253L,254L,256L,302L,307L,308L,352L,353L,355L,401L,406L,407L,409L,451L,452L,454L,500L,505L,506L,508L,550L,551L,553L,604L,605L,607L,650L,652L,703L,704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070789Inst : IEnumerable<long>
{
public static readonly long[] Value=A070789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070789.Bytes);
public long this[int i]=>Value[i];

public static A070789Inst Instance=new A070789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070790
{
public static readonly long[] Value={ 3L,6L,12L,15L,21L,24L,30L,33L,39L,42L,48L,51L,57L,60L,66L,69L,75L,78L,84L,87L,93L,96L,132L,159L,165L,177L,219L,231L,258L,264L,276L,318L,330L,357L,363L,375L,417L,429L,456L,462L,474L,516L,528L,555L,561L,573L,579L,615L,627L,654L,660L,672L,678L,699L,714L,726L,753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070790Inst : IEnumerable<long>
{
public static readonly long[] Value=A070790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070790.Bytes);
public long this[int i]=>Value[i];

public static A070790Inst Instance=new A070790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070791
{
public static readonly long[] Value={ 5L,10L,11L,13L,17L,20L,22L,26L,31L,35L,40L,44L,53L,62L,71L,79L,80L,88L,97L,115L,142L,158L,170L,176L,185L,214L,241L,257L,275L,284L,313L,329L,340L,356L,374L,383L,412L,428L,455L,469L,473L,482L,511L,527L,554L,568L,572L,581L,599L,610L,626L,649L,653L,667L,671L,680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070791Inst : IEnumerable<long>
{
public static readonly long[] Value=A070791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070791.Bytes);
public long this[int i]=>Value[i];

public static A070791Inst Instance=new A070791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070792
{
public static readonly long[] Value={ 7L,14L,19L,23L,28L,29L,32L,37L,38L,41L,46L,47L,49L,50L,55L,56L,58L,64L,65L,67L,73L,74L,76L,82L,83L,85L,89L,91L,92L,94L,98L,110L,121L,136L,143L,187L,220L,235L,242L,286L,334L,341L,385L,433L,440L,484L,532L,569L,583L,631L,668L,682L,719L,730L,767L,781L,818L,866L,869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070792Inst : IEnumerable<long>
{
public static readonly long[] Value=A070792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070792.Bytes);
public long this[int i]=>Value[i];

public static A070792Inst Instance=new A070792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070793
{
public static readonly long[] Value={ 9L,18L,27L,36L,45L,54L,63L,72L,81L,90L,99L,198L,297L,396L,495L,594L,693L,792L,891L,990L,1017L,1035L,1044L,1089L,1107L,1125L,1134L,1179L,1215L,1224L,1269L,1305L,1314L,1359L,1404L,1449L,1539L,1629L,1719L,1809L,1899L,1989L,2016L,2034L,2043L,2088L,2106L,2124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070793Inst : IEnumerable<long>
{
public static readonly long[] Value=A070793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070793.Bytes);
public long this[int i]=>Value[i];

public static A070793Inst Instance=new A070793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070794
{
public static readonly long[] Value={ 100L,101L,103L,107L,188L,193L,200L,202L,206L,287L,292L,299L,301L,305L,386L,391L,398L,400L,404L,485L,490L,497L,503L,584L,596L,602L,683L,695L,701L,709L,782L,794L,800L,808L,881L,893L,907L,980L,992L,1034L,1069L,1076L,1124L,1159L,1166L,1214L,1249L,1256L,1291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070794Inst : IEnumerable<long>
{
public static readonly long[] Value=A070794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070794.Bytes);
public long this[int i]=>Value[i];

public static A070794Inst Instance=new A070794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070795
{
public static readonly long[] Value={ 102L,105L,150L,156L,201L,204L,255L,300L,303L,309L,354L,402L,408L,453L,501L,507L,552L,600L,606L,609L,651L,705L,708L,750L,804L,807L,903L,906L,1032L,1065L,1122L,1155L,1212L,1245L,1290L,1302L,1335L,1380L,1425L,1470L,1515L,1560L,1605L,1650L,1740L,1830L,1896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070795Inst : IEnumerable<long>
{
public static readonly long[] Value=A070795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070795.Bytes);
public long this[int i]=>Value[i];

public static A070795Inst Instance=new A070795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070796
{
public static readonly long[] Value={ 106L,152L,179L,205L,251L,278L,304L,350L,377L,379L,403L,476L,478L,479L,502L,509L,575L,577L,578L,601L,608L,674L,676L,677L,700L,707L,773L,775L,776L,806L,872L,874L,875L,905L,971L,973L,974L,1019L,1054L,1060L,1082L,1093L,1109L,1144L,1150L,1172L,1183L,1199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070796Inst : IEnumerable<long>
{
public static readonly long[] Value=A070796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070796.Bytes);
public long this[int i]=>Value[i];

public static A070796Inst Instance=new A070796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070797
{
public static readonly long[] Value={ 108L,126L,144L,153L,162L,171L,180L,189L,207L,225L,243L,252L,261L,270L,279L,288L,306L,324L,342L,351L,360L,378L,387L,405L,423L,441L,450L,477L,486L,504L,522L,540L,549L,576L,585L,603L,621L,648L,675L,684L,702L,720L,747L,774L,783L,801L,846L,873L,882L,900L,909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070797Inst : IEnumerable<long>
{
public static readonly long[] Value=A070797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070797.Bytes);
public long this[int i]=>Value[i];

public static A070797Inst Instance=new A070797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070798
{
public static readonly long[] Value={ 111L,123L,147L,210L,222L,246L,321L,345L,420L,444L,543L,642L,741L,789L,840L,888L,987L,1002L,1005L,1596L,1686L,1776L,1866L,1956L,2001L,2004L,2595L,2685L,2775L,2865L,2955L,3000L,3003L,3009L,3099L,3189L,3279L,3369L,3459L,3549L,3594L,3639L,3684L,3729L,3774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070798Inst : IEnumerable<long>
{
public static readonly long[] Value=A070798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070798.Bytes);
public long this[int i]=>Value[i];

public static A070798Inst Instance=new A070798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070799
{
public static readonly long[] Value={ 4L,9L,14L,19L,20L,24L,29L,31L,34L,39L,42L,44L,48L,49L,53L,54L,59L,64L,65L,69L,74L,75L,79L,82L,84L,86L,88L,89L,94L,97L,99L,104L,108L,109L,111L,114L,116L,119L,124L,129L,130L,133L,134L,139L,140L,141L,144L,149L,150L,152L,154L,157L,159L,163L,164L,167L,169L,174L,179L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070799Inst : IEnumerable<long>
{
public static readonly long[] Value=A070799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070799.Bytes);
public long this[int i]=>Value[i];

public static A070799Inst Instance=new A070799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070800
{
public static readonly long[] Value={ 2L,3L,3L,5L,3L,7L,5L,7L,5L,11L,5L,13L,7L,11L,11L,17L,7L,19L,11L,13L,11L,23L,11L,23L,13L,19L,13L,29L,11L,31L,17L,23L,17L,29L,13L,37L,19L,29L,17L,41L,13L,43L,23L,29L,23L,47L,17L,43L,23L,37L,29L,53L,19L,41L,29L,37L,29L,59L,17L,61L,31L,37L,37L,53L,23L,67L,37L,47L,29L,71L,29L,73L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070800Inst : IEnumerable<long>
{
public static readonly long[] Value=A070800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070800.Bytes);
public long this[int i]=>Value[i];

public static A070800Inst Instance=new A070800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070801
{
public static readonly long[] Value={ 3L,3L,7L,5L,11L,7L,13L,13L,17L,11L,23L,13L,23L,23L,31L,17L,37L,19L,41L,31L,31L,23L,59L,31L,41L,37L,53L,29L,71L,31L,61L,47L,53L,47L,89L,37L,59L,53L,89L,41L,89L,43L,83L,73L,71L,47L,113L,53L,89L,71L,97L,53L,113L,71L,113L,79L,89L,59L,167L,61L,89L,103L,127L,83L,139L,67L,113L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070801Inst : IEnumerable<long>
{
public static readonly long[] Value=A070801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070801.Bytes);
public long this[int i]=>Value[i];

public static A070801Inst Instance=new A070801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070802
{
public static readonly long[] Value={ 1L,0L,4L,0L,8L,0L,8L,6L,12L,0L,18L,0L,16L,12L,20L,0L,30L,0L,30L,18L,20L,0L,48L,8L,28L,18L,40L,0L,60L,0L,44L,24L,36L,18L,76L,0L,40L,24L,72L,0L,76L,0L,60L,44L,48L,0L,96L,10L,66L,34L,68L,0L,94L,30L,84L,42L,60L,0L,150L,0L,58L,66L,90L,30L,116L,0L,76L,42L,110L,0L,164L,0L,76L,72L,102L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070802Inst : IEnumerable<long>
{
public static readonly long[] Value=A070802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070802.Bytes);
public long this[int i]=>Value[i];

public static A070802Inst Instance=new A070802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070803
{
public static readonly long[] Value={ 0L,2L,2L,4L,3L,5L,4L,6L,6L,7L,5L,9L,6L,9L,9L,11L,7L,12L,8L,13L,11L,11L,9L,17L,11L,13L,12L,16L,10L,20L,11L,18L,15L,16L,15L,24L,12L,17L,16L,24L,13L,24L,14L,23L,21L,20L,15L,30L,16L,24L,20L,25L,16L,30L,20L,30L,22L,24L,17L,39L,18L,24L,27L,31L,23L,34L,19L,30L,24L,34L,20L,44L,21L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070803Inst : IEnumerable<long>
{
public static readonly long[] Value=A070803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070803.Bytes);
public long this[int i]=>Value[i];

public static A070803Inst Instance=new A070803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070820
{
public static readonly long[] Value={ 2L,3L,3L,4L,6L,4L,3L,4L,12L,8L,6L,4L,6L,8L,24L,14L,30L,6L,12L,8L,4L,14L,42L,12L,4L,6L,18L,54L,4L,8L,8L,14L,18L,24L,38L,6L,14L,4L,84L,44L,90L,6L,20L,4L,8L,12L,8L,38L,114L,20L,30L,18L,6L,6L,3L,132L,68L,6L,24L,8L,48L,74L,18L,32L,14L,80L,12L,8L,174L,30L,12L,180L,62L,32L,8L,192L,98L,12L,6L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070820Inst : IEnumerable<long>
{
public static readonly long[] Value=A070820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070820.Bytes);
public long this[int i]=>Value[i];

public static A070820Inst Instance=new A070820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070821
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,2L,0L,1L,1L,4L,0L,3L,0L,2L,1L,1L,0L,4L,1L,1L,3L,2L,0L,3L,0L,8L,1L,1L,1L,6L,0L,1L,1L,4L,0L,3L,0L,2L,3L,1L,0L,8L,1L,5L,1L,2L,0L,9L,1L,4L,1L,1L,0L,6L,0L,1L,3L,16L,1L,3L,0L,2L,1L,5L,0L,12L,0L,1L,5L,2L,1L,3L,0L,8L,9L,1L,0L,6L,1L,1L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070821Inst : IEnumerable<long>
{
public static readonly long[] Value=A070821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070821.Bytes);
public long this[int i]=>Value[i];

public static A070821Inst Instance=new A070821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070822
{
public static readonly long[] Value={ 1L,2L,4L,14L,45L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070822Inst : IEnumerable<long>
{
public static readonly long[] Value=A070822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070822.Bytes);
public long this[int i]=>Value[i];

public static A070822Inst Instance=new A070822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070823
{
public static readonly BigInteger[] Value={ 0L,1L,9L,72L,243L,47871L,23523372L,2434786275501L,8244905115337247871L,BigInteger.Parse("58101188398354233807319449027630"),BigInteger.Parse("243478627550182449084906698122045988902204111779759"),BigInteger.Parse("33753325643335988898828779215425644588407139004473126805509723691755094884662752129") };
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
public class A070823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070823Inst Instance=new A070823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070824
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,2L,1L,2L,0L,4L,0L,2L,2L,3L,0L,4L,0L,4L,2L,2L,0L,6L,1L,2L,2L,4L,0L,6L,0L,4L,2L,2L,2L,7L,0L,2L,2L,6L,0L,6L,0L,4L,4L,2L,0L,8L,1L,4L,2L,4L,0L,6L,2L,6L,2L,2L,0L,10L,0L,2L,4L,5L,2L,6L,0L,4L,2L,6L,0L,10L,0L,2L,4L,4L,2L,6L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070824Inst : IEnumerable<long>
{
public static readonly long[] Value=A070824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070824.Bytes);
public long this[int i]=>Value[i];

public static A070824Inst Instance=new A070824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070825
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,84L,924L,16632L,482328L,22669416L,1722875616L,211913700768L,42170826452832L,13579006117811904L,7074662187380001984L,BigInteger.Parse("5963940223961341672512"),BigInteger.Parse("8134814465483270041306368") };
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
public class A070825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070825.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070825Inst Instance=new A070825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070826
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,1155L,15015L,255255L,4849845L,111546435L,3234846615L,100280245065L,3710369067405L,152125131763605L,6541380665835015L,307444891294245705L,16294579238595022365UL,BigInteger.Parse("961380175077106319535"),BigInteger.Parse("58644190679703485491635"),BigInteger.Parse("3929160775540133527939545"),BigInteger.Parse("278970415063349480483707695") };
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
public class A070826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070826Inst Instance=new A070826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070827
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,11L,8L,29L,47L,23L,44L,199L,32L,521L,284L,46L,2207L,3571L,118L,9349L,2168L,244L,353L,600L,1152L,263L,90484L,5802L,14517L,19548L,2570L,3010349L,5568L,10104L,63513L,1022L,103713L,54018521L,29134604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070827Inst : IEnumerable<long>
{
public static readonly long[] Value=A070827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070827.Bytes);
public long this[int i]=>Value[i];

public static A070827Inst Instance=new A070827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070828
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,12L,18L,27L,31L,43L,53L,58L,70L,73L,76L,99L,115L,123L,118L,148L,156L,186L,208L,212L,251L,252L,265L,309L,298L,312L,342L,395L,396L,397L,454L,472L,508L,562L,561L,570L,610L,612L,654L,663L,686L,752L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070828Inst : IEnumerable<long>
{
public static readonly long[] Value=A070828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070828.Bytes);
public long this[int i]=>Value[i];

public static A070828Inst Instance=new A070828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070829
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070829Inst : IEnumerable<long>
{
public static readonly long[] Value=A070829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070829.Bytes);
public long this[int i]=>Value[i];

public static A070829Inst Instance=new A070829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070830
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,6L,9L,11L,14L,18L,23L,29L,35L,45L,56L,68L,85L,103L,125L,150L,183L,217L,266L,315L,380L,449L,534L,628L,745L,874L,1034L,1212L,1423L,1665L,1944L,2265L,2627L,3055L,3536L,4099L,4735L,5479L,6309L,7273L,8358L,9599L,11012L,12605L,14421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070830Inst : IEnumerable<long>
{
public static readonly long[] Value=A070830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070830.Bytes);
public long this[int i]=>Value[i];

public static A070830Inst Instance=new A070830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070831
{
public static readonly long[] Value={ 191L,353L,13331L,1123211L,1221221L,1303031L,1311131L,3103013L,110232011L,111050111L,112030211L,112111211L,121111121L,130030031L,301111103L,10000900001L,10002520001L,10013131001L,10111311101L,10301110301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070831Inst : IEnumerable<long>
{
public static readonly long[] Value=A070831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070831.Bytes);
public long this[int i]=>Value[i];

public static A070831Inst Instance=new A070831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070832
{
public static readonly BigInteger[] Value={ 1L,2L,12872L,1470944L,622116992L,125858012672L,36758056208384L,8793364151263232L,2334899414608412672L,BigInteger.Parse("586347560750962049024"),BigInteger.Parse("151652224498623981289472"),BigInteger.Parse("38612725801339748322639872") };
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
public class A070832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070832Inst Instance=new A070832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070833
{
public static readonly BigInteger[] Value={ 1L,2L,184758L,60090032L,139541849878L,94278969044262L,126648421364527548L,BigInteger.Parse("111019250117021378442"),BigInteger.Parse("125257104438594491956518"),BigInteger.Parse("121088185204450642433930072"),BigInteger.Parse("128442558588779813655233443038") };
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
public class A070833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070833Inst Instance=new A070833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070834
{
public static readonly BigInteger[] Value={ 1L,4L,27L,256L,3125L,46656L,823543L,16777216L,387420489L,1L,285311670611L,7355827511386641L,BigInteger.Parse("24417546297445042591"),BigInteger.Parse("37929227194915558802161"),BigInteger.Parse("41072642160770556400888251"),BigInteger.Parse("36751693856637464631913392961") };
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
public class A070834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070834Inst Instance=new A070834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}