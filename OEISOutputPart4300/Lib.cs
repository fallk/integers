using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190495
{
public static readonly long[] Value={ 7L,12L,19L,24L,36L,41L,48L,53L,65L,70L,77L,82L,89L,94L,106L,111L,118L,123L,135L,140L,147L,152L,164L,176L,181L,188L,193L,205L,210L,217L,222L,234L,239L,246L,251L,258L,263L,275L,280L,287L,292L,304L,309L,316L,321L,328L,333L,345L,350L,357L,362L,374L,379L,386L,391L,403L,408L,415L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190495Inst : IEnumerable<long>
{
public static readonly long[] Value=A190495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190495.Bytes);
public long this[int i]=>Value[i];

public static A190495Inst Instance=new A190495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190494
{
public static readonly long[] Value={ 2L,4L,9L,11L,14L,16L,21L,26L,28L,31L,33L,38L,40L,43L,45L,50L,52L,55L,57L,60L,62L,67L,69L,72L,74L,79L,81L,84L,86L,91L,96L,98L,101L,103L,108L,110L,113L,115L,120L,122L,125L,127L,130L,132L,137L,139L,142L,144L,149L,151L,154L,156L,159L,161L,166L,168L,171L,173L,178L,180L,183L,185L,190L,192L,195L,197L,200L,202L,207L,209L,212L,214L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190494Inst : IEnumerable<long>
{
public static readonly long[] Value=A190494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190494.Bytes);
public long this[int i]=>Value[i];

public static A190494Inst Instance=new A190494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190493
{
public static readonly long[] Value={ 1L,3L,6L,8L,13L,15L,18L,20L,23L,25L,30L,32L,35L,37L,42L,44L,47L,49L,54L,56L,59L,61L,64L,66L,71L,73L,76L,78L,83L,85L,88L,90L,93L,95L,100L,102L,105L,107L,112L,114L,117L,119L,124L,129L,131L,134L,136L,141L,143L,146L,148L,153L,155L,158L,160L,163L,165L,170L,172L,175L,177L,182L,184L,187L,189L,194L,199L,201L,204L,206L,211L,213L,216L,218L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190493Inst : IEnumerable<long>
{
public static readonly long[] Value=A190493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190493.Bytes);
public long this[int i]=>Value[i];

public static A190493Inst Instance=new A190493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190492
{
public static readonly long[] Value={ 5L,10L,17L,22L,27L,29L,34L,39L,46L,51L,58L,63L,68L,75L,80L,87L,92L,97L,99L,104L,109L,116L,121L,126L,128L,133L,138L,145L,150L,157L,162L,167L,169L,174L,179L,186L,191L,196L,198L,203L,208L,215L,220L,227L,232L,237L,244L,249L,256L,261L,266L,268L,273L,278L,285L,290L,295L,297L,302L,307L,314L,319L,326L,331L,336L,338L,343L,348L,355L,360L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190492Inst : IEnumerable<long>
{
public static readonly long[] Value=A190492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190492.Bytes);
public long this[int i]=>Value[i];

public static A190492Inst Instance=new A190492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190427
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L,1L,1L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L,1L,1L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L,1L,1L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L,1L,1L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L,1L,1L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190427Inst : IEnumerable<long>
{
public static readonly long[] Value=A190427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190427.Bytes);
public long this[int i]=>Value[i];

public static A190427Inst Instance=new A190427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190426
{
public static readonly long[] Value={ 12L,23L,45L,56L,67L,89L,100L,244L,266L,288L,310L,332L,376L,398L,420L,696L,762L,795L,828L,861L,894L,927L,1222L,1368L,1412L,1456L,1500L,1544L,1588L,1632L,1676L,1720L,2260L,2315L,2370L,2425L,2480L,2535L,2590L,2645L,2700L,3372L,3438L,3504L,3570L,3636L,3702L,3768L,3834L,3900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190426Inst : IEnumerable<long>
{
public static readonly long[] Value=A190426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190426.Bytes);
public long this[int i]=>Value[i];

public static A190426Inst Instance=new A190426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190425
{
public static readonly long[] Value={ 1L,2L,12L,60L,700L,3780L,51744L,288288L,4247100L,24066900L,369881512L,2118412296L,33466634656L,193076738400L,3109838832000L,18037065225600L,294718130342460L,1716299700229620L,28355714001615000L,165657066009435000L,2761067350729888200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190425Inst : IEnumerable<long>
{
public static readonly long[] Value=A190425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190425.Bytes);
public long this[int i]=>Value[i];

public static A190425Inst Instance=new A190425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190424
{
public static readonly long[] Value={ 0L,2L,6L,24L,30L,54L,84L,90L,120L,138L,150L,156L,204L,276L,306L,324L,360L,462L,486L,558L,612L,642L,702L,840L,990L,1014L,1584L,1704L,1722L,1770L,1848L,1932L,2010L,2034L,2208L,2310L,2406L,2772L,2814L,3204L,3312L,3450L,3594L,3870L,4080L,4530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190424Inst : IEnumerable<long>
{
public static readonly long[] Value=A190424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190424.Bytes);
public long this[int i]=>Value[i];

public static A190424Inst Instance=new A190424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190423
{
public static readonly long[] Value={ 3L,5L,13L,37L,73L,179L,503L,757L,1223L,1249L,1831L,2003L,4051L,6991L,17483L,18353L,18457L,22567L,26993L,47129L,88327L,131357L,136753L,215753L,344293L,499673L,2499143L,3345877L,3984391L,4065461L,5062649L,5418421L,7933109L,8865331L,11339287L,12464401L,18606089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190423Inst : IEnumerable<long>
{
public static readonly long[] Value=A190423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190423.Bytes);
public long this[int i]=>Value[i];

public static A190423Inst Instance=new A190423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190422
{
public static readonly BigInteger[] Value={ 34L,254L,3444L,76352L,2733816L,163925231L,16307921090L,2666369228454L,724501421348158L,326444188458835963L,BigInteger.Parse("242909750685458209759"),BigInteger.Parse("299419887986747081985221"),BigInteger.Parse("611366002048450741040107233") };
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
public class A190422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190422Inst Instance=new A190422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190421
{
public static readonly BigInteger[] Value={ 41L,418L,7196L,204512L,10058896L,841847949L,119691599225L,29020894570697L,11983601899221278L,8426537547806386479L,BigInteger.Parse("10092907365256801760968"),BigInteger.Parse("20589467353675961113678823"),BigInteger.Parse("71537585310236891049512559411") };
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
public class A190421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190421Inst Instance=new A190421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190420
{
public static readonly BigInteger[] Value={ 44L,363L,6072L,191360L,10093200L,935338785L,154543989072L,44556415740672L,22668584136931568L,BigInteger.Parse("20377347136466565883"),BigInteger.Parse("32182451728510291871740"),BigInteger.Parse("89502269428191719999392640"),BigInteger.Parse("438593646987789744491801743584") };
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
public class A190420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190420Inst Instance=new A190420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190419
{
public static readonly BigInteger[] Value={ 56L,728L,17472L,768768L,62270208L,9278260992L,2542243511808L,1281290729951232L,1187756506664792064L,BigInteger.Parse("2025124843863470469120"),BigInteger.Parse("6350791510355843391160320"),BigInteger.Parse("36631365431732504680212725760"),BigInteger.Parse("388622155865250142152376807587840") };
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
public class A190419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190419Inst Instance=new A190419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190418
{
public static readonly BigInteger[] Value={ 37L,290L,4174L,103218L,4268160L,302857233L,36530501839L,7448773789365L,2604518117252310L,1552614799946248963L,BigInteger.Parse("1570623177380821866672"),BigInteger.Parse("2710542814101229129928033"),BigInteger.Parse("7970415278138699394079102815") };
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
public class A190418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190418Inst Instance=new A190418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190417
{
public static readonly BigInteger[] Value={ 45L,497L,9580L,319760L,18980021L,1980733945L,363632891784L,117655174702396L,67024501865532719L,BigInteger.Parse("67232893079939036305"),BigInteger.Parse("118774251891797912665388"),BigInteger.Parse("369496334618903888548799176"),BigInteger.Parse("2024200318811320542229843621759") };
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
public class A190417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190417Inst Instance=new A190417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190416
{
public static readonly BigInteger[] Value={ 48L,432L,7776L,279936L,18475776L,2235568896L,491825157120L,196730062848000L,145580246507520000L,BigInteger.Parse("199299357468794880000"),BigInteger.Parse("501437183391487918080000"),BigInteger.Parse("2318645536002240133201920000"),BigInteger.Parse("19708487056019041132216320000000") };
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
public class A190416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190416Inst Instance=new A190416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190415
{
public static readonly long[] Value={ 1L,4L,3L,6L,4L,9L,6L,0L,4L,3L,9L,0L,2L,2L,0L,4L,2L,6L,0L,1L,8L,5L,3L,8L,1L,7L,6L,0L,0L,8L,5L,7L,5L,4L,5L,5L,1L,0L,0L,7L,0L,6L,0L,0L,0L,2L,8L,5L,6L,2L,0L,2L,4L,6L,7L,3L,7L,2L,4L,7L,8L,9L,5L,9L,6L,2L,7L,6L,5L,9L,2L,9L,8L,1L,4L,9L,7L,0L,4L,2L,2L,7L,7L,1L,2L,6L,9L,5L,6L,2L,8L,1L,8L,9L,0L,4L,3L,8L,8L,1L,1L,2L,8L,0L,7L,2L,6L,7L,8L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190415Inst : IEnumerable<long>
{
public static readonly long[] Value=A190415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190415.Bytes);
public long this[int i]=>Value[i];

public static A190415Inst Instance=new A190415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190414
{
public static readonly long[] Value={ 1L,2490L,567L,756L,425L,510L,70L,80L,90L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190414Inst : IEnumerable<long>
{
public static readonly long[] Value=A190414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190414.Bytes);
public long this[int i]=>Value[i];

public static A190414Inst Instance=new A190414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190413
{
public static readonly long[] Value={ 1L,1245L,189L,189L,85L,85L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190413Inst : IEnumerable<long>
{
public static readonly long[] Value=A190413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190413.Bytes);
public long this[int i]=>Value[i];

public static A190413Inst Instance=new A190413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190412
{
public static readonly long[] Value={ 8L,5L,6L,3L,5L,0L,3L,9L,5L,6L,0L,9L,7L,7L,9L,5L,7L,3L,9L,8L,1L,4L,6L,1L,8L,2L,3L,9L,9L,1L,4L,2L,4L,5L,4L,4L,8L,9L,9L,2L,9L,3L,9L,9L,9L,7L,1L,4L,3L,7L,9L,7L,5L,3L,2L,6L,2L,7L,5L,2L,1L,0L,4L,0L,3L,7L,2L,3L,4L,0L,7L,0L,1L,8L,5L,0L,2L,9L,5L,7L,7L,2L,2L,8L,7L,3L,0L,4L,3L,7L,1L,8L,1L,0L,9L,5L,6L,1L,1L,8L,8L,7L,1L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190412Inst : IEnumerable<long>
{
public static readonly long[] Value=A190412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190412.Bytes);
public long this[int i]=>Value[i];

public static A190412Inst Instance=new A190412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190347
{
public static readonly long[] Value={ 2L,5L,8L,12L,14L,17L,21L,24L,26L,29L,33L,36L,39L,42L,45L,48L,51L,54L,57L,60L,64L,67L,69L,72L,76L,79L,81L,85L,88L,91L,95L,97L,100L,103L,107L,109L,112L,116L,119L,121L,124L,128L,131L,134L,137L,140L,143L,146L,149L,152L,155L,159L,162L,164L,168L,171L,174L,176L,180L,183L,186L,190L,192L,195L,198L,202L,204L,207L,211L,214L,216L,219L,223L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190347Inst : IEnumerable<long>
{
public static readonly long[] Value=A190347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190347.Bytes);
public long this[int i]=>Value[i];

public static A190347Inst Instance=new A190347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190346
{
public static readonly long[] Value={ 4L,10L,14L,20L,24L,30L,35L,40L,45L,50L,55L,60L,65L,71L,75L,81L,85L,91L,96L,101L,106L,111L,116L,121L,126L,132L,136L,142L,146L,152L,157L,162L,167L,172L,177L,182L,187L,193L,197L,203L,207L,213L,217L,223L,228L,233L,238L,243L,248L,254L,258L,264L,268L,274L,278L,284L,289L,294L,299L,304L,309L,315L,319L,325L,329L,335L,339L,345L,350L,355L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190346Inst : IEnumerable<long>
{
public static readonly long[] Value=A190346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190346.Bytes);
public long this[int i]=>Value[i];

public static A190346Inst Instance=new A190346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190345
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,13L,16L,17L,20L,21L,23L,26L,27L,30L,32L,33L,36L,38L,40L,42L,43L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,71L,72L,74L,77L,78L,81L,82L,84L,87L,88L,91L,93L,94L,97L,98L,101L,103L,104L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,132L,133L,135L,138L,139L,142L,143L,145L,148L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190345Inst : IEnumerable<long>
{
public static readonly long[] Value=A190345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190345.Bytes);
public long this[int i]=>Value[i];

public static A190345Inst Instance=new A190345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190344
{
public static readonly long[] Value={ 2L,6L,8L,12L,15L,18L,22L,25L,28L,31L,34L,37L,41L,44L,47L,51L,53L,57L,61L,63L,67L,69L,73L,76L,79L,83L,86L,89L,92L,95L,99L,102L,105L,108L,112L,114L,118L,122L,124L,128L,130L,134L,137L,140L,144L,147L,150L,153L,156L,160L,163L,166L,169L,173L,175L,179L,183L,185L,189L,191L,195L,199L,201L,205L,208L,211L,214L,218L,221L,224L,227L,230L,234L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190344Inst : IEnumerable<long>
{
public static readonly long[] Value=A190344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190344.Bytes);
public long this[int i]=>Value[i];

public static A190344Inst Instance=new A190344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190343
{
public static readonly long[] Value={ 1L,1L,3L,8L,25L,88L,343L,1448L,6561L,31622L,161051L,861979L,4826809L,28172943L,170859375L,1073741824L,6975757441L,46753733110L,322687697779L,2289733608959L,16679880978201L,124577080440588L,952809757913927L,7454684703958210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190343Inst : IEnumerable<long>
{
public static readonly long[] Value=A190343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190343.Bytes);
public long this[int i]=>Value[i];

public static A190343Inst Instance=new A190343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190342
{
public static readonly BigInteger[] Value={ 4L,12L,52L,308L,2520L,29268L,471012L,10566004L,331575100L,14510475976L,885694047808L,75478844279780L,8975435807171244L,1489232331953993836L,BigInteger.Parse("344849471434261285096"),BigInteger.Parse("111434896145450843664604") };
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
public class A190342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190342Inst Instance=new A190342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190341
{
public static readonly BigInteger[] Value={ 3L,9L,40L,273L,2727L,41520L,944307L,32403123L,1667310336L,129124175985L,15018894671481L,2626862719652352L,690390044069042835L,BigInteger.Parse("272767004386769371833"),BigInteger.Parse("161965593156881121867648") };
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
public class A190341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190341.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190341Inst Instance=new A190341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190340
{
public static readonly BigInteger[] Value={ 4L,12L,72L,720L,10800L,259200L,10368000L,673920000L,70087680000L,11774730240000L,3214501355520000L,1420809599139840000L,BigInteger.Parse("1014458053785845760000"),BigInteger.Parse("1171699052122651852800000"),BigInteger.Parse("2191077227469358964736000000") };
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
public class A190340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190340Inst Instance=new A190340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190339
{
public static readonly long[] Value={ 2L,6L,15L,105L,105L,231L,15015L,2145L,36465L,969969L,4849845L,10140585L,10140585L,22287L,3231615L,7713865005L,7713865005L,90751353L,218257003965L,1641030105L,67282234305L,368217318651L,1841086593255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190339Inst : IEnumerable<long>
{
public static readonly long[] Value=A190339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190339.Bytes);
public long this[int i]=>Value[i];

public static A190339Inst Instance=new A190339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190338
{
public static readonly long[] Value={ 1L,4L,4L,4L,4L,1L,4L,4L,4L,4L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,2L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,1L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190338Inst : IEnumerable<long>
{
public static readonly long[] Value=A190338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190338.Bytes);
public long this[int i]=>Value[i];

public static A190338Inst Instance=new A190338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190337
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,34L,40L,46L,52L,58L,64L,69L,75L,81L,87L,93L,99L,104L,110L,116L,122L,128L,134L,139L,145L,151L,157L,163L,169L,174L,180L,186L,192L,198L,203L,209L,215L,221L,227L,233L,238L,244L,250L,256L,262L,268L,273L,279L,285L,291L,297L,303L,308L,314L,320L,326L,332L,338L,343L,349L,355L,361L,367L,373L,378L,384L,390L,396L,402L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190337Inst : IEnumerable<long>
{
public static readonly long[] Value=A190337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190337.Bytes);
public long this[int i]=>Value[i];

public static A190337Inst Instance=new A190337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190336
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,19L,23L,25L,29L,31L,34L,37L,40L,43L,46L,49L,52L,54L,58L,60L,64L,66L,69L,72L,75L,78L,81L,84L,87L,89L,93L,95L,99L,101L,104L,107L,110L,113L,116L,118L,122L,124L,128L,130L,134L,136L,139L,142L,145L,148L,151L,153L,157L,159L,163L,165L,169L,171L,174L,177L,180L,183L,186L,188L,192L,194L,198L,200L,203L,206L,209L,212L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190336Inst : IEnumerable<long>
{
public static readonly long[] Value=A190336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190336.Bytes);
public long this[int i]=>Value[i];

public static A190336Inst Instance=new A190336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190335
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,12L,13L,15L,18L,20L,21L,24L,26L,27L,30L,32L,35L,36L,38L,41L,42L,44L,47L,48L,50L,53L,55L,56L,59L,61L,62L,65L,67L,70L,71L,73L,76L,77L,79L,82L,83L,85L,88L,90L,91L,94L,96L,97L,100L,102L,105L,106L,108L,111L,112L,114L,117L,119L,120L,123L,125L,126L,129L,131L,132L,135L,137L,140L,141L,143L,146L,147L,149L,152L,154L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190335Inst : IEnumerable<long>
{
public static readonly long[] Value=A190335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190335.Bytes);
public long this[int i]=>Value[i];

public static A190335Inst Instance=new A190335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190334
{
public static readonly long[] Value={ 5L,11L,17L,22L,28L,34L,40L,45L,51L,57L,63L,68L,74L,80L,85L,91L,97L,103L,108L,114L,120L,126L,131L,137L,143L,149L,154L,160L,166L,171L,177L,183L,189L,194L,200L,206L,212L,217L,223L,229L,235L,240L,246L,252L,257L,263L,269L,275L,280L,286L,292L,298L,303L,309L,315L,320L,326L,332L,338L,343L,349L,355L,361L,366L,372L,378L,384L,389L,395L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190334Inst : IEnumerable<long>
{
public static readonly long[] Value=A190334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190334.Bytes);
public long this[int i]=>Value[i];

public static A190334Inst Instance=new A190334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190333
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,11L,13L,14L,17L,18L,20L,22L,24L,26L,28L,30L,31L,34L,35L,37L,40L,41L,43L,45L,47L,49L,51L,53L,54L,57L,58L,60L,63L,64L,66L,68L,70L,71L,74L,76L,77L,80L,81L,83L,85L,87L,89L,91L,93L,94L,97L,99L,100L,103L,104L,106L,108L,110L,112L,114L,116L,117L,120L,121L,123L,126L,127L,129L,131L,133L,134L,137L,139L,140L,143L,144L,146L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190333Inst : IEnumerable<long>
{
public static readonly long[] Value=A190333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190333.Bytes);
public long this[int i]=>Value[i];

public static A190333Inst Instance=new A190333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190332
{
public static readonly long[] Value={ 2L,6L,9L,12L,15L,19L,23L,25L,29L,32L,36L,38L,42L,46L,48L,52L,55L,59L,61L,65L,69L,72L,75L,78L,82L,86L,88L,92L,95L,98L,101L,105L,109L,111L,115L,118L,122L,124L,128L,132L,135L,138L,141L,145L,147L,151L,155L,158L,161L,164L,168L,172L,174L,178L,181L,184L,187L,191L,195L,197L,201L,204L,208L,210L,214L,218L,221L,224L,227L,231L,233L,237L,241L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190332Inst : IEnumerable<long>
{
public static readonly long[] Value=A190332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190332.Bytes);
public long this[int i]=>Value[i];

public static A190332Inst Instance=new A190332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190267
{
public static readonly long[] Value={ 19L,51L,243L,244L,424L,476L,604L,638L,723L,846L,926L,1683L,1774L,2008L,2524L,2526L,2528L,3124L,3176L,3178L,4204L,4476L,4526L,4924L,5824L,6726L,6812L,6963L,7300L,7443L,7676L,8426L,8958L,8974L,9458L,9926L,10052L,10083L,10468L,11674L,11710L,12428L,12483L,12592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190267Inst : IEnumerable<long>
{
public static readonly long[] Value=A190267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190267.Bytes);
public long this[int i]=>Value[i];

public static A190267Inst Instance=new A190267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190266
{
public static readonly long[] Value={ 7L,1241L,1673L,1751L,1769L,2471L,2839L,3161L,3305L,3497L,3711L,4135L,4265L,4279L,4471L,4711L,5191L,5433L,5561L,6017L,6041L,6103L,6313L,6809L,6953L,7031L,7241L,7463L,7671L,8023L,8057L,8345L,8791L,8889L,9079L,10169L,10793L,10891L,11111L,11209L,11391L,11751L,12297L,13207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190266Inst : IEnumerable<long>
{
public static readonly long[] Value=A190266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190266.Bytes);
public long this[int i]=>Value[i];

public static A190266Inst Instance=new A190266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190265
{
public static readonly long[] Value={ 6L,12L,19L,25L,31L,38L,44L,50L,57L,63L,69L,77L,83L,89L,96L,102L,108L,115L,121L,128L,134L,140L,147L,154L,160L,167L,173L,179L,186L,192L,198L,205L,211L,217L,225L,231L,237L,244L,250L,257L,263L,269L,276L,282L,288L,295L,302L,308L,315L,321L,327L,334L,340L,346L,353L,359L,365L,372L,379L,386L,392L,398L,405L,411L,417L,424L,430L,436L,443L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190265Inst : IEnumerable<long>
{
public static readonly long[] Value=A190265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190265.Bytes);
public long this[int i]=>Value[i];

public static A190265Inst Instance=new A190265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190264
{
public static readonly long[] Value={ 1L,7L,1L,6L,9L,9L,0L,5L,6L,6L,0L,2L,8L,3L,0L,1L,9L,0L,5L,6L,6L,0L,3L,3L,0L,1L,8L,8L,8L,1L,1L,3L,2L,0L,3L,5L,8L,4L,9L,1L,8L,1L,1L,3L,1L,6L,7L,0L,7L,5L,6L,0L,6L,6L,0L,3L,3L,1L,4L,9L,0L,7L,2L,4L,4L,9L,0L,0L,1L,1L,4L,5L,4L,7L,9L,2L,5L,5L,9L,0L,2L,9L,2L,7L,0L,5L,1L,3L,4L,9L,3L,4L,4L,5L,1L,9L,2L,0L,5L,2L,2L,6L,7L,5L,0L,6L,4L,8L,7L,1L,4L,0L,8L,7L,4L,9L,3L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190264Inst : IEnumerable<long>
{
public static readonly long[] Value=A190264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190264.Bytes);
public long this[int i]=>Value[i];

public static A190264Inst Instance=new A190264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190263
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,2L,1L,1L,1L,1L,8L,2L,17L,2L,3L,10L,2L,23L,1L,4L,1L,2L,1L,4L,1L,2L,35L,4L,1L,1L,1L,2L,5L,4L,1L,1L,3L,17L,3L,2L,1L,3L,1L,3L,1L,1L,10L,3L,1L,13L,1L,1L,1L,4L,1L,2L,2L,2L,1L,2L,15L,3L,2L,5L,6L,2L,1L,15L,132L,4L,2L,1L,1L,19L,1L,4L,1L,2L,5L,2L,16L,2L,1L,15L,5L,2L,10L,13L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190263Inst : IEnumerable<long>
{
public static readonly long[] Value=A190263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190263.Bytes);
public long this[int i]=>Value[i];

public static A190263Inst Instance=new A190263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190262
{
public static readonly long[] Value={ 1L,4L,0L,9L,5L,8L,7L,9L,6L,6L,7L,1L,3L,2L,9L,4L,7L,3L,1L,5L,1L,8L,2L,2L,6L,4L,6L,6L,1L,1L,9L,6L,5L,9L,8L,7L,6L,2L,4L,0L,7L,3L,0L,8L,8L,8L,5L,9L,1L,1L,5L,6L,3L,5L,5L,2L,8L,8L,5L,5L,5L,7L,2L,5L,2L,1L,3L,8L,1L,6L,0L,5L,3L,9L,3L,2L,6L,8L,3L,5L,4L,3L,1L,3L,3L,4L,7L,9L,9L,7L,9L,3L,8L,8L,1L,4L,6L,9L,7L,6L,0L,9L,9L,0L,7L,0L,2L,2L,6L,7L,8L,6L,1L,4L,5L,5L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190262Inst : IEnumerable<long>
{
public static readonly long[] Value=A190262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190262.Bytes);
public long this[int i]=>Value[i];

public static A190262Inst Instance=new A190262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190261
{
public static readonly long[] Value={ 1L,2L,11L,32L,1L,4L,10L,2L,1L,1L,3L,1L,1L,5L,2L,3L,2L,1L,4L,2L,3L,2L,41L,1L,2L,1L,1L,3L,4L,1L,35L,1L,5L,1L,29661L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,5L,2L,2L,2L,1L,1L,1L,5L,15L,2L,1L,1L,1L,2L,7L,1L,1L,1L,13L,1L,1L,1L,1L,20L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,3L,14L,1L,8L,2L,1L,1L,1L,1L,2L,1L,3L,2L,3L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190261Inst : IEnumerable<long>
{
public static readonly long[] Value=A190261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190261.Bytes);
public long this[int i]=>Value[i];

public static A190261Inst Instance=new A190261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190260
{
public static readonly long[] Value={ 1L,4L,7L,8L,3L,1L,8L,3L,4L,3L,4L,7L,8L,5L,1L,5L,9L,5L,6L,4L,2L,2L,1L,0L,4L,4L,3L,6L,3L,8L,5L,0L,2L,2L,2L,1L,5L,2L,5L,3L,2L,1L,2L,1L,1L,5L,0L,4L,9L,9L,0L,6L,4L,1L,6L,7L,0L,8L,4L,0L,3L,9L,1L,0L,2L,6L,4L,9L,9L,8L,0L,5L,4L,3L,7L,0L,5L,7L,3L,3L,2L,3L,3L,6L,7L,5L,1L,8L,8L,2L,0L,7L,4L,0L,8L,2L,1L,3L,6L,6L,9L,7L,8L,1L,0L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190260Inst : IEnumerable<long>
{
public static readonly long[] Value=A190260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190260.Bytes);
public long this[int i]=>Value[i];

public static A190260Inst Instance=new A190260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190259
{
public static readonly long[] Value={ 2L,11L,32L,1L,4L,10L,2L,1L,1L,3L,1L,1L,5L,2L,3L,2L,1L,4L,2L,3L,2L,41L,1L,2L,1L,1L,3L,4L,1L,35L,1L,5L,1L,29661L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,5L,2L,2L,2L,1L,1L,1L,5L,15L,2L,1L,1L,1L,2L,7L,1L,1L,1L,13L,1L,1L,1L,1L,20L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,3L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190259Inst : IEnumerable<long>
{
public static readonly long[] Value=A190259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190259.Bytes);
public long this[int i]=>Value[i];

public static A190259Inst Instance=new A190259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190258
{
public static readonly long[] Value={ 2L,0L,9L,0L,6L,5L,7L,8L,5L,0L,8L,5L,2L,2L,4L,4L,7L,7L,5L,7L,1L,0L,0L,8L,9L,6L,3L,5L,0L,0L,5L,2L,2L,1L,3L,2L,8L,0L,9L,5L,8L,8L,0L,1L,7L,1L,5L,3L,5L,0L,8L,9L,6L,1L,5L,2L,7L,0L,1L,5L,4L,0L,8L,0L,1L,3L,6L,5L,3L,8L,6L,8L,6L,5L,8L,2L,3L,0L,1L,7L,6L,3L,7L,1L,1L,4L,3L,1L,5L,0L,4L,0L,4L,6L,0L,4L,2L,6L,3L,8L,4L,6L,7L,1L,8L,0L,8L,3L,2L,7L,8L,0L,6L,7L,6L,9L,3L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190258Inst : IEnumerable<long>
{
public static readonly long[] Value=A190258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190258.Bytes);
public long this[int i]=>Value[i];

public static A190258Inst Instance=new A190258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190257
{
public static readonly long[] Value={ 2L,3L,1L,2L,5L,2L,1L,5L,95L,1L,1L,2L,1L,9L,3L,1L,1L,53L,1L,1L,1L,2L,3L,1L,7L,5L,1L,3L,8L,1L,5L,4L,1L,18L,1L,1L,6L,2L,25L,3L,5L,1L,5L,2L,4L,2L,1L,1L,43L,1L,1L,8L,1L,24L,3L,21L,1L,7L,4L,1L,13L,2L,1L,2L,1L,1811L,1L,3L,9L,1L,9L,2L,1L,1L,1L,2L,2L,23L,1L,1L,2L,1L,8L,6L,6L,2L,2L,2L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190257Inst : IEnumerable<long>
{
public static readonly long[] Value=A190257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190257.Bytes);
public long this[int i]=>Value[i];

public static A190257Inst Instance=new A190257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190256
{
public static readonly long[] Value={ 2L,2L,7L,1L,2L,8L,1L,5L,6L,2L,4L,2L,2L,9L,9L,4L,1L,4L,2L,3L,1L,3L,0L,5L,8L,0L,6L,8L,7L,5L,9L,7L,2L,6L,8L,5L,5L,4L,5L,5L,8L,4L,9L,2L,6L,9L,1L,0L,2L,1L,4L,3L,4L,3L,2L,8L,7L,4L,9L,0L,8L,2L,8L,2L,6L,5L,9L,1L,6L,4L,3L,9L,1L,5L,4L,3L,9L,2L,2L,1L,2L,3L,6L,1L,6L,7L,1L,5L,1L,8L,5L,5L,1L,0L,2L,9L,6L,0L,3L,1L,3L,7L,3L,1L,9L,7L,0L,3L,3L,5L,9L,4L,8L,5L,3L,0L,0L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190256Inst : IEnumerable<long>
{
public static readonly long[] Value=A190256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190256.Bytes);
public long this[int i]=>Value[i];

public static A190256Inst Instance=new A190256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190255
{
public static readonly long[] Value={ 1L,1L,3L,7L,18L,48L,131L,365L,1034L,2968L,8615L,25243L,74565L,221807L,663869L,1997765L,6040894L,18345668L,55931289L,171121717L,525225943L,1616805005L,4990386995L,15441275375L,47887524320L,148826022290L,463433496815L,1445737785557L,4517857601552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190255Inst : IEnumerable<long>
{
public static readonly long[] Value=A190255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190255.Bytes);
public long this[int i]=>Value[i];

public static A190255Inst Instance=new A190255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190254
{
public static readonly long[] Value={ 1L,2L,5L,14L,40L,117L,348L,1047L,3179L,9723L,29915L,92498L,287211L,895030L,2797928L,8770635L,27560288L,86792100L,273857035L,865630975L,2740541714L,8689081394L,27586212293L,87688882320L,279055280258L,888981785349L,2834784312290L,9047795153319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190254Inst : IEnumerable<long>
{
public static readonly long[] Value=A190254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190254.Bytes);
public long this[int i]=>Value[i];

public static A190254Inst Instance=new A190254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190253
{
public static readonly long[] Value={ 1L,2L,9L,48L,265L,1512L,8813L,52112L,311427L,1876290L,11376893L,69341868L,424445996L,2607388252L,16066200465L,99256947520L,614611513599L,3813391239444L,23702418040232L,147557273500400L,919907826138042L,5742264749678028L,35886019625941713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190253Inst : IEnumerable<long>
{
public static readonly long[] Value=A190253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190253.Bytes);
public long this[int i]=>Value[i];

public static A190253Inst Instance=new A190253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190252
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,5L,3L,1L,12L,14L,9L,4L,1L,31L,38L,28L,14L,5L,1L,83L,106L,84L,48L,20L,6L,1L,227L,301L,252L,157L,75L,27L,7L,1L,634L,864L,758L,504L,265L,110L,35L,8L,1L,1799L,2508L,2283L,1602L,906L,417L,154L,44L,9L,1L,5171L,7348L,6897L,5056L,3035L,1512L,623L,208L,54L,10L,1L,15027L,21699L,20903L,15894L,10020L,5324L,2387L,894L,273L,65L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190252Inst : IEnumerable<long>
{
public static readonly long[] Value=A190252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190252.Bytes);
public long this[int i]=>Value[i];

public static A190252Inst Instance=new A190252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190203
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,11L,12L,15L,20L,21L,22L,24L,25L,28L,29L,31L,33L,37L,38L,40L,41L,42L,44L,46L,49L,50L,53L,55L,58L,59L,62L,63L,66L,67L,69L,71L,72L,75L,76L,78L,80L,82L,84L,87L,88L,91L,93L,96L,97L,100L,101L,104L,105L,107L,109L,110L,113L,114L,116L,118L,122L,125L,126L,127L,129L,131L,134L,135L,138L,142L,143L,144L,145L,147L,148L,151L,152L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190203Inst : IEnumerable<long>
{
public static readonly long[] Value=A190203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190203.Bytes);
public long this[int i]=>Value[i];

public static A190203Inst Instance=new A190203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190202
{
public static readonly long[] Value={ 1L,5L,7L,9L,10L,13L,14L,16L,17L,18L,19L,23L,26L,27L,30L,32L,34L,35L,36L,39L,43L,45L,47L,48L,51L,52L,54L,56L,57L,60L,61L,64L,65L,68L,70L,73L,74L,77L,79L,81L,83L,85L,86L,89L,90L,92L,94L,95L,98L,99L,102L,103L,106L,108L,111L,112L,115L,117L,119L,120L,121L,123L,124L,128L,130L,132L,133L,136L,137L,139L,140L,141L,146L,149L,150L,153L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190202Inst : IEnumerable<long>
{
public static readonly long[] Value=A190202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190202.Bytes);
public long this[int i]=>Value[i];

public static A190202Inst Instance=new A190202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190201
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190201Inst : IEnumerable<long>
{
public static readonly long[] Value=A190201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190201.Bytes);
public long this[int i]=>Value[i];

public static A190201Inst Instance=new A190201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190200
{
public static readonly long[] Value={ 1L,4L,5L,8L,10L,12L,13L,15L,17L,19L,20L,23L,24L,27L,30L,31L,34L,36L,38L,39L,43L,45L,46L,49L,50L,53L,55L,56L,57L,60L,62L,64L,65L,68L,69L,71L,72L,75L,76L,79L,81L,83L,86L,88L,90L,91L,94L,95L,98L,101L,102L,105L,107L,109L,110L,112L,114L,116L,117L,120L,121L,124L,127L,128L,131L,133L,135L,136L,139L,140L,142L,143L,146L,147L,150L,152L,154L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190200Inst : IEnumerable<long>
{
public static readonly long[] Value=A190200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190200.Bytes);
public long this[int i]=>Value[i];

public static A190200Inst Instance=new A190200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190199
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,11L,14L,16L,18L,21L,22L,25L,26L,28L,29L,32L,33L,35L,37L,40L,41L,42L,44L,47L,48L,51L,52L,54L,58L,59L,61L,63L,66L,67L,70L,73L,74L,77L,78L,80L,82L,84L,85L,87L,89L,92L,93L,96L,97L,99L,100L,103L,104L,106L,108L,111L,113L,115L,118L,119L,122L,123L,125L,126L,129L,130L,132L,134L,137L,138L,141L,144L,145L,148L,149L,151L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190199Inst : IEnumerable<long>
{
public static readonly long[] Value=A190199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190199.Bytes);
public long this[int i]=>Value[i];

public static A190199Inst Instance=new A190199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190198
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190198Inst : IEnumerable<long>
{
public static readonly long[] Value=A190198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190198.Bytes);
public long this[int i]=>Value[i];

public static A190198Inst Instance=new A190198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190197
{
public static readonly long[] Value={ 2L,3L,5L,11L,29L,89L,313L,1259L,5669L,28349L,155921L,935531L,6080957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190197Inst : IEnumerable<long>
{
public static readonly long[] Value=A190197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190197.Bytes);
public long this[int i]=>Value[i];

public static A190197Inst Instance=new A190197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190196
{
public static readonly BigInteger[] Value={ 1L,4L,96L,5760L,645120L,16588800L,30656102400L,11158821273600L,109310902272000L,3278015337332736000L,BigInteger.Parse("191637819720990720000"),BigInteger.Parse("25296192203170775040000"),BigInteger.Parse("2541356653499348743618560000"),BigInteger.Parse("3303763649549153366704128000000"),BigInteger.Parse("713612948302617127208091648000000") };
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
public class A190196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190196Inst Instance=new A190196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190195
{
public static readonly BigInteger[] Value={ 1L,-1L,7L,-139L,5473L,-51103L,34988647L,-4784061619L,17782347217L,-203906055033841L,4586025046220899L,-234038275571853889L,BigInteger.Parse("9127322584507530151393"),BigInteger.Parse("-4621897483978366951337161"),BigInteger.Parse("390009953658229908025520161"),BigInteger.Parse("-1860452328661957054823447670979"),BigInteger.Parse("111446346975327291562408943638981"),BigInteger.Parse("-14050053632877769956552601074149491"),BigInteger.Parse("1269258883676324618437848731917951368967"),BigInteger.Parse("-1408182090109327874242950762763137949746859") };
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
public class A190195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190195Inst Instance=new A190195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190194
{
public static readonly BigInteger[] Value={ 0L,1L,4L,20L,116L,776L,5912L,50648L,482552L,5065016L,58099832L,723315128L,9715154552L,140051879096L,2157103991672L,35355232693688L,614453167841912L,11287370521073336L,218535622980161912L,4447889360078673848L,BigInteger.Parse("94944254697268017272"),BigInteger.Parse("2120984032794061422776"),BigInteger.Parse("49489160848954807154552"),BigInteger.Parse("1203943675008917425902008"),BigInteger.Parse("30486416629523244528307832") };
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
public class A190194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190194Inst Instance=new A190194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190193
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,11L,12L,14L,18L,19L,21L,24L,25L,26L,28L,31L,33L,35L,36L,38L,41L,42L,43L,45L,48L,50L,52L,53L,55L,59L,60L,62L,65L,66L,67L,69L,70L,72L,76L,77L,79L,82L,83L,84L,86L,89L,91L,93L,94L,96L,100L,101L,103L,106L,108L,110L,111L,113L,117L,118L,120L,123L,124L,125L,127L,130L,132L,134L,135L,137L,140L,141L,142L,144L,147L,149L,151L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190193Inst : IEnumerable<long>
{
public static readonly long[] Value=A190193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190193.Bytes);
public long this[int i]=>Value[i];

public static A190193Inst Instance=new A190193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190192
{
public static readonly long[] Value={ 3L,5L,6L,8L,10L,13L,15L,16L,17L,20L,22L,23L,27L,29L,30L,32L,34L,37L,39L,40L,44L,46L,47L,49L,51L,54L,56L,57L,58L,61L,63L,64L,68L,71L,73L,74L,75L,78L,80L,81L,85L,87L,88L,90L,92L,95L,97L,98L,99L,102L,104L,105L,107L,109L,112L,114L,115L,116L,119L,121L,122L,126L,128L,129L,131L,133L,136L,138L,139L,143L,145L,146L,148L,150L,153L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190192Inst : IEnumerable<long>
{
public static readonly long[] Value=A190192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190192.Bytes);
public long this[int i]=>Value[i];

public static A190192Inst Instance=new A190192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190191
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190191Inst : IEnumerable<long>
{
public static readonly long[] Value=A190191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190191.Bytes);
public long this[int i]=>Value[i];

public static A190191Inst Instance=new A190191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190190
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,12L,13L,15L,16L,18L,19L,24L,25L,26L,27L,29L,32L,35L,36L,37L,38L,40L,43L,47L,48L,50L,51L,54L,57L,59L,61L,62L,64L,65L,70L,71L,72L,73L,75L,76L,82L,83L,84L,86L,89L,93L,94L,95L,96L,97L,100L,103L,105L,106L,107L,108L,111L,114L,118L,119L,121L,122L,125L,128L,129L,130L,132L,133L,135L,140L,141L,142L,143L,144L,146L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190190Inst : IEnumerable<long>
{
public static readonly long[] Value=A190190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190190.Bytes);
public long this[int i]=>Value[i];

public static A190190Inst Instance=new A190190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190189
{
public static readonly long[] Value={ 3L,6L,7L,9L,10L,11L,14L,17L,20L,21L,22L,23L,28L,30L,31L,33L,34L,39L,41L,42L,44L,45L,46L,49L,52L,53L,55L,56L,58L,60L,63L,66L,67L,68L,69L,74L,77L,78L,79L,80L,81L,85L,87L,88L,90L,91L,92L,98L,99L,101L,102L,104L,109L,110L,112L,113L,115L,116L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190189Inst : IEnumerable<long>
{
public static readonly long[] Value=A190189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190189.Bytes);
public long this[int i]=>Value[i];

public static A190189Inst Instance=new A190189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190188
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190188Inst : IEnumerable<long>
{
public static readonly long[] Value=A190188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190188.Bytes);
public long this[int i]=>Value[i];

public static A190188Inst Instance=new A190188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190043
{
public static readonly long[] Value={ 2L,10L,14L,27L,23L,47L,31L,65L,49L,76L,52L,113L,58L,109L,92L,132L,78L,167L,87L,172L,127L,172L,108L,240L,116L,208L,167L,237L,133L,292L,143L,272L,205L,271L,169L,366L,167L,307L,244L,348L,189L,407L,198L,377L,290L,369L,218L,493L,223L,413L,322L,445L,244L,528L,263L,482L,358L,468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190043Inst : IEnumerable<long>
{
public static readonly long[] Value=A190043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190043.Bytes);
public long this[int i]=>Value[i];

public static A190043Inst Instance=new A190043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190042
{
public static readonly long[] Value={ 2L,8L,10L,18L,16L,30L,22L,40L,31L,49L,36L,64L,41L,71L,53L,81L,55L,97L,61L,103L,74L,112L,75L,131L,80L,134L,96L,144L,94L,164L,100L,166L,117L,175L,114L,198L,119L,197L,139L,207L,133L,231L,139L,229L,160L,238L,153L,265L,158L,260L,182L,270L,172L,298L,178L,292L,203L,301L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190042Inst : IEnumerable<long>
{
public static readonly long[] Value=A190042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190042.Bytes);
public long this[int i]=>Value[i];

public static A190042Inst Instance=new A190042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190041
{
public static readonly long[] Value={ 2L,4L,2L,5L,6L,2L,7L,7L,8L,2L,8L,12L,10L,10L,2L,10L,12L,18L,14L,12L,2L,11L,18L,16L,27L,18L,14L,2L,13L,17L,30L,23L,39L,22L,16L,2L,14L,24L,22L,47L,33L,53L,26L,18L,2L,16L,22L,40L,31L,72L,45L,69L,30L,20L,2L,17L,30L,31L,65L,43L,107L,57L,87L,34L,22L,2L,19L,27L,49L,49L,105L,60L,151L,69L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190041Inst : IEnumerable<long>
{
public static readonly long[] Value=A190041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190041.Bytes);
public long this[int i]=>Value[i];

public static A190041Inst Instance=new A190041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190040
{
public static readonly long[] Value={ 13L,24L,40L,65L,105L,164L,246L,349L,472L,617L,786L,981L,1204L,1457L,1742L,2061L,2416L,2809L,3242L,3717L,4236L,4801L,5414L,6077L,6792L,7561L,8386L,9269L,10212L,11217L,12286L,13421L,14624L,15897L,17242L,18661L,20156L,21729L,23382L,25117L,26936L,28841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190040Inst : IEnumerable<long>
{
public static readonly long[] Value=A190040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190040.Bytes);
public long this[int i]=>Value[i];

public static A190040Inst Instance=new A190040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190039
{
public static readonly long[] Value={ 11L,17L,22L,31L,43L,60L,80L,100L,120L,140L,160L,180L,200L,220L,240L,260L,280L,300L,320L,340L,360L,380L,400L,420L,440L,460L,480L,500L,520L,540L,560L,580L,600L,620L,640L,660L,680L,700L,720L,740L,760L,780L,800L,820L,840L,860L,880L,900L,920L,940L,960L,980L,1000L,1020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190039Inst : IEnumerable<long>
{
public static readonly long[] Value=A190039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190039.Bytes);
public long this[int i]=>Value[i];

public static A190039Inst Instance=new A190039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190038
{
public static readonly long[] Value={ 10L,18L,30L,47L,72L,107L,151L,203L,263L,331L,407L,491L,583L,683L,791L,907L,1031L,1163L,1303L,1451L,1607L,1771L,1943L,2123L,2311L,2507L,2711L,2923L,3143L,3371L,3607L,3851L,4103L,4363L,4631L,4907L,5191L,5483L,5783L,6091L,6407L,6731L,7063L,7403L,7751L,8107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190038Inst : IEnumerable<long>
{
public static readonly long[] Value=A190038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190038.Bytes);
public long this[int i]=>Value[i];

public static A190038Inst Instance=new A190038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190037
{
public static readonly long[] Value={ 8L,12L,16L,23L,33L,45L,57L,69L,81L,93L,105L,117L,129L,141L,153L,165L,177L,189L,201L,213L,225L,237L,249L,261L,273L,285L,297L,309L,321L,333L,345L,357L,369L,381L,393L,405L,417L,429L,441L,453L,465L,477L,489L,501L,513L,525L,537L,549L,561L,573L,585L,597L,609L,621L,633L,645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190037Inst : IEnumerable<long>
{
public static readonly long[] Value=A190037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190037.Bytes);
public long this[int i]=>Value[i];

public static A190037Inst Instance=new A190037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190036
{
public static readonly long[] Value={ 7L,12L,18L,27L,39L,53L,69L,87L,107L,129L,153L,179L,207L,237L,269L,303L,339L,377L,417L,459L,503L,549L,597L,647L,699L,753L,809L,867L,927L,989L,1053L,1119L,1187L,1257L,1329L,1403L,1479L,1557L,1637L,1719L,1803L,1889L,1977L,2067L,2159L,2253L,2349L,2447L,2547L,2649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190036Inst : IEnumerable<long>
{
public static readonly long[] Value=A190036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190036.Bytes);
public long this[int i]=>Value[i];

public static A190036Inst Instance=new A190036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190035
{
public static readonly long[] Value={ 5L,7L,10L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,70L,74L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,134L,138L,142L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,230L,234L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190035Inst : IEnumerable<long>
{
public static readonly long[] Value=A190035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190035.Bytes);
public long this[int i]=>Value[i];

public static A190035Inst Instance=new A190035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190034
{
public static readonly long[] Value={ 2L,6L,10L,27L,33L,107L,80L,349L,264L,735L,357L,2809L,736L,2565L,3262L,10997L,1258L,17921L,2313L,34880L,12649L,17448L,4348L,211004L,15839L,42957L,49372L,169716L,10846L,430082L,11210L,1004561L,85127L,101536L,102904L,2715826L,20183L,190249L,208100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190034Inst : IEnumerable<long>
{
public static readonly long[] Value=A190034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190034.Bytes);
public long this[int i]=>Value[i];

public static A190034Inst Instance=new A190034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190033
{
public static readonly long[] Value={ 512L,112L,112L,228L,45L,228L,415L,79L,79L,415L,616L,155L,158L,155L,616L,880L,235L,274L,274L,235L,880L,1205L,295L,362L,458L,362L,295L,1205L,1508L,355L,430L,578L,578L,430L,355L,1508L,2008L,423L,506L,670L,834L,670L,506L,423L,2008L,2793L,531L,610L,790L,970L,970L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190033Inst : IEnumerable<long>
{
public static readonly long[] Value=A190033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190033.Bytes);
public long this[int i]=>Value[i];

public static A190033Inst Instance=new A190033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190032
{
public static readonly long[] Value={ 1508L,423L,610L,966L,1418L,1834L,2362L,3018L,3834L,5122L,6886L,9242L,12530L,16874L,22626L,30959L,42112L,57029L,77815L,105765L,143231L,194899L,264884L,359302L,488708L,664381L,901953L,1226181L,1666661L,2263458L,3076317L,4181101L,5679774L,7718737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190032Inst : IEnumerable<long>
{
public static readonly long[] Value=A190032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190032.Bytes);
public long this[int i]=>Value[i];

public static A190032Inst Instance=new A190032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190031
{
public static readonly long[] Value={ 1205L,355L,506L,790L,1162L,1494L,1910L,2362L,3002L,4006L,5390L,7234L,9790L,13178L,17955L,24448L,33157L,45099L,61313L,83131L,112959L,153552L,208458L,283316L,385153L,523121L,710869L,966189L,1312546L,1783541L,2423945L,3293354L,4475149L,6081673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190031Inst : IEnumerable<long>
{
public static readonly long[] Value=A190031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190031.Bytes);
public long this[int i]=>Value[i];

public static A190031Inst Instance=new A190031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190030
{
public static readonly long[] Value={ 880L,295L,430L,670L,970L,1230L,1494L,1834L,2338L,3142L,4226L,5674L,7686L,10543L,14268L,19361L,26383L,35721L,48439L,65943L,89488L,121506L,165332L,224537L,304933L,414641L,563273L,765114L,1040093L,1413201L,1919914L,2609473L,3545793L,4817559L,6547150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190030Inst : IEnumerable<long>
{
public static readonly long[] Value=A190030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190030.Bytes);
public long this[int i]=>Value[i];

public static A190030Inst Instance=new A190030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190029
{
public static readonly long[] Value={ 616L,235L,362L,578L,834L,970L,1162L,1418L,1802L,2446L,3314L,4446L,6199L,8432L,11313L,15459L,20953L,28227L,38519L,52392L,70926L,96624L,131397L,178105L,242269L,329381L,446962L,607697L,826153L,1121786L,1524737L,2072521L,2815063L,3825658L,5199542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190029Inst : IEnumerable<long>
{
public static readonly long[] Value=A190029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190029.Bytes);
public long this[int i]=>Value[i];

public static A190029Inst Instance=new A190029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190028
{
public static readonly long[] Value={ 415L,155L,274L,458L,578L,670L,790L,966L,1242L,1702L,2338L,3247L,4460L,6025L,8139L,11017L,14883L,20207L,27508L,37362L,50788L,69069L,93769L,127365L,173117L,235142L,319489L,434273L,590030L,801705L,1089569L,1480431L,2011558L,2733658L,3714513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190028Inst : IEnumerable<long>
{
public static readonly long[] Value=A190028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190028.Bytes);
public long this[int i]=>Value[i];

public static A190028Inst Instance=new A190028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189707
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,10L,13L,16L,17L,19L,22L,25L,26L,28L,31L,32L,34L,35L,37L,40L,41L,43L,44L,46L,49L,52L,53L,55L,58L,59L,61L,62L,64L,67L,68L,70L,71L,73L,76L,79L,80L,82L,85L,86L,88L,89L,91L,94L,97L,98L,100L,103L,106L,107L,109L,112L,113L,115L,116L,118L,121L,124L,125L,127L,130L,133L,134L,136L,139L,140L,142L,143L,145L,148L,149L,151L,152L,154L,157L,160L,161L,163L,166L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189707Inst : IEnumerable<long>
{
public static readonly long[] Value=A189707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189707.Bytes);
public long this[int i]=>Value[i];

public static A189707Inst Instance=new A189707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189706
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189706Inst : IEnumerable<long>
{
public static readonly long[] Value=A189706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189706.Bytes);
public long this[int i]=>Value[i];

public static A189706Inst Instance=new A189706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189705
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,7L,8L,8L,8L,9L,10L,11L,11L,11L,12L,13L,13L,14L,15L,16L,16L,17L,17L,18L,18L,18L,19L,20L,20L,21L,22L,23L,23L,24L,24L,25L,25L,25L,26L,27L,27L,28L,29L,30L,30L,31L,31L,31L,32L,33L,34L,34L,35L,35L,36L,36L,36L,37L,38L,39L,39L,39L,40L,41L,42L,42L,42L,43L,44L,44L,45L,46L,47L,47L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189705Inst : IEnumerable<long>
{
public static readonly long[] Value=A189705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189705.Bytes);
public long this[int i]=>Value[i];

public static A189705Inst Instance=new A189705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189704
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,11L,12L,13L,16L,17L,18L,21L,22L,24L,25L,26L,28L,30L,33L,34L,36L,37L,38L,40L,42L,45L,46L,48L,49L,50L,52L,55L,56L,57L,59L,61L,64L,65L,66L,69L,70L,71L,74L,75L,77L,78L,79L,81L,84L,85L,86L,88L,90L,93L,94L,95L,98L,99L,100L,103L,104L,106L,107L,108L,110L,113L,114L,115L,117L,119L,122L,123L,124L,127L,128L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189704Inst : IEnumerable<long>
{
public static readonly long[] Value=A189704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189704.Bytes);
public long this[int i]=>Value[i];

public static A189704Inst Instance=new A189704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189703
{
public static readonly long[] Value={ 1L,5L,7L,9L,10L,14L,15L,19L,20L,23L,27L,29L,31L,32L,35L,39L,41L,43L,44L,47L,51L,53L,54L,58L,60L,62L,63L,67L,68L,72L,73L,76L,80L,82L,83L,87L,89L,91L,92L,96L,97L,101L,102L,105L,109L,111L,112L,116L,118L,120L,121L,125L,126L,129L,133L,135L,137L,138L,142L,143L,147L,148L,151L,155L,157L,159L,160L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189703Inst : IEnumerable<long>
{
public static readonly long[] Value=A189703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189703.Bytes);
public long this[int i]=>Value[i];

public static A189703Inst Instance=new A189703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189702
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189702Inst : IEnumerable<long>
{
public static readonly long[] Value=A189702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189702.Bytes);
public long this[int i]=>Value[i];

public static A189702Inst Instance=new A189702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189701
{
public static readonly BigInteger[] Value={ 88L,7744L,295720L,10867960L,437257670L,17872674996L,733660344149L,30140493826752L,1239562062347534L,50994136275721816L,2098158626051989039L,BigInteger.Parse("86335489832805005659"),BigInteger.Parse("3552764734604163177272"),BigInteger.Parse("146202547786505491839949") };
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
public class A189701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189701Inst Instance=new A189701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189700
{
public static readonly BigInteger[] Value={ 54L,2916L,77752L,1999150L,55423132L,1553640701L,43645304766L,1226051976034L,34463827972461L,968925997882076L,27242280161913994L,765954539776147015L,BigInteger.Parse("21536381951216338725"),BigInteger.Parse("605544975017743747314"),BigInteger.Parse("17026369106775648529847") };
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
public class A189700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189700Inst Instance=new A189700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189699
{
public static readonly BigInteger[] Value={ 33L,1089L,20316L,370045L,7174919L,140346362L,2748122586L,53801184855L,1053901033470L,20648231159172L,404572006660088L,7927242763654571L,155332036036173579L,3043718021008444561L,BigInteger.Parse("59641726902710453442") };
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
public class A189699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189699Inst Instance=new A189699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189698
{
public static readonly long[] Value={ 20L,400L,5172L,65297L,862652L,11451149L,151788273L,2010430729L,26638642226L,353018801580L,4678246752829L,61995665582140L,821565095555503L,10887399620742611L,144280214103179733L,1912006322548221320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189698Inst : IEnumerable<long>
{
public static readonly long[] Value=A189698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189698.Bytes);
public long this[int i]=>Value[i];

public static A189698Inst Instance=new A189698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189697
{
public static readonly long[] Value={ 12L,144L,1298L,11637L,107720L,997264L,9205575L,84987637L,784968276L,7250191247L,66962229085L,618461917882L,5712150826447L,52757783396467L,487273980078400L,4500491954718670L,41566823940472846L,383913783539151670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189697Inst : IEnumerable<long>
{
public static readonly long[] Value=A189697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189697.Bytes);
public long this[int i]=>Value[i];

public static A189697Inst Instance=new A189697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189696
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,7L,16L,64L,49L,12L,32L,256L,292L,144L,20L,64L,1024L,1723L,1298L,400L,33L,128L,4096L,10327L,11637L,5172L,1089L,54L,256L,16384L,61996L,107720L,65297L,20316L,2916L,88L,512L,65536L,371641L,997264L,862652L,370045L,77752L,7744L,143L,1024L,262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189696Inst : IEnumerable<long>
{
public static readonly long[] Value=A189696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189696.Bytes);
public long this[int i]=>Value[i];

public static A189696Inst Instance=new A189696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189695
{
public static readonly BigInteger[] Value={ 256L,65536L,2227333L,84987637L,2010430729L,53801184855L,1226051976034L,30140493826752L,693472588394369L,16601078462607021L,385676526874164679L,9137625077782012475L,BigInteger.Parse("213472003223589754146"),BigInteger.Parse("5034772028641923262353") };
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
public class A189695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189695Inst Instance=new A189695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189694
{
public static readonly BigInteger[] Value={ 128L,16384L,371641L,9205575L,151788273L,2748122586L,43645304766L,733660344149L,11722251157012L,192737455311869L,3101316117820858L,50582965637175513L,817179337255729430L,13284346442987716235UL,BigInteger.Parse("215031581266863776172") };
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
public class A189694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189694Inst Instance=new A189694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189693
{
public static readonly long[] Value={ 64L,4096L,61996L,997264L,11451149L,140346362L,1553640701L,17872674996L,198287096355L,2240961706438L,24972074224456L,280570140162495L,3134318411211896L,35138150310304642L,392994307064068970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189693Inst : IEnumerable<long>
{
public static readonly long[] Value=A189693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189693.Bytes);
public long this[int i]=>Value[i];

public static A189693Inst Instance=new A189693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189692
{
public static readonly long[] Value={ 32L,1024L,10327L,107720L,862652L,7174919L,55423132L,437257670L,3370409239L,26229648516L,202524248054L,1569866749149L,12134837088544L,93944044770612L,726545931663671L,5622258695272390L,43490662494731848L,336493987012953931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189692Inst : IEnumerable<long>
{
public static readonly long[] Value=A189692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189692.Bytes);
public long this[int i]=>Value[i];

public static A189692Inst Instance=new A189692Inst();

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