using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A189649
{
public static readonly BigInteger[] Value={ 34L,127385L,155610272L,248034953713L,376678790309002L,579697460209171993L,BigInteger.Parse("890636373071604964608"),BigInteger.Parse("1369385680210307625221600"),BigInteger.Parse("2105439181301591456075023034"),BigInteger.Parse("3237297479202888870044365473801") };
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
public class A189649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189649Inst Instance=new A189649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189650
{
public static readonly long[] Value={ 1L,2L,1L,3L,9L,1L,5L,33L,32L,1L,8L,185L,263L,121L,1L,13L,913L,4277L,2161L,450L,1L,21L,4777L,55440L,107080L,17655L,1681L,1L,34L,24577L,799069L,3774889L,2631821L,144353L,6272L,1L,55L,127385L,11047585L,157346785L,250758892L,64890337L,1180167L,23409L,1L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189650Inst : IEnumerable<long>
{
public static readonly long[] Value=A189650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189650.Bytes);
public long this[int i]=>Value[i];

public static A189650Inst Instance=new A189650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189651
{
public static readonly long[] Value={ 1L,32L,263L,4277L,55440L,799069L,11047585L,155610272L,2174615543L,30495310793L,427003730560L,5982947971505L,83805935210153L,1174054970088496L,16446690057231391L,230398085842470229L,3227563109360717136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189651Inst : IEnumerable<long>
{
public static readonly long[] Value=A189651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189651.Bytes);
public long this[int i]=>Value[i];

public static A189651Inst Instance=new A189651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189652
{
public static readonly BigInteger[] Value={ 1L,121L,2161L,107080L,3774889L,157346785L,6156828073L,248034953713L,9875814290816L,395270625350249L,15786227589947721L,631059374453758801L,BigInteger.Parse("25216827894687641369"),BigInteger.Parse("1007823833701936877224"),BigInteger.Parse("40276106049134557246481") };
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
public class A189652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189652Inst Instance=new A189652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189653
{
public static readonly BigInteger[] Value={ 1L,450L,17655L,2631821L,250758892L,30010432933L,3292827578005L,376678790309002L,42358721253919843L,4801283687544580305L,BigInteger.Parse("542386040165423966236"),BigInteger.Parse("61365524584279523157641"),BigInteger.Parse("6938297347463763255984633") };
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
public class A189653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189653Inst Instance=new A189653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189654
{
public static readonly BigInteger[] Value={ 1L,1681L,144353L,64890337L,16718653553L,5760755884032L,1778231752192145L,579697460209171993L,BigInteger.Parse("184886869974436661041"),BigInteger.Parse("59593521044870694533545"),BigInteger.Parse("19125202990272640992094705"),BigInteger.Parse("6150485955232431794501210601") };
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
public class A189654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189654Inst Instance=new A189654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189655
{
public static readonly BigInteger[] Value={ 1L,6272L,1180167L,1598901325L,1113666564608L,1104421532180261L,958681588788944613L,BigInteger.Parse("890636373071604964608"),BigInteger.Parse("805563236027350658919747"),BigInteger.Parse("738517619493670317553084705"),BigInteger.Parse("673437704833463142294374124032") };
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
public class A189655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189655Inst Instance=new A189655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189656
{
public static readonly BigInteger[] Value={ 1L,23409L,9648721L,39401919001L,74192202677913L,211788908613601649L,BigInteger.Parse("517069529154777840681"),BigInteger.Parse("1369385680210307625221600"),BigInteger.Parse("3514075326766461571852637721"),BigInteger.Parse("9167946522672764796730050799825") };
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
public class A189656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189656Inst Instance=new A189656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189657
{
public static readonly long[] Value={ 15L,95L,15L,9L,95L,55L,15L,35L,39L,21L,95L,25L,55L,119L,511L,33L,35L,303L,39L,335L,87L,91L,95L,49L,51L,215L,55L,57L,119L,123L,511L,65L,543L,69L,143L,295L,303L,77L,159L,327L,335L,85L,87L,5759L,91L,93L,95L,391L,799L,203L,415L,54271L,215L,219L,111L,3647L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189657Inst : IEnumerable<long>
{
public static readonly long[] Value=A189657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189657.Bytes);
public long this[int i]=>Value[i];

public static A189657Inst Instance=new A189657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189658
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,10L,11L,13L,14L,18L,21L,24L,25L,26L,28L,29L,31L,32L,36L,37L,38L,40L,41L,45L,48L,51L,52L,53L,57L,60L,61L,62L,66L,69L,70L,71L,73L,74L,76L,77L,81L,82L,83L,85L,86L,90L,91L,92L,94L,95L,99L,102L,105L,106L,107L,109L,110L,112L,113L,117L,118L,119L,121L,122L,126L,129L,132L,133L,134L,138L,141L,142L,143L,147L,150L,151L,152L,154L,155L,157L,158L,162L,165L,168L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189658Inst : IEnumerable<long>
{
public static readonly long[] Value=A189658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189658.Bytes);
public long this[int i]=>Value[i];

public static A189658Inst Instance=new A189658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189659
{
public static readonly long[] Value={ 3L,6L,7L,8L,12L,15L,16L,17L,19L,20L,22L,23L,27L,30L,33L,34L,35L,39L,42L,43L,44L,46L,47L,49L,50L,54L,55L,56L,58L,59L,63L,64L,65L,67L,68L,72L,75L,78L,79L,80L,84L,87L,88L,89L,93L,96L,97L,98L,100L,101L,103L,104L,108L,111L,114L,115L,116L,120L,123L,124L,125L,127L,128L,130L,131L,135L,136L,137L,139L,140L,144L,145L,146L,148L,149L,153L,156L,159L,160L,161L,163L,164L,166L,167L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189659Inst : IEnumerable<long>
{
public static readonly long[] Value=A189659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189659.Bytes);
public long this[int i]=>Value[i];

public static A189659Inst Instance=new A189659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189740
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,15L,28L,53L,102L,196L,377L,726L,1399L,2696L,5196L,10015L,19304L,37209L,71722L,138248L,266481L,513658L,990107L,1908492L,3678736L,7090991L,13668324L,26346541L,50784590L,97890444L,188689897L,363711470L,701076399L,1351368208L,2604845972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189740Inst : IEnumerable<long>
{
public static readonly long[] Value=A189740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189740.Bytes);
public long this[int i]=>Value[i];

public static A189740Inst Instance=new A189740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189741
{
public static readonly long[] Value={ 4L,2L,16L,68L,304L,1352L,6016L,26768L,119104L,529952L,2358016L,10491968L,46683904L,207719552L,924246016L,4112423168L,18298184704L,81417585152L,362266710016L,1611902010368L,7172141461504L,31912369866752L,141993762390016L,631799789293568L,2811186681954304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189741Inst : IEnumerable<long>
{
public static readonly long[] Value=A189741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189741.Bytes);
public long this[int i]=>Value[i];

public static A189741Inst Instance=new A189741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189742
{
public static readonly long[] Value={ 4L,3L,24L,105L,492L,2283L,10608L,49281L,228948L,1063635L,4941384L,22956441L,106649916L,495468987L,2301825696L,10693709745L,49680316068L,230802393507L,1072250522232L,4981409269449L,23142388644492L,107513782386315L,499482295478736L,2320470529073889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189742Inst : IEnumerable<long>
{
public static readonly long[] Value=A189742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189742.Bytes);
public long this[int i]=>Value[i];

public static A189742Inst Instance=new A189742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189743
{
public static readonly long[] Value={ 4L,4L,32L,144L,704L,3392L,16384L,79104L,381952L,1844224L,8904704L,42995712L,207601664L,1002389504L,4839964672L,23369416704L,112837525504L,544827768832L,2630661177344L,12701955784704L,61330467848192L,296129694531584L,1429840649519104L,6903881376202752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189743Inst : IEnumerable<long>
{
public static readonly long[] Value=A189743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189743.Bytes);
public long this[int i]=>Value[i];

public static A189743Inst Instance=new A189743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189744
{
public static readonly long[] Value={ 4L,5L,40L,185L,940L,4685L,23440L,117185L,585940L,2929685L,14648440L,73242185L,366210940L,1831054685L,9155273440L,45776367185L,228881835940L,1144409179685L,5722045898440L,28610229492185L,143051147460940L,715255737304685L,3576278686523440L,17881393432617185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189744Inst : IEnumerable<long>
{
public static readonly long[] Value=A189744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189744.Bytes);
public long this[int i]=>Value[i];

public static A189744Inst Instance=new A189744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189745
{
public static readonly long[] Value={ 5L,1L,10L,51L,265L,1376L,7145L,37101L,192650L,1000351L,5194405L,26972376L,140056285L,727253801L,3776325290L,19608880251L,101820726545L,528712512976L,2745383291425L,14255628970101L,74023528141930L,384373269679751L,1995889876540685L,10363822652383176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189745Inst : IEnumerable<long>
{
public static readonly long[] Value=A189745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189745.Bytes);
public long this[int i]=>Value[i];

public static A189745Inst Instance=new A189745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189746
{
public static readonly long[] Value={ 5L,2L,20L,104L,560L,3008L,16160L,86816L,466400L,2505632L,13460960L,72316064L,388502240L,2087143328L,11212721120L,60237892256L,323614903520L,1738550302112L,9339981317600L,50177007192224L,269564998596320L,1448179007366048L,7780025034022880L,41796483184846496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189746Inst : IEnumerable<long>
{
public static readonly long[] Value=A189746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189746.Bytes);
public long this[int i]=>Value[i];

public static A189746Inst Instance=new A189746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189747
{
public static readonly long[] Value={ 5L,3L,30L,159L,885L,4902L,27165L,150531L,834150L,4622343L,25614165L,141937854L,786531765L,4358472387L,24151957230L,133835203311L,741631888245L,4109665051158L,22773220920525L,126195099756099L,699295161542070L,3875061106978647L,21473191019519445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189747Inst : IEnumerable<long>
{
public static readonly long[] Value=A189747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189747.Bytes);
public long this[int i]=>Value[i];

public static A189747Inst Instance=new A189747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189748
{
public static readonly long[] Value={ 5L,4L,40L,216L,1240L,7064L,40280L,229656L,1309400L,7465624L,42565720L,242691096L,1383718360L,7889356184L,44981654360L,256465696536L,1462255100120L,8337138286744L,47534711834200L,271022112317976L,1545249408926680L,8810335493905304L,50232675105233240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189748Inst : IEnumerable<long>
{
public static readonly long[] Value=A189748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189748.Bytes);
public long this[int i]=>Value[i];

public static A189748Inst Instance=new A189748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189749
{
public static readonly long[] Value={ 5L,5L,50L,275L,1625L,9500L,55625L,325625L,1906250L,11159375L,65328125L,382437500L,2238828125L,13106328125L,76725781250L,449160546875L,2629431640625L,15392960937500L,90111962890625L,527524619140625L,3088182910156250L,18078537646484375L,105833602783203125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189749Inst : IEnumerable<long>
{
public static readonly long[] Value=A189749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189749.Bytes);
public long this[int i]=>Value[i];

public static A189749Inst Instance=new A189749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189750
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,13L,14L,16L,18L,20L,22L,24L,26L,27L,30L,31L,33L,36L,37L,39L,41L,43L,45L,47L,49L,50L,53L,55L,56L,58L,60L,62L,63L,66L,68L,69L,72L,73L,75L,78L,79L,81L,83L,85L,87L,89L,91L,92L,95L,96L,98L,101L,102L,104L,106L,108L,110L,111L,114L,115L,117L,120L,121L,123L,125L,127L,128L,131L,133L,134L,137L,138L,140L,143L,144L,146L,148L,150L,152L,154L,156L,157L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189750Inst : IEnumerable<long>
{
public static readonly long[] Value=A189750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189750.Bytes);
public long this[int i]=>Value[i];

public static A189750Inst Instance=new A189750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189751
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,34L,40L,46L,52L,59L,65L,70L,76L,82L,88L,94L,100L,105L,112L,118L,124L,130L,136L,141L,147L,153L,159L,166L,171L,177L,183L,189L,195L,201L,206L,212L,218L,225L,231L,237L,242L,248L,254L,260L,266L,272L,278L,284L,290L,296L,302L,308L,313L,319L,325L,332L,338L,343L,349L,355L,361L,367L,373L,378L,385L,391L,397L,403L,409L,414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189751Inst : IEnumerable<long>
{
public static readonly long[] Value=A189751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189751.Bytes);
public long this[int i]=>Value[i];

public static A189751Inst Instance=new A189751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189752
{
public static readonly long[] Value={ 2L,6L,9L,12L,15L,19L,21L,25L,28L,32L,35L,38L,42L,44L,48L,51L,54L,57L,61L,64L,67L,71L,74L,77L,80L,84L,86L,90L,93L,97L,99L,103L,107L,109L,113L,116L,119L,122L,126L,129L,132L,135L,139L,142L,145L,149L,151L,155L,158L,162L,164L,168L,172L,174L,178L,181L,184L,187L,191L,194L,197L,200L,204L,207L,210L,214L,216L,220L,223L,227L,229L,233L,236L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189752Inst : IEnumerable<long>
{
public static readonly long[] Value=A189752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189752.Bytes);
public long this[int i]=>Value[i];

public static A189752Inst Instance=new A189752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189753
{
public static readonly long[] Value={ 2L,4L,6L,9L,12L,14L,17L,19L,22L,25L,27L,29L,33L,35L,37L,40L,43L,45L,48L,50L,53L,56L,58L,60L,64L,66L,68L,71L,74L,76L,78L,81L,84L,86L,89L,91L,94L,97L,99L,101L,105L,107L,109L,112L,115L,117L,120L,122L,125L,128L,130L,132L,136L,138L,140L,143L,146L,148L,150L,153L,156L,158L,161L,163L,166L,169L,171L,173L,177L,179L,181L,184L,187L,189L,192L,194L,197L,200L,202L,204L,208L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189753Inst : IEnumerable<long>
{
public static readonly long[] Value=A189753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189753.Bytes);
public long this[int i]=>Value[i];

public static A189753Inst Instance=new A189753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189754
{
public static readonly long[] Value={ 7L,15L,23L,31L,39L,47L,55L,63L,70L,79L,87L,95L,103L,111L,119L,127L,134L,142L,151L,159L,167L,175L,183L,191L,199L,206L,214L,223L,231L,239L,247L,255L,263L,270L,278L,286L,294L,303L,311L,319L,327L,335L,342L,350L,358L,366L,375L,383L,391L,399L,406L,414L,422L,430L,438L,447L,455L,463L,471L,478L,486L,494L,502L,510L,519L,527L,535L,542L,550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189754Inst : IEnumerable<long>
{
public static readonly long[] Value=A189754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189754.Bytes);
public long this[int i]=>Value[i];

public static A189754Inst Instance=new A189754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189755
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,11L,13L,16L,18L,20L,21L,24L,26L,28L,30L,32L,34L,36L,38L,41L,42L,44L,46L,49L,51L,52L,54L,57L,59L,61L,62L,65L,67L,69L,72L,73L,75L,77L,80L,82L,83L,85L,88L,90L,92L,93L,96L,98L,100L,102L,104L,106L,108L,110L,113L,114L,116L,118L,121L,123L,124L,126L,129L,131L,133L,135L,137L,139L,141L,144L,145L,147L,149L,152L,154L,155L,157L,160L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189755Inst : IEnumerable<long>
{
public static readonly long[] Value=A189755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189755.Bytes);
public long this[int i]=>Value[i];

public static A189755Inst Instance=new A189755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189820
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189820Inst : IEnumerable<long>
{
public static readonly long[] Value=A189820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189820.Bytes);
public long this[int i]=>Value[i];

public static A189820Inst Instance=new A189820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189821
{
public static readonly long[] Value={ 9L,728L,2457L,124488L,124488L,124488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189821Inst : IEnumerable<long>
{
public static readonly long[] Value=A189821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189821.Bytes);
public long this[int i]=>Value[i];

public static A189821Inst Instance=new A189821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189822
{
public static readonly long[] Value={ 3L,6L,7L,8L,9L,12L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,30L,33L,34L,35L,36L,39L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189822Inst : IEnumerable<long>
{
public static readonly long[] Value=A189822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189822.Bytes);
public long this[int i]=>Value[i];

public static A189822Inst Instance=new A189822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189823
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,1L,1L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,1L,9L,2L,0L,2L,1L,2L,2L,2L,4L,2L,5L,2L,6L,2L,7L,2L,8L,2L,9L,3L,0L,3L,2L,3L,3L,3L,5L,3L,6L,3L,7L,3L,8L,3L,9L,4L,0L,4L,3L,4L,4L,4L,6L,4L,7L,4L,8L,4L,9L,5L,0L,5L,4L,5L,5L,5L,7L,5L,8L,5L,9L,6L,0L,6L,5L,6L,6L,6L,8L,6L,9L,7L,0L,7L,6L,7L,7L,7L,9L,8L,0L,8L,7L,8L,8L,9L,0L,9L,9L,1L,0L,0L,1L,0L,2L,1L,0L,3L,1L,0L,4L,1L,0L,5L,1L,0L,6L,1L,0L,7L,1L,0L,8L,1L,0L,9L,1L,1L,0L,1L,1L,2L,1L,1L,4L,1L,1L,5L,1L,1L,6L,1L,1L,7L,1L,1L,8L,1L,1L,9L,1L,2L,0L,1L,2L,4L,1L,2L,5L,1L,2L,6L,1L,2L,7L,1L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189823Inst : IEnumerable<long>
{
public static readonly long[] Value=A189823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189823.Bytes);
public long this[int i]=>Value[i];

public static A189823Inst Instance=new A189823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189824
{
public static readonly long[] Value={ 2L,5L,1L,1L,8L,8L,6L,4L,3L,1L,5L,0L,9L,5L,8L,0L,1L,1L,1L,0L,8L,5L,0L,3L,2L,0L,6L,7L,7L,9L,9L,3L,2L,7L,3L,9L,4L,1L,5L,8L,5L,1L,8L,1L,0L,0L,7L,8L,2L,4L,7L,5L,4L,2L,8L,6L,7L,9L,8L,8L,8L,4L,2L,0L,9L,0L,8L,2L,4L,3L,2L,4L,7L,7L,2L,3L,5L,6L,1L,3L,0L,8L,4L,5L,3L,8L,5L,1L,0L,0L,8L,8L,7L,7L,7L,9L,6L,9L,5L,9L,1L,9L,1L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189824Inst : IEnumerable<long>
{
public static readonly long[] Value=A189824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189824.Bytes);
public long this[int i]=>Value[i];

public static A189824Inst Instance=new A189824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189825
{
public static readonly long[] Value={ 2L,4L,3L,14L,5L,7L,15L,11L,17L,19L,35L,29L,65L,41L,101L,79L,143L,71L,197L,161L,323L,169L,2917L,181L,577L,239L,575L,629L,899L,419L,1297L,701L,901L,721L,25599L,881L,5183L,1121L,9215L,2351L,4901L,1079L,107585L,1681L,36863L,2159L,3601L,2881L,11663L,2519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189825Inst : IEnumerable<long>
{
public static readonly long[] Value=A189825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189825.Bytes);
public long this[int i]=>Value[i];

public static A189825Inst Instance=new A189825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189826
{
public static readonly long[] Value={ 2L,7L,40L,199L,856L,3359L,12440L,44335L,153808L,523159L,1752928L,5804759L,19041608L,61981807L,200458504L,644783071L,2064276256L,6581953703L,20911793168L,66230028871L,209167217752L,658918365247L,2070973772920L,6495510239759L,20334154874096L,63545035094839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189826Inst : IEnumerable<long>
{
public static readonly long[] Value=A189826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189826.Bytes);
public long this[int i]=>Value[i];

public static A189826Inst Instance=new A189826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189827
{
public static readonly long[] Value={ 3L,5L,4L,7L,4L,8L,5L,8L,5L,10L,4L,10L,6L,9L,6L,11L,4L,12L,6L,10L,6L,12L,5L,12L,7L,10L,6L,14L,4L,14L,6L,10L,8L,13L,6L,13L,6L,12L,6L,16L,4L,14L,8L,10L,8L,14L,5L,16L,7L,12L,6L,14L,6L,16L,8L,12L,6L,16L,4L,16L,8L,11L,10L,15L,6L,14L,6L,14L,6L,20L,4L,16L,8L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189827Inst : IEnumerable<long>
{
public static readonly long[] Value=A189827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189827.Bytes);
public long this[int i]=>Value[i];

public static A189827Inst Instance=new A189827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189828
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,29L,41L,71L,161L,169L,181L,239L,419L,701L,721L,881L,1079L,1681L,2159L,2519L,2521L,4031L,4159L,5039L,7561L,8399L,10081L,13441L,13859L,18721L,20161L,22679L,25199L,27719L,27721L,35281L,45361L,50399L,50401L,55439L,65519L,110879L,138599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189828Inst : IEnumerable<long>
{
public static readonly long[] Value=A189828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189828.Bytes);
public long this[int i]=>Value[i];

public static A189828Inst Instance=new A189828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189829
{
public static readonly long[] Value={ 3L,5L,7L,8L,10L,11L,12L,14L,16L,20L,22L,24L,26L,28L,32L,34L,36L,38L,44L,46L,48L,52L,56L,58L,60L,68L,72L,76L,78L,80L,84L,88L,92L,96L,98L,100L,104L,106L,108L,116L,124L,128L,136L,148L,156L,160L,168L,172L,174L,176L,184L,196L,200L,208L,224L,236L,248L,260L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189829Inst : IEnumerable<long>
{
public static readonly long[] Value=A189829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189829.Bytes);
public long this[int i]=>Value[i];

public static A189829Inst Instance=new A189829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189830
{
public static readonly long[] Value={ 464L,21L,3313L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189830Inst : IEnumerable<long>
{
public static readonly long[] Value=A189830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189830.Bytes);
public long this[int i]=>Value[i];

public static A189830Inst Instance=new A189830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189831
{
public static readonly BigInteger[] Value={ 0L,0L,0L,4L,85L,1707L,37457L,921896L,25477371L,786163135L,26890701739L,1012165431744L,41638805754078L,1860589088529164L,89802422444553825L,4658465562594667088L,BigInteger.Parse("258566755450911870007"),BigInteger.Parse("15294477441385413149679"),BigInteger.Parse("960641026388207044487891"),BigInteger.Parse("63861339527473864490450300") };
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
public class A189831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189831Inst Instance=new A189831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189832
{
public static readonly long[] Value={ 1L,0L,2L,4L,11L,30L,83L,232L,655L,1860L,5312L,15236L,43863L,126672L,366802L,1064624L,3096347L,9021696L,26328470L,76946524L,225172981L,659711646L,1934891191L,5680457960L,16691655761L,49087826580L,144470474228L,425491536172L,1253971031195L,3697850012310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189832Inst : IEnumerable<long>
{
public static readonly long[] Value=A189832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189832.Bytes);
public long this[int i]=>Value[i];

public static A189832Inst Instance=new A189832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189833
{
public static readonly long[] Value={ 8L,9L,12L,17L,24L,33L,44L,57L,72L,89L,108L,129L,152L,177L,204L,233L,264L,297L,332L,369L,408L,449L,492L,537L,584L,633L,684L,737L,792L,849L,908L,969L,1032L,1097L,1164L,1233L,1304L,1377L,1452L,1529L,1608L,1689L,1772L,1857L,1944L,2033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189833Inst : IEnumerable<long>
{
public static readonly long[] Value=A189833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189833.Bytes);
public long this[int i]=>Value[i];

public static A189833Inst Instance=new A189833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189834
{
public static readonly long[] Value={ 9L,10L,13L,18L,25L,34L,45L,58L,73L,90L,109L,130L,153L,178L,205L,234L,265L,298L,333L,370L,409L,450L,493L,538L,585L,634L,685L,738L,793L,850L,909L,970L,1033L,1098L,1165L,1234L,1305L,1378L,1453L,1530L,1609L,1690L,1773L,1858L,1945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189834Inst : IEnumerable<long>
{
public static readonly long[] Value=A189834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189834.Bytes);
public long this[int i]=>Value[i];

public static A189834Inst Instance=new A189834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189835
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,26L,36L,53L,64L,90L,100L,138L,144L,194L,200L,261L,256L,347L,324L,426L,416L,522L,484L,658L,576L,746L,712L,882L,784L,1060L,900L,1173L,1088L,1314L,1160L,1587L,1296L,1658L,1544L,1890L,1600L,2164L,1764L,2298L,2096L,2466L,2116L,2930L,2304L,2955L,2696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189835Inst : IEnumerable<long>
{
public static readonly long[] Value=A189835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189835.Bytes);
public long this[int i]=>Value[i];

public static A189835Inst Instance=new A189835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190124
{
public static readonly long[] Value={ 2L,6L,5L,5L,6L,3L,2L,7L,5L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190124Inst : IEnumerable<long>
{
public static readonly long[] Value=A190124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190124.Bytes);
public long this[int i]=>Value[i];

public static A190124Inst Instance=new A190124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190125
{
public static readonly BigInteger[] Value={ 1L,4L,27L,256L,3125L,108L,823543L,16777216L,387420489L,12500L,285311670611L,6912L,302875106592253L,3294172L,84375L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("827240261886336764177"),1549681956L,BigInteger.Parse("1978419655660313589123979"),800000L,22235661L,1141246682444L };
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
public class A190125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190125Inst Instance=new A190125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190126
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,8193L,4097L,8194L,8195L,2049L,4098L,8196L,8197L,4099L,8198L,8199L,1025L,2050L,4100L,8200L,8201L,4101L,8202L,8203L,2051L,4102L,8204L,8205L,4103L,8206L,8207L,513L,1026L,2052L,4104L,8208L,8209L,4105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190126Inst : IEnumerable<long>
{
public static readonly long[] Value=A190126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190126.Bytes);
public long this[int i]=>Value[i];

public static A190126Inst Instance=new A190126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190127
{
public static readonly long[] Value={ 1L,2L,5906L,3L,3859L,5907L,7954L,4L,2051L,3860L,4883L,5908L,6931L,7955L,8978L,5L,1028L,2052L,3075L,3861L,4372L,4884L,5395L,5909L,6420L,6932L,7443L,7956L,8467L,8979L,9490L,6L,517L,1029L,1540L,2053L,2564L,3076L,3587L,3862L,4117L,4373L,4628L,4885L,5140L,5396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190127Inst : IEnumerable<long>
{
public static readonly long[] Value=A190127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190127.Bytes);
public long this[int i]=>Value[i];

public static A190127Inst Instance=new A190127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190128
{
public static readonly long[] Value={ 1L,3L,9L,27L,81L,243L,729L,2187L,6561L,6562L,6563L,2188L,6564L,6565L,6566L,2189L,6567L,6568L,6569L,730L,2190L,6570L,6571L,6572L,2191L,6573L,6574L,6575L,2192L,6576L,6577L,6578L,731L,2193L,6579L,6580L,6581L,2194L,6582L,6583L,6584L,2195L,6585L,6586L,6587L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190128Inst : IEnumerable<long>
{
public static readonly long[] Value=A190128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190128.Bytes);
public long this[int i]=>Value[i];

public static A190128Inst Instance=new A190128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190129
{
public static readonly long[] Value={ 1L,6721L,2L,3282L,5628L,6722L,7815L,8908L,3L,1096L,2189L,3283L,4376L,5264L,5629L,5993L,6357L,6723L,7087L,7451L,7816L,8180L,8544L,8909L,9273L,9637L,4L,368L,732L,1097L,1461L,1825L,2190L,2554L,2918L,3284L,3648L,4012L,4377L,4741L,5105L,5265L,5386L,5507L,5630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190129Inst : IEnumerable<long>
{
public static readonly long[] Value=A190129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190129.Bytes);
public long this[int i]=>Value[i];

public static A190129Inst Instance=new A190129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190130
{
public static readonly long[] Value={ 1L,8L,64L,512L,4096L,4097L,4098L,4099L,4100L,4101L,4102L,4103L,513L,4104L,4105L,4106L,4107L,4108L,4109L,4110L,4111L,514L,4112L,4113L,4114L,4115L,4116L,4117L,4118L,4119L,515L,4120L,4121L,4122L,4123L,4124L,4125L,4126L,4127L,516L,4128L,4129L,4130L,4131L,4132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190130Inst : IEnumerable<long>
{
public static readonly long[] Value=A190130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190130.Bytes);
public long this[int i]=>Value[i];

public static A190130Inst Instance=new A190130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190131
{
public static readonly long[] Value={ 1L,4682L,7076L,7661L,8246L,8831L,9416L,2L,587L,1172L,1757L,2342L,2927L,3512L,4097L,4683L,5268L,5853L,6438L,6784L,6857L,6930L,7003L,7077L,7150L,7223L,7296L,7369L,7442L,7515L,7588L,7662L,7735L,7808L,7881L,7954L,8027L,8100L,8173L,8247L,8320L,8393L,8466L,8539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190131Inst : IEnumerable<long>
{
public static readonly long[] Value=A190131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190131.Bytes);
public long this[int i]=>Value[i];

public static A190131Inst Instance=new A190131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190132
{
public static readonly long[] Value={ 1L,12L,144L,1728L,1729L,1730L,1731L,1732L,1733L,1734L,1735L,1736L,1737L,1738L,1739L,145L,1740L,1741L,1742L,1743L,1744L,1745L,1746L,1747L,1748L,1749L,1750L,1751L,146L,1752L,1753L,1754L,1755L,1756L,1757L,1758L,1759L,1760L,1761L,1762L,1763L,147L,1764L,1765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190132Inst : IEnumerable<long>
{
public static readonly long[] Value=A190132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190132.Bytes);
public long this[int i]=>Value[i];

public static A190132Inst Instance=new A190132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190133
{
public static readonly long[] Value={ 1L,1886L,3771L,5656L,7541L,9059L,9216L,9373L,9530L,9687L,9844L,2L,159L,316L,473L,630L,787L,944L,1101L,1258L,1415L,1572L,1729L,1887L,2044L,2201L,2358L,2515L,2672L,2829L,2986L,3143L,3300L,3457L,3614L,3772L,3929L,4086L,4243L,4400L,4557L,4714L,4871L,5028L,5185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190133Inst : IEnumerable<long>
{
public static readonly long[] Value=A190133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190133.Bytes);
public long this[int i]=>Value[i];

public static A190133Inst Instance=new A190133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190134
{
public static readonly long[] Value={ 1L,16L,256L,4096L,4097L,4098L,4099L,4100L,4101L,4102L,4103L,4104L,4105L,4106L,4107L,4108L,4109L,4110L,4111L,257L,4112L,4113L,4114L,4115L,4116L,4117L,4118L,4119L,4120L,4121L,4122L,4123L,4124L,4125L,4126L,4127L,258L,4128L,4129L,4130L,4131L,4132L,4133L,4134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190134Inst : IEnumerable<long>
{
public static readonly long[] Value=A190134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190134.Bytes);
public long this[int i]=>Value[i];

public static A190134Inst Instance=new A190134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190135
{
public static readonly long[] Value={ 1L,4370L,6452L,6725L,6998L,7271L,7544L,7817L,8090L,8363L,8636L,8909L,9182L,9455L,9728L,2L,275L,548L,821L,1094L,1367L,1640L,1913L,2186L,2459L,2732L,3005L,3278L,3551L,3824L,4097L,4371L,4644L,4917L,5190L,5463L,5736L,6009L,6282L,6316L,6333L,6350L,6367L,6384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190135Inst : IEnumerable<long>
{
public static readonly long[] Value=A190135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190135.Bytes);
public long this[int i]=>Value[i];

public static A190135Inst Instance=new A190135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190136
{
public static readonly long[] Value={ 3L,5L,5L,7L,7L,7L,7L,11L,11L,13L,13L,13L,13L,17L,17L,19L,19L,19L,19L,23L,23L,23L,23L,13L,13L,29L,29L,31L,31L,31L,31L,17L,17L,37L,37L,37L,37L,41L,41L,43L,43L,43L,43L,47L,47L,47L,47L,17L,17L,53L,53L,53L,53L,19L,29L,59L,59L,61L,61L,61L,61L,31L,13L,67L,67L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190136Inst : IEnumerable<long>
{
public static readonly long[] Value=A190136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190136.Bytes);
public long this[int i]=>Value[i];

public static A190136Inst Instance=new A190136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190137
{
public static readonly long[] Value={ 1L,5L,4L,3L,2L,2L,3L,4L,5L,1L,1L,9L,8L,8L,7L,7L,6L,7L,6L,5L,5L,5L,5L,5L,4L,4L,5L,4L,5L,4L,4L,7L,4L,3L,4L,4L,3L,7L,6L,3L,3L,5L,5L,3L,5L,5L,5L,5L,5L,2L,2L,6L,4L,6L,2L,2L,6L,4L,6L,2L,2L,5L,5L,5L,5L,5L,3L,5L,5L,3L,3L,6L,7L,3L,4L,4L,3L,4L,7L,4L,4L,5L,4L,5L,4L,4L,5L,5L,5L,5L,5L,6L,7L,6L,7L,7L,8L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190137Inst : IEnumerable<long>
{
public static readonly long[] Value=A190137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190137.Bytes);
public long this[int i]=>Value[i];

public static A190137Inst Instance=new A190137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190138
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,15L,27L,46L,80L,138L,238L,413L,713L,1235L,2136L,3695L,6393L,11057L,19130L,33091L,57246L,99032L,171315L,296365L,512682L,886902L,1534266L,2654154L,4591475L,7942870L,13740526L,23769981L,41120131L,71134474L,123056829L,212878289L,368262059L,637063333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190138Inst : IEnumerable<long>
{
public static readonly long[] Value=A190138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190138.Bytes);
public long this[int i]=>Value[i];

public static A190138Inst Instance=new A190138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190139
{
public static readonly long[] Value={ 1L,1L,3L,8L,21L,54L,140L,363L,941L,2439L,6322L,16387L,42476L,110100L,285385L,739733L,1917427L,4970072L,12882689L,33392610L,86555408L,224356187L,581543081L,1507390367L,3907235410L,10127760455L,26251689768L,68045765768L,176378217169L,457181650329L,1185038973363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190139Inst : IEnumerable<long>
{
public static readonly long[] Value=A190139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190139.Bytes);
public long this[int i]=>Value[i];

public static A190139Inst Instance=new A190139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190204
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190204Inst : IEnumerable<long>
{
public static readonly long[] Value=A190204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190204.Bytes);
public long this[int i]=>Value[i];

public static A190204Inst Instance=new A190204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190205
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,10L,15L,16L,18L,23L,25L,27L,29L,30L,32L,36L,37L,38L,43L,45L,47L,49L,50L,52L,54L,57L,58L,59L,64L,65L,67L,69L,72L,74L,76L,78L,79L,81L,85L,86L,87L,89L,92L,94L,96L,98L,99L,101L,103L,106L,107L,108L,113L,114L,116L,118L,121L,123L,125L,127L,128L,130L,134L,135L,136L,138L,141L,143L,145L,147L,148L,150L,152L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190205Inst : IEnumerable<long>
{
public static readonly long[] Value=A190205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190205.Bytes);
public long this[int i]=>Value[i];

public static A190205Inst Instance=new A190205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190206
{
public static readonly long[] Value={ 2L,4L,6L,7L,11L,12L,13L,14L,17L,19L,20L,21L,22L,24L,26L,28L,31L,33L,34L,35L,39L,40L,41L,42L,44L,46L,48L,51L,53L,55L,56L,60L,61L,62L,63L,66L,68L,70L,71L,73L,75L,77L,80L,82L,83L,84L,88L,90L,91L,93L,95L,97L,100L,102L,104L,105L,109L,110L,111L,112L,115L,117L,119L,120L,122L,124L,126L,129L,131L,132L,133L,137L,139L,140L,142L,144L,146L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190206Inst : IEnumerable<long>
{
public static readonly long[] Value=A190206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190206.Bytes);
public long this[int i]=>Value[i];

public static A190206Inst Instance=new A190206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190207
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190207Inst : IEnumerable<long>
{
public static readonly long[] Value=A190207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190207.Bytes);
public long this[int i]=>Value[i];

public static A190207Inst Instance=new A190207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190208
{
public static readonly long[] Value={ 8L,11L,14L,16L,19L,22L,24L,25L,27L,28L,30L,31L,32L,33L,35L,36L,38L,39L,40L,41L,42L,45L,53L,56L,59L,61L,62L,64L,67L,69L,70L,72L,73L,75L,76L,77L,78L,79L,80L,81L,83L,84L,90L,93L,98L,101L,104L,106L,107L,109L,110L,112L,114L,115L,117L,118L,120L,121L,122L,123L,124L,125L,126L,127L,135L,138L,141L,143L,146L,149L,151L,152L,154L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190208Inst : IEnumerable<long>
{
public static readonly long[] Value=A190208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190208.Bytes);
public long this[int i]=>Value[i];

public static A190208Inst Instance=new A190208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190209
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,15L,17L,18L,20L,21L,23L,26L,29L,34L,37L,43L,44L,46L,47L,48L,49L,50L,51L,52L,54L,55L,57L,58L,60L,63L,65L,66L,68L,71L,74L,82L,85L,86L,87L,88L,89L,91L,92L,94L,95L,96L,97L,99L,100L,102L,103L,105L,108L,111L,113L,116L,119L,128L,129L,130L,131L,132L,133L,134L,136L,137L,139L,140L,142L,144L,145L,147L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190209Inst : IEnumerable<long>
{
public static readonly long[] Value=A190209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190209.Bytes);
public long this[int i]=>Value[i];

public static A190209Inst Instance=new A190209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190210
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190210Inst : IEnumerable<long>
{
public static readonly long[] Value=A190210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190210.Bytes);
public long this[int i]=>Value[i];

public static A190210Inst Instance=new A190210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190211
{
public static readonly long[] Value={ 3L,4L,5L,9L,10L,15L,16L,17L,20L,21L,23L,26L,27L,29L,32L,34L,37L,38L,40L,43L,46L,49L,51L,52L,54L,57L,58L,60L,63L,64L,68L,69L,71L,74L,75L,80L,81L,85L,86L,87L,91L,92L,93L,97L,98L,99L,102L,103L,104L,108L,109L,114L,115L,116L,119L,120L,122L,125L,126L,128L,131L,133L,134L,136L,137L,139L,142L,145L,148L,150L,151L,153L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190211Inst : IEnumerable<long>
{
public static readonly long[] Value=A190211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190211.Bytes);
public long this[int i]=>Value[i];

public static A190211Inst Instance=new A190211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190212
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,11L,12L,13L,14L,18L,19L,22L,24L,25L,28L,30L,31L,33L,35L,36L,39L,41L,42L,44L,45L,47L,48L,50L,53L,55L,56L,59L,61L,62L,65L,66L,67L,70L,72L,73L,76L,77L,78L,79L,82L,83L,84L,88L,89L,90L,94L,95L,96L,100L,101L,105L,106L,107L,110L,111L,112L,113L,117L,118L,121L,123L,124L,127L,129L,130L,132L,135L,138L,140L,141L,143L,144L,146L,147L,149L,152L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190212Inst : IEnumerable<long>
{
public static readonly long[] Value=A190212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190212.Bytes);
public long this[int i]=>Value[i];

public static A190212Inst Instance=new A190212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190213
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,13L,17L,19L,31L,61L,89L,107L,127L,521L,607L,1279L,2203L,2281L,3217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190213Inst : IEnumerable<long>
{
public static readonly long[] Value=A190213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190213.Bytes);
public long this[int i]=>Value[i];

public static A190213Inst Instance=new A190213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190214
{
public static readonly long[] Value={ 1L,1L,4L,13L,41L,127L,395L,1232L,3842L,11977L,37336L,116392L,362846L,1131150L,3526285L,10992961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190214Inst : IEnumerable<long>
{
public static readonly long[] Value=A190214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190214.Bytes);
public long this[int i]=>Value[i];

public static A190214Inst Instance=new A190214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190215
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,5L,3L,1L,12L,14L,9L,4L,1L,29L,38L,28L,14L,5L,1L,70L,102L,84L,48L,20L,6L,1L,169L,271L,246L,157L,75L,27L,7L,1L,408L,714L,707L,496L,265L,110L,35L,8L,1L,985L,1868L,2001L,1526L,896L,417L,154L,44L,9L,1L,2378L,4858L,5592L,4596L,2930L,1500L,623L,208L,54L,10L,1L,5741L,12569L,15461L,13602L,9330L,5186L,2373L,894L,273L,65L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190215Inst : IEnumerable<long>
{
public static readonly long[] Value=A190215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190215.Bytes);
public long this[int i]=>Value[i];

public static A190215Inst Instance=new A190215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190216
{
public static readonly long[] Value={ 12L,80L,70L,21L,50L,40L,30L,20L,10L,171L,152L,133L,114L,207L,216L,132L,234L,243L,150L,224L,270L,408L,140L,112L,306L,315L,324L,204L,342L,351L,102L,644L,918L,111L,506L,405L,120L,423L,322L,441L,230L,715L,660L,605L,550L,312L,440L,513L,330L,531L,220L,0L,110L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190216Inst : IEnumerable<long>
{
public static readonly long[] Value=A190216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190216.Bytes);
public long this[int i]=>Value[i];

public static A190216Inst Instance=new A190216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190217
{
public static readonly ulong[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,1111111111111111111L,2222222222222222222L,3333333333333333333L,4444444444444444444L,5555555555555555555L,6666666666666666666L,7777777777777777777L,8888888888888888888L,9999999999999999999UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190217Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A190217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190217.Bytes);
public ulong this[int i]=>Value[i];

public static A190217Inst Instance=new A190217Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190218
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,17L,18L,19L,23L,24L,25L,26L,27L,28L,29L,34L,35L,36L,37L,38L,39L,45L,46L,47L,48L,49L,56L,57L,58L,59L,67L,68L,69L,78L,79L,89L,125L,127L,134L,135L,136L,137L,138L,139L,145L,149L,157L,158L,167L,169L,178L,179L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190218Inst : IEnumerable<long>
{
public static readonly long[] Value=A190218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190218.Bytes);
public long this[int i]=>Value[i];

public static A190218Inst Instance=new A190218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190219
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,21L,31L,40L,41L,43L,53L,61L,62L,63L,71L,73L,82L,83L,86L,93L,97L,421L,431L,521L,541L,631L,641L,643L,653L,743L,751L,761L,821L,842L,853L,862L,863L,941L,953L,961L,971L,983L,5431L,6421L,6521L,7321L,7541L,7621L,7643L,8431L,8521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190219Inst : IEnumerable<long>
{
public static readonly long[] Value=A190219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190219.Bytes);
public long this[int i]=>Value[i];

public static A190219Inst Instance=new A190219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190284
{
public static readonly long[] Value={ 2L,1L,1L,4L,6L,1L,2L,2L,2L,1L,1L,6L,1L,179L,46L,1L,1L,3L,2L,1L,1L,3L,6L,3L,1L,1L,1L,1L,2L,1L,1L,56L,1L,1L,1L,1L,66L,1L,1L,2L,17L,8L,2L,7L,12L,1L,1L,8L,1L,2L,2L,1L,1L,2L,1L,12L,1L,2L,2L,2L,2L,1L,1L,1L,8L,1L,1L,1L,1L,2L,1L,2L,5L,1L,6L,8L,1L,1L,1L,2L,7L,1L,9L,1L,2L,5L,7L,1L,6L,1L,10L,1L,2L,1L,3L,47L,1L,1L,998L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190284Inst : IEnumerable<long>
{
public static readonly long[] Value=A190284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190284.Bytes);
public long this[int i]=>Value[i];

public static A190284Inst Instance=new A190284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190285
{
public static readonly long[] Value={ 3L,4L,9L,5L,5L,0L,7L,6L,5L,6L,6L,0L,4L,9L,2L,4L,5L,0L,3L,7L,7L,2L,8L,6L,6L,6L,7L,9L,0L,5L,4L,4L,8L,1L,0L,0L,5L,1L,8L,8L,6L,1L,0L,8L,8L,4L,0L,4L,7L,7L,3L,2L,4L,5L,3L,1L,4L,2L,1L,1L,4L,5L,0L,6L,9L,7L,2L,1L,5L,2L,8L,1L,4L,6L,2L,1L,9L,5L,7L,6L,9L,3L,6L,8L,9L,3L,0L,5L,8L,5L,3L,9L,9L,3L,9L,4L,4L,9L,0L,9L,1L,2L,9L,6L,6L,7L,2L,8L,9L,9L,6L,0L,0L,8L,6L,3L,6L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190285Inst : IEnumerable<long>
{
public static readonly long[] Value=A190285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190285.Bytes);
public long this[int i]=>Value[i];

public static A190285Inst Instance=new A190285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190286
{
public static readonly long[] Value={ 3L,2L,55L,6L,1L,1L,1L,9L,1L,1L,1L,7L,2L,2L,1L,4L,2L,6L,1L,27L,1L,10L,5L,1L,1L,2L,2L,3L,6L,6L,1L,9L,1L,1L,5L,1L,2L,3L,94L,1L,13L,18L,7L,1L,1L,1L,4L,1L,20L,1L,2L,7L,11L,1L,26251L,1L,43L,1L,1L,5L,1L,1L,1L,1L,5L,1L,47L,1L,1L,2L,12L,6L,3L,4L,6L,7L,5L,1L,1L,1L,1L,1L,4L,6L,23L,3L,2L,1L,1L,2L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190286Inst : IEnumerable<long>
{
public static readonly long[] Value=A190286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190286.Bytes);
public long this[int i]=>Value[i];

public static A190286Inst Instance=new A190286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190287
{
public static readonly long[] Value={ 5L,4L,1L,3L,0L,8L,5L,6L,4L,5L,4L,1L,1L,0L,2L,8L,7L,1L,0L,2L,8L,7L,0L,6L,5L,5L,6L,7L,5L,5L,7L,4L,9L,4L,1L,3L,5L,3L,1L,5L,9L,3L,2L,7L,3L,6L,5L,0L,4L,1L,2L,5L,8L,4L,1L,5L,5L,0L,5L,1L,3L,3L,7L,5L,9L,2L,2L,6L,7L,7L,4L,4L,9L,2L,3L,3L,0L,9L,7L,1L,9L,2L,2L,5L,1L,8L,4L,8L,8L,1L,5L,1L,0L,0L,2L,8L,8L,0L,8L,8L,7L,4L,0L,9L,0L,0L,2L,2L,3L,2L,0L,9L,6L,8L,1L,4L,0L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190287Inst : IEnumerable<long>
{
public static readonly long[] Value=A190287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190287.Bytes);
public long this[int i]=>Value[i];

public static A190287Inst Instance=new A190287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190288
{
public static readonly long[] Value={ 5L,2L,2L,2L,1L,1L,1L,10L,1L,1L,2L,1L,2L,1L,7L,1L,1L,1L,3L,1L,3L,1L,1L,2L,11L,22L,1L,1L,3L,3L,7L,1L,1L,1L,5L,1L,181L,1L,2L,2L,1L,2L,3L,17L,83L,1L,3L,2L,1L,14L,3L,1L,44L,3L,6L,4L,4L,1L,28L,1L,1L,1L,2L,1L,2L,1L,15L,1L,55L,1L,1L,3L,16L,3L,2L,1L,1L,1L,2L,1L,1L,2L,8L,4L,1L,1L,1L,1L,1L,1L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190288Inst : IEnumerable<long>
{
public static readonly long[] Value=A190288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190288.Bytes);
public long this[int i]=>Value[i];

public static A190288Inst Instance=new A190288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190289
{
public static readonly long[] Value={ 1L,8L,9L,5L,6L,4L,3L,9L,2L,3L,7L,3L,8L,9L,6L,0L,0L,0L,1L,6L,4L,7L,0L,1L,1L,7L,9L,8L,4L,3L,2L,0L,0L,2L,1L,2L,2L,2L,4L,6L,1L,1L,4L,1L,4L,4L,1L,9L,1L,9L,9L,2L,9L,7L,5L,6L,5L,1L,8L,1L,0L,5L,3L,0L,9L,7L,6L,7L,1L,7L,1L,0L,6L,3L,8L,6L,9L,4L,2L,7L,2L,1L,6L,5L,1L,0L,9L,0L,3L,8L,9L,8L,7L,3L,3L,6L,1L,2L,5L,8L,1L,6L,9L,4L,0L,0L,2L,2L,6L,3L,4L,9L,3L,9L,6L,4L,3L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190289Inst : IEnumerable<long>
{
public static readonly long[] Value=A190289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190289.Bytes);
public long this[int i]=>Value[i];

public static A190289Inst Instance=new A190289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190290
{
public static readonly long[] Value={ 2L,5L,2L,7L,5L,2L,5L,2L,3L,1L,6L,5L,1L,9L,4L,6L,6L,6L,8L,8L,6L,2L,6L,8L,2L,3L,9L,7L,9L,0L,9L,3L,3L,6L,1L,6L,2L,9L,9L,4L,8L,1L,8L,8L,5L,8L,9L,2L,2L,6L,5L,7L,3L,0L,0L,8L,6L,9L,0L,8L,0L,7L,0L,7L,9L,6L,8L,9L,5L,6L,1L,4L,1L,8L,4L,9L,2L,5L,6L,9L,6L,2L,2L,0L,1L,4L,5L,3L,8L,5L,3L,1L,6L,4L,4L,8L,1L,6L,7L,7L,5L,5L,9L,2L,0L,0L,3L,0L,1L,7L,9L,9L,1L,9L,5L,2L,4L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190290Inst : IEnumerable<long>
{
public static readonly long[] Value=A190290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190290.Bytes);
public long this[int i]=>Value[i];

public static A190290Inst Instance=new A190290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190291
{
public static readonly long[] Value={ 1L,3L,16L,124L,1262L,15898L,238572L,4152172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190291Inst : IEnumerable<long>
{
public static readonly long[] Value=A190291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190291.Bytes);
public long this[int i]=>Value[i];

public static A190291Inst Instance=new A190291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190292
{
public static readonly long[] Value={ 6720L,10560L,12480L,14784L,16320L,17472L,18240L,22080L,22848L,24640L,25536L,27456L,27840L,29120L,29760L,30912L,35520L,35904L,38080L,38976L,39360L,40128L,41280L,41664L,42432L,42560L,45120L,45760L,47424L,48576L,49728L,50880L,51030L,51520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190292Inst : IEnumerable<long>
{
public static readonly long[] Value=A190292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190292.Bytes);
public long this[int i]=>Value[i];

public static A190292Inst Instance=new A190292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190293
{
public static readonly long[] Value={ 10080L,15840L,16800L,18720L,22176L,23520L,24480L,26208L,26400L,27360L,31200L,33120L,34020L,34272L,38304L,40800L,41184L,41760L,44640L,45600L,46368L,51744L,53280L,53460L,53856L,55200L,58080L,58464L,59040L,60192L,61152L,61600L,61920L,62496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190293Inst : IEnumerable<long>
{
public static readonly long[] Value=A190293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190293.Bytes);
public long this[int i]=>Value[i];

public static A190293Inst Instance=new A190293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190294
{
public static readonly long[] Value={ 15120L,22680L,23760L,28080L,33264L,35640L,36720L,39312L,41040L,42000L,42120L,49680L,49896L,51408L,55080L,57456L,58968L,61560L,61776L,62640L,66000L,66960L,69552L,74520L,77112L,78000L,79920L,80784L,82320L,86184L,87696L,88560L,90288L,92664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190294Inst : IEnumerable<long>
{
public static readonly long[] Value=A190294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190294.Bytes);
public long this[int i]=>Value[i];

public static A190294Inst Instance=new A190294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190295
{
public static readonly long[] Value={ 1L,2L,2L,12L,12L,3L,108L,108L,36L,4L,1280L,1280L,480L,80L,5L,18750L,18750L,7500L,1500L,150L,6L,326592L,326592L,136080L,30240L,3780L,252L,7L,6588344L,6588344L,2823576L,672280L,96040L,8232L,392L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190295Inst : IEnumerable<long>
{
public static readonly long[] Value=A190295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190295.Bytes);
public long this[int i]=>Value[i];

public static A190295Inst Instance=new A190295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190296
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,15L,20L,22L,24L,33L,40L,42L,44L,48L,51L,55L,60L,66L,77L,80L,84L,88L,99L,102L,108L,111L,114L,117L,120L,126L,132L,135L,144L,150L,153L,156L,162L,171L,180L,192L,195L,198L,201L,204L,207L,210L,216L,222L,225L,228L,234L,240L,243L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190296Inst : IEnumerable<long>
{
public static readonly long[] Value=A190296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190296.Bytes);
public long this[int i]=>Value[i];

public static A190296Inst Instance=new A190296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190297
{
public static readonly long[] Value={ 1L,12L,57L,245L,1005L,4063L,16327L,65435L,261965L,1048259L,4193742L,16776218L,67107091L,268432305L,1073736223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190297Inst : IEnumerable<long>
{
public static readonly long[] Value=A190297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190297.Bytes);
public long this[int i]=>Value[i];

public static A190297Inst Instance=new A190297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190298
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,16L,17L,18L,19L,27L,28L,29L,38L,39L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190298Inst : IEnumerable<long>
{
public static readonly long[] Value=A190298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190298.Bytes);
public long this[int i]=>Value[i];

public static A190298Inst Instance=new A190298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190299
{
public static readonly long[] Value={ 21L,33L,57L,65L,69L,77L,85L,93L,129L,133L,141L,145L,161L,177L,185L,201L,205L,209L,213L,217L,221L,237L,249L,253L,265L,301L,305L,309L,321L,329L,341L,365L,377L,381L,393L,413L,417L,437L,445L,453L,469L,473L,481L,485L,489L,493L,497L,501L,505L,517L,533L,537L,545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190299Inst : IEnumerable<long>
{
public static readonly long[] Value=A190299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190299.Bytes);
public long this[int i]=>Value[i];

public static A190299Inst Instance=new A190299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190364
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,18L,20L,24L,27L,31L,33L,36L,39L,43L,46L,49L,51L,56L,58L,62L,64L,67L,71L,74L,77L,80L,84L,87L,89L,93L,95L,100L,102L,105L,108L,112L,115L,118L,120L,124L,127L,131L,133L,136L,140L,143L,146L,149L,153L,156L,158L,162L,164L,169L,171L,174L,177L,181L,184L,187L,189L,193L,196L,200L,202L,205L,209L,212L,215L,218L,220L,225L,227L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190364Inst : IEnumerable<long>
{
public static readonly long[] Value=A190364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190364.Bytes);
public long this[int i]=>Value[i];

public static A190364Inst Instance=new A190364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190365
{
public static readonly long[] Value={ 5L,11L,18L,24L,31L,36L,43L,49L,56L,62L,67L,74L,80L,87L,93L,100L,105L,112L,118L,124L,131L,136L,143L,149L,156L,162L,169L,174L,181L,187L,193L,200L,205L,212L,218L,225L,231L,238L,243L,249L,256L,262L,269L,274L,281L,287L,294L,300L,307L,312L,318L,325L,331L,338L,343L,350L,356L,363L,369L,374L,381L,387L,394L,400L,407L,412L,419L,425L,432L,438L,443L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190365Inst : IEnumerable<long>
{
public static readonly long[] Value=A190365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190365.Bytes);
public long this[int i]=>Value[i];

public static A190365Inst Instance=new A190365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190366
{
public static readonly long[] Value={ 1L,3L,7L,9L,12L,14L,16L,19L,22L,25L,26L,29L,32L,34L,38L,40L,41L,45L,47L,50L,53L,54L,57L,60L,63L,65L,69L,70L,72L,76L,78L,81L,83L,85L,88L,91L,94L,96L,98L,101L,103L,107L,109L,110L,114L,116L,119L,122L,125L,126L,129L,132L,134L,138L,139L,141L,145L,147L,150L,152L,154L,157L,160L,163L,165L,167L,170L,172L,176L,178L,179L,183L,185L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190366Inst : IEnumerable<long>
{
public static readonly long[] Value=A190366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190366.Bytes);
public long this[int i]=>Value[i];

public static A190366Inst Instance=new A190366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190367
{
public static readonly long[] Value={ 7L,14L,22L,29L,38L,45L,53L,60L,69L,76L,83L,91L,98L,107L,114L,122L,129L,138L,145L,152L,160L,167L,176L,183L,191L,198L,207L,214L,222L,229L,236L,245L,252L,260L,267L,276L,283L,291L,298L,305L,314L,321L,329L,336L,345L,352L,360L,367L,376L,383L,390L,398L,405L,414L,421L,429L,436L,445L,452L,459L,467L,474L,483L,490L,498L,505L,514L,521L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190367Inst : IEnumerable<long>
{
public static readonly long[] Value=A190367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190367.Bytes);
public long this[int i]=>Value[i];

public static A190367Inst Instance=new A190367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190368
{
public static readonly long[] Value={ 3L,8L,12L,17L,21L,26L,30L,35L,39L,44L,48L,53L,57L,62L,66L,71L,75L,80L,84L,89L,93L,98L,103L,107L,112L,116L,121L,125L,129L,134L,139L,143L,148L,152L,157L,161L,165L,170L,175L,180L,184L,188L,193L,198L,201L,207L,211L,216L,220L,224L,229L,234L,237L,243L,246L,252L,256L,260L,266L,270L,274L,279L,283L,288L,293L,296L,302L,306L,310L,315L,319L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190368Inst : IEnumerable<long>
{
public static readonly long[] Value=A190368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190368.Bytes);
public long this[int i]=>Value[i];

public static A190368Inst Instance=new A190368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190369
{
public static readonly long[] Value={ 2L,5L,9L,11L,14L,19L,22L,25L,28L,31L,34L,38L,41L,45L,47L,51L,54L,58L,61L,64L,68L,70L,74L,78L,81L,83L,87L,90L,95L,97L,100L,104L,106L,109L,114L,117L,120L,123L,126L,131L,133L,137L,140L,142L,146L,150L,153L,156L,159L,163L,166L,169L,173L,176L,179L,182L,186L,190L,192L,195L,199L,202L,206L,209L,212L,215L,218L,221L,226L,228L,232L,235L,238L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190369Inst : IEnumerable<long>
{
public static readonly long[] Value=A190369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190369.Bytes);
public long this[int i]=>Value[i];

public static A190369Inst Instance=new A190369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190370
{
public static readonly long[] Value={ 1L,4L,6L,10L,13L,15L,18L,20L,23L,27L,29L,32L,36L,37L,40L,43L,46L,49L,52L,55L,56L,60L,63L,65L,69L,72L,73L,77L,79L,82L,86L,88L,91L,94L,96L,99L,102L,105L,108L,110L,113L,115L,118L,122L,124L,127L,130L,132L,135L,138L,141L,144L,147L,149L,151L,155L,158L,160L,164L,167L,168L,172L,174L,177L,181L,183L,185L,189L,191L,194L,197L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190370Inst : IEnumerable<long>
{
public static readonly long[] Value=A190370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190370.Bytes);
public long this[int i]=>Value[i];

public static A190370Inst Instance=new A190370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190371
{
public static readonly long[] Value={ 7L,16L,24L,33L,42L,50L,59L,67L,76L,85L,92L,101L,111L,119L,128L,136L,145L,154L,162L,171L,178L,187L,196L,204L,213L,223L,231L,240L,248L,257L,265L,273L,282L,291L,299L,308L,316L,325L,335L,343L,351L,359L,368L,377L,385L,394L,403L,411L,420L,428L,437L,446L,454L,463L,471L,480L,489L,497L,506L,515L,523L,531L,539L,548L,558L,566L,575L,584L,592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190371Inst : IEnumerable<long>
{
public static readonly long[] Value=A190371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190371.Bytes);
public long this[int i]=>Value[i];

public static A190371Inst Instance=new A190371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190372
{
public static readonly long[] Value={ 5L,13L,20L,28L,35L,42L,50L,57L,65L,71L,78L,86L,94L,101L,108L,115L,123L,131L,136L,144L,151L,159L,167L,173L,181L,189L,196L,204L,209L,217L,225L,232L,240L,247L,254L,262L,269L,275L,283L,290L,298L,305L,312L,320L,327L,335L,343L,348L,356L,363L,371L,379L,385L,393L,400L,408L,414L,421L,429L,437L,444L,451L,458L,466L,474L,481L,487L,495L,502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190372Inst : IEnumerable<long>
{
public static readonly long[] Value=A190372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190372.Bytes);
public long this[int i]=>Value[i];

public static A190372Inst Instance=new A190372Inst();

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