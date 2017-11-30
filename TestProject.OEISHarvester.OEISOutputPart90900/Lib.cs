using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A110541
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,1L,1L,5L,7L,4L,1L,1L,1L,8L,19L,13L,5L,1L,1L,1L,13L,51L,46L,21L,6L,1L,1L,1L,21L,141L,166L,89L,31L,7L,1L,1L,1L,34L,393L,610L,393L,151L,43L,8L,1L,1L,1L,55L,1107L,2269L,1761L,776L,235L,57L,9L,1L,1L,1L,89L,3139L,8518L,7985L,4056L,1363L,344L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110541Inst : IEnumerable<long>
{
public static readonly long[] Value=A110541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110541.Bytes);
public long this[int i]=>Value[i];

public static A110541Inst Instance=new A110541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110542
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,19L,48L,140L,458L,1635L,6272L,25580L,110130L,497832L,2352807L,11584809L,59251847L,313995514L,1720289573L,9725340014L,56636885799L,339259270680L,2087446695738L,13177129073994L,85244657070582L,564567565446106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110542Inst : IEnumerable<long>
{
public static readonly long[] Value=A110542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110542.Bytes);
public long this[int i]=>Value[i];

public static A110542Inst Instance=new A110542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110543
{
public static readonly long[] Value={ 9L,2L,2L,7L,4L,5L,9L,5L,0L,6L,8L,0L,6L,3L,0L,6L,0L,5L,1L,4L,3L,8L,8L,0L,4L,8L,2L,3L,4L,5L,7L,5L,5L,5L,7L,7L,4L,3L,7L,2L,3L,4L,3L,9L,1L,7L,1L,0L,6L,8L,5L,9L,1L,5L,2L,0L,2L,0L,8L,0L,4L,0L,8L,3L,5L,3L,8L,4L,9L,0L,5L,8L,6L,5L,1L,9L,7L,5L,7L,8L,2L,7L,5L,8L,8L,3L,7L,1L,1L,6L,9L,7L,3L,7L,5L,9L,7L,7L,4L,4L,8L,1L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110543Inst : IEnumerable<long>
{
public static readonly long[] Value=A110543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110543.Bytes);
public long this[int i]=>Value[i];

public static A110543Inst Instance=new A110543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110544
{
public static readonly long[] Value={ 0L,8L,1L,0L,6L,1L,4L,6L,6L,7L,9L,5L,3L,2L,7L,2L,5L,8L,2L,1L,9L,6L,7L,0L,2L,6L,3L,5L,9L,4L,3L,8L,2L,3L,6L,0L,1L,3L,8L,6L,0L,2L,5L,2L,6L,3L,6L,2L,2L,1L,6L,5L,8L,7L,1L,8L,2L,8L,4L,8L,4L,5L,9L,5L,1L,7L,2L,3L,4L,3L,0L,4L,0L,7L,2L,7L,3L,9L,6L,0L,2L,3L,0L,5L,2L,5L,6L,7L,0L,1L,3L,6L,4L,0L,4L,5L,8L,0L,2L,3L,7L,7L,9L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110544Inst : IEnumerable<long>
{
public static readonly long[] Value=A110544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110544.Bytes);
public long this[int i]=>Value[i];

public static A110544Inst Instance=new A110544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110545
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,3L,6L,8L,9L,5L,3L,4L,12L,7L,5L,16L,16L,9L,18L,5L,9L,11L,22L,9L,4L,13L,27L,7L,13L,5L,30L,32L,7L,17L,7L,9L,17L,19L,13L,8L,40L,9L,13L,11L,9L,23L,46L,16L,6L,25L,17L,13L,22L,27L,11L,8L,19L,29L,58L,5L,10L,31L,9L,64L,13L,11L,66L,17L,22L,7L,70L,9L,72L,37L,25L,19L,11L,13L,78L,16L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110545Inst : IEnumerable<long>
{
public static readonly long[] Value=A110545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110545.Bytes);
public long this[int i]=>Value[i];

public static A110545Inst Instance=new A110545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110546
{
public static readonly long[] Value={ 60L,90L,108L,120L,135L,140L,144L,150L,156L,160L,162L,165L,168L,170L,171L,172L,174L,175L,176L,177L,178L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110546Inst : IEnumerable<long>
{
public static readonly long[] Value=A110546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110546.Bytes);
public long this[int i]=>Value[i];

public static A110546Inst Instance=new A110546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110547
{
public static readonly long[] Value={ 7L,11L,13L,14L,16L,17L,19L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110547Inst : IEnumerable<long>
{
public static readonly long[] Value=A110547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110547.Bytes);
public long this[int i]=>Value[i];

public static A110547Inst Instance=new A110547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110548
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,25L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110548Inst : IEnumerable<long>
{
public static readonly long[] Value=A110548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110548.Bytes);
public long this[int i]=>Value[i];

public static A110548Inst Instance=new A110548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110549
{
public static readonly long[] Value={ 1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L,1L,2L,4L,3L,3L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110549Inst : IEnumerable<long>
{
public static readonly long[] Value=A110549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110549.Bytes);
public long this[int i]=>Value[i];

public static A110549Inst Instance=new A110549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110550
{
public static readonly long[] Value={ 1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L,1L,3L,2L,4L,4L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110550Inst : IEnumerable<long>
{
public static readonly long[] Value=A110550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110550.Bytes);
public long this[int i]=>Value[i];

public static A110550Inst Instance=new A110550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110551
{
public static readonly long[] Value={ 1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110551Inst : IEnumerable<long>
{
public static readonly long[] Value=A110551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110551.Bytes);
public long this[int i]=>Value[i];

public static A110551Inst Instance=new A110551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110552
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,4L,1L,10L,17L,8L,1L,19L,51L,49L,16L,1L,36L,134L,196L,129L,32L,1L,69L,330L,650L,645L,321L,64L,1L,134L,783L,1940L,2575L,1926L,769L,128L,1L,263L,1813L,5411L,8995L,8981L,5383L,1793L,256L,1L,520L,4124L,14392L,28742L,35896L,28700L,14344L,4097L,512L,1L,1033L,9252L,36948L,86142L,129150L,129108L,86052L,36873L,9217L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110552Inst : IEnumerable<long>
{
public static readonly long[] Value=A110552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110552.Bytes);
public long this[int i]=>Value[i];

public static A110552Inst Instance=new A110552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110553
{
public static readonly long[] Value={ 9L,284L,3004L,19078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110553Inst : IEnumerable<long>
{
public static readonly long[] Value=A110553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110553.Bytes);
public long this[int i]=>Value[i];

public static A110553Inst Instance=new A110553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110554
{
public static readonly long[] Value={ 56L,285L,954L,2366L,4711L,7936L,11712L,15448L,18450L,20155L,20329L,19078L,16746L,13780L,10644L,7712L,5235L,3325L,1970L,1081L,544L,247L,99L,33L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110554Inst : IEnumerable<long>
{
public static readonly long[] Value=A110554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110554.Bytes);
public long this[int i]=>Value[i];

public static A110554Inst Instance=new A110554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110555
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,1L,0L,1L,-3L,3L,-1L,0L,1L,-4L,6L,-4L,1L,0L,1L,-5L,10L,-10L,5L,-1L,0L,1L,-6L,15L,-20L,15L,-6L,1L,0L,1L,-7L,21L,-35L,35L,-21L,7L,-1L,0L,1L,-8L,28L,-56L,70L,-56L,28L,-8L,1L,0L,1L,-9L,36L,-84L,126L,-126L,84L,-36L,9L,-1L,0L,1L,-10L,45L,-120L,210L,-252L,210L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110555Inst : IEnumerable<long>
{
public static readonly long[] Value=A110555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110555.Bytes);
public long this[int i]=>Value[i];

public static A110555Inst Instance=new A110555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110556
{
public static readonly long[] Value={ 1L,-1L,3L,-10L,35L,-126L,462L,-1716L,6435L,-24310L,92378L,-352716L,1352078L,-5200300L,20058300L,-77558760L,300540195L,-1166803110L,4537567650L,-17672631900L,68923264410L,-269128937220L,1052049481860L,-4116715363800L,16123801841550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110556Inst : IEnumerable<long>
{
public static readonly long[] Value=A110556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110556.Bytes);
public long this[int i]=>Value[i];

public static A110556Inst Instance=new A110556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110557
{
public static readonly long[] Value={ 1L,15L,157L,170L,175L,181L,183L,186L,193L,223L,232L,282L,286L,294L,374L,390L,478L,550L,970L,1066L,2046L,2124L,2180L,3147L,3165L,3240L,3277L,3346L,3826L,3899L,3916L,3982L,4061L,4798L,5788L,6520L,6567L,6651L,6713L,6723L,6793L,6831L,7681L,8068L,8121L,8164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110557Inst : IEnumerable<long>
{
public static readonly long[] Value=A110557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110557.Bytes);
public long this[int i]=>Value[i];

public static A110557Inst Instance=new A110557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110558
{
public static readonly long[] Value={ 8L,12L,16L,24L,28L,32L,40L,44L,52L,60L,68L,72L,84L,88L,96L,100L,112L,136L,144L,152L,156L,164L,168L,172L,180L,184L,196L,200L,208L,224L,236L,248L,252L,256L,276L,292L,304L,320L,324L,340L,348L,364L,368L,380L,392L,408L,432L,436L,448L,452L,460L,472L,500L,504L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110558Inst : IEnumerable<long>
{
public static readonly long[] Value=A110558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110558.Bytes);
public long this[int i]=>Value[i];

public static A110558Inst Instance=new A110558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110559
{
public static readonly long[] Value={ 4L,1L,2L,12L,6L,2L,18L,3L,10L,6L,12L,3L,12L,18L,18L,57L,12L,5L,120L,12L,2L,3L,132L,2L,42L,3L,58L,45L,12L,7L,72L,15L,10L,3L,6L,2L,60L,30L,12L,3L,168L,2L,192L,18L,2L,33L,48L,10L,138L,39L,8L,63L,42L,22L,60L,42L,32L,3L,120L,6L,90L,18L,40L,165L,204L,7L,90L,18L,70L,6L,72L,27L,30L,15L,6L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110559Inst : IEnumerable<long>
{
public static readonly long[] Value=A110559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110559.Bytes);
public long this[int i]=>Value[i];

public static A110559Inst Instance=new A110559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110560
{
public static readonly long[] Value={ 1L,3L,3L,5L,5L,7L,7L,1L,1L,11L,11L,13L,13L,1L,1L,17L,17L,19L,19L,1L,1L,23L,23L,1L,1L,1L,1L,29L,29L,31L,31L,1L,1L,1L,1L,37L,37L,1L,1L,41L,41L,43L,43L,1L,1L,47L,47L,1L,1L,1L,1L,53L,53L,1L,1L,1L,1L,59L,59L,61L,61L,1L,1L,1L,1L,67L,67L,1L,1L,71L,71L,73L,73L,1L,1L,1L,1L,79L,79L,1L,1L,83L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110560Inst : IEnumerable<long>
{
public static readonly long[] Value=A110560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110560.Bytes);
public long this[int i]=>Value[i];

public static A110560Inst Instance=new A110560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110561
{
public static readonly long[] Value={ 1L,1L,1L,3L,8L,40L,180L,140L,896L,72576L,604800L,6652800L,68428800L,59304960L,726485760L,163459296000L,2324754432000L,39520825344000L,640237370572800L,579262382899200L,10532043325440000L,4644631106519040000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110561Inst : IEnumerable<long>
{
public static readonly long[] Value=A110561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110561.Bytes);
public long this[int i]=>Value[i];

public static A110561Inst Instance=new A110561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110562
{
public static readonly long[] Value={ 32L,65L,96L,130L,131L,160L,193L,224L,260L,261L,262L,263L,288L,321L,352L,386L,387L,416L,449L,480L,520L,521L,522L,523L,524L,525L,526L,527L,544L,577L,608L,642L,643L,672L,705L,736L,772L,773L,774L,775L,800L,833L,864L,898L,899L,928L,961L,992L,1040L,1041L,1042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110562Inst : IEnumerable<long>
{
public static readonly long[] Value=A110562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110562.Bytes);
public long this[int i]=>Value[i];

public static A110562Inst Instance=new A110562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110563
{
public static readonly long[] Value={ 37L,43L,53L,57L,58L,61L,65L,77L,79L,82L,83L,88L,89L,91L,92L,99L,101L,102L,106L,112L,117L,118L,121L,122L,123L,124L,128L,129L,130L,131L,135L,136L,138L,141L,142L,143L,145L,148L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110563Inst : IEnumerable<long>
{
public static readonly long[] Value=A110563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110563.Bytes);
public long this[int i]=>Value[i];

public static A110563Inst Instance=new A110563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110564
{
public static readonly long[] Value={ 0L,2L,2L,1L,3L,6L,18L,7L,1L,10L,1L,3L,1L,39L,6L,1L,1L,7L,1L,2L,1L,7L,2L,1L,1L,1L,5L,29L,14L,7L,2L,1L,1L,4L,1L,11L,932L,1L,2L,1L,1L,2L,10L,3L,1L,4L,1L,1L,4L,1L,2L,7L,1L,1L,1L,6L,1L,2L,1L,1L,1L,1L,1L,5L,1L,38L,1L,5L,1L,3L,1L,3L,10L,1L,1L,5L,1L,14L,1L,17L,6L,1L,3L,2L,5L,1L,1L,7L,1L,25L,1L,2L,3L,1L,2L,7L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110564Inst : IEnumerable<long>
{
public static readonly long[] Value=A110564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110564.Bytes);
public long this[int i]=>Value[i];

public static A110564Inst Instance=new A110564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110565
{
public static readonly long[] Value={ 1L,3L,4L,14L,21L,53L,69L,237L,321L,867L,1044L,3638L,5441L,13667L,17684L,60854L,81921L,221187L,266244L,931854L,1397781L,3495477L,4542789L,15555437L,21053441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110565Inst : IEnumerable<long>
{
public static readonly long[] Value=A110565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110565.Bytes);
public long this[int i]=>Value[i];

public static A110565Inst Instance=new A110565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110566
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,15L,45L,45L,45L,15L,3L,3L,1L,1L,1L,1L,1L,1L,11L,11L,11L,11L,11L,11L,11L,11L,11L,77L,77L,7L,7L,7L,7L,7L,1L,1L,1L,1L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,9L,9L,9L,27L,27L,27L,9L,9L,9L,3L,3L,3L,3L,3L,33L,33L,33L,33L,11L,11L,11L,11L,11L,11L,11L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110566Inst : IEnumerable<long>
{
public static readonly long[] Value=A110566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110566.Bytes);
public long this[int i]=>Value[i];

public static A110566Inst Instance=new A110566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110567
{
public static readonly BigInteger[] Value={ 9L,82L,1025L,15626L,279937L,5764802L,134217729L,3486784402L,100000000001L,3138428376722L,106993205379073L,3937376385699290L,155568095557812225L,6568408355712890626L,BigInteger.Parse("295147905179352825857") };
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
public class A110567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110567Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110567.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110567Inst Instance=new A110567Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110568
{
public static readonly long[] Value={ 1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110568Inst : IEnumerable<long>
{
public static readonly long[] Value=A110568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110568.Bytes);
public long this[int i]=>Value[i];

public static A110568Inst Instance=new A110568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110569
{
public static readonly long[] Value={ 2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110569Inst : IEnumerable<long>
{
public static readonly long[] Value=A110569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110569.Bytes);
public long this[int i]=>Value[i];

public static A110569Inst Instance=new A110569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110570
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,2L,4L,1L,1L,5L,4L,4L,5L,1L,1L,6L,3L,2L,3L,6L,1L,1L,7L,5L,5L,5L,5L,7L,1L,1L,8L,4L,5L,2L,5L,4L,8L,1L,1L,9L,6L,3L,6L,6L,3L,6L,9L,1L,1L,10L,5L,6L,4L,2L,4L,6L,5L,10L,1L,1L,11L,7L,6L,6L,7L,7L,6L,6L,7L,11L,1L,1L,12L,6L,4L,3L,6L,2L,6L,3L,4L,6L,12L,1L,1L,13L,8L,7L,7L,6L,8L,8L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110570Inst : IEnumerable<long>
{
public static readonly long[] Value=A110570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110570.Bytes);
public long this[int i]=>Value[i];

public static A110570Inst Instance=new A110570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110571
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,20L,22L,36L,38L,50L,54L,76L,66L,100L,94L,106L,116L,152L,128L,180L,154L,182L,194L,240L,192L,258L,250L,272L,262L,340L,264L,376L,330L,362L,374L,402L,352L,488L,442L,462L,428L,564L,444L,604L,518L,536L,586L,684L,534L,698L,620L,686L,662L,812L,658L,782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110571Inst : IEnumerable<long>
{
public static readonly long[] Value=A110571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110571.Bytes);
public long this[int i]=>Value[i];

public static A110571Inst Instance=new A110571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110572
{
public static readonly long[] Value={ 7L,11L,29L,41L,47L,79L,89L,109L,119L,143L,167L,209L,221L,251L,253L,257L,277L,287L,293L,301L,307L,337L,349L,361L,383L,391L,419L,421L,439L,461L,487L,491L,521L,523L,557L,589L,593L,637L,661L,671L,677L,683L,691L,697L,707L,739L,743L,761L,767L,823L,827L,829L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110572Inst : IEnumerable<long>
{
public static readonly long[] Value=A110572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110572.Bytes);
public long this[int i]=>Value[i];

public static A110572Inst Instance=new A110572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110573
{
public static readonly long[] Value={ 1L,17L,29L,43L,53L,83L,97L,109L,119L,139L,143L,167L,173L,187L,191L,203L,229L,233L,269L,277L,301L,329L,353L,403L,427L,431L,433L,437L,439L,461L,467L,493L,511L,527L,529L,541L,557L,559L,599L,607L,637L,643L,647L,649L,667L,671L,683L,697L,707L,727L,733L,737L,749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110573Inst : IEnumerable<long>
{
public static readonly long[] Value=A110573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110573.Bytes);
public long this[int i]=>Value[i];

public static A110573Inst Instance=new A110573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110574
{
public static readonly BigInteger[] Value={ 1L,11L,1101L,1101001L,11010011L,11010011001L,1101001100101L,11010011001011L,1101001100101101L,1101001100101101001L,BigInteger.Parse("110100110010110100101"),BigInteger.Parse("1101001100101101001011"),BigInteger.Parse("1101001100101101001011001") };
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
public class A110574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110574Inst Instance=new A110574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110575
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,23L,171L,399L,819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110575Inst : IEnumerable<long>
{
public static readonly long[] Value=A110575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110575.Bytes);
public long this[int i]=>Value[i];

public static A110575Inst Instance=new A110575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110576
{
public static readonly long[] Value={ 1L,1L,2L,7L,29L,132L,648L,3407L,19109L,113946L,719896L,4802318L,33712717L,248285282L,1912928549L,15379305080L,128729241725L,1119519156562L,10097102345993L,94285391374568L,910145431036423L,9069616636456648L,93179779321299479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110576Inst : IEnumerable<long>
{
public static readonly long[] Value=A110576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110576.Bytes);
public long this[int i]=>Value[i];

public static A110576Inst Instance=new A110576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110577
{
public static readonly long[] Value={ 1L,2L,4L,11L,40L,172L,820L,4227L,23336L,137282L,857178L,5659496L,39372213L,287657495L,2200586044L,17579891124L,146309132849L,1265828289411L,11362930635404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110577Inst : IEnumerable<long>
{
public static readonly long[] Value=A110577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110577.Bytes);
public long this[int i]=>Value[i];

public static A110577Inst Instance=new A110577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110578
{
public static readonly long[] Value={ 1L,3L,7L,18L,58L,230L,1050L,5277L,28613L,165895L,1023073L,6682569L,46054782L,333712277L,2534298321L,20114189445L,166423322294L,1432251611705L,12795182247109L,118443504257081L,1134237257303476L,11219647646806519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110578Inst : IEnumerable<long>
{
public static readonly long[] Value=A110578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110578.Bytes);
public long this[int i]=>Value[i];

public static A110578Inst Instance=new A110578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110579
{
public static readonly long[] Value={ 1L,4L,11L,29L,87L,317L,1367L,6644L,35257L,201152L,1224225L,7906794L,53961576L,387673853L,2921972174L,23036161619L,189459483913L,1621711095618L,14416893342727L,132860397599808L,1267097654903284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110579Inst : IEnumerable<long>
{
public static readonly long[] Value=A110579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110579.Bytes);
public long this[int i]=>Value[i];

public static A110579Inst Instance=new A110579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110580
{
public static readonly long[] Value={ 1L,5L,16L,45L,132L,449L,1816L,8460L,43717L,244869L,1469094L,9375888L,63337464L,451011317L,3372983491L,26409145110L,215868629023L,1837579724641L,16254473067368L,149114870667176L,1416212525570460L,13902957827280263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110580Inst : IEnumerable<long>
{
public static readonly long[] Value=A110580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110580.Bytes);
public long this[int i]=>Value[i];

public static A110580Inst Instance=new A110580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110581
{
public static readonly long[] Value={ 3L,7L,31L,37L,97L,139L,157L,199L,211L,229L,271L,307L,337L,367L,379L,547L,577L,601L,607L,661L,691L,727L,811L,877L,937L,967L,997L,1009L,1171L,1237L,1297L,1399L,1429L,1459L,1609L,1627L,1657L,1759L,1867L,2011L,2029L,2137L,2221L,2281L,2467L,2539L,2551L,2557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110581Inst : IEnumerable<long>
{
public static readonly long[] Value=A110581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110581.Bytes);
public long this[int i]=>Value[i];

public static A110581Inst Instance=new A110581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110582
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,4L,3L,4L,1L,4L,7L,4L,5L,1L,6L,10L,10L,5L,6L,1L,6L,14L,16L,13L,6L,7L,1L,8L,18L,26L,22L,16L,7L,8L,1L,8L,25L,34L,38L,28L,19L,8L,9L,1L,10L,29L,52L,55L,50L,34L,22L,9L,10L,1L,10L,37L,66L,84L,76L,62L,40L,25L,10L,11L,1L,12L,44L,90L,116L,122L,97L,74L,46L,28L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110582Inst : IEnumerable<long>
{
public static readonly long[] Value=A110582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110582.Bytes);
public long this[int i]=>Value[i];

public static A110582Inst Instance=new A110582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110583
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,43L,53L,61L,67L,73L,83L,97L,103L,109L,133L,143L,157L,161L,163L,179L,203L,211L,247L,257L,263L,271L,287L,313L,319L,323L,359L,361L,373L,389L,397L,409L,413L,427L,431L,443L,451L,457L,469L,479L,493L,499L,533L,541L,557L,623L,631L,637L,653L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110583Inst : IEnumerable<long>
{
public static readonly long[] Value=A110583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110583.Bytes);
public long this[int i]=>Value[i];

public static A110583Inst Instance=new A110583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110584
{
public static readonly long[] Value={ 23L,29L,61L,71L,89L,91L,101L,133L,149L,169L,181L,199L,217L,221L,233L,239L,269L,287L,307L,329L,331L,359L,371L,377L,389L,431L,433L,437L,451L,491L,499L,521L,529L,541L,553L,563L,599L,611L,613L,623L,631L,653L,667L,671L,683L,721L,727L,749L,763L,769L,773L,809L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110584Inst : IEnumerable<long>
{
public static readonly long[] Value=A110584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110584.Bytes);
public long this[int i]=>Value[i];

public static A110584Inst Instance=new A110584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110585
{
public static readonly long[] Value={ 1L,3L,7L,16L,29L,44L,65L,89L,120L,155L,192L,236L,282L,332L,390L,453L,520L,589L,666L,746L,832L,927L,1026L,1131L,1239L,1350L,1467L,1592L,1725L,1867L,2017L,2161L,2313L,2469L,2634L,2800L,2975L,3155L,3339L,3532L,3729L,3931L,4143L,4356L,4579L,4809L,5051L,5291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110585Inst : IEnumerable<long>
{
public static readonly long[] Value=A110585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110585.Bytes);
public long this[int i]=>Value[i];

public static A110585Inst Instance=new A110585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110586
{
public static readonly long[] Value={ 25L,49L,121L,289L,361L,841L,1369L,1849L,2209L,2809L,3721L,5041L,5329L,6241L,7921L,9409L,10201L,11449L,11881L,16129L,29929L,36481L,39601L,49729L,58081L,63001L,69169L,73441L,78961L,100489L,134689L,151321L,157609L,187489L,192721L,196249L,201601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110586Inst : IEnumerable<long>
{
public static readonly long[] Value=A110586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110586.Bytes);
public long this[int i]=>Value[i];

public static A110586Inst Instance=new A110586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110587
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,29L,37L,43L,47L,53L,61L,71L,73L,79L,89L,97L,101L,107L,109L,127L,173L,191L,199L,223L,241L,251L,263L,271L,281L,317L,367L,389L,397L,433L,439L,443L,449L,457L,461L,479L,523L,541L,569L,577L,587L,613L,631L,647L,659L,677L,683L,691L,701L,739L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110587Inst : IEnumerable<long>
{
public static readonly long[] Value=A110587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110587.Bytes);
public long this[int i]=>Value[i];

public static A110587Inst Instance=new A110587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110588
{
public static readonly long[] Value={ 9L,25L,49L,121L,169L,361L,529L,841L,961L,1369L,1681L,2209L,4489L,5329L,6241L,9409L,10201L,10609L,11881L,22801L,24649L,38809L,44521L,51529L,54289L,57121L,66049L,69169L,85849L,94249L,109561L,113569L,121801L,124609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110588Inst : IEnumerable<long>
{
public static readonly long[] Value=A110588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110588.Bytes);
public long this[int i]=>Value[i];

public static A110588Inst Instance=new A110588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110589
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,23L,29L,31L,37L,41L,47L,67L,73L,79L,97L,101L,103L,109L,151L,157L,197L,211L,227L,233L,239L,257L,263L,293L,307L,331L,337L,349L,353L,359L,367L,389L,397L,409L,443L,449L,463L,487L,491L,509L,521L,547L,569L,571L,587L,613L,619L,653L,661L,673L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110589Inst : IEnumerable<long>
{
public static readonly long[] Value=A110589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110589.Bytes);
public long this[int i]=>Value[i];

public static A110589Inst Instance=new A110589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110590
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,14L,15L,30L,264L,3828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110590Inst : IEnumerable<long>
{
public static readonly long[] Value=A110590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110590.Bytes);
public long this[int i]=>Value[i];

public static A110590Inst Instance=new A110590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110591
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110591Inst : IEnumerable<long>
{
public static readonly long[] Value=A110591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110591.Bytes);
public long this[int i]=>Value[i];

public static A110591Inst Instance=new A110591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110592
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110592Inst : IEnumerable<long>
{
public static readonly long[] Value=A110592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110592.Bytes);
public long this[int i]=>Value[i];

public static A110592Inst Instance=new A110592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110593
{
public static readonly long[] Value={ 3L,6L,18L,54L,162L,486L,1458L,4374L,13122L,39366L,118098L,354294L,1062882L,3188646L,9565938L,28697814L,86093442L,258280326L,774840978L,2324522934L,6973568802L,20920706406L,62762119218L,188286357654L,564859072962L,1694577218886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110593Inst : IEnumerable<long>
{
public static readonly long[] Value=A110593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110593.Bytes);
public long this[int i]=>Value[i];

public static A110593Inst Instance=new A110593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110594
{
public static readonly long[] Value={ 4L,12L,48L,192L,768L,3072L,12288L,49152L,196608L,786432L,3145728L,12582912L,50331648L,201326592L,805306368L,3221225472L,12884901888L,51539607552L,206158430208L,824633720832L,3298534883328L,13194139533312L,52776558133248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110594Inst : IEnumerable<long>
{
public static readonly long[] Value=A110594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110594.Bytes);
public long this[int i]=>Value[i];

public static A110594Inst Instance=new A110594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110595
{
public static readonly long[] Value={ 5L,20L,100L,500L,2500L,12500L,62500L,312500L,1562500L,7812500L,39062500L,195312500L,976562500L,4882812500L,24414062500L,122070312500L,610351562500L,3051757812500L,15258789062500L,76293945312500L,381469726562500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110595Inst : IEnumerable<long>
{
public static readonly long[] Value=A110595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110595.Bytes);
public long this[int i]=>Value[i];

public static A110595Inst Instance=new A110595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110596
{
public static readonly long[] Value={ 35L,124355L,1739507L,3281663L,3852155L,7649915L,9815195L,10434515L,13321295L,19154135L,19296035L,32807555L,36664595L,41523911L,50329955L,60668135L,69664595L,83338199L,107008811L,123543695L,145960451L,275361359L,321198059L,365269355L,393656879L,407002211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110596Inst : IEnumerable<long>
{
public static readonly long[] Value=A110596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110596.Bytes);
public long this[int i]=>Value[i];

public static A110596Inst Instance=new A110596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110597
{
public static readonly long[] Value={ 1L,1045L,29029L,50065L,64285L,87685L,1390753L,2011009L,3189625L,7711405L,39298441L,53238625L,68393065L,75416341L,96345613L,225938245L,228404605L,231562825L,233591605L,279999445L,458406445L,462027565L,470527057L,491291125L,513574369L,663605761L,666373825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110597Inst : IEnumerable<long>
{
public static readonly long[] Value=A110597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110597.Bytes);
public long this[int i]=>Value[i];

public static A110597Inst Instance=new A110597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110598
{
public static readonly long[] Value={ 137885L,145145L,3501605L,6605945L,6953765L,8409305L,10055045L,11413205L,11569805L,16540205L,18545285L,19648805L,21902705L,22806905L,25965005L,26655005L,29811665L,45680921L,71569745L,79989845L,91681289L,196492205L,214218389L,223086125L,229554941L,233601641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110598Inst : IEnumerable<long>
{
public static readonly long[] Value=A110598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110598.Bytes);
public long this[int i]=>Value[i];

public static A110598Inst Instance=new A110598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110599
{
public static readonly long[] Value={ 24871L,58435L,140335L,1529983L,2086903L,3722875L,3830827L,8697535L,13932919L,16408315L,21578755L,27882595L,76319155L,126245119L,183531439L,192871987L,198394675L,207619555L,229523371L,337800463L,361504507L,416690995L,440127655L,535044055L,693298315L,729802255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110599Inst : IEnumerable<long>
{
public static readonly long[] Value=A110599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110599.Bytes);
public long this[int i]=>Value[i];

public static A110599Inst Instance=new A110599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110600
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,73L,97L,109L,577L,1489L,7537L,17401L,226201L,1097113L,32555521L,388177921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110600Inst : IEnumerable<long>
{
public static readonly long[] Value=A110600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110600.Bytes);
public long this[int i]=>Value[i];

public static A110600Inst Instance=new A110600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110601
{
public static readonly long[] Value={ 1L,4L,8L,18L,16L,32L,24L,64L,54L,64L,40L,144L,48L,96L,128L,200L,64L,216L,72L,288L,192L,160L,88L,512L,180L,192L,288L,432L,112L,512L,120L,576L,320L,256L,384L,972L,144L,288L,384L,1024L,160L,768L,168L,720L,864L,352L,184L,1600L,378L,720L,512L,864L,208L,1152L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110601Inst : IEnumerable<long>
{
public static readonly long[] Value=A110601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110601.Bytes);
public long this[int i]=>Value[i];

public static A110601Inst Instance=new A110601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110602
{
public static readonly long[] Value={ 4L,9L,10L,15L,21L,25L,26L,27L,31L,33L,34L,35L,39L,41L,49L,50L,51L,57L,59L,67L,69L,81L,85L,89L,95L,98L,99L,101L,119L,122L,127L,137L,141L,143L,145L,146L,147L,154L,155L,161L,173L,178L,185L,187L,199L,202L,205L,209L,211L,215L,221L,223L,226L,235L,239L,257L,259L,265L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110602Inst : IEnumerable<long>
{
public static readonly long[] Value=A110602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110602.Bytes);
public long this[int i]=>Value[i];

public static A110602Inst Instance=new A110602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110603
{
public static readonly long[] Value={ 4L,5L,9L,11L,12L,18L,19L,31L,36L,37L,38L,43L,44L,46L,47L,48L,51L,52L,53L,58L,59L,61L,76L,77L,78L,84L,86L,88L,94L,96L,103L,106L,108L,112L,128L,131L,146L,147L,148L,151L,156L,159L,161L,168L,171L,172L,177L,178L,181L,184L,194L,196L,198L,208L,212L,218L,223L,226L,227L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110603Inst : IEnumerable<long>
{
public static readonly long[] Value=A110603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110603.Bytes);
public long this[int i]=>Value[i];

public static A110603Inst Instance=new A110603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110604
{
public static readonly long[] Value={ 4L,6L,10L,11L,13L,14L,17L,21L,22L,23L,31L,35L,43L,47L,49L,50L,51L,57L,58L,61L,62L,63L,65L,71L,73L,74L,75L,77L,81L,82L,83L,85L,95L,105L,106L,109L,110L,111L,113L,118L,121L,123L,130L,131L,133L,143L,147L,151L,153L,155L,158L,173L,175L,177L,178L,181L,182L,185L,187L,190L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110604Inst : IEnumerable<long>
{
public static readonly long[] Value=A110604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110604.Bytes);
public long this[int i]=>Value[i];

public static A110604Inst Instance=new A110604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110605
{
public static readonly long[] Value={ 4L,6L,7L,11L,12L,15L,16L,19L,20L,24L,25L,26L,34L,36L,40L,44L,47L,55L,57L,61L,64L,65L,66L,73L,74L,78L,79L,80L,82L,83L,89L,92L,97L,99L,100L,101L,103L,104L,108L,109L,110L,113L,118L,124L,136L,137L,142L,145L,148L,149L,150L,152L,158L,162L,164L,167L,172L,173L,176L,181L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110605Inst : IEnumerable<long>
{
public static readonly long[] Value=A110605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110605.Bytes);
public long this[int i]=>Value[i];

public static A110605Inst Instance=new A110605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110606
{
public static readonly long[] Value={ 4L,6L,8L,12L,13L,17L,18L,21L,22L,27L,28L,29L,38L,41L,45L,47L,50L,53L,60L,63L,70L,73L,77L,81L,82L,83L,91L,92L,97L,98L,99L,101L,102L,109L,113L,118L,127L,129L,130L,131L,133L,134L,139L,140L,141L,143L,145L,150L,157L,159L,167L,171L,172L,178L,181L,183L,188L,193L,194L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110606Inst : IEnumerable<long>
{
public static readonly long[] Value=A110606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110606.Bytes);
public long this[int i]=>Value[i];

public static A110606Inst Instance=new A110606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110607
{
public static readonly long[] Value={ 4L,6L,9L,13L,14L,19L,20L,23L,24L,30L,31L,32L,35L,42L,46L,50L,52L,53L,56L,59L,67L,70L,74L,77L,78L,79L,87L,91L,95L,98L,100L,101L,102L,111L,112L,118L,119L,120L,122L,123L,131L,134L,136L,141L,151L,152L,156L,158L,160L,163L,164L,165L,167L,168L,174L,175L,176L,178L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110607Inst : IEnumerable<long>
{
public static readonly long[] Value=A110607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110607.Bytes);
public long this[int i]=>Value[i];

public static A110607Inst Instance=new A110607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110608
{
public static readonly long[] Value={ 1L,2L,1L,6L,8L,1L,20L,45L,18L,1L,70L,224L,168L,32L,1L,252L,1050L,1200L,450L,50L,1L,924L,4752L,7425L,4400L,990L,72L,1L,3432L,21021L,42042L,35035L,12740L,1911L,98L,1L,12870L,91520L,224224L,244608L,127400L,31360L,3360L,128L,1L,48620L,393822L,1145664L,1559376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110608Inst : IEnumerable<long>
{
public static readonly long[] Value=A110608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110608.Bytes);
public long this[int i]=>Value[i];

public static A110608Inst Instance=new A110608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110609
{
public static readonly long[] Value={ 0L,1L,8L,45L,224L,1050L,4752L,21021L,91520L,393822L,1679600L,7113106L,29953728L,125550100L,524190240L,2181340125L,9051563520L,37467344310L,154754938800L,637982011590L,2625648168000L,10789623755820L,44277560801760L,181478535620850L,742984788858624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110609Inst : IEnumerable<long>
{
public static readonly long[] Value=A110609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110609.Bytes);
public long this[int i]=>Value[i];

public static A110609Inst Instance=new A110609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110610
{
public static readonly long[] Value={ 1L,4L,11L,25L,48L,82L,129L,191L,270L,368L,487L,629L,796L,990L,1213L,1467L,1754L,2076L,2435L,2833L,3272L,3754L,4281L,4855L,5478L,6152L,6879L,7661L,8500L,9398L,10357L,11379L,12466L,13620L,14843L,16137L,17504L,18946L,20465L,22063L,23742L,25504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110610Inst : IEnumerable<long>
{
public static readonly long[] Value=A110610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110610.Bytes);
public long this[int i]=>Value[i];

public static A110610Inst Instance=new A110610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110611
{
public static readonly long[] Value={ 1L,4L,11L,21L,37L,58L,87L,123L,169L,224L,291L,369L,461L,566L,687L,823L,977L,1148L,1339L,1549L,1781L,2034L,2311L,2611L,2937L,3288L,3667L,4073L,4509L,4974L,5471L,5999L,6561L,7156L,7787L,8453L,9157L,9898L,10679L,11499L,12361L,13264L,14211L,15201L,16237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110611Inst : IEnumerable<long>
{
public static readonly long[] Value=A110611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110611.Bytes);
public long this[int i]=>Value[i];

public static A110611Inst Instance=new A110611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110612
{
public static readonly long[] Value={ 30L,420L,27720L,1531530L,58198140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110612Inst : IEnumerable<long>
{
public static readonly long[] Value=A110612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110612.Bytes);
public long this[int i]=>Value[i];

public static A110612Inst Instance=new A110612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110613
{
public static readonly long[] Value={ 1L,0L,3L,7L,29L,107L,421L,1659L,6597L,26299L,105029L,419771L,1678405L,6712251L,26846277L,107379643L,429507653L,1718008763L,6871991365L,27487878075L,109951337541L,439805000635L,1759219303493L,7036875815867L,28147500467269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110613Inst : IEnumerable<long>
{
public static readonly long[] Value=A110613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110613.Bytes);
public long this[int i]=>Value[i];

public static A110613Inst Instance=new A110613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110614
{
public static readonly long[] Value={ 1L,5L,15L,57L,215L,841L,3319L,13193L,52599L,210057L,839543L,3356809L,13424503L,53692553L,214759287L,859015305L,3436017527L,13743982729L,54975756151L,219902675081L,879610001271L,3518438606985L,14073751631735L,56295000934537L,225179992553335L,900719947843721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110614Inst : IEnumerable<long>
{
public static readonly long[] Value=A110614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110614.Bytes);
public long this[int i]=>Value[i];

public static A110614Inst Instance=new A110614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110615
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,24L,25L,26L,27L,35L,36L,38L,39L,60L,62L,63L,65L,84L,85L,86L,87L,91L,95L,132L,133L,134L,135L,143L,161L,205L,215L,355L,377L,445L,451L,455L,493L,1651L,1673L,1885L,1891L,1895L,8797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110615Inst : IEnumerable<long>
{
public static readonly long[] Value=A110615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110615.Bytes);
public long this[int i]=>Value[i];

public static A110615Inst Instance=new A110615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110616
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,12L,7L,3L,1L,55L,30L,12L,4L,1L,273L,143L,55L,18L,5L,1L,1428L,728L,273L,88L,25L,6L,1L,7752L,3876L,1428L,455L,130L,33L,7L,1L,43263L,21318L,7752L,2448L,700L,182L,42L,8L,1L,246675L,120175L,43263L,13566L,3876L,1020L,245L,52L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110616Inst : IEnumerable<long>
{
public static readonly long[] Value=A110616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110616.Bytes);
public long this[int i]=>Value[i];

public static A110616Inst Instance=new A110616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110617
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,5L,4L,9L,6L,1L,8L,7L,9L,3L,7L,7L,6L,7L,3L,0L,9L,2L,4L,1L,9L,2L,6L,4L,8L,6L,0L,8L,4L,4L,2L,3L,2L,3L,1L,8L,8L,4L,9L,5L,6L,3L,0L,0L,7L,5L,0L,0L,1L,5L,4L,9L,6L,1L,8L,7L,9L,3L,7L,7L,6L,7L,3L,0L,9L,2L,4L,1L,9L,2L,6L,4L,8L,6L,0L,8L,4L,4L,2L,3L,2L,3L,1L,8L,8L,4L,9L,5L,6L,3L,0L,0L,7L,5L,0L,0L,1L,5L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110617Inst : IEnumerable<long>
{
public static readonly long[] Value=A110617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110617.Bytes);
public long this[int i]=>Value[i];

public static A110617Inst Instance=new A110617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110618
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,3L,7L,8L,15L,18L,30L,37L,58L,71L,105L,131L,186L,230L,318L,393L,530L,653L,863L,1060L,1380L,1686L,2164L,2637L,3345L,4057L,5096L,6158L,7665L,9228L,11395L,13671L,16765L,20040L,24418L,29098L,35251L,41869L,50460L,59755L,71669L,84626L,101050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110618Inst : IEnumerable<long>
{
public static readonly long[] Value=A110618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110618.Bytes);
public long this[int i]=>Value[i];

public static A110618Inst Instance=new A110618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110619
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,5L,3L,1L,1L,7L,3L,1L,1L,1L,11L,7L,4L,1L,1L,1L,15L,8L,4L,1L,1L,1L,1L,22L,15L,5L,5L,1L,1L,1L,1L,30L,18L,12L,5L,1L,1L,1L,1L,1L,42L,30L,14L,6L,6L,1L,1L,1L,1L,1L,56L,37L,16L,6L,6L,1L,1L,1L,1L,1L,1L,77L,58L,34L,19L,7L,7L,1L,1L,1L,1L,1L,1L,101L,71L,39L,21L,7L,7L,1L,1L,1L,1L,1L,1L,1L,135L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110619Inst : IEnumerable<long>
{
public static readonly long[] Value=A110619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110619.Bytes);
public long this[int i]=>Value[i];

public static A110619Inst Instance=new A110619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110620
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,6L,8L,0L,4L,0L,3L,4L,6L,0L,0L,6L,0L,5L,4L,0L,0L,8L,0L,4L,4L,4L,3L,4L,4L,5L,4L,4L,0L,6L,1L,2L,8L,2L,0L,6L,4L,8L,2L,2L,1L,6L,4L,6L,7L,3L,0L,0L,1L,4L,6L,4L,2L,12L,1L,0L,2L,4L,0L,6L,2L,0L,12L,1L,6L,4L,1L,8L,0L,2L,1L,6L,2L,0L,0L,1L,3L,16L,4L,3L,0L,2L,0L,8L,0L,6L,11L,4L,1L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110620Inst : IEnumerable<long>
{
public static readonly long[] Value=A110620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110620.Bytes);
public long this[int i]=>Value[i];

public static A110620Inst Instance=new A110620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110621
{
public static readonly long[] Value={ 1L,4L,18L,33L,42L,44L,50L,55L,90L,98L,195L,288L,311L,395L,457L,521L,859L,891L,898L,1848L,1876L,2717L,3688L,3757L,3796L,4733L,5243L,5301L,5321L,6295L,6389L,6434L,6526L,6556L,6634L,6650L,6690L,7318L,7938L,8027L,9013L,9293L,9327L,9409L,9462L,9883L,10053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110621Inst : IEnumerable<long>
{
public static readonly long[] Value=A110621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110621.Bytes);
public long this[int i]=>Value[i];

public static A110621Inst Instance=new A110621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110622
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,8L,16L,9L,3L,27L,81L,16L,4L,64L,256L,25L,5L,125L,625L,36L,6L,216L,1296L,49L,7L,343L,2401L,64L,8L,512L,4096L,81L,9L,729L,6561L,100L,10L,1000L,10000L,121L,11L,1331L,14641L,144L,12L,1728L,20736L,169L,13L,2197L,28561L,196L,14L,2744L,38416L,225L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110622Inst : IEnumerable<long>
{
public static readonly long[] Value=A110622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110622.Bytes);
public long this[int i]=>Value[i];

public static A110622Inst Instance=new A110622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110623
{
public static readonly long[] Value={ 1L,13L,16L,20L,25L,31L,38L,46L,55L,65L,76L,197L,511L,526L,687L,758L,839L,1759L,1761L,1883L,1906L,1930L,2182L,2244L,2316L,2398L,3328L,3641L,3874L,3908L,3943L,3979L,4016L,4399L,5339L,5380L,5422L,5465L,5509L,5554L,6018L,6092L,6176L,7126L,7177L,7229L,7282L,7336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110623Inst : IEnumerable<long>
{
public static readonly long[] Value=A110623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110623.Bytes);
public long this[int i]=>Value[i];

public static A110623Inst Instance=new A110623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110624
{
public static readonly long[] Value={ 2L,148L,2159L,16746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110624Inst : IEnumerable<long>
{
public static readonly long[] Value=A110624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110624.Bytes);
public long this[int i]=>Value[i];

public static A110624Inst Instance=new A110624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110625
{
public static readonly long[] Value={ 1L,1L,3L,101L,5807L,77801L,82949L,170636L,170636L,170636L,363113L,363113L,84848L,710567L,22435781L,3901243741L,27210449083L,1003538672911L,248595095590537L,10165684261926701L,438167567023512863L,439119040574907047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110625Inst : IEnumerable<long>
{
public static readonly long[] Value=A110625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110625.Bytes);
public long this[int i]=>Value[i];

public static A110625Inst Instance=new A110625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110626
{
public static readonly long[] Value={ 6L,6L,14L,504L,27720L,360360L,360360L,765765L,765765L,765765L,1601145L,1601145L,369495L,3061530L,94907430L,16703707680L,116925953760L,4326260289120L,1068586291412640L,43812037947918240L,1883917631760484320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110626Inst : IEnumerable<long>
{
public static readonly long[] Value=A110626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110626.Bytes);
public long this[int i]=>Value[i];

public static A110626Inst Instance=new A110626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110627
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110627Inst : IEnumerable<long>
{
public static readonly long[] Value=A110627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110627.Bytes);
public long this[int i]=>Value[i];

public static A110627Inst Instance=new A110627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110628
{
public static readonly long[] Value={ 1L,1L,3L,3L,1L,2L,2L,1L,2L,3L,2L,3L,3L,2L,2L,3L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,3L,1L,2L,1L,3L,1L,3L,1L,1L,1L,2L,2L,3L,3L,2L,3L,1L,2L,1L,3L,3L,2L,3L,3L,1L,2L,3L,3L,1L,3L,3L,2L,2L,2L,1L,2L,3L,3L,3L,3L,1L,2L,2L,3L,2L,1L,2L,2L,1L,2L,3L,3L,2L,2L,1L,1L,2L,1L,3L,2L,2L,2L,1L,3L,2L,2L,3L,3L,2L,3L,1L,1L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110628Inst : IEnumerable<long>
{
public static readonly long[] Value=A110628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110628.Bytes);
public long this[int i]=>Value[i];

public static A110628Inst Instance=new A110628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110629
{
public static readonly long[] Value={ 1L,3L,1L,3L,3L,2L,4L,3L,2L,3L,3L,4L,2L,2L,2L,1L,1L,4L,1L,3L,4L,3L,2L,2L,1L,1L,3L,4L,1L,1L,2L,3L,2L,2L,3L,4L,4L,1L,4L,4L,1L,4L,2L,3L,1L,2L,1L,4L,3L,3L,1L,4L,3L,3L,2L,3L,4L,2L,3L,4L,1L,2L,1L,3L,4L,3L,4L,1L,4L,2L,2L,3L,1L,4L,3L,2L,1L,4L,3L,4L,4L,2L,1L,4L,1L,4L,4L,2L,4L,4L,1L,3L,3L,4L,1L,1L,1L,4L,3L,2L,1L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110629Inst : IEnumerable<long>
{
public static readonly long[] Value=A110629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110629.Bytes);
public long this[int i]=>Value[i];

public static A110629Inst Instance=new A110629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110630
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,4L,3L,4L,3L,4L,2L,2L,4L,4L,3L,2L,2L,2L,3L,2L,3L,2L,4L,2L,2L,4L,2L,4L,2L,2L,1L,4L,1L,2L,4L,4L,1L,2L,3L,4L,4L,4L,3L,4L,2L,2L,2L,2L,1L,4L,1L,2L,3L,2L,4L,4L,1L,4L,1L,4L,2L,2L,3L,4L,2L,4L,2L,4L,3L,4L,4L,2L,4L,2L,1L,2L,4L,4L,4L,4L,1L,2L,4L,4L,2L,2L,3L,4L,1L,2L,2L,4L,1L,2L,4L,4L,3L,2L,3L,4L,1L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110630Inst : IEnumerable<long>
{
public static readonly long[] Value=A110630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110630.Bytes);
public long this[int i]=>Value[i];

public static A110630Inst Instance=new A110630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110631
{
public static readonly long[] Value={ 1L,1L,4L,3L,2L,4L,4L,2L,1L,5L,2L,1L,5L,1L,3L,2L,5L,3L,4L,4L,5L,4L,5L,2L,1L,5L,4L,1L,2L,5L,1L,5L,1L,1L,1L,2L,3L,4L,2L,2L,4L,3L,2L,5L,2L,3L,5L,1L,1L,2L,3L,3L,1L,1L,2L,2L,3L,4L,4L,1L,2L,1L,3L,4L,1L,4L,2L,3L,5L,4L,4L,3L,5L,3L,4L,2L,2L,4L,2L,2L,5L,3L,2L,4L,2L,5L,5L,5L,3L,5L,4L,4L,1L,3L,5L,1L,5L,5L,4L,3L,5L,2L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110631Inst : IEnumerable<long>
{
public static readonly long[] Value=A110631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110631.Bytes);
public long this[int i]=>Value[i];

public static A110631Inst Instance=new A110631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110632
{
public static readonly long[] Value={ 1L,6L,6L,3L,6L,2L,6L,4L,4L,6L,3L,2L,1L,2L,3L,1L,6L,6L,1L,2L,6L,4L,2L,4L,2L,6L,2L,4L,2L,6L,5L,2L,2L,1L,5L,3L,6L,6L,2L,5L,3L,1L,4L,5L,4L,6L,2L,4L,3L,1L,6L,2L,3L,3L,6L,4L,1L,6L,3L,2L,5L,3L,3L,3L,6L,6L,5L,4L,2L,5L,3L,2L,4L,3L,3L,2L,6L,6L,3L,1L,5L,3L,6L,2L,4L,2L,6L,5L,4L,3L,3L,1L,4L,2L,4L,3L,3L,6L,3L,5L,5L,4L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110632Inst : IEnumerable<long>
{
public static readonly long[] Value=A110632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110632.Bytes);
public long this[int i]=>Value[i];

public static A110632Inst Instance=new A110632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110633
{
public static readonly long[] Value={ 1L,2L,6L,4L,6L,4L,3L,2L,6L,4L,2L,6L,6L,4L,4L,2L,4L,2L,6L,4L,3L,4L,2L,6L,1L,4L,2L,2L,3L,4L,1L,6L,6L,2L,6L,6L,1L,6L,2L,6L,6L,2L,4L,6L,2L,4L,4L,4L,2L,6L,6L,2L,2L,6L,4L,4L,2L,6L,6L,4L,5L,4L,2L,6L,2L,4L,1L,2L,5L,2L,3L,4L,6L,6L,6L,6L,2L,4L,5L,2L,3L,2L,1L,2L,4L,2L,5L,2L,4L,2L,6L,2L,2L,4L,4L,4L,3L,2L,1L,2L,6L,6L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110633Inst : IEnumerable<long>
{
public static readonly long[] Value=A110633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110633.Bytes);
public long this[int i]=>Value[i];

public static A110633Inst Instance=new A110633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110634
{
public static readonly long[] Value={ 1L,3L,3L,6L,3L,6L,6L,3L,6L,3L,6L,3L,6L,3L,6L,2L,6L,6L,6L,3L,6L,4L,6L,6L,4L,3L,3L,6L,3L,3L,3L,3L,6L,2L,3L,3L,1L,6L,6L,2L,6L,6L,3L,3L,6L,1L,6L,6L,6L,3L,6L,6L,3L,6L,1L,6L,6L,2L,3L,6L,6L,3L,3L,4L,6L,6L,2L,3L,6L,4L,3L,6L,2L,6L,3L,6L,3L,6L,2L,6L,6L,4L,3L,3L,2L,3L,3L,6L,3L,3L,5L,3L,3L,2L,6L,6L,2L,3L,6L,1L,3L,3L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110634Inst : IEnumerable<long>
{
public static readonly long[] Value=A110634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110634.Bytes);
public long this[int i]=>Value[i];

public static A110634Inst Instance=new A110634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110635
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,4L,2L,1L,1L,3L,5L,1L,2L,5L,1L,7L,6L,4L,4L,6L,4L,5L,7L,3L,4L,2L,4L,3L,3L,2L,7L,4L,6L,6L,3L,1L,1L,6L,5L,6L,6L,3L,1L,2L,5L,7L,3L,3L,7L,5L,5L,6L,4L,6L,3L,4L,2L,5L,4L,4L,7L,3L,4L,1L,5L,6L,7L,2L,2L,5L,4L,1L,4L,4L,1L,1L,4L,3L,6L,7L,6L,2L,6L,6L,2L,1L,6L,6L,1L,5L,2L,2L,5L,5L,4L,2L,3L,7L,4L,5L,1L,3L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110635Inst : IEnumerable<long>
{
public static readonly long[] Value=A110635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110635.Bytes);
public long this[int i]=>Value[i];

public static A110635Inst Instance=new A110635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110636
{
public static readonly long[] Value={ 1L,7L,3L,1L,6L,6L,4L,8L,7L,8L,8L,7L,3L,3L,3L,1L,4L,3L,6L,5L,1L,6L,6L,1L,1L,5L,4L,8L,5L,5L,4L,6L,5L,8L,7L,6L,5L,6L,6L,5L,8L,4L,7L,4L,1L,3L,7L,7L,4L,6L,8L,7L,4L,8L,8L,1L,5L,3L,5L,5L,6L,2L,4L,4L,7L,2L,6L,2L,1L,4L,3L,5L,5L,3L,5L,1L,5L,3L,7L,8L,6L,5L,1L,2L,1L,1L,2L,4L,6L,1L,6L,3L,5L,1L,7L,3L,4L,2L,6L,7L,1L,3L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110636Inst : IEnumerable<long>
{
public static readonly long[] Value=A110636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110636.Bytes);
public long this[int i]=>Value[i];

public static A110636Inst Instance=new A110636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110637
{
public static readonly long[] Value={ 1L,2L,7L,4L,3L,2L,1L,8L,6L,6L,6L,4L,4L,2L,8L,8L,7L,6L,8L,6L,8L,6L,7L,8L,3L,4L,3L,6L,3L,8L,1L,4L,4L,8L,3L,6L,6L,2L,5L,8L,1L,4L,6L,4L,6L,6L,1L,8L,1L,6L,5L,8L,4L,4L,8L,4L,5L,8L,5L,2L,4L,8L,6L,4L,5L,2L,8L,8L,7L,4L,6L,4L,5L,8L,6L,8L,6L,4L,5L,4L,8L,4L,4L,4L,7L,8L,4L,2L,1L,8L,3L,4L,7L,2L,7L,8L,4L,6L,6L,4L,8L,6L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110637Inst : IEnumerable<long>
{
public static readonly long[] Value=A110637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110637.Bytes);
public long this[int i]=>Value[i];

public static A110637Inst Instance=new A110637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110638
{
public static readonly long[] Value={ 1L,4L,2L,4L,7L,8L,4L,8L,3L,8L,2L,8L,1L,8L,8L,8L,6L,4L,6L,4L,6L,8L,4L,8L,4L,8L,2L,8L,8L,8L,8L,8L,7L,8L,6L,8L,8L,4L,6L,4L,8L,8L,6L,8L,7L,4L,8L,4L,3L,4L,4L,4L,3L,8L,6L,8L,3L,8L,8L,8L,1L,8L,4L,8L,4L,8L,8L,8L,3L,8L,6L,8L,6L,8L,2L,8L,5L,8L,8L,8L,1L,8L,4L,8L,6L,4L,4L,4L,6L,8L,6L,8L,1L,4L,8L,4L,1L,8L,6L,8L,5L,4L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110638Inst : IEnumerable<long>
{
public static readonly long[] Value=A110638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110638.Bytes);
public long this[int i]=>Value[i];

public static A110638Inst Instance=new A110638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110639
{
public static readonly long[] Value={ 1L,1L,9L,9L,2L,7L,5L,3L,5L,3L,1L,7L,3L,5L,5L,9L,9L,2L,8L,3L,1L,7L,1L,1L,4L,8L,5L,1L,1L,2L,9L,2L,7L,6L,8L,6L,6L,7L,2L,2L,5L,6L,5L,9L,6L,1L,6L,7L,4L,5L,6L,4L,9L,8L,4L,1L,4L,9L,9L,2L,3L,1L,9L,4L,2L,6L,6L,8L,2L,5L,3L,2L,5L,2L,8L,2L,4L,6L,4L,8L,6L,2L,5L,2L,8L,9L,8L,1L,2L,3L,3L,2L,9L,1L,1L,1L,4L,8L,5L,5L,7L,8L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110639Inst : IEnumerable<long>
{
public static readonly long[] Value=A110639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110639.Bytes);
public long this[int i]=>Value[i];

public static A110639Inst Instance=new A110639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110640
{
public static readonly long[] Value={ 1L,3L,3L,1L,6L,6L,9L,6L,6L,9L,3L,3L,2L,6L,6L,7L,9L,9L,5L,9L,9L,3L,6L,6L,5L,9L,9L,3L,9L,9L,1L,6L,6L,7L,6L,6L,3L,9L,9L,5L,3L,3L,5L,9L,9L,9L,9L,9L,9L,6L,6L,2L,9L,9L,8L,3L,3L,3L,3L,3L,1L,3L,3L,7L,9L,9L,1L,6L,6L,1L,9L,9L,4L,3L,3L,8L,9L,9L,5L,3L,3L,1L,6L,6L,1L,6L,6L,2L,9L,9L,9L,9L,9L,2L,6L,6L,7L,3L,3L,6L,6L,6L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110640Inst : IEnumerable<long>
{
public static readonly long[] Value=A110640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110640.Bytes);
public long this[int i]=>Value[i];

public static A110640Inst Instance=new A110640Inst();

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