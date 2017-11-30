using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A182505
{
public static readonly long[] Value={ 0L,1L,2L,6L,4L,5L,6L,10L,8L,9L,10L,14L,20L,13L,14L,26L,16L,17L,18L,22L,20L,21L,22L,26L,40L,25L,26L,46L,36L,45L,46L,58L,64L,65L,34L,70L,68L,37L,70L,74L,40L,73L,74L,46L,84L,45L,46L,58L,80L,49L,50L,86L,52L,53L,86L,58L,72L,57L,58L,110L,100L,77L,110L,122L,128L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182505Inst : IEnumerable<long>
{
public static readonly long[] Value=A182505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182505.Bytes);
public long this[int i]=>Value[i];

public static A182505Inst Instance=new A182505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182506
{
public static readonly long[] Value={ 0L,1L,5L,8L,13L,21L,42L,63L,105L,170L,291L,465L,772L,1253L,2037L,3300L,5337L,8637L,13974L,22611L,36625L,59270L,95895L,155169L,251064L,406233L,657317L,1063552L,1720917L,2784485L,4505410L,7289943L,11795417L,19085362L,30880843L,49966209L,80847116L,130813389L,211660581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182506Inst : IEnumerable<long>
{
public static readonly long[] Value=A182506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182506.Bytes);
public long this[int i]=>Value[i];

public static A182506Inst Instance=new A182506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182507
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,232L,12848L,1858464L,663242944L,562426769024L,1103780804371200L,4916976475489286656L,BigInteger.Parse("48986367134323580374016"),BigInteger.Parse("1078808700869188981508990976"),BigInteger.Parse("52024935094126934151475827453952"),BigInteger.Parse("5451309776848243787358722272838524928") };
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
public class A182507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182507Inst Instance=new A182507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182508
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,5L,2L,6L,0L,9L,2L,2L,0L,13L,10L,6L,0L,17L,2L,2L,16L,5L,2L,22L,16L,25L,2L,18L,16L,29L,10L,6L,32L,1L,2L,34L,0L,5L,34L,6L,0L,41L,2L,2L,32L,13L,10L,6L,0L,49L,34L,2L,16L,5L,2L,54L,48L,25L,2L,18L,16L,29L,42L,6L,64L,1L,2L,66L,0L,5L,66L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182508Inst : IEnumerable<long>
{
public static readonly long[] Value=A182508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182508.Bytes);
public long this[int i]=>Value[i];

public static A182508Inst Instance=new A182508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182509
{
public static readonly long[] Value={ 0L,1L,3L,1L,8L,14L,16L,37L,61L,89L,144L,244L,392L,633L,1023L,1641L,2680L,4306L,6968L,11261L,18209L,29489L,47688L,77200L,124880L,202073L,326931L,528993L,855952L,1384942L,2240896L,3625869L,5866797L,9492633L,15359464L,24852068L,40211496L,65063537L,105275007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182509Inst : IEnumerable<long>
{
public static readonly long[] Value=A182509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182509.Bytes);
public long this[int i]=>Value[i];

public static A182509Inst Instance=new A182509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182510
{
public static readonly long[] Value={ 0L,1L,3L,-1L,-8L,-2L,0L,9L,1L,-1L,-12L,0L,24L,21L,3L,-9L,-28L,-2L,8L,29L,1L,-9L,-32L,0L,56L,33L,3L,-9L,-24L,-2L,-8L,-23L,-47L,7L,84L,112L,0L,-75L,-109L,-1L,68L,110L,0L,-67L,-111L,-1L,64L,112L,0L,-63L,-13L,-1L,-40L,-18L,0L,73L,113L,-1L,-172L,-144L,-8L,85L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182510Inst : IEnumerable<long>
{
public static readonly long[] Value=A182510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182510.Bytes);
public long this[int i]=>Value[i];

public static A182510Inst Instance=new A182510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182511
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,3L,1L,4L,5L,3L,6L,8L,1L,9L,10L,1L,11L,12L,7L,9L,4L,16L,21L,15L,4L,11L,19L,21L,8L,24L,13L,3L,8L,25L,31L,6L,7L,6L,5L,31L,36L,10L,25L,36L,21L,37L,42L,4L,25L,3L,26L,28L,1L,29L,30L,46L,37L,50L,53L,55L,36L,29L,53L,26L,35L,1L,36L,37L,41L,69L,30L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182511Inst : IEnumerable<long>
{
public static readonly long[] Value=A182511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182511.Bytes);
public long this[int i]=>Value[i];

public static A182511Inst Instance=new A182511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182512
{
public static readonly BigInteger[] Value={ 0L,3L,51L,819L,13107L,209715L,3355443L,53687091L,858993459L,13743895347L,219902325555L,3518437208883L,56294995342131L,900719925474099L,14411518807585587L,230584300921369395L,3689348814741910323L,BigInteger.Parse("59029581035870565171"),BigInteger.Parse("944473296573929042739") };
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
public class A182512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182512Inst Instance=new A182512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182513
{
public static readonly long[] Value={ 2L,3L,4L,8L,5L,8L,6L,14L,10L,7L,15L,8L,20L,22L,13L,14L,9L,10L,16L,17L,35L,30L,11L,23L,12L,20L,31L,76L,21L,13L,45L,14L,15L,36L,22L,23L,61L,16L,57L,17L,42L,69L,37L,46L,18L,33L,19L,41L,35L,27L,67L,20L,149L,52L,30L,76L,123L,21L,39L,171L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182513Inst : IEnumerable<long>
{
public static readonly long[] Value=A182513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182513.Bytes);
public long this[int i]=>Value[i];

public static A182513Inst Instance=new A182513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182514
{
public static readonly long[] Value={ 2L,3L,7L,113L,1327L,1693182318746371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182514Inst : IEnumerable<long>
{
public static readonly long[] Value=A182514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182514.Bytes);
public long this[int i]=>Value[i];

public static A182514Inst Instance=new A182514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182515
{
public static readonly long[] Value={ 340561L,9494101L,499310197L,717164449L,1330655041L,1831048561L,2586927553L,2806205689L,3088134721L,3284630713L,5394826801L,5447713921L,6150705793L,7349616121L,10501586767L,11453249809L,12820178449L,13714377601L,13968642601L,15818878153L,23196631393L,23392517149L,26242929505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182515Inst : IEnumerable<long>
{
public static readonly long[] Value=A182515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182515.Bytes);
public long this[int i]=>Value[i];

public static A182515Inst Instance=new A182515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182516
{
public static readonly long[] Value={ 2L,3L,7L,8L,8L,4L,8L,2L,0L,4L,1L,3L,0L,5L,0L,4L,5L,2L,3L,8L,7L,2L,4L,0L,6L,3L,9L,1L,0L,7L,6L,6L,5L,1L,9L,4L,9L,1L,6L,0L,1L,3L,8L,4L,8L,4L,8L,3L,3L,6L,3L,0L,7L,9L,8L,2L,1L,9L,1L,6L,4L,7L,8L,9L,3L,1L,3L,1L,3L,7L,8L,7L,9L,6L,9L,7L,4L,1L,1L,3L,6L,7L,1L,4L,4L,5L,0L,0L,5L,9L,2L,9L,3L,8L,3L,0L,0L,4L,4L,6L,9L,9L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182516Inst : IEnumerable<long>
{
public static readonly long[] Value=A182516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182516.Bytes);
public long this[int i]=>Value[i];

public static A182516Inst Instance=new A182516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182517
{
public static readonly BigInteger[] Value={ 1L,1L,3L,72L,11423L,11187798L,65460885384L,2247082682913972L,BigInteger.Parse("447548280314975144427") };
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
public class A182517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182517Inst Instance=new A182517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182518
{
public static readonly long[] Value={ 63973L,31146661L,703995733L,21595159873L,192739365541L,461574735553L,3976486324993L,10028704049893L,84154807001953L,197531244744661L,741700610203861L,973694665856161L,2001111155103061L,3060522900274753L,3183276534603733L,4271903575869601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182518Inst : IEnumerable<long>
{
public static readonly long[] Value=A182518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182518.Bytes);
public long this[int i]=>Value[i];

public static A182518Inst Instance=new A182518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182519
{
public static readonly BigInteger[] Value={ 1L,2L,282L,2166L,1400268L,38610948L,6081885702L,244376712498L,26919365237780L,11380881478725028L,609745162009089348L,BigInteger.Parse("221005733915715119316"),BigInteger.Parse("36210963070633268016918"),BigInteger.Parse("2920403379610288252579938"),BigInteger.Parse("493840220599528687495132964"),BigInteger.Parse("183883082249204990404329361972") };
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
public class A182519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182519Inst Instance=new A182519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182520
{
public static readonly BigInteger[] Value={ 1L,2L,8L,42L,264L,1916L,15744L,144546L,1467544L,16335972L,197916768L,2593286692L,36547123728L,551308006392L,8863973173120L,151328667184530L,2734113089546040L,52120618871199060L,1045503182929422240L,BigInteger.Parse("22014065919151444140"),BigInteger.Parse("485475449631284066160") };
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
public class A182520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182520Inst Instance=new A182520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182521
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,17L,23L,25L,45L,47L,77L,87L,95L,103L,107L,137L,143L,175L,215L,247L,283L,287L,313L,347L,355L,373L,385L,397L,425L,443L,455L,467L,565L,577L,593L,637L,653L,667L,703L,737L,773L,775L,787L,850L,907L,913L,917L,943L,975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182521Inst : IEnumerable<long>
{
public static readonly long[] Value=A182521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182521.Bytes);
public long this[int i]=>Value[i];

public static A182521Inst Instance=new A182521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182522
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,18L,27L,54L,81L,162L,243L,486L,729L,1458L,2187L,4374L,6561L,13122L,19683L,39366L,59049L,118098L,177147L,354294L,531441L,1062882L,1594323L,3188646L,4782969L,9565938L,14348907L,28697814L,43046721L,86093442L,129140163L,258280326L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182522Inst : IEnumerable<long>
{
public static readonly long[] Value=A182522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182522.Bytes);
public long this[int i]=>Value[i];

public static A182522Inst Instance=new A182522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182523
{
public static readonly long[] Value={ -2L,-6L,-170L,-9520L,-874902L,-118950678L,-22370367448L,-5550123527520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182523Inst : IEnumerable<long>
{
public static readonly long[] Value=A182523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182523.Bytes);
public long this[int i]=>Value[i];

public static A182523Inst Instance=new A182523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182524
{
public static readonly long[] Value={ 2L,0L,8L,3L,0L,7L,1L,8L,7L,2L,7L,6L,2L,6L,9L,5L,9L,2L,0L,9L,9L,4L,8L,3L,9L,2L,7L,8L,4L,8L,1L,5L,2L,9L,3L,9L,0L,1L,6L,7L,4L,4L,3L,2L,6L,6L,9L,2L,6L,3L,6L,7L,5L,5L,1L,4L,9L,4L,8L,9L,7L,1L,3L,0L,5L,8L,0L,2L,5L,7L,5L,7L,8L,5L,2L,3L,0L,4L,8L,0L,2L,0L,1L,8L,6L,9L,7L,8L,2L,1L,3L,7L,0L,3L,8L,0L,9L,8L,9L,8L,4L,1L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182524Inst : IEnumerable<long>
{
public static readonly long[] Value=A182524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182524.Bytes);
public long this[int i]=>Value[i];

public static A182524Inst Instance=new A182524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182525
{
public static readonly BigInteger[] Value={ 1L,2L,10L,72L,664L,7440L,98064L,1486464L,25476480L,487192320L,10284768000L,237574149120L,5960907832320L,161440734873600L,4694193123379200L,145855192928256000L,4822943651308339200L,BigInteger.Parse("169104439543534387200"),BigInteger.Parse("6266811206473703424000") };
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
public class A182525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182525Inst Instance=new A182525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182526
{
public static readonly long[] Value={ 1L,8L,1L,9L,7L,0L,6L,0L,2L,7L,1L,7L,0L,8L,0L,0L,4L,7L,6L,3L,2L,9L,0L,6L,6L,0L,5L,7L,7L,5L,3L,9L,0L,6L,5L,4L,4L,5L,5L,9L,7L,4L,5L,4L,4L,9L,8L,1L,9L,0L,2L,9L,5L,2L,9L,0L,6L,0L,6L,8L,4L,3L,0L,0L,1L,9L,9L,6L,6L,6L,6L,4L,7L,6L,6L,7L,3L,1L,2L,8L,4L,3L,7L,8L,9L,3L,2L,0L,9L,1L,1L,3L,7L,2L,9L,6L,4L,4L,1L,9L,2L,7L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182526Inst : IEnumerable<long>
{
public static readonly long[] Value=A182526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182526.Bytes);
public long this[int i]=>Value[i];

public static A182526Inst Instance=new A182526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182527
{
public static readonly long[] Value={ 8L,7L,5L,6L,6L,4L,0L,5L,8L,4L,0L,6L,8L,2L,1L,2L,3L,6L,5L,7L,7L,0L,0L,9L,4L,3L,9L,1L,7L,2L,0L,7L,8L,9L,0L,0L,2L,7L,7L,3L,7L,4L,4L,8L,6L,2L,7L,5L,3L,3L,4L,7L,1L,9L,4L,8L,3L,8L,6L,4L,6L,3L,4L,1L,5L,1L,3L,8L,1L,7L,2L,9L,7L,0L,5L,1L,6L,2L,1L,7L,2L,9L,7L,4L,4L,8L,8L,5L,0L,2L,0L,1L,6L,7L,7L,8L,8L,7L,8L,9L,5L,9L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182527Inst : IEnumerable<long>
{
public static readonly long[] Value=A182527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182527.Bytes);
public long this[int i]=>Value[i];

public static A182527Inst Instance=new A182527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182528
{
public static readonly long[] Value={ 2L,8L,5L,8L,3L,8L,7L,5L,4L,3L,3L,2L,6L,4L,2L,7L,7L,3L,1L,6L,8L,9L,6L,7L,5L,8L,4L,1L,1L,8L,0L,9L,0L,5L,4L,2L,0L,1L,6L,4L,0L,9L,3L,4L,7L,6L,5L,4L,7L,8L,7L,1L,0L,1L,3L,1L,6L,1L,4L,9L,4L,8L,3L,7L,4L,8L,2L,3L,2L,2L,7L,4L,9L,5L,5L,6L,5L,9L,9L,2L,2L,1L,9L,4L,7L,6L,0L,0L,1L,0L,6L,5L,0L,5L,4L,2L,5L,6L,0L,4L,9L,1L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182528Inst : IEnumerable<long>
{
public static readonly long[] Value=A182528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182528.Bytes);
public long this[int i]=>Value[i];

public static A182528Inst Instance=new A182528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182529
{
public static readonly BigInteger[] Value={ 1L,1L,7L,100L,2438L,90246L,4702142L,327233880L,29271020760L,3268118467608L,445031112068232L,72541135526581536L,13936782476047959024UL,BigInteger.Parse("3115165518696599108976"),BigInteger.Parse("801181037747755210248432"),BigInteger.Parse("234835083029394312036638016"),BigInteger.Parse("77797056535321496989078410624") };
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
public class A182529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182529Inst Instance=new A182529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182530
{
public static readonly long[] Value={ 1L,0L,1L,3L,9L,33L,125L,484L,1933L,7883L,32656L,137127L,582353L,2496711L,10791823L,46978411L,205775845L,906291623L,4011033078L,17829430207L,79565177628L,356329040864L,1600966438342L,7214304154481L,32597284112813L,147655425387293L,670371400288210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182530Inst : IEnumerable<long>
{
public static readonly long[] Value=A182530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182530.Bytes);
public long this[int i]=>Value[i];

public static A182530Inst Instance=new A182530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182531
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,9L,12L,16L,20L,25L,30L,36L,42L,49L,56L,64L,72L,81L,90L,100L,110L,121L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182531Inst : IEnumerable<long>
{
public static readonly long[] Value=A182531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182531.Bytes);
public long this[int i]=>Value[i];

public static A182531Inst Instance=new A182531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182532
{
public static readonly long[] Value={ 825265L,6840001L,16778881L,47006785L,413631505L,490503601L,547652161L,1180398961L,1529544961L,1597009393L,2265650401L,2313774001L,2523947041L,2560104001L,2586927553L,3180632833L,3754483201L,4477793761L,5106068065L,5394826801L,6218177329L,6453043345L,8053562881L,10152380161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182532Inst : IEnumerable<long>
{
public static readonly long[] Value=A182532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182532.Bytes);
public long this[int i]=>Value[i];

public static A182532Inst Instance=new A182532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182533
{
public static readonly long[] Value={ 0L,1L,1L,-1L,2L,-1L,-1L,1L,1L,-1L,-1L,0L,2L,0L,-1L,-1L,-1L,2L,2L,-1L,-1L,-1L,-2L,1L,4L,1L,-2L,-1L,-1L,-3L,-1L,5L,5L,-1L,-3L,-1L,-1L,-4L,-4L,4L,10L,4L,-4L,-4L,-1L,-1L,-5L,-8L,0L,14L,14L,0L,-8L,-5L,-1L,-1L,-6L,-13L,-8L,14L,28L,14L,-8L,-13L,-6L,-1L,-1L,-7L,-19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182533Inst : IEnumerable<long>
{
public static readonly long[] Value=A182533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182533.Bytes);
public long this[int i]=>Value[i];

public static A182533Inst Instance=new A182533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182534
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,5L,4L,2L,6L,14L,10L,3L,4L,10L,42L,28L,6L,6L,5L,20L,132L,84L,14L,12L,6L,10L,35L,429L,264L,36L,28L,10L,12L,14L,70L,1430L,858L,99L,72L,20L,20L,14L,28L,126L,4862L,2860L,286L,198L,45L,40L,20L,28L,42L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182534Inst : IEnumerable<long>
{
public static readonly long[] Value=A182534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182534.Bytes);
public long this[int i]=>Value[i];

public static A182534Inst Instance=new A182534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182535
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,3L,2L,2L,3L,2L,3L,3L,2L,4L,3L,3L,4L,3L,3L,3L,4L,1L,2L,4L,3L,3L,4L,3L,4L,3L,4L,4L,2L,3L,2L,4L,3L,3L,3L,3L,3L,4L,5L,2L,5L,4L,5L,5L,1L,3L,2L,3L,3L,4L,3L,4L,4L,4L,4L,3L,5L,4L,5L,4L,4L,4L,5L,5L,5L,4L,5L,6L,2L,3L,4L,4L,3L,4L,3L,4L,5L,3L,4L,4L,5L,5L,4L,5L,3L,3L,3L,5L,6L,4L,5L,2L,3L,5L,4L,4L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182535Inst : IEnumerable<long>
{
public static readonly long[] Value=A182535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182535.Bytes);
public long this[int i]=>Value[i];

public static A182535Inst Instance=new A182535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182536
{
public static readonly long[] Value={ 0L,1L,3L,5L,10L,20L,36L,55L,27L,53L,56L,24L,44L,65L,123L,73L,66L,28L,112L,127L,35L,113L,104L,48L,112L,89L,67L,53L,146L,196L,116L,207L,219L,53L,272L,328L,124L,345L,331L,57L,410L,460L,128L,375L,547L,897L,464L,640L,896L,305L,739L,1029L,1818L,852L,1156L,2055L,3259L,1269L,2184L,3256L,1132L,2321L,3515L,1257L,2450L,3516L,1136L,2575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182536Inst : IEnumerable<long>
{
public static readonly long[] Value=A182536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182536.Bytes);
public long this[int i]=>Value[i];

public static A182536Inst Instance=new A182536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182537
{
public static readonly long[] Value={ 0L,1L,3L,5L,12L,12L,22L,33L,63L,103L,156L,264L,408L,669L,1075L,1733L,2792L,4540L,7350L,11877L,19207L,31095L,50312L,81384L,131704L,213097L,344779L,557885L,902676L,1460532L,2363198L,3823721L,6186887L,10010575L,16197492L,26208096L,42405552L,68613621L,111019147L,179632733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182537Inst : IEnumerable<long>
{
public static readonly long[] Value=A182537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182537.Bytes);
public long this[int i]=>Value[i];

public static A182537Inst Instance=new A182537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182538
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,12L,11L,16L,9L,10L,19L,14L,15L,28L,27L,40L,25L,26L,43L,30L,31L,52L,43L,56L,65L,26L,27L,54L,47L,68L,35L,32L,65L,34L,35L,70L,39L,44L,75L,48L,41L,74L,51L,46L,79L,60L,59L,104L,89L,122L,139L,62L,63L,116L,107L,152L,65L,58L,59L,118L,111L,164L,99L,96L,161L,98L,99L,166L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182538Inst : IEnumerable<long>
{
public static readonly long[] Value=A182538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182538.Bytes);
public long this[int i]=>Value[i];

public static A182538Inst Instance=new A182538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182539
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,4L,6L,6L,6L,8L,10L,18L,26L,28L,38L,54L,54L,72L,90L,90L,106L,124L,126L,150L,174L,192L,202L,202L,210L,220L,238L,238L,270L,304L,306L,338L,370L,372L,406L,438L,438L,472L,506L,514L,554L,556L,598L,630L,646L,696L,698L,746L,794L,828L,846L,902L,910L,912L,922L,938L,962L,1004L,1006L,1070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182539Inst : IEnumerable<long>
{
public static readonly long[] Value=A182539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182539.Bytes);
public long this[int i]=>Value[i];

public static A182539Inst Instance=new A182539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182540
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,1L,6L,44L,208L,912L,8016L,61952L,671248L,8160620L,87412258L,888954284L,12156253488L,180955852060L,2907927356451L,50317255621843L,802326797235038L,12251146829850324L,233309934271940028L,4243527581615332664L,BigInteger.Parse("79533825261873435894"),BigInteger.Parse("1602629887788636447221"),BigInteger.Parse("30450585799991840921483"),BigInteger.Parse("622433536382831426225696"),BigInteger.Parse("14891218890120375419560713"),BigInteger.Parse("344515231090957672408413959") };
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
public class A182540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182540Inst Instance=new A182540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182541
{
public static readonly BigInteger[] Value={ 1L,4L,19L,107L,702L,5274L,44712L,422568L,4407120L,50292720L,623471040L,8344624320L,119938250880L,1842662908800L,30136443724800L,522780938265600L,9587900602828800L,185371298306611200L,3768248516336640000L,BigInteger.Parse("80349669847157760000"),BigInteger.Parse("1793238207723325440000"),BigInteger.Parse("41806479141525288960000") };
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
public class A182541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182541Inst Instance=new A182541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182542
{
public static readonly long[] Value={ 1L,8L,46L,232L,1093L,4944L,21778L,94184L,401930L,1698160L,7119516L,29666704L,123012781L,508019104L,2091005866L,8582372584L,35141476126L,143595498544L,585720020356L,2385430111024L,9701814930466L,39411044641888L,159926316674356L,648348726966672L,2626193752638388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182542Inst : IEnumerable<long>
{
public static readonly long[] Value=A182542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182542.Bytes);
public long this[int i]=>Value[i];

public static A182542Inst Instance=new A182542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182543
{
public static readonly BigInteger[] Value={ 5L,8L,26L,112L,596L,3768L,27576L,229248L,2133792L,21983040L,248345280L,3052719360L,40563521280L,579385336320L,8852682585600L,144083913523200L,2488656760934400L,45465350973235200L,875935041046732800L,17749186274340864000UL,BigInteger.Parse("377355425576693760000") };
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
public class A182543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182543Inst Instance=new A182543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182544
{
public static readonly long[] Value={ 1L,2L,6L,22L,2L,90L,26L,4L,394L,232L,82L,12L,1806L,1776L,1062L,348L,48L,8558L,12546L,11118L,6022L,1836L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182544Inst : IEnumerable<long>
{
public static readonly long[] Value=A182544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182544.Bytes);
public long this[int i]=>Value[i];

public static A182544Inst Instance=new A182544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182545
{
public static readonly long[] Value={ 1L,1L,4L,1L,9L,9L,0L,4L,5L,9L,0L,1L,1L,6L,3L,8L,4L,8L,9L,9L,1L,2L,4L,6L,2L,0L,8L,8L,1L,2L,0L,1L,7L,7L,4L,2L,9L,5L,7L,1L,5L,5L,2L,3L,5L,6L,1L,5L,0L,1L,7L,2L,7L,0L,4L,1L,9L,5L,6L,5L,7L,7L,0L,2L,6L,8L,0L,6L,9L,2L,4L,6L,2L,5L,2L,2L,0L,0L,0L,5L,3L,4L,8L,4L,0L,7L,1L,9L,1L,1L,7L,3L,7L,6L,3L,0L,3L,9L,7L,8L,2L,6L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182545Inst : IEnumerable<long>
{
public static readonly long[] Value=A182545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182545.Bytes);
public long this[int i]=>Value[i];

public static A182545Inst Instance=new A182545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182546
{
public static readonly long[] Value={ 3L,2L,6L,4L,2L,5L,1L,3L,0L,2L,6L,3L,6L,4L,9L,6L,9L,0L,6L,7L,3L,1L,5L,3L,3L,6L,7L,8L,4L,3L,6L,2L,9L,4L,9L,0L,7L,8L,1L,4L,9L,1L,0L,3L,9L,3L,1L,5L,8L,8L,0L,5L,1L,8L,1L,8L,9L,6L,3L,2L,6L,6L,9L,3L,9L,9L,8L,2L,1L,2L,5L,6L,9L,4L,1L,5L,2L,0L,6L,3L,8L,1L,5L,5L,9L,0L,6L,4L,1L,6L,4L,3L,5L,6L,0L,9L,1L,4L,8L,5L,6L,1L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182546Inst : IEnumerable<long>
{
public static readonly long[] Value=A182546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182546.Bytes);
public long this[int i]=>Value[i];

public static A182546Inst Instance=new A182546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182547
{
public static readonly long[] Value={ 1L,9L,3L,6L,2L,5L,5L,6L,3L,3L,4L,1L,9L,6L,7L,4L,4L,6L,0L,0L,1L,3L,9L,3L,4L,6L,3L,8L,9L,4L,6L,3L,2L,9L,9L,6L,0L,2L,9L,1L,1L,6L,2L,0L,1L,4L,3L,0L,6L,5L,6L,5L,7L,9L,6L,3L,3L,3L,6L,2L,6L,6L,8L,2L,5L,1L,6L,6L,7L,2L,0L,5L,1L,1L,9L,9L,3L,7L,6L,7L,1L,0L,8L,5L,5L,2L,2L,7L,4L,8L,6L,7L,2L,4L,9L,9L,3L,8L,8L,5L,6L,3L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182547Inst : IEnumerable<long>
{
public static readonly long[] Value=A182547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182547.Bytes);
public long this[int i]=>Value[i];

public static A182547Inst Instance=new A182547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182548
{
public static readonly long[] Value={ 7L,2L,6L,5L,9L,0L,3L,7L,5L,4L,3L,6L,6L,0L,5L,6L,0L,3L,9L,9L,6L,0L,5L,1L,7L,1L,5L,5L,8L,3L,3L,2L,7L,8L,7L,5L,7L,0L,6L,5L,7L,2L,1L,5L,4L,6L,1L,5L,4L,3L,0L,6L,2L,3L,8L,2L,0L,8L,2L,0L,1L,8L,3L,1L,8L,9L,0L,7L,7L,6L,3L,1L,5L,4L,6L,5L,1L,2L,5L,7L,6L,1L,7L,9L,9L,6L,1L,1L,8L,4L,6L,4L,3L,9L,3L,4L,4L,1L,2L,1L,2L,8L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182548Inst : IEnumerable<long>
{
public static readonly long[] Value=A182548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182548.Bytes);
public long this[int i]=>Value[i];

public static A182548Inst Instance=new A182548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182549
{
public static readonly long[] Value={ 6L,3L,7L,3L,9L,0L,2L,1L,4L,2L,3L,0L,3L,3L,9L,4L,6L,5L,1L,6L,7L,1L,6L,4L,7L,9L,0L,8L,7L,7L,5L,2L,5L,1L,9L,8L,3L,1L,5L,5L,1L,4L,4L,6L,2L,1L,3L,1L,6L,8L,2L,7L,4L,1L,3L,4L,5L,5L,4L,2L,0L,9L,5L,2L,2L,1L,9L,1L,8L,1L,0L,2L,8L,7L,7L,7L,5L,0L,3L,8L,6L,2L,3L,4L,8L,1L,9L,7L,6L,4L,2L,8L,1L,3L,0L,4L,2L,7L,2L,5L,6L,7L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182549Inst : IEnumerable<long>
{
public static readonly long[] Value=A182549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182549.Bytes);
public long this[int i]=>Value[i];

public static A182549Inst Instance=new A182549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182550
{
public static readonly long[] Value={ 2L,0L,2L,8L,8L,7L,6L,0L,6L,5L,4L,6L,3L,2L,1L,3L,0L,8L,4L,0L,3L,6L,5L,6L,7L,9L,3L,4L,6L,6L,4L,2L,6L,8L,9L,6L,2L,8L,6L,0L,4L,8L,1L,5L,7L,2L,9L,6L,7L,7L,5L,3L,3L,0L,2L,2L,6L,5L,8L,0L,9L,2L,5L,1L,5L,5L,4L,6L,9L,8L,8L,1L,1L,1L,9L,3L,7L,4L,3L,2L,5L,3L,0L,9L,7L,1L,3L,7L,5L,1L,1L,6L,7L,3L,1L,3L,5L,1L,3L,4L,0L,0L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182550Inst : IEnumerable<long>
{
public static readonly long[] Value=A182550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182550.Bytes);
public long this[int i]=>Value[i];

public static A182550Inst Instance=new A182550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182551
{
public static readonly long[] Value={ 8L,1L,6L,9L,6L,0L,7L,5L,9L,4L,1L,9L,8L,9L,3L,0L,9L,8L,1L,3L,7L,6L,5L,5L,1L,4L,1L,0L,3L,0L,2L,7L,6L,9L,7L,6L,4L,4L,2L,1L,1L,1L,2L,0L,8L,7L,9L,2L,6L,3L,2L,3L,7L,0L,0L,8L,4L,2L,4L,7L,1L,0L,3L,8L,9L,6L,6L,7L,0L,7L,2L,3L,7L,4L,0L,7L,5L,5L,4L,9L,9L,5L,8L,9L,2L,6L,1L,1L,9L,4L,1L,8L,0L,7L,9L,3L,4L,2L,6L,6L,2L,2L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182551Inst : IEnumerable<long>
{
public static readonly long[] Value=A182551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182551.Bytes);
public long this[int i]=>Value[i];

public static A182551Inst Instance=new A182551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182552
{
public static readonly long[] Value={ 1L,1L,9L,3L,6L,6L,4L,4L,4L,0L,4L,0L,8L,5L,8L,7L,4L,4L,5L,5L,1L,2L,1L,9L,9L,3L,1L,4L,0L,0L,2L,6L,2L,1L,8L,2L,9L,7L,7L,3L,4L,5L,2L,8L,2L,0L,4L,7L,6L,8L,3L,7L,0L,0L,6L,0L,4L,9L,7L,7L,3L,9L,5L,1L,2L,5L,0L,2L,9L,2L,9L,4L,7L,4L,0L,7L,5L,9L,0L,8L,1L,2L,2L,8L,7L,3L,6L,5L,3L,8L,1L,1L,5L,8L,3L,6L,9L,7L,7L,9L,0L,5L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182552Inst : IEnumerable<long>
{
public static readonly long[] Value=A182552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182552.Bytes);
public long this[int i]=>Value[i];

public static A182552Inst Instance=new A182552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182553
{
public static readonly BigInteger[] Value={ 1L,11L,1243L,490043L,463370491L,860454250571L,2769263554592683L,14178247400433059003UL,BigInteger.Parse("108483732651999512059291"),BigInteger.Parse("1182804548772797481324575531"),BigInteger.Parse("17700419121823142496192223238923"),BigInteger.Parse("352709466470858225716888461028622363"),BigInteger.Parse("9127611521817307582541815420363992765691") };
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
public class A182553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182553Inst Instance=new A182553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182554
{
public static readonly long[] Value={ 323L,377L,442L,1891L,2737L,2834L,3827L,4181L,5777L,6479L,6601L,6721L,8149L,10877L,11663L,13201L,13981L,15251L,17119L,17711L,18407L,19043L,20999L,23407L,25877L,27323L,30889L,34561L,34943L,35207L,39203L,40501L,44099L,47519L,50183L,51841L,51983L,52701L,53663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182554Inst : IEnumerable<long>
{
public static readonly long[] Value=A182554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182554.Bytes);
public long this[int i]=>Value[i];

public static A182554Inst Instance=new A182554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182555
{
public static readonly long[] Value={ 1L,2L,5L,12L,29L,68L,158L,360L,813L,1812L,4010L,8792L,19170L,41512L,89500L,191952L,410237L,873140L,1853042L,3919608L,8271126L,17406072L,36556580L,76602032L,160240594L,334554248L,697462628L,1451633520L,3017426468L,6263171792L,12985655736L,26889935776L,55626815005L,114947516916L,237318165314L,489482593592L,1008787357902L,2077219057240L,4274204436052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182555Inst : IEnumerable<long>
{
public static readonly long[] Value=A182555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182555.Bytes);
public long this[int i]=>Value[i];

public static A182555Inst Instance=new A182555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182556
{
public static readonly long[] Value={ 1L,7L,45L,291L,2033L,10327L,55901L,377971L,2580161L,13329991L,68092909L,475337827L,3047910961L,21335374615L,108342024605L,611555770419L,4227169747201L,22855656310535L,114836769975597L,592467546841635L,4147130288467697L,24449879086004055L,171122765320764253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182556Inst : IEnumerable<long>
{
public static readonly long[] Value=A182556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182556.Bytes);
public long this[int i]=>Value[i];

public static A182556Inst Instance=new A182556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182557
{
public static readonly long[] Value={ 0L,1L,2L,5L,11L,24L,51L,106L,219L,448L,910L,1841L,3712L,7466L,14992L,30070L,60262L,120697L,241639L,483625L,967741L,1936177L,3873337L,7748065L,15498098L,30998979L,62001894L,124009355L,248026584L,496064303L,992144354L,1984310980L,3968653458L,7937351461L,15874765919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182557Inst : IEnumerable<long>
{
public static readonly long[] Value=A182557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182557.Bytes);
public long this[int i]=>Value[i];

public static A182557Inst Instance=new A182557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182558
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,9L,16L,29L,54L,103L,199L,388L,762L,1505L,2983L,5928L,11802L,23528L,46948L,93743L,187270L,374234L,748036L,1495461L,2990058L,5978894L,11956059L,23909673L,47815889L,95626889L,191246864L,382483950L,764954071L,1529888585L,3059749513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182558Inst : IEnumerable<long>
{
public static readonly long[] Value=A182558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182558.Bytes);
public long this[int i]=>Value[i];

public static A182558Inst Instance=new A182558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182559
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,7L,8L,16L,20L,36L,46L,78L,100L,166L,212L,346L,442L,713L,910L,1456L,1858L,2955L,3770L,5971L,7617L,12029L,15343L,24181L,30841L,48537L,61902L,97322L,124115L,194996L,248671L,390490L,497966L,781685L,996816L,1564368L,1994882L,3130148L,3991533L,6262293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182559Inst : IEnumerable<long>
{
public static readonly long[] Value=A182559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182559.Bytes);
public long this[int i]=>Value[i];

public static A182559Inst Instance=new A182559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182560
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,0L,7L,8L,9L,2L,11L,14L,7L,8L,15L,24L,25L,10L,27L,30L,15L,24L,31L,0L,25L,26L,3L,30L,31L,0L,31L,32L,33L,2L,35L,38L,7L,32L,39L,8L,41L,34L,11L,46L,39L,8L,47L,56L,25L,42L,59L,30L,47L,56L,31L,32L,57L,26L,35L,62L,31L,32L,63L,96L,97L,34L,99L,102L,39L,96L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182560Inst : IEnumerable<long>
{
public static readonly long[] Value=A182560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182560.Bytes);
public long this[int i]=>Value[i];

public static A182560Inst Instance=new A182560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182561
{
public static readonly long[] Value={ 1L,4L,7L,16L,45L,74L,166L,529L,866L,1993L,4560L,9907L,27425L,62894L,161134L,386007L,1308165L,2363223L,7190239L,17844411L,54259731L,90564740L,308061971L,487568736L,1422102892L,3573737940L,8516241133L,22686128280L,77770540116L,144783290133L,365331892456L,928427248701L,2354811032695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182561Inst : IEnumerable<long>
{
public static readonly long[] Value=A182561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182561.Bytes);
public long this[int i]=>Value[i];

public static A182561Inst Instance=new A182561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182562
{
public static readonly BigInteger[] Value={ 2L,16L,288L,11664L,1458000L,506250000L,414720000000L,869730877440000L,5045702916833280000L,BigInteger.Parse("77297454895962562560000"),BigInteger.Parse("3017525202366485003182080000"),BigInteger.Parse("307389127582207654481154908160000"),BigInteger.Parse("83016370640108703579427655610531840000"),BigInteger.Parse("58770343311359208383258439665073059266560000") };
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
public class A182562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182562Inst Instance=new A182562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182563
{
public static readonly BigInteger[] Value={ 1L,6L,70L,1289L,33864L,1148760L,47700972L,2344465830L,133055587660L,8559364525414L,615266768106190L,48861588247978827L,4247584874013608724L,BigInteger.Parse("401107335066453376830"),BigInteger.Parse("40880928693752664368224") };
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
public class A182563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182563Inst Instance=new A182563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182564
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,5L,8L,11L,16L,23L,34L,50L,74L,111L,166L,250L,376L,574L,871L,1329L,2033L,3120L,4794L,7396L,11425L,17688L,27426L,42612L,66317L,103298L,161207L,251757L,393790L,616645L,966507L,1516410L,2381429L,3743010L,5888201L,9269519L,14604028L,23023555L,36322186L,57337078L,90565070L,143130478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182564Inst : IEnumerable<long>
{
public static readonly long[] Value=A182564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182564.Bytes);
public long this[int i]=>Value[i];

public static A182564Inst Instance=new A182564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182565
{
public static readonly long[] Value={ 4L,4L,4L,2L,4L,7L,5L,2L,0L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182565Inst : IEnumerable<long>
{
public static readonly long[] Value=A182565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182565.Bytes);
public long this[int i]=>Value[i];

public static A182565Inst Instance=new A182565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182566
{
public static readonly long[] Value={ 1L,6L,3L,8L,0L,5L,5L,0L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182566Inst : IEnumerable<long>
{
public static readonly long[] Value=A182566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182566.Bytes);
public long this[int i]=>Value[i];

public static A182566Inst Instance=new A182566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182567
{
public static readonly long[] Value={ 5L,0L,3L,8L,7L,8L,4L,8L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182567Inst : IEnumerable<long>
{
public static readonly long[] Value=A182567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182567.Bytes);
public long this[int i]=>Value[i];

public static A182567Inst Instance=new A182567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182568
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,4L,6L,8L,12L,16L,20L,24L,30L,36L,42L,48L,56L,64L,72L,80L,90L,100L,110L,120L,132L,144L,156L,168L,182L,196L,210L,224L,240L,256L,272L,288L,306L,324L,342L,360L,380L,400L,420L,440L,462L,484L,506L,528L,552L,576L,600L,624L,650L,676L,702L,728L,756L,784L,812L,840L,870L,900L,930L,960L,992L,1024L,1056L,1088L,1122L,1156L,1190L,1224L,1260L,1296L,1332L,1368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182568Inst : IEnumerable<long>
{
public static readonly long[] Value=A182568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182568.Bytes);
public long this[int i]=>Value[i];

public static A182568Inst Instance=new A182568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182569
{
public static readonly long[] Value={ 7L,11L,23L,29L,37L,47L,97L,149L,157L,199L,241L,379L,521L,613L,631L,1021L,1741L,2207L,3571L,9349L,10949L,11933L,17713L,46381L,46457L,46601L,50549L,75169L,196439L,203183L,214129L,560597L,832129L,2178343L,3010349L,3531343L,14930441L,15444581L,16276621L,24157961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182569Inst : IEnumerable<long>
{
public static readonly long[] Value=A182569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182569.Bytes);
public long this[int i]=>Value[i];

public static A182569Inst Instance=new A182569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182570
{
public static readonly long[] Value={ 17L,19L,31L,41L,43L,59L,61L,71L,73L,79L,103L,107L,113L,131L,151L,167L,173L,179L,181L,191L,239L,251L,257L,269L,293L,383L,401L,419L,433L,467L,479L,487L,523L,617L,619L,647L,673L,701L,733L,757L,809L,877L,991L,997L,1009L,1013L,1063L,1097L,1223L,1367L,1453L,1601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182570Inst : IEnumerable<long>
{
public static readonly long[] Value=A182570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182570.Bytes);
public long this[int i]=>Value[i];

public static A182570Inst Instance=new A182570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182571
{
public static readonly long[] Value={ 53L,67L,83L,101L,109L,127L,137L,139L,163L,193L,223L,263L,271L,277L,281L,283L,311L,317L,331L,337L,359L,389L,397L,409L,421L,439L,443L,461L,503L,547L,557L,563L,577L,641L,653L,659L,683L,691L,709L,761L,769L,811L,853L,857L,859L,911L,919L,937L,953L,1019L,1031L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182571Inst : IEnumerable<long>
{
public static readonly long[] Value=A182571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182571.Bytes);
public long this[int i]=>Value[i];

public static A182571Inst Instance=new A182571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182572
{
public static readonly long[] Value={ 197L,211L,227L,229L,307L,313L,347L,349L,353L,367L,431L,449L,457L,463L,491L,509L,541L,569L,571L,587L,599L,643L,661L,677L,719L,727L,739L,743L,751L,773L,797L,823L,827L,863L,881L,883L,887L,907L,941L,947L,967L,971L,1033L,1061L,1069L,1093L,1103L,1117L,1151L,1163L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182572Inst : IEnumerable<long>
{
public static readonly long[] Value=A182572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182572.Bytes);
public long this[int i]=>Value[i];

public static A182572Inst Instance=new A182572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182573
{
public static readonly long[] Value={ 373L,499L,593L,601L,607L,787L,821L,829L,839L,929L,977L,1109L,1129L,1213L,1217L,1303L,1307L,1321L,1361L,1439L,1447L,1451L,1481L,1483L,1493L,1549L,1553L,1567L,1579L,1787L,1823L,1913L,1931L,1949L,1951L,2027L,2083L,2111L,2113L,2137L,2143L,2161L,2179L,2281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182573Inst : IEnumerable<long>
{
public static readonly long[] Value=A182573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182573.Bytes);
public long this[int i]=>Value[i];

public static A182573Inst Instance=new A182573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182574
{
public static readonly long[] Value={ 983L,1499L,1559L,1583L,1973L,2203L,2347L,2423L,2437L,2473L,2549L,2557L,2579L,2939L,2957L,3049L,3083L,3187L,3191L,3329L,3371L,3389L,3391L,3413L,3499L,3533L,3541L,3547L,3557L,3559L,3659L,3761L,3769L,3797L,3889L,3923L,3931L,3943L,4001L,4049L,4057L,4111L,4133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182574Inst : IEnumerable<long>
{
public static readonly long[] Value=A182574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182574.Bytes);
public long this[int i]=>Value[i];

public static A182574Inst Instance=new A182574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182575
{
public static readonly long[] Value={ 2L,7L,17L,19L,53L,373L,983L,6709L,6761L,6763L,17333L,17707L,43783L,103681L,317789L,785671L,2177321L,5581493L,38770357L,39070457L,1836305137L,10749957121L,12586147631L,12586251313L,32951279111L,86252640919L,86267571127L,86267571263L,213265164691L,225845730829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182575Inst : IEnumerable<long>
{
public static readonly long[] Value=A182575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182575.Bytes);
public long this[int i]=>Value[i];

public static A182575Inst Instance=new A182575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182576
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,2L,3L,3L,3L,3L,4L,1L,4L,4L,4L,3L,3L,3L,4L,3L,4L,4L,3L,3L,3L,4L,5L,5L,6L,4L,5L,3L,3L,5L,3L,4L,3L,6L,4L,2L,4L,4L,5L,6L,6L,7L,3L,4L,6L,5L,4L,5L,5L,5L,5L,6L,3L,5L,7L,4L,5L,6L,4L,6L,4L,5L,6L,5L,6L,6L,6L,4L,6L,7L,7L,8L,5L,6L,7L,6L,6L,7L,4L,4L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182576Inst : IEnumerable<long>
{
public static readonly long[] Value=A182576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182576.Bytes);
public long this[int i]=>Value[i];

public static A182576Inst Instance=new A182576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182577
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,3L,5L,6L,9L,8L,11L,11L,11L,16L,17L,17L,18L,23L,23L,28L,31L,33L,27L,33L,29L,40L,37L,42L,42L,41L,44L,47L,44L,53L,56L,57L,50L,64L,55L,59L,68L,63L,72L,70L,61L,69L,85L,80L,83L,87L,97L,98L,101L,87L,91L,100L,102L,114L,108L,116L,109L,117L,117L,113L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182577Inst : IEnumerable<long>
{
public static readonly long[] Value=A182577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182577.Bytes);
public long this[int i]=>Value[i];

public static A182577Inst Instance=new A182577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182578
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,6L,3L,10L,13L,12L,16L,15L,20L,24L,20L,30L,25L,31L,26L,33L,33L,31L,34L,42L,49L,49L,53L,55L,56L,55L,58L,64L,64L,67L,73L,78L,70L,76L,77L,75L,89L,83L,92L,90L,106L,99L,100L,99L,107L,116L,107L,115L,125L,125L,122L,119L,127L,137L,127L,138L,155L,156L,153L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182578Inst : IEnumerable<long>
{
public static readonly long[] Value=A182578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182578.Bytes);
public long this[int i]=>Value[i];

public static A182578Inst Instance=new A182578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182579
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,4L,3L,2L,1L,1L,5L,4L,5L,2L,1L,1L,6L,5L,9L,5L,2L,1L,1L,7L,6L,14L,9L,7L,2L,1L,1L,8L,7L,20L,14L,16L,7L,2L,1L,1L,9L,8L,27L,20L,30L,16L,9L,2L,1L,1L,10L,9L,35L,27L,50L,30L,25L,9L,2L,1L,1L,11L,10L,44L,35L,77L,50L,55L,25L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182579Inst : IEnumerable<long>
{
public static readonly long[] Value=A182579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182579.Bytes);
public long this[int i]=>Value[i];

public static A182579Inst Instance=new A182579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182580
{
public static readonly long[] Value={ 0L,1L,2L,5L,11L,27L,29L,46L,76L,167L,133L,348L,521L,1160L,1364L,3005L,3571L,9348L,9349L,20820L,24476L,64062L,64079L,123651L,167761L,439203L,439204L,1149850L,1149851L,3010348L,3010349L,7881195L,7881196L,20633238L,20633239L,54018520L,54018521L,141422323L,141422324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182580Inst : IEnumerable<long>
{
public static readonly long[] Value=A182580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182580.Bytes);
public long this[int i]=>Value[i];

public static A182580Inst Instance=new A182580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182581
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182581Inst : IEnumerable<long>
{
public static readonly long[] Value=A182581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182581.Bytes);
public long this[int i]=>Value[i];

public static A182581Inst Instance=new A182581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182582
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182582Inst : IEnumerable<long>
{
public static readonly long[] Value=A182582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182582.Bytes);
public long this[int i]=>Value[i];

public static A182582Inst Instance=new A182582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182583
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,23L,29L,31L,43L,53L,61L,71L,73L,89L,109L,127L,139L,149L,163L,229L,257L,263L,271L,277L,307L,331L,337L,383L,389L,419L,433L,449L,457L,463L,479L,523L,541L,607L,631L,643L,647L,653L,661L,673L,691L,727L,761L,769L,797L,809L,821L,823L,829L,859L,881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182583Inst : IEnumerable<long>
{
public static readonly long[] Value=A182583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182583.Bytes);
public long this[int i]=>Value[i];

public static A182583Inst Instance=new A182583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182584
{
public static readonly long[] Value={ 1L,1L,4L,5L,20L,27L,112L,156L,660L,935L,4004L,5733L,24752L,35700L,155040L,224808L,980628L,1427679L,6249100L,9126975L,40060020L,58659315L,258048960L,378658800L,1668903600L,2453288292L,10829900592L,15944020316L,70480305440L,103897691640L,459823234112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182584Inst : IEnumerable<long>
{
public static readonly long[] Value=A182584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182584.Bytes);
public long this[int i]=>Value[i];

public static A182584Inst Instance=new A182584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182585
{
public static readonly long[] Value={ 34L,169L,194L,985L,4181L,9077L,14701L,51641L,135137L,294685L,499393L,646018L,925765L,1136689L,1346269L,2012674L,6625109L,8399329L,9647009L,11485154L,16964653L,21531778L,43484701L,48928105L,111242465L,137295677L,144059117L,165580141L,225058681L,253191266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182585Inst : IEnumerable<long>
{
public static readonly long[] Value=A182585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182585.Bytes);
public long this[int i]=>Value[i];

public static A182585Inst Instance=new A182585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182586
{
public static readonly long[] Value={ 0L,2L,6L,8L,7L,3L,5L,4L,14L,16L,19L,21L,20L,9L,25L,10L,29L,31L,11L,13L,12L,33L,37L,40L,15L,41L,45L,47L,17L,50L,18L,49L,22L,55L,58L,60L,23L,63L,61L,24L,26L,69L,71L,70L,27L,76L,28L,77L,32L,30L,82L,84L,87L,89L,34L,92L,90L,35L,97L,36L,39L,99L,38L,103L,105L,108L,110L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182586Inst : IEnumerable<long>
{
public static readonly long[] Value=A182586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182586.Bytes);
public long this[int i]=>Value[i];

public static A182586Inst Instance=new A182586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182587
{
public static readonly long[] Value={ 2L,7L,1L,8L,3L,0L,2L,6L,6L,8L,1L,7L,5L,3L,4L,8L,7L,0L,6L,2L,4L,4L,8L,5L,9L,4L,3L,5L,5L,9L,3L,3L,9L,5L,9L,7L,9L,9L,7L,0L,8L,1L,8L,2L,9L,7L,4L,8L,8L,2L,7L,3L,5L,2L,5L,4L,5L,4L,6L,2L,2L,9L,6L,7L,8L,4L,4L,7L,7L,3L,2L,5L,4L,2L,4L,5L,8L,9L,3L,1L,2L,2L,4L,5L,1L,2L,7L,0L,0L,5L,0L,7L,0L,9L,8L,2L,0L,2L,3L,6L,7L,0L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182587Inst : IEnumerable<long>
{
public static readonly long[] Value=A182587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182587.Bytes);
public long this[int i]=>Value[i];

public static A182587Inst Instance=new A182587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182588
{
public static readonly long[] Value={ 33L,158L,428L,437L,513L,611L,843L,1016L,1184L,1328L,1405L,1472L,2252L,2427L,2669L,2763L,3272L,4304L,4568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182588Inst : IEnumerable<long>
{
public static readonly long[] Value=A182588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182588.Bytes);
public long this[int i]=>Value[i];

public static A182588Inst Instance=new A182588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182589
{
public static readonly BigInteger[] Value={ 8L,24L,216L,2376L,381672L,5163480L,1010595960L,14467313448L,3059511345864L,9938978525015640L,148764065249108232L,BigInteger.Parse("510526106263606993560"),BigInteger.Parse("117943982401534505983800"),BigInteger.Parse("1799331452450089752726504"),BigInteger.Parse("421426396352475869646014856"),BigInteger.Parse("1530747894615220749248821030680") };
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
public class A182589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182589Inst Instance=new A182589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182590
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,1L,2L,3L,2L,1L,2L,2L,1L,2L,3L,3L,1L,2L,1L,2L,2L,3L,2L,2L,3L,2L,2L,4L,3L,3L,2L,3L,3L,3L,1L,4L,4L,3L,3L,2L,3L,2L,3L,5L,2L,2L,1L,2L,3L,4L,2L,3L,2L,3L,1L,4L,3L,3L,3L,4L,5L,3L,1L,5L,3L,2L,3L,4L,2L,3L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182590Inst : IEnumerable<long>
{
public static readonly long[] Value=A182590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182590.Bytes);
public long this[int i]=>Value[i];

public static A182590Inst Instance=new A182590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182591
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,1L,1L,3L,2L,2L,1L,2L,1L,2L,2L,3L,2L,2L,2L,4L,2L,2L,2L,2L,4L,3L,3L,4L,3L,2L,1L,5L,2L,4L,2L,4L,4L,2L,3L,5L,2L,3L,3L,3L,4L,5L,5L,4L,2L,4L,3L,6L,3L,2L,5L,6L,2L,3L,2L,5L,2L,2L,4L,5L,3L,3L,2L,3L,1L,4L,4L,5L,3L,5L,4L,9L,3L,3L,3L,5L,4L,5L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182591Inst : IEnumerable<long>
{
public static readonly long[] Value=A182591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182591.Bytes);
public long this[int i]=>Value[i];

public static A182591Inst Instance=new A182591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182592
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,2L,3L,1L,2L,1L,3L,3L,2L,2L,3L,3L,3L,3L,4L,2L,3L,4L,3L,4L,3L,3L,5L,2L,3L,3L,4L,6L,3L,3L,6L,3L,5L,2L,6L,2L,3L,4L,4L,1L,2L,1L,6L,5L,3L,3L,7L,5L,3L,2L,5L,2L,7L,3L,5L,6L,4L,4L,7L,5L,8L,6L,8L,2L,3L,3L,6L,5L,5L,3L,7L,3L,4L,2L,6L,3L,3L,3L,6L,4L,4L,6L,5L,3L,2L,5L,4L,7L,5L,3L,4L,5L,7L,3L,10L,4L,5L,8L,6L,5L,2L,4L,7L,3L,6L,8L,5L,10L,2L,3L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182592Inst : IEnumerable<long>
{
public static readonly long[] Value=A182592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182592.Bytes);
public long this[int i]=>Value[i];

public static A182592Inst Instance=new A182592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182593
{
public static readonly long[] Value={ 2L,1L,2L,1L,3L,1L,1L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,2L,3L,3L,3L,4L,3L,2L,5L,2L,4L,1L,4L,2L,3L,2L,6L,3L,5L,5L,4L,4L,3L,2L,4L,4L,4L,4L,6L,3L,5L,3L,4L,5L,6L,3L,5L,2L,5L,3L,4L,3L,7L,3L,3L,4L,4L,5L,6L,2L,4L,4L,8L,1L,7L,4L,8L,5L,4L,2L,9L,3L,5L,4L,5L,7L,4L,3L,5L,5L,4L,3L,6L,2L,6L,5L,4L,7L,8L,5L,6L,6L,7L,2L,11L,4L,7L,6L,7L,3L,6L,2L,6L,5L,6L,4L,6L,7L,4L,4L,4L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182593Inst : IEnumerable<long>
{
public static readonly long[] Value=A182593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182593.Bytes);
public long this[int i]=>Value[i];

public static A182593Inst Instance=new A182593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182594
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,3L,3L,2L,2L,1L,4L,2L,3L,2L,4L,2L,3L,1L,4L,3L,4L,3L,3L,4L,4L,3L,3L,3L,2L,4L,3L,3L,3L,3L,4L,4L,5L,3L,4L,2L,4L,2L,4L,2L,3L,4L,4L,5L,5L,3L,5L,1L,6L,3L,4L,4L,5L,4L,6L,2L,3L,6L,6L,4L,6L,3L,8L,2L,5L,5L,5L,3L,2L,3L,7L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182594Inst : IEnumerable<long>
{
public static readonly long[] Value=A182594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182594.Bytes);
public long this[int i]=>Value[i];

public static A182594Inst Instance=new A182594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182595
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,3L,1L,1L,2L,2L,1L,2L,2L,3L,2L,2L,2L,3L,2L,1L,2L,2L,1L,2L,1L,4L,2L,2L,1L,3L,3L,2L,2L,3L,2L,2L,3L,2L,3L,3L,1L,4L,2L,2L,4L,4L,2L,2L,2L,2L,2L,2L,2L,4L,2L,3L,3L,5L,1L,2L,3L,4L,5L,3L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182595Inst : IEnumerable<long>
{
public static readonly long[] Value=A182595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182595.Bytes);
public long this[int i]=>Value[i];

public static A182595Inst Instance=new A182595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182596
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,2L,3L,1L,3L,2L,2L,2L,3L,2L,1L,4L,2L,2L,2L,2L,3L,1L,2L,1L,4L,2L,1L,2L,3L,2L,5L,2L,2L,2L,1L,3L,3L,2L,3L,2L,2L,3L,6L,2L,2L,2L,3L,3L,5L,2L,2L,5L,2L,3L,5L,1L,2L,1L,2L,3L,6L,3L,5L,3L,2L,3L,6L,4L,1L,2L,3L,4L,7L,3L,4L,5L,4L,5L,8L,3L,3L,3L,6L,2L,6L,2L,4L,4L,3L,5L,6L,3L,2L,5L,3L,4L,6L,4L,3L,7L,4L,4L,7L,7L,3L,4L,3L,3L,6L,1L,2L,5L,4L,4L,6L,2L,3L,4L,4L,5L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182596Inst : IEnumerable<long>
{
public static readonly long[] Value=A182596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182596.Bytes);
public long this[int i]=>Value[i];

public static A182596Inst Instance=new A182596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182597
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,1L,2L,3L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L,3L,1L,2L,3L,3L,3L,4L,4L,2L,3L,3L,2L,4L,2L,4L,3L,4L,1L,1L,1L,3L,4L,3L,3L,5L,4L,3L,1L,2L,4L,3L,1L,4L,4L,4L,2L,6L,3L,4L,2L,1L,5L,4L,3L,3L,2L,3L,3L,5L,3L,2L,4L,4L,4L,5L,4L,3L,4L,6L,3L,4L,4L,3L,3L,2L,2L,4L,4L,4L,4L,5L,4L,1L,4L,1L,7L,1L,5L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182597Inst : IEnumerable<long>
{
public static readonly long[] Value=A182597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182597.Bytes);
public long this[int i]=>Value[i];

public static A182597Inst Instance=new A182597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182598
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,2L,1L,2L,1L,2L,3L,2L,2L,3L,2L,4L,2L,2L,1L,3L,2L,2L,2L,3L,3L,4L,3L,6L,1L,3L,4L,2L,5L,5L,3L,2L,5L,4L,3L,4L,1L,2L,2L,4L,1L,5L,3L,3L,6L,3L,4L,5L,4L,4L,3L,2L,1L,3L,2L,1L,3L,3L,3L,8L,4L,4L,2L,4L,3L,1L,5L,3L,5L,4L,1L,7L,5L,3L,3L,3L,4L,5L,3L,4L,7L,2L,2L,7L,5L,3L,2L,4L,5L,2L,3L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182598Inst : IEnumerable<long>
{
public static readonly long[] Value=A182598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182598.Bytes);
public long this[int i]=>Value[i];

public static A182598Inst Instance=new A182598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182599
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,4L,2L,1L,1L,2L,1L,2L,2L,3L,3L,3L,1L,1L,1L,2L,1L,4L,1L,4L,3L,3L,2L,3L,5L,4L,2L,1L,3L,3L,4L,2L,7L,3L,4L,4L,1L,3L,7L,4L,4L,3L,4L,3L,6L,5L,5L,4L,4L,3L,1L,3L,8L,3L,2L,5L,3L,3L,4L,4L,2L,5L,3L,1L,5L,5L,5L,4L,4L,3L,4L,3L,2L,5L,3L,3L,4L,2L,5L,4L,5L,4L,5L,3L,6L,6L,3L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182599Inst : IEnumerable<long>
{
public static readonly long[] Value=A182599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182599.Bytes);
public long this[int i]=>Value[i];

public static A182599Inst Instance=new A182599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182600
{
public static readonly long[] Value={ 1L,3L,1L,3L,5L,5L,13L,3L,35L,47L,5L,221L,71L,1L,15L,59L,59L,1L,2399L,1751L,663L,3923L,365L,4753L,11129L,5195L,5241L,1511L,13321L,31005L,23071L,25109L,18069L,53015L,196271L,36401L,156259L,3647L,11021L,326805L,118379L,235709L,350399L,167051L,165661L,935631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182600Inst : IEnumerable<long>
{
public static readonly long[] Value=A182600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182600.Bytes);
public long this[int i]=>Value[i];

public static A182600Inst Instance=new A182600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182601
{
public static readonly long[] Value={ 6L,8L,8L,18L,18L,30L,30L,30L,30L,30L,30L,30L,30L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,84L,84L,84L,84L,84L,84L,84L,84L,84L,84L,84L,84L,138L,138L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182601Inst : IEnumerable<long>
{
public static readonly long[] Value=A182601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182601.Bytes);
public long this[int i]=>Value[i];

public static A182601Inst Instance=new A182601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182602
{
public static readonly long[] Value={ 8L,21L,21L,2584L,2584L,832040L,832040L,832040L,832040L,832040L,832040L,832040L,832040L,4807526976L,4807526976L,4807526976L,4807526976L,4807526976L,4807526976L,4807526976L,4807526976L,4807526976L,4807526976L,4807526976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182602Inst : IEnumerable<long>
{
public static readonly long[] Value=A182602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182602.Bytes);
public long this[int i]=>Value[i];

public static A182602Inst Instance=new A182602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182603
{
public static readonly long[] Value={ 1L,7L,63L,504L,4088L,32697L,262080L,2096577L,16776648L,134213128L,1073737224L,8589897288L,68719439943L,549755515008L,4398046212672L,35184369697407L,281474974319672L,2251799794521144L,18014398490350584L,144115187922510840L,1152921504453534648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182603Inst : IEnumerable<long>
{
public static readonly long[] Value=A182603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182603.Bytes);
public long this[int i]=>Value[i];

public static A182603Inst Instance=new A182603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182604
{
public static readonly ulong[] Value={ 1L,8L,80L,720L,6552L,58960L,531360L,4782160L,43045920L,387413208L,3486777120L,31380993360L,282429470960L,2541865231440L,22876791858720L,205891126722080L,1853020183479912L,16677181651254480L,150094635248646000L,1350851717237225040L,12157665458621220720UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182604Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A182604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182604.Bytes);
public ulong this[int i]=>Value[i];

public static A182604Inst Instance=new A182604Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}