using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190576
{
public static readonly long[] Value={ 1L,9L,19L,31L,45L,61L,79L,99L,121L,145L,171L,199L,229L,261L,295L,331L,369L,409L,451L,495L,541L,589L,639L,691L,745L,801L,859L,919L,981L,1045L,1111L,1179L,1249L,1321L,1395L,1471L,1549L,1629L,1711L,1795L,1881L,1969L,2059L,2151L,2245L,2341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190576Inst : IEnumerable<long>
{
public static readonly long[] Value=A190576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190576.Bytes);
public long this[int i]=>Value[i];

public static A190576Inst Instance=new A190576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190577
{
public static readonly long[] Value={ 105L,384L,945L,1920L,3465L,5760L,9009L,13440L,19305L,26880L,36465L,48384L,62985L,80640L,101745L,126720L,156009L,190080L,229425L,274560L,326025L,384384L,450225L,524160L,606825L,698880L,801009L,913920L,1038345L,1175040L,1324785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190577Inst : IEnumerable<long>
{
public static readonly long[] Value=A190577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190577.Bytes);
public long this[int i]=>Value[i];

public static A190577Inst Instance=new A190577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190578
{
public static readonly long[] Value={ 0L,2L,130L,2190L,16388L,78130L,279942L,823550L,2097160L,4782978L,10000010L,19487182L,35831820L,62748530L,105413518L,170859390L,268435472L,410338690L,612220050L,893871758L,1280000020L,1801088562L,2494357910L,3404825470L,4586471448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190578Inst : IEnumerable<long>
{
public static readonly long[] Value=A190578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190578.Bytes);
public long this[int i]=>Value[i];

public static A190578Inst Instance=new A190578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190579
{
public static readonly long[] Value={ 0L,0L,2L,998L,51618L,873852L,8039322L,50272978L,240764814L,947860554L,3210392210L,9649651136L,26316155354L,66191981440L,155482089002L,344411086374L,725043524246L,1459722296638L,2825136685698L,5278863810724L,9557560367842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190579Inst : IEnumerable<long>
{
public static readonly long[] Value=A190579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190579.Bytes);
public long this[int i]=>Value[i];

public static A190579Inst Instance=new A190579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190580
{
public static readonly long[] Value={ 1L,17L,-1L,1L,19L,2L,397L,-1L,-2L,1L,17299L,-1L,1L,107L,-65L,523L,-359L,2L,-3L,-71L,1L,-2L,-11267L,62641L,-1819L,-14653L,-4L,7L,-1L,1L,1208L,-472663L,-10441L,17L,-126L,-11951L,53L,-4L,323L,-2404889L,5L,-907929611L,36L,-431L,3L,-3547L,-15616184186396177L,-5L,-3L,-349L,3527L,-140131L,17L,-71L,-901L,-2741617L,-2L,10183412861L,-1L,1L,-6L,33728183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190580Inst : IEnumerable<long>
{
public static readonly long[] Value=A190580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190580.Bytes);
public long this[int i]=>Value[i];

public static A190580Inst Instance=new A190580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190581
{
public static readonly long[] Value={ 1L,21L,1L,1L,39L,3L,294L,7L,1L,7L,9954L,1L,1L,57L,42L,582L,182L,1L,1L,129L,2L,3L,6111L,197028L,217L,7083L,1L,3L,1L,1L,1323L,620505L,3318L,13L,43L,3606L,1302L,3L,111L,330498L,3L,216266610L,13L,273L,1L,5733L,590736058375050L,3L,1L,117L,1014L,25767L,19L,37L,1878L,1029364L,1L,37045412880L,1L,1L,1L,11285694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190581Inst : IEnumerable<long>
{
public static readonly long[] Value=A190581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190581.Bytes);
public long this[int i]=>Value[i];

public static A190581Inst Instance=new A190581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190582
{
public static readonly long[] Value={ 16L,17L,18L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190582Inst : IEnumerable<long>
{
public static readonly long[] Value=A190582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190582.Bytes);
public long this[int i]=>Value[i];

public static A190582Inst Instance=new A190582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190583
{
public static readonly long[] Value={ 4827859L,5413813L,59069473L,59069489L,171426679L,189784123L,191766193L,196232137L,306928507L,359727833L,367733497L,409634959L,452273897L,508068287L,644033227L,665209213L,737454929L,879260659L,889580717L,924491669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190583Inst : IEnumerable<long>
{
public static readonly long[] Value=A190583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190583.Bytes);
public long this[int i]=>Value[i];

public static A190583Inst Instance=new A190583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190584
{
public static readonly long[] Value={ 4L,27L,119L,497L,2023L,8149L,32692L,130938L,524050L,2096730L,8387859L,33553102L,134215364L,536866711L,2147476180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190584Inst : IEnumerable<long>
{
public static readonly long[] Value=A190584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190584.Bytes);
public long this[int i]=>Value[i];

public static A190584Inst Instance=new A190584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190585
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,-5L,-29L,-89L,-209L,-9239L,-120455L,-801359L,-3674879L,15450931L,505760971L,4925214295L,30957618511L,-3280733667119L,-49063880680079L,-327527326905119L,-1087577476736255L,97366167074820331L,1723137650565888691L,13360549076712501511UL };
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
public class A190585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190585Inst Instance=new A190585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190586
{
public static readonly long[] Value={ 1L,3L,6L,15L,35L,83L,195L,460L,1085L,2560L,6039L,14247L,33613L,79306L,187114L,441477L,1041626L,2457630L,5798569L,13681202L,32279488L,76160166L,179691649L,423961718L,1000285928L,2360046161L,5568211498L,13137414580L,30995819288L,73129978187L,172538870438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190586Inst : IEnumerable<long>
{
public static readonly long[] Value=A190586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190586.Bytes);
public long this[int i]=>Value[i];

public static A190586Inst Instance=new A190586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190587
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,56L,130L,304L,714L,1678L,3944L,9276L,21832L,51408L,121088L,285288L,672304L,1584638L,3735596L,8807312L,20766914L,48970942L,115487946L,272371376L,642404770L,1515218012L,3574025956L,8430514614L,19886678810L,46911630678L,110664280068L,261060908326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190587Inst : IEnumerable<long>
{
public static readonly long[] Value=A190587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190587.Bytes);
public long this[int i]=>Value[i];

public static A190587Inst Instance=new A190587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190620
{
public static readonly long[] Value={ 5L,11L,13L,23L,27L,29L,47L,55L,59L,61L,95L,111L,119L,123L,125L,191L,223L,239L,247L,251L,253L,383L,447L,479L,495L,503L,507L,509L,767L,895L,959L,991L,1007L,1015L,1019L,1021L,1535L,1791L,1919L,1983L,2015L,2031L,2039L,2043L,2045L,3071L,3583L,3839L,3967L,4031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190620Inst : IEnumerable<long>
{
public static readonly long[] Value=A190620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190620.Bytes);
public long this[int i]=>Value[i];

public static A190620Inst Instance=new A190620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190621
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,5L,6L,7L,0L,9L,10L,11L,0L,13L,14L,15L,0L,17L,18L,19L,0L,21L,22L,23L,0L,25L,26L,27L,0L,29L,30L,31L,0L,33L,34L,35L,0L,37L,38L,39L,0L,41L,42L,43L,0L,45L,46L,47L,0L,49L,50L,51L,0L,53L,54L,55L,0L,57L,58L,59L,0L,61L,62L,63L,0L,65L,66L,67L,0L,69L,70L,71L,0L,73L,74L,75L,0L,77L,78L,79L,0L,81L,82L,83L,0L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190621Inst : IEnumerable<long>
{
public static readonly long[] Value=A190621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190621.Bytes);
public long this[int i]=>Value[i];

public static A190621Inst Instance=new A190621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190622
{
public static readonly long[] Value={ 12L,48L,148L,192L,300L,336L,948L,768L,716L,1200L,2388L,1344L,2028L,2256L,3700L,3072L,3468L,3120L,7188L,4800L,3500L,5712L,10548L,5376L,7500L,8112L,12244L,9024L,10092L,8400L,19188L,12288L,8972L,13872L,23700L,12480L,16428L,17232L,25012L,19200L,20172L,15792L,36948L,22848L,17900L,25296L,44148L,21504L,27276L,30000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190622Inst : IEnumerable<long>
{
public static readonly long[] Value=A190622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190622.Bytes);
public long this[int i]=>Value[i];

public static A190622Inst Instance=new A190622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190623
{
public static readonly long[] Value={ 1L,6L,27L,64L,125L,162L,343L,512L,729L,750L,1331L,1728L,2197L,2058L,3375L,4096L,4913L,4374L,6859L,8000L,9261L,7986L,12167L,13824L,15625L,13182L,19683L,21952L,24389L,20250L,29791L,32768L,35937L,29478L,42875L,46656L,50653L,41154L,59319L,64000L,68921L,55566L,79507L,85184L,91125L,73002L,103823L,110592L,117649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190623Inst : IEnumerable<long>
{
public static readonly long[] Value=A190623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190623.Bytes);
public long this[int i]=>Value[i];

public static A190623Inst Instance=new A190623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190624
{
public static readonly long[] Value={ 11L,6L,27L,64L,125L,162L,343L,512L,729L,750L,1331L,1728L,2197L,2058L,3375L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190624Inst : IEnumerable<long>
{
public static readonly long[] Value=A190624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190624.Bytes);
public long this[int i]=>Value[i];

public static A190624Inst Instance=new A190624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190625
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,46L,338L,3788L,62929L,1549089L,56951770L,3109920701L,252393913470L,30471276950027L,5468189500564227L,1458879136021929400L,BigInteger.Parse("578685384553802577987"),BigInteger.Parse("341244992947305097698156") };
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
public class A190625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190625Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190625.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190625Inst Instance=new A190625Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190626
{
public static readonly BigInteger[] Value={ 1L,0L,2L,6L,42L,324L,4092L,76160L,2171670L,91674436L,5732036632L,535081395254L,74600276538996L,15457006345833026L,4764968523827845468L,BigInteger.Parse("2185341275223905432960"),BigInteger.Parse("1490580025901441886543202") };
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
public class A190626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190626Inst Instance=new A190626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190627
{
public static readonly long[] Value={ 1L,1L,3L,9L,46L,462L,6253L,132061L,4611023L,250827373L,21305367718L,2862744251998L,605949209796465L,201612254630124309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190627Inst : IEnumerable<long>
{
public static readonly long[] Value=A190627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190627.Bytes);
public long this[int i]=>Value[i];

public static A190627Inst Instance=new A190627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190628
{
public static readonly long[] Value={ 1L,1L,5L,37L,401L,7177L,211675L,10163916L,789061887L,99261256018L,20257890922045L,6705845140373654L,3599724849478263520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190628Inst : IEnumerable<long>
{
public static readonly long[] Value=A190628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190628.Bytes);
public long this[int i]=>Value[i];

public static A190628Inst Instance=new A190628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190629
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,115L,1587L,33283L,1147868L,64664807L,5886944926L,868821662115L,207892029761070L,80727613405529244L,BigInteger.Parse("50826500691456029359"),BigInteger.Parse("51893686154530928512158"),BigInteger.Parse("85927150265759233982684320") };
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
public class A190629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190629Inst Instance=new A190629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190630
{
public static readonly long[] Value={ 1L,4L,6L,8L,63L,563L,10027L,209836L,6257561L,259705792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190630Inst : IEnumerable<long>
{
public static readonly long[] Value=A190630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190630.Bytes);
public long this[int i]=>Value[i];

public static A190630Inst Instance=new A190630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190631
{
public static readonly long[] Value={ 1L,1L,2L,7L,34L,193L,1540L,18231L,316852L,8478040L,322171328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190631Inst : IEnumerable<long>
{
public static readonly long[] Value=A190631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190631.Bytes);
public long this[int i]=>Value[i];

public static A190631Inst Instance=new A190631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190632
{
public static readonly long[] Value={ 2L,2L,22L,22L,12L,22L,22L,22L,222L,202L,102L,222L,222L,112L,122L,122L,122L,222L,202L,202L,222L,222L,212L,222L,222L,222L,2222L,2002L,1002L,2222L,2022L,1012L,1122L,1022L,1022L,2222L,2202L,1102L,2222L,2222L,1112L,1122L,1122L,1122L,1222L,1202L,1202L,1222L,1222L,1212L,1222L,1222L,1222L,2222L,2002L,2002L,2222L,2012L,2012L,2222L,2022L,2022L,2222L,2102L,2102L,2222L,2222L,2112L,2222L,2222L,2122L,2222L,2202L,2202L,2222L,2222L,2212L,2222L,2222L,2222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190632Inst : IEnumerable<long>
{
public static readonly long[] Value=A190632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190632.Bytes);
public long this[int i]=>Value[i];

public static A190632Inst Instance=new A190632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190633
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,16L,118L,1077L,11486L,138444L,1847148L,26912226L,424290217L,7194012328L,130641675418L,2534008088656L,52404312807800L,1154031769467768L,27034986095711172L,673063391032594741L,17786452294614118713UL,BigInteger.Parse("498174223396072711297"),BigInteger.Parse("14762117810503938465521"),BigInteger.Parse("461836676823537625928868") };
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
public class A190633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190633Inst Instance=new A190633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190634
{
public static readonly long[] Value={ 2L,14L,969L,2831L,4050L,6167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190634Inst : IEnumerable<long>
{
public static readonly long[] Value=A190634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190634.Bytes);
public long this[int i]=>Value[i];

public static A190634Inst Instance=new A190634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190635
{
public static readonly long[] Value={ 4L,280L,3469989L,34317382L,73414350L,178935505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190635Inst : IEnumerable<long>
{
public static readonly long[] Value=A190635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190635.Bytes);
public long this[int i]=>Value[i];

public static A190635Inst Instance=new A190635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190668
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,12L,14L,32L,54L,60L,66L,72L,78L,84L,90L,256L,272L,288L,304L,320L,336L,352L,368L,384L,500L,520L,810L,840L,870L,900L,930L,1920L,1980L,2040L,2100L,2592L,2664L,2736L,2808L,2880L,2952L,3024L,3096L,3168L,3240L,3312L,3384L,3456L,4116L,4200L,4284L,4368L,4452L,4536L,4620L,4704L,4788L,4872L,4956L,5040L,5124L,5208L,5292L,16384L,16640L,16896L,17152L,17408L,17664L,17920L,18176L,18432L,18688L,18944L,19200L,19456L,19712L,19968L,20224L,20480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190668Inst : IEnumerable<long>
{
public static readonly long[] Value=A190668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190668.Bytes);
public long this[int i]=>Value[i];

public static A190668Inst Instance=new A190668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190669
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190669Inst : IEnumerable<long>
{
public static readonly long[] Value=A190669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190669.Bytes);
public long this[int i]=>Value[i];

public static A190669Inst Instance=new A190669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190670
{
public static readonly long[] Value={ 2L,3L,6L,7L,10L,11L,14L,17L,18L,21L,22L,25L,26L,28L,29L,32L,33L,36L,37L,40L,41L,43L,44L,47L,48L,51L,52L,55L,58L,59L,62L,63L,66L,67L,70L,73L,74L,77L,78L,81L,82L,84L,85L,88L,89L,92L,93L,96L,97L,99L,100L,103L,104L,107L,108L,111L,114L,115L,118L,119L,122L,123L,126L,129L,130L,133L,134L,137L,138L,140L,141L,144L,145L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190670Inst : IEnumerable<long>
{
public static readonly long[] Value=A190670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190670.Bytes);
public long this[int i]=>Value[i];

public static A190670Inst Instance=new A190670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190671
{
public static readonly long[] Value={ 1L,4L,5L,8L,9L,12L,13L,15L,16L,19L,20L,23L,24L,27L,30L,31L,34L,35L,38L,39L,42L,45L,46L,49L,50L,53L,54L,56L,57L,60L,61L,64L,65L,68L,69L,71L,72L,75L,76L,79L,80L,83L,86L,87L,90L,91L,94L,95L,98L,101L,102L,105L,106L,109L,110L,112L,113L,116L,117L,120L,121L,124L,125L,127L,128L,131L,132L,135L,136L,139L,142L,143L,146L,147L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190671Inst : IEnumerable<long>
{
public static readonly long[] Value=A190671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190671.Bytes);
public long this[int i]=>Value[i];

public static A190671Inst Instance=new A190671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190672
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190672Inst : IEnumerable<long>
{
public static readonly long[] Value=A190672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190672.Bytes);
public long this[int i]=>Value[i];

public static A190672Inst Instance=new A190672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190673
{
public static readonly long[] Value={ 7L,11L,22L,26L,37L,41L,52L,63L,67L,78L,82L,93L,97L,104L,108L,119L,123L,134L,138L,149L,153L,160L,164L,175L,179L,190L,194L,205L,216L,220L,231L,235L,246L,250L,261L,272L,276L,287L,291L,302L,306L,313L,317L,328L,332L,343L,347L,358L,362L,369L,373L,384L,388L,399L,403L,414L,425L,429L,440L,444L,455L,459L,470L,481L,485L,496L,500L,511L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190673Inst : IEnumerable<long>
{
public static readonly long[] Value=A190673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190673.Bytes);
public long this[int i]=>Value[i];

public static A190673Inst Instance=new A190673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190674
{
public static readonly long[] Value={ 2L,3L,6L,9L,10L,13L,14L,17L,18L,21L,24L,25L,28L,29L,32L,33L,35L,36L,39L,40L,43L,44L,47L,48L,50L,51L,54L,55L,58L,59L,62L,65L,66L,69L,70L,73L,74L,77L,80L,81L,84L,85L,88L,89L,91L,92L,95L,96L,99L,100L,103L,106L,107L,110L,111L,114L,115L,118L,121L,122L,125L,126L,129L,130L,132L,133L,136L,137L,140L,141L,144L,145L,147L,148L,151L,152L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190674Inst : IEnumerable<long>
{
public static readonly long[] Value=A190674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190674.Bytes);
public long this[int i]=>Value[i];

public static A190674Inst Instance=new A190674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190675
{
public static readonly long[] Value={ 1L,4L,5L,8L,12L,15L,16L,19L,20L,23L,27L,30L,31L,34L,38L,42L,45L,46L,49L,53L,56L,57L,60L,61L,64L,68L,71L,72L,75L,76L,79L,83L,86L,87L,90L,94L,98L,101L,102L,105L,109L,112L,113L,116L,117L,120L,124L,127L,128L,131L,135L,139L,142L,143L,146L,150L,154L,157L,158L,161L,165L,168L,169L,172L,173L,176L,180L,183L,184L,187L,191L,195L,198L,199L,202L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190675Inst : IEnumerable<long>
{
public static readonly long[] Value=A190675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190675.Bytes);
public long this[int i]=>Value[i];

public static A190675Inst Instance=new A190675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190676
{
public static readonly long[] Value={ 2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190676Inst : IEnumerable<long>
{
public static readonly long[] Value=A190676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190676.Bytes);
public long this[int i]=>Value[i];

public static A190676Inst Instance=new A190676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190677
{
public static readonly long[] Value={ 3L,7L,10L,11L,14L,18L,22L,25L,26L,29L,33L,37L,40L,41L,44L,48L,52L,55L,59L,63L,66L,67L,70L,74L,78L,81L,82L,85L,89L,93L,96L,97L,100L,104L,107L,108L,111L,115L,119L,122L,123L,126L,130L,134L,137L,138L,141L,145L,149L,152L,153L,156L,160L,163L,164L,167L,171L,175L,178L,179L,182L,186L,190L,193L,194L,197L,201L,205L,208L,212L,216L,219L,220L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190677Inst : IEnumerable<long>
{
public static readonly long[] Value=A190677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190677.Bytes);
public long this[int i]=>Value[i];

public static A190677Inst Instance=new A190677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190678
{
public static readonly long[] Value={ 2L,5L,6L,9L,13L,17L,20L,21L,24L,28L,32L,35L,36L,39L,43L,47L,50L,51L,54L,58L,61L,62L,65L,69L,73L,76L,77L,80L,84L,88L,91L,92L,95L,99L,103L,106L,110L,114L,117L,118L,121L,125L,129L,132L,133L,136L,140L,144L,147L,148L,151L,155L,158L,159L,162L,166L,170L,173L,174L,177L,181L,185L,188L,189L,192L,196L,200L,203L,204L,207L,211L,214L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190678Inst : IEnumerable<long>
{
public static readonly long[] Value=A190678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190678.Bytes);
public long this[int i]=>Value[i];

public static A190678Inst Instance=new A190678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190679
{
public static readonly long[] Value={ 1L,4L,8L,12L,15L,16L,19L,23L,27L,30L,31L,34L,38L,42L,45L,46L,49L,53L,56L,57L,60L,64L,68L,71L,72L,75L,79L,83L,86L,87L,90L,94L,98L,101L,102L,105L,109L,112L,113L,116L,120L,124L,127L,128L,131L,135L,139L,142L,143L,146L,150L,154L,157L,161L,165L,168L,169L,172L,176L,180L,183L,184L,187L,191L,195L,198L,199L,202L,206L,209L,210L,213L,217L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190679Inst : IEnumerable<long>
{
public static readonly long[] Value=A190679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190679.Bytes);
public long this[int i]=>Value[i];

public static A190679Inst Instance=new A190679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190680
{
public static readonly long[] Value={ 11L,251L,1429L,906949L,1050449L,1058389L,3728113L,9665329L,13623667L,14320489L,30668003L,30910391L,45717377L,49437001L,55544959L,57510911L,58206653L,58772257L,69490901L,72191321L,73625789L,75235973L,79396433L,99673891L,103821169L,104662139L,121322449L,125938889L,147210257L,164810311L,169844879L,170650169L,201991721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190680Inst : IEnumerable<long>
{
public static readonly long[] Value=A190680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190680.Bytes);
public long this[int i]=>Value[i];

public static A190680Inst Instance=new A190680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190681
{
public static readonly long[] Value={ 0L,0L,2L,61L,899L,11219L,126905L,1374229L,14529946L,151426672L,1563147978L,16031036348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190681Inst : IEnumerable<long>
{
public static readonly long[] Value=A190681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190681.Bytes);
public long this[int i]=>Value[i];

public static A190681Inst Instance=new A190681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190682
{
public static readonly long[] Value={ 582169L,588289L,1136356L,1183744L,1454436L,1700416L,2030625L,2424249L,2436721L,2669956L,2732409L,2930944L,3024121L,3175524L,3305124L,3381921L,3481956L,3526884L,3900625L,4129024L,4182025L,4223025L,4553956L,4804864L,4981824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190682Inst : IEnumerable<long>
{
public static readonly long[] Value=A190682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190682.Bytes);
public long this[int i]=>Value[i];

public static A190682Inst Instance=new A190682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190683
{
public static readonly long[] Value={ 2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190683Inst : IEnumerable<long>
{
public static readonly long[] Value=A190683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190683.Bytes);
public long this[int i]=>Value[i];

public static A190683Inst Instance=new A190683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190700
{
public static readonly long[] Value={ 3L,7L,14L,18L,22L,25L,29L,33L,37L,40L,44L,48L,55L,59L,63L,66L,70L,74L,78L,81L,85L,89L,93L,96L,100L,104L,111L,115L,119L,122L,126L,130L,134L,137L,141L,145L,149L,152L,156L,160L,167L,171L,175L,178L,182L,186L,190L,193L,197L,201L,205L,208L,212L,216L,223L,227L,231L,234L,238L,242L,246L,249L,253L,257L,264L,268L,272L,275L,279L,283L,287L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190700Inst : IEnumerable<long>
{
public static readonly long[] Value=A190700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190700.Bytes);
public long this[int i]=>Value[i];

public static A190700Inst Instance=new A190700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190701
{
public static readonly long[] Value={ 2L,6L,10L,13L,17L,21L,28L,32L,36L,39L,43L,47L,51L,54L,58L,62L,69L,73L,77L,80L,84L,88L,92L,95L,99L,103L,107L,110L,114L,118L,125L,129L,133L,136L,140L,144L,148L,151L,155L,159L,163L,166L,170L,174L,181L,185L,189L,192L,196L,200L,204L,207L,211L,215L,219L,222L,226L,230L,237L,241L,245L,248L,252L,256L,260L,263L,267L,271L,278L,282L,286L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190701Inst : IEnumerable<long>
{
public static readonly long[] Value=A190701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190701.Bytes);
public long this[int i]=>Value[i];

public static A190701Inst Instance=new A190701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190702
{
public static readonly long[] Value={ 1L,5L,9L,12L,16L,20L,24L,27L,31L,35L,42L,46L,50L,53L,57L,61L,65L,68L,72L,76L,83L,87L,91L,94L,98L,102L,106L,109L,113L,117L,121L,124L,128L,132L,139L,143L,147L,150L,154L,158L,162L,165L,169L,173L,177L,180L,184L,188L,195L,199L,203L,206L,210L,214L,218L,221L,225L,229L,233L,236L,240L,244L,247L,251L,255L,259L,262L,266L,270L,274L,277L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190702Inst : IEnumerable<long>
{
public static readonly long[] Value=A190702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190702.Bytes);
public long this[int i]=>Value[i];

public static A190702Inst Instance=new A190702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190703
{
public static readonly long[] Value={ 4L,8L,15L,19L,23L,30L,34L,38L,45L,49L,56L,60L,64L,71L,75L,79L,86L,90L,101L,105L,112L,116L,120L,127L,131L,135L,142L,146L,157L,161L,168L,172L,176L,183L,187L,191L,198L,202L,209L,213L,217L,224L,228L,232L,239L,243L,254L,258L,265L,269L,273L,280L,284L,288L,295L,299L,310L,314L,321L,325L,329L,336L,340L,344L,351L,355L,366L,370L,377L,381L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190703Inst : IEnumerable<long>
{
public static readonly long[] Value=A190703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190703.Bytes);
public long this[int i]=>Value[i];

public static A190703Inst Instance=new A190703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190704
{
public static readonly long[] Value={ 3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190704Inst : IEnumerable<long>
{
public static readonly long[] Value=A190704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190704.Bytes);
public long this[int i]=>Value[i];

public static A190704Inst Instance=new A190704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190705
{
public static readonly long[] Value={ 0L,18L,120L,378L,864L,1650L,2808L,4410L,6528L,9234L,12600L,16698L,21600L,27378L,34104L,41850L,50688L,60690L,71928L,84474L,98400L,113778L,130680L,149178L,169344L,191250L,214968L,240570L,268128L,297714L,329400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190705Inst : IEnumerable<long>
{
public static readonly long[] Value=A190705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190705.Bytes);
public long this[int i]=>Value[i];

public static A190705Inst Instance=new A190705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190706
{
public static readonly long[] Value={ 3L,10L,14L,18L,21L,25L,29L,33L,36L,40L,44L,48L,51L,55L,59L,66L,70L,74L,77L,81L,85L,89L,92L,96L,100L,107L,111L,115L,118L,122L,126L,130L,133L,137L,141L,145L,148L,152L,156L,163L,167L,171L,174L,178L,182L,186L,189L,193L,197L,201L,204L,208L,212L,219L,223L,227L,230L,234L,238L,242L,245L,249L,253L,257L,260L,264L,268L,275L,279L,283L,286L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190706Inst : IEnumerable<long>
{
public static readonly long[] Value=A190706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190706.Bytes);
public long this[int i]=>Value[i];

public static A190706Inst Instance=new A190706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190707
{
public static readonly long[] Value={ 2L,6L,9L,13L,17L,24L,28L,32L,35L,39L,43L,47L,50L,54L,58L,62L,65L,69L,73L,80L,84L,88L,91L,95L,99L,103L,106L,110L,114L,121L,125L,129L,132L,136L,140L,144L,147L,151L,155L,159L,162L,166L,170L,177L,181L,185L,188L,192L,196L,200L,203L,207L,211L,215L,218L,222L,226L,233L,237L,241L,244L,248L,252L,256L,259L,263L,267L,271L,274L,278L,282L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190707Inst : IEnumerable<long>
{
public static readonly long[] Value=A190707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190707.Bytes);
public long this[int i]=>Value[i];

public static A190707Inst Instance=new A190707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190708
{
public static readonly long[] Value={ 1L,5L,8L,12L,16L,20L,23L,27L,31L,38L,42L,46L,49L,53L,57L,61L,64L,68L,72L,76L,79L,83L,87L,94L,98L,102L,105L,109L,113L,117L,120L,124L,128L,135L,139L,143L,146L,150L,154L,158L,161L,165L,169L,173L,176L,180L,184L,191L,195L,199L,202L,206L,210L,214L,217L,221L,225L,229L,232L,236L,240L,247L,251L,255L,258L,262L,266L,270L,273L,277L,281L,285L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190708Inst : IEnumerable<long>
{
public static readonly long[] Value=A190708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190708.Bytes);
public long this[int i]=>Value[i];

public static A190708Inst Instance=new A190708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190709
{
public static readonly long[] Value={ 4L,15L,19L,30L,34L,45L,56L,60L,71L,75L,86L,90L,101L,112L,116L,127L,131L,142L,157L,168L,172L,183L,187L,198L,209L,213L,224L,228L,239L,243L,254L,265L,269L,280L,284L,295L,310L,321L,325L,336L,340L,351L,366L,377L,381L,392L,396L,407L,418L,422L,433L,437L,448L,452L,463L,474L,478L,489L,493L,504L,519L,530L,534L,545L,549L,560L,575L,586L,590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190709Inst : IEnumerable<long>
{
public static readonly long[] Value=A190709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190709.Bytes);
public long this[int i]=>Value[i];

public static A190709Inst Instance=new A190709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190710
{
public static readonly long[] Value={ 3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,1L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190710Inst : IEnumerable<long>
{
public static readonly long[] Value=A190710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190710.Bytes);
public long this[int i]=>Value[i];

public static A190710Inst Instance=new A190710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190711
{
public static readonly long[] Value={ 3L,7L,11L,18L,22L,26L,33L,37L,41L,48L,52L,59L,63L,67L,74L,78L,82L,89L,93L,97L,104L,108L,115L,119L,123L,130L,134L,138L,145L,149L,153L,156L,160L,164L,171L,175L,179L,186L,190L,194L,201L,205L,212L,216L,220L,227L,231L,235L,242L,246L,250L,257L,261L,268L,272L,276L,283L,287L,291L,298L,302L,306L,313L,317L,324L,328L,332L,339L,343L,347L,354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190711Inst : IEnumerable<long>
{
public static readonly long[] Value=A190711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190711.Bytes);
public long this[int i]=>Value[i];

public static A190711Inst Instance=new A190711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190712
{
public static readonly long[] Value={ 6L,10L,14L,17L,21L,25L,29L,32L,36L,40L,44L,47L,51L,55L,62L,66L,70L,73L,77L,81L,85L,88L,92L,96L,100L,103L,107L,111L,118L,122L,126L,129L,133L,137L,141L,144L,148L,152L,159L,163L,167L,170L,174L,178L,182L,185L,189L,193L,197L,200L,204L,208L,215L,219L,223L,226L,230L,234L,238L,241L,245L,249L,253L,256L,260L,264L,271L,275L,279L,282L,286L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190712Inst : IEnumerable<long>
{
public static readonly long[] Value=A190712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190712.Bytes);
public long this[int i]=>Value[i];

public static A190712Inst Instance=new A190712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190713
{
public static readonly long[] Value={ 2L,5L,9L,13L,20L,24L,28L,31L,35L,39L,43L,46L,50L,54L,58L,61L,65L,69L,76L,80L,84L,87L,91L,95L,99L,102L,106L,110L,114L,117L,121L,125L,132L,136L,140L,143L,147L,151L,155L,158L,162L,166L,173L,177L,181L,184L,188L,192L,196L,199L,203L,207L,211L,214L,218L,222L,229L,233L,237L,240L,244L,248L,252L,255L,259L,263L,267L,270L,274L,278L,285L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190713Inst : IEnumerable<long>
{
public static readonly long[] Value=A190713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190713.Bytes);
public long this[int i]=>Value[i];

public static A190713Inst Instance=new A190713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190714
{
public static readonly long[] Value={ 1L,4L,8L,12L,16L,19L,23L,27L,34L,38L,42L,45L,49L,53L,57L,60L,64L,68L,72L,75L,79L,83L,90L,94L,98L,101L,105L,109L,113L,116L,120L,124L,128L,131L,135L,139L,146L,150L,154L,157L,161L,165L,169L,172L,176L,180L,187L,191L,195L,198L,202L,206L,210L,213L,217L,221L,225L,228L,232L,236L,243L,247L,251L,254L,258L,262L,266L,269L,273L,277L,281L,284L,288L,292L,299L,303L,307L,310L,314L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190714Inst : IEnumerable<long>
{
public static readonly long[] Value=A190714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190714.Bytes);
public long this[int i]=>Value[i];

public static A190714Inst Instance=new A190714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190715
{
public static readonly long[] Value={ 15L,30L,56L,71L,86L,112L,127L,142L,168L,183L,209L,224L,239L,265L,280L,295L,321L,336L,377L,392L,418L,433L,448L,474L,489L,504L,530L,545L,586L,601L,627L,642L,657L,683L,698L,713L,739L,754L,780L,795L,810L,836L,851L,866L,892L,907L,948L,963L,989L,1004L,1019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190715Inst : IEnumerable<long>
{
public static readonly long[] Value=A190715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190715.Bytes);
public long this[int i]=>Value[i];

public static A190715Inst Instance=new A190715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190732
{
public static readonly long[] Value={ 1L,1L,2L,8L,3L,7L,9L,1L,6L,7L,0L,9L,5L,5L,1L,2L,5L,7L,3L,8L,9L,6L,1L,5L,8L,9L,0L,3L,1L,2L,1L,5L,4L,5L,1L,7L,1L,6L,8L,8L,1L,0L,1L,2L,5L,8L,6L,5L,7L,9L,9L,7L,7L,1L,3L,6L,8L,8L,1L,7L,1L,4L,4L,3L,4L,2L,1L,2L,8L,4L,9L,3L,6L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190732Inst : IEnumerable<long>
{
public static readonly long[] Value=A190732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190732.Bytes);
public long this[int i]=>Value[i];

public static A190732Inst Instance=new A190732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190733
{
public static readonly long[] Value={ 1L,3L,5L,15L,49L,175L,657L,2559L,10241L,41855L,173953L,732927L,3123457L,13439743L,58307841L,254779391L,1120247809L,4952864767L,22005184513L,98196398079L,439923990529L,1977917169663L,8921667641345L,40361657696255L,183092192411649L,832634240106495L,3795237359190017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190733Inst : IEnumerable<long>
{
public static readonly long[] Value=A190733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190733.Bytes);
public long this[int i]=>Value[i];

public static A190733Inst Instance=new A190733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190734
{
public static readonly BigInteger[] Value={ 1L,5L,51L,618L,8043L,108753L,1505652L,21181632L,301445115L,4327546335L,62550664827L,909065484726L,13271032349844L,194464001709708L,2858582670411768L,42135099729748512L,622533141544186779L,9216768941364987195L,BigInteger.Parse("136706015987753749593") };
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
public class A190734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190734Inst Instance=new A190734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190735
{
public static readonly long[] Value={ 1L,3L,6L,16L,38L,93L,93L,223L,540L,1305L,3157L,7629L,18436L,44543L,107607L,259899L,627606L,1515284L,3657904L,8828836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190735Inst : IEnumerable<long>
{
public static readonly long[] Value=A190735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190735.Bytes);
public long this[int i]=>Value[i];

public static A190735Inst Instance=new A190735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190736
{
public static readonly long[] Value={ 1L,2L,7L,29L,139L,731L,4096L,24005L,145420L,903503L,5726290L,36878978L,240663403L,1587928511L,10575884599L,71005972250L,480071241463L,3265685620913L,22335284505529L,153496543690226L,1059443187603955L,7340794592800628L,51042913856490028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190736Inst : IEnumerable<long>
{
public static readonly long[] Value=A190736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190736.Bytes);
public long this[int i]=>Value[i];

public static A190736Inst Instance=new A190736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190737
{
public static readonly long[] Value={ 1L,2L,6L,19L,66L,244L,946L,3801L,15697L,66234L,284339L,1237983L,5453611L,24263355L,108865901L,492051006L,2238220336L,10238568080L,47070014643L,217363784060L,1007794226777L,4689545704246L,21893712581740L,102520882301832L,481393173378979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190737Inst : IEnumerable<long>
{
public static readonly long[] Value=A190737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190737.Bytes);
public long this[int i]=>Value[i];

public static A190737Inst Instance=new A190737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190738
{
public static readonly long[] Value={ 1L,4L,27L,212L,1785L,15630L,140287L,1280592L,11833389L,110360150L,1036670272L,9794291556L,92972640761L,886023463122L,8471878678545L,81236546627920L,780898417097733L,7522708492892214L,72607180401922894L,701969331508141900L,6796919869909393140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190738Inst : IEnumerable<long>
{
public static readonly long[] Value=A190738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190738.Bytes);
public long this[int i]=>Value[i];

public static A190738Inst Instance=new A190738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190739
{
public static readonly long[] Value={ 18L,38L,59L,80L,101L,119L,140L,161L,181L,203L,223L,241L,264L,284L,305L,325L,347L,365L,385L,407L,427L,448L,469L,487L,509L,530L,551L,571L,592L,611L,631L,652L,673L,694L,712L,733L,755L,775L,797L,817L,835L,856L,877L,898L,918L,940L,958L,978L,1001L,1021L,1042L,1063L,1081L,1102L,1122L,1144L,1164L,1185L,1204L,1224L,1246L,1267L,1288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190739Inst : IEnumerable<long>
{
public static readonly long[] Value=A190739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190739.Bytes);
public long this[int i]=>Value[i];

public static A190739Inst Instance=new A190739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190740
{
public static readonly long[] Value={ 6L,14L,23L,31L,41L,48L,57L,65L,74L,83L,90L,99L,107L,116L,125L,133L,142L,151L,158L,167L,175L,184L,193L,200L,210L,217L,227L,235L,244L,252L,260L,269L,277L,286L,294L,303L,311L,320L,328L,336L,345L,353L,362L,370L,379L,388L,396L,404L,413L,421L,430L,438L,446L,456L,463L,473L,480L,490L,498L,505L,515L,523L,532L,540L,548L,557L,566L,574L,582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190740Inst : IEnumerable<long>
{
public static readonly long[] Value=A190740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190740.Bytes);
public long this[int i]=>Value[i];

public static A190740Inst Instance=new A190740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190741
{
public static readonly long[] Value={ 16L,35L,53L,73L,93L,110L,130L,148L,168L,188L,206L,224L,243L,262L,281L,299L,319L,338L,356L,376L,394L,414L,434L,451L,470L,489L,508L,527L,545L,564L,584L,602L,622L,640L,659L,679L,697L,716L,735L,754L,772L,790L,810L,829L,848L,868L,885L,905L,925L,943L,962L,981L,999L,1018L,1036L,1056L,1075L,1094L,1113L,1131L,1151L,1171L,1189L,1208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190741Inst : IEnumerable<long>
{
public static readonly long[] Value=A190741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190741.Bytes);
public long this[int i]=>Value[i];

public static A190741Inst Instance=new A190741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190742
{
public static readonly long[] Value={ 1L,3L,7L,9L,12L,15L,19L,22L,25L,28L,30L,33L,37L,39L,43L,45L,49L,51L,54L,58L,61L,64L,67L,69L,72L,76L,78L,81L,85L,87L,89L,94L,96L,100L,103L,105L,109L,112L,115L,117L,120L,123L,126L,129L,132L,136L,138L,141L,145L,147L,152L,154L,155L,159L,162L,165L,169L,172L,174L,177L,180L,183L,187L,190L,192L,195L,197L,201L,204L,207L,211L,213L,216L,219L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190742Inst : IEnumerable<long>
{
public static readonly long[] Value=A190742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190742.Bytes);
public long this[int i]=>Value[i];

public static A190742Inst Instance=new A190742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190743
{
public static readonly long[] Value={ 5L,11L,20L,26L,34L,42L,47L,55L,63L,70L,77L,84L,91L,98L,106L,113L,121L,128L,135L,143L,149L,157L,164L,171L,178L,185L,194L,199L,208L,214L,221L,230L,236L,245L,251L,257L,266L,272L,279L,288L,293L,301L,308L,316L,323L,331L,337L,344L,352L,359L,367L,373L,381L,389L,395L,402L,410L,418L,424L,431L,440L,445L,454L,460L,466L,476L,482L,491L,496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190743Inst : IEnumerable<long>
{
public static readonly long[] Value=A190743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190743.Bytes);
public long this[int i]=>Value[i];

public static A190743Inst Instance=new A190743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190744
{
public static readonly long[] Value={ 2L,4L,8L,10L,13L,17L,21L,24L,27L,29L,32L,36L,40L,44L,46L,50L,52L,56L,60L,62L,66L,68L,71L,75L,79L,82L,86L,88L,92L,95L,97L,102L,104L,108L,111L,114L,118L,122L,124L,127L,131L,134L,137L,139L,144L,146L,150L,153L,156L,160L,163L,166L,170L,173L,176L,179L,182L,186L,189L,191L,196L,198L,202L,205L,209L,212L,215L,218L,220L,225L,228L,231L,234L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190744Inst : IEnumerable<long>
{
public static readonly long[] Value=A190744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190744.Bytes);
public long this[int i]=>Value[i];

public static A190744Inst Instance=new A190744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190745
{
public static readonly long[] Value={ 3L,9L,13L,19L,24L,29L,35L,40L,45L,52L,57L,61L,68L,73L,77L,83L,89L,94L,99L,105L,110L,115L,120L,126L,131L,137L,142L,148L,152L,158L,164L,169L,174L,179L,185L,191L,195L,200L,207L,211L,216L,223L,228L,233L,239L,244L,249L,255L,260L,265L,270L,276L,282L,286L,292L,297L,302L,307L,313L,319L,325L,330L,334L,341L,346L,350L,355L,362L,367L,372L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190745Inst : IEnumerable<long>
{
public static readonly long[] Value=A190745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190745.Bytes);
public long this[int i]=>Value[i];

public static A190745Inst Instance=new A190745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190746
{
public static readonly long[] Value={ 1L,5L,10L,14L,18L,22L,25L,30L,33L,38L,43L,47L,51L,53L,59L,62L,67L,70L,75L,80L,82L,87L,91L,96L,100L,103L,107L,111L,116L,119L,125L,128L,133L,135L,140L,144L,149L,151L,157L,161L,165L,168L,173L,177L,181L,186L,188L,193L,198L,201L,206L,209L,215L,217L,222L,225L,230L,234L,238L,243L,246L,251L,254L,258L,263L,267L,272L,274L,279L,283L,288L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190746Inst : IEnumerable<long>
{
public static readonly long[] Value=A190746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190746.Bytes);
public long this[int i]=>Value[i];

public static A190746Inst Instance=new A190746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190747
{
public static readonly long[] Value={ 6L,15L,23L,31L,39L,48L,55L,63L,72L,81L,88L,97L,106L,113L,121L,129L,138L,147L,155L,163L,171L,178L,187L,196L,204L,213L,220L,229L,236L,245L,253L,262L,269L,277L,287L,295L,303L,311L,321L,328L,336L,344L,354L,361L,370L,378L,386L,394L,402L,411L,418L,428L,436L,444L,451L,460L,468L,476L,485L,494L,502L,509L,518L,526L,535L,542L,551L,558L,567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190747Inst : IEnumerable<long>
{
public static readonly long[] Value=A190747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190747.Bytes);
public long this[int i]=>Value[i];

public static A190747Inst Instance=new A190747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190796
{
public static readonly long[] Value={ 1L,4L,5L,5L,8L,8L,9L,9L,9L,9L,9L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190796Inst : IEnumerable<long>
{
public static readonly long[] Value=A190796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190796.Bytes);
public long this[int i]=>Value[i];

public static A190796Inst Instance=new A190796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190797
{
public static readonly long[] Value={ 11L,23L,41L,83L,107L,167L,191L,263L,307L,347L,367L,461L,641L,653L,877L,881L,1103L,1187L,1367L,2081L,2393L,2677L,3607L,4283L,4357L,4967L,5081L,5231L,5387L,5471L,5651L,6037L,6197L,6311L,6353L,6857L,7823L,8117L,8693L,8747L,9221L,9743L,9851L,9923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190797Inst : IEnumerable<long>
{
public static readonly long[] Value=A190797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190797.Bytes);
public long this[int i]=>Value[i];

public static A190797Inst Instance=new A190797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190798
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,18L,32L,50L,75L,108L,147L,196L,256L,324L,405L,500L,605L,726L,864L,1014L,1183L,1372L,1575L,1800L,2048L,2312L,2601L,2916L,3249L,3610L,4000L,4410L,4851L,5324L,5819L,6348L,6912L,7500L,8125L,8788L,9477L,10206L,10976L,11774L,12615L,13500L,14415L,15376L,16384L,17424L,18513L,19652L,20825L,22050L,23328L,24642L,26011L,27436L,28899L,30420L,32000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190798Inst : IEnumerable<long>
{
public static readonly long[] Value=A190798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190798.Bytes);
public long this[int i]=>Value[i];

public static A190798Inst Instance=new A190798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190799
{
public static readonly long[] Value={ 47L,83L,131L,137L,173L,191L,251L,257L,347L,419L,443L,557L,587L,593L,1013L,1019L,1031L,1049L,1217L,1301L,1427L,1433L,1439L,1979L,1997L,2069L,2267L,2531L,2657L,2687L,2693L,2699L,2711L,3251L,3299L,3539L,4007L,4211L,4241L,4253L,4643L,4931L,5003L,5099L,5399L,5501L,5861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190799Inst : IEnumerable<long>
{
public static readonly long[] Value=A190799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190799.Bytes);
public long this[int i]=>Value[i];

public static A190799Inst Instance=new A190799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190800
{
public static readonly long[] Value={ 11L,17L,41L,844427L,51448361L,51867197L,85776137L,86966771L,93685301L,97122197L,107599757L,113575727L,118136267L,122983031L,180078317L,232728647L,316973621L,483040757L,564537761L,749930717L,840472307L,901288517L,960959381L,1278189947L,1559839991L,1696818647L,1761702947L,1829187287L,2251028567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190800Inst : IEnumerable<long>
{
public static readonly long[] Value=A190800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190800.Bytes);
public long this[int i]=>Value[i];

public static A190800Inst Instance=new A190800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190801
{
public static readonly ulong[] Value={ 6L,15L,55L,145L,889L,5089L,55561L,927889L,6169249L,39916921L,678585889L,13891047241L,417210398089L,1656387533161L,56229997825849L,481224167424529L,11026310270976961L,236887827111937369L,10826413936386055921UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190801Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A190801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190801.Bytes);
public ulong this[int i]=>Value[i];

public static A190801Inst Instance=new A190801Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190802
{
public static readonly long[] Value={ 5L,29L,177L,1245L,9629L,78627L,664917L,5762208L,50849234L,455055614L,4118066400L,37607950280L,346065645809L,3204942065691L,29844571475287L,279238344248556L,2623557165610821L,24739954309690414L,234057667376222381L,2220819602783663483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190802Inst : IEnumerable<long>
{
public static readonly long[] Value=A190802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190802.Bytes);
public long this[int i]=>Value[i];

public static A190802Inst Instance=new A190802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190803
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,9L,14L,15L,17L,23L,26L,27L,29L,33L,41L,44L,45L,50L,51L,53L,57L,65L,68L,77L,80L,81L,86L,87L,89L,98L,99L,101L,105L,113L,122L,129L,131L,134L,135L,149L,152L,153L,158L,159L,161L,170L,171L,173L,177L,194L,195L,197L,201L,203L,209L,225L,230L,239L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190803Inst : IEnumerable<long>
{
public static readonly long[] Value=A190803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190803.Bytes);
public long this[int i]=>Value[i];

public static A190803Inst Instance=new A190803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190804
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,17L,27L,29L,33L,45L,51L,53L,57L,65L,81L,87L,89L,99L,101L,105L,113L,129L,135L,153L,159L,161L,171L,173L,177L,195L,197L,201L,209L,225L,243L,257L,261L,267L,269L,297L,303L,305L,315L,317L,321L,339L,341L,345L,353L,387L,389L,393L,401L,405L,417L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190804Inst : IEnumerable<long>
{
public static readonly long[] Value=A190804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190804.Bytes);
public long this[int i]=>Value[i];

public static A190804Inst Instance=new A190804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190805
{
public static readonly long[] Value={ 1L,4L,7L,13L,22L,25L,40L,43L,49L,67L,76L,79L,85L,97L,121L,130L,133L,148L,151L,157L,169L,193L,202L,229L,238L,241L,256L,259L,265L,292L,295L,301L,313L,337L,364L,385L,391L,400L,403L,445L,454L,457L,472L,475L,481L,508L,511L,517L,529L,580L,583L,589L,601L,607L,625L,673L,688L,715L,724L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190805Inst : IEnumerable<long>
{
public static readonly long[] Value=A190805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190805.Bytes);
public long this[int i]=>Value[i];

public static A190805Inst Instance=new A190805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190806
{
public static readonly long[] Value={ 1L,5L,9L,17L,29L,33L,53L,57L,65L,89L,101L,105L,113L,129L,161L,173L,177L,197L,201L,209L,225L,257L,269L,305L,317L,321L,341L,345L,353L,389L,393L,401L,417L,449L,485L,513L,521L,533L,537L,593L,605L,609L,629L,633L,641L,677L,681L,689L,705L,773L,777L,785L,801L,809L,833L,897L,917L,953L,965L,969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190806Inst : IEnumerable<long>
{
public static readonly long[] Value=A190806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190806.Bytes);
public long this[int i]=>Value[i];

public static A190806Inst Instance=new A190806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190807
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,11L,14L,16L,20L,22L,23L,28L,29L,32L,40L,41L,44L,46L,47L,56L,58L,59L,64L,65L,68L,80L,82L,83L,86L,88L,92L,94L,95L,112L,116L,118L,119L,122L,128L,130L,131L,136L,137L,140L,160L,164L,166L,167L,172L,173L,176L,184L,188L,190L,191L,194L,203L,224L,232L,236L,238L,239L,244L,245L,248L,256L,257L,260L,262L,263L,272L,274L,275L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190807Inst : IEnumerable<long>
{
public static readonly long[] Value=A190807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190807.Bytes);
public long this[int i]=>Value[i];

public static A190807Inst Instance=new A190807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190808
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,13L,14L,16L,22L,25L,26L,28L,32L,40L,43L,44L,49L,50L,52L,56L,64L,67L,76L,79L,80L,85L,86L,88L,97L,98L,100L,104L,112L,121L,128L,130L,133L,134L,148L,151L,152L,157L,158L,160L,169L,170L,172L,176L,193L,194L,196L,200L,202L,208L,224L,229L,238L,241L,242L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190808Inst : IEnumerable<long>
{
public static readonly long[] Value=A190808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190808.Bytes);
public long this[int i]=>Value[i];

public static A190808Inst Instance=new A190808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190809
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,14L,16L,17L,20L,26L,28L,32L,34L,40L,44L,50L,52L,53L,56L,62L,64L,68L,80L,86L,88L,98L,100L,104L,106L,112L,122L,124L,128L,134L,136L,152L,158L,160L,161L,170L,172L,176L,188L,194L,196L,200L,206L,208L,212L,224L,242L,244L,248L,256L,260L,266L,268L,272L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190809Inst : IEnumerable<long>
{
public static readonly long[] Value=A190809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190809.Bytes);
public long this[int i]=>Value[i];

public static A190809Inst Instance=new A190809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190810
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,11L,14L,15L,17L,20L,23L,29L,31L,32L,35L,41L,44L,47L,50L,59L,63L,65L,68L,71L,83L,86L,89L,92L,95L,101L,104L,119L,122L,127L,131L,137L,140L,143L,149L,167L,173L,176L,179L,185L,188L,191L,194L,203L,209L,212L,239L,245L,248L,255L,257L,263L,266L,275L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190810Inst : IEnumerable<long>
{
public static readonly long[] Value=A190810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190810.Bytes);
public long this[int i]=>Value[i];

public static A190810Inst Instance=new A190810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190811
{
public static readonly long[] Value={ 1L,3L,7L,9L,15L,19L,21L,27L,31L,39L,43L,45L,55L,57L,63L,79L,81L,87L,91L,93L,111L,115L,117L,127L,129L,135L,159L,163L,165L,171L,175L,183L,187L,189L,223L,231L,235L,237L,243L,255L,259L,261L,271L,273L,279L,319L,327L,331L,333L,343L,345L,351L,367L,375L,379L,381L,387L,405L,447L,463L,471L,475L,477L,487L,489L,495L,511L,513L,519L,523L,525L,543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190811Inst : IEnumerable<long>
{
public static readonly long[] Value=A190811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190811.Bytes);
public long this[int i]=>Value[i];

public static A190811Inst Instance=new A190811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190892
{
public static readonly long[] Value={ 192L,216L,240L,288L,320L,336L,360L,384L,432L,448L,480L,504L,528L,540L,560L,576L,600L,624L,640L,648L,672L,704L,720L,756L,768L,792L,800L,810L,816L,832L,840L,864L,880L,896L,900L,912L,936L,960L,972L,1000L,1008L,1024L,1040L,1056L,1080L,1088L,1104L,1120L,1134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190892Inst : IEnumerable<long>
{
public static readonly long[] Value=A190892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190892.Bytes);
public long this[int i]=>Value[i];

public static A190892Inst Instance=new A190892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190893
{
public static readonly long[] Value={ 2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190893Inst : IEnumerable<long>
{
public static readonly long[] Value=A190893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190893.Bytes);
public long this[int i]=>Value[i];

public static A190893Inst Instance=new A190893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190894
{
public static readonly long[] Value={ 5L,9L,11L,21L,23L,45L,47L,93L,95L,99L,101L,201L,203L,209L,219L,221L,233L,465L,467L,933L,935L,939L,941L,1881L,1883L,1889L,3777L,3779L,7557L,7559L,15117L,15119L,15131L,30261L,30263L,30315L,30317L,30323L,60645L,60647L,121293L,121295L,121299L,121301L,121401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190894Inst : IEnumerable<long>
{
public static readonly long[] Value=A190894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190894.Bytes);
public long this[int i]=>Value[i];

public static A190894Inst Instance=new A190894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190895
{
public static readonly long[] Value={ 1L,5L,6L,11L,12L,23L,24L,47L,48L,50L,51L,101L,102L,105L,110L,111L,117L,233L,234L,467L,468L,470L,471L,941L,942L,945L,1889L,1890L,3779L,3780L,7559L,7560L,7566L,15131L,15132L,15158L,15159L,15162L,30323L,30324L,60647L,60648L,60650L,60651L,60701L,60702L,121403L,121404L,242807L,242808L,242810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190895Inst : IEnumerable<long>
{
public static readonly long[] Value=A190895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190895.Bytes);
public long this[int i]=>Value[i];

public static A190895Inst Instance=new A190895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190896
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,10L,13L,15L,16L,19L,20L,32L,35L,37L,38L,40L,49L,54L,61L,64L,67L,68L,73L,74L,79L,80L,85L,87L,93L,103L,117L,121L,127L,128L,131L,134L,136L,139L,141L,143L,148L,151L,152L,155L,156L,158L,160L,165L,166L,170L,172L,174L,182L,193L,197L,217L,218L,239L,241L,251L,256L,259L,262L,264L,267L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190896Inst : IEnumerable<long>
{
public static readonly long[] Value=A190896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190896.Bytes);
public long this[int i]=>Value[i];

public static A190896Inst Instance=new A190896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190897
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190897Inst : IEnumerable<long>
{
public static readonly long[] Value=A190897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190897.Bytes);
public long this[int i]=>Value[i];

public static A190897Inst Instance=new A190897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190898
{
public static readonly long[] Value={ 3L,7L,11L,17L,29L,43L,53L,71L,83L,107L,127L,157L,173L,199L,229L,257L,293L,337L,379L,401L,457L,499L,541L,577L,631L,683L,733L,787L,857L,911L,967L,1031L,1091L,1163L,1229L,1297L,1373L,1447L,1553L,1601L,1697L,1787L,1867L,1973L,2029L,2129L,2213L,2339L,2411L,2503L,2617L,2707L,2819L,2927L,3041L,3137L,3251L,3457L,3491L,3607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190898Inst : IEnumerable<long>
{
public static readonly long[] Value=A190898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190898.Bytes);
public long this[int i]=>Value[i];

public static A190898Inst Instance=new A190898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190899
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,11L,12L,15L,16L,17L,18L,21L,22L,24L,25L,27L,28L,31L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,47L,48L,49L,51L,54L,55L,56L,57L,58L,59L,60L,61L,64L,66L,67L,68L,69L,70L,71L,72L,73L,75L,76L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,93L,94L,96L,97L,98L,99L,100L,101L,102L,103L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190899Inst : IEnumerable<long>
{
public static readonly long[] Value=A190899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190899.Bytes);
public long this[int i]=>Value[i];

public static A190899Inst Instance=new A190899Inst();

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