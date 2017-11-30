using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A070620
{
public static readonly long[] Value={ 0L,1L,32L,21L,25L,17L,6L,9L,23L,34L,26L,27L,7L,35L,29L,24L,33L,19L,15L,22L,18L,4L,13L,8L,2L,30L,10L,11L,3L,14L,28L,31L,20L,12L,16L,5L,36L,0L,1L,32L,21L,25L,17L,6L,9L,23L,34L,26L,27L,7L,35L,29L,24L,33L,19L,15L,22L,18L,4L,13L,8L,2L,30L,10L,11L,3L,14L,28L,31L,20L,12L,16L,5L,36L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070620Inst : IEnumerable<long>
{
public static readonly long[] Value=A070620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070620.Bytes);
public long this[int i]=>Value[i];

public static A070620Inst Instance=new A070620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070619
{
public static readonly long[] Value={ 0L,1L,32L,27L,16L,29L,0L,31L,8L,9L,28L,23L,0L,25L,20L,27L,4L,17L,0L,19L,32L,9L,16L,11L,0L,13L,8L,27L,28L,5L,0L,7L,20L,9L,4L,35L,0L,1L,32L,27L,16L,29L,0L,31L,8L,9L,28L,23L,0L,25L,20L,27L,4L,17L,0L,19L,32L,9L,16L,11L,0L,13L,8L,27L,28L,5L,0L,7L,20L,9L,4L,35L,0L,1L,32L,27L,16L,29L,0L,31L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070619Inst : IEnumerable<long>
{
public static readonly long[] Value=A070619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070619.Bytes);
public long this[int i]=>Value[i];

public static A070619Inst Instance=new A070619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070618
{
public static readonly long[] Value={ 0L,1L,32L,33L,9L,10L,6L,7L,8L,4L,5L,16L,17L,13L,14L,15L,11L,12L,23L,24L,20L,21L,22L,18L,19L,30L,31L,27L,28L,29L,25L,26L,2L,3L,34L,0L,1L,32L,33L,9L,10L,6L,7L,8L,4L,5L,16L,17L,13L,14L,15L,11L,12L,23L,24L,20L,21L,22L,18L,19L,30L,31L,27L,28L,29L,25L,26L,2L,3L,34L,0L,1L,32L,33L,9L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070618Inst : IEnumerable<long>
{
public static readonly long[] Value=A070618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070618.Bytes);
public long this[int i]=>Value[i];

public static A070618Inst Instance=new A070618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070617
{
public static readonly long[] Value={ 0L,1L,32L,5L,4L,31L,24L,11L,26L,25L,6L,27L,20L,13L,12L,19L,16L,17L,18L,15L,22L,21L,14L,7L,28L,9L,8L,23L,10L,3L,30L,29L,2L,33L,0L,1L,32L,5L,4L,31L,24L,11L,26L,25L,6L,27L,20L,13L,12L,19L,16L,17L,18L,15L,22L,21L,14L,7L,28L,9L,8L,23L,10L,3L,30L,29L,2L,33L,0L,1L,32L,5L,4L,31L,24L,11L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070617Inst : IEnumerable<long>
{
public static readonly long[] Value=A070617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070617.Bytes);
public long this[int i]=>Value[i];

public static A070617Inst Instance=new A070617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070616
{
public static readonly long[] Value={ 0L,1L,32L,12L,1L,23L,21L,10L,32L,12L,10L,11L,12L,10L,23L,12L,1L,32L,21L,10L,23L,21L,22L,23L,21L,1L,23L,12L,10L,32L,21L,1L,32L,0L,1L,32L,12L,1L,23L,21L,10L,32L,12L,10L,11L,12L,10L,23L,12L,1L,32L,21L,10L,23L,21L,22L,23L,21L,1L,23L,12L,10L,32L,21L,1L,32L,0L,1L,32L,12L,1L,23L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070616Inst : IEnumerable<long>
{
public static readonly long[] Value=A070616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070616.Bytes);
public long this[int i]=>Value[i];

public static A070616Inst Instance=new A070616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070615
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070615Inst : IEnumerable<long>
{
public static readonly long[] Value=A070615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070615.Bytes);
public long this[int i]=>Value[i];

public static A070615Inst Instance=new A070615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070614
{
public static readonly long[] Value={ 0L,1L,1L,26L,1L,25L,26L,5L,1L,25L,25L,6L,26L,6L,5L,30L,1L,26L,25L,5L,25L,6L,6L,30L,26L,5L,6L,30L,5L,30L,30L,0L,1L,1L,26L,1L,25L,26L,5L,1L,25L,25L,6L,26L,6L,5L,30L,1L,26L,25L,5L,25L,6L,6L,30L,26L,5L,6L,30L,5L,30L,30L,0L,1L,1L,26L,1L,25L,26L,5L,1L,25L,25L,6L,26L,6L,5L,30L,1L,26L,25L,5L,25L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070614Inst : IEnumerable<long>
{
public static readonly long[] Value=A070614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070614.Bytes);
public long this[int i]=>Value[i];

public static A070614Inst Instance=new A070614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070613
{
public static readonly long[] Value={ 0L,1L,3L,11L,9L,22L,4L,16L,27L,5L,8L,14L,12L,6L,19L,10L,23L,17L,15L,21L,24L,2L,13L,25L,7L,20L,18L,26L,28L,0L,1L,3L,11L,9L,22L,4L,16L,27L,5L,8L,14L,12L,6L,19L,10L,23L,17L,15L,21L,24L,2L,13L,25L,7L,20L,18L,26L,28L,0L,1L,3L,11L,9L,22L,4L,16L,27L,5L,8L,14L,12L,6L,19L,10L,23L,17L,15L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070613Inst : IEnumerable<long>
{
public static readonly long[] Value=A070613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070613.Bytes);
public long this[int i]=>Value[i];

public static A070613Inst Instance=new A070613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070612
{
public static readonly long[] Value={ 0L,1L,4L,19L,16L,17L,20L,7L,8L,25L,12L,23L,24L,13L,0L,15L,4L,5L,16L,3L,20L,21L,8L,11L,12L,9L,24L,27L,0L,1L,4L,19L,16L,17L,20L,7L,8L,25L,12L,23L,24L,13L,0L,15L,4L,5L,16L,3L,20L,21L,8L,11L,12L,9L,24L,27L,0L,1L,4L,19L,16L,17L,20L,7L,8L,25L,12L,23L,24L,13L,0L,15L,4L,5L,16L,3L,20L,21L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070612Inst : IEnumerable<long>
{
public static readonly long[] Value=A070612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070612.Bytes);
public long this[int i]=>Value[i];

public static A070612Inst Instance=new A070612Inst();

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

public static class A070579
{
public static readonly long[] Value={ 0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070579Inst : IEnumerable<long>
{
public static readonly long[] Value=A070579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070579.Bytes);
public long this[int i]=>Value[i];

public static A070579Inst Instance=new A070579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070578
{
public static readonly long[] Value={ 0L,1L,16L,11L,11L,30L,1L,21L,1L,16L,25L,11L,16L,1L,21L,15L,16L,11L,11L,16L,15L,21L,1L,16L,11L,25L,16L,1L,21L,1L,30L,11L,11L,16L,1L,0L,1L,16L,11L,11L,30L,1L,21L,1L,16L,25L,11L,16L,1L,21L,15L,16L,11L,11L,16L,15L,21L,1L,16L,11L,25L,16L,1L,21L,1L,30L,11L,11L,16L,1L,0L,1L,16L,11L,11L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070578Inst : IEnumerable<long>
{
public static readonly long[] Value=A070578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070578.Bytes);
public long this[int i]=>Value[i];

public static A070578Inst Instance=new A070578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070577
{
public static readonly long[] Value={ 0L,1L,16L,13L,18L,13L,4L,21L,16L,33L,4L,21L,30L,1L,30L,33L,18L,17L,18L,33L,30L,1L,30L,21L,4L,33L,16L,21L,4L,13L,18L,13L,16L,1L,0L,1L,16L,13L,18L,13L,4L,21L,16L,33L,4L,21L,30L,1L,30L,33L,18L,17L,18L,33L,30L,1L,30L,21L,4L,33L,16L,21L,4L,13L,18L,13L,16L,1L,0L,1L,16L,13L,18L,13L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070577Inst : IEnumerable<long>
{
public static readonly long[] Value=A070577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070577.Bytes);
public long this[int i]=>Value[i];

public static A070577Inst Instance=new A070577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070576
{
public static readonly long[] Value={ 0L,1L,16L,15L,25L,31L,9L,25L,4L,27L,1L,22L,12L,16L,4L,3L,31L,31L,3L,4L,16L,12L,22L,1L,27L,4L,25L,9L,31L,25L,15L,16L,1L,0L,1L,16L,15L,25L,31L,9L,25L,4L,27L,1L,22L,12L,16L,4L,3L,31L,31L,3L,4L,16L,12L,22L,1L,27L,4L,25L,9L,31L,25L,15L,16L,1L,0L,1L,16L,15L,25L,31L,9L,25L,4L,27L,1L,22L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070576Inst : IEnumerable<long>
{
public static readonly long[] Value=A070576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070576.Bytes);
public long this[int i]=>Value[i];

public static A070576Inst Instance=new A070576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070575
{
public static readonly long[] Value={ 0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070575Inst : IEnumerable<long>
{
public static readonly long[] Value=A070575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070575.Bytes);
public long this[int i]=>Value[i];

public static A070575Inst Instance=new A070575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070574
{
public static readonly long[] Value={ 0L,1L,16L,19L,8L,5L,25L,14L,4L,20L,18L,9L,28L,10L,7L,2L,2L,7L,10L,28L,9L,18L,20L,4L,14L,25L,5L,8L,19L,16L,1L,0L,1L,16L,19L,8L,5L,25L,14L,4L,20L,18L,9L,28L,10L,7L,2L,2L,7L,10L,28L,9L,18L,20L,4L,14L,25L,5L,8L,19L,16L,1L,0L,1L,16L,19L,8L,5L,25L,14L,4L,20L,18L,9L,28L,10L,7L,2L,2L,7L,10L,28L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070574Inst : IEnumerable<long>
{
public static readonly long[] Value=A070574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070574.Bytes);
public long this[int i]=>Value[i];

public static A070574Inst Instance=new A070574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070573
{
public static readonly long[] Value={ 0L,1L,16L,21L,16L,25L,6L,1L,16L,21L,10L,1L,6L,1L,16L,15L,16L,1L,6L,1L,10L,21L,16L,1L,6L,25L,16L,21L,16L,1L,0L,1L,16L,21L,16L,25L,6L,1L,16L,21L,10L,1L,6L,1L,16L,15L,16L,1L,6L,1L,10L,21L,16L,1L,6L,25L,16L,21L,16L,1L,0L,1L,16L,21L,16L,25L,6L,1L,16L,21L,10L,1L,6L,1L,16L,15L,16L,1L,6L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070573Inst : IEnumerable<long>
{
public static readonly long[] Value=A070573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070573.Bytes);
public long this[int i]=>Value[i];

public static A070573Inst Instance=new A070573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070572
{
public static readonly long[] Value={ 0L,1L,16L,23L,24L,16L,20L,23L,7L,7L,24L,25L,1L,25L,20L,20L,25L,1L,25L,24L,7L,7L,23L,20L,16L,24L,23L,16L,1L,0L,1L,16L,23L,24L,16L,20L,23L,7L,7L,24L,25L,1L,25L,20L,20L,25L,1L,25L,24L,7L,7L,23L,20L,16L,24L,23L,16L,1L,0L,1L,16L,23L,24L,16L,20L,23L,7L,7L,24L,25L,1L,25L,20L,20L,25L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070572Inst : IEnumerable<long>
{
public static readonly long[] Value=A070572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070572.Bytes);
public long this[int i]=>Value[i];

public static A070572Inst Instance=new A070572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070571
{
public static readonly long[] Value={ 0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070571Inst : IEnumerable<long>
{
public static readonly long[] Value=A070571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070571.Bytes);
public long this[int i]=>Value[i];

public static A070571Inst Instance=new A070571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070570
{
public static readonly long[] Value={ 0L,1L,16L,0L,13L,4L,0L,25L,19L,0L,10L,7L,0L,22L,22L,0L,7L,10L,0L,19L,25L,0L,4L,13L,0L,16L,1L,0L,1L,16L,0L,13L,4L,0L,25L,19L,0L,10L,7L,0L,22L,22L,0L,7L,10L,0L,19L,25L,0L,4L,13L,0L,16L,1L,0L,1L,16L,0L,13L,4L,0L,25L,19L,0L,10L,7L,0L,22L,22L,0L,7L,10L,0L,19L,25L,0L,4L,13L,0L,16L,1L,0L,1L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070570Inst : IEnumerable<long>
{
public static readonly long[] Value=A070570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070570.Bytes);
public long this[int i]=>Value[i];

public static A070570Inst Instance=new A070570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070569
{
public static readonly long[] Value={ 0L,1L,16L,3L,22L,1L,22L,9L,14L,9L,16L,3L,14L,13L,14L,3L,16L,9L,14L,9L,22L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L,22L,9L,14L,9L,16L,3L,14L,13L,14L,3L,16L,9L,14L,9L,22L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L,22L,9L,14L,9L,16L,3L,14L,13L,14L,3L,16L,9L,14L,9L,22L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070569Inst : IEnumerable<long>
{
public static readonly long[] Value=A070569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070569.Bytes);
public long this[int i]=>Value[i];

public static A070569Inst Instance=new A070569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070568
{
public static readonly long[] Value={ 0L,1L,16L,6L,6L,0L,21L,1L,21L,11L,0L,16L,11L,11L,16L,0L,11L,21L,1L,21L,0L,6L,6L,16L,1L,0L,1L,16L,6L,6L,0L,21L,1L,21L,11L,0L,16L,11L,11L,16L,0L,11L,21L,1L,21L,0L,6L,6L,16L,1L,0L,1L,16L,6L,6L,0L,21L,1L,21L,11L,0L,16L,11L,11L,16L,0L,11L,21L,1L,21L,0L,6L,6L,16L,1L,0L,1L,16L,6L,6L,0L,21L,1L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070568Inst : IEnumerable<long>
{
public static readonly long[] Value=A070568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070568.Bytes);
public long this[int i]=>Value[i];

public static A070568Inst Instance=new A070568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070567
{
public static readonly long[] Value={ 0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070567Inst : IEnumerable<long>
{
public static readonly long[] Value=A070567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070567.Bytes);
public long this[int i]=>Value[i];

public static A070567Inst Instance=new A070567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070566
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,57L,59L,61L,67L,71L,73L,79L,83L,87L,89L,93L,97L,101L,103L,107L,109L,113L,117L,121L,127L,131L,137L,139L,145L,149L,151L,157L,163L,167L,169L,173L,177L,179L,181L,189L,191L,193L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070566Inst : IEnumerable<long>
{
public static readonly long[] Value=A070566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070566.Bytes);
public long this[int i]=>Value[i];

public static A070566Inst Instance=new A070566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070565
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,30L,28L,26L,24L,22L,20L,18L,16L,14L,12L,40L,37L,34L,31L,28L,25L,22L,19L,16L,13L,50L,46L,42L,38L,34L,30L,26L,22L,18L,14L,60L,55L,50L,45L,40L,35L,30L,25L,20L,15L,70L,64L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070565Inst : IEnumerable<long>
{
public static readonly long[] Value=A070565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070565.Bytes);
public long this[int i]=>Value[i];

public static A070565Inst Instance=new A070565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070564
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070564Inst : IEnumerable<long>
{
public static readonly long[] Value=A070564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070564.Bytes);
public long this[int i]=>Value[i];

public static A070564Inst Instance=new A070564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070547
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,4L,4L,5L,6L,5L,5L,7L,6L,7L,8L,7L,9L,5L,10L,9L,10L,9L,7L,11L,9L,10L,10L,8L,9L,10L,11L,13L,12L,12L,13L,11L,11L,12L,14L,12L,13L,8L,16L,15L,16L,15L,11L,19L,16L,12L,15L,11L,16L,15L,17L,16L,15L,10L,14L,15L,12L,20L,15L,20L,18L,11L,17L,16L,18L,16L,18L,15L,18L,18L,16L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070547Inst : IEnumerable<long>
{
public static readonly long[] Value=A070547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070547.Bytes);
public long this[int i]=>Value[i];

public static A070547Inst Instance=new A070547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070546
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,8L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,31L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070546Inst : IEnumerable<long>
{
public static readonly long[] Value=A070546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070546.Bytes);
public long this[int i]=>Value[i];

public static A070546Inst Instance=new A070546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070545
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,6L,7L,8L,8L,9L,9L,10L,10L,10L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,20L,20L,20L,21L,22L,23L,23L,24L,24L,25L,25L,26L,26L,26L,26L,27L,27L,28L,29L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,36L,37L,37L,38L,38L,38L,38L,39L,39L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070545Inst : IEnumerable<long>
{
public static readonly long[] Value=A070545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070545.Bytes);
public long this[int i]=>Value[i];

public static A070545Inst Instance=new A070545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070544
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,3L,3L,5L,6L,6L,6L,8L,7L,7L,7L,9L,9L,11L,11L,13L,13L,14L,13L,15L,15L,15L,16L,17L,17L,18L,18L,19L,19L,20L,20L,22L,22L,22L,22L,24L,23L,24L,24L,26L,27L,27L,27L,29L,30L,30L,30L,32L,32L,34L,34L,36L,36L,37L,36L,38L,37L,38L,38L,39L,39L,40L,40L,41L,41L,42L,42L,44L,44L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070544Inst : IEnumerable<long>
{
public static readonly long[] Value=A070544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070544.Bytes);
public long this[int i]=>Value[i];

public static A070544Inst Instance=new A070544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070543
{
public static readonly long[] Value={ 1L,3L,3L,5L,7L,6L,7L,11L,12L,10L,9L,15L,18L,18L,15L,11L,19L,24L,26L,25L,21L,13L,23L,30L,34L,35L,33L,28L,15L,27L,36L,42L,45L,45L,42L,36L,17L,31L,42L,50L,55L,57L,56L,52L,45L,19L,35L,48L,58L,65L,69L,70L,68L,63L,55L,21L,39L,54L,66L,75L,81L,84L,84L,81L,75L,66L,23L,43L,60L,74L,85L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070543Inst : IEnumerable<long>
{
public static readonly long[] Value=A070543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070543.Bytes);
public long this[int i]=>Value[i];

public static A070543Inst Instance=new A070543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070542
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,15L,26L,28L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070542Inst : IEnumerable<long>
{
public static readonly long[] Value=A070542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070542.Bytes);
public long this[int i]=>Value[i];

public static A070542Inst Instance=new A070542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070541
{
public static readonly long[] Value={ 0L,1L,16L,15L,14L,9L,20L,3L,4L,5L,12L,11L,12L,5L,4L,3L,20L,9L,14L,15L,16L,1L,0L,1L,16L,15L,14L,9L,20L,3L,4L,5L,12L,11L,12L,5L,4L,3L,20L,9L,14L,15L,16L,1L,0L,1L,16L,15L,14L,9L,20L,3L,4L,5L,12L,11L,12L,5L,4L,3L,20L,9L,14L,15L,16L,1L,0L,1L,16L,15L,14L,9L,20L,3L,4L,5L,12L,11L,12L,5L,4L,3L,20L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070541Inst : IEnumerable<long>
{
public static readonly long[] Value=A070541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070541.Bytes);
public long this[int i]=>Value[i];

public static A070541Inst Instance=new A070541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070540
{
public static readonly long[] Value={ 0L,1L,16L,18L,4L,16L,15L,7L,1L,9L,4L,4L,9L,1L,7L,15L,16L,4L,18L,16L,1L,0L,1L,16L,18L,4L,16L,15L,7L,1L,9L,4L,4L,9L,1L,7L,15L,16L,4L,18L,16L,1L,0L,1L,16L,18L,4L,16L,15L,7L,1L,9L,4L,4L,9L,1L,7L,15L,16L,4L,18L,16L,1L,0L,1L,16L,18L,4L,16L,15L,7L,1L,9L,4L,4L,9L,1L,7L,15L,16L,4L,18L,16L,1L,0L,1L,16L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070540Inst : IEnumerable<long>
{
public static readonly long[] Value=A070540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070540.Bytes);
public long this[int i]=>Value[i];

public static A070540Inst Instance=new A070540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070539
{
public static readonly long[] Value={ 0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L,1L,16L,1L,0L,1L,16L,1L,16L,5L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070539Inst : IEnumerable<long>
{
public static readonly long[] Value=A070539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070539.Bytes);
public long this[int i]=>Value[i];

public static A070539Inst Instance=new A070539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070538
{
public static readonly long[] Value={ 0L,1L,16L,5L,9L,17L,4L,7L,11L,6L,6L,11L,7L,4L,17L,9L,5L,16L,1L,0L,1L,16L,5L,9L,17L,4L,7L,11L,6L,6L,11L,7L,4L,17L,9L,5L,16L,1L,0L,1L,16L,5L,9L,17L,4L,7L,11L,6L,6L,11L,7L,4L,17L,9L,5L,16L,1L,0L,1L,16L,5L,9L,17L,4L,7L,11L,6L,6L,11L,7L,4L,17L,9L,5L,16L,1L,0L,1L,16L,5L,9L,17L,4L,7L,11L,6L,6L,11L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070538Inst : IEnumerable<long>
{
public static readonly long[] Value=A070538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070538.Bytes);
public long this[int i]=>Value[i];

public static A070538Inst Instance=new A070538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070537
{
public static readonly long[] Value={ 1L,15L,21L,30L,33L,35L,39L,42L,45L,51L,55L,57L,60L,63L,65L,66L,69L,70L,75L,77L,78L,84L,85L,87L,90L,91L,93L,95L,99L,102L,105L,110L,111L,114L,115L,117L,119L,120L,123L,126L,129L,130L,132L,133L,135L,138L,140L,141L,143L,145L,147L,150L,153L,154L,155L,156L,159L,161L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070537Inst : IEnumerable<long>
{
public static readonly long[] Value=A070537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070537.Bytes);
public long this[int i]=>Value[i];

public static A070537Inst Instance=new A070537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070536
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,4L,0L,10L,0L,0L,0L,4L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,6L,0L,0L,0L,6L,0L,6L,0L,0L,2L,0L,0L,2L,0L,18L,4L,0L,0L,8L,10L,0L,0L,0L,0L,2L,0L,20L,4L,0L,0L,0L,0L,0L,2L,24L,0L,10L,0L,0L,2L,10L,0L,10L,0L,12L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070536Inst : IEnumerable<long>
{
public static readonly long[] Value=A070536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070536.Bytes);
public long this[int i]=>Value[i];

public static A070536Inst Instance=new A070536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070535
{
public static readonly long[] Value={ 0L,1L,16L,9L,4L,13L,0L,7L,10L,9L,10L,7L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,7L,10L,9L,10L,7L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,7L,10L,9L,10L,7L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,7L,10L,9L,10L,7L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,7L,10L,9L,10L,7L,0L,13L,4L,9L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070535Inst : IEnumerable<long>
{
public static readonly long[] Value=A070535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070535.Bytes);
public long this[int i]=>Value[i];

public static A070535Inst Instance=new A070535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070534
{
public static readonly long[] Value={ 0L,1L,16L,13L,1L,13L,4L,4L,16L,16L,4L,4L,13L,1L,13L,16L,1L,0L,1L,16L,13L,1L,13L,4L,4L,16L,16L,4L,4L,13L,1L,13L,16L,1L,0L,1L,16L,13L,1L,13L,4L,4L,16L,16L,4L,4L,13L,1L,13L,16L,1L,0L,1L,16L,13L,1L,13L,4L,4L,16L,16L,4L,4L,13L,1L,13L,16L,1L,0L,1L,16L,13L,1L,13L,4L,4L,16L,16L,4L,4L,13L,1L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070534Inst : IEnumerable<long>
{
public static readonly long[] Value=A070534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070534.Bytes);
public long this[int i]=>Value[i];

public static A070534Inst Instance=new A070534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070533
{
public static readonly long[] Value={ 0L,1L,1L,6L,1L,10L,6L,1L,1L,6L,10L,1L,6L,1L,1L,0L,1L,1L,6L,1L,10L,6L,1L,1L,6L,10L,1L,6L,1L,1L,0L,1L,1L,6L,1L,10L,6L,1L,1L,6L,10L,1L,6L,1L,1L,0L,1L,1L,6L,1L,10L,6L,1L,1L,6L,10L,1L,6L,1L,1L,0L,1L,1L,6L,1L,10L,6L,1L,1L,6L,10L,1L,6L,1L,1L,0L,1L,1L,6L,1L,10L,6L,1L,1L,6L,10L,1L,6L,1L,1L,0L,1L,1L,6L,1L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070533Inst : IEnumerable<long>
{
public static readonly long[] Value=A070533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070533.Bytes);
public long this[int i]=>Value[i];

public static A070533Inst Instance=new A070533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070532
{
public static readonly long[] Value={ 0L,1L,2L,11L,4L,9L,8L,7L,8L,9L,4L,11L,2L,1L,0L,1L,2L,11L,4L,9L,8L,7L,8L,9L,4L,11L,2L,1L,0L,1L,2L,11L,4L,9L,8L,7L,8L,9L,4L,11L,2L,1L,0L,1L,2L,11L,4L,9L,8L,7L,8L,9L,4L,11L,2L,1L,0L,1L,2L,11L,4L,9L,8L,7L,8L,9L,4L,11L,2L,1L,0L,1L,2L,11L,4L,9L,8L,7L,8L,9L,4L,11L,2L,1L,0L,1L,2L,11L,4L,9L,8L,7L,8L,9L,4L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070532Inst : IEnumerable<long>
{
public static readonly long[] Value=A070532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070532.Bytes);
public long this[int i]=>Value[i];

public static A070532Inst Instance=new A070532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070515
{
public static readonly long[] Value={ 0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070515Inst : IEnumerable<long>
{
public static readonly long[] Value=A070515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070515.Bytes);
public long this[int i]=>Value[i];

public static A070515Inst Instance=new A070515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070514
{
public static readonly long[] Value={ 0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070514Inst : IEnumerable<long>
{
public static readonly long[] Value=A070514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070514.Bytes);
public long this[int i]=>Value[i];

public static A070514Inst Instance=new A070514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070513
{
public static readonly long[] Value={ 0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070513Inst : IEnumerable<long>
{
public static readonly long[] Value=A070513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070513.Bytes);
public long this[int i]=>Value[i];

public static A070513Inst Instance=new A070513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070512
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070512Inst : IEnumerable<long>
{
public static readonly long[] Value=A070512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070512.Bytes);
public long this[int i]=>Value[i];

public static A070512Inst Instance=new A070512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070511
{
public static readonly long[] Value={ 0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070511Inst : IEnumerable<long>
{
public static readonly long[] Value=A070511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070511.Bytes);
public long this[int i]=>Value[i];

public static A070511Inst Instance=new A070511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070510
{
public static readonly long[] Value={ 0L,1L,8L,27L,16L,29L,24L,7L,32L,9L,40L,35L,0L,37L,8L,15L,16L,17L,24L,43L,32L,45L,40L,23L,0L,25L,8L,3L,16L,5L,24L,31L,32L,33L,40L,11L,0L,13L,8L,39L,16L,41L,24L,19L,32L,21L,40L,47L,0L,1L,8L,27L,16L,29L,24L,7L,32L,9L,40L,35L,0L,37L,8L,15L,16L,17L,24L,43L,32L,45L,40L,23L,0L,25L,8L,3L,16L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070510Inst : IEnumerable<long>
{
public static readonly long[] Value=A070510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070510.Bytes);
public long this[int i]=>Value[i];

public static A070510Inst Instance=new A070510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070509
{
public static readonly long[] Value={ 0L,1L,8L,27L,17L,31L,28L,14L,42L,24L,13L,15L,36L,35L,18L,38L,7L,25L,4L,44L,10L,2L,26L,41L,6L,21L,45L,37L,3L,43L,22L,40L,9L,29L,12L,11L,32L,34L,23L,5L,33L,19L,16L,30L,20L,39L,46L,0L,1L,8L,27L,17L,31L,28L,14L,42L,24L,13L,15L,36L,35L,18L,38L,7L,25L,4L,44L,10L,2L,26L,41L,6L,21L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070509Inst : IEnumerable<long>
{
public static readonly long[] Value=A070509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070509.Bytes);
public long this[int i]=>Value[i];

public static A070509Inst Instance=new A070509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070508
{
public static readonly long[] Value={ 0L,1L,8L,27L,18L,33L,32L,21L,6L,39L,34L,43L,26L,35L,30L,17L,2L,37L,36L,5L,42L,15L,22L,23L,24L,31L,4L,41L,10L,9L,44L,29L,16L,11L,20L,3L,12L,7L,40L,25L,14L,13L,28L,19L,38L,45L,0L,1L,8L,27L,18L,33L,32L,21L,6L,39L,34L,43L,26L,35L,30L,17L,2L,37L,36L,5L,42L,15L,22L,23L,24L,31L,4L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070508Inst : IEnumerable<long>
{
public static readonly long[] Value=A070508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070508.Bytes);
public long this[int i]=>Value[i];

public static A070508Inst Instance=new A070508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070507
{
public static readonly long[] Value={ 0L,1L,8L,27L,19L,35L,36L,28L,17L,9L,10L,26L,18L,37L,44L,0L,1L,8L,27L,19L,35L,36L,28L,17L,9L,10L,26L,18L,37L,44L,0L,1L,8L,27L,19L,35L,36L,28L,17L,9L,10L,26L,18L,37L,44L,0L,1L,8L,27L,19L,35L,36L,28L,17L,9L,10L,26L,18L,37L,44L,0L,1L,8L,27L,19L,35L,36L,28L,17L,9L,10L,26L,18L,37L,44L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070507Inst : IEnumerable<long>
{
public static readonly long[] Value=A070507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070507.Bytes);
public long this[int i]=>Value[i];

public static A070507Inst Instance=new A070507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070506
{
public static readonly long[] Value={ 0L,1L,8L,27L,20L,37L,40L,35L,28L,25L,32L,11L,12L,41L,16L,31L,4L,29L,24L,39L,36L,21L,0L,23L,8L,5L,20L,15L,40L,13L,28L,3L,32L,33L,12L,19L,16L,9L,4L,7L,24L,17L,36L,43L,0L,1L,8L,27L,20L,37L,40L,35L,28L,25L,32L,11L,12L,41L,16L,31L,4L,29L,24L,39L,36L,21L,0L,23L,8L,5L,20L,15L,40L,13L,28L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070506Inst : IEnumerable<long>
{
public static readonly long[] Value=A070506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070506.Bytes);
public long this[int i]=>Value[i];

public static A070506Inst Instance=new A070506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070505
{
public static readonly long[] Value={ 0L,1L,8L,27L,21L,39L,1L,42L,39L,41L,11L,41L,8L,4L,35L,21L,11L,11L,27L,22L,2L,16L,27L,41L,21L,16L,32L,32L,22L,8L,39L,35L,2L,32L,2L,4L,1L,42L,4L,22L,16L,35L,42L,0L,1L,8L,27L,21L,39L,1L,42L,39L,41L,11L,41L,8L,4L,35L,21L,11L,11L,27L,22L,2L,16L,27L,41L,21L,16L,32L,32L,22L,8L,39L,35L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070505Inst : IEnumerable<long>
{
public static readonly long[] Value=A070505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070505.Bytes);
public long this[int i]=>Value[i];

public static A070505Inst Instance=new A070505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070504
{
public static readonly long[] Value={ 0L,1L,8L,27L,22L,41L,6L,7L,8L,15L,34L,29L,6L,13L,14L,15L,22L,41L,36L,13L,20L,21L,22L,29L,6L,1L,20L,27L,28L,29L,36L,13L,8L,27L,34L,35L,36L,1L,20L,15L,34L,41L,0L,1L,8L,27L,22L,41L,6L,7L,8L,15L,34L,29L,6L,13L,14L,15L,22L,41L,36L,13L,20L,21L,22L,29L,6L,1L,20L,27L,28L,29L,36L,13L,8L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070504Inst : IEnumerable<long>
{
public static readonly long[] Value=A070504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070504.Bytes);
public long this[int i]=>Value[i];

public static A070504Inst Instance=new A070504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070503
{
public static readonly long[] Value={ 0L,1L,8L,27L,23L,2L,11L,15L,20L,32L,16L,19L,6L,24L,38L,13L,37L,34L,10L,12L,5L,36L,29L,31L,7L,4L,28L,3L,17L,35L,22L,25L,9L,21L,26L,30L,39L,18L,14L,33L,40L,0L,1L,8L,27L,23L,2L,11L,15L,20L,32L,16L,19L,6L,24L,38L,13L,37L,34L,10L,12L,5L,36L,29L,31L,7L,4L,28L,3L,17L,35L,22L,25L,9L,21L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070503Inst : IEnumerable<long>
{
public static readonly long[] Value=A070503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070503.Bytes);
public long this[int i]=>Value[i];

public static A070503Inst Instance=new A070503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070502
{
public static readonly long[] Value={ 0L,1L,8L,27L,24L,5L,16L,23L,32L,9L,0L,11L,8L,37L,24L,15L,16L,33L,32L,19L,0L,21L,8L,7L,24L,25L,16L,3L,32L,29L,0L,31L,8L,17L,24L,35L,16L,13L,32L,39L,0L,1L,8L,27L,24L,5L,16L,23L,32L,9L,0L,11L,8L,37L,24L,15L,16L,33L,32L,19L,0L,21L,8L,7L,24L,25L,16L,3L,32L,29L,0L,31L,8L,17L,24L,35L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070502Inst : IEnumerable<long>
{
public static readonly long[] Value=A070502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070502.Bytes);
public long this[int i]=>Value[i];

public static A070502Inst Instance=new A070502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070501
{
public static readonly long[] Value={ 0L,1L,8L,27L,25L,8L,21L,31L,5L,27L,25L,5L,12L,13L,14L,21L,1L,38L,21L,34L,5L,18L,1L,38L,18L,25L,26L,27L,34L,14L,12L,34L,8L,18L,31L,14L,12L,31L,38L,0L,1L,8L,27L,25L,8L,21L,31L,5L,27L,25L,5L,12L,13L,14L,21L,1L,38L,21L,34L,5L,18L,1L,38L,18L,25L,26L,27L,34L,14L,12L,34L,8L,18L,31L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070501Inst : IEnumerable<long>
{
public static readonly long[] Value=A070501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070501.Bytes);
public long this[int i]=>Value[i];

public static A070501Inst Instance=new A070501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070500
{
public static readonly long[] Value={ 0L,1L,8L,27L,26L,11L,26L,1L,18L,7L,12L,1L,18L,31L,8L,31L,30L,11L,18L,19L,20L,27L,8L,7L,30L,7L,20L,37L,26L,31L,20L,37L,12L,27L,12L,11L,30L,37L,0L,1L,8L,27L,26L,11L,26L,1L,18L,7L,12L,1L,18L,31L,8L,31L,30L,11L,18L,19L,20L,27L,8L,7L,30L,7L,20L,37L,26L,31L,20L,37L,12L,27L,12L,11L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070500Inst : IEnumerable<long>
{
public static readonly long[] Value=A070500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070500.Bytes);
public long this[int i]=>Value[i];

public static A070500Inst Instance=new A070500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070387
{
public static readonly long[] Value={ 1L,5L,25L,2L,10L,9L,4L,20L,18L,8L,40L,36L,16L,39L,31L,32L,37L,21L,23L,33L,1L,5L,25L,2L,10L,9L,4L,20L,18L,8L,40L,36L,16L,39L,31L,32L,37L,21L,23L,33L,1L,5L,25L,2L,10L,9L,4L,20L,18L,8L,40L,36L,16L,39L,31L,32L,37L,21L,23L,33L,1L,5L,25L,2L,10L,9L,4L,20L,18L,8L,40L,36L,16L,39L,31L,32L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070387Inst : IEnumerable<long>
{
public static readonly long[] Value=A070387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070387.Bytes);
public long this[int i]=>Value[i];

public static A070387Inst Instance=new A070387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070386
{
public static readonly long[] Value={ 1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L,5L,25L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070386Inst : IEnumerable<long>
{
public static readonly long[] Value=A070386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070386.Bytes);
public long this[int i]=>Value[i];

public static A070386Inst Instance=new A070386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070385
{
public static readonly long[] Value={ 1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L,1L,5L,25L,11L,17L,9L,7L,35L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070385Inst : IEnumerable<long>
{
public static readonly long[] Value=A070385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070385.Bytes);
public long this[int i]=>Value[i];

public static A070385Inst Instance=new A070385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070384
{
public static readonly long[] Value={ 1L,5L,25L,14L,33L,17L,11L,18L,16L,6L,30L,2L,10L,13L,28L,29L,34L,22L,36L,32L,12L,23L,4L,20L,26L,19L,21L,31L,7L,35L,27L,24L,9L,8L,3L,15L,1L,5L,25L,14L,33L,17L,11L,18L,16L,6L,30L,2L,10L,13L,28L,29L,34L,22L,36L,32L,12L,23L,4L,20L,26L,19L,21L,31L,7L,35L,27L,24L,9L,8L,3L,15L,1L,5L,25L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070384Inst : IEnumerable<long>
{
public static readonly long[] Value=A070384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070384.Bytes);
public long this[int i]=>Value[i];

public static A070384Inst Instance=new A070384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070383
{
public static readonly long[] Value={ 1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L,1L,5L,25L,17L,13L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070383Inst : IEnumerable<long>
{
public static readonly long[] Value=A070383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070383.Bytes);
public long this[int i]=>Value[i];

public static A070383Inst Instance=new A070383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070382
{
public static readonly long[] Value={ 1L,5L,25L,23L,13L,31L,19L,27L,33L,29L,9L,11L,21L,3L,15L,7L,1L,5L,25L,23L,13L,31L,19L,27L,33L,29L,9L,11L,21L,3L,15L,7L,1L,5L,25L,23L,13L,31L,19L,27L,33L,29L,9L,11L,21L,3L,15L,7L,1L,5L,25L,23L,13L,31L,19L,27L,33L,29L,9L,11L,21L,3L,15L,7L,1L,5L,25L,23L,13L,31L,19L,27L,33L,29L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070382Inst : IEnumerable<long>
{
public static readonly long[] Value=A070382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070382.Bytes);
public long this[int i]=>Value[i];

public static A070382Inst Instance=new A070382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070381
{
public static readonly long[] Value={ 1L,5L,25L,26L,31L,23L,16L,14L,4L,20L,1L,5L,25L,26L,31L,23L,16L,14L,4L,20L,1L,5L,25L,26L,31L,23L,16L,14L,4L,20L,1L,5L,25L,26L,31L,23L,16L,14L,4L,20L,1L,5L,25L,26L,31L,23L,16L,14L,4L,20L,1L,5L,25L,26L,31L,23L,16L,14L,4L,20L,1L,5L,25L,26L,31L,23L,16L,14L,4L,20L,1L,5L,25L,26L,31L,23L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070381Inst : IEnumerable<long>
{
public static readonly long[] Value=A070381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070381.Bytes);
public long this[int i]=>Value[i];

public static A070381Inst Instance=new A070381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070380
{
public static readonly long[] Value={ 1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L,13L,1L,5L,25L,29L,17L,21L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070380Inst : IEnumerable<long>
{
public static readonly long[] Value=A070380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070380.Bytes);
public long this[int i]=>Value[i];

public static A070380Inst Instance=new A070380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070379
{
public static readonly long[] Value={ 1L,5L,25L,9L,16L,22L,23L,28L,24L,4L,20L,13L,7L,6L,1L,5L,25L,9L,16L,22L,23L,28L,24L,4L,20L,13L,7L,6L,1L,5L,25L,9L,16L,22L,23L,28L,24L,4L,20L,13L,7L,6L,1L,5L,25L,9L,16L,22L,23L,28L,24L,4L,20L,13L,7L,6L,1L,5L,25L,9L,16L,22L,23L,28L,24L,4L,20L,13L,7L,6L,1L,5L,25L,9L,16L,22L,23L,28L,24L,4L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070379Inst : IEnumerable<long>
{
public static readonly long[] Value=A070379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070379.Bytes);
public long this[int i]=>Value[i];

public static A070379Inst Instance=new A070379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070378
{
public static readonly long[] Value={ 1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L,17L,1L,5L,25L,13L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070378Inst : IEnumerable<long>
{
public static readonly long[] Value=A070378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070378.Bytes);
public long this[int i]=>Value[i];

public static A070378Inst Instance=new A070378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070377
{
public static readonly long[] Value={ 1L,5L,25L,17L,4L,20L,19L,14L,16L,26L,22L,2L,10L,23L,7L,8L,13L,11L,1L,5L,25L,17L,4L,20L,19L,14L,16L,26L,22L,2L,10L,23L,7L,8L,13L,11L,1L,5L,25L,17L,4L,20L,19L,14L,16L,26L,22L,2L,10L,23L,7L,8L,13L,11L,1L,5L,25L,17L,4L,20L,19L,14L,16L,26L,22L,2L,10L,23L,7L,8L,13L,11L,1L,5L,25L,17L,4L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070377Inst : IEnumerable<long>
{
public static readonly long[] Value=A070377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070377.Bytes);
public long this[int i]=>Value[i];

public static A070377Inst Instance=new A070377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070376
{
public static readonly long[] Value={ 1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L,1L,5L,25L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070376Inst : IEnumerable<long>
{
public static readonly long[] Value=A070376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070376.Bytes);
public long this[int i]=>Value[i];

public static A070376Inst Instance=new A070376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070375
{
public static readonly long[] Value={ 1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L,9L,1L,5L,3L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070375Inst : IEnumerable<long>
{
public static readonly long[] Value=A070375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070375.Bytes);
public long this[int i]=>Value[i];

public static A070375Inst Instance=new A070375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070374
{
public static readonly long[] Value={ 1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L,17L,1L,5L,4L,20L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070374Inst : IEnumerable<long>
{
public static readonly long[] Value=A070374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070374.Bytes);
public long this[int i]=>Value[i];

public static A070374Inst Instance=new A070374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070373
{
public static readonly long[] Value={ 1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,6L,11L,17L,9L,7L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070373Inst : IEnumerable<long>
{
public static readonly long[] Value=A070373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070373.Bytes);
public long this[int i]=>Value[i];

public static A070373Inst Instance=new A070373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070372
{
public static readonly long[] Value={ 1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L,11L,1L,5L,7L,17L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070372Inst : IEnumerable<long>
{
public static readonly long[] Value=A070372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070372.Bytes);
public long this[int i]=>Value[i];

public static A070372Inst Instance=new A070372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070355
{
public static readonly long[] Value={ 1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070355Inst : IEnumerable<long>
{
public static readonly long[] Value=A070355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070355.Bytes);
public long this[int i]=>Value[i];

public static A070355Inst Instance=new A070355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070354
{
public static readonly long[] Value={ 1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070354Inst : IEnumerable<long>
{
public static readonly long[] Value=A070354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070354.Bytes);
public long this[int i]=>Value[i];

public static A070354Inst Instance=new A070354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070353
{
public static readonly long[] Value={ 1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070353Inst : IEnumerable<long>
{
public static readonly long[] Value=A070353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070353.Bytes);
public long this[int i]=>Value[i];

public static A070353Inst Instance=new A070353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070352
{
public static readonly long[] Value={ 1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070352Inst : IEnumerable<long>
{
public static readonly long[] Value=A070352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070352.Bytes);
public long this[int i]=>Value[i];

public static A070352Inst Instance=new A070352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070351
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L,7L,14L,28L,9L,18L,36L,25L,3L,6L,12L,24L,1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L,7L,14L,28L,9L,18L,36L,25L,3L,6L,12L,24L,1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L,7L,14L,28L,9L,18L,36L,25L,3L,6L,12L,24L,1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070351Inst : IEnumerable<long>
{
public static readonly long[] Value=A070351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070351.Bytes);
public long this[int i]=>Value[i];

public static A070351Inst Instance=new A070351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070350
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070350Inst : IEnumerable<long>
{
public static readonly long[] Value=A070350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070350.Bytes);
public long this[int i]=>Value[i];

public static A070350Inst Instance=new A070350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070349
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070349Inst : IEnumerable<long>
{
public static readonly long[] Value=A070349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070349.Bytes);
public long this[int i]=>Value[i];

public static A070349Inst Instance=new A070349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070348
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L,36L,31L,21L,1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L,36L,31L,21L,1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L,36L,31L,21L,1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070348Inst : IEnumerable<long>
{
public static readonly long[] Value=A070348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070348.Bytes);
public long this[int i]=>Value[i];

public static A070348Inst Instance=new A070348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070347
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070347Inst : IEnumerable<long>
{
public static readonly long[] Value=A070347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070347.Bytes);
public long this[int i]=>Value[i];

public static A070347Inst Instance=new A070347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070346
{
public static readonly long[] Value={ 1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L,33L,25L,1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L,33L,25L,1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L,33L,25L,1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070346Inst : IEnumerable<long>
{
public static readonly long[] Value=A070346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070346.Bytes);
public long this[int i]=>Value[i];

public static A070346Inst Instance=new A070346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070345
{
public static readonly long[] Value={ 1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070345Inst : IEnumerable<long>
{
public static readonly long[] Value=A070345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070345.Bytes);
public long this[int i]=>Value[i];

public static A070345Inst Instance=new A070345Inst();

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