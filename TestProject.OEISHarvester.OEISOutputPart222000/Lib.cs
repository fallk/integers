using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A260382
{
public static readonly long[] Value={ 3L,7L,37L,73L,79L,97L,337L,373L,379L,397L,733L,739L,773L,797L,937L,977L,997L,3373L,3733L,3739L,3779L,3793L,3797L,7333L,7393L,7793L,7933L,7937L,7993L,9337L,9377L,9397L,9733L,9739L,9973L,33377L,33739L,33773L,33797L,33937L,33997L,37337L,37339L,37379L,37397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260382Inst : IEnumerable<long>
{
public static readonly long[] Value=A260382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260382.Bytes);
public long this[int i]=>Value[i];

public static A260382Inst Instance=new A260382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260383
{
public static readonly long[] Value={ 0L,1L,0L,36L,15L,6L,2304L,1280L,704L,384L,250000L,159375L,101250L,64125L,40500L,41990400L,29113344L,20155392L,13934592L,9621504L,6635520L,10169108964L,7465417295L,5476560950L,4014772125L,2941225000L,2153396875L,1575656250L,3367254360064L,2576980377600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260383Inst : IEnumerable<long>
{
public static readonly long[] Value=A260383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260383.Bytes);
public long this[int i]=>Value[i];

public static A260383Inst Instance=new A260383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260384
{
public static readonly long[] Value={ 6L,16L,44L,122L,268L,556L,886L,1446L,1964L,2900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260384Inst : IEnumerable<long>
{
public static readonly long[] Value=A260384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260384.Bytes);
public long this[int i]=>Value[i];

public static A260384Inst Instance=new A260384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260385
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,12L,15L,20L,24L,25L,30L,32L,40L,50L,56L,58L,59L,60L,69L,75L,100L,112L,120L,125L,150L,170L,175L,200L,220L,240L,250L,275L,276L,300L,320L,325L,366L,399L,400L,440L,500L,510L,525L,600L,660L,726L,775L,1000L,1250L,2000L,2200L,2360L,2413L,2500L,3142L,3200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260385Inst : IEnumerable<long>
{
public static readonly long[] Value=A260385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260385.Bytes);
public long this[int i]=>Value[i];

public static A260385Inst Instance=new A260385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260386
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,12L,15L,19L,21L,24L,25L,48L,68L,75L,96L,123L,228L,231L,275L,312L,321L,375L,451L,484L,712L,726L,768L,868L,1234L,1324L,2143L,2341L,3412L,3421L,4123L,4231L,4312L,4321L,4544L,11425L,12345L,13425L,14235L,14325L,21354L,23451L,24153L,24351L,31524L,32541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260386Inst : IEnumerable<long>
{
public static readonly long[] Value=A260386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260386.Bytes);
public long this[int i]=>Value[i];

public static A260386Inst Instance=new A260386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260387
{
public static readonly long[] Value={ 12L,13L,320L,3201L,72200L,89000L,132110L,345000L,643000L,2320200L,3121300L,10103111L,11300130L,42430000L,51340000L,64030000L,72300000L,86300000L,125102000L,130213000L,211220001L,220101111L,323111000L,431130000L,614110000L,667000000L,2153100000L,2521002000L,3021211100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260387Inst : IEnumerable<long>
{
public static readonly long[] Value=A260387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260387.Bytes);
public long this[int i]=>Value[i];

public static A260387Inst Instance=new A260387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260388
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,29L,53L,89L,199L,271L,349L,823L,1747L,2251L,2593L,6569L,7121L,27479L,44129L,85361L,115259L,254731L,462103L,903751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260388Inst : IEnumerable<long>
{
public static readonly long[] Value=A260388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260388.Bytes);
public long this[int i]=>Value[i];

public static A260388Inst Instance=new A260388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260389
{
public static readonly long[] Value={ 2L,2L,3L,6L,3L,3L,7L,42L,7L,73L,39L,288L,27L,27L,135L,1974L,1419L,861L,2787L,13530L,7297L,5247L,33963L,92736L,100033L,161857L,116395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260389Inst : IEnumerable<long>
{
public static readonly long[] Value=A260389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260389.Bytes);
public long this[int i]=>Value[i];

public static A260389Inst Instance=new A260389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260390
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260390Inst : IEnumerable<long>
{
public static readonly long[] Value=A260390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260390.Bytes);
public long this[int i]=>Value[i];

public static A260390Inst Instance=new A260390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260391
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,38L,40L,42L,44L,46L,50L,52L,54L,56L,58L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260391Inst : IEnumerable<long>
{
public static readonly long[] Value=A260391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260391.Bytes);
public long this[int i]=>Value[i];

public static A260391Inst Instance=new A260391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260392
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,12L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,36L,37L,39L,41L,43L,45L,47L,48L,49L,51L,53L,55L,57L,59L,60L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,84L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,108L,109L,111L,113L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260392Inst : IEnumerable<long>
{
public static readonly long[] Value=A260392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260392.Bytes);
public long this[int i]=>Value[i];

public static A260392Inst Instance=new A260392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260393
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260393Inst : IEnumerable<long>
{
public static readonly long[] Value=A260393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260393.Bytes);
public long this[int i]=>Value[i];

public static A260393Inst Instance=new A260393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260394
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260394Inst : IEnumerable<long>
{
public static readonly long[] Value=A260394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260394.Bytes);
public long this[int i]=>Value[i];

public static A260394Inst Instance=new A260394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260395
{
public static readonly long[] Value={ 1L,4L,7L,9L,12L,15L,17L,20L,23L,25L,28L,31L,32L,33L,36L,39L,41L,44L,47L,49L,52L,55L,57L,60L,63L,65L,68L,71L,73L,76L,79L,81L,84L,87L,89L,92L,95L,96L,97L,100L,103L,105L,108L,111L,113L,116L,119L,121L,124L,127L,129L,132L,135L,137L,140L,143L,145L,148L,151L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260395Inst : IEnumerable<long>
{
public static readonly long[] Value=A260395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260395.Bytes);
public long this[int i]=>Value[i];

public static A260395Inst Instance=new A260395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260396
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,10L,11L,13L,14L,16L,18L,19L,21L,22L,24L,26L,27L,29L,30L,34L,35L,37L,38L,40L,42L,43L,45L,46L,48L,50L,51L,53L,54L,56L,58L,59L,61L,62L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,82L,83L,85L,86L,88L,90L,91L,93L,94L,98L,99L,101L,102L,104L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260396Inst : IEnumerable<long>
{
public static readonly long[] Value=A260396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260396.Bytes);
public long this[int i]=>Value[i];

public static A260396Inst Instance=new A260396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260397
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260397Inst : IEnumerable<long>
{
public static readonly long[] Value=A260397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260397.Bytes);
public long this[int i]=>Value[i];

public static A260397Inst Instance=new A260397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260398
{
public static readonly long[] Value={ 3L,5L,11L,13L,16L,19L,21L,27L,29L,35L,37L,43L,45L,48L,51L,53L,59L,61L,64L,67L,69L,75L,77L,80L,83L,85L,91L,93L,99L,101L,107L,109L,112L,115L,117L,123L,125L,131L,133L,139L,141L,144L,147L,149L,155L,157L,163L,165L,171L,173L,176L,179L,181L,187L,189L,192L,195L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260398Inst : IEnumerable<long>
{
public static readonly long[] Value=A260398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260398.Bytes);
public long this[int i]=>Value[i];

public static A260398Inst Instance=new A260398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260399
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,9L,10L,12L,14L,15L,17L,18L,20L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,36L,38L,39L,40L,41L,42L,44L,46L,47L,49L,50L,52L,54L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,70L,71L,72L,73L,74L,76L,78L,79L,81L,82L,84L,86L,87L,88L,89L,90L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260399Inst : IEnumerable<long>
{
public static readonly long[] Value=A260399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260399.Bytes);
public long this[int i]=>Value[i];

public static A260399Inst Instance=new A260399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260400
{
public static readonly long[] Value={ 2L,6L,8L,10L,14L,18L,22L,24L,26L,30L,34L,38L,40L,42L,46L,50L,54L,56L,58L,62L,66L,70L,72L,74L,78L,82L,86L,88L,90L,94L,98L,102L,104L,106L,110L,114L,118L,120L,122L,126L,128L,130L,134L,136L,138L,142L,146L,150L,152L,154L,158L,162L,166L,168L,170L,174L,178L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260400Inst : IEnumerable<long>
{
public static readonly long[] Value=A260400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260400.Bytes);
public long this[int i]=>Value[i];

public static A260400Inst Instance=new A260400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260401
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,11L,12L,13L,15L,16L,17L,19L,20L,21L,23L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,41L,43L,44L,45L,47L,48L,49L,51L,52L,53L,55L,57L,59L,60L,61L,63L,64L,65L,67L,68L,69L,71L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,89L,91L,92L,93L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260401Inst : IEnumerable<long>
{
public static readonly long[] Value=A260401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260401.Bytes);
public long this[int i]=>Value[i];

public static A260401Inst Instance=new A260401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260402
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,16L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,34L,37L,38L,39L,41L,43L,44L,46L,47L,49L,50L,51L,53L,57L,58L,59L,61L,62L,64L,67L,68L,69L,71L,73L,74L,79L,81L,82L,83L,86L,87L,89L,92L,93L,94L,97L,98L,101L,103L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260402Inst : IEnumerable<long>
{
public static readonly long[] Value=A260402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260402.Bytes);
public long this[int i]=>Value[i];

public static A260402Inst Instance=new A260402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260403
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,3L,5L,8L,14L,24L,43L,76L,138L,250L,460L,848L,1576L,2939L,5516L,10382L,19629L,37221L,70820L,135097L,258426L,495460L,952083L,1833176L,3536502L,6834408L,13229829L,25649202L,49799891L,96821854L,188485968L,367375883L,716872030L,1400373358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260403Inst : IEnumerable<long>
{
public static readonly long[] Value=A260403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260403.Bytes);
public long this[int i]=>Value[i];

public static A260403Inst Instance=new A260403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260404
{
public static readonly BigInteger[] Value={ 1L,1L,2L,192L,6115295232L,BigInteger.Parse("15436756676507918107049554083840"),BigInteger.Parse("18356962141505758798331790171539976807981714702571497465907439808868887035904000000") };
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
public class A260404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260404Inst Instance=new A260404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260405
{
public static readonly long[] Value={ 5L,7L,13L,17L,19L,23L,29L,11L,19L,23L,31L,37L,41L,47L,53L,61L,67L,71L,73L,83L,89L,103L,107L,109L,113L,127L,137L,139L,149L,151L,157L,163L,179L,181L,191L,193L,197L,17L,23L,29L,37L,53L,59L,71L,73L,97L,101L,103L,107L,113L,127L,137L,139L,157L,163L,173L,179L,197L,199L,211L,223L,229L,257L,263L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260405Inst : IEnumerable<long>
{
public static readonly long[] Value=A260405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260405.Bytes);
public long this[int i]=>Value[i];

public static A260405Inst Instance=new A260405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260406
{
public static readonly long[] Value={ 1L,3L,5L,17L,37L,257L,457L,1297L,2557L,4357L,6481L,8009L,11953L,26321L,44101L,47521L,47881L,49681L,57241L,65537L,74449L,84421L,97813L,141157L,157081L,165601L,225457L,278497L,310591L,333433L,365941L,403901L,419711L,476737L,557041L,560737L,576721L,647089L,1011961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260406Inst : IEnumerable<long>
{
public static readonly long[] Value=A260406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260406.Bytes);
public long this[int i]=>Value[i];

public static A260406Inst Instance=new A260406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260407
{
public static readonly long[] Value={ 1L,17L,257L,8209L,65537L,649801L,1382401L,4294967297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260407Inst : IEnumerable<long>
{
public static readonly long[] Value=A260407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260407.Bytes);
public long this[int i]=>Value[i];

public static A260407Inst Instance=new A260407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260408
{
public static readonly long[] Value={ 3L,7L,11L,7L,17L,29L,41L,53L,31L,71L,29L,107L,61L,41L,131L,53L,157L,113L,179L,239L,131L,79L,73L,127L,127L,229L,223L,113L,199L,73L,317L,181L,43L,269L,241L,89L,193L,101L,89L,211L,331L,167L,313L,409L,97L,113L,401L,480L,193L,109L,457L,241L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260408Inst : IEnumerable<long>
{
public static readonly long[] Value=A260408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260408.Bytes);
public long this[int i]=>Value[i];

public static A260408Inst Instance=new A260408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260409
{
public static readonly long[] Value={ 8L,16L,18L,27L,45L,50L,54L,60L,64L,84L,99L,132L,147L,153L,162L,207L,220L,225L,228L,240L,242L,243L,245L,255L,256L,264L,280L,297L,315L,325L,336L,338L,343L,348L,364L,369L,375L,423L,425L,435L,440L,455L,460L,468L,475L,477L,486L,487L,507L,539L,552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260409Inst : IEnumerable<long>
{
public static readonly long[] Value=A260409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260409.Bytes);
public long this[int i]=>Value[i];

public static A260409Inst Instance=new A260409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260410
{
public static readonly long[] Value={ 3276L,21L,2L,18L,6L,5L,7L,44L,1L,3L,23L,30L,19L,16L,78L,10L,26L,27L,4L,183L,9L,57L,260L,58L,138L,84L,59L,80L,208L,281L,147L,476L,49L,11L,282L,192L,114L,290L,553L,222L,851L,1582L,1077L,293L,348L,15L,700L,155L,37L,1234L,1786L,93L,266L,1103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260410Inst : IEnumerable<long>
{
public static readonly long[] Value=A260410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260410.Bytes);
public long this[int i]=>Value[i];

public static A260410Inst Instance=new A260410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260411
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,0L,2L,0L,1L,2L,2L,2L,0L,3L,1L,1L,3L,1L,4L,0L,1L,3L,1L,2L,1L,5L,0L,2L,3L,2L,4L,2L,4L,0L,2L,3L,6L,3L,2L,3L,1L,3L,1L,5L,4L,4L,2L,2L,2L,2L,3L,5L,4L,2L,2L,3L,4L,2L,4L,1L,4L,1L,5L,4L,3L,4L,3L,4L,0L,7L,5L,5L,2L,4L,3L,1L,7L,4L,5L,3L,3L,8L,1L,2L,6L,2L,6L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260411Inst : IEnumerable<long>
{
public static readonly long[] Value=A260411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260411.Bytes);
public long this[int i]=>Value[i];

public static A260411Inst Instance=new A260411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260412
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,2L,3L,2L,3L,4L,4L,5L,7L,6L,9L,10L,11L,12L,13L,15L,17L,19L,21L,24L,28L,30L,35L,37L,41L,47L,52L,56L,62L,69L,75L,83L,92L,99L,110L,121L,131L,143L,157L,170L,186L,203L,219L,239L,260L,281L,307L,332L,359L,389L,421L,453L,491L,530L,570L,617L,665L,714L,770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260412Inst : IEnumerable<long>
{
public static readonly long[] Value=A260412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260412.Bytes);
public long this[int i]=>Value[i];

public static A260412Inst Instance=new A260412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260413
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,0L,1L,-1L,0L,0L,-1L,0L,1L,-1L,1L,1L,0L,0L,0L,-1L,0L,0L,-1L,0L,1L,-1L,1L,0L,-1L,1L,1L,-1L,0L,1L,-1L,0L,1L,-2L,1L,1L,-1L,0L,1L,-1L,0L,1L,-2L,0L,1L,-2L,1L,1L,-1L,1L,1L,-2L,1L,1L,-2L,1L,2L,-2L,1L,1L,-2L,1L,1L,-2L,0L,1L,-3L,0L,2L,-3L,2L,2L,-2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260413Inst : IEnumerable<long>
{
public static readonly long[] Value=A260413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260413.Bytes);
public long this[int i]=>Value[i];

public static A260413Inst Instance=new A260413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260414
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,2L,2L,1L,2L,3L,2L,2L,4L,5L,4L,5L,6L,7L,7L,7L,9L,12L,11L,11L,15L,16L,16L,18L,21L,24L,25L,26L,31L,36L,35L,38L,45L,50L,51L,55L,63L,69L,73L,77L,87L,98L,101L,107L,122L,132L,138L,149L,164L,180L,190L,201L,222L,243L,254L,271L,300L,324L,340L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260414Inst : IEnumerable<long>
{
public static readonly long[] Value=A260414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260414.Bytes);
public long this[int i]=>Value[i];

public static A260414Inst Instance=new A260414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260415
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,0L,2L,1L,0L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,1L,1L,3L,0L,1L,1L,1L,3L,0L,0L,0L,1L,2L,0L,1L,2L,1L,0L,1L,0L,2L,1L,2L,1L,0L,1L,1L,3L,0L,1L,0L,1L,3L,2L,1L,2L,0L,2L,0L,1L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,0L,1L,1L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260415Inst : IEnumerable<long>
{
public static readonly long[] Value=A260415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260415.Bytes);
public long this[int i]=>Value[i];

public static A260415Inst Instance=new A260415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260416
{
public static readonly long[] Value={ 3L,5L,13L,11L,71L,19L,41L,103L,101L,97L,73L,197L,587L,229L,109L,281L,607L,79L,421L,233L,167L,101L,521L,113L,607L,127L,233L,349L,683L,821L,1301L,163L,307L,173L,631L,1093L,1607L,853L,373L,1597L,757L,223L,1571L,1009L,439L,643L,2579L,271L,503L,2111L,983L,769L,1499L,1811L,569L,2423L,3823L,3581L,613L,2027L,1193L,941L,677L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260416Inst : IEnumerable<long>
{
public static readonly long[] Value=A260416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260416.Bytes);
public long this[int i]=>Value[i];

public static A260416Inst Instance=new A260416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260417
{
public static readonly long[] Value={ 0L,1L,12L,30L,128L,147L,264L,1056L,600L,825L,2380L,1482L,1932L,9635L,3024L,3672L,8484L,5301L,6300L,19474L,8580L,9867L,20744L,12900L,14664L,30141L,18564L,20706L,62200L,25575L,28320L,54956L,34272L,37485L,62868L,44622L,48564L,86359L,57000L,61500L,117068L,71337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260417Inst : IEnumerable<long>
{
public static readonly long[] Value=A260417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260417.Bytes);
public long this[int i]=>Value[i];

public static A260417Inst Instance=new A260417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260418
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,3L,2L,4L,3L,2L,3L,2L,5L,2L,3L,3L,2L,4L,3L,3L,3L,2L,5L,2L,3L,3L,2L,6L,3L,4L,3L,5L,6L,3L,3L,5L,3L,5L,4L,2L,5L,4L,7L,3L,2L,7L,4L,6L,2L,2L,4L,3L,8L,4L,1L,2L,4L,8L,6L,2L,5L,2L,7L,4L,4L,3L,4L,5L,2L,4L,5L,6L,4L,3L,2L,5L,2L,7L,4L,5L,5L,2L,5L,3L,6L,5L,4L,7L,3L,4L,3L,5L,9L,3L,4L,3L,5L,11L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260418Inst : IEnumerable<long>
{
public static readonly long[] Value=A260418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260418.Bytes);
public long this[int i]=>Value[i];

public static A260418Inst Instance=new A260418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260419
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,4L,1L,1L,5L,16L,11L,1L,1L,5L,16L,27L,16L,1L,1L,7L,25L,125L,81L,42L,1L,1L,7L,49L,125L,256L,378L,64L,1L,1L,9L,49L,243L,1296L,1184L,729L,163L,1L,1L,9L,64L,343L,1296L,3125L,4096L,2187L,256L,1L,1L,11L,100L,729L,2401L,16807L,15625L,27213L,9529L,638L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260419Inst : IEnumerable<long>
{
public static readonly long[] Value=A260419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260419.Bytes);
public long this[int i]=>Value[i];

public static A260419Inst Instance=new A260419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260420
{
public static readonly long[] Value={ 2L,3L,23L,14927L,31049L,69107L,246263L,5860169L,307164671L,881198663L,1489455647L,2386555631L,8225563703L,14311679063L,111494234183L,154357775303L,299004519623L,870455062823L,970388922263L,991817878343L,1677028870823L,1782783762503L,1830446935223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260420Inst : IEnumerable<long>
{
public static readonly long[] Value=A260420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260420.Bytes);
public long this[int i]=>Value[i];

public static A260420Inst Instance=new A260420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260421
{
public static readonly long[] Value={ 1L,3L,7L,2L,15L,6L,5L,14L,4L,30L,31L,12L,13L,10L,28L,8L,11L,60L,29L,62L,24L,26L,9L,20L,61L,56L,16L,22L,63L,120L,25L,58L,124L,48L,52L,18L,27L,40L,122L,112L,21L,32L,57L,44L,126L,240L,17L,50L,116L,248L,96L,104L,23L,36L,121L,54L,80L,244L,59L,224L,125L,42L,64L,114L,88L,252L,49L,480L,53L,34L,19L,100L,41L,232L,496L,192L,123L,208L,113L,46L,33L,72L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260421Inst : IEnumerable<long>
{
public static readonly long[] Value=A260421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260421.Bytes);
public long this[int i]=>Value[i];

public static A260421Inst Instance=new A260421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260422
{
public static readonly long[] Value={ 1L,4L,2L,9L,7L,6L,3L,16L,23L,14L,17L,12L,13L,8L,5L,27L,47L,36L,71L,24L,41L,28L,53L,21L,31L,22L,37L,15L,19L,10L,11L,42L,81L,70L,149L,54L,109L,106L,239L,38L,73L,62L,127L,44L,83L,80L,171L,34L,67L,48L,91L,35L,69L,56L,113L,26L,43L,32L,59L,18L,25L,20L,29L,63L,131L,122L,271L,105L,233L,216L,477L,82L,173L,159L,353L,155L,347L,345L,787L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260422Inst : IEnumerable<long>
{
public static readonly long[] Value=A260422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260422.Bytes);
public long this[int i]=>Value[i];

public static A260422Inst Instance=new A260422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260423
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,28L,30L,25L,32L,29L,33L,34L,35L,36L,38L,31L,40L,42L,44L,37L,46L,41L,39L,49L,45L,43L,50L,51L,52L,54L,57L,47L,48L,60L,63L,65L,56L,53L,68L,55L,62L,58L,74L,66L,64L,59L,75L,76L,78L,61L,82L,67L,86L,70L,72L,92L,95L,69L,98L,85L,80L,71L,102L,84L,94L,88L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260423Inst : IEnumerable<long>
{
public static readonly long[] Value=A260423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260423.Bytes);
public long this[int i]=>Value[i];

public static A260423Inst Instance=new A260423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260424
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,29L,25L,26L,27L,31L,28L,37L,30L,32L,33L,34L,35L,41L,36L,44L,38L,43L,39L,47L,40L,46L,42L,53L,54L,45L,48L,49L,50L,59L,51L,61L,58L,52L,63L,67L,55L,71L,62L,56L,66L,57L,65L,73L,60L,79L,75L,83L,76L,89L,64L,68L,69L,109L,70L,97L,82L,101L,72L,103L,85L,81L,74L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260424Inst : IEnumerable<long>
{
public static readonly long[] Value=A260424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260424.Bytes);
public long this[int i]=>Value[i];

public static A260424Inst Instance=new A260424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260425
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,9L,12L,15L,7L,10L,13L,16L,21L,26L,14L,18L,19L,22L,27L,34L,40L,24L,11L,30L,32L,35L,42L,51L,23L,60L,38L,20L,46L,49L,31L,52L,63L,76L,43L,36L,92L,57L,33L,68L,17L,74L,48L,78L,95L,114L,64L,54L,25L,135L,86L,50L,37L,102L,47L,28L,111L,72L,118L,140L,67L,165L,96L,82L,39L,195L,79L,128L,75L,56L,150L,70L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260425Inst : IEnumerable<long>
{
public static readonly long[] Value=A260425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260425.Bytes);
public long this[int i]=>Value[i];

public static A260425Inst Instance=new A260425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260426
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,5L,11L,6L,8L,12L,25L,9L,13L,17L,10L,14L,47L,18L,19L,34L,15L,20L,31L,24L,55L,16L,21L,62L,137L,26L,37L,27L,45L,22L,28L,42L,59L,33L,71L,23L,87L,29L,41L,79L,166L,35L,61L,49L,36L,58L,30L,38L,319L,54L,91L,76L,44L,89L,97L,32L,203L,108L,39L,53L,99L,200L,67L,46L,103L,78L,185L,64L,131L,48L,75L,40L,379L,50L,73L,373L,109L,70L,433L,113L,95L,57L,1123L,111L,143L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260426Inst : IEnumerable<long>
{
public static readonly long[] Value=A260426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260426.Bytes);
public long this[int i]=>Value[i];

public static A260426Inst Instance=new A260426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260427
{
public static readonly long[] Value={ 5L,17L,23L,29L,43L,53L,69L,71L,77L,79L,81L,83L,89L,101L,107L,113L,121L,127L,139L,149L,151L,163L,169L,173L,179L,181L,197L,199L,205L,209L,223L,227L,233L,251L,257L,261L,263L,265L,269L,271L,275L,277L,281L,289L,293L,295L,305L,307L,311L,317L,321L,323L,327L,329L,331L,337L,339L,347L,349L,353L,359L,367L,373L,377L,383L,389L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260427Inst : IEnumerable<long>
{
public static readonly long[] Value=A260427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260427.Bytes);
public long this[int i]=>Value[i];

public static A260427Inst Instance=new A260427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260428
{
public static readonly long[] Value={ 69L,77L,81L,121L,169L,205L,209L,261L,265L,275L,289L,295L,305L,321L,323L,327L,329L,339L,377L,405L,407L,437L,453L,473L,475L,481L,493L,517L,533L,551L,553L,559L,565L,575L,581L,583L,595L,625L,649L,667L,671L,689L,703L,707L,737L,747L,749L,755L,763L,767L,779L,781L,785L,805L,815L,833L,835L,851L,855L,861L,869L,893L,905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260428Inst : IEnumerable<long>
{
public static readonly long[] Value=A260428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260428.Bytes);
public long this[int i]=>Value[i];

public static A260428Inst Instance=new A260428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260429
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,5L,1L,6L,3L,7L,1L,8L,1L,9L,4L,10L,2L,11L,1L,12L,5L,13L,1L,14L,2L,15L,6L,16L,1L,17L,1L,18L,7L,19L,1L,20L,3L,21L,8L,22L,1L,23L,2L,24L,9L,25L,1L,26L,1L,27L,10L,28L,2L,29L,3L,30L,11L,31L,4L,32L,1L,33L,12L,34L,1L,35L,1L,36L,13L,37L,1L,38L,1L,39L,14L,40L,1L,41L,5L,42L,15L,43L,2L,44L,1L,45L,16L,46L,4L,47L,1L,48L,17L,49L,3L,50L,1L,51L,18L,52L,6L,53L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260429Inst : IEnumerable<long>
{
public static readonly long[] Value=A260429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260429.Bytes);
public long this[int i]=>Value[i];

public static A260429Inst Instance=new A260429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260430
{
public static readonly long[] Value={ 1L,4L,12L,2L,30L,7L,6L,74L,19L,21L,18L,3L,172L,52L,54L,49L,48L,11L,9L,383L,10L,128L,125L,32L,36L,132L,31L,119L,118L,5L,27L,24L,812L,314L,89L,25L,283L,92L,275L,76L,86L,85L,83L,290L,75L,267L,266L,17L,16L,68L,60L,14L,724L,15L,227L,1675L,219L,659L,207L,51L,64L,599L,216L,61L,232L,583L,174L,50L,204L,210L,201L,193L,208L,8L,45L,40L,1574L,612L,173L,569L,595L,159L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260430Inst : IEnumerable<long>
{
public static readonly long[] Value=A260430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260430.Bytes);
public long this[int i]=>Value[i];

public static A260430Inst Instance=new A260430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260431
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,5L,16L,9L,12L,10L,7L,32L,18L,24L,20L,17L,13L,14L,64L,11L,36L,33L,19L,25L,48L,21L,40L,34L,15L,26L,28L,128L,65L,37L,22L,72L,49L,66L,38L,41L,35L,50L,96L,42L,80L,68L,30L,27L,52L,56L,29L,129L,23L,73L,256L,67L,130L,74L,39L,44L,144L,98L,51L,97L,132L,76L,43L,82L,81L,70L,100L,69L,31L,53L,57L,257L,192L,84L,160L,131L,75L,45L,136L,60L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260431Inst : IEnumerable<long>
{
public static readonly long[] Value=A260431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260431.Bytes);
public long this[int i]=>Value[i];

public static A260431Inst Instance=new A260431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260432
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,6L,12L,5L,9L,11L,21L,10L,18L,19L,30L,8L,17L,14L,24L,16L,27L,36L,54L,15L,25L,31L,49L,32L,52L,48L,74L,13L,23L,29L,42L,22L,35L,40L,60L,28L,41L,45L,68L,61L,83L,92L,132L,26L,38L,43L,64L,50L,75L,86L,119L,51L,76L,89L,128L,85L,118L,125L,172L,20L,34L,39L,57L,47L,73L,71L,106L,37L,55L,59L,82L,67L,96L,101L,140L,46L,70L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260432Inst : IEnumerable<long>
{
public static readonly long[] Value=A260432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260432.Bytes);
public long this[int i]=>Value[i];

public static A260432Inst Instance=new A260432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260433
{
public static readonly long[] Value={ 1L,3L,7L,2L,15L,5L,6L,31L,14L,11L,13L,4L,63L,29L,23L,27L,30L,10L,9L,127L,12L,59L,62L,28L,22L,47L,26L,55L,61L,8L,21L,19L,255L,126L,58L,25L,119L,46L,125L,57L,54L,60L,45L,95L,53L,111L,123L,17L,20L,43L,39L,18L,254L,24L,118L,511L,124L,253L,117L,56L,51L,239L,93L,44L,94L,251L,115L,52L,109L,110L,121L,91L,122L,16L,42L,38L,510L,191L,107L,223L,252L,116L,50L,247L,35L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260433Inst : IEnumerable<long>
{
public static readonly long[] Value=A260433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260433.Bytes);
public long this[int i]=>Value[i];

public static A260433Inst Instance=new A260433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260434
{
public static readonly long[] Value={ 1L,4L,2L,12L,6L,7L,3L,30L,19L,18L,10L,21L,11L,9L,5L,74L,48L,52L,32L,49L,31L,25L,15L,54L,36L,27L,16L,24L,14L,17L,8L,172L,125L,118L,85L,128L,89L,76L,51L,119L,86L,75L,50L,64L,43L,38L,26L,132L,92L,83L,61L,68L,45L,41L,28L,60L,40L,35L,22L,42L,29L,23L,13L,383L,314L,275L,219L,266L,208L,201L,152L,283L,227L,207L,159L,174L,129L,127L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260434Inst : IEnumerable<long>
{
public static readonly long[] Value=A260434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260434.Bytes);
public long this[int i]=>Value[i];

public static A260434Inst Instance=new A260434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260435
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,6L,5L,8L,7L,10L,15L,12L,11L,14L,13L,16L,21L,18L,19L,20L,17L,22L,27L,24L,23L,26L,31L,28L,33L,30L,25L,32L,29L,34L,39L,36L,37L,38L,35L,40L,45L,42L,41L,44L,55L,46L,51L,48L,43L,50L,47L,52L,57L,54L,73L,56L,59L,58L,63L,60L,49L,62L,53L,64L,69L,66L,61L,68L,67L,70L,75L,72L,71L,74L,77L,76L,81L,78L,83L,80L,65L,82L,87L,84L,101L,86L,89L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260435Inst : IEnumerable<long>
{
public static readonly long[] Value=A260435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260435.Bytes);
public long this[int i]=>Value[i];

public static A260435Inst Instance=new A260435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260436
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,9L,8L,5L,10L,13L,12L,15L,14L,11L,16L,21L,18L,19L,20L,17L,22L,25L,24L,31L,26L,23L,28L,33L,30L,27L,32L,29L,34L,39L,36L,37L,38L,35L,40L,43L,42L,49L,44L,41L,46L,51L,48L,61L,50L,47L,52L,63L,54L,45L,56L,53L,58L,57L,60L,67L,62L,59L,64L,81L,66L,69L,68L,65L,70L,73L,72L,55L,74L,71L,76L,75L,78L,103L,80L,77L,82L,79L,84L,91L,86L,83L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260436Inst : IEnumerable<long>
{
public static readonly long[] Value=A260436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260436.Bytes);
public long this[int i]=>Value[i];

public static A260436Inst Instance=new A260436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260437
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,4L,0L,5L,2L,6L,0L,7L,0L,8L,3L,9L,1L,10L,0L,11L,4L,12L,0L,13L,1L,14L,5L,15L,0L,16L,0L,17L,6L,18L,0L,19L,2L,20L,7L,21L,0L,22L,1L,23L,8L,24L,0L,25L,0L,26L,9L,27L,1L,28L,2L,29L,10L,30L,3L,31L,0L,32L,11L,33L,0L,34L,0L,35L,12L,36L,0L,37L,0L,38L,13L,39L,0L,40L,4L,41L,14L,42L,1L,43L,0L,44L,15L,45L,3L,46L,0L,47L,16L,48L,2L,49L,0L,50L,17L,51L,5L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260437Inst : IEnumerable<long>
{
public static readonly long[] Value=A260437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260437.Bytes);
public long this[int i]=>Value[i];

public static A260437Inst Instance=new A260437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260438
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,1L,4L,1L,2L,1L,5L,1L,6L,1L,2L,1L,3L,1L,7L,1L,2L,1L,8L,1L,4L,1L,2L,1L,9L,1L,10L,1L,2L,1L,11L,1L,3L,1L,2L,1L,12L,1L,5L,1L,2L,1L,13L,1L,14L,1L,2L,1L,6L,1L,4L,1L,2L,1L,3L,1L,15L,1L,2L,1L,16L,1L,17L,1L,2L,1L,18L,1L,19L,1L,2L,1L,20L,1L,3L,1L,2L,1L,7L,1L,21L,1L,2L,1L,4L,1L,22L,1L,2L,1L,5L,1L,23L,1L,2L,1L,3L,1L,24L,1L,2L,1L,8L,1L,25L,1L,2L,1L,26L,1L,6L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260438Inst : IEnumerable<long>
{
public static readonly long[] Value=A260438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260438.Bytes);
public long this[int i]=>Value[i];

public static A260438Inst Instance=new A260438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260439
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,1L,4L,1L,5L,3L,6L,1L,7L,1L,8L,4L,9L,2L,10L,1L,11L,5L,12L,1L,13L,2L,14L,6L,15L,1L,16L,1L,17L,7L,18L,1L,19L,3L,20L,8L,21L,1L,22L,2L,23L,9L,24L,1L,25L,1L,26L,10L,27L,2L,28L,3L,29L,11L,30L,4L,31L,1L,32L,12L,33L,1L,34L,1L,35L,13L,36L,1L,37L,1L,38L,14L,39L,1L,40L,5L,41L,15L,42L,2L,43L,1L,44L,16L,45L,4L,46L,1L,47L,17L,48L,3L,49L,1L,50L,18L,51L,6L,52L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260439Inst : IEnumerable<long>
{
public static readonly long[] Value=A260439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260439.Bytes);
public long this[int i]=>Value[i];

public static A260439Inst Instance=new A260439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260440
{
public static readonly long[] Value={ 27L,57L,91L,121L,153L,183L,217L,247L,279L,309L,343L,373L,405L,435L,469L,499L,531L,561L,595L,625L,657L,687L,721L,751L,783L,813L,847L,877L,909L,939L,973L,1003L,1035L,1065L,1099L,1129L,1161L,1191L,1225L,1255L,1287L,1317L,1351L,1381L,1413L,1443L,1477L,1507L,1539L,1569L,1603L,1633L,1665L,1695L,1729L,1759L,1791L,1821L,1855L,1885L,1917L,1947L,1981L,2011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260440Inst : IEnumerable<long>
{
public static readonly long[] Value=A260440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260440.Bytes);
public long this[int i]=>Value[i];

public static A260440Inst Instance=new A260440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260441
{
public static readonly long[] Value={ 1361L,3721L,8073L,40257L,64125L,344925L,1121373L,4127085L,47053305L,89025909L,256718241L,864417085L,2339944761L,7793372565L,10483463769L,15540712857L,19217417625L,51731153357L,315005744053L,731886242745L,3047881618969L,19546038155241L,55232813508469L,389828042124021L,1225948485247905L,17008166929275225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260441Inst : IEnumerable<long>
{
public static readonly long[] Value=A260441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260441.Bytes);
public long this[int i]=>Value[i];

public static A260441Inst Instance=new A260441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260442
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,11L,13L,15L,17L,18L,19L,23L,29L,30L,31L,35L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,75L,77L,79L,83L,89L,90L,97L,101L,103L,105L,107L,109L,113L,127L,131L,137L,139L,143L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,210L,211L,221L,223L,227L,229L,233L,239L,241L,245L,251L,257L,263L,269L,270L,271L,277L,281L,283L,293L,307L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260442Inst : IEnumerable<long>
{
public static readonly long[] Value=A260442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260442.Bytes);
public long this[int i]=>Value[i];

public static A260442Inst Instance=new A260442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260443
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,18L,15L,30L,7L,90L,75L,270L,35L,450L,105L,210L,11L,630L,525L,6750L,245L,20250L,2625L,9450L,77L,15750L,3675L,47250L,385L,22050L,1155L,2310L,13L,6930L,5775L,330750L,2695L,3543750L,128625L,1653750L,847L,4961250L,643125L,53156250L,18865L,24806250L,202125L,727650L,143L,1212750L,282975L,57881250L,29645L,173643750L,1414875L,18191250L,1001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260443Inst : IEnumerable<long>
{
public static readonly long[] Value=A260443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260443.Bytes);
public long this[int i]=>Value[i];

public static A260443Inst Instance=new A260443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260444
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260444Inst : IEnumerable<long>
{
public static readonly long[] Value=A260444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260444.Bytes);
public long this[int i]=>Value[i];

public static A260444Inst Instance=new A260444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260445
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260445Inst : IEnumerable<long>
{
public static readonly long[] Value=A260445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260445.Bytes);
public long this[int i]=>Value[i];

public static A260445Inst Instance=new A260445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260446
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260446Inst : IEnumerable<long>
{
public static readonly long[] Value=A260446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260446.Bytes);
public long this[int i]=>Value[i];

public static A260446Inst Instance=new A260446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260447
{
public static readonly BigInteger[] Value={ 1L,-1L,-1L,157L,65911L,-918227L,-234932171L,592642957L,149463069056137L,-16648792617135289L,BigInteger.Parse("-286497627060094895989"),BigInteger.Parse("3538603031642540133299"),BigInteger.Parse("57674522110226646157873673"),BigInteger.Parse("-713986824035720029666660757"),BigInteger.Parse("-6478234620955890989297122598683") };
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
public class A260447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260447Inst Instance=new A260447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260448
{
public static readonly BigInteger[] Value={ 1L,12L,1440L,51840L,87091200L,1045094400L,376233984000L,902961561600L,166867296583680000L,18021668031037440000UL,BigInteger.Parse("140569010642092032000000"),BigInteger.Parse("1686828127705104384000000"),BigInteger.Parse("8501613763633726095360000000"),BigInteger.Parse("102019365163604713144320000000"),BigInteger.Parse("208119504933753614814412800000000") };
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
public class A260448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260448Inst Instance=new A260448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260449
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,2L,1L,2L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L,1L,2L,1L,2L,3L,1L,3L,2L,1L,1L,1L,2L,3L,1L,3L,2L,1L,2L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L,1L,2L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L,1L,2L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260449Inst : IEnumerable<long>
{
public static readonly long[] Value=A260449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260449.Bytes);
public long this[int i]=>Value[i];

public static A260449Inst Instance=new A260449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260450
{
public static readonly long[] Value={ 1L,3L,2L,1L,2L,3L,1L,3L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,3L,2L,1L,2L,3L,1L,1L,1L,3L,2L,1L,2L,3L,1L,3L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260450Inst : IEnumerable<long>
{
public static readonly long[] Value=A260450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260450.Bytes);
public long this[int i]=>Value[i];

public static A260450Inst Instance=new A260450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260451
{
public static readonly long[] Value={ 2L,3L,1L,2L,1L,3L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L,2L,3L,2L,3L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,3L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,2L,3L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260451Inst : IEnumerable<long>
{
public static readonly long[] Value=A260451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260451.Bytes);
public long this[int i]=>Value[i];

public static A260451Inst Instance=new A260451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260452
{
public static readonly long[] Value={ 2L,1L,3L,2L,3L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,2L,2L,1L,3L,2L,3L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260452Inst : IEnumerable<long>
{
public static readonly long[] Value=A260452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260452.Bytes);
public long this[int i]=>Value[i];

public static A260452Inst Instance=new A260452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260453
{
public static readonly long[] Value={ 3L,1L,2L,3L,2L,1L,3L,1L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L,3L,1L,3L,1L,2L,3L,2L,1L,3L,3L,3L,1L,2L,3L,2L,1L,3L,1L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L,3L,1L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L,3L,1L,3L,1L,2L,3L,2L,1L,3L,2L,3L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260453Inst : IEnumerable<long>
{
public static readonly long[] Value=A260453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260453.Bytes);
public long this[int i]=>Value[i];

public static A260453Inst Instance=new A260453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260454
{
public static readonly long[] Value={ 3L,2L,1L,3L,1L,2L,3L,2L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L,3L,2L,3L,2L,1L,3L,1L,2L,3L,3L,3L,2L,1L,3L,1L,2L,3L,2L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L,3L,2L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L,3L,2L,3L,2L,1L,3L,1L,2L,3L,1L,3L,2L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260454Inst : IEnumerable<long>
{
public static readonly long[] Value=A260454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260454.Bytes);
public long this[int i]=>Value[i];

public static A260454Inst Instance=new A260454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260455
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260455Inst : IEnumerable<long>
{
public static readonly long[] Value=A260455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260455.Bytes);
public long this[int i]=>Value[i];

public static A260455Inst Instance=new A260455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260456
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260456Inst : IEnumerable<long>
{
public static readonly long[] Value=A260456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260456.Bytes);
public long this[int i]=>Value[i];

public static A260456Inst Instance=new A260456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260457
{
public static readonly BigInteger[] Value={ 1L,13L,10309L,185025612421L,BigInteger.Parse("56226054983232874655910074821"),BigInteger.Parse("5090777843424139731612639602181310410515979763727978155884175693164901") };
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
public class A260457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260457Inst Instance=new A260457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260458
{
public static readonly long[] Value={ 1L,4L,3L,2L,5L,12L,7L,2L,3L,20L,11L,6L,13L,28L,15L,2L,17L,12L,19L,10L,21L,44L,23L,6L,5L,52L,3L,14L,29L,60L,31L,2L,33L,68L,35L,6L,37L,76L,39L,10L,41L,84L,43L,22L,15L,92L,47L,6L,7L,20L,51L,26L,53L,12L,55L,14L,57L,116L,59L,30L,61L,124L,21L,2L,65L,132L,67L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260458Inst : IEnumerable<long>
{
public static readonly long[] Value=A260458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260458.Bytes);
public long this[int i]=>Value[i];

public static A260458Inst Instance=new A260458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260459
{
public static readonly BigInteger[] Value={ 30103L,333010333L,33330103333L,9333301033339L,12933330103333921L,BigInteger.Parse("121293333010333392121"),BigInteger.Parse("3812129333301033339212183"),BigInteger.Parse("15381212933330103333921218351"),BigInteger.Parse("101538121293333010333392121835101"),BigInteger.Parse("3910153812129333301033339212183510193") };
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
public class A260459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260459Inst Instance=new A260459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260460
{
public static readonly long[] Value={ 1L,-1L,-2L,-3L,-3L,-3L,-5L,-7L,-6L,-6L,-10L,-12L,-11L,-13L,-17L,-20L,-21L,-21L,-27L,-34L,-33L,-36L,-46L,-51L,-53L,-58L,-68L,-78L,-82L,-89L,-104L,-118L,-123L,-131L,-154L,-171L,-179L,-197L,-221L,-245L,-262L,-279L,-314L,-349L,-369L,-398L,-446L,-486L,-515L,-557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260460Inst : IEnumerable<long>
{
public static readonly long[] Value=A260460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260460.Bytes);
public long this[int i]=>Value[i];

public static A260460Inst Instance=new A260460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260461
{
public static readonly long[] Value={ 105L,108L,150L,180L,405L,450L,501L,504L,510L,540L,801L,810L,1002L,1005L,1008L,1020L,1200L,2001L,2004L,2005L,2010L,2040L,2050L,2100L,2400L,2500L,3006L,3060L,3600L,4002L,4005L,4008L,4020L,4080L,4200L,4800L,5001L,5002L,5004L,5020L,5200L,6003L,6030L,6300L,8001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260461Inst : IEnumerable<long>
{
public static readonly long[] Value=A260461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260461.Bytes);
public long this[int i]=>Value[i];

public static A260461Inst Instance=new A260461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260462
{
public static readonly long[] Value={ 12L,15L,16L,18L,24L,25L,36L,45L,48L,125L,128L,144L,168L,225L,256L,288L,1125L,1344L,2688L,12288L,111888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260462Inst : IEnumerable<long>
{
public static readonly long[] Value=A260462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260462.Bytes);
public long this[int i]=>Value[i];

public static A260462Inst Instance=new A260462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260463
{
public static readonly long[] Value={ 1L,5L,6L,2L,23L,8L,27L,9L,3L,10L,34L,11L,37L,12L,39L,4L,42L,43L,14L,45L,46L,15L,48L,49L,16L,51L,52L,17L,54L,55L,56L,18L,58L,59L,188L,19L,61L,62L,63L,20L,203L,65L,66L,21L,213L,68L,69L,22L,7L,71L,72L,229L,73L,74L,235L,75L,24L,241L,77L,78L,247L,25L,251L,80L,81L,257L,26L,83L,263L,84L,267L,85L,86L,273L,87L,276L,88L,28L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260463Inst : IEnumerable<long>
{
public static readonly long[] Value=A260463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260463.Bytes);
public long this[int i]=>Value[i];

public static A260463Inst Instance=new A260463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260464
{
public static readonly BigInteger[] Value={ 1L,1L,3L,7L,27L,91L,483L,2227L,15627L,92491L,810963L,5866147L,61720827L,527635291L,6476783043L,63886537267L,896245131627L,10019232896491L,158126425788723L,1975680877259587L,34645295464104027L,478434297205284091L,9228741116739540003UL,BigInteger.Parse("139581878985127217107") };
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
public class A260464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260464Inst Instance=new A260464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260465
{
public static readonly long[] Value={ 1L,3L,7L,16L,8L,4L,9L,2L,21L,10L,48L,5L,11L,52L,25L,55L,12L,57L,27L,59L,6L,61L,62L,29L,63L,64L,14L,66L,31L,67L,68L,32L,15L,70L,33L,154L,72L,73L,34L,74L,161L,35L,76L,164L,77L,36L,78L,169L,17L,37L,80L,174L,81L,38L,82L,178L,83L,18L,39L,182L,85L,184L,86L,40L,87L,188L,189L,19L,191L,89L,193L,90L,194L,42L,91L,197L,92L,199L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260465Inst : IEnumerable<long>
{
public static readonly long[] Value=A260465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260465.Bytes);
public long this[int i]=>Value[i];

public static A260465Inst Instance=new A260465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260466
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,7L,10L,12L,14L,16L,20L,22L,24L,26L,28L,32L,34L,36L,38L,40L,43L,47L,49L,51L,53L,55L,57L,59L,63L,65L,67L,69L,71L,73L,75L,79L,83L,85L,87L,89L,91L,93L,95L,97L,99L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,125L,129L,131L,133L,135L,137L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260466Inst : IEnumerable<long>
{
public static readonly long[] Value=A260466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260466.Bytes);
public long this[int i]=>Value[i];

public static A260466Inst Instance=new A260466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260467
{
public static readonly BigInteger[] Value={ 34L,92L,658L,5034L,57524L,1095328L,24138984L,741446708L,35549850396L,2210679193297L,185698612792568L,22953437585181163L,3891199671596923784L,BigInteger.Parse("894945430246534184300"),BigInteger.Parse("292131961025408714854594") };
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
public class A260467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260467Inst Instance=new A260467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260468
{
public static readonly long[] Value={ 34L,49L,103L,205L,414L,840L,1716L,3477L,7049L,14293L,29064L,58992L,119714L,243113L,493739L,1002385L,2035086L,4131940L,8389884L,17034549L,34585457L,70222293L,142579896L,289489424L,587771042L,1193399465L,2423058571L,4919726081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260468Inst : IEnumerable<long>
{
public static readonly long[] Value=A260468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260468.Bytes);
public long this[int i]=>Value[i];

public static A260468Inst Instance=new A260468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260469
{
public static readonly long[] Value={ 49L,92L,213L,471L,1085L,2562L,5891L,13530L,31372L,72451L,166919L,385563L,890572L,2054927L,4743628L,10953016L,25283529L,58363941L,134740753L,311052242L,718052661L,1657646568L,3826724610L,8834001277L,20393409965L,47078589297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260469Inst : IEnumerable<long>
{
public static readonly long[] Value=A260469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260469.Bytes);
public long this[int i]=>Value[i];

public static A260469Inst Instance=new A260469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260470
{
public static readonly long[] Value={ 103L,213L,658L,1723L,4607L,13198L,36254L,98246L,272542L,752720L,2061534L,5677324L,15656100L,43045526L,118431170L,326172286L,897659278L,2470110390L,6799627354L,18715886532L,51508911086L,141773805068L,390225182152L,1074023884216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260470Inst : IEnumerable<long>
{
public static readonly long[] Value=A260470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260470.Bytes);
public long this[int i]=>Value[i];

public static A260470Inst Instance=new A260470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260471
{
public static readonly long[] Value={ 205L,471L,1723L,5034L,15502L,51552L,161176L,500384L,1604536L,5086798L,15970826L,50628404L,160518794L,506646020L,1602247622L,5073114544L,16039699386L,50717541826L,160468331560L,507552451076L,1605133576768L,5077305382754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260471Inst : IEnumerable<long>
{
public static readonly long[] Value=A260471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260471.Bytes);
public long this[int i]=>Value[i];

public static A260471Inst Instance=new A260471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260472
{
public static readonly long[] Value={ 414L,1085L,4607L,15502L,57524L,228287L,839073L,3095233L,11809031L,44303443L,164909771L,620730229L,2333261427L,8731252217L,32758466355L,123014796659L,461213884299L,1729719499043L,6490923837905L,24348087968989L,91323390042221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260472Inst : IEnumerable<long>
{
public static readonly long[] Value=A260472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260472.Bytes);
public long this[int i]=>Value[i];

public static A260472Inst Instance=new A260472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260473
{
public static readonly long[] Value={ 840L,2562L,13198L,51552L,228287L,1095328L,4771920L,20881559L,95279821L,425856847L,1884583524L,8455381667L,37878158698L,168740477794L,754075134087L,3373768933461L,15065098940991L,67292893064782L,300807873404901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260473Inst : IEnumerable<long>
{
public static readonly long[] Value=A260473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260473.Bytes);
public long this[int i]=>Value[i];

public static A260473Inst Instance=new A260473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260474
{
public static readonly long[] Value={ 1716L,5891L,36254L,161176L,839073L,4771920L,24138984L,123310754L,662480793L,3462881003L,17901457898L,94193468029L,494253218713L,2575427089930L,13479058203992L,70635679978670L,369192210644796L,1930772613998630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260474Inst : IEnumerable<long>
{
public static readonly long[] Value=A260474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260474.Bytes);
public long this[int i]=>Value[i];

public static A260474Inst Instance=new A260474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260475
{
public static readonly long[] Value={ 34L,49L,49L,103L,92L,103L,205L,213L,213L,205L,414L,471L,658L,471L,414L,840L,1085L,1723L,1723L,1085L,840L,1716L,2562L,4607L,5034L,4607L,2562L,1716L,3477L,5891L,13198L,15502L,15502L,13198L,5891L,3477L,7049L,13530L,36254L,51552L,57524L,51552L,36254L,13530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260475Inst : IEnumerable<long>
{
public static readonly long[] Value=A260475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260475.Bytes);
public long this[int i]=>Value[i];

public static A260475Inst Instance=new A260475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260476
{
public static readonly long[] Value={ 3L,5L,17L,257L,65537L,285121L,1425601L,2380801L,100638721L,8778792961L,184354652161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260476Inst : IEnumerable<long>
{
public static readonly long[] Value=A260476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260476.Bytes);
public long this[int i]=>Value[i];

public static A260476Inst Instance=new A260476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260477
{
public static readonly long[] Value={ 9L,17L,33L,49L,50L,65L,73L,77L,85L,86L,97L,106L,129L,137L,149L,157L,161L,165L,178L,186L,193L,201L,212L,213L,225L,226L,257L,265L,273L,279L,281L,285L,300L,305L,307L,310L,317L,321L,325L,332L,334L,345L,355L,365L,366L,378L,385L,393L,394L,413L,426L,427L,449L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260477Inst : IEnumerable<long>
{
public static readonly long[] Value=A260477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260477.Bytes);
public long this[int i]=>Value[i];

public static A260477Inst Instance=new A260477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260478
{
public static readonly BigInteger[] Value={ 2L,2L,17L,1297L,331777L,207360001L,268738560001L,645241282560001L,2642908293365760001L,BigInteger.Parse("17340121312772751360001"),BigInteger.Parse("173401213127727513600000001"),BigInteger.Parse("2538767161403058526617600000001"),BigInteger.Parse("52643875858853821607942553600000001"),BigInteger.Parse("1503561738404723998944447273369600000001") };
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
public class A260478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260478Inst Instance=new A260478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260479
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,13L,14L,16L,17L,19L,21L,23L,24L,26L,28L,30L,31L,33L,35L,37L,38L,40L,41L,43L,44L,46L,48L,50L,51L,53L,54L,56L,57L,59L,61L,63L,64L,66L,67L,69L,70L,72L,74L,76L,77L,79L,81L,83L,84L,86L,88L,90L,91L,93L,94L,96L,97L,99L,101L,103L,104L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260479Inst : IEnumerable<long>
{
public static readonly long[] Value=A260479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260479.Bytes);
public long this[int i]=>Value[i];

public static A260479Inst Instance=new A260479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260480
{
public static readonly long[] Value={ 2L,5L,7L,9L,12L,15L,18L,20L,22L,25L,27L,29L,32L,34L,36L,39L,42L,45L,47L,49L,52L,55L,58L,60L,62L,65L,68L,71L,73L,75L,78L,80L,82L,85L,87L,89L,92L,95L,98L,100L,102L,105L,107L,109L,112L,114L,116L,119L,122L,125L,127L,129L,132L,134L,136L,139L,141L,143L,146L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260480Inst : IEnumerable<long>
{
public static readonly long[] Value=A260480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260480.Bytes);
public long this[int i]=>Value[i];

public static A260480Inst Instance=new A260480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260481
{
public static readonly BigInteger[] Value={ 1L,5L,725L,494613125L,BigInteger.Parse("237200374061503726953125"),BigInteger.Parse("57083011552674242150083383668890855252740781729278564453125") };
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
public class A260481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260481Inst Instance=new A260481Inst();

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