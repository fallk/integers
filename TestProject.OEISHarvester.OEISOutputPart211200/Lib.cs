using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A249582
{
public static readonly long[] Value={ 1L,1L,4L,17L,29L,160L,377L,1377L,4468L,13369L,46573L,141440L,469169L,1499329L,4795556L,15600033L,49731901L,161026720L,516993193L,1663865633L,5361647252L,17231870281L,55519546637L,178586104320L,574860647521L,1850350458241L,5954177494084L,19166631789617L,61680287845469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249582Inst : IEnumerable<long>
{
public static readonly long[] Value=A249582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249582.Bytes);
public long this[int i]=>Value[i];

public static A249582Inst Instance=new A249582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249583
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,9L,40L,169L,477L,3194L,19241L,74601L,666160L,5216485L,25740261L,287316122L,2769073949L,16591655817L,222237912664L,2543467934449L,17929265150637L,280180369563194L,3712914075133121L,30098784753112329L,537546603651987424L,8094884285992309261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249583Inst : IEnumerable<long>
{
public static readonly long[] Value=A249583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249583.Bytes);
public long this[int i]=>Value[i];

public static A249583Inst Instance=new A249583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249584
{
public static readonly BigInteger[] Value={ 1L,1L,31L,117715L,103060086811L,BigInteger.Parse("35762522984596014091"),BigInteger.Parse("7426384178532990386136937008571"),BigInteger.Parse("1294894823429942167077615079432957932604708795"),BigInteger.Parse("253092741940931724342360814670783323840910439695820558059377771"),BigInteger.Parse("71352024076415778396125047299738711969981288880155877082517115026490261985701403851") };
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
public class A249584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249584Inst Instance=new A249584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249585
{
public static readonly long[] Value={ 1L,10L,20L,11L,30L,2L,12L,13L,21L,14L,3L,22L,15L,4L,23L,16L,5L,24L,17L,6L,25L,18L,7L,26L,19L,8L,27L,31L,28L,37L,29L,38L,32L,41L,33L,42L,34L,35L,40L,36L,45L,39L,48L,43L,52L,44L,53L,46L,50L,47L,56L,49L,58L,54L,63L,51L,60L,55L,64L,57L,61L,59L,68L,65L,74L,62L,71L,66L,75L,67L,69L,78L,70L,76L,85L,72L,81L,73L,82L,77L,86L,79L,80L,87L,96L,83L,92L,84L,93L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249585Inst : IEnumerable<long>
{
public static readonly long[] Value=A249585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249585.Bytes);
public long this[int i]=>Value[i];

public static A249585Inst Instance=new A249585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249586
{
public static readonly long[] Value={ 0L,1L,1296L,142884L,4326400L,62015625L,549246096L,3480528016L,17247043584L,70801227225L,250500250000L,785786510916L,2231605748736L,5829824737009L,14183810499600L,32455809000000L,70403108110336L,145714859280081L,289307033504784L,553490085376900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249586Inst : IEnumerable<long>
{
public static readonly long[] Value=A249586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249586.Bytes);
public long this[int i]=>Value[i];

public static A249586Inst Instance=new A249586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249587
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,9L,10L,15L,20L,25L,30L,35L,45L,55L,65L,70L,75L,80L,85L,90L,95L,100L,125L,150L,165L,175L,185L,200L,205L,225L,245L,250L,265L,275L,285L,300L,305L,325L,350L,450L,525L,550L,575L,650L,700L,750L,775L,800L,850L,900L,945L,950L,975L,985L,1000L,1025L,1250L,1425L,1500L,1650L,1750L,1825L,1850L,2000L,2050L,2225L,2250L,2450L,2500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249587Inst : IEnumerable<long>
{
public static readonly long[] Value=A249587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249587.Bytes);
public long this[int i]=>Value[i];

public static A249587Inst Instance=new A249587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249588
{
public static readonly BigInteger[] Value={ 1L,1L,5L,49L,856L,22376L,842536L,42409480L,2782192064L,229357803456L,23289083584704L,2851295406197184L,414855423241758720L,BigInteger.Parse("70695451937596732416"),BigInteger.Parse("13958230719814052097024"),BigInteger.Parse("3159974451734082088897536"),BigInteger.Parse("813380358295803762813321216"),BigInteger.Parse("236172126115504055456155975680") };
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
public class A249588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249588Inst Instance=new A249588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249589
{
public static readonly long[] Value={ 5L,17L,19L,21L,23L,27L,29L,31L,33L,39L,49L,51L,53L,69L,71L,77L,79L,87L,91L,97L,143L,147L,151L,157L,159L,163L,171L,173L,187L,191L,199L,201L,229L,231L,233L,239L,241L,243L,247L,251L,267L,279L,283L,293L,297L,301L,321L,333L,351L,357L,363L,369L,381L,393L,423L,447L,449L,453L,457L,463L,467L,469L,471L,477L,483L,491L,493L,501L,511L,517L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249589Inst : IEnumerable<long>
{
public static readonly long[] Value=A249589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249589.Bytes);
public long this[int i]=>Value[i];

public static A249589Inst Instance=new A249589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249590
{
public static readonly BigInteger[] Value={ 1L,1L,6L,63L,1162L,31263L,1207344L,61719326L,4103067834L,341454828363L,34946904263560L,4304483416099530L,629558493157805370L,BigInteger.Parse("107728435291299602135"),BigInteger.Parse("21346960361800584031800"),BigInteger.Parse("4847223770735591212039818"),BigInteger.Parse("1250978551922243595690043914"),BigInteger.Parse("364052135715732457875255719691") };
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
public class A249590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249590Inst Instance=new A249590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249591
{
public static readonly long[] Value={ 1L,10L,9L,8L,7L,6L,5L,4L,3L,2L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,20L,29L,22L,23L,24L,25L,26L,27L,28L,32L,30L,39L,31L,33L,34L,35L,36L,37L,38L,43L,40L,49L,41L,42L,44L,45L,46L,47L,48L,54L,50L,59L,51L,52L,53L,55L,56L,57L,58L,65L,60L,69L,61L,62L,63L,64L,66L,67L,68L,70L,76L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249591Inst : IEnumerable<long>
{
public static readonly long[] Value=A249591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249591.Bytes);
public long this[int i]=>Value[i];

public static A249591Inst Instance=new A249591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249592
{
public static readonly BigInteger[] Value={ 1L,1L,6L,64L,1192L,32360L,1257880L,64644520L,4315649600L,360332919360L,36979925855040L,4564758983929920L,668857835862650880L,BigInteger.Parse("114624254940995404800"),BigInteger.Parse("22742780483191398589440"),BigInteger.Parse("5169745984444274224143360"),BigInteger.Parse("1335478685859609449305006080"),BigInteger.Parse("388956774210908224056394014720") };
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
public class A249592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249592Inst Instance=new A249592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249593
{
public static readonly BigInteger[] Value={ 1L,1L,9L,251L,16496L,2083824L,453803984L,156304214576L,80272385155584L,58631012094472704L,BigInteger.Parse("58713787327403063808"),BigInteger.Parse("78225670182020153384448"),BigInteger.Parse("135277046518915274471718912"),BigInteger.Parse("297374407080303931562525442048"),BigInteger.Parse("816367902369725640298981464096768") };
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
public class A249593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249593Inst Instance=new A249593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249594
{
public static readonly long[] Value={ 2L,4L,7L,11L,12L,14L,17L,18L,19L,22L,23L,27L,30L,32L,34L,37L,38L,41L,42L,45L,47L,50L,51L,53L,54L,55L,58L,61L,64L,65L,68L,71L,72L,74L,75L,78L,80L,81L,84L,87L,89L,90L,94L,97L,100L,102L,105L,108L,109L,111L,113L,116L,117L,119L,120L,123L,125L,129L,133L,134L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249594Inst : IEnumerable<long>
{
public static readonly long[] Value=A249594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249594.Bytes);
public long this[int i]=>Value[i];

public static A249594Inst Instance=new A249594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249595
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,9L,10L,13L,15L,16L,20L,21L,24L,25L,26L,28L,29L,31L,33L,35L,36L,39L,40L,43L,44L,46L,48L,49L,52L,56L,57L,59L,60L,62L,63L,66L,67L,69L,70L,73L,76L,77L,79L,82L,83L,85L,86L,88L,91L,92L,93L,95L,96L,98L,99L,101L,103L,104L,106L,107L,110L,112L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249595Inst : IEnumerable<long>
{
public static readonly long[] Value=A249595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249595.Bytes);
public long this[int i]=>Value[i];

public static A249595Inst Instance=new A249595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249596
{
public static readonly long[] Value={ 1L,2L,9L,4L,35L,558L,2205L,8L,135L,137970L,33L,1068L,545259L,135926L,138845925L,16L,527L,2106L,35288379945L,2100L,537075L,8382L,2093L,4283544L,1069975L,130L,2294286602622705L,533820L,133371L,146557818382226310L,585910928570692725L,32L,2079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249596Inst : IEnumerable<long>
{
public static readonly long[] Value=A249596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249596.Bytes);
public long this[int i]=>Value[i];

public static A249596Inst Instance=new A249596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249597
{
public static readonly BigInteger[] Value={ 1L,32L,3L,88L,260L,15192960L,28L,61616L,9L,7888549122400L,55L,182208L,132538588L,2240L,165L,32048741728L,1185506696L,BigInteger.Parse("2194329698227926780769440"),247L,23264534699960L,69737318935284L,179872L,14559920L,16912071582760464L,130885300L,69521680967024L,27L };
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
public class A249597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249597Inst Instance=new A249597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249598
{
public static readonly BigInteger[] Value={ 1L,18L,279L,4L,68985L,1094166L,49L,264L,1053L,1050L,4191L,17966487875148L,65L,266910L,73278909191113155L,16L,BigInteger.Parse("18722068612123127013"),BigInteger.Parse("299304917928357795234"),265639L,BigInteger.Parse("76514292380672732576340"),BigInteger.Parse("1223491190935287357533961"),67880230L,1035L,17360709912L,775L };
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
public class A249598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249598Inst Instance=new A249598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249599
{
public static readonly BigInteger[] Value={ 1L,16L,3348L,411184L,5L,1262796336L,31415153952L,128L,639L,BigInteger.Parse("46402790906782052954848931760"),9548L,BigInteger.Parse("37884308119951668432"),507L,483747841655344L,BigInteger.Parse("2949712546290578068913640"),BigInteger.Parse("368402917173844349535205696"),3162L,BigInteger.Parse("1149642179207353109724066230688") };
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
public class A249599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249599Inst Instance=new A249599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249600
{
public static readonly long[] Value={ 9L,4L,4L,2L,7L,1L,9L,0L,9L,9L,9L,9L,1L,5L,8L,7L,8L,5L,6L,3L,6L,6L,9L,4L,6L,7L,4L,9L,2L,5L,1L,0L,4L,9L,4L,1L,7L,6L,2L,4L,7L,3L,4L,3L,8L,4L,4L,6L,1L,0L,2L,8L,9L,7L,0L,8L,3L,5L,8L,8L,9L,8L,1L,6L,4L,2L,0L,8L,3L,7L,0L,2L,5L,5L,1L,2L,1L,9L,5L,9L,7L,6L,5L,7L,6L,5L,7L,6L,3L,3L,5L,1L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249600Inst : IEnumerable<long>
{
public static readonly long[] Value=A249600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249600.Bytes);
public long this[int i]=>Value[i];

public static A249600Inst Instance=new A249600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249601
{
public static readonly long[] Value={ 9L,7L,8L,7L,1L,3L,7L,6L,3L,7L,4L,7L,7L,9L,1L,8L,1L,2L,2L,9L,6L,3L,2L,3L,5L,2L,1L,6L,7L,8L,4L,0L,0L,4L,7L,2L,1L,2L,6L,4L,9L,2L,7L,7L,5L,9L,2L,1L,0L,2L,0L,1L,0L,4L,8L,4L,4L,4L,2L,1L,0L,7L,6L,8L,1L,0L,4L,6L,9L,7L,1L,9L,1L,9L,6L,9L,5L,1L,4L,4L,3L,8L,5L,1L,3L,5L,1L,2L,8L,7L,9L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249601Inst : IEnumerable<long>
{
public static readonly long[] Value=A249601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249601.Bytes);
public long this[int i]=>Value[i];

public static A249601Inst Instance=new A249601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249602
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,10L,12L,13L,16L,19L,24L,27L,28L,30L,31L,37L,43L,45L,51L,54L,55L,58L,60L,61L,67L,73L,76L,79L,82L,85L,94L,96L,97L,100L,103L,106L,115L,121L,124L,130L,133L,136L,139L,142L,144L,145L,151L,160L,163L,166L,169L,175L,178L,187L,192L,198L,201L,202L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249602Inst : IEnumerable<long>
{
public static readonly long[] Value=A249602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249602.Bytes);
public long this[int i]=>Value[i];

public static A249602Inst Instance=new A249602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249603
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,2L,1L,0L,1L,1L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,0L,2L,1L,0L,1L,2L,0L,2L,2L,1L,0L,1L,2L,0L,2L,1L,0L,1L,2L,1L,0L,2L,1L,0L,2L,2L,0L,1L,1L,1L,0L,1L,1L,0L,2L,2L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249603Inst : IEnumerable<long>
{
public static readonly long[] Value=A249603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249603.Bytes);
public long this[int i]=>Value[i];

public static A249603Inst Instance=new A249603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249604
{
public static readonly BigInteger[] Value={ 1L,11L,211L,3211L,53211L,853211L,13853211L,223853211L,3623853211L,58623853211L,948623853211L,15348623853211L,248348623853211L,4018348623853211L,65018348623853211L,1052018348623853211L,17022018348623853211UL,BigInteger.Parse("275422018348623853211"),BigInteger.Parse("4456422018348623853211") };
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
public class A249604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249604Inst Instance=new A249604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249605
{
public static readonly long[] Value={ 9L,18L,27L,36L,45L,54L,63L,72L,81L,108L,117L,126L,135L,144L,153L,162L,207L,216L,225L,234L,243L,306L,315L,324L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249605Inst : IEnumerable<long>
{
public static readonly long[] Value=A249605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249605.Bytes);
public long this[int i]=>Value[i];

public static A249605Inst Instance=new A249605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249606
{
public static readonly long[] Value={ 2L,5L,23L,107L,173L,353L,467L,743L,1277L,1487L,2213L,2777L,3083L,10733L,14537L,15227L,17393L,18917L,21323L,22157L,23873L,33413L,36587L,38783L,42197L,50723L,54617L,71633L,94397L,101477L,112577L,118343L,122267L,128273L,130307L,140717L,149333L,174347L,203843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249606Inst : IEnumerable<long>
{
public static readonly long[] Value=A249606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249606.Bytes);
public long this[int i]=>Value[i];

public static A249606Inst Instance=new A249606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249607
{
public static readonly BigInteger[] Value={ 1L,1L,4L,37L,600L,15229L,554868L,27444786L,1770376080L,144306428161L,14507072762052L,1762845211827574L,254794661274061848L,BigInteger.Parse("43191427238728121445"),BigInteger.Parse("8488249087135630544628"),BigInteger.Parse("1914196040519793284483542"),BigInteger.Parse("491024013925643339847990144"),BigInteger.Parse("142153433027873627036756565313") };
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
public class A249607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249607Inst Instance=new A249607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249608
{
public static readonly long[] Value={ 1L,1L,7L,19L,115L,451L,2521L,11677L,63379L,318115L,1716517L,8981017L,48623389L,260410333L,1418640055L,7707719299L,42263782099L,231857347603L,1278917211061L,7065478018585L,39174182961865L,217591443710905L,1211736702238795L,6759723716824855L,37785032547293245L,211540175726995501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249608Inst : IEnumerable<long>
{
public static readonly long[] Value=A249608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249608.Bytes);
public long this[int i]=>Value[i];

public static A249608Inst Instance=new A249608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249609
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,1L,0L,0L,1L,1L,3L,1L,2L,7L,1L,2L,1L,1L,3L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,4L,5L,1L,1L,3L,1L,3L,2L,1L,1L,3L,4L,1L,2L,1L,1L,6L,1L,2L,6L,1L,2L,1L,1L,3L,3L,1L,1L,2L,1L,2L,6L,1L,2L,1L,1L,3L,1L,3L,2L,1L,1L,2L,2L,1L,9L,1L,1L,2L,1L,4L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249609Inst : IEnumerable<long>
{
public static readonly long[] Value=A249609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249609.Bytes);
public long this[int i]=>Value[i];

public static A249609Inst Instance=new A249609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249610
{
public static readonly long[] Value={ 585691L,1248103L,4713493L,5799691L,13766521L,15939631L,23805073L,42023263L,46526581L,80435161L,102284443L,127770301L,157172671L,179088331L,215640301L,287060731L,519072451L,591998821L,617744731L,788035711L,951796141L,987056419L,1433977333L,1998789031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249610Inst : IEnumerable<long>
{
public static readonly long[] Value=A249610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249610.Bytes);
public long this[int i]=>Value[i];

public static A249610Inst Instance=new A249610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249611
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,18L,22L,23L,24L,27L,28L,29L,30L,34L,37L,38L,39L,40L,51L,55L,56L,59L,60L,65L,66L,70L,71L,72L,75L,78L,83L,84L,85L,86L,87L,89L,90L,94L,95L,107L,108L,109L,110L,111L,113L,114L,117L,118L,120L,123L,124L,131L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249611Inst : IEnumerable<long>
{
public static readonly long[] Value=A249611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249611.Bytes);
public long this[int i]=>Value[i];

public static A249611Inst Instance=new A249611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249612
{
public static readonly long[] Value={ 16L,19L,20L,21L,25L,26L,31L,32L,33L,35L,36L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,54L,57L,58L,61L,62L,63L,64L,67L,68L,69L,73L,74L,76L,77L,79L,80L,82L,88L,91L,92L,93L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,112L,115L,116L,119L,122L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249612Inst : IEnumerable<long>
{
public static readonly long[] Value=A249612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249612.Bytes);
public long this[int i]=>Value[i];

public static A249612Inst Instance=new A249612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249613
{
public static readonly long[] Value={ 81L,106L,121L,133L,148L,160L,162L,170L,189L,211L,212L,214L,237L,297L,301L,313L,314L,320L,340L,352L,361L,378L,381L,394L,409L,410L,428L,438L,442L,474L,502L,512L,535L,583L,605L,609L,621L,627L,645L,647L,648L,657L,680L,691L,692L,704L,709L,710L,717L,736L,742L,748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249613Inst : IEnumerable<long>
{
public static readonly long[] Value=A249613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249613.Bytes);
public long this[int i]=>Value[i];

public static A249613Inst Instance=new A249613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249614
{
public static readonly long[] Value={ 22521L,28927L,28928L,29109L,29127L,30026L,30032L,35161L,35517L,38833L,38834L,39751L,40192L,40369L,42997L,47353L,47354L,47360L,49341L,56931L,58111L,58112L,62961L,65792L,65919L,72303L,74389L,75345L,79107L,83727L,85024L,87513L,87871L,90368L,90447L,92637L,95235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249614Inst : IEnumerable<long>
{
public static readonly long[] Value=A249614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249614.Bytes);
public long this[int i]=>Value[i];

public static A249614Inst Instance=new A249614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249615
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L,1L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249615Inst : IEnumerable<long>
{
public static readonly long[] Value=A249615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249615.Bytes);
public long this[int i]=>Value[i];

public static A249615Inst Instance=new A249615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249616
{
public static readonly long[] Value={ 0L,2L,2L,2L,3L,2L,4L,2L,4L,3L,2L,4L,3L,3L,4L,2L,4L,4L,4L,5L,2L,4L,4L,4L,5L,3L,5L,2L,4L,4L,4L,5L,3L,5L,3L,5L,4L,2L,4L,4L,4L,5L,3L,5L,3L,5L,4L,3L,5L,4L,4L,5L,2L,4L,4L,4L,5L,4L,6L,4L,6L,5L,4L,6L,5L,5L,6L,2L,4L,4L,4L,5L,4L,6L,4L,6L,5L,4L,6L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249616Inst : IEnumerable<long>
{
public static readonly long[] Value=A249616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249616.Bytes);
public long this[int i]=>Value[i];

public static A249616Inst Instance=new A249616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249617
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,1L,3L,2L,1L,3L,2L,2L,4L,1L,3L,3L,3L,5L,1L,3L,3L,3L,5L,2L,5L,1L,3L,3L,3L,5L,2L,5L,2L,5L,4L,1L,3L,3L,3L,5L,2L,5L,2L,5L,4L,2L,5L,4L,4L,6L,1L,3L,3L,3L,5L,3L,7L,3L,7L,5L,3L,7L,5L,5L,8L,1L,3L,3L,3L,5L,3L,7L,3L,7L,5L,3L,7L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249617Inst : IEnumerable<long>
{
public static readonly long[] Value=A249617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249617.Bytes);
public long this[int i]=>Value[i];

public static A249617Inst Instance=new A249617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249618
{
public static readonly long[] Value={ 0L,1L,3L,4L,4L,2L,10L,11L,13L,14L,14L,12L,13L,14L,7L,9L,8L,14L,14L,12L,9L,5L,14L,6L,37L,38L,40L,41L,41L,39L,47L,48L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249618Inst : IEnumerable<long>
{
public static readonly long[] Value=A249618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249618.Bytes);
public long this[int i]=>Value[i];

public static A249618Inst Instance=new A249618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249619
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,3L,1L,24L,12L,4L,6L,1L,120L,60L,20L,30L,5L,10L,1L,720L,360L,120L,180L,30L,60L,6L,90L,15L,20L,1L,5040L,2520L,840L,1260L,210L,420L,42L,630L,105L,140L,7L,210L,21L,35L,1L,40320L,20160L,6720L,10080L,1680L,3360L,336L,5040L,840L,1120L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249619Inst : IEnumerable<long>
{
public static readonly long[] Value=A249619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249619.Bytes);
public long this[int i]=>Value[i];

public static A249619Inst Instance=new A249619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249620
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,4L,3L,15L,11L,7L,9L,5L,52L,36L,21L,26L,12L,16L,7L,203L,135L,74L,92L,38L,52L,19L,66L,29L,31L,11L,877L,566L,296L,371L,141L,198L,64L,249L,98L,109L,30L,137L,47L,57L,15L,4140L,2610L,1315L,1663L,592L,850L,250L,1075L,392L,444L,105L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249620Inst : IEnumerable<long>
{
public static readonly long[] Value=A249620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249620.Bytes);
public long this[int i]=>Value[i];

public static A249620Inst Instance=new A249620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249621
{
public static readonly BigInteger[] Value={ 81390384100L,1406394753724900L,BigInteger.Parse("35835016467147821056"),BigInteger.Parse("40988174007950912656"),BigInteger.Parse("50380850763055363600"),BigInteger.Parse("4792217024781750114460900"),BigInteger.Parse("284966691269408660851864225156"),BigInteger.Parse("14530422026948661087028976772730756"),BigInteger.Parse("30683674238436575795584244321722756") };
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
public class A249621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249621Inst Instance=new A249621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249622
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,1L,3L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,4L,1L,1L,1L,3L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,2L,1L,2L,1L,1L,6L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249622Inst : IEnumerable<long>
{
public static readonly long[] Value=A249622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249622.Bytes);
public long this[int i]=>Value[i];

public static A249622Inst Instance=new A249622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249623
{
public static readonly long[] Value={ 2L,3L,4L,15L,8L,7L,0L,347L,0L,11L,3682L,17L,0L,23L,0L,17L,26L,313L,30L,47L,400L,53L,1428L,0L,0L,77L,214L,195L,3820L,709L,270L,0L,956L,0L,0L,65L,396L,905L,0L,737L,0L,73L,0L,0L,1712L,0L,0L,0L,0L,0L,0L,167L,0L,383L,0L,0L,110L,0L,100L,0L,0L,3435L,2806L,0L,92L,1729L,84L,0L,0L,0L,122L,173L,3792L,0L,514L,0L,0L,163L,0L,101L,0L,195L,438L,277L,0L,369L,6392L,0L,294L,0L,0L,0L,122L,137L,6326L,0L,0L,0L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249623Inst : IEnumerable<long>
{
public static readonly long[] Value=A249623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249623.Bytes);
public long this[int i]=>Value[i];

public static A249623Inst Instance=new A249623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249624
{
public static readonly long[] Value={ 0L,1L,2L,6L,8L,14L,18L,20L,24L,30L,34L,36L,38L,48L,50L,54L,64L,68L,78L,80L,84L,94L,96L,98L,104L,110L,114L,124L,132L,134L,138L,144L,154L,156L,164L,174L,182L,188L,198L,208L,210L,216L,220L,228L,230L,248L,252L,258L,260L,270L,284L,294L,300L,306L,308L,314L,322L,328L,330L,336L,344L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249624Inst : IEnumerable<long>
{
public static readonly long[] Value=A249624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249624.Bytes);
public long this[int i]=>Value[i];

public static A249624Inst Instance=new A249624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249625
{
public static readonly long[] Value={ 24001L,95881L,205633L,2266177L,3792673L,3850393L,6846241L,7448641L,15498121L,21566497L,25267681L,28987681L,48114841L,57207697L,69805261L,79176001L,90257521L,110360641L,121223761L,129642001L,139752001L,164655793L,166175461L,185983981L,211268881L,264159601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249625Inst : IEnumerable<long>
{
public static readonly long[] Value=A249625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249625.Bytes);
public long this[int i]=>Value[i];

public static A249625Inst Instance=new A249625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249626
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,29L,30L,34L,35L,36L,37L,38L,39L,40L,45L,46L,47L,48L,49L,50L,56L,57L,58L,59L,60L,67L,68L,69L,70L,78L,79L,80L,89L,90L,100L,21L,31L,41L,51L,61L,71L,81L,91L,22L,32L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249626Inst : IEnumerable<long>
{
public static readonly long[] Value=A249626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249626.Bytes);
public long this[int i]=>Value[i];

public static A249626Inst Instance=new A249626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249627
{
public static readonly BigInteger[] Value={ 121L,111L,1111L,11111L,111L,1111111L,1507L,1001001L,100001L,11111111111L,29703L,14064697609L,10000001L,8718483L,64705883L,11111111111111111L,1001001L,BigInteger.Parse("1234567901234567900987654320987654321"),307571L,32516067L,5645629L,BigInteger.Parse("123456790123456790123454320987654320987654321") };
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
public class A249627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249627Inst Instance=new A249627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249628
{
public static readonly long[] Value={ 8L,10L,12L,16L,18L,22L,24L,30L,34L,36L,42L,46L,48L,54L,60L,64L,66L,72L,76L,78L,84L,90L,102L,106L,108L,112L,114L,120L,126L,132L,138L,142L,144L,150L,154L,156L,162L,168L,174L,180L,184L,186L,192L,196L,198L,202L,204L,210L,216L,222L,228L,232L,234L,240L,244L,246L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249628Inst : IEnumerable<long>
{
public static readonly long[] Value=A249628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249628.Bytes);
public long this[int i]=>Value[i];

public static A249628Inst Instance=new A249628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249629
{
public static readonly long[] Value={ 0L,0L,4L,28L,124L,532L,2164L,8788L,35284L,141628L,567004L,2269948L,9081724L,36334492L,145345564L,581412508L,2325680284L,9302841652L,37211487124L,148846430068L,595386201844L,2381546731732L,9526188851284L,38104763100628L,152419060098004L,609676271166388L,2438705115439924L,9754820584849588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249629Inst : IEnumerable<long>
{
public static readonly long[] Value=A249629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249629.Bytes);
public long this[int i]=>Value[i];

public static A249629Inst Instance=new A249629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249630
{
public static readonly long[] Value={ 0L,4L,6L,12L,18L,27L,30L,42L,45L,60L,63L,72L,102L,108L,117L,130L,135L,138L,150L,170L,180L,192L,198L,207L,228L,240L,243L,250L,270L,280L,282L,297L,312L,315L,320L,333L,348L,380L,387L,420L,430L,432L,462L,495L,522L,570L,585L,600L,618L,642L,651L,660L,670L,675L,693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249630Inst : IEnumerable<long>
{
public static readonly long[] Value=A249630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249630.Bytes);
public long this[int i]=>Value[i];

public static A249630Inst Instance=new A249630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249631
{
public static readonly long[] Value={ 2L,2L,6L,2L,12L,24L,2L,20L,72L,120L,2L,34L,180L,480L,720L,2L,56L,428L,1632L,3600L,5040L,2L,88L,1042L,5124L,15600L,30240L,40320L,2L,136L,2512L,15860L,61872L,159840L,282240L,362880L,2L,208L,5912L,50186L,236388L,773040L,1764000L,2903040L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249631Inst : IEnumerable<long>
{
public static readonly long[] Value=A249631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249631.Bytes);
public long this[int i]=>Value[i];

public static A249631Inst Instance=new A249631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249632
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,9L,9L,3L,16L,64L,96L,64L,16L,125L,625L,1250L,1250L,625L,125L,1296L,7776L,19440L,25920L,19440L,7776L,1296L,16807L,117649L,352947L,588245L,588245L,352947L,117649L,16807L,262144L,2097152L,7340032L,14680064L,18350080L,14680064L,7340032L,2097152L,262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249632Inst : IEnumerable<long>
{
public static readonly long[] Value=A249632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249632.Bytes);
public long this[int i]=>Value[i];

public static A249632Inst Instance=new A249632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249633
{
public static readonly BigInteger[] Value={ 285290L,37501930L,5986235584L,6402200716L,7097946940L,2189113296470L,533822715205534L,120542200191255266L,175167560462651234L,BigInteger.Parse("1035777761966641262300"),BigInteger.Parse("55811056504696202088334"),BigInteger.Parse("87383897508158263975600"),BigInteger.Parse("342433449090893699643070"),BigInteger.Parse("356558269841736892522930") };
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
public class A249633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249633Inst Instance=new A249633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249634
{
public static readonly long[] Value={ 0L,1L,2L,25L,6L,14L,32L,54L,30L,11L,84L,39L,140L,75L,176L,102L,198L,19L,220L,147L,110L,69L,384L,175L,416L,486L,420L,58L,570L,279L,544L,429L,306L,245L,684L,296L,380L,663L,880L,615L,1134L,258L,1012L,1035L,1104L,47L,1392L,539L,1500L,1071L,1508L,53L,2106L,935L,1736L,1311L,1798L,413L,2940L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249634Inst : IEnumerable<long>
{
public static readonly long[] Value=A249634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249634.Bytes);
public long this[int i]=>Value[i];

public static A249634Inst Instance=new A249634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249635
{
public static readonly long[] Value={ 7L,40L,41L,96L,664L,6095L,8419L,11471L,13690L,38835L,49832L,97152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249635Inst : IEnumerable<long>
{
public static readonly long[] Value=A249635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249635.Bytes);
public long this[int i]=>Value[i];

public static A249635Inst Instance=new A249635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249636
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,33L,186L,1213L,8949L,73300L,657589L,6396829L,66936872L,748528619L,8896663389L,111873459298L,1482522176651L,20633389026901L,300705290677218L,4576892504775417L,72584518271451169L,1196883163316172252L,BigInteger.Parse("20482129284796798609"),BigInteger.Parse("363138667441109774065"),BigInteger.Parse("6659922487212111452776") };
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
public class A249636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249636Inst Instance=new A249636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249637
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,36L,252L,2278L,25479L,343318L,5455963L,100504720L,2117265242L,50438185262L,1345840435641L,39899564488618L,1305139816260887L,46817884128344164L,1831903983379048308L,BigInteger.Parse("77815287718736660334"),BigInteger.Parse("3573159363560866942735"),BigInteger.Parse("176687138080525842904446"),BigInteger.Parse("9376097634171921557906827") };
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
public class A249637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249637Inst Instance=new A249637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249638
{
public static readonly long[] Value={ 0L,0L,5L,45L,245L,1305L,6605L,33405L,167405L,838845L,4196045L,20989245L,104955245L,524820945L,2624149445L,13120970445L,65605075445L,328026491505L,1640133571805L,8200673428605L,41003372712605L,205016891401905L,1025084484848405L,5125422563427405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249638Inst : IEnumerable<long>
{
public static readonly long[] Value=A249638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249638.Bytes);
public long this[int i]=>Value[i];

public static A249638Inst Instance=new A249638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249639
{
public static readonly long[] Value={ 0L,0L,6L,66L,426L,2706L,16386L,99186L,595986L,3580986L,21490986L,128976186L,773887386L,4643505066L,27861211146L,167168350506L,1003011186666L,6018073616706L,36108448196946L,216650728156866L,1299904407916386L,7799426681319186L,46796560321735986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249639Inst : IEnumerable<long>
{
public static readonly long[] Value=A249639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249639.Bytes);
public long this[int i]=>Value[i];

public static A249639Inst Instance=new A249639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249640
{
public static readonly long[] Value={ 0L,0L,7L,91L,679L,5005L,35287L,248731L,1742839L,12211675L,85493527L,598537051L,4189841719L,29329466845L,205306842727L,1437151921051L,10060067469319L,70420500427165L,492943531132087L,3450604914906331L,24154234601326039L,169079643588071965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249640Inst : IEnumerable<long>
{
public static readonly long[] Value=A249640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249640.Bytes);
public long this[int i]=>Value[i];

public static A249640Inst Instance=new A249640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249641
{
public static readonly long[] Value={ 0L,0L,8L,120L,1016L,8520L,68552L,551496L,4415048L,35344632L,282781304L,2262444024L,18099745784L,144799511928L,1158397641080L,9267193490808L,74137560288632L,593100581182152L,4744804748330312L,37958438777603016L,303667511011784648L,2429340094421767752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249641Inst : IEnumerable<long>
{
public static readonly long[] Value=A249641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249641.Bytes);
public long this[int i]=>Value[i];

public static A249641Inst Instance=new A249641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249642
{
public static readonly BigInteger[] Value={ 0L,0L,9L,153L,1449L,13617L,123129L,1113273L,10024569L,90266553L,812444409L,7312407993L,65812080249L,592312391937L,5330815197129L,47977369796313L,431796361188969L,3886167547854657L,34975508227845849L,314779576724952633L,2833016193198913689L,BigInteger.Parse("25497145762858874817") };
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
public class A249642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249642Inst Instance=new A249642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249643
{
public static readonly BigInteger[] Value={ 0L,0L,10L,190L,1990L,20710L,207910L,2087110L,20879110L,208870390L,2088783190L,20888623990L,208887031990L,2088878232790L,20888790240790L,208887981528790L,2088879894408790L,20888799735217510L,208887998143304710L,2088879989344263910L,BigInteger.Parse("20888799901353855910") };
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
public class A249643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249643Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249643.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249643Inst Instance=new A249643Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249644
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,29L,37L,43L,47L,59L,67L,71L,79L,89L,97L,107L,109L,127L,137L,139L,167L,181L,191L,197L,199L,211L,223L,227L,229L,251L,263L,283L,311L,331L,337L,347L,353L,389L,409L,439L,443L,449L,457L,461L,463L,467L,503L,521L,557L,587L,599L,601L,617L,619L,631L,641L,677L,683L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249644Inst : IEnumerable<long>
{
public static readonly long[] Value=A249644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249644.Bytes);
public long this[int i]=>Value[i];

public static A249644Inst Instance=new A249644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249645
{
public static readonly BigInteger[] Value={ 1L,11L,15619L,2943155L,1331492839973L,1630880903184421L,BigInteger.Parse("31439787218843145032971"),BigInteger.Parse("1077761962140496544395985052611"),BigInteger.Parse("413553884506370765259209008566673121899"),BigInteger.Parse("88544903809570893686211499586310192741581300347") };
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
public class A249645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249645Inst Instance=new A249645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249646
{
public static readonly BigInteger[] Value={ 2L,20L,27720L,5173168L,2329089562800L,2844937529085600L,BigInteger.Parse("54749786241679275146400"),BigInteger.Parse("1874681189225708508850515710400"),BigInteger.Parse("718766754945489455304472257065075294400"),BigInteger.Parse("153803387341307877636928566091115101174034840640") };
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
public class A249646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249646Inst Instance=new A249646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249647
{
public static readonly long[] Value={ 1L,3L,9L,11L,33L,99L,111L,333L,999L,1111L,3333L,9999L,11111L,33333L,99999L,111111L,142857L,333333L,999999L,1111111L,3333333L,9999999L,11111111L,33333333L,99999999L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249647Inst : IEnumerable<long>
{
public static readonly long[] Value=A249647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249647.Bytes);
public long this[int i]=>Value[i];

public static A249647Inst Instance=new A249647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249648
{
public static readonly long[] Value={ 0L,10L,19L,27L,34L,40L,45L,49L,52L,54L,55L,72L,80L,87L,93L,98L,102L,105L,107L,108L,109L,118L,126L,133L,139L,144L,148L,151L,153L,154L,176L,183L,189L,194L,198L,201L,203L,204L,205L,213L,221L,222L,229L,235L,240L,244L,247L,249L,257L,276L,282L,287L,291L,294L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249648Inst : IEnumerable<long>
{
public static readonly long[] Value=A249648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249648.Bytes);
public long this[int i]=>Value[i];

public static A249648Inst Instance=new A249648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249649
{
public static readonly long[] Value={ 5L,5L,7L,1L,2L,2L,8L,3L,6L,3L,1L,1L,3L,6L,7L,8L,4L,8L,9L,2L,7L,3L,2L,2L,9L,9L,4L,8L,6L,5L,4L,2L,4L,8L,0L,1L,5L,4L,6L,0L,3L,6L,3L,9L,1L,1L,3L,3L,7L,0L,0L,4L,4L,4L,0L,5L,6L,7L,1L,3L,3L,2L,5L,9L,7L,1L,8L,3L,0L,7L,3L,5L,3L,8L,3L,1L,1L,2L,2L,1L,6L,3L,5L,2L,8L,2L,6L,9L,7L,2L,9L,8L,9L,5L,7L,6L,5L,5L,2L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249649Inst : IEnumerable<long>
{
public static readonly long[] Value=A249649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249649.Bytes);
public long this[int i]=>Value[i];

public static A249649Inst Instance=new A249649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249650
{
public static readonly long[] Value={ 0L,3L,4L,11L,14L,76L,911L,2218L,2654L,22527L,134917L,352490L,448005L,706886L,886953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249650Inst : IEnumerable<long>
{
public static readonly long[] Value=A249650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249650.Bytes);
public long this[int i]=>Value[i];

public static A249650Inst Instance=new A249650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249651
{
public static readonly long[] Value={ 6L,0L,7L,7L,1L,2L,3L,3L,7L,9L,4L,3L,0L,1L,5L,4L,6L,4L,2L,4L,6L,2L,2L,6L,2L,6L,2L,0L,1L,5L,0L,6L,9L,4L,1L,5L,4L,3L,9L,0L,3L,2L,4L,0L,8L,0L,2L,1L,2L,2L,4L,8L,6L,6L,5L,6L,7L,2L,3L,7L,8L,5L,8L,5L,0L,2L,9L,3L,3L,7L,7L,6L,5L,1L,5L,7L,6L,8L,0L,0L,7L,9L,7L,9L,1L,9L,2L,7L,9L,4L,1L,7L,7L,3L,9L,1L,3L,4L,9L,8L,8L,9L,6L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249651Inst : IEnumerable<long>
{
public static readonly long[] Value=A249651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249651.Bytes);
public long this[int i]=>Value[i];

public static A249651Inst Instance=new A249651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249652
{
public static readonly long[] Value={ 4L,2L,7L,7L,1L,4L,7L,8L,4L,2L,9L,0L,8L,2L,4L,0L,8L,8L,1L,1L,2L,8L,3L,8L,9L,7L,1L,6L,1L,2L,7L,9L,4L,5L,3L,2L,4L,2L,8L,6L,0L,2L,4L,7L,8L,7L,7L,4L,6L,9L,5L,7L,4L,4L,5L,5L,4L,9L,2L,9L,8L,3L,5L,2L,4L,1L,6L,1L,6L,5L,8L,8L,1L,5L,1L,6L,7L,4L,1L,4L,3L,2L,0L,4L,6L,5L,6L,6L,8L,1L,9L,8L,6L,3L,4L,5L,4L,2L,1L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249652Inst : IEnumerable<long>
{
public static readonly long[] Value=A249652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249652.Bytes);
public long this[int i]=>Value[i];

public static A249652Inst Instance=new A249652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249653
{
public static readonly long[] Value={ 1046L,1218L,1408L,1620L,1858L,2126L,2590L,3132L,3764L,4498L,5346L,6778L,8510L,10594L,13082L,16026L,20906L,26980L,34468L,43590L,54566L,72558L,95404L,124036L,159386L,202386L,272426L,362494L,476538L,618506L,792346L,1074554L,1440204L,1906020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249653Inst : IEnumerable<long>
{
public static readonly long[] Value=A249653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249653.Bytes);
public long this[int i]=>Value[i];

public static A249653Inst Instance=new A249653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249654
{
public static readonly long[] Value={ 2077L,2589L,3221L,3981L,4877L,5917L,7709L,9957L,12707L,16005L,19897L,26589L,35003L,45331L,57773L,72537L,98073L,130311L,169993L,217901L,274857L,373909L,499355L,654105L,841221L,1063917L,1452913L,1946663L,2556733L,3295241L,4174857L,5716733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249654Inst : IEnumerable<long>
{
public static readonly long[] Value=A249654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249654.Bytes);
public long this[int i]=>Value[i];

public static A249654Inst Instance=new A249654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249655
{
public static readonly long[] Value={ 3708L,4944L,6678L,9026L,12108L,16048L,23048L,33102L,47170L,66232L,91288L,137656L,205348L,301356L,432832L,607088L,940560L,1433518L,2138642L,3109400L,4400108L,6919536L,10669870L,16059534L,23500428L,33408288L,52962568L,82175864L,124260856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249655Inst : IEnumerable<long>
{
public static readonly long[] Value=A249655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249655.Bytes);
public long this[int i]=>Value[i];

public static A249655Inst Instance=new A249655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249656
{
public static readonly long[] Value={ 2L,53L,2L,164L,53L,2L,485L,164L,53L,2L,1046L,485L,164L,53L,2L,2077L,1218L,485L,164L,53L,2L,3708L,2589L,1408L,485L,164L,53L,2L,6149L,4944L,3221L,1620L,485L,164L,53L,2L,9610L,8605L,6678L,3981L,1858L,485L,164L,53L,2L,14441L,13814L,12377L,9026L,4877L,2126L,485L,164L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249656Inst : IEnumerable<long>
{
public static readonly long[] Value=A249656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249656.Bytes);
public long this[int i]=>Value[i];

public static A249656Inst Instance=new A249656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249657
{
public static readonly long[] Value={ 2L,53L,164L,485L,1046L,2077L,3708L,6149L,9610L,14441L,20832L,29173L,39794L,53105L,69476L,89417L,113318L,141769L,175260L,214361L,259642L,311813L,371424L,439225L,515906L,602237L,698948L,806909L,926870L,1059781L,1206492L,1367933L,1545034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249657Inst : IEnumerable<long>
{
public static readonly long[] Value=A249657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249657.Bytes);
public long this[int i]=>Value[i];

public static A249657Inst Instance=new A249657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249658
{
public static readonly long[] Value={ 2L,53L,164L,485L,1218L,2589L,4944L,8605L,13814L,21789L,32332L,46097L,63726L,85773L,114604L,149773L,191878L,241869L,300548L,371753L,454178L,548821L,656856L,779409L,922630L,1083277L,1262944L,1462789L,1684282L,1935745L,2212864L,2516841L,2849582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249658Inst : IEnumerable<long>
{
public static readonly long[] Value=A249658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249658.Bytes);
public long this[int i]=>Value[i];

public static A249658Inst Instance=new A249658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249659
{
public static readonly long[] Value={ 2L,53L,164L,485L,1408L,3221L,6678L,12377L,20572L,33877L,51568L,74947L,105310L,143727L,195754L,259799L,336688L,428339L,536286L,671719L,828944L,1009781L,1216838L,1452459L,1732578L,2047055L,2399248L,2791887L,3227102L,3727571L,4279592L,4886643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249659Inst : IEnumerable<long>
{
public static readonly long[] Value=A249659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249659.Bytes);
public long this[int i]=>Value[i];

public static A249659Inst Instance=new A249659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249660
{
public static readonly long[] Value={ 2L,53L,164L,485L,1620L,3981L,9026L,18009L,31276L,53643L,83648L,124019L,177426L,246495L,341802L,460879L,604888L,778121L,983998L,1248361L,1556940L,1913895L,2325318L,2796619L,3361158L,3997715L,4713400L,5516083L,6407962L,7439621L,8580604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249660Inst : IEnumerable<long>
{
public static readonly long[] Value=A249660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249660.Bytes);
public long this[int i]=>Value[i];

public static A249660Inst Instance=new A249660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249661
{
public static readonly long[] Value={ 2L,53L,164L,485L,1858L,4877L,12108L,26269L,48120L,85863L,137008L,207153L,301826L,428059L,603620L,827265L,1100658L,1433863L,1835248L,2358199L,2972906L,3690145L,4524776L,5489583L,6646490L,7959243L,9443456L,11122729L,12996902L,15168183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249661Inst : IEnumerable<long>
{
public static readonly long[] Value=A249661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249661.Bytes);
public long this[int i]=>Value[i];

public static A249661Inst Instance=new A249661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249662
{
public static readonly long[] Value={ 2L,53L,164L,485L,2126L,5917L,16048L,38149L,74540L,138277L,225550L,347407L,515094L,747495L,1070778L,1491711L,2013094L,2658997L,3450970L,4490477L,5722276L,7174557L,8884696L,10883133L,13271770L,16002033L,19110766L,22665877L,26659154L,31279765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249662Inst : IEnumerable<long>
{
public static readonly long[] Value=A249662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249662.Bytes);
public long this[int i]=>Value[i];

public static A249662Inst Instance=new A249662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249663
{
public static readonly long[] Value={ 2L,53L,164L,485L,2590L,7709L,23048L,58981L,118234L,229677L,383820L,602267L,905604L,1335037L,1951402L,2768703L,3790164L,5063335L,6638626L,8766367L,11301260L,14309507L,17870666L,22057917L,27136820L,32971357L,39630644L,47296045L,55935830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249663Inst : IEnumerable<long>
{
public static readonly long[] Value=A249663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249663.Bytes);
public long this[int i]=>Value[i];

public static A249663Inst Instance=new A249663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249664
{
public static readonly long[] Value={ 1L,3L,7L,9L,27L,33L,65L,255L,511L,585L,1025L,3591L,4617L,13611L,32639L,34401L,109675L,147441L,264833L,923271L,1183241L,3620667L,7178459L,11295285L,25104893L,57717819L,102148931L,168533253L,403441155L,712644501L,1221813641L,4029305871L,8397439583L,9813933129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249664Inst : IEnumerable<long>
{
public static readonly long[] Value=A249664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249664.Bytes);
public long this[int i]=>Value[i];

public static A249664Inst Instance=new A249664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249665
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,14L,28L,56L,118L,254L,541L,1140L,2401L,5074L,10738L,22711L,48001L,101447L,214446L,453355L,958395L,2025963L,4282685L,9053286L,19138115L,40456779L,85522862L,180789396L,382176531L,807895636L,1707837203L,3610252689L,7631830480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249665Inst : IEnumerable<long>
{
public static readonly long[] Value=A249665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249665.Bytes);
public long this[int i]=>Value[i];

public static A249665Inst Instance=new A249665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249666
{
public static readonly long[] Value={ 3L,4L,6L,10L,12L,16L,22L,24L,30L,36L,42L,46L,50L,54L,56L,66L,70L,76L,78L,84L,90L,92L,100L,114L,116L,120L,126L,130L,132L,142L,144L,156L,160L,170L,174L,176L,180L,186L,192L,196L,202L,210L,220L,222L,226L,232L,234L,240L,246L,250L,252L,276L,280L,282L,286L,288L,294L,300L,306L,310L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249666Inst : IEnumerable<long>
{
public static readonly long[] Value=A249666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249666.Bytes);
public long this[int i]=>Value[i];

public static A249666Inst Instance=new A249666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249667
{
public static readonly long[] Value={ 6L,24L,30L,36L,50L,54L,78L,84L,114L,132L,144L,156L,174L,210L,220L,252L,294L,300L,306L,330L,360L,378L,474L,492L,510L,512L,528L,546L,560L,594L,610L,650L,660L,690L,714L,720L,762L,780L,800L,804L,810L,816L,870L,912L,996L,1002L,1068L,1074L,1104L,1120L,1170L,1176L,1190L,1210L,1236L,1262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249667Inst : IEnumerable<long>
{
public static readonly long[] Value=A249667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249667.Bytes);
public long this[int i]=>Value[i];

public static A249667Inst Instance=new A249667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249668
{
public static readonly long[] Value={ 3L,4L,7L,10L,15L,20L,25L,30L,38L,47L,55L,63L,69L,79L,91L,96L,105L,112L,124L,134L,139L,144L,152L,157L,163L,168L,176L,183L,187L,195L,205L,217L,223L,229L,239L,247L,259L,273L,285L,289L,295L,303L,311L,323L,334L,339L,343L,351L,363L,375L,383L,389L,397L,405L,413L,423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249668Inst : IEnumerable<long>
{
public static readonly long[] Value=A249668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249668.Bytes);
public long this[int i]=>Value[i];

public static A249668Inst Instance=new A249668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249669
{
public static readonly long[] Value={ 4L,5L,8L,11L,17L,19L,25L,27L,32L,40L,42L,49L,54L,56L,60L,67L,74L,76L,83L,87L,89L,96L,100L,107L,116L,120L,122L,126L,128L,132L,148L,152L,159L,160L,171L,173L,179L,186L,190L,196L,203L,204L,215L,217L,221L,223L,236L,249L,253L,255L,259L,265L,267L,278L,284L,290L,296L,298L,304L,308L,310L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249669Inst : IEnumerable<long>
{
public static readonly long[] Value=A249669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249669.Bytes);
public long this[int i]=>Value[i];

public static A249669Inst Instance=new A249669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249670
{
public static readonly long[] Value={ 1L,6L,12L,28L,30L,2L,56L,120L,117L,45L,132L,21L,182L,84L,40L,496L,306L,78L,380L,210L,672L,198L,552L,10L,775L,273L,1080L,2L,870L,60L,992L,2016L,176L,459L,1680L,3276L,1406L,570L,2184L,36L,1722L,112L,1892L,231L,390L,828L,2256L,372L,2793L,4650L,408L,1274L,2862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249670Inst : IEnumerable<long>
{
public static readonly long[] Value=A249670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249670.Bytes);
public long this[int i]=>Value[i];

public static A249670Inst Instance=new A249670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249671
{
public static readonly long[] Value={ 1L,364L,86800L,90768L,149856L,632400L,828816L,46462800L,61987600L,148468320L,153972000L,185684160L,187465824L,189300384L,191659104L,193808160L,196219296L,202460352L,204118464L,215399520L,220116960L,221931360L,222778080L,223382880L,228584160L,338116680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249671Inst : IEnumerable<long>
{
public static readonly long[] Value=A249671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249671.Bytes);
public long this[int i]=>Value[i];

public static A249671Inst Instance=new A249671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249672
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,6L,55L,826L,20839L,925470L,76332845L,12144225666L,3786386476697L,2323365229270526L,2810644438909846175L,BigInteger.Parse("6714880936575265290018"),BigInteger.Parse("31734660733696955320333111"),BigInteger.Parse("297106568811291486526250342118"),BigInteger.Parse("5516820501917771489801597101682245") };
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
public class A249672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249672Inst Instance=new A249672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249673
{
public static readonly long[] Value={ 2L,1L,1L,6L,4L,6L,5L,5L,3L,6L,5L,0L,5L,4L,8L,4L,7L,7L,5L,8L,7L,8L,5L,7L,2L,2L,2L,7L,0L,2L,5L,8L,3L,1L,9L,8L,8L,1L,4L,8L,0L,8L,9L,3L,9L,2L,8L,0L,9L,0L,8L,2L,5L,6L,8L,2L,8L,1L,3L,4L,8L,0L,7L,8L,6L,9L,4L,2L,3L,8L,3L,0L,7L,2L,8L,9L,0L,1L,1L,7L,2L,9L,9L,6L,1L,9L,3L,4L,6L,5L,9L,2L,4L,3L,1L,0L,8L,8L,9L,4L,2L,8L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249673Inst : IEnumerable<long>
{
public static readonly long[] Value=A249673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249673.Bytes);
public long this[int i]=>Value[i];

public static A249673Inst Instance=new A249673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249674
{
public static readonly long[] Value={ 0L,30L,60L,90L,120L,150L,180L,210L,240L,270L,300L,330L,360L,390L,420L,450L,480L,510L,540L,570L,600L,630L,660L,690L,720L,750L,780L,810L,840L,870L,900L,930L,960L,990L,1020L,1050L,1080L,1110L,1140L,1170L,1200L,1230L,1260L,1290L,1320L,1350L,1380L,1410L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249674Inst : IEnumerable<long>
{
public static readonly long[] Value=A249674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249674.Bytes);
public long this[int i]=>Value[i];

public static A249674Inst Instance=new A249674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249675
{
public static readonly BigInteger[] Value={ 1L,10L,2520L,49008960L,1052427228652800L,BigInteger.Parse("18543848132205515927808000"),BigInteger.Parse("3663312848979081767807855264321333760000"),BigInteger.Parse("1860046674511129497317809046448809961990598435124736000000"),BigInteger.Parse("46250563343969315569958487234182581699417368835772148395100189090556723200000000") };
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
public class A249675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249675Inst Instance=new A249675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249676
{
public static readonly long[] Value={ 6L,30L,50L,144L,300L,560L,610L,650L,660L,714L,780L,810L,816L,870L,1120L,1176L,1190L,1806L,2130L,2470L,2490L,2550L,2922L,3030L,3240L,3330L,3390L,3480L,3600L,3620L,3840L,4266L,4368L,5796L,5850L,6270L,6786L,6954L,7074L,7710L,8280L,9400L,9990L,10146L,10350L,10380L,10530L,10660L,11064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249676Inst : IEnumerable<long>
{
public static readonly long[] Value=A249676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249676.Bytes);
public long this[int i]=>Value[i];

public static A249676Inst Instance=new A249676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249677
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,8L,1L,36L,251L,216L,1L,100L,2555L,16280L,13824L,1L,225L,15055L,335655L,2048824L,1728000L,1L,441L,63655L,3587535L,74550304L,444273984L,373248000L,1L,784L,214918L,25421200L,1305074809L,26015028256L,152759224512L,128024064000L,1L,1296L,616326L,135459216L,14320729209L,694213330464L,13472453691584L,78340747014144L,65548320768000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249677Inst : IEnumerable<long>
{
public static readonly long[] Value=A249677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249677.Bytes);
public long this[int i]=>Value[i];

public static A249677Inst Instance=new A249677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249678
{
public static readonly long[] Value={ 1L,3L,2L,75L,9L,5L,4L,17L,10L,7L,8L,91L,6L,23L,13L,83L,15L,16049L,43L,11L,16L,25L,26L,95L,12L,449L,452L,99L,14L,451L,20L,453L,1072L,31L,22L,16043L,34L,33L,56L,459L,24L,101L,18L,35L,62L,37L,102L,19L,27L,39L,28L,21L,30L,109L,42L,41L,118L,117L,120L,487L,44L,45L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249678Inst : IEnumerable<long>
{
public static readonly long[] Value=A249678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249678.Bytes);
public long this[int i]=>Value[i];

public static A249678Inst Instance=new A249678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249679
{
public static readonly long[] Value={ 0L,129L,381L,501L,639L,963L,1161L,1371L,1593L,1851L,2127L,2427L,3087L,3447L,3831L,4227L,5589L,6081L,6870L,10191L,10887L,12339L,13101L,13887L,14697L,15537L,16401L,17283L,18189L,19113L,22548L,23592L,25800L,26940L,28104L,30504L,31734L,35568L,36888L,38238L,39612L,41022L,42468L,46191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249679Inst : IEnumerable<long>
{
public static readonly long[] Value=A249679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249679.Bytes);
public long this[int i]=>Value[i];

public static A249679Inst Instance=new A249679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249680
{
public static readonly long[] Value={ 1L,5L,9L,13L,19L,23L,29L,27L,35L,41L,47L,49L,53L,55L,59L,63L,57L,69L,73L,79L,89L,91L,97L,95L,101L,103L,107L,109L,113L,117L,121L,127L,137L,139L,149L,151L,145L,155L,157L,161L,163L,167L,169L,173L,179L,181L,191L,193L,199L,209L,211L,221L,215L,223L,227L,229L,233L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249680Inst : IEnumerable<long>
{
public static readonly long[] Value=A249680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249680.Bytes);
public long this[int i]=>Value[i];

public static A249680Inst Instance=new A249680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249681
{
public static readonly long[] Value={ 2L,4L,8L,6L,10L,16L,14L,22L,12L,18L,20L,26L,28L,32L,38L,34L,44L,40L,24L,30L,36L,46L,52L,56L,50L,58L,62L,64L,68L,74L,48L,42L,54L,60L,70L,76L,82L,86L,80L,88L,92L,94L,98L,100L,104L,66L,72L,78L,84L,96L,90L,106L,112L,110L,116L,118L,122L,124L,128L,134L,136L,142L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249681Inst : IEnumerable<long>
{
public static readonly long[] Value=A249681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249681.Bytes);
public long this[int i]=>Value[i];

public static A249681Inst Instance=new A249681Inst();

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