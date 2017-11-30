using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A240913
{
public static readonly long[] Value={ 23L,25L,27L,29L,32L,34L,35L,37L,38L,43L,45L,47L,49L,52L,53L,54L,56L,57L,58L,59L,65L,67L,72L,73L,74L,75L,76L,78L,79L,83L,85L,87L,89L,92L,94L,95L,97L,98L,203L,205L,207L,209L,223L,225L,227L,229L,230L,232L,233L,234L,235L,236L,237L,238L,239L,243L,245L,247L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240913Inst : IEnumerable<long>
{
public static readonly long[] Value=A240913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240913.Bytes);
public long this[int i]=>Value[i];

public static A240913Inst Instance=new A240913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240914
{
public static readonly long[] Value={ 15L,26L,57L,77L,155L,187L,301L,551L,737L,1027L,1457L,1751L,3197L,3337L,5251L,6767L,7597L,8251L,13301L,22387L,24257L,25807L,32047L,34277L,41417L,41917L,48151L,61307L,63757L,66887L,68801L,85801L,103097L,112751L,136957L,141527L,145237L,179747L,180787L,196747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240914Inst : IEnumerable<long>
{
public static readonly long[] Value=A240914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240914.Bytes);
public long this[int i]=>Value[i];

public static A240914Inst Instance=new A240914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240915
{
public static readonly long[] Value={ 8L,9L,19L,59L,499L,1889L,17989L,39989L,199999L,4999999L,9899999L,389999999L,9199999999L,9959999999L,99499999999L,899999998999L,64999999999999L,59999999999999L,999999899999999L,9999979999999999L,99999999299999999L,699999989999999999L,5989999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240915Inst : IEnumerable<long>
{
public static readonly long[] Value=A240915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240915.Bytes);
public long this[int i]=>Value[i];

public static A240915Inst Instance=new A240915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240916
{
public static readonly long[] Value={ 0L,0L,3L,24L,158L,978L,5930L,35706L,214490L,1287450L,7725722L,46356378L,278142362L,1668862362L,10013190554L,60079176090L,360475122074L,2162850863514L,12977105443226L,77862633183642L,467175800150426L,2803054802999706L,16818328822192538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240916Inst : IEnumerable<long>
{
public static readonly long[] Value=A240916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240916.Bytes);
public long this[int i]=>Value[i];

public static A240916Inst Instance=new A240916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240917
{
public static readonly long[] Value={ 0L,10L,136L,1378L,12880L,117370L,1060696L,9559378L,86073760L,774781930L,6973391656L,62761587778L,564857478640L,5083726873690L,45753570561016L,411782221142578L,3706040248563520L,33354363011912650L,300189269431736776L,2701703431859199778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240917Inst : IEnumerable<long>
{
public static readonly long[] Value=A240917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240917.Bytes);
public long this[int i]=>Value[i];

public static A240917Inst Instance=new A240917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240918
{
public static readonly long[] Value={ 211L,257L,269L,461L,463L,467L,523L,547L,769L,829L,839L,947L,967L,983L,1129L,1213L,1259L,1327L,1361L,1381L,1429L,1433L,1453L,1487L,1619L,1667L,1721L,1723L,1741L,1811L,1847L,2143L,2153L,2161L,2243L,2251L,2311L,2339L,2357L,2371L,2473L,2531L,2591L,2593L,2617L,2659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240918Inst : IEnumerable<long>
{
public static readonly long[] Value=A240918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240918.Bytes);
public long this[int i]=>Value[i];

public static A240918Inst Instance=new A240918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240919
{
public static readonly long[] Value={ 9L,10L,10L,11L,11L,12L,13L,14L,15L,16L,18L,19L,22L,23L,27L,28L,33L,34L,40L,41L,49L,50L,59L,61L,63L,65L,68L,70L,77L,79L,87L,90L,93L,96L,100L,104L,104L,108L,109L,113L,122L,127L,127L,132L,141L,147L,148L,154L,157L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240919Inst : IEnumerable<long>
{
public static readonly long[] Value=A240919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240919.Bytes);
public long this[int i]=>Value[i];

public static A240919Inst Instance=new A240919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240920
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,29L,41L,43L,47L,61L,67L,83L,89L,101L,103L,107L,109L,127L,149L,163L,167L,181L,223L,227L,229L,241L,263L,269L,281L,283L,307L,347L,349L,367L,383L,389L,401L,409L,421L,443L,449L,461L,463L,467L,487L,503L,509L,521L,523L,541L,547L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240920Inst : IEnumerable<long>
{
public static readonly long[] Value=A240920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240920.Bytes);
public long this[int i]=>Value[i];

public static A240920Inst Instance=new A240920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240921
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,146L,1530L,19620L,297360L,5201784L,103146120L,2286181800L,56011087440L,1503057473280L,43844234353920L,1381310964633600L,46743301840435200L,1690919874777893760L,BigInteger.Parse("65116170597269151360"),BigInteger.Parse("2659604669692822051200"),BigInteger.Parse("114838104572526535200000"),BigInteger.Parse("5226654647185285702752000") };
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
public class A240921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240921.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240921Inst Instance=new A240921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240922
{
public static readonly long[] Value={ 1260L,1320L,1380L,1428L,1440L,1500L,1560L,1596L,1620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240922Inst : IEnumerable<long>
{
public static readonly long[] Value=A240922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240922.Bytes);
public long this[int i]=>Value[i];

public static A240922Inst Instance=new A240922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240923
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,3L,0L,4L,2L,0L,0L,1L,0L,3L,0L,6L,0L,2L,0L,7L,0L,1L,0L,6L,0L,0L,4L,9L,0L,0L,0L,10L,0L,2L,0L,8L,0L,9L,2L,12L,0L,3L,0L,0L,6L,7L,0L,7L,0L,7L,0L,15L,0L,8L,0L,16L,0L,0L,0L,12L,0L,9L,8L,24L,0L,5L,0L,19L,0L,15L,0L,14L,0L,3L,0L,21L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240923Inst : IEnumerable<long>
{
public static readonly long[] Value=A240923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240923.Bytes);
public long this[int i]=>Value[i];

public static A240923Inst Instance=new A240923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240924
{
public static readonly long[] Value={ 1L,4L,4L,7L,1L,1L,7L,4L,7L,1L,7L,4L,4L,7L,1L,7L,4L,7L,1L,1L,7L,4L,4L,1L,1L,4L,4L,7L,1L,1L,7L,4L,7L,1L,7L,4L,4L,7L,1L,7L,4L,7L,1L,1L,7L,4L,4L,1L,1L,4L,4L,7L,1L,1L,7L,4L,7L,1L,7L,4L,4L,7L,1L,7L,4L,7L,1L,1L,7L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240924Inst : IEnumerable<long>
{
public static readonly long[] Value=A240924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240924.Bytes);
public long this[int i]=>Value[i];

public static A240924Inst Instance=new A240924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240925
{
public static readonly long[] Value={ 1L,32L,7L,6L,8L,3L,4L,321L,65L,12L,2L,76L,43L,30L,761L,61L,27L,46L,25L,17L,28L,84L,38L,9L,767L,950L,72L,7000L,440L,71L,10L,81L,22L,69L,811L,96L,83L,97L,33L,615L,62L,5L,49L,13L,21L,95L,259L,270L,45L,48L,727L,29L,451L,217L,66L,385L,73L,75000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240925Inst : IEnumerable<long>
{
public static readonly long[] Value=A240925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240925.Bytes);
public long this[int i]=>Value[i];

public static A240925Inst Instance=new A240925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240926
{
public static readonly long[] Value={ 4L,5L,9L,20L,49L,125L,324L,845L,2209L,5780L,15129L,39605L,103684L,271445L,710649L,1860500L,4870849L,12752045L,33385284L,87403805L,228826129L,599074580L,1568397609L,4106118245L,10749957124L,28143753125L,73681302249L,192900153620L,505019158609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240926Inst : IEnumerable<long>
{
public static readonly long[] Value=A240926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240926.Bytes);
public long this[int i]=>Value[i];

public static A240926Inst Instance=new A240926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240927
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,1001L,1010L,1102L,1111L,1120L,1203L,1212L,1221L,1230L,1304L,1313L,1322L,1331L,1340L,1405L,1414L,1423L,1432L,1441L,1450L,1506L,1515L,1524L,1533L,1542L,1551L,1560L,1607L,1616L,1625L,1634L,1643L,1652L,1661L,1670L,1708L,1717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240927Inst : IEnumerable<long>
{
public static readonly long[] Value=A240927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240927.Bytes);
public long this[int i]=>Value[i];

public static A240927Inst Instance=new A240927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241184
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,2L,7L,7L,2L,2L,12L,18L,12L,2L,3L,17L,37L,37L,17L,3L,3L,24L,64L,88L,64L,24L,3L,4L,31L,102L,176L,176L,102L,31L,4L,4L,40L,151L,316L,400L,316L,151L,40L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241184Inst : IEnumerable<long>
{
public static readonly long[] Value=A241184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241184.Bytes);
public long this[int i]=>Value[i];

public static A241184Inst Instance=new A241184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241185
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,2L,7L,7L,2L,2L,13L,16L,13L,2L,3L,18L,36L,36L,18L,3L,3L,27L,60L,90L,60L,27L,3L,4L,34L,102L,173L,173L,102L,34L,4L,4L,46L,148L,323L,380L,323L,148L,46L,4L,4L,31L,102L,176L,176L,102L,31L,4L,4L,40L,151L,316L,400L,316L,151L,40L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241185Inst : IEnumerable<long>
{
public static readonly long[] Value=A241185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241185.Bytes);
public long this[int i]=>Value[i];

public static A241185Inst Instance=new A241185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241186
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,3L,9L,9L,3L,4L,8L,20L,8L,14L,5L,25L,175L,75L,425L,95L,6L,18L,27L,24L,123L,33L,41L,7L,49L,539L,1225L,26117L,2499L,30919L,5257L,8L,32L,208L,96L,3928L,2336L,18128L,736L,3956L,9L,81L,405L,1323L,14661L,4455L,159219L,103437L,26649L,25713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241186Inst : IEnumerable<long>
{
public static readonly long[] Value=A241186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241186.Bytes);
public long this[int i]=>Value[i];

public static A241186Inst Instance=new A241186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241187
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,2L,4L,8L,1L,1L,3L,3L,45L,1L,2L,12L,8L,144L,288L,1L,1L,1L,1L,10L,10L,140L,1L,2L,12L,24L,720L,160L,8640L,17280L,1L,1L,3L,1L,45L,45L,945L,189L,14175L,1L,2L,4L,8L,80L,32L,2240L,4480L,6400L,89600L,1L,1L,3L,3L,18L,2L,756L,189L,4536L,4536L,299376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241187Inst : IEnumerable<long>
{
public static readonly long[] Value=A241187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241187.Bytes);
public long this[int i]=>Value[i];

public static A241187Inst Instance=new A241187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241188
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,5L,5L,1L,4L,9L,16L,20L,1L,5L,14L,30L,55L,77L,1L,6L,20L,50L,105L,196L,294L,1L,7L,27L,77L,182L,378L,714L,1122L,1L,8L,35L,112L,294L,672L,1386L,2640L,4290L,1L,9L,44L,156L,450L,1122L,2508L,5148L,9867L,16445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241188Inst : IEnumerable<long>
{
public static readonly long[] Value=A241188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241188.Bytes);
public long this[int i]=>Value[i];

public static A241188Inst Instance=new A241188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241189
{
public static readonly BigInteger[] Value={ 1L,7L,11L,127L,1693L,29243L,561623L,13019431L,379503437L,11809225121L,438235268123L,18007758091069L,775817745542929L,36524284093223105L,1938403609207158571L,2160165866032831207L,BigInteger.Parse("131893095784520401909"),BigInteger.Parse("8844093116997411126541"),BigInteger.Parse("628373208972323386101329"),BigInteger.Parse("45900898298568589325230523") };
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
public class A241189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241189Inst Instance=new A241189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241190
{
public static readonly BigInteger[] Value={ 6L,30L,42L,462L,6006L,102102L,1939938L,44618574L,1293938646L,40112098026L,1484147626962L,60850052705442L,2616552266334006L,122977956517698282L,6517831695438008946L,7255699434544198638L,BigInteger.Parse("442597665507196116918"),BigInteger.Parse("29654043588982139833506"),BigInteger.Parse("2105437094817731928178926"),BigInteger.Parse("153696907921694430757061598") };
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
public class A241190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241190Inst Instance=new A241190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241191
{
public static readonly BigInteger[] Value={ 1L,3L,1L,93L,145L,213L,289L,365L,260511L,9645025L,395623447L,17017308303L,800016993275L,902324346127L,2502504187659113L,152669617912106167L,10229758110750827711UL,BigInteger.Parse("726365554791051924279"),BigInteger.Parse("53027901964339123037045"),BigInteger.Parse("57389311757677767147397") };
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
public class A241191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241191Inst Instance=new A241191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241192
{
public static readonly BigInteger[] Value={ 30L,70L,22L,2002L,3094L,4522L,6118L,7714L,5500082L,203503034L,8343624394L,358775848942L,16862464900274L,19015119993926L,52728927743156798L,3216464592332564678L,BigInteger.Parse("215503127686281833426"),BigInteger.Parse("15300722065726010173246"),BigInteger.Parse("1116952710797998742646958"),BigInteger.Parse("1208757043192354803686434") };
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
public class A241192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241192Inst Instance=new A241192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241193
{
public static readonly BigInteger[] Value={ 1L,11L,181L,3499L,73501L,1623467L,37081045L,867484331L,20661914989L,499049420011L,12188943245909L,300438089843371L,7461880085538581L,186524863637339819L,4688354828111460181L,BigInteger.Parse("118407620161890380459"),BigInteger.Parse("3002994055439841324301"),BigInteger.Parse("76441823131542496027499"),BigInteger.Parse("1952230701520399696996501"),BigInteger.Parse("50003999526279431605603499") };
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
public class A241193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241193Inst Instance=new A241193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241194
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,5L,3L,4L,1L,2L,2L,11L,6L,14L,4L,10L,12L,1L,4L,20L,5L,1L,2L,16L,26L,1L,3L,2L,24L,8L,22L,18L,4L,4L,1L,41L,21L,44L,4L,36L,1L,3L,10L,8L,12L,56L,6L,14L,48L,4L,2L,1L,65L,33L,4L,22L,12L,46L,36L,16L,12L,4L,39L,8L,2L,86L,28L,5L,89L,20L,10L,2L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241194Inst : IEnumerable<long>
{
public static readonly long[] Value=A241194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241194.Bytes);
public long this[int i]=>Value[i];

public static A241194Inst Instance=new A241194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241195
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,2L,3L,11L,7L,15L,3L,5L,7L,23L,13L,29L,15L,33L,35L,3L,13L,41L,11L,3L,5L,51L,53L,3L,7L,7L,65L,17L,69L,37L,15L,13L,3L,83L,43L,89L,15L,95L,3L,7L,33L,35L,37L,113L,19L,29L,119L,15L,5L,2L,131L,67L,15L,69L,35L,141L,73L,51L,31L,13L,79L,33L,7L,173L,87L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241195Inst : IEnumerable<long>
{
public static readonly long[] Value=A241195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241195.Bytes);
public long this[int i]=>Value[i];

public static A241195Inst Instance=new A241195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241196
{
public static readonly long[] Value={ 2L,3L,7L,31L,211L,2311L,43891L,78541L,120121L,870871L,1381381L,2282281L,4084081L,13123111L,82192111L,106696591L,300690391L,562582021L,892371481L,6915878971L,71166625531L,200560490131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241196Inst : IEnumerable<long>
{
public static readonly long[] Value=A241196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241196.Bytes);
public long this[int i]=>Value[i];

public static A241196Inst Instance=new A241196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241197
{
public static readonly long[] Value={ 1L,1L,1L,4L,8L,16L,288L,256L,192L,768L,384L,3456L,3072L,6912L,6144L,55296L,1658880L,221184L,110592L,3317760L,442368L,13271040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241197Inst : IEnumerable<long>
{
public static readonly long[] Value=A241197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241197.Bytes);
public long this[int i]=>Value[i];

public static A241197Inst Instance=new A241197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241198
{
public static readonly long[] Value={ 1L,2L,3L,15L,35L,77L,1463L,1309L,1001L,4147L,2093L,19019L,17017L,39767L,35581L,323323L,10023013L,1339481L,676039L,20957209L,2800733L,86822723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241198Inst : IEnumerable<long>
{
public static readonly long[] Value=A241198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241198.Bytes);
public long this[int i]=>Value[i];

public static A241198Inst Instance=new A241198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241199
{
public static readonly long[] Value={ 14L,19L,31L,38L,54L,63L,83L,94L,118L,131L,159L,174L,206L,223L,259L,278L,318L,339L,383L,406L,454L,479L,531L,558L,614L,643L,703L,734L,798L,831L,899L,934L,1006L,1043L,1119L,1158L,1238L,1279L,1363L,1406L,1494L,1539L,1631L,1678L,1774L,1823L,1923L,1974L,2078L,2131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241199Inst : IEnumerable<long>
{
public static readonly long[] Value=A241199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241199.Bytes);
public long this[int i]=>Value[i];

public static A241199Inst Instance=new A241199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241712
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,11L,43L,234L,1498L,11451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241712Inst : IEnumerable<long>
{
public static readonly long[] Value=A241712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241712.Bytes);
public long this[int i]=>Value[i];

public static A241712Inst Instance=new A241712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241713
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,5L,18L,82L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241713Inst : IEnumerable<long>
{
public static readonly long[] Value=A241713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241713.Bytes);
public long this[int i]=>Value[i];

public static A241713Inst Instance=new A241713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241714
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,7L,25L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241714Inst : IEnumerable<long>
{
public static readonly long[] Value=A241714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241714.Bytes);
public long this[int i]=>Value[i];

public static A241714Inst Instance=new A241714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241715
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,6L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241715Inst : IEnumerable<long>
{
public static readonly long[] Value=A241715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241715.Bytes);
public long this[int i]=>Value[i];

public static A241715Inst Instance=new A241715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241716
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,41L,43L,47L,61L,79L,89L,101L,107L,139L,157L,181L,199L,239L,271L,307L,311L,331L,337L,347L,349L,379L,397L,409L,421L,431L,479L,487L,499L,521L,523L,541L,571L,607L,613L,641L,643L,661L,673L,701L,719L,761L,769L,811L,823L,829L,839L,877L,881L,883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241716Inst : IEnumerable<long>
{
public static readonly long[] Value=A241716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241716.Bytes);
public long this[int i]=>Value[i];

public static A241716Inst Instance=new A241716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241717
{
public static readonly long[] Value={ 1L,3L,3L,9L,3L,9L,15L,21L,3L,9L,15L,21L,27L,33L,39L,45L,3L,9L,15L,21L,27L,33L,39L,45L,51L,57L,63L,69L,75L,81L,87L,93L,3L,9L,15L,21L,27L,33L,39L,45L,51L,57L,63L,69L,75L,81L,87L,93L,99L,105L,111L,117L,123L,129L,135L,141L,147L,153L,159L,165L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241717Inst : IEnumerable<long>
{
public static readonly long[] Value=A241717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241717.Bytes);
public long this[int i]=>Value[i];

public static A241717Inst Instance=new A241717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241718
{
public static readonly long[] Value={ 1L,7L,13L,43L,25L,79L,133L,211L,49L,151L,253L,379L,457L,607L,757L,931L,97L,295L,493L,715L,889L,1135L,1381L,1651L,1681L,1975L,2269L,2587L,2857L,3199L,3541L,3907L,193L,583L,973L,1387L,1753L,2191L,2629L,3091L,3313L,3799L,4285L,4795L,5257L,5791L,6325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241718Inst : IEnumerable<long>
{
public static readonly long[] Value=A241718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241718.Bytes);
public long this[int i]=>Value[i];

public static A241718Inst Instance=new A241718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241719
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,2L,4L,6L,1L,5L,7L,1L,6L,11L,2L,8L,16L,3L,10L,31L,15L,1L,12L,36L,16L,1L,15L,55L,29L,2L,18L,71L,41L,3L,22L,101L,65L,5L,27L,147L,144L,32L,1L,32L,188L,179L,35L,1L,38L,245L,269L,63L,2L,46L,327L,382L,93L,3L,54L,421L,549L,148L,5L,64L,540L,739L,205L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241719Inst : IEnumerable<long>
{
public static readonly long[] Value=A241719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241719.Bytes);
public long this[int i]=>Value[i];

public static A241719Inst Instance=new A241719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241720
{
public static readonly long[] Value={ 1L,1L,2L,6L,7L,11L,16L,31L,36L,55L,71L,101L,147L,188L,245L,327L,421L,540L,732L,899L,1154L,1445L,1831L,2253L,2846L,3545L,4352L,5352L,6576L,7993L,9778L,11826L,14314L,17430L,20866L,25076L,30043L,35974L,42776L,51053L,60463L,71772L,85094L,100370L,118155L,139331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241720Inst : IEnumerable<long>
{
public static readonly long[] Value=A241720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241720.Bytes);
public long this[int i]=>Value[i];

public static A241720Inst Instance=new A241720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241721
{
public static readonly long[] Value={ 1L,1L,2L,3L,15L,16L,29L,41L,65L,144L,179L,269L,382L,549L,739L,1286L,1564L,2254L,2978L,4124L,5304L,7264L,10157L,12941L,17027L,22194L,28663L,36884L,47306L,59837L,79467L,98114L,125117L,156392L,198113L,244710L,307908L,378429L,471337L,588642L,721300L,884498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241721Inst : IEnumerable<long>
{
public static readonly long[] Value=A241721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241721.Bytes);
public long this[int i]=>Value[i];

public static A241721Inst Instance=new A241721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241722
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,32L,35L,63L,93L,148L,205L,589L,674L,1111L,1551L,2344L,3140L,4616L,8210L,10370L,14976L,20564L,28598L,38244L,52451L,68597L,105527L,131194L,180087L,234267L,316204L,404032L,538282L,683281L,893039L,1205430L,1516912L,1949691L,2506797L,3192751L,4039430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241722Inst : IEnumerable<long>
{
public static readonly long[] Value=A241722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241722.Bytes);
public long this[int i]=>Value[i];

public static A241722Inst Instance=new A241722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241723
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,67L,70L,132L,194L,315L,436L,674L,2046L,2401L,3948L,5669L,8582L,11784L,17312L,23187L,47121L,56974L,86078L,116892L,169282L,223496L,316211L,413133L,565423L,879530L,1111950L,1523112L,2042569L,2744398L,3588200L,4804470L,6199849L,8142059L,10485846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241723Inst : IEnumerable<long>
{
public static readonly long[] Value=A241723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241723.Bytes);
public long this[int i]=>Value[i];

public static A241723Inst Instance=new A241723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241724
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,134L,140L,266L,395L,644L,898L,1391L,1890L,6923L,7789L,13309L,18958L,29500L,40173L,60154L,80506L,114580L,237383L,290326L,436413L,609703L,876498L,1179323L,1672718L,2211328L,3033278L,4006213L,6582029L,8104364L,11507527L,15185574L,20938573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241724Inst : IEnumerable<long>
{
public static readonly long[] Value=A241724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241724.Bytes);
public long this[int i]=>Value[i];

public static A241724Inst Instance=new A241724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241725
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,268L,275L,532L,790L,1300L,1811L,2822L,3836L,5598L,21972L,24736L,42360L,61478L,95459L,131430L,197368L,265795L,379046L,510385L,1142239L,1352589L,2108022L,2898138L,4263545L,5709193L,8215288L,10832575L,15040276L,19845562L,26770982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241725Inst : IEnumerable<long>
{
public static readonly long[] Value=A241725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241725.Bytes);
public long this[int i]=>Value[i];

public static A241725Inst Instance=new A241725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241726
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,531L,542L,1056L,1576L,2599L,3630L,5668L,7716L,11274L,15348L,68774L,75382L,132851L,191346L,301710L,414613L,628232L,845401L,1213643L,1634287L,2256360L,5137346L,6161809L,9496049L,13277964L,19515699L,26349160L,37943650L,50425938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241726Inst : IEnumerable<long>
{
public static readonly long[] Value=A241726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241726.Bytes);
public long this[int i]=>Value[i];

public static A241726Inst Instance=new A241726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241727
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,1054L,1067L,2099L,3133L,5188L,7248L,11344L,15447L,22604L,30783L,43034L,208950L,229344L,404422L,588651L,930608L,1284764L,1951323L,2636169L,3789105L,5119060L,7075832L,9369369L,22789793L,26524108L,41851347L,58150258L,86514208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241727Inst : IEnumerable<long>
{
public static readonly long[] Value=A241727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241727.Bytes);
public long this[int i]=>Value[i];

public static A241727Inst Instance=new A241727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241760
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,2L,1L,2L,2L,3L,2L,6L,5L,8L,9L,11L,11L,17L,17L,23L,26L,32L,36L,47L,51L,63L,71L,84L,93L,115L,127L,151L,171L,201L,225L,266L,297L,346L,389L,448L,501L,580L,648L,740L,831L,945L,1056L,1201L,1340L,1517L,1695L,1910L,2130L,2399L,2670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241760Inst : IEnumerable<long>
{
public static readonly long[] Value=A241760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241760.Bytes);
public long this[int i]=>Value[i];

public static A241760Inst Instance=new A241760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241761
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,7L,9L,14L,20L,28L,39L,54L,71L,96L,127L,167L,220L,286L,368L,473L,604L,766L,970L,1219L,1528L,1907L,2373L,2939L,3634L,4472L,5489L,6715L,8198L,9972L,12109L,14658L,17711L,21340L,25669L,30796L,36890L,44082L,52594L,62613L,74435L,88303L,104613L,123698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241761Inst : IEnumerable<long>
{
public static readonly long[] Value=A241761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241761.Bytes);
public long this[int i]=>Value[i];

public static A241761Inst Instance=new A241761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241762
{
public static readonly long[] Value={ 1L,2L,45L,12L,70L,36L,42L,336L,270L,420L,1848L,2520L,2730L,5880L,12600L,332640L,353430L,166320L,175560L,1663200L,2522520L,87650640L,118798680L,1051807680L,671517000L,1139458320L,35231316120L,15952416480L,16522145640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241762Inst : IEnumerable<long>
{
public static readonly long[] Value=A241762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241762.Bytes);
public long this[int i]=>Value[i];

public static A241762Inst Instance=new A241762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241763
{
public static readonly long[] Value={ 10L,16L,19L,33L,36L,42L,50L,56L,65L,73L,82L,88L,91L,102L,110L,111L,119L,128L,137L,145L,148L,151L,165L,168L,174L,182L,183L,191L,197L,205L,214L,220L,223L,237L,240L,243L,251L,260L,269L,277L,286L,297L,300L,306L,314L,315L,323L,332L,346L,352L,355L,369L,372L,378L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241763Inst : IEnumerable<long>
{
public static readonly long[] Value=A241763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241763.Bytes);
public long this[int i]=>Value[i];

public static A241763Inst Instance=new A241763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241764
{
public static readonly long[] Value={ 9L,25L,38L,49L,58L,65L,77L,85L,94L,118L,121L,122L,145L,146L,158L,161L,169L,205L,206L,209L,217L,218L,221L,262L,265L,298L,301L,302L,305L,326L,329L,358L,361L,365L,394L,398L,454L,469L,481L,485L,505L,514L,517L,529L,538L,545L,554L,562L,565L,586L,589L,614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241764Inst : IEnumerable<long>
{
public static readonly long[] Value=A241764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241764.Bytes);
public long this[int i]=>Value[i];

public static A241764Inst Instance=new A241764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241765
{
public static readonly long[] Value={ 0L,5L,23L,65L,145L,280L,490L,798L,1230L,1815L,2585L,3575L,4823L,6370L,8260L,10540L,13260L,16473L,20235L,24605L,29645L,35420L,41998L,49450L,57850L,67275L,77805L,89523L,102515L,116870L,132680L,150040L,169048L,189805L,212415L,236985L,263625L,292448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241765Inst : IEnumerable<long>
{
public static readonly long[] Value=A241765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241765.Bytes);
public long this[int i]=>Value[i];

public static A241765Inst Instance=new A241765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241766
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,5L,6L,6L,6L,6L,7L,8L,8L,8L,8L,9L,10L,10L,10L,10L,11L,12L,12L,12L,13L,14L,15L,15L,15L,16L,17L,18L,18L,18L,19L,20L,21L,21L,21L,22L,23L,24L,24L,25L,26L,27L,28L,28L,29L,30L,31L,33L,33L,34L,35L,36L,38L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241766Inst : IEnumerable<long>
{
public static readonly long[] Value=A241766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241766.Bytes);
public long this[int i]=>Value[i];

public static A241766Inst Instance=new A241766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241767
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,33L,244L,2792L,52448L,1690206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241767Inst : IEnumerable<long>
{
public static readonly long[] Value=A241767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241767.Bytes);
public long this[int i]=>Value[i];

public static A241767Inst Instance=new A241767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241768
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,17L,101L,890L,11468L,239728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241768Inst : IEnumerable<long>
{
public static readonly long[] Value=A241768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241768.Bytes);
public long this[int i]=>Value[i];

public static A241768Inst Instance=new A241768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241769
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,5L,32L,242L,2461L,35839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241769Inst : IEnumerable<long>
{
public static readonly long[] Value=A241769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241769.Bytes);
public long this[int i]=>Value[i];

public static A241769Inst Instance=new A241769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241770
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,7L,60L,527L,6056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241770Inst : IEnumerable<long>
{
public static readonly long[] Value=A241770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241770.Bytes);
public long this[int i]=>Value[i];

public static A241770Inst Instance=new A241770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241771
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,9L,97L,1029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241771Inst : IEnumerable<long>
{
public static readonly long[] Value=A241771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241771.Bytes);
public long this[int i]=>Value[i];

public static A241771Inst Instance=new A241771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241772
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,6L,7L,9L,12L,15L,19L,24L,30L,37L,45L,55L,68L,82L,99L,119L,143L,171L,203L,241L,286L,338L,398L,468L,548L,642L,749L,873L,1015L,1177L,1364L,1577L,1821L,2099L,2415L,2775L,3184L,3647L,4173L,4768L,5441L,6201L,7058L,8025L,9113L,10337L,11713L,13258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241772Inst : IEnumerable<long>
{
public static readonly long[] Value=A241772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241772.Bytes);
public long this[int i]=>Value[i];

public static A241772Inst Instance=new A241772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241773
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,5L,2L,1L,6L,1L,7L,1L,2L,3L,1L,8L,1L,9L,2L,1L,4L,1L,10L,1L,3L,2L,1L,11L,1L,2L,5L,1L,12L,1L,3L,1L,2L,4L,1L,13L,1L,2L,6L,1L,14L,1L,3L,1L,2L,15L,1L,16L,1L,2L,4L,1L,3L,1L,5L,7L,1L,2L,1L,17L,1L,2L,3L,1L,18L,1L,8L,2L,1L,4L,1L,6L,1L,2L,3L,1L,5L,1L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241773Inst : IEnumerable<long>
{
public static readonly long[] Value=A241773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241773.Bytes);
public long this[int i]=>Value[i];

public static A241773Inst Instance=new A241773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241774
{
public static readonly long[] Value={ 1L,2L,9L,29L,108L,399L,1573L,6249L,25642L,107751L,466898L,2071183L,9429453L,43889227L,209111720L,1017353435L,5056450994L,25627110560L,132451351403L,697165582228L,3736595119730L,20372395392794L,112961465325799L,636497947945382L,3643481367551384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241774Inst : IEnumerable<long>
{
public static readonly long[] Value=A241774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241774.Bytes);
public long this[int i]=>Value[i];

public static A241774Inst Instance=new A241774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241775
{
public static readonly long[] Value={ 1L,3L,13L,49L,201L,802L,3343L,14368L,62909L,282989L,1299074L,6111610L,29330177L,143869556L,719339872L,3669604633L,19062972671L,100880716332L,543086732800L,2974442015323L,16556687511535L,93655725178808L,537951557765438L,3137040309057826L,18560431188723607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241775Inst : IEnumerable<long>
{
public static readonly long[] Value=A241775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241775.Bytes);
public long this[int i]=>Value[i];

public static A241775Inst Instance=new A241775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241808
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,13L,17L,19L,20L,37L,40L,53L,55L,58L,62L,68L,79L,89L,92L,95L,103L,112L,115L,119L,128L,137L,140L,158L,160L,169L,170L,193L,205L,214L,223L,229L,232L,235L,242L,248L,265L,272L,275L,278L,295L,313L,317L,322L,323L,337L,355L,359L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241808Inst : IEnumerable<long>
{
public static readonly long[] Value=A241808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241808.Bytes);
public long this[int i]=>Value[i];

public static A241808Inst Instance=new A241808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241809
{
public static readonly long[] Value={ 9L,15L,21L,35L,39L,51L,57L,65L,69L,77L,87L,95L,111L,129L,155L,161L,177L,209L,221L,237L,249L,267L,291L,305L,309L,329L,335L,365L,371L,377L,381L,395L,407L,417L,437L,447L,485L,489L,497L,501L,519L,545L,591L,597L,611L,629L,671L,681L,689L,699L,707L,717L,731L,737L,749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241809Inst : IEnumerable<long>
{
public static readonly long[] Value=A241809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241809.Bytes);
public long this[int i]=>Value[i];

public static A241809Inst Instance=new A241809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241810
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,6L,0L,6L,8L,36L,0L,88L,58L,376L,0L,1096L,526L,4476L,0L,14200L,5448L,57284L,0L,190206L,61108L,764812L,0L,2615268L,723354L,10499504L,0L,36677626L,8908546L,147110276L,0L,522288944L,113093022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241810Inst : IEnumerable<long>
{
public static readonly long[] Value=A241810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241810.Bytes);
public long this[int i]=>Value[i];

public static A241810Inst Instance=new A241810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241811
{
public static readonly long[] Value={ 1L,0L,2L,3L,11L,71L,29L,9L,683L,67L,7L,743L,739L,1933L,23L,161L,21L,37L,19L,17L,119L,49L,332534262883L,13L,39L,13739483941387L,83L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241811Inst : IEnumerable<long>
{
public static readonly long[] Value=A241811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241811.Bytes);
public long this[int i]=>Value[i];

public static A241811Inst Instance=new A241811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241812
{
public static readonly long[] Value={ 1062489753L,1239845706L,1256984730L,1520843976L,1539264870L,1597283460L,1684930275L,1952843760L,1957346028L,1978236450L,2197480365L,2367098415L,2418079653L,2503948761L,2634980715L,2718609453L,2735891406L,2750483196L,2764518903L,2854316790L,2915768430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241812Inst : IEnumerable<long>
{
public static readonly long[] Value=A241812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241812.Bytes);
public long this[int i]=>Value[i];

public static A241812Inst Instance=new A241812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241813
{
public static readonly long[] Value={ 8L,96L,480L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241813Inst : IEnumerable<long>
{
public static readonly long[] Value=A241813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241813.Bytes);
public long this[int i]=>Value[i];

public static A241813Inst Instance=new A241813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241814
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,2L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241814Inst : IEnumerable<long>
{
public static readonly long[] Value=A241814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241814.Bytes);
public long this[int i]=>Value[i];

public static A241814Inst Instance=new A241814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241815
{
public static readonly long[] Value={ 2L,2L,3L,1L,2L,1L,1L,3L,1L,1L,1L,2L,1L,1L,3L,1L,3L,1L,1L,2L,2L,2L,2L,1L,1L,3L,2L,4L,1L,1L,1L,2L,4L,2L,1L,4L,1L,3L,4L,4L,1L,4L,1L,1L,1L,3L,1L,5L,1L,4L,1L,2L,3L,1L,1L,6L,5L,6L,1L,1L,2L,2L,2L,1L,1L,2L,6L,1L,2L,5L,4L,3L,1L,2L,4L,1L,2L,6L,5L,1L,2L,8L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241815Inst : IEnumerable<long>
{
public static readonly long[] Value=A241815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241815.Bytes);
public long this[int i]=>Value[i];

public static A241815Inst Instance=new A241815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241816
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,3L,5L,7L,4L,5L,9L,7L,10L,11L,13L,15L,8L,9L,17L,11L,18L,19L,21L,15L,20L,21L,25L,23L,26L,27L,29L,31L,16L,17L,33L,19L,34L,35L,37L,23L,36L,37L,41L,39L,42L,43L,45L,31L,40L,41L,49L,43L,50L,51L,53L,47L,52L,53L,57L,55L,58L,59L,61L,63L,32L,33L,65L,35L,66L,67L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241816Inst : IEnumerable<long>
{
public static readonly long[] Value=A241816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241816.Bytes);
public long this[int i]=>Value[i];

public static A241816Inst Instance=new A241816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241817
{
public static readonly long[] Value={ 6L,10L,14L,22L,26L,34L,46L,62L,74L,82L,86L,106L,134L,142L,166L,194L,202L,214L,226L,254L,274L,314L,334L,362L,382L,386L,422L,446L,466L,482L,502L,526L,566L,622L,634L,662L,694L,746L,842L,862L,866L,886L,914L,922L,974L,1042L,1094L,1126L,1154L,1174L,1226L,1234L,1262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241817Inst : IEnumerable<long>
{
public static readonly long[] Value=A241817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241817.Bytes);
public long this[int i]=>Value[i];

public static A241817Inst Instance=new A241817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241818
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,9L,12L,17L,20L,27L,37L,46L,59L,81L,102L,130L,170L,212L,273L,344L,432L,539L,679L,843L,1049L,1297L,1602L,1968L,2422L,2961L,3608L,4395L,5334L,6467L,7800L,9418L,11311L,13593L,16287L,19482L,23214L,27702L,32908L,39117L,46305L,54856L,64749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241818Inst : IEnumerable<long>
{
public static readonly long[] Value=A241818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241818.Bytes);
public long this[int i]=>Value[i];

public static A241818Inst Instance=new A241818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241819
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,9L,11L,17L,20L,30L,37L,50L,64L,84L,106L,141L,178L,224L,290L,368L,457L,574L,722L,894L,1113L,1371L,1693L,2082L,2555L,3108L,3806L,4630L,5605L,6787L,8197L,9881L,11877L,14256L,17047L,20395L,24320L,28958L,34409L,40867L,48333L,57243L,67548L,79683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241819Inst : IEnumerable<long>
{
public static readonly long[] Value=A241819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241819.Bytes);
public long this[int i]=>Value[i];

public static A241819Inst Instance=new A241819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241820
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,5L,3L,10L,10L,13L,18L,25L,25L,39L,48L,54L,78L,95L,113L,142L,183L,215L,270L,322L,396L,480L,587L,686L,845L,1022L,1210L,1453L,1730L,2081L,2459L,2945L,3454L,4108L,4838L,5744L,6707L,7959L,9216L,10938L,12692L,14934L,17346L,20296L,23526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241820Inst : IEnumerable<long>
{
public static readonly long[] Value=A241820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241820.Bytes);
public long this[int i]=>Value[i];

public static A241820Inst Instance=new A241820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241821
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,6L,10L,13L,22L,29L,40L,55L,76L,95L,129L,167L,215L,278L,354L,448L,570L,716L,896L,1115L,1387L,1713L,2116L,2597L,3182L,3881L,4741L,5748L,6976L,8416L,10177L,12219L,14704L,17592L,21051L,25101L,29960L,35559L,42267L,50017L,59253L,69898L,82524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241821Inst : IEnumerable<long>
{
public static readonly long[] Value=A241821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241821.Bytes);
public long this[int i]=>Value[i];

public static A241821Inst Instance=new A241821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241822
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,4L,5L,10L,12L,19L,27L,37L,51L,70L,90L,119L,161L,200L,259L,335L,428L,533L,681L,845L,1065L,1317L,1636L,2010L,2496L,3036L,3719L,4538L,5523L,6686L,8096L,9760L,11759L,14138L,16943L,20263L,24216L,28852L,34308L,40801L,48315L,57206L,67590L,79748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241822Inst : IEnumerable<long>
{
public static readonly long[] Value=A241822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241822.Bytes);
public long this[int i]=>Value[i];

public static A241822Inst Instance=new A241822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241823
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,5L,8L,12L,18L,26L,37L,51L,70L,94L,126L,166L,219L,284L,369L,473L,607L,770L,977L,1228L,1544L,1925L,2399L,2970L,3673L,4517L,5550L,6784L,8284L,10073L,12232L,14799L,17883L,21536L,25903L,31064L,37204L,44439L,53015L,63090L,74987L,88932L,105337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241823Inst : IEnumerable<long>
{
public static readonly long[] Value=A241823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241823.Bytes);
public long this[int i]=>Value[i];

public static A241823Inst Instance=new A241823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241904
{
public static readonly long[] Value={ 1L,2L,3L,8L,22L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241904Inst : IEnumerable<long>
{
public static readonly long[] Value=A241904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241904.Bytes);
public long this[int i]=>Value[i];

public static A241904Inst Instance=new A241904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241905
{
public static readonly long[] Value={ 1L,1L,1L,4L,13L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241905Inst : IEnumerable<long>
{
public static readonly long[] Value=A241905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241905.Bytes);
public long this[int i]=>Value[i];

public static A241905Inst Instance=new A241905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241906
{
public static readonly long[] Value={ 1L,2L,3L,8L,18L,42L,102L,248L,611L,1525L,3845L,9787L,25118L,64944L,169047L,442727L,1165990L,3086692L,8210400L,21936230L,58851484L,158502600L,428446818L,1162110731L,3162318827L,8631705612L,23629386708L,64865101678L,178531867765L,492622401009L,1362567996602L,3777490059587L,10495626146222L,29223682273897L,81535625627546L,227935763726546L,638409001899851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241906Inst : IEnumerable<long>
{
public static readonly long[] Value=A241906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241906.Bytes);
public long this[int i]=>Value[i];

public static A241906Inst Instance=new A241906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241907
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,14L,17L,20L,23L,26L,29L,33L,36L,40L,44L,48L,52L,56L,60L,65L,69L,74L,78L,83L,88L,93L,98L,103L,108L,114L,119L,124L,130L,136L,141L,147L,153L,159L,165L,171L,177L,183L,189L,196L,202L,209L,215L,222L,229L,235L,242L,249L,256L,263L,270L,277L,284L,292L,299L,306L,314L,321L,329L,336L,344L,352L,360L,367L,375L,383L,391L,399L,408L,416L,424L,432L,441L,449L,457L,466L,474L,483L,492L,500L,509L,518L,527L,536L,545L,554L,563L,572L,581L,590L,599L,609L,618L,627L,637L,646L,656L,665L,675L,685L,694L,704L,714L,724L,734L,744L,753L,764L,774L,784L,794L,804L,814L,825L,835L,845L,856L,866L,877L,887L,898L,908L,919L,930L,940L,951L,962L,973L,984L,995L,1006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241907Inst : IEnumerable<long>
{
public static readonly long[] Value=A241907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241907.Bytes);
public long this[int i]=>Value[i];

public static A241907Inst Instance=new A241907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241908
{
public static readonly BigInteger[] Value={ 1L,377L,413351L,536948224L,731164253833L,1012747193318519L,1412218550274852671L,BigInteger.Parse("1974622635952709613247"),BigInteger.Parse("2764079753958605286860951"),BigInteger.Parse("3870940598132705729413670953"),BigInteger.Parse("5422065916132126528319352874496"),BigInteger.Parse("7595338059193606161156363370300487"),BigInteger.Parse("10640045682768766172108553992086690201") };
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
public class A241908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241908Inst Instance=new A241908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241909
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,16L,5L,6L,27L,32L,25L,64L,81L,18L,7L,128L,15L,256L,125L,54L,243L,512L,49L,12L,729L,10L,625L,1024L,75L,2048L,11L,162L,2187L,36L,35L,4096L,6561L,486L,343L,8192L,375L,16384L,3125L,50L,19683L,32768L,121L,24L,45L,1458L,15625L,65536L,21L,108L,2401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241909Inst : IEnumerable<long>
{
public static readonly long[] Value=A241909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241909.Bytes);
public long this[int i]=>Value[i];

public static A241909Inst Instance=new A241909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241910
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,2L,0L,1L,0L,1L,0L,0L,1L,2L,0L,0L,1L,0L,1L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,2L,0L,1L,0L,1L,0L,0L,1L,2L,3L,0L,1L,0L,1L,0L,1L,2L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,3L,4L,0L,1L,0L,1L,0L,1L,0L,1L,2L,3L,0L,0L,1L,0L,1L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,2L,0L,1L,2L,0L,1L,0L,0L,1L,2L,3L,4L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241910Inst : IEnumerable<long>
{
public static readonly long[] Value=A241910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241910.Bytes);
public long this[int i]=>Value[i];

public static A241910Inst Instance=new A241910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241911
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,2L,1L,1L,2L,3L,1L,1L,2L,1L,2L,1L,2L,3L,4L,1L,1L,2L,3L,1L,1L,2L,3L,1L,2L,1L,2L,1L,1L,2L,3L,4L,1L,2L,1L,2L,1L,2L,3L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,3L,4L,5L,1L,2L,1L,2L,1L,2L,1L,2L,3L,4L,1L,1L,2L,1L,2L,1L,2L,3L,4L,1L,1L,2L,3L,1L,1L,2L,3L,1L,2L,3L,1L,2L,1L,1L,2L,3L,4L,5L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,1L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241911Inst : IEnumerable<long>
{
public static readonly long[] Value=A241911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241911.Bytes);
public long this[int i]=>Value[i];

public static A241911Inst Instance=new A241911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241912
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,13L,15L,16L,17L,18L,19L,23L,29L,31L,32L,37L,41L,43L,45L,47L,50L,53L,55L,59L,61L,64L,67L,71L,73L,79L,83L,89L,97L,98L,101L,103L,105L,107L,108L,109L,113L,119L,127L,128L,131L,135L,137L,139L,149L,150L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241912Inst : IEnumerable<long>
{
public static readonly long[] Value=A241912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241912.Bytes);
public long this[int i]=>Value[i];

public static A241912Inst Instance=new A241912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241913
{
public static readonly long[] Value={ 6L,9L,10L,12L,14L,20L,21L,22L,24L,25L,26L,27L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,46L,48L,49L,51L,52L,54L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,99L,100L,102L,104L,106L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241913Inst : IEnumerable<long>
{
public static readonly long[] Value=A241913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241913.Bytes);
public long this[int i]=>Value[i];

public static A241913Inst Instance=new A241913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241914
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,2L,0L,1L,0L,1L,2L,3L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,4L,0L,1L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,0L,1L,2L,0L,0L,1L,2L,3L,4L,5L,6L,0L,1L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,0L,1L,2L,0L,1L,2L,3L,4L,5L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241914Inst : IEnumerable<long>
{
public static readonly long[] Value=A241914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241914.Bytes);
public long this[int i]=>Value[i];

public static A241914Inst Instance=new A241914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241915
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,1L,2L,3L,1L,1L,2L,3L,4L,5L,6L,7L,1L,2L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,1L,2L,3L,1L,2L,3L,4L,5L,6L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241915Inst : IEnumerable<long>
{
public static readonly long[] Value=A241915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241915.Bytes);
public long this[int i]=>Value[i];

public static A241915Inst Instance=new A241915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241916
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,7L,8L,6L,25L,11L,27L,13L,49L,15L,16L,17L,18L,19L,125L,35L,121L,23L,81L,10L,169L,12L,343L,29L,75L,31L,32L,77L,289L,21L,54L,37L,361L,143L,625L,41L,245L,43L,1331L,45L,529L,47L,243L,14L,50L,221L,2197L,53L,36L,55L,2401L,323L,841L,59L,375L,61L,961L,175L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241916Inst : IEnumerable<long>
{
public static readonly long[] Value=A241916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241916.Bytes);
public long this[int i]=>Value[i];

public static A241916Inst Instance=new A241916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241917
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,0L,0L,2L,5L,1L,6L,3L,1L,0L,7L,0L,8L,2L,2L,4L,9L,1L,0L,5L,0L,3L,10L,1L,11L,0L,3L,6L,1L,0L,12L,7L,4L,2L,13L,2L,14L,4L,1L,8L,15L,1L,0L,0L,5L,5L,16L,0L,2L,3L,6L,9L,17L,1L,18L,10L,2L,0L,3L,3L,19L,6L,7L,1L,20L,0L,21L,11L,0L,7L,1L,4L,22L,2L,0L,12L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241917Inst : IEnumerable<long>
{
public static readonly long[] Value=A241917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241917.Bytes);
public long this[int i]=>Value[i];

public static A241917Inst Instance=new A241917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241918
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,2L,2L,4L,1L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,4L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,3L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241918Inst : IEnumerable<long>
{
public static readonly long[] Value=A241918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241918.Bytes);
public long this[int i]=>Value[i];

public static A241918Inst Instance=new A241918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241919
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,4L,1L,2L,2L,5L,1L,6L,3L,1L,1L,7L,1L,8L,2L,2L,4L,9L,1L,3L,5L,2L,3L,10L,1L,11L,1L,3L,6L,1L,1L,12L,7L,4L,2L,13L,2L,14L,4L,1L,8L,15L,1L,4L,2L,5L,5L,16L,1L,2L,3L,6L,9L,17L,1L,18L,10L,2L,1L,3L,3L,19L,6L,7L,1L,20L,1L,21L,11L,1L,7L,1L,4L,22L,2L,2L,12L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241919Inst : IEnumerable<long>
{
public static readonly long[] Value=A241919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241919.Bytes);
public long this[int i]=>Value[i];

public static A241919Inst Instance=new A241919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242096
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,3L,0L,3L,0L,4L,0L,4L,0L,4L,0L,4L,0L,5L,0L,5L,0L,6L,0L,6L,0L,6L,0L,6L,0L,7L,0L,7L,0L,8L,0L,8L,0L,8L,0L,8L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,10L,0L,10L,0L,11L,0L,11L,0L,11L,0L,11L,0L,11L,0L,11L,0L,12L,0L,12L,0L,12L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242096Inst : IEnumerable<long>
{
public static readonly long[] Value=A242096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242096.Bytes);
public long this[int i]=>Value[i];

public static A242096Inst Instance=new A242096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242097
{
public static readonly long[] Value={ 4L,9L,94L,46L,121L,961L,982L,4L,526L,9L,169L,6511L,5221L,9481L,1042L,6313L,4633L,1843L,1273L,94L,1405L,9235L,46L,9886L,6937L,4069L,10201L,61801L,94411L,18811L,121L,44521L,96721L,52231L,65431L,42931L,67351L,52651L,92161L,48361L,961L,16171L,98671L,65971L,96781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242097Inst : IEnumerable<long>
{
public static readonly long[] Value=A242097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242097.Bytes);
public long this[int i]=>Value[i];

public static A242097Inst Instance=new A242097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242098
{
public static readonly long[] Value={ 11L,14L,18L,19L,22L,23L,27L,28L,32L,33L,38L,39L,41L,44L,45L,47L,51L,52L,54L,58L,59L,61L,66L,67L,69L,71L,74L,75L,77L,79L,83L,84L,86L,88L,92L,93L,95L,97L,102L,103L,105L,107L,112L,113L,115L,117L,123L,124L,126L,128L,134L,135L,137L,139L,146L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242098Inst : IEnumerable<long>
{
public static readonly long[] Value=A242098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242098.Bytes);
public long this[int i]=>Value[i];

public static A242098Inst Instance=new A242098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242099
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,18L,84L,387L,2670L,20373L,182796L,1816325L,19973962L,239523846L,3113717784L,43589470208L,653840410004L,10461400104968L,177843770847822L,3201186945761289L,60822551319191028L,1216451005946790780L,BigInteger.Parse("25545471110008012860"),BigInteger.Parse("562000363929678643211") };
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
public class A242099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242099Inst Instance=new A242099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242100
{
public static readonly long[] Value={ 6L,10L,12L,18L,20L,24L,30L,34L,36L,40L,42L,48L,56L,66L,68L,72L,80L,84L,90L,96L,108L,110L,130L,132L,136L,144L,150L,156L,160L,182L,192L,210L,222L,240L,246L,252L,258L,260L,264L,270L,272L,288L,306L,320L,324L,342L,350L,380L,384L,392L,420L,462L,506L,514L,516L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242100Inst : IEnumerable<long>
{
public static readonly long[] Value=A242100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242100.Bytes);
public long this[int i]=>Value[i];

public static A242100Inst Instance=new A242100Inst();

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