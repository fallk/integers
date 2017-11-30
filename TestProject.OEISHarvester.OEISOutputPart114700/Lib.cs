using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A280685
{
public static readonly long[] Value={ 1L,3L,4L,15L,6L,91L,8L,127L,40L,217L,12L,5080L,14L,399L,403L,2047L,18L,16395L,20L,19812L,741L,931L,24L,991111L,156L,1281L,1093L,50800L,30L,2929531L,32L,65535L,1729L,2149L,1767L,30203052L,38L,2667L,2379L,6397171L,42L,10506551L,44L,185928L,170508L,3871L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280685Inst : IEnumerable<long>
{
public static readonly long[] Value=A280685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280685.Bytes);
public long this[int i]=>Value[i];

public static A280685Inst Instance=new A280685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280686
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,1L,2L,3L,5L,1L,3L,1L,2L,5L,8L,1L,3L,1L,5L,3L,2L,1L,8L,5L,13L,3L,2L,1L,5L,1L,8L,3L,2L,5L,3L,1L,2L,13L,8L,1L,21L,1L,2L,5L,2L,1L,8L,1L,5L,3L,13L,1L,3L,5L,8L,3L,2L,1L,5L,1L,2L,21L,8L,13L,3L,1L,34L,3L,5L,1L,8L,1L,2L,5L,2L,1L,13L,1L,8L,3L,2L,1L,21L,5L,2L,3L,8L,1L,5L,13L,2L,3L,2L,5L,8L,1L,2L,3L,5L,1L,34L,1L,13L,21L,2L,1L,3L,1L,55L,3L,8L,1L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280686Inst : IEnumerable<long>
{
public static readonly long[] Value=A280686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280686.Bytes);
public long this[int i]=>Value[i];

public static A280686Inst Instance=new A280686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280687
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,4L,3L,2L,11L,4L,13L,7L,3L,2L,17L,6L,19L,4L,7L,11L,23L,3L,5L,2L,9L,14L,29L,6L,31L,4L,11L,17L,7L,12L,37L,19L,3L,5L,41L,2L,43L,22L,9L,23L,47L,6L,49L,10L,17L,4L,53L,18L,11L,7L,19L,29L,59L,12L,61L,31L,3L,8L,5L,22L,67L,2L,23L,14L,71L,9L,73L,37L,15L,38L,77L,6L,79L,10L,27L,41L,83L,4L,17L,43L,29L,11L,89L,18L,7L,46L,31L,47L,19L,12L,97L,49L,33L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280687Inst : IEnumerable<long>
{
public static readonly long[] Value=A280687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280687.Bytes);
public long this[int i]=>Value[i];

public static A280687Inst Instance=new A280687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280688
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,5L,1L,1L,1L,8L,1L,1L,2L,13L,1L,5L,1L,21L,1L,1L,1L,34L,1L,1L,1L,55L,1L,13L,1L,89L,5L,1L,1L,144L,1L,5L,1L,233L,1L,34L,1L,377L,1L,1L,1L,610L,1L,1L,13L,987L,1L,89L,1L,1597L,1L,13L,1L,2584L,1L,1L,5L,4181L,1L,233L,1L,6765L,34L,1L,1L,10946L,1L,1L,1L,17711L,1L,610L,1L,28657L,1L,1L,1L,46368L,1L,13L,89L,75025L,1L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280688Inst : IEnumerable<long>
{
public static readonly long[] Value=A280688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280688.Bytes);
public long this[int i]=>Value[i];

public static A280688Inst Instance=new A280688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280689
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,5L,1L,4L,1L,13L,5L,7L,1L,17L,1L,11L,13L,89L,1L,18L,5L,233L,17L,29L,1L,122L,1L,47L,89L,1597L,13L,76L,1L,4181L,233L,123L,1L,842L,1L,199L,122L,28657L,1L,322L,13L,15005L,1597L,521L,1L,5777L,89L,843L,4181L,514229L,1L,1364L,1L,1346269L,842L,2207L,233L,39602L,1L,3571L,28657L,709805L,1L,5778L,1L,24157817L,15005L,9349L,89L,271442L,1L,15127L,5777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280689Inst : IEnumerable<long>
{
public static readonly long[] Value=A280689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280689.Bytes);
public long this[int i]=>Value[i];

public static A280689Inst Instance=new A280689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280690
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,4L,13L,7L,17L,11L,89L,18L,233L,29L,122L,47L,1597L,76L,4181L,123L,842L,199L,28657L,322L,15005L,521L,5777L,843L,514229L,1364L,1346269L,2207L,39602L,3571L,709805L,5778L,24157817L,9349L,271442L,15127L,165580141L,24476L,433494437L,39603L,1860497L,64079L,2971215073L,103682L,598364773L,167761L,12752042L,271443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280690Inst : IEnumerable<long>
{
public static readonly long[] Value=A280690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280690.Bytes);
public long this[int i]=>Value[i];

public static A280690Inst Instance=new A280690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280691
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,7L,1L,10L,7L,61L,1L,26L,1L,547L,61L,82L,1L,703L,1L,242L,547L,44287L,1L,730L,61L,398581L,703L,2186L,1L,58807L,1L,6562L,44287L,32285041L,547L,19682L,1L,290565367L,398581L,59050L,1L,4780783L,1L,177146L,58807L,23535794707L,1L,531442L,547L,3472494301L,32285041L,1594322L,1L,387400807L,44287L,4782970L,290565367L,17157594341221L,1L,14348906L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280691Inst : IEnumerable<long>
{
public static readonly long[] Value=A280691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280691.Bytes);
public long this[int i]=>Value[i];

public static A280691Inst Instance=new A280691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280692
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,6L,0L,-6L,0L,12L,0L,-6L,0L,36L,0L,24L,0L,6L,0L,-24L,0L,66L,0L,-24L,60L,18L,0L,18L,0L,150L,-20L,-42L,0L,120L,0L,-42L,-10L,72L,0L,42L,0L,-12L,60L,-48L,0L,264L,0L,0L,-30L,0L,0L,216L,0L,132L,-30L,-78L,0L,138L,0L,-72L,120L,540L,0L,0L,0L,-30L,-30L,24L,0L,462L,0L,-96L,60L,-18L,0L,24L,0L,330L,420L,-114L,0L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280692Inst : IEnumerable<long>
{
public static readonly long[] Value=A280692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280692.Bytes);
public long this[int i]=>Value[i];

public static A280692Inst Instance=new A280692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280741
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,5L,11L,6L,10L,8L,14L,9L,23L,12L,17L,13L,24L,16L,28L,18L,20L,15L,31L,19L,35L,22L,34L,21L,39L,26L,49L,30L,43L,25L,36L,33L,55L,29L,44L,41L,63L,37L,66L,46L,27L,32L,70L,38L,48L,51L,59L,45L,87L,54L,42L,57L,74L,40L,91L,61L,95L,50L,58L,65L,52L,68L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280741Inst : IEnumerable<long>
{
public static readonly long[] Value=A280741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280741.Bytes);
public long this[int i]=>Value[i];

public static A280741Inst Instance=new A280741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280742
{
public static readonly long[] Value={ 2L,4L,7L,11L,14L,23L,24L,28L,31L,39L,49L,55L,63L,66L,70L,87L,91L,95L,104L,121L,128L,132L,136L,140L,145L,149L,162L,166L,186L,198L,212L,256L,259L,262L,263L,276L,287L,291L,301L,312L,320L,331L,335L,351L,355L,359L,368L,376L,380L,400L,415L,421L,428L,444L,448L,454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280742Inst : IEnumerable<long>
{
public static readonly long[] Value=A280742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280742.Bytes);
public long this[int i]=>Value[i];

public static A280742Inst Instance=new A280742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280743
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,14L,16L,22L,24L,28L,34L,45L,46L,48L,58L,77L,78L,82L,86L,99L,105L,121L,135L,136L,165L,195L,325L,455L,459L,465L,605L,637L,651L,715L,777L,897L,987L,1001L,1495L,1573L,2275L,2387L,2415L,2421L,2451L,2493L,2919L,3129L,3171L,3633L,3689L,4011L,4053L,4137L,4179L,4879L,4893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280743Inst : IEnumerable<long>
{
public static readonly long[] Value=A280743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280743.Bytes);
public long this[int i]=>Value[i];

public static A280743Inst Instance=new A280743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280744
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,12L,13L,15L,19L,21L,25L,27L,32L,38L,40L,47L,53L,64L,67L,69L,73L,86L,90L,99L,107L,114L,131L,189L,290L,304L,311L,354L,366L,387L,435L,520L,553L,563L,598L,817L,885L,1333L,1361L,1615L,1634L,1651L,1655L,1765L,1776L,2031L,2068L,2248L,2261L,2314L,2700L,2704L,2712L,2993L,3128L,3670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280744Inst : IEnumerable<long>
{
public static readonly long[] Value=A280744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280744.Bytes);
public long this[int i]=>Value[i];

public static A280744Inst Instance=new A280744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280745
{
public static readonly long[] Value={ 13L,139L,379L,397L,647L,661L,967L,983L,997L,1021L,1063L,1109L,1129L,1187L,1201L,1223L,1231L,1249L,1289L,1297L,1307L,1453L,1481L,1487L,1499L,1543L,1553L,1597L,1607L,1613L,1621L,1637L,1667L,1697L,1723L,1759L,1789L,1831L,1867L,1873L,1879L,1907L,1933L,2011L,2029L,2069L,2083L,2089L,2141L,2309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280745Inst : IEnumerable<long>
{
public static readonly long[] Value=A280745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280745.Bytes);
public long this[int i]=>Value[i];

public static A280745Inst Instance=new A280745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280746
{
public static readonly long[] Value={ 1L,2L,3L,6L,13L,30L,65L,127L,258L,530L,1009L,1988L,3942L,8004L,16195L,32389L,64923L,129870L,260326L,520787L,1043257L,2085202L,4171403L,8338443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280746Inst : IEnumerable<long>
{
public static readonly long[] Value=A280746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280746.Bytes);
public long this[int i]=>Value[i];

public static A280746Inst Instance=new A280746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280747
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,3L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,1L,1L,4L,3L,3L,2L,2L,2L,4L,2L,4L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,2L,2L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,4L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,4L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280747Inst : IEnumerable<long>
{
public static readonly long[] Value=A280747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280747.Bytes);
public long this[int i]=>Value[i];

public static A280747Inst Instance=new A280747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280748
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,0L,2L,0L,1L,0L,1L,1L,1L,0L,1L,1L,3L,0L,2L,2L,2L,0L,1L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,0L,1L,1L,1L,0L,3L,0L,2L,0L,2L,2L,2L,0L,2L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,2L,0L,2L,1L,2L,0L,1L,1L,1L,0L,2L,0L,1L,0L,1L,1L,1L,0L,1L,1L,4L,0L,3L,3L,3L,0L,2L,0L,2L,0L,2L,2L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280748Inst : IEnumerable<long>
{
public static readonly long[] Value=A280748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280748.Bytes);
public long this[int i]=>Value[i];

public static A280748Inst Instance=new A280748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280749
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,3L,0L,0L,0L,2L,0L,2L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,2L,0L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280749Inst : IEnumerable<long>
{
public static readonly long[] Value=A280749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280749.Bytes);
public long this[int i]=>Value[i];

public static A280749Inst Instance=new A280749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280750
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,1L,1L,1L,0L,2L,0L,1L,0L,1L,1L,1L,0L,1L,0L,3L,0L,2L,2L,2L,0L,1L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,0L,1L,1L,1L,0L,3L,0L,2L,0L,2L,2L,2L,0L,2L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,2L,0L,2L,1L,2L,0L,1L,1L,1L,0L,2L,0L,1L,0L,1L,1L,1L,0L,1L,0L,4L,0L,3L,3L,3L,0L,2L,0L,2L,0L,2L,2L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280750Inst : IEnumerable<long>
{
public static readonly long[] Value=A280750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280750.Bytes);
public long this[int i]=>Value[i];

public static A280750Inst Instance=new A280750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280751
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,2L,0L,2L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,2L,0L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280751Inst : IEnumerable<long>
{
public static readonly long[] Value=A280751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280751.Bytes);
public long this[int i]=>Value[i];

public static A280751Inst Instance=new A280751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280752
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,10L,1L,1L,2L,865L,71L,1L,1L,5L,2630L,1427L,181L,1L,1L,3L,163133L,306553L,36667L,145L,1L,1L,7L,3368938L,129115655L,46958822L,43662L,4036L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280752Inst : IEnumerable<long>
{
public static readonly long[] Value=A280752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280752.Bytes);
public long this[int i]=>Value[i];

public static A280752Inst Instance=new A280752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280753
{
public static readonly long[] Value={ 1L,3L,3L,7L,2L,7L,15L,5L,21L,15L,31L,3L,651L,186L,31L,63L,7L,651L,651L,651L,63L,127L,4L,11811L,15748L,11811L,762L,127L,255L,9L,66929L,602361L,602361L,10795L,32385L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280753Inst : IEnumerable<long>
{
public static readonly long[] Value=A280753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280753.Bytes);
public long this[int i]=>Value[i];

public static A280753Inst Instance=new A280753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280754
{
public static readonly long[] Value={ 1L,2L,54L,100L,130L,190L,392L,486L,608L,623L,799L,1448L,1614L,6169L,7807L,8149L,24403L,28945L,37665L,40395L,43559L,46117L,46259L,119663L,121149L,153317L,214459L,262759L,306637L,318605L,318815L,365029L,387471L,394597L,403431L,439125L,450051L,483511L,506807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280754Inst : IEnumerable<long>
{
public static readonly long[] Value=A280754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280754.Bytes);
public long this[int i]=>Value[i];

public static A280754Inst Instance=new A280754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280755
{
public static readonly long[] Value={ 65L,91L,95L,115L,119L,217L,231L,259L,299L,329L,371L,455L,511L,529L,539L,553L,623L,679L,707L,721L,749L,805L,973L,1043L,1057L,1211L,1337L,1351L,1379L,1631L,1799L,1883L,2839L,3017L,3077L,6601L,8449L,8897L,11237L,11509L,11921L,18683L,19193L,19411L,22043L,26719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280755Inst : IEnumerable<long>
{
public static readonly long[] Value=A280755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280755.Bytes);
public long this[int i]=>Value[i];

public static A280755Inst Instance=new A280755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280756
{
public static readonly long[] Value={ 1L,3L,7L,19L,46L,119L,296L,753L,1891L,4784L,12052L,30435L,76752L,193708L,488664L,1233061L,3110965L,7849501L,19804697L,49969640L,126077463L,318106522L,802611677L,2025068125L,5109437370L,12891603348L,32526741151L,82068086418L,207065613652L,522446355976L,1318182069433L,3325899406919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280756Inst : IEnumerable<long>
{
public static readonly long[] Value=A280756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280756.Bytes);
public long this[int i]=>Value[i];

public static A280756Inst Instance=new A280756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280805
{
public static readonly long[] Value={ 0L,3L,56L,332L,1578L,6540L,24490L,86010L,288426L,933792L,2940425L,9053479L,27364145L,81436340L,239191322L,694661663L,1997809427L,5696648777L,16121608346L,45319683250L,126637762818L,351964959409L,973463999825L,2680515593254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280805Inst : IEnumerable<long>
{
public static readonly long[] Value=A280805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280805.Bytes);
public long this[int i]=>Value[i];

public static A280805Inst Instance=new A280805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280806
{
public static readonly long[] Value={ 0L,18L,332L,2146L,9715L,37644L,133067L,440282L,1387898L,4213683L,12419791L,35750871L,100948088L,280549719L,769389206L,2086323089L,5602827011L,14920267585L,39440232733L,103577644060L,270436207834L,702418367935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280806Inst : IEnumerable<long>
{
public static readonly long[] Value=A280806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280806.Bytes);
public long this[int i]=>Value[i];

public static A280806Inst Instance=new A280806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280807
{
public static readonly long[] Value={ 0L,72L,1578L,9715L,41931L,155560L,521862L,1635481L,4878157L,14014639L,39104351L,106631105L,285454905L,752759713L,1960409283L,5051884455L,12901249792L,32688874902L,82257457021L,205730877021L,511748655573L,1266736498098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280807Inst : IEnumerable<long>
{
public static readonly long[] Value=A280807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280807.Bytes);
public long this[int i]=>Value[i];

public static A280807Inst Instance=new A280807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280808
{
public static readonly long[] Value={ 0L,284L,6540L,37644L,155560L,547197L,1736603L,5150299L,14554327L,39708623L,105469880L,274358836L,702041419L,1772651619L,4426877398L,10952897674L,26883495456L,65525790275L,158732212994L,382416259916L,916790487361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280808Inst : IEnumerable<long>
{
public static readonly long[] Value=A280808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280808.Bytes);
public long this[int i]=>Value[i];

public static A280808Inst Instance=new A280808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280809
{
public static readonly long[] Value={ 0L,1047L,24490L,133067L,521862L,1736603L,5219491L,14672850L,39446188L,102668319L,261032587L,651872767L,1605291205L,3909190755L,9432062891L,22579858190L,53688882185L,126896063565L,298328702932L,698005209403L,1626059718118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280809Inst : IEnumerable<long>
{
public static readonly long[] Value=A280809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280809.Bytes);
public long this[int i]=>Value[i];

public static A280809Inst Instance=new A280809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280810
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,3L,3L,0L,0L,18L,56L,18L,0L,0L,72L,332L,332L,72L,0L,0L,284L,1578L,2146L,1578L,284L,0L,0L,1047L,6540L,9715L,9715L,6540L,1047L,0L,0L,3722L,24490L,37644L,41931L,37644L,24490L,3722L,0L,0L,12816L,86010L,133067L,155560L,155560L,133067L,86010L,12816L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280810Inst : IEnumerable<long>
{
public static readonly long[] Value=A280810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280810.Bytes);
public long this[int i]=>Value[i];

public static A280810Inst Instance=new A280810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280811
{
public static readonly long[] Value={ 0L,7L,5L,6L,6L,0L,0L,0L,0L,0L,6L,6L,6L,6L,6L,6L,0L,0L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280811Inst : IEnumerable<long>
{
public static readonly long[] Value=A280811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280811.Bytes);
public long this[int i]=>Value[i];

public static A280811Inst Instance=new A280811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280812
{
public static readonly BigInteger[] Value={ 22L,47171L,431302721L,741269838109L,26856502742629699L,BigInteger.Parse("211938730834003723543"),BigInteger.Parse("506119433541064524255449"),BigInteger.Parse("19809071774292917047896724979"),BigInteger.Parse("23285066731814401580687501596643"),BigInteger.Parse("89293478252053341114758995682016773") };
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
public class A280812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280812Inst Instance=new A280812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280813
{
public static readonly BigInteger[] Value={ 7L,15015L,137287920L,235953517800L,8548690331301120L,BigInteger.Parse("67462193289708771840"),BigInteger.Parse("161102819285860855603200"),BigInteger.Parse("6305423381881718760060595200"),BigInteger.Parse("7411866941185812791748757094400"),BigInteger.Parse("28422996899365886608045972478361600"),BigInteger.Parse("24827411794278189209115835981312819200") };
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
public class A280813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280813Inst Instance=new A280813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280814
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,26L,27L,27L,28L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,35L,36L,36L,37L,37L,38L,38L,39L,40L,40L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280814Inst : IEnumerable<long>
{
public static readonly long[] Value=A280814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280814.Bytes);
public long this[int i]=>Value[i];

public static A280814Inst Instance=new A280814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280815
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,3L,0L,0L,1L,2L,2L,0L,0L,3L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,2L,0L,0L,3L,0L,0L,4L,0L,0L,4L,0L,0L,2L,0L,1L,4L,0L,3L,1L,4L,0L,0L,0L,3L,2L,4L,1L,3L,0L,0L,2L,6L,0L,0L,4L,4L,0L,0L,0L,2L,2L,0L,1L,0L,3L,0L,0L,0L,3L,0L,0L,3L,0L,0L,1L,3L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280815Inst : IEnumerable<long>
{
public static readonly long[] Value=A280815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280815.Bytes);
public long this[int i]=>Value[i];

public static A280815Inst Instance=new A280815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280816
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280816Inst : IEnumerable<long>
{
public static readonly long[] Value=A280816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280816.Bytes);
public long this[int i]=>Value[i];

public static A280816Inst Instance=new A280816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280817
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,1L,0L,2L,5L,2L,3L,3L,2L,2L,0L,5L,1L,4L,9L,1L,5L,2L,4L,0L,9L,4L,3L,4L,5L,1L,0L,2L,7L,2L,5L,6L,4L,3L,11L,9L,2L,5L,9L,7L,5L,2L,5L,3L,6L,5L,8L,7L,4L,5L,4L,4L,11L,4L,9L,5L,2L,6L,0L,9L,5L,6L,6L,2L,5L,5L,2L,11L,9L,5L,7L,2L,9L,4L,13L,4L,6L,9L,3L,7L,7L,4L,11L,11L,15L,3L,9L,1L,5L,4L,6L,8L,9L,7L,7L,8L,7L,6L,13L,2L,11L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280817Inst : IEnumerable<long>
{
public static readonly long[] Value=A280817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280817.Bytes);
public long this[int i]=>Value[i];

public static A280817Inst Instance=new A280817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280818
{
public static readonly long[] Value={ 1L,5L,3L,13L,17L,7L,5L,29L,11L,37L,41L,15L,7L,53L,19L,61L,13L,23L,73L,11L,27L,17L,89L,31L,97L,101L,35L,109L,113L,39L,11L,25L,43L,19L,137L,47L,29L,149L,51L,157L,23L,55L,13L,173L,59L,181L,37L,63L,193L,197L,67L,41L,19L,71L,31L,17L,75L,229L,233L,79L,241L,49L,83L,23L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280818Inst : IEnumerable<long>
{
public static readonly long[] Value=A280818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280818.Bytes);
public long this[int i]=>Value[i];

public static A280818Inst Instance=new A280818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280819
{
public static readonly long[] Value={ 3L,1L,0L,5L,8L,2L,8L,5L,4L,1L,2L,3L,0L,2L,4L,9L,1L,4L,8L,1L,8L,6L,7L,8L,6L,0L,5L,1L,4L,8L,8L,5L,7L,9L,9L,4L,0L,1L,8L,8L,8L,2L,6L,8L,1L,5L,8L,3L,9L,1L,6L,6L,1L,6L,5L,7L,6L,8L,0L,3L,8L,4L,8L,7L,7L,8L,0L,6L,8L,3L,6L,9L,6L,9L,8L,5L,6L,2L,3L,9L,6L,3L,0L,6L,8L,4L,1L,5L,6L,9L,6L,3L,3L,0L,9L,9L,5L,9L,8L,6L,2L,5L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280819Inst : IEnumerable<long>
{
public static readonly long[] Value=A280819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280819.Bytes);
public long this[int i]=>Value[i];

public static A280819Inst Instance=new A280819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280820
{
public static readonly BigInteger[] Value={ 1L,2L,4L,7L,31L,36L,756L,861L,3101L,3290L,3632090L,3632475L,482634075L,482653380L,483550276L,485577301L,20923275465301L,20923275550386L,6423296981278386L,6423296990008107L,6423344287544107L,6423345537481432L,BigInteger.Parse("1124007151123145161432"),BigInteger.Parse("1124007151123182343577") };
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
public class A280820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280820Inst Instance=new A280820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280869
{
public static readonly long[] Value={ 1L,-1008L,220752L,16519104L,399517776L,4624512480L,34423752384L,187506813312L,814794618960L,2975666040144L,9486668147040L,27052407031104L,70486610910912L,169931677686624L,384163181281152L,820165393918080L,1668889095288912L,3249638073414432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280869Inst : IEnumerable<long>
{
public static readonly long[] Value=A280869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280869.Bytes);
public long this[int i]=>Value[i];

public static A280869Inst Instance=new A280869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280870
{
public static readonly long[] Value={ 7L,5L,4L,5L,7L,4L,5L,8L,9L,11L,9L,10L,11L,48L,53L,19L,21L,33L,14L,25L,13L,14L,18L,19L,25L,52L,53L,55L,59L,61L,44L,135L,143L,145L,153L,157L,27L,168L,173L,177L,185L,187L,97L,49L,204L,211L,219L,113L,115L,78L,237L,245L,249L,257L,263L,89L,91L,69L,40L,287L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280870Inst : IEnumerable<long>
{
public static readonly long[] Value=A280870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280870.Bytes);
public long this[int i]=>Value[i];

public static A280870Inst Instance=new A280870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280871
{
public static readonly long[] Value={ 10L,8L,5L,7L,8L,5L,6L,9L,11L,12L,10L,11L,12L,53L,57L,21L,22L,35L,15L,26L,14L,15L,19L,20L,26L,53L,55L,59L,61L,66L,45L,143L,145L,153L,157L,162L,28L,173L,177L,185L,187L,194L,98L,51L,211L,219L,226L,115L,117L,79L,245L,249L,257L,263L,267L,91L,92L,70L,41L,295L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280871Inst : IEnumerable<long>
{
public static readonly long[] Value=A280871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280871.Bytes);
public long this[int i]=>Value[i];

public static A280871Inst Instance=new A280871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280872
{
public static readonly long[] Value={ 8287L,8311L,8317L,8423L,8429L,8527L,8539L,8563L,8599L,8627L,8629L,8647L,8677L,8681L,8689L,8783L,8807L,8819L,8821L,8861L,8933L,8999L,9011L,9013L,9043L,9049L,9059L,9109L,9137L,9157L,9161L,9277L,9319L,9323L,9337L,9371L,9397L,9419L,9421L,9433L,9511L,9547L,9613L,9619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280872Inst : IEnumerable<long>
{
public static readonly long[] Value=A280872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280872.Bytes);
public long this[int i]=>Value[i];

public static A280872Inst Instance=new A280872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280873
{
public static readonly long[] Value={ 1L,3L,6L,7L,13L,14L,15L,26L,27L,29L,30L,31L,53L,54L,55L,58L,59L,61L,62L,63L,106L,107L,109L,110L,111L,117L,118L,119L,122L,123L,125L,126L,127L,213L,214L,215L,218L,219L,221L,222L,223L,234L,235L,237L,238L,239L,245L,246L,247L,250L,251L,253L,254L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280873Inst : IEnumerable<long>
{
public static readonly long[] Value=A280873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280873.Bytes);
public long this[int i]=>Value[i];

public static A280873Inst Instance=new A280873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280874
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,24L,39L,62L,96L,146L,218L,320L,463L,662L,936L,1310L,1816L,2496L,3404L,4608L,6196L,8278L,10994L,14520L,19076L,24938L,32448L,42032L,54218L,69656L,89149L,113680L,144456L,182952L,230966L,290688L,364774L,456446L,569600L,708938L,880128L,1089984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280874Inst : IEnumerable<long>
{
public static readonly long[] Value=A280874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280874.Bytes);
public long this[int i]=>Value[i];

public static A280874Inst Instance=new A280874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280875
{
public static readonly long[] Value={ 87L,90L,91L,93L,94L,95L,106L,107L,109L,110L,111L,117L,118L,119L,122L,123L,125L,126L,127L,170L,171L,173L,174L,175L,181L,182L,183L,186L,187L,189L,190L,191L,213L,214L,215L,218L,219L,221L,222L,223L,234L,235L,237L,238L,239L,245L,246L,247L,250L,251L,253L,254L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280875Inst : IEnumerable<long>
{
public static readonly long[] Value=A280875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280875.Bytes);
public long this[int i]=>Value[i];

public static A280875Inst Instance=new A280875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280876
{
public static readonly long[] Value={ 3L,5L,11L,191L,353L,797L,919L,11311L,12421L,13331L,16061L,18181L,31513L,32323L,34543L,34843L,36563L,37273L,70207L,72727L,77377L,78787L,1117111L,1120211L,1253521L,1257521L,1280821L,1328231L,1409041L,1456541L,1633361L,1824281L,1851581L,1903091L,1982891L,1984891L,1998991L,3002003L,3073703L,3211123L,3212123L,3252523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280876Inst : IEnumerable<long>
{
public static readonly long[] Value=A280876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280876.Bytes);
public long this[int i]=>Value[i];

public static A280876Inst Instance=new A280876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280877
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,28L,30L,32L,33L,34L,36L,38L,40L,42L,44L,45L,46L,48L,50L,52L,54L,56L,58L,60L,62L,63L,64L,66L,68L,70L,72L,74L,75L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280877Inst : IEnumerable<long>
{
public static readonly long[] Value=A280877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280877.Bytes);
public long this[int i]=>Value[i];

public static A280877Inst Instance=new A280877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280878
{
public static readonly long[] Value={ 21L,33L,63L,99L,147L,189L,231L,273L,297L,357L,363L,399L,429L,441L,483L,561L,567L,609L,627L,651L,663L,693L,741L,759L,777L,819L,861L,891L,897L,903L,957L,969L,987L,1023L,1029L,1071L,1089L,1113L,1131L,1173L,1197L,1209L,1221L,1239L,1281L,1287L,1311L,1323L,1353L,1407L,1419L,1443L,1449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280878Inst : IEnumerable<long>
{
public static readonly long[] Value=A280878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280878.Bytes);
public long this[int i]=>Value[i];

public static A280878Inst Instance=new A280878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280879
{
public static readonly long[] Value={ 5005L,6545L,7315L,7735L,8645L,8855L,10465L,11165L,11935L,14245L,25025L,32725L,35035L,36575L,38675L,43225L,44275L,45815L,51205L,52325L,54145L,55055L,55825L,59675L,60515L,61985L,65065L,71225L,71995L,73255L,78155L,80465L,83545L,85085L,95095L,97405L,99715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280879Inst : IEnumerable<long>
{
public static readonly long[] Value=A280879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280879.Bytes);
public long this[int i]=>Value[i];

public static A280879Inst Instance=new A280879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280880
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,1L,0L,1L,4L,6L,1L,0L,1L,15L,10L,10L,1L,0L,1L,6L,75L,20L,15L,1L,0L,1L,63L,21L,245L,35L,21L,1L,0L,1L,64L,476L,56L,630L,56L,28L,1L,0L,1L,171L,540L,2100L,126L,1386L,84L,36L,1L,0L,1L,130L,4185L,2640L,6930L,252L,2730L,120L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280880Inst : IEnumerable<long>
{
public static readonly long[] Value=A280880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280880.Bytes);
public long this[int i]=>Value[i];

public static A280880Inst Instance=new A280880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280881
{
public static readonly long[] Value={ 1L,6L,10L,75L,21L,476L,540L,4185L,1375L,47850L,10374L,249431L,395955L,2572680L,278392L,30877389L,5000211L,214159070L,291693150L,1465649955L,1224138223L,23284864476L,13175039700L,157019230225L,198060711381L,1510657970346L,1118209769530L,18176060999625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280881Inst : IEnumerable<long>
{
public static readonly long[] Value=A280881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280881.Bytes);
public long this[int i]=>Value[i];

public static A280881Inst Instance=new A280881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280882
{
public static readonly long[] Value={ 1L,10L,20L,245L,56L,2100L,2640L,36795L,8140L,542542L,72436L,3311945L,6050240L,91668080L,2505120L,1972220235L,92327460L,5331136090L,6360277000L,320219686633L,29187262016L,4567704520100L,3125812500200L,39433339579725L,19033980625296L,2173716576665550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280882Inst : IEnumerable<long>
{
public static readonly long[] Value=A280882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280882.Bytes);
public long this[int i]=>Value[i];

public static A280882Inst Instance=new A280882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280883
{
public static readonly long[] Value={ 1L,15L,35L,630L,126L,6930L,9570L,202455L,35035L,3612609L,361725L,25350780L,50620220L,1262865060L,15864468L,33652405845L,942571665L,68217941715L,72924794635L,7281932609490L,364040548850L,111203641740750L,79780936522950L,2097251547484275L,471615091340211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280883Inst : IEnumerable<long>
{
public static readonly long[] Value=A280883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280883.Bytes);
public long this[int i]=>Value[i];

public static A280883Inst Instance=new A280883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280884
{
public static readonly long[] Value={ 1L,21L,56L,1386L,252L,18942L,28512L,837837L,122122L,17600583L,1445808L,140411908L,301302288L,10781435088L,79318464L,333208994139L,6813685494L,597189699029L,582524800704L,89346032143830L,3151550453480L,1467268659100530L,1095411461933880L,45383787697612455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280884Inst : IEnumerable<long>
{
public static readonly long[] Value=A280884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280884.Bytes);
public long this[int i]=>Value[i];

public static A280884Inst Instance=new A280884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280901
{
public static readonly BigInteger[] Value={ 34L,184076L,162640161L,91647699996L,42393379206019L,17508860441441769L,6718652421698535725L,BigInteger.Parse("2448407789410628918742"),BigInteger.Parse("858754574814302324217872"),BigInteger.Parse("292445632786957126081923641"),BigInteger.Parse("97284552066245842895422600165") };
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
public class A280901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280901Inst Instance=new A280901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280902
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,10L,9L,0L,2L,213L,646L,124L,0L,9L,2292L,22568L,22632L,1464L,0L,34L,21762L,492490L,1451655L,610448L,15768L,0L,124L,184076L,9426050L,65348136L,75809243L,14262832L,159920L,0L,432L,1457827L,162640161L,2571528867L,7083739466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280902Inst : IEnumerable<long>
{
public static readonly long[] Value=A280902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280902.Bytes);
public long this[int i]=>Value[i];

public static A280902Inst Instance=new A280902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280903
{
public static readonly long[] Value={ 0L,1L,10L,213L,2292L,21762L,184076L,1457827L,11000888L,80107879L,567420546L,3931417538L,26752272278L,179329108005L,1186930999936L,7770945222145L,50399529101088L,324186782002754L,2070149445768880L,13133990417566391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280903Inst : IEnumerable<long>
{
public static readonly long[] Value=A280903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280903.Bytes);
public long this[int i]=>Value[i];

public static A280903Inst Instance=new A280903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280904
{
public static readonly long[] Value={ 0L,9L,646L,22568L,492490L,9426050L,162640161L,2636238543L,40818734359L,610807332682L,8899797476985L,126936297853576L,1779063560531884L,24572630681534366L,335222285940398228L,4524762545977409290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280904Inst : IEnumerable<long>
{
public static readonly long[] Value=A280904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280904.Bytes);
public long this[int i]=>Value[i];

public static A280904Inst Instance=new A280904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280905
{
public static readonly BigInteger[] Value={ 0L,124L,22632L,1451655L,65348136L,2571528867L,91647699996L,3072729111454L,98499096530389L,3053023277146528L,92172928166402753L,2724604438231223343L,BigInteger.Parse("79153860087200853877"),BigInteger.Parse("2266446081673358266508"),BigInteger.Parse("64102854500808145878543") };
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
public class A280905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280905Inst Instance=new A280905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280906
{
public static readonly BigInteger[] Value={ 0L,1464L,610448L,75809243L,7083739466L,574982226478L,42393379206019L,2942502897692141L,195365303234441770L,12545498025247203218UL,BigInteger.Parse("784842927161230385854"),BigInteger.Parse("48079317345677228680390"),BigInteger.Parse("2894948350054066836940824") };
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
public class A280906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280906Inst Instance=new A280906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280907
{
public static readonly long[] Value={ 4L,10L,42L,294L,3462L,45042L,760446L,14549526L,289194150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280907Inst : IEnumerable<long>
{
public static readonly long[] Value=A280907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280907.Bytes);
public long this[int i]=>Value[i];

public static A280907Inst Instance=new A280907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280908
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,16L,25L,38L,56L,82L,118L,166L,233L,322L,440L,598L,804L,1072L,1422L,1872L,2449L,3188L,4126L,5312L,6810L,8690L,11040L,13974L,17618L,22130L,27707L,34572L,43000L,53328L,65942L,81312L,100004L,122674L,150110L,183254L,223200L,271248L,328945L,398086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280908Inst : IEnumerable<long>
{
public static readonly long[] Value=A280908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280908.Bytes);
public long this[int i]=>Value[i];

public static A280908Inst Instance=new A280908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280909
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,7L,9L,12L,15L,19L,24L,30L,37L,47L,58L,72L,87L,107L,130L,158L,190L,229L,275L,330L,393L,469L,557L,661L,780L,921L,1084L,1275L,1494L,1750L,2044L,2386L,2777L,3231L,3750L,4348L,5030L,5815L,6711L,7738L,8905L,10240L,11757L,13488L,15449L,17680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280909Inst : IEnumerable<long>
{
public static readonly long[] Value=A280909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280909.Bytes);
public long this[int i]=>Value[i];

public static A280909Inst Instance=new A280909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280910
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280910Inst : IEnumerable<long>
{
public static readonly long[] Value=A280910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280910.Bytes);
public long this[int i]=>Value[i];

public static A280910Inst Instance=new A280910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280911
{
public static readonly long[] Value={ 30L,102L,1002L,1012L,1210L,2001L,2120L,3010L,10002L,10030L,20001L,20112L,20120L,100012L,100030L,101020L,102010L,110020L,110120L,120001L,121120L,200001L,200120L,211100L,221120L,230010L,300010L,320320L,400010L,400140L,1000002L,1000012L,1000140L,1000230L,1001020L,1003002L,1004010L,1010120L,1011300L,1013310L,1021100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280911Inst : IEnumerable<long>
{
public static readonly long[] Value=A280911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280911.Bytes);
public long this[int i]=>Value[i];

public static A280911Inst Instance=new A280911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280912
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,2L,0L,0L,2L,1L,1L,2L,0L,0L,3L,1L,0L,3L,1L,1L,3L,1L,0L,4L,2L,2L,5L,1L,1L,5L,3L,1L,6L,3L,2L,8L,2L,1L,7L,5L,4L,9L,4L,3L,11L,6L,3L,11L,6L,6L,14L,7L,5L,15L,9L,7L,16L,9L,8L,20L,14L,9L,21L,13L,11L,26L,16L,12L,28L,19L,17L,29L,19L,17L,37L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280912Inst : IEnumerable<long>
{
public static readonly long[] Value=A280912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280912.Bytes);
public long this[int i]=>Value[i];

public static A280912Inst Instance=new A280912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280913
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,5L,4L,3L,2L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,5L,6L,7L,8L,9L,10L,9L,8L,7L,6L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,1L,2L,3L,4L,5L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,5L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280913Inst : IEnumerable<long>
{
public static readonly long[] Value=A280913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280913.Bytes);
public long this[int i]=>Value[i];

public static A280913Inst Instance=new A280913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280914
{
public static readonly long[] Value={ 1L,21L,52L,172L,268L,428L,588L,812L,1004L,1324L,1580L,1900L,2252L,2668L,2988L,3532L,3916L,4460L,5004L,5548L,6028L,6764L,7308L,8044L,8716L,9548L,10156L,11116L,11852L,12620L,13548L,14444L,15244L,16524L,17228L,18380L,19340L,20588L,21548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280914Inst : IEnumerable<long>
{
public static readonly long[] Value=A280914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280914.Bytes);
public long this[int i]=>Value[i];

public static A280914Inst Instance=new A280914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280915
{
public static readonly long[] Value={ 11L,23L,37L,43L,59L,67L,73L,89L,101L,113L,127L,131L,149L,157L,167L,179L,197L,211L,239L,241L,257L,263L,269L,271L,293L,307L,311L,337L,347L,359L,373L,419L,421L,431L,449L,461L,491L,509L,523L,541L,571L,593L,607L,617L,641L,719L,733L,743L,751L,761L,809L,853L,941L,953L,971L,1013L,1021L,1031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280915Inst : IEnumerable<long>
{
public static readonly long[] Value=A280915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280915.Bytes);
public long this[int i]=>Value[i];

public static A280915Inst Instance=new A280915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280916
{
public static readonly long[] Value={ 5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,9L,8L,7L,6L,5L,4L,5L,6L,7L,8L,8L,7L,6L,5L,4L,3L,4L,5L,6L,7L,7L,6L,5L,4L,3L,2L,3L,4L,5L,6L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,7L,6L,5L,4L,3L,2L,3L,4L,5L,6L,8L,7L,6L,5L,4L,3L,4L,5L,6L,7L,9L,8L,7L,6L,5L,4L,5L,6L,7L,8L,14L,13L,12L,11L,10L,9L,10L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280916Inst : IEnumerable<long>
{
public static readonly long[] Value=A280916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280916.Bytes);
public long this[int i]=>Value[i];

public static A280916Inst Instance=new A280916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280949
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,7L,10L,13L,16L,21L,27L,34L,42L,53L,67L,82L,100L,123L,151L,183L,220L,266L,321L,384L,457L,545L,649L,768L,906L,1069L,1260L,1478L,1729L,2023L,2363L,2751L,3196L,3711L,4304L,4978L,5747L,6631L,7641L,8787L,10089L,11575L,13266L,15177L,17340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280949Inst : IEnumerable<long>
{
public static readonly long[] Value=A280949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280949.Bytes);
public long this[int i]=>Value[i];

public static A280949Inst Instance=new A280949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280950
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,11L,11L,12L,13L,15L,15L,16L,17L,19L,20L,22L,24L,26L,27L,29L,31L,33L,34L,37L,40L,43L,45L,48L,51L,54L,56L,60L,63L,67L,70L,76L,80L,84L,87L,93L,97L,102L,106L,113L,118L,125L,130L,138L,143L,151L,157L,166L,172L,181L,189L,200L,207L,217L,225L,237L,245L,257L,267L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280950Inst : IEnumerable<long>
{
public static readonly long[] Value=A280950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280950.Bytes);
public long this[int i]=>Value[i];

public static A280950Inst Instance=new A280950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280951
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,10L,11L,11L,12L,12L,14L,15L,15L,16L,16L,18L,19L,19L,21L,22L,24L,26L,26L,28L,29L,31L,33L,33L,35L,36L,39L,42L,43L,45L,47L,50L,53L,54L,56L,58L,61L,65L,66L,69L,72L,76L,81L,83L,86L,89L,93L,98L,100L,103L,107L,112L,118L,121L,125L,130L,136L,142L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280951Inst : IEnumerable<long>
{
public static readonly long[] Value=A280951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280951.Bytes);
public long this[int i]=>Value[i];

public static A280951Inst Instance=new A280951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280952
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,9L,10L,11L,11L,12L,12L,13L,14L,15L,15L,16L,16L,17L,18L,19L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,37L,38L,40L,42L,44L,45L,47L,49L,51L,53L,55L,56L,58L,60L,62L,64L,67L,68L,71L,74L,77L,79L,83L,85L,88L,91L,94L,96L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280952Inst : IEnumerable<long>
{
public static readonly long[] Value=A280952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280952.Bytes);
public long this[int i]=>Value[i];

public static A280952Inst Instance=new A280952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280953
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,5L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,22L,23L,24L,25L,25L,27L,27L,29L,30L,31L,32L,32L,34L,34L,36L,37L,38L,39L,40L,43L,44L,46L,47L,48L,50L,51L,54L,55L,57L,58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280953Inst : IEnumerable<long>
{
public static readonly long[] Value=A280953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280953.Bytes);
public long this[int i]=>Value[i];

public static A280953Inst Instance=new A280953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280954
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,7L,11L,11L,17L,17L,26L,26L,37L,37L,53L,53L,74L,74L,101L,101L,137L,137L,183L,183L,240L,240L,314L,314L,406L,406L,520L,520L,662L,662L,837L,837L,1049L,1049L,1311L,1311L,1627L,1627L,2008L,2008L,2469L,2469L,3021L,3021L,3678L,3678L,4466L,4466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280954Inst : IEnumerable<long>
{
public static readonly long[] Value=A280954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280954.Bytes);
public long this[int i]=>Value[i];

public static A280954Inst Instance=new A280954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280955
{
public static readonly long[] Value={ 2L,9L,42L,205L,997L,4850L,23593L,114769L,558298L,2715861L,13211405L,64267362L,312630929L,1520804569L,7398009354L,35987886621L,175064388469L,851607109714L,4142673879353L,20152188344737L,98031056006074L,476875651282597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280955Inst : IEnumerable<long>
{
public static readonly long[] Value=A280955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280955.Bytes);
public long this[int i]=>Value[i];

public static A280955Inst Instance=new A280955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280956
{
public static readonly long[] Value={ 4L,42L,241L,1554L,9899L,63085L,402077L,2562733L,16334111L,104108376L,663554669L,4229292041L,26956196587L,171810442122L,1095066516245L,6979614612419L,44485900541127L,283539343806484L,1807191908208865L,11518481171610485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280956Inst : IEnumerable<long>
{
public static readonly long[] Value=A280956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280956.Bytes);
public long this[int i]=>Value[i];

public static A280956Inst Instance=new A280956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280957
{
public static readonly long[] Value={ 11L,205L,1554L,14106L,126267L,1121528L,9986376L,88940022L,791997382L,7052519878L,62801413162L,559236961207L,4979918315253L,44345374930680L,394888443546716L,3516418473800700L,31313145020210260L,278838553941378885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280957Inst : IEnumerable<long>
{
public static readonly long[] Value=A280957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280957.Bytes);
public long this[int i]=>Value[i];

public static A280957Inst Instance=new A280957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280958
{
public static readonly long[] Value={ 30L,997L,9899L,126267L,1599234L,20029500L,251270618L,3152475854L,39530438497L,495721552160L,6216700479112L,77962372076794L,977711970478121L,12261314459515967L,153766955348557489L,1928363669762835672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280958Inst : IEnumerable<long>
{
public static readonly long[] Value=A280958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280958.Bytes);
public long this[int i]=>Value[i];

public static A280958Inst Instance=new A280958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280959
{
public static readonly BigInteger[] Value={ 82L,4850L,63085L,1121528L,20029500L,346289502L,6052621154L,105777297118L,1846875100200L,32253949107668L,563278827019060L,9836989060923111L,171791531487108414L,3000138481060751984L,BigInteger.Parse("52393917402743354484") };
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
public class A280959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280959Inst Instance=new A280959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280960
{
public static readonly BigInteger[] Value={ 224L,23593L,402077L,9986376L,251270618L,6052621154L,148137367471L,3624578433814L,88500510514256L,2162800206884214L,52848406746190667L,1291317121466531838L,BigInteger.Parse("31553229218022226192"),BigInteger.Parse("770996700142671487457") };
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
public class A280960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280960Inst Instance=new A280960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280961
{
public static readonly long[] Value={ 1L,2L,2L,4L,9L,4L,11L,42L,42L,11L,30L,205L,241L,205L,30L,82L,997L,1554L,1554L,997L,82L,224L,4850L,9899L,14106L,9899L,4850L,224L,612L,23593L,63085L,126267L,126267L,63085L,23593L,612L,1672L,114769L,402077L,1121528L,1599234L,1121528L,402077L,114769L,1672L,4568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280961Inst : IEnumerable<long>
{
public static readonly long[] Value=A280961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280961.Bytes);
public long this[int i]=>Value[i];

public static A280961Inst Instance=new A280961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280962
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,17L,26L,37L,53L,74L,101L,137L,183L,240L,314L,406L,520L,662L,837L,1049L,1311L,1627L,2008L,2469L,3021L,3678L,4466L,5397L,6499L,7804L,9338L,11137L,13251L,15715L,18589L,21938L,25823L,30322L,35535L,41544L,48471L,56448L,65602L,76097L,88128L,101867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280962Inst : IEnumerable<long>
{
public static readonly long[] Value=A280962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280962.Bytes);
public long this[int i]=>Value[i];

public static A280962Inst Instance=new A280962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280963
{
public static readonly long[] Value={ 1L,3L,9L,15L,27L,75L,81L,99L,243L,255L,315L,375L,729L,783L,1089L,1875L,2187L,4335L,6561L,6723L,9375L,9999L,11979L,19683L,22707L,46875L,59049L,65535L,73695L,99855L,131769L,177147L,234375L,531441L,558009L,658503L,1009899L,1171875L,1188099L,1252815L,1449459L,1594323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280963Inst : IEnumerable<long>
{
public static readonly long[] Value=A280963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280963.Bytes);
public long this[int i]=>Value[i];

public static A280963Inst Instance=new A280963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280964
{
public static readonly long[] Value={ 6L,15L,725L,91L,15851L,30589L,6977093777L,703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280964Inst : IEnumerable<long>
{
public static readonly long[] Value=A280964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280964.Bytes);
public long this[int i]=>Value[i];

public static A280964Inst Instance=new A280964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281014
{
public static readonly long[] Value={ 8L,12L,14L,16L,17L,19L,23L,24L,25L,27L,28L,29L,30L,33L,35L,39L,47L,49L,51L,55L,57L,59L,61L,64L,69L,73L,75L,77L,81L,83L,87L,89L,91L,93L,96L,101L,105L,107L,109L,112L,117L,120L,124L,126L,129L,131L,133L,135L,137L,139L,141L,143L,145L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281014Inst : IEnumerable<long>
{
public static readonly long[] Value=A281014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281014.Bytes);
public long this[int i]=>Value[i];

public static A281014Inst Instance=new A281014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281015
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,11L,12L,14L,16L,18L,19L,20L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,41L,43L,47L,49L,50L,52L,58L,61L,63L,67L,69L,70L,72L,74L,76L,78L,80L,81L,83L,85L,87L,89L,91L,92L,94L,96L,98L,99L,101L,102L,104L,106L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281015Inst : IEnumerable<long>
{
public static readonly long[] Value=A281015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281015.Bytes);
public long this[int i]=>Value[i];

public static A281015Inst Instance=new A281015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281016
{
public static readonly long[] Value={ 8L,16L,32L,64L,125L,128L,256L,512L,1024L,2048L,3125L,4096L,4913L,8192L,16384L,32768L,50653L,65536L,78125L,131072L,262144L,524288L,1030301L,1048576L,1419857L,1953125L,2097152L,4194304L,7645373L,8388608L,16777216L,16974593L,33554432L,35831808L,48828125L,64481201L,67108864L,69343957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281016Inst : IEnumerable<long>
{
public static readonly long[] Value=A281016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281016.Bytes);
public long this[int i]=>Value[i];

public static A281016Inst Instance=new A281016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281017
{
public static readonly long[] Value={ 0L,2L,3L,7L,8L,12L,14L,16L,18L,21L,23L,25L,27L,29L,30L,32L,34L,35L,36L,38L,41L,43L,44L,46L,47L,49L,50L,52L,53L,57L,58L,61L,63L,64L,66L,67L,69L,70L,72L,74L,75L,76L,78L,81L,83L,85L,87L,89L,92L,94L,96L,98L,101L,103L,107L,109L,110L,112L,118L,121L,125L,129L,130L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281017Inst : IEnumerable<long>
{
public static readonly long[] Value=A281017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281017.Bytes);
public long this[int i]=>Value[i];

public static A281017Inst Instance=new A281017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281018
{
public static readonly long[] Value={ 2L,3L,7L,8L,12L,14L,16L,18L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,41L,43L,47L,49L,50L,52L,58L,61L,63L,67L,69L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,92L,94L,96L,98L,101L,109L,110L,190L,200L,355L,445L,454L,456L,465L,535L,544L,546L,553L,557L,564L,566L,575L,645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281018Inst : IEnumerable<long>
{
public static readonly long[] Value=A281018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281018.Bytes);
public long this[int i]=>Value[i];

public static A281018Inst Instance=new A281018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281019
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,8L,8L,32L,96L,576L,576L,4608L,4608L,36864L,258048L,2064384L,2064384L,24772608L,24772608L,297271296L,2675441664L,32105299968L,32105299968L,513684799488L,2568423997440L,35957935964160L,323621423677440L,5177942778839040L,5177942778839040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281019Inst : IEnumerable<long>
{
public static readonly long[] Value=A281019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281019.Bytes);
public long this[int i]=>Value[i];

public static A281019Inst Instance=new A281019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281020
{
public static readonly long[] Value={ 0L,1L,4L,6L,8L,12L,13L,15L,19L,21L,31L,47L,51L,67L,70L,74L,76L,78L,87L,91L,100L,104L,106L,108L,111L,127L,137L,140L,144L,146L,148L,157L,160L,164L,166L,168L,172L,173L,175L,177L,179L,180L,184L,186L,188L,197L,202L,203L,205L,207L,209L,217L,220L,224L,226L,228L,230L,234L,236L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281020Inst : IEnumerable<long>
{
public static readonly long[] Value=A281020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281020.Bytes);
public long this[int i]=>Value[i];

public static A281020Inst Instance=new A281020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281021
{
public static readonly long[] Value={ 2L,3L,5L,7L,137L,191L,379L,421L,683L,757L,919L,1001933L,1005553L,1006091L,1012463L,1012513L,1013431L,1013813L,1013921L,1013923L,1016027L,1016401L,1016681L,1019657L,1022729L,1022837L,1025537L,1028011L,1028569L,1030069L,1030889L,1030933L,1034069L,1038119L,1040057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281021Inst : IEnumerable<long>
{
public static readonly long[] Value=A281021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281021.Bytes);
public long this[int i]=>Value[i];

public static A281021Inst Instance=new A281021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281022
{
public static readonly long[] Value={ 23L,47L,83L,167L,263L,359L,383L,467L,479L,503L,563L,587L,719L,839L,863L,887L,983L,1187L,1283L,1307L,1367L,1439L,1523L,1823L,1907L,2039L,2063L,2099L,2207L,2447L,2459L,2579L,2819L,2879L,2903L,2963L,3023L,3203L,3623L,3779L,3803L,3863L,3947L,4007L,4079L,4139L,4283L,4679L,4703L,4919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281022Inst : IEnumerable<long>
{
public static readonly long[] Value=A281022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281022.Bytes);
public long this[int i]=>Value[i];

public static A281022Inst Instance=new A281022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281023
{
public static readonly long[] Value={ 0L,2L,5L,11L,16L,31L,38L,58L,76L,111L,122L,176L,189L,252L,312L,384L,401L,518L,537L,667L,772L,915L,938L,1142L,1217L,1412L,1547L,1785L,1814L,2159L,2190L,2462L,2693L,3016L,3226L,3676L,3713L,4112L,4424L,4924L,4965L,5616L,5659L,6209L,6704L,7279L,7326L,8118L,8314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281023Inst : IEnumerable<long>
{
public static readonly long[] Value=A281023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281023.Bytes);
public long this[int i]=>Value[i];

public static A281023Inst Instance=new A281023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281024
{
public static readonly BigInteger[] Value={ 1L,2L,6L,36L,180L,2700L,18900L,378000L,6804000L,238140000L,2619540000L,141455160000L,1838917080000L,115851776040000L,6951106562400000L,500479672492800000L,8508154432377600000L,BigInteger.Parse("995454068588179200000"),BigInteger.Parse("18913627303175404800000"),BigInteger.Parse("2458771549412802624000000") };
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
public class A281024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281024Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281024.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A281024.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281024Inst Instance=new A281024Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281025
{
public static readonly long[] Value={ 1L,2L,5L,13L,18L,162L,169L,553L,715L,19915L,19926L,1264086L,1264099L,5779939L,7237939L,17559859L,17559876L,75264356676L,75264356695L,353956196695L,355036399735L,1254282070135L,1254282070158L,16687983940438158L,16687983940813158L,17351136747929958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281025Inst : IEnumerable<long>
{
public static readonly long[] Value=A281025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281025.Bytes);
public long this[int i]=>Value[i];

public static A281025Inst Instance=new A281025Inst();

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