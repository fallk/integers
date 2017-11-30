using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A070388
{
public static readonly long[] Value={ 1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L,1L,5L,25L,41L,37L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070388Inst : IEnumerable<long>
{
public static readonly long[] Value=A070388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070388.Bytes);
public long this[int i]=>Value[i];

public static A070388Inst Instance=new A070388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070389
{
public static readonly long[] Value={ 1L,5L,25L,39L,23L,29L,16L,37L,13L,22L,24L,34L,41L,33L,36L,8L,40L,28L,11L,12L,17L,42L,38L,18L,4L,20L,14L,27L,6L,30L,21L,19L,9L,2L,10L,7L,35L,3L,15L,32L,31L,26L,1L,5L,25L,39L,23L,29L,16L,37L,13L,22L,24L,34L,41L,33L,36L,8L,40L,28L,11L,12L,17L,42L,38L,18L,4L,20L,14L,27L,6L,30L,21L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070389Inst : IEnumerable<long>
{
public static readonly long[] Value=A070389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070389.Bytes);
public long this[int i]=>Value[i];

public static A070389Inst Instance=new A070389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070390
{
public static readonly long[] Value={ 1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L,25L,37L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070390Inst : IEnumerable<long>
{
public static readonly long[] Value=A070390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070390.Bytes);
public long this[int i]=>Value[i];

public static A070390Inst Instance=new A070390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070391
{
public static readonly long[] Value={ 1L,5L,25L,33L,27L,43L,31L,17L,39L,11L,9L,45L,41L,21L,13L,19L,3L,15L,29L,7L,35L,37L,1L,5L,25L,33L,27L,43L,31L,17L,39L,11L,9L,45L,41L,21L,13L,19L,3L,15L,29L,7L,35L,37L,1L,5L,25L,33L,27L,43L,31L,17L,39L,11L,9L,45L,41L,21L,13L,19L,3L,15L,29L,7L,35L,37L,1L,5L,25L,33L,27L,43L,31L,17L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070391Inst : IEnumerable<long>
{
public static readonly long[] Value=A070391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070391.Bytes);
public long this[int i]=>Value[i];

public static A070391Inst Instance=new A070391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070392
{
public static readonly long[] Value={ 1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070392Inst : IEnumerable<long>
{
public static readonly long[] Value=A070392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070392.Bytes);
public long this[int i]=>Value[i];

public static A070392Inst Instance=new A070392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070393
{
public static readonly long[] Value={ 1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L,5L,4L,11L,1L,6L,10L,8L,9L,2L,12L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070393Inst : IEnumerable<long>
{
public static readonly long[] Value=A070393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070393.Bytes);
public long this[int i]=>Value[i];

public static A070393Inst Instance=new A070393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070394
{
public static readonly long[] Value={ 1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L,8L,14L,16L,11L,15L,5L,13L,10L,9L,3L,1L,6L,2L,12L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070394Inst : IEnumerable<long>
{
public static readonly long[] Value=A070394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070394.Bytes);
public long this[int i]=>Value[i];

public static A070394Inst Instance=new A070394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070395
{
public static readonly long[] Value={ 1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L,16L,1L,6L,17L,7L,4L,5L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070395Inst : IEnumerable<long>
{
public static readonly long[] Value=A070395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070395.Bytes);
public long this[int i]=>Value[i];

public static A070395Inst Instance=new A070395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070396
{
public static readonly long[] Value={ 1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L,1L,6L,13L,9L,8L,2L,12L,3L,18L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070396Inst : IEnumerable<long>
{
public static readonly long[] Value=A070396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070396.Bytes);
public long this[int i]=>Value[i];

public static A070396Inst Instance=new A070396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070397
{
public static readonly long[] Value={ 1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L,21L,1L,6L,11L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070397Inst : IEnumerable<long>
{
public static readonly long[] Value=A070397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070397.Bytes);
public long this[int i]=>Value[i];

public static A070397Inst Instance=new A070397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070398
{
public static readonly long[] Value={ 1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L,9L,25L,5L,1L,6L,7L,13L,20L,4L,24L,28L,23L,22L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070398Inst : IEnumerable<long>
{
public static readonly long[] Value=A070398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070398.Bytes);
public long this[int i]=>Value[i];

public static A070398Inst Instance=new A070398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070399
{
public static readonly long[] Value={ 1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L,26L,1L,6L,5L,30L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070399Inst : IEnumerable<long>
{
public static readonly long[] Value=A070399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070399.Bytes);
public long this[int i]=>Value[i];

public static A070399Inst Instance=new A070399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070400
{
public static readonly long[] Value={ 1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L,1L,6L,36L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070400Inst : IEnumerable<long>
{
public static readonly long[] Value=A070400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070400.Bytes);
public long this[int i]=>Value[i];

public static A070400Inst Instance=new A070400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070401
{
public static readonly long[] Value={ 1L,6L,36L,28L,27L,21L,32L,4L,24L,3L,18L,14L,37L,34L,16L,2L,12L,25L,9L,7L,42L,17L,8L,1L,6L,36L,28L,27L,21L,32L,4L,24L,3L,18L,14L,37L,34L,16L,2L,12L,25L,9L,7L,42L,17L,8L,1L,6L,36L,28L,27L,21L,32L,4L,24L,3L,18L,14L,37L,34L,16L,2L,12L,25L,9L,7L,42L,17L,8L,1L,6L,36L,28L,27L,21L,32L,4L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070401Inst : IEnumerable<long>
{
public static readonly long[] Value=A070401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070401.Bytes);
public long this[int i]=>Value[i];

public static A070401Inst Instance=new A070401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070402
{
public static readonly long[] Value={ 1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070402Inst : IEnumerable<long>
{
public static readonly long[] Value=A070402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070402.Bytes);
public long this[int i]=>Value[i];

public static A070402Inst Instance=new A070402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070403
{
public static readonly long[] Value={ 1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070403Inst : IEnumerable<long>
{
public static readonly long[] Value=A070403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070403.Bytes);
public long this[int i]=>Value[i];

public static A070403Inst Instance=new A070403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070436
{
public static readonly long[] Value={ 0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070436Inst : IEnumerable<long>
{
public static readonly long[] Value=A070436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070436.Bytes);
public long this[int i]=>Value[i];

public static A070436Inst Instance=new A070436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070437
{
public static readonly long[] Value={ 0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070437Inst : IEnumerable<long>
{
public static readonly long[] Value=A070437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070437.Bytes);
public long this[int i]=>Value[i];

public static A070437Inst Instance=new A070437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070438
{
public static readonly long[] Value={ 0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070438Inst : IEnumerable<long>
{
public static readonly long[] Value=A070438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070438.Bytes);
public long this[int i]=>Value[i];

public static A070438Inst Instance=new A070438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070439
{
public static readonly long[] Value={ 0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070439Inst : IEnumerable<long>
{
public static readonly long[] Value=A070439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070439.Bytes);
public long this[int i]=>Value[i];

public static A070439Inst Instance=new A070439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070440
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070440Inst : IEnumerable<long>
{
public static readonly long[] Value=A070440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070440.Bytes);
public long this[int i]=>Value[i];

public static A070440Inst Instance=new A070440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070441
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070441Inst : IEnumerable<long>
{
public static readonly long[] Value=A070441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070441.Bytes);
public long this[int i]=>Value[i];

public static A070441Inst Instance=new A070441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070442
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070442Inst : IEnumerable<long>
{
public static readonly long[] Value=A070442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070442.Bytes);
public long this[int i]=>Value[i];

public static A070442Inst Instance=new A070442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070443
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070443Inst : IEnumerable<long>
{
public static readonly long[] Value=A070443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070443.Bytes);
public long this[int i]=>Value[i];

public static A070443Inst Instance=new A070443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070444
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L,14L,3L,16L,9L,4L,1L,0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L,14L,3L,16L,9L,4L,1L,0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L,14L,3L,16L,9L,4L,1L,0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070444Inst : IEnumerable<long>
{
public static readonly long[] Value=A070444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070444.Bytes);
public long this[int i]=>Value[i];

public static A070444Inst Instance=new A070444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070445
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L,9L,4L,1L,0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L,9L,4L,1L,0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L,9L,4L,1L,0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070445Inst : IEnumerable<long>
{
public static readonly long[] Value=A070445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070445.Bytes);
public long this[int i]=>Value[i];

public static A070445Inst Instance=new A070445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070446
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070446Inst : IEnumerable<long>
{
public static readonly long[] Value=A070446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070446.Bytes);
public long this[int i]=>Value[i];

public static A070446Inst Instance=new A070446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070447
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,0L,11L,24L,14L,6L,0L,21L,19L,19L,21L,0L,6L,14L,24L,11L,0L,16L,9L,4L,1L,0L,1L,4L,9L,16L,0L,11L,24L,14L,6L,0L,21L,19L,19L,21L,0L,6L,14L,24L,11L,0L,16L,9L,4L,1L,0L,1L,4L,9L,16L,0L,11L,24L,14L,6L,0L,21L,19L,19L,21L,0L,6L,14L,24L,11L,0L,16L,9L,4L,1L,0L,1L,4L,9L,16L,0L,11L,24L,14L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070447Inst : IEnumerable<long>
{
public static readonly long[] Value=A070447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070447.Bytes);
public long this[int i]=>Value[i];

public static A070447Inst Instance=new A070447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070448
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,10L,23L,12L,3L,22L,17L,14L,13L,14L,17L,22L,3L,12L,23L,10L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,10L,23L,12L,3L,22L,17L,14L,13L,14L,17L,22L,3L,12L,23L,10L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,10L,23L,12L,3L,22L,17L,14L,13L,14L,17L,22L,3L,12L,23L,10L,25L,16L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070448Inst : IEnumerable<long>
{
public static readonly long[] Value=A070448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070448.Bytes);
public long this[int i]=>Value[i];

public static A070448Inst Instance=new A070448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070449
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,9L,22L,10L,0L,19L,13L,9L,7L,7L,9L,13L,19L,0L,10L,22L,9L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,9L,22L,10L,0L,19L,13L,9L,7L,7L,9L,13L,19L,0L,10L,22L,9L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,9L,22L,10L,0L,19L,13L,9L,7L,7L,9L,13L,19L,0L,10L,22L,9L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070449Inst : IEnumerable<long>
{
public static readonly long[] Value=A070449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070449.Bytes);
public long this[int i]=>Value[i];

public static A070449Inst Instance=new A070449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070450
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070450Inst : IEnumerable<long>
{
public static readonly long[] Value=A070450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070450.Bytes);
public long this[int i]=>Value[i];

public static A070450Inst Instance=new A070450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070451
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,7L,20L,6L,23L,13L,5L,28L,24L,22L,22L,24L,28L,5L,13L,23L,6L,20L,7L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,7L,20L,6L,23L,13L,5L,28L,24L,22L,22L,24L,28L,5L,13L,23L,6L,20L,7L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,7L,20L,6L,23L,13L,5L,28L,24L,22L,22L,24L,28L,5L,13L,23L,6L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070451Inst : IEnumerable<long>
{
public static readonly long[] Value=A070451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070451.Bytes);
public long this[int i]=>Value[i];

public static A070451Inst Instance=new A070451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070468
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,3L,18L,35L,8L,29L,6L,31L,12L,41L,26L,13L,2L,39L,32L,27L,24L,23L,24L,27L,32L,39L,2L,13L,26L,41L,12L,31L,6L,29L,8L,35L,18L,3L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,3L,18L,35L,8L,29L,6L,31L,12L,41L,26L,13L,2L,39L,32L,27L,24L,23L,24L,27L,32L,39L,2L,13L,26L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070468Inst : IEnumerable<long>
{
public static readonly long[] Value=A070468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070468.Bytes);
public long this[int i]=>Value[i];

public static A070468Inst Instance=new A070468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070469
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,2L,17L,34L,6L,27L,3L,28L,8L,37L,21L,7L,42L,32L,24L,18L,14L,12L,12L,14L,18L,24L,32L,42L,7L,21L,37L,8L,28L,3L,27L,6L,34L,17L,2L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,2L,17L,34L,6L,27L,3L,28L,8L,37L,21L,7L,42L,32L,24L,18L,14L,12L,12L,14L,18L,24L,32L,42L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070469Inst : IEnumerable<long>
{
public static readonly long[] Value=A070469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070469.Bytes);
public long this[int i]=>Value[i];

public static A070469Inst Instance=new A070469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070470
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L,25L,0L,25L,4L,33L,16L,1L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L,25L,0L,25L,4L,33L,16L,1L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L,25L,0L,25L,4L,33L,16L,1L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070470Inst : IEnumerable<long>
{
public static readonly long[] Value=A070470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070470.Bytes);
public long this[int i]=>Value[i];

public static A070470Inst Instance=new A070470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070471
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070471Inst : IEnumerable<long>
{
public static readonly long[] Value=A070471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070471.Bytes);
public long this[int i]=>Value[i];

public static A070471Inst Instance=new A070471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070472
{
public static readonly long[] Value={ 0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070472Inst : IEnumerable<long>
{
public static readonly long[] Value=A070472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070472.Bytes);
public long this[int i]=>Value[i];

public static A070472Inst Instance=new A070472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070473
{
public static readonly long[] Value={ 0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070473Inst : IEnumerable<long>
{
public static readonly long[] Value=A070473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070473.Bytes);
public long this[int i]=>Value[i];

public static A070473Inst Instance=new A070473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070474
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
public class A070474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070474Inst : IEnumerable<long>
{
public static readonly long[] Value=A070474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070474.Bytes);
public long this[int i]=>Value[i];

public static A070474Inst Instance=new A070474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070475
{
public static readonly long[] Value={ 0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070475Inst : IEnumerable<long>
{
public static readonly long[] Value=A070475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070475.Bytes);
public long this[int i]=>Value[i];

public static A070475Inst Instance=new A070475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070476
{
public static readonly long[] Value={ 0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070476Inst : IEnumerable<long>
{
public static readonly long[] Value=A070476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070476.Bytes);
public long this[int i]=>Value[i];

public static A070476Inst Instance=new A070476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070477
{
public static readonly long[] Value={ 0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070477Inst : IEnumerable<long>
{
public static readonly long[] Value=A070477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070477.Bytes);
public long this[int i]=>Value[i];

public static A070477Inst Instance=new A070477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070478
{
public static readonly long[] Value={ 0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070478Inst : IEnumerable<long>
{
public static readonly long[] Value=A070478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070478.Bytes);
public long this[int i]=>Value[i];

public static A070478Inst Instance=new A070478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070479
{
public static readonly long[] Value={ 0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070479Inst : IEnumerable<long>
{
public static readonly long[] Value=A070479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070479.Bytes);
public long this[int i]=>Value[i];

public static A070479Inst Instance=new A070479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070480
{
public static readonly long[] Value={ 0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070480Inst : IEnumerable<long>
{
public static readonly long[] Value=A070480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070480.Bytes);
public long this[int i]=>Value[i];

public static A070480Inst Instance=new A070480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070481
{
public static readonly long[] Value={ 0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070481Inst : IEnumerable<long>
{
public static readonly long[] Value=A070481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070481.Bytes);
public long this[int i]=>Value[i];

public static A070481Inst Instance=new A070481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070482
{
public static readonly long[] Value={ 0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070482Inst : IEnumerable<long>
{
public static readonly long[] Value=A070482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070482.Bytes);
public long this[int i]=>Value[i];

public static A070482Inst Instance=new A070482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070483
{
public static readonly long[] Value={ 0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L,0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L,0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L,0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070483Inst : IEnumerable<long>
{
public static readonly long[] Value=A070483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070483.Bytes);
public long this[int i]=>Value[i];

public static A070483Inst Instance=new A070483Inst();

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

public static class A070580
{
public static readonly long[] Value={ 0L,1L,16L,7L,34L,33L,1L,33L,26L,12L,10L,26L,16L,34L,10L,9L,9L,12L,7L,7L,12L,9L,9L,10L,34L,16L,26L,10L,12L,26L,33L,1L,33L,34L,7L,16L,1L,0L,1L,16L,7L,34L,33L,1L,33L,26L,12L,10L,26L,16L,34L,10L,9L,9L,12L,7L,7L,12L,9L,9L,10L,34L,16L,26L,10L,12L,26L,33L,1L,33L,34L,7L,16L,1L,0L,1L,16L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070580Inst : IEnumerable<long>
{
public static readonly long[] Value=A070580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070580.Bytes);
public long this[int i]=>Value[i];

public static A070580Inst Instance=new A070580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070581
{
public static readonly long[] Value={ 0L,1L,16L,5L,28L,17L,4L,7L,30L,25L,6L,11L,26L,23L,36L,9L,24L,35L,20L,19L,20L,35L,24L,9L,36L,23L,26L,11L,6L,25L,30L,7L,4L,17L,28L,5L,16L,1L,0L,1L,16L,5L,28L,17L,4L,7L,30L,25L,6L,11L,26L,23L,36L,9L,24L,35L,20L,19L,20L,35L,24L,9L,36L,23L,26L,11L,6L,25L,30L,7L,4L,17L,28L,5L,16L,1L,0L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070581Inst : IEnumerable<long>
{
public static readonly long[] Value=A070581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070581.Bytes);
public long this[int i]=>Value[i];

public static A070581Inst Instance=new A070581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070582
{
public static readonly long[] Value={ 0L,1L,16L,3L,22L,1L,9L,22L,1L,9L,16L,16L,27L,13L,1L,3L,16L,22L,27L,22L,22L,27L,22L,16L,3L,1L,13L,27L,16L,16L,9L,1L,22L,9L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L,9L,22L,1L,9L,16L,16L,27L,13L,1L,3L,16L,22L,27L,22L,22L,27L,22L,16L,3L,1L,13L,27L,16L,16L,9L,1L,22L,9L,1L,22L,3L,16L,1L,0L,1L,16L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070582Inst : IEnumerable<long>
{
public static readonly long[] Value=A070582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070582.Bytes);
public long this[int i]=>Value[i];

public static A070582Inst Instance=new A070582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070583
{
public static readonly long[] Value={ 0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L,16L,25L,16L,1L,16L,1L,0L,1L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070583Inst : IEnumerable<long>
{
public static readonly long[] Value=A070583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070583.Bytes);
public long this[int i]=>Value[i];

public static A070583Inst Instance=new A070583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070584
{
public static readonly long[] Value={ 0L,1L,16L,40L,10L,10L,25L,23L,37L,1L,37L,4L,31L,25L,40L,31L,18L,4L,16L,23L,18L,18L,23L,16L,4L,18L,31L,40L,25L,31L,4L,37L,1L,37L,23L,25L,10L,10L,40L,16L,1L,0L,1L,16L,40L,10L,10L,25L,23L,37L,1L,37L,4L,31L,25L,40L,31L,18L,4L,16L,23L,18L,18L,23L,16L,4L,18L,31L,40L,25L,31L,4L,37L,1L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070584Inst : IEnumerable<long>
{
public static readonly long[] Value=A070584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070584.Bytes);
public long this[int i]=>Value[i];

public static A070584Inst Instance=new A070584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070585
{
public static readonly long[] Value={ 0L,1L,16L,39L,4L,37L,36L,7L,22L,9L,4L,25L,30L,1L,28L,15L,16L,25L,18L,37L,22L,21L,22L,37L,18L,25L,16L,15L,28L,1L,30L,25L,4L,9L,22L,7L,36L,37L,4L,39L,16L,1L,0L,1L,16L,39L,4L,37L,36L,7L,22L,9L,4L,25L,30L,1L,28L,15L,16L,25L,18L,37L,22L,21L,22L,37L,18L,25L,16L,15L,28L,1L,30L,25L,4L,9L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070585Inst : IEnumerable<long>
{
public static readonly long[] Value=A070585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070585.Bytes);
public long this[int i]=>Value[i];

public static A070585Inst Instance=new A070585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070586
{
public static readonly long[] Value={ 0L,1L,16L,38L,41L,23L,6L,36L,11L,25L,24L,21L,10L,9L,17L,14L,4L,15L,13L,31L,40L,35L,35L,40L,31L,13L,15L,4L,14L,17L,9L,10L,21L,24L,25L,11L,36L,6L,23L,41L,38L,16L,1L,0L,1L,16L,38L,41L,23L,6L,36L,11L,25L,24L,21L,10L,9L,17L,14L,4L,15L,13L,31L,40L,35L,35L,40L,31L,13L,15L,4L,14L,17L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070586Inst : IEnumerable<long>
{
public static readonly long[] Value=A070586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070586.Bytes);
public long this[int i]=>Value[i];

public static A070586Inst Instance=new A070586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070587
{
public static readonly long[] Value={ 0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L,25L,20L,9L,36L,37L,16L,1L,0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L,25L,20L,9L,36L,37L,16L,1L,0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L,25L,20L,9L,36L,37L,16L,1L,0L,1L,16L,37L,36L,9L,20L,25L,4L,5L,12L,33L,12L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070587Inst : IEnumerable<long>
{
public static readonly long[] Value=A070587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070587.Bytes);
public long this[int i]=>Value[i];

public static A070587Inst Instance=new A070587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070588
{
public static readonly long[] Value={ 0L,1L,16L,36L,31L,40L,36L,16L,1L,36L,10L,16L,36L,31L,31L,0L,16L,1L,36L,1L,25L,36L,31L,31L,36L,25L,1L,36L,1L,16L,0L,31L,31L,36L,16L,10L,36L,1L,16L,36L,40L,31L,36L,16L,1L,0L,1L,16L,36L,31L,40L,36L,16L,1L,36L,10L,16L,36L,31L,31L,0L,16L,1L,36L,1L,25L,36L,31L,31L,36L,25L,1L,36L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070588Inst : IEnumerable<long>
{
public static readonly long[] Value=A070588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070588.Bytes);
public long this[int i]=>Value[i];

public static A070588Inst Instance=new A070588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070589
{
public static readonly long[] Value={ 0L,1L,16L,35L,26L,27L,8L,9L,2L,29L,18L,13L,36L,41L,6L,25L,32L,31L,4L,3L,12L,39L,24L,23L,24L,39L,12L,3L,4L,31L,32L,25L,6L,41L,36L,13L,18L,29L,2L,9L,8L,27L,26L,35L,16L,1L,0L,1L,16L,35L,26L,27L,8L,9L,2L,29L,18L,13L,36L,41L,6L,25L,32L,31L,4L,3L,12L,39L,24L,23L,24L,39L,12L,3L,4L,31L,32L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070589Inst : IEnumerable<long>
{
public static readonly long[] Value=A070589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070589.Bytes);
public long this[int i]=>Value[i];

public static A070589Inst Instance=new A070589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070590
{
public static readonly long[] Value={ 0L,1L,16L,34L,21L,14L,27L,4L,7L,28L,36L,24L,9L,32L,17L,6L,18L,2L,25L,37L,12L,42L,8L,3L,3L,8L,42L,12L,37L,25L,2L,18L,6L,17L,32L,9L,24L,36L,28L,7L,4L,27L,14L,21L,34L,16L,1L,0L,1L,16L,34L,21L,14L,27L,4L,7L,28L,36L,24L,9L,32L,17L,6L,18L,2L,25L,37L,12L,42L,8L,3L,3L,8L,42L,12L,37L,25L,2L,18L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070590Inst : IEnumerable<long>
{
public static readonly long[] Value=A070590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070590.Bytes);
public long this[int i]=>Value[i];

public static A070590Inst Instance=new A070590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070591
{
public static readonly long[] Value={ 0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L,1L,0L,1L,16L,33L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070591Inst : IEnumerable<long>
{
public static readonly long[] Value=A070591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070591.Bytes);
public long this[int i]=>Value[i];

public static A070591Inst Instance=new A070591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070592
{
public static readonly BigInteger[] Value={ 3L,5L,17L,257L,65537L,6700417L,67280421310721L,BigInteger.Parse("5704689200685129054721"),BigInteger.Parse("93461639715357977769163558199606896584051237541638188580280321") };
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
public class A070592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070592Inst Instance=new A070592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070593
{
public static readonly long[] Value={ 0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L,5L,2L,3L,6L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070593Inst : IEnumerable<long>
{
public static readonly long[] Value=A070593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070593.Bytes);
public long this[int i]=>Value[i];

public static A070593Inst Instance=new A070593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070594
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,910L,912L,915L,918L,9920L,9922L,9925L,18927L,18928L,78329L,99930L,99936L,99937L,198939L,999944L,999945L,2998848L,2998849L,9999950L,18999954L,19989957L,29988958L,48798959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070594Inst : IEnumerable<long>
{
public static readonly long[] Value=A070594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070594.Bytes);
public long this[int i]=>Value[i];

public static A070594Inst Instance=new A070594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070595
{
public static readonly long[] Value={ 0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070595Inst : IEnumerable<long>
{
public static readonly long[] Value=A070595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070595.Bytes);
public long this[int i]=>Value[i];

public static A070595Inst Instance=new A070595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070756
{
public static readonly long[] Value={ 30L,85L,195L,240L,525L,700L,960L,1020L,1170L,1845L,2720L,3045L,3120L,4026L,4818L,5005L,5655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070756Inst : IEnumerable<long>
{
public static readonly long[] Value=A070756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070756.Bytes);
public long this[int i]=>Value[i];

public static A070756Inst Instance=new A070756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070757
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,9L,11L,14L,19L,23L,25L,32L,36L,40L,50L,55L,57L,70L,76L,81L,96L,100L,109L,126L,129L,138L,156L,163L,175L,199L,198L,211L,239L,241L,258L,283L,281L,308L,335L,335L,360L,382L,385L,421L,445L,437L,482L,508L,503L,556L,571L,561L,632L,657L,645L,705L,726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070757Inst : IEnumerable<long>
{
public static readonly long[] Value=A070757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070757.Bytes);
public long this[int i]=>Value[i];

public static A070757Inst Instance=new A070757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070758
{
public static readonly long[] Value={ 25L,38L,57L,86L,129L,194L,291L,437L,656L,985L,1477L,2216L,3325L,11222L,16834L,25251L,37876L,56815L,85222L,127834L,191751L,287626L,431439L,647159L,970739L,1456109L,2184164L,3276246L,4914369L,7371554L,11057332L,16585998L,24878997L,37318496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070758Inst : IEnumerable<long>
{
public static readonly long[] Value=A070758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070758.Bytes);
public long this[int i]=>Value[i];

public static A070758Inst Instance=new A070758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070759
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,21L,22L,98L,106L,164L,189L,219L,364L,443L,670L,775L,1919L,2204L,2715L,3692L,4228L,4912L,10466L,12300L,14087L,21659L,28170L,55832L,66577L,87309L,87505L,98144L,167512L,259517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070759Inst : IEnumerable<long>
{
public static readonly long[] Value=A070759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070759.Bytes);
public long this[int i]=>Value[i];

public static A070759Inst Instance=new A070759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070760
{
public static readonly long[] Value={ 100L,144L,169L,200L,288L,300L,400L,441L,500L,528L,600L,700L,768L,800L,825L,867L,882L,900L,961L,1089L,1100L,1584L,2178L,2200L,3300L,4400L,4851L,5500L,6600L,7700L,8712L,8800L,9801L,9900L,10000L,10100L,10404L,10609L,10989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070760Inst : IEnumerable<long>
{
public static readonly long[] Value=A070760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070760.Bytes);
public long this[int i]=>Value[i];

public static A070760Inst Instance=new A070760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070761
{
public static readonly long[] Value={ 4L,9L,42L,56L,74L,99L,133L,177L,236L,315L,420L,560L,747L,996L,1328L,1771L,2362L,3149L,4199L,5599L,7466L,9954L,13273L,17697L,23596L,31462L,41950L,74577L,99437L,132583L,235703L,314271L,419028L,558704L,744938L,993251L,1324335L,1765780L,2354374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070761Inst : IEnumerable<long>
{
public static readonly long[] Value=A070761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070761.Bytes);
public long this[int i]=>Value[i];

public static A070761Inst Instance=new A070761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070762
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,10L,11L,12L,38L,42L,59L,96L,154L,171L,211L,313L,465L,563L,1040L,1176L,1213L,1431L,1519L,1987L,2527L,3033L,4039L,4209L,4358L,5109L,5251L,6642L,19200L,25275L,42589L,43025L,49294L,58585L,66290L,77458L,80409L,86533L,94192L,110452L,115166L,124470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070762Inst : IEnumerable<long>
{
public static readonly long[] Value=A070762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070762.Bytes);
public long this[int i]=>Value[i];

public static A070762Inst Instance=new A070762Inst();

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