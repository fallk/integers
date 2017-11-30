using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A118779
{
public static readonly BigInteger[] Value={ 16L,-224L,0L,182016L,12734992L,-80430368L,-125120640L,1334967760L,1060202222660L,-2759409121760L,54820105989504L,-14148083510835712L,49989643415528010L,299304923505836144L,1713123391839442498L,BigInteger.Parse("93227182153040103540"),BigInteger.Parse("-86403659709730762670") };
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
public class A118779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118779Inst Instance=new A118779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118780
{
public static readonly long[] Value={ -14L,-6L,-5L,0L,-7L,-87L,-4L,76L,-8L,-212L,64L,-4L,128L,68L,-265L,31L,-12L,-177L,104L,109L,-28L,103L,-101L,-40L,-24L,-348L,-176L,253L,81L,-285L,-97L,928L,364L,-841L,-257L,-361L,-127L,-3L,-125L,603L,359L,-675L,367L,-8L,-860L,139L,-3L,995L,280L,-1276L,-167L,629L,145L,443L,-365L,-579L,171L,-569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118780Inst : IEnumerable<long>
{
public static readonly long[] Value=A118780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118780.Bytes);
public long this[int i]=>Value[i];

public static A118780Inst Instance=new A118780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118781
{
public static readonly long[] Value={ -196L,272L,-251L,149L,-423L,909L,-408L,-452L,958L,-123L,-112L,-460L,84L,-271L,-187L,-162L,63L,7L,101L,-483L,-133L,205L,-860L,-46L,339L,1178L,848L,366L,1084L,719L,-384L,334L,-2736L,-984L,-1912L,214L,34L,40L,-1735L,-60L,64L,-2263L,-3468L,5795L,69L,132L,3007L,256L,2130L,3428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118781Inst : IEnumerable<long>
{
public static readonly long[] Value=A118781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118781.Bytes);
public long this[int i]=>Value[i];

public static A118781Inst Instance=new A118781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118782
{
public static readonly long[] Value={ 6L,9L,12L,19L,20L,23L,28L,31L,32L,33L,39L,59L,62L,66L,67L,75L,79L,80L,83L,84L,85L,91L,98L,99L,107L,108L,109L,117L,121L,144L,147L,149L,150L,153L,155L,156L,159L,160L,167L,169L,178L,179L,184L,186L,187L,191L,195L,208L,210L,212L,220L,222L,226L,227L,229L,231L,242L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118782Inst : IEnumerable<long>
{
public static readonly long[] Value=A118782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118782.Bytes);
public long this[int i]=>Value[i];

public static A118782Inst Instance=new A118782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118783
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,5L,12L,9L,13L,11L,19L,15L,23L,21L,20L,25L,32L,18L,35L,24L,30L,29L,43L,28L,41L,37L,44L,38L,55L,27L,60L,47L,49L,51L,56L,42L,71L,54L,61L,50L,79L,46L,83L,63L,65L,68L,91L,59L,87L,67L,81L,75L,104L,66L,93L,77L,88L,85L,115L,57L,119L,96L,90L,99L,109L,73L,131L,102L,105L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118783Inst : IEnumerable<long>
{
public static readonly long[] Value=A118783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118783.Bytes);
public long this[int i]=>Value[i];

public static A118783Inst Instance=new A118783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118784
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,8L,13L,14L,16L,12L,22L,11L,25L,19L,24L,23L,34L,21L,37L,28L,32L,30L,45L,27L,46L,36L,43L,38L,58L,26L,62L,42L,52L,44L,60L,33L,73L,49L,61L,50L,82L,39L,85L,56L,70L,59L,94L,51L,89L,64L,83L,68L,106L,55L,96L,71L,95L,78L,117L,53L,121L,86L,100L,87L,111L,66L,134L,90L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118784Inst : IEnumerable<long>
{
public static readonly long[] Value=A118784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118784.Bytes);
public long this[int i]=>Value[i];

public static A118784Inst Instance=new A118784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118785
{
public static readonly long[] Value={ 1L,12L,32L,42L,32L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118785Inst : IEnumerable<long>
{
public static readonly long[] Value=A118785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118785.Bytes);
public long this[int i]=>Value[i];

public static A118785Inst Instance=new A118785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118786
{
public static readonly long[] Value={ 2L,5L,7L,31L,71L,83L,89L,101L,103L,109L,139L,223L,241L,293L,349L,433L,491L,509L,521L,541L,599L,617L,641L,719L,751L,787L,827L,883L,947L,997L,1213L,1291L,1303L,1321L,1367L,1381L,1423L,1531L,1571L,1597L,1747L,1787L,2017L,2027L,2029L,2111L,2129L,2207L,2237L,2341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118786Inst : IEnumerable<long>
{
public static readonly long[] Value=A118786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118786.Bytes);
public long this[int i]=>Value[i];

public static A118786Inst Instance=new A118786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118787
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,6L,12L,23L,41L,24L,60L,130L,255L,469L,120L,360L,870L,1860L,3679L,6889L,720L,2520L,6720L,15540L,32858L,65247L,123605L,5040L,20160L,58800L,146160L,328734L,689388L,1371887L,2620169L,40320L,181440L,574560L,1527120L,3638376L,8029980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118787Inst : IEnumerable<long>
{
public static readonly long[] Value=A118787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118787.Bytes);
public long this[int i]=>Value[i];

public static A118787Inst Instance=new A118787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118788
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,5L,1L,6L,23L,41L,1L,10L,65L,255L,469L,1L,15L,145L,930L,3679L,6889L,1L,21L,280L,2590L,16429L,65247L,123605L,1L,28L,490L,6090L,54789L,344694L,1371887L,2620169L,1L,36L,798L,12726L,151599L,1338330L,8367785L,33347535L,64074901L,1L,45L,1230L,24360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118788Inst : IEnumerable<long>
{
public static readonly long[] Value=A118788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118788.Bytes);
public long this[int i]=>Value[i];

public static A118788Inst Instance=new A118788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118789
{
public static readonly BigInteger[] Value={ 1L,2L,9L,71L,800L,11659L,208173L,4398148L,107293711L,2967800711L,91777098006L,3137581240925L,117499040544197L,4783424590188490L,210333509575901445L,9934472399437068811UL,BigInteger.Parse("501615620424564184408"),BigInteger.Parse("26963169913347131361647") };
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
public class A118789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118789Inst Instance=new A118789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118790
{
public static readonly BigInteger[] Value={ 1L,3L,23L,255L,3679L,65247L,1371887L,33347535L,919848991L,28382683263L,968565339983L,36217270235055L,1472548026160639L,64679673007670367L,3052084360057720367L,BigInteger.Parse("153980839859926277775"),BigInteger.Parse("8270901171633696369631") };
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
public class A118790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118790Inst Instance=new A118790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118791
{
public static readonly long[] Value={ 1L,-1L,3L,2L,-9L,19L,-6L,36L,-103L,207L,24L,-180L,650L,-1605L,3211L,-120L,1080L,-4710L,13860L,-32191L,64383L,720L,-7560L,38640L,-132300L,351722L,-790629L,1581259L,-5040L,60480L,-354480L,1386000L,-4163166L,10433556L,-22974463L,45948927L,40320L,-544320L,3598560L,-15830640L,53117064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118791Inst : IEnumerable<long>
{
public static readonly long[] Value=A118791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118791.Bytes);
public long this[int i]=>Value[i];

public static A118791Inst Instance=new A118791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118792
{
public static readonly BigInteger[] Value={ 0L,1L,4L,30L,352L,5670L,116344L,2902830L,85326112L,2887962870L,110620824904L,4730842053630L,223445584599472L,11552029520192070L,648869447924011864L,BigInteger.Parse("39347855472366932430"),BigInteger.Parse("2562065820090343738432"),BigInteger.Parse("178286102174571726213270") };
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
public class A118792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118792Inst Instance=new A118792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118793
{
public static readonly long[] Value={ 1L,-1L,3L,1L,-9L,19L,-1L,18L,-103L,207L,1L,-30L,325L,-1605L,3211L,-1L,45L,-785L,6930L,-32191L,64383L,1L,-63L,1610L,-22050L,175861L,-790629L,1581259L,-1L,84L,-2954L,57750L,-693861L,5216778L,-22974463L,45948927L,1L,-108L,4998L,-131922L,2213211L,-24542910L,177555925L,-770820885L,1541641771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118793Inst : IEnumerable<long>
{
public static readonly long[] Value=A118793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118793.Bytes);
public long this[int i]=>Value[i];

public static A118793Inst Instance=new A118793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118794
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,121L,1902L,38381L,945989L,27552260L,925920081L,35265751869L,1501219998148L,70632987480771L,3639861179067661L,203881981765871618L,12333901891547136559UL,BigInteger.Parse("801418950244634922973"),BigInteger.Parse("55665376886060309513990") };
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
public class A118794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118794Inst Instance=new A118794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118795
{
public static readonly BigInteger[] Value={ 0L,1L,4L,29L,329L,5172L,104335L,2571473L,74894818L,2516911731L,95862252417L,4080739041238L,192000366357981L,9894168501171229L,554208686184384028L,BigInteger.Parse("33527021385789228265"),BigInteger.Parse("2178482569432714859789"),BigInteger.Parse("151314182463701892157460"),BigInteger.Parse("11188187745418763137485747") };
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
public class A118795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118795Inst Instance=new A118795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118796
{
public static readonly long[] Value={ 2L,13L,23L,29L,37L,41L,79L,107L,127L,149L,211L,239L,263L,313L,383L,389L,397L,439L,467L,509L,547L,631L,673L,743L,757L,773L,787L,827L,829L,907L,997L,1019L,1061L,1091L,1231L,1297L,1367L,1451L,1459L,1487L,1543L,1559L,1601L,1609L,1613L,1627L,1637L,1699L,1721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118796Inst : IEnumerable<long>
{
public static readonly long[] Value=A118796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118796.Bytes);
public long this[int i]=>Value[i];

public static A118796Inst Instance=new A118796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118797
{
public static readonly long[] Value={ 7L,11L,14L,17L,19L,23L,25L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118797Inst : IEnumerable<long>
{
public static readonly long[] Value=A118797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118797.Bytes);
public long this[int i]=>Value[i];

public static A118797Inst Instance=new A118797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118798
{
public static readonly long[] Value={ 79L,178L,179L,186L,210L,284L,300L,349L,391L,456L,594L,595L,599L,624L,645L,654L,659L,704L,712L,713L,860L,871L,892L,904L,924L,990L,1015L,1089L,1097L,1110L,1118L,1151L,1165L,1374L,1396L,1459L,1709L,1721L,1826L,1831L,1911L,1943L,1956L,2005L,2061L,2082L,2089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118798Inst : IEnumerable<long>
{
public static readonly long[] Value=A118798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118798.Bytes);
public long this[int i]=>Value[i];

public static A118798Inst Instance=new A118798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118799
{
public static readonly long[] Value={ 880L,-448L,-1472L,-240L,2480L,-1352L,-4128L,-96L,2736L,-2520L,120L,1080L,4288L,4880L,4600L,13368L,7056L,14560L,2960L,13320L,0L,24864L,-11096L,-24264L,0L,-9168L,-2128L,-15792L,0L,18120L,-5248L,6384L,-21840L,-38776L,-20480L,20176L,-72896L,-69200L,40080L,-37632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118799Inst : IEnumerable<long>
{
public static readonly long[] Value=A118799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118799.Bytes);
public long this[int i]=>Value[i];

public static A118799Inst Instance=new A118799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118800
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-3L,1L,4L,-8L,5L,-1L,8L,-20L,18L,-7L,1L,16L,-48L,56L,-32L,9L,-1L,32L,-112L,160L,-120L,50L,-11L,1L,64L,-256L,432L,-400L,220L,-72L,13L,-1L,128L,-576L,1120L,-1232L,840L,-364L,98L,-15L,1L,256L,-1280L,2816L,-3584L,2912L,-1568L,560L,-128L,17L,-1L,512L,-2816L,6912L,-9984L,9408L,-6048L,2688L,-816L,162L,-19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118800Inst : IEnumerable<long>
{
public static readonly long[] Value=A118800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118800.Bytes);
public long this[int i]=>Value[i];

public static A118800Inst Instance=new A118800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118801
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,1L,1L,-7L,5L,-1L,1L,-15L,17L,-7L,1L,1L,-31L,49L,-31L,9L,-1L,1L,-63L,129L,-111L,49L,-11L,1L,1L,-127L,321L,-351L,209L,-71L,13L,-1L,1L,-255L,769L,-1023L,769L,-351L,97L,-15L,1L,1L,-511L,1793L,-2815L,2561L,-1471L,545L,-127L,17L,-1L,1L,-1023L,4097L,-7423L,7937L,-5503L,2561L,-799L,161L,-19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118801Inst : IEnumerable<long>
{
public static readonly long[] Value=A118801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118801.Bytes);
public long this[int i]=>Value[i];

public static A118801Inst Instance=new A118801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118802
{
public static readonly long[] Value={ 1L,2L,11L,76L,565L,4406L,35455L,291264L,2427113L,20436202L,173435251L,1481052596L,12711044125L,109543953182L,947334302951L,8216780507176L,71450654876625L,622692860482514L,5437356743763163L,47561030194674972L,416661242790844421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118802Inst : IEnumerable<long>
{
public static readonly long[] Value=A118802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118802.Bytes);
public long this[int i]=>Value[i];

public static A118802Inst Instance=new A118802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118803
{
public static readonly long[] Value={ 1L,1L,5L,33L,237L,1801L,14197L,114609L,940445L,7809273L,65437541L,552276577L,4688278093L,39991233641L,342517093333L,2943809545105L,25377201555325L,219341012215385L,1900216743054021L,16496109719061825L,143469924189693229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118803Inst : IEnumerable<long>
{
public static readonly long[] Value=A118803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118803.Bytes);
public long this[int i]=>Value[i];

public static A118803Inst Instance=new A118803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118804
{
public static readonly BigInteger[] Value={ 1L,2L,9L,66L,685L,9294L,156697L,3169910L,74998081L,2035262154L,62391632417L,2134187066010L,80641239109677L,3337651407273846L,150239268816661137L,7310140430519234862L,BigInteger.Parse("382439924662714479457"),BigInteger.Parse("21413128578896024921298"),BigInteger.Parse("1277905479699750127195097") };
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
public class A118804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118804Inst Instance=new A118804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118805
{
public static readonly BigInteger[] Value={ 1L,2L,11L,106L,1506L,28736L,694719L,20452602L,712529978L,28746803264L,1320665162746L,68164569542628L,3909330000805268L,246855506805662816L,17030177827550184395UL,BigInteger.Parse("1275139722566251183642"),BigInteger.Parse("103032621304705343054010") };
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
public class A118805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118805Inst Instance=new A118805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118806
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,5L,6L,1L,9L,2L,12L,3L,19L,3L,24L,5L,1L,34L,8L,43L,13L,62L,13L,2L,77L,23L,1L,105L,28L,2L,132L,40L,4L,177L,49L,5L,220L,71L,6L,287L,89L,8L,1L,356L,123L,11L,462L,147L,18L,570L,198L,23L,1L,723L,249L,29L,1L,888L,329L,37L,1L,1121L,400L,50L,4L,1370L,518L,69L,1L,1705L,642L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118806Inst : IEnumerable<long>
{
public static readonly long[] Value=A118806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118806.Bytes);
public long this[int i]=>Value[i];

public static A118806Inst Instance=new A118806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118807
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,6L,9L,12L,19L,24L,34L,43L,62L,77L,105L,132L,177L,220L,287L,356L,462L,570L,723L,888L,1121L,1370L,1705L,2074L,2570L,3111L,3816L,4601L,5617L,6743L,8170L,9777L,11794L,14058L,16858L,20029L,23932L,28334L,33692L,39772L,47133L,55468L,65471L,76840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118807Inst : IEnumerable<long>
{
public static readonly long[] Value=A118807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118807.Bytes);
public long this[int i]=>Value[i];

public static A118807Inst Instance=new A118807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118808
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,3L,3L,5L,8L,13L,13L,23L,28L,40L,49L,71L,89L,123L,147L,198L,249L,329L,400L,518L,642L,825L,996L,1265L,1545L,1941L,2340L,2920L,3533L,4357L,5233L,6417L,7717L,9399L,11211L,13591L,16215L,19540L,23189L,27826L,32990L,39392L,46504L,55313L,65200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118808Inst : IEnumerable<long>
{
public static readonly long[] Value=A118808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118808.Bytes);
public long this[int i]=>Value[i];

public static A118808Inst Instance=new A118808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118809
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,4L,10L,11L,13L,8L,16L,12L,14L,17L,20L,15L,22L,7L,25L,21L,24L,18L,31L,26L,28L,27L,33L,19L,36L,29L,35L,34L,37L,38L,44L,30L,40L,39L,47L,23L,48L,32L,49L,46L,45L,42L,57L,50L,54L,51L,55L,41L,61L,56L,63L,58L,59L,52L,70L,53L,62L,67L,68L,64L,72L,60L,73L,66L,77L,43L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118809Inst : IEnumerable<long>
{
public static readonly long[] Value=A118809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118809.Bytes);
public long this[int i]=>Value[i];

public static A118809Inst Instance=new A118809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118810
{
public static readonly long[] Value={ 1L,2L,3L,7L,4L,5L,19L,11L,6L,8L,9L,13L,10L,14L,17L,12L,15L,23L,29L,16L,21L,18L,41L,22L,20L,25L,27L,26L,31L,37L,24L,43L,28L,33L,32L,30L,34L,35L,39L,38L,53L,47L,71L,36L,46L,45L,40L,42L,44L,49L,51L,59L,61L,50L,52L,55L,48L,57L,58L,67L,54L,62L,56L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118810Inst : IEnumerable<long>
{
public static readonly long[] Value=A118810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118810.Bytes);
public long this[int i]=>Value[i];

public static A118810Inst Instance=new A118810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118811
{
public static readonly long[] Value={ 9L,0L,1L,7L,3L,5L,6L,9L,8L,5L,6L,5L,4L,6L,9L,7L,6L,9L,1L,8L,6L,0L,9L,6L,3L,4L,0L,2L,9L,7L,0L,0L,7L,7L,0L,0L,3L,9L,3L,0L,5L,9L,7L,1L,8L,6L,1L,3L,0L,9L,8L,0L,1L,9L,8L,9L,3L,4L,3L,3L,8L,3L,3L,7L,6L,1L,7L,1L,5L,4L,4L,6L,8L,0L,2L,0L,3L,4L,6L,9L,4L,5L,5L,7L,2L,9L,6L,9L,7L,0L,5L,9L,3L,1L,0L,3L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118811Inst : IEnumerable<long>
{
public static readonly long[] Value=A118811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118811.Bytes);
public long this[int i]=>Value[i];

public static A118811Inst Instance=new A118811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118812
{
public static readonly BigInteger[] Value={ 2L,23L,87178286161L,BigInteger.Parse("403291461126605629356979201"),BigInteger.Parse("5502622159812088949850305428800254867109635014075023360001") };
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
public class A118812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118812Inst Instance=new A118812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118813
{
public static readonly BigInteger[] Value={ 3628679L,87178286159L,20922789847679L,BigInteger.Parse("265252859812191058635000805631999") };
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
public class A118813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118813Inst Instance=new A118813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118814
{
public static readonly long[] Value={ 1L,2L,5L,18L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118814Inst : IEnumerable<long>
{
public static readonly long[] Value=A118814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118814.Bytes);
public long this[int i]=>Value[i];

public static A118814Inst Instance=new A118814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118815
{
public static readonly long[] Value={ -4656L,1440L,2912L,2832L,-10464L,-768L,-17376L,20384L,-72976L,-18944L,12672L,41184L,-199776L,28944L,-21104L,3552L,25488L,338448L,-60192L,39952L,-21792L,-161904L,499488L,-83424L,-7440L,7440L,-54288L,-75456L,1641792L,42288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118815Inst : IEnumerable<long>
{
public static readonly long[] Value=A118815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118815.Bytes);
public long this[int i]=>Value[i];

public static A118815Inst Instance=new A118815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118816
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,2L,2L,1L,3L,3L,1L,4L,4L,1L,5L,5L,0L,6L,6L,2L,7L,7L,2L,8L,8L,1L,9L,9L,3L,10L,10L,3L,11L,11L,1L,12L,12L,4L,13L,13L,4L,14L,14L,1L,15L,15L,5L,16L,16L,5L,17L,17L,0L,18L,18L,6L,19L,19L,6L,20L,20L,2L,21L,21L,7L,22L,22L,7L,23L,23L,2L,24L,24L,8L,25L,25L,8L,26L,26L,1L,27L,27L,9L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118816Inst : IEnumerable<long>
{
public static readonly long[] Value=A118816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118816.Bytes);
public long this[int i]=>Value[i];

public static A118816Inst Instance=new A118816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118817
{
public static readonly long[] Value={ 3L,8L,8L,5L,3L,6L,1L,5L,3L,3L,3L,5L,1L,7L,5L,8L,5L,9L,1L,8L,4L,3L,2L,9L,5L,7L,5L,6L,8L,7L,0L,3L,5L,9L,0L,5L,0L,1L,3L,9L,0L,0L,5L,2L,8L,5L,9L,7L,5L,1L,7L,9L,2L,1L,9L,1L,3L,1L,8L,4L,6L,1L,1L,9L,9L,8L,7L,9L,8L,7L,4L,9L,4L,3L,4L,6L,3L,3L,9L,3L,2L,7L,6L,8L,3L,8L,8L,4L,3L,1L,9L,7L,8L,1L,3L,8L,3L,4L,0L,8L,2L,2L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118817Inst : IEnumerable<long>
{
public static readonly long[] Value=A118817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118817.Bytes);
public long this[int i]=>Value[i];

public static A118817Inst Instance=new A118817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118818
{
public static readonly long[] Value={ 223L,379L,463L,631L,691L,883L,907L,1051L,1423L,1447L,1543L,1723L,1747L,1783L,1987L,2143L,2179L,2347L,2467L,2591L,2767L,3259L,3307L,3511L,3631L,3691L,3739L,3823L,3907L,4219L,4447L,4507L,4519L,4639L,4987L,5023L,5107L,5119L,5347L,5683L,5923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118818Inst : IEnumerable<long>
{
public static readonly long[] Value=A118818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118818.Bytes);
public long this[int i]=>Value[i];

public static A118818Inst Instance=new A118818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118819
{
public static readonly long[] Value={ 1L,7L,13L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118819Inst : IEnumerable<long>
{
public static readonly long[] Value=A118819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118819.Bytes);
public long this[int i]=>Value[i];

public static A118819Inst Instance=new A118819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118820
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118820Inst : IEnumerable<long>
{
public static readonly long[] Value=A118820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118820.Bytes);
public long this[int i]=>Value[i];

public static A118820Inst Instance=new A118820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118821
{
public static readonly long[] Value={ 2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-8L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-16L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-8L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-32L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-8L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118821Inst : IEnumerable<long>
{
public static readonly long[] Value=A118821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118821.Bytes);
public long this[int i]=>Value[i];

public static A118821Inst Instance=new A118821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118822
{
public static readonly long[] Value={ 2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118822Inst : IEnumerable<long>
{
public static readonly long[] Value=A118822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118822.Bytes);
public long this[int i]=>Value[i];

public static A118822Inst Instance=new A118822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118823
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,0L,1L,-4L,-7L,3L,-1L,5L,9L,-4L,1L,-12L,-23L,11L,-1L,13L,25L,-12L,1L,-16L,-31L,15L,-1L,17L,33L,-16L,1L,-32L,-63L,31L,-1L,33L,65L,-32L,1L,-36L,-71L,35L,-1L,37L,73L,-36L,1L,-44L,-87L,43L,-1L,45L,89L,-44L,1L,-48L,-95L,47L,-1L,49L,97L,-48L,1L,-80L,-159L,79L,-1L,81L,161L,-80L,1L,-84L,-167L,83L,-1L,85L,169L,-84L,1L,-92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118823Inst : IEnumerable<long>
{
public static readonly long[] Value=A118823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118823.Bytes);
public long this[int i]=>Value[i];

public static A118823Inst Instance=new A118823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118824
{
public static readonly long[] Value={ -2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,8L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,16L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,8L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,32L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,8L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,16L,-2L,1L,-2L,2L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118824Inst : IEnumerable<long>
{
public static readonly long[] Value=A118824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118824.Bytes);
public long this[int i]=>Value[i];

public static A118824Inst Instance=new A118824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118825
{
public static readonly long[] Value={ -2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118825Inst : IEnumerable<long>
{
public static readonly long[] Value=A118825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118825.Bytes);
public long this[int i]=>Value[i];

public static A118825Inst Instance=new A118825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118826
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,0L,1L,4L,-7L,-3L,-1L,-5L,9L,4L,1L,12L,-23L,-11L,-1L,-13L,25L,12L,1L,16L,-31L,-15L,-1L,-17L,33L,16L,1L,32L,-63L,-31L,-1L,-33L,65L,32L,1L,36L,-71L,-35L,-1L,-37L,73L,36L,1L,44L,-87L,-43L,-1L,-45L,89L,44L,1L,48L,-95L,-47L,-1L,-49L,97L,48L,1L,80L,-159L,-79L,-1L,-81L,161L,80L,1L,84L,-167L,-83L,-1L,-85L,169L,84L,1L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118826Inst : IEnumerable<long>
{
public static readonly long[] Value=A118826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118826.Bytes);
public long this[int i]=>Value[i];

public static A118826Inst Instance=new A118826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118827
{
public static readonly long[] Value={ 1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-16L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-32L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-16L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-64L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-16L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-32L,1L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118827Inst : IEnumerable<long>
{
public static readonly long[] Value=A118827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118827.Bytes);
public long this[int i]=>Value[i];

public static A118827Inst Instance=new A118827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118828
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118828Inst : IEnumerable<long>
{
public static readonly long[] Value=A118828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118828.Bytes);
public long this[int i]=>Value[i];

public static A118828Inst Instance=new A118828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118829
{
public static readonly long[] Value={ 1L,-2L,-1L,2L,1L,0L,1L,-8L,-7L,6L,-1L,10L,9L,-8L,1L,-24L,-23L,22L,-1L,26L,25L,-24L,1L,-32L,-31L,30L,-1L,34L,33L,-32L,1L,-64L,-63L,62L,-1L,66L,65L,-64L,1L,-72L,-71L,70L,-1L,74L,73L,-72L,1L,-88L,-87L,86L,-1L,90L,89L,-88L,1L,-96L,-95L,94L,-1L,98L,97L,-96L,1L,-160L,-159L,158L,-1L,162L,161L,-160L,1L,-168L,-167L,166L,-1L,170L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118829Inst : IEnumerable<long>
{
public static readonly long[] Value=A118829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118829.Bytes);
public long this[int i]=>Value[i];

public static A118829Inst Instance=new A118829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118830
{
public static readonly long[] Value={ -1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,16L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,32L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,16L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,64L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,16L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,32L,-1L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118830Inst : IEnumerable<long>
{
public static readonly long[] Value=A118830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118830.Bytes);
public long this[int i]=>Value[i];

public static A118830Inst Instance=new A118830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118831
{
public static readonly long[] Value={ -1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118831Inst : IEnumerable<long>
{
public static readonly long[] Value=A118831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118831.Bytes);
public long this[int i]=>Value[i];

public static A118831Inst Instance=new A118831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118832
{
public static readonly long[] Value={ 1L,2L,-1L,-2L,1L,0L,1L,8L,-7L,-6L,-1L,-10L,9L,8L,1L,24L,-23L,-22L,-1L,-26L,25L,24L,1L,32L,-31L,-30L,-1L,-34L,33L,32L,1L,64L,-63L,-62L,-1L,-66L,65L,64L,1L,72L,-71L,-70L,-1L,-74L,73L,72L,1L,88L,-87L,-86L,-1L,-90L,89L,88L,1L,96L,-95L,-94L,-1L,-98L,97L,96L,1L,160L,-159L,-158L,-1L,-162L,161L,160L,1L,168L,-167L,-166L,-1L,-170L,169L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118832Inst : IEnumerable<long>
{
public static readonly long[] Value=A118832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118832.Bytes);
public long this[int i]=>Value[i];

public static A118832Inst Instance=new A118832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118833
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,7L,4L,12L,11L,9L,13L,10L,16L,15L,8L,24L,23L,21L,18L,19L,20L,22L,17L,31L,30L,28L,25L,29L,14L,46L,45L,43L,40L,36L,27L,42L,37L,32L,44L,38L,35L,49L,48L,41L,47L,33L,61L,60L,58L,55L,51L,34L,72L,71L,69L,66L,62L,53L,57L,52L,67L,59L,56L,70L,64L,50L,84L,83L,81L,78L,74L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118833Inst : IEnumerable<long>
{
public static readonly long[] Value=A118833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118833.Bytes);
public long this[int i]=>Value[i];

public static A118833Inst Instance=new A118833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118834
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,6L,15L,10L,12L,9L,8L,11L,29L,14L,13L,23L,19L,20L,21L,18L,22L,17L,16L,27L,141L,35L,26L,28L,25L,24L,38L,46L,52L,41L,34L,37L,40L,78L,33L,44L,36L,32L,39L,31L,30L,45L,43L,42L,66L,51L,60L,58L,72L,50L,63L,59L,49L,62L,48L,47L,57L,87L,65L,91L,56L,61L,106L,55L,64L,54L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118834Inst : IEnumerable<long>
{
public static readonly long[] Value=A118834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118834.Bytes);
public long this[int i]=>Value[i];

public static A118834Inst Instance=new A118834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118835
{
public static readonly BigInteger[] Value={ 4L,25L,229L,2315L,32639L,491900L,10362539L,228467758L,5722056489L,149001936472L,4922785960065L,167523724578682L,5868253146213935L,223161143280708212L,8709152841093834203L,BigInteger.Parse("400844191833597081550"),BigInteger.Parse("19650074552687350830153"),BigInteger.Parse("1002554646378888489419353") };
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
public class A118835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118835Inst Instance=new A118835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118836
{
public static readonly BigInteger[] Value={ 1L,6L,55L,556L,7839L,118141L,2488800L,54871741L,1374282325L,35786212191L,1182319284628L,40234641889543L,1409394785418633L,53597236487797597L,2091701617809524916L,BigInteger.Parse("96271871655725943733"),BigInteger.Parse("4719413412748380767833"),BigInteger.Parse("240786355921823145103216") };
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
public class A118836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118836Inst Instance=new A118836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118837
{
public static readonly long[] Value={ 1L,5L,9L,13L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118837Inst : IEnumerable<long>
{
public static readonly long[] Value=A118837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118837.Bytes);
public long this[int i]=>Value[i];

public static A118837Inst Instance=new A118837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118838
{
public static readonly long[] Value={ 1L,8L,45L,58L,92L,36L,70L,14L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L,104L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L,104L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L,104L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118838Inst : IEnumerable<long>
{
public static readonly long[] Value=A118838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118838.Bytes);
public long this[int i]=>Value[i];

public static A118838Inst Instance=new A118838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118839
{
public static readonly BigInteger[] Value={ 2L,11L,17L,29L,199L,521L,3571L,9349L,103681L,3010349L,54018521L,370248451L,6643838879L,10749957121L,119218851371L,5600748293801L,688846502588399L,32361122672259149L,BigInteger.Parse("115561578124838522881"),BigInteger.Parse("412670427844921037470771") };
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
public class A118839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118839Inst Instance=new A118839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118840
{
public static readonly BigInteger[] Value={ 3L,149L,1097L,22027L,BigInteger.Parse("3989519570547215850763757278730095398677254309") };
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
public class A118840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118840Inst Instance=new A118840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118841
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,16L,51169L,56003L,81671L,89849L,94823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118841Inst : IEnumerable<long>
{
public static readonly long[] Value=A118841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118841.Bytes);
public long this[int i]=>Value[i];

public static A118841Inst Instance=new A118841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118842
{
public static readonly long[] Value={ 2L,3L,5L,7L,47L,2207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118842Inst : IEnumerable<long>
{
public static readonly long[] Value=A118842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118842.Bytes);
public long this[int i]=>Value[i];

public static A118842Inst Instance=new A118842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118843
{
public static readonly BigInteger[] Value={ 307L,261424513284461L,BigInteger.Parse("56129192858827520816193436882886842322337671") };
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
public class A118843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118843Inst Instance=new A118843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118844
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,20L,22L,23L,24L,27L,28L,30L,32L,33L,34L,35L,36L,40L,43L,44L,45L,46L,48L,51L,54L,56L,60L,64L,65L,66L,67L,68L,70L,72L,77L,80L,83L,85L,86L,88L,90L,92L,96L,99L,102L,108L,112L,119L,120L,128L,129L,130L,131L,132L,134L,135L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118844Inst : IEnumerable<long>
{
public static readonly long[] Value=A118844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118844.Bytes);
public long this[int i]=>Value[i];

public static A118844Inst Instance=new A118844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118845
{
public static readonly long[] Value={ 13L,19L,21L,25L,26L,29L,31L,37L,38L,39L,41L,42L,47L,49L,50L,52L,53L,55L,57L,58L,59L,61L,62L,63L,69L,71L,73L,74L,75L,76L,78L,79L,81L,82L,84L,87L,89L,91L,93L,94L,95L,97L,98L,100L,101L,103L,104L,105L,106L,107L,109L,110L,111L,113L,114L,115L,116L,117L,118L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118845Inst : IEnumerable<long>
{
public static readonly long[] Value=A118845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118845.Bytes);
public long this[int i]=>Value[i];

public static A118845Inst Instance=new A118845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118846
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,18L,13L,6L,5L,2L,3L,6L,37L,1L,2L,3L,34L,17L,25L,44L,4L,15L,32L,7L,3L,244L,7L,13L,2L,8L,6L,129L,3L,6L,9L,73L,77L,69L,45L,90L,13L,1L,2L,3L,49L,15L,4L,46L,81L,4L,25L,44L,13L,20L,62L,3L,73L,7L,9L,20L,35L,7L,52L,4L,20L,674L,3L,3L,6L,163L,403L,673L,124L,8L,15L,2L,20L,6L,157L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118846Inst : IEnumerable<long>
{
public static readonly long[] Value=A118846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118846.Bytes);
public long this[int i]=>Value[i];

public static A118846Inst Instance=new A118846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118847
{
public static readonly long[] Value={ 1L,6L,11L,16L,66L,72L,22L,27L,77L,82L,33L,38L,88L,93L,44L,49L,99L,104L,46L,69L,101L,16L,66L,72L,22L,27L,77L,82L,33L,38L,88L,93L,44L,49L,99L,104L,46L,69L,101L,16L,66L,72L,22L,27L,77L,82L,33L,38L,88L,93L,44L,49L,99L,104L,46L,69L,101L,16L,66L,72L,22L,27L,77L,82L,33L,38L,88L,93L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118847Inst : IEnumerable<long>
{
public static readonly long[] Value=A118847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118847.Bytes);
public long this[int i]=>Value[i];

public static A118847Inst Instance=new A118847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118848
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,63L,67L,69L,73L,87L,91L,97L,99L,109L,111L,117L,131L,143L,147L,149L,153L,159L,161L,171L,177L,187L,191L,193L,197L,211L,217L,227L,229L,233L,239L,241L,249L,259L,261L,271L,273L,279L,283L,289L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118848Inst : IEnumerable<long>
{
public static readonly long[] Value=A118848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118848.Bytes);
public long this[int i]=>Value[i];

public static A118848Inst Instance=new A118848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118849
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,101L,107L,113L,137L,149L,211L,229L,311L,313L,317L,331L,347L,349L,353L,359L,401L,431L,443L,547L,607L,613L,619L,641L,659L,701L,719L,743L,811L,823L,829L,907L,929L,937L,947L,953L,1013L,1019L,1031L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118849Inst : IEnumerable<long>
{
public static readonly long[] Value=A118849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118849.Bytes);
public long this[int i]=>Value[i];

public static A118849Inst Instance=new A118849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118850
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,73L,97L,109L,131L,149L,191L,193L,197L,211L,227L,229L,233L,239L,241L,271L,283L,347L,367L,373L,379L,401L,419L,421L,439L,463L,491L,503L,509L,547L,569L,577L,587L,593L,613L,619L,631L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118850Inst : IEnumerable<long>
{
public static readonly long[] Value=A118850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118850.Bytes);
public long this[int i]=>Value[i];

public static A118850Inst Instance=new A118850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118851
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,4L,2L,1L,5L,4L,6L,3L,4L,2L,1L,6L,5L,8L,9L,4L,6L,8L,3L,4L,2L,1L,7L,6L,10L,12L,5L,8L,9L,12L,4L,6L,8L,3L,4L,2L,1L,8L,7L,12L,15L,16L,6L,10L,12L,16L,18L,5L,8L,9L,12L,16L,4L,6L,8L,3L,4L,2L,1L,9L,8L,14L,18L,20L,7L,12L,15L,16L,20L,24L,27L,6L,10L,12L,16L,18L,24L,5L,8L,9L,12L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118851Inst : IEnumerable<long>
{
public static readonly long[] Value=A118851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118851.Bytes);
public long this[int i]=>Value[i];

public static A118851Inst Instance=new A118851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118852
{
public static readonly long[] Value={ 1L,9L,17L,79L,105L,59L,103L,39L,101L,19L,99L,107L,79L,105L,59L,103L,39L,101L,19L,99L,107L,79L,105L,59L,103L,39L,101L,19L,99L,107L,79L,105L,59L,103L,39L,101L,19L,99L,107L,79L,105L,59L,103L,39L,101L,19L,99L,107L,79L,105L,59L,103L,39L,101L,19L,99L,107L,79L,105L,59L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118852Inst : IEnumerable<long>
{
public static readonly long[] Value=A118852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118852.Bytes);
public long this[int i]=>Value[i];

public static A118852Inst Instance=new A118852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118853
{
public static readonly long[] Value={ 1L,11L,21L,22L,32L,33L,43L,44L,54L,55L,65L,66L,76L,77L,87L,88L,98L,99L,109L,101L,21L,22L,32L,33L,43L,44L,54L,55L,65L,66L,76L,77L,87L,88L,98L,99L,109L,101L,21L,22L,32L,33L,43L,44L,54L,55L,65L,66L,76L,77L,87L,88L,98L,99L,109L,101L,21L,22L,32L,33L,43L,44L,54L,55L,65L,66L,76L,77L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118853Inst : IEnumerable<long>
{
public static readonly long[] Value=A118853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118853.Bytes);
public long this[int i]=>Value[i];

public static A118853Inst Instance=new A118853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118854
{
public static readonly long[] Value={ 2L,3L,8L,21L,24L,27L,45L,75L,93L,105L,117L,123L,147L,165L,213L,309L,315L,333L,357L,387L,453L,525L,555L,573L,627L,636L,693L,717L,729L,765L,795L,843L,915L,933L,957L,1005L,1083L,1125L,1173L,1227L,1323L,1347L,1437L,1467L,1515L,1563L,1575L,1677L,1725L,1755L,1773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118854Inst : IEnumerable<long>
{
public static readonly long[] Value=A118854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118854.Bytes);
public long this[int i]=>Value[i];

public static A118854Inst Instance=new A118854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118855
{
public static readonly long[] Value={ 2L,8L,24L,636L,12318L,13446L,32396L,46206L,133788L,162926L,181428L,359906L,439098L,453168L,485238L,508200L,739024L,840852L,1007580L,1410120L,1577066L,2056076L,2126134L,2422566L,2512406L,3275832L,3307848L,3457758L,4481014L,4698784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118855Inst : IEnumerable<long>
{
public static readonly long[] Value=A118855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118855.Bytes);
public long this[int i]=>Value[i];

public static A118855Inst Instance=new A118855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118856
{
public static readonly long[] Value={ 1L,14L,54L,58L,98L,102L,34L,56L,78L,100L,14L,54L,58L,98L,102L,34L,56L,78L,100L,14L,54L,58L,98L,102L,34L,56L,78L,100L,14L,54L,58L,98L,102L,34L,56L,78L,100L,14L,54L,58L,98L,102L,34L,56L,78L,100L,14L,54L,58L,98L,102L,34L,56L,78L,100L,14L,54L,58L,98L,102L,34L,56L,78L,100L,14L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118856Inst : IEnumerable<long>
{
public static readonly long[] Value=A118856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118856.Bytes);
public long this[int i]=>Value[i];

public static A118856Inst Instance=new A118856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118857
{
public static readonly long[] Value={ 1L,13L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L,76L,79L,109L,103L,43L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118857Inst : IEnumerable<long>
{
public static readonly long[] Value=A118857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118857.Bytes);
public long this[int i]=>Value[i];

public static A118857Inst Instance=new A118857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118858
{
public static readonly long[] Value={ 0L,7L,0L,2L,3L,0L,4L,9L,2L,7L,7L,2L,6L,8L,2L,8L,7L,6L,4L,0L,8L,9L,3L,8L,5L,9L,9L,4L,9L,6L,9L,9L,7L,0L,0L,9L,6L,3L,2L,8L,7L,6L,5L,3L,2L,4L,4L,3L,2L,6L,2L,5L,4L,1L,3L,7L,7L,4L,3L,4L,3L,7L,8L,2L,2L,8L,2L,4L,9L,6L,4L,1L,3L,3L,6L,9L,6L,8L,5L,3L,4L,0L,1L,4L,2L,0L,1L,6L,9L,3L,5L,8L,0L,7L,3L,3L,4L,0L,0L,9L,4L,3L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118858Inst : IEnumerable<long>
{
public static readonly long[] Value=A118858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118858.Bytes);
public long this[int i]=>Value[i];

public static A118858Inst Instance=new A118858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118859
{
public static readonly long[] Value={ 6L,53550L,420420L,422310L,1624350L,2130240L,3399900L,5199810L,5246010L,6549270L,7384440L,7775880L,9516570L,9565710L,10430280L,11845260L,13207950L,14562870L,14619990L,18747960L,20099940L,21596820L,21968100L,24358950L,24610740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118859Inst : IEnumerable<long>
{
public static readonly long[] Value=A118859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118859.Bytes);
public long this[int i]=>Value[i];

public static A118859Inst Instance=new A118859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118860
{
public static readonly long[] Value={ 21968100L,37674210L,81875220L,356467230L,416172330L,750662640L,1007393730L,1150070040L,1586271960L,1963954650L,3127171320L,3669568560L,4377895410L,4383541050L,5575083360L,5686935870L,5708418870L,7365234450L,7478474430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118860Inst : IEnumerable<long>
{
public static readonly long[] Value=A118860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118860.Bytes);
public long this[int i]=>Value[i];

public static A118860Inst Instance=new A118860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118861
{
public static readonly long[] Value={ 1L,15L,65L,70L,21L,26L,76L,81L,32L,37L,87L,92L,43L,48L,98L,103L,45L,68L,100L,15L,65L,70L,21L,26L,76L,81L,32L,37L,87L,92L,43L,48L,98L,103L,45L,68L,100L,15L,65L,70L,21L,26L,76L,81L,32L,37L,87L,92L,43L,48L,98L,103L,45L,68L,100L,15L,65L,70L,21L,26L,76L,81L,32L,37L,87L,92L,43L,48L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118861Inst : IEnumerable<long>
{
public static readonly long[] Value=A118861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118861.Bytes);
public long this[int i]=>Value[i];

public static A118861Inst Instance=new A118861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118862
{
public static readonly long[] Value={ 1L,16L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L,43L,49L,109L,106L,76L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118862Inst : IEnumerable<long>
{
public static readonly long[] Value=A118862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118862.Bytes);
public long this[int i]=>Value[i];

public static A118862Inst Instance=new A118862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118863
{
public static readonly long[] Value={ 1L,17L,87L,94L,65L,72L,43L,50L,21L,28L,98L,105L,67L,92L,45L,70L,23L,48L,100L,17L,87L,94L,65L,72L,43L,50L,21L,28L,98L,105L,67L,92L,45L,70L,23L,48L,100L,17L,87L,94L,65L,72L,43L,50L,21L,28L,98L,105L,67L,92L,45L,70L,23L,48L,100L,17L,87L,94L,65L,72L,43L,50L,21L,28L,98L,105L,67L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118863Inst : IEnumerable<long>
{
public static readonly long[] Value=A118863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118863.Bytes);
public long this[int i]=>Value[i];

public static A118863Inst Instance=new A118863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118864
{
public static readonly long[] Value={ 1L,18L,98L,106L,78L,104L,58L,102L,38L,100L,18L,98L,106L,78L,104L,58L,102L,38L,100L,18L,98L,106L,78L,104L,58L,102L,38L,100L,18L,98L,106L,78L,104L,58L,102L,38L,100L,18L,98L,106L,78L,104L,58L,102L,38L,100L,18L,98L,106L,78L,104L,58L,102L,38L,100L,18L,98L,106L,78L,104L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118864Inst : IEnumerable<long>
{
public static readonly long[] Value=A118864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118864.Bytes);
public long this[int i]=>Value[i];

public static A118864Inst Instance=new A118864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118865
{
public static readonly long[] Value={ 1L,20L,21L,31L,32L,42L,43L,53L,54L,64L,65L,75L,76L,86L,87L,97L,98L,108L,100L,20L,21L,31L,32L,42L,43L,53L,54L,64L,65L,75L,76L,86L,87L,97L,98L,108L,100L,20L,21L,31L,32L,42L,43L,53L,54L,64L,65L,75L,76L,86L,87L,97L,98L,108L,100L,20L,21L,31L,32L,42L,43L,53L,54L,64L,65L,75L,76L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118865Inst : IEnumerable<long>
{
public static readonly long[] Value=A118865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118865.Bytes);
public long this[int i]=>Value[i];

public static A118865Inst Instance=new A118865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118866
{
public static readonly long[] Value={ 1L,21L,32L,43L,54L,65L,76L,87L,98L,109L,111L,131L,331L,333L,353L,553L,555L,575L,775L,777L,797L,997L,999L,1019L,211L,132L,341L,433L,354L,563L,655L,576L,785L,877L,798L,1007L,91L,39L,113L,151L,531L,335L,373L,753L,557L,595L,975L,779L,817L,198L,1001L,31L,33L,53L,55L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118866Inst : IEnumerable<long>
{
public static readonly long[] Value=A118866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118866.Bytes);
public long this[int i]=>Value[i];

public static A118866Inst Instance=new A118866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118867
{
public static readonly long[] Value={ 15L,37L,46L,47L,64L,71L,83L,84L,90L,102L,106L,107L,116L,120L,122L,135L,149L,154L,168L,173L,179L,180L,181L,185L,193L,195L,198L,200L,210L,222L,224L,229L,232L,239L,242L,248L,265L,289L,299L,304L,310L,327L,330L,332L,333L,347L,356L,364L,367L,369L,375L,383L,402L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118867Inst : IEnumerable<long>
{
public static readonly long[] Value=A118867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118867.Bytes);
public long this[int i]=>Value[i];

public static A118867Inst Instance=new A118867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118868
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,24L,26L,28L,30L,33L,36L,39L,42L,45L,48L,56L,57L,60L,69L,72L,81L,84L,93L,105L,105L,144L,144L,177L,216L,225L,225L,288L,441L,513L,513L,729L,1224L,1800L,2304L,2304L,4761L,4761L,11664L,11664L,11664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118868Inst : IEnumerable<long>
{
public static readonly long[] Value=A118868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118868.Bytes);
public long this[int i]=>Value[i];

public static A118868Inst Instance=new A118868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118869
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,1L,28L,4L,53L,10L,1L,100L,24L,4L,188L,57L,10L,1L,354L,128L,26L,4L,667L,278L,68L,10L,1L,1256L,596L,164L,28L,4L,2365L,1260L,381L,79L,10L,1L,4454L,2628L,876L,200L,30L,4L,8388L,5430L,1977L,488L,90L,10L,1L,15796L,11136L,4380L,1184L,236L,32L,4L,29747L,22683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118869Inst : IEnumerable<long>
{
public static readonly long[] Value=A118869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118869.Bytes);
public long this[int i]=>Value[i];

public static A118869Inst Instance=new A118869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118870
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,28L,53L,100L,188L,354L,667L,1256L,2365L,4454L,8388L,15796L,29747L,56020L,105497L,198672L,374140L,704582L,1326871L,2498768L,4705689L,8861770L,16688516L,31427872L,59185079L,111457548L,209897245L,395279228L,744391228L,1401840170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118870Inst : IEnumerable<long>
{
public static readonly long[] Value=A118870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118870.Bytes);
public long this[int i]=>Value[i];

public static A118870Inst Instance=new A118870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118871
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,4L,10L,24L,57L,128L,278L,596L,1260L,2628L,5430L,11136L,22683L,45936L,92574L,185764L,371347L,739840L,1469580L,2911224L,5753048L,11343800L,22322444L,43845120L,85973013L,168314604L,329041842L,642385248L,1252552077L,2439430272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118871Inst : IEnumerable<long>
{
public static readonly long[] Value=A118871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118871.Bytes);
public long this[int i]=>Value[i];

public static A118871Inst Instance=new A118871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118872
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,9L,10L,11L,13L,16L,17L,21L,27L,31L,35L,36L,39L,114L,119L,973L,1005L,1010L,1025L,3006L,3029L,3040L,9128L,9215L,9227L,9316L,27431L,27442L,27515L,27519L,27554L,82632L,82746L,82763L,82784L,83111L,246838L,247206L,247388L,247406L,247447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118872Inst : IEnumerable<long>
{
public static readonly long[] Value=A118872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118872.Bytes);
public long this[int i]=>Value[i];

public static A118872Inst Instance=new A118872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118873
{
public static readonly long[] Value={ -29L,-136L,-1704L,-6288L,-5160L,-14928L,52080L,-97968L,-84000L,98112L,-524400L,-84048L,637488L,231288L,-1558440L,-343200L,844152L,-2799840L,1152360L,1469160L,-783240L,4153800L,-4254000L,-11947320L,-498768L,-264360L,-559248L,32952432L,-2061360L,-37128408L,-10466400L,18355512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118873Inst : IEnumerable<long>
{
public static readonly long[] Value=A118873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118873.Bytes);
public long this[int i]=>Value[i];

public static A118873Inst Instance=new A118873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118874
{
public static readonly long[] Value={ 1L,3L,1L,4L,2L,1L,1L,0L,1L,12L,2L,1L,1L,1L,1L,16L,0L,19L,1L,21L,3L,2L,2L,0L,1L,1L,1L,1L,1L,1L,1L,32L,1L,0L,0L,36L,2L,1L,1L,0L,2L,45L,3L,2L,2L,2L,2L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,64L,1L,67L,1L,0L,0L,0L,0L,0L,1L,76L,2L,1L,1L,1L,1L,81L,0L,84L,2L,86L,4L,3L,3L,0L,2L,2L,2L,2L,2L,2L,2L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118874Inst : IEnumerable<long>
{
public static readonly long[] Value=A118874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118874.Bytes);
public long this[int i]=>Value[i];

public static A118874Inst Instance=new A118874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118875
{
public static readonly long[] Value={ -213720L,114432L,-548352L,892800L,-1774080L,-7289856L,10105344L,-79557120L,-97790976L,171740160L,147556224L,56531520L,-380053440L,122206464L,-164292480L,-958000320L,394761600L,189907200L,-1495428480L,-4260988800L,-14501393280L,7022695680L,-3345955200L,-26017441920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118875Inst : IEnumerable<long>
{
public static readonly long[] Value=A118875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118875.Bytes);
public long this[int i]=>Value[i];

public static A118875Inst Instance=new A118875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118876
{
public static readonly long[] Value={ 768280320L,-1010949120L,-4719098880L,-1791590400L,24298444800L,-19462947840L,-109685145600L,-3192514560L,144441833472L,-198529367040L,15778022400L,159125783040L,861983659008L,1193361776640L,1359501373440L,5328357672960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118876Inst : IEnumerable<long>
{
public static readonly long[] Value=A118876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118876.Bytes);
public long this[int i]=>Value[i];

public static A118876Inst Instance=new A118876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118877
{
public static readonly long[] Value={ -12L,-12L,6L,6L,-18L,-18L,12L,12L,-24L,-24L,18L,-3L,-28L,-2L,-2L,24L,24L,-36L,-36L,-2L,-2L,32L,-3L,-42L,36L,36L,-48L,-48L,42L,-3L,-52L,-2L,-2L,48L,-3L,-58L,-2L,-2L,54L,54L,-66L,-66L,-2L,-2L,62L,-3L,-72L,66L,66L,-78L,-78L,-2L,-2L,74L,-3L,-84L,78L,-3L,-88L,-2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118877Inst : IEnumerable<long>
{
public static readonly long[] Value=A118877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118877.Bytes);
public long this[int i]=>Value[i];

public static A118877Inst Instance=new A118877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118878
{
public static readonly long[] Value={ 1L,190L,1L,87L,1L,0L,189L,0L,86L,0L,0L,188L,0L,85L,191L,0L,0L,95L,0L,190L,1L,0L,184L,0L,3L,187L,0L,0L,91L,0L,96L,0L,0L,180L,88L,0L,183L,0L,0L,87L,1L,92L,0L,0L,3L,84L,0L,179L,0L,0L,191L,0L,88L,0L,2L,190L,2L,87L,2L,1L,2L,97L,2L,192L,3L,0L,186L,0L,83L,189L,0L,0L,93L,0L,98L,0L,0L,182L,0L,1L,185L,0L,0L,89L,3L,94L,0L,0L,178L,86L,0L,181L,0L,0L,193L,0L,90L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118878Inst : IEnumerable<long>
{
public static readonly long[] Value=A118878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118878.Bytes);
public long this[int i]=>Value[i];

public static A118878Inst Instance=new A118878Inst();

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