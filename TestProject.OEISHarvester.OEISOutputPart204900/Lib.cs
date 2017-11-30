using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A243282
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243282Inst : IEnumerable<long>
{
public static readonly long[] Value=A243282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243282.Bytes);
public long this[int i]=>Value[i];

public static A243282Inst Instance=new A243282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243283
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243283Inst : IEnumerable<long>
{
public static readonly long[] Value=A243283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243283.Bytes);
public long this[int i]=>Value[i];

public static A243283Inst Instance=new A243283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243284
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,15L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243284Inst : IEnumerable<long>
{
public static readonly long[] Value=A243284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243284.Bytes);
public long this[int i]=>Value[i];

public static A243284Inst Instance=new A243284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243285
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,5L,5L,5L,6L,7L,8L,9L,10L,11L,11L,12L,12L,13L,14L,15L,16L,17L,18L,18L,19L,19L,20L,21L,22L,23L,23L,24L,25L,26L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,38L,38L,39L,40L,41L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,50L,51L,52L,53L,54L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243285Inst : IEnumerable<long>
{
public static readonly long[] Value=A243285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243285.Bytes);
public long this[int i]=>Value[i];

public static A243285Inst Instance=new A243285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243286
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,12L,8L,9L,10L,27L,7L,13L,14L,36L,16L,62L,18L,19L,121L,148L,22L,23L,24L,43L,191L,11L,28L,283L,75L,113L,32L,87L,34L,481L,15L,388L,38L,39L,160L,1456L,42L,25L,795L,213L,602L,47L,74L,49L,818L,51L,52L,339L,54L,2699L,345L,57L,58L,59L,1053L,5219L,17L,914L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243286Inst : IEnumerable<long>
{
public static readonly long[] Value=A243286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243286.Bytes);
public long this[int i]=>Value[i];

public static A243286Inst Instance=new A243286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243287
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,9L,12L,32L,10L,18L,24L,64L,7L,20L,17L,36L,48L,128L,14L,40L,34L,13L,72L,33L,96L,256L,28L,80L,11L,68L,26L,144L,19L,66L,192L,512L,56L,160L,22L,136L,52L,288L,38L,132L,384L,25L,65L,1024L,112L,320L,21L,44L,272L,104L,576L,76L,264L,768L,50L,130L,37L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243287Inst : IEnumerable<long>
{
public static readonly long[] Value=A243287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243287.Bytes);
public long this[int i]=>Value[i];

public static A243287Inst Instance=new A243287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243288
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,9L,12L,32L,10L,25L,22L,81L,7L,18L,13L,36L,17L,54L,42L,242L,14L,49L,34L,150L,30L,128L,99L,882L,11L,27L,24L,100L,19L,64L,46L,256L,23L,98L,68L,490L,55L,338L,279L,4624L,20L,72L,62L,432L,44L,245L,178L,2209L,40L,216L,154L,1800L,119L,1200L,966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243288Inst : IEnumerable<long>
{
public static readonly long[] Value=A243288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243288.Bytes);
public long this[int i]=>Value[i];

public static A243288Inst Instance=new A243288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243289
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,4L,3L,3L,6L,8L,5L,5L,10L,10L,7L,11L,8L,16L,9L,16L,15L,19L,12L,17L,20L,14L,24L,15L,21L,16L,25L,17L,29L,27L,26L,20L,20L,28L,34L,36L,23L,34L,40L,25L,25L,35L,43L,43L,28L,38L,29L,46L,40L,45L,32L,51L,47L,44L,52L,36L,36L,56L,37L,61L,50L,39L,39L,64L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243289Inst : IEnumerable<long>
{
public static readonly long[] Value=A243289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243289.Bytes);
public long this[int i]=>Value[i];

public static A243289Inst Instance=new A243289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243290
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,4L,3L,5L,6L,4L,3L,7L,8L,4L,5L,9L,6L,10L,3L,11L,5L,7L,4L,12L,8L,6L,13L,4L,14L,9L,15L,7L,16L,5L,8L,10L,17L,18L,11L,6L,5L,19L,9L,4L,20L,21L,12L,5L,6L,22L,13L,23L,7L,14L,10L,24L,6L,11L,15L,8L,25L,26L,7L,27L,4L,16L,28L,29L,5L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243290Inst : IEnumerable<long>
{
public static readonly long[] Value=A243290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243290.Bytes);
public long this[int i]=>Value[i];

public static A243290Inst Instance=new A243290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243291
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,4L,3L,7L,7L,7L,6L,10L,7L,10L,12L,15L,10L,16L,11L,17L,17L,17L,14L,22L,22L,20L,25L,24L,19L,27L,20L,31L,28L,27L,31L,34L,25L,30L,33L,37L,28L,38L,29L,39L,42L,37L,32L,46L,45L,47L,44L,46L,37L,52L,50L,52L,49L,48L,42L,57L,43L,51L,59L,63L,59L,61L,48L,61L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243291Inst : IEnumerable<long>
{
public static readonly long[] Value=A243291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243291.Bytes);
public long this[int i]=>Value[i];

public static A243291Inst Instance=new A243291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243292
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,85L,89L,91L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243292Inst : IEnumerable<long>
{
public static readonly long[] Value=A243292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243292.Bytes);
public long this[int i]=>Value[i];

public static A243292Inst Instance=new A243292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243293
{
public static readonly long[] Value={ 3L,4L,6L,7L,8L,9L,10L,11L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,26L,27L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,41L,42L,43L,43L,44L,44L,45L,46L,46L,47L,47L,48L,49L,49L,50L,50L,51L,52L,52L,53L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243293Inst : IEnumerable<long>
{
public static readonly long[] Value=A243293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243293.Bytes);
public long this[int i]=>Value[i];

public static A243293Inst Instance=new A243293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243294
{
public static readonly long[] Value={ 171L,2L,179L,4L,29L,2L,5L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243294Inst : IEnumerable<long>
{
public static readonly long[] Value=A243294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243294.Bytes);
public long this[int i]=>Value[i];

public static A243294Inst Instance=new A243294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243295
{
public static readonly long[] Value={ 1L,8L,15L,57L,102L,332L,2345L,2345L,10110L,118745L,127188L,326758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243295Inst : IEnumerable<long>
{
public static readonly long[] Value=A243295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243295.Bytes);
public long this[int i]=>Value[i];

public static A243295Inst Instance=new A243295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243296
{
public static readonly long[] Value={ 3L,5L,4L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,4L,3L,5L,3L,4L,5L,4L,4L,3L,3L,3L,8L,4L,3L,4L,4L,4L,3L,3L,6L,3L,3L,4L,3L,3L,4L,3L,4L,4L,4L,3L,3L,6L,7L,3L,5L,4L,4L,4L,3L,3L,3L,5L,9L,3L,3L,6L,3L,7L,4L,9L,3L,6L,5L,3L,6L,7L,4L,4L,3L,5L,5L,3L,5L,7L,4L,3L,4L,4L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243296Inst : IEnumerable<long>
{
public static readonly long[] Value=A243296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243296.Bytes);
public long this[int i]=>Value[i];

public static A243296Inst Instance=new A243296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243297
{
public static readonly long[] Value={ 4L,5L,18L,23L,24L,25L,39L,41L,49L,61L,68L,73L,100L,102L,103L,109L,111L,114L,125L,140L,150L,157L,158L,167L,181L,210L,228L,242L,245L,259L,282L,286L,287L,290L,294L,299L,300L,303L,307L,311L,315L,325L,341L,347L,364L,367L,371L,385L,390L,395L,403L,406L,415L,430L,437L,441L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243297Inst : IEnumerable<long>
{
public static readonly long[] Value=A243297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243297.Bytes);
public long this[int i]=>Value[i];

public static A243297Inst Instance=new A243297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243298
{
public static readonly long[] Value={ 4L,16L,18L,28L,76L,84L,88L,118L,146L,180L,258L,272L,274L,282L,316L,380L,384L,400L,462L,464L,468L,476L,548L,586L,588L,610L,616L,644L,646L,702L,708L,756L,786L,810L,826L,944L,954L,956L,988L,1000L,1016L,1052L,1104L,1138L,1166L,1178L,1194L,1212L,1226L,1240L,1258L,1356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243298Inst : IEnumerable<long>
{
public static readonly long[] Value=A243298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243298.Bytes);
public long this[int i]=>Value[i];

public static A243298Inst Instance=new A243298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243299
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243299Inst : IEnumerable<long>
{
public static readonly long[] Value=A243299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243299.Bytes);
public long this[int i]=>Value[i];

public static A243299Inst Instance=new A243299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243300
{
public static readonly long[] Value={ 4L,5L,7L,9L,17L,30L,37L,39L,42L,62L,69L,72L,79L,82L,85L,90L,92L,95L,99L,104L,110L,157L,170L,175L,177L,182L,187L,194L,195L,215L,217L,220L,234L,239L,240L,242L,255L,262L,269L,272L,277L,319L,334L,339L,342L,344L,359L,365L,369L,370L,374L,377L,387L,392L,400L,417L,419L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243300Inst : IEnumerable<long>
{
public static readonly long[] Value=A243300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243300.Bytes);
public long this[int i]=>Value[i];

public static A243300Inst Instance=new A243300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243301
{
public static readonly long[] Value={ 30L,38L,66L,110L,144L,156L,164L,174L,194L,210L,222L,230L,266L,278L,282L,318L,354L,374L,392L,432L,474L,528L,540L,552L,588L,630L,636L,650L,704L,714L,716L,812L,918L,960L,1076L,1086L,1122L,1142L,1190L,1224L,1322L,1362L,1388L,1394L,1418L,1452L,1506L,1508L,1532L,1538L,1596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243301Inst : IEnumerable<long>
{
public static readonly long[] Value=A243301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243301.Bytes);
public long this[int i]=>Value[i];

public static A243301Inst Instance=new A243301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243302
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,11L,14L,18L,21L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243302Inst : IEnumerable<long>
{
public static readonly long[] Value=A243302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243302.Bytes);
public long this[int i]=>Value[i];

public static A243302Inst Instance=new A243302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243303
{
public static readonly long[] Value={ 1L,5L,25L,78L,161L,341L,1076L,16361L,19383L,56047L,132903L,862935L,862935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243303Inst : IEnumerable<long>
{
public static readonly long[] Value=A243303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243303.Bytes);
public long this[int i]=>Value[i];

public static A243303Inst Instance=new A243303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243304
{
public static readonly long[] Value={ 1L,5L,13L,50L,213L,536L,536L,536L,9354L,63202L,117150L,1314904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243304Inst : IEnumerable<long>
{
public static readonly long[] Value=A243304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243304.Bytes);
public long this[int i]=>Value[i];

public static A243304Inst Instance=new A243304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243305
{
public static readonly long[] Value={ 3L,3L,5L,5L,17L,5L,65L,17L,65L,17L,1025L,17L,4097L,65L,257L,257L,65537L,65L,262145L,257L,4097L,1025L,4194305L,257L,1048577L,4097L,262145L,4097L,268435457L,257L,1073741825L,65537L,1048577L,65537L,16777217L,4097L,68719476737L,262145L,16777217L,65537L,1099511627777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243305Inst : IEnumerable<long>
{
public static readonly long[] Value=A243305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243305.Bytes);
public long this[int i]=>Value[i];

public static A243305Inst Instance=new A243305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243306
{
public static readonly long[] Value={ 1L,1L,2L,2L,12L,2L,58L,12L,58L,12L,1014L,12L,4084L,58L,248L,248L,65520L,58L,262126L,248L,4084L,1014L,4194282L,248L,1048556L,4084L,262126L,4084L,268435428L,248L,1073741794L,65520L,1048556L,65520L,16777192L,4084L,68719476700L,262126L,16777192L,65520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243306Inst : IEnumerable<long>
{
public static readonly long[] Value=A243306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243306.Bytes);
public long this[int i]=>Value[i];

public static A243306Inst Instance=new A243306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243307
{
public static readonly long[] Value={ 3L,3L,6L,6L,20L,6L,70L,20L,70L,20L,1034L,20L,4108L,70L,264L,264L,65552L,70L,262162L,264L,4108L,1034L,4194326L,264L,1048596L,4108L,262162L,4108L,268435484L,264L,1073741854L,65552L,1048596L,65552L,16777240L,4108L,68719476772L,262162L,16777240L,65552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243307Inst : IEnumerable<long>
{
public static readonly long[] Value=A243307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243307.Bytes);
public long this[int i]=>Value[i];

public static A243307Inst Instance=new A243307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243308
{
public static readonly long[] Value={ 1L,0L,1L,7L,4L,0L,8L,7L,9L,7L,5L,9L,5L,9L,5L,6L,0L,0L,8L,6L,6L,9L,5L,3L,8L,7L,5L,3L,3L,5L,0L,0L,6L,3L,4L,2L,5L,9L,9L,5L,2L,5L,6L,9L,1L,8L,5L,4L,5L,4L,1L,1L,8L,9L,9L,9L,1L,5L,0L,5L,4L,2L,3L,7L,5L,3L,5L,2L,1L,2L,4L,3L,1L,8L,0L,6L,2L,5L,0L,1L,6L,3L,9L,4L,4L,2L,3L,6L,6L,6L,5L,0L,9L,7L,6L,1L,2L,0L,0L,7L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243308Inst : IEnumerable<long>
{
public static readonly long[] Value=A243308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243308.Bytes);
public long this[int i]=>Value[i];

public static A243308Inst Instance=new A243308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243309
{
public static readonly long[] Value={ 1L,0L,0L,7L,4L,3L,4L,7L,5L,6L,8L,8L,4L,2L,7L,9L,3L,7L,6L,0L,9L,8L,2L,5L,3L,5L,9L,5L,2L,3L,1L,0L,9L,9L,1L,4L,1L,9L,2L,5L,6L,9L,0L,1L,1L,4L,1L,1L,3L,6L,6L,9L,7L,7L,0L,2L,3L,4L,9L,6L,3L,7L,9L,8L,5L,7L,1L,1L,5L,2L,3L,1L,3L,2L,8L,0L,2L,8L,6L,7L,7L,7L,9L,6L,2L,5L,2L,0L,5L,5L,1L,4L,7L,4L,6L,3L,5L,9L,2L,3L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243309Inst : IEnumerable<long>
{
public static readonly long[] Value=A243309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243309.Bytes);
public long this[int i]=>Value[i];

public static A243309Inst Instance=new A243309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243310
{
public static readonly long[] Value={ 1L,2L,2L,2L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243310Inst : IEnumerable<long>
{
public static readonly long[] Value=A243310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243310.Bytes);
public long this[int i]=>Value[i];

public static A243310Inst Instance=new A243310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243311
{
public static readonly long[] Value={ 2L,6L,8L,8L,9L,5L,6L,6L,0L,1L,6L,9L,3L,1L,1L,2L,2L,5L,4L,6L,9L,2L,9L,4L,8L,6L,7L,2L,2L,7L,2L,4L,5L,6L,6L,4L,5L,2L,4L,9L,9L,4L,4L,3L,7L,1L,9L,3L,0L,3L,1L,3L,7L,2L,9L,2L,1L,0L,7L,6L,4L,8L,0L,2L,5L,7L,6L,3L,9L,2L,6L,0L,9L,0L,0L,9L,9L,2L,6L,4L,7L,2L,9L,4L,4L,3L,7L,4L,8L,1L,3L,4L,8L,4L,3L,1L,8L,1L,9L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243311Inst : IEnumerable<long>
{
public static readonly long[] Value=A243311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243311.Bytes);
public long this[int i]=>Value[i];

public static A243311Inst Instance=new A243311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243312
{
public static readonly long[] Value={ 1L,4L,31L,305L,3345L,39505L,487935L,6245118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243312Inst : IEnumerable<long>
{
public static readonly long[] Value=A243312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243312.Bytes);
public long this[int i]=>Value[i];

public static A243312Inst Instance=new A243312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243313
{
public static readonly long[] Value={ 1L,0L,9L,6L,3L,7L,6L,3L,1L,7L,1L,7L,7L,3L,1L,2L,8L,0L,4L,0L,7L,5L,9L,3L,1L,1L,0L,6L,9L,1L,3L,5L,2L,3L,7L,9L,0L,1L,9L,6L,5L,3L,8L,4L,9L,6L,9L,4L,3L,5L,1L,5L,5L,1L,8L,2L,9L,7L,5L,5L,2L,4L,9L,6L,5L,2L,9L,5L,3L,1L,9L,4L,0L,0L,1L,5L,4L,1L,4L,0L,4L,0L,6L,1L,9L,6L,2L,8L,8L,8L,1L,8L,9L,8L,0L,3L,4L,5L,6L,9L,7L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243313Inst : IEnumerable<long>
{
public static readonly long[] Value=A243313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243313.Bytes);
public long this[int i]=>Value[i];

public static A243313Inst Instance=new A243313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243314
{
public static readonly BigInteger[] Value={ 1L,34L,55888L,37213728L,31371388772L,25014514225856L,20223491612180232L,16295162098717276928UL,BigInteger.Parse("13140746227808545282304"),BigInteger.Parse("10594819370472223969569120"),BigInteger.Parse("8542571199105608333942735840"),BigInteger.Parse("6887766005343647823407800357376"),BigInteger.Parse("5553534245505786602829188504607680") };
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
public class A243314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243314Inst Instance=new A243314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243315
{
public static readonly BigInteger[] Value={ 1L,55L,237472L,371654153L,757341382671L,1450226501771584L,2820152941289640505L,BigInteger.Parse("5463664833842177843423"),BigInteger.Parse("10594819370472223969569120"),BigInteger.Parse("20540255065209806005525289313"),BigInteger.Parse("39823725482559144291828665014967"),BigInteger.Parse("77209746313875957204633819730760448") };
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
public class A243315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243315Inst Instance=new A243315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243316
{
public static readonly BigInteger[] Value={ 1L,89L,1009056L,3711809483L,18283618480037L,84080327982982848L,BigInteger.Parse("393283923444213896309"),BigInteger.Parse("1832013557267266441097285"),BigInteger.Parse("8542571199105608333942735840"),BigInteger.Parse("39823725482559144291828665014967"),BigInteger.Parse("185661218973084382181156348510614065"),BigInteger.Parse("865553976307450198923428125167024054656") };
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
public class A243316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243316Inst Instance=new A243316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243317
{
public static readonly long[] Value={ 1L,1L,0L,6L,1L,0L,2L,8L,6L,7L,4L,6L,5L,6L,3L,2L,7L,4L,9L,2L,5L,1L,6L,7L,2L,8L,7L,8L,7L,1L,4L,6L,4L,3L,3L,9L,8L,8L,0L,2L,3L,9L,2L,6L,8L,3L,9L,3L,6L,9L,2L,1L,8L,0L,1L,3L,9L,7L,1L,9L,0L,5L,6L,9L,8L,9L,1L,4L,6L,3L,7L,4L,7L,1L,5L,3L,2L,6L,2L,3L,2L,8L,2L,2L,9L,8L,1L,1L,4L,3L,3L,1L,4L,4L,2L,5L,0L,5L,0L,3L,8L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243317Inst : IEnumerable<long>
{
public static readonly long[] Value=A243317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243317.Bytes);
public long this[int i]=>Value[i];

public static A243317Inst Instance=new A243317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243318
{
public static readonly long[] Value={ 15L,56L,65L,74L,87L,104L,132L,150L,171L,185L,186L,204L,225L,234L,360L,429L,449L,455L,459L,476L,485L,512L,675L,746L,770L,780L,795L,816L,836L,839L,840L,846L,857L,876L,902L,930L,939L,941L,944L,977L,1109L,1152L,1161L,1190L,1262L,1289L,1295L,1316L,1355L,1362L,1374L,1395L,1401L,1425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243318Inst : IEnumerable<long>
{
public static readonly long[] Value=A243318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243318.Bytes);
public long this[int i]=>Value[i];

public static A243318Inst Instance=new A243318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243319
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,2L,0L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243319Inst : IEnumerable<long>
{
public static readonly long[] Value=A243319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243319.Bytes);
public long this[int i]=>Value[i];

public static A243319Inst Instance=new A243319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243320
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,1L,6L,7L,29L,64L,287L,1148L,7267L,55997L,620561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243320Inst : IEnumerable<long>
{
public static readonly long[] Value=A243320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243320.Bytes);
public long this[int i]=>Value[i];

public static A243320Inst Instance=new A243320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243321
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,16L,41L,158L,582L,2749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243321Inst : IEnumerable<long>
{
public static readonly long[] Value=A243321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243321.Bytes);
public long this[int i]=>Value[i];

public static A243321Inst Instance=new A243321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243322
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,2L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243322Inst : IEnumerable<long>
{
public static readonly long[] Value=A243322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243322.Bytes);
public long this[int i]=>Value[i];

public static A243322Inst Instance=new A243322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243323
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,14L,43L,179L,730L,4019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243323Inst : IEnumerable<long>
{
public static readonly long[] Value=A243323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243323.Bytes);
public long this[int i]=>Value[i];

public static A243323Inst Instance=new A243323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243324
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,6L,33L,180L,1773L,31006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243324Inst : IEnumerable<long>
{
public static readonly long[] Value=A243324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243324.Bytes);
public long this[int i]=>Value[i];

public static A243324Inst Instance=new A243324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243325
{
public static readonly long[] Value={ 0L,0L,1L,4L,18L,95L,642L,5962L,71876L,1052786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243325Inst : IEnumerable<long>
{
public static readonly long[] Value=A243325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243325.Bytes);
public long this[int i]=>Value[i];

public static A243325Inst Instance=new A243325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243326
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,16L,58L,264L,1380L,9818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243326Inst : IEnumerable<long>
{
public static readonly long[] Value=A243326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243326.Bytes);
public long this[int i]=>Value[i];

public static A243326Inst Instance=new A243326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243327
{
public static readonly long[] Value={ 0L,0L,1L,4L,15L,77L,531L,5597L,95900L,2784034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243327Inst : IEnumerable<long>
{
public static readonly long[] Value=A243327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243327.Bytes);
public long this[int i]=>Value[i];

public static A243327Inst Instance=new A243327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243328
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,3L,1L,3L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243328Inst : IEnumerable<long>
{
public static readonly long[] Value=A243328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243328.Bytes);
public long this[int i]=>Value[i];

public static A243328Inst Instance=new A243328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243329
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,1L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243329Inst : IEnumerable<long>
{
public static readonly long[] Value=A243329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243329.Bytes);
public long this[int i]=>Value[i];

public static A243329Inst Instance=new A243329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243330
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,9L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243330Inst : IEnumerable<long>
{
public static readonly long[] Value=A243330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243330.Bytes);
public long this[int i]=>Value[i];

public static A243330Inst Instance=new A243330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243331
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,4L,12L,9L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243331Inst : IEnumerable<long>
{
public static readonly long[] Value=A243331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243331.Bytes);
public long this[int i]=>Value[i];

public static A243331Inst Instance=new A243331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243332
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,3L,1L,3L,0L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243332Inst : IEnumerable<long>
{
public static readonly long[] Value=A243332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243332.Bytes);
public long this[int i]=>Value[i];

public static A243332Inst Instance=new A243332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243333
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,5L,5L,9L,15L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243333Inst : IEnumerable<long>
{
public static readonly long[] Value=A243333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243333.Bytes);
public long this[int i]=>Value[i];

public static A243333Inst Instance=new A243333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243334
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,1L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243334Inst : IEnumerable<long>
{
public static readonly long[] Value=A243334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243334.Bytes);
public long this[int i]=>Value[i];

public static A243334Inst Instance=new A243334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243335
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,2L,3L,8L,19L,62L,229L,1192L,8147L,80182L,1106086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243335Inst : IEnumerable<long>
{
public static readonly long[] Value=A243335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243335.Bytes);
public long this[int i]=>Value[i];

public static A243335Inst Instance=new A243335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243336
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,6L,22L,93L,656L,7484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243336Inst : IEnumerable<long>
{
public static readonly long[] Value=A243336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243336.Bytes);
public long this[int i]=>Value[i];

public static A243336Inst Instance=new A243336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243337
{
public static readonly long[] Value={ 1L,1L,2L,5L,17L,79L,478L,4123L,46666L,648758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243337Inst : IEnumerable<long>
{
public static readonly long[] Value=A243337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243337.Bytes);
public long this[int i]=>Value[i];

public static A243337Inst Instance=new A243337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243338
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,5L,10L,23L,47L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243338Inst : IEnumerable<long>
{
public static readonly long[] Value=A243338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243338.Bytes);
public long this[int i]=>Value[i];

public static A243338Inst Instance=new A243338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243339
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243339Inst : IEnumerable<long>
{
public static readonly long[] Value=A243339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243339.Bytes);
public long this[int i]=>Value[i];

public static A243339Inst Instance=new A243339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243340
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,3L,5L,7L,8L,8L,8L,9L,8L,7L,6L,4L,2L,4L,8L,3L,7L,5L,2L,3L,9L,6L,4L,3L,7L,3L,2L,0L,6L,2L,4L,1L,1L,9L,9L,1L,9L,9L,0L,6L,8L,4L,6L,5L,3L,7L,9L,6L,0L,0L,3L,2L,6L,6L,4L,3L,6L,4L,9L,3L,4L,7L,1L,5L,7L,5L,9L,9L,0L,2L,7L,9L,3L,6L,8L,5L,4L,9L,1L,5L,9L,5L,8L,8L,2L,1L,3L,8L,0L,1L,7L,0L,0L,4L,3L,2L,1L,7L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243340Inst : IEnumerable<long>
{
public static readonly long[] Value=A243340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243340.Bytes);
public long this[int i]=>Value[i];

public static A243340Inst Instance=new A243340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243341
{
public static readonly long[] Value={ 3L,3L,4L,3L,4L,4L,30L,4L,4L,15L,4L,27L,54L,10L,4L,3L,10L,11L,56L,35L,4L,35L,8L,34L,6L,24L,32L,17L,6L,4L,18L,3L,100L,191L,10L,63L,54L,40L,4L,129L,20L,14L,474L,16L,142L,330L,20L,36L,116L,4L,664L,161L,32L,19L,62L,7L,54L,366L,132L,71L,162L,5L,4L,3L,204L,60L,18L,30L,198L,155L,28L,274L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243341Inst : IEnumerable<long>
{
public static readonly long[] Value=A243341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243341.Bytes);
public long this[int i]=>Value[i];

public static A243341Inst Instance=new A243341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243342
{
public static readonly long[] Value={ 83L,419L,3779L,10739L,240899L,229979L,1180019L,369419L,36964859L,33670379L,13235699L,21899939L,412547339L,370247939L,467152019L,579994619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243342Inst : IEnumerable<long>
{
public static readonly long[] Value=A243342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243342.Bytes);
public long this[int i]=>Value[i];

public static A243342Inst Instance=new A243342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243343
{
public static readonly long[] Value={ 1L,3L,7L,2L,15L,5L,31L,6L,14L,11L,63L,4L,13L,29L,23L,30L,127L,10L,9L,62L,27L,59L,47L,12L,28L,61L,22L,126L,255L,21L,19L,8L,125L,55L,119L,26L,95L,25L,57L,58L,123L,45L,253L,46L,60L,511L,43L,254L,20L,18L,39L,124L,17L,54L,251L,118L,111L,239L,53L,94L,191L,51L,24L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243343Inst : IEnumerable<long>
{
public static readonly long[] Value=A243343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243343.Bytes);
public long this[int i]=>Value[i];

public static A243343Inst Instance=new A243343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243344
{
public static readonly long[] Value={ 1L,4L,2L,12L,6L,8L,3L,32L,19L,18L,10L,24L,13L,9L,5L,84L,53L,50L,31L,49L,30L,27L,15L,63L,38L,36L,21L,25L,14L,16L,7L,220L,138L,136L,86L,128L,82L,81L,51L,126L,79L,80L,47L,72L,42L,44L,23L,162L,103L,99L,62L,96L,59L,54L,34L,64L,39L,40L,22L,45L,26L,20L,11L,564L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243344Inst : IEnumerable<long>
{
public static readonly long[] Value=A243344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243344.Bytes);
public long this[int i]=>Value[i];

public static A243344Inst Instance=new A243344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243345
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,9L,12L,32L,7L,10L,18L,24L,17L,64L,13L,14L,33L,20L,36L,48L,11L,19L,34L,25L,65L,128L,26L,28L,15L,66L,40L,72L,21L,96L,22L,38L,37L,68L,50L,130L,49L,35L,256L,52L,129L,27L,29L,56L,67L,30L,41L,132L,73L,80L,144L,42L,97L,192L,44L,23L,39L,76L,74L,136L,69L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243345Inst : IEnumerable<long>
{
public static readonly long[] Value=A243345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243345.Bytes);
public long this[int i]=>Value[i];

public static A243345Inst Instance=new A243345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243346
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,12L,5L,9L,13L,24L,10L,18L,19L,32L,7L,16L,14L,25L,21L,36L,38L,63L,15L,27L,30L,49L,31L,50L,53L,84L,11L,20L,26L,45L,22L,40L,39L,64L,34L,54L,59L,96L,62L,99L,103L,162L,23L,44L,42L,72L,47L,80L,79L,126L,51L,81L,82L,128L,86L,136L,138L,220L,17L,28L,33L,52L,41L,68L,73L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243346Inst : IEnumerable<long>
{
public static readonly long[] Value=A243346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243346.Bytes);
public long this[int i]=>Value[i];

public static A243346Inst Instance=new A243346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243347
{
public static readonly long[] Value={ 1L,4L,12L,2L,32L,8L,84L,6L,19L,24L,220L,3L,18L,50L,63L,53L,564L,13L,9L,138L,49L,128L,162L,10L,31L,136L,38L,365L,1448L,36L,25L,5L,351L,126L,332L,30L,414L,27L,81L,82L,348L,99L,931L,103L,86L,3699L,96L,929L,21L,14L,64L,223L,16L,79L,892L,210L,325L,847L,80L,265L,1056L,72L,15L,51L,208L,212L,884L,221L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243347Inst : IEnumerable<long>
{
public static readonly long[] Value=A243347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243347.Bytes);
public long this[int i]=>Value[i];

public static A243347Inst Instance=new A243347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243348
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,3L,3L,4L,4L,4L,5L,6L,7L,7L,7L,9L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,16L,16L,19L,20L,21L,22L,22L,22L,23L,23L,25L,25L,25L,26L,26L,26L,27L,27L,29L,29L,29L,31L,31L,32L,32L,32L,33L,34L,35L,35L,35L,36L,39L,39L,39L,40L,40L,40L,41L,41L,41L,42L,42L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243348Inst : IEnumerable<long>
{
public static readonly long[] Value=A243348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243348.Bytes);
public long this[int i]=>Value[i];

public static A243348Inst Instance=new A243348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243349
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,3L,7L,6L,7L,10L,12L,10L,11L,17L,17L,14L,20L,19L,27L,20L,28L,27L,31L,25L,30L,33L,28L,38L,29L,37L,32L,44L,37L,50L,49L,48L,42L,43L,51L,59L,61L,48L,60L,66L,51L,52L,62L,72L,72L,57L,69L,60L,78L,72L,77L,65L,85L,82L,79L,87L,72L,75L,95L,76L,101L,90L,79L,80L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243349Inst : IEnumerable<long>
{
public static readonly long[] Value=A243349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243349.Bytes);
public long this[int i]=>Value[i];

public static A243349Inst Instance=new A243349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243350
{
public static readonly long[] Value={ 1L,3L,9L,9L,4L,3L,3L,3L,2L,8L,7L,2L,6L,3L,3L,0L,3L,1L,8L,2L,0L,2L,8L,0L,7L,2L,1L,4L,7L,4L,5L,6L,4L,4L,3L,2L,7L,9L,0L,4L,7L,2L,7L,4L,2L,9L,4L,8L,4L,3L,8L,3L,9L,4L,1L,2L,7L,4L,7L,6L,5L,8L,2L,2L,8L,8L,8L,0L,6L,2L,4L,9L,2L,4L,8L,7L,2L,4L,7L,8L,0L,0L,2L,3L,3L,3L,9L,0L,5L,2L,0L,0L,2L,1L,6L,6L,8L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243350Inst : IEnumerable<long>
{
public static readonly long[] Value=A243350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243350.Bytes);
public long this[int i]=>Value[i];

public static A243350Inst Instance=new A243350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243351
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,4L,5L,5L,6L,7L,7L,7L,7L,8L,9L,8L,7L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,15L,14L,15L,13L,13L,13L,13L,14L,15L,15L,16L,15L,16L,17L,17L,18L,19L,19L,20L,19L,20L,21L,20L,21L,21L,22L,23L,23L,23L,23L,24L,25L,25L,23L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243351Inst : IEnumerable<long>
{
public static readonly long[] Value=A243351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243351.Bytes);
public long this[int i]=>Value[i];

public static A243351Inst Instance=new A243351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243352
{
public static readonly long[] Value={ 1L,3L,5L,2L,7L,9L,11L,4L,6L,13L,15L,8L,17L,19L,21L,10L,23L,12L,25L,14L,27L,29L,31L,16L,18L,33L,20L,22L,35L,37L,39L,24L,41L,43L,45L,26L,47L,49L,51L,28L,53L,55L,57L,30L,32L,59L,61L,34L,36L,38L,63L,40L,65L,42L,67L,44L,69L,71L,73L,46L,75L,77L,48L,50L,79L,81L,83L,52L,85L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243352Inst : IEnumerable<long>
{
public static readonly long[] Value=A243352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243352.Bytes);
public long this[int i]=>Value[i];

public static A243352Inst Instance=new A243352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243353
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,8L,6L,5L,25L,18L,16L,27L,15L,12L,10L,7L,49L,50L,36L,75L,81L,32L,54L,125L,35L,30L,24L,45L,21L,20L,14L,11L,121L,98L,100L,147L,225L,72L,150L,245L,625L,162L,64L,243L,375L,108L,250L,343L,77L,70L,60L,105L,135L,48L,90L,175L,55L,42L,40L,63L,33L,28L,22L,13L,169L,242L,196L,363L,441L,200L,294L,605L,1225L,450L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243353Inst : IEnumerable<long>
{
public static readonly long[] Value=A243353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243353.Bytes);
public long this[int i]=>Value[i];

public static A243353Inst Instance=new A243353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243354
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,15L,5L,4L,14L,31L,13L,63L,30L,12L,10L,127L,9L,255L,29L,28L,62L,511L,26L,8L,126L,11L,61L,1023L,25L,2047L,21L,60L,254L,24L,18L,4095L,510L,124L,58L,8191L,57L,16383L,125L,27L,1022L,32767L,53L,16L,17L,252L,253L,65535L,22L,56L,122L,508L,2046L,131071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243354Inst : IEnumerable<long>
{
public static readonly long[] Value=A243354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243354.Bytes);
public long this[int i]=>Value[i];

public static A243354Inst Instance=new A243354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243355
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,28L,35L,36L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,53L,57L,58L,59L,60L,61L,64L,65L,66L,67L,68L,69L,70L,71L,72L,76L,77L,79L,85L,86L,87L,88L,89L,90L,91L,93L,96L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243355Inst : IEnumerable<long>
{
public static readonly long[] Value=A243355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243355.Bytes);
public long this[int i]=>Value[i];

public static A243355Inst Instance=new A243355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243356
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,18L,20L,22L,24L,27L,30L,32L,33L,34L,35L,36L,39L,40L,44L,46L,48L,51L,54L,55L,56L,57L,62L,64L,65L,66L,68L,69L,70L,74L,75L,77L,78L,80L,81L,82L,85L,86L,87L,88L,90L,91L,92L,93L,95L,96L,98L,99L,105L,106L,108L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243356Inst : IEnumerable<long>
{
public static readonly long[] Value=A243356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243356.Bytes);
public long this[int i]=>Value[i];

public static A243356Inst Instance=new A243356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243357
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,12L,4L,8L,7L,13L,6L,9L,15L,17L,16L,21L,22L,23L,24L,25L,26L,31L,28L,27L,51L,52L,32L,41L,53L,33L,35L,55L,36L,39L,61L,29L,62L,19L,63L,57L,64L,42L,44L,37L,56L,45L,65L,111L,112L,48L,66L,91L,113L,68L,43L,92L,46L,69L,93L,115L,116L,81L,95L,121L,96L,82L,119L,99L,122L,49L,71L,124L,84L,47L,72L,85L,67L,75L,59L,123L,117L,77L,73L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243357Inst : IEnumerable<long>
{
public static readonly long[] Value=A243357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243357.Bytes);
public long this[int i]=>Value[i];

public static A243357Inst Instance=new A243357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243358
{
public static readonly BigInteger[] Value={ 2L,2L,2L,3L,5L,7L,11L,19L,37L,83L,223L,739L,3181L,18911L,166657L,2375617L,60916697L,3199316947L,403223394631L,147983594957101L,200280265936061027L,BigInteger.Parse("1333721075205083093951"),BigInteger.Parse("62146579709944366260614273"),BigInteger.Parse("31146685223026045243771057244741") };
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
public class A243358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243358Inst Instance=new A243358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243359
{
public static readonly long[] Value={ 1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L,1L,5L,3L,4L,2L,2L,4L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243359Inst : IEnumerable<long>
{
public static readonly long[] Value=A243359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243359.Bytes);
public long this[int i]=>Value[i];

public static A243359Inst Instance=new A243359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243360
{
public static readonly long[] Value={ 1L,21L,31L,421L,51L,6321L,71L,8421L,931L,52110L,111L,6432211L,311L,74211L,55311L,864211L,711L,9863211L,911L,54221100L,73211L,222111L,321L,8644322211L,5521L,632211L,97321L,87442211L,921L,65533211100L,311L,86432211L,333111L,743211L,75531L,986643322111L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243360Inst : IEnumerable<long>
{
public static readonly long[] Value=A243360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243360.Bytes);
public long this[int i]=>Value[i];

public static A243360Inst Instance=new A243360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243361
{
public static readonly long[] Value={ 1L,12L,13L,124L,15L,1236L,17L,1248L,139L,1125L,111L,1122346L,113L,11247L,11355L,112468L,117L,1123689L,119L,112245L,11237L,111222L,123L,1122234468L,1255L,112236L,12379L,11224478L,129L,111233556L,113L,11223468L,111333L,112347L,13557L,111223346689L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243361Inst : IEnumerable<long>
{
public static readonly long[] Value=A243361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243361.Bytes);
public long this[int i]=>Value[i];

public static A243361Inst Instance=new A243361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243362
{
public static readonly long[] Value={ 54023L,54203L,500407L,23456789L,23458679L,23459687L,23465789L,23465987L,23469587L,23475869L,23478569L,23489657L,23495867L,23496587L,23498567L,23546879L,23546987L,23548697L,23564897L,23564987L,23567849L,23569487L,23576489L,23584679L,23587649L,23589647L,23594687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243362Inst : IEnumerable<long>
{
public static readonly long[] Value=A243362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243362.Bytes);
public long this[int i]=>Value[i];

public static A243362Inst Instance=new A243362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243363
{
public static readonly long[] Value={ 203457869L,203465789L,203465897L,203468579L,203475869L,203478659L,203485697L,203485769L,203495867L,203548967L,203564897L,203568947L,203574689L,203584679L,203584769L,203594687L,203596847L,203598467L,203645879L,203645987L,203648957L,203654987L,203659487L,203674589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243363Inst : IEnumerable<long>
{
public static readonly long[] Value=A243363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243363.Bytes);
public long this[int i]=>Value[i];

public static A243363Inst Instance=new A243363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243364
{
public static readonly long[] Value={ 23456789L,23458679L,23459687L,23465789L,23465987L,23469587L,23475869L,23478569L,23489657L,23495867L,23496587L,23498567L,23546879L,23546987L,23548697L,23564897L,23564987L,23567849L,23569487L,23576489L,23584679L,23587649L,23589647L,23594687L,23645879L,23645987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243364Inst : IEnumerable<long>
{
public static readonly long[] Value=A243364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243364.Bytes);
public long this[int i]=>Value[i];

public static A243364Inst Instance=new A243364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243365
{
public static readonly long[] Value={ 101L,157L,173L,229L,233L,239L,347L,349L,353L,421L,439L,479L,521L,577L,619L,661L,719L,751L,761L,829L,881L,1019L,1061L,1117L,1129L,1153L,1277L,1289L,1321L,1447L,1453L,1489L,1523L,1579L,1721L,1733L,1801L,1811L,1823L,1831L,1861L,1871L,1873L,2027L,2099L,2221L,2239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243365Inst : IEnumerable<long>
{
public static readonly long[] Value=A243365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243365.Bytes);
public long this[int i]=>Value[i];

public static A243365Inst Instance=new A243365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243366
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,1L,37L,5L,112L,19L,1L,352L,70L,7L,1136L,259L,34L,1L,3742L,962L,149L,9L,12529L,3585L,627L,54L,1L,42513L,13399L,2584L,279L,11L,145868L,50201L,10529L,1334L,79L,1L,505234L,188481L,42606L,6092L,474L,13L,1764157L,709001L,171563L,27048L,2561L,109L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243366Inst : IEnumerable<long>
{
public static readonly long[] Value=A243366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243366.Bytes);
public long this[int i]=>Value[i];

public static A243366Inst Instance=new A243366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243367
{
public static readonly long[] Value={ 3L,7L,11L,13L,31L,53L,59L,71L,83L,97L,101L,127L,151L,157L,179L,181L,211L,223L,227L,239L,311L,367L,379L,449L,487L,521L,599L,601L,613L,619L,631L,743L,773L,809L,827L,883L,977L,1009L,1021L,1039L,1091L,1093L,1103L,1117L,1193L,1201L,1217L,1249L,1427L,1471L,1481L,1483L,1487L,1567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243367Inst : IEnumerable<long>
{
public static readonly long[] Value=A243367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243367.Bytes);
public long this[int i]=>Value[i];

public static A243367Inst Instance=new A243367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243368
{
public static readonly long[] Value={ 7L,13L,211L,601L,743L,2281L,2659L,2897L,3109L,3361L,4271L,4397L,6173L,7321L,7351L,8807L,8863L,11941L,12377L,13033L,13159L,13999L,14449L,14951L,20117L,20161L,20551L,22709L,24109L,25733L,27299L,27749L,29989L,30071L,31123L,31541L,33347L,33377L,33487L,33629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243368Inst : IEnumerable<long>
{
public static readonly long[] Value=A243368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243368.Bytes);
public long this[int i]=>Value[i];

public static A243368Inst Instance=new A243368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243369
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,2355L,17497263L,1860801514823609L,BigInteger.Parse("3584505381349378370871887741627"),BigInteger.Parse("85751894581999497691951513557530024967086681471033652102477414") };
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
public class A243369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243369Inst Instance=new A243369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243370
{
public static readonly long[] Value={ 1L,8L,2L,5L,2L,0L,7L,6L,3L,4L,7L,6L,9L,3L,3L,5L,0L,6L,8L,0L,5L,1L,8L,3L,4L,1L,5L,5L,7L,8L,3L,3L,4L,2L,4L,8L,6L,2L,2L,8L,9L,5L,8L,9L,7L,7L,4L,9L,7L,8L,6L,2L,8L,5L,6L,9L,6L,5L,4L,5L,0L,0L,8L,0L,5L,0L,0L,5L,0L,9L,8L,2L,2L,4L,9L,2L,8L,1L,2L,5L,3L,5L,7L,5L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243370Inst : IEnumerable<long>
{
public static readonly long[] Value=A243370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243370.Bytes);
public long this[int i]=>Value[i];

public static A243370Inst Instance=new A243370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243371
{
public static readonly long[] Value={ 4L,6L,4L,5L,9L,2L,2L,7L,0L,8L,9L,4L,7L,9L,0L,5L,1L,2L,9L,2L,0L,7L,6L,7L,4L,9L,3L,2L,0L,0L,8L,3L,6L,9L,1L,9L,4L,8L,0L,0L,4L,9L,3L,7L,0L,4L,2L,7L,9L,8L,6L,9L,5L,2L,2L,9L,8L,6L,0L,3L,1L,1L,1L,6L,1L,5L,2L,4L,1L,7L,7L,9L,6L,2L,6L,7L,2L,9L,2L,7L,4L,1L,9L,3L,3L,1L,7L,2L,1L,0L,8L,2L,0L,5L,6L,7L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243371Inst : IEnumerable<long>
{
public static readonly long[] Value=A243371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243371.Bytes);
public long this[int i]=>Value[i];

public static A243371Inst Instance=new A243371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243372
{
public static readonly long[] Value={ 4L,9L,0L,6L,9L,4L,0L,5L,0L,4L,1L,1L,5L,3L,9L,5L,7L,3L,6L,0L,0L,3L,4L,9L,3L,0L,3L,5L,4L,2L,5L,8L,9L,1L,9L,9L,5L,4L,2L,5L,7L,1L,3L,1L,1L,4L,4L,1L,9L,5L,5L,2L,3L,0L,3L,7L,5L,1L,7L,1L,6L,6L,7L,3L,6L,8L,3L,5L,7L,7L,3L,0L,1L,9L,2L,4L,8L,6L,0L,8L,4L,9L,5L,2L,3L,7L,7L,1L,6L,2L,1L,8L,1L,1L,4L,8L,0L,2L,0L,4L,9L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243372Inst : IEnumerable<long>
{
public static readonly long[] Value=A243372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243372.Bytes);
public long this[int i]=>Value[i];

public static A243372Inst Instance=new A243372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243373
{
public static readonly long[] Value={ 1L,2L,6L,9L,10L,14L,18L,26L,42L,66L,90L,126L,150L,186L,234L,266L,342L,490L,666L,1426L,1634L,2394L,4410L,12834L,14706L,16758L,18846L,209754L,308602L,350154L,385434L,1122786L,2777418L,12130734L,15616986L,29682342L,223843466L,270397974L,300398714L,559894482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243373Inst : IEnumerable<long>
{
public static readonly long[] Value=A243373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243373.Bytes);
public long this[int i]=>Value[i];

public static A243373Inst Instance=new A243373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243374
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,0L,7L,0L,3L,0L,1L,0L,0L,0L,3L,0L,7L,0L,13L,0L,11L,0L,0L,0L,1L,0L,27L,0L,1L,0L,7L,0L,0L,0L,3L,0L,7L,0L,9L,0L,39L,0L,0L,0L,9L,0L,1L,0L,19L,0L,51L,0L,0L,0L,1L,0L,3L,0L,7L,0L,1L,0L,0L,0L,3L,0L,49L,0L,9L,0L,3L,0L,0L,0L,17L,0L,19L,0L,1L,0L,9L,0L,0L,0L,7L,0L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243374Inst : IEnumerable<long>
{
public static readonly long[] Value=A243374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243374.Bytes);
public long this[int i]=>Value[i];

public static A243374Inst Instance=new A243374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243375
{
public static readonly long[] Value={ 3L,2L,7L,1L,2L,9L,3L,6L,6L,9L,4L,1L,0L,2L,6L,3L,8L,2L,4L,0L,0L,2L,3L,2L,8L,6L,9L,0L,2L,8L,3L,9L,2L,7L,9L,9L,6L,9L,5L,0L,4L,7L,5L,4L,0L,9L,6L,1L,3L,0L,3L,4L,8L,6L,9L,1L,6L,7L,8L,1L,1L,1L,1L,5L,7L,8L,9L,0L,5L,1L,5L,3L,4L,6L,1L,6L,5L,7L,3L,8L,9L,9L,6L,8L,2L,5L,1L,4L,4L,1L,4L,5L,4L,0L,9L,8L,6L,8L,0L,3L,2L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243375Inst : IEnumerable<long>
{
public static readonly long[] Value=A243375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243375.Bytes);
public long this[int i]=>Value[i];

public static A243375Inst Instance=new A243375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243376
{
public static readonly long[] Value={ 4L,8L,6L,5L,1L,9L,8L,8L,8L,3L,8L,5L,8L,9L,0L,9L,9L,7L,1L,2L,7L,2L,4L,5L,6L,4L,0L,5L,8L,6L,8L,2L,3L,4L,0L,5L,5L,3L,8L,1L,7L,1L,9L,8L,1L,7L,3L,9L,5L,4L,1L,2L,1L,3L,6L,8L,8L,1L,5L,4L,5L,1L,0L,8L,1L,6L,2L,9L,8L,5L,5L,0L,9L,3L,2L,0L,7L,5L,8L,1L,7L,1L,4L,7L,6L,0L,2L,0L,2L,1L,0L,3L,8L,1L,0L,6L,9L,3L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243376Inst : IEnumerable<long>
{
public static readonly long[] Value=A243376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243376.Bytes);
public long this[int i]=>Value[i];

public static A243376Inst Instance=new A243376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243377
{
public static readonly long[] Value={ 7L,3L,2L,6L,4L,9L,8L,1L,9L,2L,8L,3L,8L,3L,2L,6L,1L,3L,6L,2L,0L,3L,0L,5L,8L,2L,3L,1L,1L,7L,6L,8L,3L,6L,8L,7L,3L,6L,3L,1L,6L,9L,9L,4L,4L,1L,9L,9L,4L,6L,3L,2L,9L,3L,4L,5L,0L,6L,0L,7L,7L,7L,2L,9L,6L,3L,8L,3L,4L,3L,1L,9L,3L,3L,1L,8L,7L,7L,1L,9L,0L,6L,4L,0L,4L,9L,1L,5L,5L,2L,9L,2L,7L,7L,9L,6L,8L,9L,1L,4L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243377Inst : IEnumerable<long>
{
public static readonly long[] Value=A243377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243377.Bytes);
public long this[int i]=>Value[i];

public static A243377Inst Instance=new A243377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243378
{
public static readonly long[] Value={ 9L,8L,5L,2L,4L,7L,5L,8L,1L,0L,0L,6L,0L,9L,6L,3L,4L,3L,6L,9L,0L,5L,1L,0L,6L,0L,4L,2L,9L,8L,8L,9L,6L,8L,0L,1L,0L,8L,1L,2L,1L,6L,4L,7L,9L,1L,4L,4L,4L,0L,2L,8L,2L,4L,7L,1L,7L,2L,1L,1L,8L,8L,9L,5L,6L,5L,1L,3L,3L,9L,1L,6L,2L,8L,8L,5L,1L,9L,2L,1L,9L,1L,2L,2L,7L,6L,2L,8L,5L,2L,2L,3L,3L,8L,4L,5L,3L,4L,4L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243378Inst : IEnumerable<long>
{
public static readonly long[] Value=A243378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243378.Bytes);
public long this[int i]=>Value[i];

public static A243378Inst Instance=new A243378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243379
{
public static readonly long[] Value={ 8L,5L,6L,1L,0L,8L,9L,8L,1L,7L,2L,1L,8L,9L,3L,4L,7L,6L,9L,0L,6L,0L,3L,3L,0L,0L,6L,1L,4L,8L,0L,6L,1L,1L,7L,3L,4L,8L,1L,0L,7L,8L,4L,2L,7L,3L,8L,8L,1L,7L,3L,4L,9L,0L,8L,6L,0L,5L,1L,8L,4L,0L,0L,5L,8L,3L,4L,3L,0L,7L,9L,6L,1L,1L,1L,8L,6L,3L,6L,5L,8L,9L,6L,2L,3L,3L,8L,1L,2L,9L,4L,5L,1L,7L,7L,7L,7L,0L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243379Inst : IEnumerable<long>
{
public static readonly long[] Value=A243379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243379.Bytes);
public long this[int i]=>Value[i];

public static A243379Inst Instance=new A243379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243380
{
public static readonly long[] Value={ 1L,0L,5L,4L,4L,3L,9L,9L,4L,4L,7L,9L,9L,9L,4L,8L,4L,8L,9L,6L,4L,8L,8L,1L,9L,4L,6L,4L,8L,2L,6L,7L,1L,7L,9L,4L,8L,3L,1L,7L,3L,4L,3L,6L,5L,0L,6L,9L,7L,0L,6L,0L,4L,8L,8L,0L,7L,8L,4L,8L,9L,7L,2L,7L,6L,1L,8L,5L,7L,7L,4L,6L,8L,0L,4L,2L,1L,5L,8L,2L,9L,3L,8L,7L,1L,6L,4L,3L,3L,6L,0L,3L,3L,7L,6L,6L,8L,5L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243380Inst : IEnumerable<long>
{
public static readonly long[] Value=A243380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243380.Bytes);
public long this[int i]=>Value[i];

public static A243380Inst Instance=new A243380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243381
{
public static readonly long[] Value={ 1L,1L,5L,3L,0L,8L,0L,5L,6L,1L,5L,8L,5L,4L,4L,7L,8L,7L,0L,3L,6L,5L,2L,5L,8L,0L,6L,8L,5L,6L,1L,7L,6L,3L,3L,6L,5L,1L,0L,4L,8L,4L,4L,8L,7L,0L,8L,0L,3L,9L,3L,1L,8L,8L,6L,7L,7L,9L,2L,3L,1L,9L,0L,2L,1L,0L,3L,5L,4L,6L,8L,4L,1L,3L,2L,5L,2L,9L,8L,2L,0L,0L,4L,3L,5L,4L,9L,2L,5L,3L,5L,9L,2L,8L,1L,2L,0L,7L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243381Inst : IEnumerable<long>
{
public static readonly long[] Value=A243381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243381.Bytes);
public long this[int i]=>Value[i];

public static A243381Inst Instance=new A243381Inst();

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