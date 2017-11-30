using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A085160
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,17L,10L,16L,18L,11L,20L,12L,14L,21L,13L,15L,19L,22L,23L,45L,24L,44L,46L,25L,48L,26L,42L,49L,27L,43L,47L,50L,28L,54L,29L,53L,55L,30L,57L,31L,37L,58L,32L,38L,56L,59L,33L,61L,34L,39L,62L,35L,40L,51L,63L,36L,41L,52L,60L,64L,65L,129L,66L,128L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085160Inst : IEnumerable<long>
{
public static readonly long[] Value=A085160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085160.Bytes);
public long this[int i]=>Value[i];

public static A085160Inst Instance=new A085160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085159
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,11L,14L,16L,19L,17L,20L,12L,10L,13L,21L,15L,18L,22L,23L,25L,28L,30L,33L,37L,39L,42L,44L,47L,51L,53L,56L,60L,45L,48L,54L,57L,61L,31L,34L,26L,24L,27L,35L,29L,32L,36L,58L,62L,40L,38L,41L,49L,43L,46L,50L,63L,52L,55L,59L,64L,65L,67L,70L,72L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085159Inst : IEnumerable<long>
{
public static readonly long[] Value=A085159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085159.Bytes);
public long this[int i]=>Value[i];

public static A085159Inst Instance=new A085159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085158
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,7L,16L,27L,40L,55L,72L,91L,224L,405L,640L,935L,1296L,1729L,4480L,8505L,14080L,21505L,31104L,43225L,116480L,229635L,394240L,623645L,933120L,1339975L,3727360L,7577955L,13404160L,21827575L,33592320L,49579075L,141639680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085158Inst : IEnumerable<long>
{
public static readonly long[] Value=A085158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085158.Bytes);
public long this[int i]=>Value[i];

public static A085158Inst Instance=new A085158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085157
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,14L,24L,36L,50L,66L,168L,312L,504L,750L,1056L,2856L,5616L,9576L,15000L,22176L,62832L,129168L,229824L,375000L,576576L,1696464L,3616704L,6664896L,11250000L,17873856L,54286848L,119351232L,226606464L,393750000L,643458816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085157Inst : IEnumerable<long>
{
public static readonly long[] Value=A085157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085157.Bytes);
public long this[int i]=>Value[i];

public static A085157Inst Instance=new A085157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085156
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,43L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,62L,64L,65L,67L,69L,71L,73L,74L,77L,79L,81L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085156Inst : IEnumerable<long>
{
public static readonly long[] Value=A085156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085156.Bytes);
public long this[int i]=>Value[i];

public static A085156Inst Instance=new A085156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085155
{
public static readonly long[] Value={ 1L,4L,6L,9L,10L,14L,15L,16L,21L,22L,25L,26L,33L,34L,35L,36L,38L,39L,46L,49L,51L,55L,57L,58L,62L,64L,65L,69L,74L,77L,81L,82L,85L,86L,87L,91L,93L,94L,95L,100L,106L,111L,115L,118L,119L,121L,122L,123L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085155Inst : IEnumerable<long>
{
public static readonly long[] Value=A085155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085155.Bytes);
public long this[int i]=>Value[i];

public static A085155Inst Instance=new A085155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085154
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,24L,30L,32L,33L,36L,42L,48L,60L,64L,65L,66L,72L,78L,80L,84L,96L,102L,104L,105L,108L,110L,112L,114L,120L,128L,129L,130L,132L,144L,150L,160L,165L,168L,192L,195L,196L,198L,200L,204L,208L,210L,216L,220L,224L,228L,240L,256L,258L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085154Inst : IEnumerable<long>
{
public static readonly long[] Value=A085154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085154.Bytes);
public long this[int i]=>Value[i];

public static A085154Inst Instance=new A085154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085153
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,14L,15L,20L,24L,27L,35L,48L,49L,63L,80L,125L,224L,2400L,4374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085153Inst : IEnumerable<long>
{
public static readonly long[] Value=A085153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085153.Bytes);
public long this[int i]=>Value[i];

public static A085153Inst Instance=new A085153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085152
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,9L,15L,24L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085152Inst : IEnumerable<long>
{
public static readonly long[] Value=A085152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085152.Bytes);
public long this[int i]=>Value[i];

public static A085152Inst Instance=new A085152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085151
{
public static readonly long[] Value={ 5L,29L,109L,305L,701L,1405L,2549L,4289L,6805L,10301L,15005L,21169L,29069L,39005L,51301L,66305L,84389L,105949L,131405L,161201L,195805L,235709L,281429L,333505L,392501L,459005L,533629L,617009L,709805L,812701L,926405L,1051649L,1189189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085151Inst : IEnumerable<long>
{
public static readonly long[] Value=A085151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085151.Bytes);
public long this[int i]=>Value[i];

public static A085151Inst Instance=new A085151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085150
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,10L,12L,16L,18L,20L,22L,28L,40L,42L,44L,52L,66L,68L,78L,80L,92L,100L,102L,106L,210L,214L,232L,534L,676L,772L,822L,964L,1020L,1184L,1498L,2304L,2348L,7738L,9488L,11250L,12760L,12798L,25336L,27728L,35242L,41730L,46576L,55458L,73908L,94412L,99088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085150Inst : IEnumerable<long>
{
public static readonly long[] Value=A085150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085150.Bytes);
public long this[int i]=>Value[i];

public static A085150Inst Instance=new A085150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085149
{
public static readonly long[] Value={ 3L,4L,6L,7L,8L,12L,13L,14L,27L,28L,33L,35L,44L,50L,62L,64L,74L,88L,114L,140L,142L,242L,248L,262L,270L,284L,395L,473L,582L,600L,634L,707L,805L,882L,907L,1008L,1152L,1243L,1853L,2340L,2410L,2703L,2793L,3033L,3600L,3925L,4124L,4154L,6185L,6367L,7130L,9104L,9992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085149Inst : IEnumerable<long>
{
public static readonly long[] Value=A085149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085149.Bytes);
public long this[int i]=>Value[i];

public static A085149Inst Instance=new A085149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085148
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,11L,13L,15L,17L,23L,26L,31L,32L,35L,36L,49L,52L,89L,92L,106L,120L,141L,149L,173L,201L,280L,289L,353L,455L,483L,499L,543L,811L,866L,1010L,1126L,1557L,2358L,2411L,2435L,2485L,2491L,2772L,2851L,2937L,2996L,3642L,3777L,4123L,4642L,5566L,6416L,9202L,9382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085148Inst : IEnumerable<long>
{
public static readonly long[] Value=A085148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085148.Bytes);
public long this[int i]=>Value[i];

public static A085148Inst Instance=new A085148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085147
{
public static readonly long[] Value={ 3L,4L,6L,8L,12L,16L,22L,24L,54L,56L,98L,152L,156L,176L,256L,454L,460L,720L,750L,770L,800L,1442L,2846L,5920L,7066L,12778L,19978L,22726L,25938L,27780L,36072L,39746L,48244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085147Inst : IEnumerable<long>
{
public static readonly long[] Value=A085147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085147.Bytes);
public long this[int i]=>Value[i];

public static A085147Inst Instance=new A085147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085146
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,18L,38L,56L,94L,118L,148L,286L,1358L,1480L,1514L,2680L,2846L,4078L,4288L,5612L,5680L,6440L,6586L,14614L,30972L,31690L,54406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085146Inst : IEnumerable<long>
{
public static readonly long[] Value=A085146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085146.Bytes);
public long this[int i]=>Value[i];

public static A085146Inst Instance=new A085146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085145
{
public static readonly long[] Value={ 0L,1L,3L,7L,10L,15L,21L,26L,31L,36L,43L,46L,53L,58L,63L,73L,82L,87L,93L,100L,107L,110L,117L,122L,127L,136L,147L,150L,156L,165L,170L,175L,180L,187L,190L,201L,210L,215L,221L,228L,235L,238L,245L,250L,255L,273L,290L,295L,301L,313L,324L,331L,334L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085145Inst : IEnumerable<long>
{
public static readonly long[] Value=A085145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085145.Bytes);
public long this[int i]=>Value[i];

public static A085145Inst Instance=new A085145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085144
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,-1L,1L,0L,3L,-2L,0L,1L,2L,-1L,1L,0L,4L,-3L,-1L,2L,1L,0L,2L,-1L,3L,-2L,0L,1L,2L,-1L,1L,0L,5L,-4L,-2L,3L,0L,1L,3L,-2L,2L,-1L,1L,0L,3L,-2L,0L,1L,4L,-3L,-1L,2L,1L,0L,2L,-1L,3L,-2L,0L,1L,2L,-1L,1L,0L,6L,-5L,-3L,4L,-1L,2L,4L,-3L,1L,0L,2L,-1L,4L,-3L,-1L,2L,3L,-2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085144Inst : IEnumerable<long>
{
public static readonly long[] Value=A085144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085144.Bytes);
public long this[int i]=>Value[i];

public static A085144Inst Instance=new A085144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085143
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-1L,-1L,1L,0L,2L,1L,1L,-2L,4L,3L,1L,-1L,3L,-11L,-5L,-5L,-1L,-1L,-1L,-34L,10L,-20L,-8L,-1L,1L,11L,106L,-116L,96L,44L,13L,1L,1L,15L,368L,-328L,716L,86L,125L,21L,1L,-1L,13L,-1324L,-1344L,-5634L,1866L,-1063L,-316L,-34L,-1L,-1L,77L,-4811L,-17235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085143Inst : IEnumerable<long>
{
public static readonly long[] Value=A085143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085143.Bytes);
public long this[int i]=>Value[i];

public static A085143Inst Instance=new A085143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085142
{
public static readonly long[] Value={ 1L,0L,-4L,4L,-4L,4L,-4L,8L,-4L,0L,-4L,8L,-4L,0L,-4L,4L,-4L,0L,0L,8L,-4L,-4L,-4L,8L,0L,0L,0L,4L,-4L,0L,-4L,8L,-4L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085142Inst : IEnumerable<long>
{
public static readonly long[] Value=A085142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085142.Bytes);
public long this[int i]=>Value[i];

public static A085142Inst Instance=new A085142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085141
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085141Inst : IEnumerable<long>
{
public static readonly long[] Value=A085141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085141.Bytes);
public long this[int i]=>Value[i];

public static A085141Inst Instance=new A085141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085140
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,6L,10L,12L,15L,20L,26L,32L,40L,50L,60L,76L,92L,110L,134L,160L,191L,230L,272L,320L,380L,446L,522L,612L,715L,830L,966L,1120L,1292L,1494L,1720L,1976L,2272L,2602L,2974L,3400L,3876L,4412L,5020L,5700L,6460L,7322L,8282L,9352L,10559L,11900L,13396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085140Inst : IEnumerable<long>
{
public static readonly long[] Value=A085140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085140.Bytes);
public long this[int i]=>Value[i];

public static A085140Inst Instance=new A085140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085123
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,25L,126L,27L,35L,28L,36L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085123Inst : IEnumerable<long>
{
public static readonly long[] Value=A085123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085123.Bytes);
public long this[int i]=>Value[i];

public static A085123Inst Instance=new A085123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085122
{
public static readonly long[] Value={ 0L,-1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,2L,0L,1L,1L,2L,0L,2L,0L,2L,2L,2L,0L,2L,2L,2L,3L,3L,0L,2L,0L,3L,2L,2L,3L,3L,0L,3L,4L,3L,0L,4L,0L,3L,4L,3L,0L,4L,3L,5L,3L,5L,0L,3L,3L,3L,3L,3L,0L,3L,0L,4L,3L,4L,3L,4L,0L,5L,5L,5L,0L,4L,0L,2L,5L,4L,4L,4L,0L,5L,5L,5L,0L,7L,4L,5L,4L,5L,0L,4L,3L,5L,5L,5L,5L,4L,0L,5L,5L,5L,0L,6L,0L,6L,6L,7L,0L,5L,0L,5L,6L,8L,0L,5L,5L,6L,7L,5L,5L,5L,6L,5L,6L,7L,5L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085122Inst : IEnumerable<long>
{
public static readonly long[] Value=A085122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085122.Bytes);
public long this[int i]=>Value[i];

public static A085122Inst Instance=new A085122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085121
{
public static readonly long[] Value={ 0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,0L,0L,32L,0L,0L,0L,0L,0L,0L,0L,48L,0L,0L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,0L,0L,48L,0L,0L,0L,0L,0L,0L,0L,72L,0L,0L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,0L,0L,56L,0L,0L,0L,0L,0L,0L,0L,72L,0L,0L,0L,0L,0L,0L,0L,48L,0L,0L,0L,0L,0L,0L,0L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085121Inst : IEnumerable<long>
{
public static readonly long[] Value=A085121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085121.Bytes);
public long this[int i]=>Value[i];

public static A085121Inst Instance=new A085121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085120
{
public static readonly BigInteger[] Value={ 484L,5200L,74248L,1231168L,22274392L,426121840L,8473865608L,173384503648L,3626078527672L,77156534226640L,1664879923268968L,36341339939604928L,800962970101817752L,17798446869494190640UL,BigInteger.Parse("398294702872579430728"),BigInteger.Parse("8967482707817471999008"),BigInteger.Parse("202975553115995639744632") };
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
public class A085120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085120Inst Instance=new A085120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085119
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,2L,1L,1L,1L,9L,13L,13L,13L,13L,13L,2L,13L,13L,17L,13L,13L,5L,13L,13L,13L,22L,13L,5L,29L,1L,13L,13L,13L,29L,13L,13L,13L,7L,13L,1L,17L,13L,29L,1L,13L,1L,33L,49L,13L,20L,31L,11L,13L,11L,3L,19L,13L,19L,61L,13L,61L,13L,61L,27L,49L,10L,13L,40L,13L,34L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085119Inst : IEnumerable<long>
{
public static readonly long[] Value=A085119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085119.Bytes);
public long this[int i]=>Value[i];

public static A085119Inst Instance=new A085119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085118
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,13L,14L,17L,19L,22L,23L,26L,29L,31L,34L,37L,38L,41L,43L,46L,47L,53L,58L,59L,61L,62L,67L,71L,73L,74L,79L,82L,83L,86L,89L,94L,97L,101L,103L,106L,107L,109L,113L,118L,122L,127L,131L,134L,137L,139L,142L,146L,149L,151L,157L,158L,163L,166L,167L,173L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085118Inst : IEnumerable<long>
{
public static readonly long[] Value=A085118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085118.Bytes);
public long this[int i]=>Value[i];

public static A085118Inst Instance=new A085118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085117
{
public static readonly long[] Value={ 0L,5L,8L,6L,6L,1L,0L,2L,8L,7L,3L,4L,3L,3L,7L,2L,9L,6L,5L,8L,4L,2L,2L,5L,5L,4L,8L,0L,8L,1L,5L,1L,1L,3L,2L,6L,2L,4L,1L,8L,5L,8L,6L,1L,0L,7L,8L,2L,2L,6L,5L,9L,8L,3L,4L,3L,6L,1L,2L,1L,1L,0L,2L,3L,9L,8L,9L,2L,9L,9L,6L,5L,4L,6L,3L,9L,8L,4L,6L,3L,6L,9L,1L,6L,5L,1L,2L,3L,5L,9L,4L,5L,3L,9L,9L,3L,3L,9L,7L,8L,0L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085117Inst : IEnumerable<long>
{
public static readonly long[] Value=A085117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085117.Bytes);
public long this[int i]=>Value[i];

public static A085117Inst Instance=new A085117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085116
{
public static readonly BigInteger[] Value={ 4L,12L,480L,2880L,171360L,15079680L,2979744768L,256258050048L,2206253681888256L,BigInteger.Parse("32081134788337130496"),BigInteger.Parse("3025251010540191405772800"),BigInteger.Parse("60806680954426264344203059200"),BigInteger.Parse("22247876027117358528051602802320179200") };
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
public class A085116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085116Inst Instance=new A085116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085115
{
public static readonly BigInteger[] Value={ 1L,5L,241L,1561L,96029L,8580709L,1707931151L,147403551109L,1271289370866337L,BigInteger.Parse("18501833565256581935"),BigInteger.Parse("1745474502799550774494057"),BigInteger.Parse("35091068020856449153974443861"),BigInteger.Parse("12840452368911027932139293073746831113") };
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
public class A085115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085115Inst Instance=new A085115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085114
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085114Inst : IEnumerable<long>
{
public static readonly long[] Value=A085114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085114.Bytes);
public long this[int i]=>Value[i];

public static A085114Inst Instance=new A085114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085113
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,9L,5L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085113Inst : IEnumerable<long>
{
public static readonly long[] Value=A085113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085113.Bytes);
public long this[int i]=>Value[i];

public static A085113Inst Instance=new A085113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085112
{
public static readonly long[] Value={ 101L,131L,151L,181L,191L,313L,353L,373L,383L,727L,757L,787L,797L,919L,929L,14741L,18181L,32323L,34543L,35353L,35753L,72727L,74747L,78787L,94949L,95959L,97579L,1212121L,1616161L,3135313L,3212123L,7654567L,159595951L,323232323L,345656543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085112Inst : IEnumerable<long>
{
public static readonly long[] Value=A085112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085112.Bytes);
public long this[int i]=>Value[i];

public static A085112Inst Instance=new A085112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085111
{
public static readonly long[] Value={ 1L,2L,4L,1L,4L,9L,54L,47L,376L,385L,3850L,3839L,46068L,46081L,645134L,645119L,10321904L,10321921L,185794578L,185794559L,3715891180L,3715891201L,81749606422L,81749606399L,1961990553576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085111Inst : IEnumerable<long>
{
public static readonly long[] Value=A085111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085111.Bytes);
public long this[int i]=>Value[i];

public static A085111Inst Instance=new A085111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085110
{
public static readonly BigInteger[] Value={ 1L,4L,9L,40L,195L,1176L,8225L,65808L,592263L,5922640L,65149029L,781788360L,10163248667L,142285481352L,2134282220265L,34148515524256L,580524763912335L,10449445750422048L,198539469258018893L,3970789385160377880L,BigInteger.Parse("83386577088367935459"),BigInteger.Parse("1834504695944094580120") };
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
public class A085110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085110Inst Instance=new A085110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085109
{
public static readonly long[] Value={ 1111L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,10101L,11111L,12121L,12321L,13131L,13531L,14141L,14741L,15151L,15951L,16161L,17171L,18181L,19191L,20202L,21012L,21212L,22222L,23232L,23432L,24242L,24642L,25252L,25852L,26262L,27272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085109Inst : IEnumerable<long>
{
public static readonly long[] Value=A085109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085109.Bytes);
public long this[int i]=>Value[i];

public static A085109Inst Instance=new A085109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085108
{
public static readonly long[] Value={ 0L,4L,7L,9L,7L,0L,5L,4L,6L,3L,4L,6L,4L,4L,6L,5L,2L,3L,4L,8L,8L,2L,8L,7L,3L,0L,9L,9L,8L,0L,9L,4L,7L,3L,2L,3L,2L,0L,5L,8L,2L,4L,5L,4L,0L,3L,1L,3L,0L,4L,0L,4L,3L,0L,4L,8L,3L,3L,9L,8L,2L,3L,2L,0L,4L,5L,1L,7L,2L,1L,2L,9L,2L,9L,4L,9L,9L,1L,0L,1L,7L,4L,4L,7L,8L,4L,8L,7L,9L,0L,3L,7L,7L,1L,3L,0L,0L,7L,6L,7L,7L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085108Inst : IEnumerable<long>
{
public static readonly long[] Value=A085108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085108.Bytes);
public long this[int i]=>Value[i];

public static A085108Inst Instance=new A085108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085059
{
public static readonly long[] Value={ 1L,2L,4L,1L,5L,10L,4L,11L,3L,12L,2L,13L,1L,14L,28L,13L,29L,12L,30L,11L,31L,10L,32L,9L,33L,8L,34L,7L,35L,6L,36L,5L,37L,4L,38L,3L,39L,2L,40L,1L,41L,82L,40L,83L,39L,84L,38L,85L,37L,86L,36L,87L,35L,88L,34L,89L,33L,90L,32L,91L,31L,92L,30L,93L,29L,94L,28L,95L,27L,96L,26L,97L,25L,98L,24L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085059Inst : IEnumerable<long>
{
public static readonly long[] Value=A085059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085059.Bytes);
public long this[int i]=>Value[i];

public static A085059Inst Instance=new A085059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085058
{
public static readonly long[] Value={ 2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,6L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,7L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,6L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,8L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,6L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,7L,2L,3L,2L,4L,2L,3L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085058Inst : IEnumerable<long>
{
public static readonly long[] Value=A085058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085058.Bytes);
public long this[int i]=>Value[i];

public static A085058Inst Instance=new A085058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085057
{
public static readonly long[] Value={ 2L,6L,5L,70L,7L,231L,858L,1430L,12155L,46189L,176358L,676039L,104006L,44574L,1077205L,66786710L,64822395L,90751353L,353452638L,3829070245L,134564468610L,526024740930L,2287064091L,35830670759L,71661341518L,281132955186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085057Inst : IEnumerable<long>
{
public static readonly long[] Value=A085057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085057.Bytes);
public long this[int i]=>Value[i];

public static A085057Inst Instance=new A085057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085056
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,8L,24L,24L,24L,48L,48L,48L,48L,384L,384L,1152L,1152L,2304L,2304L,2304L,2304L,9216L,46080L,46080L,414720L,829440L,829440L,829440L,829440L,13271040L,13271040L,13271040L,13271040L,79626240L,79626240L,79626240L,79626240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085056Inst : IEnumerable<long>
{
public static readonly long[] Value=A085056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085056.Bytes);
public long this[int i]=>Value[i];

public static A085056Inst Instance=new A085056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085055
{
public static readonly long[] Value={ 1L,2L,4L,32L,288L,576L,6912L,13824L,207360L,3317760L,59719680L,1194393600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085055Inst : IEnumerable<long>
{
public static readonly long[] Value=A085055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085055.Bytes);
public long this[int i]=>Value[i];

public static A085055Inst Instance=new A085055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085054
{
public static readonly long[] Value={ 101L,11L,2L,3L,11411L,5L,10601L,7L,181L,191L,11L,72227L,13331L,1444441L,15551L,16661L,77377L,78887L,19991L,101L,1114111L,1212121L,131L,11411L,151L,1611161L,1117111L,181L,191L,1120211L,1212121L,72227L,32323L,12421L,3252523L,1126211L,12721L,12821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085054Inst : IEnumerable<long>
{
public static readonly long[] Value=A085054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085054.Bytes);
public long this[int i]=>Value[i];

public static A085054Inst Instance=new A085054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085053
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,5L,2L,2L,3L,6L,3L,6L,4L,6L,5L,6L,3L,10L,2L,7L,6L,9L,4L,10L,5L,10L,7L,11L,4L,17L,3L,10L,9L,12L,9L,16L,4L,9L,11L,14L,5L,21L,7L,11L,10L,16L,8L,19L,6L,18L,13L,17L,5L,24L,10L,19L,9L,16L,8L,27L,7L,15L,13L,16L,13L,30L,9L,18L,13L,27L,9L,26L,10L,20L,18L,17L,11L,29L,11L,23L,18L,22L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085053Inst : IEnumerable<long>
{
public static readonly long[] Value=A085053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085053.Bytes);
public long this[int i]=>Value[i];

public static A085053Inst Instance=new A085053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085052
{
public static readonly long[] Value={ 3L,7L,5L,643L,7L,11L,17L,13L,11L,139L,13L,17L,23L,19L,17L,397L,19L,23L,29L,37L,23L,151L,463L,29L,53L,31L,29L,157L,31L,47L,41L,37L,43L,163L,37L,41L,47L,43L,41L,421L,43L,47L,53L,61L,47L,547L,487L,53L,59L,67L,53L,181L,3319L,59L,83L,61L,59L,439L,61L,101L,71L,67L,73L,193L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085052Inst : IEnumerable<long>
{
public static readonly long[] Value=A085052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085052.Bytes);
public long this[int i]=>Value[i];

public static A085052Inst Instance=new A085052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085051
{
public static readonly long[] Value={ 17L,26L,51L,244L,55L,846L,49L,424L,99L,170L,55L,3480L,26L,476L,1275L,1376L,17L,846L,19L,1520L,651L,638L,161L,3480L,125L,26L,243L,476L,377L,3480L,341L,1376L,99L,170L,595L,6876L,629L,874L,351L,1520L,451L,28224L,559L,2024L,1665L,874L,235L,18768L,49L,7300L,51L,5824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085051Inst : IEnumerable<long>
{
public static readonly long[] Value=A085051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085051.Bytes);
public long this[int i]=>Value[i];

public static A085051Inst Instance=new A085051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085050
{
public static readonly long[] Value={ 4L,4L,6L,4L,20L,6L,14L,16L,18L,20L,22L,12L,52L,14L,30L,16L,34L,18L,38L,20L,42L,22L,92L,72L,150L,52L,54L,56L,58L,30L,186L,32L,66L,34L,70L,36L,222L,38L,78L,40L,164L,42L,86L,88L,90L,92L,94L,96L,196L,150L,102L,52L,106L,54L,110L,56L,114L,58L,236L,60L,366L,186L,252L,128L,130L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085050Inst : IEnumerable<long>
{
public static readonly long[] Value=A085050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085050.Bytes);
public long this[int i]=>Value[i];

public static A085050Inst Instance=new A085050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085049
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,10L,2L,3L,5L,7L,12L,14L,15L,16L,18L,11L,13L,17L,19L,23L,29L,20L,21L,22L,24L,25L,26L,27L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085049Inst : IEnumerable<long>
{
public static readonly long[] Value=A085049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085049.Bytes);
public long this[int i]=>Value[i];

public static A085049Inst Instance=new A085049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085048
{
public static readonly long[] Value={ 1L,4L,7L,12L,15L,18L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085048Inst : IEnumerable<long>
{
public static readonly long[] Value=A085048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085048.Bytes);
public long this[int i]=>Value[i];

public static A085048Inst Instance=new A085048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085047
{
public static readonly long[] Value={ 1L,7L,4L,24L,9L,51L,16L,88L,25L,135L,36L,192L,49L,259L,64L,336L,81L,423L,100L,520L,121L,627L,144L,744L,169L,871L,196L,1008L,225L,1155L,256L,1312L,289L,1479L,324L,1656L,361L,1843L,400L,2040L,441L,2247L,484L,2464L,529L,2691L,576L,2928L,625L,3175L,676L,3432L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085047Inst : IEnumerable<long>
{
public static readonly long[] Value=A085047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085047.Bytes);
public long this[int i]=>Value[i];

public static A085047Inst Instance=new A085047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085046
{
public static readonly long[] Value={ 1L,3L,9L,15L,25L,35L,49L,63L,81L,99L,121L,143L,169L,195L,225L,255L,289L,323L,361L,399L,441L,483L,529L,575L,625L,675L,729L,783L,841L,899L,961L,1023L,1089L,1155L,1225L,1295L,1369L,1443L,1521L,1599L,1681L,1763L,1849L,1935L,2025L,2115L,2209L,2303L,2401L,2499L,2601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085046Inst : IEnumerable<long>
{
public static readonly long[] Value=A085046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085046.Bytes);
public long this[int i]=>Value[i];

public static A085046Inst Instance=new A085046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085045
{
public static readonly long[] Value={ 2L,1L,5L,2L,3L,134L,3L,4L,11L,2L,3L,548L,2L,1L,3L,2L,5L,402L,2L,316L,1L,38L,3L,1236L,3L,1L,13L,2L,5L,1986L,2L,16L,1L,1L,19L,1644L,2L,1L,13L,716L,4L,1398L,3L,1L,15L,14L,11L,2472L,3L,10L,5L,2L,2L,1146L,23L,4L,1L,14L,3L,11028L,13L,4L,3L,2L,23L,1194L,2L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085045Inst : IEnumerable<long>
{
public static readonly long[] Value=A085045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085045.Bytes);
public long this[int i]=>Value[i];

public static A085045Inst Instance=new A085045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085044
{
public static readonly long[] Value={ 1L,10L,1L,32L,3L,34L,3L,22L,1L,2L,3L,148L,2L,10L,1L,209L,5L,62L,2L,52L,7L,8L,3L,186L,1L,2L,5L,2L,5L,138L,2L,4L,11L,6L,17L,324L,2L,7L,5L,86L,5L,78L,3L,28L,11L,8L,11L,402L,15L,62L,15L,2L,2L,6L,9L,34L,11L,5L,3L,444L,13L,8L,1L,3905L,3L,6L,2L,2L,7L,14L,3L,348L,13L,2L,3L,2L,27L,2L,3L,370L,49L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085044Inst : IEnumerable<long>
{
public static readonly long[] Value=A085044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085044.Bytes);
public long this[int i]=>Value[i];

public static A085044Inst Instance=new A085044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085043
{
public static readonly long[] Value={ 2L,5L,5L,19L,41L,67L,101L,139L,277L,509L,571L,719L,883L,1399L,1493L,1811L,3109L,3719L,3853L,4421L,4567L,6779L,8273L,8629L,10181L,11393L,12011L,12653L,15269L,17077L,17839L,20983L,22079L,23747L,25237L,25841L,26783L,27109L,28111L,30187L,32693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085043Inst : IEnumerable<long>
{
public static readonly long[] Value=A085043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085043.Bytes);
public long this[int i]=>Value[i];

public static A085043Inst Instance=new A085043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085042
{
public static readonly long[] Value={ 2L,3L,0L,14L,22L,26L,34L,38L,138L,232L,62L,148L,164L,516L,94L,318L,1298L,610L,134L,568L,146L,2212L,1494L,356L,1552L,1212L,618L,642L,2616L,1808L,762L,3144L,1096L,1668L,1490L,604L,942L,326L,1002L,2076L,2506L,1448L,2292L,1158L,7092L,4776L,2532L,892L,908L,2290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085042Inst : IEnumerable<long>
{
public static readonly long[] Value=A085042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085042.Bytes);
public long this[int i]=>Value[i];

public static A085042Inst Instance=new A085042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085041
{
public static readonly long[] Value={ 2L,11L,31L,59L,103L,181L,283L,359L,727L,1249L,1373L,1447L,1693L,1951L,2609L,2927L,3163L,3407L,3541L,3967L,4259L,4733L,5231L,6121L,6703L,7309L,7927L,8783L,9001L,9227L,10243L,12601L,13697L,15643L,17431L,20149L,23603L,23929L,25933L,30431L,31147L,32233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085041Inst : IEnumerable<long>
{
public static readonly long[] Value=A085041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085041.Bytes);
public long this[int i]=>Value[i];

public static A085041Inst Instance=new A085041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085040
{
public static readonly long[] Value={ 4L,16L,36L,64L,196L,625L,676L,961L,1444L,2401L,5625L,12100L,18496L,27225L,44521L,45369L,67081L,84100L,97969L,106276L,109561L,144400L,202500L,279841L,289444L,328329L,439569L,529984L,636804L,804609L,1016064L,1183744L,1218816L,1254400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085040Inst : IEnumerable<long>
{
public static readonly long[] Value=A085040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085040.Bytes);
public long this[int i]=>Value[i];

public static A085040Inst Instance=new A085040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085039
{
public static readonly long[] Value={ 4L,12L,20L,28L,132L,429L,51L,285L,483L,957L,3224L,6475L,6396L,8729L,17296L,848L,21712L,17019L,13869L,8307L,3285L,34839L,58100L,77341L,9603L,38885L,111240L,90415L,106820L,167805L,211455L,167680L,35072L,35584L,343296L,100113L,168147L,108069L,82331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085039Inst : IEnumerable<long>
{
public static readonly long[] Value=A085039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085039.Bytes);
public long this[int i]=>Value[i];

public static A085039Inst Instance=new A085039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085038
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,10L,13L,12L,11L,14L,17L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085038Inst : IEnumerable<long>
{
public static readonly long[] Value=A085038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085038.Bytes);
public long this[int i]=>Value[i];

public static A085038Inst Instance=new A085038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085037
{
public static readonly long[] Value={ 1L,9L,36L,100L,225L,441L,196L,36L,225L,3025L,4356L,6084L,8281L,11025L,3600L,4624L,2601L,3249L,36100L,44100L,53361L,64009L,19044L,900L,4225L,13689L,15876L,164836L,189225L,216225L,15376L,17424L,314721L,354025L,44100L,49284L,494209L,549081L,152100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085037Inst : IEnumerable<long>
{
public static readonly long[] Value=A085037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085037.Bytes);
public long this[int i]=>Value[i];

public static A085037Inst Instance=new A085037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085036
{
public static readonly long[] Value={ 14L,84L,204L,374L,594L,864L,1184L,1554L,1974L,2444L,2964L,3534L,4154L,4824L,5544L,6314L,7134L,8004L,8924L,9894L,10914L,11984L,13104L,14274L,15494L,16764L,18084L,19454L,20874L,22344L,23864L,25434L,27054L,28724L,30444L,32214L,34034L,35904L,37824L,39794L,41814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085036Inst : IEnumerable<long>
{
public static readonly long[] Value=A085036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085036.Bytes);
public long this[int i]=>Value[i];

public static A085036Inst Instance=new A085036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085035
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,3L,1L,2L,2L,2L,2L,1L,2L,3L,4L,1L,1L,3L,2L,3L,3L,5L,3L,3L,5L,2L,3L,3L,1L,3L,1L,1L,2L,4L,4L,4L,3L,2L,4L,2L,1L,2L,3L,4L,2L,4L,2L,4L,2L,3L,2L,2L,3L,7L,1L,5L,4L,2L,2L,3L,3L,3L,2L,2L,3L,3L,3L,3L,2L,4L,5L,6L,2L,6L,2L,3L,2L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085035Inst : IEnumerable<long>
{
public static readonly long[] Value=A085035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085035.Bytes);
public long this[int i]=>Value[i];

public static A085035Inst Instance=new A085035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085034
{
public static readonly long[] Value={ 3L,2L,2L,2L,3L,1L,2L,3L,3L,2L,4L,1L,2L,2L,3L,2L,5L,1L,4L,1L,4L,2L,3L,3L,4L,2L,5L,2L,6L,1L,5L,2L,3L,2L,3L,1L,5L,2L,8L,2L,5L,2L,3L,3L,5L,2L,7L,2L,7L,4L,5L,2L,5L,1L,5L,3L,6L,2L,4L,3L,4L,3L,5L,2L,4L,1L,5L,3L,7L,3L,6L,2L,6L,3L,7L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085034Inst : IEnumerable<long>
{
public static readonly long[] Value=A085034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085034.Bytes);
public long this[int i]=>Value[i];

public static A085034Inst Instance=new A085034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085033
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,2L,3L,4L,2L,3L,4L,2L,3L,3L,2L,4L,2L,3L,4L,5L,1L,2L,3L,3L,4L,5L,2L,5L,3L,4L,2L,4L,1L,4L,4L,3L,3L,5L,2L,3L,3L,2L,8L,7L,4L,4L,3L,2L,3L,5L,3L,4L,3L,2L,3L,2L,2L,5L,7L,4L,5L,6L,2L,6L,5L,4L,6L,3L,1L,7L,3L,4L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085033Inst : IEnumerable<long>
{
public static readonly long[] Value=A085033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085033.Bytes);
public long this[int i]=>Value[i];

public static A085033Inst Instance=new A085033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085032
{
public static readonly long[] Value={ 2L,3L,2L,3L,1L,1L,2L,2L,3L,2L,2L,2L,1L,2L,2L,3L,2L,1L,2L,3L,1L,2L,3L,3L,2L,2L,5L,1L,3L,1L,3L,3L,3L,1L,2L,1L,3L,2L,3L,2L,3L,2L,2L,3L,2L,1L,2L,1L,4L,1L,4L,2L,3L,1L,1L,4L,4L,1L,4L,2L,4L,3L,1L,4L,5L,2L,4L,3L,3L,4L,2L,3L,5L,2L,2L,1L,3L,3L,2L,3L,5L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085032Inst : IEnumerable<long>
{
public static readonly long[] Value=A085032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085032.Bytes);
public long this[int i]=>Value[i];

public static A085032Inst Instance=new A085032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085031
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,3L,2L,2L,4L,1L,2L,2L,1L,1L,4L,1L,3L,3L,2L,2L,1L,1L,2L,3L,2L,2L,3L,3L,5L,2L,2L,2L,2L,1L,4L,3L,3L,2L,3L,2L,3L,1L,3L,3L,3L,2L,2L,4L,3L,3L,3L,4L,3L,1L,4L,3L,4L,3L,2L,2L,2L,5L,1L,3L,4L,3L,3L,2L,2L,4L,3L,3L,2L,3L,7L,2L,3L,1L,4L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085031Inst : IEnumerable<long>
{
public static readonly long[] Value=A085031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085031.Bytes);
public long this[int i]=>Value[i];

public static A085031Inst Instance=new A085031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085030
{
public static readonly long[] Value={ 2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,1L,1L,1L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,1L,4L,2L,4L,1L,3L,2L,2L,3L,2L,2L,4L,2L,3L,3L,2L,2L,2L,4L,2L,2L,3L,2L,1L,1L,1L,2L,3L,3L,3L,4L,5L,1L,1L,2L,2L,2L,3L,3L,3L,4L,3L,2L,5L,4L,4L,2L,2L,3L,3L,3L,5L,2L,3L,2L,3L,2L,2L,4L,3L,2L,3L,4L,3L,1L,6L,1L,2L,1L,4L,3L,4L,2L,3L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085030Inst : IEnumerable<long>
{
public static readonly long[] Value=A085030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085030.Bytes);
public long this[int i]=>Value[i];

public static A085030Inst Instance=new A085030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085029
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,2L,2L,1L,2L,2L,2L,1L,3L,2L,3L,2L,4L,3L,3L,1L,5L,2L,2L,2L,3L,3L,4L,2L,4L,3L,3L,1L,4L,2L,4L,2L,3L,4L,5L,2L,2L,4L,6L,2L,5L,2L,6L,2L,4L,2L,5L,1L,2L,4L,3L,2L,4L,2L,4L,3L,3L,2L,5L,2L,5L,4L,3L,3L,4L,5L,4L,2L,7L,4L,7L,2L,2L,4L,3L,3L,4L,3L,6L,1L,3L,3L,5L,1L,6L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085029Inst : IEnumerable<long>
{
public static readonly long[] Value=A085029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085029.Bytes);
public long this[int i]=>Value[i];

public static A085029Inst Instance=new A085029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085028
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,2L,2L,2L,2L,1L,2L,2L,1L,2L,1L,3L,2L,3L,2L,3L,2L,1L,3L,2L,1L,2L,2L,4L,1L,3L,3L,2L,2L,3L,1L,4L,3L,5L,2L,2L,2L,3L,2L,3L,2L,3L,3L,2L,1L,2L,2L,1L,2L,3L,2L,3L,2L,2L,1L,1L,1L,4L,3L,3L,2L,3L,4L,3L,2L,3L,2L,4L,2L,2L,1L,3L,3L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085028Inst : IEnumerable<long>
{
public static readonly long[] Value=A085028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085028.Bytes);
public long this[int i]=>Value[i];

public static A085028Inst Instance=new A085028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085027
{
public static readonly long[] Value={ 21L,77L,165L,285L,437L,621L,837L,1085L,1365L,1677L,2021L,2397L,2805L,3245L,3717L,4221L,4757L,5325L,5925L,6557L,7221L,7917L,8645L,9405L,10197L,11021L,11877L,12765L,13685L,14637L,15621L,16637L,17685L,18765L,19877L,21021L,22197L,23405L,24645L,25917L,27221L,28557L,29925L,31325L,32757L,34221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085027Inst : IEnumerable<long>
{
public static readonly long[] Value=A085027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085027.Bytes);
public long this[int i]=>Value[i];

public static A085027Inst Instance=new A085027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085026
{
public static readonly long[] Value={ 7L,91L,247L,475L,775L,1147L,1591L,2107L,2695L,3355L,4087L,4891L,5767L,6715L,7735L,8827L,9991L,11227L,12535L,13915L,15367L,16891L,18487L,20155L,21895L,23707L,25591L,27547L,29575L,31675L,33847L,36091L,38407L,40795L,43255L,45787L,48391L,51067L,53815L,56635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085026Inst : IEnumerable<long>
{
public static readonly long[] Value=A085026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085026.Bytes);
public long this[int i]=>Value[i];

public static A085026Inst Instance=new A085026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085025
{
public static readonly long[] Value={ 6L,66L,176L,336L,546L,806L,1116L,1476L,1886L,2346L,2856L,3416L,4026L,4686L,5396L,6156L,6966L,7826L,8736L,9696L,10706L,11766L,12876L,14036L,15246L,16506L,17816L,19176L,20586L,22046L,23556L,25116L,26726L,28386L,30096L,31856L,33666L,35526L,37436L,39396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085025Inst : IEnumerable<long>
{
public static readonly long[] Value=A085025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085025.Bytes);
public long this[int i]=>Value[i];

public static A085025Inst Instance=new A085025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085024
{
public static readonly long[] Value={ 4L,28L,70L,130L,208L,304L,418L,550L,700L,868L,1054L,1258L,1480L,1720L,1978L,2254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085024Inst : IEnumerable<long>
{
public static readonly long[] Value=A085024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085024.Bytes);
public long this[int i]=>Value[i];

public static A085024Inst Instance=new A085024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085023
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,97L,981L,12331L,187153L,3319233L,67362697L,1540796851L,39256807701L,1102344130273L,33822265578973L,1125785761963227L,40407886961046361L,1555858721974047361L,BigInteger.Parse("63972335301256871313"),BigInteger.Parse("2797676940942967706083") };
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
public class A085023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085023Inst Instance=new A085023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085022
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,17L,37L,82L,185L,424L,983L,2301L,5431L,12913L,30900L,74361L,179855L,436974L,1065985L,2609993L,6411730L,15799090L,39039031L,96711591L,240150955L,597640140L,1490309462L,3723343793L,9318686066L,23360994967L,58654055246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085022Inst : IEnumerable<long>
{
public static readonly long[] Value=A085022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085022.Bytes);
public long this[int i]=>Value[i];

public static A085022Inst Instance=new A085022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085021
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,2L,1L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,3L,1L,2L,3L,2L,3L,2L,2L,3L,1L,1L,3L,1L,3L,2L,2L,2L,1L,1L,2L,2L,1L,1L,3L,4L,1L,2L,3L,2L,2L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085021Inst : IEnumerable<long>
{
public static readonly long[] Value=A085021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085021.Bytes);
public long this[int i]=>Value[i];

public static A085021Inst Instance=new A085021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085020
{
public static readonly long[] Value={ 2L,5L,2L,10L,2L,12L,2L,10L,2L,16L,2L,30L,2L,5L,2L,27L,2L,31L,2L,21L,2L,28L,2L,30L,2L,5L,2L,39L,2L,54L,2L,27L,2L,5L,2L,86L,2L,5L,2L,62L,2L,55L,2L,33L,2L,52L,2L,47L,2L,16L,2L,63L,2L,31L,2L,39L,2L,64L,2L,133L,2L,5L,2L,27L,2L,102L,2L,10L,2L,87L,2L,159L,2L,5L,2L,10L,2L,91L,2L,79L,2L,88L,2L,102L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085020Inst : IEnumerable<long>
{
public static readonly long[] Value=A085020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085020.Bytes);
public long this[int i]=>Value[i];

public static A085020Inst Instance=new A085020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085019
{
public static readonly long[] Value={ 393L,109L,132L,157L,481L,184L,213L,1048L,244L,577L,277L,1833L,312L,681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085019Inst : IEnumerable<long>
{
public static readonly long[] Value=A085019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085019.Bytes);
public long this[int i]=>Value[i];

public static A085019Inst Instance=new A085019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085018
{
public static readonly long[] Value={ 1L,4L,13L,24L,33L,37L,52L,61L,69L,73L,88L,97L,109L,121L,132L,141L,157L,177L,181L,184L,193L,213L,229L,241L,244L,249L,253L,277L,292L,312L,313L,321L,337L,349L,373L,376L,388L,393L,397L,409L,421L,429L,433L,457L,472L,481L,501L,517L,529L,537L,541L,564L,568L,573L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085018Inst : IEnumerable<long>
{
public static readonly long[] Value=A085018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085018.Bytes);
public long this[int i]=>Value[i];

public static A085018Inst Instance=new A085018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085017
{
public static readonly long[] Value={ 1L,11L,189211L,219131L,3912073L,251088329L,4281405931L,5613526973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085017Inst : IEnumerable<long>
{
public static readonly long[] Value=A085017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085017.Bytes);
public long this[int i]=>Value[i];

public static A085017Inst Instance=new A085017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085016
{
public static readonly long[] Value={ 1L,7L,11L,59L,146L,319L,124243L,461867L,1446247L,4846042L,16146448L,19466227L,57973091L,73661929L,208574393L,681491953L,883910281L,1058487166L,1066657966L,1112633324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085016Inst : IEnumerable<long>
{
public static readonly long[] Value=A085016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085016.Bytes);
public long this[int i]=>Value[i];

public static A085016Inst Instance=new A085016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085015
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,5L,0L,3L,2L,5L,0L,11L,6L,9L,4L,7L,6L,9L,4L,15L,10L,21L,0L,11L,6L,9L,4L,15L,10L,13L,8L,11L,10L,13L,8L,19L,14L,25L,4L,15L,10L,21L,0L,43L,22L,33L,12L,23L,18L,21L,16L,27L,22L,33L,12L,23L,18L,21L,16L,27L,22L,25L,20L,23L,22L,25L,20L,31L,26L,37L,16L,27L,22L,33L,12L,55L,34L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085015Inst : IEnumerable<long>
{
public static readonly long[] Value=A085015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085015.Bytes);
public long this[int i]=>Value[i];

public static A085015Inst Instance=new A085015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085014
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,2L,1L,3L,2L,1L,3L,2L,2L,4L,1L,2L,3L,5L,4L,3L,6L,4L,4L,6L,4L,5L,4L,6L,5L,4L,2L,5L,8L,7L,5L,6L,3L,3L,3L,4L,5L,4L,4L,5L,9L,8L,7L,8L,5L,8L,7L,8L,4L,6L,6L,7L,7L,9L,6L,11L,7L,8L,2L,7L,12L,8L,6L,8L,4L,5L,5L,6L,5L,11L,10L,9L,11L,5L,8L,9L,12L,9L,4L,7L,13L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085014Inst : IEnumerable<long>
{
public static readonly long[] Value=A085014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085014.Bytes);
public long this[int i]=>Value[i];

public static A085014Inst Instance=new A085014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085013
{
public static readonly long[] Value={ 1L,3L,5L,7L,13L,23L,29L,37L,43L,61L,73L,89L,137L,151L,167L,199L,269L,383L,397L,521L,619L,659L,739L,1217L,1307L,1613L,1741L,1847L,1873L,2039L,2473L,2521L,2531L,3011L,3391L,3637L,3793L,4201L,4751L,5039L,5879L,6299L,7307L,7829L,8243L,8933L,9781L,9829L,10069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085013Inst : IEnumerable<long>
{
public static readonly long[] Value=A085013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085013.Bytes);
public long this[int i]=>Value[i];

public static A085013Inst Instance=new A085013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085012
{
public static readonly long[] Value={ 0L,0L,0L,31L,0L,257L,73L,89L,113L,11L,73L,61681L,127L,178481L,157L,233L,1321L,20857L,281L,19L,2731L,13367L,23L,193L,601L,307L,6361L,37L,29L,43L,2731L,953L,168749965921L,593L,31L,53L,2593L,499L,101653L,62020897L,54001L,2281L,97L,19707683773L,5347L,29191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085012Inst : IEnumerable<long>
{
public static readonly long[] Value=A085012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085012.Bytes);
public long this[int i]=>Value[i];

public static A085012Inst Instance=new A085012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085011
{
public static readonly long[] Value={ 8L,3L,8L,8L,4L,4L,8L,8L,3L,5L,9L,0L,2L,1L,5L,1L,9L,5L,4L,1L,9L,9L,1L,2L,2L,1L,5L,4L,0L,5L,9L,4L,8L,5L,0L,4L,4L,6L,7L,9L,0L,6L,4L,6L,8L,7L,8L,5L,3L,3L,3L,4L,9L,8L,1L,6L,0L,8L,9L,9L,8L,3L,3L,2L,6L,3L,5L,4L,4L,1L,0L,1L,7L,4L,5L,4L,1L,8L,3L,8L,7L,8L,2L,0L,0L,4L,6L,4L,9L,0L,9L,4L,8L,4L,7L,6L,3L,9L,1L,0L,0L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085011Inst : IEnumerable<long>
{
public static readonly long[] Value=A085011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085011.Bytes);
public long this[int i]=>Value[i];

public static A085011Inst Instance=new A085011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085010
{
public static readonly BigInteger[] Value={ 1L,3L,13L,209L,53505L,3506503681L,15060318633198616577UL,BigInteger.Parse("277813843495134114797235287762174738433"),BigInteger.Parse("94535152227927400227782074307303551040545228366095741656402842333161034088449") };
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
public class A085010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085010Inst Instance=new A085010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085009
{
public static readonly long[] Value={ 2L,0L,5L,8L,9L,8L,5L,0L,2L,2L,0L,5L,8L,9L,17L,23L,27L,29L,29L,27L,32L,35L,36L,35L,32L,27L,29L,29L,27L,23L,17L,9L,8L,5L,0L,2L,2L,0L,5L,8L,9L,8L,5L,0L,2L,2L,0L,5L,8L,9L,17L,23L,27L,29L,29L,27L,32L,35L,36L,44L,50L,54L,65L,74L,81L,86L,89L,90L,98L,104L,108L,110L,110L,108L,113L,116L,117L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085009Inst : IEnumerable<long>
{
public static readonly long[] Value=A085009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085009.Bytes);
public long this[int i]=>Value[i];

public static A085009Inst Instance=new A085009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085008
{
public static readonly long[] Value={ -2L,-4L,3L,1L,-1L,-3L,-5L,-7L,0L,-2L,-4L,3L,1L,-1L,6L,4L,2L,0L,-2L,-4L,3L,1L,-1L,-3L,-5L,-7L,0L,-2L,-4L,-6L,-8L,-10L,-3L,-5L,-7L,0L,-2L,-4L,3L,1L,-1L,-3L,-5L,-7L,0L,-2L,-4L,3L,1L,-1L,6L,4L,2L,0L,-2L,-4L,3L,1L,-1L,6L,4L,2L,9L,7L,5L,3L,1L,-1L,6L,4L,2L,0L,-2L,-4L,3L,1L,-1L,-3L,-5L,-7L,0L,-2L,-4L,3L,1L,-1L,6L,4L,2L,0L,-2L,-4L,3L,1L,-1L,-3L,-5L,-7L,0L,-2L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085008Inst : IEnumerable<long>
{
public static readonly long[] Value=A085008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085008.Bytes);
public long this[int i]=>Value[i];

public static A085008Inst Instance=new A085008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085007
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085007Inst : IEnumerable<long>
{
public static readonly long[] Value=A085007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085007.Bytes);
public long this[int i]=>Value[i];

public static A085007Inst Instance=new A085007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085006
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085006Inst : IEnumerable<long>
{
public static readonly long[] Value=A085006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085006.Bytes);
public long this[int i]=>Value[i];

public static A085006Inst Instance=new A085006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085005
{
public static readonly long[] Value={ 1L,3L,4L,4L,3L,3L,4L,4L,3L,1L,0L,0L,1L,1L,0L,0L,1L,3L,4L,4L,5L,7L,10L,12L,13L,13L,14L,16L,17L,17L,16L,16L,17L,19L,20L,20L,21L,23L,26L,28L,29L,31L,34L,38L,41L,43L,44L,46L,49L,51L,52L,52L,53L,55L,56L,56L,55L,55L,56L,58L,59L,59L,60L,62L,65L,67L,68L,68L,69L,71L,72L,72L,71L,71L,72L,72L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085005Inst : IEnumerable<long>
{
public static readonly long[] Value=A085005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085005.Bytes);
public long this[int i]=>Value[i];

public static A085005Inst Instance=new A085005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085004
{
public static readonly long[] Value={ 1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,0L,1L,0L,-1L,0L,1L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,2L,1L,0L,1L,2L,3L,2L,1L,2L,3L,4L,3L,2L,1L,2L,3L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,0L,1L,0L,-1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,0L,-1L,-2L,-3L,-2L,-1L,0L,-1L,-2L,-1L,0L,1L,0L,-1L,0L,1L,2L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085004Inst : IEnumerable<long>
{
public static readonly long[] Value=A085004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085004.Bytes);
public long this[int i]=>Value[i];

public static A085004Inst Instance=new A085004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085003
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,4L,4L,4L,4L,5L,6L,7L,7L,7L,8L,9L,10L,10L,10L,11L,12L,13L,13L,13L,13L,14L,15L,15L,15L,15L,16L,17L,18L,18L,18L,19L,20L,21L,21L,21L,22L,23L,24L,24L,24L,24L,25L,26L,26L,26L,26L,27L,28L,28L,28L,28L,29L,30L,31L,31L,31L,32L,33L,34L,34L,34L,34L,35L,36L,36L,36L,36L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085003Inst : IEnumerable<long>
{
public static readonly long[] Value=A085003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085003.Bytes);
public long this[int i]=>Value[i];

public static A085003Inst Instance=new A085003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085002
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085002Inst : IEnumerable<long>
{
public static readonly long[] Value=A085002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085002.Bytes);
public long this[int i]=>Value[i];

public static A085002Inst Instance=new A085002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085001
{
public static readonly long[] Value={ 4L,28L,70L,130L,208L,304L,418L,550L,700L,868L,1054L,1258L,1480L,1720L,1978L,2254L,2548L,2860L,3190L,3538L,3904L,4288L,4690L,5110L,5548L,6004L,6478L,6970L,7480L,8008L,8554L,9118L,9700L,10300L,10918L,11554L,12208L,12880L,13570L,14278L,15004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085001Inst : IEnumerable<long>
{
public static readonly long[] Value=A085001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085001.Bytes);
public long this[int i]=>Value[i];

public static A085001Inst Instance=new A085001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085000
{
public static readonly long[] Value={ 1L,10L,412L,40800L,6839492L,1865999570L,762150368499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085000Inst : IEnumerable<long>
{
public static readonly long[] Value=A085000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085000.Bytes);
public long this[int i]=>Value[i];

public static A085000Inst Instance=new A085000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084999
{
public static readonly BigInteger[] Value={ 1L,-10L,260L,-9002L,391860L,-20256038L,1211950740L,-82281893850L,6247844526420L,-524546069736150L,48243794823724500L,-4823577417987578250L,BigInteger.Parse("520903033165862392500"),BigInteger.Parse("-60422912433611865159750"),BigInteger.Parse("7492466897219978346172500") };
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
public class A084999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A084999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A084999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A084999Inst Instance=new A084999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084998
{
public static readonly long[] Value={ 121L,242L,363L,484L,0L,0L,0L,0L,0L,101101L,112211L,123321L,134431L,145541L,156651L,167761L,178871L,189981L,0L,202202L,213312L,224422L,235532L,246642L,257752L,268862L,279972L,0L,2912192L,303303L,314431L,325523L,336633L,347743L,358853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A084998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084998Inst : IEnumerable<long>
{
public static readonly long[] Value=A084998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084998.Bytes);
public long this[int i]=>Value[i];

public static A084998Inst Instance=new A084998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084997
{
public static readonly long[] Value={ 4L,6L,10L,14L,15L,21L,22L,26L,33L,34L,38L,39L,46L,55L,58L,62L,69L,74L,82L,85L,86L,91L,94L,106L,111L,115L,118L,122L,129L,133L,134L,141L,142L,146L,158L,159L,166L,178L,183L,194L,201L,202L,206L,213L,214L,218L,226L,235L,253L,254L,259L,262L,265L,274L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A084997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084997Inst : IEnumerable<long>
{
public static readonly long[] Value=A084997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084997.Bytes);
public long this[int i]=>Value[i];

public static A084997Inst Instance=new A084997Inst();

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