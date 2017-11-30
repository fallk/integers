using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A285320
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,1L,4L,1L,0L,0L,2L,1L,0L,1L,1L,5L,0L,1L,0L,1L,0L,3L,2L,1L,0L,0L,2L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,3L,0L,1L,2L,1L,0L,0L,2L,1L,0L,0L,0L,3L,0L,1L,0L,1L,0L,3L,1L,1L,0L,1L,1L,0L,0L,1L,2L,1L,0L,3L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285320Inst : IEnumerable<long>
{
public static readonly long[] Value=A285320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285320.Bytes);
public long this[int i]=>Value[i];

public static A285320Inst Instance=new A285320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285321
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,8L,5L,12L,27L,16L,10L,25L,18L,81L,32L,15L,20L,125L,24L,243L,64L,30L,45L,40L,625L,36L,729L,128L,7L,60L,75L,50L,3125L,48L,2187L,256L,14L,49L,90L,135L,80L,15625L,54L,6561L,512L,21L,28L,343L,120L,225L,100L,78125L,72L,19683L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285321Inst : IEnumerable<long>
{
public static readonly long[] Value=A285321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285321.Bytes);
public long this[int i]=>Value[i];

public static A285321Inst Instance=new A285321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285322
{
public static readonly long[] Value={ 2L,4L,3L,8L,9L,6L,16L,27L,12L,5L,32L,81L,18L,25L,10L,64L,243L,24L,125L,20L,15L,128L,729L,36L,625L,40L,45L,30L,256L,2187L,48L,3125L,50L,75L,60L,7L,512L,6561L,54L,15625L,80L,135L,90L,49L,14L,1024L,19683L,72L,78125L,100L,225L,120L,343L,28L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285322Inst : IEnumerable<long>
{
public static readonly long[] Value=A285322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285322.Bytes);
public long this[int i]=>Value[i];

public static A285322Inst Instance=new A285322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285323
{
public static readonly long[] Value={ 1L,4L,9L,3L,25L,4L,5L,3L,49L,4L,7L,3L,7L,4L,5L,3L,121L,4L,9L,3L,11L,4L,5L,3L,11L,4L,7L,3L,7L,4L,5L,3L,169L,4L,9L,3L,13L,4L,5L,3L,13L,4L,7L,3L,7L,4L,5L,3L,13L,4L,9L,3L,11L,4L,5L,3L,11L,4L,7L,3L,7L,4L,5L,3L,289L,4L,9L,3L,17L,4L,5L,3L,17L,4L,7L,3L,7L,4L,5L,3L,17L,4L,9L,3L,11L,4L,5L,3L,11L,4L,7L,3L,7L,4L,5L,3L,17L,4L,9L,3L,13L,4L,5L,3L,13L,4L,7L,3L,7L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285323Inst : IEnumerable<long>
{
public static readonly long[] Value=A285323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285323.Bytes);
public long this[int i]=>Value[i];

public static A285323Inst Instance=new A285323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285324
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,4L,1L,3L,1L,3L,1L,2L,1L,5L,1L,2L,1L,4L,1L,2L,1L,4L,1L,3L,1L,3L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,5L,1L,3L,1L,3L,1L,2L,1L,5L,1L,2L,1L,4L,1L,2L,1L,4L,1L,3L,1L,3L,1L,2L,1L,7L,1L,2L,1L,6L,1L,2L,1L,6L,1L,3L,1L,3L,1L,2L,1L,6L,1L,2L,1L,4L,1L,2L,1L,4L,1L,3L,1L,3L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,5L,1L,3L,1L,3L,1L,2L,1L,5L,1L,2L,1L,4L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285324Inst : IEnumerable<long>
{
public static readonly long[] Value=A285324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285324.Bytes);
public long this[int i]=>Value[i];

public static A285324Inst Instance=new A285324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285325
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,4L,6L,4L,5L,8L,5L,8L,5L,6L,6L,12L,5L,10L,6L,7L,8L,7L,16L,6L,12L,7L,8L,8L,10L,9L,20L,6L,14L,8L,9L,16L,9L,10L,8L,24L,7L,16L,9L,10L,10L,24L,9L,12L,10L,28L,7L,18L,10L,11L,12L,11L,32L,11L,14L,9L,32L,7L,20L,11L,12L,12L,18L,17L,40L,10L,12L,11L,36L,8L,22L,12L,13L,16L,13L,14L,12L,48L,10L,14L,13L,40L,8L,24L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285325Inst : IEnumerable<long>
{
public static readonly long[] Value=A285325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285325.Bytes);
public long this[int i]=>Value[i];

public static A285325Inst Instance=new A285325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285326
{
public static readonly long[] Value={ 0L,2L,4L,4L,8L,6L,8L,8L,16L,10L,12L,12L,16L,14L,16L,16L,32L,18L,20L,20L,24L,22L,24L,24L,32L,26L,28L,28L,32L,30L,32L,32L,64L,34L,36L,36L,40L,38L,40L,40L,48L,42L,44L,44L,48L,46L,48L,48L,64L,50L,52L,52L,56L,54L,56L,56L,64L,58L,60L,60L,64L,62L,64L,64L,128L,66L,68L,68L,72L,70L,72L,72L,80L,74L,76L,76L,80L,78L,80L,80L,96L,82L,84L,84L,88L,86L,88L,88L,96L,90L,92L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285326Inst : IEnumerable<long>
{
public static readonly long[] Value=A285326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285326.Bytes);
public long this[int i]=>Value[i];

public static A285326Inst Instance=new A285326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285327
{
public static readonly long[] Value={ 0L,3L,6L,5L,12L,7L,10L,9L,24L,11L,18L,13L,20L,15L,18L,17L,48L,19L,22L,21L,36L,23L,26L,25L,40L,27L,34L,29L,36L,31L,34L,33L,96L,35L,38L,37L,68L,39L,42L,41L,72L,43L,50L,45L,52L,47L,50L,49L,80L,51L,54L,53L,68L,55L,58L,57L,72L,59L,66L,61L,68L,63L,66L,65L,192L,67L,70L,69L,132L,71L,74L,73L,136L,75L,82L,77L,84L,79L,82L,81L,144L,83L,86L,85L,100L,87L,90L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285327Inst : IEnumerable<long>
{
public static readonly long[] Value=A285327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285327.Bytes);
public long this[int i]=>Value[i];

public static A285327Inst Instance=new A285327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285328
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,4L,3L,1L,1L,6L,1L,1L,1L,8L,1L,12L,1L,10L,1L,1L,1L,18L,5L,1L,9L,14L,1L,1L,1L,16L,1L,1L,1L,24L,1L,1L,1L,20L,1L,1L,1L,22L,15L,1L,1L,36L,7L,40L,1L,26L,1L,48L,1L,28L,1L,1L,1L,30L,1L,1L,21L,32L,1L,1L,1L,34L,1L,1L,1L,54L,1L,1L,45L,38L,1L,1L,1L,50L,27L,1L,1L,42L,1L,1L,1L,44L,1L,60L,1L,46L,1L,1L,1L,72L,1L,56L,33L,80L,1L,1L,1L,52L,1L,1L,1L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285328Inst : IEnumerable<long>
{
public static readonly long[] Value=A285328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285328.Bytes);
public long this[int i]=>Value[i];

public static A285328Inst Instance=new A285328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285329
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,4L,5L,1L,2L,6L,7L,4L,8L,9L,10L,1L,11L,4L,12L,6L,13L,14L,15L,4L,3L,16L,2L,9L,17L,18L,19L,1L,20L,21L,22L,4L,23L,24L,25L,6L,26L,27L,28L,14L,10L,29L,30L,4L,5L,6L,31L,16L,32L,4L,33L,9L,34L,35L,36L,18L,37L,38L,13L,1L,39L,40L,41L,21L,42L,43L,44L,4L,45L,46L,10L,24L,47L,48L,49L,6L,2L,50L,51L,27L,52L,53L,54L,14L,55L,18L,56L,29L,57L,58L,59L,4L,60L,9L,20L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285329Inst : IEnumerable<long>
{
public static readonly long[] Value=A285329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285329.Bytes);
public long this[int i]=>Value[i];

public static A285329Inst Instance=new A285329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285330
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,3L,8L,4L,3L,5L,16L,6L,32L,9L,6L,8L,64L,12L,128L,10L,10L,17L,256L,18L,5L,33L,9L,14L,512L,7L,1024L,16L,18L,65L,12L,24L,2048L,129L,34L,20L,4096L,11L,8192L,22L,15L,257L,16384L,36L,7L,40L,66L,26L,32768L,48L,20L,28L,130L,513L,65536L,30L,131072L,1025L,21L,32L,36L,19L,262144L,34L,258L,13L,524288L,54L,1048576L,2049L,45L,38L,24L,35L,2097152L,50L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285330Inst : IEnumerable<long>
{
public static readonly long[] Value=A285330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285330.Bytes);
public long this[int i]=>Value[i];

public static A285330Inst Instance=new A285330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285331
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,4L,14L,7L,5L,12L,30L,9L,62L,10L,8L,15L,126L,19L,254L,25L,24L,252L,510L,39L,13L,76L,11L,21L,1022L,28L,2046L,31L,38L,316L,18L,79L,4094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285331Inst : IEnumerable<long>
{
public static readonly long[] Value=A285331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285331.Bytes);
public long this[int i]=>Value[i];

public static A285331Inst Instance=new A285331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285460
{
public static readonly long[] Value={ 1L,1L,3L,6L,14L,25L,51L,92L,175L,308L,554L,957L,1670L,2820L,4778L,7940L,13169L,21511L,35032L,56405L,90453L,143716L,227342L,356950L,557977L,866588L,1340109L,2060912L,3156274L,4810016L,7301490L,11034661L,16614681L,24916208L,37234864L,55440054L,82274277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285460Inst : IEnumerable<long>
{
public static readonly long[] Value=A285460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285460.Bytes);
public long this[int i]=>Value[i];

public static A285460Inst Instance=new A285460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285461
{
public static readonly long[] Value={ 1L,1L,3L,6L,13L,25L,49L,89L,166L,295L,526L,909L,1571L,2657L,4475L,7432L,12257L,20000L,32436L,52126L,83285L,132057L,208221L,326202L,508372L,787777L,1214828L,1863932L,2847020L,4328765L,6554359L,9882795L,14843999L,22210386L,33112817L,49192218L,72834243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285461Inst : IEnumerable<long>
{
public static readonly long[] Value=A285461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285461.Bytes);
public long this[int i]=>Value[i];

public static A285461Inst Instance=new A285461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285462
{
public static readonly long[] Value={ 1L,1L,4L,7L,18L,32L,72L,127L,257L,454L,861L,1497L,2719L,4654L,8171L,13781L,23564L,39159L,65559L,107455L,176712L,286000L,463200L,740910L,1184123L,1873656L,2959376L,4636145L,7245680L,11246590L,17409731L,26792371L,41114202L,62769820L,95553779L,144803917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285462Inst : IEnumerable<long>
{
public static readonly long[] Value=A285462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285462.Bytes);
public long this[int i]=>Value[i];

public static A285462Inst Instance=new A285462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285463
{
public static readonly long[] Value={ 349L,936227L,241853952611L,248296403939L,402089961397L,14290027171787L,22798543031501L,25498249343221L,928194481893587L,1108961833390907L,56735483914668107L,56840981804535371L,65947215239750827L,67113509914884011L,90309903454333957L,97912610367958237L,99307055366487077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285463Inst : IEnumerable<long>
{
public static readonly long[] Value=A285463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285463.Bytes);
public long this[int i]=>Value[i];

public static A285463Inst Instance=new A285463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285464
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285464Inst : IEnumerable<long>
{
public static readonly long[] Value=A285464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285464.Bytes);
public long this[int i]=>Value[i];

public static A285464Inst Instance=new A285464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285465
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,45L,47L,48L,49L,51L,52L,53L,55L,56L,57L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,99L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285465Inst : IEnumerable<long>
{
public static readonly long[] Value=A285465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285465.Bytes);
public long this[int i]=>Value[i];

public static A285465Inst Instance=new A285465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285466
{
public static readonly long[] Value={ 4L,8L,12L,16L,20L,24L,25L,26L,27L,28L,29L,30L,34L,38L,42L,46L,50L,54L,58L,59L,60L,61L,62L,63L,64L,68L,72L,76L,80L,84L,88L,92L,93L,94L,95L,96L,97L,98L,102L,106L,110L,114L,118L,122L,126L,127L,128L,129L,130L,131L,132L,136L,140L,144L,148L,152L,156L,160L,161L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285466Inst : IEnumerable<long>
{
public static readonly long[] Value=A285466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285466.Bytes);
public long this[int i]=>Value[i];

public static A285466Inst Instance=new A285466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285467
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285467Inst : IEnumerable<long>
{
public static readonly long[] Value=A285467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285467.Bytes);
public long this[int i]=>Value[i];

public static A285467Inst Instance=new A285467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285468
{
public static readonly long[] Value={ 7L,8L,9L,17L,18L,19L,27L,28L,29L,37L,38L,39L,47L,48L,49L,57L,58L,59L,61L,62L,63L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,91L,92L,93L,101L,102L,103L,111L,112L,113L,121L,122L,123L,131L,132L,133L,141L,142L,143L,151L,152L,153L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285468Inst : IEnumerable<long>
{
public static readonly long[] Value=A285468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285468.Bytes);
public long this[int i]=>Value[i];

public static A285468Inst Instance=new A285468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285469
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,11L,12L,13L,14L,15L,16L,20L,21L,22L,23L,24L,25L,26L,30L,31L,32L,33L,34L,35L,36L,40L,41L,42L,43L,44L,45L,46L,50L,51L,52L,53L,54L,55L,56L,60L,64L,68L,72L,76L,80L,84L,85L,86L,87L,88L,89L,90L,94L,95L,96L,97L,98L,99L,100L,104L,105L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285469Inst : IEnumerable<long>
{
public static readonly long[] Value=A285469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285469.Bytes);
public long this[int i]=>Value[i];

public static A285469Inst Instance=new A285469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285470
{
public static readonly long[] Value={ 12L,22L,32L,42L,52L,62L,72L,82L,92L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,220L,221L,222L,223L,224L,225L,226L,227L,228L,229L,320L,321L,322L,323L,324L,325L,326L,327L,328L,329L,420L,421L,422L,423L,424L,425L,426L,427L,428L,429L,520L,521L,522L,523L,524L,525L,526L,527L,528L,529L,620L,621L,622L,623L,624L,625L,626L,627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285470Inst : IEnumerable<long>
{
public static readonly long[] Value=A285470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285470.Bytes);
public long this[int i]=>Value[i];

public static A285470Inst Instance=new A285470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285471
{
public static readonly long[] Value={ 1L,3L,0L,5L,7L,9L,2L,20L,13L,15L,4L,18L,31L,38L,33L,35L,21L,8L,34L,37L,23L,17L,19L,6L,11L,78L,28L,50L,51L,25L,61L,39L,29L,81L,10L,16L,53L,27L,80L,14L,55L,57L,22L,59L,83L,30L,58L,85L,65L,12L,43L,70L,40L,71L,32L,52L,41L,73L,45L,47L,72L,42L,75L,49L,24L,54L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285471Inst : IEnumerable<long>
{
public static readonly long[] Value=A285471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285471.Bytes);
public long this[int i]=>Value[i];

public static A285471Inst Instance=new A285471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285472
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,13L,18L,28L,38L,55L,74L,106L,140L,192L,253L,342L,444L,588L,758L,992L,1267L,1634L,2072L,2650L,3334L,4218L,5276L,6627L,8234L,10262L,12682L,15708L,19308L,23764L,29070L,35597L,43340L,52792L,64008L,77622L,93724L,113160L,136124L,163712L,196225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285472Inst : IEnumerable<long>
{
public static readonly long[] Value=A285472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285472.Bytes);
public long this[int i]=>Value[i];

public static A285472Inst Instance=new A285472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285473
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,1L,111111L,1L,11111111L,1L,1111111111L,1L,111111111111L,1L,11111111111111L,1L,1111111111111111L,1L,111111111111111111L,1L,11111111111111111111UL,1L,BigInteger.Parse("1111111111111111111111"),1L,BigInteger.Parse("111111111111111111111111"),1L,BigInteger.Parse("11111111111111111111111111"),1L };
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
public class A285473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285473Inst Instance=new A285473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285474
{
public static readonly ulong[] Value={ 1L,11L,100L,1111L,10000L,111111L,1000000L,11111111L,100000000L,1111111111L,10000000000L,111111111111L,1000000000000L,11111111111111L,100000000000000L,1111111111111111L,10000000000000000L,111111111111111111L,1000000000000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285474Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A285474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285474.Bytes);
public ulong this[int i]=>Value[i];

public static A285474Inst Instance=new A285474Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285475
{
public static readonly long[] Value={ 1L,3L,4L,15L,16L,63L,64L,255L,256L,1023L,1024L,4095L,4096L,16383L,16384L,65535L,65536L,262143L,262144L,1048575L,1048576L,4194303L,4194304L,16777215L,16777216L,67108863L,67108864L,268435455L,268435456L,1073741823L,1073741824L,4294967295L,4294967296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285475Inst : IEnumerable<long>
{
public static readonly long[] Value=A285475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285475.Bytes);
public long this[int i]=>Value[i];

public static A285475Inst Instance=new A285475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285508
{
public static readonly long[] Value={ 8L,12L,18L,20L,27L,28L,44L,45L,50L,52L,63L,68L,75L,76L,92L,98L,99L,116L,117L,124L,125L,147L,148L,153L,164L,171L,172L,175L,188L,207L,212L,236L,242L,244L,245L,261L,268L,275L,279L,284L,292L,316L,325L,332L,333L,338L,343L,356L,363L,369L,387L,388L,404L,412L,423L,425L,428L,436L,452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285508Inst : IEnumerable<long>
{
public static readonly long[] Value=A285508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285508.Bytes);
public long this[int i]=>Value[i];

public static A285508Inst Instance=new A285508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285509
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,5L,5L,5L,5L,6L,8L,10L,10L,10L,9L,10L,10L,10L,10L,11L,13L,18L,20L,18L,15L,15L,15L,20L,20L,19L,18L,20L,20L,20L,19L,20L,20L,20L,20L,21L,23L,31L,38L,33L,28L,20L,20L,21L,30L,39L,39L,38L,30L,29L,25L,35L,40L,40L,38L,31L,33L,36L,40L,38L,40L,35L,40L,40L,40L,39L,38L,40L,40L,40L,39L,40L,40L,40L,40L,41L,43L,54L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285509Inst : IEnumerable<long>
{
public static readonly long[] Value=A285509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285509.Bytes);
public long this[int i]=>Value[i];

public static A285509Inst Instance=new A285509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285510
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,81L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285510Inst : IEnumerable<long>
{
public static readonly long[] Value=A285510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285510.Bytes);
public long this[int i]=>Value[i];

public static A285510Inst Instance=new A285510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285511
{
public static readonly long[] Value={ 9L,243L,6327L,256L,22L,581L,15115L,392999L,258L,24L,633L,16467L,428151L,16480L,646L,16805L,436939L,11360423L,16482L,648L,16857L,438291L,11395575L,438304L,16870L,438629L,11404363L,296513447L,438306L,16872L,438681L,11405715L,296548599L,11405728L,438694L,11406053L,296557387L,7710492071L,11405730L,636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285511Inst : IEnumerable<long>
{
public static readonly long[] Value=A285511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285511.Bytes);
public long this[int i]=>Value[i];

public static A285511Inst Instance=new A285511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285512
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,3L,5L,2L,3L,2L,7L,2L,3L,7L,5L,3L,5L,2L,11L,5L,7L,5L,13L,2L,5L,2L,5L,2L,11L,3L,5L,5L,3L,3L,7L,2L,3L,7L,11L,3L,11L,3L,7L,7L,5L,5L,13L,3L,3L,5L,5L,2L,5L,3L,11L,5L,3L,2L,13L,2L,3L,5L,5L,3L,7L,2L,5L,5L,19L,7L,13L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285512Inst : IEnumerable<long>
{
public static readonly long[] Value=A285512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285512.Bytes);
public long this[int i]=>Value[i];

public static A285512Inst Instance=new A285512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285513
{
public static readonly long[] Value={ 26L,41L,82L,103L,109L,151L,157L,191L,229L,251L,271L,277L,302L,311L,313L,337L,338L,362L,367L,382L,397L,409L,439L,457L,499L,542L,622L,626L,643L,674L,683L,733L,761L,769L,818L,842L,878L,911L,914L,919L,967L,971L,991L,998L,1021L,1031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285513Inst : IEnumerable<long>
{
public static readonly long[] Value=A285513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285513.Bytes);
public long this[int i]=>Value[i];

public static A285513Inst Instance=new A285513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285514
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,17L,18L,19L,22L,23L,25L,27L,29L,31L,34L,37L,38L,43L,46L,47L,49L,50L,53L,54L,58L,59L,61L,62L,67L,71L,73L,74L,79L,81L,83L,86L,89L,94L,97L,98L,101L,106L,107L,113L,118L,121L,122L,125L,127L,131L,134L,137L,139L,142L,146L,149L,158L,162L,163L,166L,167L,169L,173L,178L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285514Inst : IEnumerable<long>
{
public static readonly long[] Value=A285514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285514.Bytes);
public long this[int i]=>Value[i];

public static A285514Inst Instance=new A285514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285515
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285515Inst : IEnumerable<long>
{
public static readonly long[] Value=A285515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285515.Bytes);
public long this[int i]=>Value[i];

public static A285515Inst Instance=new A285515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285516
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,21L,23L,25L,27L,31L,33L,37L,39L,41L,43L,45L,47L,51L,53L,57L,59L,61L,63L,65L,67L,71L,73L,77L,79L,83L,85L,89L,91L,95L,97L,101L,103L,105L,107L,109L,111L,115L,117L,121L,123L,125L,127L,129L,131L,135L,137L,141L,143L,147L,149L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285516Inst : IEnumerable<long>
{
public static readonly long[] Value=A285516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285516.Bytes);
public long this[int i]=>Value[i];

public static A285516Inst Instance=new A285516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285517
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,22L,24L,26L,28L,29L,30L,32L,34L,35L,36L,38L,40L,42L,44L,46L,48L,49L,50L,52L,54L,55L,56L,58L,60L,62L,64L,66L,68L,69L,70L,72L,74L,75L,76L,78L,80L,81L,82L,84L,86L,87L,88L,90L,92L,93L,94L,96L,98L,99L,100L,102L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285517Inst : IEnumerable<long>
{
public static readonly long[] Value=A285517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285517.Bytes);
public long this[int i]=>Value[i];

public static A285517Inst Instance=new A285517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285518
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285518Inst : IEnumerable<long>
{
public static readonly long[] Value=A285518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285518.Bytes);
public long this[int i]=>Value[i];

public static A285518Inst Instance=new A285518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285519
{
public static readonly long[] Value={ 3L,5L,9L,11L,15L,17L,21L,23L,25L,27L,29L,31L,35L,37L,41L,43L,45L,47L,49L,51L,55L,57L,61L,63L,67L,69L,73L,75L,79L,81L,85L,87L,89L,91L,93L,95L,99L,101L,105L,107L,109L,111L,113L,115L,119L,121L,125L,127L,131L,133L,137L,139L,143L,145L,149L,151L,153L,155L,157L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285519Inst : IEnumerable<long>
{
public static readonly long[] Value=A285519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285519.Bytes);
public long this[int i]=>Value[i];

public static A285519Inst Instance=new A285519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285520
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,10L,12L,13L,14L,16L,18L,19L,20L,22L,24L,26L,28L,30L,32L,33L,34L,36L,38L,39L,40L,42L,44L,46L,48L,50L,52L,53L,54L,56L,58L,59L,60L,62L,64L,65L,66L,68L,70L,71L,72L,74L,76L,77L,78L,80L,82L,83L,84L,86L,88L,90L,92L,94L,96L,97L,98L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285520Inst : IEnumerable<long>
{
public static readonly long[] Value=A285520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285520.Bytes);
public long this[int i]=>Value[i];

public static A285520Inst Instance=new A285520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285521
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,3L,2L,3L,1L,2L,1L,3L,2L,3L,1L,3L,1L,4L,4L,2L,3L,2L,3L,1L,1L,4L,4L,2L,3L,1L,3L,4L,1L,5L,5L,2L,4L,3L,3L,2L,4L,1L,1L,5L,5L,2L,4L,3L,2L,1L,5L,6L,1L,7L,7L,2L,6L,3L,4L,4L,3L,6L,2L,7L,7L,1L,1L,6L,2L,5L,4L,2L,4L,1L,7L,8L,1L,9L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285521Inst : IEnumerable<long>
{
public static readonly long[] Value=A285521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285521.Bytes);
public long this[int i]=>Value[i];

public static A285521Inst Instance=new A285521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285522
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,6L,6L,4L,1L,1L,6L,18L,10L,5L,1L,1L,20L,24L,40L,15L,6L,1L,1L,14L,135L,70L,75L,21L,7L,1L,1L,48L,130L,544L,165L,126L,28L,8L,1L,1L,52L,648L,700L,1625L,336L,196L,36L,9L,1L,1L,140L,1137L,4480L,2635L,3996L,616L,288L,45L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285522Inst : IEnumerable<long>
{
public static readonly long[] Value=A285522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285522.Bytes);
public long this[int i]=>Value[i];

public static A285522Inst Instance=new A285522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285523
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,17L,18L,21L,22L,23L,27L,30L,31L,32L,34L,38L,41L,43L,46L,47L,50L,55L,57L,68L,70L,72L,73L,75L,83L,99L,117L,119L,123L,132L,133L,157L,172L,173L,182L,191L,216L,233L,239L,242L,255L,265L,268L,278L,302L,307L,319L,327L,378L,401L,411L,438L,447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285523Inst : IEnumerable<long>
{
public static readonly long[] Value=A285523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285523.Bytes);
public long this[int i]=>Value[i];

public static A285523Inst Instance=new A285523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285589
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285589Inst : IEnumerable<long>
{
public static readonly long[] Value=A285589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285589.Bytes);
public long this[int i]=>Value[i];

public static A285589Inst Instance=new A285589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285590
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,37L,39L,41L,43L,45L,47L,49L,51L,53L,56L,58L,60L,62L,64L,66L,68L,70L,72L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,98L,100L,102L,104L,106L,108L,110L,112L,114L,117L,119L,121L,124L,126L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285590Inst : IEnumerable<long>
{
public static readonly long[] Value=A285590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285590.Bytes);
public long this[int i]=>Value[i];

public static A285590Inst Instance=new A285590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285591
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,116L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285591Inst : IEnumerable<long>
{
public static readonly long[] Value=A285591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285591.Bytes);
public long this[int i]=>Value[i];

public static A285591Inst Instance=new A285591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285592
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285592Inst : IEnumerable<long>
{
public static readonly long[] Value=A285592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285592.Bytes);
public long this[int i]=>Value[i];

public static A285592Inst Instance=new A285592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285593
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,13L,15L,17L,19L,21L,23L,25L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,51L,53L,55L,57L,59L,61L,63L,65L,67L,70L,72L,74L,77L,79L,81L,84L,86L,88L,90L,92L,94L,96L,98L,100L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,126L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285593Inst : IEnumerable<long>
{
public static readonly long[] Value=A285593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285593.Bytes);
public long this[int i]=>Value[i];

public static A285593Inst Instance=new A285593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285594
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,69L,71L,73L,75L,76L,78L,80L,82L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,102L,104L,106L,108L,110L,112L,114L,116L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285594Inst : IEnumerable<long>
{
public static readonly long[] Value=A285594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285594.Bytes);
public long this[int i]=>Value[i];

public static A285594Inst Instance=new A285594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285595
{
public static readonly long[] Value={ 1L,4L,2L,17L,10L,3L,76L,52L,18L,4L,362L,274L,111L,28L,5L,1842L,1500L,675L,200L,40L,6L,9991L,8614L,4185L,1380L,325L,54L,7L,57568L,51992L,26832L,9568L,2510L,492L,70L,8L,351125L,329650L,178755L,67820L,19255L,4206L,707L,88L,9L,2259302L,2192434L,1239351L,494828L,149605L,35382L,6629L,976L,108L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285595Inst : IEnumerable<long>
{
public static readonly long[] Value=A285595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285595.Bytes);
public long this[int i]=>Value[i];

public static A285595Inst Instance=new A285595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285596
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285596Inst : IEnumerable<long>
{
public static readonly long[] Value=A285596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285596.Bytes);
public long this[int i]=>Value[i];

public static A285596Inst Instance=new A285596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285597
{
public static readonly long[] Value={ 1L,5L,11L,15L,19L,25L,29L,33L,39L,43L,47L,51L,55L,61L,65L,69L,75L,79L,83L,89L,93L,97L,103L,107L,111L,117L,121L,125L,129L,133L,139L,143L,147L,153L,157L,161L,167L,171L,175L,179L,183L,189L,193L,197L,203L,207L,211L,217L,221L,225L,229L,233L,239L,243L,247L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285597Inst : IEnumerable<long>
{
public static readonly long[] Value=A285597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285597.Bytes);
public long this[int i]=>Value[i];

public static A285597Inst Instance=new A285597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285598
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,24L,26L,27L,28L,30L,31L,32L,34L,35L,36L,37L,38L,40L,41L,42L,44L,45L,46L,48L,49L,50L,52L,53L,54L,56L,57L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285598Inst : IEnumerable<long>
{
public static readonly long[] Value=A285598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285598.Bytes);
public long this[int i]=>Value[i];

public static A285598Inst Instance=new A285598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285599
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285599Inst : IEnumerable<long>
{
public static readonly long[] Value=A285599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285599.Bytes);
public long this[int i]=>Value[i];

public static A285599Inst Instance=new A285599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285600
{
public static readonly long[] Value={ 3L,7L,11L,17L,21L,25L,29L,33L,39L,43L,47L,53L,57L,61L,67L,71L,75L,79L,83L,89L,93L,97L,103L,107L,111L,117L,121L,125L,129L,133L,139L,143L,147L,153L,157L,161L,167L,171L,175L,181L,185L,189L,195L,199L,203L,207L,211L,217L,221L,225L,231L,235L,239L,245L,249L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285600Inst : IEnumerable<long>
{
public static readonly long[] Value=A285600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285600.Bytes);
public long this[int i]=>Value[i];

public static A285600Inst Instance=new A285600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285601
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,22L,23L,24L,26L,27L,28L,30L,31L,32L,34L,35L,36L,37L,38L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,58L,59L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285601Inst : IEnumerable<long>
{
public static readonly long[] Value=A285601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285601.Bytes);
public long this[int i]=>Value[i];

public static A285601Inst Instance=new A285601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285602
{
public static readonly BigInteger[] Value={ 1L,5L,25L,325L,8125L,99125L,8425625L,1221715625L,44226105625L,11719917990625L,986817094810625L,94931804520782125L,BigInteger.Parse("65028286096735755625"),BigInteger.Parse("10937757721470954096125"),BigInteger.Parse("10117425892360632538915625"),BigInteger.Parse("11179755611058498955501765625") };
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
public class A285602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285602Inst Instance=new A285602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285603
{
public static readonly BigInteger[] Value={ 1L,3L,12L,144L,3456L,41472L,3483648L,501645312L,18059231232L,4767637045248L,400481511800832L,38446225132879872L,BigInteger.Parse("26297217990889832448"),BigInteger.Parse("4417932622469491851264"),BigInteger.Parse("4082169743161810470567936"),BigInteger.Parse("4506715396450638759507001344"),BigInteger.Parse("486725262816668986026756145152") };
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
public class A285603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285603Inst Instance=new A285603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285604
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1100L,111L,111000L,1111L,11110010L,11101L,1111100110L,111111L,111111001110L,1110001L,11111110011110L,11110011L,1111111100111100L,111011011L,111111111001100110L,1111011111L,11111111110011111100UL,11100000111L,BigInteger.Parse("1111111111100111111000"),111111101011L };
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
public class A285604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285604Inst Instance=new A285604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285653
{
public static readonly long[] Value={ 1L,2L,1L,14L,1L,62L,1L,252L,3L,1020L,3L,4092L,3L,16380L,3L,65520L,15L,262128L,15L,1048560L,15L,4194288L,15L,16777200L,15L,67108848L,15L,268435440L,15L,1073741808L,15L,4294967040L,255L,17179868928L,255L,68719476480L,255L,274877906688L,239L,1099511627536L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285653Inst : IEnumerable<long>
{
public static readonly long[] Value=A285653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285653.Bytes);
public long this[int i]=>Value[i];

public static A285653Inst Instance=new A285653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285654
{
public static readonly long[] Value={ 1L,1L,4L,7L,16L,31L,64L,63L,384L,255L,1536L,1023L,6144L,4095L,24576L,4095L,122880L,16383L,491520L,65535L,1966080L,262143L,7864320L,1048575L,31457280L,4194303L,125829120L,16777215L,503316480L,67108863L,2013265920L,16777215L,8556380160L,67108863L,34225520640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285654Inst : IEnumerable<long>
{
public static readonly long[] Value=A285654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285654.Bytes);
public long this[int i]=>Value[i];

public static A285654Inst Instance=new A285654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285655
{
public static readonly long[] Value={ 1L,30030L,2L,15015L,4L,19635L,6L,5005L,12L,6545L,18L,7315L,24L,7735L,22L,1365L,34L,1155L,26L,1785L,38L,2145L,14L,2805L,28L,3135L,42L,715L,84L,935L,78L,385L,102L,455L,66L,595L,114L,770L,39L,1190L,33L,910L,51L,1330L,69L,1430L,21L,1870L,57L,1540L,87L,1610L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285655Inst : IEnumerable<long>
{
public static readonly long[] Value=A285655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285655.Bytes);
public long this[int i]=>Value[i];

public static A285655Inst Instance=new A285655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285656
{
public static readonly long[] Value={ 1L,3L,1486L,5L,352L,7L,342L,2022L,1488L,354L,336L,9L,334L,23L,59L,2024L,338L,11L,344L,356L,47L,15L,340L,13L,1464L,19L,1490L,25L,346L,61L,348L,2026L,41L,17L,109L,1492L,350L,21L,39L,358L,414L,27L,416L,330L,450L,360L,418L,1494L,420L,384L,43L,332L,422L,1496L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285656Inst : IEnumerable<long>
{
public static readonly long[] Value=A285656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285656.Bytes);
public long this[int i]=>Value[i];

public static A285656Inst Instance=new A285656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285657
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285657Inst : IEnumerable<long>
{
public static readonly long[] Value=A285657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285657.Bytes);
public long this[int i]=>Value[i];

public static A285657Inst Instance=new A285657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285658
{
public static readonly long[] Value={ 2L,8L,12L,16L,20L,24L,30L,34L,38L,44L,48L,52L,58L,62L,66L,72L,76L,80L,86L,90L,94L,98L,102L,108L,112L,116L,122L,126L,130L,136L,140L,144L,148L,152L,158L,162L,166L,172L,176L,180L,186L,190L,194L,198L,202L,208L,212L,216L,222L,226L,230L,236L,240L,244L,248L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285658Inst : IEnumerable<long>
{
public static readonly long[] Value=A285658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285658.Bytes);
public long this[int i]=>Value[i];

public static A285658Inst Instance=new A285658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285659
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,67L,68L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285659Inst : IEnumerable<long>
{
public static readonly long[] Value=A285659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285659.Bytes);
public long this[int i]=>Value[i];

public static A285659Inst Instance=new A285659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285660
{
public static readonly long[] Value={ 1L,48L,12L,16L,24L,12L,4L,48L,24L,8L,3L,48L,8L,48L,12L,4L,24L,48L,2L,48L,6L,16L,12L,48L,8L,12L,12L,8L,24L,48L,1L,48L,24L,16L,12L,12L,4L,48L,12L,16L,6L,48L,4L,48L,24L,2L,12L,48L,8L,48L,3L,16L,24L,48L,2L,12L,24L,16L,12L,48L,2L,48L,12L,8L,24L,12L,4L,48L,24L,16L,3L,48L,4L,48L,12L,4L,24L,48L,4L,48L,6L,8L,12L,48L,8L,12L,12L,16L,24L,48L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285660Inst : IEnumerable<long>
{
public static readonly long[] Value=A285660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285660.Bytes);
public long this[int i]=>Value[i];

public static A285660Inst Instance=new A285660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285661
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285661Inst : IEnumerable<long>
{
public static readonly long[] Value=A285661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285661.Bytes);
public long this[int i]=>Value[i];

public static A285661Inst Instance=new A285661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285662
{
public static readonly long[] Value={ 3L,4L,7L,8L,15L,16L,19L,20L,27L,28L,31L,32L,35L,36L,39L,40L,43L,44L,47L,48L,55L,56L,59L,60L,67L,68L,71L,72L,75L,76L,79L,80L,83L,84L,87L,88L,95L,96L,99L,100L,107L,108L,111L,112L,119L,120L,123L,124L,131L,132L,135L,136L,143L,144L,147L,148L,155L,156L,159L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285662Inst : IEnumerable<long>
{
public static readonly long[] Value=A285662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285662.Bytes);
public long this[int i]=>Value[i];

public static A285662Inst Instance=new A285662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285663
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,10L,11L,12L,13L,14L,17L,18L,21L,22L,23L,24L,25L,26L,29L,30L,33L,34L,37L,38L,41L,42L,45L,46L,49L,50L,51L,52L,53L,54L,57L,58L,61L,62L,63L,64L,65L,66L,69L,70L,73L,74L,77L,78L,81L,82L,85L,86L,89L,90L,91L,92L,93L,94L,97L,98L,101L,102L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285663Inst : IEnumerable<long>
{
public static readonly long[] Value=A285663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285663.Bytes);
public long this[int i]=>Value[i];

public static A285663Inst Instance=new A285663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285664
{
public static readonly long[] Value={ 1L,2L,3L,6L,6L,20L,14L,46L,51L,140L,108L,624L,352L,1440L,2172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285664Inst : IEnumerable<long>
{
public static readonly long[] Value=A285664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285664.Bytes);
public long this[int i]=>Value[i];

public static A285664Inst Instance=new A285664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285665
{
public static readonly long[] Value={ 2L,3L,6L,10L,17L,29L,51L,90L,160L,282L,499L,881L,1559L,2758L,4880L,8634L,15275L,27025L,47815L,84598L,149680L,264826L,468555L,829009L,1466759L,2595126L,4591536L,8123770L,14373323L,25430609L,44994183L,79607862L,140849584L,249204090L,440914891L,780107345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285665Inst : IEnumerable<long>
{
public static readonly long[] Value=A285665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285665.Bytes);
public long this[int i]=>Value[i];

public static A285665Inst Instance=new A285665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285666
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285666Inst : IEnumerable<long>
{
public static readonly long[] Value=A285666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285666.Bytes);
public long this[int i]=>Value[i];

public static A285666Inst Instance=new A285666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285667
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,10L,11L,12L,14L,15L,17L,18L,19L,21L,22L,24L,25L,26L,28L,30L,31L,32L,34L,35L,37L,38L,39L,41L,43L,44L,45L,47L,48L,50L,51L,52L,54L,55L,56L,58L,59L,61L,62L,63L,65L,67L,68L,69L,71L,72L,74L,75L,76L,78L,79L,80L,82L,83L,85L,86L,87L,89L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285667Inst : IEnumerable<long>
{
public static readonly long[] Value=A285667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285667.Bytes);
public long this[int i]=>Value[i];

public static A285667Inst Instance=new A285667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285668
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285668Inst : IEnumerable<long>
{
public static readonly long[] Value=A285668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285668.Bytes);
public long this[int i]=>Value[i];

public static A285668Inst Instance=new A285668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285733
{
public static readonly long[] Value={ -1L,1L,1L,3L,-2L,2L,6L,2L,3L,4L,10L,5L,-3L,5L,7L,15L,9L,4L,6L,8L,11L,21L,14L,8L,-4L,9L,12L,16L,28L,20L,13L,7L,10L,13L,17L,22L,36L,27L,19L,12L,-5L,14L,18L,23L,29L,45L,35L,26L,18L,11L,15L,19L,24L,30L,37L,55L,44L,34L,25L,17L,-6L,20L,25L,31L,38L,46L,66L,54L,43L,33L,24L,16L,21L,26L,32L,39L,47L,56L,78L,65L,53L,42L,32L,23L,-7L,27L,33L,40L,48L,57L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285733Inst : IEnumerable<long>
{
public static readonly long[] Value=A285733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285733.Bytes);
public long this[int i]=>Value[i];

public static A285733Inst Instance=new A285733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285734
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,3L,3L,5L,5L,6L,6L,7L,5L,6L,7L,7L,6L,10L,10L,11L,10L,11L,11L,13L,13L,14L,14L,15L,14L,15L,14L,17L,14L,17L,15L,19L,17L,19L,19L,21L,21L,22L,22L,23L,21L,22L,23L,21L,22L,26L,23L,23L,26L,26L,26L,29L,29L,30L,30L,31L,30L,31L,31L,33L,33L,34L,34L,35L,34L,35L,35L,37L,37L,38L,38L,39L,38L,39L,39L,41L,41L,42L,42L,43L,41L,42L,43L,43L,38L,46L,46L,47L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285734Inst : IEnumerable<long>
{
public static readonly long[] Value=A285734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285734.Bytes);
public long this[int i]=>Value[i];

public static A285734Inst Instance=new A285734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285735
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,5L,5L,6L,5L,6L,6L,7L,7L,10L,10L,10L,11L,13L,10L,11L,11L,13L,13L,14L,13L,14L,14L,15L,15L,17L,17L,19L,17L,21L,19L,22L,19L,22L,21L,22L,21L,22L,22L,23L,23L,26L,26L,26L,29L,29L,26L,30L,31L,29L,30L,31L,29L,30L,30L,31L,31L,33L,33L,34L,33L,34L,34L,35L,35L,37L,37L,38L,37L,38L,38L,39L,39L,41L,41L,42L,41L,42L,42L,43L,43L,46L,46L,46L,47L,53L,46L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285735Inst : IEnumerable<long>
{
public static readonly long[] Value=A285735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285735.Bytes);
public long this[int i]=>Value[i];

public static A285735Inst Instance=new A285735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285736
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,3L,2L,3L,0L,1L,0L,1L,0L,5L,4L,3L,4L,7L,0L,1L,0L,3L,2L,3L,0L,1L,0L,1L,0L,3L,2L,5L,0L,7L,2L,7L,0L,5L,2L,3L,0L,1L,0L,1L,0L,5L,4L,3L,8L,7L,0L,7L,8L,3L,4L,5L,0L,1L,0L,1L,0L,3L,2L,3L,0L,1L,0L,1L,0L,3L,2L,3L,0L,1L,0L,1L,0L,3L,2L,3L,0L,1L,0L,1L,0L,5L,4L,3L,4L,15L,0L,1L,0L,11L,10L,5L,4L,7L,6L,9L,0L,11L,2L,11L,0L,15L,2L,7L,0L,5L,2L,3L,0L,1L,0L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285736Inst : IEnumerable<long>
{
public static readonly long[] Value=A285736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285736.Bytes);
public long this[int i]=>Value[i];

public static A285736Inst Instance=new A285736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285737
{
public static readonly long[] Value={ 1L,1L,8L,35L,107L,421L,1312L,4474L,13622L,43977L,130473L,388025L,1146640L,3265446L,9352424L,26033637L,72144351L,196664848L,532768901L,1422725368L,3768251677L,9893857617L,25709347054L,66367179293L,169754459790L,431237516979L,1086813719408L,2722241654623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285737Inst : IEnumerable<long>
{
public static readonly long[] Value=A285737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285737.Bytes);
public long this[int i]=>Value[i];

public static A285737Inst Instance=new A285737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285738
{
public static readonly long[] Value={ 1L,7L,17L,31L,47L,71L,97L,127L,157L,199L,241L,283L,337L,389L,449L,509L,577L,647L,719L,797L,881L,967L,1051L,1151L,1249L,1327L,1453L,1567L,1669L,1789L,1913L,2039L,2161L,2311L,2447L,2591L,2731L,2887L,3041L,3191L,3361L,3527L,3697L,3863L,4049L,4231L,4409L,4603L,4801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285738Inst : IEnumerable<long>
{
public static readonly long[] Value=A285738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285738.Bytes);
public long this[int i]=>Value[i];

public static A285738Inst Instance=new A285738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285739
{
public static readonly BigInteger[] Value={ 1L,1L,1L,28L,343L,31L,29791L,178035712L,11651995228221L,1087618835548371875L,13429024118357421875UL,BigInteger.Parse("143533445691269324970571729935778225264543312"),BigInteger.Parse("91376242719004834465589805254054451484345405903423332764620213"),BigInteger.Parse("25397841834482816377486479267527401525220329290217") };
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
public class A285739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285739Inst Instance=new A285739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285740
{
public static readonly BigInteger[] Value={ 1L,3L,16L,3375L,559872L,1815156L,80621568L,124556484375L,80000000000000L,11881340006899968L,1218719480020992L,BigInteger.Parse("3405780508865246682482292626953125"),BigInteger.Parse("1526226812966134209666905971200000000000000000"),BigInteger.Parse("18160335421875000000000000") };
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
public class A285740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285740Inst Instance=new A285740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285741
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,4L,8L,2L,4L,4L,8L,4L,8L,8L,16L,2L,4L,4L,8L,4L,8L,8L,16L,4L,8L,8L,16L,8L,16L,16L,77L,2L,4L,4L,8L,4L,8L,8L,16L,4L,8L,8L,16L,8L,16L,16L,77L,4L,8L,8L,16L,8L,16L,16L,77L,8L,16L,16L,77L,16L,77L,77L,154L,2L,4L,4L,8L,4L,8L,8L,16L,4L,8L,8L,16L,8L,16L,16L,77L,4L,8L,8L,16L,8L,16L,16L,77L,8L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285741Inst : IEnumerable<long>
{
public static readonly long[] Value=A285741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285741.Bytes);
public long this[int i]=>Value[i];

public static A285741Inst Instance=new A285741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285742
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,14L,11L,16L,5L,48L,43L,74L,31L,84L,53L,64L,11L,234L,223L,414L,191L,564L,373L,500L,127L,560L,433L,674L,241L,552L,311L,342L,31L,1512L,1481L,2890L,1409L,4260L,2851L,4004L,1153L,5246L,4093L,6642L,2549L,6120L,3571L,4280L,709L,4766L,4057L,7076L,3019L,8042L,5023L,6546L,1523L,5526L,4003L,6066L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285742Inst : IEnumerable<long>
{
public static readonly long[] Value=A285742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285742.Bytes);
public long this[int i]=>Value[i];

public static A285742Inst Instance=new A285742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285743
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,17L,11L,19L,5L,71L,59L,107L,31L,113L,67L,89L,11L,383L,353L,733L,277L,983L,587L,787L,127L,827L,617L,1069L,331L,911L,461L,541L,31L,2707L,2647L,5573L,2381L,8713L,5557L,8017L,1787L,10271L,7753L,13187L,4273L,11383L,6037L,7129L,709L,7529L,6353L,12049L,4549L,14389L,8581L,11657L,2221L,10111L,7109L,11353L,3259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285743Inst : IEnumerable<long>
{
public static readonly long[] Value=A285743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285743.Bytes);
public long this[int i]=>Value[i];

public static A285743Inst Instance=new A285743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285744
{
public static readonly long[] Value={ 2310L,1155L,770L,1365L,462L,385L,330L,1785L,910L,231L,210L,455L,420L,165L,154L,1995L,390L,595L,510L,273L,110L,105L,546L,665L,714L,255L,1190L,195L,570L,77L,630L,2145L,70L,285L,66L,715L,660L,315L,140L,357L,690L,55L,780L,345L,182L,399L,798L,805L,858L,429L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285744Inst : IEnumerable<long>
{
public static readonly long[] Value=A285744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285744.Bytes);
public long this[int i]=>Value[i];

public static A285744Inst Instance=new A285744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285745
{
public static readonly long[] Value={ 1L,8L,105L,550L,5105L,30918L,265920L,1773432L,14632372L,103605826L,834224969L,6128787272L,48666035225L,365893476096L,2883831290602L,22005412864334L,172812531531152L,1331535174196624L,10442072847350585L,80985489140322402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285745Inst : IEnumerable<long>
{
public static readonly long[] Value=A285745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285745.Bytes);
public long this[int i]=>Value[i];

public static A285745Inst Instance=new A285745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285746
{
public static readonly BigInteger[] Value={ 2L,44L,630L,8544L,125088L,1835412L,27339964L,410644956L,6209001966L,94379911740L,1441030936810L,22084845714940L,339564086313454L,5235658587223164L,80926601563138862L,1253589943179659024L,BigInteger.Parse("19456171723796564164") };
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
public class A285746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285746Inst Instance=new A285746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285747
{
public static readonly BigInteger[] Value={ 6L,150L,4850L,119506L,3640966L,101515318L,3077883556L,90409954434L,2751592992660L,82880894952670L,2536733201153036L,77454228451256600L,2383647319436407454L,BigInteger.Parse("73384273965571071952"),BigInteger.Parse("2269082578454361003697") };
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
public class A285747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285747Inst Instance=new A285747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285748
{
public static readonly BigInteger[] Value={ 12L,540L,31276L,1729212L,99685406L,5826888288L,345505561776L,20683003285236L,1247496214559062L,75696417871360268L,4615888774091221702L,BigInteger.Parse("282636062954942366016"),BigInteger.Parse("17366871309998173841404"),BigInteger.Parse("1070340278818744008980972") };
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
public class A285748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285748Inst Instance=new A285748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285797
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,1L,2L,2L,2L,3L,0L,2L,2L,3L,2L,4L,0L,4L,2L,4L,2L,5L,0L,6L,2L,5L,0L,4L,0L,6L,2L,6L,4L,7L,2L,8L,2L,3L,2L,6L,2L,8L,4L,8L,4L,7L,4L,10L,6L,8L,0L,6L,4L,10L,4L,6L,0L,7L,4L,13L,6L,5L,2L,10L,2L,12L,2L,6L,4L,10L,6L,16L,10L,9L,4L,10L,6L,14L,4L,10L,6L,9L,10L,17L,8L,9L,2L,8L,10L,18L,6L,8L,2L,9L,6L,16L,6L,6L,4L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285797Inst : IEnumerable<long>
{
public static readonly long[] Value=A285797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285797.Bytes);
public long this[int i]=>Value[i];

public static A285797Inst Instance=new A285797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285798
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,5L,5L,6L,7L,8L,8L,11L,11L,14L,16L,19L,19L,25L,26L,31L,34L,40L,41L,51L,53L,62L,68L,80L,85L,103L,107L,124L,135L,157L,166L,195L,205L,235L,256L,294L,311L,362L,383L,437L,472L,535L,568L,652L,695L,786L,847L,954L,1016L,1155L,1231L,1381L,1486L,1662L,1774L,1997L,2130L,2377L,2557L,2846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285798Inst : IEnumerable<long>
{
public static readonly long[] Value=A285798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285798.Bytes);
public long this[int i]=>Value[i];

public static A285798Inst Instance=new A285798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285799
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,3L,4L,6L,7L,9L,12L,15L,19L,23L,29L,37L,44L,54L,66L,80L,96L,115L,138L,165L,196L,231L,275L,322L,380L,444L,520L,608L,706L,821L,952L,1102L,1272L,1467L,1688L,1941L,2226L,2549L,2917L,3329L,3798L,4324L,4918L,5587L,6337L,7180L,8125L,9184L,10369L,11695L,13174L,14828L,16671L,18723L,21011L,23551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285799Inst : IEnumerable<long>
{
public static readonly long[] Value=A285799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285799.Bytes);
public long this[int i]=>Value[i];

public static A285799Inst Instance=new A285799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285800
{
public static readonly long[] Value={ 15L,21L,30L,33L,35L,39L,42L,51L,55L,57L,60L,65L,66L,69L,70L,77L,78L,84L,85L,87L,91L,93L,95L,102L,105L,110L,111L,114L,115L,119L,120L,123L,129L,130L,132L,133L,135L,138L,140L,141L,143L,145L,154L,155L,156L,159L,161L,165L,168L,170L,174L,177L,182L,183L,185L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285800Inst : IEnumerable<long>
{
public static readonly long[] Value=A285800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285800.Bytes);
public long this[int i]=>Value[i];

public static A285800Inst Instance=new A285800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285801
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,34L,36L,37L,38L,40L,41L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,54L,56L,58L,59L,61L,62L,63L,64L,67L,68L,71L,72L,73L,74L,75L,76L,79L,80L,81L,82L,83L,86L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285801Inst : IEnumerable<long>
{
public static readonly long[] Value=A285801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285801.Bytes);
public long this[int i]=>Value[i];

public static A285801Inst Instance=new A285801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285802
{
public static readonly long[] Value={ 7L,35L,9L,18L,14L,12L,1L,9L,3L,7L,7L,6L,6L,5L,5L,11L,1L,4L,3L,35L,7L,8L,9L,3L,3L,3L,1L,17L,3L,9L,7L,18L,9L,5L,2L,2L,1L,2L,2L,18L,7L,9L,4L,4L,6L,6L,1L,12L,3L,14L,7L,11L,7L,5L,5L,12L,1L,3L,3L,12L,7L,6L,6L,9L,11L,11L,1L,4L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,9L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285802Inst : IEnumerable<long>
{
public static readonly long[] Value=A285802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285802.Bytes);
public long this[int i]=>Value[i];

public static A285802Inst Instance=new A285802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285803
{
public static readonly long[] Value={ 37L,87L,137L,187L,237L,287L,337L,357L,367L,370L,371L,372L,373L,374L,375L,376L,377L,378L,379L,387L,397L,437L,487L,537L,587L,637L,687L,735L,736L,737L,738L,739L,785L,786L,787L,788L,789L,837L,857L,867L,870L,871L,872L,873L,874L,875L,876L,877L,878L,879L,887L,897L,937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285803Inst : IEnumerable<long>
{
public static readonly long[] Value=A285803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285803.Bytes);
public long this[int i]=>Value[i];

public static A285803Inst Instance=new A285803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285804
{
public static readonly long[] Value={ 55L,65L,77L,91L,115L,125L,161L,175L,185L,187L,209L,221L,235L,245L,247L,259L,295L,305L,319L,329L,341L,343L,355L,365L,377L,391L,403L,413L,415L,425L,427L,437L,451L,473L,475L,485L,497L,511L,533L,535L,545L,559L,581L,583L,595L,605L,629L,655L,665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285804Inst : IEnumerable<long>
{
public static readonly long[] Value=A285804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285804.Bytes);
public long this[int i]=>Value[i];

public static A285804Inst Instance=new A285804Inst();

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