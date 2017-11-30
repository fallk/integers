using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A230105
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,22L,23L,24L,28L,29L,30L,32L,34L,35L,40L,41L,42L,44L,45L,46L,47L,54L,55L,56L,58L,65L,66L,67L,68L,75L,78L,81L,85L,88L,89L,90L,92L,94L,95L,101L,103L,105L,106L,108L,112L,114L,122L,124L,125L,128L,129L,132L,135L,141L,143L,144L,145L,146L,147L,152L,154L,155L,156L,158L,161L,165L,166L,167L,168L,175L,178L,181L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230105Inst : IEnumerable<long>
{
public static readonly long[] Value=A230105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230105.Bytes);
public long this[int i]=>Value[i];

public static A230105Inst Instance=new A230105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230106
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,0L,2L,0L,2L,0L,2L,0L,1L,0L,2L,1L,1L,0L,2L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,2L,0L,0L,1L,1L,0L,2L,1L,1L,1L,0L,0L,2L,0L,0L,0L,1L,2L,1L,0L,1L,0L,1L,0L,2L,0L,0L,1L,2L,1L,1L,0L,1L,0L,0L,0L,2L,1L,0L,1L,1L,0L,2L,1L,0L,0L,0L,1L,2L,0L,2L,1L,0L,0L,1L,0L,1L,1L,0L,0L,2L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230106Inst : IEnumerable<long>
{
public static readonly long[] Value=A230106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230106.Bytes);
public long this[int i]=>Value[i];

public static A230106Inst Instance=new A230106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230107
{
public static readonly long[] Value={ 0L,0L,-1L,0L,52L,-1L,11L,0L,-1L,51L,50L,-1L,49L,10L,-1L,0L,48L,-1L,9L,50L,-1L,49L,0L,-1L,47L,48L,-1L,0L,8L,-1L,49L,46L,-1L,47L,48L,-1L,45L,0L,-1L,7L,46L,-1L,47L,6L,-1L,45L,44L,-1L,0L,46L,-1L,5L,5L,-1L,45L,44L,-1L,43L,4L,-1L,4L,0L,-1L,4L,44L,-1L,43L,3L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230107Inst : IEnumerable<long>
{
public static readonly long[] Value=A230107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230107.Bytes);
public long this[int i]=>Value[i];

public static A230107Inst Instance=new A230107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230108
{
public static readonly long[] Value={ 2L,3L,6L,8L,11L,12L,18L,19L,22L,24L,27L,32L,38L,43L,44L,48L,50L,51L,54L,59L,66L,67L,72L,75L,76L,83L,86L,88L,96L,98L,99L,102L,107L,108L,114L,118L,123L,128L,131L,134L,139L,146L,147L,150L,152L,162L,163L,166L,171L,172L,176L,178L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230108Inst : IEnumerable<long>
{
public static readonly long[] Value=A230108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230108.Bytes);
public long this[int i]=>Value[i];

public static A230108Inst Instance=new A230108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230109
{
public static readonly long[] Value={ 3L,7L,12L,13L,19L,21L,27L,28L,31L,39L,43L,48L,52L,57L,61L,63L,67L,73L,75L,76L,84L,91L,93L,97L,103L,108L,109L,111L,112L,117L,124L,127L,129L,133L,139L,147L,151L,156L,157L,163L,171L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230109Inst : IEnumerable<long>
{
public static readonly long[] Value=A230109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230109.Bytes);
public long this[int i]=>Value[i];

public static A230109Inst Instance=new A230109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230110
{
public static readonly long[] Value={ 8L,10L,30L,63L,64L,512L,588L,720L,800L,1320L,3960L,4096L,5184L,5760L,6400L,7200L,21600L,27720L,27900L,32768L,35280L,41472L,46080L,51200L,70840L,84672L,92400L,95040L,105600L,151200L,188160L,262144L,331776L,368640L,376320L,409600L,504000L,518400L,576000L,640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230110Inst : IEnumerable<long>
{
public static readonly long[] Value=A230110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230110.Bytes);
public long this[int i]=>Value[i];

public static A230110Inst Instance=new A230110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230111
{
public static readonly long[] Value={ 8L,10L,64L,512L,720L,800L,1320L,1944L,4096L,5184L,5760L,6400L,7200L,8370L,23520L,32768L,41472L,44000L,46080L,47040L,51200L,69580L,74088L,76096L,84672L,93000L,95040L,105600L,129360L,235200L,240000L,262144L,331776L,368640L,409600L,518400L,546480L,576000L,640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230111Inst : IEnumerable<long>
{
public static readonly long[] Value=A230111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230111.Bytes);
public long this[int i]=>Value[i];

public static A230111Inst Instance=new A230111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230112
{
public static readonly long[] Value={ 4L,8L,16L,64L,256L,720L,800L,2200L,4096L,25600L,33600L,36288L,41472L,46080L,65536L,92400L,104960L,235200L,282240L,338688L,376320L,403200L,419840L,535680L,556640L,576000L,580800L,640000L,844800L,979776L,1088640L,1244160L,1354752L,1382400L,1505280L,1689600L,1995840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230112Inst : IEnumerable<long>
{
public static readonly long[] Value=A230112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230112.Bytes);
public long this[int i]=>Value[i];

public static A230112Inst Instance=new A230112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230113
{
public static readonly long[] Value={ 3L,4L,5L,6L,6L,5L,4L,3L,4L,6L,6L,5L,4L,3L,3L,5L,6L,5L,4L,3L,3L,4L,5L,6L,5L,3L,3L,4L,5L,6L,6L,4L,3L,4L,5L,6L,6L,5L,4L,3L,4L,6L,6L,5L,4L,3L,3L,5L,6L,5L,4L,3L,3L,4L,5L,6L,5L,3L,3L,4L,5L,6L,6L,4L,3L,4L,5L,6L,6L,5L,4L,3L,4L,6L,6L,5L,4L,3L,3L,5L,6L,5L,4L,3L,3L,4L,5L,6L,5L,3L,3L,4L,5L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230113Inst : IEnumerable<long>
{
public static readonly long[] Value=A230113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230113.Bytes);
public long this[int i]=>Value[i];

public static A230113Inst Instance=new A230113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230114
{
public static readonly BigInteger[] Value={ 1L,1L,9L,89L,1521L,32401L,869049L,27608489L,1019581281L,42824944801L,2017329504489L,105299243488889L,6032850630082641L,376363074361201201L,BigInteger.Parse("25396689469918450329"),BigInteger.Parse("1843101478742259481289"),BigInteger.Parse("143145930384321475601601"),BigInteger.Parse("11846611289341729822881601"),BigInteger.Parse("1040750126963789832859930569") };
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
public class A230114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230114Inst Instance=new A230114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230115
{
public static readonly long[] Value={ 5L,7L,13L,27L,37L,51L,61L,62L,73L,74L,91L,115L,123L,146L,153L,157L,164L,187L,188L,193L,206L,235L,245L,267L,274L,277L,278L,284L,291L,313L,355L,356L,362L,369L,386L,397L,403L,411L,421L,422L,423L,425L,427L,428L,451L,457L,538L,541L,605L,613L,637L,657L,661L,667L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230115Inst : IEnumerable<long>
{
public static readonly long[] Value=A230115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230115.Bytes);
public long this[int i]=>Value[i];

public static A230115Inst Instance=new A230115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230116
{
public static readonly long[] Value={ 1L,3L,7L,9L,17L,51L,127L,129L,257L,771L,1799L,2313L,4369L,13107L,32767L,32769L,65537L,196611L,458759L,589833L,1114129L,3342387L,8323199L,8454273L,16843009L,50529027L,117901063L,151587081L,286331153L,858993459L,2147483647L,2147483649L,4294967297L,12884901891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230116Inst : IEnumerable<long>
{
public static readonly long[] Value=A230116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230116.Bytes);
public long this[int i]=>Value[i];

public static A230116Inst Instance=new A230116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230117
{
public static readonly long[] Value={ 3L,11L,23L,41L,83L,131L,179L,191L,233L,239L,251L,281L,293L,359L,419L,431L,443L,491L,593L,641L,653L,683L,719L,761L,911L,953L,1019L,1031L,1049L,1103L,1223L,1229L,1289L,1409L,1439L,1451L,1481L,1511L,1601L,1811L,1889L,1901L,1931L,1973L,2003L,2039L,2069L,2141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230117Inst : IEnumerable<long>
{
public static readonly long[] Value=A230117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230117.Bytes);
public long this[int i]=>Value[i];

public static A230117Inst Instance=new A230117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230118
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,18L,29L,42L,61L,87L,122L,167L,229L,306L,409L,538L,705L,915L,1182L,1509L,1927L,2438L,3075L,3854L,4814L,5985L,7416L,9144L,11253L,13784L,16845L,20512L,24922L,30179L,36470L,43939L,52841L,63378L,75864L,90605L,108022L,128496L,152603L,180865L,214044L,252826L,298192L,351108L,412832L,484632L,568157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230118Inst : IEnumerable<long>
{
public static readonly long[] Value=A230118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230118.Bytes);
public long this[int i]=>Value[i];

public static A230118Inst Instance=new A230118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230119
{
public static readonly long[] Value={ 3L,9L,23L,47L,91L,169L,291L,494L,815L,1295L,2043L,3155L,4775L,7165L,10599L,15458L,22455L,32145L,45659L,64519L,90247L,125493L,173515L,238153L,325423L,442169L,597575L,804203L,1077283L,1436593L,1908571L,2525611L,3329391L,4373969L,5726611L,7472763L,9721983L,12608475L,16305179L,21027921L,27043631L,34689187L,44385995L,56652421L,72137483L,91645813L,116167379L,146932651L,185456419L,233594265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230119Inst : IEnumerable<long>
{
public static readonly long[] Value=A230119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230119.Bytes);
public long this[int i]=>Value[i];

public static A230119Inst Instance=new A230119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230120
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,3L,2L,1L,2L,5L,1L,6L,3L,0L,4L,7L,2L,9L,3L,4L,5L,10L,3L,8L,6L,5L,7L,13L,3L,15L,8L,6L,8L,12L,4L,18L,9L,7L,8L,20L,4L,20L,10L,5L,11L,23L,5L,24L,9L,8L,12L,25L,6L,19L,14L,11L,14L,29L,5L,30L,15L,12L,16L,22L,7L,33L,15L,12L,12L,34L,8L,36L,18L,10L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230120Inst : IEnumerable<long>
{
public static readonly long[] Value=A230120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230120.Bytes);
public long this[int i]=>Value[i];

public static A230120Inst Instance=new A230120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230121
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,2L,1L,1L,0L,2L,1L,2L,1L,2L,3L,2L,2L,6L,1L,3L,5L,1L,2L,3L,5L,2L,1L,3L,3L,3L,4L,3L,8L,2L,5L,11L,2L,5L,8L,4L,6L,4L,9L,4L,6L,5L,4L,6L,3L,8L,8L,5L,8L,10L,7L,7L,11L,8L,6L,7L,8L,5L,9L,7L,6L,8L,7L,7L,8L,13L,9L,11L,10L,7L,22L,9L,10L,13L,3L,6L,10L,8L,17L,12L,7L,9L,10L,16L,6L,18L,18L,10L,15L,9L,12L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230121Inst : IEnumerable<long>
{
public static readonly long[] Value=A230121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230121.Bytes);
public long this[int i]=>Value[i];

public static A230121Inst Instance=new A230121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230122
{
public static readonly long[] Value={ 1L,1L,3L,8L,23L,67L,199L,600L,1834L,5674L,17743L,56011L,178301L,571812L,1845913L,5993985L,19565770L,64168531L,211343740L,698753053L,2318315786L,7716186315L,25757105801L,86208990248L,289253059765L,972729789813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230122Inst : IEnumerable<long>
{
public static readonly long[] Value=A230122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230122.Bytes);
public long this[int i]=>Value[i];

public static A230122Inst Instance=new A230122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230123
{
public static readonly long[] Value={ 1L,23L,34L,12L,56L,243L,144L,320L,2432L,1728L,1024L,17920L,20736L,12288L,57344L,248832L,147456L,327680L,2490368L,1769472L,1048576L,18350080L,21233664L,12582912L,58720256L,254803968L,150994944L,335544320L,2550136832L,1811939328L,1073741824L,18790481920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230123Inst : IEnumerable<long>
{
public static readonly long[] Value=A230123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230123.Bytes);
public long this[int i]=>Value[i];

public static A230123Inst Instance=new A230123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230124
{
public static readonly long[] Value={ 3L,5L,6L,10L,15L,17L,23L,29L,30L,33L,34L,39L,43L,46L,51L,53L,57L,58L,65L,66L,71L,77L,78L,83L,85L,86L,89L,95L,101L,102L,105L,106L,111L,113L,114L,119L,123L,129L,130L,139L,141L,142L,149L,154L,159L,163L,165L,166L,170L,177L,178L,183L,187L,190L,195L,197L,201L,202L,209L,210L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230124Inst : IEnumerable<long>
{
public static readonly long[] Value=A230124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230124.Bytes);
public long this[int i]=>Value[i];

public static A230124Inst Instance=new A230124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230125
{
public static readonly BigInteger[] Value={ 55L,89L,233L,377L,5702887L,9227465L,24157817L,39088169L,7778742049L,86267571272L,139583862445L,591286729879L,956722026041L,2504730781961L,4052739537881L,61305790721611591L,99194853094755497L,259695496911122585L,420196140727489673L,BigInteger.Parse("135301852344706746049") };
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
public class A230125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230125Inst Instance=new A230125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230126
{
public static readonly long[] Value={ 1L,4L,17L,82L,396L,1905L,9165L,44088L,212082L,1020218L,4907734L,23608545L,113568371L,546318080L,2628050766L,12642178765L,60814914995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230126Inst : IEnumerable<long>
{
public static readonly long[] Value=A230126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230126.Bytes);
public long this[int i]=>Value[i];

public static A230126Inst Instance=new A230126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230127
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,20L,26L,38L,42L,52L,56L,56L,48L,42L,32L,22L,10L,4L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230127Inst : IEnumerable<long>
{
public static readonly long[] Value=A230127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230127.Bytes);
public long this[int i]=>Value[i];

public static A230127Inst Instance=new A230127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230128
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,2L,3L,3L,2L,4L,4L,4L,4L,5L,5L,6L,5L,6L,7L,7L,6L,8L,8L,8L,8L,9L,9L,10L,9L,10L,11L,11L,10L,12L,12L,12L,12L,13L,13L,14L,13L,14L,15L,15L,14L,16L,16L,16L,16L,17L,17L,18L,17L,18L,19L,19L,18L,20L,20L,20L,20L,21L,21L,22L,21L,22L,23L,23L,22L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230128Inst : IEnumerable<long>
{
public static readonly long[] Value=A230128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230128.Bytes);
public long this[int i]=>Value[i];

public static A230128Inst Instance=new A230128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230129
{
public static readonly BigInteger[] Value={ 2L,24L,274L,3204L,39420L,514296L,7137818L,105318770L,1649355338L,27356466626L,479446719522L,8858271760146L,172151975433756L,3511580514677006L,75032190827549478L,1676210011258705592L,BigInteger.Parse("39082263260517298658"),BigInteger.Parse("949481770375318700914"),BigInteger.Parse("23998362106238648271276") };
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
public class A230129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230129Inst Instance=new A230129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230130
{
public static readonly BigInteger[] Value={ 2L,28L,362L,4720L,64020L,913440L,13760472L,219040274L,3681354658L,65231186514L,1216489698082L,23832126613268L,489566931234322L,10526180908026522L,236475437787567496L,5541690642862917134L,BigInteger.Parse("135258139216049657102"),BigInteger.Parse("3433304061341792767884"),BigInteger.Parse("90508485528963754208076") };
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
public class A230130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230130Inst Instance=new A230130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230131
{
public static readonly BigInteger[] Value={ 2L,32L,462L,6644L,98472L,1523808L,24744720L,422335056L,7575963254L,142706934722L,2819192544786L,58323311592602L,1261634626792744L,28492765388656632L,670804322638496378L,16439609940896532018UL,BigInteger.Parse("418816100433422180196"),BigInteger.Parse("11077009292500273732470") };
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
public class A230131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230131Inst Instance=new A230131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230132
{
public static readonly BigInteger[] Value={ 2L,36L,574L,9024L,145080L,2419872L,42129360L,767370240L,14631376500L,291914163322L,6088804487138L,132624737931726L,3012939864521998L,71296697740927172L,1755099895042102380L,BigInteger.Parse("44889002698811118240"),BigInteger.Parse("1191389820174200208622"),BigInteger.Parse("32774409073391657243622") };
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
public class A230132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230132Inst Instance=new A230132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230133
{
public static readonly BigInteger[] Value={ 2L,40L,698L,11908L,206388L,3690960L,68577600L,1327697280L,26812356480L,564796979240L,12403183337690L,283718956204402L,6753363090218970L,167092903876164794L,4292602805804464576L,BigInteger.Parse("114374394103260000000"),BigInteger.Parse("3157276569203744863200"),BigInteger.Parse("90202107365906127228000") };
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
public class A230133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230133Inst Instance=new A230133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230134
{
public static readonly BigInteger[] Value={ 1L,1L,6L,41L,456L,6301L,108576L,2207981L,52012416L,1390239481L,41593598976L,1376769180401L,49955931795456L,1971671764875541L,84095262825824256L,3854514200269774901L,BigInteger.Parse("188942180401957502976"),BigInteger.Parse("9863099585213327293681"),BigInteger.Parse("546266997049408050364416"),BigInteger.Parse("31993839349571172423492281") };
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
public class A230134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230134Inst Instance=new A230134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230135
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230135Inst : IEnumerable<long>
{
public static readonly long[] Value=A230135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230135.Bytes);
public long this[int i]=>Value[i];

public static A230135Inst Instance=new A230135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230136
{
public static readonly long[] Value={ 48L,240L,480L,1440L,1680L,2640L,5040L,6720L,7920L,10560L,12480L,13680L,18720L,21840L,28560L,31200L,32640L,34320L,36960L,44880L,48720L,53040L,63840L,71760L,77520L,87360L,92400L,100320L,115920L,147840L,187680L,201600L,215280L,236640L,244800L,257040L,277200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230136Inst : IEnumerable<long>
{
public static readonly long[] Value=A230136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230136.Bytes);
public long this[int i]=>Value[i];

public static A230136Inst Instance=new A230136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230137
{
public static readonly long[] Value={ 0L,2L,6L,18L,44L,110L,252L,588L,1304L,2934L,6380L,14036L,30120L,65260L,138712L,297240L,627248L,1332902L,2796876L,5904516L,12333320L,25899972L,53897096L,112693928L,233776464L,487034300L,1007623032L,2092755528L,4319728784L,8948009624L,18432890160L,38094639664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230137Inst : IEnumerable<long>
{
public static readonly long[] Value=A230137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230137.Bytes);
public long this[int i]=>Value[i];

public static A230137Inst Instance=new A230137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230138
{
public static readonly long[] Value={ 5L,11L,17L,29L,59L,71L,101L,137L,149L,179L,197L,227L,281L,311L,431L,599L,617L,641L,809L,821L,857L,1151L,1277L,1319L,1451L,1481L,1487L,1607L,1667L,1697L,1997L,2027L,2081L,2111L,2129L,2339L,2657L,2711L,2789L,3167L,3329L,3371L,3461L,3557L,3767L,3917L,3929L,4049L,4217L,4259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230138Inst : IEnumerable<long>
{
public static readonly long[] Value=A230138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230138.Bytes);
public long this[int i]=>Value[i];

public static A230138Inst Instance=new A230138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230139
{
public static readonly long[] Value={ 3L,5L,7L,11L,31L,101L,887L,4861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230139Inst : IEnumerable<long>
{
public static readonly long[] Value=A230139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230139.Bytes);
public long this[int i]=>Value[i];

public static A230139Inst Instance=new A230139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230140
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,2L,3L,1L,2L,2L,2L,3L,3L,4L,2L,3L,2L,3L,3L,3L,4L,2L,5L,2L,6L,3L,6L,5L,4L,5L,3L,5L,5L,8L,7L,6L,5L,6L,5L,5L,7L,6L,8L,4L,6L,5L,6L,7L,9L,8L,8L,5L,7L,6L,8L,10L,6L,10L,4L,8L,6L,6L,10L,6L,9L,5L,6L,5L,7L,7L,9L,6L,7L,8L,5L,10L,6L,9L,6L,6L,7L,4L,7L,7L,9L,6L,5L,5L,4L,6L,5L,6L,5L,5L,6L,4L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230140Inst : IEnumerable<long>
{
public static readonly long[] Value=A230140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230140.Bytes);
public long this[int i]=>Value[i];

public static A230140Inst Instance=new A230140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230141
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,4L,5L,3L,2L,3L,4L,4L,5L,6L,5L,3L,5L,4L,4L,2L,4L,6L,2L,3L,2L,6L,9L,8L,8L,5L,5L,4L,5L,10L,14L,10L,12L,6L,11L,7L,9L,13L,6L,11L,3L,9L,7L,8L,14L,6L,11L,4L,4L,8L,9L,15L,15L,7L,14L,3L,6L,13L,10L,19L,6L,6L,12L,5L,10L,8L,7L,16L,6L,10L,4L,7L,19L,11L,13L,3L,12L,5L,6L,13L,5L,12L,7L,8L,4L,5L,6L,10L,6L,4L,6L,4L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230141Inst : IEnumerable<long>
{
public static readonly long[] Value=A230141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230141.Bytes);
public long this[int i]=>Value[i];

public static A230141Inst Instance=new A230141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230142
{
public static readonly BigInteger[] Value={ 16L,256L,5632L,1048576L,80543744L,18185977856L,2823575044096L,4608812904349696L,1194823452775677952L,BigInteger.Parse("766890677854432919552"),BigInteger.Parse("298370458295691856838656"),BigInteger.Parse("184465173199612912007643136"),BigInteger.Parse("301475731054794304317414178816"),BigInteger.Parse("381273851270136749855228154609664") };
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
public class A230142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230142Inst Instance=new A230142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230143
{
public static readonly BigInteger[] Value={ 3L,75L,1785L,333795L,25638459L,5788790007L,898772045457L,1467030741832227L,380324118068556519L,BigInteger.Parse("244108884436744360605"),BigInteger.Parse("94974266622893811200463"),BigInteger.Parse("58717088286185620331978925"),BigInteger.Parse("95962705639251788100721754775"),BigInteger.Parse("121363236202656183485569513082175") };
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
public class A230143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230143Inst Instance=new A230143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230144
{
public static readonly BigInteger[] Value={ 8L,224L,1856L,1048064L,80542720L,18185973760L,2823575035904L,4608812904218624L,398274484258471936L,BigInteger.Parse("766890677854431870976"),BigInteger.Parse("298370458295691854741504"),BigInteger.Parse("553395519598838736006152192"),BigInteger.Parse("301475731054794304317380624384"),BigInteger.Parse("381273851270136749855228020391936") };
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
public class A230144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230144Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230144.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230144Inst Instance=new A230144Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230145
{
public static readonly BigInteger[] Value={ 3L,75L,595L,333795L,25638459L,5788790007L,898772045457L,1467030741832227L,126774706022852173L,BigInteger.Parse("244108884436744360605"),BigInteger.Parse("94974266622893811200463"),BigInteger.Parse("176151264858556860995936775"),BigInteger.Parse("95962705639251788100721754775"),BigInteger.Parse("121363236202656183485569513082175") };
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
public class A230145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230145Inst Instance=new A230145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230146
{
public static readonly long[] Value={ 1L,2L,3L,6L,17L,19L,77L,121L,167L,1413L,1550L,1882L,1905L,2917L,12584L,14990L,20640L,25730L,27336L,28023L,93554L,106600L,127318L,134871L,295621L,669047L,1000875L,1178689L,1208481L,2620546L,6427781L,9755037L,9863644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230146Inst : IEnumerable<long>
{
public static readonly long[] Value=A230146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230146.Bytes);
public long this[int i]=>Value[i];

public static A230146Inst Instance=new A230146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230147
{
public static readonly long[] Value={ 2L,3L,5L,11L,15L,27L,33L,37L,65L,67L,75L,77L,95L,137L,147L,151L,153L,169L,191L,219L,247L,249L,251L,291L,297L,303L,307L,319L,415L,429L,441L,465L,495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230147Inst : IEnumerable<long>
{
public static readonly long[] Value=A230147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230147.Bytes);
public long this[int i]=>Value[i];

public static A230147Inst Instance=new A230147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230148
{
public static readonly long[] Value={ 397575L,3145425129L,7096702977L,53164445037705L,130468907286855L,1229923663366167L,2774951736355071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230148Inst : IEnumerable<long>
{
public static readonly long[] Value=A230148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230148.Bytes);
public long this[int i]=>Value[i];

public static A230148Inst Instance=new A230148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230149
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,2L,1L,2L,2L,3L,3L,2L,3L,4L,4L,4L,3L,5L,5L,5L,5L,5L,6L,6L,6L,7L,6L,7L,7L,8L,8L,7L,8L,9L,9L,9L,8L,10L,10L,10L,10L,10L,11L,11L,11L,12L,11L,12L,12L,13L,13L,12L,13L,14L,14L,14L,13L,15L,15L,15L,15L,15L,16L,16L,16L,17L,16L,17L,17L,18L,18L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230149Inst : IEnumerable<long>
{
public static readonly long[] Value=A230149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230149.Bytes);
public long this[int i]=>Value[i];

public static A230149Inst Instance=new A230149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230150
{
public static readonly long[] Value={ 1L,4L,11L,24L,25L,47L,48L,49L,50L,80L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230150Inst : IEnumerable<long>
{
public static readonly long[] Value=A230150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230150.Bytes);
public long this[int i]=>Value[i];

public static A230150Inst Instance=new A230150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230151
{
public static readonly long[] Value={ 8L,1L,9L,1L,7L,2L,5L,1L,3L,3L,9L,6L,1L,6L,4L,4L,3L,9L,6L,9L,9L,5L,7L,1L,1L,8L,8L,3L,4L,2L,4L,2L,7L,0L,4L,0L,3L,4L,8L,4L,9L,7L,8L,3L,2L,5L,5L,3L,7L,1L,2L,9L,6L,5L,6L,6L,7L,6L,8L,0L,2L,5L,3L,1L,6L,7L,4L,2L,8L,6L,0L,9L,3L,3L,0L,8L,7L,1L,3L,7L,0L,3L,1L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230151Inst : IEnumerable<long>
{
public static readonly long[] Value=A230151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230151.Bytes);
public long this[int i]=>Value[i];

public static A230151Inst Instance=new A230151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230152
{
public static readonly long[] Value={ 8L,5L,6L,6L,7L,4L,8L,8L,3L,8L,5L,4L,5L,0L,2L,8L,7L,4L,8L,5L,2L,3L,2L,4L,8L,1L,5L,3L,1L,2L,4L,3L,4L,3L,6L,9L,8L,3L,1L,3L,9L,9L,9L,4L,5L,4L,9L,3L,7L,5L,2L,6L,2L,5L,5L,7L,6L,4L,1L,2L,8L,1L,0L,3L,4L,6L,7L,9L,8L,4L,2L,4L,6L,2L,2L,9L,0L,4L,3L,6L,2L,1L,1L,0L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230152Inst : IEnumerable<long>
{
public static readonly long[] Value=A230152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230152.Bytes);
public long this[int i]=>Value[i];

public static A230152Inst Instance=new A230152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230153
{
public static readonly long[] Value={ 8L,8L,1L,2L,7L,1L,4L,6L,1L,6L,3L,3L,5L,6L,9L,5L,9L,4L,4L,0L,7L,6L,4L,9L,1L,6L,2L,8L,4L,1L,3L,7L,2L,0L,2L,5L,2L,7L,9L,1L,9L,3L,9L,7L,9L,3L,7L,8L,8L,9L,5L,2L,6L,3L,6L,0L,6L,7L,6L,3L,8L,4L,6L,9L,5L,7L,7L,6L,8L,7L,6L,8L,4L,6L,8L,6L,3L,2L,4L,6L,7L,3L,5L,5L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230153Inst : IEnumerable<long>
{
public static readonly long[] Value=A230153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230153.Bytes);
public long this[int i]=>Value[i];

public static A230153Inst Instance=new A230153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230154
{
public static readonly long[] Value={ 8L,9L,8L,6L,5L,3L,7L,1L,2L,6L,2L,8L,6L,9L,9L,2L,9L,3L,2L,6L,0L,8L,7L,5L,7L,2L,2L,0L,4L,6L,8L,0L,5L,8L,8L,6L,2L,6L,0L,4L,4L,8L,2L,2L,0L,0L,9L,3L,4L,3L,9L,6L,9L,6L,6L,8L,5L,5L,3L,1L,5L,5L,6L,5L,4L,7L,3L,2L,5L,8L,4L,7L,0L,1L,7L,2L,1L,9L,7L,8L,2L,4L,6L,8L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230154Inst : IEnumerable<long>
{
public static readonly long[] Value=A230154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230154.Bytes);
public long this[int i]=>Value[i];

public static A230154Inst Instance=new A230154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230155
{
public static readonly long[] Value={ 9L,1L,1L,5L,9L,2L,3L,5L,3L,4L,8L,2L,0L,5L,4L,9L,1L,8L,6L,2L,8L,6L,7L,3L,6L,7L,2L,4L,9L,4L,0L,5L,0L,1L,7L,7L,3L,7L,5L,8L,8L,4L,6L,9L,4L,3L,6L,1L,4L,1L,3L,9L,4L,6L,9L,5L,5L,7L,6L,2L,6L,5L,3L,9L,2L,3L,4L,4L,3L,4L,8L,8L,2L,5L,2L,4L,0L,4L,1L,2L,8L,9L,8L,9L,5L,8L,0L,1L,2L,7L,5L,4L,7L,3L,9L,0L,7L,0L,9L,4L,3L,0L,0L,0L,1L,9L,6L,8L,6L,8L,7L,3L,6L,8L,9L,5L,6L,5L,8L,7L,3L,2L,9L,6L,8L,1L,6L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230155Inst : IEnumerable<long>
{
public static readonly long[] Value=A230155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230155.Bytes);
public long this[int i]=>Value[i];

public static A230155Inst Instance=new A230155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230156
{
public static readonly long[] Value={ 9L,2L,1L,5L,9L,9L,3L,1L,9L,6L,3L,3L,9L,8L,3L,0L,0L,6L,2L,9L,9L,4L,3L,0L,3L,1L,5L,2L,0L,1L,9L,6L,9L,3L,9L,4L,2L,5L,3L,6L,8L,0L,3L,8L,4L,2L,5L,3L,3L,7L,0L,7L,8L,9L,8L,7L,9L,6L,5L,4L,5L,1L,6L,4L,4L,4L,7L,1L,4L,5L,9L,4L,2L,4L,9L,1L,7L,4L,3L,0L,8L,2L,7L,9L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230156Inst : IEnumerable<long>
{
public static readonly long[] Value=A230156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230156.Bytes);
public long this[int i]=>Value[i];

public static A230156Inst Instance=new A230156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230157
{
public static readonly long[] Value={ 9L,2L,9L,5L,7L,0L,1L,2L,8L,2L,3L,2L,0L,2L,2L,8L,6L,4L,2L,0L,4L,4L,1L,3L,0L,3L,6L,9L,1L,4L,4L,6L,4L,1L,2L,5L,4L,3L,5L,3L,2L,5L,8L,5L,3L,0L,0L,2L,0L,2L,4L,8L,3L,3L,6L,3L,0L,2L,0L,5L,5L,4L,5L,2L,1L,5L,0L,9L,8L,7L,8L,5L,3L,0L,6L,5L,4L,2L,7L,2L,6L,2L,1L,3L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230157Inst : IEnumerable<long>
{
public static readonly long[] Value=A230157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230157.Bytes);
public long this[int i]=>Value[i];

public static A230157Inst Instance=new A230157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230158
{
public static readonly long[] Value={ 9L,3L,6L,0L,6L,9L,1L,1L,1L,0L,7L,7L,7L,5L,8L,3L,7L,8L,3L,9L,7L,1L,9L,1L,4L,8L,7L,5L,7L,0L,2L,9L,6L,2L,0L,3L,4L,3L,6L,0L,7L,1L,4L,7L,8L,2L,0L,6L,4L,8L,5L,0L,8L,4L,9L,9L,6L,5L,3L,3L,7L,2L,6L,8L,5L,5L,6L,3L,9L,5L,0L,6L,3L,9L,2L,7L,3L,5L,4L,3L,2L,6L,4L,9L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230158Inst : IEnumerable<long>
{
public static readonly long[] Value=A230158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230158.Bytes);
public long this[int i]=>Value[i];

public static A230158Inst Instance=new A230158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230159
{
public static readonly long[] Value={ 1L,1L,3L,4L,7L,2L,4L,1L,3L,8L,4L,0L,1L,5L,1L,9L,4L,9L,2L,6L,0L,5L,4L,4L,6L,0L,5L,4L,5L,0L,6L,4L,7L,2L,8L,4L,0L,2L,7L,9L,6L,6L,7L,2L,2L,6L,3L,8L,2L,8L,0L,1L,4L,8L,5L,9L,2L,5L,1L,4L,9L,5L,5L,1L,6L,6L,8L,2L,3L,6L,8L,9L,3L,9L,9L,9L,8L,4L,2L,6L,7L,1L,2L,7L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230159Inst : IEnumerable<long>
{
public static readonly long[] Value=A230159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230159.Bytes);
public long this[int i]=>Value[i];

public static A230159Inst Instance=new A230159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230160
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,7L,5L,6L,8L,4L,2L,7L,8L,7L,0L,5L,4L,7L,0L,6L,2L,9L,7L,0L,4L,0L,2L,0L,5L,7L,1L,0L,9L,2L,9L,3L,5L,6L,0L,6L,8L,5L,9L,2L,7L,1L,8L,5L,5L,2L,8L,3L,6L,8L,1L,4L,8L,5L,7L,0L,1L,6L,2L,8L,0L,0L,7L,1L,6L,6L,3L,3L,2L,5L,7L,9L,5L,2L,8L,4L,4L,3L,4L,5L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230160Inst : IEnumerable<long>
{
public static readonly long[] Value=A230160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230160.Bytes);
public long this[int i]=>Value[i];

public static A230160Inst Instance=new A230160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230161
{
public static readonly long[] Value={ 1L,0L,9L,6L,9L,8L,1L,5L,5L,7L,7L,9L,8L,5L,5L,9L,8L,1L,7L,9L,0L,8L,2L,7L,8L,9L,6L,7L,1L,6L,7L,5L,3L,7L,0L,8L,9L,5L,9L,2L,5L,3L,0L,1L,0L,8L,2L,1L,2L,7L,8L,6L,7L,1L,3L,8L,1L,2L,3L,2L,8L,8L,5L,1L,2L,4L,8L,5L,5L,8L,9L,8L,0L,5L,9L,9L,0L,1L,8L,4L,9L,3L,4L,7L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230161Inst : IEnumerable<long>
{
public static readonly long[] Value=A230161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230161.Bytes);
public long this[int i]=>Value[i];

public static A230161Inst Instance=new A230161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230162
{
public static readonly long[] Value={ 1L,0L,8L,5L,0L,7L,0L,2L,4L,5L,4L,9L,1L,4L,5L,0L,8L,2L,8L,3L,3L,6L,8L,9L,5L,8L,6L,4L,0L,9L,7L,3L,1L,4L,2L,3L,4L,0L,5L,0L,6L,5L,3L,6L,3L,1L,0L,3L,0L,8L,9L,6L,5L,8L,1L,4L,6L,8L,6L,1L,5L,5L,3L,3L,3L,6L,5L,1L,8L,0L,4L,9L,9L,4L,0L,1L,1L,5L,7L,1L,9L,9L,7L,4L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230162Inst : IEnumerable<long>
{
public static readonly long[] Value=A230162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230162.Bytes);
public long this[int i]=>Value[i];

public static A230162Inst Instance=new A230162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230163
{
public static readonly long[] Value={ 1L,0L,7L,5L,7L,6L,6L,0L,6L,6L,0L,8L,6L,8L,3L,7L,1L,5L,8L,0L,5L,9L,5L,9L,9L,5L,2L,4L,1L,6L,5L,2L,7L,5L,8L,2L,0L,6L,9L,2L,5L,3L,0L,2L,4L,7L,6L,3L,9L,2L,0L,3L,2L,7L,9L,4L,7L,7L,0L,6L,8L,3L,9L,4L,5L,4L,4L,4L,7L,2L,6L,2L,6L,9L,5L,8L,5L,8L,2L,1L,6L,1L,9L,3L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230163Inst : IEnumerable<long>
{
public static readonly long[] Value=A230163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230163.Bytes);
public long this[int i]=>Value[i];

public static A230163Inst Instance=new A230163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230164
{
public static readonly long[] Value={ 17296L,24016L,334144656L,358585488L,2955423888L,311063879024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230164Inst : IEnumerable<long>
{
public static readonly long[] Value=A230164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230164.Bytes);
public long this[int i]=>Value[i];

public static A230164Inst Instance=new A230164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230165
{
public static readonly long[] Value={ 6L,15L,42L,47058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230165Inst : IEnumerable<long>
{
public static readonly long[] Value=A230165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230165.Bytes);
public long this[int i]=>Value[i];

public static A230165Inst Instance=new A230165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230166
{
public static readonly long[] Value={ 1L,3L,15L,135L,819L,1365L,1485L,2295L,9009L,13923L,63855L,387387L,397575L,667275L,14381055L,16410735L,99558459L,271543725L,3145425129L,7096702977L,741585912975L,2148325363107L,4847048133291L,39206559148911L,53164445037705L,130468907286855L,1229923663366167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230166Inst : IEnumerable<long>
{
public static readonly long[] Value=A230166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230166.Bytes);
public long this[int i]=>Value[i];

public static A230166Inst Instance=new A230166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230167
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,2L,4L,4L,7L,7L,10L,10L,15L,14L,20L,19L,25L,24L,31L,31L,39L,37L,45L,44L,55L,53L,63L,61L,72L,71L,83L,81L,94L,91L,105L,103L,118L,115L,130L,128L,144L,141L,158L,155L,174L,170L,188L,185L,205L,202L,222L,218L,239L,235L,258L,254L,277L,272L,295L,292L,317L,312L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230167Inst : IEnumerable<long>
{
public static readonly long[] Value=A230167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230167.Bytes);
public long this[int i]=>Value[i];

public static A230167Inst Instance=new A230167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230168
{
public static readonly BigInteger[] Value={ 89L,179L,359L,719L,1439L,2879L,11519L,23039L,737279L,1474559L,2949119L,188743679L,12079595519L,24159191039L,3092376453119L,6184752906239L,810647932926689279L,BigInteger.Parse("25940733853654056959"),BigInteger.Parse("1740853180245066011576893439"),BigInteger.Parse("445658414142736898963684720639") };
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
public class A230168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230168Inst Instance=new A230168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230169
{
public static readonly BigInteger[] Value={ 0L,27L,3787L,4722977L,49754476927L,4381081731832923L,BigInteger.Parse("3274958849115023706081") };
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
public class A230169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230169Inst Instance=new A230169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230170
{
public static readonly long[] Value={ 3L,27L,193L,1407L,10211L,73417L,530771L,3841171L,27770777L,200748959L,1451396131L,10493696945L,75868350707L,548518150083L,3965728577777L,28671821546207L,207294285260867L,1498715914818009L,10835559670997043L,78339967436748115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230170Inst : IEnumerable<long>
{
public static readonly long[] Value=A230170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230170.Bytes);
public long this[int i]=>Value[i];

public static A230170Inst Instance=new A230170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230171
{
public static readonly BigInteger[] Value={ 3L,193L,3787L,78849L,1637019L,33908253L,704822331L,14643857893L,304104787011L,6315931613849L,131183171878903L,2724650132436217L,56590036701710599L,1175359025263665849L,BigInteger.Parse("24411897444501278899"),BigInteger.Parse("507028430780683682221") };
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
public class A230171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230171Inst Instance=new A230171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230172
{
public static readonly BigInteger[] Value={ 9L,1407L,78849L,4722977L,284444079L,17072965263L,1027868078181L,61861526624839L,3721702070420191L,223920929460093089L,13473042937456532657UL,BigInteger.Parse("810647385075641076549"),BigInteger.Parse("48774886700839338028985"),BigInteger.Parse("2934683063063203660000047") };
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
public class A230172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230172Inst Instance=new A230172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230173
{
public static readonly BigInteger[] Value={ 15L,10211L,1637019L,284444079L,49754476927L,8666440899433L,1514677019365483L,264644708761844781L,BigInteger.Parse("46219801332800121297"),BigInteger.Parse("8072805292655435557305"),BigInteger.Parse("1410066823439995419927677"),BigInteger.Parse("246292114172239867332919195") };
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
public class A230173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230173Inst Instance=new A230173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230174
{
public static readonly BigInteger[] Value={ 33L,73417L,33908253L,17072965263L,8666440899433L,4381081731832923L,2222884630214739547L,BigInteger.Parse("1127411488744987043611"),BigInteger.Parse("571557326062169407226463"),BigInteger.Parse("289782351408303721961315329"),BigInteger.Parse("146927686537779809297483679829") };
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
public class A230174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230174Inst Instance=new A230174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230175
{
public static readonly BigInteger[] Value={ 63L,530771L,704822331L,1027868078181L,1514677019365483L,2222884630214739547L,BigInteger.Parse("3274958849115023706081"),BigInteger.Parse("4822680345112751878337083"),BigInteger.Parse("7098618594645882579322969411"),BigInteger.Parse("10449577732703043756255819628725") };
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
public class A230175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230175Inst Instance=new A230175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230176
{
public static readonly long[] Value={ 0L,3L,3L,3L,27L,3L,9L,193L,193L,9L,15L,1407L,3787L,1407L,15L,33L,10211L,78849L,78849L,10211L,33L,63L,73417L,1637019L,4722977L,1637019L,73417L,63L,129L,530771L,33908253L,284444079L,284444079L,33908253L,530771L,129L,255L,3841171L,704822331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230176Inst : IEnumerable<long>
{
public static readonly long[] Value=A230176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230176.Bytes);
public long this[int i]=>Value[i];

public static A230176Inst Instance=new A230176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230177
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,240L,464L,866L,1642L,3048L,5720L,10642L,19868L,36894L,68722L,127630L,237324L,440594L,818584L,1519802L,2822630L,5240262L,9730478L,18065252L,33542006L,62272196L,115616582L,214646190L,398507348L,739840164L,1373551484L,2550032248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230177Inst : IEnumerable<long>
{
public static readonly long[] Value=A230177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230177.Bytes);
public long this[int i]=>Value[i];

public static A230177Inst Instance=new A230177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230178
{
public static readonly BigInteger[] Value={ 0L,9L,231L,73857L,133265847L,1576417829097L,117863748242661711L,BigInteger.Parse("56231441027001164749647"),BigInteger.Parse("170772883022204028026156020737"),BigInteger.Parse("3303166614870365380110300414534929643") };
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
public class A230178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230178Inst Instance=new A230178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230179
{
public static readonly long[] Value={ 3L,27L,231L,1971L,16815L,143451L,1223799L,10440387L,89068287L,759853035L,6482404167L,55302225363L,471790411599L,4024904802939L,34336981580055L,292933215008739L,2499051008758431L,21319726218790923L,181881331934084583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230179Inst : IEnumerable<long>
{
public static readonly long[] Value=A230179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230179.Bytes);
public long this[int i]=>Value[i];

public static A230179Inst Instance=new A230179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230180
{
public static readonly BigInteger[] Value={ 9L,159L,3411L,73857L,1603431L,34825803L,756450105L,16430979183L,356900507139L,7752307003185L,168389408761527L,3657619992450939L,79447894698990441L,1725703595660236095L,BigInteger.Parse("37484352623641494963"),BigInteger.Parse("814205113293390761697") };
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
public class A230180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230180Inst Instance=new A230180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230181
{
public static readonly BigInteger[] Value={ 15L,825L,44487L,2432241L,133265847L,7303192425L,400233701367L,21933865129257L,1202033948127351L,65874647188725513L,3610105315787830647L,BigInteger.Parse("197843342593747917321"),BigInteger.Parse("10842339706191376541559"),BigInteger.Parse("594188961646805379691401") };
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
public class A230181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230181Inst Instance=new A230181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230182
{
public static readonly BigInteger[] Value={ 33L,4395L,596973L,82359177L,11393567289L,1576417829097L,218117038953009L,30179260908320577L,4175684607609841059L,BigInteger.Parse("577759089171442494555"),BigInteger.Parse("79940320493798468104653"),BigInteger.Parse("11060760378778721204329065") };
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
public class A230182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230182Inst Instance=new A230182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230183
{
public static readonly BigInteger[] Value={ 63L,23307L,7957785L,2770525761L,967087903539L,337613109419463L,117863748242661711L,BigInteger.Parse("41147363351637663933"),BigInteger.Parse("14364941208682152185085"),BigInteger.Parse("5014939538324891181282729"),BigInteger.Parse("1750763768994816766061338911") };
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
public class A230183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230183Inst Instance=new A230183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230184
{
public static readonly long[] Value={ 0L,3L,0L,3L,9L,0L,9L,27L,33L,0L,15L,159L,231L,129L,0L,33L,825L,3411L,1971L,513L,0L,63L,4395L,44487L,73857L,16815L,2049L,0L,129L,23307L,596973L,2432241L,1603431L,143451L,8193L,0L,255L,123729L,7957785L,82359177L,133265847L,34825803L,1223799L,32769L,0L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230184Inst : IEnumerable<long>
{
public static readonly long[] Value=A230184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230184.Bytes);
public long this[int i]=>Value[i];

public static A230184Inst Instance=new A230184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230185
{
public static readonly long[] Value={ 0L,9L,27L,159L,825L,4395L,23307L,123729L,656715L,3485775L,18502017L,98206299L,521266155L,2766812505L,14685878427L,77950719519L,413752211145L,2196142553835L,11656837079787L,61872964697889L,328413594039435L,1743176349744015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230185Inst : IEnumerable<long>
{
public static readonly long[] Value=A230185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230185.Bytes);
public long this[int i]=>Value[i];

public static A230185Inst Instance=new A230185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230186
{
public static readonly long[] Value={ 0L,33L,231L,3411L,44487L,596973L,7957785L,106248147L,1418070843L,18928121865L,252644742093L,3372208415751L,45010959441111L,600789299156241L,8019108619691037L,107036033204372163L,1428676544542445175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230186Inst : IEnumerable<long>
{
public static readonly long[] Value=A230186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230186.Bytes);
public long this[int i]=>Value[i];

public static A230186Inst Instance=new A230186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230187
{
public static readonly BigInteger[] Value={ 0L,129L,1971L,73857L,2432241L,82359177L,2770525761L,93340154655L,3143682463065L,105885454704267L,3566387657985771L,120121801796361177L,4045897974546191799L,BigInteger.Parse("136272446957010253599"),BigInteger.Parse("4589878342395006746985"),BigInteger.Parse("154594591461184687863333") };
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
public class A230187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230187Inst Instance=new A230187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230188
{
public static readonly BigInteger[] Value={ 0L,513L,16815L,1603431L,133265847L,11393567289L,967087903539L,82226647665621L,6988859258823513L,594060143921819223L,BigInteger.Parse("50495027179295395167"),BigInteger.Parse("4292081456142986073615"),BigInteger.Parse("364827090034511080822419") };
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
public class A230188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230188Inst Instance=new A230188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230189
{
public static readonly BigInteger[] Value={ 0L,2049L,143451L,34825803L,7303192425L,1576417829097L,337613109419463L,72442679020274343L,15538191696598121541UL,BigInteger.Parse("3333031870313982444195"),BigInteger.Parse("714944148431332304491227"),BigInteger.Parse("153357839247813109681299999") };
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
public class A230189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230189Inst Instance=new A230189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230190
{
public static readonly BigInteger[] Value={ 0L,8193L,1223799L,756450105L,400233701367L,218117038953009L,117863748242661711L,BigInteger.Parse("63824360296979648967"),BigInteger.Parse("34546668873829672101987"),BigInteger.Parse("18700870126913632045893531"),BigInteger.Parse("10123031708751736005223316745") };
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
public class A230190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230190Inst Instance=new A230190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230191
{
public static readonly long[] Value={ 9L,2L,1L,2L,9L,2L,0L,2L,2L,9L,3L,4L,0L,9L,0L,7L,8L,0L,9L,1L,3L,4L,0L,8L,4L,4L,9L,9L,6L,1L,6L,0L,4L,7L,1L,6L,4L,1L,7L,0L,8L,0L,7L,8L,9L,0L,9L,3L,0L,3L,0L,2L,4L,1L,0L,9L,5L,5L,0L,0L,2L,8L,6L,4L,3L,3L,8L,6L,1L,8L,0L,9L,5L,0L,2L,7L,1L,6L,5L,1L,8L,1L,1L,6L,5L,0L,9L,9L,2L,5L,3L,9L,1L,3L,1L,1L,6L,1L,5L,9L,5L,5L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230191Inst : IEnumerable<long>
{
public static readonly long[] Value=A230191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230191.Bytes);
public long this[int i]=>Value[i];

public static A230191Inst Instance=new A230191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230192
{
public static readonly long[] Value={ 1L,1L,0L,5L,5L,5L,0L,4L,2L,7L,5L,2L,0L,9L,0L,8L,9L,3L,7L,0L,9L,6L,0L,9L,0L,1L,3L,9L,9L,5L,3L,9L,2L,5L,6L,5L,9L,7L,0L,0L,4L,9L,6L,9L,4L,6L,9L,1L,1L,6L,3L,6L,2L,8L,9L,3L,1L,4L,6L,0L,0L,3L,4L,3L,7L,2L,0L,6L,3L,4L,1L,7L,1L,4L,0L,3L,2L,5L,9L,8L,2L,1L,7L,3L,9L,8L,1L,1L,9L,1L,0L,4L,6L,9L,5L,7L,3L,9L,3L,9L,1L,4L,7L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230192Inst : IEnumerable<long>
{
public static readonly long[] Value=A230192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230192.Bytes);
public long this[int i]=>Value[i];

public static A230192Inst Instance=new A230192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230193
{
public static readonly long[] Value={ 3L,6L,9L,11L,12L,15L,18L,21L,22L,24L,27L,30L,33L,36L,39L,42L,44L,45L,48L,51L,54L,55L,57L,60L,63L,66L,69L,72L,75L,77L,78L,81L,84L,87L,88L,90L,93L,96L,99L,102L,105L,108L,110L,111L,114L,117L,120L,121L,123L,126L,129L,132L,135L,138L,141L,143L,144L,147L,150L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230193Inst : IEnumerable<long>
{
public static readonly long[] Value=A230193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230193.Bytes);
public long this[int i]=>Value[i];

public static A230193Inst Instance=new A230193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230194
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,3L,3L,3L,4L,3L,6L,5L,3L,3L,3L,5L,4L,4L,4L,2L,9L,10L,9L,7L,5L,12L,8L,2L,8L,6L,6L,7L,9L,4L,3L,10L,11L,2L,4L,6L,10L,9L,11L,9L,4L,10L,17L,9L,1L,4L,7L,6L,6L,6L,2L,5L,14L,13L,7L,5L,14L,6L,3L,5L,4L,12L,11L,14L,5L,2L,16L,11L,5L,9L,6L,8L,11L,23L,15L,3L,23L,18L,17L,9L,8L,20L,5L,10L,14L,3L,14L,15L,16L,9L,8L,24L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230194Inst : IEnumerable<long>
{
public static readonly long[] Value=A230194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230194.Bytes);
public long this[int i]=>Value[i];

public static A230194Inst Instance=new A230194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230195
{
public static readonly long[] Value={ 24L,30L,36L,42L,48L,54L,60L,66L,84L,96L,114L,120L,126L,150L,156L,198L,210L,270L,294L,330L,336L,390L,420L,462L,504L,510L,546L,570L,630L,714L,726L,756L,810L,840L,924L,930L,1008L,1014L,1056L,1134L,1386L,1428L,1554L,1638L,1680L,1716L,1734L,1848L,1890L,1950L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230195Inst : IEnumerable<long>
{
public static readonly long[] Value=A230195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230195.Bytes);
public long this[int i]=>Value[i];

public static A230195Inst Instance=new A230195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230196
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,2L,1L,2L,2L,1L,2L,3L,2L,3L,2L,3L,3L,4L,3L,3L,4L,4L,4L,5L,3L,5L,5L,5L,5L,5L,5L,6L,6L,6L,5L,7L,6L,7L,7L,6L,7L,8L,7L,8L,7L,8L,8L,9L,8L,8L,9L,9L,9L,10L,8L,10L,10L,10L,10L,10L,10L,11L,11L,11L,10L,12L,11L,12L,12L,11L,12L,13L,12L,13L,12L,13L,13L,14L,13L,13L,14L,14L,14L,15L,13L,15L,15L,15L,15L,15L,15L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230196Inst : IEnumerable<long>
{
public static readonly long[] Value=A230196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230196.Bytes);
public long this[int i]=>Value[i];

public static A230196Inst Instance=new A230196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230197
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,4L,4L,4L,3L,4L,4L,5L,5L,5L,5L,4L,5L,6L,6L,6L,6L,6L,5L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,8L,9L,9L,9L,9L,10L,10L,9L,10L,10L,10L,11L,11L,11L,10L,11L,11L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230197Inst : IEnumerable<long>
{
public static readonly long[] Value=A230197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230197.Bytes);
public long this[int i]=>Value[i];

public static A230197Inst Instance=new A230197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230198
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,4L,4L,4L,3L,4L,4L,4L,5L,5L,5L,5L,4L,5L,5L,6L,6L,6L,6L,6L,5L,6L,7L,7L,7L,7L,7L,7L,6L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,9L,10L,10L,10L,10L,10L,11L,11L,10L,11L,11L,11L,11L,12L,12L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230198Inst : IEnumerable<long>
{
public static readonly long[] Value=A230198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230198.Bytes);
public long this[int i]=>Value[i];

public static A230198Inst Instance=new A230198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230199
{
public static readonly long[] Value={ 2L,3L,5L,7L,2L,2L,5L,7L,10L,11L,7L,11L,13L,14L,16L,19L,22L,23L,19L,20L,5L,7L,8L,7L,8L,10L,13L,14L,11L,16L,17L,13L,17L,16L,17L,14L,17L,19L,20L,20L,25L,19L,22L,23L,28L,29L,7L,8L,10L,13L,14L,8L,13L,13L,14L,17L,19L,22L,16L,17L,19L,23L,20L,23L,22L,25L,22L,23L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230199Inst : IEnumerable<long>
{
public static readonly long[] Value=A230199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230199.Bytes);
public long this[int i]=>Value[i];

public static A230199Inst Instance=new A230199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230200
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,0L,3L,5L,8L,9L,9L,45L,63L,72L,98L,245L,392L,441L,81L,162L,0L,0L,0L,3L,4L,16L,28L,32L,27L,72L,81L,48L,112L,100L,125L,0L,108L,180L,216L,196L,441L,64L,256L,243L,648L,729L,0L,0L,0L,0L,0L,0L,45L,108L,144L,405L,720L,1152L,0L,225L,675L,1575L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230200Inst : IEnumerable<long>
{
public static readonly long[] Value=A230200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230200.Bytes);
public long this[int i]=>Value[i];

public static A230200Inst Instance=new A230200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230201
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,30L,32L,34L,36L,40L,42L,44L,46L,48L,50L,54L,58L,60L,64L,66L,68L,70L,72L,78L,80L,84L,90L,92L,94L,96L,98L,100L,102L,106L,108L,110L,114L,118L,120L,126L,128L,130L,132L,136L,138L,140L,144L,150L,156L,160L,162L,166L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230201Inst : IEnumerable<long>
{
public static readonly long[] Value=A230201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230201.Bytes);
public long this[int i]=>Value[i];

public static A230201Inst Instance=new A230201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230202
{
public static readonly long[] Value={ 1999L,2999L,4999L,8999L,13999L,25999L,32999L,35999L,41999L,49999L,52999L,56999L,59999L,70999L,71999L,73999L,77999L,79999L,85999L,94999L,98999L,100999L,101999L,104999L,107999L,133999L,134999L,136999L,137999L,139999L,143999L,157999L,161999L,164999L,172999L,179999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230202Inst : IEnumerable<long>
{
public static readonly long[] Value=A230202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230202.Bytes);
public long this[int i]=>Value[i];

public static A230202Inst Instance=new A230202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230203
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,17L,19L,21L,23L,25L,26L,27L,29L,31L,33L,35L,37L,38L,39L,41L,43L,45L,47L,49L,51L,52L,53L,55L,56L,57L,59L,61L,62L,63L,65L,67L,69L,71L,73L,74L,75L,76L,77L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,93L,95L,97L,99L,101L,103L,104L,105L,107L,109L,111L,112L,113L,115L,116L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230203Inst : IEnumerable<long>
{
public static readonly long[] Value=A230203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230203.Bytes);
public long this[int i]=>Value[i];

public static A230203Inst Instance=new A230203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230204
{
public static readonly long[] Value={ 1L,-2L,0L,1L,0L,1L,-2L,2L,0L,0L,0L,0L,-2L,0L,-1L,-2L,2L,0L,3L,0L,0L,2L,2L,-2L,0L,-2L,0L,-2L,-2L,0L,0L,0L,0L,1L,0L,0L,2L,2L,0L,1L,-2L,2L,-2L,0L,0L,0L,0L,0L,-2L,0L,2L,0L,-2L,0L,0L,2L,0L,0L,-2L,0L,1L,-2L,0L,-2L,2L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,2L,2L,-2L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230204Inst : IEnumerable<long>
{
public static readonly long[] Value=A230204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230204.Bytes);
public long this[int i]=>Value[i];

public static A230204Inst Instance=new A230204Inst();

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