using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A069787
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,12L,11L,13L,17L,18L,16L,14L,15L,21L,20L,19L,22L,23L,24L,26L,25L,27L,31L,32L,30L,28L,29L,35L,34L,33L,36L,45L,46L,49L,48L,50L,44L,47L,42L,37L,38L,43L,40L,39L,41L,58L,59L,57L,54L,55L,56L,53L,51L,52L,63L,62L,61L,60L,64L,65L,66L,68L,67L,69L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069787Inst : IEnumerable<long>
{
public static readonly long[] Value=A069787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069787.Bytes);
public long this[int i]=>Value[i];

public static A069787Inst Instance=new A069787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069788
{
public static readonly BigInteger[] Value={ 2L,54L,4320L,2500000L,5252187500L,68336412238080L,3507134014317846528L,BigInteger.Parse("1039468958911770833166336"),BigInteger.Parse("1271288794044247678785011427072"),BigInteger.Parse("8629570422218326431392139107794299444"),BigInteger.Parse("248662702551142788293946930136251315440514048"),BigInteger.Parse("38763625610496798571986566181715696354290667009540096") };
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
public class A069788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A069788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A069788Inst Instance=new A069788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069789
{
public static readonly long[] Value={ 2L,5L,6L,12L,6L,11L,14L,24L,18L,17L,14L,28L,20L,15L,23L,25L,22L,45L,24L,26L,31L,30L,30L,38L,48L,41L,54L,39L,38L,46L,42L,68L,35L,53L,42L,117L,74L,54L,60L,58L,44L,62L,86L,60L,90L,51L,62L,75L,74L,80L,55L,97L,85L,56L,66L,87L,79L,88L,87L,78L,75L,69L,103L,192L,78L,70L,134L,82L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069789Inst : IEnumerable<long>
{
public static readonly long[] Value=A069789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069789.Bytes);
public long this[int i]=>Value[i];

public static A069789Inst Instance=new A069789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069790
{
public static readonly long[] Value={ 1L,120L,210L,300L,112101L,100600020L,101111310L,110120220L,200130021L,200310120L,1000051003L,1010004040L,1130002030L,1411000003L,2002021003L,3200200003L,5000050000L,100110002070L,111111101310L,111202101003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069790Inst : IEnumerable<long>
{
public static readonly long[] Value=A069790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069790.Bytes);
public long this[int i]=>Value[i];

public static A069790Inst Instance=new A069790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069791
{
public static readonly long[] Value={ 1021L,1031L,1033L,1039L,1051L,1117L,1171L,1193L,1231L,1237L,1291L,1297L,1319L,1373L,1433L,1439L,1471L,1531L,1597L,1613L,1619L,1733L,1831L,1973L,1979L,2027L,2029L,2039L,2053L,2111L,2113L,2131L,2137L,2179L,2237L,2239L,2293L,2297L,2311L,2371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069791Inst : IEnumerable<long>
{
public static readonly long[] Value=A069791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069791.Bytes);
public long this[int i]=>Value[i];

public static A069791Inst Instance=new A069791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069792
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,28L,36L,45L,78L,3741L,4005L,4278L,14028L,224115L,238395L,258121L,994755L,1104841L,2440945L,4601061L,19185915L,26451901L,27073761L,38250631L,611712753L,1787631321L,3620877351L,4427640253L,16786524835L,60302220121L,65003739895L,226236074130L,367188935361L,6710200324191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069792Inst : IEnumerable<long>
{
public static readonly long[] Value=A069792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069792.Bytes);
public long this[int i]=>Value[i];

public static A069792Inst Instance=new A069792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069793
{
public static readonly long[] Value={ 2L,1913L,113L,79L,179L,13L,337L,137L,1039L,37L,139L,619L,1031L,17L,1123L,349L,563L,3617L,1213L,1193L,839L,1129L,617L,1597L,2153L,1021L,173L,127L,571L,241L,3037L,3361L,131L,137L,113L,2141L,359L,1361L,1471L,1031L,1367L,587L,1013L,6337L,251L,2153L,149L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069793Inst : IEnumerable<long>
{
public static readonly long[] Value=A069793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069793.Bytes);
public long this[int i]=>Value[i];

public static A069793Inst Instance=new A069793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069794
{
public static readonly long[] Value={ 113L,313L,1579L,2113L,2879L,3779L,4813L,5179L,5237L,5279L,5879L,6113L,6379L,8713L,9091L,9479L,9679L,10313L,10513L,10613L,13313L,13913L,14779L,15013L,17579L,18713L,19213L,20879L,22013L,22091L,22679L,24179L,25037L,25913L,26479L,27179L,28579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069794Inst : IEnumerable<long>
{
public static readonly long[] Value=A069794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069794.Bytes);
public long this[int i]=>Value[i];

public static A069794Inst Instance=new A069794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069795
{
public static readonly long[] Value={ 79L,379L,613L,1013L,1979L,2713L,3613L,4817L,5413L,9413L,11113L,11579L,11813L,12437L,12479L,14713L,14813L,14879L,15313L,15937L,17239L,18617L,19037L,19979L,20071L,21379L,23279L,23813L,23917L,24337L,27091L,28279L,29437L,29537L,30091L,30781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069795Inst : IEnumerable<long>
{
public static readonly long[] Value=A069795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069795.Bytes);
public long this[int i]=>Value[i];

public static A069795Inst Instance=new A069795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069828
{
public static readonly long[] Value={ 1L,0L,1L,0L,6L,0L,15L,0L,12L,0L,45L,0L,66L,0L,21L,0L,120L,0L,153L,0L,50L,0L,231L,0L,180L,0L,117L,0L,378L,0L,435L,0L,144L,0L,255L,0L,630L,0L,209L,0L,780L,0L,861L,0L,198L,0L,1035L,0L,840L,0L,375L,0L,1326L,0L,729L,0L,476L,0L,1653L,0L,1770L,0L,465L,0L,1056L,0L,2145L,0L,714L,0L,2415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069828Inst : IEnumerable<long>
{
public static readonly long[] Value=A069828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069828.Bytes);
public long this[int i]=>Value[i];

public static A069828Inst Instance=new A069828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069829
{
public static readonly long[] Value={ 2L,5L,9L,11L,13L,19L,17L,23L,31L,26L,25L,40L,29L,47L,58L,51L,37L,69L,41L,56L,71L,67L,49L,82L,70L,73L,92L,95L,61L,123L,65L,105L,118L,94L,112L,148L,77L,107L,134L,116L,85L,143L,89L,122L,177L,127L,97L,166L,130L,133L,175L,162L,109L,211L,159L,188L,190L,154L,121L,248L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069829Inst : IEnumerable<long>
{
public static readonly long[] Value=A069829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069829.Bytes);
public long this[int i]=>Value[i];

public static A069829Inst Instance=new A069829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069830
{
public static readonly long[] Value={ 2L,2L,3L,8L,6L,4L,9L,17L,24L,15L,6L,10L,21L,35L,44L,49L,30L,11L,53L,36L,13L,62L,74L,12L,25L,51L,80L,54L,28L,9L,98L,114L,69L,134L,75L,26L,27L,125L,144L,149L,90L,19L,96L,49L,99L,123L,130L,170L,114L,58L,199L,120L,25L,214L,219L,224L,135L,46L,70L,141L,205L,285L,233L,156L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069830Inst : IEnumerable<long>
{
public static readonly long[] Value=A069830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069830.Bytes);
public long this[int i]=>Value[i];

public static A069830Inst Instance=new A069830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069831
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,2L,3L,3L,5L,8L,10L,13L,16L,22L,29L,36L,45L,61L,74L,95L,118L,152L,183L,232L,279L,354L,422L,524L,627L,780L,926L,1134L,1355L,1651L,1958L,2366L,2809L,3372L,3988L,4757L,5628L,6678L,7874L,9283L,10964L,12861L,15130L,17686L,20799L,24209L,28389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069831Inst : IEnumerable<long>
{
public static readonly long[] Value=A069831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069831.Bytes);
public long this[int i]=>Value[i];

public static A069831Inst Instance=new A069831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069832
{
public static readonly long[] Value={ 1L,3L,9L,19L,27L,33L,39L,57L,87L,97L,159L,177L,187L,433L,487L,541L,603L,691L,717L,753L,757L,853L,949L,1257L,1471L,1707L,2277L,2367L,2617L,2953L,4317L,4507L,4623L,4779L,4797L,5773L,6481L,6757L,6777L,7017L,7351L,7417L,7471L,7479L,7747L,7797L,7813L,7977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069832Inst : IEnumerable<long>
{
public static readonly long[] Value=A069832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069832.Bytes);
public long this[int i]=>Value[i];

public static A069832Inst Instance=new A069832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069833
{
public static readonly long[] Value={ 7L,19L,37L,41L,91L,199L,209L,239L,311L,539L,587L,661L,749L,923L,931L,941L,967L,1009L,1079L,1139L,1997L,2717L,2959L,3971L,3979L,4559L,4993L,4999L,5393L,5629L,5651L,6401L,6739L,6911L,8213L,8491L,8939L,9109L,9397L,9607L,9679L,9829L,11089L,11227L,13943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069833Inst : IEnumerable<long>
{
public static readonly long[] Value=A069833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069833.Bytes);
public long this[int i]=>Value[i];

public static A069833Inst Instance=new A069833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069834
{
public static readonly long[] Value={ 1L,3L,3L,5L,15L,21L,7L,9L,45L,55L,33L,39L,91L,105L,15L,17L,153L,171L,95L,105L,231L,253L,69L,75L,325L,351L,189L,203L,435L,465L,31L,33L,561L,595L,315L,333L,703L,741L,195L,205L,861L,903L,473L,495L,1035L,1081L,141L,147L,1225L,1275L,663L,689L,1431L,1485L,385L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069834Inst : IEnumerable<long>
{
public static readonly long[] Value=A069834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069834.Bytes);
public long this[int i]=>Value[i];

public static A069834Inst Instance=new A069834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069835
{
public static readonly long[] Value={ 1L,4L,22L,136L,886L,5944L,40636L,281488L,1968934L,13875544L,98365972L,700701808L,5011371964L,35961808432L,258805997752L,1867175631136L,13500088649734L,97794850668952L,709626281415076L,5157024231645616L,37528209137458516L,273431636191026064L,1994448720786816712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069835Inst : IEnumerable<long>
{
public static readonly long[] Value=A069835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069835.Bytes);
public long this[int i]=>Value[i];

public static A069835Inst Instance=new A069835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069836
{
public static readonly long[] Value={ 1L,4L,2L,13L,3L,7L,40L,22L,5L,10L,6L,12L,121L,31L,8L,67L,9L,16L,17L,364L,11L,19L,202L,37L,94L,49L,14L,24L,15L,25L,1093L,58L,112L,28L,18L,27L,52L,607L,20L,283L,21L,34L,32L,76L,23L,148L,62L,73L,157L,85L,26L,175L,38L,43L,3280L,337L,29L,46L,30L,42L,850L,103L,82L,45L,33L,1822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069836Inst : IEnumerable<long>
{
public static readonly long[] Value=A069836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069836.Bytes);
public long this[int i]=>Value[i];

public static A069836Inst Instance=new A069836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069837
{
public static readonly BigInteger[] Value={ 2L,23L,223L,2237L,22273L,222323L,2222273L,22222223L,222222227L,2222222377L,22222222223L,222222223273L,2222222222273L,22222222222327L,222222222222227L,2222222222222533L,22222222222223557L,222222222222222577L,2222222222222222327L,BigInteger.Parse("22222222222222222253"),BigInteger.Parse("222222222222222222277"),BigInteger.Parse("2222222222222222222273"),BigInteger.Parse("22222222222222222222327") };
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
public class A069837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A069837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A069837Inst Instance=new A069837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069838
{
public static readonly long[] Value={ 6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,20L,23L,27L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,46L,47L,48L,49L,50L,57L,58L,59L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069838Inst : IEnumerable<long>
{
public static readonly long[] Value=A069838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069838.Bytes);
public long this[int i]=>Value[i];

public static A069838Inst Instance=new A069838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069839
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,78L,265764L,71095150000L,1791180894322714050L,BigInteger.Parse("5782448787773327324756945480"),BigInteger.Parse("3129263982719398327413605440811466528960"),BigInteger.Parse("359946241929477448403523246795300556527932947115524992") };
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
public class A069839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A069839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A069839Inst Instance=new A069839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069840
{
public static readonly BigInteger[] Value={ 16L,80L,666L,6588L,80886L,1146916L,18583160L,337808300L,6812539360L,150922350288L,3643698427650L,95221941543232L,2678117152113428L,80658585770586368L,2590036811212597862L,BigInteger.Parse("88333886984966359596") };
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
public class A069840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A069840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A069840Inst Instance=new A069840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069841
{
public static readonly long[] Value={ 0L,1L,1L,7L,15L,5L,7L,1L,47L,21L,1L,61L,5L,13L,51L,41L,29L,29L,31L,19L,33L,7L,13L,31L,19L,67L,27L,93L,25L,43L,9L,49L,5L,81L,67L,1L,91L,21L,121L,81L,15L,149L,19L,161L,23L,119L,25L,107L,117L,43L,9L,117L,13L,85L,55L,131L,9L,7L,57L,17L,145L,73L,17L,301L,305L,157L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069841Inst : IEnumerable<long>
{
public static readonly long[] Value=A069841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069841.Bytes);
public long this[int i]=>Value[i];

public static A069841Inst Instance=new A069841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069842
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,1L,2L,0L,1L,1L,0L,0L,2L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,2L,1L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,3L,0L,1L,1L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,3L,1L,0L,1L,2L,0L,2L,1L,0L,0L,1L,0L,1L,1L,0L,0L,2L,0L,2L,1L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,1L,1L,0L,0L,2L,0L,3L,0L,0L,1L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069842Inst : IEnumerable<long>
{
public static readonly long[] Value=A069842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069842.Bytes);
public long this[int i]=>Value[i];

public static A069842Inst Instance=new A069842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069843
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069843Inst : IEnumerable<long>
{
public static readonly long[] Value=A069843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069843.Bytes);
public long this[int i]=>Value[i];

public static A069843Inst Instance=new A069843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069908
{
public static readonly long[] Value={ 2L,3L,4L,5L,11L,12L,13L,14L,18L,19L,20L,21L,27L,28L,29L,30L,34L,35L,36L,37L,43L,44L,45L,46L,50L,51L,52L,53L,59L,60L,61L,62L,66L,67L,68L,69L,75L,76L,77L,78L,82L,83L,84L,85L,91L,92L,93L,94L,98L,99L,100L,101L,107L,108L,109L,110L,114L,115L,116L,117L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069908Inst : IEnumerable<long>
{
public static readonly long[] Value=A069908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069908.Bytes);
public long this[int i]=>Value[i];

public static A069908Inst Instance=new A069908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069909
{
public static readonly long[] Value={ 1L,4L,6L,7L,9L,10L,12L,15L,17L,20L,22L,23L,25L,26L,28L,31L,33L,36L,38L,39L,41L,42L,44L,47L,49L,52L,54L,55L,57L,58L,60L,63L,65L,68L,70L,71L,73L,74L,76L,79L,81L,84L,86L,87L,89L,90L,92L,95L,97L,100L,102L,103L,105L,106L,108L,111L,113L,116L,118L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069909Inst : IEnumerable<long>
{
public static readonly long[] Value=A069909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069909.Bytes);
public long this[int i]=>Value[i];

public static A069909Inst Instance=new A069909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069910
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,3L,3L,5L,5L,7L,8L,11L,12L,16L,18L,23L,26L,33L,37L,46L,52L,63L,72L,87L,98L,117L,133L,157L,178L,209L,236L,276L,312L,361L,408L,471L,530L,609L,686L,784L,881L,1004L,1126L,1279L,1433L,1621L,1814L,2048L,2286L,2574L,2871L,3223L,3590L,4022L,4472L,5000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069910Inst : IEnumerable<long>
{
public static readonly long[] Value=A069910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069910.Bytes);
public long this[int i]=>Value[i];

public static A069910Inst Instance=new A069910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069911
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,12L,14L,17L,20L,25L,29L,35L,41L,49L,57L,68L,78L,93L,107L,125L,144L,168L,192L,223L,255L,294L,335L,385L,437L,501L,568L,647L,732L,833L,939L,1065L,1199L,1355L,1523L,1717L,1925L,2166L,2425L,2720L,3040L,3405L,3797L,4244L,4727L,5272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069911Inst : IEnumerable<long>
{
public static readonly long[] Value=A069911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069911.Bytes);
public long this[int i]=>Value[i];

public static A069911Inst Instance=new A069911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069912
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,4L,6L,8L,0L,0L,0L,0L,1L,3L,4L,5L,8L,10L,0L,0L,0L,1L,2L,4L,5L,7L,9L,12L,0L,0L,2L,2L,4L,6L,7L,9L,12L,15L,1L,1L,2L,3L,5L,8L,10L,12L,15L,18L,2L,3L,4L,5L,7L,10L,12L,14L,17L,20L,3L,4L,5L,6L,9L,12L,14L,16L,20L,23L,4L,6L,7L,9L,11L,14L,16L,19L,23L,27L,6L,7L,9L,10L,14L,17L,19L,22L,26L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069912Inst : IEnumerable<long>
{
public static readonly long[] Value=A069912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069912.Bytes);
public long this[int i]=>Value[i];

public static A069912Inst Instance=new A069912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069913
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,11L,6L,16L,12L,19L,10L,37L,12L,27L,26L,42L,16L,54L,18L,59L,36L,43L,22L,100L,32L,51L,48L,81L,28L,113L,30L,99L,56L,67L,54L,162L,36L,75L,66L,152L,40L,153L,42L,125L,108L,91L,46L,240L,60L,134L,86L,147L,52L,202L,82L,204L,96L,115L,58L,331L,60L,123L,144L,219L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069913Inst : IEnumerable<long>
{
public static readonly long[] Value=A069913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069913.Bytes);
public long this[int i]=>Value[i];

public static A069913Inst Instance=new A069913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069914
{
public static readonly long[] Value={ 0L,1L,2L,6L,4L,15L,6L,23L,16L,27L,10L,64L,12L,39L,42L,72L,16L,98L,18L,110L,60L,63L,22L,213L,48L,75L,84L,156L,28L,245L,30L,201L,96L,99L,102L,380L,36L,111L,114L,357L,40L,345L,42L,248L,248L,135L,46L,618L,96L,278L,150L,294L,52L,478L,162L,501L,168L,171L,58L,924L,60L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069914Inst : IEnumerable<long>
{
public static readonly long[] Value=A069914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069914.Bytes);
public long this[int i]=>Value[i];

public static A069914Inst Instance=new A069914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069915
{
public static readonly long[] Value={ 1L,3L,4L,3L,6L,12L,8L,7L,4L,18L,12L,12L,14L,24L,24L,11L,18L,12L,20L,18L,32L,36L,24L,28L,6L,42L,13L,24L,30L,72L,32L,31L,48L,54L,48L,12L,38L,60L,56L,42L,42L,96L,44L,36L,24L,72L,48L,44L,8L,18L,72L,42L,54L,39L,72L,56L,80L,90L,60L,72L,62L,96L,32L,35L,84L,144L,68L,54L,96L,144L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069915Inst : IEnumerable<long>
{
public static readonly long[] Value=A069915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069915.Bytes);
public long this[int i]=>Value[i];

public static A069915Inst Instance=new A069915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069916
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,9L,14L,20L,26L,36L,47L,60L,80L,102L,127L,159L,194L,236L,291L,355L,425L,514L,611L,718L,856L,1009L,1182L,1381L,1605L,1861L,2156L,2496L,2873L,3299L,3778L,4301L,4902L,5574L,6325L,7176L,8116L,9152L,10317L,11610L,13028L,14611L,16354L,18259L,20365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069916Inst : IEnumerable<long>
{
public static readonly long[] Value=A069916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069916.Bytes);
public long this[int i]=>Value[i];

public static A069916Inst Instance=new A069916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069917
{
public static readonly long[] Value={ 28L,145L,901L,1081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069917Inst : IEnumerable<long>
{
public static readonly long[] Value=A069917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069917.Bytes);
public long this[int i]=>Value[i];

public static A069917Inst Instance=new A069917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069918
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,5L,4L,7L,23L,40L,35L,62L,221L,397L,361L,657L,2410L,4441L,4110L,7636L,28460L,53222L,49910L,93846L,353743L,668273L,632602L,1199892L,4559828L,8679280L,8273610L,15796439L,60400688L,115633260L,110826888L,212681976L,817175698L,1571588177L,1512776590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069918Inst : IEnumerable<long>
{
public static readonly long[] Value=A069918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069918.Bytes);
public long this[int i]=>Value[i];

public static A069918Inst Instance=new A069918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069919
{
public static readonly long[] Value={ 225L,441L,40401L,69696L,2042041L,2362369L,2862864L,3323329L,4004001L,5345344L,6086089L,7447441L,8168164L,9909904L,317231721L,400040001L,16198161984L,40000400001L,46822468225L,56722567225L,74382743824L,95540955409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069919Inst : IEnumerable<long>
{
public static readonly long[] Value=A069919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069919.Bytes);
public long this[int i]=>Value[i];

public static A069919Inst Instance=new A069919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069920
{
public static readonly BigInteger[] Value={ 4L,1008L,8190720L,2332005728256L,BigInteger.Parse("23674927650073214976"),BigInteger.Parse("8618480376852061696039059456"),BigInteger.Parse("112746432609478969278312620164116381696"),BigInteger.Parse("53053593891934168169788522401776516627950360068096") };
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
public class A069920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A069920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A069920Inst Instance=new A069920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069921
{
public static readonly long[] Value={ 1L,5L,10L,29L,73L,194L,505L,1325L,3466L,9077L,23761L,62210L,162865L,426389L,1116298L,2922509L,7651225L,20031170L,52442281L,137295677L,359444746L,941038565L,2463670945L,6449974274L,16886251873L,44208781349L,115740092170L,303011495165L,793294393321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069921Inst : IEnumerable<long>
{
public static readonly long[] Value=A069921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069921.Bytes);
public long this[int i]=>Value[i];

public static A069921Inst Instance=new A069921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069922
{
public static readonly long[] Value={ 1L,2L,2L,4L,1L,5L,4L,1L,2L,5L,1L,4L,4L,9L,7L,6L,2L,4L,7L,9L,7L,3L,7L,10L,10L,6L,12L,6L,10L,7L,8L,10L,7L,9L,13L,13L,7L,10L,11L,11L,9L,13L,11L,10L,15L,10L,11L,10L,19L,14L,16L,11L,16L,21L,20L,12L,9L,15L,21L,12L,10L,16L,15L,22L,19L,17L,18L,12L,19L,20L,13L,17L,13L,13L,17L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069922Inst : IEnumerable<long>
{
public static readonly long[] Value=A069922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069922.Bytes);
public long this[int i]=>Value[i];

public static A069922Inst Instance=new A069922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A069923
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,3L,4L,2L,5L,3L,5L,5L,4L,7L,9L,4L,5L,5L,7L,3L,4L,7L,3L,7L,6L,8L,6L,5L,8L,4L,6L,10L,3L,5L,3L,7L,6L,7L,7L,8L,6L,7L,5L,7L,5L,8L,4L,2L,7L,6L,6L,7L,3L,6L,6L,11L,6L,6L,9L,8L,8L,7L,7L,6L,6L,10L,8L,7L,10L,9L,7L,5L,5L,9L,6L,8L,11L,9L,5L,8L,6L,10L,9L,5L,9L,12L,6L,7L,4L,7L,6L,9L,8L,5L,7L,6L,7L,3L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A069923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A069923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A069923Inst : IEnumerable<long>
{
public static readonly long[] Value=A069923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A069923.Bytes);
public long this[int i]=>Value[i];

public static A069923Inst Instance=new A069923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070068
{
public static readonly long[] Value={ 9L,99L,1881L,171171L,1882881L,306909603L,11355655311L,1033364633301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070068Inst : IEnumerable<long>
{
public static readonly long[] Value=A070068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070068.Bytes);
public long this[int i]=>Value[i];

public static A070068Inst Instance=new A070068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070069
{
public static readonly BigInteger[] Value={ 11L,22L,44L,88L,616L,6776L,88088L,616616L,232464232L,21154245112L,232696696232L,21175399357112L,BigInteger.Parse("21154245133154245112"),BigInteger.Parse("232696696464696696232"),BigInteger.Parse("21175399378287399357112"),BigInteger.Parse("63386501441764911946714410568336") };
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
public class A070069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070069Inst Instance=new A070069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070070
{
public static readonly long[] Value={ 0L,2L,7L,17L,35L,64L,111L,182L,286L,436L,647L,938L,1336L,1871L,2583L,3520L,4741L,6320L,8347L,10930L,14199L,18312L,23460L,29869L,37808L,47600L,59624L,74331L,92250L,114006L,140329L,172077L,210249L,256010L,310717L,375943L,453513L,545538L,654453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070070Inst : IEnumerable<long>
{
public static readonly long[] Value=A070070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070070.Bytes);
public long this[int i]=>Value[i];

public static A070070Inst Instance=new A070070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070071
{
public static readonly long[] Value={ 0L,1L,4L,15L,60L,260L,1218L,6139L,33120L,190323L,1159750L,7464270L,50563164L,359377681L,2672590508L,20744378175L,167682274352L,1408702786668L,12277382510862L,110822101896083L,1034483164707440L,9972266139291771L,99147746245841106L,1015496134666939958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070071Inst : IEnumerable<long>
{
public static readonly long[] Value=A070071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070071.Bytes);
public long this[int i]=>Value[i];

public static A070071Inst Instance=new A070071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070072
{
public static readonly long[] Value={ 1L,2L,4L,4L,7L,9L,14L,14L,14L,17L,24L,24L,32L,37L,43L,43L,54L,54L,66L,66L,74L,83L,98L,98L,98L,108L,108L,108L,125L,133L,152L,152L,165L,178L,193L,193L,216L,231L,248L,248L,274L,285L,313L,313L,313L,331L,361L,361L,361L,361L,382L,382L,414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070072Inst : IEnumerable<long>
{
public static readonly long[] Value=A070072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070072.Bytes);
public long this[int i]=>Value[i];

public static A070072Inst Instance=new A070072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070073
{
public static readonly long[] Value={ 1L,3L,8L,11L,23L,33L,57L,57L,70L,95L,142L,156L,220L,271L,338L,338L,441L,480L,609L,658L,775L,896L,1090L,1090L,1220L,1387L,1387L,1468L,1737L,1882L,2197L,2197L,2474L,2735L,3078L,3153L,3592L,3923L,4328L,4328L,4861L,5195L,5794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070073Inst : IEnumerable<long>
{
public static readonly long[] Value=A070073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070073.Bytes);
public long this[int i]=>Value[i];

public static A070073Inst Instance=new A070073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070074
{
public static readonly BigInteger[] Value={ 1L,7L,141L,5305L,313333L,26405391L,2986704817L,434460962041L,78746410575945L,17355333316259863L,4561636814725190101L,BigInteger.Parse("1407386778722787214617"),BigInteger.Parse("503024214435970044854461") };
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
public class A070074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070074Inst Instance=new A070074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070075
{
public static readonly long[] Value={ 1L,2L,9L,57L,464L,4593L,53381L,711056L,10665071L,177698377L,3253933294L,64917524367L,1400923403957L,32503510579738L,806599849548101L,21313355891736741L,597326671763101944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070075Inst : IEnumerable<long>
{
public static readonly long[] Value=A070075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070075.Bytes);
public long this[int i]=>Value[i];

public static A070075Inst Instance=new A070075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070076
{
public static readonly long[] Value={ 2L,6L,27L,170L,1019L,6945L,50811L,381332L,2984194L,23988173L,196963369L,1646209172L,13964079652L,119945656793L,1041428920639L,9126986454994L,80644643655861L,717727049224277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070076Inst : IEnumerable<long>
{
public static readonly long[] Value=A070076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070076.Bytes);
public long this[int i]=>Value[i];

public static A070076Inst Instance=new A070076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070077
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,2L,1L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070077Inst : IEnumerable<long>
{
public static readonly long[] Value=A070077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070077.Bytes);
public long this[int i]=>Value[i];

public static A070077Inst Instance=new A070077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070078
{
public static readonly long[] Value={ 1L,2L,3L,0L,60L,106L,217L,0L,0L,409L,276L,0L,120L,129L,376L,0L,157L,0L,175L,0L,1086L,899L,365L,0L,0L,1343L,0L,0L,2630L,4068L,775L,0L,1785L,313L,1981L,0L,339L,348L,2727L,0L,6311L,11216L,680L,0L,0L,422L,431L,0L,0L,0L,808L,0L,840L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070078Inst : IEnumerable<long>
{
public static readonly long[] Value=A070078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070078.Bytes);
public long this[int i]=>Value[i];

public static A070078Inst Instance=new A070078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070079
{
public static readonly long[] Value={ 3L,5L,15L,21L,35L,9L,45L,11L,55L,39L,65L,99L,91L,15L,105L,51L,85L,165L,19L,95L,195L,221L,105L,209L,255L,69L,115L,231L,285L,25L,75L,175L,299L,225L,275L,189L,325L,399L,391L,29L,145L,351L,425L,261L,459L,279L,341L,165L,231L,575L,465L,551L,35L,105L,609L,315L,589L,385L,675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070079Inst : IEnumerable<long>
{
public static readonly long[] Value=A070079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070079.Bytes);
public long this[int i]=>Value[i];

public static A070079Inst Instance=new A070079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070080
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,2L,3L,2L,3L,1L,2L,3L,3L,2L,3L,4L,1L,2L,3L,3L,4L,2L,3L,4L,4L,1L,2L,3L,3L,4L,4L,5L,2L,3L,4L,4L,5L,1L,2L,3L,3L,4L,4L,5L,5L,2L,3L,4L,4L,5L,5L,6L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,2L,3L,4L,4L,5L,5L,6L,6L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,2L,3L,4L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070080Inst : IEnumerable<long>
{
public static readonly long[] Value=A070080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070080.Bytes);
public long this[int i]=>Value[i];

public static A070080Inst Instance=new A070080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070081
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,4L,3L,3L,4L,3L,5L,4L,3L,4L,5L,4L,4L,6L,5L,4L,5L,4L,6L,5L,4L,5L,7L,6L,5L,6L,4L,5L,5L,7L,6L,5L,6L,5L,8L,7L,6L,7L,5L,6L,5L,6L,8L,7L,6L,7L,5L,6L,6L,9L,8L,7L,8L,6L,7L,5L,6L,7L,6L,9L,8L,7L,8L,6L,7L,6L,7L,10L,9L,8L,9L,7L,8L,6L,7L,8L,6L,7L,7L,10L,9L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070081Inst : IEnumerable<long>
{
public static readonly long[] Value=A070081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070081.Bytes);
public long this[int i]=>Value[i];

public static A070081Inst Instance=new A070081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070082
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,4L,3L,4L,4L,5L,5L,5L,4L,5L,5L,4L,6L,6L,6L,5L,5L,6L,6L,6L,5L,7L,7L,7L,6L,7L,6L,5L,7L,7L,7L,6L,6L,8L,8L,8L,7L,8L,7L,7L,6L,8L,8L,8L,7L,8L,7L,6L,9L,9L,9L,8L,9L,8L,9L,8L,7L,7L,9L,9L,9L,8L,9L,8L,8L,7L,10L,10L,10L,9L,10L,9L,10L,9L,8L,9L,8L,7L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070082Inst : IEnumerable<long>
{
public static readonly long[] Value=A070082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070082.Bytes);
public long this[int i]=>Value[i];

public static A070082Inst Instance=new A070082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070083
{
public static readonly long[] Value={ 3L,5L,6L,7L,7L,8L,9L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070083Inst : IEnumerable<long>
{
public static readonly long[] Value=A070083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070083.Bytes);
public long this[int i]=>Value[i];

public static A070083Inst Instance=new A070083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070132
{
public static readonly long[] Value={ 30L,101L,153L,193L,328L,334L,392L,444L,454L,519L,603L,621L,771L,777L,795L,878L,1005L,1123L,1135L,1508L,1526L,1538L,1694L,1818L,1848L,1858L,1999L,2023L,2037L,2066L,2193L,2223L,2253L,2454L,2663L,2903L,3055L,3321L,3363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070132Inst : IEnumerable<long>
{
public static readonly long[] Value=A070132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070132.Bytes);
public long this[int i]=>Value[i];

public static A070132Inst Instance=new A070132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070133
{
public static readonly long[] Value={ 5L,14L,26L,32L,52L,61L,82L,91L,104L,118L,133L,146L,163L,182L,202L,219L,242L,246L,266L,291L,314L,342L,347L,372L,404L,432L,437L,467L,472L,504L,542L,547L,577L,582L,619L,625L,663L,709L,714L,751L,757L,801L,807L,853L,858L,907L,913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070133Inst : IEnumerable<long>
{
public static readonly long[] Value=A070133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070133.Bytes);
public long this[int i]=>Value[i];

public static A070133Inst Instance=new A070133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070134
{
public static readonly long[] Value={ 5L,14L,32L,52L,61L,104L,118L,133L,146L,163L,202L,242L,246L,266L,314L,342L,404L,437L,467L,472L,504L,542L,547L,577L,619L,625L,714L,757L,801L,807L,853L,907L,957L,1015L,1022L,1082L,1139L,1145L,1265L,1278L,1335L,1414L,1475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070134Inst : IEnumerable<long>
{
public static readonly long[] Value=A070134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070134.Bytes);
public long this[int i]=>Value[i];

public static A070134Inst Instance=new A070134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070135
{
public static readonly long[] Value={ 5L,14L,133L,163L,472L,542L,714L,907L,1888L,2064L,2267L,2466L,3133L,4240L,4858L,5188L,7563L,8469L,9466L,9958L,11069L,12841L,13471L,14876L,17032L,17794L,20214L,20268L,21125L,21943L,22843L,22933L,23837L,25767L,25797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070135Inst : IEnumerable<long>
{
public static readonly long[] Value=A070135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070135.Bytes);
public long this[int i]=>Value[i];

public static A070135Inst Instance=new A070135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070136
{
public static readonly long[] Value={ 17L,116L,212L,370L,493L,850L,1297L,1599L,1629L,2574L,2778L,3751L,4298L,4370L,5251L,5286L,6476L,9169L,10066L,12398L,12441L,12520L,14414L,16365L,16602L,19831L,21231L,21486L,24060L,26125L,27245L,29230L,33625L,33658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070136Inst : IEnumerable<long>
{
public static readonly long[] Value=A070136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070136.Bytes);
public long this[int i]=>Value[i];

public static A070136Inst Instance=new A070136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070137
{
public static readonly long[] Value={ 17L,212L,493L,1297L,2574L,4298L,5251L,14414L,16365L,21231L,26125L,39056L,42597L,55042L,63770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070137Inst : IEnumerable<long>
{
public static readonly long[] Value=A070137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070137.Bytes);
public long this[int i]=>Value[i];

public static A070137Inst Instance=new A070137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070138
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,3L,0L,1L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,5L,0L,0L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070138Inst : IEnumerable<long>
{
public static readonly long[] Value=A070138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070138.Bytes);
public long this[int i]=>Value[i];

public static A070138Inst Instance=new A070138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070139
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070139Inst : IEnumerable<long>
{
public static readonly long[] Value=A070139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070139.Bytes);
public long this[int i]=>Value[i];

public static A070139Inst Instance=new A070139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070140
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070140Inst : IEnumerable<long>
{
public static readonly long[] Value=A070140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070140.Bytes);
public long this[int i]=>Value[i];

public static A070140Inst Instance=new A070140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070141
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,3L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,0L,0L,0L,0L,3L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,4L,0L,0L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070141Inst : IEnumerable<long>
{
public static readonly long[] Value=A070141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070141.Bytes);
public long this[int i]=>Value[i];

public static A070141Inst Instance=new A070141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070142
{
public static readonly long[] Value={ 17L,39L,52L,116L,212L,252L,269L,368L,370L,372L,375L,493L,561L,587L,659L,839L,850L,862L,957L,972L,1156L,1186L,1196L,1204L,1297L,1582L,1599L,1629L,1912L,1920L,1955L,1971L,1988L,2115L,2352L,2555L,2574L,2713L,2774L,2778L,2790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070142Inst : IEnumerable<long>
{
public static readonly long[] Value=A070142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070142.Bytes);
public long this[int i]=>Value[i];

public static A070142Inst Instance=new A070142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070143
{
public static readonly long[] Value={ 17L,39L,52L,212L,252L,368L,375L,493L,561L,587L,659L,839L,957L,972L,1156L,1186L,1196L,1297L,1582L,1912L,1955L,1971L,2115L,2352L,2555L,2574L,2713L,3251L,3473L,3728L,3746L,4286L,4298L,4313L,4319L,4330L,5251L,5272L,5378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070143Inst : IEnumerable<long>
{
public static readonly long[] Value=A070143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070143.Bytes);
public long this[int i]=>Value[i];

public static A070143Inst Instance=new A070143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070144
{
public static readonly long[] Value={ 17L,116L,212L,252L,368L,370L,493L,561L,587L,659L,839L,850L,1156L,1186L,1196L,1297L,1582L,1599L,1629L,1912L,1920L,2115L,2352L,2555L,2574L,2713L,2774L,2778L,3251L,3473L,3728L,3746L,3751L,4286L,4298L,4307L,4313L,4319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070144Inst : IEnumerable<long>
{
public static readonly long[] Value=A070144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070144.Bytes);
public long this[int i]=>Value[i];

public static A070144Inst Instance=new A070144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070145
{
public static readonly long[] Value={ 39L,52L,269L,372L,375L,862L,957L,972L,1204L,1955L,1971L,1988L,2790L,2796L,3818L,5374L,6522L,6880L,6881L,6921L,7234L,7310L,7341L,7360L,9198L,9207L,10272L,14506L,15101L,15177L,15237L,21289L,21493L,21540L,21552L,21589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070145Inst : IEnumerable<long>
{
public static readonly long[] Value=A070145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070145.Bytes);
public long this[int i]=>Value[i];

public static A070145Inst Instance=new A070145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070146
{
public static readonly long[] Value={ 39L,269L,375L,587L,862L,972L,1196L,1955L,1988L,2352L,2555L,2796L,3818L,4319L,4406L,5378L,6522L,6808L,6880L,6890L,6921L,7234L,7360L,8193L,9159L,9207L,10272L,14545L,15004L,15061L,15101L,15216L,15237L,15943L,16502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070146Inst : IEnumerable<long>
{
public static readonly long[] Value=A070146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070146.Bytes);
public long this[int i]=>Value[i];

public static A070146Inst Instance=new A070146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070147
{
public static readonly long[] Value={ 52L,252L,368L,372L,561L,659L,839L,957L,1156L,1186L,1204L,1582L,1912L,1920L,1971L,2115L,2713L,2774L,2790L,3251L,3473L,3728L,3746L,4286L,4307L,4313L,4330L,5008L,5272L,5374L,6369L,6389L,6432L,6776L,6881L,7223L,7310L,7341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070147Inst : IEnumerable<long>
{
public static readonly long[] Value=A070147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070147.Bytes);
public long this[int i]=>Value[i];

public static A070147Inst Instance=new A070147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070340
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,25L,11L,22L,5L,10L,20L,1L,2L,4L,8L,16L,32L,25L,11L,22L,5L,10L,20L,1L,2L,4L,8L,16L,32L,25L,11L,22L,5L,10L,20L,1L,2L,4L,8L,16L,32L,25L,11L,22L,5L,10L,20L,1L,2L,4L,8L,16L,32L,25L,11L,22L,5L,10L,20L,1L,2L,4L,8L,16L,32L,25L,11L,22L,5L,10L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070340Inst : IEnumerable<long>
{
public static readonly long[] Value=A070340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070340.Bytes);
public long this[int i]=>Value[i];

public static A070340Inst Instance=new A070340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070341
{
public static readonly long[] Value={ 1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L,5L,4L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070341Inst : IEnumerable<long>
{
public static readonly long[] Value=A070341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070341.Bytes);
public long this[int i]=>Value[i];

public static A070341Inst Instance=new A070341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070342
{
public static readonly long[] Value={ 1L,3L,9L,8L,5L,15L,7L,2L,6L,18L,16L,10L,11L,14L,4L,12L,17L,13L,1L,3L,9L,8L,5L,15L,7L,2L,6L,18L,16L,10L,11L,14L,4L,12L,17L,13L,1L,3L,9L,8L,5L,15L,7L,2L,6L,18L,16L,10L,11L,14L,4L,12L,17L,13L,1L,3L,9L,8L,5L,15L,7L,2L,6L,18L,16L,10L,11L,14L,4L,12L,17L,13L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070342Inst : IEnumerable<long>
{
public static readonly long[] Value=A070342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070342.Bytes);
public long this[int i]=>Value[i];

public static A070342Inst Instance=new A070342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070343
{
public static readonly long[] Value={ 1L,3L,9L,2L,6L,18L,4L,12L,11L,8L,24L,22L,16L,23L,19L,7L,21L,13L,14L,17L,1L,3L,9L,2L,6L,18L,4L,12L,11L,8L,24L,22L,16L,23L,19L,7L,21L,13L,14L,17L,1L,3L,9L,2L,6L,18L,4L,12L,11L,8L,24L,22L,16L,23L,19L,7L,21L,13L,14L,17L,1L,3L,9L,2L,6L,18L,4L,12L,11L,8L,24L,22L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070343Inst : IEnumerable<long>
{
public static readonly long[] Value=A070343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070343.Bytes);
public long this[int i]=>Value[i];

public static A070343Inst Instance=new A070343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070344
{
public static readonly long[] Value={ 1L,3L,9L,27L,23L,11L,4L,12L,7L,21L,5L,15L,16L,19L,28L,26L,20L,2L,6L,18L,25L,17L,22L,8L,24L,14L,13L,10L,1L,3L,9L,27L,23L,11L,4L,12L,7L,21L,5L,15L,16L,19L,28L,26L,20L,2L,6L,18L,25L,17L,22L,8L,24L,14L,13L,10L,1L,3L,9L,27L,23L,11L,4L,12L,7L,21L,5L,15L,16L,19L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070344Inst : IEnumerable<long>
{
public static readonly long[] Value=A070344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070344.Bytes);
public long this[int i]=>Value[i];

public static A070344Inst Instance=new A070344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070345
{
public static readonly long[] Value={ 1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L,1L,3L,9L,27L,11L,33L,29L,17L,16L,13L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070345Inst : IEnumerable<long>
{
public static readonly long[] Value=A070345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070345.Bytes);
public long this[int i]=>Value[i];

public static A070345Inst Instance=new A070345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070346
{
public static readonly long[] Value={ 1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L,33L,25L,1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L,33L,25L,1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L,33L,25L,1L,3L,9L,27L,7L,21L,26L,4L,12L,36L,34L,28L,10L,30L,16L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070346Inst : IEnumerable<long>
{
public static readonly long[] Value=A070346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070346.Bytes);
public long this[int i]=>Value[i];

public static A070346Inst Instance=new A070346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070347
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070347Inst : IEnumerable<long>
{
public static readonly long[] Value=A070347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070347.Bytes);
public long this[int i]=>Value[i];

public static A070347Inst Instance=new A070347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070348
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L,36L,31L,21L,1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L,36L,31L,21L,1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L,36L,31L,21L,1L,2L,4L,8L,16L,32L,23L,5L,10L,20L,40L,39L,37L,33L,25L,9L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070348Inst : IEnumerable<long>
{
public static readonly long[] Value=A070348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070348.Bytes);
public long this[int i]=>Value[i];

public static A070348Inst Instance=new A070348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070349
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L,42L,41L,39L,35L,27L,11L,22L,1L,2L,4L,8L,16L,32L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070349Inst : IEnumerable<long>
{
public static readonly long[] Value=A070349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070349.Bytes);
public long this[int i]=>Value[i];

public static A070349Inst Instance=new A070349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070350
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L,31L,17L,34L,23L,1L,2L,4L,8L,16L,32L,19L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070350Inst : IEnumerable<long>
{
public static readonly long[] Value=A070350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070350.Bytes);
public long this[int i]=>Value[i];

public static A070350Inst Instance=new A070350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070351
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L,7L,14L,28L,9L,18L,36L,25L,3L,6L,12L,24L,1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L,7L,14L,28L,9L,18L,36L,25L,3L,6L,12L,24L,1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L,7L,14L,28L,9L,18L,36L,25L,3L,6L,12L,24L,1L,2L,4L,8L,16L,32L,17L,34L,21L,42L,37L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070351Inst : IEnumerable<long>
{
public static readonly long[] Value=A070351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070351.Bytes);
public long this[int i]=>Value[i];

public static A070351Inst Instance=new A070351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070352
{
public static readonly long[] Value={ 1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070352Inst : IEnumerable<long>
{
public static readonly long[] Value=A070352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070352.Bytes);
public long this[int i]=>Value[i];

public static A070352Inst Instance=new A070352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070353
{
public static readonly long[] Value={ 1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L,1L,3L,9L,13L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070353Inst : IEnumerable<long>
{
public static readonly long[] Value=A070353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070353.Bytes);
public long this[int i]=>Value[i];

public static A070353Inst Instance=new A070353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070354
{
public static readonly long[] Value={ 1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L,3L,9L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070354Inst : IEnumerable<long>
{
public static readonly long[] Value=A070354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070354.Bytes);
public long this[int i]=>Value[i];

public static A070354Inst Instance=new A070354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070355
{
public static readonly long[] Value={ 1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L,1L,3L,9L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070355Inst : IEnumerable<long>
{
public static readonly long[] Value=A070355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070355.Bytes);
public long this[int i]=>Value[i];

public static A070355Inst Instance=new A070355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070404
{
public static readonly long[] Value={ 1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,5L,2L,3L,10L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070404Inst : IEnumerable<long>
{
public static readonly long[] Value=A070404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070404.Bytes);
public long this[int i]=>Value[i];

public static A070404Inst Instance=new A070404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070405
{
public static readonly long[] Value={ 1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070405Inst : IEnumerable<long>
{
public static readonly long[] Value=A070405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070405.Bytes);
public long this[int i]=>Value[i];

public static A070405Inst Instance=new A070405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070406
{
public static readonly long[] Value={ 1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L,7L,4L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070406Inst : IEnumerable<long>
{
public static readonly long[] Value=A070406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070406.Bytes);
public long this[int i]=>Value[i];

public static A070406Inst Instance=new A070406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070407
{
public static readonly long[] Value={ 1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,15L,3L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070407Inst : IEnumerable<long>
{
public static readonly long[] Value=A070407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070407.Bytes);
public long this[int i]=>Value[i];

public static A070407Inst Instance=new A070407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070408
{
public static readonly long[] Value={ 1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L,3L,21L,15L,17L,9L,19L,1L,7L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070408Inst : IEnumerable<long>
{
public static readonly long[] Value=A070408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070408.Bytes);
public long this[int i]=>Value[i];

public static A070408Inst Instance=new A070408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070409
{
public static readonly long[] Value={ 1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070409Inst : IEnumerable<long>
{
public static readonly long[] Value=A070409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070409.Bytes);
public long this[int i]=>Value[i];

public static A070409Inst Instance=new A070409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070410
{
public static readonly long[] Value={ 1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L,1L,7L,24L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070410Inst : IEnumerable<long>
{
public static readonly long[] Value=A070410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070410.Bytes);
public long this[int i]=>Value[i];

public static A070410Inst Instance=new A070410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070411
{
public static readonly long[] Value={ 1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L,21L,17L,15L,1L,7L,23L,5L,9L,11L,25L,19L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070411Inst : IEnumerable<long>
{
public static readonly long[] Value=A070411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070411.Bytes);
public long this[int i]=>Value[i];

public static A070411Inst Instance=new A070411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070412
{
public static readonly long[] Value={ 1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L,10L,16L,4L,1L,7L,22L,19L,25L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070412Inst : IEnumerable<long>
{
public static readonly long[] Value=A070412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070412.Bytes);
public long this[int i]=>Value[i];

public static A070412Inst Instance=new A070412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070413
{
public static readonly long[] Value={ 1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L,1L,7L,20L,24L,23L,16L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070413Inst : IEnumerable<long>
{
public static readonly long[] Value=A070413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070413.Bytes);
public long this[int i]=>Value[i];

public static A070413Inst Instance=new A070413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070414
{
public static readonly long[] Value={ 1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L,1L,7L,19L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070414Inst : IEnumerable<long>
{
public static readonly long[] Value=A070414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070414.Bytes);
public long this[int i]=>Value[i];

public static A070414Inst Instance=new A070414Inst();

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