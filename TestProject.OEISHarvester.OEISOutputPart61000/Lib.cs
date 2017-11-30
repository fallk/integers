using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A071297
{
public static readonly long[] Value={ 2L,5L,4L,10L,8L,56L,8L,39L,10L,38L,9L,208L,15L,37L,95L,143L,7L,502L,2L,319L,184L,235L,2L,1631L,68L,142L,58L,614L,71L,14216L,14L,5286L,81L,149L,251L,4018L,12L,17L,79L,5162L,21L,43065L,34L,3858L,932L,140L,6L,12852L,27L,2457L,360L,1121L,37L,10014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071297Inst : IEnumerable<long>
{
public static readonly long[] Value=A071297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071297.Bytes);
public long this[int i]=>Value[i];

public static A071297Inst Instance=new A071297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071298
{
public static readonly long[] Value={ 1L,1L,2L,4L,22L,77L,223L,2303L,27439L,74099L,1868341L,31327879L,63988651L,3837093769L,425208803L,148171090931L,1227124994453L,10822002242731L,911688749229889L,5415761728327927L,848138531958005663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071298Inst : IEnumerable<long>
{
public static readonly long[] Value=A071298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071298.Bytes);
public long this[int i]=>Value[i];

public static A071298Inst Instance=new A071298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071299
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,6L,10L,60L,420L,672L,10080L,100800L,123200L,4435200L,295680L,62092800L,310464000L,1655808000L,84446208000L,304006348800L,28880603136000L,192537354240000L,4043284439040000L,88952257658880000L,409180385230848000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071299Inst : IEnumerable<long>
{
public static readonly long[] Value=A071299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071299.Bytes);
public long this[int i]=>Value[i];

public static A071299Inst Instance=new A071299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071444
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,2L,1L,2L,3L,4L,0L,1L,0L,5L,1L,2L,1L,2L,5L,3L,0L,3L,4L,5L,1L,2L,1L,1L,2L,3L,0L,3L,3L,2L,3L,4L,5L,1L,2L,5L,4L,5L,3L,2L,3L,4L,2L,3L,2L,1L,1L,2L,3L,4L,5L,3L,2L,3L,4L,2L,6L,2L,1L,4L,5L,3L,4L,5L,4L,2L,3L,2L,2L,6L,2L,3L,0L,5L,3L,8L,5L,4L,2L,3L,2L,5L,4L,7L,3L,4L,5L,4L,2L,5L,2L,2L,3L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071444Inst : IEnumerable<long>
{
public static readonly long[] Value=A071444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071444.Bytes);
public long this[int i]=>Value[i];

public static A071444Inst Instance=new A071444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071445
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,2L,1L,2L,2L,3L,0L,1L,4L,2L,1L,4L,5L,1L,2L,2L,3L,2L,3L,4L,0L,1L,4L,5L,1L,2L,5L,1L,2L,3L,4L,2L,3L,4L,0L,1L,2L,1L,1L,2L,5L,4L,2L,3L,4L,5L,3L,4L,1L,1L,2L,5L,4L,2L,3L,2L,2L,3L,6L,5L,4L,2L,5L,4L,5L,3L,2L,2L,3L,2L,3L,8L,2L,7L,4L,5L,3L,2L,5L,4L,2L,3L,6L,2L,3L,1L,9L,3L,2L,5L,6L,2L,5L,4L,9L,8L,4L,7L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071445Inst : IEnumerable<long>
{
public static readonly long[] Value=A071445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071445.Bytes);
public long this[int i]=>Value[i];

public static A071445Inst Instance=new A071445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071446
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,2L,0L,1L,0L,1L,4L,4L,2L,2L,1L,6L,1L,6L,0L,4L,2L,1L,2L,7L,6L,6L,1L,5L,1L,2L,8L,4L,6L,1L,2L,1L,0L,8L,4L,5L,1L,9L,7L,9L,8L,4L,5L,1L,0L,8L,0L,6L,6L,5L,3L,4L,8L,9L,0L,1L,6L,5L,2L,3L,2L,8L,1L,6L,7L,2L,3L,2L,10L,5L,9L,7L,0L,8L,2L,2L,3L,4L,12L,4L,8L,11L,16L,3L,4L,3L,9L,8L,9L,16L,1L,4L,8L,4L,2L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071446Inst : IEnumerable<long>
{
public static readonly long[] Value=A071446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071446.Bytes);
public long this[int i]=>Value[i];

public static A071446Inst Instance=new A071446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071447
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,3L,1L,1L,4L,0L,4L,5L,1L,3L,2L,0L,2L,1L,1L,1L,4L,0L,2L,6L,1L,6L,4L,0L,4L,1L,1L,1L,2L,0L,2L,6L,1L,5L,4L,0L,4L,6L,1L,3L,2L,0L,2L,1L,1L,1L,8L,0L,2L,6L,1L,6L,4L,0L,4L,1L,1L,1L,2L,0L,2L,6L,1L,1L,4L,0L,4L,6L,1L,3L,2L,0L,2L,1L,1L,1L,4L,0L,2L,6L,1L,6L,4L,0L,4L,1L,1L,1L,2L,0L,2L,6L,1L,5L,4L,0L,4L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071447Inst : IEnumerable<long>
{
public static readonly long[] Value=A071447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071447.Bytes);
public long this[int i]=>Value[i];

public static A071447Inst Instance=new A071447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071448
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,0L,4L,1L,1L,2L,5L,3L,2L,4L,1L,1L,5L,5L,6L,0L,3L,1L,2L,5L,1L,4L,8L,1L,4L,2L,1L,9L,6L,7L,4L,2L,2L,1L,6L,8L,7L,9L,2L,1L,3L,2L,8L,7L,2L,8L,5L,4L,10L,3L,4L,0L,8L,9L,6L,5L,1L,4L,10L,13L,9L,6L,1L,11L,2L,0L,3L,6L,8L,5L,9L,4L,3L,3L,4L,10L,5L,2L,8L,7L,4L,4L,5L,1L,2L,8L,9L,4L,3L,5L,11L,10L,10L,11L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071448Inst : IEnumerable<long>
{
public static readonly long[] Value=A071448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071448.Bytes);
public long this[int i]=>Value[i];

public static A071448Inst Instance=new A071448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071449
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,0L,4L,1L,1L,2L,5L,3L,3L,4L,1L,1L,2L,5L,3L,0L,4L,4L,2L,1L,1L,3L,3L,4L,4L,2L,1L,1L,5L,6L,3L,2L,2L,8L,1L,5L,6L,0L,7L,2L,2L,5L,5L,8L,9L,7L,4L,2L,5L,5L,10L,9L,4L,2L,11L,5L,5L,10L,3L,4L,4L,7L,5L,5L,10L,9L,4L,4L,7L,8L,6L,5L,10L,2L,4L,7L,8L,0L,5L,10L,2L,2L,8L,0L,6L,3L,9L,4L,4L,8L,11L,0L,1L,9L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071449Inst : IEnumerable<long>
{
public static readonly long[] Value=A071449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071449.Bytes);
public long this[int i]=>Value[i];

public static A071449Inst Instance=new A071449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071450
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,3L,1L,4L,0L,1L,4L,3L,1L,2L,2L,1L,0L,5L,1L,4L,5L,6L,3L,2L,4L,8L,1L,4L,0L,2L,7L,6L,2L,4L,5L,8L,4L,1L,1L,3L,2L,2L,4L,1L,8L,5L,5L,4L,3L,2L,7L,5L,8L,1L,1L,8L,7L,2L,2L,6L,5L,4L,1L,5L,4L,9L,2L,2L,6L,8L,4L,5L,0L,4L,6L,7L,2L,2L,8L,1L,5L,4L,9L,8L,7L,2L,8L,7L,1L,8L,4L,1L,8L,2L,2L,3L,1L,8L,0L,1L,8L,14L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071450Inst : IEnumerable<long>
{
public static readonly long[] Value=A071450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071450.Bytes);
public long this[int i]=>Value[i];

public static A071450Inst Instance=new A071450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071451
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,1L,1L,1L,4L,4L,4L,3L,3L,3L,2L,2L,2L,1L,1L,1L,4L,4L,4L,2L,2L,2L,6L,6L,6L,4L,4L,4L,1L,1L,1L,2L,2L,2L,7L,7L,7L,1L,1L,1L,4L,4L,4L,3L,3L,3L,2L,2L,2L,1L,1L,1L,4L,4L,4L,6L,6L,6L,7L,7L,7L,4L,4L,4L,1L,1L,1L,2L,2L,2L,8L,8L,8L,5L,5L,5L,4L,4L,4L,7L,7L,7L,2L,2L,2L,1L,1L,1L,8L,8L,8L,6L,6L,6L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071451Inst : IEnumerable<long>
{
public static readonly long[] Value=A071451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071451.Bytes);
public long this[int i]=>Value[i];

public static A071451Inst Instance=new A071451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071452
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,1L,1L,1L,4L,4L,4L,3L,3L,2L,2L,2L,1L,1L,1L,4L,4L,2L,2L,2L,6L,6L,4L,4L,4L,1L,1L,1L,2L,2L,2L,7L,7L,1L,1L,1L,4L,4L,4L,3L,3L,2L,2L,2L,1L,1L,1L,4L,4L,8L,6L,2L,7L,7L,4L,4L,4L,1L,1L,1L,2L,2L,2L,8L,8L,8L,5L,1L,4L,4L,4L,7L,7L,2L,2L,2L,1L,1L,1L,8L,8L,8L,6L,2L,7L,7L,4L,4L,4L,1L,1L,1L,2L,2L,2L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071452Inst : IEnumerable<long>
{
public static readonly long[] Value=A071452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071452.Bytes);
public long this[int i]=>Value[i];

public static A071452Inst Instance=new A071452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071453
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,2L,1L,3L,4L,0L,1L,1L,1L,3L,2L,2L,2L,3L,4L,0L,1L,5L,4L,3L,2L,2L,2L,3L,1L,0L,1L,0L,4L,3L,2L,2L,2L,0L,1L,0L,1L,0L,4L,3L,2L,5L,4L,0L,1L,0L,1L,0L,2L,3L,2L,3L,4L,0L,1L,0L,1L,3L,2L,3L,2L,3L,4L,0L,1L,0L,4L,3L,2L,3L,2L,3L,1L,0L,1L,0L,4L,3L,2L,3L,2L,0L,1L,0L,1L,0L,4L,3L,2L,3L,4L,0L,1L,0L,1L,0L,2L,3L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071453Inst : IEnumerable<long>
{
public static readonly long[] Value=A071453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071453.Bytes);
public long this[int i]=>Value[i];

public static A071453Inst Instance=new A071453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071454
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,2L,3L,4L,4L,1L,1L,1L,6L,3L,2L,2L,2L,4L,1L,1L,6L,6L,6L,7L,3L,4L,4L,5L,1L,1L,1L,6L,7L,3L,5L,4L,4L,1L,8L,7L,6L,3L,3L,10L,4L,4L,4L,8L,8L,6L,6L,7L,10L,4L,4L,4L,5L,8L,7L,6L,7L,10L,10L,5L,4L,3L,3L,3L,6L,6L,1L,1L,10L,4L,4L,3L,3L,6L,6L,1L,1L,1L,4L,4L,3L,3L,8L,6L,6L,1L,1L,10L,10L,3L,3L,3L,8L,8L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071454Inst : IEnumerable<long>
{
public static readonly long[] Value=A071454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071454.Bytes);
public long this[int i]=>Value[i];

public static A071454Inst Instance=new A071454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071455
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,1L,1L,1L,4L,4L,4L,3L,2L,2L,2L,1L,1L,1L,4L,2L,2L,2L,6L,4L,4L,4L,1L,1L,1L,2L,2L,2L,7L,1L,1L,1L,4L,4L,4L,3L,2L,2L,2L,1L,1L,1L,4L,8L,2L,2L,7L,4L,4L,4L,1L,1L,1L,2L,2L,2L,7L,8L,1L,1L,4L,4L,4L,7L,2L,2L,2L,1L,1L,1L,4L,4L,2L,2L,7L,7L,4L,4L,1L,1L,1L,2L,2L,2L,7L,7L,1L,1L,1L,4L,4L,7L,2L,2L,2L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071455Inst : IEnumerable<long>
{
public static readonly long[] Value=A071455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071455.Bytes);
public long this[int i]=>Value[i];

public static A071455Inst Instance=new A071455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071456
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,1L,1L,5L,5L,3L,3L,2L,2L,1L,1L,5L,4L,4L,2L,2L,6L,6L,8L,4L,1L,1L,2L,2L,3L,3L,7L,4L,4L,5L,5L,8L,7L,2L,2L,9L,5L,1L,4L,4L,7L,7L,6L,2L,8L,4L,1L,9L,9L,6L,2L,2L,7L,7L,4L,4L,1L,13L,8L,2L,3L,3L,14L,1L,5L,4L,4L,16L,3L,3L,2L,2L,1L,1L,8L,8L,13L,2L,2L,15L,14L,4L,5L,1L,1L,2L,2L,3L,7L,14L,16L,4L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071456Inst : IEnumerable<long>
{
public static readonly long[] Value=A071456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071456.Bytes);
public long this[int i]=>Value[i];

public static A071456Inst Instance=new A071456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071457
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,2L,2L,1L,2L,2L,4L,1L,0L,4L,0L,1L,5L,6L,6L,1L,2L,2L,8L,1L,0L,4L,0L,1L,5L,6L,6L,2L,5L,4L,8L,1L,0L,1L,0L,1L,5L,2L,2L,2L,5L,4L,4L,4L,5L,1L,0L,1L,6L,1L,2L,8L,3L,2L,0L,4L,5L,1L,6L,6L,6L,1L,6L,4L,3L,4L,8L,4L,0L,1L,6L,10L,6L,1L,8L,10L,3L,4L,5L,4L,5L,1L,6L,1L,6L,1L,6L,8L,0L,3L,5L,4L,5L,10L,5L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071457Inst : IEnumerable<long>
{
public static readonly long[] Value=A071457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071457.Bytes);
public long this[int i]=>Value[i];

public static A071457Inst Instance=new A071457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071458
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,2L,2L,2L,1L,4L,4L,0L,1L,0L,6L,2L,1L,2L,4L,2L,1L,0L,4L,5L,1L,6L,6L,5L,1L,2L,4L,5L,1L,0L,6L,5L,3L,0L,4L,5L,3L,0L,1L,5L,3L,0L,6L,5L,3L,0L,8L,5L,4L,0L,6L,7L,6L,0L,3L,5L,4L,0L,1L,5L,6L,2L,1L,3L,4L,0L,1L,0L,4L,2L,1L,7L,4L,7L,3L,0L,4L,5L,1L,8L,6L,2L,3L,0L,4L,5L,4L,0L,1L,2L,3L,10L,3L,7L,3L,0L,9L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071458Inst : IEnumerable<long>
{
public static readonly long[] Value=A071458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071458.Bytes);
public long this[int i]=>Value[i];

public static A071458Inst Instance=new A071458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071459
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,2L,0L,2L,1L,2L,0L,4L,1L,1L,0L,4L,1L,1L,5L,2L,4L,1L,5L,2L,4L,1L,1L,2L,0L,1L,1L,2L,0L,4L,3L,2L,2L,4L,4L,1L,5L,4L,4L,7L,5L,2L,3L,3L,2L,2L,4L,4L,1L,2L,4L,1L,8L,2L,2L,4L,3L,2L,2L,4L,4L,5L,5L,4L,4L,7L,5L,2L,4L,3L,2L,2L,4L,3L,5L,2L,1L,4L,8L,2L,2L,4L,7L,2L,9L,4L,4L,5L,5L,1L,8L,7L,7L,2L,4L,7L,2L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071459Inst : IEnumerable<long>
{
public static readonly long[] Value=A071459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071459.Bytes);
public long this[int i]=>Value[i];

public static A071459Inst Instance=new A071459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071476
{
public static readonly long[] Value={ 1L,0L,2L,1L,3L,2L,1L,3L,4L,4L,3L,6L,2L,3L,1L,2L,8L,1L,2L,6L,5L,4L,4L,5L,1L,8L,2L,1L,8L,2L,1L,3L,6L,12L,5L,6L,4L,8L,1L,2L,8L,1L,2L,8L,5L,4L,4L,5L,7L,6L,8L,1L,11L,2L,1L,11L,6L,12L,5L,6L,4L,5L,15L,2L,3L,1L,2L,8L,5L,4L,6L,5L,7L,6L,8L,1L,11L,2L,1L,11L,6L,12L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071476Inst : IEnumerable<long>
{
public static readonly long[] Value=A071476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071476.Bytes);
public long this[int i]=>Value[i];

public static A071476Inst Instance=new A071476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071477
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,3L,4L,1L,1L,6L,6L,2L,2L,4L,4L,1L,1L,3L,3L,8L,5L,4L,4L,6L,6L,3L,3L,1L,1L,8L,8L,2L,6L,4L,4L,1L,9L,3L,3L,10L,10L,4L,4L,6L,6L,3L,9L,1L,1L,10L,10L,2L,3L,4L,4L,1L,9L,7L,7L,3L,3L,4L,1L,1L,6L,6L,7L,5L,4L,4L,8L,8L,3L,6L,16L,5L,4L,13L,13L,7L,6L,6L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071477Inst : IEnumerable<long>
{
public static readonly long[] Value=A071477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071477.Bytes);
public long this[int i]=>Value[i];

public static A071477Inst Instance=new A071477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071478
{
public static readonly long[] Value={ 1L,0L,2L,2L,3L,4L,1L,1L,6L,2L,2L,4L,4L,1L,1L,3L,3L,5L,4L,4L,6L,6L,3L,3L,1L,5L,8L,6L,6L,10L,4L,4L,3L,3L,6L,10L,10L,4L,4L,3L,6L,6L,1L,1L,8L,2L,2L,6L,6L,1L,4L,3L,2L,8L,8L,1L,12L,12L,3L,3L,8L,1L,1L,10L,10L,3L,4L,4L,1L,1L,6L,3L,2L,4L,4L,1L,6L,6L,3L,5L,4L,8L,8L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071478Inst : IEnumerable<long>
{
public static readonly long[] Value=A071478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071478.Bytes);
public long this[int i]=>Value[i];

public static A071478Inst Instance=new A071478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071479
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,3L,0L,1L,1L,3L,2L,2L,4L,4L,0L,6L,3L,2L,2L,4L,0L,1L,6L,3L,2L,2L,0L,1L,1L,6L,3L,3L,4L,4L,1L,1L,0L,3L,5L,4L,4L,1L,1L,3L,8L,5L,4L,4L,1L,6L,3L,3L,2L,4L,4L,1L,6L,3L,3L,2L,0L,9L,1L,6L,3L,3L,4L,4L,1L,1L,6L,3L,5L,4L,4L,1L,1L,6L,3L,5L,4L,4L,1L,1L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071479Inst : IEnumerable<long>
{
public static readonly long[] Value=A071479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071479.Bytes);
public long this[int i]=>Value[i];

public static A071479Inst Instance=new A071479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071480
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,0L,4L,3L,2L,0L,1L,1L,2L,2L,3L,5L,1L,4L,3L,2L,2L,1L,1L,0L,2L,3L,7L,4L,1L,3L,2L,2L,1L,0L,4L,6L,2L,7L,4L,0L,1L,2L,2L,3L,1L,0L,4L,6L,2L,0L,1L,1L,2L,2L,7L,5L,1L,4L,7L,2L,2L,1L,1L,0L,2L,3L,7L,4L,1L,3L,2L,2L,1L,0L,4L,6L,2L,7L,4L,0L,1L,2L,2L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071480Inst : IEnumerable<long>
{
public static readonly long[] Value=A071480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071480.Bytes);
public long this[int i]=>Value[i];

public static A071480Inst Instance=new A071480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071481
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,3L,2L,2L,1L,4L,4L,5L,6L,4L,2L,2L,3L,1L,1L,5L,4L,1L,2L,8L,8L,6L,5L,7L,4L,1L,11L,2L,2L,6L,8L,8L,10L,1L,11L,10L,6L,6L,7L,12L,1L,1L,14L,5L,1L,3L,9L,2L,8L,4L,16L,5L,4L,6L,6L,2L,3L,6L,1L,8L,10L,1L,11L,7L,16L,6L,11L,7L,13L,14L,12L,15L,8L,6L,9L,2L,6L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071481Inst : IEnumerable<long>
{
public static readonly long[] Value=A071481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071481.Bytes);
public long this[int i]=>Value[i];

public static A071481Inst Instance=new A071481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071482
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,1L,2L,3L,1L,2L,1L,2L,3L,1L,4L,3L,0L,3L,1L,4L,3L,2L,3L,2L,4L,3L,2L,3L,2L,4L,5L,2L,0L,2L,1L,5L,2L,3L,2L,3L,5L,2L,5L,2L,3L,5L,1L,5L,0L,3L,5L,4L,5L,6L,1L,2L,4L,3L,6L,1L,6L,8L,0L,6L,1L,6L,8L,9L,6L,7L,0L,2L,9L,3L,7L,6L,7L,9L,5L,7L,0L,7L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071482Inst : IEnumerable<long>
{
public static readonly long[] Value=A071482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071482.Bytes);
public long this[int i]=>Value[i];

public static A071482Inst Instance=new A071482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071483
{
public static readonly long[] Value={ 1L,2L,0L,1L,0L,1L,2L,3L,1L,2L,3L,1L,3L,4L,0L,3L,4L,5L,3L,2L,3L,2L,5L,3L,2L,1L,0L,2L,0L,2L,5L,4L,7L,3L,4L,2L,0L,4L,6L,4L,5L,6L,0L,8L,3L,1L,6L,3L,8L,6L,7L,2L,9L,7L,0L,3L,8L,5L,3L,4L,5L,2L,5L,9L,6L,5L,0L,6L,0L,2L,5L,4L,3L,10L,0L,9L,10L,1L,5L,4L,5L,2L,4L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071483Inst : IEnumerable<long>
{
public static readonly long[] Value=A071483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071483.Bytes);
public long this[int i]=>Value[i];

public static A071483Inst Instance=new A071483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071484
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,0L,1L,0L,1L,2L,3L,2L,3L,4L,5L,1L,2L,3L,2L,3L,4L,5L,4L,0L,1L,0L,3L,4L,2L,4L,2L,1L,7L,5L,4L,5L,3L,2L,1L,4L,6L,8L,7L,8L,2L,1L,2L,9L,6L,7L,6L,2L,3L,2L,3L,6L,7L,1L,2L,3L,2L,4L,8L,9L,3L,1L,3L,5L,7L,4L,9L,3L,2L,10L,11L,9L,8L,1L,3L,2L,10L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071484Inst : IEnumerable<long>
{
public static readonly long[] Value=A071484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071484.Bytes);
public long this[int i]=>Value[i];

public static A071484Inst Instance=new A071484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071485
{
public static readonly long[] Value={ 1L,2L,1L,2L,0L,3L,0L,1L,2L,4L,5L,3L,1L,2L,1L,2L,4L,3L,0L,3L,0L,2L,1L,4L,3L,5L,8L,2L,1L,3L,6L,3L,0L,4L,1L,2L,1L,2L,0L,5L,4L,1L,2L,3L,5L,4L,7L,2L,7L,2L,3L,5L,0L,7L,1L,3L,8L,3L,5L,2L,7L,8L,1L,3L,0L,3L,2L,4L,7L,6L,0L,2L,10L,2L,1L,7L,0L,3L,12L,4L,1L,2L,7L,6L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071485Inst : IEnumerable<long>
{
public static readonly long[] Value=A071485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071485.Bytes);
public long this[int i]=>Value[i];

public static A071485Inst Instance=new A071485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071486
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,3L,1L,2L,3L,1L,4L,3L,0L,4L,3L,1L,4L,2L,1L,3L,2L,1L,0L,2L,1L,4L,2L,6L,4L,1L,6L,4L,2L,6L,1L,2L,0L,1L,2L,3L,1L,2L,3L,1L,4L,3L,2L,4L,3L,1L,4L,6L,1L,3L,8L,1L,0L,8L,1L,4L,8L,9L,4L,1L,9L,4L,5L,9L,1L,5L,0L,1L,5L,3L,1L,2L,3L,1L,10L,3L,2L,10L,3L,1L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071486Inst : IEnumerable<long>
{
public static readonly long[] Value=A071486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071486.Bytes);
public long this[int i]=>Value[i];

public static A071486Inst Instance=new A071486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071487
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,3L,4L,5L,1L,5L,6L,7L,3L,2L,3L,2L,1L,5L,8L,9L,7L,6L,7L,6L,5L,4L,5L,4L,8L,2L,3L,2L,10L,11L,4L,5L,4L,5L,2L,6L,7L,10L,11L,10L,1L,8L,2L,3L,2L,3L,10L,5L,4L,5L,8L,9L,8L,9L,3L,2L,1L,11L,16L,12L,7L,6L,7L,5L,4L,5L,4L,16L,1L,8L,6L,18L,15L,14L,4L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071487Inst : IEnumerable<long>
{
public static readonly long[] Value=A071487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071487.Bytes);
public long this[int i]=>Value[i];

public static A071487Inst Instance=new A071487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071488
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,5L,1L,5L,6L,7L,3L,2L,1L,2L,8L,9L,7L,6L,5L,6L,4L,12L,9L,2L,1L,2L,10L,7L,4L,5L,2L,12L,7L,3L,13L,2L,1L,8L,3L,7L,9L,6L,12L,15L,12L,3L,9L,1L,2L,8L,16L,7L,10L,17L,2L,12L,3L,13L,9L,2L,11L,16L,3L,9L,14L,2L,15L,12L,3L,13L,2L,9L,8L,7L,16L,10L,2L,13L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071488Inst : IEnumerable<long>
{
public static readonly long[] Value=A071488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071488.Bytes);
public long this[int i]=>Value[i];

public static A071488Inst Instance=new A071488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071489
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,6L,3L,2L,5L,1L,8L,6L,7L,5L,2L,4L,8L,1L,6L,10L,4L,5L,2L,6L,7L,10L,5L,1L,8L,7L,14L,6L,1L,5L,3L,8L,6L,1L,12L,10L,13L,6L,8L,1L,16L,2L,5L,17L,14L,16L,1L,12L,10L,3L,5L,1L,8L,7L,13L,5L,11L,8L,7L,1L,16L,5L,3L,18L,8L,1L,11L,10L,5L,8L,12L,7L,16L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071489Inst : IEnumerable<long>
{
public static readonly long[] Value=A071489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071489.Bytes);
public long this[int i]=>Value[i];

public static A071489Inst Instance=new A071489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071490
{
public static readonly long[] Value={ 1L,0L,2L,1L,3L,0L,1L,3L,4L,0L,2L,3L,4L,2L,1L,3L,2L,0L,3L,4L,1L,3L,4L,6L,2L,0L,1L,2L,5L,3L,1L,6L,7L,8L,1L,3L,4L,1L,6L,0L,7L,3L,4L,7L,2L,1L,6L,5L,1L,3L,4L,5L,8L,0L,6L,5L,1L,6L,5L,8L,3L,9L,1L,7L,4L,6L,7L,3L,2L,8L,4L,3L,9L,7L,10L,5L,11L,0L,9L,6L,12L,5L,6L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071490Inst : IEnumerable<long>
{
public static readonly long[] Value=A071490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071490.Bytes);
public long this[int i]=>Value[i];

public static A071490Inst Instance=new A071490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071491
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,0L,3L,1L,2L,3L,1L,2L,4L,3L,5L,0L,3L,4L,2L,6L,1L,2L,4L,1L,3L,0L,2L,1L,7L,2L,4L,7L,8L,4L,2L,0L,6L,1L,5L,2L,4L,7L,2L,4L,8L,0L,6L,4L,7L,6L,1L,3L,5L,0L,6L,5L,8L,6L,10L,7L,4L,6L,7L,10L,2L,0L,7L,4L,5L,2L,4L,11L,5L,10L,2L,5L,8L,3L,4L,2L,5L,9L,13L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071491Inst : IEnumerable<long>
{
public static readonly long[] Value=A071491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071491.Bytes);
public long this[int i]=>Value[i];

public static A071491Inst Instance=new A071491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071492
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,4L,0L,3L,1L,2L,0L,3L,4L,1L,2L,3L,6L,1L,2L,3L,0L,5L,1L,3L,0L,6L,4L,1L,3L,5L,2L,4L,6L,3L,0L,1L,4L,3L,0L,6L,1L,7L,0L,5L,1L,4L,6L,3L,1L,4L,0L,6L,8L,7L,2L,3L,6L,8L,2L,9L,3L,8L,2L,4L,0L,6L,8L,1L,3L,5L,6L,2L,4L,5L,0L,8L,1L,9L,0L,8L,1L,9L,10L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071492Inst : IEnumerable<long>
{
public static readonly long[] Value=A071492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071492.Bytes);
public long this[int i]=>Value[i];

public static A071492Inst Instance=new A071492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071493
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,0L,1L,0L,3L,2L,3L,4L,5L,0L,2L,3L,2L,5L,4L,0L,1L,0L,2L,3L,2L,1L,4L,5L,6L,7L,2L,0L,5L,4L,7L,6L,2L,3L,2L,0L,1L,7L,3L,6L,8L,4L,1L,0L,2L,6L,8L,5L,4L,1L,10L,3L,2L,0L,1L,0L,10L,11L,6L,7L,4L,0L,4L,10L,2L,6L,8L,0L,1L,0L,2L,3L,2L,8L,4L,5L,10L,6L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071493Inst : IEnumerable<long>
{
public static readonly long[] Value=A071493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071493.Bytes);
public long this[int i]=>Value[i];

public static A071493Inst Instance=new A071493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071494
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,4L,5L,1L,4L,6L,2L,3L,2L,1L,4L,5L,8L,7L,6L,7L,10L,1L,4L,1L,2L,3L,2L,6L,4L,1L,4L,8L,2L,3L,2L,1L,10L,1L,8L,9L,6L,7L,10L,1L,11L,1L,8L,2L,3L,6L,4L,5L,1L,12L,8L,3L,14L,10L,1L,4L,5L,8L,6L,7L,10L,11L,1L,4L,8L,2L,3L,6L,11L,10L,5L,4L,8L,3L,7L,10L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071494Inst : IEnumerable<long>
{
public static readonly long[] Value=A071494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071494.Bytes);
public long this[int i]=>Value[i];

public static A071494Inst Instance=new A071494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071495
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,4L,5L,1L,6L,7L,2L,3L,2L,1L,5L,8L,6L,7L,6L,10L,5L,4L,8L,9L,2L,3L,10L,11L,4L,5L,8L,3L,2L,11L,10L,1L,5L,8L,9L,3L,6L,10L,5L,4L,1L,3L,6L,2L,10L,11L,4L,9L,8L,6L,14L,15L,10L,13L,12L,8L,7L,6L,7L,5L,4L,12L,3L,12L,7L,14L,15L,4L,5L,4L,9L,6L,11L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071495Inst : IEnumerable<long>
{
public static readonly long[] Value=A071495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071495.Bytes);
public long this[int i]=>Value[i];

public static A071495Inst Instance=new A071495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071496
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,4L,3L,1L,2L,3L,5L,2L,4L,3L,5L,1L,3L,5L,2L,4L,7L,2L,4L,7L,8L,6L,4L,7L,6L,2L,7L,8L,6L,8L,3L,6L,12L,7L,4L,2L,7L,4L,2L,5L,3L,4L,2L,8L,4L,2L,1L,3L,12L,1L,8L,4L,2L,1L,11L,9L,1L,16L,17L,16L,1L,11L,13L,9L,2L,4L,16L,2L,8L,3L,1L,2L,4L,16L,2L,15L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071496Inst : IEnumerable<long>
{
public static readonly long[] Value=A071496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071496.Bytes);
public long this[int i]=>Value[i];

public static A071496Inst Instance=new A071496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071497
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,2L,4L,5L,1L,6L,7L,5L,1L,2L,8L,2L,6L,2L,8L,1L,5L,11L,7L,9L,5L,8L,1L,2L,1L,2L,12L,2L,5L,8L,5L,6L,1L,8L,1L,2L,12L,2L,14L,2L,8L,11L,1L,6L,8L,5L,1L,2L,12L,2L,1L,2L,6L,8L,5L,8L,11L,16L,1L,16L,2L,12L,1L,8L,2L,6L,5L,8L,11L,16L,5L,15L,1L,2L,1L,8L,16L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071497Inst : IEnumerable<long>
{
public static readonly long[] Value=A071497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071497.Bytes);
public long this[int i]=>Value[i];

public static A071497Inst Instance=new A071497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071498
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,1L,0L,2L,3L,4L,1L,5L,2L,3L,7L,1L,4L,2L,3L,7L,0L,1L,2L,3L,7L,5L,0L,1L,3L,2L,5L,4L,8L,6L,2L,5L,4L,8L,7L,2L,6L,1L,4L,8L,2L,6L,1L,4L,8L,2L,6L,1L,0L,8L,2L,3L,7L,4L,1L,8L,2L,10L,0L,1L,8L,2L,7L,5L,1L,8L,3L,6L,10L,1L,5L,2L,6L,10L,1L,5L,3L,2L,10L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071498Inst : IEnumerable<long>
{
public static readonly long[] Value=A071498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071498.Bytes);
public long this[int i]=>Value[i];

public static A071498Inst Instance=new A071498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071499
{
public static readonly long[] Value={ 1L,0L,2L,1L,3L,2L,1L,3L,4L,5L,3L,4L,2L,3L,1L,2L,5L,1L,2L,5L,7L,4L,5L,7L,4L,8L,2L,9L,6L,2L,9L,6L,8L,7L,6L,4L,7L,2L,1L,10L,5L,8L,3L,5L,2L,4L,5L,2L,4L,8L,2L,12L,3L,11L,4L,14L,8L,2L,12L,5L,15L,11L,16L,15L,17L,2L,18L,17L,14L,1L,4L,2L,12L,4L,19L,12L,3L,13L,2L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071499Inst : IEnumerable<long>
{
public static readonly long[] Value=A071499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071499.Bytes);
public long this[int i]=>Value[i];

public static A071499Inst Instance=new A071499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071500
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,5L,1L,6L,2L,3L,4L,5L,7L,6L,8L,9L,1L,2L,7L,6L,8L,5L,4L,3L,2L,9L,1L,5L,11L,3L,2L,8L,4L,10L,11L,3L,6L,5L,9L,10L,2L,3L,12L,4L,5L,6L,10L,9L,12L,4L,5L,7L,16L,13L,1L,4L,3L,14L,6L,12L,11L,4L,10L,8L,9L,13L,16L,14L,6L,8L,9L,19L,10L,16L,17L,4L,9L,11L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071500Inst : IEnumerable<long>
{
public static readonly long[] Value=A071500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071500.Bytes);
public long this[int i]=>Value[i];

public static A071500Inst Instance=new A071500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071501
{
public static readonly long[] Value={ 1L,2L,3L,1L,0L,3L,2L,4L,0L,2L,3L,4L,0L,1L,2L,4L,1L,6L,3L,2L,0L,1L,2L,3L,4L,1L,3L,4L,2L,1L,0L,7L,3L,4L,1L,6L,2L,1L,8L,7L,2L,4L,1L,6L,8L,4L,0L,1L,3L,4L,1L,6L,7L,4L,5L,1L,6L,8L,4L,9L,6L,4L,10L,5L,0L,7L,5L,4L,10L,6L,8L,4L,11L,7L,13L,2L,5L,6L,12L,5L,4L,7L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071501Inst : IEnumerable<long>
{
public static readonly long[] Value=A071501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071501.Bytes);
public long this[int i]=>Value[i];

public static A071501Inst Instance=new A071501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071502
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,4L,3L,1L,2L,3L,5L,2L,4L,3L,5L,1L,3L,5L,2L,4L,7L,2L,4L,7L,8L,6L,4L,7L,6L,2L,7L,8L,6L,9L,3L,6L,9L,7L,4L,2L,7L,4L,2L,5L,3L,4L,2L,9L,4L,2L,1L,3L,12L,1L,9L,4L,2L,1L,9L,8L,13L,9L,10L,8L,11L,10L,15L,11L,2L,4L,15L,2L,4L,3L,16L,2L,4L,11L,2L,17L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071502Inst : IEnumerable<long>
{
public static readonly long[] Value=A071502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071502.Bytes);
public long this[int i]=>Value[i];

public static A071502Inst Instance=new A071502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071503
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,4L,3L,2L,1L,3L,4L,2L,7L,4L,8L,1L,4L,8L,1L,2L,4L,8L,1L,4L,3L,8L,1L,4L,8L,2L,1L,4L,8L,1L,4L,8L,1L,2L,4L,8L,1L,4L,7L,8L,1L,4L,8L,2L,1L,4L,8L,1L,7L,4L,1L,2L,4L,8L,1L,4L,7L,8L,1L,4L,8L,2L,1L,4L,8L,1L,7L,4L,1L,2L,4L,8L,1L,4L,7L,8L,1L,4L,8L,2L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071503Inst : IEnumerable<long>
{
public static readonly long[] Value=A071503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071503.Bytes);
public long this[int i]=>Value[i];

public static A071503Inst Instance=new A071503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071504
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,4L,3L,5L,2L,4L,3L,5L,1L,4L,3L,2L,6L,4L,5L,8L,6L,7L,10L,8L,2L,7L,3L,6L,2L,7L,4L,6L,5L,3L,9L,2L,5L,3L,4L,2L,6L,14L,4L,5L,1L,8L,9L,15L,1L,13L,9L,12L,5L,13L,4L,16L,2L,9L,3L,8L,2L,4L,13L,5L,2L,3L,7L,5L,1L,3L,8L,16L,6L,13L,14L,16L,15L,7L,14L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071504Inst : IEnumerable<long>
{
public static readonly long[] Value=A071504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071504.Bytes);
public long this[int i]=>Value[i];

public static A071504Inst Instance=new A071504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071505
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,1L,1L,5L,6L,3L,3L,2L,2L,1L,1L,0L,8L,7L,7L,2L,5L,5L,4L,0L,1L,1L,2L,2L,8L,8L,4L,5L,5L,6L,6L,7L,7L,2L,8L,1L,1L,11L,10L,7L,6L,6L,5L,5L,4L,4L,11L,11L,2L,2L,8L,8L,4L,5L,5L,2L,6L,7L,7L,8L,5L,1L,1L,2L,10L,7L,6L,8L,1L,1L,4L,14L,11L,11L,6L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071505Inst : IEnumerable<long>
{
public static readonly long[] Value=A071505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071505.Bytes);
public long this[int i]=>Value[i];

public static A071505Inst Instance=new A071505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071506
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,3L,4L,4L,0L,1L,1L,3L,2L,2L,3L,4L,4L,5L,6L,6L,3L,2L,2L,3L,1L,1L,8L,7L,6L,3L,10L,10L,0L,1L,1L,8L,7L,6L,4L,4L,5L,8L,1L,1L,0L,2L,10L,11L,4L,5L,8L,8L,6L,3L,2L,10L,11L,4L,5L,5L,6L,6L,11L,1L,10L,3L,1L,8L,8L,7L,6L,11L,10L,16L,12L,1L,9L,8L,7L,6L,4L,4L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071506Inst : IEnumerable<long>
{
public static readonly long[] Value=A071506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071506.Bytes);
public long this[int i]=>Value[i];

public static A071506Inst Instance=new A071506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071507
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,1L,1L,6L,6L,3L,2L,2L,1L,0L,6L,6L,8L,4L,4L,5L,10L,1L,7L,8L,3L,3L,2L,4L,1L,6L,6L,8L,8L,4L,10L,10L,12L,1L,8L,14L,5L,4L,4L,7L,1L,6L,9L,3L,3L,1L,12L,6L,7L,7L,4L,4L,5L,11L,10L,1L,1L,8L,14L,14L,4L,10L,7L,6L,8L,1L,14L,3L,11L,12L,13L,7L,14L,14L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071507Inst : IEnumerable<long>
{
public static readonly long[] Value=A071507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071507.Bytes);
public long this[int i]=>Value[i];

public static A071507Inst Instance=new A071507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071508
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,1L,1L,5L,6L,3L,3L,2L,2L,1L,1L,8L,8L,7L,7L,6L,5L,5L,4L,4L,1L,1L,2L,2L,8L,8L,4L,5L,5L,6L,6L,7L,7L,8L,8L,1L,1L,10L,10L,7L,6L,6L,1L,1L,4L,4L,3L,3L,2L,1L,1L,8L,4L,4L,11L,2L,2L,6L,12L,8L,8L,1L,1L,2L,3L,3L,8L,4L,9L,1L,14L,14L,11L,3L,16L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071508Inst : IEnumerable<long>
{
public static readonly long[] Value=A071508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071508.Bytes);
public long this[int i]=>Value[i];

public static A071508Inst Instance=new A071508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071509
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,1L,1L,6L,6L,3L,2L,2L,1L,1L,6L,6L,8L,4L,4L,5L,10L,1L,1L,8L,3L,3L,4L,4L,7L,6L,6L,8L,8L,4L,1L,1L,6L,7L,8L,4L,4L,5L,10L,8L,1L,1L,15L,5L,4L,4L,7L,6L,6L,1L,1L,4L,3L,3L,6L,1L,1L,4L,4L,3L,8L,8L,1L,1L,10L,14L,8L,4L,13L,6L,6L,1L,1L,8L,3L,3L,13L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071509Inst : IEnumerable<long>
{
public static readonly long[] Value=A071509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071509.Bytes);
public long this[int i]=>Value[i];

public static A071509Inst Instance=new A071509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071510
{
public static readonly long[] Value={ 1L,0L,2L,2L,1L,0L,4L,4L,1L,6L,7L,0L,1L,2L,2L,6L,1L,4L,4L,6L,1L,8L,7L,0L,1L,8L,7L,6L,1L,4L,7L,6L,1L,0L,7L,8L,1L,6L,7L,4L,1L,0L,7L,2L,1L,0L,7L,8L,1L,6L,7L,8L,1L,0L,2L,2L,1L,0L,4L,4L,1L,6L,7L,0L,1L,2L,2L,6L,1L,4L,4L,6L,1L,8L,7L,0L,1L,8L,7L,6L,1L,4L,7L,6L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071510Inst : IEnumerable<long>
{
public static readonly long[] Value=A071510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071510.Bytes);
public long this[int i]=>Value[i];

public static A071510Inst Instance=new A071510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071511
{
public static readonly long[] Value={ 1L,0L,2L,2L,4L,4L,1L,1L,3L,2L,5L,4L,7L,6L,8L,2L,3L,10L,7L,6L,8L,9L,3L,2L,12L,6L,5L,4L,3L,2L,1L,1L,9L,4L,5L,10L,10L,12L,14L,9L,9L,11L,11L,16L,16L,2L,3L,12L,6L,6L,16L,16L,5L,5L,20L,10L,17L,8L,8L,18L,11L,20L,20L,9L,5L,17L,13L,21L,21L,6L,2L,24L,17L,13L,1L,28L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071511Inst : IEnumerable<long>
{
public static readonly long[] Value=A071511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071511.Bytes);
public long this[int i]=>Value[i];

public static A071511Inst Instance=new A071511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071512
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,3L,1L,2L,3L,4L,5L,3L,4L,5L,3L,2L,1L,3L,2L,1L,0L,2L,5L,4L,7L,5L,4L,7L,6L,8L,9L,2L,0L,1L,2L,3L,9L,6L,7L,4L,5L,7L,4L,5L,9L,10L,1L,3L,2L,1L,4L,10L,5L,4L,7L,6L,4L,7L,6L,8L,9L,2L,8L,3L,2L,7L,4L,6L,7L,4L,5L,7L,4L,5L,9L,10L,2L,9L,8L,5L,4L,7L,5L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071512Inst : IEnumerable<long>
{
public static readonly long[] Value=A071512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071512.Bytes);
public long this[int i]=>Value[i];

public static A071512Inst Instance=new A071512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071513
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,7L,3L,4L,1L,6L,7L,8L,9L,1L,6L,7L,8L,9L,1L,4L,3L,7L,6L,5L,4L,3L,2L,6L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,0L,4L,3L,2L,8L,10L,9L,4L,2L,12L,8L,9L,14L,2L,3L,4L,0L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071513Inst : IEnumerable<long>
{
public static readonly long[] Value=A071513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071513.Bytes);
public long this[int i]=>Value[i];

public static A071513Inst Instance=new A071513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071514
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,6L,3L,2L,5L,8L,9L,6L,10L,5L,4L,9L,6L,14L,10L,4L,2L,3L,6L,7L,16L,4L,9L,14L,10L,16L,17L,9L,4L,14L,15L,1L,9L,16L,2L,5L,14L,9L,16L,17L,2L,3L,5L,9L,17L,10L,16L,3L,9L,24L,28L,16L,17L,2L,8L,32L,15L,14L,16L,5L,8L,2L,28L,32L,12L,4L,2L,14L,16L,29L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071514Inst : IEnumerable<long>
{
public static readonly long[] Value=A071514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071514.Bytes);
public long this[int i]=>Value[i];

public static A071514Inst Instance=new A071514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071515
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,4L,5L,1L,6L,7L,2L,3L,2L,1L,8L,9L,6L,7L,10L,4L,5L,9L,8L,1L,10L,11L,10L,4L,5L,9L,6L,1L,10L,11L,3L,9L,8L,9L,6L,7L,10L,12L,5L,9L,8L,1L,6L,10L,16L,4L,5L,18L,14L,7L,16L,10L,12L,1L,8L,9L,6L,7L,16L,12L,5L,19L,18L,8L,20L,16L,10L,1L,4L,18L,8L,7L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071515Inst : IEnumerable<long>
{
public static readonly long[] Value=A071515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071515.Bytes);
public long this[int i]=>Value[i];

public static A071515Inst Instance=new A071515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071516
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,5L,1L,6L,2L,3L,4L,5L,7L,6L,8L,9L,1L,10L,7L,6L,8L,5L,4L,3L,2L,6L,1L,5L,4L,3L,2L,8L,14L,10L,11L,5L,9L,16L,14L,15L,18L,3L,4L,5L,1L,6L,2L,3L,4L,5L,11L,6L,7L,16L,2L,5L,18L,9L,7L,16L,4L,3L,2L,6L,1L,5L,4L,18L,8L,9L,16L,26L,23L,5L,13L,9L,1L,15L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071516Inst : IEnumerable<long>
{
public static readonly long[] Value=A071516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071516.Bytes);
public long this[int i]=>Value[i];

public static A071516Inst Instance=new A071516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071517
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,5L,6L,7L,1L,3L,2L,8L,9L,5L,4L,6L,12L,2L,1L,9L,6L,4L,5L,12L,13L,2L,3L,8L,9L,5L,6L,13L,12L,3L,2L,9L,6L,10L,16L,6L,12L,2L,3L,8L,6L,11L,16L,14L,12L,3L,16L,9L,8L,6L,16L,24L,13L,3L,2L,8L,9L,11L,16L,14L,12L,13L,3L,16L,8L,6L,19L,16L,1L,12L,23L,27L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071517Inst : IEnumerable<long>
{
public static readonly long[] Value=A071517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071517.Bytes);
public long this[int i]=>Value[i];

public static A071517Inst Instance=new A071517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071518
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,6L,3L,2L,1L,6L,7L,4L,5L,8L,1L,10L,5L,4L,7L,6L,1L,2L,3L,6L,1L,4L,3L,2L,1L,8L,10L,4L,14L,16L,1L,2L,3L,4L,1L,6L,3L,2L,1L,6L,7L,4L,5L,8L,1L,10L,5L,8L,7L,6L,1L,2L,3L,6L,1L,4L,3L,14L,1L,8L,10L,16L,14L,18L,1L,10L,3L,4L,1L,6L,3L,2L,1L,20L,7L,16L,5L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071518Inst : IEnumerable<long>
{
public static readonly long[] Value=A071518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071518.Bytes);
public long this[int i]=>Value[i];

public static A071518Inst Instance=new A071518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071519
{
public static readonly long[] Value={ 11826L,12363L,12543L,14676L,15681L,15963L,18072L,19023L,19377L,19569L,19629L,20316L,22887L,23019L,23178L,23439L,24237L,24276L,24441L,24807L,25059L,25572L,25941L,26409L,26733L,27129L,27273L,29034L,29106L,30384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071519Inst : IEnumerable<long>
{
public static readonly long[] Value=A071519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071519.Bytes);
public long this[int i]=>Value[i];

public static A071519Inst Instance=new A071519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071520
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,9L,10L,10L,10L,11L,12L,12L,13L,13L,14L,14L,14L,14L,15L,16L,16L,17L,17L,17L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,27L,27L,27L,27L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071520Inst : IEnumerable<long>
{
public static readonly long[] Value=A071520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071520.Bytes);
public long this[int i]=>Value[i];

public static A071520Inst Instance=new A071520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071521
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,6L,7L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071521Inst : IEnumerable<long>
{
public static readonly long[] Value=A071521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071521.Bytes);
public long this[int i]=>Value[i];

public static A071521Inst Instance=new A071521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071522
{
public static readonly long[] Value={ 2L,6L,16L,22L,36L,42L,46L,52L,72L,82L,96L,102L,106L,112L,136L,156L,166L,172L,192L,196L,222L,226L,232L,256L,262L,276L,282L,292L,306L,316L,346L,352L,372L,382L,396L,432L,442L,462L,466L,502L,522L,546L,556L,562L,576L,586L,592L,606L,612L,616L,646L,652L,672L,676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071522Inst : IEnumerable<long>
{
public static readonly long[] Value=A071522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071522.Bytes);
public long this[int i]=>Value[i];

public static A071522Inst Instance=new A071522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071523
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,16L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,24L,25L,26L,26L,27L,28L,28L,28L,28L,29L,29L,30L,30L,31L,32L,32L,32L,33L,34L,35L,35L,35L,35L,36L,37L,38L,38L,38L,38L,39L,39L,39L,40L,41L,41L,42L,42L,42L,42L,43L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071523Inst : IEnumerable<long>
{
public static readonly long[] Value=A071523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071523.Bytes);
public long this[int i]=>Value[i];

public static A071523Inst Instance=new A071523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071524
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,16L,25L,-25L,-100L,1L,81L,-16L,-36L,0L,1764L,-3136L,-196L,324L,16L,-225L,-1764L,1521L,9L,-3969L,-4356L,4761L,9L,-1225L,-19881L,5041L,156816L,-312481L,-167281L,219024L,3600L,-186624L,-158404L,5541316L,3020644L,-19554084L,-1350244L,198810000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071524Inst : IEnumerable<long>
{
public static readonly long[] Value=A071524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071524.Bytes);
public long this[int i]=>Value[i];

public static A071524Inst Instance=new A071524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071525
{
public static readonly long[] Value={ 1L,3L,304L,918L,23922L,2388063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071525Inst : IEnumerable<long>
{
public static readonly long[] Value=A071525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071525.Bytes);
public long this[int i]=>Value[i];

public static A071525Inst Instance=new A071525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071526
{
public static readonly long[] Value={ 1L,3L,9L,15L,21L,33L,39L,45L,63L,75L,99L,117L,135L,189L,225L,231L,255L,273L,285L,345L,375L,399L,405L,435L,465L,555L,609L,615L,645L,675L,693L,705L,765L,819L,855L,915L,1005L,1035L,1095L,1125L,1185L,1215L,1245L,1275L,1395L,1425L,1515L,1545L,1605L,1617L,1665L,1725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071526Inst : IEnumerable<long>
{
public static readonly long[] Value=A071526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071526.Bytes);
public long this[int i]=>Value[i];

public static A071526Inst Instance=new A071526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071527
{
public static readonly long[] Value={ 2L,3L,7L,8L,15L,17L,18L,24L,32L,45L,54L,59L,90L,100L,112L,114L,128L,135L,144L,249L,270L,419L,452L,517L,557L,674L,701L,822L,916L,1074L,1274L,1643L,2137L,2180L,2272L,2519L,2539L,3049L,3294L,3666L,3907L,4405L,4463L,4478L,4848L,5226L,5446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071527Inst : IEnumerable<long>
{
public static readonly long[] Value=A071527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071527.Bytes);
public long this[int i]=>Value[i];

public static A071527Inst Instance=new A071527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071528
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,6L,8L,7L,12L,11L,11L,15L,13L,13L,16L,19L,17L,18L,19L,23L,25L,25L,27L,29L,32L,32L,27L,40L,40L,46L,35L,44L,38L,41L,43L,40L,46L,45L,55L,54L,57L,62L,53L,57L,52L,59L,67L,61L,67L,66L,69L,74L,80L,79L,85L,77L,78L,76L,83L,85L,88L,96L,78L,101L,93L,89L,101L,88L,106L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071528Inst : IEnumerable<long>
{
public static readonly long[] Value=A071528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071528.Bytes);
public long this[int i]=>Value[i];

public static A071528Inst Instance=new A071528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071529
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,4L,7L,7L,12L,5L,8L,10L,23L,18L,25L,14L,18L,17L,14L,24L,22L,22L,35L,15L,21L,30L,29L,33L,37L,30L,27L,47L,49L,44L,54L,55L,53L,51L,46L,46L,43L,60L,64L,65L,79L,64L,64L,67L,73L,66L,79L,68L,60L,76L,86L,85L,85L,83L,86L,74L,90L,84L,93L,106L,90L,85L,98L,107L,88L,104L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071529Inst : IEnumerable<long>
{
public static readonly long[] Value=A071529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071529.Bytes);
public long this[int i]=>Value[i];

public static A071529Inst Instance=new A071529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071530
{
public static readonly long[] Value={ 3L,6L,7L,9L,10L,13L,15L,17L,18L,19L,23L,24L,25L,26L,32L,33L,35L,38L,41L,44L,47L,54L,60L,62L,68L,69L,74L,80L,83L,89L,95L,99L,110L,113L,119L,128L,179L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071530Inst : IEnumerable<long>
{
public static readonly long[] Value=A071530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071530.Bytes);
public long this[int i]=>Value[i];

public static A071530Inst Instance=new A071530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071531
{
public static readonly long[] Value={ 10L,10L,5L,8L,9L,4L,4L,5L,1L,5L,4L,6L,7L,4L,3L,7L,4L,4L,1L,5L,3L,6L,6L,4L,6L,5L,5L,4L,1L,6L,2L,2L,3L,4L,5L,3L,4L,5L,1L,5L,3L,3L,4L,2L,5L,2L,2L,2L,1L,2L,2L,2L,4L,2L,5L,4L,6L,3L,1L,5L,6L,3L,2L,4L,6L,3L,9L,3L,1L,2L,6L,3L,3L,4L,8L,4L,2L,3L,1L,4L,5L,5L,2L,4L,3L,3L,6L,3L,1L,5L,5L,3L,3L,2L,7L,2L,2L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071531Inst : IEnumerable<long>
{
public static readonly long[] Value=A071531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071531.Bytes);
public long this[int i]=>Value[i];

public static A071531Inst Instance=new A071531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071532
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,10L,9L,8L,9L,8L,9L,8L,7L,8L,7L,8L,9L,10L,11L,10L,9L,10L,9L,8L,7L,8L,7L,6L,7L,8L,7L,8L,7L,6L,5L,6L,7L,6L,7L,6L,7L,8L,9L,8L,9L,10L,11L,12L,13L,12L,11L,10L,11L,10L,11L,10L,9L,10L,9L,10L,9L,8L,7L,6L,5L,6L,7L,6L,7L,6L,5L,4L,5L,6L,5L,4L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071532Inst : IEnumerable<long>
{
public static readonly long[] Value=A071532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071532.Bytes);
public long this[int i]=>Value[i];

public static A071532Inst Instance=new A071532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071533
{
public static readonly long[] Value={ 1L,-3L,8L,44L,192L,-323L,289L,4641L,10520L,4400L,-68280L,484561L,808201L,488157L,-2948752L,17408204L,130987992L,-65477123L,11580409L,658776561L,9777980240L,8114321600L,-39315892560L,138239377921L,475273738801L,1607488031517L,-3426809717512L,4583117135564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071533Inst : IEnumerable<long>
{
public static readonly long[] Value=A071533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071533.Bytes);
public long this[int i]=>Value[i];

public static A071533Inst Instance=new A071533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071534
{
public static readonly long[] Value={ 1L,-3L,0L,12L,-8L,-35L,57L,81L,-264L,-80L,1000L,-495L,-3159L,4221L,7912L,-21140L,-11568L,83997L,-24495L,-278783L,304336L,751296L,-1665360L,-1365375L,6971185L,-595619L,-24258384L,21035052L,69622920L,-128909123L,-146359223L,571337745L,73385352L,-2083467984L,1364948056L,6324200785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071534Inst : IEnumerable<long>
{
public static readonly long[] Value=A071534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071534.Bytes);
public long this[int i]=>Value[i];

public static A071534Inst Instance=new A071534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071535
{
public static readonly long[] Value={ 1L,15L,176L,1680L,13824L,102144L,696320L,4460544L,27197440L,159318016L,902823936L,4975493120L,26776436736L,141180272640L,731218182144L,3728300048384L,18747532247040L,93110596009984L,457328117678080L,2223830986653696L,10715840324304896L,51209754063667200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071535Inst : IEnumerable<long>
{
public static readonly long[] Value=A071535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071535.Bytes);
public long this[int i]=>Value[i];

public static A071535Inst Instance=new A071535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071536
{
public static readonly long[] Value={ 1L,1L,3L,3L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071536Inst : IEnumerable<long>
{
public static readonly long[] Value=A071536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071536.Bytes);
public long this[int i]=>Value[i];

public static A071536Inst Instance=new A071536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071537
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,9L,14L,12L,15L,16L,22L,18L,26L,21L,20L,24L,34L,25L,38L,27L,28L,33L,46L,30L,32L,39L,35L,36L,58L,40L,62L,42L,44L,51L,45L,48L,74L,57L,52L,49L,82L,50L,86L,55L,54L,69L,94L,56L,60L,63L,68L,65L,106L,64L,66L,70L,76L,87L,118L,72L,122L,93L,75L,77L,78L,80L,134L,85L,92L,84L,142L,81L,146L,111L,88L,95L,90L,91L,158L,96L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071537Inst : IEnumerable<long>
{
public static readonly long[] Value=A071537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071537.Bytes);
public long this[int i]=>Value[i];

public static A071537Inst Instance=new A071537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071538
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071538Inst : IEnumerable<long>
{
public static readonly long[] Value=A071538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071538.Bytes);
public long this[int i]=>Value[i];

public static A071538Inst Instance=new A071538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071539
{
public static readonly long[] Value={ 0L,18L,168L,1170L,7440L,45738L,277368L,1672290L,10056480L,60404058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071539Inst : IEnumerable<long>
{
public static readonly long[] Value=A071539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071539.Bytes);
public long this[int i]=>Value[i];

public static A071539Inst Instance=new A071539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071652
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,14L,16L,8L,9L,15L,42L,19L,17L,11L,37L,43L,51L,44L,20L,12L,39L,121L,52L,126L,53L,21L,10L,40L,123L,149L,127L,154L,56L,18L,28L,38L,124L,151L,385L,155L,163L,47L,54L,30L,112L,122L,152L,387L,475L,164L,135L,156L,57L,13L,114L,376L,150L,388L,477L,503L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071652Inst : IEnumerable<long>
{
public static readonly long[] Value=A071652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071652.Bytes);
public long this[int i]=>Value[i];

public static A071652Inst Instance=new A071652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071653
{
public static readonly long[] Value={ 0L,1L,3L,2L,10L,6L,5L,7L,4L,66L,28L,21L,36L,15L,14L,9L,12L,56L,22L,8L,16L,29L,11L,2278L,435L,253L,703L,136L,120L,55L,91L,1653L,276L,45L,153L,465L,78L,77L,35L,27L,44L,20L,25L,18L,68L,2212L,407L,30L,232L,667L,121L,19L,13L,23L,106L,46L,38L,79L,1597L,254L,17L,37L,137L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071653Inst : IEnumerable<long>
{
public static readonly long[] Value=A071653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071653.Bytes);
public long this[int i]=>Value[i];

public static A071653Inst Instance=new A071653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071654
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,5L,7L,19L,15L,4L,22L,16L,52L,14L,13L,20L,60L,43L,51L,41L,11L,18L,53L,178L,42L,153L,39L,10L,21L,47L,155L,177L,125L,151L,38L,12L,61L,56L,136L,154L,555L,123L,150L,40L,33L,55L,179L,164L,135L,479L,553L,122L,152L,117L,29L,17L,159L,557L,163L,417L,477L,552L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071654Inst : IEnumerable<long>
{
public static readonly long[] Value=A071654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071654.Bytes);
public long this[int i]=>Value[i];

public static A071654Inst Instance=new A071654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071655
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,4L,6L,17L,18L,20L,21L,22L,12L,13L,10L,9L,11L,15L,14L,19L,16L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,31L,32L,34L,35L,36L,26L,27L,24L,23L,25L,29L,28L,33L,30L,40L,41L,38L,37L,39L,52L,51L,56L,60L,43L,42L,47L,44L,53L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071655Inst : IEnumerable<long>
{
public static readonly long[] Value=A071655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071655.Bytes);
public long this[int i]=>Value[i];

public static A071655Inst Instance=new A071655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071656
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,4L,5L,17L,16L,18L,14L,15L,20L,19L,22L,9L,10L,21L,11L,12L,13L,45L,44L,46L,42L,43L,48L,47L,50L,37L,38L,49L,39L,40L,41L,54L,53L,55L,51L,52L,61L,60L,63L,23L,24L,62L,25L,26L,27L,57L,56L,64L,28L,29L,58L,30L,31L,32L,59L,33L,34L,35L,36L,129L,128L,130L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071656Inst : IEnumerable<long>
{
public static readonly long[] Value=A071656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071656.Bytes);
public long this[int i]=>Value[i];

public static A071656Inst Instance=new A071656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071657
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,6L,4L,17L,18L,20L,21L,22L,12L,13L,15L,16L,19L,10L,9L,14L,11L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,31L,32L,34L,35L,36L,40L,41L,43L,44L,47L,52L,53L,56L,60L,26L,27L,24L,28L,25L,38L,37L,42L,51L,29L,33L,30L,39L,23L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071657Inst : IEnumerable<long>
{
public static readonly long[] Value=A071657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071657.Bytes);
public long this[int i]=>Value[i];

public static A071657Inst Instance=new A071657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071658
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,4L,5L,20L,19L,22L,14L,15L,21L,16L,17L,9L,10L,18L,11L,12L,13L,64L,53L,55L,51L,52L,54L,60L,62L,37L,38L,61L,39L,40L,41L,57L,56L,63L,42L,43L,58L,44L,45L,23L,24L,46L,25L,26L,27L,59L,47L,48L,28L,29L,49L,30L,31L,32L,50L,33L,34L,35L,36L,162L,191L,192L,154L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071658Inst : IEnumerable<long>
{
public static readonly long[] Value=A071658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071658.Bytes);
public long this[int i]=>Value[i];

public static A071658Inst Instance=new A071658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071659
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,6L,5L,17L,18L,20L,21L,22L,10L,9L,14L,16L,19L,11L,12L,15L,13L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,26L,27L,23L,25L,24L,38L,37L,42L,44L,47L,51L,53L,56L,60L,29L,28L,30L,32L,31L,39L,40L,43L,52L,33L,34L,35L,41L,36L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071659Inst : IEnumerable<long>
{
public static readonly long[] Value=A071659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071659.Bytes);
public long this[int i]=>Value[i];

public static A071659Inst Instance=new A071659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071660
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,4L,5L,15L,14L,19L,20L,22L,16L,21L,17L,9L,10L,18L,11L,12L,13L,39L,41L,40L,37L,38L,52L,51L,53L,55L,54L,60L,61L,62L,64L,43L,42L,56L,57L,63L,44L,58L,45L,23L,24L,46L,25L,26L,27L,47L,59L,48L,28L,29L,49L,30L,31L,32L,50L,33L,34L,35L,36L,113L,112L,117L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071660Inst : IEnumerable<long>
{
public static readonly long[] Value=A071660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071660.Bytes);
public long this[int i]=>Value[i];

public static A071660Inst Instance=new A071660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071661
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,14L,16L,11L,19L,17L,20L,12L,10L,15L,21L,18L,13L,22L,23L,37L,42L,28L,51L,44L,53L,30L,25L,39L,56L,47L,33L,60L,45L,54L,57L,48L,61L,31L,34L,26L,24L,38L,40L,43L,29L,52L,58L,62L,49L,46L,55L,35L,32L,27L,41L,63L,59L,50L,36L,64L,65L,107L,121L,79L,149L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071661Inst : IEnumerable<long>
{
public static readonly long[] Value=A071661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071661.Bytes);
public long this[int i]=>Value[i];

public static A071661Inst Instance=new A071661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071662
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,17L,12L,16L,21L,10L,18L,11L,14L,20L,13L,15L,19L,22L,23L,45L,31L,44L,58L,26L,49L,30L,42L,57L,35L,43L,56L,63L,24L,46L,32L,47L,59L,25L,48L,28L,37L,54L,34L,40L,53L,62L,27L,50L,29L,38L,55L,33L,39L,51L,61L,36L,41L,52L,60L,64L,65L,129L,87L,128L,170L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071662Inst : IEnumerable<long>
{
public static readonly long[] Value=A071662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071662.Bytes);
public long this[int i]=>Value[i];

public static A071662Inst Instance=new A071662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071663
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,5L,6L,7L,4L,22L,13L,15L,18L,10L,19L,11L,20L,21L,12L,14L,16L,17L,9L,64L,36L,41L,50L,27L,52L,29L,55L,59L,32L,38L,43L,46L,24L,60L,33L,39L,47L,25L,61L,48L,62L,63L,35L,34L,40L,49L,26L,51L,28L,53L,56L,30L,54L,57L,58L,31L,37L,42L,44L,45L,23L,196L,106L,120L,148L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071663Inst : IEnumerable<long>
{
public static readonly long[] Value=A071663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071663.Bytes);
public long this[int i]=>Value[i];

public static A071663Inst Instance=new A071663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071664
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,5L,6L,7L,4L,22L,13L,15L,18L,10L,19L,11L,20L,21L,12L,14L,16L,17L,9L,64L,36L,41L,50L,27L,52L,29L,55L,59L,32L,38L,47L,46L,24L,60L,33L,39L,48L,25L,61L,34L,62L,63L,35L,40L,43L,49L,26L,51L,28L,53L,56L,30L,54L,57L,58L,31L,37L,42L,44L,45L,23L,196L,106L,120L,148L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071664Inst : IEnumerable<long>
{
public static readonly long[] Value=A071664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071664.Bytes);
public long this[int i]=>Value[i];

public static A071664Inst Instance=new A071664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071665
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,17L,12L,16L,21L,10L,18L,11L,14L,20L,13L,15L,19L,22L,23L,45L,31L,44L,58L,26L,49L,30L,42L,57L,35L,40L,56L,63L,24L,46L,32L,43L,59L,25L,47L,28L,37L,54L,48L,34L,53L,62L,27L,50L,29L,38L,55L,33L,39L,51L,61L,36L,41L,52L,60L,64L,65L,129L,87L,128L,170L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071665Inst : IEnumerable<long>
{
public static readonly long[] Value=A071665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071665.Bytes);
public long this[int i]=>Value[i];

public static A071665Inst Instance=new A071665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071666
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,14L,16L,11L,19L,17L,20L,12L,10L,15L,21L,18L,13L,22L,23L,37L,42L,28L,51L,44L,53L,30L,25L,39L,56L,48L,33L,60L,45L,54L,57L,34L,61L,31L,40L,26L,24L,38L,43L,47L,29L,52L,58L,62L,49L,46L,55L,35L,32L,27L,41L,63L,59L,50L,36L,64L,65L,107L,121L,79L,149L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071666Inst : IEnumerable<long>
{
public static readonly long[] Value=A071666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071666.Bytes);
public long this[int i]=>Value[i];

public static A071666Inst Instance=new A071666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071667
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,5L,4L,22L,19L,20L,15L,14L,21L,16L,18L,13L,11L,17L,12L,10L,9L,64L,60L,61L,52L,51L,62L,53L,55L,41L,39L,54L,34L,38L,37L,63L,56L,57L,40L,42L,59L,43L,50L,36L,33L,47L,48L,29L,28L,58L,44L,49L,35L,30L,46L,32L,27L,25L,45L,31L,26L,24L,23L,196L,191L,192L,178L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071667Inst : IEnumerable<long>
{
public static readonly long[] Value=A071667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071667.Bytes);
public long this[int i]=>Value[i];

public static A071667Inst Instance=new A071667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071764
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,11L,14L,17L,21L,26L,30L,36L,42L,48L,54L,62L,69L,78L,86L,95L,105L,116L,125L,136L,148L,160L,172L,186L,198L,213L,227L,242L,258L,274L,288L,306L,324L,342L,359L,379L,397L,418L,438L,458L,480L,503L,523L,546L,569L,593L,617L,643L,667L,693L,718L,745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071764Inst : IEnumerable<long>
{
public static readonly long[] Value=A071764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071764.Bytes);
public long this[int i]=>Value[i];

public static A071764Inst Instance=new A071764Inst();

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