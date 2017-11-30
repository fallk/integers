using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276962
{
public static readonly long[] Value={ 20L,62L,84L,368L,410L,614L,720L,740L,762L,1230L,1280L,1988L,1998L,2064L,2100L,2268L,2312L,2468L,2678L,2940L,3002L,3324L,3392L,3462L,3768L,3848L,3968L,4178L,4244L,4680L,4968L,5022L,5024L,5198L,5304L,5382L,5624L,5822L,5850L,6048L,6248L,6338L,6354L,6398L,6428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276962Inst : IEnumerable<long>
{
public static readonly long[] Value=A276962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276962.Bytes);
public long this[int i]=>Value[i];

public static A276962Inst Instance=new A276962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276963
{
public static readonly long[] Value={ 65L,544L,1776L,12240L,13920L,54960L,46800L,149520L,427440L,216240L,950640L,951600L,593040L,1460880L,3010800L,4226880L,1728480L,6305280L,5260560L,2986560L,10551840L,8508240L,15283920L,25787040L,15531120L,8490480L,18528720L,10078560L,21889200L,97097280L,34355280L,57775440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276963Inst : IEnumerable<long>
{
public static readonly long[] Value=A276963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276963.Bytes);
public long this[int i]=>Value[i];

public static A276963Inst Instance=new A276963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276964
{
public static readonly BigInteger[] Value={ 1L,3L,39L,949L,36573L,2029551L,152451283L,14840686449L,1812664465209L,270925848659323L,48571769994336831L,10276325760127883853UL,BigInteger.Parse("2531148652596607988629"),BigInteger.Parse("717525135328209346300839"),BigInteger.Parse("231804543407519025287933163") };
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
public class A276964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276964Inst Instance=new A276964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276965
{
public static readonly BigInteger[] Value={ 1L,1L,5L,73L,2017L,86801L,5289301L,430814665L,45052534913L,5868875082817L,930114039075301L,175964489469769001L,BigInteger.Parse("39125942325820605025"),BigInteger.Parse("10092849114680961297553"),BigInteger.Parse("2987365449592984040715317"),BigInteger.Parse("1005030253302269078318250601") };
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
public class A276965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276965Inst Instance=new A276965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276966
{
public static readonly long[] Value={ 1L,0L,1L,12L,1L,60L,1L,244L,1L,1012L,1L,4084L,1L,16340L,1L,65364L,1L,261972L,1L,1048404L,1L,4194132L,1L,16777044L,1L,67108180L,1L,268432724L,1L,1073730900L,1L,4294923604L,1L,17179825492L,1L,68719433044L,1L,274877863252L,1L,1099511584084L,1L,4398046467412L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276966Inst : IEnumerable<long>
{
public static readonly long[] Value=A276966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276966.Bytes);
public long this[int i]=>Value[i];

public static A276966Inst Instance=new A276966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276967
{
public static readonly long[] Value={ 1L,3L,9L,15L,21L,33L,39L,51L,57L,63L,69L,87L,93L,111L,123L,129L,141L,159L,177L,183L,195L,201L,213L,219L,237L,249L,267L,291L,303L,309L,315L,321L,327L,339L,381L,393L,399L,411L,417L,447L,453L,471L,489L,501L,519L,537L,543L,573L,579L,591L,597L,633L,669L,681L,687L,693L,699L,717L,723L,731L,753L,771L,789L,807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276967Inst : IEnumerable<long>
{
public static readonly long[] Value=A276967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276967.Bytes);
public long this[int i]=>Value[i];

public static A276967Inst Instance=new A276967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276968
{
public static readonly long[] Value={ 1L,3L,5L,25L,65L,85L,145L,165L,185L,205L,221L,265L,305L,365L,445L,465L,485L,505L,545L,565L,685L,745L,785L,825L,865L,905L,965L,985L,1025L,1085L,1145L,1165L,1205L,1285L,1345L,1385L,1405L,1465L,1565L,1585L,1685L,1705L,1745L,1765L,1865L,1925L,1945L,1985L,2005L,2045L,2105L,2165L,2245L,2285L,2305L,2325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276968Inst : IEnumerable<long>
{
public static readonly long[] Value=A276968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276968.Bytes);
public long this[int i]=>Value[i];

public static A276968Inst Instance=new A276968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276969
{
public static readonly long[] Value={ 1L,3L,7L,15L,49L,91L,133L,217L,255L,259L,301L,427L,469L,511L,527L,553L,679L,721L,763L,889L,973L,1015L,1057L,1099L,1141L,1267L,1351L,1393L,1477L,1561L,1603L,1687L,1897L,1939L,1981L,2107L,2149L,2191L,2317L,2359L,2443L,2569L,2611L,2653L,2779L,2863L,2947L,3031L,3073L,3199L,3241L,3409L,3493L,3661L,3787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276969Inst : IEnumerable<long>
{
public static readonly long[] Value=A276969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276969.Bytes);
public long this[int i]=>Value[i];

public static A276969Inst Instance=new A276969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276970
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,21L,27L,45L,63L,99L,105L,117L,153L,171L,189L,207L,261L,273L,279L,333L,369L,387L,423L,429L,477L,513L,531L,549L,585L,603L,639L,657L,711L,747L,801L,873L,909L,927L,945L,963L,981L,1017L,1143L,1179L,1197L,1209L,1233L,1251L,1341L,1359L,1365L,1413L,1467L,1503L,1557L,1611L,1629L,1665L,1719L,1737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276970Inst : IEnumerable<long>
{
public static readonly long[] Value=A276970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276970.Bytes);
public long this[int i]=>Value[i];

public static A276970Inst Instance=new A276970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276971
{
public static readonly long[] Value={ 1L,3L,11L,15L,31L,35L,51L,121L,341L,451L,455L,671L,781L,1111L,1235L,1271L,1441L,1547L,1661L,1991L,2091L,2101L,2321L,2651L,2761L,2981L,3091L,3421L,3641L,3731L,3751L,4403L,4411L,4631L,4741L,5071L,5401L,5731L,5951L,6171L,6191L,6281L,6611L,6851L,6941L,7051L,7271L,7601L,7711L,8261L,8371L,8435L,8921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276971Inst : IEnumerable<long>
{
public static readonly long[] Value=A276971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276971.Bytes);
public long this[int i]=>Value[i];

public static A276971Inst Instance=new A276971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276972
{
public static readonly BigInteger[] Value={ 0L,1L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("589881151426658740854227725580736348849310352832644300781946246613899173590427") };
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
public class A276972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276972Inst Instance=new A276972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276973
{
public static readonly long[] Value={ 6L,11L,15L,26L,30L,35L,51L,55L,60L,75L,101L,105L,110L,125L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276973Inst : IEnumerable<long>
{
public static readonly long[] Value=A276973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276973.Bytes);
public long this[int i]=>Value[i];

public static A276973Inst Instance=new A276973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276974
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,4L,1L,1L,0L,19L,3L,1L,1L,0L,103L,12L,3L,1L,1L,0L,651L,54L,10L,3L,1L,1L,0L,4702L,281L,42L,10L,3L,1L,1L,0L,38413L,1652L,203L,37L,10L,3L,1L,1L,0L,350559L,11017L,1086L,166L,37L,10L,3L,1L,1L,0L,3539511L,81665L,6564L,857L,151L,37L,10L,3L,1L,1L,0L,39196758L,669948L,44265L,4900L,726L,151L,37L,10L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276974Inst : IEnumerable<long>
{
public static readonly long[] Value=A276974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276974.Bytes);
public long this[int i]=>Value[i];

public static A276974Inst Instance=new A276974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276975
{
public static readonly BigInteger[] Value={ 1L,1L,4L,19L,103L,651L,4702L,38413L,350559L,3539511L,39196758L,472612883L,6165080443L,86526834271L,1300282224846L,20832761552453L,354515666646827L,6386139146435035L,121406489336263622L,2429193186525638435L,BigInteger.Parse("51030147426536745655"),BigInteger.Parse("1122952442325988152627") };
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
public class A276975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276975.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276975Inst Instance=new A276975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276976
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,4L,3L,2L,1L,2L,1L,2L,3L,4L,1L,6L,1L,4L,3L,2L,1L,4L,5L,2L,9L,4L,1L,2L,1L,8L,3L,2L,11L,6L,1L,2L,3L,4L,1L,6L,1L,4L,9L,2L,1L,4L,7L,10L,3L,4L,1L,18L,15L,8L,3L,2L,1L,4L,1L,2L,3L,16L,5L,6L,1L,4L,3L,10L,1L,6L,1L,2L,15L,4L,17L,6L,1L,4L,27L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276976Inst : IEnumerable<long>
{
public static readonly long[] Value=A276976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276976.Bytes);
public long this[int i]=>Value[i];

public static A276976Inst Instance=new A276976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276977
{
public static readonly BigInteger[] Value={ 1L,1L,11L,315L,17129L,1510425L,196385475L,35327367075L,8399994587985L,2550903574364145L,963207568455370875L,BigInteger.Parse("442613044315692124875"),BigInteger.Parse("243195136160954426677305"),BigInteger.Parse("157442856285298191126143625"),BigInteger.Parse("118607799383105394973766029875"),BigInteger.Parse("102867257381973743111023517821875") };
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
public class A276977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276977.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276977Inst Instance=new A276977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276978
{
public static readonly BigInteger[] Value={ 1L,1L,8L,16L,243L,729L,16384L,65536L,1953125L,9765625L,362797056L,2176782336L,96889010407L,678223072849L,35184372088832L,281474976710656L,16677181699666569L,150094635296999121L,10000000000000000000UL,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("7400249944258160101211") };
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
public class A276978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276978Inst Instance=new A276978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276979
{
public static readonly BigInteger[] Value={ 1L,4L,8L,81L,243L,4096L,16384L,390625L,1953125L,60466176L,362797056L,13841287201L,96889010407L,4398046511104L,35184372088832L,1853020188851841L,16677181699666569L,1000000000000000000L,10000000000000000000UL,BigInteger.Parse("672749994932560009201") };
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
public class A276979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276979Inst Instance=new A276979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276980
{
public static readonly long[] Value={ 273L,1729L,2109L,2255L,4433L,4641L,4697L,5673L,6643L,6935L,7667L,8103L,8729L,10235L,11543L,14497L,16385L,16523L,17507L,18915L,20033L,22649L,23579L,26691L,29309L,29393L,34799L,35853L,35929L,37209L,37829L,39277L,42653L,45551L,55699L,56163L,68735L,68901L,69167L,69977L,70993L,73505L,75361L,76373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276980Inst : IEnumerable<long>
{
public static readonly long[] Value=A276980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276980.Bytes);
public long this[int i]=>Value[i];

public static A276980Inst Instance=new A276980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276981
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,4L,1L,3L,2L,6L,4L,5L,1L,2L,4L,0L,1L,1L,0L,1L,10L,1L,10L,4L,1L,10L,9L,12L,3L,4L,1L,10L,2L,6L,4L,12L,8L,1L,10L,1L,10L,4L,8L,0L,1L,10L,15L,14L,4L,6L,9L,5L,16L,7L,2L,3L,13L,11L,8L,12L,1L,10L,1L,10L,5L,12L,6L,3L,11L,15L,17L,18L,9L,14L,7L,13L,16L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276981Inst : IEnumerable<long>
{
public static readonly long[] Value=A276981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276981.Bytes);
public long this[int i]=>Value[i];

public static A276981Inst Instance=new A276981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276982
{
public static readonly long[] Value={ 4L,6L,8L,10L,10L,10L,7L,19L,18L,16L,19L,17L,16L,11L,20L,19L,21L,22L,21L,19L,30L,21L,22L,23L,30L,22L,30L,30L,30L,7L,24L,27L,23L,28L,24L,29L,45L,25L,29L,20L,53L,28L,50L,45L,50L,30L,24L,25L,48L,25L,45L,40L,45L,26L,53L,48L,53L,45L,50L,45L,10L,27L,26L,32L,24L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276982Inst : IEnumerable<long>
{
public static readonly long[] Value=A276982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276982.Bytes);
public long this[int i]=>Value[i];

public static A276982Inst Instance=new A276982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276983
{
public static readonly long[] Value={ 4L,6L,10L,14L,22L,38L,46L,58L,62L,74L,82L,106L,158L,166L,178L,194L,226L,262L,278L,314L,346L,358L,382L,398L,422L,458L,466L,478L,502L,542L,562L,586L,614L,662L,674L,718L,734L,758L,838L,862L,878L,886L,982L,998L,1018L,1094L,1154L,1186L,1202L,1214L,1238L,1282L,1306L,1318L,1322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276983Inst : IEnumerable<long>
{
public static readonly long[] Value=A276983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276983.Bytes);
public long this[int i]=>Value[i];

public static A276983Inst Instance=new A276983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276984
{
public static readonly long[] Value={ 0L,0L,4L,9L,29L,41L,90L,119L,194L,255L,384L,440L,649L,765L,980L,1155L,1495L,1654L,2108L,2324L,2811L,3185L,3794L,4050L,4874L,5351L,6110L,6664L,7713L,8155L,9454L,10075L,11309L,12235L,13610L,14295L,16205L,17209L,18840L,19930L,22139L,23085L,25584L,26808L,29029L,30861L,33510L,34614L,37974L,39670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276984Inst : IEnumerable<long>
{
public static readonly long[] Value=A276984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276984.Bytes);
public long this[int i]=>Value[i];

public static A276984Inst Instance=new A276984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276985
{
public static readonly long[] Value={ 2L,4L,4L,6L,12L,8L,8L,24L,32L,16L,10L,40L,80L,80L,32L,12L,60L,160L,240L,192L,64L,14L,84L,280L,560L,672L,448L,128L,16L,112L,448L,1120L,1792L,1792L,1024L,256L,18L,144L,672L,2016L,4032L,5376L,4608L,2304L,512L,20L,180L,960L,3360L,8064L,13440L,15360L,11520L,5120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276985Inst : IEnumerable<long>
{
public static readonly long[] Value=A276985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276985.Bytes);
public long this[int i]=>Value[i];

public static A276985Inst Instance=new A276985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276986
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,12L,13L,28L,29L,31L,32L,37L,38L,40L,41L,90L,91L,93L,94L,99L,100L,102L,103L,118L,119L,121L,122L,127L,128L,130L,131L,297L,298L,300L,301L,306L,307L,309L,310L,325L,326L,328L,329L,334L,335L,337L,338L,387L,388L,390L,391L,396L,397L,399L,400L,415L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276986Inst : IEnumerable<long>
{
public static readonly long[] Value=A276986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276986.Bytes);
public long this[int i]=>Value[i];

public static A276986Inst Instance=new A276986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276987
{
public static readonly long[] Value={ 1L,2L,0L,8L,0L,1L,9L,2L,1L,8L,6L,1L,7L,0L,6L,1L,2L,9L,4L,2L,3L,7L,2L,3L,1L,5L,6L,9L,8L,8L,7L,9L,2L,0L,5L,6L,3L,0L,4L,3L,9L,9L,2L,5L,1L,6L,7L,9L,4L,0L,6L,9L,1L,3L,6L,6L,9L,7L,9L,2L,1L,5L,6L,9L,6L,2L,0L,8L,1L,0L,2L,1L,2L,3L,5L,7L,9L,0L,2L,4L,8L,8L,8L,7L,3L,9L,5L,1L,8L,4L,5L,5L,1L,1L,7L,8L,9L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276987Inst : IEnumerable<long>
{
public static readonly long[] Value=A276987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276987.Bytes);
public long this[int i]=>Value[i];

public static A276987Inst Instance=new A276987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276988
{
public static readonly long[] Value={ 1L,3L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276988Inst : IEnumerable<long>
{
public static readonly long[] Value=A276988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276988.Bytes);
public long this[int i]=>Value[i];

public static A276988Inst Instance=new A276988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276989
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,140L,474L,1650L,5863L,21170L,77441L,286372L,1068790L,4020704L,15230470L,58044354L,222401745L,856235030L,3310615055L,12849946406L,50051007940L,195571906140L,766413504375L,3011469930300L,11862075827007L,46830440626612L,185271557066226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276989Inst : IEnumerable<long>
{
public static readonly long[] Value=A276989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276989.Bytes);
public long this[int i]=>Value[i];

public static A276989Inst Instance=new A276989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276990
{
public static readonly BigInteger[] Value={ 2L,1L,2L,-2L,20L,-190L,3240L,-90800L,4174920L,-313173840L,38204662320L,-7564715117520L,2428250059593600L,-1262694691720176000L,BigInteger.Parse("1063187432567808662400"),BigInteger.Parse("-1449125250052431355430400"),BigInteger.Parse("3196769645011428154428883200"),BigInteger.Parse("-11412468527893653264760022630400") };
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
public class A276990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276990Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276990.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276990.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276990Inst Instance=new A276990Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276991
{
public static readonly BigInteger[] Value={ 0L,-1L,0L,-2L,8L,-86L,1448L,-40608L,1867080L,-140055600L,17085644400L,-3383043446640L,1085946439923840L,-564694233102890880L,BigInteger.Parse("475471874409018791040"),BigInteger.Parse("-648068513405723438730240"),BigInteger.Parse("1429638846930684965104992000"),BigInteger.Parse("-5103811083889432701541321459200") };
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
public class A276991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276991Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276991.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276991.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276991Inst Instance=new A276991Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276992
{
public static readonly long[] Value={ 31L,26L,93L,62L,82L,28L,28L,28L,48L,48L,48L,48L,48L,9L,9L,81L,17L,17L,95L,95L,95L,95L,95L,95L,95L,19L,21L,21L,21L,19L,95L,9L,9L,9L,95L,46L,95L,59L,9L,9L,9L,95L,95L,95L,95L,59L,59L,59L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,14L,14L,14L,9L,9L,9L,9L,14L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276992Inst : IEnumerable<long>
{
public static readonly long[] Value=A276992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276992.Bytes);
public long this[int i]=>Value[i];

public static A276992Inst Instance=new A276992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276993
{
public static readonly long[] Value={ 314L,592L,446L,117L,105L,19L,381L,279L,609L,609L,848L,848L,654L,654L,654L,654L,19L,19L,965L,965L,965L,965L,19L,19L,19L,494L,564L,390L,390L,390L,390L,390L,682L,682L,390L,346L,390L,390L,390L,390L,390L,390L,346L,346L,346L,99L,201L,201L,201L,201L,201L,201L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276993Inst : IEnumerable<long>
{
public static readonly long[] Value=A276993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276993.Bytes);
public long this[int i]=>Value[i];

public static A276993Inst Instance=new A276993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276994
{
public static readonly long[] Value={ 2L,3L,0L,9L,1L,3L,8L,5L,9L,3L,3L,3L,0L,4L,9L,4L,7L,3L,1L,0L,9L,8L,7L,2L,0L,3L,0L,5L,0L,1L,7L,2L,1L,2L,5L,3L,1L,9L,1L,1L,8L,1L,4L,4L,7L,2L,5L,8L,1L,6L,2L,8L,4L,0L,1L,6L,9L,4L,4L,0L,2L,9L,0L,0L,2L,8L,4L,4L,5L,6L,4L,4L,0L,7L,4L,8L,3L,1L,6L,8L,4L,2L,7L,1L,7L,2L,8L,1L,6L,1L,5L,7L,7L,4L,4L,1L,2L,1L,7L,4L,3L,7L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276994Inst : IEnumerable<long>
{
public static readonly long[] Value=A276994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276994.Bytes);
public long this[int i]=>Value[i];

public static A276994Inst Instance=new A276994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276995
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,2L,4L,0L,1L,0L,9L,16L,9L,0L,1L,0L,44L,144L,54L,16L,0L,1L,0L,265L,1408L,729L,128L,25L,0L,1L,0L,1854L,16960L,10692L,2304L,250L,36L,0L,1L,0L,14833L,237312L,193185L,45056L,5625L,432L,49L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276995Inst : IEnumerable<long>
{
public static readonly long[] Value=A276995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276995.Bytes);
public long this[int i]=>Value[i];

public static A276995Inst Instance=new A276995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276996
{
public static readonly long[] Value={ 1L,0L,0L,1L,-1L,1L,0L,1L,-3L,1L,1L,-1L,6L,-10L,5L,0L,-1L,-15L,95L,-40L,16L,239L,-1L,13L,-85L,240L,-237L,79L,0L,403L,21L,385L,-1575L,3577L,-2947L,421L,-46409L,-239L,3841L,175L,861L,-8036L,45458L,-10692L,2673L,0L,-82451L,-2657L,56177L,1638L,19488L,-85260L,139656L,-86472L,19216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276996Inst : IEnumerable<long>
{
public static readonly long[] Value=A276996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276996.Bytes);
public long this[int i]=>Value[i];

public static A276996Inst Instance=new A276996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276997
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,1L,1L,2L,2L,1L,60L,1L,1L,1L,1L,1L,6L,2L,3L,1L,1L,504L,4L,4L,1L,1L,1L,1L,1L,24L,8L,12L,2L,2L,2L,1L,2160L,18L,9L,3L,2L,1L,3L,1L,1L,1L,60L,4L,6L,1L,5L,1L,1L,1L,1L,3168L,48L,16L,6L,3L,2L,2L,1L,2L,1L,1L,1L,288L,32L,144L,12L,12L,4L,2L,1L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276997Inst : IEnumerable<long>
{
public static readonly long[] Value=A276997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276997.Bytes);
public long this[int i]=>Value[i];

public static A276997Inst Instance=new A276997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276998
{
public static readonly long[] Value={ 1L,1L,2L,1L,12L,6L,-1L,72L,24L,-24L,1L,1440L,120L,-960L,200L,37L,43200L,-9360L,-44280L,20640L,3750L,-1493L,1814400L,-997920L,-2484720L,2028600L,271740L,-378966L,14017L,25401600L,-23042880L,-42497280L,54159840L,3328080L,-18236064L,1977248L,751267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276998Inst : IEnumerable<long>
{
public static readonly long[] Value=A276998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276998.Bytes);
public long this[int i]=>Value[i];

public static A276998Inst Instance=new A276998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276999
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,9L,0L,0L,1L,12L,93L,0L,0L,1L,15L,147L,1175L,0L,0L,1L,18L,213L,2070L,17835L,0L,0L,1L,21L,291L,3325L,33825L,317667L,0L,0L,1L,24L,381L,5000L,58575L,635208L,6506647L,0L,0L,1L,27L,483L,7155L,94785L,1164429L,13536453L,150776397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276999Inst : IEnumerable<long>
{
public static readonly long[] Value=A276999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276999.Bytes);
public long this[int i]=>Value[i];

public static A276999Inst Instance=new A276999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277000
{
public static readonly BigInteger[] Value={ 1L,-1L,19L,-2561L,874831L,-319094777L,47095708213409L,-751163826506551L,BigInteger.Parse("281559662236405100437"),BigInteger.Parse("-49061598325832137241324057"),BigInteger.Parse("5012066724315488368700829665081"),BigInteger.Parse("-26602063280041700132088988446735433"),BigInteger.Parse("40762630349420684160007591156102493590477") };
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
public class A277000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277000Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277000.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277000.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277000Inst Instance=new A277000Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277001
{
public static readonly BigInteger[] Value={ 1L,24L,5760L,2903040L,1393459200L,367873228800L,24103053950976000L,115694658964684800L,BigInteger.Parse("9440684171518279680000"),BigInteger.Parse("271211974879377138647040000"),BigInteger.Parse("3579998068407778230140928000000"),BigInteger.Parse("1976158933761093583037792256000000"),BigInteger.Parse("258955866680053703121272297226240000000") };
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
public class A277001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277001Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277001.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277001.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277001Inst Instance=new A277001Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277002
{
public static readonly BigInteger[] Value={ -1L,7L,-31L,127L,-511L,1414477L,-8191L,118518239L,-5749691557L,91546277357L,-23273283019L,1982765468311237L,-22076500342261L,455371239541065869L,BigInteger.Parse("-925118910976041358111"),BigInteger.Parse("16555640865486520478399"),BigInteger.Parse("-1302480594081611886641"),BigInteger.Parse("904185845619475242495834469891") };
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
public class A277002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277002Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277002.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277002.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277002Inst Instance=new A277002Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277003
{
public static readonly BigInteger[] Value={ 24L,2880L,40320L,215040L,608256L,738017280L,1277952L,4010803200L,32006209536L,65745715200L,1736441856L,12641296711680L,10066329600L,12611097722880L,1337897345089536L,1086454927196160L,3401614098432L,BigInteger.Parse("83088011510887219200"),61022895341568L };
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
public class A277003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277003.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277003Inst Instance=new A277003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277004
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,4L,2L,1L,0L,27L,9L,2L,4L,0L,256L,44L,9L,8L,27L,0L,3125L,265L,44L,36L,54L,256L,0L,46656L,1854L,265L,176L,243L,512L,3125L,0L,823543L,14833L,1854L,1060L,1188L,2304L,6250L,46656L,0L,16777216L,133496L,14833L,7416L,7155L,11264L,28125L,93312L,823543L,0L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277004Inst : IEnumerable<long>
{
public static readonly long[] Value=A277004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277004.Bytes);
public long this[int i]=>Value[i];

public static A277004Inst Instance=new A277004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277005
{
public static readonly BigInteger[] Value={ 2L,5L,29L,193L,1733L,17291L,207367L,2903041L,43545611L,696729629L,12541132817L,250822656001L,5267275776047L,115880067072017L,2781121609728037L,69528040243200079L,1807729046323200001L,BigInteger.Parse("48808684250726400031"),BigInteger.Parse("136664315902033920001") };
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
public class A277005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277005.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277005Inst Instance=new A277005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277006
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,15L,11L,14L,21L,35L,30L,13L,22L,33L,55L,42L,77L,70L,105L,17L,26L,39L,65L,66L,91L,110L,165L,143L,154L,231L,385L,210L,19L,34L,51L,85L,78L,119L,130L,195L,187L,182L,273L,455L,330L,221L,286L,429L,715L,462L,1001L,770L,1155L,23L,38L,57L,95L,102L,133L,170L,255L,209L,238L,357L,595L,390L,247L,374L,561L,935L,546L,1309L,910L,1365L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277006Inst : IEnumerable<long>
{
public static readonly long[] Value=A277006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277006.Bytes);
public long this[int i]=>Value[i];

public static A277006Inst Instance=new A277006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277007
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277007Inst : IEnumerable<long>
{
public static readonly long[] Value=A277007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277007.Bytes);
public long this[int i]=>Value[i];

public static A277007Inst Instance=new A277007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277008
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,32L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,48L,49L,50L,52L,53L,54L,56L,57L,58L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,80L,81L,82L,84L,85L,86L,88L,89L,90L,92L,96L,97L,98L,100L,101L,102L,104L,105L,106L,108L,109L,112L,113L,114L,116L,117L,118L,120L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277008Inst : IEnumerable<long>
{
public static readonly long[] Value=A277008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277008.Bytes);
public long this[int i]=>Value[i];

public static A277008Inst Instance=new A277008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277009
{
public static readonly long[] Value={ 3L,7L,11L,14L,15L,19L,23L,27L,29L,30L,31L,35L,39L,43L,46L,47L,51L,55L,59L,60L,61L,62L,63L,67L,71L,75L,78L,79L,83L,87L,91L,93L,94L,95L,99L,103L,107L,110L,111L,115L,119L,121L,122L,123L,124L,125L,126L,127L,131L,135L,139L,142L,143L,147L,151L,155L,157L,158L,159L,163L,167L,171L,174L,175L,179L,183L,187L,188L,189L,190L,191L,195L,199L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277009Inst : IEnumerable<long>
{
public static readonly long[] Value=A277009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277009.Bytes);
public long this[int i]=>Value[i];

public static A277009Inst Instance=new A277009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277010
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,9L,16L,32L,17L,10L,64L,128L,18L,33L,256L,65L,512L,21L,1024L,34L,129L,20L,2048L,257L,66L,4096L,37L,8192L,513L,16384L,130L,32768L,36L,258L,1025L,65536L,131072L,2049L,68L,69L,262144L,514L,41L,524288L,1048576L,4097L,40L,133L,2097152L,8193L,4194304L,132L,16385L,1026L,8388608L,72L,2050L,32769L,260L,16777216L,33554432L,261L,67108864L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277010Inst : IEnumerable<long>
{
public static readonly long[] Value=A277010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277010.Bytes);
public long this[int i]=>Value[i];

public static A277010Inst Instance=new A277010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277011
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,3L,4L,3L,24L,7L,8L,4L,12L,5L,6L,4L,120L,25L,26L,8L,30L,9L,10L,5L,48L,13L,14L,6L,18L,7L,8L,5L,720L,121L,122L,26L,126L,27L,28L,9L,144L,31L,32L,10L,36L,11L,12L,6L,240L,49L,50L,14L,54L,15L,16L,7L,72L,19L,20L,8L,24L,9L,10L,6L,5040L,721L,722L,122L,726L,123L,124L,27L,744L,127L,128L,28L,132L,29L,30L,10L,840L,145L,146L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277011Inst : IEnumerable<long>
{
public static readonly long[] Value=A277011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277011.Bytes);
public long this[int i]=>Value[i];

public static A277011Inst Instance=new A277011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277012
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,13L,4L,9L,10L,21L,22L,45L,12L,25L,26L,53L,54L,109L,28L,57L,58L,117L,118L,237L,8L,17L,18L,37L,38L,77L,20L,41L,42L,85L,86L,173L,44L,89L,90L,181L,182L,365L,92L,185L,186L,373L,374L,749L,24L,49L,50L,101L,102L,205L,52L,105L,106L,213L,214L,429L,108L,217L,218L,437L,438L,877L,220L,441L,442L,885L,886L,1773L,56L,113L,114L,229L,230L,461L,116L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277012Inst : IEnumerable<long>
{
public static readonly long[] Value=A277012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277012.Bytes);
public long this[int i]=>Value[i];

public static A277012Inst Instance=new A277012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277013
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,2L,2L,4L,1L,3L,1L,3L,2L,2L,1L,4L,1L,2L,3L,3L,1L,3L,1L,5L,2L,2L,2L,4L,1L,2L,2L,4L,1L,3L,1L,3L,3L,2L,1L,5L,2L,2L,2L,3L,1L,4L,1L,4L,2L,2L,1L,4L,1L,2L,3L,6L,1L,3L,1L,3L,2L,3L,1L,5L,1L,2L,3L,3L,1L,3L,1L,5L,2L,2L,1L,4L,2L,2L,2L,4L,1L,4L,1L,3L,2L,2L,1L,6L,1L,3L,3L,3L,1L,3L,1L,4L,3L,2L,1L,5L,1L,2L,2L,5L,1L,3L,1L,3L,2L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277013Inst : IEnumerable<long>
{
public static readonly long[] Value=A277013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277013.Bytes);
public long this[int i]=>Value[i];

public static A277013Inst Instance=new A277013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277014
{
public static readonly long[] Value={ 0L,6L,24L,53L,92L,132L,145L,208L,462L,568L,716L,815L,1106L,1270L,1625L,1822L,2245L,2415L,2474L,2960L,3222L,3777L,4148L,4377L,5022L,5359L,6064L,6436L,6815L,7204L,7508L,7611L,8452L,8888L,9339L,9797L,10383L,10744L,11237L,12775L,14413L,14982L,15409L,16146L,16741L,17352L,17978L,18612L,19423L,19916L,21944L,24067L,25533L,26099L,26289L,27053L,27831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277014Inst : IEnumerable<long>
{
public static readonly long[] Value=A277014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277014.Bytes);
public long this[int i]=>Value[i];

public static A277014Inst Instance=new A277014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277015
{
public static readonly long[] Value={ 0L,4L,8L,12L,16L,19L,20L,24L,36L,40L,45L,48L,56L,60L,68L,72L,80L,83L,84L,92L,96L,104L,109L,112L,120L,124L,132L,136L,140L,144L,147L,148L,156L,160L,164L,168L,173L,176L,180L,192L,204L,208L,211L,216L,220L,224L,228L,232L,237L,240L,252L,264L,272L,275L,276L,280L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277015Inst : IEnumerable<long>
{
public static readonly long[] Value=A277015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277015.Bytes);
public long this[int i]=>Value[i];

public static A277015Inst Instance=new A277015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277016
{
public static readonly long[] Value={ 0L,16L,64L,144L,256L,361L,400L,576L,1296L,1600L,2025L,2304L,3136L,3600L,4624L,5184L,6400L,6889L,7056L,8464L,9216L,10816L,11881L,12544L,14400L,15376L,17424L,18496L,19600L,20736L,21609L,21904L,24336L,25600L,26896L,28224L,29929L,30976L,32400L,36864L,41616L,43264L,44521L,46656L,48400L,50176L,51984L,53824L,56169L,57600L,63504L,69696L,73984L,75625L,76176L,78400L,80656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277016Inst : IEnumerable<long>
{
public static readonly long[] Value=A277016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277016.Bytes);
public long this[int i]=>Value[i];

public static A277016Inst Instance=new A277016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277017
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277017Inst : IEnumerable<long>
{
public static readonly long[] Value=A277017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277017.Bytes);
public long this[int i]=>Value[i];

public static A277017Inst Instance=new A277017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277018
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,32L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,48L,49L,50L,52L,53L,54L,56L,57L,58L,60L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,80L,81L,82L,84L,85L,86L,88L,89L,90L,92L,96L,97L,98L,100L,101L,102L,104L,105L,106L,108L,109L,112L,113L,114L,116L,117L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277018Inst : IEnumerable<long>
{
public static readonly long[] Value=A277018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277018.Bytes);
public long this[int i]=>Value[i];

public static A277018Inst Instance=new A277018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277019
{
public static readonly long[] Value={ 3L,7L,11L,14L,15L,19L,23L,27L,29L,30L,31L,35L,39L,43L,46L,47L,51L,55L,59L,61L,62L,63L,67L,71L,75L,78L,79L,83L,87L,91L,93L,94L,95L,99L,103L,107L,110L,111L,115L,119L,123L,124L,125L,126L,127L,131L,135L,139L,142L,143L,147L,151L,155L,157L,158L,159L,163L,167L,171L,174L,175L,179L,183L,187L,189L,190L,191L,195L,199L,203L,206L,207L,211L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277019Inst : IEnumerable<long>
{
public static readonly long[] Value=A277019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277019.Bytes);
public long this[int i]=>Value[i];

public static A277019Inst Instance=new A277019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277020
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,13L,10L,21L,8L,45L,26L,93L,20L,109L,42L,85L,16L,173L,90L,477L,52L,957L,186L,733L,40L,749L,218L,1501L,84L,877L,170L,341L,32L,685L,346L,3549L,180L,12221L,954L,7133L,104L,14269L,1914L,49021L,372L,28605L,1466L,5853L,80L,5869L,1498L,30685L,436L,61373L,3002L,23517L,168L,12013L,1754L,24029L,340L,7021L,682L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277020Inst : IEnumerable<long>
{
public static readonly long[] Value=A277020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277020.Bytes);
public long this[int i]=>Value[i];

public static A277020Inst Instance=new A277020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277021
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,3L,4L,3L,30L,7L,8L,4L,12L,5L,6L,4L,210L,31L,32L,8L,36L,9L,10L,5L,60L,13L,14L,6L,18L,7L,8L,5L,2310L,211L,212L,32L,216L,33L,34L,9L,240L,37L,38L,10L,42L,11L,12L,6L,420L,61L,62L,14L,66L,15L,16L,7L,90L,19L,20L,8L,24L,9L,10L,6L,30030L,2311L,2312L,212L,2316L,213L,214L,33L,2340L,217L,218L,34L,222L,35L,36L,10L,2520L,241L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277021Inst : IEnumerable<long>
{
public static readonly long[] Value=A277021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277021.Bytes);
public long this[int i]=>Value[i];

public static A277021Inst Instance=new A277021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277022
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,13L,4L,9L,10L,21L,22L,45L,12L,25L,26L,53L,54L,109L,28L,57L,58L,117L,118L,237L,60L,121L,122L,245L,246L,493L,8L,17L,18L,37L,38L,77L,20L,41L,42L,85L,86L,173L,44L,89L,90L,181L,182L,365L,92L,185L,186L,373L,374L,749L,188L,377L,378L,757L,758L,1517L,24L,49L,50L,101L,102L,205L,52L,105L,106L,213L,214L,429L,108L,217L,218L,437L,438L,877L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277022Inst : IEnumerable<long>
{
public static readonly long[] Value=A277022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277022.Bytes);
public long this[int i]=>Value[i];

public static A277022Inst Instance=new A277022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277023
{
public static readonly long[] Value={ 0L,3L,6L,11L,16L,27L,38L,51L,64L,83L,102L,123L,144L,171L,198L,227L,256L,291L,326L,361L,400L,444L,486L,531L,576L,627L,678L,731L,786L,843L,902L,963L,1026L,1091L,1158L,1227L,1296L,1371L,1446L,1523L,1600L,1683L,1767L,1851L,1938L,2025L,2118L,2211L,2304L,2403L,2502L,2603L,2706L,2811L,2918L,3027L,3136L,3251L,3366L,3483L,3600L,3723L,3846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277023Inst : IEnumerable<long>
{
public static readonly long[] Value=A277023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277023.Bytes);
public long this[int i]=>Value[i];

public static A277023Inst Instance=new A277023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277024
{
public static readonly long[] Value={ 0L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,0L,0L,3L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,3L,2L,2L,0L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,0L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,3L,2L,2L,0L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277024Inst : IEnumerable<long>
{
public static readonly long[] Value=A277024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277024.Bytes);
public long this[int i]=>Value[i];

public static A277024Inst Instance=new A277024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277025
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,28L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,48L,51L,52L,54L,55L,56L,57L,58L,60L,63L,66L,68L,69L,70L,71L,72L,74L,78L,80L,81L,84L,88L,90L,91L,93L,95L,96L,98L,99L,102L,105L,107L,108L,110L,111L,112L,114L,117L,118L,120L,121L,123L,126L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277025Inst : IEnumerable<long>
{
public static readonly long[] Value=A277025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277025.Bytes);
public long this[int i]=>Value[i];

public static A277025Inst Instance=new A277025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277026
{
public static readonly long[] Value={ 7L,8L,11L,13L,16L,19L,22L,25L,27L,29L,32L,38L,43L,46L,47L,49L,50L,53L,59L,61L,62L,64L,65L,67L,73L,75L,76L,77L,79L,82L,83L,85L,86L,87L,89L,92L,94L,97L,100L,101L,103L,104L,106L,109L,113L,115L,116L,119L,122L,124L,125L,127L,128L,130L,133L,134L,137L,140L,141L,143L,145L,146L,148L,151L,152L,154L,155L,163L,164L,167L,168L,169L,170L,173L,174L,176L,178L,179L,181L,184L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277026Inst : IEnumerable<long>
{
public static readonly long[] Value=A277026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277026.Bytes);
public long this[int i]=>Value[i];

public static A277026Inst Instance=new A277026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277027
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,4L,1L,9L,4L,4L,1L,9L,1L,4L,4L,16L,1L,9L,1L,9L,4L,4L,1L,16L,1L,4L,9L,9L,1L,9L,1L,25L,4L,4L,4L,16L,1L,4L,4L,16L,1L,9L,1L,9L,9L,4L,1L,25L,4L,4L,4L,9L,1L,16L,1L,16L,4L,4L,1L,16L,1L,4L,9L,36L,1L,9L,1L,9L,4L,9L,1L,25L,1L,4L,9L,9L,1L,9L,1L,25L,4L,4L,1L,16L,4L,4L,4L,16L,1L,16L,1L,9L,4L,4L,1L,36L,1L,9L,9L,9L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277027Inst : IEnumerable<long>
{
public static readonly long[] Value=A277027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277027.Bytes);
public long this[int i]=>Value[i];

public static A277027Inst Instance=new A277027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277028
{
public static readonly long[] Value={ 0L,1L,3L,7L,31L,255L,32767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277028Inst : IEnumerable<long>
{
public static readonly long[] Value=A277028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277028.Bytes);
public long this[int i]=>Value[i];

public static A277028Inst Instance=new A277028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277029
{
public static readonly long[] Value={ 0L,1L,4L,8L,16L,25L,42L,61L,90L,130L,178L,242L,332L,436L,566L,747L,952L,1210L,1540L,1926L,2400L,2994L,3674L,4506L,5526L,6708L,8108L,9808L,11768L,14080L,16850L,20022L,23738L,28128L,33152L,39015L,45854L,53662L,62696L,73166L,85118L,98826L,114636L,132586L,153102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277029Inst : IEnumerable<long>
{
public static readonly long[] Value=A277029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277029.Bytes);
public long this[int i]=>Value[i];

public static A277029Inst Instance=new A277029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277030
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,2L,12L,6L,4L,4L,16L,6L,18L,4L,6L,10L,22L,4L,20L,12L,18L,6L,28L,4L,30L,8L,10L,16L,12L,6L,36L,18L,12L,4L,40L,6L,42L,10L,12L,22L,46L,4L,42L,20L,16L,12L,52L,18L,20L,6L,18L,28L,58L,4L,60L,30L,6L,16L,12L,10L,66L,16L,22L,12L,70L,6L,72L,36L,20L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277030Inst : IEnumerable<long>
{
public static readonly long[] Value=A277030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277030.Bytes);
public long this[int i]=>Value[i];

public static A277030Inst Instance=new A277030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277031
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,5L,0L,1L,0L,20L,3L,0L,1L,0L,109L,10L,0L,0L,1L,0L,668L,44L,7L,0L,0L,1L,0L,4801L,210L,28L,0L,0L,0L,1L,0L,38894L,1320L,90L,15L,0L,0L,0L,1L,0L,353811L,8439L,554L,75L,0L,0L,0L,0L,1L,0L,3561512L,63404L,3542L,310L,31L,0L,0L,0L,0L,1L,0L,39374609L,517418L,23298L,1276L,198L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277031Inst : IEnumerable<long>
{
public static readonly long[] Value=A277031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277031.Bytes);
public long this[int i]=>Value[i];

public static A277031Inst Instance=new A277031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277032
{
public static readonly BigInteger[] Value={ 1L,1L,5L,20L,109L,668L,4801L,38894L,353811L,3561512L,39374609L,474132730L,6179650125L,86676293916L,1301952953989L,20852719565694L,354771488612075L,6389625786835184L,121456993304945749L,2429966790591643402L,BigInteger.Parse("51042656559451380013"),BigInteger.Parse("1123165278137918510772") };
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
public class A277032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277032Inst Instance=new A277032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277033
{
public static readonly BigInteger[] Value={ 1L,2L,4L,18L,76L,420L,2248L,14410L,89676L,642764L,4487896L,35282228L,271094936L,2310824808L,19309255952L,177093587874L,1596354765308L,15664040851996L,151403517122328L,1582290415072396L,16319413287176584L,180949924453071544L,1983128441367699632L,BigInteger.Parse("23249895784026465044"),BigInteger.Parse("269763155110100504568"),BigInteger.Parse("3333619355332522429656") };
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
public class A277033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277033Inst Instance=new A277033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277034
{
public static readonly BigInteger[] Value={ 1L,2L,4L,50L,268L,3780L,28872L,438410L,4087180L,65365260L,697738072L,11624944660L,137432369816L,2371412517480L,30441246407440L,542177876315970L,7460629909188796L,136882304192481020L,2001263659780301080L,BigInteger.Parse("37777108180867675020"),BigInteger.Parse("583057080531893501960"),BigInteger.Parse("11314432259935102732856"),BigInteger.Parse("183452721005994056356272") };
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
public class A277034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277034.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277034Inst Instance=new A277034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277035
{
public static readonly BigInteger[] Value={ 1L,2L,14L,320L,21036L,4248736L,2753284608L,5889659239296L,42571528094271584L,BigInteger.Parse("1060699597956427433984"),BigInteger.Parse("92622122614950875482410496"),BigInteger.Parse("28732153964162783015337150191616"),BigInteger.Parse("32013867511269166370870196132112760832"),BigInteger.Parse("129287051721999031624124705228031781712207872"),BigInteger.Parse("1906782843976072893849368486957954962408685271556096") };
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
public class A277035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277035Inst Instance=new A277035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277036
{
public static readonly BigInteger[] Value={ 1L,2L,16L,640L,102656L,63897600L,154597064704L,1463095704682496L,BigInteger.Parse("54479037904873062400"),BigInteger.Parse("8016231806154061580861440"),BigInteger.Parse("4675328432258454936484990418944"),BigInteger.Parse("10830326782491721013522399339743281152"),BigInteger.Parse("99782643106894570834269165391541758337220608"),BigInteger.Parse("3659836060539105945122413831815090863199825623515136"),BigInteger.Parse("534751190090057629985959636400471838795213939324687126364160") };
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
public class A277036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277036Inst Instance=new A277036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277037
{
public static readonly BigInteger[] Value={ 1L,2L,18L,484L,54630L,26638924L,53843811956L,442942117297000L,14725418961500037126UL,BigInteger.Parse("1971239927985067569365772"),BigInteger.Parse("1060292226589575099894174194524"),BigInteger.Parse("2288290973515256950275126683431946552"),BigInteger.Parse("19795837218795604674370624304477542380054748"),BigInteger.Parse("685985356865646724678258830150265065104998427771576"),BigInteger.Parse("95174256167264272421248219248338459257647770713814222870312") };
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
public class A277037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277037Inst Instance=new A277037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277038
{
public static readonly BigInteger[] Value={ 1L,1L,-4L,56L,-1452L,58368L,-3339220L,257978168L,-25928865116L,3293850854208L,-516648260338724L,98140914400430840L,BigInteger.Parse("-22212891796114092556"),BigInteger.Parse("5908226316995291448256"),BigInteger.Parse("-1824964039545848666778100"),BigInteger.Parse("647939176919565713349368184"),BigInteger.Parse("-262058639306505158896089030332"),BigInteger.Parse("119788326167873858048176581362560"),BigInteger.Parse("-61452317226714509108846922021817924") };
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
public class A277038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277038.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277038Inst Instance=new A277038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277039
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,4L,14L,79L,758L,16865L,191965L,4642399L,86248902L,3501670714L,115114996057L,8565607353234L,490214100103707L,84938404987634353L,3664613039216888961L,BigInteger.Parse("479579554530728437490"),BigInteger.Parse("35532408630828993454198"),BigInteger.Parse("8604356703941292707727453"),BigInteger.Parse("611094051996156994790949416"),BigInteger.Parse("149400677551660775985467062785"),BigInteger.Parse("19315916074995756159830225305613") };
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
public class A277039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277039.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277039Inst Instance=new A277039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277040
{
public static readonly long[] Value={ 1L,2L,3L,8L,25L,66L,357L,1968L,8073L,135260L,1271941L,7376172L,113614228L,1258281038L,8941092630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277040Inst : IEnumerable<long>
{
public static readonly long[] Value=A277040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277040.Bytes);
public long this[int i]=>Value[i];

public static A277040Inst Instance=new A277040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277041
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,11L,51L,246L,897L,13526L,115631L,614681L,8739556L,89877217L,596072842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277041Inst : IEnumerable<long>
{
public static readonly long[] Value=A277041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277041.Bytes);
public long this[int i]=>Value[i];

public static A277041Inst Instance=new A277041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277042
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,27L,0L,0L,10666L,0L,0L,6174792L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277042Inst : IEnumerable<long>
{
public static readonly long[] Value=A277042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277042.Bytes);
public long this[int i]=>Value[i];

public static A277042Inst Instance=new A277042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277043
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,30L,0L,0L,10921L,0L,0L,6308995L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277043Inst : IEnumerable<long>
{
public static readonly long[] Value=A277043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277043.Bytes);
public long this[int i]=>Value[i];

public static A277043Inst Instance=new A277043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277044
{
public static readonly long[] Value={ 0L,0L,0L,16L,96L,216L,600L,1008L,2064L,3040L,5280L,7200L,11280L,14616L,21336L,26656L,36960L,44928L,59904L,71280L,92160L,107800L,135960L,156816L,193776L,220896L,268320L,302848L,362544L,405720L,479640L,532800L,623040L,687616L,796416L,873936L,1003680L,1095768L,1248984L,1357360L,1536720L,1663200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277044Inst : IEnumerable<long>
{
public static readonly long[] Value=A277044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277044.Bytes);
public long this[int i]=>Value[i];

public static A277044Inst Instance=new A277044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277045
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,2L,2L,0L,3L,1L,1L,0L,2L,3L,1L,2L,3L,1L,0L,2L,4L,1L,0L,2L,3L,2L,0L,2L,4L,3L,1L,1L,4L,2L,1L,0L,2L,4L,3L,1L,2L,4L,4L,1L,0L,2L,5L,4L,1L,0L,3L,3L,5L,1L,0L,2L,6L,5L,2L,0L,2L,5L,5L,3L,0L,0L,7L,5L,3L,1L,2L,4L,7L,3L,1L,0L,2L,5L,8L,2L,1L,0L,2L,5L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277045Inst : IEnumerable<long>
{
public static readonly long[] Value=A277045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277045.Bytes);
public long this[int i]=>Value[i];

public static A277045Inst Instance=new A277045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277046
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,17L,18L,27L,28L,29L,30L,31L,32L,33L,34L,35L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L,131L,132L,133L,248L,249L,250L,251L,252L,253L,254L,255L,256L,257L,258L,259L,260L,261L,262L,503L,504L,505L,506L,507L,508L,509L,510L,511L,512L,513L,514L,515L,516L,517L,518L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277046Inst : IEnumerable<long>
{
public static readonly long[] Value=A277046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277046.Bytes);
public long this[int i]=>Value[i];

public static A277046Inst Instance=new A277046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277047
{
public static readonly long[] Value={ 8L,27L,125L,343L,11L,127L,1343L,1729L,827L,8729L,271L,27343L,641L,6427L,64343L,12527L,125729L,2161L,216343L,3431L,34327L,343729L,51227L,512729L,729343L,101L,1027L,10343L,10729L,1127L,18343L,1271L,127343L,127729L,164729L,11251L,1125343L,121627L,1216343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277047Inst : IEnumerable<long>
{
public static readonly long[] Value=A277047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277047.Bytes);
public long this[int i]=>Value[i];

public static A277047Inst Instance=new A277047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277048
{
public static readonly long[] Value={ 11L,13L,23L,47L,59L,83L,107L,167L,179L,227L,263L,347L,359L,383L,431L,467L,479L,503L,563L,587L,683L,719L,839L,863L,887L,983L,1019L,1091L,1093L,1187L,1223L,1283L,1307L,1319L,1367L,1439L,1487L,1511L,1523L,1583L,1597L,1619L,1669L,1823L,1871L,1907L,2027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277048Inst : IEnumerable<long>
{
public static readonly long[] Value=A277048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277048.Bytes);
public long this[int i]=>Value[i];

public static A277048Inst Instance=new A277048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277049
{
public static readonly long[] Value={ 3L,11L,31L,59L,71L,149L,179L,191L,269L,359L,389L,409L,479L,569L,719L,839L,1019L,1039L,1091L,1319L,1439L,1609L,1619L,1699L,1759L,1861L,1949L,2039L,2099L,2239L,2309L,2459L,2579L,2621L,2749L,2819L,2879L,2909L,2939L,2999L,3119L,3229L,3449L,3461L,3581L,3709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277049Inst : IEnumerable<long>
{
public static readonly long[] Value=A277049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277049.Bytes);
public long this[int i]=>Value[i];

public static A277049Inst Instance=new A277049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277050
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,16L,18L,19L,20L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,68L,69L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277050Inst : IEnumerable<long>
{
public static readonly long[] Value=A277050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277050.Bytes);
public long this[int i]=>Value[i];

public static A277050Inst Instance=new A277050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277051
{
public static readonly long[] Value={ 22L,44L,66L,88L,110L,133L,155L,177L,199L,221L,244L,266L,288L,310L,332L,355L,377L,399L,421L,443L,465L,488L,510L,532L,554L,576L,599L,621L,643L,665L,687L,710L,732L,754L,776L,798L,820L,843L,865L,887L,909L,931L,954L,976L,998L,1020L,1042L,1065L,1087L,1109L,1131L,1153L,1175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277051Inst : IEnumerable<long>
{
public static readonly long[] Value=A277051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277051.Bytes);
public long this[int i]=>Value[i];

public static A277051Inst Instance=new A277051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277052
{
public static readonly long[] Value={ 8L,17L,26L,35L,43L,52L,61L,70L,79L,87L,96L,105L,114L,123L,131L,140L,149L,158L,166L,175L,184L,193L,202L,210L,219L,228L,237L,246L,254L,263L,272L,281L,290L,298L,307L,316L,325L,333L,342L,351L,360L,369L,377L,386L,395L,404L,413L,421L,430L,439L,448L,457L,465L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277052Inst : IEnumerable<long>
{
public static readonly long[] Value=A277052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277052.Bytes);
public long this[int i]=>Value[i];

public static A277052Inst Instance=new A277052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277053
{
public static readonly long[] Value={ 7L,8L,5L,1L,7L,6L,6L,8L,8L,7L,3L,3L,8L,0L,6L,8L,5L,1L,9L,2L,8L,2L,9L,7L,5L,9L,9L,9L,0L,3L,9L,1L,9L,9L,3L,7L,6L,0L,0L,4L,9L,5L,9L,5L,1L,3L,1L,9L,5L,8L,9L,3L,6L,7L,1L,5L,5L,8L,0L,1L,1L,0L,8L,4L,7L,3L,5L,2L,7L,1L,7L,3L,1L,2L,6L,0L,6L,7L,6L,3L,0L,0L,6L,4L,2L,6L,8L,9L,0L,6L,0L,7L,5L,1L,8L,8L,1L,6L,1L,7L,7L,8L,2L,3L,9L,7L,2L,2L,3L,9L,1L,7L,7L,4L,3L,0L,2L,7L,7L,7L,7L,5L,8L,2L,4L,0L,4L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277053Inst : IEnumerable<long>
{
public static readonly long[] Value=A277053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277053.Bytes);
public long this[int i]=>Value[i];

public static A277053Inst Instance=new A277053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277054
{
public static readonly long[] Value={ 1023456789L,93125079L,9222117L,1110789L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L,92115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277054Inst : IEnumerable<long>
{
public static readonly long[] Value=A277054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277054.Bytes);
public long this[int i]=>Value[i];

public static A277054Inst Instance=new A277054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277055
{
public static readonly long[] Value={ 2L,11L,8L,5L,75L,15L,7L,694L,119L,34L,8345L,1505L,195L,123717L,105803L,2217L,2134L,727L,2177399L,241934L,37303L,3724L,44317196L,4431858L,487068L,54771L,9124L,1023456789L,93125079L,9222117L,1110789L,92115L,26432593615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277055Inst : IEnumerable<long>
{
public static readonly long[] Value=A277055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277055.Bytes);
public long this[int i]=>Value[i];

public static A277055Inst Instance=new A277055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277056
{
public static readonly long[] Value={ 2L,5L,7L,34L,195L,727L,3724L,9124L,92115L,338161L,2780514L,6871290L,99000993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277056Inst : IEnumerable<long>
{
public static readonly long[] Value=A277056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277056.Bytes);
public long this[int i]=>Value[i];

public static A277056Inst Instance=new A277056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277057
{
public static readonly long[] Value={ 123456789L,11225079L,1113198L,210789L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L,11115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277057Inst : IEnumerable<long>
{
public static readonly long[] Value=A277057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277057.Bytes);
public long this[int i]=>Value[i];

public static A277057Inst Instance=new A277057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277058
{
public static readonly long[] Value={ 1L,5L,4L,27L,6L,194L,33L,14L,1865L,425L,45L,22875L,17603L,403L,370L,342391L,38094L,8631L,588L,6053444L,605410L,67228L,7385L,3364L,123456789L,11225079L,1113198L,210789L,11115L,2853116705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277058Inst : IEnumerable<long>
{
public static readonly long[] Value=A277058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277058.Bytes);
public long this[int i]=>Value[i];

public static A277058Inst Instance=new A277058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277059
{
public static readonly long[] Value={ 1L,4L,6L,14L,45L,370L,588L,3364L,11115L,168496L,271458L,2442138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277059Inst : IEnumerable<long>
{
public static readonly long[] Value=A277059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277059.Bytes);
public long this[int i]=>Value[i];

public static A277059Inst Instance=new A277059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277060
{
public static readonly BigInteger[] Value={ 0L,1L,28L,729L,19376L,529575L,14835780L,424231465L,12338211520L,363931754949L,10862528888300L,327501958094003L,9959845931792784L,305175084350065267L,9412306255856822388UL,BigInteger.Parse("291982561878565118025"),BigInteger.Parse("9104382992541189221120") };
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
public class A277060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277060.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277060Inst Instance=new A277060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277061
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,51L,53L,57L,61L,62L,63L,64L,66L,67L,68L,71L,72L,73L,74L,75L,76L,77L,79L,81L,82L,83L,84L,86L,88L,89L,91L,92L,93L,94L,97L,98L,99L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277061Inst : IEnumerable<long>
{
public static readonly long[] Value=A277061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277061.Bytes);
public long this[int i]=>Value[i];

public static A277061Inst Instance=new A277061Inst();

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