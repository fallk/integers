using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A053545
{
public static readonly long[] Value={ 0L,1L,5L,19L,63L,191L,543L,1471L,3839L,9727L,24063L,58367L,139263L,327679L,761855L,1753087L,3997695L,9043967L,20316159L,45350911L,100663295L,222298111L,488636415L,1069547519L,2332033023L,5066719231L,10972299263L,23689428991L,51002736639L,109521666047L,234612588543L,501437431807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053545Inst : IEnumerable<long>
{
public static readonly long[] Value=A053545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053545.Bytes);
public long this[int i]=>Value[i];

public static A053545Inst Instance=new A053545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053546
{
public static readonly BigInteger[] Value={ 11L,127L,1231L,12343L,123457L,12345623L,123456719L,1234567801L,1234567891L,1234567891003L,12345678910111L,12345678910111207L,1234567891011121309L,BigInteger.Parse("123456789101112131449"),BigInteger.Parse("12345678910111213141523"),BigInteger.Parse("123456789101112131415161"),BigInteger.Parse("123456789101112131415161717") };
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
public class A053546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053546Inst Instance=new A053546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053547
{
public static readonly BigInteger[] Value={ 11L,211L,3217L,432121L,543217L,65432117L,76543217L,876543211L,9876543211L,1098765432101L,11109876543211L,12111098765432101L,1312111098765432139L,BigInteger.Parse("141312111098765432113"),BigInteger.Parse("15141312111098765432173") };
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
public class A053547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053547Inst Instance=new A053547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053548
{
public static readonly long[] Value={ 1L,0L,0L,2L,4L,9L,32L,90L,240L,654L,1804L,4950L,13664L,37944L,106272L,298890L,843796L,2390595L,6796160L,19370696L,55345680L,158489298L,454803100L,1307556162L,3765741324L,10862667648L,31381058880L,90780903460L,262951527460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053548Inst : IEnumerable<long>
{
public static readonly long[] Value=A053548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053548.Bytes);
public long this[int i]=>Value[i];

public static A053548Inst Instance=new A053548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053549
{
public static readonly BigInteger[] Value={ 0L,1L,2L,12L,152L,3640L,160224L,13063792L,2012388736L,596666619648L,344964885948160L,392058233038486784L,BigInteger.Parse("880255154481199466496"),BigInteger.Parse("3916538634445633156373504"),BigInteger.Parse("34603083354426212294072477696"),BigInteger.Parse("607915214065957203519146330173440") };
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
public class A053549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053549Inst Instance=new A053549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053550
{
public static readonly BigInteger[] Value={ 1L,2L,-4L,72L,-2168L,114864L,-10671216L,1787642272L,-557621854080L,332091938264960L,-383877081387120640L,BigInteger.Parse("870132605833456937472"),BigInteger.Parse("-3891989736269204588784384"),BigInteger.Parse("34485850497928703119235323904"),BigInteger.Parse("-606809291874393995479640098992128") };
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
public class A053550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053550Inst Instance=new A053550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053551
{
public static readonly BigInteger[] Value={ 1L,4L,12L,128L,-2360L,225504L,-31479056L,7663698176L,-3268091071872L,2502155367185920L,-3525130171601665792L,BigInteger.Parse("9336272433375180957696"),BigInteger.Parse("-47283253230423958235278336"),BigInteger.Parse("463782058088334028985937178624"),BigInteger.Parse("-8890882429150197015851583349985280") };
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
public class A053551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053551Inst Instance=new A053551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053552
{
public static readonly BigInteger[] Value={ 1L,-2L,0L,-32L,-1000L,-61104L,-6622448L,-1274984320L,-444075170688L,-286507347953920L,-349824570713902592L,BigInteger.Parse("-821921957328576534528"),BigInteger.Parse("-3760909487461975276739584"),BigInteger.Parse("-33794780371666462710538704896"),BigInteger.Parse("-599695123654141294961479035617280") };
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
public class A053552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053552Inst Instance=new A053552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053553
{
public static readonly ulong[] Value={ 1L,2L,5L,15L,51L,204L,933L,5115L,32385L,245214L,2090961L,20648547L,221781915L,2679261840L,34419818241L,488332067679L,7271691132033L,118162937240730L,1998172269602685L,36552556172242359L,691550102624919651L,14056929989746659252UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053553Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A053553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053553.Bytes);
public ulong this[int i]=>Value[i];

public static A053553Inst Instance=new A053553Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053554
{
public static readonly BigInteger[] Value={ 1L,3L,19L,195L,2791L,51303L,1152019L,30564075L,935494831L,32447734143L,1257770533339L,53884306900515L,2528224238464471L,128934398091500823L,7101273378743303779L,BigInteger.Parse("420078397130637237915"),BigInteger.Parse("26563302733186339752511") };
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
public class A053554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053554Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053554.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053554Inst Instance=new A053554Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053555
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,2L,1L,2L,5L,0L,2L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053555Inst : IEnumerable<long>
{
public static readonly long[] Value=A053555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053555.Bytes);
public long this[int i]=>Value[i];

public static A053555Inst Instance=new A053555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053556
{
public static readonly ulong[] Value={ 1L,1L,2L,3L,8L,30L,144L,280L,5760L,45360L,44800L,3991680L,43545600L,172972800L,6706022400L,93405312000L,42268262400L,22230464256000L,376610217984000L,250298560512000L,11640679464960000L,196503623737344000L,17841281393295360000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053556Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A053556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053556.Bytes);
public ulong this[int i]=>Value[i];

public static A053556Inst Instance=new A053556Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053557
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,3L,11L,53L,103L,2119L,16687L,16481L,1468457L,16019531L,63633137L,2467007773L,34361893981L,15549624751L,8178130767479L,138547156531409L,92079694567171L,4282366656425369L,72289643288657479L,6563440628747948887L,BigInteger.Parse("39299278806015611311") };
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
public class A053557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053557Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053557.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053557Inst Instance=new A053557Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053558
{
public static readonly BigInteger[] Value={ 23L,BigInteger.Parse("157158159160161162163"),BigInteger.Parse("271272273274275276277"),BigInteger.Parse("653654655656657658659"),BigInteger.Parse("733734735736737738739") };
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
public class A053558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053558Inst Instance=new A053558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053559
{
public static readonly BigInteger[] Value={ 23L,67L,89L,BigInteger.Parse("131132133134135136137138139140141") };
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
public class A053559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053559Inst Instance=new A053559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053560
{
public static readonly long[] Value={ 0L,0L,0L,1L,6L,14L,36L,93L,252L,661L,1782L,4893L,13608L,37890L,106142L,298755L,844182L,2391732L,6797196L,19371684L,55348596L,158491993L,454795398L,1307534319L,3765720066L,10862647236L,31381000560L,90780846494L,262951692390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053560Inst : IEnumerable<long>
{
public static readonly long[] Value=A053560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053560.Bytes);
public long this[int i]=>Value[i];

public static A053560Inst Instance=new A053560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053561
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,15L,36L,87L,234L,645L,1782L,4893L,13608L,37994L,106434L,299025L,844182L,2391723L,6797196L,19369708L,55342972L,158486625L,454795398L,1307534319L,3765720066L,10862688116L,31381118658L,90780960426L,262951692390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053561Inst : IEnumerable<long>
{
public static readonly long[] Value=A053561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053561.Bytes);
public long this[int i]=>Value[i];

public static A053561Inst Instance=new A053561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053562
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,13L,32L,87L,243L,654L,1782L,4914L,13664L,37994L,106288L,298890L,844182L,2391363L,6796160L,19369708L,55345784L,158489298L,454795398L,1307541690L,3765741324L,10862688116L,31381059609L,90780903460L,262951692390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053562Inst : IEnumerable<long>
{
public static readonly long[] Value=A053562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053562.Bytes);
public long this[int i]=>Value[i];

public static A053562Inst Instance=new A053562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053563
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,13L,36L,90L,243L,661L,1804L,4914L,13608L,37944L,106288L,298755L,843796L,2391363L,6797196L,19370696L,55345784L,158491993L,454803100L,1307541690L,3765720066L,10862667648L,31381059609L,90780846494L,262951527460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053563Inst : IEnumerable<long>
{
public static readonly long[] Value=A053563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053563.Bytes);
public long this[int i]=>Value[i];

public static A053563Inst Instance=new A053563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053564
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,13L,36L,93L,243L,645L,1782L,4914L,13608L,37890L,106288L,299025L,844182L,2391363L,6797196L,19371684L,55345784L,158486625L,454795398L,1307541690L,3765720066L,10862647236L,31381059609L,90780960426L,262951692390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053564Inst : IEnumerable<long>
{
public static readonly long[] Value=A053564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053564.Bytes);
public long this[int i]=>Value[i];

public static A053564Inst Instance=new A053564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053565
{
public static readonly long[] Value={ -2L,-1L,4L,20L,64L,176L,448L,1088L,2560L,5888L,13312L,29696L,65536L,143360L,311296L,671744L,1441792L,3080192L,6553600L,13893632L,29360128L,61865984L,130023424L,272629760L,570425344L,1191182336L,2483027968L,5167382528L,10737418240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053565Inst : IEnumerable<long>
{
public static readonly long[] Value=A053565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053565.Bytes);
public long this[int i]=>Value[i];

public static A053565Inst Instance=new A053565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053566
{
public static readonly long[] Value={ -2L,-1L,12L,81L,378L,1539L,5832L,21141L,74358L,255879L,866052L,2893401L,9565938L,31355019L,102036672L,330024861L,1061819118L,3400690959L,10847773692L,34480423521L,109252577898L,345191655699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053566Inst : IEnumerable<long>
{
public static readonly long[] Value=A053566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053566.Bytes);
public long this[int i]=>Value[i];

public static A053566Inst Instance=new A053566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053567
{
public static readonly long[] Value={ -120L,1764L,-13132L,67284L,-269325L,902055L,-2637558L,6926634L,-16669653L,37312275L,-78558480L,156952432L,-299650806L,549789282L,-973941900L,1672280820L,-2792167686L,4546047198L,-7234669596L,11276842500L,-17247104875L,25922927745L,-38343278610L,55880640270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053567Inst : IEnumerable<long>
{
public static readonly long[] Value=A053567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053567.Bytes);
public long this[int i]=>Value[i];

public static A053567Inst Instance=new A053567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053568
{
public static readonly long[] Value={ 2L,4L,6L,6L,10L,12L,6L,8L,16L,18L,12L,22L,20L,12L,18L,28L,30L,20L,16L,24L,36L,18L,24L,40L,42L,24L,46L,42L,20L,32L,52L,40L,36L,58L,60L,30L,36L,48L,66L,32L,44L,70L,72L,36L,40L,36L,60L,78L,54L,82L,64L,42L,56L,88L,24L,72L,60L,46L,72L,96L,42L,60L,100L,102L,48L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053568Inst : IEnumerable<long>
{
public static readonly long[] Value=A053568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053568.Bytes);
public long this[int i]=>Value[i];

public static A053568Inst Instance=new A053568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053569
{
public static readonly long[] Value={ 3L,6L,13L,18L,12L,31L,18L,20L,32L,36L,24L,31L,42L,40L,30L,48L,54L,48L,38L,42L,44L,78L,72L,48L,57L,93L,72L,98L,54L,72L,90L,60L,62L,127L,84L,144L,68L,96L,144L,72L,74L,124L,140L,96L,80L,121L,126L,84L,108L,132L,120L,180L,90L,168L,144L,120L,98L,156L,217L,102L,104L,192L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053569Inst : IEnumerable<long>
{
public static readonly long[] Value=A053569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053569.Bytes);
public long this[int i]=>Value[i];

public static A053569Inst Instance=new A053569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053570
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,5L,12L,13L,18L,15L,32L,21L,46L,35L,42L,49L,80L,49L,102L,71L,88L,85L,150L,89L,156L,125L,164L,137L,242L,113L,278L,213L,230L,217L,272L,191L,396L,275L,320L,261L,490L,237L,542L,369L,386L,401L,650L,355L,640L,431L,560L,507L,830L,449L,704L,551L,696L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053570Inst : IEnumerable<long>
{
public static readonly long[] Value=A053570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053570.Bytes);
public long this[int i]=>Value[i];

public static A053570Inst Instance=new A053570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053571
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,2L,2L,8L,0L,14L,0L,16L,16L,16L,0L,36L,0L,38L,32L,44L,0L,68L,20L,62L,40L,78L,0L,136L,0L,80L,82L,110L,78L,170L,0L,138L,116L,190L,0L,264L,0L,192L,198L,204L,0L,310L,66L,294L,196L,272L,0L,398L,182L,358L,248L,328L,0L,584L,0L,372L,372L,372L,248L,658L,0L,468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053571Inst : IEnumerable<long>
{
public static readonly long[] Value=A053571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053571.Bytes);
public long this[int i]=>Value[i];

public static A053571Inst Instance=new A053571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053572
{
public static readonly long[] Value={ 1L,1L,1L,3L,16L,75L,384L,1805L,8640L,42336L,207368L,995808L,5184000L,24192672L,121730700L,594350400L,2921811200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053572Inst : IEnumerable<long>
{
public static readonly long[] Value=A053572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053572.Bytes);
public long this[int i]=>Value[i];

public static A053572Inst Instance=new A053572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053573
{
public static readonly long[] Value={ 1L,5L,39L,265L,1871L,13065L,91519L,640505L,4483791L,31386025L,219703199L,1537920345L,10765446511L,75358117385L,527506838079L,3692547833785L,25847834902031L,180934844183145L,1266543909544159L,8865807366284825L,62060651565042351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053573Inst : IEnumerable<long>
{
public static readonly long[] Value=A053573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053573.Bytes);
public long this[int i]=>Value[i];

public static A053573Inst Instance=new A053573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053574
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,3L,3L,4L,1L,1L,3L,2L,1L,1L,3L,2L,2L,1L,2L,2L,3L,1L,4L,2L,4L,3L,2L,2L,1L,3L,4L,3L,2L,1L,2L,3L,1L,1L,4L,1L,2L,5L,3L,2L,1L,3L,3L,2L,2L,1L,4L,2L,1L,2L,5L,4L,2L,1L,5L,2L,3L,1L,3L,3L,2L,3L,2L,2L,3L,1L,5L,1L,3L,1L,3L,6L,1L,3L,3L,3L,3L,3L,2L,2L,1L,3L,5L,5L,1L,2L,3L,2L,5L,1L,4L,4L,2L,1L,2L,2L,3L,3L,4L,4L,2L,3L,3L,3L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053574Inst : IEnumerable<long>
{
public static readonly long[] Value=A053574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053574.Bytes);
public long this[int i]=>Value[i];

public static A053574Inst Instance=new A053574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053575
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,5L,1L,3L,3L,1L,1L,1L,3L,9L,1L,3L,5L,11L,1L,5L,3L,9L,3L,7L,1L,15L,1L,5L,1L,3L,3L,9L,9L,3L,1L,5L,3L,21L,5L,3L,11L,23L,1L,21L,5L,1L,3L,13L,9L,5L,3L,9L,7L,29L,1L,15L,15L,9L,1L,3L,5L,33L,1L,11L,3L,35L,3L,9L,9L,5L,9L,15L,3L,39L,1L,27L,5L,41L,3L,1L,21L,7L,5L,11L,3L,9L,11L,15L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053575Inst : IEnumerable<long>
{
public static readonly long[] Value=A053575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053575.Bytes);
public long this[int i]=>Value[i];

public static A053575Inst Instance=new A053575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053576
{
public static readonly long[] Value={ 1L,3L,5L,15L,17L,51L,85L,255L,257L,771L,1285L,3855L,4369L,13107L,21845L,65535L,65537L,196611L,327685L,983055L,1114129L,3342387L,5570645L,16711935L,16843009L,50529027L,84215045L,252645135L,286331153L,858993459L,1431655765L,4294967295L,8589934592L,17179869184L,34359738368L,68719476736L,137438953472L,274877906944L,549755813888L,1099511627776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053576Inst : IEnumerable<long>
{
public static readonly long[] Value=A053576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053576.Bytes);
public long this[int i]=>Value[i];

public static A053576Inst Instance=new A053576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053577
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,11L,12L,13L,14L,16L,17L,19L,23L,24L,28L,29L,31L,32L,37L,41L,43L,47L,48L,53L,56L,59L,61L,62L,64L,67L,71L,73L,79L,83L,89L,96L,97L,101L,103L,107L,109L,112L,113L,124L,127L,128L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,192L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053577Inst : IEnumerable<long>
{
public static readonly long[] Value=A053577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053577.Bytes);
public long this[int i]=>Value[i];

public static A053577Inst Instance=new A053577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053578
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,4L,1L,8L,1L,8L,8L,1L,1L,1L,16L,16L,1L,1L,16L,1L,1L,1L,1L,32L,1L,32L,1L,1L,32L,32L,1L,1L,1L,1L,1L,1L,64L,1L,1L,1L,1L,1L,64L,1L,64L,1L,64L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,128L,1L,1L,1L,1L,1L,128L,1L,1L,1L,1L,1L,128L,1L,128L,128L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053578Inst : IEnumerable<long>
{
public static readonly long[] Value=A053578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053578.Bytes);
public long this[int i]=>Value[i];

public static A053578Inst Instance=new A053578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053579
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,16L,24L,28L,32L,48L,56L,62L,64L,96L,112L,124L,128L,192L,224L,248L,254L,256L,384L,448L,496L,508L,512L,768L,896L,992L,1016L,1024L,1536L,1792L,1984L,2032L,2048L,3072L,3584L,3968L,4064L,4096L,6144L,7168L,7936L,8128L,8192L,12288L,14336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053579Inst : IEnumerable<long>
{
public static readonly long[] Value=A053579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053579.Bytes);
public long this[int i]=>Value[i];

public static A053579Inst Instance=new A053579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053580
{
public static readonly long[] Value={ 89L,809L,6089L,6689L,6869L,6899L,8009L,8069L,8089L,8609L,8669L,8689L,8699L,8969L,8999L,9689L,60089L,60689L,60869L,60889L,60899L,66089L,66809L,66889L,68099L,68669L,68699L,68899L,68909L,69809L,69899L,80669L,80809L,80909L,80989L,86069L,86689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053580Inst : IEnumerable<long>
{
public static readonly long[] Value=A053580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053580.Bytes);
public long this[int i]=>Value[i];

public static A053580Inst Instance=new A053580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053581
{
public static readonly long[] Value={ 1L,3L,10L,32L,100L,308L,940L,2852L,8620L,25988L,78220L,235172L,706540L,2121668L,6369100L,19115492L,57362860L,172121348L,516429580L,1549419812L,4648521580L,13946089028L,41839315660L,125520044132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053581Inst : IEnumerable<long>
{
public static readonly long[] Value=A053581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053581.Bytes);
public long this[int i]=>Value[i];

public static A053581Inst Instance=new A053581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053582
{
public static readonly BigInteger[] Value={ 1L,11L,211L,4211L,34211L,234211L,4234211L,154234211L,3154234211L,93154234211L,2093154234211L,42093154234211L,342093154234211L,11342093154234211L,3111342093154234211L,BigInteger.Parse("63111342093154234211"),BigInteger.Parse("2463111342093154234211") };
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
public class A053582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053582Inst Instance=new A053582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053583
{
public static readonly BigInteger[] Value={ 3L,13L,113L,2113L,12113L,612113L,11612113L,1611612113L,111611612113L,1111611612113L,81111611612113L,2181111611612113L,132181111611612113L,11132181111611612113UL,BigInteger.Parse("3411132181111611612113"),BigInteger.Parse("413411132181111611612113") };
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
public class A053583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053583Inst Instance=new A053583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053584
{
public static readonly BigInteger[] Value={ 7L,17L,317L,6317L,26317L,126317L,2126317L,72126317L,372126317L,5372126317L,125372126317L,15125372126317L,415125372126317L,23415125372126317L,2223415125372126317L,BigInteger.Parse("152223415125372126317"),BigInteger.Parse("21152223415125372126317") };
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
public class A053584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053584Inst Instance=new A053584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053585
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,8L,9L,5L,11L,3L,13L,7L,5L,16L,17L,9L,19L,5L,7L,11L,23L,3L,25L,13L,27L,7L,29L,5L,31L,32L,11L,17L,7L,9L,37L,19L,13L,5L,41L,7L,43L,11L,5L,23L,47L,3L,49L,25L,17L,13L,53L,27L,11L,7L,19L,29L,59L,5L,61L,31L,7L,64L,13L,11L,67L,17L,23L,7L,71L,9L,73L,37L,25L,19L,11L,13L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053585Inst : IEnumerable<long>
{
public static readonly long[] Value=A053585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053585.Bytes);
public long this[int i]=>Value[i];

public static A053585Inst Instance=new A053585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053586
{
public static readonly BigInteger[] Value={ 89888786858483L,BigInteger.Parse("211210209208207206205204203202201200199"),BigInteger.Parse("593592591590589588587"),BigInteger.Parse("1327132613251324132313221321"),BigInteger.Parse("2377237623752374237323722371"),BigInteger.Parse("2963296229612960295929582957") };
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
public class A053586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053586Inst Instance=new A053586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053587
{
public static readonly long[] Value={ 2L,16L,81L,471L,1056L,1381L,6906L,17956L,34531L,40056L,200281L,520731L,1001406L,1482081L,7410406L,19267056L,37052031L,60765331L,303826656L,789949306L,1519133281L,3220562556L,13429138206L,16102812781L,41867313231L,80514063906L,196454315931L,711744324931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053587Inst : IEnumerable<long>
{
public static readonly long[] Value=A053587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053587.Bytes);
public long this[int i]=>Value[i];

public static A053587Inst Instance=new A053587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053588
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,121L,1480L,50993L,3279685L,505641590L,152461906778L,103587671805408L,145528904385412088L,BigInteger.Parse("442626996609870050404"),BigInteger.Parse("2918362542591139744394993"),BigInteger.Parse("40446812392580562094804791143") };
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
public class A053588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053588Inst Instance=new A053588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053589
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,30L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,30L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,30L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053589Inst : IEnumerable<long>
{
public static readonly long[] Value=A053589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053589.Bytes);
public long this[int i]=>Value[i];

public static A053589Inst Instance=new A053589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053590
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,3L,2L,11L,6L,13L,2L,15L,2L,17L,6L,19L,2L,3L,2L,23L,6L,5L,2L,3L,2L,29L,30L,31L,2L,3L,2L,35L,6L,37L,2L,3L,2L,41L,6L,43L,2L,15L,2L,47L,6L,7L,2L,3L,2L,53L,6L,5L,2L,3L,2L,59L,30L,61L,2L,3L,2L,5L,6L,67L,2L,3L,2L,71L,6L,73L,2L,15L,2L,77L,6L,79L,2L,3L,2L,83L,6L,5L,2L,3L,2L,89L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053590Inst : IEnumerable<long>
{
public static readonly long[] Value=A053590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053590.Bytes);
public long this[int i]=>Value[i];

public static A053590Inst Instance=new A053590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053591
{
public static readonly long[] Value={ 1L,1L,7L,19L,33L,81L,123L,179L,257L,389L,515L,739L,925L,1189L,1419L,1791L,2109L,2553L,3071L,3695L,4169L,4945L,5575L,6403L,7153L,8217L,9171L,10395L,11513L,12893L,14147L,15515L,17077L,18853L,20479L,22575L,24405L,26745L,28671L,31103L,33401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053591Inst : IEnumerable<long>
{
public static readonly long[] Value=A053591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053591.Bytes);
public long this[int i]=>Value[i];

public static A053591Inst Instance=new A053591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053592
{
public static readonly long[] Value={ 0L,1L,1L,19L,27L,81L,93L,179L,251L,389L,485L,739L,895L,1189L,1365L,1791L,2103L,2553L,2969L,3695L,4139L,4945L,5497L,6403L,7123L,8217L,9093L,10395L,11459L,12893L,13997L,15515L,17071L,18853L,20377L,22575L,24303L,26745L,28545L,31103L,33371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053592Inst : IEnumerable<long>
{
public static readonly long[] Value=A053592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053592.Bytes);
public long this[int i]=>Value[i];

public static A053592Inst Instance=new A053592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053593
{
public static readonly long[] Value={ 0L,2L,2L,20L,28L,70L,110L,192L,256L,402L,498L,708L,884L,1166L,1422L,1800L,2104L,2594L,3026L,3588L,4140L,4918L,5542L,6432L,7224L,8186L,9122L,10380L,11460L,12790L,14094L,15624L,17080L,18882L,20458L,22500L,24364L,26590L,28678L,31136L,33400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053593Inst : IEnumerable<long>
{
public static readonly long[] Value=A053593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053593.Bytes);
public long this[int i]=>Value[i];

public static A053593Inst Instance=new A053593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053594
{
public static readonly long[] Value={ 0L,0L,2L,10L,28L,60L,110L,174L,256L,368L,498L,682L,884L,1140L,1422L,1750L,2104L,2560L,3026L,3546L,4140L,4828L,5542L,6382L,7224L,8136L,9122L,10274L,11460L,12732L,14094L,15558L,17080L,18752L,20458L,22410L,24364L,26516L,28678L,31006L,33400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053594Inst : IEnumerable<long>
{
public static readonly long[] Value=A053594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053594.Bytes);
public long this[int i]=>Value[i];

public static A053594Inst Instance=new A053594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053595
{
public static readonly long[] Value={ 0L,0L,4L,12L,36L,56L,112L,168L,268L,372L,536L,680L,888L,1132L,1452L,1740L,2160L,2544L,3048L,3556L,4196L,4812L,5552L,6304L,7248L,8116L,9220L,10280L,11512L,12656L,14108L,15564L,17164L,18800L,20664L,22368L,24436L,26412L,28692L,30984L,33536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053595Inst : IEnumerable<long>
{
public static readonly long[] Value=A053595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053595.Bytes);
public long this[int i]=>Value[i];

public static A053595Inst Instance=new A053595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053596
{
public static readonly long[] Value={ 0L,0L,8L,8L,32L,56L,136L,160L,280L,360L,552L,672L,912L,1088L,1472L,1736L,2176L,2512L,3112L,3544L,4224L,4776L,5616L,6272L,7208L,8144L,9328L,10144L,11536L,12712L,14328L,15408L,17256L,18656L,20672L,22400L,24464L,26344L,28768L,30976L,33552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053596Inst : IEnumerable<long>
{
public static readonly long[] Value=A053596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053596.Bytes);
public long this[int i]=>Value[i];

public static A053596Inst Instance=new A053596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053597
{
public static readonly long[] Value={ 2L,1L,2L,2L,2L,2L,3L,3L,2L,3L,3L,2L,3L,2L,1L,2L,3L,3L,3L,3L,2L,3L,4L,3L,2L,2L,2L,3L,2L,5L,4L,3L,2L,3L,2L,1L,2L,2L,1L,3L,2L,3L,2L,3L,2L,1L,3L,2L,3L,4L,3L,3L,2L,1L,1L,2L,3L,5L,4L,4L,4L,3L,2L,5L,5L,5L,4L,5L,4L,3L,2L,2L,1L,2L,3L,3L,2L,4L,3L,2L,2L,4L,3L,2L,3L,4L,3L,2L,4L,3L,3L,2L,2L,6L,5L,4L,5L,4L,3L,2L,2L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053597Inst : IEnumerable<long>
{
public static readonly long[] Value=A053597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053597.Bytes);
public long this[int i]=>Value[i];

public static A053597Inst Instance=new A053597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053598
{
public static readonly BigInteger[] Value={ 1L,0L,2L,13L,202L,9390L,1531336L,880492496L,1792477159408L,13026163465206704L,BigInteger.Parse("341247403996148180800"),BigInteger.Parse("32522568124623933138617088"),BigInteger.Parse("11366712907916015518547782806784"),BigInteger.Parse("14669074325967499043636521641422216704"),BigInteger.Parse("70315641946149306808455637518883828774996992") };
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
public class A053598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053598Inst Instance=new A053598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053599
{
public static readonly long[] Value={ 1L,3L,7L,13L,23L,37L,59L,89L,135L,197L,291L,417L,607L,861L,1243L,1753L,2519L,3541L,5075L,7121L,10191L,14285L,20427L,28617L,40903L,57285L,81859L,114625L,163775L,229309L,327611L,458681L,655287L,917429L,1310643L,1834929L,2621359L,3669933L,5242795L,7339945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053599Inst : IEnumerable<long>
{
public static readonly long[] Value=A053599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053599.Bytes);
public long this[int i]=>Value[i];

public static A053599Inst Instance=new A053599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053600
{
public static readonly BigInteger[] Value={ 2L,727L,37273L,333727333L,93337273339L,309333727333903L,1830933372733390381L,BigInteger.Parse("92183093337273339038129"),BigInteger.Parse("3921830933372733390381293"),BigInteger.Parse("1333921830933372733390381293331"),BigInteger.Parse("18133392183093337273339038129333181") };
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
public class A053600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053600Inst Instance=new A053600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053601
{
public static readonly BigInteger[] Value={ 1L,1L,3L,28L,840L,83328L,27998208L,32509919232L,132640470466560L,1927943976061501440L,BigInteger.Parse("100981078400558897823744"),BigInteger.Parse("19242660536873338307044442112"),BigInteger.Parse("13448310596010038676027219703234560") };
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
public class A053601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053601Inst Instance=new A053601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053602
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,5L,3L,8L,5L,13L,8L,21L,13L,34L,21L,55L,34L,89L,55L,144L,89L,233L,144L,377L,233L,610L,377L,987L,610L,1597L,987L,2584L,1597L,4181L,2584L,6765L,4181L,10946L,6765L,17711L,10946L,28657L,17711L,46368L,28657L,75025L,46368L,121393L,75025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053602Inst : IEnumerable<long>
{
public static readonly long[] Value=A053602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053602.Bytes);
public long this[int i]=>Value[i];

public static A053602Inst Instance=new A053602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053603
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,2L,0L,2L,0L,2L,1L,2L,0L,0L,4L,0L,2L,0L,1L,2L,2L,0L,2L,2L,0L,2L,0L,2L,1L,4L,0L,0L,2L,0L,2L,2L,2L,2L,0L,0L,3L,2L,0L,0L,4L,0L,2L,2L,0L,4L,0L,0L,0L,2L,3L,2L,2L,0L,2L,2L,0L,0L,2L,2L,2L,2L,0L,2L,2L,0L,3L,2L,0L,0L,4L,0L,0L,2L,0L,6L,0L,2L,2L,0L,0L,2L,2L,0L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053603Inst : IEnumerable<long>
{
public static readonly long[] Value=A053603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053603.Bytes);
public long this[int i]=>Value[i];

public static A053603Inst Instance=new A053603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053604
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,3L,0L,3L,3L,1L,6L,0L,6L,3L,6L,3L,3L,9L,1L,12L,0L,6L,9L,6L,6L,6L,9L,6L,12L,0L,10L,9L,12L,6L,9L,9L,3L,18L,3L,12L,12L,9L,9L,9L,12L,10L,12L,9L,9L,18L,6L,6L,27L,6L,12L,6L,9L,18L,15L,15L,6L,21L,9L,13L,12L,9L,18L,21L,9L,6L,21L,15L,15L,15L,12L,15L,18L,15L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053604Inst : IEnumerable<long>
{
public static readonly long[] Value=A053604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053604.Bytes);
public long this[int i]=>Value[i];

public static A053604Inst Instance=new A053604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053605
{
public static readonly BigInteger[] Value={ 1L,0L,3L,8L,135L,1164L,21035L,322832L,7040943L,153153620L,4048737099L,112389077976L,3537768793559L,118535631544316L,4353324736520955L,170245846476629024L,7163230987527864543L,BigInteger.Parse("319708454444016133284") };
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
public class A053605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053605Inst Instance=new A053605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053606
{
public static readonly BigInteger[] Value={ 0L,8L,152L,2736L,49104L,881144L,15811496L,283725792L,5091252768L,91358824040L,1639367579960L,29417257615248L,527871269494512L,9472265593285976L,169972909409653064L,3050040103780469184L,BigInteger.Parse("54730748958638792256"),BigInteger.Parse("982103441151717791432") };
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
public class A053606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053606Inst Instance=new A053606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053607
{
public static readonly long[] Value={ 3L,7L,13L,23L,31L,47L,61L,79L,113L,127L,167L,241L,251L,283L,337L,359L,509L,523L,619L,727L,839L,953L,1021L,1327L,1367L,1669L,1847L,2039L,2179L,2207L,2399L,2803L,3121L,3469L,3719L,4093L,4483L,4909L,5039L,5323L,6229L,6553L,6857L,6883L,7919L,8191L,9403L,10193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053607Inst : IEnumerable<long>
{
public static readonly long[] Value=A053607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053607.Bytes);
public long this[int i]=>Value[i];

public static A053607Inst Instance=new A053607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053608
{
public static readonly BigInteger[] Value={ 1L,2L,6L,420L,360360L,BigInteger.Parse("718766754945489455304472257065075294400") };
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
public class A053608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053608Inst Instance=new A053608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053609
{
public static readonly BigInteger[] Value={ 2L,5L,37L,176401L,129859329601L,BigInteger.Parse("516625648014869290354797521879383114125823989794742396526049715541246671360001") };
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
public class A053609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053609Inst Instance=new A053609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053610
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,4L,2L,1L,2L,3L,4L,2L,3L,4L,1L,2L,3L,4L,2L,3L,4L,5L,3L,1L,2L,3L,4L,2L,3L,4L,5L,3L,2L,3L,1L,2L,3L,4L,2L,3L,4L,5L,3L,2L,3L,4L,5L,1L,2L,3L,4L,2L,3L,4L,5L,3L,2L,3L,4L,5L,3L,4L,1L,2L,3L,4L,2L,3L,4L,5L,3L,2L,3L,4L,5L,3L,4L,5L,2L,1L,2L,3L,4L,2L,3L,4L,5L,3L,2L,3L,4L,5L,3L,4L,5L,2L,3L,4L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053610Inst : IEnumerable<long>
{
public static readonly long[] Value=A053610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053610.Bytes);
public long this[int i]=>Value[i];

public static A053610Inst Instance=new A053610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053611
{
public static readonly long[] Value={ 1L,5L,6L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053611Inst : IEnumerable<long>
{
public static readonly long[] Value=A053611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053611.Bytes);
public long this[int i]=>Value[i];

public static A053611Inst Instance=new A053611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053612
{
public static readonly long[] Value={ 1L,10L,13L,645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053612Inst : IEnumerable<long>
{
public static readonly long[] Value=A053612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053612.Bytes);
public long this[int i]=>Value[i];

public static A053612Inst Instance=new A053612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053613
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,31L,37L,43L,61L,67L,79L,127L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053613Inst : IEnumerable<long>
{
public static readonly long[] Value=A053613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053613.Bytes);
public long this[int i]=>Value[i];

public static A053613Inst Instance=new A053613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053614
{
public static readonly long[] Value={ 2L,5L,8L,12L,23L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053614Inst : IEnumerable<long>
{
public static readonly long[] Value=A053614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053614.Bytes);
public long this[int i]=>Value[i];

public static A053614Inst Instance=new A053614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053615
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053615Inst : IEnumerable<long>
{
public static readonly long[] Value=A053615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053615.Bytes);
public long this[int i]=>Value[i];

public static A053615Inst Instance=new A053615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053616
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,2L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,3L,4L,3L,2L,1L,0L,1L,2L,3L,4L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053616Inst : IEnumerable<long>
{
public static readonly long[] Value=A053616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053616.Bytes);
public long this[int i]=>Value[i];

public static A053616Inst Instance=new A053616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053617
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,90L,396L,1837L,8864L,44074L,224352L,1163724L,6129840L,32703074L,176351644L,959658200L,5262988330L,29057961666L,161374413196L,900792925199L,5050924332096L,28434661250454L,160644331001476L,910455895039056L,5174722258676440L,29486753617569684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053617Inst : IEnumerable<long>
{
public static readonly long[] Value=A053617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053617.Bytes);
public long this[int i]=>Value[i];

public static A053617Inst Instance=new A053617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053618
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,5L,9L,14L,21L,30L,42L,55L,72L,91L,114L,140L,170L,204L,243L,285L,333L,385L,443L,506L,575L,650L,732L,819L,914L,1015L,1124L,1240L,1364L,1496L,1637L,1785L,1943L,2109L,2285L,2470L,2665L,2870L,3086L,3311L,3548L,3795L,4054L,4324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053618Inst : IEnumerable<long>
{
public static readonly long[] Value=A053618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053618.Bytes);
public long this[int i]=>Value[i];

public static A053618Inst Instance=new A053618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053619
{
public static readonly long[] Value={ -1L,-8L,28L,8L,5L,5L,3L,3L,4L,4L,3L,3L,2L,3L,3L,3L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,2L,2L,3L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053619Inst : IEnumerable<long>
{
public static readonly long[] Value=A053619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053619.Bytes);
public long this[int i]=>Value[i];

public static A053619Inst Instance=new A053619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053620
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,19L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053620Inst : IEnumerable<long>
{
public static readonly long[] Value=A053620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053620.Bytes);
public long this[int i]=>Value[i];

public static A053620Inst Instance=new A053620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053621
{
public static readonly long[] Value={ -1L,-7L,30L,10L,8L,8L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053621Inst : IEnumerable<long>
{
public static readonly long[] Value=A053621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053621.Bytes);
public long this[int i]=>Value[i];

public static A053621Inst Instance=new A053621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053622
{
public static readonly long[] Value={ 2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,-1L,-1L,-2L,-1L,-1L,-1L,-2L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-2L,-2L,-2L,-1L,-1L,-1L,-2L,-2L,-1L,-1L,-2L,-2L,-3L,-2L,-2L,-2L,-3L,-3L,-2L,-2L,-2L,-2L,-3L,-2L,-2L,-2L,-2L,-2L,-3L,-2L,-3L,-3L,-3L,-3L,-2L,-2L,-3L,-3L,-3L,-3L,-3L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053622Inst : IEnumerable<long>
{
public static readonly long[] Value=A053622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053622.Bytes);
public long this[int i]=>Value[i];

public static A053622Inst Instance=new A053622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053623
{
public static readonly long[] Value={ 1L,2L,4L,14L,38L,126L,252L,1662L,7180L,39430L,111064L,803876L,2863992L,12123360L,24246720L,329012784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053623Inst : IEnumerable<long>
{
public static readonly long[] Value=A053623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053623.Bytes);
public long this[int i]=>Value[i];

public static A053623Inst Instance=new A053623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053624
{
public static readonly long[] Value={ 1L,3L,9L,15L,45L,105L,225L,315L,945L,1575L,2835L,3465L,10395L,17325L,31185L,45045L,121275L,135135L,225225L,405405L,675675L,1576575L,2027025L,2297295L,3828825L,6891885L,11486475L,26801775L,34459425L,43648605L,72747675L,130945815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053624Inst : IEnumerable<long>
{
public static readonly long[] Value=A053624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053624.Bytes);
public long this[int i]=>Value[i];

public static A053624Inst Instance=new A053624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053625
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,720L,5040L,20160L,60480L,151200L,332640L,665280L,1235520L,2162160L,3603600L,5765760L,8910720L,13366080L,19535040L,27907200L,39070080L,53721360L,72681840L,96909120L,127512000L,165765600L,213127200L,271252800L,342014400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053625Inst : IEnumerable<long>
{
public static readonly long[] Value=A053625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053625.Bytes);
public long this[int i]=>Value[i];

public static A053625Inst Instance=new A053625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053626
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,7L,8L,9L,10L,11L,4L,13L,14L,3L,16L,17L,6L,19L,5L,21L,22L,23L,8L,25L,26L,27L,4L,29L,6L,31L,32L,33L,34L,14L,12L,37L,38L,39L,10L,41L,7L,43L,44L,5L,46L,47L,16L,49L,50L,51L,52L,53L,18L,55L,8L,57L,58L,59L,12L,61L,62L,18L,64L,65L,6L,67L,68L,69L,28L,71L,9L,73L,74L,15L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053626Inst : IEnumerable<long>
{
public static readonly long[] Value=A053626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053626.Bytes);
public long this[int i]=>Value[i];

public static A053626Inst Instance=new A053626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053627
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,8L,9L,10L,11L,6L,13L,14L,5L,16L,17L,9L,19L,8L,21L,22L,23L,12L,25L,26L,27L,7L,29L,10L,31L,32L,33L,34L,20L,18L,37L,38L,39L,16L,41L,12L,43L,44L,9L,46L,47L,24L,49L,50L,51L,52L,53L,27L,55L,14L,57L,58L,59L,20L,61L,62L,28L,64L,65L,11L,67L,68L,69L,40L,71L,16L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053627Inst : IEnumerable<long>
{
public static readonly long[] Value=A053627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053627.Bytes);
public long this[int i]=>Value[i];

public static A053627Inst Instance=new A053627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053628
{
public static readonly long[] Value={ 3L,6L,5L,9L,8L,12L,7L,10L,20L,18L,16L,12L,9L,24L,27L,14L,20L,28L,11L,40L,16L,25L,33L,39L,32L,21L,48L,18L,13L,48L,36L,40L,51L,39L,35L,54L,20L,28L,57L,65L,15L,36L,60L,22L,27L,69L,35L,44L,32L,50L,17L,66L,24L,64L,81L,55L,42L,51L,87L,100L,96L,36L,26L,93L,85L,84L,19L,96L,52L,49L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053628Inst : IEnumerable<long>
{
public static readonly long[] Value=A053628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053628.Bytes);
public long this[int i]=>Value[i];

public static A053628Inst Instance=new A053628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053629
{
public static readonly long[] Value={ 2L,4L,3L,6L,5L,8L,4L,6L,14L,12L,10L,7L,5L,16L,18L,8L,12L,18L,6L,28L,9L,15L,21L,26L,20L,12L,33L,10L,7L,32L,22L,25L,34L,24L,21L,36L,11L,16L,38L,45L,8L,21L,39L,12L,15L,46L,20L,26L,18L,30L,9L,42L,13L,40L,54L,33L,24L,30L,58L,70L,66L,20L,14L,62L,55L,54L,10L,64L,30L,28L,18L,50L,68L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053629Inst : IEnumerable<long>
{
public static readonly long[] Value=A053629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053629.Bytes);
public long this[int i]=>Value[i];

public static A053629Inst Instance=new A053629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053630
{
public static readonly BigInteger[] Value={ 3L,5L,13L,85L,3613L,6526885L,21300113901613L,BigInteger.Parse("226847426110843688722000885"),BigInteger.Parse("25729877366557343481074291996721923093306518970391613") };
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
public class A053630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053630Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053630.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053630Inst Instance=new A053630Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053631
{
public static readonly BigInteger[] Value={ 2L,4L,12L,84L,3612L,6526884L,21300113901612L,BigInteger.Parse("226847426110843688722000884"),BigInteger.Parse("25729877366557343481074291996721923093306518970391612"),BigInteger.Parse("331013294649039928396936390888878360035026305412754995683702777533071737279144813617823976263475290370884") };
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
public class A053631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053631Inst Instance=new A053631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053632
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,3L,3L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,4L,4L,5L,5L,5L,5L,4L,4L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,8L,8L,8L,8L,7L,7L,6L,5L,5L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053632Inst : IEnumerable<long>
{
public static readonly long[] Value=A053632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053632.Bytes);
public long this[int i]=>Value[i];

public static A053632Inst Instance=new A053632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053633
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,4L,3L,3L,3L,3L,6L,5L,5L,6L,5L,5L,10L,9L,9L,9L,9L,9L,9L,16L,16L,16L,16L,16L,16L,16L,16L,30L,28L,28L,29L,28L,28L,29L,28L,28L,52L,51L,51L,51L,51L,52L,51L,51L,51L,51L,94L,93L,93L,93L,93L,93L,93L,93L,93L,93L,93L,172L,170L,170L,172L,170L,170L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053633Inst : IEnumerable<long>
{
public static readonly long[] Value=A053633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053633.Bytes);
public long this[int i]=>Value[i];

public static A053633Inst Instance=new A053633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053634
{
public static readonly long[] Value={ 2L,3L,4L,7L,10L,18L,30L,54L,94L,176L,316L,591L,1096L,2058L,3856L,7301L,13798L,26244L,49940L,95373L,182362L,349626L,671092L,1290714L,2485534L,4793790L,9256396L,17896284L,34636834L,67109898L,130150588L,252647064L,490853416L,954440950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053634Inst : IEnumerable<long>
{
public static readonly long[] Value=A053634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053634.Bytes);
public long this[int i]=>Value[i];

public static A053634Inst Instance=new A053634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053635
{
public static readonly long[] Value={ 0L,2L,6L,12L,24L,40L,84L,140L,288L,540L,1080L,2068L,4224L,8216L,16548L,32880L,65856L,131104L,262836L,524324L,1049760L,2097480L,4196412L,8388652L,16782048L,33554600L,67117128L,134218836L,268452240L,536870968L,1073777040L,2147483708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053635Inst : IEnumerable<long>
{
public static readonly long[] Value=A053635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053635.Bytes);
public long this[int i]=>Value[i];

public static A053635Inst Instance=new A053635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053636
{
public static readonly long[] Value={ 0L,2L,4L,12L,16L,40L,72L,140L,256L,540L,1040L,2068L,4128L,8216L,16408L,32880L,65536L,131104L,262296L,524324L,1048640L,2097480L,4194344L,8388652L,16777728L,33554600L,67108912L,134218836L,268435552L,536870968L,1073744160L,2147483708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053636Inst : IEnumerable<long>
{
public static readonly long[] Value=A053636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053636.Bytes);
public long this[int i]=>Value[i];

public static A053636Inst Instance=new A053636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053637
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,10L,16L,29L,52L,94L,171L,316L,586L,1093L,2048L,3856L,7282L,13798L,26215L,49933L,95326L,182362L,349526L,671089L,1290556L,2485514L,4793491L,9256396L,17895698L,34636834L,67108864L,130150525L,252645136L,490853406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053637Inst : IEnumerable<long>
{
public static readonly long[] Value=A053637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053637.Bytes);
public long this[int i]=>Value[i];

public static A053637Inst Instance=new A053637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053638
{
public static readonly long[] Value={ 2L,2L,3L,4L,7L,11L,19L,32L,57L,103L,187L,342L,631L,1171L,2185L,4096L,7711L,14564L,27595L,52429L,99865L,190651L,364723L,699051L,1342178L,2581111L,4971027L,9586981L,18512791L,35791395L,69273667L,134217728L,260301049L,505290271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053638Inst : IEnumerable<long>
{
public static readonly long[] Value=A053638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053638.Bytes);
public long this[int i]=>Value[i];

public static A053638Inst Instance=new A053638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053639
{
public static readonly long[] Value={ 4L,4L,6L,8L,13L,22L,37L,64L,114L,205L,373L,683L,1261L,2341L,4370L,8192L,15421L,29128L,55189L,104858L,199729L,381301L,729445L,1398102L,2684355L,5162221L,9942054L,19173962L,37025581L,71582789L,138547333L,268435456L,520602097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053639Inst : IEnumerable<long>
{
public static readonly long[] Value=A053639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053639.Bytes);
public long this[int i]=>Value[i];

public static A053639Inst Instance=new A053639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053640
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,16L,18L,20L,24L,32L,36L,40L,48L,54L,64L,72L,80L,96L,108L,120L,128L,144L,160L,192L,216L,240L,256L,288L,320L,384L,432L,480L,512L,576L,640L,720L,768L,864L,960L,1024L,1152L,1280L,1440L,1536L,1728L,1920L,2048L,2304L,2560L,2880L,3072L,3456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053640Inst : IEnumerable<long>
{
public static readonly long[] Value=A053640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053640.Bytes);
public long this[int i]=>Value[i];

public static A053640Inst Instance=new A053640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053641
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,9L,3L,11L,5L,13L,7L,15L,1L,17L,3L,19L,5L,21L,7L,23L,9L,25L,11L,27L,13L,29L,15L,31L,1L,33L,3L,35L,5L,37L,7L,39L,9L,41L,11L,43L,13L,45L,15L,47L,17L,49L,19L,51L,21L,53L,23L,55L,25L,57L,27L,59L,29L,61L,31L,63L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053641Inst : IEnumerable<long>
{
public static readonly long[] Value=A053641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053641.Bytes);
public long this[int i]=>Value[i];

public static A053641Inst Instance=new A053641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053642
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,6L,7L,1L,3L,6L,7L,12L,13L,14L,15L,1L,3L,6L,7L,12L,13L,14L,15L,24L,25L,26L,27L,28L,29L,30L,31L,1L,3L,6L,7L,12L,13L,14L,15L,24L,25L,26L,27L,28L,29L,30L,31L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053642Inst : IEnumerable<long>
{
public static readonly long[] Value=A053642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053642.Bytes);
public long this[int i]=>Value[i];

public static A053642Inst Instance=new A053642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053643
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,4L,10L,21L,42L,77L,132L,215L,334L,501L,728L,1032L,1428L,1938L,2584L,3392L,4389L,5609L,7084L,8855L,10964L,13455L,16380L,19793L,23751L,28319L,33563L,39556L,46376L,54106L,62832L,72650L,83657L,95960L,109668L,124900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053643Inst : IEnumerable<long>
{
public static readonly long[] Value=A053643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053643.Bytes);
public long this[int i]=>Value[i];

public static A053643Inst Instance=new A053643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053644
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,4L,4L,8L,8L,8L,8L,8L,8L,8L,8L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053644Inst : IEnumerable<long>
{
public static readonly long[] Value=A053644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053644.Bytes);
public long this[int i]=>Value[i];

public static A053644Inst Instance=new A053644Inst();

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