using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198057
{
public static readonly long[] Value={ 1L,4L,15L,75L,879L,15766L,530019L,30323508L,2989066962L,507557052083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198057Inst : IEnumerable<long>
{
public static readonly long[] Value=A198057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198057.Bytes);
public long this[int i]=>Value[i];

public static A198057Inst Instance=new A198057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198058
{
public static readonly long[] Value={ 1L,4L,25L,239L,9456L,423328L,55900189L,15136412831L,8243506243585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198058Inst : IEnumerable<long>
{
public static readonly long[] Value=A198058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198058.Bytes);
public long this[int i]=>Value[i];

public static A198058Inst Instance=new A198058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198059
{
public static readonly long[] Value={ 1L,9L,28L,121L,496L,2100L,9017L,38969L,169975L,744984L,3282005L,14513236L,64394500L,286519305L,1277975053L,5712392313L,25581765122L,114754116351L,515530099946L,2319115721576L,10445215621547L,47096725844837L,212569226371737L,960306310551860L,4341968468524371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198059Inst : IEnumerable<long>
{
public static readonly long[] Value=A198059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198059.Bytes);
public long this[int i]=>Value[i];

public static A198059Inst Instance=new A198059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198060
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,4L,10L,8L,1L,5L,22L,35L,16L,1L,6L,46L,134L,126L,32L,1L,7L,94L,485L,866L,462L,64L,1L,8L,190L,1700L,5626L,5812L,1716L,128L,1L,9L,382L,5831L,35466L,69062L,40048L,6435L,256L,1L,10L,766L,19682L,219626L,795312L,882540L,281374L,24310L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198060Inst : IEnumerable<long>
{
public static readonly long[] Value=A198060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198060.Bytes);
public long this[int i]=>Value[i];

public static A198060Inst Instance=new A198060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198061
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,3L,0L,2L,6L,4L,0L,2L,11L,12L,5L,0L,2L,20L,32L,20L,6L,0L,2L,37L,84L,70L,30L,7L,0L,2L,70L,224L,240L,130L,42L,8L,0L,2L,135L,612L,834L,550L,217L,56L,9L,0L,2L,264L,1712L,2968L,2354L,1092L,336L,72L,10L,0L,2L,521L,4884L,10826L,10310L,5551L,1960L,492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198061Inst : IEnumerable<long>
{
public static readonly long[] Value=A198061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198061.Bytes);
public long this[int i]=>Value[i];

public static A198061Inst Instance=new A198061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198062
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,4L,2L,1L,0L,1L,1L,8L,3L,2L,1L,0L,1L,1L,16L,4L,4L,3L,1L,0L,1L,1L,32L,5L,8L,9L,3L,1L,0L,1L,1L,64L,6L,16L,27L,7L,3L,1L,0L,1L,1L,128L,7L,32L,81L,15L,7L,3L,1L,0L,1L,1L,256L,8L,64L,243L,31L,15L,9L,4L,1L,0L,1L,1L,512L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198062Inst : IEnumerable<long>
{
public static readonly long[] Value=A198062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198062.Bytes);
public long this[int i]=>Value[i];

public static A198062Inst Instance=new A198062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198063
{
public static readonly long[] Value={ 0L,1L,1L,8L,4L,8L,27L,15L,15L,27L,64L,40L,32L,40L,64L,125L,85L,65L,65L,85L,125L,216L,156L,120L,108L,120L,156L,216L,343L,259L,203L,175L,175L,203L,259L,343L,512L,400L,320L,272L,256L,272L,320L,400L,512L,729L,585L,477L,405L,369L,369L,405L,477L,585L,729L,1000L,820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198063Inst : IEnumerable<long>
{
public static readonly long[] Value=A198063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198063.Bytes);
public long this[int i]=>Value[i];

public static A198063Inst Instance=new A198063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198064
{
public static readonly long[] Value={ 0L,1L,1L,16L,5L,16L,81L,31L,31L,81L,256L,121L,80L,121L,256L,625L,341L,211L,211L,341L,625L,1296L,781L,496L,405L,496L,781L,1296L,2401L,1555L,1031L,781L,781L,1031L,1555L,2401L,4096L,2801L,1936L,1441L,1280L,1441L,1936L,2801L,4096L,6561L,4681L,3355L,2511L,2101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198064Inst : IEnumerable<long>
{
public static readonly long[] Value=A198064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198064.Bytes);
public long this[int i]=>Value[i];

public static A198064Inst Instance=new A198064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198065
{
public static readonly long[] Value={ 0L,1L,1L,32L,6L,32L,243L,63L,63L,243L,1024L,364L,192L,364L,1024L,3125L,1365L,665L,665L,1365L,3125L,7776L,3906L,2016L,1458L,2016L,3906L,7776L,16807L,9331L,5187L,3367L,3367L,5187L,9331L,16807L,32768L,19608L,11648L,7448L,6144L,7448L,11648L,19608L,32768L,59049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198065Inst : IEnumerable<long>
{
public static readonly long[] Value=A198065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198065.Bytes);
public long this[int i]=>Value[i];

public static A198065Inst Instance=new A198065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198066
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,2L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,3L,1L,1L,1L,1L,0L,0L,3L,2L,1L,1L,1L,0L,0L,0L,3L,3L,2L,1L,2L,0L,1L,0L,0L,2L,2L,2L,2L,0L,0L,1L,0L,0L,0L,4L,2L,3L,3L,2L,1L,2L,1L,1L,0L,0L,3L,3L,1L,2L,2L,1L,1L,1L,0L,0L,0L,0L,5L,3L,3L,2L,2L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198066Inst : IEnumerable<long>
{
public static readonly long[] Value=A198066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198066.Bytes);
public long this[int i]=>Value[i];

public static A198066Inst Instance=new A198066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198067
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,2L,1L,1L,1L,1L,2L,3L,1L,2L,1L,2L,1L,1L,1L,1L,6L,2L,3L,1L,3L,1L,2L,1L,1L,1L,1L,1L,6L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,7L,1L,6L,2L,3L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198067Inst : IEnumerable<long>
{
public static readonly long[] Value=A198067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198067.Bytes);
public long this[int i]=>Value[i];

public static A198067Inst Instance=new A198067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198068
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,1L,1L,1L,0L,2L,2L,2L,2L,1L,0L,1L,2L,2L,1L,1L,1L,0L,1L,2L,2L,2L,1L,2L,1L,0L,1L,1L,2L,2L,1L,2L,1L,1L,0L,2L,2L,2L,2L,3L,3L,1L,2L,1L,0L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,0L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,1L,0L,1L,2L,2L,2L,2L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198068Inst : IEnumerable<long>
{
public static readonly long[] Value=A198068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198068.Bytes);
public long this[int i]=>Value[i];

public static A198068Inst Instance=new A198068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198069
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,1L,2L,1L,4L,8L,1L,2L,1L,4L,1L,2L,1L,8L,16L,1L,2L,1L,4L,1L,2L,1L,8L,1L,2L,1L,4L,1L,2L,1L,16L,32L,1L,2L,1L,4L,1L,2L,1L,8L,1L,2L,1L,4L,1L,2L,1L,16L,1L,2L,1L,4L,1L,2L,1L,8L,1L,2L,1L,4L,1L,2L,1L,32L,64L,1L,2L,1L,4L,1L,2L,1L,8L,1L,2L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198069Inst : IEnumerable<long>
{
public static readonly long[] Value=A198069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198069.Bytes);
public long this[int i]=>Value[i];

public static A198069Inst Instance=new A198069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198070
{
public static readonly long[] Value={ 32L,98L,412L,1387L,3802L,8918L,18593L,35409L,62785L,105101L,167817L,257593L,382409L,551685L,776401L,1069217L,1444593L,1918909L,2510585L,3240201L,4130616L,5207092L,6497408L,8031984L,9844000L,11969516L,14447592L,17320408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198070Inst : IEnumerable<long>
{
public static readonly long[] Value=A198070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198070.Bytes);
public long this[int i]=>Value[i];

public static A198070Inst Instance=new A198070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198071
{
public static readonly long[] Value={ 64L,244L,1372L,5893L,19771L,54992L,132810L,287700L,572042L,1061520L,1861242L,3112580L,5000730L,7762992L,11697770L,17174292L,24643050L,34646960L,47833242L,64966020L,86939642L,114792720L,149722890L,193102292L,246493770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198071Inst : IEnumerable<long>
{
public static readonly long[] Value=A198071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198071.Bytes);
public long this[int i]=>Value[i];

public static A198071Inst Instance=new A198071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198072
{
public static readonly long[] Value={ 128L,610L,4572L,25045L,102807L,339120L,948645L,2337564L,5211940L,10721354L,20642867L,37610343L,65394163L,109236389L,176246402L,275862066L,420381442L,625570112L,911349138L,1302568702L,1829872466L,2530657692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198072Inst : IEnumerable<long>
{
public static readonly long[] Value=A198072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198072.Bytes);
public long this[int i]=>Value[i];

public static A198072Inst Instance=new A198072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198073
{
public static readonly long[] Value={ 256L,1526L,15242L,106442L,534597L,2091240L,6776036L,18992711L,47486564L,108285671L,228948163L,454458310L,855154435L,1537112038L,2655445795L,4431034438L,7171212835L,11295015910L,17363599363L,26116502470L,38514458563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198073Inst : IEnumerable<long>
{
public static readonly long[] Value=A198073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198073.Bytes);
public long this[int i]=>Value[i];

public static A198073Inst Instance=new A198073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198074
{
public static readonly long[] Value={ 512L,3815L,50805L,452377L,2779906L,12895977L,48400258L,154315776L,432655358L,1093685273L,2539243268L,5491371251L,11182788770L,21629362253L,40008716648L,71173490664L,122332454247L,203937787267L,330822261551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198074Inst : IEnumerable<long>
{
public static readonly long[] Value=A198074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198074.Bytes);
public long this[int i]=>Value[i];

public static A198074Inst Instance=new A198074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198075
{
public static readonly long[] Value={ 1024L,9537L,169351L,1922602L,14455511L,79525194L,345716130L,1253815679L,3941971041L,11046221254L,28162516240L,66354069277L,146236468527L,304356025989L,602797997503L,1143224193789L,2086847748927L,3682210047877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198075Inst : IEnumerable<long>
{
public static readonly long[] Value=A198075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198075.Bytes);
public long this[int i]=>Value[i];

public static A198075Inst Instance=new A198075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198076
{
public static readonly BigInteger[] Value={ 2L,6L,43L,410L,5033L,75419L,1334839L,27249053L,630249410L,16288946268L,465239139606L,14551915228367L,494696673952512L,18161513224841276L,716102966059713316L,BigInteger.Parse("30181658957863752410"),BigInteger.Parse("1354087807629298185930"),BigInteger.Parse("64430442087414935111822") };
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
public class A198076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198076Inst Instance=new A198076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198077
{
public static readonly BigInteger[] Value={ 1L,5L,37L,353L,4315L,64535L,1140539L,23256804L,537441241L,13880477010L,396218076727L,12386985584176L,420923890579262L,15447592770126360L,608903758014263549L,BigInteger.Parse("25656487848259583960"),BigInteger.Parse("1150788495459483630200"),BigInteger.Parse("54745172171004903538414") };
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
public class A198077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198077Inst Instance=new A198077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198078
{
public static readonly BigInteger[] Value={ 1L,5L,34L,326L,3988L,59605L,1052849L,21460092L,495764693L,12800845442L,365323615365L,11419131242071L,387977390372850L,14236659589753581L,561109543344974894L,BigInteger.Parse("23640346895461300427"),BigInteger.Parse("1060265646084471617079"),BigInteger.Parse("50434955069054663240727") };
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
public class A198078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198078Inst Instance=new A198078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198079
{
public static readonly BigInteger[] Value={ 1L,5L,33L,311L,3802L,56800L,1003061L,20441409L,472161363L,12189944200L,347854999335L,10872213398723L,369369563065819L,13553043160362243L,534138422146939893L,BigInteger.Parse("22502990284669009819"),BigInteger.Parse("1009214769013552542796"),BigInteger.Parse("48004835269442445650150") };
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
public class A198079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198079Inst Instance=new A198079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198080
{
public static readonly BigInteger[] Value={ 0L,4L,116L,3144L,84904L,2292428L,61895580L,1671180688L,45121878608L,1218290722452L,32893849506244L,888133936668632L,23979616290053112L,647449639831434076L,17481140275448720108UL,BigInteger.Parse("471990787437115442976"),BigInteger.Parse("12743751260802116960416"),BigInteger.Parse("344081284041657157931300") };
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
public class A198080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198080Inst Instance=new A198080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198081
{
public static readonly long[] Value={ 0L,2L,4L,6L,7L,9L,11L,13L,14L,16L,18L,20L,21L,23L,25L,26L,28L,30L,32L,33L,35L,37L,39L,40L,42L,44L,46L,47L,49L,51L,52L,54L,56L,58L,59L,61L,63L,65L,66L,68L,70L,72L,73L,75L,77L,78L,80L,82L,84L,85L,87L,89L,91L,92L,94L,96L,97L,99L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198081Inst : IEnumerable<long>
{
public static readonly long[] Value=A198081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198081.Bytes);
public long this[int i]=>Value[i];

public static A198081Inst Instance=new A198081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198082
{
public static readonly long[] Value={ 0L,3L,5L,7L,9L,12L,14L,16L,18L,21L,23L,25L,27L,30L,32L,34L,36L,39L,41L,43L,45L,47L,50L,52L,54L,56L,59L,61L,63L,65L,68L,70L,72L,74L,77L,79L,81L,83L,85L,88L,90L,92L,94L,97L,99L,101L,103L,106L,108L,110L,112L,115L,117L,119L,121L,123L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198082Inst : IEnumerable<long>
{
public static readonly long[] Value=A198082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198082.Bytes);
public long this[int i]=>Value[i];

public static A198082Inst Instance=new A198082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198083
{
public static readonly long[] Value={ 0L,3L,5L,8L,10L,13L,15L,18L,20L,23L,25L,27L,30L,32L,35L,37L,40L,42L,45L,47L,49L,52L,54L,57L,59L,62L,64L,67L,69L,72L,74L,76L,79L,81L,84L,86L,89L,91L,94L,96L,98L,101L,103L,106L,108L,111L,113L,116L,118L,121L,123L,125L,128L,130L,133L,135L,138L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198083Inst : IEnumerable<long>
{
public static readonly long[] Value=A198083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198083.Bytes);
public long this[int i]=>Value[i];

public static A198083Inst Instance=new A198083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198084
{
public static readonly long[] Value={ 0L,3L,6L,8L,11L,14L,16L,19L,22L,24L,27L,30L,32L,35L,38L,40L,43L,45L,48L,51L,53L,56L,59L,61L,64L,67L,69L,72L,75L,77L,80L,83L,85L,88L,90L,93L,96L,98L,101L,104L,106L,109L,112L,114L,117L,120L,122L,125L,127L,130L,133L,135L,138L,141L,143L,146L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198084Inst : IEnumerable<long>
{
public static readonly long[] Value=A198084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198084.Bytes);
public long this[int i]=>Value[i];

public static A198084Inst Instance=new A198084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198085
{
public static readonly long[] Value={ 1L,3L,11L,114L,6833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198085Inst : IEnumerable<long>
{
public static readonly long[] Value=A198085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198085.Bytes);
public long this[int i]=>Value[i];

public static A198085Inst Instance=new A198085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198086
{
public static readonly long[] Value={ 1L,5L,14L,41L,93L,212L,413L,797L,1399L,2424L,3941L,6317L,9686L,14654L,21451L,31025L,43754L,61042L,83484L,113084L,150732L,199211L,259804L,336263L,430401L,547166L,689034L,862426L,1070653L,1321891L,1620501L,1976744L,2396247L,2891749L,3470397L,4147802L,4932954L,5844785L,6894435L,8104688L,9489198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198086Inst : IEnumerable<long>
{
public static readonly long[] Value=A198086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198086.Bytes);
public long this[int i]=>Value[i];

public static A198086Inst Instance=new A198086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198087
{
public static readonly long[] Value={ 1L,1L,7L,51L,580L,14960L,692710L,57268094L,9248071023L,2766940534117L,1541427833628443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198087Inst : IEnumerable<long>
{
public static readonly long[] Value=A198087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198087.Bytes);
public long this[int i]=>Value[i];

public static A198087Inst Instance=new A198087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198088
{
public static readonly long[] Value={ 1L,2L,11L,74L,976L,21825L,872834L,59303832L,7042717250L,1444475469020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198088Inst : IEnumerable<long>
{
public static readonly long[] Value=A198088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198088.Bytes);
public long this[int i]=>Value[i];

public static A198088Inst Instance=new A198088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198089
{
public static readonly long[] Value={ 1L,2L,5L,33L,228L,3088L,57920L,1692421L,89966033L,7774886220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198089Inst : IEnumerable<long>
{
public static readonly long[] Value=A198089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198089.Bytes);
public long this[int i]=>Value[i];

public static A198089Inst Instance=new A198089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198090
{
public static readonly long[] Value={ 1L,5L,17L,92L,1017L,23269L,789910L,53978753L,6677975379L,1487161118854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198090Inst : IEnumerable<long>
{
public static readonly long[] Value=A198090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198090.Bytes);
public long this[int i]=>Value[i];

public static A198090Inst Instance=new A198090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198091
{
public static readonly long[] Value={ 1L,5L,14L,87L,1076L,18288L,851062L,53145769L,5147572134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198091Inst : IEnumerable<long>
{
public static readonly long[] Value=A198091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198091.Bytes);
public long this[int i]=>Value[i];

public static A198091Inst Instance=new A198091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198092
{
public static readonly long[] Value={ 1L,2L,8L,38L,587L,9649L,374209L,27337248L,3366388352L,804248984354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198092Inst : IEnumerable<long>
{
public static readonly long[] Value=A198092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198092.Bytes);
public long this[int i]=>Value[i];

public static A198092Inst Instance=new A198092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198093
{
public static readonly long[] Value={ 1L,5L,23L,181L,2682L,76326L,3762043L,354138576L,62665720459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198093Inst : IEnumerable<long>
{
public static readonly long[] Value=A198093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198093.Bytes);
public long this[int i]=>Value[i];

public static A198093Inst Instance=new A198093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198094
{
public static readonly long[] Value={ 2L,1L,3L,5L,8L,12L,19L,28L,41L,60L,87L,127L,183L,266L,384L,555L,802L,1158L,1671L,2412L,3480L,5022L,7246L,10455L,15084L,21763L,31398L,45298L,65353L,94285L,136025L,196244L,283121L,408458L,589281L,850154L,1226514L,1769486L,2552829L,3682955L,5313382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198094Inst : IEnumerable<long>
{
public static readonly long[] Value=A198094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198094.Bytes);
public long this[int i]=>Value[i];

public static A198094Inst Instance=new A198094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198095
{
public static readonly long[] Value={ 1L,4L,9L,27L,79L,225L,108L,249L,999L,2104L,1005L,2235L,1007L,2108L,1119L,2169L,1999L,22132L,10003L,21213L,11133L,21004L,10024L,22334L,10015L,21035L,11106L,21226L,10007L,22127L,10008L,21228L,11109L,21039L,10069L,22389L,19999L,210002L,111302L,212112L,100022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198095Inst : IEnumerable<long>
{
public static readonly long[] Value=A198095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198095.Bytes);
public long this[int i]=>Value[i];

public static A198095Inst Instance=new A198095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198096
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,12L,13L,15L,16L,18L,19L,20L,30L,31L,32L,34L,35L,37L,38L,50L,51L,53L,54L,56L,57L,59L,70L,72L,73L,75L,76L,78L,91L,92L,94L,95L,97L,101L,102L,103L,105L,106L,107L,110L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,131L,132L,134L,135L,136L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198096Inst : IEnumerable<long>
{
public static readonly long[] Value=A198096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198096.Bytes);
public long this[int i]=>Value[i];

public static A198096Inst Instance=new A198096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198097
{
public static readonly long[] Value={ 1L,4L,9L,10L,14L,21L,27L,33L,40L,46L,52L,65L,71L,79L,84L,90L,98L,100L,104L,108L,111L,133L,137L,140L,162L,166L,191L,195L,210L,212L,225L,241L,249L,254L,270L,278L,283L,301L,323L,327L,330L,352L,356L,381L,385L,400L,402L,415L,431L,439L,444L,460L,468L,473L,497L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198097Inst : IEnumerable<long>
{
public static readonly long[] Value=A198097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198097.Bytes);
public long this[int i]=>Value[i];

public static A198097Inst Instance=new A198097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198098
{
public static readonly long[] Value={ 6L,7L,2L,2L,5L,5L,1L,6L,7L,7L,3L,8L,2L,5L,6L,8L,8L,0L,7L,4L,8L,6L,0L,4L,6L,1L,7L,8L,7L,0L,3L,2L,5L,9L,7L,6L,6L,5L,7L,5L,0L,9L,3L,6L,8L,2L,1L,3L,9L,8L,1L,8L,9L,5L,5L,0L,1L,7L,7L,5L,2L,3L,5L,7L,8L,1L,1L,2L,9L,5L,4L,4L,7L,2L,1L,2L,4L,8L,1L,8L,8L,7L,8L,6L,0L,8L,5L,0L,8L,3L,4L,5L,5L,2L,9L,9L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198098Inst : IEnumerable<long>
{
public static readonly long[] Value=A198098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198098.Bytes);
public long this[int i]=>Value[i];

public static A198098Inst Instance=new A198098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198099
{
public static readonly long[] Value={ 3L,5L,2L,5L,8L,6L,7L,9L,0L,1L,2L,2L,7L,9L,5L,8L,6L,1L,7L,9L,5L,4L,8L,2L,5L,0L,8L,1L,7L,1L,1L,3L,9L,4L,3L,0L,9L,9L,4L,6L,9L,8L,7L,4L,7L,8L,3L,2L,2L,2L,5L,2L,7L,4L,0L,4L,3L,6L,2L,7L,9L,1L,3L,1L,4L,5L,5L,0L,0L,6L,7L,9L,4L,6L,7L,9L,5L,3L,0L,3L,7L,6L,7L,8L,4L,7L,2L,6L,4L,1L,2L,1L,6L,5L,5L,4L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198099Inst : IEnumerable<long>
{
public static readonly long[] Value=A198099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198099.Bytes);
public long this[int i]=>Value[i];

public static A198099Inst Instance=new A198099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198100
{
public static readonly long[] Value={ 5L,0L,1L,3L,0L,4L,7L,5L,5L,4L,5L,4L,8L,0L,6L,4L,6L,3L,3L,9L,3L,6L,9L,0L,3L,5L,7L,5L,6L,8L,1L,9L,8L,1L,3L,0L,5L,5L,2L,3L,4L,5L,1L,0L,1L,0L,8L,2L,1L,5L,0L,5L,7L,8L,0L,8L,6L,0L,2L,6L,4L,3L,5L,1L,2L,3L,4L,9L,8L,6L,8L,7L,4L,5L,2L,9L,4L,4L,8L,4L,5L,0L,2L,3L,6L,7L,8L,7L,3L,8L,1L,8L,7L,6L,3L,6L,1L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198100Inst : IEnumerable<long>
{
public static readonly long[] Value=A198100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198100.Bytes);
public long this[int i]=>Value[i];

public static A198100Inst Instance=new A198100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198101
{
public static readonly long[] Value={ 4L,2L,2L,2L,7L,4L,9L,5L,2L,8L,7L,9L,4L,9L,2L,7L,3L,2L,4L,4L,8L,4L,2L,4L,9L,6L,7L,6L,6L,1L,0L,8L,2L,0L,1L,2L,8L,1L,6L,3L,3L,7L,1L,2L,5L,9L,8L,2L,1L,1L,0L,6L,8L,4L,2L,5L,6L,3L,8L,6L,4L,9L,8L,5L,9L,8L,2L,7L,0L,2L,6L,1L,8L,7L,8L,2L,0L,1L,6L,6L,2L,4L,8L,1L,4L,0L,6L,0L,0L,0L,9L,9L,4L,5L,8L,4L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198101Inst : IEnumerable<long>
{
public static readonly long[] Value=A198101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198101.Bytes);
public long this[int i]=>Value[i];

public static A198101Inst Instance=new A198101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198102
{
public static readonly long[] Value={ 2L,6L,6L,6L,5L,0L,9L,8L,2L,1L,5L,2L,5L,4L,2L,1L,4L,7L,1L,1L,9L,2L,9L,0L,9L,8L,8L,1L,2L,4L,3L,5L,6L,5L,4L,8L,2L,0L,4L,0L,5L,8L,9L,6L,3L,2L,5L,6L,0L,6L,1L,3L,7L,4L,7L,1L,3L,8L,6L,7L,6L,2L,0L,9L,2L,6L,7L,6L,5L,2L,5L,1L,2L,9L,3L,0L,3L,2L,0L,1L,7L,1L,2L,6L,8L,5L,9L,7L,1L,2L,8L,2L,7L,4L,4L,3L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198102Inst : IEnumerable<long>
{
public static readonly long[] Value=A198102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198102.Bytes);
public long this[int i]=>Value[i];

public static A198102Inst Instance=new A198102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198103
{
public static readonly long[] Value={ 2L,9L,1L,0L,7L,1L,4L,5L,0L,7L,8L,0L,6L,0L,3L,8L,0L,1L,0L,1L,1L,7L,6L,6L,1L,0L,6L,4L,0L,7L,3L,1L,2L,3L,6L,7L,5L,1L,5L,8L,0L,0L,4L,9L,7L,9L,8L,4L,2L,5L,2L,5L,1L,5L,1L,1L,7L,9L,3L,5L,2L,7L,6L,7L,8L,3L,8L,3L,5L,7L,4L,7L,1L,7L,3L,1L,6L,3L,6L,6L,6L,3L,3L,8L,3L,5L,1L,7L,0L,5L,1L,7L,3L,8L,6L,6L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198103Inst : IEnumerable<long>
{
public static readonly long[] Value=A198103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198103.Bytes);
public long this[int i]=>Value[i];

public static A198103Inst Instance=new A198103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198104
{
public static readonly long[] Value={ 2L,3L,8L,8L,9L,4L,9L,3L,4L,3L,6L,0L,8L,9L,0L,4L,5L,9L,6L,8L,7L,0L,4L,3L,2L,6L,7L,8L,1L,9L,7L,3L,0L,9L,9L,2L,9L,6L,6L,3L,3L,0L,6L,0L,2L,9L,4L,6L,2L,2L,9L,0L,1L,9L,9L,1L,1L,6L,9L,1L,8L,0L,1L,5L,0L,7L,5L,0L,6L,1L,3L,9L,6L,6L,1L,9L,5L,3L,1L,0L,8L,6L,7L,7L,8L,1L,1L,0L,6L,0L,0L,3L,7L,0L,5L,5L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198104Inst : IEnumerable<long>
{
public static readonly long[] Value=A198104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198104.Bytes);
public long this[int i]=>Value[i];

public static A198104Inst Instance=new A198104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198105
{
public static readonly long[] Value={ 5L,0L,1L,0L,4L,1L,1L,8L,6L,4L,4L,6L,4L,9L,0L,3L,8L,3L,3L,1L,5L,1L,4L,1L,7L,7L,9L,0L,6L,6L,3L,4L,6L,4L,9L,7L,8L,6L,0L,8L,4L,9L,9L,1L,4L,5L,4L,4L,5L,0L,9L,0L,6L,7L,8L,0L,4L,3L,2L,0L,5L,8L,4L,4L,4L,6L,2L,6L,3L,3L,0L,2L,7L,0L,5L,5L,2L,4L,7L,0L,5L,3L,4L,5L,8L,4L,0L,1L,6L,9L,4L,5L,2L,2L,4L,9L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198105Inst : IEnumerable<long>
{
public static readonly long[] Value=A198105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198105.Bytes);
public long this[int i]=>Value[i];

public static A198105Inst Instance=new A198105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198106
{
public static readonly long[] Value={ 2L,1L,9L,8L,5L,6L,1L,3L,3L,5L,4L,6L,8L,1L,6L,1L,8L,8L,2L,3L,3L,0L,7L,6L,4L,3L,6L,7L,1L,0L,9L,0L,6L,3L,1L,8L,3L,0L,2L,6L,1L,2L,8L,5L,2L,9L,8L,7L,8L,1L,7L,3L,2L,7L,1L,0L,0L,7L,3L,4L,5L,3L,2L,0L,2L,7L,0L,9L,1L,8L,0L,3L,5L,6L,3L,0L,6L,6L,1L,0L,7L,8L,5L,2L,9L,2L,4L,7L,7L,7L,3L,9L,5L,0L,9L,6L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198106Inst : IEnumerable<long>
{
public static readonly long[] Value=A198106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198106.Bytes);
public long this[int i]=>Value[i];

public static A198106Inst Instance=new A198106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198107
{
public static readonly long[] Value={ 6L,5L,2L,5L,7L,3L,2L,5L,1L,5L,3L,3L,3L,9L,7L,4L,2L,4L,4L,4L,1L,2L,6L,2L,3L,4L,5L,3L,4L,6L,4L,8L,8L,2L,4L,9L,7L,6L,4L,9L,9L,2L,8L,7L,6L,1L,0L,9L,1L,8L,7L,1L,1L,5L,3L,0L,9L,2L,9L,0L,6L,7L,8L,2L,2L,7L,6L,5L,4L,4L,2L,1L,9L,9L,0L,9L,5L,6L,9L,3L,7L,0L,1L,4L,2L,1L,0L,8L,9L,9L,5L,5L,2L,0L,4L,1L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198107Inst : IEnumerable<long>
{
public static readonly long[] Value=A198107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198107.Bytes);
public long this[int i]=>Value[i];

public static A198107Inst Instance=new A198107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198108
{
public static readonly long[] Value={ 2L,0L,7L,2L,1L,9L,1L,3L,0L,2L,7L,1L,1L,8L,0L,9L,3L,2L,7L,3L,7L,9L,6L,8L,2L,2L,9L,0L,0L,2L,7L,0L,0L,3L,7L,2L,6L,5L,6L,8L,7L,2L,0L,3L,7L,5L,9L,3L,5L,8L,9L,1L,6L,2L,5L,2L,8L,7L,0L,1L,4L,3L,3L,8L,1L,2L,1L,1L,8L,3L,7L,7L,0L,3L,9L,0L,6L,6L,3L,2L,8L,1L,3L,6L,2L,5L,0L,3L,7L,1L,3L,5L,7L,3L,6L,6L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198108Inst : IEnumerable<long>
{
public static readonly long[] Value=A198108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198108.Bytes);
public long this[int i]=>Value[i];

public static A198108Inst Instance=new A198108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198109
{
public static readonly long[] Value={ 7L,6L,5L,7L,2L,6L,4L,4L,2L,9L,2L,0L,5L,4L,0L,7L,1L,7L,4L,8L,3L,1L,0L,1L,0L,4L,9L,2L,3L,9L,4L,4L,9L,9L,3L,8L,2L,5L,9L,3L,8L,8L,0L,0L,4L,2L,0L,4L,9L,6L,3L,7L,0L,7L,0L,8L,5L,2L,1L,5L,1L,7L,2L,8L,8L,4L,5L,8L,6L,9L,4L,9L,7L,5L,8L,1L,7L,4L,9L,7L,9L,4L,2L,2L,8L,3L,9L,2L,5L,1L,1L,7L,8L,8L,9L,2L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198109Inst : IEnumerable<long>
{
public static readonly long[] Value=A198109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198109.Bytes);
public long this[int i]=>Value[i];

public static A198109Inst Instance=new A198109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198110
{
public static readonly long[] Value={ 6L,3L,4L,5L,5L,9L,9L,4L,5L,5L,2L,6L,6L,2L,2L,7L,4L,0L,0L,6L,7L,7L,6L,8L,3L,4L,3L,7L,6L,9L,8L,5L,4L,4L,8L,0L,3L,0L,7L,5L,7L,1L,6L,7L,8L,2L,2L,5L,1L,8L,8L,3L,6L,2L,1L,7L,7L,0L,5L,1L,5L,4L,1L,6L,2L,5L,6L,9L,3L,7L,6L,9L,2L,8L,9L,1L,9L,5L,4L,3L,1L,2L,9L,7L,3L,0L,1L,4L,0L,1L,9L,5L,5L,1L,3L,1L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198110Inst : IEnumerable<long>
{
public static readonly long[] Value=A198110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198110.Bytes);
public long this[int i]=>Value[i];

public static A198110Inst Instance=new A198110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198111
{
public static readonly long[] Value={ 9L,4L,0L,3L,4L,9L,9L,6L,5L,3L,5L,5L,0L,5L,3L,8L,8L,8L,2L,2L,9L,3L,9L,3L,6L,8L,7L,6L,1L,4L,9L,6L,8L,9L,0L,9L,7L,7L,0L,7L,2L,7L,6L,0L,7L,4L,2L,6L,4L,6L,4L,3L,9L,3L,6L,8L,6L,1L,6L,4L,4L,5L,1L,6L,3L,1L,8L,3L,0L,4L,5L,5L,1L,7L,4L,7L,9L,6L,9L,1L,4L,9L,4L,6L,8L,9L,3L,4L,4L,0L,1L,1L,2L,0L,1L,0L,3L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198111Inst : IEnumerable<long>
{
public static readonly long[] Value=A198111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198111.Bytes);
public long this[int i]=>Value[i];

public static A198111Inst Instance=new A198111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198112
{
public static readonly long[] Value={ 8L,7L,0L,3L,1L,6L,3L,4L,1L,1L,7L,7L,4L,8L,7L,5L,3L,8L,6L,7L,2L,4L,0L,5L,2L,9L,2L,3L,4L,8L,1L,5L,0L,6L,1L,5L,2L,5L,6L,1L,6L,0L,7L,0L,2L,9L,9L,6L,8L,3L,2L,4L,5L,5L,8L,8L,1L,6L,7L,6L,2L,7L,6L,7L,6L,7L,2L,5L,5L,6L,9L,1L,4L,2L,2L,9L,5L,1L,2L,4L,2L,5L,4L,7L,8L,9L,3L,4L,4L,4L,8L,8L,5L,8L,5L,3L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198112Inst : IEnumerable<long>
{
public static readonly long[] Value=A198112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198112.Bytes);
public long this[int i]=>Value[i];

public static A198112Inst Instance=new A198112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198113
{
public static readonly long[] Value={ 4L,6L,3L,9L,0L,2L,3L,8L,2L,5L,9L,7L,4L,1L,1L,9L,0L,9L,7L,5L,6L,7L,0L,3L,1L,6L,9L,5L,3L,5L,3L,5L,0L,5L,8L,9L,7L,2L,0L,7L,5L,7L,5L,8L,2L,7L,1L,2L,0L,1L,4L,2L,0L,1L,5L,3L,6L,2L,2L,5L,6L,8L,9L,2L,6L,5L,2L,5L,9L,5L,3L,1L,9L,5L,9L,9L,6L,0L,9L,6L,9L,0L,7L,4L,0L,1L,1L,9L,4L,4L,2L,7L,3L,8L,0L,3L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198113Inst : IEnumerable<long>
{
public static readonly long[] Value=A198113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198113.Bytes);
public long this[int i]=>Value[i];

public static A198113Inst Instance=new A198113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198114
{
public static readonly long[] Value={ 1L,0L,1L,7L,0L,5L,4L,9L,0L,0L,6L,7L,5L,0L,6L,0L,9L,6L,9L,3L,3L,1L,1L,6L,5L,5L,8L,3L,6L,1L,7L,7L,4L,5L,8L,9L,4L,7L,7L,1L,6L,2L,8L,8L,7L,5L,9L,6L,6L,0L,1L,0L,6L,6L,4L,6L,7L,9L,0L,5L,9L,1L,1L,4L,9L,3L,0L,8L,5L,1L,5L,3L,9L,2L,6L,3L,6L,1L,5L,3L,4L,6L,0L,6L,7L,0L,2L,4L,6L,8L,6L,9L,6L,7L,9L,5L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198114Inst : IEnumerable<long>
{
public static readonly long[] Value=A198114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198114.Bytes);
public long this[int i]=>Value[i];

public static A198114Inst Instance=new A198114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198115
{
public static readonly long[] Value={ 6L,6L,9L,9L,6L,8L,1L,6L,9L,0L,4L,6L,9L,3L,3L,1L,9L,1L,7L,5L,0L,9L,3L,9L,2L,8L,9L,5L,6L,2L,1L,6L,6L,2L,8L,7L,2L,9L,5L,4L,9L,4L,3L,5L,5L,1L,3L,5L,9L,1L,9L,9L,5L,8L,3L,7L,3L,0L,9L,3L,3L,7L,4L,7L,0L,7L,4L,6L,7L,7L,9L,1L,4L,4L,7L,9L,6L,2L,4L,3L,1L,3L,5L,0L,2L,7L,7L,8L,0L,6L,1L,6L,6L,2L,4L,5L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198115Inst : IEnumerable<long>
{
public static readonly long[] Value=A198115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198115.Bytes);
public long this[int i]=>Value[i];

public static A198115Inst Instance=new A198115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198116
{
public static readonly long[] Value={ 1L,1L,0L,6L,6L,9L,5L,8L,9L,2L,8L,6L,3L,5L,0L,3L,1L,2L,3L,6L,0L,5L,9L,4L,5L,6L,7L,5L,9L,2L,0L,8L,2L,0L,8L,0L,2L,3L,1L,2L,9L,0L,8L,0L,2L,1L,7L,5L,4L,9L,9L,6L,7L,8L,5L,5L,3L,0L,1L,5L,2L,5L,0L,9L,8L,6L,6L,6L,8L,0L,9L,5L,3L,5L,3L,2L,9L,3L,1L,6L,5L,5L,2L,8L,1L,8L,1L,9L,3L,3L,2L,0L,6L,8L,3L,5L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198116Inst : IEnumerable<long>
{
public static readonly long[] Value=A198116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198116.Bytes);
public long this[int i]=>Value[i];

public static A198116Inst Instance=new A198116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198117
{
public static readonly long[] Value={ 8L,0L,1L,5L,9L,1L,9L,8L,7L,2L,9L,9L,7L,4L,7L,2L,0L,4L,3L,5L,7L,7L,6L,4L,4L,4L,3L,2L,0L,0L,0L,5L,7L,7L,9L,2L,6L,0L,7L,9L,0L,4L,5L,1L,5L,8L,6L,0L,5L,8L,2L,6L,0L,3L,1L,9L,3L,6L,5L,5L,7L,5L,1L,7L,4L,0L,1L,5L,8L,7L,6L,7L,9L,2L,2L,1L,9L,6L,4L,0L,0L,5L,4L,4L,9L,0L,8L,0L,2L,4L,9L,2L,2L,3L,6L,0L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198117Inst : IEnumerable<long>
{
public static readonly long[] Value=A198117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198117.Bytes);
public long this[int i]=>Value[i];

public static A198117Inst Instance=new A198117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198118
{
public static readonly long[] Value={ 1L,1L,6L,9L,0L,2L,2L,6L,9L,2L,3L,0L,5L,3L,9L,2L,9L,1L,0L,2L,1L,0L,1L,0L,0L,2L,2L,8L,8L,5L,2L,7L,8L,3L,0L,5L,6L,7L,1L,9L,3L,8L,9L,3L,3L,1L,6L,6L,1L,0L,8L,7L,0L,6L,8L,2L,3L,0L,0L,3L,7L,1L,1L,4L,0L,7L,6L,3L,3L,3L,7L,9L,1L,4L,0L,7L,8L,2L,0L,2L,5L,4L,9L,6L,7L,4L,5L,4L,2L,3L,5L,8L,9L,3L,3L,6L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198118Inst : IEnumerable<long>
{
public static readonly long[] Value=A198118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198118.Bytes);
public long this[int i]=>Value[i];

public static A198118Inst Instance=new A198118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198119
{
public static readonly long[] Value={ 8L,9L,5L,6L,5L,2L,3L,8L,1L,3L,5L,8L,4L,2L,8L,9L,0L,1L,2L,1L,8L,1L,7L,6L,4L,7L,2L,1L,3L,5L,3L,7L,1L,4L,7L,5L,8L,5L,7L,2L,8L,2L,6L,9L,1L,0L,7L,0L,9L,1L,2L,9L,4L,1L,6L,6L,7L,0L,7L,1L,1L,4L,7L,3L,5L,4L,5L,1L,6L,6L,9L,0L,9L,7L,0L,1L,9L,2L,6L,0L,7L,5L,9L,3L,8L,2L,1L,7L,1L,4L,6L,6L,9L,5L,4L,8L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198119Inst : IEnumerable<long>
{
public static readonly long[] Value=A198119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198119.Bytes);
public long this[int i]=>Value[i];

public static A198119Inst Instance=new A198119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198120
{
public static readonly long[] Value={ 4L,2L,3L,4L,1L,8L,8L,6L,7L,4L,3L,6L,9L,5L,6L,3L,9L,0L,2L,5L,4L,9L,0L,1L,9L,1L,4L,5L,6L,7L,1L,3L,7L,9L,8L,7L,7L,8L,8L,8L,1L,6L,9L,1L,7L,2L,9L,9L,4L,8L,0L,6L,3L,4L,0L,9L,5L,8L,5L,0L,6L,3L,0L,6L,0L,5L,6L,7L,1L,3L,8L,3L,3L,0L,6L,0L,1L,9L,8L,2L,1L,5L,8L,2L,0L,6L,1L,7L,4L,1L,3L,1L,2L,5L,8L,5L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198120Inst : IEnumerable<long>
{
public static readonly long[] Value=A198120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198120.Bytes);
public long this[int i]=>Value[i];

public static A198120Inst Instance=new A198120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198121
{
public static readonly long[] Value={ 1L,4L,6L,3L,3L,6L,2L,8L,2L,7L,2L,9L,6L,4L,3L,1L,1L,4L,5L,1L,0L,5L,2L,9L,6L,4L,2L,6L,1L,6L,1L,3L,5L,8L,7L,0L,6L,9L,1L,8L,2L,7L,7L,3L,2L,5L,2L,2L,4L,4L,1L,4L,1L,2L,6L,9L,7L,2L,5L,8L,6L,5L,5L,2L,8L,2L,5L,0L,0L,0L,9L,8L,5L,6L,6L,1L,6L,1L,2L,6L,5L,6L,7L,7L,4L,7L,4L,2L,9L,8L,4L,9L,2L,8L,9L,7L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198121Inst : IEnumerable<long>
{
public static readonly long[] Value=A198121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198121.Bytes);
public long this[int i]=>Value[i];

public static A198121Inst Instance=new A198121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198122
{
public static readonly long[] Value={ 2L,7L,9L,3L,2L,0L,7L,7L,9L,7L,3L,8L,1L,6L,5L,0L,6L,1L,2L,8L,0L,5L,9L,3L,3L,9L,6L,6L,5L,5L,3L,9L,5L,5L,4L,5L,6L,2L,2L,7L,5L,8L,0L,0L,4L,5L,9L,7L,1L,7L,5L,0L,7L,1L,9L,7L,1L,5L,7L,2L,0L,3L,7L,7L,8L,7L,0L,6L,0L,4L,7L,5L,9L,8L,5L,5L,1L,2L,1L,8L,5L,0L,1L,1L,8L,3L,3L,3L,0L,1L,4L,4L,5L,1L,7L,5L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198122Inst : IEnumerable<long>
{
public static readonly long[] Value=A198122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198122.Bytes);
public long this[int i]=>Value[i];

public static A198122Inst Instance=new A198122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198123
{
public static readonly long[] Value={ 2L,1L,2L,3L,6L,3L,3L,3L,3L,4L,5L,1L,9L,9L,8L,2L,3L,9L,4L,1L,9L,8L,7L,7L,0L,2L,4L,6L,4L,1L,1L,0L,6L,1L,4L,6L,7L,9L,0L,2L,8L,1L,7L,3L,9L,1L,0L,9L,6L,7L,7L,3L,4L,1L,9L,2L,3L,6L,9L,5L,8L,2L,4L,7L,6L,4L,8L,6L,0L,7L,5L,3L,6L,7L,3L,0L,0L,4L,0L,4L,0L,3L,9L,0L,5L,4L,2L,9L,6L,4L,9L,6L,8L,8L,6L,0L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198123Inst : IEnumerable<long>
{
public static readonly long[] Value=A198123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198123.Bytes);
public long this[int i]=>Value[i];

public static A198123Inst Instance=new A198123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198124
{
public static readonly long[] Value={ 1L,1L,6L,7L,8L,7L,3L,1L,5L,2L,7L,3L,8L,5L,6L,7L,1L,9L,7L,9L,3L,0L,8L,1L,2L,2L,4L,2L,7L,6L,9L,9L,6L,3L,0L,8L,1L,7L,5L,4L,3L,1L,1L,3L,5L,6L,7L,0L,9L,6L,3L,3L,5L,0L,8L,3L,6L,5L,3L,9L,2L,4L,5L,1L,0L,0L,6L,7L,5L,4L,6L,9L,5L,2L,1L,7L,2L,6L,9L,0L,0L,0L,3L,0L,3L,1L,4L,3L,2L,3L,5L,5L,8L,4L,9L,8L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198124Inst : IEnumerable<long>
{
public static readonly long[] Value=A198124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198124.Bytes);
public long this[int i]=>Value[i];

public static A198124Inst Instance=new A198124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198125
{
public static readonly long[] Value={ 3L,4L,8L,4L,9L,5L,0L,4L,8L,1L,7L,3L,8L,4L,2L,9L,1L,6L,5L,5L,6L,6L,8L,4L,1L,8L,4L,7L,1L,9L,9L,0L,5L,9L,9L,3L,9L,6L,1L,7L,9L,0L,4L,1L,3L,8L,9L,4L,7L,5L,1L,8L,9L,5L,3L,6L,0L,4L,1L,6L,1L,8L,2L,0L,6L,2L,1L,8L,2L,5L,6L,7L,0L,2L,6L,2L,9L,1L,6L,0L,5L,9L,4L,5L,9L,2L,4L,8L,6L,5L,3L,5L,4L,0L,3L,6L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198125Inst : IEnumerable<long>
{
public static readonly long[] Value=A198125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198125.Bytes);
public long this[int i]=>Value[i];

public static A198125Inst Instance=new A198125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198126
{
public static readonly long[] Value={ 1L,3L,0L,3L,6L,8L,8L,2L,3L,6L,0L,8L,2L,7L,3L,1L,2L,3L,6L,1L,5L,7L,9L,4L,2L,3L,4L,9L,2L,0L,1L,7L,3L,1L,5L,8L,1L,7L,1L,3L,6L,6L,2L,5L,6L,7L,7L,7L,5L,0L,6L,2L,3L,8L,8L,1L,7L,3L,8L,3L,0L,4L,5L,9L,1L,1L,6L,0L,2L,7L,0L,3L,4L,3L,4L,5L,4L,9L,4L,8L,7L,8L,0L,3L,8L,4L,4L,5L,0L,8L,7L,1L,0L,4L,7L,6L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198126Inst : IEnumerable<long>
{
public static readonly long[] Value=A198126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198126.Bytes);
public long this[int i]=>Value[i];

public static A198126Inst Instance=new A198126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198127
{
public static readonly long[] Value={ 6L,8L,7L,2L,2L,8L,2L,9L,2L,2L,5L,2L,5L,4L,8L,8L,5L,4L,0L,1L,5L,3L,6L,6L,7L,6L,6L,9L,9L,7L,6L,1L,9L,0L,5L,2L,1L,7L,1L,1L,1L,6L,2L,1L,1L,9L,2L,3L,5L,6L,6L,2L,5L,0L,8L,5L,0L,8L,0L,1L,0L,4L,6L,0L,3L,6L,6L,6L,7L,9L,0L,0L,1L,1L,4L,7L,5L,2L,4L,3L,9L,0L,6L,9L,9L,0L,9L,2L,7L,7L,9L,3L,6L,1L,8L,3L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198127Inst : IEnumerable<long>
{
public static readonly long[] Value=A198127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198127.Bytes);
public long this[int i]=>Value[i];

public static A198127Inst Instance=new A198127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198128
{
public static readonly long[] Value={ 2L,7L,1L,8L,3L,1L,8L,5L,1L,8L,9L,5L,8L,0L,5L,9L,0L,7L,1L,8L,6L,8L,8L,2L,0L,3L,3L,3L,5L,8L,8L,3L,9L,7L,6L,2L,7L,5L,0L,2L,0L,4L,9L,6L,5L,7L,2L,7L,6L,0L,5L,9L,5L,0L,8L,2L,5L,3L,0L,1L,4L,3L,8L,9L,5L,8L,6L,4L,8L,6L,0L,0L,8L,2L,1L,5L,1L,5L,5L,6L,7L,9L,0L,9L,3L,5L,2L,1L,7L,2L,9L,6L,5L,7L,5L,2L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198128Inst : IEnumerable<long>
{
public static readonly long[] Value=A198128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198128.Bytes);
public long this[int i]=>Value[i];

public static A198128Inst Instance=new A198128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198129
{
public static readonly long[] Value={ 1L,5L,1L,7L,5L,3L,8L,9L,8L,0L,6L,6L,1L,4L,8L,2L,2L,4L,4L,8L,3L,2L,7L,4L,6L,9L,8L,6L,3L,9L,0L,8L,1L,1L,5L,0L,8L,0L,9L,9L,5L,0L,7L,1L,0L,7L,8L,4L,5L,4L,2L,2L,8L,5L,8L,6L,9L,0L,1L,4L,6L,0L,6L,0L,6L,1L,6L,8L,2L,6L,6L,7L,2L,5L,9L,4L,1L,1L,6L,4L,7L,4L,3L,7L,3L,9L,2L,5L,7L,7L,1L,3L,3L,9L,9L,5L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198129Inst : IEnumerable<long>
{
public static readonly long[] Value=A198129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198129.Bytes);
public long this[int i]=>Value[i];

public static A198129Inst Instance=new A198129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198130
{
public static readonly long[] Value={ 1L,5L,2L,7L,9L,9L,9L,7L,1L,2L,0L,3L,6L,8L,4L,0L,6L,3L,3L,5L,2L,0L,8L,3L,6L,6L,9L,3L,8L,8L,8L,9L,0L,4L,6L,6L,3L,6L,7L,6L,3L,7L,5L,9L,3L,9L,9L,4L,1L,6L,2L,5L,9L,9L,2L,0L,8L,7L,2L,7L,8L,7L,3L,2L,5L,4L,0L,3L,7L,9L,1L,6L,5L,3L,5L,9L,8L,1L,0L,2L,5L,1L,2L,5L,7L,5L,0L,2L,9L,4L,2L,8L,6L,0L,8L,7L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198130Inst : IEnumerable<long>
{
public static readonly long[] Value=A198130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198130.Bytes);
public long this[int i]=>Value[i];

public static A198130Inst Instance=new A198130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198131
{
public static readonly long[] Value={ 4L,5L,8L,0L,6L,1L,0L,8L,6L,8L,3L,0L,8L,3L,8L,0L,4L,8L,9L,0L,4L,1L,5L,6L,4L,9L,0L,0L,2L,3L,1L,2L,5L,5L,1L,2L,7L,0L,2L,4L,9L,8L,7L,8L,6L,0L,0L,9L,3L,5L,4L,9L,1L,0L,7L,2L,4L,6L,7L,3L,8L,6L,2L,7L,8L,9L,3L,1L,6L,8L,3L,4L,2L,1L,8L,1L,7L,8L,3L,0L,4L,3L,6L,0L,4L,6L,3L,6L,2L,8L,4L,6L,3L,6L,3L,6L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198131Inst : IEnumerable<long>
{
public static readonly long[] Value=A198131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198131.Bytes);
public long this[int i]=>Value[i];

public static A198131Inst Instance=new A198131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198132
{
public static readonly long[] Value={ 1L,5L,3L,4L,9L,8L,6L,3L,2L,2L,6L,2L,0L,3L,0L,7L,2L,0L,5L,9L,6L,9L,6L,6L,2L,5L,2L,0L,2L,0L,1L,4L,1L,4L,6L,4L,6L,5L,4L,0L,8L,2L,1L,6L,5L,4L,7L,0L,5L,9L,7L,1L,6L,5L,0L,7L,7L,5L,9L,7L,1L,3L,7L,3L,8L,6L,3L,2L,5L,9L,7L,9L,0L,1L,2L,8L,7L,4L,8L,9L,8L,8L,8L,9L,7L,7L,8L,2L,4L,6L,8L,0L,7L,1L,3L,5L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198132Inst : IEnumerable<long>
{
public static readonly long[] Value=A198132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198132.Bytes);
public long this[int i]=>Value[i];

public static A198132Inst Instance=new A198132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198133
{
public static readonly long[] Value={ 5L,9L,3L,7L,8L,0L,8L,1L,2L,6L,7L,9L,1L,5L,9L,0L,3L,7L,6L,6L,0L,8L,1L,6L,4L,5L,5L,6L,1L,0L,9L,9L,4L,7L,8L,4L,6L,8L,2L,5L,0L,7L,3L,4L,4L,8L,9L,8L,0L,6L,8L,7L,9L,9L,6L,6L,1L,0L,5L,7L,3L,4L,5L,7L,0L,3L,4L,7L,3L,5L,1L,7L,4L,8L,9L,9L,2L,7L,6L,1L,0L,6L,0L,3L,6L,9L,0L,2L,9L,3L,1L,1L,7L,3L,8L,6L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198133Inst : IEnumerable<long>
{
public static readonly long[] Value=A198133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198133.Bytes);
public long this[int i]=>Value[i];

public static A198133Inst Instance=new A198133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198134
{
public static readonly long[] Value={ 1L,5L,3L,9L,9L,9L,5L,2L,2L,7L,2L,6L,6L,8L,3L,9L,0L,8L,1L,8L,0L,5L,9L,8L,8L,5L,8L,0L,2L,0L,4L,0L,5L,4L,2L,5L,3L,5L,5L,4L,3L,3L,5L,8L,2L,9L,2L,4L,3L,1L,7L,9L,4L,9L,6L,0L,9L,4L,6L,6L,9L,4L,6L,6L,3L,8L,4L,5L,0L,1L,2L,5L,0L,3L,2L,8L,3L,5L,1L,3L,8L,9L,7L,0L,5L,5L,5L,3L,7L,9L,3L,3L,0L,0L,3L,6L,7L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198134Inst : IEnumerable<long>
{
public static readonly long[] Value=A198134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198134.Bytes);
public long this[int i]=>Value[i];

public static A198134Inst Instance=new A198134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198135
{
public static readonly long[] Value={ 6L,9L,7L,5L,3L,4L,5L,5L,5L,2L,2L,8L,4L,1L,2L,9L,9L,3L,7L,9L,5L,1L,7L,4L,0L,6L,6L,2L,5L,2L,1L,2L,9L,8L,8L,7L,4L,6L,5L,4L,7L,9L,0L,3L,6L,1L,1L,5L,3L,4L,4L,7L,5L,7L,6L,5L,0L,6L,4L,9L,3L,5L,8L,6L,6L,2L,0L,1L,5L,2L,5L,6L,1L,6L,3L,4L,3L,2L,5L,0L,2L,2L,8L,7L,2L,3L,3L,1L,4L,5L,0L,3L,7L,7L,5L,7L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198135Inst : IEnumerable<long>
{
public static readonly long[] Value=A198135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198135.Bytes);
public long this[int i]=>Value[i];

public static A198135Inst Instance=new A198135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198136
{
public static readonly long[] Value={ 8L,5L,8L,7L,6L,9L,7L,1L,3L,6L,9L,7L,6L,1L,4L,4L,2L,1L,1L,9L,3L,1L,0L,4L,3L,2L,1L,8L,1L,0L,5L,3L,3L,0L,8L,6L,1L,1L,8L,5L,6L,5L,7L,7L,3L,4L,6L,8L,7L,1L,4L,7L,4L,5L,8L,5L,1L,7L,3L,6L,1L,6L,4L,0L,8L,0L,2L,9L,2L,2L,0L,6L,4L,7L,4L,8L,6L,2L,6L,4L,9L,1L,8L,3L,9L,5L,6L,3L,6L,3L,9L,4L,4L,5L,2L,3L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198136Inst : IEnumerable<long>
{
public static readonly long[] Value=A198136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198136.Bytes);
public long this[int i]=>Value[i];

public static A198136Inst Instance=new A198136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198137
{
public static readonly long[] Value={ 2L,4L,7L,6L,6L,1L,6L,9L,7L,4L,0L,6L,6L,8L,1L,7L,0L,8L,1L,0L,1L,9L,2L,7L,2L,6L,4L,1L,7L,3L,2L,2L,4L,7L,7L,4L,8L,4L,0L,2L,1L,0L,1L,7L,7L,8L,4L,7L,1L,8L,8L,6L,3L,1L,2L,1L,4L,1L,4L,7L,7L,7L,8L,9L,2L,1L,6L,0L,7L,4L,0L,2L,1L,6L,0L,6L,7L,7L,5L,5L,2L,1L,6L,4L,6L,7L,3L,7L,0L,4L,4L,9L,7L,2L,1L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198137Inst : IEnumerable<long>
{
public static readonly long[] Value=A198137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198137.Bytes);
public long this[int i]=>Value[i];

public static A198137Inst Instance=new A198137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198138
{
public static readonly long[] Value={ 1L,4L,4L,7L,0L,5L,7L,1L,5L,1L,0L,4L,1L,6L,5L,5L,0L,7L,8L,7L,7L,9L,4L,7L,1L,6L,8L,1L,4L,4L,9L,8L,8L,0L,6L,2L,7L,5L,0L,5L,7L,7L,2L,9L,3L,2L,5L,5L,0L,6L,3L,6L,8L,9L,6L,4L,8L,9L,5L,3L,3L,6L,2L,9L,5L,4L,9L,4L,1L,3L,3L,4L,8L,1L,0L,8L,7L,4L,9L,3L,3L,3L,4L,4L,2L,9L,6L,6L,7L,5L,8L,2L,5L,8L,1L,5L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198138Inst : IEnumerable<long>
{
public static readonly long[] Value=A198138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198138.Bytes);
public long this[int i]=>Value[i];

public static A198138Inst Instance=new A198138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198139
{
public static readonly long[] Value={ 5L,8L,1L,7L,2L,0L,0L,7L,9L,7L,3L,1L,6L,5L,9L,7L,2L,2L,8L,4L,2L,8L,6L,5L,9L,2L,3L,2L,7L,1L,4L,8L,8L,2L,7L,4L,9L,0L,7L,5L,9L,9L,1L,9L,8L,4L,9L,2L,8L,9L,2L,5L,9L,8L,6L,9L,8L,4L,4L,3L,4L,7L,2L,5L,8L,1L,1L,3L,0L,3L,7L,5L,4L,1L,9L,5L,2L,2L,4L,1L,8L,7L,9L,2L,9L,8L,8L,4L,1L,3L,4L,0L,5L,2L,8L,0L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198139Inst : IEnumerable<long>
{
public static readonly long[] Value=A198139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198139.Bytes);
public long this[int i]=>Value[i];

public static A198139Inst Instance=new A198139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198140
{
public static readonly long[] Value={ 1L,2L,5L,3L,6L,1L,0L,6L,2L,9L,1L,6L,6L,5L,3L,9L,5L,8L,6L,3L,0L,7L,8L,4L,2L,4L,6L,6L,9L,4L,5L,2L,8L,3L,6L,2L,9L,0L,4L,8L,3L,2L,4L,7L,5L,0L,4L,3L,8L,3L,7L,1L,0L,9L,8L,0L,1L,6L,4L,0L,4L,1L,5L,6L,2L,6L,9L,3L,3L,9L,6L,8L,3L,2L,5L,3L,3L,8L,1L,0L,4L,3L,4L,3L,6L,1L,8L,3L,7L,6L,4L,0L,4L,0L,0L,9L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198140Inst : IEnumerable<long>
{
public static readonly long[] Value=A198140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198140.Bytes);
public long this[int i]=>Value[i];

public static A198140Inst Instance=new A198140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198141
{
public static readonly long[] Value={ 2L,9L,9L,1L,5L,5L,6L,4L,2L,3L,8L,9L,7L,8L,6L,3L,5L,6L,2L,5L,7L,2L,7L,2L,2L,6L,4L,8L,2L,4L,8L,2L,2L,0L,3L,1L,6L,6L,9L,8L,5L,0L,9L,3L,6L,1L,0L,2L,4L,7L,3L,4L,2L,9L,4L,1L,6L,9L,7L,2L,9L,1L,2L,9L,6L,6L,4L,2L,0L,4L,8L,6L,1L,7L,9L,0L,1L,0L,8L,8L,4L,7L,2L,4L,5L,1L,2L,0L,5L,8L,3L,1L,8L,1L,3L,8L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198141Inst : IEnumerable<long>
{
public static readonly long[] Value=A198141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198141.Bytes);
public long this[int i]=>Value[i];

public static A198141Inst Instance=new A198141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198142
{
public static readonly long[] Value={ 8L,9L,2L,9L,1L,0L,7L,1L,1L,4L,1L,7L,7L,7L,5L,2L,7L,3L,7L,3L,9L,9L,6L,8L,3L,1L,8L,3L,1L,7L,0L,4L,5L,6L,9L,8L,6L,9L,3L,9L,7L,7L,5L,0L,3L,1L,2L,4L,3L,6L,6L,5L,2L,2L,8L,2L,9L,0L,2L,9L,8L,6L,4L,1L,2L,7L,0L,7L,0L,4L,6L,7L,0L,0L,5L,0L,2L,4L,0L,7L,4L,7L,2L,4L,8L,9L,6L,6L,3L,4L,0L,7L,0L,3L,0L,0L,6L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198142Inst : IEnumerable<long>
{
public static readonly long[] Value=A198142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198142.Bytes);
public long this[int i]=>Value[i];

public static A198142Inst Instance=new A198142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198143
{
public static readonly long[] Value={ 3L,6L,9L,2L,3L,4L,7L,7L,7L,3L,9L,2L,7L,9L,8L,9L,8L,6L,0L,1L,8L,2L,8L,4L,7L,7L,0L,6L,2L,9L,9L,4L,0L,1L,0L,4L,9L,8L,7L,2L,7L,9L,3L,8L,2L,1L,9L,3L,0L,3L,1L,4L,4L,1L,9L,0L,0L,1L,4L,4L,4L,4L,4L,2L,3L,9L,5L,3L,1L,0L,9L,9L,2L,4L,3L,7L,1L,6L,5L,6L,8L,5L,9L,2L,7L,2L,9L,3L,0L,3L,0L,9L,1L,7L,2L,5L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198143Inst : IEnumerable<long>
{
public static readonly long[] Value=A198143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198143.Bytes);
public long this[int i]=>Value[i];

public static A198143Inst Instance=new A198143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198144
{
public static readonly long[] Value={ 6L,9L,6L,5L,8L,5L,8L,4L,7L,7L,7L,9L,0L,6L,5L,8L,0L,1L,9L,8L,6L,5L,9L,2L,4L,3L,4L,6L,3L,2L,7L,5L,4L,3L,5L,8L,8L,5L,5L,9L,0L,0L,5L,4L,6L,0L,3L,5L,9L,3L,5L,5L,5L,7L,7L,8L,4L,6L,5L,4L,9L,7L,8L,7L,6L,5L,8L,8L,3L,8L,9L,3L,3L,9L,9L,4L,9L,1L,0L,8L,6L,8L,4L,8L,8L,2L,3L,0L,7L,8L,6L,1L,8L,6L,4L,0L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198144Inst : IEnumerable<long>
{
public static readonly long[] Value=A198144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198144.Bytes);
public long this[int i]=>Value[i];

public static A198144Inst Instance=new A198144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198145
{
public static readonly long[] Value={ 4L,2L,8L,8L,0L,4L,7L,6L,2L,3L,7L,0L,3L,1L,3L,6L,5L,7L,8L,7L,4L,5L,8L,0L,0L,0L,2L,7L,8L,7L,8L,9L,3L,6L,9L,7L,4L,6L,5L,9L,5L,3L,7L,8L,2L,3L,7L,0L,2L,3L,6L,5L,0L,1L,5L,5L,8L,5L,6L,6L,2L,1L,8L,9L,2L,2L,3L,3L,0L,1L,5L,6L,0L,6L,6L,1L,5L,1L,5L,5L,9L,1L,5L,4L,8L,6L,9L,7L,8L,7L,5L,4L,5L,1L,9L,7L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198145Inst : IEnumerable<long>
{
public static readonly long[] Value=A198145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198145.Bytes);
public long this[int i]=>Value[i];

public static A198145Inst Instance=new A198145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198146
{
public static readonly long[] Value={ 2293L,2393L,2591L,2693L,2791L,2903L,2957L,5297L,5927L,7297L,7927L,8293L,8923L,9203L,9257L,9323L,9521L,9623L,9721L,9923L,12491L,12497L,12907L,12911L,12967L,12973L,13291L,13921L,14293L,14923L,17291L,17293L,17921L,17923L,19207L,19211L,19267L,19273L,19421L,19427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198146Inst : IEnumerable<long>
{
public static readonly long[] Value=A198146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198146.Bytes);
public long this[int i]=>Value[i];

public static A198146Inst Instance=new A198146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198147
{
public static readonly long[] Value={ 27L,32L,54L,64L,81L,96L,100L,108L,125L,128L,135L,147L,160L,162L,189L,192L,200L,216L,224L,243L,250L,260L,270L,273L,288L,294L,297L,300L,320L,324L,340L,343L,351L,352L,375L,378L,399L,400L,405L,416L,432L,441L,448L,459L,480L,486L,500L,507L,513L,520L,540L,546L,567L,580L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198147Inst : IEnumerable<long>
{
public static readonly long[] Value=A198147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198147.Bytes);
public long this[int i]=>Value[i];

public static A198147Inst Instance=new A198147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198148
{
public static readonly long[] Value={ 0L,3L,1L,15L,3L,35L,6L,63L,10L,99L,15L,143L,21L,195L,28L,255L,36L,323L,45L,399L,55L,483L,66L,575L,78L,675L,91L,783L,105L,899L,120L,1023L,136L,1155L,153L,1295L,171L,1443L,190L,1599L,210L,1763L,231L,1935L,253L,2115L,276L,2303L,300L,2499L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198148Inst : IEnumerable<long>
{
public static readonly long[] Value=A198148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198148.Bytes);
public long this[int i]=>Value[i];

public static A198148Inst Instance=new A198148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198149
{
public static readonly long[] Value={ 1L,7L,54L,2093L,260917L,108428600L,147146211014L,642756367398421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198149Inst : IEnumerable<long>
{
public static readonly long[] Value=A198149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198149.Bytes);
public long this[int i]=>Value[i];

public static A198149Inst Instance=new A198149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198150
{
public static readonly long[] Value={ 2L,12L,54L,240L,1170L,5330L,24689L,116890L,549479L,2578328L,12131698L,57065922L,268256602L,1261383897L,5931754425L,27891320698L,131147135601L,616682910805L,2899744304684L,13635001788168L,64114012351029L,301474577118884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198150Inst : IEnumerable<long>
{
public static readonly long[] Value=A198150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198150.Bytes);
public long this[int i]=>Value[i];

public static A198150Inst Instance=new A198150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198151
{
public static readonly long[] Value={ 3L,31L,240L,2093L,17991L,145266L,1255491L,10755887L,91079908L,776489747L,6609595197L,56225308358L,478661740841L,4073710243375L,34669903065204L,295087373696575L,2511459871139255L,21374984840018414L,181923479457037295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198151Inst : IEnumerable<long>
{
public static readonly long[] Value=A198151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198151.Bytes);
public long this[int i]=>Value[i];

public static A198151Inst Instance=new A198151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198152
{
public static readonly long[] Value={ 5L,79L,1170L,17991L,260917L,3964286L,61513749L,932035559L,14154918386L,215575583089L,3280040161825L,49908649333492L,759419186812363L,11555623785446115L,175836452139467978L,2675566091089841463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198152Inst : IEnumerable<long>
{
public static readonly long[] Value=A198152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198152.Bytes);
public long this[int i]=>Value[i];

public static A198152Inst Instance=new A198152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198153
{
public static readonly BigInteger[] Value={ 8L,186L,5330L,145266L,3964286L,108428600L,2969407571L,81119721484L,2220541431613L,60728204921422L,1660150662376018L,45410172854910038L,1241951689613745110L,BigInteger.Parse("33963196923739786489"),BigInteger.Parse("928843844069002393595") };
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
public class A198153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198153Inst Instance=new A198153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198154
{
public static readonly BigInteger[] Value={ 13L,465L,24689L,1255491L,61513749L,2969407571L,147146211014L,7259079414491L,356611993766901L,17542851737213231L,863257429585871111L,BigInteger.Parse("42468055861968831263"),BigInteger.Parse("2089291751765730194449"),BigInteger.Parse("102792392272753053884368") };
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
public class A198154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198154Inst Instance=new A198154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198155
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,12L,12L,3L,5L,31L,54L,31L,5L,8L,79L,240L,240L,79L,8L,13L,186L,1170L,2093L,1170L,186L,13L,21L,465L,5330L,17991L,17991L,5330L,465L,21L,34L,1131L,24689L,145266L,260917L,145266L,24689L,1131L,34L,55L,2776L,116890L,1255491L,3964286L,3964286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198155Inst : IEnumerable<long>
{
public static readonly long[] Value=A198155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198155.Bytes);
public long this[int i]=>Value[i];

public static A198155Inst Instance=new A198155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198156
{
public static readonly long[] Value={ 1L,4L,10L,116L,2862L,51686L,4052747L,435035530L,65207007652L,27807146172472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198156Inst : IEnumerable<long>
{
public static readonly long[] Value=A198156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198156.Bytes);
public long this[int i]=>Value[i];

public static A198156Inst Instance=new A198156Inst();

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