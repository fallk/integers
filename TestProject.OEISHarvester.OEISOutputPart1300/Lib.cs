using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A281595
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,10L,125L,1890L,33621L,688506L,15958405L,413066170L,11810819141L,369730963602L,12577271147805L,461980538087250L,18223376862518101L,768327068469302218L,BigInteger.Parse("34480595937671194805"),BigInteger.Parse("1641060381277816308810"),BigInteger.Parse("82562177153973368528901"),BigInteger.Parse("4378026144983797903473954") };
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
public class A281595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281595Inst Instance=new A281595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281594
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,42L,66L,429L,1430L,4862L,8398L,58786L,104006L,74290L,222870L,3231615L,11785890L,129644790L,47763870L,1767263190L,3282060210L,12233133510L,22870640910L,22870640910L,214984024554L,115760628606L,655976895434L,34766775458002L,65936987937590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281594Inst : IEnumerable<long>
{
public static readonly long[] Value=A281594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281594.Bytes);
public long this[int i]=>Value[i];

public static A281594Inst Instance=new A281594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281593
{
public static readonly long[] Value={ 1L,1L,3L,11L,41L,153L,573L,2157L,8163L,31043L,118559L,454479L,1747771L,6740059L,26055459L,100939779L,391785129L,1523230569L,5931153429L,23126146629L,90282147849L,352846964649L,1380430179489L,5405662979649L,21186405207549L,83101804279101L,326199124351701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281593Inst : IEnumerable<long>
{
public static readonly long[] Value=A281593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281593.Bytes);
public long this[int i]=>Value[i];

public static A281593Inst Instance=new A281593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281592
{
public static readonly long[] Value={ 138L,777L,4642L,10258L,10263L,12207L,13282L,16167L,19762L,30783L,37407L,38482L,46978L,48927L,56127L,60145L,63543L,73767L,81687L,89823L,95367L,95627L,103863L,110905L,115527L,128545L,202705L,208879L,223643L,284119L,324947L,325793L,360151L,395003L,477538L,541163L,558322L,585538L,672199L,673693L,780082L,914551L,1016643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281592Inst : IEnumerable<long>
{
public static readonly long[] Value=A281592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281592.Bytes);
public long this[int i]=>Value[i];

public static A281592Inst Instance=new A281592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281591
{
public static readonly long[] Value={ 3L,5L,6L,5L,7L,6L,8L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,10L,11L,12L,11L,11L,12L,11L,12L,12L,12L,12L,13L,12L,13L,12L,13L,13L,13L,13L,13L,13L,13L,14L,13L,14L,13L,14L,14L,14L,14L,14L,14L,15L,14L,15L,14L,15L,14L,15L,15L,15L,15L,15L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281591Inst : IEnumerable<long>
{
public static readonly long[] Value=A281591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281591.Bytes);
public long this[int i]=>Value[i];

public static A281591Inst Instance=new A281591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281590
{
public static readonly long[] Value={ 1L,4L,9L,15L,20L,27L,33L,41L,48L,56L,64L,72L,80L,89L,98L,107L,116L,126L,136L,146L,156L,166L,176L,187L,198L,208L,219L,231L,242L,253L,265L,276L,288L,300L,312L,324L,337L,349L,362L,374L,387L,400L,413L,426L,439L,452L,465L,479L,492L,506L,519L,533L,547L,561L,575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281590Inst : IEnumerable<long>
{
public static readonly long[] Value=A281590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281590.Bytes);
public long this[int i]=>Value[i];

public static A281590Inst Instance=new A281590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281589
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,2L,1L,8L,5L,4L,3L,6L,7L,2L,1L,16L,9L,8L,5L,12L,13L,4L,3L,14L,11L,6L,7L,10L,15L,2L,1L,32L,17L,16L,9L,24L,25L,8L,5L,28L,21L,12L,13L,20L,29L,4L,3L,30L,19L,14L,11L,22L,27L,6L,7L,26L,23L,10L,15L,18L,31L,2L,1L,64L,33L,32L,17L,48L,49L,16L,9L,56L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281589Inst : IEnumerable<long>
{
public static readonly long[] Value=A281589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281589.Bytes);
public long this[int i]=>Value[i];

public static A281589Inst Instance=new A281589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281588
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,-5L,-24L,-98L,-272L,621L,4960L,31856L,132672L,-437593L,-4893056L,-42854160L,-237969664L,1026405753L,14756156928L,163699919104L,1136284574720L,-6054175060941L,-106379840985088L,-1428593836836352L,-11899498670002176L,75477454065058725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281588Inst : IEnumerable<long>
{
public static readonly long[] Value=A281588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281588.Bytes);
public long this[int i]=>Value[i];

public static A281588Inst Instance=new A281588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281587
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,-1L,4L,6L,4L,1L,-4L,-5L,10L,10L,5L,1L,-14L,-24L,-15L,20L,15L,6L,1L,-34L,-98L,-84L,-35L,35L,21L,7L,1L,69L,-272L,-392L,-224L,-70L,56L,28L,8L,1L,496L,621L,-1224L,-1176L,-504L,-126L,84L,36L,9L,1L,2896L,4960L,3105L,-4080L,-2940L,-1008L,-210L,120L,45L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281587Inst : IEnumerable<long>
{
public static readonly long[] Value=A281587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281587.Bytes);
public long this[int i]=>Value[i];

public static A281587Inst Instance=new A281587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281586
{
public static readonly long[] Value={ 0L,1L,2L,3L,-4L,-15L,-54L,133L,792L,4293L,-15130L,-123849L,-895212L,4101799L,42732522L,386103915L,-2177360656L,-27544520691L,-298649804706L,1999963458217L,29765143177020L,376514568163377L,-2919514870785766L,-49968285360277437L,-722370834074695896L,6365117686550339275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281586Inst : IEnumerable<long>
{
public static readonly long[] Value=A281586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281586.Bytes);
public long this[int i]=>Value[i];

public static A281586Inst Instance=new A281586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281585
{
public static readonly BigInteger[] Value={ 1L,5L,691L,3617L,43867L,174611L,854513L,236364091L,23749461029L,8615841276005L,BigInteger.Parse("26315271553053477373"),BigInteger.Parse("261082718496449122051"),BigInteger.Parse("1520097643918070802691"),BigInteger.Parse("27833269579301024235023"),BigInteger.Parse("596451111593912163277961"),BigInteger.Parse("5609403368997817686249127547") };
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
public class A281585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281585Inst Instance=new A281585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281584
{
public static readonly long[] Value={ 2L,7L,23L,58L,182L,457L,1433L,3598L,11282L,28327L,88823L,223018L,699302L,1755817L,5505593L,13823518L,43345442L,108832327L,341257943L,856835098L,2686718102L,6745848457L,21152486873L,53109952558L,166533176882L,418133772007L,1311112928183L,3291960223498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281584Inst : IEnumerable<long>
{
public static readonly long[] Value=A281584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281584.Bytes);
public long this[int i]=>Value[i];

public static A281584Inst Instance=new A281584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281551
{
public static readonly long[] Value={ 3L,23L,41L,47L,59L,89L,101L,149L,179L,227L,317L,347L,353L,383L,389L,479L,503L,599L,821L,887L,929L,977L,1019L,1109L,1229L,1283L,1319L,1511L,1571L,1619L,1667L,1709L,1733L,1787L,1847L,1889L,1907L,1913L,1931L,2207L,2309L,2333L,2357L,2399L,2417L,2459L,2609L,2753L,2789L,2909L,2963L,2999L,3203L,3257L,3299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281551Inst : IEnumerable<long>
{
public static readonly long[] Value=A281551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281551.Bytes);
public long this[int i]=>Value[i];

public static A281551Inst Instance=new A281551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281550
{
public static readonly long[] Value={ 0L,10L,46L,114L,234L,458L,826L,1370L,2090L,3010L,4174L,5658L,7534L,9930L,12954L,16662L,21074L,26242L,32246L,39182L,47186L,56386L,66874L,78798L,92290L,107434L,124282L,142942L,163550L,186266L,211250L,238626L,268526L,301134L,336610L,375086L,416678L,461454L,509434L,560662L,615182L,673106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281550Inst : IEnumerable<long>
{
public static readonly long[] Value=A281550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281550.Bytes);
public long this[int i]=>Value[i];

public static A281550Inst Instance=new A281550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281549
{
public static readonly long[] Value={ 525L,635L,3335L,22547L,132725L,242073L,590663L,598793L,795143L,963815L,1910433L,2506647L,5833497L,13032533L,13336685L,22163097L,22291055L,27730755L,36069767L,39412953L,41006745L,42520623L,44594457L,47869577L,63735185L,73770483L,76852937L,89703543L,100998105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281549Inst : IEnumerable<long>
{
public static readonly long[] Value=A281549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281549.Bytes);
public long this[int i]=>Value[i];

public static A281549Inst Instance=new A281549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281548
{
public static readonly long[] Value={ 1L,3L,11L,46L,210L,1018L,5150L,26889L,143829L,784167L,4341843L,24348352L,138007784L,789375504L,4550522248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281548Inst : IEnumerable<long>
{
public static readonly long[] Value=A281548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281548.Bytes);
public long this[int i]=>Value[i];

public static A281548Inst Instance=new A281548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281547
{
public static readonly BigInteger[] Value={ 1L,2L,10L,82L,1038L,19754L,561778L,23890766L,1516425978L,142478603490L,19560464078774L,3868751287074546L,1088233853378616578L,BigInteger.Parse("430599111941369628326"),BigInteger.Parse("237480490462200909980594"),BigInteger.Parse("181131722604060126010422898"),BigInteger.Parse("189780362331001773747253412782"),BigInteger.Parse("271553393666987988551182068682458"),BigInteger.Parse("527932854364810523962111033565618786") };
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
public class A281547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281547Inst Instance=new A281547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281546
{
public static readonly long[] Value={ 2L,29L,56L,83L,110L,137L,164L,191L,218L,245L,272L,299L,326L,353L,380L,407L,434L,461L,488L,515L,542L,569L,596L,623L,650L,677L,704L,731L,758L,785L,812L,839L,866L,893L,920L,947L,974L,1001L,1028L,1055L,1082L,1109L,1136L,1163L,1190L,1217L,1244L,1271L,1298L,1325L,1352L,1379L,1406L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281546Inst : IEnumerable<long>
{
public static readonly long[] Value=A281546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281546.Bytes);
public long this[int i]=>Value[i];

public static A281546Inst Instance=new A281546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281545
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,2L,0L,2L,1L,2L,1L,2L,3L,4L,1L,4L,4L,4L,6L,4L,7L,6L,6L,8L,9L,8L,10L,6L,13L,12L,12L,14L,15L,16L,16L,18L,23L,22L,19L,24L,24L,30L,28L,30L,33L,34L,34L,40L,44L,46L,44L,46L,58L,56L,60L,64L,65L,68L,70L,80L,86L,88L,87L,94L,101L,112L,114L,116L,125L,130L,132L,148L,159L,162L,163L,168L,190L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281545Inst : IEnumerable<long>
{
public static readonly long[] Value=A281545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281545.Bytes);
public long this[int i]=>Value[i];

public static A281545Inst Instance=new A281545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281544
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,1L,2L,3L,4L,4L,6L,7L,8L,11L,12L,15L,18L,20L,26L,29L,34L,40L,46L,54L,62L,71L,82L,94L,106L,122L,138L,157L,178L,201L,226L,254L,286L,321L,360L,402L,448L,501L,558L,619L,690L,764L,846L,938L,1036L,1145L,1264L,1392L,1532L,1687L,1854L,2036L,2234L,2448L,2680L,2934L,3210L,3507L,3828L,4178L,4554L,4961L,5404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281544Inst : IEnumerable<long>
{
public static readonly long[] Value=A281544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281544.Bytes);
public long this[int i]=>Value[i];

public static A281544Inst Instance=new A281544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281543
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,1L,4L,3L,4L,1L,4L,4L,3L,2L,4L,1L,8L,4L,4L,3L,6L,3L,5L,3L,4L,4L,9L,3L,8L,4L,6L,6L,9L,2L,7L,4L,7L,5L,7L,3L,5L,7L,7L,6L,9L,4L,14L,4L,8L,4L,9L,4L,11L,7L,7L,6L,17L,5L,11L,6L,10L,8L,9L,5L,11L,6L,9L,7L,8L,3L,13L,9L,9L,5L,15L,5L,20L,8L,11L,8L,14L,7L,13L,9L,8L,6L,18L,7L,14L,10L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281543Inst : IEnumerable<long>
{
public static readonly long[] Value=A281543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281543.Bytes);
public long this[int i]=>Value[i];

public static A281543Inst Instance=new A281543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281542
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,0L,0L,0L,1L,2L,0L,0L,2L,3L,0L,1L,2L,0L,0L,2L,3L,0L,0L,0L,3L,5L,0L,0L,5L,7L,0L,0L,0L,2L,3L,1L,2L,3L,4L,2L,5L,3L,0L,0L,5L,7L,0L,0L,4L,9L,4L,2L,5L,7L,5L,3L,4L,2L,3L,0L,5L,10L,4L,1L,11L,12L,0L,2L,6L,7L,4L,0L,2L,12L,12L,0L,6L,15L,9L,2L,8L,7L,3L,7L,8L,10L,9L,5L,8L,21L,13L,0L,7L,19L,13L,0L,2L,10L,13L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281542Inst : IEnumerable<long>
{
public static readonly long[] Value=A281542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281542.Bytes);
public long this[int i]=>Value[i];

public static A281542Inst Instance=new A281542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281541
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,15L,19L,23L,27L,34L,41L,47L,53L,64L,75L,86L,96L,113L,129L,145L,159L,182L,206L,229L,252L,284L,318L,349L,380L,423L,468L,513L,555L,616L,676L,736L,791L,869L,949L,1026L,1103L,1202L,1310L,1408L,1506L,1631L,1766L,1896L,2020L,2185L,2354L,2525L,2680L,2882L,3094L,3305L,3506L,3751L,4023L,4281L,4537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281541Inst : IEnumerable<long>
{
public static readonly long[] Value=A281541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281541.Bytes);
public long this[int i]=>Value[i];

public static A281541Inst Instance=new A281541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281540
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,4L,4L,1L,2L,104L,290L,104L,2L,9L,612L,2919L,2919L,612L,9L,34L,3056L,14561L,15624L,14561L,3056L,34L,124L,16368L,63840L,52529L,52529L,63840L,16368L,124L,432L,82656L,245037L,146956L,130646L,146956L,245037L,82656L,432L,1464L,397040L,871492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281540Inst : IEnumerable<long>
{
public static readonly long[] Value=A281540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281540.Bytes);
public long this[int i]=>Value[i];

public static A281540Inst Instance=new A281540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281539
{
public static readonly long[] Value={ 34L,16368L,245037L,385284L,610493L,1066920L,1935368L,3474958L,6171868L,11158871L,20395467L,37090446L,66559412L,117785326L,205663182L,355907155L,612385903L,1050975150L,1799990677L,3077499241L,5246920963L,8917248681L,15096933611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281539Inst : IEnumerable<long>
{
public static readonly long[] Value=A281539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281539.Bytes);
public long this[int i]=>Value[i];

public static A281539Inst Instance=new A281539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281538
{
public static readonly long[] Value={ 9L,3056L,63840L,146956L,290073L,560972L,1066920L,2001002L,3797780L,7294930L,13957058L,26289482L,48689121L,88983896L,161189818L,290577490L,522149018L,935543592L,1669547078L,2965851310L,5243956096L,9233806648L,16204912228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281538Inst : IEnumerable<long>
{
public static readonly long[] Value=A281538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281538.Bytes);
public long this[int i]=>Value[i];

public static A281538Inst Instance=new A281538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281537
{
public static readonly long[] Value={ 2L,612L,14561L,52529L,130646L,290073L,610493L,1274531L,2667156L,5549073L,11333101L,22677459L,44625082L,86892393L,168012940L,322971613L,616923324L,1170830552L,2208492442L,4144258432L,7742439594L,14409433203L,26720926188L,49383541627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281537Inst : IEnumerable<long>
{
public static readonly long[] Value=A281537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281537.Bytes);
public long this[int i]=>Value[i];

public static A281537Inst Instance=new A281537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281536
{
public static readonly long[] Value={ 1L,104L,2919L,15624L,52529L,146956L,385284L,979866L,2440042L,5946178L,14218134L,33491002L,77932633L,179450414L,409349989L,926267006L,2081273523L,4647417316L,10319376525L,22798153410L,50137931781L,109808283414L,239585399751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281536Inst : IEnumerable<long>
{
public static readonly long[] Value=A281536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281536.Bytes);
public long this[int i]=>Value[i];

public static A281536Inst Instance=new A281536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281303
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,16L,20L,56L,58L,75L,109L,124L,217L,221L,368L,439L,595L,1309L,6986L,11600L,20855L,29327L,34305L,42145L,44056L,52667L,75707L,79067L,81848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281303Inst : IEnumerable<long>
{
public static readonly long[] Value=A281303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281303.Bytes);
public long this[int i]=>Value[i];

public static A281303Inst Instance=new A281303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281302
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281302Inst : IEnumerable<long>
{
public static readonly long[] Value=A281302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281302.Bytes);
public long this[int i]=>Value[i];

public static A281302Inst Instance=new A281302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281301
{
public static readonly BigInteger[] Value={ 1000004999700144385L,6834415079694144386L,13668830049399288772UL,BigInteger.Parse("41457129443403175403"),BigInteger.Parse("71914259877895350817"),BigInteger.Parse("143719619755790592734"),BigInteger.Parse("581014717313707510075"),BigInteger.Parse("1151030424627424920260"),BigInteger.Parse("1771324671891665221771"),BigInteger.Parse("3542550333873429453542"),BigInteger.Parse("5996099577656760005995") };
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
public class A281301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281301Inst Instance=new A281301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281300
{
public static readonly long[] Value={ 2L,5L,3L,3L,7L,1L,4L,5L,1L,11L,11L,9L,3L,6L,7L,14L,7L,4L,9L,13L,13L,6L,15L,2L,6L,27L,11L,19L,7L,9L,3L,8L,17L,22L,34L,27L,23L,11L,2L,11L,9L,25L,15L,38L,17L,9L,21L,4L,6L,24L,16L,14L,28L,4L,30L,29L,25L,1L,11L,14L,41L,38L,30L,44L,27L,13L,32L,15L,5L,6L,28L,39L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281300Inst : IEnumerable<long>
{
public static readonly long[] Value=A281300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281300.Bytes);
public long this[int i]=>Value[i];

public static A281300Inst Instance=new A281300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281299
{
public static readonly long[] Value={ 5011L,7001L,11251L,22501L,32303L,32411L,90031L,101107L,104123L,108011L,111323L,121343L,122131L,124001L,125101L,141023L,224011L,233021L,235003L,241141L,321203L,324011L,421303L,432031L,442201L,510331L,511213L,520411L,801011L,1000183L,1000541L,1001191L,1005223L,1006231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281299Inst : IEnumerable<long>
{
public static readonly long[] Value=A281299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281299.Bytes);
public long this[int i]=>Value[i];

public static A281299Inst Instance=new A281299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281298
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,3L,0L,8L,9L,2L,1L,8L,6L,4L,4L,9L,0L,0L,7L,9L,8L,0L,0L,0L,3L,1L,0L,5L,1L,8L,1L,5L,7L,8L,2L,4L,0L,4L,1L,8L,7L,4L,0L,3L,8L,1L,0L,6L,1L,3L,8L,3L,4L,9L,3L,3L,0L,1L,1L,9L,6L,8L,2L,1L,6L,5L,0L,8L,6L,8L,5L,0L,7L,1L,1L,2L,0L,3L,8L,3L,3L,3L,8L,2L,5L,3L,0L,4L,1L,0L,6L,3L,5L,3L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281298Inst : IEnumerable<long>
{
public static readonly long[] Value=A281298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281298.Bytes);
public long this[int i]=>Value[i];

public static A281298Inst Instance=new A281298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281297
{
public static readonly long[] Value={ 1L,0L,4L,0L,4L,10L,0L,4L,24L,20L,0L,4L,42L,84L,35L,0L,4L,64L,224L,224L,56L,0L,4L,90L,480L,840L,504L,84L,0L,4L,120L,900L,2400L,2520L,1008L,120L,0L,4L,154L,1540L,5775L,9240L,6468L,1848L,165L,0L,4L,192L,2464L,12320L,27720L,29568L,14784L,3168L,220L,0L,4L,234L,3744L,24024L,72072L,108108L,82368L,30888L,5148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281297Inst : IEnumerable<long>
{
public static readonly long[] Value=A281297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281297.Bytes);
public long this[int i]=>Value[i];

public static A281297Inst Instance=new A281297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281296
{
public static readonly long[] Value={ 0L,1L,2L,8L,9L,14L,15L,20L,32L,37L,123L,134L,135L,288L,361L,414L,469L,510L,6272L,11204L,11694L,16788L,20718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281296Inst : IEnumerable<long>
{
public static readonly long[] Value=A281296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281296.Bytes);
public long this[int i]=>Value[i];

public static A281296Inst Instance=new A281296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281295
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,167L,173L,179L,181L,191L,193L,197L,211L,223L,227L,229L,233L,239L,241L,251L,263L,271L,277L,281L,283L,293L,307L,313L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281295Inst : IEnumerable<long>
{
public static readonly long[] Value=A281295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281295.Bytes);
public long this[int i]=>Value[i];

public static A281295Inst Instance=new A281295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281294
{
public static readonly long[] Value={ 3280L,6160L,8320L,51520L,99904L,174640L,386320L,541840L,883120L,1690960L,2062480L,2365312L,2688880L,2959744L,3077680L,3152560L,3274240L,5375920L,6885760L,8925312L,10030720L,11219584L,11912080L,12058960L,14370160L,15854080L,18966640L,21839440L,22038160L,24787840L,26725360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281294Inst : IEnumerable<long>
{
public static readonly long[] Value=A281294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281294.Bytes);
public long this[int i]=>Value[i];

public static A281294Inst Instance=new A281294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281293
{
public static readonly long[] Value={ 1L,0L,3L,0L,3L,6L,0L,3L,15L,10L,0L,3L,27L,45L,15L,0L,3L,42L,126L,105L,21L,0L,3L,60L,280L,420L,210L,28L,0L,3L,81L,540L,1260L,1134L,378L,36L,0L,3L,105L,945L,3150L,4410L,2646L,630L,45L,0L,3L,132L,1540L,6930L,13860L,12936L,5544L,990L,55L,0L,3L,162L,2376L,13860L,37422L,49896L,33264L,10692L,1485L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281293Inst : IEnumerable<long>
{
public static readonly long[] Value=A281293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281293.Bytes);
public long this[int i]=>Value[i];

public static A281293Inst Instance=new A281293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281292
{
public static readonly long[] Value={ 1L,2L,5L,10L,13L,17L,26L,29L,34L,37L,41L,53L,58L,61L,73L,74L,82L,89L,97L,101L,106L,109L,113L,122L,137L,146L,149L,157L,173L,178L,181L,193L,194L,197L,202L,218L,226L,229L,233L,241L,257L,269L,274L,277L,281L,293L,298L,313L,314L,317L,337L,346L,349L,353L,362L,373L,386L,389L,394L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281292Inst : IEnumerable<long>
{
public static readonly long[] Value=A281292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281292.Bytes);
public long this[int i]=>Value[i];

public static A281292Inst Instance=new A281292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281291
{
public static readonly long[] Value={ 2L,4L,8L,16L,256L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281291Inst : IEnumerable<long>
{
public static readonly long[] Value=A281291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281291.Bytes);
public long this[int i]=>Value[i];

public static A281291Inst Instance=new A281291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281290
{
public static readonly long[] Value={ 37L,59L,73L,127L,149L,239L,271L,293L,307L,419L,491L,509L,941L,1049L,1061L,1117L,1171L,1193L,1229L,1319L,1409L,1601L,1913L,1931L,2017L,2039L,2129L,2309L,2903L,3119L,3191L,3209L,3911L,4019L,4091L,5009L,6011L,6101L,9041L,9203L,9221L,9311L,10061L,10139L,10193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281290Inst : IEnumerable<long>
{
public static readonly long[] Value=A281290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281290.Bytes);
public long this[int i]=>Value[i];

public static A281290Inst Instance=new A281290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281289
{
public static readonly long[] Value={ 2L,3L,9L,3L,5L,3L,9L,5L,4L,1L,7L,6L,2L,5L,6L,1L,0L,7L,1L,9L,6L,4L,9L,1L,3L,9L,2L,1L,4L,5L,2L,6L,4L,3L,7L,7L,8L,4L,5L,4L,1L,4L,5L,8L,8L,9L,0L,6L,2L,1L,9L,2L,4L,3L,5L,0L,9L,6L,7L,9L,8L,5L,4L,8L,4L,6L,1L,5L,4L,6L,1L,1L,5L,7L,9L,4L,4L,9L,4L,0L,4L,2L,6L,0L,7L,7L,5L,6L,9L,0L,4L,8L,7L,6L,4L,4L,0L,2L,2L,9L,3L,4L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281289Inst : IEnumerable<long>
{
public static readonly long[] Value=A281289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281289.Bytes);
public long this[int i]=>Value[i];

public static A281289Inst Instance=new A281289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281288
{
public static readonly long[] Value={ 1L,0L,6L,1L,16L,7L,96L,31L,256L,223L,1536L,319L,6144L,1151L,16640L,15359L,107264L,53503L,399360L,198655L,1110016L,1888255L,5382144L,77823L,21848064L,278527L,86089728L,1597439L,344358912L,32767L,1407909888L,65535L,5498208256L,33947647L,25507659776L,507510783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281288Inst : IEnumerable<long>
{
public static readonly long[] Value=A281288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281288.Bytes);
public long this[int i]=>Value[i];

public static A281288Inst Instance=new A281288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281239
{
public static readonly long[] Value={ 34L,38L,66L,102L,162L,358L,578L,934L,2082L,3366L,5442L,12134L,19618L,31718L,70722L,114342L,184866L,412198L,666434L,1077478L,2402466L,3884262L,6280002L,14002598L,22639138L,36602534L,81613122L,131950566L,213335202L,475676134L,769064258L,1243408678L,2772443682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281239Inst : IEnumerable<long>
{
public static readonly long[] Value=A281239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281239.Bytes);
public long this[int i]=>Value[i];

public static A281239Inst Instance=new A281239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281238
{
public static readonly long[] Value={ 0L,768L,4608L,26880L,156672L,913152L,5322240L,31020288L,180799488L,1053776640L,6141860352L,35797385472L,208642452480L,1216057329408L,7087701523968L,41310151814400L,240773209362432L,1403329104360192L,8179201416798720L,47671879396432128L,277852074961794048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281238Inst : IEnumerable<long>
{
public static readonly long[] Value=A281238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281238.Bytes);
public long this[int i]=>Value[i];

public static A281238Inst Instance=new A281238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281237
{
public static readonly long[] Value={ 32L,96L,544L,3168L,18464L,107616L,627232L,3655776L,21307424L,124188768L,723825184L,4218762336L,24588748832L,143313730656L,835293635104L,4868448079968L,28375394844704L,165383920988256L,963928131084832L,5618184865520736L,32745181062039584L,190852901506716768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281237Inst : IEnumerable<long>
{
public static readonly long[] Value=A281237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281237.Bytes);
public long this[int i]=>Value[i];

public static A281237Inst Instance=new A281237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281236
{
public static readonly long[] Value={ 0L,288L,960L,1632L,2688L,6048L,9792L,15840L,35328L,57120L,92352L,205920L,332928L,538272L,1200192L,1940448L,3137280L,6995232L,11309760L,18285408L,40771200L,65918112L,106575168L,237631968L,384198912L,621165600L,1385020608L,2239275360L,3620418432L,8072491680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281236Inst : IEnumerable<long>
{
public static readonly long[] Value=A281236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281236.Bytes);
public long this[int i]=>Value[i];

public static A281236Inst Instance=new A281236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281235
{
public static readonly long[] Value={ 68L,76L,132L,204L,324L,716L,1156L,1868L,4164L,6732L,10884L,24268L,39236L,63436L,141444L,228684L,369732L,824396L,1332868L,2154956L,4804932L,7768524L,12560004L,28005196L,45278276L,73205068L,163226244L,263901132L,426670404L,951352268L,1538128516L,2486817356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281235Inst : IEnumerable<long>
{
public static readonly long[] Value=A281235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281235.Bytes);
public long this[int i]=>Value[i];

public static A281235Inst Instance=new A281235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281234
{
public static readonly long[] Value={ 0L,48L,288L,1680L,9792L,57072L,332640L,1938768L,11299968L,65861040L,383866272L,2237336592L,13040153280L,76003583088L,442981345248L,2581884488400L,15048325585152L,87708069022512L,511200088549920L,2979492462277008L,17365754685112128L,101215035648395760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281234Inst : IEnumerable<long>
{
public static readonly long[] Value=A281234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281234.Bytes);
public long this[int i]=>Value[i];

public static A281234Inst Instance=new A281234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281233
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,18L,35L,52L,168L,335L,502L,1668L,3335L,5002L,14287L,16668L,33335L,50002L,166668L,333335L,500002L,1666668L,3333335L,5000002L,16666668L,33333335L,50000002L,166666668L,333333335L,500000002L,1666666668L,3333333335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281233Inst : IEnumerable<long>
{
public static readonly long[] Value=A281233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281233.Bytes);
public long this[int i]=>Value[i];

public static A281233Inst Instance=new A281233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281232
{
public static readonly long[] Value={ 1L,5L,65L,665L,6665L,66665L,666665L,2857141L,6666665L,66666665L,666666665L,1052631577L,6666666665L,66666666665L,666666666665L,2857142857141L,6666666666665L,11764705882351L,66666666666665L,666666666666665L,6666666666666665L,66666666666666665L,666666666666666665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281232Inst : IEnumerable<long>
{
public static readonly long[] Value=A281232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281232.Bytes);
public long this[int i]=>Value[i];

public static A281232Inst Instance=new A281232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281231
{
public static readonly BigInteger[] Value={ 1L,1L,5L,23L,133L,916L,7107L,61286L,580505L,5968400L,66032901L,780962524L,9817927385L,130572957724L,1829676460991L,26919714974436L,414591408939313L,6665930432840304L,111624874150941193L,1942675652654112012L,BigInteger.Parse("35071252458352443001"),BigInteger.Parse("655641049733709757516") };
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
public class A281231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281231Inst Instance=new A281231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281230
{
public static readonly long[] Value={ 1L,3L,4L,3L,10L,12L,8L,6L,12L,30L,5L,12L,14L,24L,20L,12L,18L,12L,9L,30L,8L,15L,24L,12L,50L,42L,36L,24L,7L,60L,15L,24L,20L,18L,40L,12L,38L,9L,28L,30L,20L,24L,44L,15L,60L,24L,16L,12L,56L,150L,36L,42L,54L,36L,10L,24L,36L,21L,29L,60L,30L,15L,24L,48L,70L,60L,68L,18L,24L,120L,35L,12L,74L,114L,100L,9L,40L,84L,39L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281230Inst : IEnumerable<long>
{
public static readonly long[] Value=A281230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281230.Bytes);
public long this[int i]=>Value[i];

public static A281230Inst Instance=new A281230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281229
{
public static readonly long[] Value={ 1L,2L,5L,10L,13L,26L,29L,34L,41L,58L,61L,74L,89L,106L,113L,146L,149L,194L,181L,202L,233L,274L,269L,386L,313L,346L,389L,394L,421L,458L,521L,514L,557L,586L,613L,698L,709L,794L,761L,802L,853L,914L,929L,1018L,1013L,1186L,1109L,1154L,1201L,1282L,1301L,1354L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281229Inst : IEnumerable<long>
{
public static readonly long[] Value=A281229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281229.Bytes);
public long this[int i]=>Value[i];

public static A281229Inst Instance=new A281229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281228
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,2L,2L,0L,0L,1L,0L,0L,0L,0L,2L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281228Inst : IEnumerable<long>
{
public static readonly long[] Value=A281228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281228.Bytes);
public long this[int i]=>Value[i];

public static A281228Inst Instance=new A281228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281227
{
public static readonly long[] Value={ 2L,53L,233L,281L,397L,521L,613L,673L,733L,773L,797L,829L,1049L,1129L,1433L,1553L,1697L,1933L,2129L,2237L,2273L,2281L,2437L,2521L,2557L,2617L,2729L,2969L,3121L,3181L,3413L,3457L,3517L,3637L,3709L,3761L,3881L,4337L,4357L,4729L,4733L,4877L,4889L,5101L,5657L,5813L,5857L,6113L,6133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281227Inst : IEnumerable<long>
{
public static readonly long[] Value=A281227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281227.Bytes);
public long this[int i]=>Value[i];

public static A281227Inst Instance=new A281227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281226
{
public static readonly long[] Value={ 23L,43L,67L,89L,113L,131L,157L,179L,197L,241L,263L,269L,311L,337L,359L,373L,421L,449L,461L,571L,593L,607L,641L,719L,733L,751L,809L,953L,971L,1013L,1031L,1097L,1103L,1163L,1237L,1259L,1301L,1327L,1361L,1439L,1471L,1493L,1613L,1619L,1709L,1723L,1741L,1907L,2003L,2063L,2069L,2137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281226Inst : IEnumerable<long>
{
public static readonly long[] Value=A281226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281226.Bytes);
public long this[int i]=>Value[i];

public static A281226Inst Instance=new A281226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281225
{
public static readonly long[] Value={ 1L,8L,9L,20L,21L,22L,23L,192L,193L,194L,195L,196L,197L,198L,199L,400L,401L,402L,403L,404L,405L,406L,407L,408L,409L,410L,411L,412L,413L,414L,415L,832L,833L,834L,835L,836L,837L,838L,839L,840L,841L,842L,843L,844L,845L,846L,847L,848L,849L,850L,851L,852L,853L,854L,855L,856L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281225Inst : IEnumerable<long>
{
public static readonly long[] Value=A281225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281225.Bytes);
public long this[int i]=>Value[i];

public static A281225Inst Instance=new A281225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281224
{
public static readonly long[] Value={ 9L,12L,103L,144L,150L,172L,249L,495L,505L,577L,729L,738L,904L,1010L,1210L,1544L,1852L,1988L,2304L,2316L,3097L,3753L,4184L,5262L,5625L,5640L,6081L,6756L,8657L,8703L,9791L,9953L,11664L,11682L,12884L,14258L,16849L,18649L,21279L,21609L,21630L,24987L,29737L,31615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281224Inst : IEnumerable<long>
{
public static readonly long[] Value=A281224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281224.Bytes);
public long this[int i]=>Value[i];

public static A281224Inst Instance=new A281224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281045
{
public static readonly long[] Value={ 1L,1L,3L,8L,3L,56L,3L,248L,11L,1004L,57L,3969L,61L,16283L,28L,65485L,15L,262124L,29L,1048519L,16L,4194263L,184L,16776931L,392L,67107883L,6588L,268425413L,31255L,1073684188L,18865L,4294920293L,51975L,17179741296L,60679L,68719370096L,158935L,274877517880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281045Inst : IEnumerable<long>
{
public static readonly long[] Value=A281045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281045.Bytes);
public long this[int i]=>Value[i];

public static A281045Inst Instance=new A281045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281044
{
public static readonly ulong[] Value={ 1L,10L,110L,1L,11000L,111L,1100000L,11111L,110100000L,11011111L,10011100000L,100000011111L,1011110000000L,11011001111111L,1110000000000L,1011001111111111L,11110000000000000L,1101111111111111L,1011100000000000000L,11100011111111111111UL,10000000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281044Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281044.Bytes);
public ulong this[int i]=>Value[i];

public static A281044Inst Instance=new A281044Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281043
{
public static readonly BigInteger[] Value={ 1L,1L,11L,1000L,11L,111000L,11L,11111000L,1011L,1111101100L,111001L,111110000001L,111101L,11111110011011L,11100L,1111111111001101L,1111L,111111111111101100L,11101L,11111111111111000111UL,10000L,BigInteger.Parse("1111111111111111010111"),10111000L,BigInteger.Parse("111111111111111011100011") };
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
public class A281043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281043Inst Instance=new A281043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281042
{
public static readonly long[] Value={ 1L,0L,4L,3L,20L,19L,64L,63L,368L,495L,1952L,735L,5696L,6207L,26368L,3327L,116992L,767L,520704L,229887L,1210368L,47103L,8230912L,1521663L,28446720L,15052799L,72146944L,42491903L,307675136L,5488639L,2128707584L,1050181631L,4681236480L,2598502399L,17617649664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281042Inst : IEnumerable<long>
{
public static readonly long[] Value=A281042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281042.Bytes);
public long this[int i]=>Value[i];

public static A281042Inst Instance=new A281042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281041
{
public static readonly long[] Value={ 1L,0L,1L,12L,5L,50L,1L,252L,29L,990L,47L,4020L,77L,16134L,115L,65328L,295L,261376L,639L,1046556L,969L,4193088L,3295L,16772328L,4251L,67098268L,14737L,268411156L,27977L,1073705600L,50111L,4294842748L,49617L,17179745636L,49857L,68719368540L,156069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281041Inst : IEnumerable<long>
{
public static readonly long[] Value=A281041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281041.Bytes);
public long this[int i]=>Value[i];

public static A281041Inst Instance=new A281041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281040
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10100L,10011L,1000000L,111111L,101110000L,111101111L,11110100000L,1011011111L,1011001000000L,1100000111111L,110011100000000L,110011111111L,11100100100000000L,1011111111L,1111111001000000000L,111000000111111111L,BigInteger.Parse("100100111100000000000") };
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
public class A281040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281040Inst Instance=new A281040Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281039
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,101L,110010L,1L,11111100L,11101L,1111011110L,101111L,111110110100L,1001101L,11111100000110L,1110011L,1111111100110000L,100100111L,111111110100000000L,1001111111L,11111111100000011100UL,1111001001L,BigInteger.Parse("1111111111101101000000"),110011011111L };
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
public class A281039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281039Inst Instance=new A281039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281038
{
public static readonly long[] Value={ 1L,3L,1L,3L,1L,27L,73L,187L,425L,243L,153L,1803L,4505L,13507L,6153L,1243L,38985L,216723L,101177L,39051L,721817L,3756099L,2879625L,16500059L,15228873L,37281299L,109331129L,62705547L,10641561L,432800579L,1292118409L,3350164571L,283187913L,849530387L,4696974009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281038Inst : IEnumerable<long>
{
public static readonly long[] Value=A281038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281038.Bytes);
public long this[int i]=>Value[i];

public static A281038Inst Instance=new A281038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281037
{
public static readonly long[] Value={ 1L,3L,4L,12L,16L,54L,73L,221L,299L,828L,1224L,3342L,4913L,12491L,18444L,56096L,74802L,206283L,321164L,856464L,1259546L,3179175L,4753386L,14328799L,19395630L,52554865L,82448651L,220148700L,320915616L,816844006L,1221202009L,3660510691L,4944104976L,13451990320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281037Inst : IEnumerable<long>
{
public static readonly long[] Value=A281037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281037.Bytes);
public long this[int i]=>Value[i];

public static A281037Inst Instance=new A281037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281036
{
public static readonly ulong[] Value={ 1L,11L,1L,11L,1L,11011L,1001001L,10111011L,110101001L,11110011L,10011001L,11100001011L,1000110011001L,11010011000011L,1100000001001L,10011011011L,1001100001001001L,110100111010010011L,11000101100111001L,1001100010001011L,10110000001110011001UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281036Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281036.Bytes);
public ulong this[int i]=>Value[i];

public static A281036Inst Instance=new A281036Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281035
{
public static readonly ulong[] Value={ 1L,11L,100L,1100L,10000L,110110L,1001001L,11011101L,100101011L,1100111100L,10011001000L,110100001110L,1001100110001L,11000011001011L,100100000001100L,1101101100100000L,10010010000110010L,110010010111001011L,1001110011010001100L,11010001000110010000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281035Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281035.Bytes);
public ulong this[int i]=>Value[i];

public static A281035Inst Instance=new A281035Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281034
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,12L,96L,12L,0L,0L,58L,532L,532L,58L,0L,0L,252L,2321L,2324L,2321L,252L,0L,0L,1048L,8886L,9854L,9854L,8886L,1048L,0L,0L,4204L,31700L,38972L,44395L,38972L,31700L,4204L,0L,0L,16454L,108034L,146606L,184290L,184290L,146606L,108034L,16454L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281034Inst : IEnumerable<long>
{
public static readonly long[] Value=A281034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281034.Bytes);
public long this[int i]=>Value[i];

public static A281034Inst Instance=new A281034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281033
{
public static readonly long[] Value={ 0L,1048L,31700L,146606L,722952L,3042556L,12164474L,46511454L,172759149L,628675456L,2254017339L,7988988368L,28056053572L,97767659494L,338498139062L,1165614974008L,3995250761421L,13639469138120L,46401641163562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281033Inst : IEnumerable<long>
{
public static readonly long[] Value=A281033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281033.Bytes);
public long this[int i]=>Value[i];

public static A281033Inst Instance=new A281033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281032
{
public static readonly long[] Value={ 0L,252L,8886L,38972L,184290L,770788L,3042556L,11471132L,41949794L,150344672L,531019564L,1853716800L,6408859134L,21978465412L,74865327034L,253567733120L,854665596576L,2868578317992L,9592422240950L,31971551621052L,106249551692574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281032Inst : IEnumerable<long>
{
public static readonly long[] Value=A281032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281032.Bytes);
public long this[int i]=>Value[i];

public static A281032Inst Instance=new A281032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281031
{
public static readonly long[] Value={ 0L,58L,2321L,9854L,44395L,184290L,722952L,2696692L,9734320L,34378916L,119479572L,409793340L,1390770988L,4679313804L,15630279254L,51891762034L,171376744116L,563406924184L,1844814347903L,6019287405002L,19577996105250L,63498640476100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281031Inst : IEnumerable<long>
{
public static readonly long[] Value=A281031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281031.Bytes);
public long this[int i]=>Value[i];

public static A281031Inst Instance=new A281031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281030
{
public static readonly long[] Value={ 0L,12L,532L,2324L,9854L,38972L,146606L,533340L,1896352L,6625144L,22832024L,77840640L,263040538L,882310796L,2941006434L,9750587480L,32176182992L,105744971236L,346270006718L,1130247359072L,3678591411860L,11941616925216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281030Inst : IEnumerable<long>
{
public static readonly long[] Value=A281030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281030.Bytes);
public long this[int i]=>Value[i];

public static A281030Inst Instance=new A281030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280997
{
public static readonly long[] Value={ 13L,37L,41L,67L,97L,131L,193L,577L,1033L,1153L,2053L,4129L,8209L,18433L,32771L,32801L,32833L,65539L,133121L,525313L,557057L,1049089L,4194433L,167772161L,268435459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280997Inst : IEnumerable<long>
{
public static readonly long[] Value=A280997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280997.Bytes);
public long this[int i]=>Value[i];

public static A280997Inst Instance=new A280997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280996
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,23L,31L,53L,59L,67L,83L,97L,103L,127L,131L,227L,241L,277L,311L,331L,419L,431L,509L,563L,661L,691L,709L,719L,739L,1433L,1523L,1543L,1619L,1787L,1879L,2063L,2221L,2309L,2437L,2897L,3001L,3637L,3671L,3803L,4091L,4637L,4943L,5189L,5381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280996Inst : IEnumerable<long>
{
public static readonly long[] Value=A280996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280996.Bytes);
public long this[int i]=>Value[i];

public static A280996Inst Instance=new A280996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280995
{
public static readonly long[] Value={ 0L,1L,3L,1L,3L,7L,5L,1L,3L,11L,15L,7L,5L,13L,9L,1L,3L,19L,27L,11L,15L,31L,23L,7L,5L,21L,29L,13L,9L,25L,17L,1L,3L,35L,51L,19L,27L,59L,43L,11L,15L,47L,63L,31L,23L,55L,39L,7L,5L,37L,53L,21L,29L,61L,45L,13L,9L,41L,57L,25L,17L,49L,33L,1L,3L,67L,99L,35L,51L,115L,83L,19L,27L,91L,123L,59L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280995Inst : IEnumerable<long>
{
public static readonly long[] Value=A280995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280995.Bytes);
public long this[int i]=>Value[i];

public static A280995Inst Instance=new A280995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280994
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,16L,17L,19L,23L,31L,32L,53L,59L,67L,25L,27L,49L,64L,83L,127L,131L,241L,277L,331L,97L,103L,128L,227L,311L,431L,709L,739L,1523L,1787L,2221L,81L,121L,256L,289L,361L,509L,563L,719L,1433L,2063L,3001L,5381L,5623L,12763L,15299L,19577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280994Inst : IEnumerable<long>
{
public static readonly long[] Value=A280994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280994.Bytes);
public long this[int i]=>Value[i];

public static A280994Inst Instance=new A280994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280993
{
public static readonly long[] Value={ 11L,19L,23L,43L,67L,89L,101L,109L,113L,131L,157L,167L,179L,197L,199L,211L,223L,241L,257L,263L,269L,311L,313L,331L,337L,347L,353L,359L,373L,379L,397L,421L,431L,449L,461L,463L,523L,541L,571L,593L,607L,617L,641L,643L,661L,683L,719L,733L,739L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280993Inst : IEnumerable<long>
{
public static readonly long[] Value=A280993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280993.Bytes);
public long this[int i]=>Value[i];

public static A280993Inst Instance=new A280993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280991
{
public static readonly long[] Value={ 3L,4L,7L,12L,15L,19L,27L,28L,31L,36L,39L,43L,51L,52L,55L,60L,63L,67L,75L,76L,79L,84L,87L,91L,99L,103L,108L,111L,115L,123L,124L,127L,132L,135L,139L,147L,148L,151L,156L,159L,163L,171L,172L,175L,180L,183L,187L,195L,196L,199L,204L,207L,211L,219L,220L,223L,228L,231L,235L,243L,244L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280991Inst : IEnumerable<long>
{
public static readonly long[] Value=A280991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280991.Bytes);
public long this[int i]=>Value[i];

public static A280991Inst Instance=new A280991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280990
{
public static readonly long[] Value={ 2L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,3L,13L,7L,31L,2L,17L,3L,19L,5L,7L,11L,23L,3L,5L,13L,3L,7L,29L,31L,31L,2L,67L,17L,71L,3L,37L,19L,13L,5L,41L,7L,43L,11L,31L,23L,47L,3L,7L,5L,103L,13L,53L,3L,11L,7L,19L,29L,59L,31L,61L,31L,7L,2L,131L,67L,67L,17L,139L,71L,71L,3L,73L,37L,31L,19L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280990Inst : IEnumerable<long>
{
public static readonly long[] Value=A280990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280990.Bytes);
public long this[int i]=>Value[i];

public static A280990Inst Instance=new A280990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280989
{
public static readonly long[] Value={ 0L,16L,28L,37L,44L,50L,55L,59L,62L,65L,68L,70L,72L,74L,76L,77L,78L,80L,81L,82L,83L,83L,84L,85L,86L,86L,87L,88L,88L,89L,89L,90L,90L,90L,91L,91L,91L,92L,92L,92L,93L,93L,93L,93L,94L,94L,94L,94L,95L,95L,95L,95L,95L,96L,96L,96L,96L,96L,96L,96L,97L,97L,97L,97L,97L,97L,97L,97L,98L,98L,98L,98L,98L,98L,98L,98L,98L,98L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,100L,100L,100L,100L,100L,100L,100L,100L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280989Inst : IEnumerable<long>
{
public static readonly long[] Value=A280989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280989.Bytes);
public long this[int i]=>Value[i];

public static A280989Inst Instance=new A280989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280988
{
public static readonly long[] Value={ 1L,1L,4L,2L,1L,2L,9L,1L,7L,1L,41L,1L,21L,9L,4L,2L,1L,6L,3L,2L,3L,41L,89L,2L,5L,14L,4L,13L,113L,2L,143L,1L,25L,1L,9L,3L,1L,2L,7L,1L,11L,3L,49L,25L,7L,89L,1151L,1L,43L,5L,4L,7L,553L,2L,15L,9L,1L,113L,233L,1L,77L,122L,1L,2L,21L,25L,299L,2L,356L,9L,281L,6L,3L,1L,11L,1L,61L,6L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280988Inst : IEnumerable<long>
{
public static readonly long[] Value=A280988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280988.Bytes);
public long this[int i]=>Value[i];

public static A280988Inst Instance=new A280988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280987
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,9L,1L,6L,4L,1L,9L,21L,1L,9L,9L,16L,9L,24L,1L,33L,17L,1L,9L,21L,0L,9L,1L,41L,21L,33L,17L,6L,33L,19L,33L,25L,25L,21L,1L,1L,33L,81L,17L,21L,45L,1L,33L,85L,49L,69L,57L,77L,27L,81L,1L,81L,1L,1L,21L,57L,59L,81L,33L,60L,21L,33L,45L,51L,81L,1L,9L,66L,41L,9L,97L,1L,81L,81L,1L,57L,117L,73L,33L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280987Inst : IEnumerable<long>
{
public static readonly long[] Value=A280987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280987.Bytes);
public long this[int i]=>Value[i];

public static A280987Inst Instance=new A280987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280986
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,4L,1L,6L,1L,2L,2L,8L,1L,2L,1L,2L,1L,4L,1L,4L,1L,2L,2L,2L,1L,2L,3L,4L,1L,6L,1L,10L,1L,2L,4L,2L,1L,4L,1L,4L,1L,8L,1L,2L,1L,2L,2L,4L,1L,12L,2L,2L,1L,2L,1L,2L,1L,4L,1L,4L,1L,2L,1L,2L,3L,4L,2L,6L,1L,2L,3L,8L,1L,2L,5L,2L,1L,6L,1L,4L,2L,2L,1L,4L,1L,8L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280986Inst : IEnumerable<long>
{
public static readonly long[] Value=A280986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280986.Bytes);
public long this[int i]=>Value[i];

public static A280986Inst Instance=new A280986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280985
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,10L,7L,14L,8L,9L,12L,11L,22L,13L,26L,15L,18L,16L,17L,34L,19L,38L,20L,21L,24L,23L,46L,25L,30L,27L,28L,32L,29L,58L,31L,62L,33L,36L,35L,40L,37L,74L,39L,42L,41L,82L,43L,86L,44L,45L,48L,47L,94L,49L,56L,50L,51L,54L,52L,53L,106L,55L,60L,57L,59L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280985Inst : IEnumerable<long>
{
public static readonly long[] Value=A280985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280985.Bytes);
public long this[int i]=>Value[i];

public static A280985Inst Instance=new A280985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280984
{
public static readonly long[] Value={ 0L,2L,3L,6L,9L,12L,17L,22L,27L,34L,41L,48L,57L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280984Inst : IEnumerable<long>
{
public static readonly long[] Value=A280984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280984.Bytes);
public long this[int i]=>Value[i];

public static A280984Inst Instance=new A280984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280983
{
public static readonly long[] Value={ 11824560L,14283650L,14283666L,14283672L,14422716L,14872610L,14872612L,14881986L,14917048L,22453380L,29875904L,29877516L,29878760L,29878776L,29878782L,29878812L,29879052L,29880432L,31852820L,31852822L,31888098L,31894108L,31894110L,31894130L,32255514L,32527482L,32557320L,32565868L,32565888L,32565890L,32566068L,32568748L,32568822L,32569040L,33082200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280983Inst : IEnumerable<long>
{
public static readonly long[] Value=A280983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280983.Bytes);
public long this[int i]=>Value[i];

public static A280983Inst Instance=new A280983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280982
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,54L,486L,9720L,204120L,6531840L,241678080L,13050616320L,652530816000L,50244872832000L,4069834699392000L,390704131141632000L,BigInteger.Parse("41023933769871360000"),BigInteger.Parse("5538231058932633600000"),BigInteger.Parse("731046499779107635200000"),BigInteger.Parse("124277904962448297984000000") };
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
public class A280982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280982Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280982.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280982Inst Instance=new A280982Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280981
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,6L,30L,120L,720L,4320L,38880L,233280L,2566080L,25660800L,282268800L,3104956800L,46574352000L,558892224000L,9501167808000L,133016349312000L,2261277938304000L,40703002889472000L,854763060678912000L,13676208970862592000UL,BigInteger.Parse("300876597358977024000") };
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
public class A280981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280981Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280981.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280981Inst Instance=new A280981Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280580
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,1L,5L,30L,15L,1L,14L,140L,140L,28L,1L,42L,630L,1050L,420L,45L,1L,132L,2772L,6930L,4620L,990L,66L,1L,429L,12012L,42042L,42042L,15015L,2002L,91L,1L,1430L,51480L,240240L,336336L,180180L,40040L,3640L,120L,1L,4862L,218790L,1312740L,2450448L,1837836L,612612L,92820L,6120L,153L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280580Inst : IEnumerable<long>
{
public static readonly long[] Value=A280580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280580.Bytes);
public long this[int i]=>Value[i];

public static A280580Inst Instance=new A280580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280579
{
public static readonly long[] Value={ 0L,0L,4L,0L,-3L,1L,0L,11L,8L,12L,0L,-8L,3L,0L,4L,0L,24L,16L,27L,24L,28L,0L,-19L,5L,-3L,8L,5L,9L,0L,43L,24L,48L,40L,51L,48L,52L,0L,-36L,7L,-12L,12L,4L,15L,12L,16L,0L,68L,32L,75L,56L,80L,72L,83L,80L,84L,0L,-59L,9L,-27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280579Inst : IEnumerable<long>
{
public static readonly long[] Value=A280579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280579.Bytes);
public long this[int i]=>Value[i];

public static A280579Inst Instance=new A280579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280578
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,15L,16L,21L,22L,23L,30L,32L,33L,36L,45L,46L,64L,128L,255L,256L,413L,498L,512L,513L,514L,553L,554L,580L,612L,744L,765L,766L,1024L,1073L,1125L,1162L,1250L,1540L,1544L,2048L,2241L,2413L,2457L,2458L,2522L,2524L,2596L,2754L,2889L,3348L,3352L,3474L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280578Inst : IEnumerable<long>
{
public static readonly long[] Value=A280578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280578.Bytes);
public long this[int i]=>Value[i];

public static A280578Inst Instance=new A280578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280577
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,9L,8L,10L,9L,15L,10L,18L,13L,15L,16L,24L,15L,27L,18L,22L,21L,33L,20L,32L,25L,31L,26L,42L,23L,45L,32L,36L,33L,41L,30L,54L,37L,43L,36L,60L,33L,63L,42L,46L,45L,69L,40L,66L,45L,57L,50L,78L,45L,67L,52L,64L,57L,87L,46L,90L,61L,67L,64L,80L,53L,99L,66L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280577Inst : IEnumerable<long>
{
public static readonly long[] Value=A280577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280577.Bytes);
public long this[int i]=>Value[i];

public static A280577Inst Instance=new A280577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280576
{
public static readonly long[] Value={ 23L,79L,3137L,3739L,4751L,6163L,8387L,8389L,109111L,113117L,113123L,151153L,151157L,157163L,167173L,173177L,181183L,199207L,199211L,211213L,211217L,211219L,233239L,241249L,251257L,257263L,263267L,263269L,271273L,271277L,277279L,283289L,317321L,317323L,317327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280576Inst : IEnumerable<long>
{
public static readonly long[] Value=A280576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280576.Bytes);
public long this[int i]=>Value[i];

public static A280576Inst Instance=new A280576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280575
{
public static readonly BigInteger[] Value={ 1L,5L,85L,2625L,119225L,7209725L,547774525L,50342086425L,5448583486625L,680816992367125L,96720369562897125L,15433474653279056625UL,BigInteger.Parse("2738894920523846767625"),BigInteger.Parse("536165521694896664958125"),BigInteger.Parse("114986014404299081313978125"),BigInteger.Parse("26857525461337375682549015625"),BigInteger.Parse("6797751676147997291181732240625"),BigInteger.Parse("1856223312322488721077123869053125"),BigInteger.Parse("544728880837527263669006279810003125"),BigInteger.Parse("171209466763535665605709125529165390625") };
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
public class A280575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280575Inst Instance=new A280575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280574
{
public static readonly BigInteger[] Value={ 1L,5L,70L,1775L,66175L,3283475L,204594175L,15411893450L,1366394303500L,139767921720875L,16243630181913625L,2118892887756520250L,BigInteger.Parse("307173379745256857875"),BigInteger.Parse("49084564051462443496250"),BigInteger.Parse("8586127214178418541668750"),BigInteger.Parse("1634509914502001105016284375"),BigInteger.Parse("336910750825106071274158853125"),BigInteger.Parse("74862327518834451026921878887500"),BigInteger.Parse("17862833297180486514281227128971875"),BigInteger.Parse("4561279298680105599840369905594562500") };
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
public class A280574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280574Inst Instance=new A280574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280573
{
public static readonly BigInteger[] Value={ 1L,5L,55L,1075L,30825L,1174725L,56153575L,3241453075L,219981653625L,17205716877125L,1527315775776375L,152004555650445875L,16793815038459239625UL,BigInteger.Parse("2042866310966722613125"),BigInteger.Parse("271723598687954810434375"),BigInteger.Parse("39287423162026628955721875"),BigInteger.Parse("6143464129092882413626065625"),BigInteger.Parse("1034396495380447234136660853125"),BigInteger.Parse("186805274512176503194633726284375"),BigInteger.Parse("36060209533917578045193572845421875") };
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
public class A280573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280573Inst Instance=new A280573Inst();

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