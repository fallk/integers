using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A111041
{
public static readonly long[] Value={ 3L,6L,12L,18L,21L,27L,33L,36L,39L,51L,54L,63L,66L,69L,81L,96L,114L,138L,159L,168L,177L,183L,204L,216L,219L,228L,231L,234L,237L,252L,258L,276L,279L,282L,312L,324L,369L,381L,393L,402L,411L,423L,426L,429L,432L,447L,462L,483L,492L,507L,516L,531L,546L,561L,564L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111041Inst : IEnumerable<long>
{
public static readonly long[] Value=A111041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111041.Bytes);
public long this[int i]=>Value[i];

public static A111041Inst Instance=new A111041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111042
{
public static readonly long[] Value={ 903L,2545L,4533L,5067L,8759L,9071L,9269L,10353L,11035L,11625L,11865L,13629L,15395L,15493L,16803L,17955L,18575L,18637L,19149L,24189L,35547L,36941L,37911L,42111L,43613L,45179L,50717L,52383L,53367L,54159L,58285L,59903L,61333L,62373L,65109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111042Inst : IEnumerable<long>
{
public static readonly long[] Value=A111042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111042.Bytes);
public long this[int i]=>Value[i];

public static A111042Inst Instance=new A111042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111043
{
public static readonly long[] Value={ 1L,37L,38L,102L,102L,111L,120L,201L,265L,329L,378L,394L,475L,539L,620L,636L,700L,716L,780L,784L,784L,800L,825L,889L,925L,989L,998L,1014L,1023L,1059L,1084L,1120L,1129L,1193L,1194L,1195L,1244L,1293L,1297L,1297L,1306L,1306L,1387L,1388L,1437L,1518L,1582L,1582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111043Inst : IEnumerable<long>
{
public static readonly long[] Value=A111043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111043.Bytes);
public long this[int i]=>Value[i];

public static A111043Inst Instance=new A111043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111044
{
public static readonly long[] Value={ 147441L,910805L,1026745L,2403800L,2513434L,3198550L,11739805L,15053585L,18646301L,33313175L,93812510L,102939515L,134910295L,136448235L,151443110L,163998695L,195435485L,197780465L,213872920L,267043455L,461498779L,482204660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111044Inst : IEnumerable<long>
{
public static readonly long[] Value=A111044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111044.Bytes);
public long this[int i]=>Value[i];

public static A111044Inst Instance=new A111044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111045
{
public static readonly long[] Value={ 1L,9L,33L,42L,47L,53L,54L,110L,324L,534L,627L,642L,683L,728L,792L,1114L,2112L,2228L,2323L,2770L,3007L,3255L,3368L,3760L,4062L,4569L,6139L,7650L,7939L,8138L,8310L,8493L,8674L,9122L,9407L,10345L,11127L,13343L,14713L,15442L,15632L,16358L,16904L,18165L,19303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111045Inst : IEnumerable<long>
{
public static readonly long[] Value=A111045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111045.Bytes);
public long this[int i]=>Value[i];

public static A111045Inst Instance=new A111045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111046
{
public static readonly long[] Value={ 16L,24L,48L,72L,120L,168L,240L,288L,408L,432L,552L,600L,720L,768L,792L,912L,960L,1080L,1128L,1248L,1392L,1680L,1728L,1848L,2088L,2280L,2400L,2472L,2568L,2640L,3240L,3288L,3312L,3432L,3528L,4080L,4128L,4200L,4248L,4368L,4608L,4920L,5112L,5160L,5208L,5280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111046Inst : IEnumerable<long>
{
public static readonly long[] Value=A111046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111046.Bytes);
public long this[int i]=>Value[i];

public static A111046Inst Instance=new A111046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111047
{
public static readonly long[] Value={ 1L,2L,5L,24L,48L,32L,100L,140L,840L,1872L,54000L,12960L,51840L,533871L,322371L,31104L,709632L,1921500L,4147200L,3701376L,124416L,262080L,2488320L,21811680L,403107840L,146966400L,2538086400L,1074954240L,14370048000L,415704960000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111047Inst : IEnumerable<long>
{
public static readonly long[] Value=A111047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111047.Bytes);
public long this[int i]=>Value[i];

public static A111047Inst Instance=new A111047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111048
{
public static readonly long[] Value={ 4L,3L,4L,3L,7L,5L,10L,6L,5L,16L,7L,11L,22L,12L,9L,10L,31L,12L,18L,37L,14L,21L,15L,13L,26L,52L,27L,55L,29L,10L,33L,23L,70L,15L,76L,27L,28L,42L,29L,30L,91L,20L,97L,50L,100L,18L,19L,57L,115L,59L,40L,121L,26L,43L,44L,45L,136L,47L,71L,142L,30L,22L,78L,157L,80L,24L,57L,35L,175L,89L,60L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111048Inst : IEnumerable<long>
{
public static readonly long[] Value=A111048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111048.Bytes);
public long this[int i]=>Value[i];

public static A111048Inst Instance=new A111048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111049
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,9L,4L,1L,11L,27L,25L,8L,1L,20L,70L,100L,65L,16L,1L,37L,170L,330L,325L,161L,32L,1L,70L,399L,980L,1295L,966L,385L,64L,1L,135L,917L,2723L,4515L,4501L,2635L,2695L,897L,128L,1L,264L,2076L,7224L,14406L,17976L,14364L,7176L,2049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111049Inst : IEnumerable<long>
{
public static readonly long[] Value=A111049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111049.Bytes);
public long this[int i]=>Value[i];

public static A111049Inst Instance=new A111049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111050
{
public static readonly BigInteger[] Value={ 8L,14L,44L,268L,72368L,10474616694L,BigInteger.Parse("548587974441592064876"),BigInteger.Parse("165096873787118432788111503546470822864506422983866575256543132") };
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
public class A111050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111050Inst Instance=new A111050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111051
{
public static readonly long[] Value={ 2L,6L,8L,12L,16L,20L,22L,26L,34L,36L,40L,58L,64L,68L,78L,82L,84L,86L,98L,112L,120L,126L,142L,146L,148L,152L,156L,160L,168L,188L,190L,194L,196L,208L,216L,218L,222L,238L,240L,244L,246L,254L,264L,272L,282L,286L,294L,300L,302L,306L,308L,316L,320L,330L,338L,344L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111051Inst : IEnumerable<long>
{
public static readonly long[] Value=A111051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111051.Bytes);
public long this[int i]=>Value[i];

public static A111051Inst Instance=new A111051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111052
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,19L,21L,25L,31L,33L,37L,39L,45L,49L,53L,73L,75L,77L,81L,89L,91L,93L,107L,115L,119L,129L,131L,135L,137L,145L,157L,185L,187L,193L,203L,205L,207L,213L,215L,221L,227L,229L,231L,249L,259L,261L,263L,271L,283L,291L,297L,299L,301L,317L,325L,327L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111052Inst : IEnumerable<long>
{
public static readonly long[] Value=A111052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111052.Bytes);
public long this[int i]=>Value[i];

public static A111052Inst Instance=new A111052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111053
{
public static readonly long[] Value={ 1L,2L,6L,22L,89L,379L,1661L,7405L,33367L,151398L,690147L,3156112L,14465746L,66409493L,305232025L,1404129530L,6463476538L,29767212095L,137142651679L,632021380433L,2913316615372L,13431328632593L,61931182541194L,285592218851606L,1317104663887309L,6074682489939359L,28018852961838675L,129239701278757210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111053Inst : IEnumerable<long>
{
public static readonly long[] Value=A111053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111053.Bytes);
public long this[int i]=>Value[i];

public static A111053Inst Instance=new A111053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111054
{
public static readonly long[] Value={ 1L,17L,18L,34L,38L,39L,48L,73L,109L,113L,122L,171L,180L,180L,261L,286L,286L,302L,366L,430L,430L,431L,467L,531L,595L,644L,648L,664L,668L,668L,749L,785L,866L,930L,930L,979L,1043L,1068L,1104L,1185L,1221L,1270L,1271L,1335L,1384L,1409L,1418L,1467L,1503L,1584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111054Inst : IEnumerable<long>
{
public static readonly long[] Value=A111054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111054.Bytes);
public long this[int i]=>Value[i];

public static A111054Inst Instance=new A111054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111055
{
public static readonly long[] Value={ 5L,13L,17L,29L,37L,41L,61L,73L,89L,97L,101L,109L,149L,181L,233L,277L,281L,349L,409L,433L,449L,677L,701L,709L,769L,821L,877L,881L,1669L,2221L,3001L,3121L,3169L,3221L,3301L,3833L,4969L,4993L,6469L,6833L,6949L,7121L,7477L,7949L,9001L,9049L,9221L,9649L,9833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111055Inst : IEnumerable<long>
{
public static readonly long[] Value=A111055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111055.Bytes);
public long this[int i]=>Value[i];

public static A111055Inst Instance=new A111055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111056
{
public static readonly long[] Value={ 3L,7L,11L,19L,59L,251L,491L,499L,691L,991L,2099L,2699L,2999L,4051L,4451L,4651L,5051L,5651L,5851L,6299L,6451L,6551L,6899L,8291L,8699L,8951L,8999L,9551L,9851L,22091L,22291L,66851L,80051L,80651L,84551L,85451L,86851L,88651L,92899L,98299L,98899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111056Inst : IEnumerable<long>
{
public static readonly long[] Value=A111056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111056.Bytes);
public long this[int i]=>Value[i];

public static A111056Inst Instance=new A111056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111057
{
public static readonly long[] Value={ 5L,13L,37L,73L,97L,109L,313L,337L,373L,409L,421L,577L,601L,661L,709L,1009L,1033L,1093L,1129L,1489L,1609L,1669L,3457L,7537L,12721L,13729L,17401L,17569L,19009L,19141L,20593L,20641L,165877L,208501L,221173L,225781L,226201L,226357L,228793L,246817L,246937L,248821L,1097113L,2695813L,2735269L,2736997L,2737129L,32555521L,388177921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111057Inst : IEnumerable<long>
{
public static readonly long[] Value=A111057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111057.Bytes);
public long this[int i]=>Value[i];

public static A111057Inst Instance=new A111057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111058
{
public static readonly long[] Value={ 1L,2L,8L,12L,20L,24L,48L,60L,68L,72L,92L,96L,120L,140L,144L,188L,192L,200L,212L,216L,240L,288L,300L,332L,336L,360L,384L,428L,432L,440L,452L,480L,500L,548L,576L,600L,648L,660L,668L,672L,680L,692L,696L,720L,768L,780L,788L,812L,864L,908L,932L,960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111058Inst : IEnumerable<long>
{
public static readonly long[] Value=A111058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111058.Bytes);
public long this[int i]=>Value[i];

public static A111058Inst Instance=new A111058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111059
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,180L,1260L,12600L,138600L,1801800L,25225200L,378378000L,6432426000L,122216094000L,2566537974000L,56463835428000L,1298668214844000L,33765373585944000L,979195833992376000L,BigInteger.Parse("29375875019771280000") };
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
public class A111059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111059Inst Instance=new A111059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111060
{
public static readonly long[] Value={ 0L,2L,3L,5L,5L,7L,7L,11L,13L,9L,8L,17L,19L,10L,13L,23L,15L,29L,10L,31L,14L,19L,12L,37L,21L,16L,41L,12L,43L,25L,47L,20L,53L,16L,22L,31L,59L,61L,33L,18L,16L,67L,26L,14L,71L,73L,39L,18L,18L,79L,43L,83L,22L,45L,32L,89L,20L,34L,49L,24L,97L,101L,22L,103L,15L,55L,107L,109L,18L,40L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111060Inst : IEnumerable<long>
{
public static readonly long[] Value=A111060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111060.Bytes);
public long this[int i]=>Value[i];

public static A111060Inst Instance=new A111060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111061
{
public static readonly BigInteger[] Value={ 1L,2L,6L,22L,214L,5846L,1758934L,12261709526L,30218268284999382L,BigInteger.Parse("441774643647969157361358550"),BigInteger.Parse("18704202113934148330876898021651431451973334"),BigInteger.Parse("9851903763165025237741730894918087846312835864942483209357642906130134") };
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
public class A111061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111061Inst Instance=new A111061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111062
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,6L,3L,1L,10L,16L,12L,4L,1L,26L,50L,40L,20L,5L,1L,76L,156L,150L,80L,30L,6L,1L,232L,532L,546L,350L,140L,42L,7L,1L,764L,1856L,2128L,1456L,700L,224L,56L,8L,1L,2620L,6876L,8352L,6384L,3276L,1260L,336L,72L,9L,1L,9496L,26200L,34380L,27840L,15960L,6552L,2100L,480L,90L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111062Inst : IEnumerable<long>
{
public static readonly long[] Value=A111062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111062.Bytes);
public long this[int i]=>Value[i];

public static A111062Inst Instance=new A111062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111063
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,31L,129L,651L,3913L,27399L,219201L,1972819L,19728201L,217010223L,2604122689L,33853594971L,473950329609L,7109254944151L,113748079106433L,1933717344809379L,34806912206568841L,661331331924807999L,13226626638496160001UL,BigInteger.Parse("277759159408419360043") };
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
public class A111063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111063Inst Instance=new A111063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111064
{
public static readonly long[] Value={ 7L,8L,10L,17L,47L,61L,70L,170L,185L,299L,766L,950L,1247L,1669L,1879L,2063L,2090L,2701L,3071L,5809L,6190L,7057L,7409L,8410L,12754L,13303L,13421L,14533L,16250L,18793L,24766L,24895L,28594L,28870L,29093L,29189L,30647L,31481L,36334L,38123L,38957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111064Inst : IEnumerable<long>
{
public static readonly long[] Value=A111064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111064.Bytes);
public long this[int i]=>Value[i];

public static A111064Inst Instance=new A111064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111065
{
public static readonly long[] Value={ 0L,69L,96L,609L,906L,6009L,6699L,6969L,9006L,9696L,9966L,60009L,66099L,69069L,90006L,96096L,99066L,600009L,606909L,609609L,660099L,666999L,669699L,690069L,696969L,699669L,900006L,906906L,909606L,960096L,966996L,969696L,990066L,996966L,999666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111065Inst : IEnumerable<long>
{
public static readonly long[] Value=A111065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111065.Bytes);
public long this[int i]=>Value[i];

public static A111065Inst Instance=new A111065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111066
{
public static readonly long[] Value={ 12L,21L,112L,121L,122L,211L,212L,221L,1112L,1121L,1122L,1211L,1212L,1221L,1222L,2111L,2112L,2121L,2122L,2211L,2212L,2221L,11112L,11121L,11122L,11211L,11212L,11221L,11222L,12111L,12112L,12121L,12122L,12211L,12212L,12221L,12222L,21111L,21112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111066Inst : IEnumerable<long>
{
public static readonly long[] Value=A111066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111066.Bytes);
public long this[int i]=>Value[i];

public static A111066Inst Instance=new A111066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111067
{
public static readonly long[] Value={ 1L,11L,79L,427L,3009L,21779L,166649L,1322266L,10752066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111067Inst : IEnumerable<long>
{
public static readonly long[] Value=A111067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111067.Bytes);
public long this[int i]=>Value[i];

public static A111067Inst Instance=new A111067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111068
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,15L,17L,27L,29L,35L,41L,43L,45L,49L,53L,55L,59L,63L,71L,81L,91L,95L,105L,111L,119L,123L,129L,141L,143L,155L,171L,181L,183L,197L,199L,207L,209L,217L,221L,237L,241L,249L,251L,253L,263L,277L,283L,297L,309L,315L,323L,325L,337L,349L,357L,363L,365L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111068Inst : IEnumerable<long>
{
public static readonly long[] Value=A111068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111068.Bytes);
public long this[int i]=>Value[i];

public static A111068Inst Instance=new A111068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111069
{
public static readonly long[] Value={ 2L,4L,12L,14L,18L,24L,26L,28L,38L,46L,56L,66L,74L,84L,96L,98L,102L,112L,124L,126L,128L,144L,152L,164L,168L,182L,186L,212L,214L,236L,238L,252L,254L,262L,266L,268L,278L,284L,304L,306L,312L,324L,332L,334L,338L,352L,362L,378L,388L,392L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111069Inst : IEnumerable<long>
{
public static readonly long[] Value=A111069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111069.Bytes);
public long this[int i]=>Value[i];

public static A111069Inst Instance=new A111069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111070
{
public static readonly long[] Value={ 11L,13L,311L,313L,131111L,131113L,313331L,313333L,1131131L,1131133L,3331331L,3331333L,3333131L,3333133L,3333311L,3333313L,111113111L,111113113L,113331311L,113331313L,331313111L,331313113L,331331111L,331331113L,333331331L,333331333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111070Inst : IEnumerable<long>
{
public static readonly long[] Value=A111070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111070.Bytes);
public long this[int i]=>Value[i];

public static A111070Inst Instance=new A111070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111071
{
public static readonly long[] Value={ 1L,8L,24L,64L,126L,202L,300L,408L,636L,862L,1106L,1474L,1716L,1968L,2432L,3066L,3532L,4016L,4684L,5104L,5684L,6468L,7290L,8532L,9694L,10296L,10912L,11550L,12190L,14220L,16500L,17808L,18894L,20560L,22342L,23544L,25424L,27048L,28712L,30786L,32208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111071Inst : IEnumerable<long>
{
public static readonly long[] Value=A111071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111071.Bytes);
public long this[int i]=>Value[i];

public static A111071Inst Instance=new A111071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111072
{
public static readonly long[] Value={ 0L,1L,4L,10L,10L,15L,16L,24L,30L,35L,40L,46L,54L,55L,60L,60L,66L,69L,70L,70L,70L,71L,74L,80L,80L,85L,86L,94L,100L,105L,110L,116L,124L,125L,130L,130L,136L,139L,140L,140L,140L,141L,144L,150L,150L,155L,156L,164L,170L,175L,180L,186L,194L,195L,200L,200L,206L,209L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111072Inst : IEnumerable<long>
{
public static readonly long[] Value=A111072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111072.Bytes);
public long this[int i]=>Value[i];

public static A111072Inst Instance=new A111072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111073
{
public static readonly long[] Value={ 4L,8L,16L,32L,64L,126L,128L,252L,256L,378L,390L,504L,512L,630L,756L,780L,798L,882L,1008L,1024L,1134L,1150L,1170L,1260L,1512L,1560L,1596L,1764L,1890L,1950L,2016L,2046L,2048L,2268L,2300L,2340L,2394L,2520L,2646L,2730L,2886L,3024L,3120L,3150L,3192L,3402L,3450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111073Inst : IEnumerable<long>
{
public static readonly long[] Value=A111073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111073.Bytes);
public long this[int i]=>Value[i];

public static A111073Inst Instance=new A111073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111074
{
public static readonly long[] Value={ 3L,0L,6L,1L,10L,3L,15L,6L,21L,10L,28L,15L,36L,21L,45L,28L,55L,36L,66L,45L,78L,55L,91L,66L,105L,78L,120L,91L,136L,105L,153L,120L,171L,136L,190L,153L,210L,171L,231L,190L,253L,210L,276L,231L,300L,253L,325L,276L,351L,300L,378L,325L,406L,351L,435L,378L,465L,406L,496L,435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111074Inst : IEnumerable<long>
{
public static readonly long[] Value=A111074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111074.Bytes);
public long this[int i]=>Value[i];

public static A111074Inst Instance=new A111074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111075
{
public static readonly long[] Value={ 1L,2L,3L,7L,6L,21L,14L,50L,52L,122L,90L,427L,234L,784L,1038L,2351L,1598L,6860L,4182L,17262L,17262L,35622L,28658L,139703L,90031L,243308L,300405L,766850L,514230L,2367006L,1346270L,5188658L,5326470L,11409346L,11782764L,44717548L,24157818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111075Inst : IEnumerable<long>
{
public static readonly long[] Value=A111075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111075.Bytes);
public long this[int i]=>Value[i];

public static A111075Inst Instance=new A111075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111076
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,3L,3L,2L,3L,2L,5L,2L,3L,2L,3L,3L,5L,2L,3L,2L,7L,5L,5L,2L,7L,2L,3L,2L,7L,3L,3L,2L,3L,2L,5L,2L,3L,2L,3L,6L,5L,3L,3L,2L,5L,5L,5L,3L,3L,5L,7L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,7L,5L,5L,5L,2L,3L,2L,7L,3L,3L,2L,7L,2L,5L,3L,3L,2L,3L,3L,7L,2L,3L,11L,5L,2L,5L,5L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111076Inst : IEnumerable<long>
{
public static readonly long[] Value=A111076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111076.Bytes);
public long this[int i]=>Value[i];

public static A111076Inst Instance=new A111076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111077
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,6L,10L,14L,22L,35L,57L,91L,145L,235L,379L,611L,989L,1598L,2585L,4182L,6766L,10947L,17713L,28658L,46369L,75026L,121394L,196419L,317813L,514230L,832042L,1346270L,2178310L,3524579L,5702889L,9227467L,14930353L,24157819L,39088171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111077Inst : IEnumerable<long>
{
public static readonly long[] Value=A111077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111077.Bytes);
public long this[int i]=>Value[i];

public static A111077Inst Instance=new A111077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111078
{
public static readonly long[] Value={ 0L,83L,174L,276L,388L,512L,650L,801L,969L,1154L,1358L,1584L,1833L,2107L,2411L,2746L,3115L,3523L,3973L,4470L,5018L,5624L,6291L,7028L,7842L,8740L,9730L,10824L,12031L,13363L,14833L,16456L,18247L,20224L,22406L,24815L,27473L,30408L,33648L,37224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111078Inst : IEnumerable<long>
{
public static readonly long[] Value=A111078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111078.Bytes);
public long this[int i]=>Value[i];

public static A111078Inst Instance=new A111078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111079
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,5L,1L,48L,1L,13L,10L,21L,1L,136L,1L,165L,26L,89L,1L,2016L,5L,233L,34L,1131L,1L,26840L,1L,987L,178L,1597L,65L,139536L,1L,4181L,466L,47355L,1L,1269736L,1L,53133L,10370L,28657L,1L,4358592L,13L,825275L,3194L,364179L,1L,14927768L,445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111079Inst : IEnumerable<long>
{
public static readonly long[] Value=A111079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111079.Bytes);
public long this[int i]=>Value[i];

public static A111079Inst Instance=new A111079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111080
{
public static readonly long[] Value={ 11L,44L,110L,220L,385L,616L,924L,1320L,1815L,2420L,3146L,4004L,5005L,6160L,7480L,8976L,10659L,12540L,14630L,16940L,19481L,22264L,25300L,28600L,32175L,36036L,40194L,44660L,49445L,54560L,60016L,65824L,71995L,78540L,85470L,92796L,100529L,108680L,117260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111080Inst : IEnumerable<long>
{
public static readonly long[] Value=A111080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111080.Bytes);
public long this[int i]=>Value[i];

public static A111080Inst Instance=new A111080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111081
{
public static readonly BigInteger[] Value={ 1L,2L,11L,21L,221L,22112L,11221211L,21221121121L,2212211212212112L,BigInteger.Parse("1122122112122122112112122"),BigInteger.Parse("12112212211212212211211221211212212211"),BigInteger.Parse("211212211211221211211221221121221211221221211211221221121") };
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
public class A111081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111081Inst Instance=new A111081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111082
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,18L,20L,24L,30L,32L,34L,44L,46L,48L,50L,52L,58L,68L,72L,74L,76L,78L,80L,94L,96L,104L,106L,122L,128L,132L,134L,146L,148L,158L,162L,164L,172L,178L,186L,192L,200L,204L,208L,214L,226L,230L,232L,240L,254L,256L,258L,262L,268L,270L,276L,278L,286L,292L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111082Inst : IEnumerable<long>
{
public static readonly long[] Value=A111082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111082.Bytes);
public long this[int i]=>Value[i];

public static A111082Inst Instance=new A111082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111083
{
public static readonly long[] Value={ 1L,5L,7L,9L,13L,15L,27L,33L,35L,41L,47L,51L,57L,63L,65L,69L,71L,77L,79L,83L,85L,89L,91L,103L,113L,117L,121L,139L,141L,147L,155L,175L,181L,187L,189L,191L,197L,201L,215L,219L,223L,225L,239L,243L,247L,251L,253L,259L,261L,265L,281L,293L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111083Inst : IEnumerable<long>
{
public static readonly long[] Value=A111083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111083.Bytes);
public long this[int i]=>Value[i];

public static A111083Inst Instance=new A111083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111084
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,14L,28L,32L,34L,36L,44L,46L,54L,55L,59L,60L,64L,66L,92L,96L,100L,102L,108L,114L,122L,124L,130L,132L,146L,152L,158L,162L,178L,192L,198L,204L,206L,208L,214L,216L,296L,308L,326L,328L,330L,332L,334L,342L,350L,356L,358L,426L,446L,458L,460L,464L,480L,484L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111084Inst : IEnumerable<long>
{
public static readonly long[] Value=A111084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111084.Bytes);
public long this[int i]=>Value[i];

public static A111084Inst Instance=new A111084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111085
{
public static readonly long[] Value={ 1L,12L,132L,847L,3921L,14286L,43687L,116757L,280656L,619219L,1273125L,2467302L,4547458L,8027223L,13648170L,22454470L,35884827L,55883718L,85034962L,126719913L,185303679L,266351932L,376882089L,525651699L,723488194L,983663109L,1322315307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111085Inst : IEnumerable<long>
{
public static readonly long[] Value=A111085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111085.Bytes);
public long this[int i]=>Value[i];

public static A111085Inst Instance=new A111085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111086
{
public static readonly long[] Value={ 1L,153L,6297L,82161L,582377L,2823169L,10577681L,32908425L,88984025L,215645185L,478631121L,988480025L,1922282689L,3552547017L,6284626217L,10704205425L,17636581137L,28219457161L,43991281193L,66997065953L,99914018553L,146199131313L,210261368801L,297660801977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111086Inst : IEnumerable<long>
{
public static readonly long[] Value=A111086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111086.Bytes);
public long this[int i]=>Value[i];

public static A111086Inst Instance=new A111086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111087
{
public static readonly long[] Value={ 1L,8L,12L,16L,18L,20L,24L,27L,28L,30L,32L,36L,40L,42L,44L,45L,48L,50L,52L,54L,56L,60L,63L,64L,66L,68L,70L,72L,75L,76L,78L,80L,81L,84L,88L,90L,92L,96L,98L,99L,100L,102L,104L,105L,108L,110L,112L,114L,116L,117L,120L,124L,125L,126L,128L,130L,132L,135L,136L,138L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111087Inst : IEnumerable<long>
{
public static readonly long[] Value=A111087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111087.Bytes);
public long this[int i]=>Value[i];

public static A111087Inst Instance=new A111087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111088
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,52L,464L,5184L,68928L,1057584L,18345536L,354570112L,7551674624L,175700025728L,4433961734656L,120642462777344L,3520972469815296L,109731998026937088L,3637456413350962176L,BigInteger.Parse("127800512612435896320") };
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
public class A111088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111088Inst Instance=new A111088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111089
{
public static readonly long[] Value={ 2L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,3L,13L,7L,5L,2L,17L,3L,19L,5L,7L,11L,23L,3L,5L,13L,3L,7L,29L,5L,31L,2L,11L,17L,7L,3L,37L,19L,13L,5L,41L,7L,43L,11L,5L,23L,47L,3L,7L,5L,17L,13L,53L,3L,11L,7L,19L,29L,59L,5L,61L,31L,7L,2L,13L,11L,67L,17L,23L,7L,71L,3L,73L,37L,5L,19L,11L,13L,79L,5L,3L,41L,83L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111089Inst : IEnumerable<long>
{
public static readonly long[] Value=A111089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111089.Bytes);
public long this[int i]=>Value[i];

public static A111089Inst Instance=new A111089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111090
{
public static readonly BigInteger[] Value={ 1L,2L,11L,21L,112L,2122L,1121122L,2122121122L,1121122122121122L,BigInteger.Parse("212212112212211211212211"),BigInteger.Parse("112112212212112212211212212112112212") };
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
public class A111090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111090Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111090.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111090Inst Instance=new A111090Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111091
{
public static readonly BigInteger[] Value={ 1L,3L,111L,313L,1113111L,313111313L,11131113131113111L,BigInteger.Parse("3131113131113111313111313"),BigInteger.Parse("1113111313111311131311131311131113131113111") };
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
public class A111091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111091Inst Instance=new A111091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111092
{
public static readonly long[] Value={ 71L,139L,211L,281L,349L,419L,421L,491L,631L,701L,769L,839L,911L,1049L,1051L,1259L,1399L,1471L,1609L,1889L,2029L,2099L,2239L,2309L,2311L,2381L,2521L,2591L,2659L,2729L,2731L,2801L,2939L,3011L,3079L,3221L,3359L,3361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111092Inst : IEnumerable<long>
{
public static readonly long[] Value=A111092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111092.Bytes);
public long this[int i]=>Value[i];

public static A111092Inst Instance=new A111092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111093
{
public static readonly long[] Value={ 0L,1L,6L,10L,10L,15L,16L,16L,20L,25L,30L,36L,36L,45L,50L,50L,56L,61L,70L,70L,70L,71L,76L,80L,80L,85L,86L,86L,90L,95L,100L,106L,106L,115L,120L,120L,126L,131L,140L,140L,140L,141L,146L,150L,150L,155L,156L,156L,160L,165L,170L,176L,176L,185L,190L,190L,196L,201L,210L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111093Inst : IEnumerable<long>
{
public static readonly long[] Value=A111093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111093.Bytes);
public long this[int i]=>Value[i];

public static A111093Inst Instance=new A111093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111094
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,11L,15L,17L,21L,22L,24L,27L,29L,30L,32L,34L,35L,41L,42L,45L,46L,49L,51L,52L,55L,56L,59L,62L,64L,65L,71L,72L,79L,81L,85L,86L,87L,90L,92L,94L,97L,99L,100L,104L,111L,112L,114L,116L,119L,120L,121L,125L,126L,127L,130L,132L,137L,139L,140L,141L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111094Inst : IEnumerable<long>
{
public static readonly long[] Value=A111094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111094.Bytes);
public long this[int i]=>Value[i];

public static A111094Inst Instance=new A111094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111095
{
public static readonly long[] Value={ 1L,2L,12L,22L,122L,3L,13L,23L,123L,223L,1223L,33L,133L,233L,1233L,2233L,12233L,333L,1333L,2333L,12333L,22333L,122333L,4L,14L,24L,124L,224L,1224L,34L,134L,234L,1234L,2234L,12234L,334L,1334L,2334L,12334L,22334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111095Inst : IEnumerable<long>
{
public static readonly long[] Value=A111095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111095.Bytes);
public long this[int i]=>Value[i];

public static A111095Inst Instance=new A111095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111096
{
public static readonly BigInteger[] Value={ 16L,232L,59281L,10059281L,4049575228945L,1950244643588320L,BigInteger.Parse("30041944445326335483061"),BigInteger.Parse("32095019157463691981298869"),BigInteger.Parse("142108579247039194637916834814494") };
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
public class A111096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111096Inst Instance=new A111096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111097
{
public static readonly long[] Value={ 1L,2L,5L,8L,13L,19L,25L,33L,42L,51L,62L,74L,86L,100L,115L,130L,147L,165L,183L,203L,224L,245L,268L,292L,316L,342L,369L,396L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111097Inst : IEnumerable<long>
{
public static readonly long[] Value=A111097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111097.Bytes);
public long this[int i]=>Value[i];

public static A111097Inst Instance=new A111097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111098
{
public static readonly BigInteger[] Value={ 1000L,1000000000L,BigInteger.Parse("1000000000000000000000000000"),100L,0L,4L,8L,3L,5L,-1L,-1L,11L,1000000L,1L,0L,BigInteger.Parse("1000000000000000000000000"),1000000000000000L,0L,6L,2L,4L,5L,2L,6L,20L,0L };
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
public class A111098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111098Inst Instance=new A111098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111099
{
public static readonly long[] Value={ 0L,1L,2L,4L,9L,20L,45L,105L,246L,583L,1393L,3355L,8133L,19825L,48554L,119412L,294761L,729980L,1813107L,4515225L,11271198L,28196896L,70679137L,177487714L,446446560L,1124706145L,2837445500L,7167878628L,18129622761L,45907772900L,116372614251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111099Inst : IEnumerable<long>
{
public static readonly long[] Value=A111099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111099.Bytes);
public long this[int i]=>Value[i];

public static A111099Inst Instance=new A111099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111100
{
public static readonly long[] Value={ 4L,8L,112L,2720L,103552L,5764352L,445521664L,45890802176L,6094567045120L,1015769696055296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111100Inst : IEnumerable<long>
{
public static readonly long[] Value=A111100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111100.Bytes);
public long this[int i]=>Value[i];

public static A111100Inst Instance=new A111100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111101
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,12L,13L,3138L,3142L,3146L,3147L,6272L,6273L,6277L,6278L,11112006825564294L,11112006825564295L,11112006825567420L,11112006825567421L,11112006825570546L,11112006825570550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111101Inst : IEnumerable<long>
{
public static readonly long[] Value=A111101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111101.Bytes);
public long this[int i]=>Value[i];

public static A111101Inst Instance=new A111101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111102
{
public static readonly long[] Value={ 1L,5L,9L,10L,11L,15L,16L,20L,24L,25L,29L,33L,34L,35L,39L,40L,41L,45L,49L,50L,54L,55L,56L,60L,61L,65L,69L,70L,71L,75L,76L,77L,81L,82L,86L,90L,91L,95L,99L,100L,101L,105L,106L,110L,114L,115L,119L,120L,121L,125L,126L,127L,131L,135L,136L,140L,144L,145L,146L,150L,151L,155L,159L,160L,164L,168L,169L,170L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111102Inst : IEnumerable<long>
{
public static readonly long[] Value=A111102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111102.Bytes);
public long this[int i]=>Value[i];

public static A111102Inst Instance=new A111102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111103
{
public static readonly long[] Value={ 1L,8L,27L,64L,125L,343L,729L,1000L,1331L,1728L,6859L,9261L,12167L,13824L,15625L,17576L,79507L,103823L,132651L,166375L,175616L,226981L,357911L,421875L,493039L,571787L,614125L,658503L,753571L,778688L,1092727L,1331000L,1860867L,1906624L,2248091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111103Inst : IEnumerable<long>
{
public static readonly long[] Value=A111103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111103.Bytes);
public long this[int i]=>Value[i];

public static A111103Inst Instance=new A111103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111104
{
public static readonly long[] Value={ 2L,1L,4L,6L,6L,6L,18L,18L,48L,30L,12L,30L,6L,42L,66L,42L,150L,18L,12L,48L,6L,72L,12L,30L,138L,60L,18L,84L,204L,54L,36L,6L,144L,12L,156L,24L,18L,60L,36L,6L,126L,48L,18L,168L,42L,12L,12L,204L,78L,6L,6L,18L,54L,84L,30L,24L,18L,150L,72L,6L,6L,36L,42L,66L,126L,318L,186L,18L,24L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111104Inst : IEnumerable<long>
{
public static readonly long[] Value=A111104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111104.Bytes);
public long this[int i]=>Value[i];

public static A111104Inst Instance=new A111104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111105
{
public static readonly long[] Value={ 697L,925L,1073L,1105L,1394L,1850L,2091L,2146L,2165L,2210L,2665L,2775L,2788L,3219L,3277L,3315L,3485L,3700L,3965L,4181L,4182L,4225L,4292L,4330L,4420L,4453L,4625L,4879L,5330L,5365L,5525L,5550L,5576L,6005L,6273L,6438L,6475L,6495L,6554L,6630L,6970L,7085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111105Inst : IEnumerable<long>
{
public static readonly long[] Value=A111105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111105.Bytes);
public long this[int i]=>Value[i];

public static A111105Inst Instance=new A111105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111106
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,2L,1L,0L,15L,7L,3L,1L,0L,105L,36L,12L,4L,1L,0L,945L,249L,64L,18L,5L,1L,0L,10395L,2190L,441L,100L,25L,6L,1L,0L,135135L,23535L,3807L,691L,145L,33L,7L,1L,0L,2027025L,299880L,40032L,5880L,1010L,200L,42L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111106Inst : IEnumerable<long>
{
public static readonly long[] Value=A111106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111106.Bytes);
public long this[int i]=>Value[i];

public static A111106Inst Instance=new A111106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111107
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,29L,43L,53L,59L,71L,79L,83L,103L,113L,139L,173L,181L,227L,269L,277L,317L,383L,463L,509L,673L,701L,751L,863L,967L,977L,1187L,1201L,1493L,1531L,1609L,1637L,1801L,2153L,2221L,2239L,2371L,2377L,2543L,2557L,2683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111107Inst : IEnumerable<long>
{
public static readonly long[] Value=A111107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111107.Bytes);
public long this[int i]=>Value[i];

public static A111107Inst Instance=new A111107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111108
{
public static readonly long[] Value={ 0L,5L,3L,25L,25L,131L,175L,705L,1137L,3875L,7095L,21649L,43225L,122435L,259423L,698625L,1541985L,4011971L,9107175L,23143825L,53559817L,133933475L,314086735L,776787009L,1838300625L,4512108515L,10745077143L,26237143825L,62749602745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111108Inst : IEnumerable<long>
{
public static readonly long[] Value=A111108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111108.Bytes);
public long this[int i]=>Value[i];

public static A111108Inst Instance=new A111108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111109
{
public static readonly long[] Value={ 0L,1L,2L,5L,14L,40L,111L,301L,803L,2118L,5540L,14397L,37216L,95772L,245505L,627189L,1597413L,4057450L,10280678L,25990933L,65575122L,165138416L,415158963L,1042067549L,2611823431L,6537384302L,16342461128L,40805714573L,101776575332L,253587643300L,631232103045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111109Inst : IEnumerable<long>
{
public static readonly long[] Value=A111109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111109.Bytes);
public long this[int i]=>Value[i];

public static A111109Inst Instance=new A111109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111110
{
public static readonly long[] Value={ 0L,1L,2L,5L,14L,40L,111L,299L,793L,2096L,5553L,14758L,39294L,104673L,278773L,742197L,1975582L,5258269L,13995810L,37253664L,99163215L,263958623L,702620141L,1870267300L,4978351449L,13251558642L,35273486910L,93892303905L,249926170873L,665263248665L,1770823721530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111110Inst : IEnumerable<long>
{
public static readonly long[] Value=A111110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111110.Bytes);
public long this[int i]=>Value[i];

public static A111110Inst Instance=new A111110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111111
{
public static readonly BigInteger[] Value={ 1L,2L,0L,2L,6L,46L,338L,2926L,28146L,298526L,3454434L,43286526L,583835650L,8433987582L,129941213186L,2127349165822L,36889047574274L,675548628690430L,13030733384956418L,264111424634864638L,5612437196153963522L,BigInteger.Parse("124789500579376435198"),BigInteger.Parse("2897684052921851965442") };
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
public class A111111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111111Inst Instance=new A111111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111112
{
public static readonly long[] Value={ 0L,0L,0L,118560L,991680L,4465920L,14587200L,38887200L,89965440L,187368960L,359767680L,647427360L,1104978240L,1804481280L,2838790080L,4325210400L,6409455360L,9269898240L,13122120960L,18223760160L,24879648960L,33447256320L,44342422080L,58045389600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111112Inst : IEnumerable<long>
{
public static readonly long[] Value=A111112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111112.Bytes);
public long this[int i]=>Value[i];

public static A111112Inst Instance=new A111112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111113
{
public static readonly long[] Value={ 0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111113Inst : IEnumerable<long>
{
public static readonly long[] Value=A111113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111113.Bytes);
public long this[int i]=>Value[i];

public static A111113Inst Instance=new A111113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111114
{
public static readonly long[] Value={ 3L,2L,3L,3L,4L,4L,4L,5L,7L,6L,7L,6L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,11L,11L,11L,10L,11L,11L,11L,12L,12L,13L,13L,13L,13L,13L,14L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,15L,16L,17L,17L,17L,17L,17L,17L,18L,18L,17L,17L,17L,17L,18L,18L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111114Inst : IEnumerable<long>
{
public static readonly long[] Value=A111114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111114.Bytes);
public long this[int i]=>Value[i];

public static A111114Inst Instance=new A111114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111115
{
public static readonly long[] Value={ 2L,4L,6L,18L,48L,66L,150L,204L,318L,348L,450L,486L,546L,696L,1050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111115Inst : IEnumerable<long>
{
public static readonly long[] Value=A111115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111115.Bytes);
public long this[int i]=>Value[i];

public static A111115Inst Instance=new A111115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111116
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,9L,24L,27L,28L,32L,33L,42L,52L,53L,58L,59L,67L,77L,88L,89L,93L,202L,203L,258L,284L,303L,324L,329L,377L,383L,422L,669L,818L,832L,843L,878L,882L,887L,949L,2027L,2042L,2673L,3144L,3222L,3253L,3302L,3308L,3737L,3773L,3953L,3979L,3983L,4779L,5353L,5669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111116Inst : IEnumerable<long>
{
public static readonly long[] Value=A111116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111116.Bytes);
public long this[int i]=>Value[i];

public static A111116Inst Instance=new A111116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111117
{
public static readonly long[] Value={ 1L,3L,9L,27L,31L,37L,41L,93L,111L,123L,271L,279L,333L,369L,813L,837L,999L,1107L,1147L,1271L,1517L,2439L,3441L,3813L,4551L,7317L,8401L,10027L,10323L,11111L,11439L,13653L,25203L,30081L,30969L,33333L,34317L,40959L,47027L,75609L,90243L,99999L,141081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111117Inst : IEnumerable<long>
{
public static readonly long[] Value=A111117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111117.Bytes);
public long this[int i]=>Value[i];

public static A111117Inst Instance=new A111117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111118
{
public static readonly long[] Value={ 1L,5L,11L,2L,13L,23L,9L,26L,7L,28L,3L,31L,52L,29L,55L,25L,57L,22L,59L,19L,62L,17L,64L,15L,66L,10L,68L,6L,71L,115L,69L,117L,63L,119L,60L,121L,56L,124L,53L,126L,50L,128L,47L,131L,45L,133L,43L,135L,40L,137L,38L,140L,35L,142L,33L,144L,30L,147L,24L,149L,18L,151L,14L,153L,8L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111118Inst : IEnumerable<long>
{
public static readonly long[] Value=A111118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111118.Bytes);
public long this[int i]=>Value[i];

public static A111118Inst Instance=new A111118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111119
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,5L,240L,130L,4095L,884L,122522400L,5785L,1570247078400L,7050580L,6402818331L,55911099400L,BigInteger.Parse("83044763560621070208000"),2152604285L,BigInteger.Parse("342696507457909818131702784000"),122400523811956L,BigInteger.Parse("16017296251646471425875") };
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
public class A111119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111119Inst Instance=new A111119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111120
{
public static readonly long[] Value={ 1L,3L,9L,9L,9L,6L,6L,2L,7L,5L,5L,5L,9L,9L,0L,8L,9L,4L,2L,6L,0L,0L,5L,0L,9L,8L,1L,6L,3L,1L,1L,3L,1L,5L,4L,7L,1L,2L,8L,2L,3L,4L,4L,3L,6L,1L,8L,4L,4L,0L,6L,8L,8L,2L,1L,0L,3L,6L,4L,7L,6L,5L,4L,1L,7L,6L,9L,0L,3L,8L,7L,8L,7L,2L,5L,3L,3L,4L,0L,4L,1L,9L,1L,1L,8L,5L,8L,2L,1L,9L,8L,1L,8L,0L,6L,4L,9L,1L,0L,5L,8L,9L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111120Inst : IEnumerable<long>
{
public static readonly long[] Value=A111120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111120.Bytes);
public long this[int i]=>Value[i];

public static A111120Inst Instance=new A111120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111121
{
public static readonly BigInteger[] Value={ -1L,0L,1L,0L,1L,2L,3L,8L,25L,116L,1253L,30334L,3161239L,2890534072L,37908199848897L,BigInteger.Parse("39946852159641845000"),BigInteger.Parse("25587984997105954864555102857"),BigInteger.Parse("56071032677809871004962669691748664133130") };
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
public class A111121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111121Inst Instance=new A111121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111122
{
public static readonly long[] Value={ 15L,5L,1L,1L,1L,17L,1L,24L,173L,27L,412L,99L,516L,12L,509L,322L,173L,2562L,124L,7179L,1742L,3862L,489L,761L,663L,483L,9189L,393L,2668L,2856L,7867L,68L,2249L,2174L,1061L,3441L,16348L,6241L,33242L,3834L,33971L,103681L,11894L,2063L,23244L,5849L,44689L,8803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111122Inst : IEnumerable<long>
{
public static readonly long[] Value=A111122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111122.Bytes);
public long this[int i]=>Value[i];

public static A111122Inst Instance=new A111122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111123
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,8L,11L,16L,25L,38L,57L,85L,127L,192L,289L,430L,644L,966L,1450L,2173L,3263L,4899L,7341L,11022L,16526L,24802L,37201L,55808L,83702L,125541L,188301L,282444L,423683L,635569L,953356L,1429969L,2144990L,3217454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111123Inst : IEnumerable<long>
{
public static readonly long[] Value=A111123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111123.Bytes);
public long this[int i]=>Value[i];

public static A111123Inst Instance=new A111123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111124
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,6L,11L,17L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111124Inst : IEnumerable<long>
{
public static readonly long[] Value=A111124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111124.Bytes);
public long this[int i]=>Value[i];

public static A111124Inst Instance=new A111124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111125
{
public static readonly long[] Value={ 1L,3L,1L,5L,5L,1L,7L,14L,7L,1L,9L,30L,27L,9L,1L,11L,55L,77L,44L,11L,1L,13L,91L,182L,156L,65L,13L,1L,15L,140L,378L,450L,275L,90L,15L,1L,17L,204L,714L,1122L,935L,442L,119L,17L,1L,19L,285L,1254L,2508L,2717L,1729L,665L,152L,19L,1L,21L,385L,2079L,5148L,7007L,5733L,2940L,952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111125Inst : IEnumerable<long>
{
public static readonly long[] Value=A111125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111125.Bytes);
public long this[int i]=>Value[i];

public static A111125Inst Instance=new A111125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111126
{
public static readonly long[] Value={ 1L,10L,3L,35L,28L,5L,84L,126L,54L,7L,165L,396L,297L,88L,9L,286L,1001L,1144L,572L,130L,11L,455L,2184L,3510L,2600L,975L,180L,13L,680L,4284L,9180L,9350L,5100L,1530L,238L,15L,969L,7752L,21318L,28424L,20995L,9044L,2261L,304L,17L,1330L,13167L,45144L,76076L,72618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111126Inst : IEnumerable<long>
{
public static readonly long[] Value=A111126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111126.Bytes);
public long this[int i]=>Value[i];

public static A111126Inst Instance=new A111126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111127
{
public static readonly long[] Value={ 1L,3L,10L,5L,28L,35L,7L,54L,126L,84L,9L,88L,297L,396L,165L,11L,130L,572L,1144L,1001L,286L,13L,180L,975L,2600L,3510L,2184L,455L,15L,238L,1530L,5100L,9350L,9180L,4284L,680L,17L,304L,2261L,9044L,20995L,28424L,21318L,7752L,969L,19L,378L,3192L,14896L,41895L,72618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111127Inst : IEnumerable<long>
{
public static readonly long[] Value=A111127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111127.Bytes);
public long this[int i]=>Value[i];

public static A111127Inst Instance=new A111127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111128
{
public static readonly long[] Value={ 2L,21L,72L,181L,390L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111128Inst : IEnumerable<long>
{
public static readonly long[] Value=A111128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111128.Bytes);
public long this[int i]=>Value[i];

public static A111128Inst Instance=new A111128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111129
{
public static readonly long[] Value={ 1L,5L,2L,5L,1L,3L,5L,2L,7L,6L,1L,6L,0L,9L,8L,1L,2L,0L,9L,0L,8L,9L,0L,9L,0L,5L,3L,6L,3L,9L,0L,5L,7L,8L,7L,1L,3L,3L,0L,7L,1L,1L,6L,3L,6L,4L,9L,2L,0L,6L,0L,3L,3L,3L,5L,5L,4L,6L,3L,1L,3L,9L,4L,2L,4L,2L,7L,2L,2L,6L,9L,2L,5L,5L,0L,7L,9L,5L,0L,3L,1L,6L,8L,7L,0L,2L,2L,8L,0L,1L,1L,8L,2L,6L,7L,2L,1L,1L,6L,5L,5L,2L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111129Inst : IEnumerable<long>
{
public static readonly long[] Value=A111129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111129.Bytes);
public long this[int i]=>Value[i];

public static A111129Inst Instance=new A111129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111130
{
public static readonly BigInteger[] Value={ 3L,11L,295L,18839L,2178311L,396789539L,104534716847L,37582455061871L,17677524703000879L,10535586945520548779UL,BigInteger.Parse("7758255095720238886679"),BigInteger.Parse("6916955444929558486935047"),BigInteger.Parse("7342438845112941396534404087"),BigInteger.Parse("9150463033951198007724075565619"),BigInteger.Parse("13229286823498332297225524829163231") };
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
public class A111130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111130Inst Instance=new A111130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111131
{
public static readonly long[] Value={ 1L,8L,27L,64L,125L,343L,729L,1000L,1331L,1728L,2744L,3375L,4913L,5832L,8000L,10648L,13824L,15625L,17576L,21952L,24389L,35937L,42875L,50653L,54872L,59319L,68921L,74088L,79507L,103823L,132651L,166375L,175616L,195112L,205379L,300763L,314432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111131Inst : IEnumerable<long>
{
public static readonly long[] Value=A111131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111131.Bytes);
public long this[int i]=>Value[i];

public static A111131Inst Instance=new A111131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111132
{
public static readonly long[] Value={ 1L,3L,8L,11L,15L,24L,27L,27L,34L,35L,41L,48L,53L,61L,70L,79L,87L,92L,99L,105L,106L,113L,113L,116L,125L,129L,132L,137L,139L,140L,141L,143L,148L,151L,155L,164L,167L,167L,174L,175L,181L,188L,193L,201L,210L,219L,227L,232L,239L,245L,246L,253L,253L,256L,265L,269L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111132Inst : IEnumerable<long>
{
public static readonly long[] Value=A111132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111132.Bytes);
public long this[int i]=>Value[i];

public static A111132Inst Instance=new A111132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111133
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,4L,5L,7L,9L,11L,14L,17L,21L,26L,31L,37L,45L,53L,63L,75L,88L,103L,121L,141L,164L,191L,221L,255L,295L,339L,389L,447L,511L,584L,667L,759L,863L,981L,1112L,1259L,1425L,1609L,1815L,2047L,2303L,2589L,2909L,3263L,3657L,4096L,4581L,5119L,5717L,6377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111133Inst : IEnumerable<long>
{
public static readonly long[] Value=A111133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111133.Bytes);
public long this[int i]=>Value[i];

public static A111133Inst Instance=new A111133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111134
{
public static readonly BigInteger[] Value={ 1L,2L,8L,9L,128L,625L,6561L,32768L,117649L,2147483648L,25937424601L,2541865828329L,23298085122481L,59604644775390625L,9223372036854775808UL,BigInteger.Parse("48661191875666868481"),BigInteger.Parse("104127350297911241532841") };
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
public class A111134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111134Inst Instance=new A111134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111135
{
public static readonly BigInteger[] Value={ 1L,2L,10L,130L,11570L,2695810L,4305208570L,18000077031170L,515828207482238690L,BigInteger.Parse("265253823305384119320010"),BigInteger.Parse("357102999447516172932830542690"),BigInteger.Parse("8626828910804196810251673542315707730") };
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
public class A111135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111135Inst Instance=new A111135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111136
{
public static readonly long[] Value={ 1L,3L,8L,21L,110L,343L,1940L,6121L,34778L,549007L,1895276L,26053093L,191633234L,625127671L,3596342744L,56912633917L,1013634659958L,3518365441919L,48463935654772L,356525456824901L,1163040989874294L,15635375014550515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111136Inst : IEnumerable<long>
{
public static readonly long[] Value=A111136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111136.Bytes);
public long this[int i]=>Value[i];

public static A111136Inst Instance=new A111136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111137
{
public static readonly long[] Value={ 3L,31L,311L,3113197L,3113197331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111137Inst : IEnumerable<long>
{
public static readonly long[] Value=A111137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111137.Bytes);
public long this[int i]=>Value[i];

public static A111137Inst Instance=new A111137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111138
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,4L,5L,7L,10L,10L,11L,13L,16L,20L,20L,21L,23L,26L,30L,35L,35L,36L,38L,41L,45L,50L,56L,56L,57L,59L,62L,66L,71L,77L,84L,84L,85L,87L,90L,94L,99L,105L,112L,120L,120L,121L,123L,126L,130L,135L,141L,148L,156L,165L,165L,166L,168L,171L,175L,180L,186L,193L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111138Inst : IEnumerable<long>
{
public static readonly long[] Value=A111138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111138.Bytes);
public long this[int i]=>Value[i];

public static A111138Inst Instance=new A111138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111139
{
public static readonly long[] Value={ 0L,1L,3L,11L,47L,240L,1448L,10149L,81213L,730951L,7309565L,80405304L,964863792L,12543229529L,175605213783L,2634078207355L,42145251318667L,716469272418936L,12896446903543432L,245032491167329389L,4900649823346594545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111139Inst : IEnumerable<long>
{
public static readonly long[] Value=A111139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111139.Bytes);
public long this[int i]=>Value[i];

public static A111139Inst Instance=new A111139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111140
{
public static readonly long[] Value={ 1L,1L,3L,13L,71L,466L,3582L,31641L,316171L,3526606L,43421978L,584716386L,8544649478L,134622445348L,2274031087772L,40987164702945L,784981384215795L,15916200367695510L,340548893413909410L,7666975604019750630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111140Inst : IEnumerable<long>
{
public static readonly long[] Value=A111140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111140.Bytes);
public long this[int i]=>Value[i];

public static A111140Inst Instance=new A111140Inst();

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