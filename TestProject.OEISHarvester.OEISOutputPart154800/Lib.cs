using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A185737
{
public static readonly long[] Value={ 1L,3L,5L,6L,14L,11L,11L,28L,30L,20L,19L,51L,60L,54L,32L,32L,88L,109L,108L,86L,46L,53L,148L,188L,196L,172L,123L,63L,87L,245L,316L,338L,312L,246L,168L,82L,142L,402L,523L,568L,538L,446L,336L,218L,104L,231L,656L,858L,940L,904L,769L,609L,436L,276L,129L,375L,1067L,1400L,1542L,1496L,1292L,1050L,790L,552L,342L,156L,608L,1732L,2277L,2516L,2454L,2138L,1764L,1362L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185737Inst : IEnumerable<long>
{
public static readonly long[] Value=A185737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185737.Bytes);
public long this[int i]=>Value[i];

public static A185737Inst Instance=new A185737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185738
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,7L,4L,5L,8L,15L,5L,6L,9L,16L,31L,6L,7L,10L,17L,32L,63L,7L,8L,11L,18L,33L,64L,127L,8L,9L,12L,19L,34L,65L,128L,255L,9L,10L,13L,20L,35L,66L,129L,256L,511L,10L,11L,14L,21L,36L,67L,130L,257L,512L,1023L,11L,12L,15L,22L,37L,68L,131L,258L,513L,1024L,2047L,12L,13L,16L,23L,38L,69L,132L,259L,514L,1025L,2048L,4095L,13L,14L,17L,24L,39L,70L,133L,260L,515L,1026L,2049L,4096L,8191L,14L,15L,18L,25L,40L,71L,134L,261L,516L,1027L,2050L,4097L,8192L,16383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185738Inst : IEnumerable<long>
{
public static readonly long[] Value=A185738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185738.Bytes);
public long this[int i]=>Value[i];

public static A185738Inst Instance=new A185738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185739
{
public static readonly long[] Value={ 1L,3L,4L,6L,10L,11L,10L,18L,25L,26L,15L,28L,42L,56L,57L,21L,40L,62L,90L,119L,120L,28L,54L,85L,128L,186L,246L,247L,36L,70L,111L,170L,258L,378L,501L,502L,45L,88L,140L,216L,335L,516L,762L,1012L,1013L,55L,108L,172L,266L,417L,660L,1030L,1530L,2035L,2036L,66L,130L,207L,320L,504L,810L,1305L,2056L,3066L,4082L,4083L,78L,154L,245L,378L,596L,966L,1587L,2590L,4106L,6138L,8177L,8178L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185739Inst : IEnumerable<long>
{
public static readonly long[] Value=A185739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185739.Bytes);
public long this[int i]=>Value[i];

public static A185739Inst Instance=new A185739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185820
{
public static readonly BigInteger[] Value={ 5L,656L,49036L,4443292L,378212944L,32995092992L,2852526229300L,247462638659680L,21440004040979204L,1858466937288261508L,BigInteger.Parse("161065823451839652032"),BigInteger.Parse("13959918564726559991320"),BigInteger.Parse("1209903218593886396425592") };
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
public class A185820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185820Inst Instance=new A185820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185821
{
public static readonly BigInteger[] Value={ 9L,5680L,1266624L,378212944L,100480040192L,28043363244452L,7662203273902712L,2112817100467905536L,BigInteger.Parse("580282378007177354752"),BigInteger.Parse("159650092398206756238532"),BigInteger.Parse("43890600560593534666234904"),BigInteger.Parse("12070254095603726713513018032") };
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
public class A185821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185821Inst Instance=new A185821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185822
{
public static readonly long[] Value={ 29L,49248L,35446376L,32995092992L,28043363244452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185822Inst : IEnumerable<long>
{
public static readonly long[] Value=A185822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185822.Bytes);
public long this[int i]=>Value[i];

public static A185822Inst Instance=new A185822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185823
{
public static readonly long[] Value={ 65L,426928L,956312244L,2852526229300L,7662203273902712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185823Inst : IEnumerable<long>
{
public static readonly long[] Value=A185823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185823.Bytes);
public long this[int i]=>Value[i];

public static A185823Inst Instance=new A185823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185824
{
public static readonly long[] Value={ 181L,3701360L,26231137608L,247462638659680L,2112817100467905536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185824Inst : IEnumerable<long>
{
public static readonly long[] Value=A185824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185824.Bytes);
public long this[int i]=>Value[i];

public static A185824Inst Instance=new A185824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185825
{
public static readonly long[] Value={ 0L,1L,1L,1L,9L,1L,5L,76L,76L,5L,9L,656L,1584L,656L,9L,29L,5680L,49036L,49036L,5680L,29L,65L,49248L,1266624L,4443292L,1266624L,49248L,65L,181L,426928L,35446376L,378212944L,378212944L,35446376L,426928L,181L,441L,3701360L,956312244L,32995092992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185825Inst : IEnumerable<long>
{
public static readonly long[] Value=A185825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185825.Bytes);
public long this[int i]=>Value[i];

public static A185825Inst Instance=new A185825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185826
{
public static readonly BigInteger[] Value={ 1L,25L,3375L,1336336L,1160290625L,1870414552161L,5026507568359375L,BigInteger.Parse("20882706457600000000"),BigInteger.Parse("126834469112674289266929"),BigInteger.Parse("1078732544346879404306640625"),BigInteger.Parse("12415028528548173886807771291871"),BigInteger.Parse("188031682201497672618081000000000000") };
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
public class A185826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185826Inst Instance=new A185826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185827
{
public static readonly long[] Value={ 0L,3L,30L,514L,15782L,923808L,91052720L,17200095426L,5976334149476L,3829861209246738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185827Inst : IEnumerable<long>
{
public static readonly long[] Value=A185827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185827.Bytes);
public long this[int i]=>Value[i];

public static A185827Inst Instance=new A185827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185828
{
public static readonly long[] Value={ 1L,3L,10L,23L,61L,162L,421L,1103L,2890L,7563L,19801L,51842L,135721L,355323L,930250L,2435423L,6376021L,16692642L,43701901L,114413063L,299537290L,784198803L,2053059121L,5374978562L,14071876561L,36840651123L,96450076810L,252509579303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185828Inst : IEnumerable<long>
{
public static readonly long[] Value=A185828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185828.Bytes);
public long this[int i]=>Value[i];

public static A185828Inst Instance=new A185828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185829
{
public static readonly long[] Value={ 1L,10L,30L,118L,393L,1430L,5004L,17877L,63181L,224324L,794939L,2819380L,9995857L,35445025L,125677385L,445630567L,1580102608L,5602722348L,19866041906L,70440800557L,249768066156L,885624613914L,3140236676877L,11134612682393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185829Inst : IEnumerable<long>
{
public static readonly long[] Value=A185829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185829.Bytes);
public long this[int i]=>Value[i];

public static A185829Inst Instance=new A185829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185830
{
public static readonly long[] Value={ 2L,23L,118L,514L,2398L,11789L,54223L,257050L,1213538L,5716561L,26960702L,127201987L,599792318L,2828918061L,13342117403L,62924057051L,296766436047L,1399631468891L,6601012746804L,31132105093032L,146827124366034L,692474808791206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185830Inst : IEnumerable<long>
{
public static readonly long[] Value=A185830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185830.Bytes);
public long this[int i]=>Value[i];

public static A185830Inst Instance=new A185830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185831
{
public static readonly long[] Value={ 3L,61L,393L,2398L,15782L,98975L,649826L,4143707L,26679121L,171597547L,1102725806L,7092378045L,45590856963L,293158517847L,1884832244162L,12118696565347L,77918494954731L,500981651046567L,3221109348385647L,20710370917938021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185831Inst : IEnumerable<long>
{
public static readonly long[] Value=A185831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185831.Bytes);
public long this[int i]=>Value[i];

public static A185831Inst Instance=new A185831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185832
{
public static readonly long[] Value={ 5L,162L,1430L,11789L,98975L,923808L,7678409L,68363184L,593948668L,5187350050L,45205777641L,395015488029L,3443605978936L,30060887575003L,262260968830996L,2288567378102476L,19968587237909055L,174246131512755338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185832Inst : IEnumerable<long>
{
public static readonly long[] Value=A185832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185832.Bytes);
public long this[int i]=>Value[i];

public static A185832Inst Instance=new A185832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185833
{
public static readonly long[] Value={ 8L,421L,5004L,54223L,649826L,7678409L,91052720L,1073661088L,12644950311L,149729950026L,1765937206744L,20858521172073L,246298874943372L,2908556504972388L,34344854423802299L,405576876056939440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185833Inst : IEnumerable<long>
{
public static readonly long[] Value=A185833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185833.Bytes);
public long this[int i]=>Value[i];

public static A185833Inst Instance=new A185833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185834
{
public static readonly long[] Value={ 13L,1103L,17877L,257050L,4143707L,68363184L,1073661088L,17200095426L,278159538826L,4418356392225L,71020967453692L,1136704302337236L,18204389915482609L,291581361291318489L,4670236803825684178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185834Inst : IEnumerable<long>
{
public static readonly long[] Value=A185834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185834.Bytes);
public long this[int i]=>Value[i];

public static A185834Inst Instance=new A185834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185835
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,10L,10L,2L,3L,23L,30L,23L,3L,5L,61L,118L,118L,61L,5L,8L,162L,393L,514L,393L,162L,8L,13L,421L,1430L,2398L,2398L,1430L,421L,13L,21L,1103L,5004L,11789L,15782L,11789L,5004L,1103L,21L,34L,2890L,17877L,54223L,98975L,98975L,54223L,17877L,2890L,34L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185835Inst : IEnumerable<long>
{
public static readonly long[] Value=A185835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185835.Bytes);
public long this[int i]=>Value[i];

public static A185835Inst Instance=new A185835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185948
{
public static readonly long[] Value={ 1L,3L,1L,9L,8L,1L,27L,57L,15L,1L,81L,480L,186L,24L,1L,243L,5505L,2550L,450L,35L,1L,729L,87048L,42795L,8760L,915L,48L,1L,2187L,1780569L,887733L,194355L,23625L,1659L,63L,1L,6561L,44326656L,22154580L,5010768L,660870L,54432L,2772L,80L,1L,19683L,1291851585L,645896268L,148808772L,20586258L,1862406L,112140L,4356L,99L,1L,59049L,43011249480L,21505526325L,5015422800L,715608810L,68717376L,4590810L,212400L,6525L,120L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185948Inst : IEnumerable<long>
{
public static readonly long[] Value=A185948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185948.Bytes);
public long this[int i]=>Value[i];

public static A185948Inst Instance=new A185948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185949
{
public static readonly BigInteger[] Value={ 11L,101L,21001L,1810001L,2100001L,61000001L,2010000001L,11100000001L,61000000001L,1810000000001L,14100000000001L,151000000000001L,5010000000000001L,9100000000000001L,271000000000000001L,1110000000000000001L,BigInteger.Parse("24100000000000000001"),BigInteger.Parse("261000000000000000001"),BigInteger.Parse("3910000000000000000001"),BigInteger.Parse("11100000000000000000001") };
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
public class A185949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185949Inst Instance=new A185949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185950
{
public static readonly long[] Value={ -1L,2L,13L,32L,59L,94L,137L,188L,247L,314L,389L,472L,563L,662L,769L,884L,1007L,1138L,1277L,1424L,1579L,1742L,1913L,2092L,2279L,2474L,2677L,2888L,3107L,3334L,3569L,3812L,4063L,4322L,4589L,4864L,5147L,5438L,5737L,6044L,6359L,6682L,7013L,7352L,7699L,8054L,8417L,8788L,9167L,9554L,9949L,10352L,10763L,11182L,11609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185950Inst : IEnumerable<long>
{
public static readonly long[] Value=A185950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185950.Bytes);
public long this[int i]=>Value[i];

public static A185950Inst Instance=new A185950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185951
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,0L,12L,0L,1L,5L,0L,30L,0L,1L,0L,120L,0L,60L,0L,1L,7L,0L,735L,0L,105L,0L,1L,0L,896L,0L,2800L,0L,168L,0L,1L,9L,0L,15372L,0L,8190L,0L,252L,0L,1L,0L,5760L,0L,114240L,0L,20160L,0L,360L,0L,1L,11L,0L,270765L,0L,556710L,0L,43890L,0L,495L,0L,1L,0L,33792L,0L,4118400L,0L,2084544L,0L,87120L,0L,660L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185951Inst : IEnumerable<long>
{
public static readonly long[] Value=A185951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185951.Bytes);
public long this[int i]=>Value[i];

public static A185951Inst Instance=new A185951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185952
{
public static readonly BigInteger[] Value={ 2L,10L,130L,2210L,64090L,2371330L,97224530L,5152900090L,314326905490L,22945864100770L,2042181904968530L,198091644781947410L,BigInteger.Parse("20007256122976688410"),BigInteger.Parse("2180790917404459036690"),BigInteger.Parse("246429373666703871145970") };
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
public class A185952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185952Inst Instance=new A185952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185953
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,1L,11L,6L,12L,5L,31L,6L,45L,14L,21L,24L,79L,15L,101L,27L,49L,37L,149L,28L,126L,56L,109L,57L,241L,28L,277L,106L,137L,100L,183L,62L,395L,128L,193L,102L,489L,65L,541L,165L,203L,189L,649L,116L,551L,170L,347L,231L,829L,147L,506L,234L,434L,307L,1027L,119L,1101L,364L,450L,412L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185953Inst : IEnumerable<long>
{
public static readonly long[] Value=A185953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185953.Bytes);
public long this[int i]=>Value[i];

public static A185953Inst Instance=new A185953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185954
{
public static readonly long[] Value={ 1L,3L,8L,13L,23L,32L,49L,59L,80L,93L,127L,144L,185L,203L,256L,269L,319L,328L,401L,419L,504L,525L,639L,656L,761L,763L,904L,917L,1063L,1064L,1241L,1227L,1368L,1317L,1503L,1480L,1681L,1659L,1928L,1909L,2143L,2080L,2393L,2371L,2696L,2653L,3055L,2992L,3305L,3147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185954Inst : IEnumerable<long>
{
public static readonly long[] Value=A185954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185954.Bytes);
public long this[int i]=>Value[i];

public static A185954Inst Instance=new A185954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185955
{
public static readonly long[] Value={ 7L,23L,47L,167L,251L,359L,389L,839L,941L,1367L,1847L,1889L,2207L,2417L,3719L,3761L,4889L,5039L,6311L,7079L,7919L,8609L,9377L,10607L,11411L,11447L,13841L,15227L,16127L,17159L,18869L,19319L,20411L,24611L,25589L,26669L,29501L,29927L,36017L,36479L,37907L,43037L,44519L,44927L,45569L,49727L,50627L,52889L,54287L,57119L,62057L,65309L,66047L,70529L,85037L,85847L,95369L,97967L,99191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185955Inst : IEnumerable<long>
{
public static readonly long[] Value=A185955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185955.Bytes);
public long this[int i]=>Value[i];

public static A185955Inst Instance=new A185955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185956
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,11L,19L,17L,29L,23L,37L,43L,31L,47L,41L,61L,53L,67L,71L,59L,73L,89L,79L,83L,103L,101L,107L,109L,97L,127L,131L,113L,139L,137L,151L,157L,149L,163L,173L,181L,191L,167L,193L,211L,179L,199L,223L,197L,227L,233L,239L,229L,241L,257L,251L,277L,293L,283L,313L,281L,271L,307L,269L,337L,263L,311L,347L,317L,359L,353L,367L,331L,373L,379L,349L,389L,383L,401L,397L,421L,409L,443L,431L,419L,449L,433L,439L,467L,457L,463L,491L,487L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185956Inst : IEnumerable<long>
{
public static readonly long[] Value=A185956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185956.Bytes);
public long this[int i]=>Value[i];

public static A185956Inst Instance=new A185956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185957
{
public static readonly long[] Value={ 1L,3L,3L,6L,10L,6L,10L,21L,21L,10L,15L,36L,46L,36L,15L,21L,55L,81L,81L,55L,21L,28L,78L,126L,146L,126L,78L,28L,36L,105L,181L,231L,231L,181L,105L,36L,45L,136L,246L,336L,371L,336L,246L,136L,45L,55L,171L,321L,461L,546L,546L,461L,321L,171L,55L,66L,210L,406L,606L,756L,812L,756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185957Inst : IEnumerable<long>
{
public static readonly long[] Value=A185957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185957.Bytes);
public long this[int i]=>Value[i];

public static A185957Inst Instance=new A185957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185958
{
public static readonly long[] Value={ 1L,3L,3L,6L,7L,6L,10L,13L,13L,10L,15L,21L,22L,21L,15L,21L,31L,34L,34L,31L,21L,28L,43L,49L,50L,49L,43L,28L,36L,57L,67L,70L,70L,67L,57L,36L,45L,73L,88L,94L,95L,94L,88L,73L,45L,55L,91L,112L,122L,125L,125L,122L,112L,91L,55L,66L,111L,139L,154L,160L,161L,160L,154L,139L,111L,66L,78L,133L,169L,190L,200L,203L,203L,200L,190L,169L,133L,78L,91L,157L,202L,230L,245L,251L,252L,251L,245L,230L,202L,157L,91L,105L,183L,238L,274L,295L,305L,308L,308L,305L,295L,274L,238L,183L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185958Inst : IEnumerable<long>
{
public static readonly long[] Value=A185958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185958.Bytes);
public long this[int i]=>Value[i];

public static A185958Inst Instance=new A185958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185959
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,8L,4L,14L,9L,20L,8L,74L,14L,56L,44L,278L,36L,376L,60L,1132L,240L,816L,188L,15394L,464L,4104L,1434L,25784L,1182L,45184L,2192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185959Inst : IEnumerable<long>
{
public static readonly long[] Value=A185959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185959.Bytes);
public long this[int i]=>Value[i];

public static A185959Inst Instance=new A185959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185960
{
public static readonly long[] Value={ 1L,36L,126144L,236736L,934902L,3447632L,11877300L,67885860L,163704304L,1317560094L,1483434161L,5178258504L,8025266717L,12097787616L,16631037162L,25248156920L,110341933344L,145437730020L,718690577744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185960Inst : IEnumerable<long>
{
public static readonly long[] Value=A185960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185960.Bytes);
public long this[int i]=>Value[i];

public static A185960Inst Instance=new A185960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185961
{
public static readonly long[] Value={ 2L,6L,12L,28L,40L,48L,224L,234L,496L,960L,8128L,47616L,174592L,10371840L,15037440L,28090368L,33550336L,134209536L,207516672L,492101632L,1150402560L,8589869056L,59205411720L,137438691328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185961Inst : IEnumerable<long>
{
public static readonly long[] Value=A185961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185961.Bytes);
public long this[int i]=>Value[i];

public static A185961Inst Instance=new A185961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185962
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-2L,1L,0L,-1L,-3L,1L,1L,2L,0L,-4L,1L,1L,3L,5L,2L,-5L,1L,0L,0L,3L,8L,5L,-6L,1L,-1L,-4L,-6L,-1L,10L,9L,-7L,1L,-1L,-4L,-10L,-16L,-10L,10L,14L,-8L,1L,0L,1L,0L,-10L,-26L,-24L,7L,20L,-9L,1L,1L,6L,15L,20L,5L,-30L,-42L,0L,27L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185962Inst : IEnumerable<long>
{
public static readonly long[] Value=A185962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185962.Bytes);
public long this[int i]=>Value[i];

public static A185962Inst Instance=new A185962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185963
{
public static readonly long[] Value={ 1L,0L,-2L,-3L,0L,7L,11L,1L,-24L,-40L,-7L,82L,145L,37L,-279L,-524L,-174L,945L,1888L,767L,-3185L,-6783L,-3244L,10676L,24301L,13330L,-35567L,-86823L,-53615L,117672L,309366L,212101L,-386224L,-1099385L,-827997L,1255937L,3896480L,3197152L,-4039199L,-13773374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185963Inst : IEnumerable<long>
{
public static readonly long[] Value=A185963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185963.Bytes);
public long this[int i]=>Value[i];

public static A185963Inst Instance=new A185963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185996
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,-1L,10L,-7L,1L,1L,-46L,47L,-13L,1L,-1L,299L,-373L,144L,-21L,1L,1L,-2577L,3606L,-1696L,345L,-31L,1L,-1L,27636L,-41746L,22374L,-5605L,706L,-43L,1L,1L,-353404L,565202L,-332934L,96359L,-15086L,1295L,-57L,1L,-1L,5239925L,-8770446L,5556536L,-1790603L,327145L,-35161L,2192L,-73L,1L,1L,-88310783L,153499519L,-103128216L,36149287L,-7422751L,938028L,-73648L,3489L,-91L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185996Inst : IEnumerable<long>
{
public static readonly long[] Value=A185996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185996.Bytes);
public long this[int i]=>Value[i];

public static A185996Inst Instance=new A185996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185997
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,5L,11L,7L,1L,16L,48L,44L,13L,1L,64L,244L,289L,129L,21L,1L,308L,1419L,2045L,1210L,306L,31L,1L,1727L,9281L,15649L,11447L,3937L,627L,43L,1L,11008L,67236L,129112L,111890L,48586L,10680L,1156L,57L,1L,78244L,532816L,1143134L,1140554L,596698L,168102L,25293L,1969L,73L,1L,611060L,4573278L,10808122L,12163344L,7427056L,2555941L,497215L,53954L,3154L,91L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185997Inst : IEnumerable<long>
{
public static readonly long[] Value=A185997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185997.Bytes);
public long this[int i]=>Value[i];

public static A185997Inst Instance=new A185997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185998
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,16L,64L,308L,1727L,11008L,78244L,611060L,5184338L,47366320L,462782080L,4807659368L,52853722811L,612426360832L,7453621425532L,94997205901940L,1264555335831662L,17540102647480336L,252979919852470672L,3786896497867089656L,BigInteger.Parse("58733519954606892278"),BigInteger.Parse("942372338052077455168") };
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
public class A185998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185998Inst Instance=new A185998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185999
{
public static readonly long[] Value={ 291L,24502749L,36627829L,3547310731L,4721984179L,461808766011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185999Inst : IEnumerable<long>
{
public static readonly long[] Value=A185999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185999.Bytes);
public long this[int i]=>Value[i];

public static A185999Inst Instance=new A185999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186000
{
public static readonly long[] Value={ 1L,17L,291L,12L,56L,78645L,1350L,192L,896L,7936L,36096L,3072L,14336L,250880L,1247232L,49152L,229376L,4014080L,6718464L,786432L,3670016L,64225280L,45203456000L,12582912L,58720256L,622854144L,219792015360L,201326592L,939524096L,8321499136L,37849399296L,3221225472L,15032385536L,263066746880L,2924872728576L,51539607552L,240518168576L,4209067950080L,7044820107264L,824633720832L,3848290697216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186000Inst : IEnumerable<long>
{
public static readonly long[] Value=A186000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186000.Bytes);
public long this[int i]=>Value[i];

public static A186000Inst Instance=new A186000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186001
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,205L,917L,4658L,26817L,173899L,1257916L,10036409L,87351977L,821268402L,8273013085L,88696718215L,1006586902196L,12037812901733L,151136735414301L,1985815346287906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186001Inst : IEnumerable<long>
{
public static readonly long[] Value=A186001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186001.Bytes);
public long this[int i]=>Value[i];

public static A186001Inst Instance=new A186001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186002
{
public static readonly BigInteger[] Value={ 1L,1L,2L,16L,768L,294912L,1132462080L,52183852646400L,BigInteger.Parse("33664847019245568000"),BigInteger.Parse("347485857744891213250560000"),BigInteger.Parse("64560982045934655213753964953600000"),BigInteger.Parse("239901585047846581083822477336190648320000000") };
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
public class A186002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186002Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186002.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186002Inst Instance=new A186002Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186003
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,10L,5L,9L,18L,20L,6L,15L,19L,33L,35L,7L,16L,30L,34L,54L,56L,11L,17L,31L,51L,55L,82L,84L,12L,26L,32L,52L,79L,83L,118L,120L,13L,27L,47L,53L,80L,115L,119L,163L,165L,14L,28L,48L,75L,81L,116L,160L,164L,218L,220L,21L,29L,49L,76L,111L,117L,161L,215L,219L,284L,286L,22L,42L,50L,77L,112L,156L,162L,216L,281L,285L,362L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186003Inst : IEnumerable<long>
{
public static readonly long[] Value=A186003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186003.Bytes);
public long this[int i]=>Value[i];

public static A186003Inst Instance=new A186003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186004
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,5L,9L,13L,14L,8L,12L,17L,24L,25L,10L,16L,23L,29L,40L,41L,11L,19L,28L,39L,46L,62L,63L,15L,22L,32L,45L,61L,69L,91L,92L,18L,27L,38L,50L,68L,90L,99L,128L,129L,20L,31L,44L,60L,74L,98L,127L,137L,174L,175L,21L,34L,49L,67L,89L,105L,136L,173L,184L,230L,231L,26L,37L,53L,73L,97L,126L,144L,183L,229L,241L,297L,298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186004Inst : IEnumerable<long>
{
public static readonly long[] Value=A186004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186004.Bytes);
public long this[int i]=>Value[i];

public static A186004Inst Instance=new A186004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186005
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,5L,7L,8L,12L,11L,9L,13L,15L,22L,21L,10L,16L,23L,26L,37L,36L,14L,18L,27L,38L,42L,58L,57L,17L,24L,30L,43L,59L,64L,86L,85L,19L,28L,39L,47L,65L,87L,93L,122L,121L,20L,31L,44L,60L,70L,94L,123L,130L,167L,166L,25L,33L,48L,66L,88L,100L,131L,168L,176L,222L,221L,29L,40L,51L,71L,95L,124L,138L,177L,223L,232L,288L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186005Inst : IEnumerable<long>
{
public static readonly long[] Value=A186005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186005.Bytes);
public long this[int i]=>Value[i];

public static A186005Inst Instance=new A186005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186006
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,2L,3L,1L,1L,1L,3L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,3L,1L,1L,2L,2L,2L,1L,1L,2L,3L,1L,1L,1L,3L,1L,2L,1L,1L,3L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186006Inst : IEnumerable<long>
{
public static readonly long[] Value=A186006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186006.Bytes);
public long this[int i]=>Value[i];

public static A186006Inst Instance=new A186006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186007
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,3L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,4L,1L,3L,2L,1L,1L,1L,2L,3L,1L,3L,1L,1L,1L,4L,1L,8L,3L,1L,2L,1L,3L,1L,3L,6L,1L,2L,4L,1L,3L,1L,1L,1L,2L,3L,4L,1L,2L,3L,1L,2L,1L,1L,1L,5L,2L,11L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186007Inst : IEnumerable<long>
{
public static readonly long[] Value=A186007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186007.Bytes);
public long this[int i]=>Value[i];

public static A186007Inst Instance=new A186007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186008
{
public static readonly long[] Value={ 2L,4L,16L,12L,32L,8L,52L,128L,40L,56L,84L,136L,160L,180L,256L,60L,80L,136L,220L,288L,296L,448L,528L,636L,688L,712L,1024L,152L,232L,384L,648L,704L,788L,856L,1000L,1204L,1416L,1472L,1556L,1592L,1624L,1800L,1972L,2008L,2120L,2356L,2360L,2676L,2744L,2888L,2912L,3064L,3328L,3444L,3680L,3832L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186008Inst : IEnumerable<long>
{
public static readonly long[] Value=A186008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186008.Bytes);
public long this[int i]=>Value[i];

public static A186008Inst Instance=new A186008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186009
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,7L,12L,30L,85L,173L,476L,961L,2652L,8045L,17637L,51033L,108950L,312455L,663535L,1900470L,5936673L,13472296L,39993895L,87986917L,257978502L,820236724L,1899474678L,5723030586L,12809477536L,38036848410L,84141805077L,248369601964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186009Inst : IEnumerable<long>
{
public static readonly long[] Value=A186009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186009.Bytes);
public long this[int i]=>Value[i];

public static A186009Inst Instance=new A186009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186010
{
public static readonly BigInteger[] Value={ 32L,301296L,28935691550L,28418702031939836L,BigInteger.Parse("283178106619218127407323"),BigInteger.Parse("28654609946372050600800562086387") };
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
public class A186010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186010Inst Instance=new A186010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186011
{
public static readonly BigInteger[] Value={ 32L,1758L,96924L,5341590L,294396948L,16225291062L,894236244300L,49284679976982L,2716261832889540L,149703280865259606L,8250703986839316732L,BigInteger.Parse("454726949644851531894"),BigInteger.Parse("25061691593134045875060"),BigInteger.Parse("1381242932694649174358646") };
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
public class A186011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186011Inst Instance=new A186011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186060
{
public static readonly long[] Value={ 20475L,319247L,3894282L,40407070L,545528022L,6541274560L,72905263923L,948612706087L,11378633159391L,128977165646242L,1651775736889251L,19897356422385746L,227128059650587084L,2877087007288462801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186060Inst : IEnumerable<long>
{
public static readonly long[] Value=A186060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186060.Bytes);
public long this[int i]=>Value[i];

public static A186060Inst Instance=new A186060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186061
{
public static readonly BigInteger[] Value={ 60588L,1206478L,19416799L,275207345L,4584860256L,72905263923L,1130708781343L,18130539910403L,287526402899408L,4535336921964336L,72099241003949754L,1142655253137546939L,18084010448517161871UL,BigInteger.Parse("286883699606121628553") };
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
public class A186061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186061Inst Instance=new A186061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186062
{
public static readonly BigInteger[] Value={ 179442L,5004260L,109272739L,1895454019L,44097747372L,948612706087L,18130539910403L,404252413909581L,8653110308655449L,169487105353268172L,3721002454944851222L,BigInteger.Parse("79581242553779690117"),BigInteger.Parse("1574732581918069923120") };
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
public class A186062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186062Inst Instance=new A186062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186063
{
public static readonly long[] Value={ 87L,267L,267L,792L,1217L,792L,2328L,5050L,5050L,2328L,6915L,18376L,26868L,18376L,6915L,20475L,77987L,128303L,128303L,77987L,20475L,60588L,319247L,743667L,836891L,743667L,319247L,60588L,179442L,1206478L,3894282L,5877960L,5877960L,3894282L,1206478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186063Inst : IEnumerable<long>
{
public static readonly long[] Value=A186063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186063.Bytes);
public long this[int i]=>Value[i];

public static A186063Inst Instance=new A186063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186064
{
public static readonly long[] Value={ 6396L,85950L,1119798L,14499921L,189215295L,2464134402L,32080884108L,417846175365L,5441672218326L,70866667068072L,922916034310758L,12019300783493754L,156529394078831076L,2038511626441264185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186064Inst : IEnumerable<long>
{
public static readonly long[] Value=A186064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186064.Bytes);
public long this[int i]=>Value[i];

public static A186064Inst Instance=new A186064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186065
{
public static readonly BigInteger[] Value={ 85950L,2594364L,73704654L,1983108841L,56342354623L,1583479136326L,43674791825894L,1227206096949087L,34442516744766780L,955566424195215926L,BigInteger.Parse("26758623787941625854"),BigInteger.Parse("750296625321555194450"),BigInteger.Parse("20875762248134838402638") };
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
public class A186065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186065Inst Instance=new A186065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186066
{
public static readonly BigInteger[] Value={ 1119798L,73704654L,4397457795L,247063804348L,14979356975339L,883392377522107L,51270569990003466L,3057441104713811514L,BigInteger.Parse("180521405451576931323"),BigInteger.Parse("10542829305586149638446"),BigInteger.Parse("625192383944271526112188") };
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
public class A186066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186066Inst Instance=new A186066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186067
{
public static readonly BigInteger[] Value={ 14499921L,1983108841L,247063804348L,29265455672501L,3645051233578966L,448897699238594169L,BigInteger.Parse("55017751506509218482") };
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
public class A186067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186067Inst Instance=new A186067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186068
{
public static readonly long[] Value={ 6396L,85950L,85950L,1119798L,2594364L,1119798L,14499921L,73704654L,73704654L,14499921L,189215295L,1983108841L,4397457795L,1983108841L,189215295L,2464134402L,56342354623L,247063804348L,247063804348L,56342354623L,2464134402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186068Inst : IEnumerable<long>
{
public static readonly long[] Value=A186068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186068.Bytes);
public long this[int i]=>Value[i];

public static A186068Inst Instance=new A186068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186069
{
public static readonly long[] Value={ 1L,2L,2L,2L,2177L,16109L,1100318L,1315351L,74810500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186069Inst : IEnumerable<long>
{
public static readonly long[] Value=A186069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186069.Bytes);
public long this[int i]=>Value[i];

public static A186069Inst Instance=new A186069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186070
{
public static readonly long[] Value={ 1L,1L,1L,13L,13L,608L,4094L,1875397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186070Inst : IEnumerable<long>
{
public static readonly long[] Value=A186070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186070.Bytes);
public long this[int i]=>Value[i];

public static A186070Inst Instance=new A186070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186071
{
public static readonly long[] Value={ 31L,331L,3331L,33331L,333331L,3333331L,33333331L,0L,0L,0L,0L,0L,37L,337L,0L,0L,0L,311L,0L,313L,3313L,0L,0L,0L,317L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,331L,3331L,33331L,333331L,3333331L,33333331L,0L,0L,0L,0L,0L,337L,0L,0L,0L,0L,0L,0L,0L,0L,0L,347L,3347L,33347L,0L,349L,0L,0L,0L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186071Inst : IEnumerable<long>
{
public static readonly long[] Value=A186071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186071.Bytes);
public long this[int i]=>Value[i];

public static A186071Inst Instance=new A186071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186072
{
public static readonly long[] Value={ 11L,0L,13L,113L,0L,0L,0L,17L,0L,19L,0L,0L,0L,113L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,127L,0L,0L,0L,131L,0L,0L,0L,0L,0L,137L,0L,139L,0L,0L,0L,0L,0L,0L,0L,0L,0L,149L,0L,151L,1151L,0L,0L,0L,0L,0L,157L,0L,0L,0L,0L,0L,163L,1163L,0L,0L,0L,167L,0L,0L,0L,0L,0L,173L,0L,0L,0L,0L,0L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186072Inst : IEnumerable<long>
{
public static readonly long[] Value=A186072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186072.Bytes);
public long this[int i]=>Value[i];

public static A186072Inst Instance=new A186072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186073
{
public static readonly long[] Value={ 71L,0L,73L,773L,0L,0L,0L,0L,0L,79L,0L,0L,0L,0L,0L,0L,0L,0L,0L,719L,0L,0L,0L,0L,0L,0L,0L,727L,7727L,0L,0L,0L,0L,0L,733L,0L,0L,0L,0L,0L,739L,0L,0L,0L,743L,0L,0L,0L,0L,0L,0L,0L,751L,0L,0L,0L,0L,0L,757L,7757L,0L,0L,0L,761L,0L,0L,0L,0L,0L,0L,0L,769L,0L,0L,0L,773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186073Inst : IEnumerable<long>
{
public static readonly long[] Value=A186073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186073.Bytes);
public long this[int i]=>Value[i];

public static A186073Inst Instance=new A186073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186074
{
public static readonly long[] Value={ 15L,27L,429L,1353L,1863L,3388L,3591L,7119L,78403L,133533L,178623L,2282148L,2732353L,3882813L,7103835L,13335333L,17016076L,17786223L,27377889L,32738728L,35639163L,308725039L,347826603L,1248851513L,1333353333L,1420855168L,1777862223L,3146385338L,3699393633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186074Inst : IEnumerable<long>
{
public static readonly long[] Value=A186074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186074.Bytes);
public long this[int i]=>Value[i];

public static A186074Inst Instance=new A186074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186075
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,97L,997L,0L,0L,0L,911L,0L,0L,0L,0L,0L,0L,0L,919L,0L,0L,0L,0L,0L,0L,0L,0L,0L,929L,9929L,99929L,0L,0L,0L,0L,0L,0L,0L,937L,0L,0L,0L,941L,9941L,0L,0L,0L,0L,0L,947L,0L,0L,0L,0L,0L,953L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,967L,9967L,0L,0L,0L,971L,0L,0L,0L,0L,0L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186075Inst : IEnumerable<long>
{
public static readonly long[] Value=A186075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186075.Bytes);
public long this[int i]=>Value[i];

public static A186075Inst Instance=new A186075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186140
{
public static readonly BigInteger[] Value={ 63009576L,58529531286L,58311925687818L,58096554299749404L,BigInteger.Parse("58456633907530057662"),BigInteger.Parse("58923376595033869477548"),BigInteger.Parse("59477821878604876659005166"),BigInteger.Parse("60068131623385389414240300432") };
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
public class A186140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186140Inst Instance=new A186140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186141
{
public static readonly long[] Value={ 81L,558L,558L,3888L,7686L,3888L,27000L,107874L,107874L,27000L,187704L,1512792L,3090564L,1512792L,187704L,1304424L,21216780L,88110594L,88110594L,21216780L,1304424L,9066168L,297562572L,2513594016L,5108761008L,2513594016L,297562572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186141Inst : IEnumerable<long>
{
public static readonly long[] Value=A186141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186141.Bytes);
public long this[int i]=>Value[i];

public static A186141Inst Instance=new A186141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186142
{
public static readonly long[] Value={ 7L,7L,29L,907L,32207L,573217L,3136717L,4128253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186142Inst : IEnumerable<long>
{
public static readonly long[] Value=A186142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186142.Bytes);
public long this[int i]=>Value[i];

public static A186142Inst Instance=new A186142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186143
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,26009371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186143Inst : IEnumerable<long>
{
public static readonly long[] Value=A186143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186143.Bytes);
public long this[int i]=>Value[i];

public static A186143Inst Instance=new A186143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186144
{
public static readonly long[] Value={ 1L,1L,3L,3L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186144Inst : IEnumerable<long>
{
public static readonly long[] Value=A186144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186144.Bytes);
public long this[int i]=>Value[i];

public static A186144Inst Instance=new A186144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186145
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,88L,89L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L,102L,103L,104L,105L,106L,107L,108L,110L,111L,112L,113L,114L,115L,116L,118L,119L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186145Inst : IEnumerable<long>
{
public static readonly long[] Value=A186145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186145.Bytes);
public long this[int i]=>Value[i];

public static A186145Inst Instance=new A186145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186146
{
public static readonly long[] Value={ 2L,4L,8L,12L,16L,20L,25L,30L,36L,41L,47L,53L,59L,66L,73L,80L,87L,94L,101L,109L,117L,125L,133L,141L,150L,158L,167L,176L,185L,194L,203L,213L,222L,232L,242L,252L,262L,272L,282L,292L,303L,314L,324L,335L,346L,357L,369L,380L,392L,403L,415L,426L,438L,450L,462L,475L,487L,499L,512L,524L,537L,550L,563L,576L,589L,602L,615L,628L,642L,655L,669L,682L,696L,710L,724L,738L,752L,766L,781L,795L,810L,824L,839L,853L,868L,883L,898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186146Inst : IEnumerable<long>
{
public static readonly long[] Value=A186146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186146.Bytes);
public long this[int i]=>Value[i];

public static A186146Inst Instance=new A186146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186147
{
public static readonly long[] Value={ 1L,4L,8L,11L,16L,20L,25L,30L,35L,41L,47L,53L,59L,66L,73L,79L,87L,94L,101L,109L,117L,125L,133L,141L,149L,158L,167L,176L,185L,194L,203L,213L,222L,232L,242L,251L,262L,272L,282L,292L,303L,314L,324L,335L,346L,357L,369L,380L,391L,403L,415L,426L,438L,450L,462L,475L,487L,499L,512L,524L,537L,550L,563L,575L,589L,602L,615L,628L,642L,655L,669L,682L,696L,710L,724L,738L,752L,766L,781L,795L,809L,824L,839L,853L,868L,883L,898L,913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186147Inst : IEnumerable<long>
{
public static readonly long[] Value=A186147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186147.Bytes);
public long this[int i]=>Value[i];

public static A186147Inst Instance=new A186147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186148
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,13L,16L,19L,22L,25L,29L,32L,36L,40L,44L,47L,52L,56L,60L,64L,69L,73L,78L,82L,87L,92L,97L,102L,107L,112L,117L,122L,127L,133L,138L,143L,149L,155L,160L,166L,172L,178L,183L,189L,195L,201L,208L,214L,220L,226L,233L,239L,245L,252L,258L,265L,272L,278L,285L,292L,299L,306L,313L,319L,327L,334L,341L,348L,355L,362L,370L,377L,384L,392L,399L,407L,414L,422L,430L,437L,445L,453L,461L,468L,476L,484L,492L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186148Inst : IEnumerable<long>
{
public static readonly long[] Value=A186148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186148.Bytes);
public long this[int i]=>Value[i];

public static A186148Inst Instance=new A186148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186149
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,27L,28L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,45L,46L,48L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,79L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L,95L,96L,98L,99L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,113L,114L,115L,116L,118L,119L,120L,121L,123L,124L,125L,126L,128L,129L,130L,131L,132L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186149Inst : IEnumerable<long>
{
public static readonly long[] Value=A186149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186149.Bytes);
public long this[int i]=>Value[i];

public static A186149Inst Instance=new A186149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186150
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,13L,16L,19L,22L,25L,29L,32L,36L,40L,44L,48L,52L,56L,60L,64L,69L,73L,78L,82L,87L,92L,97L,102L,107L,112L,117L,122L,127L,133L,138L,144L,149L,155L,160L,166L,172L,178L,183L,189L,195L,201L,208L,214L,220L,226L,233L,239L,245L,252L,258L,265L,272L,278L,285L,292L,299L,306L,313L,320L,327L,334L,341L,348L,355L,362L,370L,377L,384L,392L,399L,407L,414L,422L,430L,437L,445L,453L,461L,468L,476L,484L,492L,500L,508L,516L,525L,533L,541L,549L,557L,566L,574L,583L,591L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186150Inst : IEnumerable<long>
{
public static readonly long[] Value=A186150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186150.Bytes);
public long this[int i]=>Value[i];

public static A186150Inst Instance=new A186150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186151
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,27L,28L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,79L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L,95L,96L,98L,99L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,113L,114L,115L,116L,118L,119L,120L,121L,123L,124L,125L,126L,128L,129L,130L,131L,132L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186151Inst : IEnumerable<long>
{
public static readonly long[] Value=A186151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186151.Bytes);
public long this[int i]=>Value[i];

public static A186151Inst Instance=new A186151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186152
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,11L,13L,15L,18L,21L,23L,26L,29L,32L,35L,38L,41L,44L,48L,51L,55L,58L,61L,65L,69L,72L,76L,80L,84L,88L,92L,95L,100L,104L,108L,112L,116L,120L,125L,129L,133L,138L,142L,147L,151L,156L,160L,165L,170L,174L,179L,184L,189L,194L,199L,204L,209L,214L,219L,224L,229L,234L,239L,245L,250L,255L,260L,266L,271L,277L,282L,287L,293L,299L,304L,310L,315L,321L,327L,332L,338L,344L,350L,356L,362L,367L,373L,379L,385L,391L,397L,403L,410L,416L,422L,428L,434L,440L,447L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186152Inst : IEnumerable<long>
{
public static readonly long[] Value=A186152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186152.Bytes);
public long this[int i]=>Value[i];

public static A186152Inst Instance=new A186152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186153
{
public static readonly long[] Value={ 3L,5L,7L,9L,10L,12L,14L,16L,17L,19L,20L,22L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,43L,45L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,96L,97L,98L,99L,101L,102L,103L,105L,106L,107L,109L,110L,111L,113L,114L,115L,117L,118L,119L,121L,122L,123L,124L,126L,127L,128L,130L,131L,132L,134L,135L,136L,137L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186153Inst : IEnumerable<long>
{
public static readonly long[] Value=A186153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186153.Bytes);
public long this[int i]=>Value[i];

public static A186153Inst Instance=new A186153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186154
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,11L,13L,16L,18L,21L,23L,26L,29L,32L,35L,38L,41L,45L,48L,51L,55L,58L,61L,65L,69L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,125L,129L,133L,138L,142L,147L,151L,156L,160L,165L,170L,175L,179L,184L,189L,194L,199L,204L,209L,214L,219L,224L,229L,234L,239L,245L,250L,255L,260L,266L,271L,277L,282L,288L,293L,299L,304L,310L,315L,321L,327L,332L,338L,344L,350L,356L,362L,367L,373L,379L,385L,391L,397L,403L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186154Inst : IEnumerable<long>
{
public static readonly long[] Value=A186154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186154.Bytes);
public long this[int i]=>Value[i];

public static A186154Inst Instance=new A186154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186155
{
public static readonly long[] Value={ 2L,5L,7L,9L,10L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,98L,99L,101L,102L,103L,105L,106L,107L,109L,110L,111L,113L,114L,115L,117L,118L,119L,121L,122L,123L,124L,126L,127L,128L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186155Inst : IEnumerable<long>
{
public static readonly long[] Value=A186155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186155.Bytes);
public long this[int i]=>Value[i];

public static A186155Inst Instance=new A186155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186220
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,14L,16L,18L,21L,23L,26L,28L,30L,33L,35L,38L,40L,42L,45L,47L,50L,52L,55L,57L,59L,62L,64L,67L,69L,71L,74L,76L,79L,81L,84L,86L,88L,91L,93L,96L,98L,100L,103L,105L,108L,110L,112L,115L,117L,120L,122L,125L,127L,129L,132L,134L,137L,139L,141L,144L,146L,149L,151L,154L,156L,158L,161L,163L,166L,168L,170L,173L,175L,178L,180L,182L,185L,187L,190L,192L,195L,197L,199L,202L,204L,207L,209L,211L,214L,216L,219L,221L,224L,226L,228L,231L,233L,236L,238L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186220Inst : IEnumerable<long>
{
public static readonly long[] Value=A186220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186220.Bytes);
public long this[int i]=>Value[i];

public static A186220Inst Instance=new A186220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186221
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,29L,31L,32L,34L,36L,37L,39L,41L,43L,44L,46L,48L,49L,51L,53L,54L,56L,58L,60L,61L,63L,65L,66L,68L,70L,72L,73L,75L,77L,78L,80L,82L,84L,85L,87L,89L,90L,92L,94L,95L,97L,99L,101L,102L,104L,106L,107L,109L,111L,113L,114L,116L,118L,119L,121L,123L,124L,126L,128L,130L,131L,133L,135L,136L,138L,140L,142L,143L,145L,147L,148L,150L,152L,153L,155L,157L,159L,160L,162L,164L,165L,167L,169L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186221Inst : IEnumerable<long>
{
public static readonly long[] Value=A186221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186221.Bytes);
public long this[int i]=>Value[i];

public static A186221Inst Instance=new A186221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186222
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,13L,16L,18L,21L,23L,26L,28L,30L,33L,35L,38L,40L,42L,45L,47L,50L,52L,55L,57L,59L,62L,64L,67L,69L,71L,74L,76L,79L,81L,83L,86L,88L,91L,93L,96L,98L,100L,103L,105L,108L,110L,112L,115L,117L,120L,122L,125L,127L,129L,132L,134L,137L,139L,141L,144L,146L,149L,151L,154L,156L,158L,161L,163L,166L,168L,170L,173L,175L,178L,180L,182L,185L,187L,190L,192L,195L,197L,199L,202L,204L,207L,209L,211L,214L,216L,219L,221L,224L,226L,228L,231L,233L,236L,238L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186222Inst : IEnumerable<long>
{
public static readonly long[] Value=A186222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186222.Bytes);
public long this[int i]=>Value[i];

public static A186222Inst Instance=new A186222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186223
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,9L,11L,13L,14L,16L,17L,19L,20L,22L,24L,25L,27L,28L,30L,31L,33L,35L,36L,38L,39L,41L,43L,44L,46L,47L,49L,50L,52L,54L,55L,57L,58L,60L,61L,63L,65L,66L,68L,69L,71L,73L,74L,76L,77L,79L,80L,82L,84L,85L,87L,88L,90L,91L,93L,95L,96L,98L,99L,101L,102L,104L,106L,107L,109L,110L,112L,114L,115L,117L,118L,120L,121L,123L,125L,126L,128L,129L,131L,132L,134L,136L,137L,139L,140L,142L,143L,145L,147L,148L,150L,151L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186223Inst : IEnumerable<long>
{
public static readonly long[] Value=A186223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186223.Bytes);
public long this[int i]=>Value[i];

public static A186223Inst Instance=new A186223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186224
{
public static readonly long[] Value={ 2L,4L,7L,10L,12L,15L,18L,21L,23L,26L,29L,32L,34L,37L,40L,42L,45L,48L,51L,53L,56L,59L,62L,64L,67L,70L,72L,75L,78L,81L,83L,86L,89L,92L,94L,97L,100L,103L,105L,108L,111L,113L,116L,119L,122L,124L,127L,130L,133L,135L,138L,141L,144L,146L,149L,152L,154L,157L,160L,163L,165L,168L,171L,174L,176L,179L,182L,184L,187L,190L,193L,195L,198L,201L,204L,206L,209L,212L,215L,217L,220L,223L,225L,228L,231L,234L,236L,239L,242L,245L,247L,250L,253L,256L,258L,261L,264L,266L,269L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186224Inst : IEnumerable<long>
{
public static readonly long[] Value=A186224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186224.Bytes);
public long this[int i]=>Value[i];

public static A186224Inst Instance=new A186224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186225
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,11L,13L,14L,16L,17L,19L,20L,22L,24L,25L,27L,28L,30L,32L,33L,35L,36L,38L,39L,41L,43L,44L,46L,47L,49L,50L,52L,54L,55L,57L,58L,60L,61L,63L,65L,66L,68L,69L,71L,73L,74L,76L,77L,79L,80L,82L,84L,85L,87L,88L,90L,91L,93L,95L,96L,98L,99L,101L,102L,104L,106L,107L,109L,110L,112L,114L,115L,117L,118L,120L,121L,123L,125L,126L,128L,129L,131L,132L,134L,136L,137L,139L,140L,142L,143L,145L,147L,148L,150L,151L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186225Inst : IEnumerable<long>
{
public static readonly long[] Value=A186225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186225.Bytes);
public long this[int i]=>Value[i];

public static A186225Inst Instance=new A186225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186226
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,15L,18L,21L,23L,26L,29L,31L,34L,37L,40L,42L,45L,48L,51L,53L,56L,59L,62L,64L,67L,70L,72L,75L,78L,81L,83L,86L,89L,92L,94L,97L,100L,103L,105L,108L,111L,113L,116L,119L,122L,124L,127L,130L,133L,135L,138L,141L,144L,146L,149L,152L,154L,157L,160L,163L,165L,168L,171L,174L,176L,179L,182L,184L,187L,190L,193L,195L,198L,201L,204L,206L,209L,212L,215L,217L,220L,223L,225L,228L,231L,234L,236L,239L,242L,245L,247L,250L,253L,256L,258L,261L,264L,266L,269L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186226Inst : IEnumerable<long>
{
public static readonly long[] Value=A186226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186226.Bytes);
public long this[int i]=>Value[i];

public static A186226Inst Instance=new A186226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186227
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,93L,94L,96L,97L,98L,100L,101L,103L,104L,106L,107L,109L,110L,111L,113L,114L,116L,117L,119L,120L,122L,123L,124L,126L,127L,129L,130L,132L,133L,135L,136L,138L,139L,140L,142L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186227Inst : IEnumerable<long>
{
public static readonly long[] Value=A186227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186227.Bytes);
public long this[int i]=>Value[i];

public static A186227Inst Instance=new A186227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186228
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,18L,21L,24L,27L,31L,34L,37L,40L,44L,47L,50L,53L,57L,60L,63L,66L,70L,73L,76L,79L,82L,86L,89L,92L,95L,99L,102L,105L,108L,112L,115L,118L,121L,125L,128L,131L,134L,137L,141L,144L,147L,150L,154L,157L,160L,163L,167L,170L,173L,176L,180L,183L,186L,189L,192L,196L,199L,202L,205L,209L,212L,215L,218L,222L,225L,228L,231L,235L,238L,241L,244L,248L,251L,254L,257L,260L,264L,267L,270L,273L,277L,280L,283L,286L,290L,293L,296L,299L,303L,306L,309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186228Inst : IEnumerable<long>
{
public static readonly long[] Value=A186228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186228.Bytes);
public long this[int i]=>Value[i];

public static A186228Inst Instance=new A186228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186229
{
public static readonly BigInteger[] Value={ 1L,14L,182L,2470L,34580L,494760L,7191690L,105793545L,1570873850L,23500272796L,353724885332L,5351515200668L,81313973049064L,1240116577389200L,18973783634054760L,291115203548084370L,4477664537437798980L,BigInteger.Parse("69023046543088792440"),BigInteger.Parse("1066084706728274263800"),BigInteger.Parse("16495237916832025427160"),BigInteger.Parse("255635559046076610807120") };
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
public class A186229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186229Inst Instance=new A186229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186230
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,2L,2L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,2L,4L,2L,0L,0L,0L,1L,0L,2L,0L,3L,0L,0L,1L,0L,1L,3L,0L,4L,3L,0L,0L,0L,1L,0L,0L,0L,2L,0L,2L,0L,0L,1L,2L,2L,4L,2L,6L,4L,6L,4L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,3L,0L,0L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,4L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,4L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186230Inst : IEnumerable<long>
{
public static readonly long[] Value=A186230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186230.Bytes);
public long this[int i]=>Value[i];

public static A186230Inst Instance=new A186230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186231
{
public static readonly BigInteger[] Value={ 1L,15L,210L,3003L,43758L,646646L,9657700L,145422675L,2203961430L,33578000610L,513791607420L,7890371113950L,121548660036300L,1877405874732108L,29065024282889672L,450883717216034179L,7007092303604022630L,BigInteger.Parse("109069992321755544170"),BigInteger.Parse("1700179760011004467468"),BigInteger.Parse("26536589497469056215210"),BigInteger.Parse("414670662257153823494820") };
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
public class A186231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186231Inst Instance=new A186231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186232
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,7L,18L,58L,221L,1055L,6485L,50536L,478836L,5440177L,76190368L,1363369202L,31071197441L,868697997215L,29108097152159L,1188937117381254L,61492149340335133L,4073478163425582443L,BigInteger.Parse("335184988593624746984"),BigInteger.Parse("33170032360612393972748") };
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
public class A186232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186232Inst Instance=new A186232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186233
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,2L,2L,3L,2L,2L,3L,3L,3L,3L,2L,3L,4L,4L,5L,5L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,5L,6L,5L,6L,7L,7L,7L,8L,8L,9L,9L,9L,8L,9L,9L,9L,10L,10L,9L,10L,9L,9L,10L,10L,10L,11L,11L,12L,12L,12L,12L,12L,11L,12L,13L,13L,13L,14L,13L,13L,14L,14L,13L,13L,12L,13L,13L,13L,12L,13L,13L,14L,14L,14L,15L,16L,15L,15L,15L,15L,15L,15L,14L,14L,15L,15L,16L,17L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186233Inst : IEnumerable<long>
{
public static readonly long[] Value=A186233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186233.Bytes);
public long this[int i]=>Value[i];

public static A186233Inst Instance=new A186233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186234
{
public static readonly long[] Value={ 7L,9L,31L,33L,43L,67L,69L,75L,87L,105L,111L,127L,159L,163L,189L,193L,201L,211L,231L,235L,259L,283L,285L,289L,303L,319L,327L,349L,357L,391L,393L,415L,475L,483L,487L,489L,495L,511L,535L,537L,579L,583L,615L,619L,621L,643L,645L,679L,685L,723L,727L,735L,739L,741L,745L,801L,867L,873L,883L,885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186234Inst : IEnumerable<long>
{
public static readonly long[] Value=A186234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186234.Bytes);
public long this[int i]=>Value[i];

public static A186234Inst Instance=new A186234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186235
{
public static readonly long[] Value={ 10L,18L,57L,82L,169L,220L,374L,460L,700L,830L,1175L,1358L,1827L,2072L,2684L,3000L,3774L,4170L,5125L,5610L,6765L,7348L,8722L,9412L,11024L,11830L,13699L,14630L,16775L,17840L,20280L,21488L,24242L,25602L,28689L,30210L,33649L,35340L,39150L,41020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186235Inst : IEnumerable<long>
{
public static readonly long[] Value=A186235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186235.Bytes);
public long this[int i]=>Value[i];

public static A186235Inst Instance=new A186235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186252
{
public static readonly BigInteger[] Value={ 1L,1L,4L,56L,2800L,509600L,342451200L,858867609600L,8105992499404800L,BigInteger.Parse("289789231853721600000"),BigInteger.Parse("39450746867638243737600000"),BigInteger.Parse("20541057076054410196318617600000"),BigInteger.Parse("41055903763279774965226732643942400000"),BigInteger.Parse("315984464183472044352469495097074620825600000") };
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
public class A186252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186252Inst Instance=new A186252Inst();

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