using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A279237
{
public static readonly long[] Value={ 2L,11L,3L,20L,101L,12L,1001L,110L,4L,21L,102L,1010L,10001L,13L,200L,100001L,30L,1002L,111L,5L,10010L,1000001L,1100L,22L,10000001L,100010L,103L,1011L,10002L,120L,100000001L,14L,2000L,201L,1000010L,100002L,31L,10100L,1003L,10000010L,1000000001L,112L,10000000001L,1020L,6L,100100L,10011L,1000002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279237Inst : IEnumerable<long>
{
public static readonly long[] Value=A279237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279237.Bytes);
public long this[int i]=>Value[i];

public static A279237Inst Instance=new A279237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279238
{
public static readonly BigInteger[] Value={ 1L,1L,-11L,-343L,871L,54871L,-12359L,-102902159L,-137687549L,344971369L,20000206271L,-34379966953693L,-452834430450401L,18163626705916771L,951418549566510481L,BigInteger.Parse("-381881231033010506527"),BigInteger.Parse("-4252976361755938012709"),BigInteger.Parse("-218740547087902859463611") };
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
public class A279238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279238Inst Instance=new A279238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279239
{
public static readonly BigInteger[] Value={ 2L,8L,48L,5760L,80640L,14515200L,958003200L,1394852659200L,41845579776000L,522642751488000L,442345819668480000L,BigInteger.Parse("8992005822220861440000"),BigInteger.Parse("1240896803466478878720000"),BigInteger.Parse("1613165844506422542336000000"),BigInteger.Parse("609776689223427721003008000000") };
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
public class A279239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279239Inst Instance=new A279239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279240
{
public static readonly BigInteger[] Value={ 1L,4L,24L,2880L,40320L,7257600L,479001600L,697426329600L,20922789888000L,261321375744000L,221172909834240000L,BigInteger.Parse("4496002911110430720000"),BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("806582922253211271168000000"),BigInteger.Parse("304888344611713860501504000000"),BigInteger.Parse("4244045756995056938180935680000000") };
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
public class A279240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279240Inst Instance=new A279240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279241
{
public static readonly long[] Value={ 1601L,1447L,1301L,1163L,1033L,911L,797L,691L,593L,503L,421L,347L,281L,223L,173L,131L,97L,71L,53L,43L,41L,47L,61L,83L,113L,151L,197L,251L,313L,383L,461L,547L,641L,743L,853L,971L,1097L,1231L,1373L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279241Inst : IEnumerable<long>
{
public static readonly long[] Value=A279241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279241.Bytes);
public long this[int i]=>Value[i];

public static A279241Inst Instance=new A279241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279242
{
public static readonly BigInteger[] Value={ 0L,1L,1L,-1L,-103L,29L,8671L,15361L,-417031L,-17815069L,1361877889L,21067460461L,-679886788111L,-31579084114577L,354886157315257L,2898608704594607L,-569165778828429437L,BigInteger.Parse("-167337689371017456229"),BigInteger.Parse("434029941439492698221"),BigInteger.Parse("33444404529041130465319") };
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
public class A279242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279242Inst Instance=new A279242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279243
{
public static readonly BigInteger[] Value={ 1L,2L,8L,16L,5760L,26880L,14515200L,958003200L,55794106368L,41845579776000L,25609494822912000L,4865804016353280000L,BigInteger.Parse("2997335274073620480000"),BigInteger.Parse("1240896803466478878720000"),BigInteger.Parse("537721948168807514112000000"),BigInteger.Parse("26512029966235987869696000000") };
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
public class A279243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279243Inst Instance=new A279243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279244
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,14L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,57L,58L,59L,61L,62L,63L,65L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,79L,81L,82L,83L,85L,86L,87L,89L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279244Inst : IEnumerable<long>
{
public static readonly long[] Value=A279244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279244.Bytes);
public long this[int i]=>Value[i];

public static A279244Inst Instance=new A279244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279245
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,20L,40L,64L,128L,208L,416L,672L,1344L,2176L,4352L,7040L,14080L,22784L,45568L,73728L,147456L,238592L,477184L,772096L,1544192L,2498560L,4997120L,8085504L,16171008L,26165248L,52330496L,84672512L,169345024L,274006016L,548012032L,886702080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279245Inst : IEnumerable<long>
{
public static readonly long[] Value=A279245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279245.Bytes);
public long this[int i]=>Value[i];

public static A279245Inst Instance=new A279245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279246
{
public static readonly ulong[] Value={ 1L,11L,100L,1100L,10100L,110110L,1010000L,11011010L,101000000L,1101100000L,10100000000L,110110101000L,1010000000000L,11011000001010L,101000000000000L,1101101010100000L,10100000001000000L,110110000011101000L,1010000000100000000L,11011010101110001010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279246Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279246.Bytes);
public ulong this[int i]=>Value[i];

public static A279246Inst Instance=new A279246Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279247
{
public static readonly long[] Value={ 1L,11L,1L,11L,101L,11011L,101L,1011011L,101L,11011L,101L,101011011L,101L,1010000011011L,101L,10101011011L,10000000101L,101110000011011L,10000000101L,1010001110101011011L,101L,10000011011L,100000000000101L,1100010101011011L,1010100010000000101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279247Inst : IEnumerable<long>
{
public static readonly long[] Value=A279247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279247.Bytes);
public long this[int i]=>Value[i];

public static A279247Inst Instance=new A279247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279248
{
public static readonly long[] Value={ 1L,3L,4L,12L,20L,54L,80L,218L,320L,864L,1280L,3496L,5120L,13834L,20480L,55968L,81984L,221416L,327936L,895882L,1310720L,3540992L,5243136L,14328576L,20989248L,56682304L,83952976L,229345264L,335548420L,906500620L,1342263316L,3668171454L,5373186048L,14510643200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279248Inst : IEnumerable<long>
{
public static readonly long[] Value=A279248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279248.Bytes);
public long this[int i]=>Value[i];

public static A279248Inst Instance=new A279248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279249
{
public static readonly long[] Value={ 1L,3L,1L,3L,5L,27L,5L,91L,5L,27L,5L,347L,5L,5147L,5L,1371L,1029L,23579L,1029L,335195L,5L,1051L,16389L,50523L,345093L,760859L,5571589L,16653659L,67174405L,202769435L,335888389L,2103166299L,1328133L,7183387L,21300229L,399121755L,4296343557L,13965853723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279249Inst : IEnumerable<long>
{
public static readonly long[] Value=A279249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279249.Bytes);
public long this[int i]=>Value[i];

public static A279249Inst Instance=new A279249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279250
{
public static readonly long[] Value={ 1L,1L,101L,111L,10100L,11101L,1010101L,1111101L,101000101L,111010111L,10101000100L,11111010101L,1010001010101L,1110101110101L,101010001010101L,111110101010101L,10100010000010101L,11101010111010101L,1010100000101000101L,1111101110101010101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279250Inst : IEnumerable<long>
{
public static readonly long[] Value=A279250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279250.Bytes);
public long this[int i]=>Value[i];

public static A279250Inst Instance=new A279250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279251
{
public static readonly ulong[] Value={ 1L,10L,101L,1110L,101L,101110L,1010101L,10111110L,101000101L,1110101110L,100010101L,101010111110L,1010101000101L,10101110101110L,101010100010101L,1010101010111110L,10101000001000101L,101010111010101110L,1010001010000010101L,10101010101110111110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279251Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279251.Bytes);
public ulong this[int i]=>Value[i];

public static A279251Inst Instance=new A279251Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279268
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,2L,2L,10L,10L,2L,5L,20L,29L,20L,5L,8L,38L,86L,86L,38L,8L,15L,68L,240L,400L,240L,68L,15L,26L,120L,626L,1592L,1592L,626L,120L,26L,46L,208L,1603L,5888L,9042L,5888L,1603L,208L,46L,80L,358L,4030L,21882L,51568L,51568L,21882L,4030L,358L,80L,139L,612L,9973L,79112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279268Inst : IEnumerable<long>
{
public static readonly long[] Value=A279268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279268.Bytes);
public long this[int i]=>Value[i];

public static A279268Inst Instance=new A279268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279269
{
public static readonly long[] Value={ 1L,7L,53L,391L,2865L,20967L,153413L,1122471L,8212705L,60089287L,439650773L,3216759751L,23535824145L,172202794407L,1259943234533L,9218531904231L,67448539061185L,493495652968327L,3610722528440693L,26418301962683911L,193292803059267825L,1414250914660723047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279269Inst : IEnumerable<long>
{
public static readonly long[] Value=A279269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279269.Bytes);
public long this[int i]=>Value[i];

public static A279269Inst Instance=new A279269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279270
{
public static readonly long[] Value={ 1L,-4L,5L,-4L,10L,-16L,12L,-8L,14L,-28L,21L,-8L,30L,-40L,28L,-16L,21L,-52L,34L,-20L,50L,-56L,48L,-24L,38L,-72L,44L,-28L,70L,-88L,56L,-24L,43L,-100L,70L,-36L,80L,-112L,84L,-32L,62L,-104L,85L,-44L,110L,-136L,56L,-56L,74L,-148L,102L,-40L,130L,-144L,120L,-56L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279270Inst : IEnumerable<long>
{
public static readonly long[] Value=A279270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279270.Bytes);
public long this[int i]=>Value[i];

public static A279270Inst Instance=new A279270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279271
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,57L,320L,2065L,14954L,119585L,1044184L,9867633L,100185294L,1086173121L,12510549116L,152422123321L,1956974934290L,26391647743937L,372769201632784L,5500416368181921L,84594395013757398L,1353277808896178145L,BigInteger.Parse("22476374660911200068"),BigInteger.Parse("386925983827921358665"),BigInteger.Parse("6893254434792968631674") };
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
public class A279271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279271Inst Instance=new A279271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279272
{
public static readonly long[] Value={ 72L,282L,9000L,13932L,19212L,22158L,49920L,65538L,72228L,78888L,144408L,169320L,201492L,201828L,218460L,234540L,270030L,296478L,325080L,355008L,365748L,411000L,448872L,461052L,484152L,504618L,555522L,558252L,586362L,622620L,674058L,981810L,1067490L,1095792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279272Inst : IEnumerable<long>
{
public static readonly long[] Value=A279272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279272.Bytes);
public long this[int i]=>Value[i];

public static A279272Inst Instance=new A279272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279273
{
public static readonly long[] Value={ 0L,0L,0L,8L,40L,104L,216L,440L,720L,1160L,1656L,2432L,3216L,4472L,5680L,7280L,9128L,11328L,13504L,16632L,19424L,23216L,27088L,31600L,35832L,41912L,47192L,53544L,60152L,68192L,75168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279273Inst : IEnumerable<long>
{
public static readonly long[] Value=A279273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279273.Bytes);
public long this[int i]=>Value[i];

public static A279273Inst Instance=new A279273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279274
{
public static readonly BigInteger[] Value={ 238L,685382117L,380358424875L,211083026086753L,BigInteger.Parse("606761281164154030532"),BigInteger.Parse("336727147248939746087250"),BigInteger.Parse("186869490875990437334549968"),BigInteger.Parse("537159115995469726115102627401247"),BigInteger.Parse("298100855085679705519137567072187125"),BigInteger.Parse("165433513379232813905174469119753565883") };
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
public class A279274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279274Inst Instance=new A279274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279275
{
public static readonly BigInteger[] Value={ 500L,721525L,1040439075L,1500312425150L,2163449476627750L,3119692644984790875L,BigInteger.Parse("4498594630618591814525"),BigInteger.Parse("6486970337659364411754700"),BigInteger.Parse("9354206728310172863158463400"),BigInteger.Parse("13488759615252931609310092468625"),BigInteger.Parse("19450782010987999070452290181294375") };
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
public class A279275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279275Inst Instance=new A279275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279276
{
public static readonly BigInteger[] Value={ 25L,2093L,2413024782L,199383164500L,16474611689525L,1361262526857873L,BigInteger.Parse("1569151855418042668762"),BigInteger.Parse("129655718749849826609000"),BigInteger.Parse("10713179445632171628299025"),BigInteger.Parse("885207493668292813536022453"),BigInteger.Parse("1020394636386389128112999131619942"),BigInteger.Parse("84313063475888056056234492629533500") };
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
public class A279276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279276Inst Instance=new A279276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279277
{
public static readonly long[] Value={ 1L,4L,12L,37L,110L,327L,968L,2864L,8469L,25040L,74029L,218856L,647008L,1912753L,5654670L,16716883L,49420052L,146100276L,431915561L,1276869920L,3774804441L,11159436284L,32990587972L,97529916957L,288327225550L,852380393407L,2519888066928L,7449533000584L,22023018662909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279277Inst : IEnumerable<long>
{
public static readonly long[] Value=A279277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279277.Bytes);
public long this[int i]=>Value[i];

public static A279277Inst Instance=new A279277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279278
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,0L,1L,2L,1L,0L,1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279278Inst : IEnumerable<long>
{
public static readonly long[] Value=A279278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279278.Bytes);
public long this[int i]=>Value[i];

public static A279278Inst Instance=new A279278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279279
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,2L,1L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279279Inst : IEnumerable<long>
{
public static readonly long[] Value=A279279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279279.Bytes);
public long this[int i]=>Value[i];

public static A279279Inst Instance=new A279279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279280
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,1L,1L,1L,2L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279280Inst : IEnumerable<long>
{
public static readonly long[] Value=A279280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279280.Bytes);
public long this[int i]=>Value[i];

public static A279280Inst Instance=new A279280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279281
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279281Inst : IEnumerable<long>
{
public static readonly long[] Value=A279281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279281.Bytes);
public long this[int i]=>Value[i];

public static A279281Inst Instance=new A279281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279282
{
public static readonly long[] Value={ 0L,1L,16L,182L,1720L,14149L,106944L,760463L,5160488L,33756514L,214369376L,1328496947L,8065970016L,48125315989L,282851349184L,1640791635086L,9409099218712L,53408767286521L,300417148670400L,1676056809217283L,9282172245277448L,51062759750186170L,279196558362482192L,1518068927980989575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279282Inst : IEnumerable<long>
{
public static readonly long[] Value=A279282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279282.Bytes);
public long this[int i]=>Value[i];

public static A279282Inst Instance=new A279282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279283
{
public static readonly long[] Value={ 0L,1L,8L,52L,304L,1650L,8492L,42000L,201356L,941367L,4310480L,19395042L,85972228L,376185250L,1627518840L,6971209090L,29595604656L,124648174343L,521225809112L,2165408553994L,8942942384500L,36733935375275L,150138939637144L,610840125062072L,2474686297520984L,9986301300789540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279283Inst : IEnumerable<long>
{
public static readonly long[] Value=A279283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279283.Bytes);
public long this[int i]=>Value[i];

public static A279283Inst Instance=new A279283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279300
{
public static readonly long[] Value={ 0L,1L,0L,3L,6L,24L,72L,232L,720L,2232L,6848L,20880L,63264L,190656L,571776L,1707264L,5077504L,15046272L,44439552L,130854656L,384228864L,1125285888L,3287672832L,9583835136L,27879174144L,80941029376L,234562535424L,678574706688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279300Inst : IEnumerable<long>
{
public static readonly long[] Value=A279300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279300.Bytes);
public long this[int i]=>Value[i];

public static A279300Inst Instance=new A279300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279301
{
public static readonly long[] Value={ 1L,0L,12L,104L,872L,8064L,71680L,635312L,5554240L,47920384L,408259136L,3437600192L,28638307456L,236298903552L,1932926374400L,15688543703808L,126443222102016L,1012619953508352L,8062922404920320L,63864515531578368L,503439208935970816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279301Inst : IEnumerable<long>
{
public static readonly long[] Value=A279301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279301.Bytes);
public long this[int i]=>Value[i];

public static A279301Inst Instance=new A279301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279302
{
public static readonly BigInteger[] Value={ 0L,12L,498L,14908L,396904L,10073670L,246262496L,5863622944L,136676490546L,3131550460530L,70733849080300L,1578557580824350L,34866752133128860L,763271052441391984L,16578556739715557822UL,BigInteger.Parse("357612940899237556004") };
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
public class A279302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279302Inst Instance=new A279302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279303
{
public static readonly BigInteger[] Value={ 3L,104L,14908L,1160588L,85082276L,6048938846L,417999641840L,28259741645108L,1876377200689742L,122717260049777256L,7923575567872456696L,BigInteger.Parse("506002930634118251738"),BigInteger.Parse("32006135169381911287878"),BigInteger.Parse("2007600046176079397378614") };
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
public class A279303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279303Inst Instance=new A279303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279304
{
public static readonly BigInteger[] Value={ 6L,872L,396904L,85082276L,17784685668L,3593187600532L,705869301747600L,135694363620306878L,BigInteger.Parse("25624173177871048697"),BigInteger.Parse("4767151315360734509636"),BigInteger.Parse("875740097922120817127250"),BigInteger.Parse("159138454239119621136483037") };
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
public class A279304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279304Inst Instance=new A279304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279305
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,3L,12L,12L,3L,6L,104L,498L,104L,6L,24L,872L,14908L,14908L,872L,24L,72L,8064L,396904L,1160588L,396904L,8064L,72L,232L,71680L,10073670L,85082276L,85082276L,10073670L,71680L,232L,720L,635312L,246262496L,6048938846L,17784685668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279305Inst : IEnumerable<long>
{
public static readonly long[] Value=A279305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279305.Bytes);
public long this[int i]=>Value[i];

public static A279305Inst Instance=new A279305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279306
{
public static readonly BigInteger[] Value={ 1L,1L,13L,377L,2551L,97711L,1686481L,447824017L,2522468131L,22174988051L,7129179751261L,1852107834946547L,34648570480339663L,828888380086508653L,BigInteger.Parse("273996480127378324681"),BigInteger.Parse("462007733994120695494433"),BigInteger.Parse("308514276772559961052721"),BigInteger.Parse("38471181499444351991058251") };
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
public class A279306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279306Inst Instance=new A279306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279307
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,137L,647L,22951L,328201L,26965819L,135880897L,37044323689L,91760237711L,250120070812867L,235374750708709L,38112363401091809L,1747698886011364219L,BigInteger.Parse("2880212454433162868027"),BigInteger.Parse("1444514603466022486187"),BigInteger.Parse("54349494835431693600323") };
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
public class A279307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279307Inst Instance=new A279307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279308
{
public static readonly BigInteger[] Value={ 2L,-1L,-23L,179L,15961L,-375481L,-77012099L,3667756091L,1363652668561L,-109208405349361L,-64265858394905339L,7770701878340584259L,BigInteger.Parse("6642366922974433027609"),BigInteger.Parse("-102726453588460111393691"),BigInteger.Parse("-1322873751136125749373458099"),BigInteger.Parse("15853417688720458694222368361") };
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
public class A279308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279308Inst Instance=new A279308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279309
{
public static readonly BigInteger[] Value={ 1L,2L,24L,720L,40320L,3628800L,479001600L,87178291200L,20922789888000L,6402373705728000L,2432902008176640000L,BigInteger.Parse("1124000727777607680000"),BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("36662860102418694144000000"),BigInteger.Parse("304888344611713860501504000000"),BigInteger.Parse("13960676832220582033489920000000") };
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
public class A279309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279309Inst Instance=new A279309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279310
{
public static readonly BigInteger[] Value={ 1L,1L,3L,5L,97L,157L,7619L,12329L,124121L,1807513L,263214179L,425890349L,90961797697L,29435864753L,1313384366851L,70128321031313L,2475709202997731L,44063598280490161L,BigInteger.Parse("21816698251120351811"),BigInteger.Parse("35300159324950341077"),BigInteger.Parse("7234801959635621099147"),BigInteger.Parse("2065792142493411347453") };
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
public class A279310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279310Inst Instance=new A279310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279311
{
public static readonly BigInteger[] Value={ 1L,1L,2L,2L,24L,24L,720L,720L,4480L,40320L,3628800L,3628800L,479001600L,95800320L,2641766400L,87178291200L,1902071808000L,20922789888000L,6402373705728000L,6402373705728000L,810967336058880000L,143111882833920000L,BigInteger.Parse("66117689869271040000"),13223537973854208000UL };
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
public class A279311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279311Inst Instance=new A279311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279312
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,24L,40L,80L,128L,256L,416L,832L,1344L,2688L,4352L,8704L,14080L,28160L,45568L,91136L,147456L,294912L,477184L,954368L,1544192L,3088384L,4997120L,9994240L,16171008L,32342016L,52330496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279312Inst : IEnumerable<long>
{
public static readonly long[] Value=A279312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279312.Bytes);
public long this[int i]=>Value[i];

public static A279312Inst Instance=new A279312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279313
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279313Inst : IEnumerable<long>
{
public static readonly long[] Value=A279313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279313.Bytes);
public long this[int i]=>Value[i];

public static A279313Inst Instance=new A279313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279314
{
public static readonly long[] Value={ 4L,22L,27L,58L,85L,94L,105L,114L,121L,150L,166L,202L,204L,222L,224L,265L,274L,315L,319L,342L,346L,355L,378L,382L,391L,438L,445L,450L,454L,483L,517L,526L,535L,540L,560L,562L,576L,588L,612L,627L,634L,636L,640L,645L,648L,654L,663L,666L,690L,697L,706L,728L,729L,762L,778L,825L,840L,841L,852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279314Inst : IEnumerable<long>
{
public static readonly long[] Value=A279314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279314.Bytes);
public long this[int i]=>Value[i];

public static A279314Inst Instance=new A279314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279315
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,2L,1L,0L,6L,0L,1L,12L,1L,0L,12L,0L,1L,6L,1L,0L,2L,0L,1L,0L,0L,2L,0L,0L,1L,30L,1L,0L,0L,2L,0L,0L,1L,0L,2L,0L,1L,12L,1L,0L,2L,0L,1L,0L,0L,2L,0L,0L,4L,0L,0L,2L,0L,0L,1L,6L,1L,0L,0L,2L,0L,0L,1L,0L,2L,0L,1L,2L,1L,0L,0L,2L,0L,0L,1L,0L,6L,0L,1L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279315Inst : IEnumerable<long>
{
public static readonly long[] Value=A279315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279315.Bytes);
public long this[int i]=>Value[i];

public static A279315Inst Instance=new A279315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279348
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,10L,15L,11L,8L,12L,14L,25L,27L,18L,35L,13L,20L,30L,21L,33L,22L,39L,49L,16L,24L,28L,50L,65L,51L,54L,77L,17L,36L,70L,57L,87L,26L,55L,85L,40L,60L,42L,63L,95L,66L,121L,45L,44L,78L,69L,81L,98L,147L,119L,32L,48L,56L,100L,130L,125L,159L,102L,143L,19L,108L,154L,105L,207L,34L,145L,215L,72L,140L,114L,75L,91L,174L,133L,117L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279348Inst : IEnumerable<long>
{
public static readonly long[] Value=A279348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279348.Bytes);
public long this[int i]=>Value[i];

public static A279348Inst Instance=new A279348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279349
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,12L,8L,9L,11L,13L,19L,14L,10L,27L,35L,17L,67L,20L,22L,24L,131L,28L,15L,40L,16L,29L,259L,21L,515L,58L,23L,72L,18L,36L,1027L,136L,25L,43L,2051L,45L,4099L,51L,50L,264L,8195L,59L,26L,30L,32L,83L,16387L,33L,41L,60L,38L,520L,32771L,44L,65539L,1032L,46L,121L,31L,48L,131075L,147L,53L,37L,262147L,75L,524291L,2056L,78L,275L,34L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279349Inst : IEnumerable<long>
{
public static readonly long[] Value=A279349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279349.Bytes);
public long this[int i]=>Value[i];

public static A279349Inst Instance=new A279349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279350
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,16L,2L,4L,12L,32L,6L,64L,24L,12L,2L,128L,6L,256L,12L,4L,48L,512L,6L,8L,96L,36L,24L,1024L,30L,2048L,2L,12L,192L,24L,6L,4096L,384L,72L,12L,8192L,60L,16384L,48L,4L,768L,32768L,6L,16L,12L,12L,96L,65536L,6L,8L,24L,36L,1536L,131072L,30L,262144L,3072L,144L,2L,72L,120L,524288L,192L,12L,60L,1048576L,6L,2097152L,6144L,288L,384L,48L,240L,4194304L,12L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279350Inst : IEnumerable<long>
{
public static readonly long[] Value=A279350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279350.Bytes);
public long this[int i]=>Value[i];

public static A279350Inst Instance=new A279350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279351
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,9L,12L,32L,10L,64L,24L,18L,7L,128L,15L,256L,20L,36L,48L,512L,14L,21L,96L,25L,40L,1024L,30L,2048L,11L,72L,192L,54L,27L,4096L,384L,144L,28L,8192L,60L,16384L,80L,50L,768L,32768L,22L,45L,33L,288L,160L,65536L,35L,108L,56L,576L,1536L,131072L,42L,262144L,3072L,100L,13L,216L,120L,524288L,320L,1152L,90L,1048576L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279351Inst : IEnumerable<long>
{
public static readonly long[] Value=A279351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279351.Bytes);
public long this[int i]=>Value[i];

public static A279351Inst Instance=new A279351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279352
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,9L,12L,32L,10L,64L,24L,18L,7L,128L,15L,256L,20L,25L,48L,512L,14L,27L,96L,36L,40L,1024L,30L,2048L,11L,50L,192L,54L,21L,4096L,384L,72L,28L,8192L,60L,16384L,80L,49L,768L,32768L,22L,81L,45L,75L,160L,65536L,35L,125L,56L,100L,1536L,131072L,42L,262144L,3072L,144L,13L,108L,120L,524288L,320L,98L,90L,1048576L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279352Inst : IEnumerable<long>
{
public static readonly long[] Value=A279352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279352.Bytes);
public long this[int i]=>Value[i];

public static A279352Inst Instance=new A279352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279353
{
public static readonly long[] Value={ 7L,3L,15L,5L,1L,3L,31L,5L,1L,13L,3L,7L,1L,3L,63L,5L,1L,13L,3L,7L,1L,29L,3L,7L,3L,13L,1L,7L,1L,3L,127L,5L,1L,13L,3L,7L,1L,29L,3L,7L,3L,13L,1L,7L,1L,61L,3L,7L,3L,13L,1L,7L,3L,29L,1L,5L,15L,3L,1L,7L,1L,3L,255L,5L,1L,13L,3L,7L,1L,29L,3L,7L,3L,13L,1L,7L,1L,61L,3L,7L,3L,13L,1L,7L,3L,29L,1L,5L,15L,3L,1L,7L,1L,125L,3L,7L,3L,13L,1L,7L,3L,29L,1L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279353Inst : IEnumerable<long>
{
public static readonly long[] Value=A279353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279353.Bytes);
public long this[int i]=>Value[i];

public static A279353Inst Instance=new A279353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279354
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,16L,2L,6L,8L,32L,4L,64L,16L,12L,2L,128L,6L,256L,8L,6L,32L,512L,4L,12L,64L,24L,16L,1024L,12L,2048L,2L,12L,128L,36L,6L,4096L,256L,48L,8L,8192L,24L,16384L,32L,6L,512L,32768L,4L,24L,12L,30L,64L,65536L,6L,12L,16L,24L,1024L,131072L,12L,262144L,2048L,96L,2L,72L,48L,524288L,128L,12L,36L,1048576L,6L,2097152L,4096L,192L,256L,72L,96L,4194304L,8L,48L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279354Inst : IEnumerable<long>
{
public static readonly long[] Value=A279354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279354.Bytes);
public long this[int i]=>Value[i];

public static A279354Inst Instance=new A279354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279355
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,16L,5L,6L,21L,32L,25L,64L,45L,18L,7L,128L,15L,256L,55L,54L,93L,512L,49L,12L,189L,10L,115L,1024L,51L,2048L,11L,162L,381L,36L,35L,4096L,765L,486L,91L,8192L,159L,16384L,235L,50L,1533L,32768L,121L,24L,33L,1458L,475L,65536L,27L,108L,203L,4374L,3069L,131072L,125L,262144L,6141L,250L,13L,324L,483L,524288L,955L,13122L,105L,1048576L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279355Inst : IEnumerable<long>
{
public static readonly long[] Value=A279355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279355.Bytes);
public long this[int i]=>Value[i];

public static A279355Inst Instance=new A279355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279356
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,16L,5L,6L,27L,32L,25L,64L,81L,18L,7L,128L,15L,256L,125L,10L,243L,512L,49L,12L,729L,54L,625L,1024L,75L,2048L,11L,50L,2187L,36L,35L,4096L,6561L,162L,343L,8192L,375L,16384L,3125L,14L,19683L,32768L,121L,24L,45L,30L,15625L,65536L,21L,20L,2401L,250L,59049L,131072L,245L,262144L,177147L,486L,13L,108L,1875L,524288L,78125L,98L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279356Inst : IEnumerable<long>
{
public static readonly long[] Value=A279356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279356.Bytes);
public long this[int i]=>Value[i];

public static A279356Inst Instance=new A279356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279357
{
public static readonly long[] Value={ 1L,2L,7L,3L,15L,2L,1L,4L,31L,2L,1L,5L,1L,14L,3L,5L,63L,2L,1L,5L,1L,14L,3L,4L,1L,30L,3L,7L,3L,14L,1L,6L,127L,2L,1L,5L,1L,14L,3L,4L,1L,30L,3L,7L,3L,14L,1L,7L,1L,62L,3L,7L,3L,14L,1L,4L,3L,30L,1L,5L,1L,2L,15L,7L,255L,2L,1L,5L,1L,14L,3L,4L,1L,30L,3L,7L,3L,14L,1L,7L,1L,62L,3L,7L,3L,14L,1L,4L,3L,30L,1L,5L,1L,2L,15L,6L,1L,126L,3L,7L,3L,14L,1L,4L,3L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279357Inst : IEnumerable<long>
{
public static readonly long[] Value=A279357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279357.Bytes);
public long this[int i]=>Value[i];

public static A279357Inst Instance=new A279357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279358
{
public static readonly BigInteger[] Value={ 1L,1L,9L,52L,413L,3916L,41077L,481384L,6198425L,86430160L,1296040841L,20763245944L,353272341061L,6353672109760L,120315348389069L,2390488408994536L,49682962883210033L,1077292416660660736L,BigInteger.Parse("24313317132393295633"),BigInteger.Parse("569937590287796925784"),BigInteger.Parse("13850459183086300341341") };
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
public class A279358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279358Inst Instance=new A279358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279359
{
public static readonly long[] Value={ 2L,4L,10L,18L,36L,62L,90L,902L,1214L,2936L,3436L,325726L,378646L,646840L,5432174L,273222344L,285775216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279359Inst : IEnumerable<long>
{
public static readonly long[] Value=A279359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279359.Bytes);
public long this[int i]=>Value[i];

public static A279359Inst Instance=new A279359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279360
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,4L,0L,0L,0L,2L,4L,0L,0L,4L,8L,0L,2L,4L,0L,0L,4L,8L,0L,0L,0L,6L,12L,0L,0L,12L,24L,0L,0L,0L,4L,8L,2L,4L,8L,16L,4L,12L,8L,0L,0L,12L,24L,0L,0L,10L,28L,16L,4L,12L,24L,32L,8L,16L,4L,8L,0L,12L,32L,16L,2L,32L,56L,0L,4L,16L,24L,16L,0L,4L,36L,56L,0L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279360Inst : IEnumerable<long>
{
public static readonly long[] Value=A279360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279360.Bytes);
public long this[int i]=>Value[i];

public static A279360Inst Instance=new A279360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279361
{
public static readonly BigInteger[] Value={ 1L,1L,4L,16L,80L,471L,3127L,23059L,186468L,1635265L,15422471L,155388399L,1663294756L,18826525771L,224434810797L,2808247979611L,36770685485408L,502505495269521L,7150461569849395L,105723461155720879L,1621191824611307436L,BigInteger.Parse("25738508587975433251") };
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
public class A279361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279361Inst Instance=new A279361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279362
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,-1L,1L,1L,-2L,0L,2L,-1L,-1L,2L,-2L,-1L,0L,-2L,-2L,-2L,0L,-1L,1L,0L,2L,-2L,-5L,0L,-2L,0L,0L,1L,-2L,0L,0L,-3L,-1L,0L,0L,-2L,1L,-1L,2L,2L,0L,0L,0L,-2L,-2L,0L,2L,2L,-2L,0L,-2L,2L,1L,1L,0L,0L,0L,-1L,2L,0L,4L,0L,1L,2L,0L,2L,-1L,0L,0L,2L,-2L,-2L,4L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279362Inst : IEnumerable<long>
{
public static readonly long[] Value=A279362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279362.Bytes);
public long this[int i]=>Value[i];

public static A279362Inst Instance=new A279362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279363
{
public static readonly long[] Value={ 0L,1L,1L,17L,1L,98L,1L,273L,82L,642L,1L,1650L,1L,2418L,707L,4369L,1L,7955L,1L,10898L,2483L,14658L,1L,26482L,626L,28578L,6643L,41090L,1L,62644L,1L,69905L,14723L,83538L,3027L,133923L,1L,130338L,28643L,174994L,1L,236692L,1L,249170L,57893L,279858L,1L,423794L,2402L,401267L,83603L,485810L,1L,644372L,15267L,659842L,130403L,707298L,1L,1053636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279363Inst : IEnumerable<long>
{
public static readonly long[] Value=A279363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279363.Bytes);
public long this[int i]=>Value[i];

public static A279363Inst Instance=new A279363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279397
{
public static readonly BigInteger[] Value={ 1L,1L,4L,9L,25L,69L,217L,745L,2801L,11399L,49859L,232639L,1151397L,6017345L,33084489L,190780154L,1150686536L,7241926820L,47455774001L,323158817943L,2282794174761L,16700943712871L,126356690691651L,987303203599953L,7957130740261570L,66071751478724210L,564631175841553564L,4961038559732049506L,BigInteger.Parse("44775183035039043106") };
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
public class A279397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279397Inst Instance=new A279397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279398
{
public static readonly long[] Value={ 3L,5L,2L,3L,3L,5L,7L,2L,7L,2L,3L,3L,5L,3L,3L,5L,3L,3L,5L,2L,7L,3L,5L,3L,3L,11L,2L,7L,2L,7L,7L,5L,3L,2L,5L,2L,3L,5L,3L,5L,5L,11L,3L,7L,2L,3L,3L,17L,3L,3L,3L,3L,7L,5L,3L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279398Inst : IEnumerable<long>
{
public static readonly long[] Value=A279398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279398.Bytes);
public long this[int i]=>Value[i];

public static A279398Inst Instance=new A279398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279399
{
public static readonly long[] Value={ 3L,5L,7L,5L,7L,11L,2L,7L,11L,13L,3L,5L,7L,11L,13L,3L,7L,11L,13L,17L,19L,2L,5L,11L,13L,17L,19L,5L,7L,11L,13L,17L,19L,23L,3L,5L,11L,13L,17L,19L,23L,7L,11L,13L,17L,19L,23L,29L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,2L,5L,7L,13L,17L,19L,23L,29L,31L,2L,3L,11L,13L,17L,19L,23L,29L,31L,5L,7L,11L,13L,17L,19L,23L,29L,31L,2L,5L,7L,11L,17L,19L,23L,29L,31L,37L,3L,7L,11L,13L,17L,19L,23L,29L,31L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279399Inst : IEnumerable<long>
{
public static readonly long[] Value=A279399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279399.Bytes);
public long this[int i]=>Value[i];

public static A279399Inst Instance=new A279399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279400
{
public static readonly long[] Value={ 3L,3L,4L,5L,6L,6L,7L,7L,7L,10L,9L,9L,9L,10L,10L,10L,12L,12L,13L,13L,13L,14L,14L,14L,14L,16L,17L,16L,15L,17L,17L,16L,18L,19L,19L,19L,18L,20L,20L,21L,21L,21L,21L,22L,22L,22L,22L,22L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279400Inst : IEnumerable<long>
{
public static readonly long[] Value=A279400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279400.Bytes);
public long this[int i]=>Value[i];

public static A279400Inst Instance=new A279400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279401
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,4L,4L,2L,4L,4L,4L,2L,4L,4L,4L,4L,2L,4L,4L,2L,6L,6L,6L,2L,6L,6L,2L,2L,2L,2L,2L,2L,2L,6L,6L,6L,2L,6L,6L,6L,4L,2L,4L,4L,2L,4L,2L,8L,8L,4L,8L,8L,2L,8L,4L,8L,2L,10L,10L,10L,10L,10L,10L,2L,10L,5L,12L,12L,3L,4L,12L,6L,12L,2L,6L,6L,6L,6L,3L,2L,2L,6L,6L,6L,12L,4L,12L,12L,6L,12L,6L,6L,4L,12L,4L,4L,2L,4L,4L,2L,4L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279401Inst : IEnumerable<long>
{
public static readonly long[] Value=A279401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279401.Bytes);
public long this[int i]=>Value[i];

public static A279401Inst Instance=new A279401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279402
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279402Inst : IEnumerable<long>
{
public static readonly long[] Value=A279402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279402.Bytes);
public long this[int i]=>Value[i];

public static A279402Inst Instance=new A279402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279403
{
public static readonly long[] Value={ 1L,4L,9L,16L,4L,25L,8L,2L,36L,16L,4L,49L,24L,11L,4L,64L,36L,16L,6L,81L,48L,27L,12L,3L,100L,64L,36L,19L,4L,121L,80L,51L,29L,13L,144L,100L,64L,39L,16L,6L,169L,120L,83L,53L,29L,8L,2L,196L,144L,100L,67L,36L,18L,8L,225L,168L,223L,82L,41L,256L,196L,144L,103L,64L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279403Inst : IEnumerable<long>
{
public static readonly long[] Value=A279403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279403.Bytes);
public long this[int i]=>Value[i];

public static A279403Inst Instance=new A279403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279404
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,4L,5L,4L,5L,5L,5L,6L,7L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279404Inst : IEnumerable<long>
{
public static readonly long[] Value=A279404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279404.Bytes);
public long this[int i]=>Value[i];

public static A279404Inst Instance=new A279404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279405
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,4L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279405Inst : IEnumerable<long>
{
public static readonly long[] Value=A279405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279405.Bytes);
public long this[int i]=>Value[i];

public static A279405Inst Instance=new A279405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279406
{
public static readonly long[] Value={ 0L,1L,0L,4L,4L,4L,4L,0L,9L,9L,9L,9L,9L,9L,9L,9L,9L,0L,12L,14L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,0L,17L,22L,23L,24L,24L,24L,24L,24L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,0L,20L,26L,30L,30L,32L,32L,34L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279406Inst : IEnumerable<long>
{
public static readonly long[] Value=A279406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279406.Bytes);
public long this[int i]=>Value[i];

public static A279406Inst Instance=new A279406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279407
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279407Inst : IEnumerable<long>
{
public static readonly long[] Value=A279407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279407.Bytes);
public long this[int i]=>Value[i];

public static A279407Inst Instance=new A279407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279408
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,2L,2L,2L,4L,4L,2L,2L,2L,4L,4L,4L,3L,3L,3L,5L,5L,6L,7L,3L,3L,3L,6L,6L,6L,8L,8L,3L,3L,3L,6L,6L,6L,9L,9L,9L,4L,4L,4L,7L,7L,8L,10L,11L,12L,14L,4L,4L,4L,8L,8L,8L,11L,11L,12L,15L,15L,4L,4L,4L,8L,8L,8L,12L,12L,12L,16L,16L,16L,5L,5L,5L,9L,9L,10L,13L,14L,15L,18L,19L,20L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279408Inst : IEnumerable<long>
{
public static readonly long[] Value=A279408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279408.Bytes);
public long this[int i]=>Value[i];

public static A279408Inst Instance=new A279408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279409
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,4L,2L,2L,2L,4L,5L,3L,3L,3L,6L,6L,9L,3L,3L,3L,6L,7L,9L,10L,4L,4L,4L,8L,8L,12L,12L,16L,4L,4L,4L,8L,9L,12L,13L,16L,18L,5L,5L,5L,10L,10L,15L,15L,20L,20L,25L,5L,5L,5L,10L,11L,15L,16L,20L,22L,25L,27L,6L,6L,6L,12L,12L,18L,18L,24L,24L,30L,30L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279409Inst : IEnumerable<long>
{
public static readonly long[] Value=A279409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279409.Bytes);
public long this[int i]=>Value[i];

public static A279409Inst Instance=new A279409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279410
{
public static readonly long[] Value={ 35L,38L,46L,65L,76L,83L,85L,318L,335L,348L,359L,380L,383L,393L,400L,415L,419L,432L,436L,441L,457L,469L,500L,511L,526L,527L,585L,586L,599L,600L,611L,620L,636L,648L,654L,665L,688L,692L,696L,700L,711L,718L,728L,752L,755L,771L,781L,786L,793L,800L,809L,811L,826L,828L,832L,834L,836L,838L,857L,866L,880L,900L,908L,911L,922L,928L,944L,951L,958L,995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279410Inst : IEnumerable<long>
{
public static readonly long[] Value=A279410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279410.Bytes);
public long this[int i]=>Value[i];

public static A279410Inst Instance=new A279410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279411
{
public static readonly long[] Value={ 1L,-4L,2L,0L,23L,-20L,2L,-88L,63L,-96L,318L,-104L,626L,-844L,504L,-2472L,1525L,-3704L,6184L,-4288L,15284L,-10736L,23254L,-35792L,30228L,-84544L,60974L,-139240L,176658L,-190108L,418940L,-320976L,755332L,-773524L,1111678L,-1847304L,1669046L,-3634296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279411Inst : IEnumerable<long>
{
public static readonly long[] Value=A279411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279411.Bytes);
public long this[int i]=>Value[i];

public static A279411Inst Instance=new A279411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279412
{
public static readonly long[] Value={ 0L,2L,3L,0L,10L,0L,14L,8L,9L,20L,11L,24L,26L,28L,30L,48L,34L,72L,57L,80L,84L,88L,115L,120L,125L,156L,135L,168L,203L,180L,279L,224L,297L,306L,315L,396L,407L,418L,507L,480L,574L,630L,645L,748L,720L,828L,893L,960L,1029L,1150L,1122L,1300L,1378L,1458L,1650L,1624L,1824L,1856L,2065L,2220L,2379L,2480L,2646L,2816L,2925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279412Inst : IEnumerable<long>
{
public static readonly long[] Value=A279412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279412.Bytes);
public long this[int i]=>Value[i];

public static A279412Inst Instance=new A279412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279429
{
public static readonly long[] Value={ 3L,14L,114L,118L,130L,134L,148L,158L,161L,170L,173L,176L,187L,212L,219L,228L,230L,270L,272L,281L,288L,313L,1034L,1039L,1044L,1058L,1063L,1072L,1077L,1086L,1095L,1109L,1118L,1131L,1140L,1153L,1166L,1183L,1204L,1208L,1292L,1296L,1315L,1319L,1334L,1345L,1349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279429Inst : IEnumerable<long>
{
public static readonly long[] Value=A279429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279429.Bytes);
public long this[int i]=>Value[i];

public static A279429Inst Instance=new A279429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279430
{
public static readonly long[] Value={ 0L,2L,4L,5L,8L,9L,10L,16L,17L,18L,19L,22L,32L,33L,34L,35L,36L,37L,40L,41L,44L,64L,65L,66L,67L,68L,69L,70L,71L,76L,77L,80L,81L,84L,85L,87L,90L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,144L,145L,146L,147L,151L,152L,153L,156L,157L,160L,161L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279430Inst : IEnumerable<long>
{
public static readonly long[] Value=A279430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279430.Bytes);
public long this[int i]=>Value[i];

public static A279430Inst Instance=new A279430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279431
{
public static readonly long[] Value={ 1L,11L,20L,21L,38L,39L,42L,43L,45L,72L,73L,74L,75L,78L,79L,82L,83L,86L,88L,89L,140L,141L,142L,143L,148L,149L,150L,154L,155L,158L,159L,162L,163L,166L,167L,169L,170L,172L,173L,175L,178L,180L,181L,272L,273L,274L,275L,276L,277L,278L,284L,285L,286L,287L,292L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279431Inst : IEnumerable<long>
{
public static readonly long[] Value=A279431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279431.Bytes);
public long this[int i]=>Value[i];

public static A279431Inst Instance=new A279431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279432
{
public static readonly long[] Value={ 0L,0L,4L,0L,10L,20L,0L,16L,34L,48L,0L,22L,44L,70L,88L,0L,28L,58L,88L,118L,140L,0L,34L,68L,102L,140L,178L,204L,0L,40L,82L,124L,166L,208L,250L,280L,0L,46L,92L,142L,184L,238L,284L,334L,368L,0L,52L,106L,156L,214L,268L,318L,376L,430L,468L,0L,58L,116L,178L,236L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279432Inst : IEnumerable<long>
{
public static readonly long[] Value=A279432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279432.Bytes);
public long this[int i]=>Value[i];

public static A279432Inst Instance=new A279432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279433
{
public static readonly long[] Value={ 0L,0L,4L,0L,6L,4L,0L,4L,12L,4L,0L,4L,6L,12L,12L,0L,4L,8L,12L,12L,4L,0L,4L,4L,6L,12L,20L,4L,0L,4L,4L,12L,12L,12L,20L,4L,0L,4L,4L,4L,14L,12L,20L,12L,12L,0L,4L,4L,4L,12L,12L,16L,12L,12L,20L,0L,4L,4L,8L,8L,6L,12L,20L,20L,20L,4L,0L,4L,4L,4L,4L,12L,28L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279433Inst : IEnumerable<long>
{
public static readonly long[] Value=A279433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279433.Bytes);
public long this[int i]=>Value[i];

public static A279433Inst Instance=new A279433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279434
{
public static readonly BigInteger[] Value={ 1L,1L,5L,31L,257L,2671L,6661L,484471L,8054177L,150635551L,626067541L,71556251911L,1784401334897L,48205833997231L,280492556837221L,43716593539939351L,1453550100421124417L,BigInteger.Parse("51350258701767067711"),BigInteger.Parse("384157083636635210101"),BigInteger.Parse("530347007443935458537") };
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
public class A279434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279434Inst Instance=new A279434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279435
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,144L,5040L,40320L,362880L,725760L,39916800L,479001600L,6227020800L,17435658240L,1307674368000L,20922789888000L,355687428096000L,1280474741145600L,850665037824000L,221172909834240000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279435Inst : IEnumerable<long>
{
public static readonly long[] Value=A279435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279435.Bytes);
public long this[int i]=>Value[i];

public static A279435Inst Instance=new A279435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279436
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,3L,4L,5L,3L,6L,6L,7L,6L,9L,7L,10L,8L,11L,12L,13L,9L,14L,15L,15L,15L,18L,15L,19L,16L,20L,21L,22L,18L,24L,24L,25L,22L,27L,24L,28L,26L,27L,30L,31L,25L,32L,31L,34L,33L,36L,32L,37L,34L,39L,40L,41L,34L,42L,42L,41L,40L,45L,43L,47L,45L,48L,46L,50L,42L,51L,51L,50L,51L,54L,52L,56L,50L,55L,58L,59L,52L,60L,61L,62L,59L,64L,57L,65L,64L,67L,68L,69L,62L,71L,69L,70L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279436Inst : IEnumerable<long>
{
public static readonly long[] Value=A279436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279436.Bytes);
public long this[int i]=>Value[i];

public static A279436Inst Instance=new A279436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279437
{
public static readonly long[] Value={ 0L,4L,78L,528L,2200L,6900L,17934L,40768L,83808L,159300L,284350L,482064L,782808L,1225588L,1859550L,2745600L,3958144L,5586948L,7739118L,10541200L,14141400L,18711924L,24451438L,31587648L,40380000L,51122500L,64146654L,79824528L,98571928L,120851700L,147177150L,178115584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279437Inst : IEnumerable<long>
{
public static readonly long[] Value=A279437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279437.Bytes);
public long this[int i]=>Value[i];

public static A279437Inst Instance=new A279437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279438
{
public static readonly long[] Value={ 0L,1L,90L,1428L,10600L,51525L,190806L,584080L,1552608L,3701025L,8088850L,16470036L,31616520L,57743413L,101055150L,170433600L,278290816L,441610785L,683206218L,1033218100L,1530887400L,2226630021L,3184447750L,4484709648L,6227340000L,8535450625L,11559457026L,15481719540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279438Inst : IEnumerable<long>
{
public static readonly long[] Value=A279438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279438.Bytes);
public long this[int i]=>Value[i];

public static A279438Inst Instance=new A279438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279439
{
public static readonly long[] Value={ 0L,0L,45L,2304L,34020L,270720L,1475145L,6209280L,21654864L,65422080L,176467005L,434206080L,990140580L,2117816064L,4288771305L,8284308480L,15355471680L,27446584320L,47501098029L,79872376320L,130866406020L,209448328320L,328150139625L,504222960384L,761083938000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279439Inst : IEnumerable<long>
{
public static readonly long[] Value=A279439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279439.Bytes);
public long this[int i]=>Value[i];

public static A279439Inst Instance=new A279439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279440
{
public static readonly long[] Value={ 0L,0L,6L,2040L,71400L,1005720L,8421630L,50092896L,233483040L,905925600L,3045791430L,9125544120L,24868110696L,62593429080L,147255640350L,326843422080L,689604309120L,1391614736256L,2699616160710L,5055848825400L,9173923662120L,16177675640280L,27798546316926L,46651469520480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279440Inst : IEnumerable<long>
{
public static readonly long[] Value=A279440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279440.Bytes);
public long this[int i]=>Value[i];

public static A279440Inst Instance=new A279440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279441
{
public static readonly long[] Value={ 0L,0L,0L,816L,93000L,2602800L,35526120L,309328320L,1972234656L,9989784000L,42369069600L,155993500080L,511660972680L,1524225598896L,4185197289000L,10715254368000L,25817751281280L,58981960615680L,128554066935936L,268691201838000L,540886175310600L,1052558059827120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279441Inst : IEnumerable<long>
{
public static readonly long[] Value=A279441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279441.Bytes);
public long this[int i]=>Value[i];

public static A279441Inst Instance=new A279441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279442
{
public static readonly long[] Value={ 0L,0L,0L,90L,67950L,4531950L,109425330L,1460297160L,13112872920L,88456195800L,480149029800L,2196080372970L,8743233946590L,31033043111070L,99992483914050L,296626638016800L,819218054279520L,2125440234303840L,5218743585428640L,12201529135725450L,27304286810701950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279442Inst : IEnumerable<long>
{
public static readonly long[] Value=A279442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279442.Bytes);
public long this[int i]=>Value[i];

public static A279442Inst Instance=new A279442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279443
{
public static readonly long[] Value={ 0L,0L,0L,0L,22650L,4987800L,240023070L,5219088000L,68483325960L,630486309600L,4456523194200L,25647802519680L,125166919041450L,533442526857240L,2029603476250350L,7011735609715200L,22291042191643680L,65914292362262400L,182880685655641440L,479548000781222400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279443Inst : IEnumerable<long>
{
public static readonly long[] Value=A279443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279443.Bytes);
public long this[int i]=>Value[i];

public static A279443Inst Instance=new A279443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279444
{
public static readonly BigInteger[] Value={ 1L,6L,78L,1428L,34020L,1005720L,35526120L,1460297160L,68483325960L,3608847088560L,211125189789360L,13577790144108960L,952129825291925280L,BigInteger.Parse("72303731169467878080"),BigInteger.Parse("5911241852357814772800"),BigInteger.Parse("517670861532464104264800"),BigInteger.Parse("48347072773751574327304800") };
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
public class A279444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279444Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279444.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279444Inst Instance=new A279444Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279477
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,6L,2L,5L,3L,3L,4L,7L,8L,9L,1L,6L,10L,2L,5L,6L,2L,5L,1L,3L,4L,4L,7L,6L,3L,5L,1L,8L,4L,2L,4L,7L,8L,6L,10L,2L,8L,9L,5L,1L,10L,2L,11L,12L,5L,9L,3L,7L,13L,1L,6L,9L,5L,1L,3L,11L,7L,1L,4L,3L,8L,6L,12L,10L,2L,3L,7L,5L,8L,6L,4L,10L,2L,6L,1L,3L,5L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279477Inst : IEnumerable<long>
{
public static readonly long[] Value=A279477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279477.Bytes);
public long this[int i]=>Value[i];

public static A279477Inst Instance=new A279477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279478
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,2L,6L,7L,3L,3L,4L,5L,6L,2L,8L,3L,1L,5L,7L,6L,7L,1L,4L,5L,9L,10L,2L,8L,4L,6L,7L,3L,2L,10L,4L,5L,6L,3L,1L,7L,1L,3L,9L,10L,2L,7L,8L,11L,1L,11L,9L,4L,5L,6L,8L,8L,2L,11L,5L,6L,3L,4L,10L,12L,4L,7L,9L,5L,2L,13L,14L,8L,12L,1L,3L,7L,9L,12L,19L,1L,4L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279478Inst : IEnumerable<long>
{
public static readonly long[] Value=A279478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279478.Bytes);
public long this[int i]=>Value[i];

public static A279478Inst Instance=new A279478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279479
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,2L,-2L,0L,0L,0L,-2L,0L,0L,2L,-1L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,-2L,0L,0L,5L,-5L,0L,0L,0L,-5L,0L,0L,6L,-2L,0L,0L,0L,0L,0L,0L,7L,-1L,0L,0L,0L,-5L,0L,0L,10L,-10L,0L,0L,0L,-10L,0L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279479Inst : IEnumerable<long>
{
public static readonly long[] Value=A279479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279479.Bytes);
public long this[int i]=>Value[i];

public static A279479Inst Instance=new A279479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279480
{
public static readonly long[] Value={ 1L,2L,4L,6L,16L,28L,46L,82L,88L,106L,180L,198L,210L,228L,238L,276L,312L,352L,430L,442L,466L,498L,540L,556L,568L,600L,616L,690L,732L,738L,742L,760L,768L,772L,786L,810L,856L,928L,936L,952L,966L,996L,1038L,1150L,1152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279480Inst : IEnumerable<long>
{
public static readonly long[] Value=A279480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279480.Bytes);
public long this[int i]=>Value[i];

public static A279480Inst Instance=new A279480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279481
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,2L,5L,8L,6L,9L,13L,12L,14L,10L,12L,12L,24L,22L,9L,20L,24L,27L,29L,38L,36L,24L,39L,29L,33L,43L,24L,58L,58L,17L,52L,60L,53L,63L,80L,46L,54L,87L,70L,46L,100L,62L,58L,87L,31L,79L,104L,71L,87L,119L,99L,116L,152L,114L,94L,181L,54L,82L,144L,39L,116L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279481Inst : IEnumerable<long>
{
public static readonly long[] Value=A279481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279481.Bytes);
public long this[int i]=>Value[i];

public static A279481Inst Instance=new A279481Inst();

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