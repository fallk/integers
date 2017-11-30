using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A144345
{
public static readonly BigInteger[] Value={ 1L,6L,52L,600L,8680L,151200L,3082240L,71998080L,1896294400L,55601145600L,1796277683200L,63397990656000L,2427084884224000L,100175046107136000L,4434284662872064000L,BigInteger.Parse("209554432423784448000"),BigInteger.Parse("10530302071553904640000"),BigInteger.Parse("560682451860226375680000") };
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
public class A144345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144345Inst Instance=new A144345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144346
{
public static readonly BigInteger[] Value={ 1L,12L,160L,2520L,46480L,987840L,23826880L,643843200L,19280060800L,634002969600L,22718375680000L,881259515136000L,36796205974528000L,1645615697037312000L,BigInteger.Parse("78486991029551104000"),BigInteger.Parse("3976930001842237440000"),BigInteger.Parse("213353732165508014080000"),BigInteger.Parse("12081783988797659136000000") };
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
public class A144346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144346.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144346Inst Instance=new A144346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144347
{
public static readonly BigInteger[] Value={ 1L,12L,192L,3960L,100656L,3048192L,107255232L,4302305280L,193836779136L,9693022090752L,532784148728832L,31930395433896960L,2072320885985366016L,BigInteger.Parse("144803002560595771392"),BigInteger.Parse("10838696766561262190592"),BigInteger.Parse("865256088684973495910400"),BigInteger.Parse("73383436891415208719056896") };
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
public class A144347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144347Inst Instance=new A144347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144348
{
public static readonly BigInteger[] Value={ 1L,24L,600L,17160L,563976L,21095424L,887785920L,41589313920L,2148534533376L,121416817826304L,7453542764828160L,494050046853242880L,BigInteger.Parse("35173674025152638976"),BigInteger.Parse("2677307532371585777664"),BigInteger.Parse("216991376759173367070720"),BigInteger.Parse("18658548982937189595709440"),BigInteger.Parse("1696677198406950703545778176") };
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
public class A144348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144348Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144348.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144348.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144348Inst Instance=new A144348Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144349
{
public static readonly BigInteger[] Value={ 1L,15L,295L,7425L,229405L,8423415L,358764175L,17398082625L,946762033525L,57141470006775L,3788581132110775L,273749937606770625L,BigInteger.Parse("21411992601604730125"),BigInteger.Parse("1802522188780330392375"),BigInteger.Parse("162501272634914703865375"),BigInteger.Parse("15620379109661843174282625"),BigInteger.Parse("1594837561754271113467313125") };
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
public class A144349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144349Inst Instance=new A144349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144350
{
public static readonly BigInteger[] Value={ 1L,30L,925L,32400L,1298605L,59069010L,3016869625L,171258433500L,10708492743025L,731776512817350L,54281160516507925L,4344836976344865000L,BigInteger.Parse("373343787685538795125"),BigInteger.Parse("34283431717422205568250"),BigInteger.Parse("3350860422355179821712625"),BigInteger.Parse("347355560922824645523832500") };
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
public class A144350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144350Inst Instance=new A144350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144351
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,6L,3L,1L,1L,24L,8L,3L,1L,1L,120L,34L,9L,3L,1L,1L,720L,156L,36L,9L,3L,1L,1L,5040L,924L,166L,37L,9L,3L,1L,1L,40320L,6144L,968L,168L,37L,9L,3L,1L,1L,362880L,48096L,6372L,978L,169L,37L,9L,3L,1L,1L,3628800L,420480L,49368L,6416L,980L,169L,37L,9L,3L,1L,1L,39916800L,4134240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144351Inst : IEnumerable<long>
{
public static readonly long[] Value=A144351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144351.Bytes);
public long this[int i]=>Value[i];

public static A144351Inst Instance=new A144351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144352
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,36L,166L,968L,6372L,49368L,429240L,4198176L,45268416L,535590144L,6879038400L,95412176640L,1419918128640L,22571960048640L,381596438638080L,6836248502784000L,129352329079142400L,2577689266340966400L,BigInteger.Parse("53957785094515814400"),BigInteger.Parse("1183674698660605132800") };
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
public class A144352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144352Inst Instance=new A144352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144353
{
public static readonly long[] Value={ 1L,3L,1L,12L,9L,1L,60L,48L,27L,18L,1L,360L,300L,360L,120L,135L,30L,1L,2520L,2160L,2700L,1440L,900L,2160L,405L,240L,405L,45L,1L,20160L,17640L,22680L,25200L,7560L,18900L,10080L,11340L,2100L,7560L,2835L,420L,945L,63L,1L,181440L,161280L,211680L,241920L,126000L,70560L,181440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144353Inst : IEnumerable<long>
{
public static readonly long[] Value=A144353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144353.Bytes);
public long this[int i]=>Value[i];

public static A144353Inst Instance=new A144353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144354
{
public static readonly long[] Value={ 1L,4L,1L,20L,12L,1L,120L,80L,48L,24L,1L,840L,600L,800L,200L,240L,40L,1L,6720L,5040L,7200L,4000L,1800L,4800L,960L,400L,720L,60L,1L,60480L,47040L,70560L,84000L,17640L,50400L,28000L,33600L,4200L,16800L,6720L,700L,1680L,84L,1L,604800L,483840L,752640L,940800L,504000L,188160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144354Inst : IEnumerable<long>
{
public static readonly long[] Value=A144354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144354.Bytes);
public long this[int i]=>Value[i];

public static A144354Inst Instance=new A144354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144355
{
public static readonly long[] Value={ 1L,5L,1L,30L,15L,1L,210L,120L,75L,30L,1L,1680L,1050L,1500L,300L,375L,50L,1L,15120L,10080L,15750L,9000L,3150L,9000L,1875L,600L,1125L,75L,1L,151200L,105840L,176400L,220500L,35280L,110250L,63000L,78750L,7350L,31500L,13125L,1050L,2625L,105L,1L,1663200L,1209600L,2116800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144355Inst : IEnumerable<long>
{
public static readonly long[] Value=A144355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144355.Bytes);
public long this[int i]=>Value[i];

public static A144355Inst Instance=new A144355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144356
{
public static readonly long[] Value={ 1L,6L,1L,42L,18L,1L,336L,168L,108L,36L,1L,3024L,1680L,2520L,420L,540L,60L,1L,30240L,18144L,30240L,17640L,5040L,15120L,3240L,840L,1620L,90L,1L,332640L,211680L,381024L,493920L,63504L,211680L,123480L,158760L,11760L,52920L,22680L,1470L,3780L,126L,1L,3991680L,2661120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144356Inst : IEnumerable<long>
{
public static readonly long[] Value=A144356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144356.Bytes);
public long this[int i]=>Value[i];

public static A144356Inst Instance=new A144356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144357
{
public static readonly long[] Value={ 1L,1L,1L,0L,3L,1L,0L,0L,3L,6L,1L,0L,0L,0L,0L,15L,10L,1L,0L,0L,0L,0L,0L,0L,15L,0L,45L,15L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,105L,0L,105L,21L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,105L,0L,0L,420L,0L,210L,28L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,945L,0L,0L,1260L,0L,378L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144357Inst : IEnumerable<long>
{
public static readonly long[] Value=A144357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144357.Bytes);
public long this[int i]=>Value[i];

public static A144357Inst Instance=new A144357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144358
{
public static readonly long[] Value={ 1L,2L,1L,2L,6L,1L,0L,8L,12L,12L,1L,0L,0L,40L,20L,60L,20L,1L,0L,0L,0L,40L,0L,240L,120L,40L,180L,30L,1L,0L,0L,0L,0L,0L,0L,280L,840L,0L,840L,840L,70L,420L,42L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2240L,0L,0L,1120L,6720L,1680L,0L,2240L,3360L,112L,840L,56L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2240L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144358Inst : IEnumerable<long>
{
public static readonly long[] Value=A144358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144358.Bytes);
public long this[int i]=>Value[i];

public static A144358Inst Instance=new A144358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144359
{
public static readonly long[] Value={ 1L,20L,94L,103L,130L,556L,1048L,1330L,1359L,3147L,3599L,5963L,9248L,13855L,24264L,29098L,29099L,30697L,39854L,66568L,83730L,150837L,150936L,300494L,334988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144359Inst : IEnumerable<long>
{
public static readonly long[] Value=A144359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144359.Bytes);
public long this[int i]=>Value[i];

public static A144359Inst Instance=new A144359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144392
{
public static readonly long[] Value={ 0L,5L,-7L,27L,-84L,240L,-630L,1554L,-3702L,8694L,-20310L,47190L,-108684L,247572L,-557928L,1246320L,-2765760L,6106944L,-13427424L,29404704L,-64138560L,139366080L,-301749888L,651236352L,-1401444864L,3007987200L,-6440578560L,13759041024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144392Inst : IEnumerable<long>
{
public static readonly long[] Value=A144392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144392.Bytes);
public long this[int i]=>Value[i];

public static A144392Inst Instance=new A144392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144393
{
public static readonly long[] Value={ 2L,2L,2L,1L,4L,1L,1L,3L,3L,1L,1L,4L,0L,4L,1L,1L,5L,0L,0L,5L,1L,1L,6L,0L,0L,0L,6L,1L,1L,7L,0L,0L,0L,0L,7L,1L,1L,8L,0L,0L,0L,0L,0L,8L,1L,1L,9L,0L,0L,0L,0L,0L,0L,9L,1L,1L,10L,0L,0L,0L,0L,0L,0L,0L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144393Inst : IEnumerable<long>
{
public static readonly long[] Value=A144393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144393.Bytes);
public long this[int i]=>Value[i];

public static A144393Inst Instance=new A144393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144394
{
public static readonly long[] Value={ 6L,10L,10L,15L,20L,15L,21L,35L,35L,21L,28L,56L,70L,56L,28L,36L,84L,126L,126L,84L,36L,45L,120L,210L,252L,210L,120L,45L,55L,165L,330L,462L,462L,330L,165L,55L,66L,220L,495L,792L,924L,792L,495L,220L,66L,78L,286L,715L,1287L,1716L,1716L,1287L,715L,286L,78L,91L,364L,1001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144394Inst : IEnumerable<long>
{
public static readonly long[] Value=A144394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144394.Bytes);
public long this[int i]=>Value[i];

public static A144394Inst Instance=new A144394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144395
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,10L,10L,1L,1L,15L,20L,15L,1L,1L,21L,35L,35L,21L,1L,1L,28L,56L,70L,56L,28L,1L,1L,36L,84L,126L,126L,84L,36L,1L,1L,45L,120L,210L,252L,210L,120L,45L,1L,1L,55L,165L,330L,462L,462L,330L,165L,55L,1L,1L,66L,220L,495L,792L,924L,792L,495L,220L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144395Inst : IEnumerable<long>
{
public static readonly long[] Value=A144395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144395.Bytes);
public long this[int i]=>Value[i];

public static A144395Inst Instance=new A144395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144396
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144396Inst : IEnumerable<long>
{
public static readonly long[] Value=A144396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144396.Bytes);
public long this[int i]=>Value[i];

public static A144396Inst Instance=new A144396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144397
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,19L,19L,1L,1L,94L,146L,94L,1L,1L,581L,1198L,1198L,581L,1L,1L,4206L,10767L,14384L,10767L,4206L,1L,1L,34567L,105621L,176291L,176291L,105621L,34567L,1L,1L,317528L,1127548L,2257256L,2821894L,2257256L,1127548L,317528L,1L,1L,3225609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144397Inst : IEnumerable<long>
{
public static readonly long[] Value=A144397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144397.Bytes);
public long this[int i]=>Value[i];

public static A144397Inst Instance=new A144397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144398
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,5L,10L,10L,5L,1L,1L,6L,15L,0L,15L,6L,1L,1L,7L,21L,0L,0L,21L,7L,1L,1L,8L,28L,0L,0L,0L,28L,8L,1L,1L,9L,36L,0L,0L,0L,0L,36L,9L,1L,1L,10L,45L,0L,0L,0L,0L,0L,45L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144398Inst : IEnumerable<long>
{
public static readonly long[] Value=A144398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144398.Bytes);
public long this[int i]=>Value[i];

public static A144398Inst Instance=new A144398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144399
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,7L,10L,10L,1L,6L,25L,75L,175L,280L,280L,1L,10L,65L,315L,1225L,3780L,9100L,15400L,15400L,1L,15L,140L,980L,5565L,26145L,102025L,323400L,800800L,1401400L,1401400L,1L,21L,266L,2520L,19425L,125895L,695695L,3273270L,12962950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144399Inst : IEnumerable<long>
{
public static readonly long[] Value=A144399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144399.Bytes);
public long this[int i]=>Value[i];

public static A144399Inst Instance=new A144399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144400
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-3L,1L,4L,-6L,4L,5L,-10L,10L,0L,-3L,6L,-15L,20L,0L,-18L,10L,7L,-21L,35L,0L,-63L,70L,-24L,8L,-28L,56L,0L,-168L,280L,-192L,49L,9L,-36L,84L,0L,-378L,840L,-864L,441L,-89L,10L,-45L,120L,0L,-756L,2100L,-2880L,2205L,-890L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144400Inst : IEnumerable<long>
{
public static readonly long[] Value=A144400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144400.Bytes);
public long this[int i]=>Value[i];

public static A144400Inst Instance=new A144400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144401
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,2L,1L,4L,6L,6L,3L,1L,5L,10L,13L,11L,4L,1L,6L,15L,24L,27L,18L,6L,1L,7L,21L,40L,55L,51L,30L,9L,1L,8L,28L,62L,100L,116L,94L,50L,13L,1L,9L,36L,91L,168L,231L,234L,171L,81L,19L,1L,10L,45L,128L,266L,420L,505L,460L,303L,130L,28L,1L,11L,55L,174L,402L,714L,987L,1065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144401Inst : IEnumerable<long>
{
public static readonly long[] Value=A144401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144401.Bytes);
public long this[int i]=>Value[i];

public static A144401Inst Instance=new A144401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144402
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,1L,0L,0L,7L,6L,1L,0L,0L,10L,25L,10L,1L,0L,0L,10L,75L,65L,15L,1L,0L,0L,0L,175L,315L,140L,21L,1L,0L,0L,0L,280L,1225L,980L,266L,28L,1L,0L,0L,0L,280L,3780L,5565L,2520L,462L,36L,1L,0L,0L,0L,0L,9100L,26145L,19425L,5670L,750L,45L,1L,0L,0L,0L,0L,15400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144402Inst : IEnumerable<long>
{
public static readonly long[] Value=A144402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144402.Bytes);
public long this[int i]=>Value[i];

public static A144402Inst Instance=new A144402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144403
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,1L,-1L,-1L,5L,5L,-1L,-1L,11L,29L,11L,-1L,-1L,19L,89L,89L,19L,-1L,-1L,29L,209L,379L,209L,29L,-1L,-1L,41L,419L,1189L,1189L,419L,41L,-1L,-1L,55L,755L,3079L,4829L,3079L,755L,55L,-1L,-1L,71L,1259L,6971L,15749L,15749L,6971L,1259L,71L,-1L,-1L,89L,1979L,14279L,43889L,63251L,43889L,14279L,1979L,89L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144403Inst : IEnumerable<long>
{
public static readonly long[] Value=A144403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144403.Bytes);
public long this[int i]=>Value[i];

public static A144403Inst Instance=new A144403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144404
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,23L,23L,1L,1L,43L,101L,43L,1L,1L,69L,289L,289L,69L,1L,1L,101L,659L,1179L,659L,101L,1L,1L,139L,1301L,3639L,3639L,1301L,139L,1L,1L,183L,2323L,9351L,14629L,9351L,2323L,183L,1L,1L,233L,3851L,21083L,47501L,47501L,21083L,3851L,233L,1L,1L,289L,6029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144404Inst : IEnumerable<long>
{
public static readonly long[] Value=A144404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144404.Bytes);
public long this[int i]=>Value[i];

public static A144404Inst Instance=new A144404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144405
{
public static readonly long[] Value={ 1L,1L,1L,1L,18L,1L,1L,69L,69L,1L,1L,172L,606L,172L,1L,1L,345L,2890L,2890L,345L,1L,1L,606L,9885L,23580L,9885L,606L,1L,1L,973L,27321L,127365L,127365L,27321L,973L,1L,1L,1464L,65044L,523656L,1024030L,523656L,65044L,1464L,1L,1L,2097L,138636L,1770972L,5985126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144405Inst : IEnumerable<long>
{
public static readonly long[] Value=A144405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144405.Bytes);
public long this[int i]=>Value[i];

public static A144405Inst Instance=new A144405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144406
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,2L,4L,5L,1L,1L,1L,2L,4L,7L,8L,1L,1L,1L,2L,4L,8L,13L,13L,1L,1L,1L,2L,4L,8L,15L,24L,21L,1L,1L,1L,2L,4L,8L,16L,29L,44L,34L,1L,1L,1L,2L,4L,8L,16L,31L,56L,81L,55L,1L,1L,1L,2L,4L,8L,16L,32L,61L,108L,149L,89L,1L,1L,1L,2L,4L,8L,16L,32L,63L,120L,208L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144406Inst : IEnumerable<long>
{
public static readonly long[] Value=A144406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144406.Bytes);
public long this[int i]=>Value[i];

public static A144406Inst Instance=new A144406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144407
{
public static readonly long[] Value={ 49L,289L,529L,961L,1681L,2209L,2401L,5041L,5329L,6241L,7921L,9409L,10609L,12769L,14161L,16129L,18769L,22801L,25921L,27889L,36481L,37249L,39601L,47089L,49729L,54289L,57121L,58081L,66049L,69169L,73441L,78961L,82369L,83521L,96721L,97969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144407Inst : IEnumerable<long>
{
public static readonly long[] Value=A144407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144407.Bytes);
public long this[int i]=>Value[i];

public static A144407Inst Instance=new A144407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144504
{
public static readonly BigInteger[] Value={ 142857L,285714L,142857142857L,285714285714L,142857142857142857L,285714285714285714L,BigInteger.Parse("142857142857142857142857"),BigInteger.Parse("285714285714285714285714"),BigInteger.Parse("142857142857142857142857142857") };
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
public class A144504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144504Inst Instance=new A144504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144505
{
public static readonly long[] Value={ 1L,1L,-1L,2L,1L,-5L,7L,-1L,9L,-30L,37L,1L,-14L,81L,-229L,266L,-1L,20L,-175L,835L,-2165L,2431L,1L,-27L,330L,-2330L,9990L,-24576L,27007L,-1L,35L,-567L,5495L,-34300L,137466L,-326515L,353522L,1L,-44L,910L,-11522L,97405L,-561386L,2148139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144505Inst : IEnumerable<long>
{
public static readonly long[] Value=A144505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144505.Bytes);
public long this[int i]=>Value[i];

public static A144505Inst Instance=new A144505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144506
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,14L,175L,2330L,34300L,561386L,10179309L,203240850L,4439192835L,105413331100L,2705921548616L,74703337429084L,2207904948683525L,69575538504102190L,2329022305536291275L,BigInteger.Parse("82546355086989894366"),BigInteger.Parse("3088417981826529182964"),BigInteger.Parse("121651432581579519835950"),BigInteger.Parse("5032424258902838518567945") };
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
public class A144506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144506Inst Instance=new A144506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144507
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,1L,20L,330L,5495L,97405L,1867446L,38849790L,875734035L,21320230140L,558453090910L,15677076200786L,469894617088260L,14985440023696415L,506831098757070010L,18125347345533260190UL,BigInteger.Parse("683518670893880841921"),BigInteger.Parse("27112243165544881804755"),BigInteger.Parse("1128576366359460556636770") };
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
public class A144507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144507Inst Instance=new A144507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144508
{
public static readonly BigInteger[] Value={ 1L,4L,121L,18252L,7958726L,7528988476L,13130817809439L,38001495237579931L,BigInteger.Parse("169490425291053577442"),BigInteger.Parse("1102725620990181693266071"),BigInteger.Parse("10030550674270068548738783696"),BigInteger.Parse("123317200510025161580777179001154"),BigInteger.Parse("1993320784474917266370637900936051186"),BigInteger.Parse("41401645296339316791633672053851083955147") };
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
public class A144508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144508Inst Instance=new A144508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144509
{
public static readonly BigInteger[] Value={ 1L,5L,456L,405408L,1495388159L,15467641899285L,361207016885536095L,BigInteger.Parse("16557834064546698285496"),BigInteger.Parse("1350410785161120363519024709"),BigInteger.Parse("182141025850694258874753732988078"),BigInteger.Parse("38395944834298393218465758049745918098"),BigInteger.Parse("12093097322244029427838390643054170162054258"),BigInteger.Parse("5485321312184901565806045962453632525844948020084") };
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
public class A144509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144509Inst Instance=new A144509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144510
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,7L,3L,1L,1L,37L,31L,4L,1L,1L,266L,842L,121L,5L,1L,1L,2431L,45296L,18252L,456L,6L,1L,1L,27007L,4061871L,7958726L,405408L,1709L,7L,1L,1L,353522L,546809243L,7528988476L,1495388159L,9268549L,6427L,8L,1L,1L,5329837L,103123135501L,13130817809439L,15467641899285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144510Inst : IEnumerable<long>
{
public static readonly long[] Value=A144510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144510.Bytes);
public long this[int i]=>Value[i];

public static A144510Inst Instance=new A144510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144511
{
public static readonly BigInteger[] Value={ 0L,1L,37L,842L,18252L,405408L,9268549L,216864652L,5165454442L,124762262630L,3047235458767L,75109521108771L,1865470016184352L,46631215889276662L,1172088706950306293L,BigInteger.Parse("29601905040172054928"),BigInteger.Parse("750748513858793527974"),BigInteger.Parse("19110455782881086439234"),BigInteger.Parse("488057675380082251617235") };
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
public class A144511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144511Inst Instance=new A144511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144512
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,7L,1L,1L,4L,31L,37L,1L,1L,5L,121L,842L,266L,1L,1L,6L,456L,18252L,45296L,2431L,1L,1L,7L,1709L,405408L,7958726L,4061871L,27007L,1L,1L,8L,6427L,9268549L,1495388159L,7528988476L,546809243L,353522L,1L,1L,9L,24301L,216864652L,295887993624L,15467641899285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144512Inst : IEnumerable<long>
{
public static readonly long[] Value=A144512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144512.Bytes);
public long this[int i]=>Value[i];

public static A144512Inst Instance=new A144512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144513
{
public static readonly BigInteger[] Value={ 2L,18L,162L,1670L,19980L,274932L,4296278L,75324762L,1466031690L,31386435410L,733391707752L,18578222154648L,507246285802802L,14851746921266010L,464244744007818090L,15431886798641124662UL,BigInteger.Parse("543593886328031841828"),BigInteger.Parse("20228083875146926867932"),BigInteger.Parse("792934721766833544369830") };
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
public class A144513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144513Inst Instance=new A144513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144514
{
public static readonly BigInteger[] Value={ 6L,84L,1050L,13980L,205800L,3368316L,61075854L,1219445100L,26635157010L,632479986600L,16235529291696L,448220024574504L,13247429692101150L,417453231024613140L,13974133833217747650UL,BigInteger.Parse("495278130521939366196"),BigInteger.Parse("18530507890959175097784"),BigInteger.Parse("729908595489477119015700") };
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
public class A144514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144514Inst Instance=new A144514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144515
{
public static readonly long[] Value={ 1L,2L,1L,2L,0L,1L,3L,1L,0L,1L,2L,0L,0L,0L,1L,4L,1L,1L,0L,0L,1L,2L,0L,0L,0L,0L,0L,1L,4L,1L,0L,1L,0L,0L,0L,1L,3L,0L,1L,0L,0L,0L,0L,0L,1L,4L,1L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144515Inst : IEnumerable<long>
{
public static readonly long[] Value=A144515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144515.Bytes);
public long this[int i]=>Value[i];

public static A144515Inst Instance=new A144515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144516
{
public static readonly long[] Value={ 0L,0L,10L,175L,1225L,5565L,19425L,56595L,144375L,332475L,705705L,1401400L,2632630L,4718350L,8121750L,13498170L,21754050L,34118490L,52229100L,78233925L,114911335L,165809875L,235410175L,329311125L,454442625L,619307325L,834253875L,1111784310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144516Inst : IEnumerable<long>
{
public static readonly long[] Value=A144516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144516.Bytes);
public long this[int i]=>Value[i];

public static A144516Inst Instance=new A144516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144517
{
public static readonly long[] Value={ 7L,23L,31L,41L,101L,109L,227L,241L,311L,347L,389L,587L,701L,757L,859L,947L,977L,1063L,1069L,1123L,1181L,1229L,1237L,1289L,1303L,1327L,1451L,1489L,1543L,1559L,1613L,1669L,1733L,1787L,1879L,2011L,2029L,2039L,2203L,2213L,2281L,2357L,2393L,2459L,2503L,2593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144517Inst : IEnumerable<long>
{
public static readonly long[] Value=A144517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144517.Bytes);
public long this[int i]=>Value[i];

public static A144517Inst Instance=new A144517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144518
{
public static readonly long[] Value={ 5L,14L,3L,11L,10L,9L,6L,5L,14L,6L,6L,6L,2L,9L,8L,6L,2L,7L,1L,6L,6L,12L,8L,12L,18L,5L,14L,16L,5L,13L,9L,7L,16L,12L,13L,9L,13L,14L,12L,10L,7L,12L,15L,11L,6L,5L,10L,11L,13L,13L,6L,10L,4L,8L,9L,13L,8L,7L,10L,12L,9L,6L,5L,4L,5L,12L,11L,6L,11L,8L,6L,8L,12L,16L,10L,13L,5L,8L,8L,8L,5L,3L,6L,11L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144518Inst : IEnumerable<long>
{
public static readonly long[] Value=A144518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144518.Bytes);
public long this[int i]=>Value[i];

public static A144518Inst Instance=new A144518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144519
{
public static readonly long[] Value={ 6L,15L,28L,66L,91L,153L,190L,276L,435L,496L,703L,861L,946L,1128L,1431L,1770L,1891L,2278L,2556L,2701L,3160L,3486L,4005L,4753L,5151L,5356L,5778L,5995L,6441L,8128L,8646L,9453L,9730L,11175L,11476L,12403L,13366L,14028L,15051L,16110L,16471L,18336L,18721L,19503L,19900L,22366L,24976L,25878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144519Inst : IEnumerable<long>
{
public static readonly long[] Value=A144519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144519.Bytes);
public long this[int i]=>Value[i];

public static A144519Inst Instance=new A144519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144568
{
public static readonly long[] Value={ 6L,12L,22L,34L,48L,54L,58L,63L,82L,88L,96L,99L,108L,117L,118L,136L,142L,147L,148L,153L,165L,176L,184L,198L,202L,207L,214L,268L,273L,274L,279L,296L,298L,316L,325L,328L,333L,345L,358L,368L,369L,376L,382L,384L,385L,388L,394L,399L,414L,423L,424L,432L,435L,454L,462L,464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144568Inst : IEnumerable<long>
{
public static readonly long[] Value=A144568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144568.Bytes);
public long this[int i]=>Value[i];

public static A144568Inst Instance=new A144568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144569
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,2L,0L,2L,2L,2L,1L,2L,1L,1L,2L,2L,0L,0L,3L,0L,3L,3L,3L,2L,3L,2L,2L,3L,3L,1L,3L,1L,1L,3L,3L,0L,1L,3L,2L,0L,3L,2L,1L,0L,3L,1L,0L,2L,3L,1L,2L,0L,1L,2L,3L,0L,2L,1L,3L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,2L,0L,2L,2L,2L,1L,2L,1L,1L,2L,2L,0L,0L,3L,0L,3L,3L,3L,2L,3L,2L,2L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144569Inst : IEnumerable<long>
{
public static readonly long[] Value=A144569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144569.Bytes);
public long this[int i]=>Value[i];

public static A144569Inst Instance=new A144569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144570
{
public static readonly long[] Value={ 1L,4L,8L,10L,16L,20L,25L,27L,33L,40L,44L,51L,56L,58L,64L,72L,80L,82L,90L,94L,96L,105L,111L,118L,126L,132L,134L,140L,142L,146L,164L,169L,176L,178L,190L,194L,202L,208L,213L,219L,226L,230L,243L,245L,249L,252L,266L,282L,287L,289L,294L,300L,302L,315L,322L,328L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144570Inst : IEnumerable<long>
{
public static readonly long[] Value=A144570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144570.Bytes);
public long this[int i]=>Value[i];

public static A144570Inst Instance=new A144570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144571
{
public static readonly long[] Value={ 17L,1601L,8837L,16901L,33857L,65537L,160001L,190097L,240101L,295937L,401957L,577601L,1136357L,1336337L,1378277L,1464101L,1552517L,1833317L,2464901L,2755601L,3519377L,3587237L,3865157L,4227137L,4301477L,5410277L,5664401L,6100901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144571Inst : IEnumerable<long>
{
public static readonly long[] Value=A144571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144571.Bytes);
public long this[int i]=>Value[i];

public static A144571Inst Instance=new A144571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144572
{
public static readonly long[] Value={ 2L,5L,11L,17L,41L,59L,73L,83L,97L,127L,179L,191L,227L,283L,353L,389L,431L,461L,563L,571L,599L,661L,727L,751L,797L,877L,947L,1031L,1087L,1093L,1103L,1129L,1217L,1297L,1303L,1409L,1453L,1483L,1523L,1543L,1567L,1697L,1741L,1753L,1787L,1801L,1823L,1867L,1913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144572Inst : IEnumerable<long>
{
public static readonly long[] Value=A144572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144572.Bytes);
public long this[int i]=>Value[i];

public static A144572Inst Instance=new A144572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144573
{
public static readonly long[] Value={ 2L,5L,11L,11L,17L,23L,29L,29L,37L,41L,47L,53L,59L,59L,67L,73L,83L,83L,97L,97L,97L,107L,113L,127L,127L,137L,137L,149L,149L,149L,167L,173L,179L,179L,191L,197L,211L,211L,223L,223L,227L,233L,251L,251L,251L,257L,269L,283L,293L,293L,307L,307L,307L,317L,331L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144573Inst : IEnumerable<long>
{
public static readonly long[] Value=A144573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144573.Bytes);
public long this[int i]=>Value[i];

public static A144573Inst Instance=new A144573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144574
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,23L,23L,31L,41L,43L,47L,53L,59L,61L,73L,79L,83L,89L,89L,97L,103L,109L,113L,127L,131L,131L,139L,139L,139L,163L,167L,173L,179L,191L,193L,199L,199L,211L,211L,227L,229L,241L,241L,241L,251L,263L,283L,283L,283L,293L,293L,293L,313L,317L,317L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144574Inst : IEnumerable<long>
{
public static readonly long[] Value=A144574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144574.Bytes);
public long this[int i]=>Value[i];

public static A144574Inst Instance=new A144574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144575
{
public static readonly BigInteger[] Value={ 1L,1L,5L,25L,217L,2321L,32221L,536425L,10547825L,238451617L,6103391221L,174418724921L,5506024371145L,190282381973425L,7145586497798477L,289733147423281801L,12615792602988127201UL,BigInteger.Parse("587128127734854278465"),BigInteger.Parse("29084008051746449028325"),BigInteger.Parse("1527881758843209566647897") };
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
public class A144575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144575Inst Instance=new A144575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144576
{
public static readonly BigInteger[] Value={ 1L,1L,6L,31L,301L,3426L,51751L,926731L,19691106L,479961901L,13256384851L,408621822126L,13915350562081L,518741273626681L,21013220503491126L,919071064063596151L,BigInteger.Parse("43167975952565245501"),BigInteger.Parse("2167078807061679282306"),BigInteger.Parse("115795155400715170458631"),BigInteger.Parse("6561750899663711363984851") };
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
public class A144576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144576Inst Instance=new A144576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144577
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,757L,4973L,194671L,842411L,11218933L,3358395757L,115106092471L,2189182968473L,7379994323497L,1699615680368861L,19346973713722411L,BigInteger.Parse("23008945996332629551"),BigInteger.Parse("1335947317588460238301"),BigInteger.Parse("8289679255721758160317"),BigInteger.Parse("1095056665754286849584771") };
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
public class A144577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144577Inst Instance=new A144577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144578
{
public static readonly BigInteger[] Value={ 1L,2L,4L,48L,384L,1920L,46080L,129024L,1032192L,185794560L,3715891200L,40874803200L,78479622144L,10202350878720L,64924051046400L,42849873690624000L,1371195958099968000L,4662066257539891200L,BigInteger.Parse("335668770542872166400"),BigInteger.Parse("5797915127558701056000") };
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
public class A144578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144578Inst Instance=new A144578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144579
{
public static readonly BigInteger[] Value={ 1L,1L,3L,31L,301L,571L,51751L,926731L,3281851L,479961901L,13256384851L,9729091003L,13915350562081L,74105896232383L,3502203417248521L,919071064063596151L,BigInteger.Parse("43167975952565245501"),BigInteger.Parse("361179801176946547051"),BigInteger.Parse("16542165057245024351233"),BigInteger.Parse("6561750899663711363984851") };
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
public class A144579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144579Inst Instance=new A144579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144580
{
public static readonly BigInteger[] Value={ 1L,2L,4L,48L,384L,640L,46080L,645120L,1720320L,185794560L,3715891200L,1946419200L,1961990553600L,7287393484800L,238054853836800L,42849873690624000L,1371195958099968000L,7770110429233152000L,BigInteger.Parse("239763407530622976000"),BigInteger.Parse("63777066403145711616000") };
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
public class A144580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144580Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144580.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144580Inst Instance=new A144580Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144581
{
public static readonly long[] Value={ 28L,45L,66L,78L,105L,120L,153L,171L,190L,231L,300L,325L,378L,406L,435L,465L,496L,561L,595L,630L,741L,780L,861L,903L,946L,990L,1128L,1378L,1485L,1540L,1596L,1653L,2016L,2080L,2211L,2278L,2485L,2556L,2628L,2850L,3081L,3160L,3240L,3321L,3570L,3655L,3741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144581Inst : IEnumerable<long>
{
public static readonly long[] Value=A144581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144581.Bytes);
public long this[int i]=>Value[i];

public static A144581Inst Instance=new A144581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144582
{
public static readonly long[] Value={ 0L,1L,10L,11L,12L,28L,29L,32L,33L,34L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,272L,273L,274L,275L,276L,277L,278L,279L,280L,281L,282L,283L,284L,285L,286L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144582Inst : IEnumerable<long>
{
public static readonly long[] Value=A144582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144582.Bytes);
public long this[int i]=>Value[i];

public static A144582Inst Instance=new A144582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144583
{
public static readonly long[] Value={ 2L,3L,6L,6L,10L,7L,14L,7L,18L,11L,22L,14L,26L,15L,30L,12L,34L,19L,38L,22L,42L,23L,46L,15L,50L,27L,54L,30L,58L,31L,62L,13L,66L,35L,70L,38L,74L,39L,78L,23L,82L,43L,86L,46L,90L,47L,94L,28L,98L,51L,102L,54L,106L,55L,110L,31L,114L,59L,118L,62L,122L,63L,126L,14L,130L,67L,134L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144583Inst : IEnumerable<long>
{
public static readonly long[] Value=A144583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144583.Bytes);
public long this[int i]=>Value[i];

public static A144583Inst Instance=new A144583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144616
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,BigInteger.Parse("467807924720320453655260875000"),BigInteger.Parse("17708695394150597647449176493763755467520000000"),BigInteger.Parse("8096800377970649960875919032857634716820075076062381575000000"),BigInteger.Parse("2051564503724359411435325207087513361930253427318374450656960000000000") };
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
public class A144616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144616Inst Instance=new A144616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144617
{
public static readonly long[] Value={ 1L,3L,-5L,81L,-462L,385L,30375L,-369603L,765765L,-425425L,4465125L,-94121676L,349922430L,-446185740L,185910725L,1519035525L,-49286948607L,284499769554L,-614135872350L,566098157625L,-188699385875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144617Inst : IEnumerable<long>
{
public static readonly long[] Value=A144617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144617.Bytes);
public long this[int i]=>Value[i];

public static A144617Inst Instance=new A144617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144618
{
public static readonly BigInteger[] Value={ 1L,24L,1152L,414720L,39813120L,6688604160L,4815794995200L,115579079884800L,22191183337881600L,BigInteger.Parse("263631258054033408000"),BigInteger.Parse("88580102706155225088000"),BigInteger.Parse("27636992044320430227456000"),BigInteger.Parse("39797268543821419527536640000") };
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
public class A144618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144618Inst Instance=new A144618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144619
{
public static readonly long[] Value={ 8L,27L,46L,65L,84L,103L,122L,141L,160L,179L,198L,217L,236L,255L,274L,293L,312L,331L,350L,369L,388L,407L,426L,445L,464L,483L,502L,521L,540L,559L,578L,597L,616L,635L,654L,673L,692L,711L,730L,749L,768L,787L,806L,825L,844L,863L,882L,901L,920L,939L,958L,977L,996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144619Inst : IEnumerable<long>
{
public static readonly long[] Value=A144619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144619.Bytes);
public long this[int i]=>Value[i];

public static A144619Inst Instance=new A144619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144620
{
public static readonly long[] Value={ 5L,17L,41L,59L,89L,167L,191L,239L,269L,281L,359L,449L,479L,491L,509L,521L,587L,617L,647L,701L,719L,821L,881L,911L,929L,971L,1031L,1181L,1217L,1259L,1289L,1307L,1361L,1367L,1559L,1601L,1697L,1709L,1721L,1787L,1877L,1889L,1907L,1931L,1949L,1997L,2039L,2129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144620Inst : IEnumerable<long>
{
public static readonly long[] Value=A144620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144620.Bytes);
public long this[int i]=>Value[i];

public static A144620Inst Instance=new A144620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144621
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,945L,1845585L,6922244887425L,BigInteger.Parse("96595543392827888368850625"),BigInteger.Parse("18734868077603955570406193129480504943860234712890625") };
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
public class A144621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144621.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144621Inst Instance=new A144621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144622
{
public static readonly long[] Value={ 1L,-9L,7L,-135L,594L,-455L,-42525L,451737L,-883575L,475475L,-5740875L,111234708L,-396578754L,493152660L,-202076875L,-1856598975L,56869556085L,-317970330678L,672625003050L,-611386010235L,201713136625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144622Inst : IEnumerable<long>
{
public static readonly long[] Value=A144622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144622.Bytes);
public long this[int i]=>Value[i];

public static A144622Inst Instance=new A144622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144623
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,3L,4L,2L,4L,4L,4L,5L,6L,6L,6L,3L,5L,5L,5L,6L,6L,5L,7L,7L,8L,8L,8L,8L,9L,9L,8L,4L,6L,6L,6L,7L,6L,7L,8L,8L,8L,8L,6L,8L,10L,9L,10L,9L,10L,10L,10L,10L,11L,10L,10L,11L,12L,12L,12L,12L,12L,12L,10L,5L,7L,7L,7L,8L,7L,8L,9L,9L,8L,7L,9L,10L,10L,11L,11L,10L,10L,10L,10L,11L,9L,7L,11L,11L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144623Inst : IEnumerable<long>
{
public static readonly long[] Value=A144623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144623.Bytes);
public long this[int i]=>Value[i];

public static A144623Inst Instance=new A144623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144624
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,6L,4L,7L,7L,8L,11L,16L,17L,19L,11L,15L,15L,16L,19L,22L,18L,28L,29L,36L,37L,40L,41L,49L,51L,48L,26L,31L,31L,32L,35L,34L,39L,44L,45L,50L,51L,39L,53L,66L,63L,72L,67L,76L,77L,80L,81L,90L,87L,90L,98L,109L,111L,116L,118L,122L,125L,109L,57L,63L,63L,64L,67L,66L,71L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144624Inst : IEnumerable<long>
{
public static readonly long[] Value=A144624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144624.Bytes);
public long this[int i]=>Value[i];

public static A144624Inst Instance=new A144624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144625
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,1L,0L,0L,2L,3L,0L,0L,2L,1L,0L,1L,2L,0L,0L,3L,0L,2L,0L,1L,1L,1L,1L,0L,2L,1L,1L,0L,2L,0L,1L,2L,0L,0L,3L,4L,0L,0L,3L,1L,0L,2L,2L,0L,1L,3L,0L,0L,4L,0L,3L,0L,1L,2L,1L,1L,1L,2L,1L,0L,3L,1L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144625Inst : IEnumerable<long>
{
public static readonly long[] Value=A144625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144625.Bytes);
public long this[int i]=>Value[i];

public static A144625Inst Instance=new A144625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144626
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,4L,10L,10L,1L,6L,15L,15L,10L,60L,105L,70L,280L,280L,1L,10L,45L,105L,105L,20L,210L,840L,1260L,280L,2520L,6300L,2800L,15400L,15400L,1L,15L,105L,420L,945L,945L,35L,560L,3780L,12600L,17325L,840L,12600L,69300L,138600L,15400L,184800L,600600L,200200L,1401400L,1401400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144626Inst : IEnumerable<long>
{
public static readonly long[] Value=A144626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144626.Bytes);
public long this[int i]=>Value[i];

public static A144626Inst Instance=new A144626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144627
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,1L,0L,1L,0L,0L,3L,2L,1L,0L,2L,1L,0L,1L,0L,0L,4L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,1L,0L,0L,5L,4L,3L,2L,1L,0L,4L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,1L,0L,0L,6L,5L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,4L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,1L,0L,0L,7L,6L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144627Inst : IEnumerable<long>
{
public static readonly long[] Value=A144627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144627.Bytes);
public long this[int i]=>Value[i];

public static A144627Inst Instance=new A144627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144628
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,2L,0L,1L,0L,0L,1L,2L,3L,0L,1L,2L,0L,1L,0L,0L,1L,2L,3L,4L,0L,1L,2L,3L,0L,1L,2L,0L,1L,0L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,0L,1L,2L,3L,0L,1L,2L,0L,1L,0L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,0L,1L,2L,3L,0L,1L,2L,0L,1L,0L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144628Inst : IEnumerable<long>
{
public static readonly long[] Value=A144628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144628.Bytes);
public long this[int i]=>Value[i];

public static A144628Inst Instance=new A144628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144629
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,1L,2L,0L,0L,0L,0L,1L,1L,1L,2L,2L,3L,0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,5L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,6L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144629Inst : IEnumerable<long>
{
public static readonly long[] Value=A144629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144629.Bytes);
public long this[int i]=>Value[i];

public static A144629Inst Instance=new A144629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144630
{
public static readonly long[] Value={ 1L,12L,4L,180L,12L,9L,2800L,880L,40L,16L,44100L,46900L,4480L,40L,25L,698544L,1615824L,411264L,13104L,84L,36L,11099088L,45094896L,23653476L,2268756L,36036L,84L,49L,176679360L,1115345088L,1017615456L,207193536L,9660816L,79776L,144L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144630Inst : IEnumerable<long>
{
public static readonly long[] Value=A144630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144630.Bytes);
public long this[int i]=>Value[i];

public static A144630Inst Instance=new A144630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144631
{
public static readonly BigInteger[] Value={ 4L,12L,880L,46900L,1615824L,45094896L,1115345088L,25519125060L,553014576400L,11514200107696L,232490008680384L,4581732884262352L,88532684825838400L,1683073282734360000L,BigInteger.Parse("31561148509363526400"),BigInteger.Parse("584964180982546208100") };
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
public class A144631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144631Inst Instance=new A144631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144648
{
public static readonly long[] Value={ 10147737600L,166240237363200L,310334052188160L,9500311941120000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144648Inst : IEnumerable<long>
{
public static readonly long[] Value=A144648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144648.Bytes);
public long this[int i]=>Value[i];

public static A144648Inst Instance=new A144648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144649
{
public static readonly BigInteger[] Value={ 0L,14400L,134289792000L,BigInteger.Parse("29865588836219136000"),BigInteger.Parse("64007711015400701105356800000"),BigInteger.Parse("799901135455942846519287494400000000000"),BigInteger.Parse("42346525471797343063631567858734790430720000000000"),BigInteger.Parse("7611746717262781749937067971966455935937523732684800000000000"),BigInteger.Parse("3949387898792061570875758855816554982971495343701121923966566400000000000") };
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
public class A144649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144649.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144649Inst Instance=new A144649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144650
{
public static readonly long[] Value={ 5L,8L,13L,11L,18L,25L,14L,23L,32L,41L,17L,28L,39L,50L,61L,20L,33L,46L,59L,72L,85L,23L,38L,53L,68L,83L,98L,113L,26L,43L,60L,77L,94L,111L,128L,145L,29L,48L,67L,86L,105L,124L,143L,162L,181L,32L,53L,74L,95L,116L,137L,158L,179L,200L,221L,35L,58L,81L,104L,127L,150L,173L,196L,219L,242L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144650Inst : IEnumerable<long>
{
public static readonly long[] Value=A144650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144650.Bytes);
public long this[int i]=>Value[i];

public static A144650Inst Instance=new A144650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144651
{
public static readonly long[] Value={ 8954982400L,146700521676800L,273857689763840L,8383654522880000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144651Inst : IEnumerable<long>
{
public static readonly long[] Value=A144651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144651.Bytes);
public long this[int i]=>Value[i];

public static A144651Inst Instance=new A144651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144652
{
public static readonly long[] Value={ 2L,3L,6L,5L,8L,12L,6L,11L,15L,20L,8L,13L,19L,24L,30L,9L,16L,22L,29L,35L,42L,11L,18L,26L,33L,41L,48L,56L,12L,21L,29L,38L,46L,55L,63L,72L,14L,23L,33L,42L,52L,61L,71L,80L,90L,15L,26L,36L,47L,57L,68L,78L,89L,99L,110L,17L,28L,40L,51L,63L,74L,86L,97L,109L,120L,132L,18L,31L,43L,56L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144652Inst : IEnumerable<long>
{
public static readonly long[] Value=A144652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144652.Bytes);
public long this[int i]=>Value[i];

public static A144652Inst Instance=new A144652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144653
{
public static readonly long[] Value={ 1L,2L,6L,15L,21L,126L,990L,1287L,15015L,102102L,75582L,1322685L,5148297L,12257850L,286833690L,29113619535L,24131609775L,5056146810L,158337229050L,135195634035L,4770474515235L,177808595567850L,155131557292530L,12798353476633725L,79057257761377467L,35057064527669646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144653Inst : IEnumerable<long>
{
public static readonly long[] Value=A144653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144653.Bytes);
public long this[int i]=>Value[i];

public static A144653Inst Instance=new A144653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144654
{
public static readonly long[] Value={ 0L,3L,6L,14L,155L,167L,1239L,433L,8109L,8389L,95051L,97571L,1298453L,1326173L,1351913L,1375937L,47547623L,48268343L,930031437L,314094559L,317974435L,64333911L,498634963L,1511424393L,38157431275L,38514379867L,349718397003L,352692968603L,10311277859587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144654Inst : IEnumerable<long>
{
public static readonly long[] Value=A144654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144654.Bytes);
public long this[int i]=>Value[i];

public static A144654Inst Instance=new A144654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144655
{
public static readonly long[] Value={ 1L,2L,1L,1L,6L,4L,20L,5L,70L,56L,504L,420L,4620L,3960L,3432L,3003L,90090L,80080L,1361360L,408408L,369512L,67184L,470288L,1293292L,29745716L,27457584L,228813200L,212469400L,5736673800L,5354228880L,155272637520L,145568097675L,273491577450L,257403837600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144655Inst : IEnumerable<long>
{
public static readonly long[] Value=A144655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144655.Bytes);
public long this[int i]=>Value[i];

public static A144655Inst Instance=new A144655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144656
{
public static readonly BigInteger[] Value={ 0L,1L,0L,1L,4L,49L,900L,24649L,944784L,48455521L,3210355600L,267186643801L,27307626948900L,3363915436531441L,491705171699154084L,BigInteger.Parse("84158959760104032049"),BigInteger.Parse("16675767262618669710400"),BigInteger.Parse("3787671541267275818341249"),BigInteger.Parse("977702867682508392324162624"),BigInteger.Parse("284628954669920840314598014801") };
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
public class A144656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144656Inst Instance=new A144656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144657
{
public static readonly long[] Value={ 0L,2L,14L,62L,242L,912L,3418L,12854L,48602L,184736L,705410L,2704132L,10400574L,40116572L,155117490L,601080358L,2333606186L,9075135264L,35345263762L,137846528780L,538257874398L,2104098963676L,8233430727554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144657Inst : IEnumerable<long>
{
public static readonly long[] Value=A144657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144657.Bytes);
public long this[int i]=>Value[i];

public static A144657Inst Instance=new A144657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144658
{
public static readonly BigInteger[] Value={ 0L,6L,222L,5052L,109512L,2432448L,55611294L,1301187912L,30992726652L,748573575780L,18283412752602L,450657126652626L,11192820097106112L,279787295335659972L,7032532241701837758L,BigInteger.Parse("177611430241032329568") };
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
public class A144658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144658Inst Instance=new A144658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144659
{
public static readonly BigInteger[] Value={ 0L,0L,3L,60L,990L,16485L,292215L,5602338L,116549370L,2627202105L,63960690420L,1675359272730L,47031228602358L,1409683851264780L,44956320071089245L,1520493296271210030L,BigInteger.Parse("54376042036599780570"),BigInteger.Parse("2050556012681642525763"),BigInteger.Parse("81336729496634645414265"),BigInteger.Parse("3385729099078381669910310") };
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
public class A144659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144659Inst Instance=new A144659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144660
{
public static readonly BigInteger[] Value={ 1L,16L,271L,5248L,110251L,2435200L,55621567L,1301226496L,30992872483L,748574130016L,18283414868863L,450657134765056L,11192820128307871L,279787295456009728L,7032532242167190271L,BigInteger.Parse("177611430242835570688"),BigInteger.Parse("4504491083159761986451"),BigInteger.Parse("114662734697313744041248") };
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
public class A144660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144660Inst Instance=new A144660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144661
{
public static readonly BigInteger[] Value={ 1L,65L,7365L,1107697L,191448941L,35899051101L,7101534312685L,1458965717496881L,308290573348183629L,BigInteger.Parse("66577182435768923245"),BigInteger.Parse("14629025943480502591445"),BigInteger.Parse("3260160391173522631759533"),BigInteger.Parse("735119604833362632050789701"),BigInteger.Parse("167408468505328518543519208949"),BigInteger.Parse("38448088693846486556578015883325") };
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
public class A144661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144661Inst Instance=new A144661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144662
{
public static readonly BigInteger[] Value={ 0L,1L,266L,45296L,7958726L,1495388159L,295887993624L,60790021361170L,12845435390707724L,2774049143394729653L,BigInteger.Parse("609542744597785306189"),BigInteger.Parse("135840016223787254538508"),BigInteger.Parse("30629983532857972983331740"),BigInteger.Parse("6975352854342057056747327899"),BigInteger.Parse("1602003695575764851150428242804"),BigInteger.Parse("370631496919828403109950449644134") };
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
public class A144662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144662Inst Instance=new A144662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144663
{
public static readonly long[] Value={ 8L,4L,8L,0L,5L,4L,0L,4L,9L,3L,5L,2L,9L,0L,0L,3L,9L,2L,1L,2L,9L,6L,5L,0L,1L,8L,3L,4L,0L,5L,0L,0L,7L,7L,0L,5L,8L,4L,7L,9L,8L,7L,4L,8L,6L,8L,8L,4L,7L,1L,7L,6L,6L,6L,4L,3L,0L,6L,9L,6L,4L,5L,3L,8L,0L,6L,6L,1L,3L,5L,7L,2L,8L,5L,5L,5L,5L,4L,4L,1L,2L,7L,1L,3L,6L,7L,6L,6L,3L,7L,6L,7L,3L,6L,9L,0L,1L,2L,5L,2L,9L,5L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144663Inst : IEnumerable<long>
{
public static readonly long[] Value=A144663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144663.Bytes);
public long this[int i]=>Value[i];

public static A144663Inst Instance=new A144663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144744
{
public static readonly BigInteger[] Value={ 4L,11L,109L,11771L,138544669L,19194625169774891L,BigInteger.Parse("368433635408155743950638444286989"),BigInteger.Parse("135743343700069833946317076518699443524748244656296738254150399131") };
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
public class A144744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144744Inst Instance=new A144744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144745
{
public static readonly BigInteger[] Value={ 9L,71L,4969L,24685991L,609398126966089L,BigInteger.Parse("371366077149776919833628989831"),BigInteger.Parse("137912763257614063309949706968500684963726537144819872418729") };
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
public class A144745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144745Inst Instance=new A144745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144746
{
public static readonly BigInteger[] Value={ 6L,29L,811L,656909L,431528777371L,BigInteger.Parse("186217085698878552894269"),BigInteger.Parse("34676803006183479266409218250231853558140150091"),BigInteger.Parse("1202480666729655584789949373132702064208272454072740050128160074167965751208292536045867158189") };
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
public class A144746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144746Inst Instance=new A144746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144747
{
public static readonly BigInteger[] Value={ 7L,41L,1639L,2684681L,7207509387079L,BigInteger.Parse("51948191564824694742765161"),BigInteger.Parse("2698614606855723567054656642857156538246857652590759"),BigInteger.Parse("7282520796335071470236496456671241855257664867148949932302276253455702665493855273950765616767079605321") };
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
public class A144747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144747Inst Instance=new A144747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144748
{
public static readonly BigInteger[] Value={ 8L,55L,2969L,8811991L,77651176572089L,BigInteger.Parse("6029705223029665929437251831"),BigInteger.Parse("36357345076631233348346773693633697407708655232275600729"),BigInteger.Parse("1321856541021241383115043586121503961331042183698683965174269952435581223368633124721267107619465028785549730711") };
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
public class A144748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144748Inst Instance=new A144748Inst();

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