using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A117079
{
public static readonly long[] Value={ 1L,3L,7L,15L,32L,66L,134L,271L,545L,1093L,2190L,4384L,8772L,17548L,35101L,70207L,140419L,280844L,561694L,1123394L,2246795L,4493597L,8987201L,17974409L,35948826L,71897660L,143795328L,287590665L,575181339L,1150362687L,2300725384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117079Inst : IEnumerable<long>
{
public static readonly long[] Value=A117079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117079.Bytes);
public long this[int i]=>Value[i];

public static A117079Inst Instance=new A117079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117080
{
public static readonly long[] Value={ 1L,3L,8L,18L,40L,89L,197L,435L,960L,2118L,4672L,10305L,22729L,50131L,110568L,243866L,537864L,1186297L,2616461L,5770787L,12727872L,28072206L,61915200L,136558273L,301188753L,664292707L,1465143688L,3231476130L,7127244968L,15719633625L,34670743381L,76468731731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117080Inst : IEnumerable<long>
{
public static readonly long[] Value=A117080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117080.Bytes);
public long this[int i]=>Value[i];

public static A117080Inst Instance=new A117080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117081
{
public static readonly long[] Value={ 2753L,1979L,1277L,647L,89L,-397L,-811L,-1153L,-1423L,-1621L,-1747L,-1801L,-1783L,-1693L,-1531L,-1297L,-991L,-613L,-163L,359L,953L,1619L,2357L,3167L,4049L,5003L,6029L,7127L,8297L,9539L,10853L,12239L,13697L,15227L,16829L,18503L,20249L,22067L,23957L,25919L,27953L,30059L,32237L,34487L,36809L,39203L,41669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117081Inst : IEnumerable<long>
{
public static readonly long[] Value=A117081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117081.Bytes);
public long this[int i]=>Value[i];

public static A117081Inst Instance=new A117081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117082
{
public static readonly long[] Value={ 0L,1L,8L,341L,1160L,4485L,6816L,9633L,12936L,16725L,20501L,25761L,30401L,36741L,42960L,64533L,81345L,90480L,131880L,143445L,168033L,181056L,208560L,238008L,253461L,269400L,302736L,338016L,375240L,414408L,434721L,455520L,520833L,590520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117082Inst : IEnumerable<long>
{
public static readonly long[] Value=A117082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117082.Bytes);
public long this[int i]=>Value[i];

public static A117082Inst Instance=new A117082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117083
{
public static readonly long[] Value={ 0L,1L,8L,40L,280L,408L,560L,1045L,1160L,1408L,1680L,2640L,3008L,3201L,3400L,3605L,4033L,4720L,5208L,5720L,7105L,7400L,7701L,8008L,8640L,10325L,10680L,11041L,11408L,12160L,14560L,15408L,16280L,18096L,19040L,20008L,20501L,21000L,21505L,22016L,23056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117083Inst : IEnumerable<long>
{
public static readonly long[] Value=A117083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117083.Bytes);
public long this[int i]=>Value[i];

public static A117083Inst Instance=new A117083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117084
{
public static readonly long[] Value={ 0L,1L,8L,1160L,20501L,30401L,42960L,90480L,131880L,168033L,181056L,208560L,238008L,269400L,302736L,338016L,375240L,414408L,455520L,520833L,590520L,690240L,743016L,770133L,854400L,913008L,943041L,1004565L,1036056L,1068033L,1100496L,1235208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117084Inst : IEnumerable<long>
{
public static readonly long[] Value=A117084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117084.Bytes);
public long this[int i]=>Value[i];

public static A117084Inst Instance=new A117084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117085
{
public static readonly BigInteger[] Value={ 9L,37L,593L,18977L,4858113L,19898830849L,10432718228160513L,BigInteger.Parse("11202045899583117393395713"),BigInteger.Parse("3153095608696857509125380749498911817729"),BigInteger.Parse("476482336633392067336089761008918511215119000704844672205324289") };
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
public class A117085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117085Inst Instance=new A117085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117086
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,12L,20L,26L,37L,45L,71L,84L,117L,152L,203L,253L,342L,421L,556L,694L,884L,1096L,1409L,1729L,2168L,2672L,3327L,4061L,5039L,6114L,7514L,9110L,11098L,13400L,16275L,19537L,23575L,28245L,33929L,40465L,48424L,57552L,68569L,81296L,96449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117086Inst : IEnumerable<long>
{
public static readonly long[] Value=A117086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117086.Bytes);
public long this[int i]=>Value[i];

public static A117086Inst Instance=new A117086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117087
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,7L,14L,17L,26L,34L,53L,62L,94L,116L,157L,202L,275L,336L,452L,555L,719L,898L,1155L,1411L,1797L,2207L,2758L,3375L,4202L,5094L,6303L,7633L,9337L,11288L,13730L,16500L,19998L,23958L,28832L,34439L,41302L,49120L,58671L,69589L,82718L,97867L,115956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117087Inst : IEnumerable<long>
{
public static readonly long[] Value=A117087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117087.Bytes);
public long this[int i]=>Value[i];

public static A117087Inst Instance=new A117087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117088
{
public static readonly long[] Value={ 1L,12L,67L,342L,1717L,8592L,42967L,214842L,1074217L,5371092L,26855467L,134277342L,671386717L,3356933592L,16784667967L,83923339842L,419616699217L,2098083496092L,10490417480467L,52452087402342L,262260437011717L,1311302185058592L,6556510925292967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117088Inst : IEnumerable<long>
{
public static readonly long[] Value=A117088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117088.Bytes);
public long this[int i]=>Value[i];

public static A117088Inst Instance=new A117088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117089
{
public static readonly long[] Value={ 5L,11L,19L,23L,37L,41L,53L,59L,83L,89L,113L,131L,167L,173L,179L,229L,251L,269L,293L,313L,317L,383L,389L,439L,443L,509L,599L,641L,683L,859L,929L,1031L,1033L,1049L,1163L,1193L,1283L,1301L,1303L,1307L,1439L,1493L,1499L,1543L,1619L,1733L,2143L,2153L,2333L,2687L,2693L,3083L,3089L,3533L,3719L,3989L,4003L,4583L,4673L,4703L,5387L,5651L,5849L,5903L,6173L,6389L,6449L,7481L,9293L,12113L,15803L,16433L,19763L,61403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117089Inst : IEnumerable<long>
{
public static readonly long[] Value=A117089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117089.Bytes);
public long this[int i]=>Value[i];

public static A117089Inst Instance=new A117089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117090
{
public static readonly long[] Value={ 10729L,5273L,2273L,829L,257L,89L,73L,173L,569L,1657L,4049L,8573L,16273L,28409L,46457L,72109L,107273L,154073L,214849L,292157L,507673L,825389L,1883773L,2260529L,4357673L,5834657L,8717273L,19496657L,26342573L,31815257L,67625969L,104356457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117090Inst : IEnumerable<long>
{
public static readonly long[] Value=A117090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117090.Bytes);
public long this[int i]=>Value[i];

public static A117090Inst Instance=new A117090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117091
{
public static readonly long[] Value={ 100823L,30467L,5419L,89L,719L,1423L,947L,149L,199L,1499L,3323L,4177L,2879L,359L,2179L,21773L,84407L,231859L,527819L,1967023L,13443239L,19869323L,55748639L,75716119L,101253923L,173883799L,285153899L,449885327L,557975279L,686780659L,1475059259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117091Inst : IEnumerable<long>
{
public static readonly long[] Value=A117091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117091.Bytes);
public long this[int i]=>Value[i];

public static A117091Inst Instance=new A117091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117092
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,10L,11L,12L,13L,16L,17L,19L,22L,23L,27L,28L,29L,31L,37L,40L,41L,42L,43L,45L,46L,47L,52L,53L,57L,58L,59L,60L,61L,66L,67L,70L,71L,72L,73L,79L,82L,83L,87L,88L,89L,97L,100L,101L,102L,103L,106L,107L,108L,109L,112L,113L,126L,127L,129L,130L,131L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117092Inst : IEnumerable<long>
{
public static readonly long[] Value=A117092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117092.Bytes);
public long this[int i]=>Value[i];

public static A117092Inst Instance=new A117092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117093
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,16L,17L,18L,19L,23L,28L,29L,30L,31L,37L,38L,39L,40L,41L,43L,47L,53L,58L,59L,61L,67L,71L,72L,73L,78L,79L,81L,82L,83L,88L,89L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117093Inst : IEnumerable<long>
{
public static readonly long[] Value=A117093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117093.Bytes);
public long this[int i]=>Value[i];

public static A117093Inst Instance=new A117093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117094
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,18L,19L,23L,28L,29L,31L,37L,40L,41L,43L,47L,53L,59L,60L,61L,67L,71L,72L,73L,78L,79L,82L,83L,89L,96L,97L,101L,102L,103L,105L,106L,107L,109L,113L,127L,131L,137L,139L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117094Inst : IEnumerable<long>
{
public static readonly long[] Value=A117094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117094.Bytes);
public long this[int i]=>Value[i];

public static A117094Inst Instance=new A117094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117095
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,42L,43L,46L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117095Inst : IEnumerable<long>
{
public static readonly long[] Value=A117095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117095.Bytes);
public long this[int i]=>Value[i];

public static A117095Inst Instance=new A117095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117096
{
public static readonly long[] Value={ 1L,6L,8L,9L,14L,15L,18L,20L,21L,24L,25L,26L,30L,32L,33L,34L,35L,36L,38L,39L,44L,48L,49L,50L,51L,54L,55L,56L,62L,63L,64L,65L,68L,69L,74L,75L,76L,77L,78L,80L,81L,84L,85L,86L,90L,91L,92L,93L,94L,95L,96L,98L,99L,104L,105L,110L,111L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117096Inst : IEnumerable<long>
{
public static readonly long[] Value=A117096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117096.Bytes);
public long this[int i]=>Value[i];

public static A117096Inst Instance=new A117096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117097
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,10L,12L,14L,15L,20L,21L,22L,24L,25L,26L,27L,32L,33L,34L,35L,36L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,60L,62L,63L,64L,65L,66L,68L,69L,70L,74L,75L,76L,77L,80L,84L,85L,86L,87L,90L,91L,92L,93L,94L,102L,104L,105L,110L,111L,112L,114L,115L,116L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117097Inst : IEnumerable<long>
{
public static readonly long[] Value=A117097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117097.Bytes);
public long this[int i]=>Value[i];

public static A117097Inst Instance=new A117097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117098
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,10L,12L,14L,15L,16L,20L,21L,22L,24L,25L,26L,27L,30L,32L,33L,34L,35L,36L,38L,39L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,62L,63L,64L,65L,66L,68L,69L,70L,74L,75L,76L,77L,80L,81L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117098Inst : IEnumerable<long>
{
public static readonly long[] Value=A117098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117098.Bytes);
public long this[int i]=>Value[i];

public static A117098Inst Instance=new A117098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117099
{
public static readonly long[] Value={ 4L,10L,12L,16L,22L,27L,28L,40L,42L,45L,46L,52L,57L,58L,60L,66L,70L,72L,82L,87L,88L,100L,102L,106L,108L,112L,126L,129L,130L,136L,147L,148L,150L,159L,160L,161L,162L,166L,169L,170L,171L,172L,177L,178L,180L,190L,192L,195L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117099Inst : IEnumerable<long>
{
public static readonly long[] Value=A117099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117099.Bytes);
public long this[int i]=>Value[i];

public static A117099Inst Instance=new A117099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117100
{
public static readonly long[] Value={ 16L,18L,28L,30L,38L,39L,40L,58L,72L,78L,81L,82L,88L,95L,96L,98L,99L,100L,106L,108L,130L,138L,148L,150L,156L,170L,171L,172L,175L,176L,177L,178L,196L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117100Inst : IEnumerable<long>
{
public static readonly long[] Value=A117100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117100.Bytes);
public long this[int i]=>Value[i];

public static A117100Inst Instance=new A117100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117101
{
public static readonly long[] Value={ 18L,28L,40L,60L,72L,78L,82L,96L,102L,105L,106L,155L,156L,166L,178L,180L,192L,222L,226L,228L,250L,262L,266L,267L,268L,270L,280L,282L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117101Inst : IEnumerable<long>
{
public static readonly long[] Value=A117101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117101.Bytes);
public long this[int i]=>Value[i];

public static A117101Inst Instance=new A117101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117102
{
public static readonly long[] Value={ 4L,16L,18L,42L,126L,126L,136L,70L,58L,292L,822L,1872L,1446L,1008L,3318L,2026L,2280L,2842L,7726L,17922L,2136L,5022L,20142L,17550L,19540L,68898L,59082L,18792L,90006L,136540L,246888L,392382L,197088L,144060L,819898L,137956L,1555162L,291198L,909772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117102Inst : IEnumerable<long>
{
public static readonly long[] Value=A117102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117102.Bytes);
public long this[int i]=>Value[i];

public static A117102Inst Instance=new A117102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117103
{
public static readonly long[] Value={ 27L,39L,105L,279L,629L,597L,1661L,1875L,3777L,13961L,15491L,33585L,87401L,11445L,28877L,113451L,265115L,146189L,584705L,668525L,1370667L,1582581L,1471865L,2193351L,2932901L,3832635L,3571617L,3617721L,15131459L,31245831L,11442269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117103Inst : IEnumerable<long>
{
public static readonly long[] Value=A117103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117103.Bytes);
public long this[int i]=>Value[i];

public static A117103Inst Instance=new A117103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117104
{
public static readonly long[] Value={ 2L,8L,14L,19L,25L,35L,36L,41L,52L,56L,62L,68L,73L,82L,88L,89L,99L,110L,113L,115L,119L,130L,136L,146L,149L,155L,162L,166L,167L,182L,190L,193L,196L,203L,207L,223L,224L,229L,236L,242L,244L,253L,260L,269L,270L,287L,290L,293L,296L,301L,304L,316L,320L,337L,341L,343L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117104Inst : IEnumerable<long>
{
public static readonly long[] Value=A117104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117104.Bytes);
public long this[int i]=>Value[i];

public static A117104Inst Instance=new A117104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117105
{
public static readonly long[] Value={ 3L,9L,15L,20L,21L,26L,32L,36L,37L,42L,43L,48L,53L,54L,57L,59L,63L,69L,70L,74L,75L,80L,83L,86L,89L,90L,91L,95L,96L,100L,102L,106L,107L,111L,114L,116L,116L,116L,117L,120L,122L,123L,123L,126L,128L,131L,133L,137L,143L,144L,147L,148L,149L,150L,153L,154L,156L,162L,163L,164L,165L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117105Inst : IEnumerable<long>
{
public static readonly long[] Value=A117105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117105.Bytes);
public long this[int i]=>Value[i];

public static A117105Inst Instance=new A117105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117106
{
public static readonly long[] Value={ 1L,2L,6L,23L,104L,530L,2958L,17734L,112657L,750726L,5207910L,37387881L,276467208L,2097763554L,16282567502L,128951419810L,1039752642231L,8520041699078L,70840843420234L,596860116487097L,5089815866230374L,43886435477701502L,382269003235832006L,3361054683237796748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117106Inst : IEnumerable<long>
{
public static readonly long[] Value=A117106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117106.Bytes);
public long this[int i]=>Value[i];

public static A117106Inst Instance=new A117106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117107
{
public static readonly long[] Value={ 1L,1L,3L,12L,57L,304L,1765L,10943L,71519L,488186L,3456526L,25251479L,189545179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117107Inst : IEnumerable<long>
{
public static readonly long[] Value=A117107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117107.Bytes);
public long this[int i]=>Value[i];

public static A117107Inst Instance=new A117107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117108
{
public static readonly long[] Value={ 1L,3L,9L,16L,34L,43L,83L,100L,155L,182L,285L,292L,454L,473L,636L,696L,968L,929L,1329L,1304L,1678L,1735L,2299L,2136L,2890L,2818L,3489L,3484L,4494L,4052L,5455L,5168L,6250L,6168L,7652L,6988L,9138L,8547L,10196L,9840L,12340L,10954L,14189L,13140L,15380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117108Inst : IEnumerable<long>
{
public static readonly long[] Value=A117108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117108.Bytes);
public long this[int i]=>Value[i];

public static A117108Inst Instance=new A117108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117109
{
public static readonly long[] Value={ 1L,4L,14L,30L,69L,107L,209L,295L,480L,641L,1000L,1209L,1819L,2166L,2976L,3546L,4844L,5379L,7314L,8110L,10402L,11645L,14949L,15890L,20405L,21927L,26910L,29055L,35959L,37108L,46375L,48484L,57890L,61196L,73536L,75027L,91389L,93951L,110096L,114260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117109Inst : IEnumerable<long>
{
public static readonly long[] Value=A117109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117109.Bytes);
public long this[int i]=>Value[i];

public static A117109Inst Instance=new A117109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117110
{
public static readonly long[] Value={ 0L,1L,7L,22L,100L,376L,1552L,6112L,24640L,98176L,393472L,1572352L,6292480L,25163776L,100667392L,402644992L,1610629120L,6442418176L,25769869312L,103079084032L,412317122560L,1649266917376L,6597070815232L,26388276969472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117110Inst : IEnumerable<long>
{
public static readonly long[] Value=A117110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117110.Bytes);
public long this[int i]=>Value[i];

public static A117110Inst Instance=new A117110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117111
{
public static readonly long[] Value={ 4L,10L,16L,21L,22L,27L,28L,33L,37L,38L,39L,43L,44L,49L,50L,54L,55L,58L,60L,61L,64L,66L,70L,71L,72L,75L,76L,77L,81L,82L,84L,87L,88L,90L,91L,92L,93L,96L,97L,98L,101L,102L,103L,104L,107L,108L,109L,112L,113L,114L,115L,117L,118L,120L,121L,123L,124L,125L,127L,129L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117111Inst : IEnumerable<long>
{
public static readonly long[] Value=A117111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117111.Bytes);
public long this[int i]=>Value[i];

public static A117111Inst Instance=new A117111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117112
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,29L,31L,37L,43L,61L,67L,73L,79L,83L,97L,101L,127L,137L,139L,151L,157L,163L,181L,191L,193L,199L,211L,227L,241L,263L,277L,281L,307L,331L,353L,367L,373L,379L,389L,409L,421L,433L,443L,461L,463L,487L,499L,541L,571L,577L,587L,601L,619L,631L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117112Inst : IEnumerable<long>
{
public static readonly long[] Value=A117112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117112.Bytes);
public long this[int i]=>Value[i];

public static A117112Inst Instance=new A117112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117113
{
public static readonly long[] Value={ 2L,2L,4L,3L,3L,2L,4L,4L,2L,1L,4L,2L,5L,3L,2L,2L,4L,3L,2L,2L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117113Inst : IEnumerable<long>
{
public static readonly long[] Value=A117113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117113.Bytes);
public long this[int i]=>Value[i];

public static A117113Inst Instance=new A117113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117114
{
public static readonly long[] Value={ 2L,2L,3L,4L,3L,3L,2L,4L,5L,3L,3L,1L,3L,3L,4L,6L,2L,4L,5L,1L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117114Inst : IEnumerable<long>
{
public static readonly long[] Value=A117114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117114.Bytes);
public long this[int i]=>Value[i];

public static A117114Inst Instance=new A117114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117115
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,11L,14L,21L,24L,34L,37L,51L,58L,75L,82L,110L,117L,148L,161L,202L,215L,265L,278L,342L,365L,436L,459L,557L,580L,685L,722L,855L,892L,1046L,1083L,1268L,1325L,1523L,1580L,1839L,1896L,2168L,2251L,2573L,2656L,3017L,3100L,3525L,3644L,4092L,4211L,4766L,4885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117115Inst : IEnumerable<long>
{
public static readonly long[] Value=A117115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117115.Bytes);
public long this[int i]=>Value[i];

public static A117115Inst Instance=new A117115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117116
{
public static readonly BigInteger[] Value={ 1L,2L,9L,145L,37986L,2345721887L,BigInteger.Parse("26943815937041299094"),BigInteger.Parse("811625643619814151937413504618770581764"),BigInteger.Parse("697120590223140234675813998970770820981012350673738243594006422610850113672220") };
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
public class A117116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117116Inst Instance=new A117116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117117
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,8L,13L,15L,21L,29L,37L,45L,62L,70L,89L,108L,132L,151L,191L,210L,256L,296L,350L,390L,476L,516L,610L,684L,795L,869L,1025L,1099L,1274L,1399L,1593L,1718L,1994L,2119L,2414L,2614L,2949L,3149L,3585L,3785L,4267L,4577L,5099L,5409L,6102L,6412L,7145L,7603L,8422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117117Inst : IEnumerable<long>
{
public static readonly long[] Value=A117117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117117.Bytes);
public long this[int i]=>Value[i];

public static A117117Inst Instance=new A117117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117118
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,0L,1L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,0L,2L,1L,2L,2L,2L,1L,3L,1L,2L,3L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,3L,3L,1L,3L,1L,2L,3L,2L,1L,2L,0L,2L,2L,2L,1L,4L,1L,2L,2L,2L,2L,4L,1L,2L,3L,2L,1L,3L,2L,2L,3L,2L,2L,3L,1L,2L,3L,2L,1L,2L,2L,3L,1L,2L,2L,2L,2L,2L,3L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117118Inst : IEnumerable<long>
{
public static readonly long[] Value=A117118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117118.Bytes);
public long this[int i]=>Value[i];

public static A117118Inst Instance=new A117118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117119
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,5L,6L,6L,6L,7L,8L,6L,9L,7L,6L,8L,7L,6L,8L,7L,7L,9L,8L,7L,9L,8L,7L,11L,9L,7L,12L,8L,7L,9L,9L,8L,10L,8L,9L,12L,11L,9L,12L,9L,8L,13L,9L,8L,13L,10L,11L,14L,11L,8L,13L,12L,10L,13L,9L,9L,16L,10L,11L,14L,10L,10L,15L,10L,9L,16L,12L,9L,16L,12L,11L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117119Inst : IEnumerable<long>
{
public static readonly long[] Value=A117119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117119.Bytes);
public long this[int i]=>Value[i];

public static A117119Inst Instance=new A117119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117120
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,11L,10L,9L,8L,15L,14L,13L,12L,23L,22L,21L,20L,19L,18L,17L,16L,31L,30L,29L,28L,27L,26L,25L,24L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,95L,94L,93L,92L,91L,90L,89L,88L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117120Inst : IEnumerable<long>
{
public static readonly long[] Value=A117120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117120.Bytes);
public long this[int i]=>Value[i];

public static A117120Inst Instance=new A117120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117121
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,11L,12L,15L,18L,22L,25L,36L,39L,44L,45L,55L,66L,72L,74L,75L,88L,99L,111L,125L,132L,135L,148L,167L,182L,198L,222L,225L,239L,259L,264L,271L,275L,296L,351L,369L,375L,378L,396L,399L,444L,455L,478L,481L,495L,525L,555L,585L,666L,675L,876L,888L,925L,984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117121Inst : IEnumerable<long>
{
public static readonly long[] Value=A117121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117121.Bytes);
public long this[int i]=>Value[i];

public static A117121Inst Instance=new A117121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117122
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,7L,4L,2L,2L,2L,3L,6L,7L,2L,4L,10L,2L,10L,2L,6L,3L,10L,4L,2L,7L,3L,8L,10L,2L,9L,5L,2L,10L,7L,3L,3L,10L,6L,3L,5L,6L,9L,3L,2L,10L,10L,4L,10L,2L,10L,7L,10L,4L,3L,7L,10L,10L,10L,3L,10L,9L,6L,5L,7L,3L,9L,10L,10L,7L,10L,4L,6L,4L,3L,10L,6L,5L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117122Inst : IEnumerable<long>
{
public static readonly long[] Value=A117122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117122.Bytes);
public long this[int i]=>Value[i];

public static A117122Inst Instance=new A117122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117123
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,5L,7L,5L,7L,8L,10L,10L,12L,13L,15L,12L,14L,15L,17L,17L,19L,20L,22L,21L,23L,24L,26L,26L,28L,29L,31L,27L,29L,30L,32L,32L,34L,35L,37L,36L,38L,39L,41L,41L,43L,44L,46L,44L,46L,47L,49L,49L,51L,52L,54L,53L,55L,56L,58L,58L,60L,61L,63L,58L,60L,61L,63L,63L,65L,66L,68L,67L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117123Inst : IEnumerable<long>
{
public static readonly long[] Value=A117123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117123.Bytes);
public long this[int i]=>Value[i];

public static A117123Inst Instance=new A117123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117124
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,18L,21L,24L,27L,33L,66L,99L,132L,273L,303L,333L,363L,393L,423L,453L,483L,513L,546L,576L,606L,636L,666L,696L,726L,756L,819L,849L,879L,909L,939L,969L,999L,1092L,1122L,1152L,1182L,1212L,1242L,1365L,1395L,1425L,1455L,1485L,1638L,1668L,1698L,1728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117124Inst : IEnumerable<long>
{
public static readonly long[] Value=A117124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117124.Bytes);
public long this[int i]=>Value[i];

public static A117124Inst Instance=new A117124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117125
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,9L,15L,16L,21L,22L,23L,72L,105L,112L,117L,118L,119L,336L,615L,672L,705L,712L,717L,718L,719L,1200L,4095L,4656L,4935L,4992L,5025L,5032L,5037L,5038L,5039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117125Inst : IEnumerable<long>
{
public static readonly long[] Value=A117125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117125.Bytes);
public long this[int i]=>Value[i];

public static A117125Inst Instance=new A117125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117126
{
public static readonly long[] Value={ 1L,5L,3L,7L,2L,7L,27L,8L,1L,1L,9L,11L,27L,27L,6L,13L,45L,5L,45L,5L,27L,9L,45L,11L,4L,27L,10L,30L,45L,3L,38L,11L,3L,45L,27L,9L,9L,45L,18L,7L,18L,27L,39L,9L,2L,45L,45L,13L,45L,2L,45L,28L,45L,14L,9L,27L,45L,45L,45L,7L,45L,38L,24L,14L,27L,6L,39L,45L,45L,27L,45L,12L,27L,9L,4L,45L,27L,16L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117126Inst : IEnumerable<long>
{
public static readonly long[] Value=A117126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117126.Bytes);
public long this[int i]=>Value[i];

public static A117126Inst Instance=new A117126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117127
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,3L,1L,2L,1L,4L,3L,4L,5L,4L,1L,2L,2L,3L,2L,3L,2L,7L,3L,4L,4L,6L,6L,5L,7L,5L,1L,2L,2L,3L,1L,4L,3L,4L,2L,4L,2L,5L,2L,4L,4L,9L,3L,4L,5L,5L,4L,6L,4L,9L,6L,6L,6L,7L,9L,6L,9L,6L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,5L,2L,6L,4L,5L,2L,4L,3L,6L,3L,5L,4L,7L,2L,5L,4L,7L,3L,7L,5L,11L,3L,4L,5L,5L,4L,7L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117127Inst : IEnumerable<long>
{
public static readonly long[] Value=A117127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117127.Bytes);
public long this[int i]=>Value[i];

public static A117127Inst Instance=new A117127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117128
{
public static readonly long[] Value={ 1L,3L,6L,11L,4L,15L,2L,19L,38L,61L,32L,63L,26L,67L,24L,71L,18L,77L,16L,83L,12L,85L,164L,81L,170L,73L,174L,277L,384L,275L,162L,35L,166L,29L,168L,317L,468L,311L,148L,315L,142L,321L,140L,331L,138L,335L,136L,347L,124L,351L,122L,355L,116L,357L,106L,363L,100L,369L,98L,375L,94L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117128Inst : IEnumerable<long>
{
public static readonly long[] Value=A117128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117128.Bytes);
public long this[int i]=>Value[i];

public static A117128Inst Instance=new A117128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117129
{
public static readonly long[] Value={ 641L,1213L,2617L,2957L,3727L,5443L,9283L,17359L,33829L,66173L,131303L,264763L,494743L,957547L,1888157L,3753647L,7490797L,14961157L,29899357L,59773871L,119551489L,239106347L,478234723L,956607929L,1913366111L,3826828409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117129Inst : IEnumerable<long>
{
public static readonly long[] Value=A117129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117129.Bytes);
public long this[int i]=>Value[i];

public static A117129Inst Instance=new A117129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117130
{
public static readonly long[] Value={ 0L,0L,0L,1L,7L,37L,197L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117130Inst : IEnumerable<long>
{
public static readonly long[] Value=A117130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117130.Bytes);
public long this[int i]=>Value[i];

public static A117130Inst Instance=new A117130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117131
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,12L,12L,7L,2L,6L,24L,26L,11L,6L,30L,15L,9L,41L,39L,32L,51L,64L,78L,4L,72L,43L,89L,25L,31L,109L,26L,62L,80L,36L,9L,72L,132L,140L,105L,52L,132L,135L,117L,147L,79L,193L,93L,49L,175L,76L,64L,187L,196L,9L,163L,221L,190L,62L,102L,280L,71L,87L,102L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117131Inst : IEnumerable<long>
{
public static readonly long[] Value=A117131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117131.Bytes);
public long this[int i]=>Value[i];

public static A117131Inst Instance=new A117131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117132
{
public static readonly long[] Value={ 8L,14L,32L,80L,138L,144L,236L,284L,302L,342L,344L,390L,420L,438L,446L,510L,542L,546L,570L,612L,638L,644L,680L,690L,696L,768L,794L,804L,812L,816L,822L,834L,866L,888L,908L,942L,960L,1020L,1022L,1148L,1190L,1194L,1224L,1250L,1278L,1358L,1368L,1398L,1434L,1446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117132Inst : IEnumerable<long>
{
public static readonly long[] Value=A117132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117132.Bytes);
public long this[int i]=>Value[i];

public static A117132Inst Instance=new A117132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117133
{
public static readonly long[] Value={ 3L,14L,52L,78L,133L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117133Inst : IEnumerable<long>
{
public static readonly long[] Value=A117133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117133.Bytes);
public long this[int i]=>Value[i];

public static A117133Inst Instance=new A117133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117134
{
public static readonly long[] Value={ 3L,4L,7L,6L,17L,8L,21L,20L,24L,12L,70L,14L,32L,55L,63L,18L,80L,20L,99L,73L,48L,24L,191L,78L,56L,121L,130L,30L,224L,32L,204L,108L,72L,203L,323L,38L,80L,126L,398L,42L,293L,44L,193L,505L,96L,48L,575L,200L,312L,162L,225L,54L,485L,302L,522L,180L,120L,60L,898L,62L,128L,660L,682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117134Inst : IEnumerable<long>
{
public static readonly long[] Value=A117134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117134.Bytes);
public long this[int i]=>Value[i];

public static A117134Inst Instance=new A117134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117135
{
public static readonly long[] Value={ 2L,3L,5L,7L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,269L,349L,359L,367L,379L,389L,397L,439L,449L,457L,467L,479L,487L,499L,547L,557L,569L,577L,587L,593L,599L,647L,659L,673L,677L,683L,739L,757L,769L,773L,787L,797L,827L,829L,839L,853L,857L,859L,863L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117135Inst : IEnumerable<long>
{
public static readonly long[] Value=A117135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117135.Bytes);
public long this[int i]=>Value[i];

public static A117135Inst Instance=new A117135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117136
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,1L,3L,6L,2L,7L,1L,1L,4L,8L,3L,9L,2L,10L,1L,1L,5L,10L,4L,11L,3L,12L,2L,13L,1L,1L,6L,12L,5L,13L,4L,14L,3L,15L,2L,16L,1L,1L,7L,14L,6L,15L,5L,16L,4L,17L,3L,18L,2L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117136Inst : IEnumerable<long>
{
public static readonly long[] Value=A117136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117136.Bytes);
public long this[int i]=>Value[i];

public static A117136Inst Instance=new A117136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117137
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,3L,6L,2L,7L,1L,4L,8L,3L,9L,2L,10L,1L,5L,10L,4L,11L,3L,12L,2L,13L,1L,6L,12L,5L,13L,4L,14L,3L,15L,2L,16L,1L,7L,14L,6L,15L,5L,16L,4L,17L,3L,18L,2L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117137Inst : IEnumerable<long>
{
public static readonly long[] Value=A117137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117137.Bytes);
public long this[int i]=>Value[i];

public static A117137Inst Instance=new A117137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117138
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,0L,0L,2L,5L,1L,6L,0L,0L,3L,7L,2L,8L,1L,9L,0L,0L,4L,9L,3L,10L,2L,11L,1L,12L,0L,0L,5L,11L,4L,12L,3L,13L,2L,14L,1L,15L,0L,0L,6L,13L,5L,14L,4L,15L,3L,16L,2L,17L,1L,18L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117138Inst : IEnumerable<long>
{
public static readonly long[] Value=A117138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117138.Bytes);
public long this[int i]=>Value[i];

public static A117138Inst Instance=new A117138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117139
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,2L,5L,1L,6L,0L,3L,7L,2L,8L,1L,9L,0L,4L,9L,3L,10L,2L,11L,1L,12L,0L,5L,11L,4L,12L,3L,13L,2L,14L,1L,15L,0L,6L,13L,5L,14L,4L,15L,3L,16L,2L,17L,1L,18L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117139Inst : IEnumerable<long>
{
public static readonly long[] Value=A117139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117139.Bytes);
public long this[int i]=>Value[i];

public static A117139Inst Instance=new A117139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117140
{
public static readonly long[] Value={ 5L,7L,12L,17L,19L,22L,26L,27L,32L,33L,36L,37L,40L,42L,46L,50L,56L,60L,66L,70L,71L,74L,81L,85L,91L,99L,101L,132L,138L,140L,150L,154L,156L,158L,160L,179L,181L,185L,189L,195L,205L,209L,233L,234L,236L,240L,248L,258L,264L,268L,287L,289L,293L,297L,303L,336L,340L,342L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117140Inst : IEnumerable<long>
{
public static readonly long[] Value=A117140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117140.Bytes);
public long this[int i]=>Value[i];

public static A117140Inst Instance=new A117140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117141
{
public static readonly BigInteger[] Value={ 2L,7L,47L,383L,10321919L,51011754393599L,BigInteger.Parse("1130138339199322632554990773529330319359999999"),BigInteger.Parse("73562883979319395645666688474019139929848516028923903999999999") };
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
public class A117141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117141Inst Instance=new A117141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117142
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,14L,15L,20L,21L,27L,28L,35L,36L,44L,45L,54L,55L,65L,66L,77L,78L,90L,91L,104L,105L,119L,120L,135L,136L,152L,153L,170L,171L,189L,190L,209L,210L,230L,231L,252L,253L,275L,276L,299L,300L,324L,325L,350L,351L,377L,378L,405L,406L,434L,435L,464L,465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117142Inst : IEnumerable<long>
{
public static readonly long[] Value=A117142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117142.Bytes);
public long this[int i]=>Value[i];

public static A117142Inst Instance=new A117142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117143
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,13L,17L,22L,27L,33L,41L,48L,57L,68L,78L,90L,105L,118L,134L,153L,170L,190L,214L,235L,260L,289L,315L,345L,380L,411L,447L,488L,525L,567L,615L,658L,707L,762L,812L,868L,931L,988L,1052L,1123L,1188L,1260L,1340L,1413L,1494L,1583L,1665L,1755L,1854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117143Inst : IEnumerable<long>
{
public static readonly long[] Value=A117143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117143.Bytes);
public long this[int i]=>Value[i];

public static A117143Inst Instance=new A117143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117144
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,6L,8L,9L,10L,12L,15L,16L,19L,21L,25L,28L,32L,34L,41L,46L,51L,55L,64L,70L,79L,86L,97L,106L,119L,129L,146L,159L,175L,190L,214L,232L,256L,277L,306L,334L,367L,394L,434L,472L,515L,556L,607L,654L,714L,770L,836L,901L,978L,1048L,1140L,1226L,1322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117144Inst : IEnumerable<long>
{
public static readonly long[] Value=A117144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117144.Bytes);
public long this[int i]=>Value[i];

public static A117144Inst Instance=new A117144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117145
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,2L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,2L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117145Inst : IEnumerable<long>
{
public static readonly long[] Value=A117145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117145.Bytes);
public long this[int i]=>Value[i];

public static A117145Inst Instance=new A117145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117146
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,20L,27L,34L,40L,50L,60L,70L,85L,100L,115L,136L,156L,176L,206L,234L,261L,300L,336L,370L,418L,466L,511L,572L,633L,690L,765L,840L,914L,1008L,1102L,1194L,1307L,1420L,1530L,1668L,1806L,1940L,2107L,2272L,2431L,2626L,2825L,3016L,3246L,3484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117146Inst : IEnumerable<long>
{
public static readonly long[] Value=A117146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117146.Bytes);
public long this[int i]=>Value[i];

public static A117146Inst Instance=new A117146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117147
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,3L,3L,2L,1L,3L,4L,3L,1L,1L,4L,5L,4L,2L,1L,4L,7L,6L,3L,1L,1L,5L,8L,9L,5L,1L,1L,5L,10L,11L,8L,3L,1L,6L,12L,14L,11L,5L,1L,1L,6L,14L,18L,15L,8L,2L,1L,7L,16L,23L,20L,11L,4L,1L,7L,19L,27L,27L,17L,6L,1L,1L,8L,21L,33L,34L,23L,10L,2L,1L,8L,24L,39L,43L,32L,15L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117147Inst : IEnumerable<long>
{
public static readonly long[] Value=A117147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117147.Bytes);
public long this[int i]=>Value[i];

public static A117147Inst Instance=new A117147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117148
{
public static readonly long[] Value={ 1L,3L,6L,8L,15L,24L,36L,50L,75L,102L,143L,197L,264L,349L,467L,606L,789L,1016L,1299L,1656L,2100L,2634L,3302L,4117L,5106L,6306L,7772L,9523L,11639L,14185L,17216L,20839L,25166L,30280L,36361L,43551L,52022L,62004L,73753L,87510L,103638L,122507L,144496L,170133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117148Inst : IEnumerable<long>
{
public static readonly long[] Value=A117148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117148.Bytes);
public long this[int i]=>Value[i];

public static A117148Inst Instance=new A117148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117149
{
public static readonly long[] Value={ 4L,6L,10L,17L,12L,20L,34L,58L,99L,70L,119L,84L,143L,101L,72L,122L,208L,355L,251L,178L,303L,214L,365L,258L,440L,751L,531L,376L,641L,453L,321L,227L,161L,114L,194L,331L,234L,399L,282L,481L,340L,580L,990L,1690L,2885L,2040L,3482L,5944L,10147L,7175L,5074L,8661L,6124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117149Inst : IEnumerable<long>
{
public static readonly long[] Value=A117149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117149.Bytes);
public long this[int i]=>Value[i];

public static A117149Inst Instance=new A117149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117150
{
public static readonly long[] Value={ 4L,5L,7L,9L,13L,8L,11L,15L,21L,29L,41L,57L,81L,48L,67L,95L,56L,79L,111L,157L,92L,54L,32L,45L,63L,89L,125L,177L,104L,147L,207L,293L,172L,243L,343L,485L,685L,969L,568L,803L,1135L,1605L,2269L,3209L,1880L,2659L,1558L,2203L,3115L,4405L,6229L,8809L,12457L,17617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117150Inst : IEnumerable<long>
{
public static readonly long[] Value=A117150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117150.Bytes);
public long this[int i]=>Value[i];

public static A117150Inst Instance=new A117150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117151
{
public static readonly long[] Value={ 432541L,838861L,865082L,1468007L,1677722L,1730164L,1887437L,2516583L,2726299L,2936014L,3355444L,3460301L,3460328L,3774874L,5033165L,5033166L,5452598L,5872027L,5872028L,6710888L,6920602L,6920605L,6920656L,7130317L,7549748L,7549749L,10066330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117151Inst : IEnumerable<long>
{
public static readonly long[] Value=A117151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117151.Bytes);
public long this[int i]=>Value[i];

public static A117151Inst Instance=new A117151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117152
{
public static readonly long[] Value={ 0L,0L,1L,7L,25L,75L,195L,468L,1056L,2280L,4755L,9650L,19154L,37328L,71635L,135685L,254125L,471317L,866669L,1581620L,2866970L,5165630L,9256871L,16507092L,29304660L,51812160L,91264885L,160207603L,280340161L,489117135L,851054535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117152Inst : IEnumerable<long>
{
public static readonly long[] Value=A117152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117152.Bytes);
public long this[int i]=>Value[i];

public static A117152Inst Instance=new A117152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117153
{
public static readonly long[] Value={ 3L,-3L,9L,-12L,-15L,0L,33L,-42L,-36L,30L,15L,-54L,-6L,63L,-63L,-15L,54L,-36L,-42L,24L,-12L,-15L,33L,-36L,12L,39L,-30L,3L,15L,27L,39L,9L,54L,12L,33L,51L,18L,99L,60L,0L,87L,84L,36L,60L,96L,45L,102L,93L,42L,93L,111L,57L,114L,129L,57L,132L,138L,78L,81L,165L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117153Inst : IEnumerable<long>
{
public static readonly long[] Value=A117153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117153.Bytes);
public long this[int i]=>Value[i];

public static A117153Inst Instance=new A117153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117154
{
public static readonly long[] Value={ 1L,0L,0L,1L,-1L,2L,0L,1L,0L,0L,1L,-1L,2L,-2L,1L,-2L,0L,-1L,0L,0L,-1L,1L,-2L,2L,-3L,4L,-2L,3L,-2L,2L,-1L,2L,0L,1L,0L,0L,1L,-1L,2L,-2L,3L,-3L,4L,-4L,5L,-4L,4L,-3L,4L,-2L,3L,-2L,2L,-1L,2L,0L,1L,0L,0L,1L,-1L,2L,-2L,3L,-3L,4L,-4L,5L,-5L,6L,-6L,5L,-6L,4L,-5L,4L,-4L,3L,-4L,2L,-3L,2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117154Inst : IEnumerable<long>
{
public static readonly long[] Value=A117154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117154.Bytes);
public long this[int i]=>Value[i];

public static A117154Inst Instance=new A117154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117155
{
public static readonly long[] Value={ 2L,11L,17L,29L,41L,59L,71L,1009L,1087L,1093L,1213L,1279L,1297L,1303L,1429L,1447L,1483L,1489L,1549L,1567L,1579L,1609L,1663L,1693L,1783L,1867L,1873L,1993L,1999L,2039L,2083L,2137L,2203L,2239L,2269L,2293L,2347L,2377L,2389L,2437L,2473L,2539L,2617L,2659L,2683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117155Inst : IEnumerable<long>
{
public static readonly long[] Value=A117155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117155.Bytes);
public long this[int i]=>Value[i];

public static A117155Inst Instance=new A117155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117156
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,110L,630L,4210L,32150L,276210L,2636720L,27687440L,317169270L,3936056080L,52603684760L,753241509900L,11504852242400L,186705357825800L,3208160592252000L,58188413286031600L,1110946958902609400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117156Inst : IEnumerable<long>
{
public static readonly long[] Value=A117156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117156.Bytes);
public long this[int i]=>Value[i];

public static A117156Inst Instance=new A117156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117157
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,4L,11L,49L,548L,26872L,14725925L,395715057217L,5827270253948278214L,BigInteger.Parse("2305938581960065033611659323852"),BigInteger.Parse("13437327306087560724405450621249967248150551970959") };
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
public class A117157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117157Inst Instance=new A117157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117158
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,111L,642L,4326L,33333L,288901L,2782082L,29471046L,340568843L,4263603891L,57482264322L,830335952166L,12793889924553L,209449977967081L,3630626729775362L,66429958806679686L,1279448352687538463L,BigInteger.Parse("25874432578888440471"),BigInteger.Parse("548178875969847203202") };
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
public class A117158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117158Inst Instance=new A117158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117159
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,31L,37L,43L,53L,71L,73L,113L,131L,137L,151L,157L,173L,211L,223L,311L,317L,359L,367L,389L,431L,557L,571L,593L,673L,751L,827L,839L,929L,953L,983L,1117L,1151L,1153L,1171L,1223L,1279L,1297L,1367L,1447L,1511L,1531L,1553L,1571L,1579L,1597L,1621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117159Inst : IEnumerable<long>
{
public static readonly long[] Value=A117159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117159.Bytes);
public long this[int i]=>Value[i];

public static A117159Inst Instance=new A117159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117160
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,19L,43L,94L,210L,464L,1035L,2295L,5111L,11352L,25259L,56145L,124888L,277669L,617554L,1373201L,3053883L,6790995L,15102178L,33583784L,74684504L,166082706L,369337117L,821331578L,1826484804L,4061741926L,9032530513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117160Inst : IEnumerable<long>
{
public static readonly long[] Value=A117160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117160.Bytes);
public long this[int i]=>Value[i];

public static A117160Inst Instance=new A117160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117161
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,73L,157L,358L,785L,1762L,3896L,8702L,19299L,42995L,95507L,212552L,472445L,1050973L,2336670L,5197036L,11556157L,25700188L,57150018L,127093805L,282627186L,628514815L,1397684691L,3108193486L,6911996344L,15370966058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117161Inst : IEnumerable<long>
{
public static readonly long[] Value=A117161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117161.Bytes);
public long this[int i]=>Value[i];

public static A117161Inst Instance=new A117161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117162
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-1L,1L,0L,-2L,-1L,1L,-1L,0L,-2L,-1L,1L,1L,-1L,-1L,-2L,-1L,1L,-1L,1L,-1L,-1L,-2L,-1L,1L,0L,0L,2L,-2L,-1L,-2L,-1L,1L,0L,1L,-1L,2L,-2L,-1L,-2L,-1L,1L,1L,-1L,3L,0L,1L,-2L,-1L,-2L,-1L,1L,-1L,1L,-1L,3L,0L,1L,-2L,-1L,-2L,-1L,1L,0L,2L,2L,0L,4L,-1L,1L,-2L,-1L,-2L,-1L,1L,-1L,0L,2L,2L,0L,4L,-1L,1L,-2L,-1L,-2L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117162Inst : IEnumerable<long>
{
public static readonly long[] Value=A117162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117162.Bytes);
public long this[int i]=>Value[i];

public static A117162Inst Instance=new A117162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117163
{
public static readonly long[] Value={ 0L,1L,-1L,-2L,0L,-1L,1L,0L,1L,-1L,1L,2L,0L,-3L,2L,2L,0L,-1L,0L,1L,0L,-1L,1L,0L,0L,-1L,1L,3L,0L,-1L,-1L,-2L,0L,0L,0L,2L,0L,-2L,2L,2L,0L,2L,-1L,0L,-2L,-2L,1L,-2L,-1L,0L,1L,3L,0L,-1L,-1L,1L,1L,0L,1L,-1L,0L,-1L,0L,1L,0L,2L,-1L,0L,0L,3L,-1L,-2L,0L,-2L,0L,3L,-2L,1L,-1L,-4L,-1L,-1L,1L,-3L,0L,1L,2L,2L,0L,2L,-1L,3L,2L,-1L,1L,4L,0L,1L,-1L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117163Inst : IEnumerable<long>
{
public static readonly long[] Value=A117163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117163.Bytes);
public long this[int i]=>Value[i];

public static A117163Inst Instance=new A117163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117164
{
public static readonly long[] Value={ 0L,0L,1L,-1L,-2L,-1L,-1L,2L,-1L,3L,-1L,2L,2L,1L,-2L,1L,2L,1L,-1L,0L,1L,1L,-1L,-2L,2L,-2L,-1L,2L,3L,1L,-1L,-3L,-2L,-2L,3L,-1L,2L,1L,-5L,0L,2L,-1L,2L,0L,4L,-1L,-2L,-1L,-1L,-4L,-3L,2L,3L,1L,2L,-4L,1L,-2L,0L,0L,-1L,1L,-1L,1L,1L,2L,2L,0L,0L,-4L,3L,-1L,-2L,-2L,-1L,1L,5L,3L,1L,-4L,-3L,-3L,-1L,-2L,-3L,-2L,-3L,1L,2L,-4L,1L,2L,3L,4L,2L,3L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117164Inst : IEnumerable<long>
{
public static readonly long[] Value=A117164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117164.Bytes);
public long this[int i]=>Value[i];

public static A117164Inst Instance=new A117164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117165
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,0L,1L,-1L,-1L,0L,1L,-2L,-1L,0L,0L,1L,1L,-2L,-1L,0L,0L,1L,-1L,-1L,-1L,0L,0L,0L,1L,3L,-2L,-1L,-1L,0L,0L,0L,1L,0L,0L,-2L,-1L,0L,0L,0L,0L,1L,4L,-2L,-1L,-1L,-1L,0L,0L,0L,0L,1L,4L,0L,-2L,-1L,-1L,0L,0L,0L,0L,0L,1L,5L,1L,-1L,-2L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,2L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,1L,7L,0L,0L,-2L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117165Inst : IEnumerable<long>
{
public static readonly long[] Value=A117165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117165.Bytes);
public long this[int i]=>Value[i];

public static A117165Inst Instance=new A117165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117166
{
public static readonly long[] Value={ 1L,-1L,-2L,-1L,-2L,1L,-1L,3L,0L,4L,4L,5L,1L,7L,6L,5L,4L,6L,3L,5L,3L,2L,5L,-3L,-5L,-1L,2L,-7L,-6L,-13L,-9L,-14L,-12L,-22L,-12L,-25L,-23L,-26L,-21L,-35L,-27L,-38L,-27L,-43L,-32L,-47L,-34L,-51L,-46L,-52L,-33L,-53L,-35L,-58L,-41L,-56L,-39L,-54L,-39L,-61L,-45L,-53L,-24L,-46L,-23L,-44L,-20L,-41L,-14L,-32L,-12L,-22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117166Inst : IEnumerable<long>
{
public static readonly long[] Value=A117166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117166.Bytes);
public long this[int i]=>Value[i];

public static A117166Inst Instance=new A117166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117167
{
public static readonly long[] Value={ 0L,1L,0L,-1L,-1L,-2L,-1L,-2L,0L,-2L,0L,1L,2L,0L,3L,3L,4L,4L,6L,5L,7L,6L,7L,10L,7L,4L,7L,10L,7L,8L,5L,7L,6L,6L,1L,5L,0L,-1L,-2L,-1L,-8L,-6L,-11L,-7L,-15L,-12L,-20L,-15L,-24L,-27L,-33L,-25L,-36L,-28L,-41L,-39L,-48L,-42L,-51L,-46L,-61L,-61L,-69L,-58L,-72L,-64L,-77L,-70L,-85L,-76L,-90L,-85L,-94L,-86L,-99L,-84L,-100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117167Inst : IEnumerable<long>
{
public static readonly long[] Value=A117167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117167.Bytes);
public long this[int i]=>Value[i];

public static A117167Inst Instance=new A117167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117168
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,-1L,-1L,-1L,-2L,-1L,-2L,-1L,-1L,0L,-2L,1L,0L,2L,1L,4L,1L,5L,3L,6L,6L,7L,4L,8L,8L,10L,8L,10L,8L,12L,9L,10L,10L,10L,8L,10L,8L,9L,6L,7L,7L,5L,5L,3L,4L,1L,-4L,-5L,-4L,-7L,-6L,-13L,-12L,-17L,-15L,-20L,-18L,-28L,-29L,-37L,-31L,-40L,-37L,-47L,-42L,-55L,-51L,-62L,-59L,-69L,-65L,-78L,-69L,-84L,-75L,-93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117168Inst : IEnumerable<long>
{
public static readonly long[] Value=A117168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117168.Bytes);
public long this[int i]=>Value[i];

public static A117168Inst Instance=new A117168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117169
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,-2L,-1L,-2L,0L,-2L,0L,1L,2L,0L,3L,3L,4L,4L,6L,5L,7L,6L,7L,10L,7L,4L,7L,10L,7L,8L,5L,7L,6L,6L,1L,5L,0L,-1L,-2L,-1L,-8L,-6L,-11L,-7L,-15L,-12L,-20L,-15L,-24L,-27L,-33L,-25L,-36L,-28L,-41L,-39L,-48L,-42L,-51L,-46L,-61L,-61L,-69L,-58L,-72L,-64L,-77L,-70L,-85L,-76L,-90L,-85L,-94L,-86L,-99L,-84L,-100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117169Inst : IEnumerable<long>
{
public static readonly long[] Value=A117169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117169.Bytes);
public long this[int i]=>Value[i];

public static A117169Inst Instance=new A117169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117170
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,1L,0L,1L,3L,1L,0L,0L,1L,3L,2L,1L,0L,0L,1L,4L,1L,1L,0L,0L,0L,1L,3L,3L,1L,1L,0L,0L,0L,1L,6L,1L,2L,1L,0L,0L,0L,0L,1L,5L,4L,1L,1L,1L,0L,0L,0L,0L,1L,5L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,6L,4L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,7L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,7L,6L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117170Inst : IEnumerable<long>
{
public static readonly long[] Value=A117170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117170.Bytes);
public long this[int i]=>Value[i];

public static A117170Inst Instance=new A117170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117171
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,3L,6L,5L,5L,6L,7L,7L,10L,7L,8L,10L,11L,11L,14L,11L,11L,14L,16L,14L,18L,17L,17L,21L,18L,17L,23L,22L,24L,25L,21L,24L,32L,28L,27L,33L,28L,32L,39L,30L,31L,36L,38L,41L,42L,41L,38L,50L,48L,44L,48L,45L,46L,59L,49L,53L,65L,55L,59L,63L,56L,65L,71L,70L,61L,72L,62L,72L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117171Inst : IEnumerable<long>
{
public static readonly long[] Value=A117171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117171.Bytes);
public long this[int i]=>Value[i];

public static A117171Inst Instance=new A117171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117172
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,1L,3L,1L,4L,2L,4L,2L,6L,3L,6L,4L,7L,3L,10L,5L,9L,6L,10L,7L,13L,7L,12L,9L,16L,8L,17L,10L,17L,14L,18L,12L,20L,13L,24L,16L,26L,15L,27L,20L,25L,19L,30L,18L,34L,23L,33L,26L,37L,28L,41L,26L,36L,28L,45L,30L,48L,35L,47L,38L,50L,33L,55L,42L,59L,41L,60L,39L,61L,51L,61L,53L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117172Inst : IEnumerable<long>
{
public static readonly long[] Value=A117172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117172.Bytes);
public long this[int i]=>Value[i];

public static A117172Inst Instance=new A117172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117173
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,2L,3L,4L,4L,3L,6L,4L,6L,6L,4L,6L,10L,6L,6L,9L,9L,8L,11L,8L,12L,12L,9L,12L,16L,11L,12L,16L,15L,15L,18L,16L,18L,19L,17L,17L,24L,19L,20L,26L,24L,25L,27L,23L,26L,28L,21L,30L,39L,29L,30L,35L,32L,33L,38L,36L,38L,41L,36L,39L,48L,42L,41L,50L,44L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117173Inst : IEnumerable<long>
{
public static readonly long[] Value=A117173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117173.Bytes);
public long this[int i]=>Value[i];

public static A117173Inst Instance=new A117173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117174
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,7L,9L,11L,13L,12L,17L,15L,21L,23L,23L,22L,31L,27L,37L,36L,38L,36L,49L,43L,52L,54L,60L,54L,74L,58L,74L,74L,82L,83L,97L,77L,100L,104L,115L,100L,132L,107L,138L,137L,136L,130L,165L,140L,174L,165L,182L,166L,215L,189L,217L,200L,216L,207L,265L,208L,260L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117174Inst : IEnumerable<long>
{
public static readonly long[] Value=A117174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117174.Bytes);
public long this[int i]=>Value[i];

public static A117174Inst Instance=new A117174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117175
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,0L,-1L,-2L,0L,-3L,0L,-5L,-6L,-4L,-2L,-7L,-3L,-8L,-7L,-6L,-4L,-9L,-5L,-9L,-10L,-9L,-2L,-9L,3L,-2L,-4L,-4L,-7L,-2L,9L,2L,-7L,2L,9L,5L,14L,10L,7L,21L,20L,20L,28L,21L,20L,28L,35L,31L,28L,44L,45L,56L,50L,53L,65L,62L,37L,61L,54L,66L,69L,71L,59L,75L,83L,93L,97L,92L,60L,87L,74L,99L,95L,106L,98L,117L,104L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117175Inst : IEnumerable<long>
{
public static readonly long[] Value=A117175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117175.Bytes);
public long this[int i]=>Value[i];

public static A117175Inst Instance=new A117175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117176
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,16L,16L,24L,27L,35L,35L,51L,45L,65L,70L,79L,77L,107L,96L,132L,128L,146L,145L,193L,169L,211L,218L,251L,235L,308L,262L,335L,330L,373L,377L,449L,384L,483L,489L,555L,507L,638L,559L,696L,682L,726L,709L,873L,765L,923L,894L,995L,945L,1159L,1050L,1223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117176Inst : IEnumerable<long>
{
public static readonly long[] Value=A117176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117176.Bytes);
public long this[int i]=>Value[i];

public static A117176Inst Instance=new A117176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117177
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,25L,57L,115L,240L,484L,996L,1987L,4041L,8071L,16252L,32527L,65292L,130558L,261651L,523271L,1047533L,2095138L,4192255L,8384449L,16773161L,33546227L,67100496L,134201373L,268419000L,536837755L,1073709065L,2147417864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117177Inst : IEnumerable<long>
{
public static readonly long[] Value=A117177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117177.Bytes);
public long this[int i]=>Value[i];

public static A117177Inst Instance=new A117177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117178
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,0L,4L,0L,1L,10L,0L,5L,0L,1L,0L,15L,0L,6L,0L,1L,35L,0L,21L,0L,7L,0L,1L,0L,56L,0L,28L,0L,8L,0L,1L,126L,0L,84L,0L,36L,0L,9L,0L,1L,0L,210L,0L,120L,0L,45L,0L,10L,0L,1L,462L,0L,330L,0L,165L,0L,55L,0L,11L,0L,1L,0L,792L,0L,495L,0L,220L,0L,66L,0L,12L,0L,1L,1716L,0L,1287L,0L,715L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117178Inst : IEnumerable<long>
{
public static readonly long[] Value=A117178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117178.Bytes);
public long this[int i]=>Value[i];

public static A117178Inst Instance=new A117178Inst();

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